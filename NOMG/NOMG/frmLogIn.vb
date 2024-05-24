﻿Imports System.IO
Imports System.Text
Public Class frmLogIn
    Dim appCount As Integer
    Dim blnExistingDrApp As Boolean
    Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
        frmStart.Show()
        Me.Hide()
    End Sub
    Private Sub ImportFileData(ByVal userEmail As String)
        appCount = 0
        Try
            MsgBox("Running 1")
            Dim filePath As String = userEmail & ".txt"
            If Not File.Exists(filePath) Then
                MsgBox("No saved data found for this user.")
                Return
            End If
            MsgBox("Running 2")
            Using reader As New StreamReader(filePath, Encoding.UTF8)
                Dim user As New frmAccountInformation.User()

                ' Read user details
                Dim userName = GetValue(reader.ReadLine())  ' Name
                Dim userAddress = GetValue(reader.ReadLine())  ' Address
                Dim userAge = CInt(GetValue(reader.ReadLine()))  ' Age
                Dim userIsFirstBaby = GetValue(reader.ReadLine())  ' IsFirstBaby
                Dim userGestationalAge = CInt(GetValue(reader.ReadLine()))  ' GestationalAge

                ' Skip blank line after user details
                reader.ReadLine()

                ' Read List Appointments
                Dim appointments As New List(Of Date)
                Dim appointmentsHeader = reader.ReadLine()
                If Not appointmentsHeader.StartsWith("Patient's Appointment Lists:") Then
                    Throw New Exception("Unexpected format for appointment lists.")
                End If
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
                appCount = appointments.Count

                ' Read Payment status
                Dim isPaidList As New List(Of Boolean)
                Dim isPaidHeader As String = reader.ReadLine()
                If isPaidHeader.StartsWith("List Is paid:") Or isPaidHeader.StartsWith("List is paid:") Then
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
                If checkedAppointmentsLine.StartsWith("List Checked Appointments:") And checkedAppointmentsLine <> "List Checked Appointments: None" Then
                    If checkedAppointmentsLine.Length > 27 Then
                        Dim checkedItems = checkedAppointmentsLine.Substring(27).Split(", ")
                        For Each item In checkedItems
                            If Not String.IsNullOrWhiteSpace(item) Then
                                checkedAppointments.Add(Integer.Parse(item.Trim()))
                            End If
                        Next
                    End If
                End If

                reader.ReadLine()

                ' Read Bill
                Dim billLine As String = reader.ReadLine()
                Dim billAmount As Double = 0
                If (Not String.IsNullOrWhiteSpace(billLine) And Not billLine = "Bill: Nothing") AndAlso billLine.StartsWith("Bill: ") Then
                    Dim billValue = billLine.Substring(6).Trim()
                    If Not billValue.Equals("Nothing", StringComparison.OrdinalIgnoreCase) Then
                        billAmount = Double.Parse(billValue)
                    End If
                End If

                reader.ReadLine()

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

                reader.ReadLine()

                ' Read Patient's Doctor
                Dim doctorLine As String = reader.ReadLine()
                Dim doctorName As String = Nothing

                If Not String.IsNullOrWhiteSpace(doctorLine) AndAlso doctorLine.StartsWith("Doctor Name: ") Then
                    If doctorLine.Length >= 13 Then
                        Dim doctorValue = doctorLine.Substring(13).Trim()
                        If Not doctorValue.Equals("Nothing", StringComparison.OrdinalIgnoreCase) Then
                            doctorName = doctorValue
                        End If
                    End If
                End If

                Dim counter As Integer = 0
                Dim userDoctor As frmAccountInformation.Doctor = Nothing
                Do While counter < frmAccountInformation.listDoctors.Count
                    If doctorName = frmAccountInformation.listDoctors(counter).GetName Then
                        userDoctor = frmAccountInformation.listDoctors(counter)
                    End If
                    counter = counter + 1
                Loop

                reader.ReadLine()

                Dim passLine As String = reader.ReadLine()
                Dim userPass As String = Nothing

                If Not String.IsNullOrWhiteSpace(passLine) AndAlso passLine.StartsWith("Password: ") Then
                    If passLine.Length >= 10 Then
                        Dim passValue = passLine.Substring(10).Trim()
                        If Not passValue.Equals("Nothing", StringComparison.OrdinalIgnoreCase) Then
                            userPass = passValue
                        End If
                    End If
                End If

                Dim setInDrAppLine As String = reader.ReadLine()
                Dim userSetInDrApp As String = Nothing

                If Not String.IsNullOrWhiteSpace(setInDrAppLine) AndAlso setInDrAppLine.StartsWith("Password: ") Then
                    If setInDrAppLine.Length >= 10 Then
                        Dim setInDrAppValue = setInDrAppLine.Substring(10).Trim()
                        If Not setInDrAppValue.Equals("Nothing", StringComparison.OrdinalIgnoreCase) Then
                            userSetInDrApp = setInDrAppValue
                        End If
                    End If
                End If

                ' Set user credentials and data
                user.SetUserCredentials(userName, userAddress, userEmail, userPass, userAge, userIsFirstBaby, userGestationalAge, userDoctor, Date.MinValue)
                user.GetListAppointments().AddRange(appointments)
                user.GetListIsPaid().AddRange(isPaidList)
                user.GetListCheckedAppointments().AddRange(checkedAppointments)
                user.SetBill(billAmount)
                user.SetHadFluVac(hadFluVaccine)
                user.SetSetInDrApp(userSetInDrApp)

                ' Add user's appointments to doctor's appointments
                If (Not userSetInDrApp) And userDoctor IsNot Nothing Then
                    userDoctor.listDrAppointments.AddRange(appointments)
                    userSetInDrApp = True
                    user.SetSetInDrApp(userSetInDrApp)
                End If

                ' Adds to the list of users
                frmAccountInformation.listUsers.Add(user)

            End Using

            MsgBox("Data imported successfully.")
        Catch ex As Exception
            MsgBox("Running 3")
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
        ImportFileData(txtEmail.Text)

        Do While intCounter < frmAccountInformation.listUsers.Count
            If txtEmail.Text = frmAccountInformation.listUsers(intCounter).GetEmail() And txtPassword.Text = frmAccountInformation.listUsers(intCounter).GetPass() Then
                MsgBox("Log In Successful", vbOKOnly, "Log In")
                txtEmail.Clear()
                txtPassword.Clear()
                frmAccountInformation.currentUser = frmAccountInformation.listUsers(intCounter)

                If blnExistingDrApp = False Then
                    ExistingDrAppointments()
                    blnExistingDrApp = True
                End If

                ' Initializes the textboxes in frmMain
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
            ElseIf txtEmail.Text = frmAccountInformation.listUsers(intCounter).GetEmail() Then
                ' If the password is incorrect
                Dim i As Integer = frmAccountInformation.currentUser.GetDoctor().listDrAppointments.Count - appCount
                Dim totalDrApp As Integer = frmAccountInformation.currentUser.GetDoctor().listDrAppointments.Count
                Do While i < totalDrApp
                    frmAccountInformation.currentUser.GetDoctor().listDrAppointments.RemoveAt(frmAccountInformation.currentUser.GetDoctor().listDrAppointments.Count - appCount)
                    i = i + 1
                Loop
                frmAccountInformation.listUsers.RemoveAt(intCounter)
                Exit Do
            End If
            intCounter += 1
        Loop
        MsgBox("Log in error: User not found")
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    Public Sub ExistingDrAppointments()
        Try
            Dim drFilePath As String = frmAccountInformation.currentUser.GetDoctor().GetName & ".txt"
            If Not File.Exists(drFilePath) Then
                Return
            End If

            Using reader2 As New StreamReader(drFilePath, Encoding.UTF8)
                reader2.ReadLine()
                reader2.ReadLine()

                ' Read Appointments of Doctor
                Dim drAppointments As New List(Of Date)
                Dim drAppointmentsHeader = reader2.ReadLine()
                If Not drAppointmentsHeader.StartsWith("Doctor's Appointments:") Then
                    Throw New Exception("Unexpected format for appointments of doctor.")
                End If
                Dim drLine As String
                Do
                    drLine = reader2.ReadLine()
                    If Not String.IsNullOrWhiteSpace(drLine) Then
                        Dim drAppointmentDate As Date
                        If DateTime.TryParse(drLine.Trim(), drAppointmentDate) Then
                            frmAccountInformation.currentUser.GetDoctor().listDrAppointments.Add(drAppointmentDate)
                        Else
                            Throw New Exception("Invalid date format in appointments of doctor: " & drLine.Trim())
                        End If
                    End If
                Loop Until String.IsNullOrWhiteSpace(drLine)
            End Using
        Catch err As Exception
        End Try
    End Sub
End Class
