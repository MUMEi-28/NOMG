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
                Dim nameLine = reader.ReadLine().Split(":")(1).Trim()
                Dim addressLine = reader.ReadLine().Split(":")(1).Trim()
                Dim ageLine = CInt(reader.ReadLine().Split(":")(1).Trim())
                Dim firstBabyLine = reader.ReadLine().Split(":")(1).Trim()
                Dim gestationalAgeLine = CInt(reader.ReadLine().Split(":")(1).Trim())

                ' Skip blank line
                reader.ReadLine()

                ' Set user credentials
                user.SetUserCredentials(
                nameLine, ' Name
                addressLine, ' Address
                frmAccountInformation.currentUser.GetEmail(), ' Use the email from the current user
                frmAccountInformation.currentUser.GetPass(), ' Use the password from the current user
                ageLine, ' Age
                firstBabyLine, ' IsFirstBaby
                gestationalAgeLine, ' GestationalAge
                frmAccountInformation.listDoctors.First(Function(doc) doc.GetName() = "Doctor Name Placeholder"), ' Placeholder, update accordingly
                Date.Parse("01/01/2023") ' Placeholder, update accordingly
            )

                ' Read Appointments
                reader.ReadLine() ' Skip the "List Appointments:" line
                Dim appointments As New List(Of Date)
                Dim line As String = reader.ReadLine()
                While Not String.IsNullOrWhiteSpace(line)
                    appointments.Add(Date.Parse(line.Trim()))
                    line = reader.ReadLine()
                End While
                user.GetListAppointments().AddRange(appointments)

                ' Read IsPaid
                line = reader.ReadLine()
                Dim isPaidList As New List(Of Boolean)
                If line.StartsWith("List is paid: Yes") Then
                    isPaidList.Add(True)
                Else
                    isPaidList.Add(False)
                End If
                user.GetListIsPaid().AddRange(isPaidList)

                ' Read Checked Appointments
                line = reader.ReadLine()
                Dim checkedAppointments As New List(Of Integer)
                If Not line.StartsWith("List Checked Appointments: None") Then
                    line = line.Substring(line.IndexOf(":") + 1).Trim()
                    Dim checkedAppointmentItems = line.Split(", ")
                    For Each item In checkedAppointmentItems
                        If Not String.IsNullOrWhiteSpace(item) Then
                            checkedAppointments.Add(Integer.Parse(item.Trim()))
                        End If
                    Next
                End If
                user.GetListCheckedAppointments().AddRange(checkedAppointments)

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
                MsgBox("log in successful")
                txtEmail.Clear()
                txtPassword.Clear()
                frmAccountInformation.currentUser = frmAccountInformation.listUsers(intCounter)
                ImportFileData(frmAccountInformation.currentUser.GetName())
                frmMain.txtPDName.Text = frmAccountInformation.currentUser.GetName()
                frmMain.txtPDAddress.Text = frmAccountInformation.currentUser.GetAddress()
                frmMain.txtPDAge.Text = frmAccountInformation.currentUser.GetAge()
                frmMain.txtPDFirstBaby.Text = frmAccountInformation.currentUser.GetIsFirstBaby()
                frmMain.txtPDGestationalAge.Text = frmAccountInformation.currentUser.GetGestationalAge()
                frmMain.txtPDAdditionalInfo.Text = "The patient's doctor is " & frmAccountInformation.currentUser.GetDoctor.GetName & "."
                frmMain.blnLogOut = False
                frmRoutine.getNextCheckUp()
                frmMain.Show()
                Me.Hide()

                Return '' Make sure not to show the other msgBox
            End If
            intCounter += 1
        Loop
        MsgBox("Log in error: User not found")
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

End Class