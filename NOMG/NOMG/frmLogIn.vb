Imports System.IO
Imports System.Text
Public Class frmLogIn
    Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
        frmStart.Show()
        Me.Hide()
    End Sub
    Private Sub ImportFileData(ByVal name As String)
        Try
            Dim filePath As String = name & ".txt"
            If Not File.Exists(filePath) Then
                MsgBox("No saved data found for this user.")
                Return
            End If

            Using reader As New StreamReader(filePath, Encoding.UTF8)
                Dim user As New frmAccountInformation.User()

                ' Read user details
                Dim userName = GetValue(reader.ReadLine())  ' Name
                Dim userAddress = GetValue(reader.ReadLine())  ' Address
                Dim userEmail = frmAccountInformation.currentUser.GetEmail() ' Use the email from the current user
                Dim userPass = frmAccountInformation.currentUser.GetPass()  ' Use the password from the current user
                Dim userAge = CInt(GetValue(reader.ReadLine()))  ' Age
                Dim userIsFirstBaby = GetValue(reader.ReadLine())  ' IsFirstBaby
                Dim userGestationalAge = CInt(GetValue(reader.ReadLine()))  ' GestationalAge
                Dim userLMCString = GetValue(reader.ReadLine())  ' Last Menstrual Cycle (LMC)

                ' Initialize LMC date with a default value
                Dim userLMC As Date = Date.MinValue

                ' Parse the Last Menstrual Cycle date if it exists
                If Not String.IsNullOrWhiteSpace(userLMCString) Then
                    If Not DateTime.TryParse(userLMCString, userLMC) Then
                        Throw New Exception("Invalid date format for Last Menstrual Cycle: " & userLMCString)
                    End If
                End If

                ' Skip blank line after user details
                reader.ReadLine()

                ' Read List Appointments
                Dim appointments As New List(Of Date)
                Dim appointmentsHeader = reader.ReadLine()
                If appointmentsHeader <> "List Appointments: Nothing" Then
                    Dim line As String
                    Do
                        line = reader.ReadLine()
                        If Not String.IsNullOrWhiteSpace(line) Then
                            Dim appointmentDate As Date
                            If DateTime.TryParse(line.Trim(), appointmentDate) Then
                                appointments.Add(appointmentDate)
                            Else
                                Throw New Exception("Invalid date format in appointments: " & line.Trim())
                            End If
                        End If
                    Loop Until String.IsNullOrWhiteSpace(line)
                End If

                ' Read Payment status
                Dim isPaidList As New List(Of Boolean)
                Dim isPaidHeader As String = reader.ReadLine()
                If isPaidHeader = "List is paid: No" Then
                    ' Skip blank line
                    reader.ReadLine()
                ElseIf isPaidHeader = "List Is paid:" Then
                    Dim line As String
                    Do
                        line = reader.ReadLine()
                        If Not String.IsNullOrWhiteSpace(line) Then
                            Dim isPaid As Boolean
                            If Boolean.TryParse(line.Trim(), isPaid) Then
                                isPaidList.Add(isPaid)
                            Else
                                Throw New Exception("Invalid boolean value in payment status: " & line.Trim())
                            End If
                        End If
                    Loop Until String.IsNullOrWhiteSpace(line)
                End If

                ' Read List Checked Appointments
                Dim checkedAppointmentsLine As String = reader.ReadLine()
                Dim checkedAppointments As New List(Of Integer)
                If checkedAppointmentsLine <> "List Checked Appointments: None" Then
                    If checkedAppointmentsLine.Length > 27 Then
                        Dim checkedItems = checkedAppointmentsLine.Substring(27).Split(", ")
                        For Each item In checkedItems
                            If Not String.IsNullOrWhiteSpace(item) Then
                                checkedAppointments.Add(Integer.Parse(item.Trim()))
                            End If
                        Next
                    End If
                End If

                ' Read Bill
                Dim billLine As String = reader.ReadLine()
                Dim billAmount As Double = 0
                If Not String.IsNullOrWhiteSpace(billLine) AndAlso billLine.StartsWith("Bill: ") Then
                    Dim billValue = billLine.Substring(6).Trim()
                    If Not billValue.Equals("Nothing", StringComparison.OrdinalIgnoreCase) Then
                        billAmount = Double.Parse(billValue)
                    End If
                End If

                ' Read Had Flu Vaccine
                Dim fluVaccineLine As String = reader.ReadLine()
                Dim hadFluVaccine As Boolean = False
                If Not String.IsNullOrWhiteSpace(fluVaccineLine) AndAlso fluVaccineLine.StartsWith("Had Flu Vaccine: ") Then
                    If fluVaccineLine.Length >= 17 Then
                        If Boolean.TryParse(fluVaccineLine.Substring(17).Trim(), hadFluVaccine) Then
                            ' Successfully parsed boolean
                        Else
                            Throw New Exception("Invalid boolean value for flu vaccine: " & fluVaccineLine.Substring(17).Trim())
                        End If
                    End If
                End If

                ' Set user credentials and data without doctor
                user.SetUserCredentials(userName, userAddress, userEmail, userPass, userAge, userIsFirstBaby, userGestationalAge, Nothing, userLMC)
                user.GetListAppointments().AddRange(appointments)
                user.GetListIsPaid().AddRange(isPaidList)
                user.GetListCheckedAppointments().AddRange(checkedAppointments)
                user.SetBill(billAmount)
                user.SetHadFluVac(hadFluVaccine)

                ' Set current user
                frmAccountInformation.currentUser = user
            End Using

            MsgBox("Data imported successfully.")
        Catch ex As Exception
            MsgBox("Error importing data: " & ex.Message)
        End Try
    End Sub

    Private Function GetValue(line As String) As String
        Dim parts As String() = line.Split(New String() {": "}, StringSplitOptions.None)
        If parts.Length > 1 Then
            Return parts(1).Trim()
        Else
            Return String.Empty
        End If
    End Function













    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim intCounter = 0
        Do While intCounter < frmAccountInformation.listUsers.Count
            If txtEmail.Text = frmAccountInformation.listUsers(intCounter).GetEmail() And txtPassword.Text = frmAccountInformation.listUsers(intCounter).GetPass() Then
                MsgBox("Log In Successful", vbOKOnly, "Log In")
                txtEmail.Clear()
                txtPassword.Clear()
                frmAccountInformation.currentUser = frmAccountInformation.listUsers(intCounter)
                ImportFileData(frmAccountInformation.currentUser.GetName())
                frmMain.txtPDName.Text = frmAccountInformation.currentUser.GetName()
                frmMain.txtPDAddress.Text = frmAccountInformation.currentUser.GetAddress()
                frmMain.txtPDAge.Text = frmAccountInformation.currentUser.GetAge()
                frmMain.txtPDFirstBaby.Text = frmAccountInformation.currentUser.GetIsFirstBaby()
                frmMain.txtPDGestationalAge.Text = frmAccountInformation.currentUser.GetGestationalAge()

                If frmAccountInformation.currentUser.GetDoctor() IsNot Nothing Then
                    frmMain.txtPDAdditionalInfo.Text = "The patient's doctor is " & frmAccountInformation.currentUser.GetDoctor().GetName() & "."
                Else
                    frmMain.txtPDAdditionalInfo.Text = "The patient has no assigned doctor."
                End If

                frmMain.blnLogOut = False
                frmRoutine.getNextCheckUp()
                frmMain.Show()
                Me.Hide()

                Return ' Make sure not to show the other MsgBox
            End If
            intCounter += 1
        Loop
        MsgBox("Log in error: User not found")
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub
End Class