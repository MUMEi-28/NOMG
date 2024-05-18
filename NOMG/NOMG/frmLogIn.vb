Imports System.IO
Imports System.Text
Public Class frmLogIn
    Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
        frmStart.Show()
        Me.Hide()
    End Sub
    Private Sub ImportFileData(ByVal email As String)
        Try
            Dim filePath As String = email & ".txt"
            If Not File.Exists(filePath) Then
                MsgBox("No saved data found for this user.")
                Return
            End If

            Using reader As New StreamReader(filePath, Encoding.UTF8)
                Dim user As New frmAccountInformation.User()

                user.SetUserCredentials(
                reader.ReadLine().Split(":")(1).Trim(), 'Name
                reader.ReadLine().Split(":")(1).Trim(), 'Address
                reader.ReadLine().Split(":")(1).Trim(), 'Email
                reader.ReadLine().Split(":")(1).Trim(), 'Password
                CInt(reader.ReadLine().Split(":")(1).Trim()), 'Age
                reader.ReadLine().Split(":")(1).Trim(), 'IsFirstBaby
                CInt(reader.ReadLine().Split(":")(1).Trim()), 'GestationalAge
                frmAccountInformation.listDoctors.First(Function(doc) doc.GetName() = reader.ReadLine().Split(":")(1).Trim()), 'Doctor
                Date.Parse(reader.ReadLine().Split(":")(1).Trim()) 'LMC
            )

                ' Read Appointments
                reader.ReadLine() ' Skip the "Appointments:" line
                Dim appointments As New List(Of Date)
                Dim line As String = reader.ReadLine()
                While Not line.StartsWith("CheckedAppointments:")
                    appointments.Add(Date.Parse(line.Trim()))
                    line = reader.ReadLine()
                End While
                user.GetListAppointments().AddRange(appointments)

                ' Read CheckedAppointments
                Dim checkedAppointments As New List(Of Integer)
                line = reader.ReadLine()
                While Not line.StartsWith("IsPaid:")
                    checkedAppointments.Add(Integer.Parse(line.Trim()))
                    line = reader.ReadLine()
                End While
                user.GetListCheckedAppointments().AddRange(checkedAppointments)

                ' Read IsPaid
                Dim isPaidList As New List(Of Boolean)
                line = reader.ReadLine()
                While Not line.StartsWith("Bill:")
                    isPaidList.Add(Boolean.Parse(line.Trim()))
                    line = reader.ReadLine()
                End While
                user.GetListIsPaid().AddRange(isPaidList)

                user.SetBill(Double.Parse(line.Split(":")(1).Trim())) 'Bill
                user.SetHadFluVac(Boolean.Parse(reader.ReadLine().Split(":")(1).Trim())) 'HadFluVac

                frmAccountInformation.currentUser = user
            End Using

            MsgBox("Data imported successfully.")
        Catch ex As Exception
            MsgBox("Error importing data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim intCounter = 0
        Do While intCounter < frmAccountInformation.listUsers.Count
            If txtEmail.Text = frmAccountInformation.listUsers(intCounter).GetEmail() And txtPassword.Text = frmAccountInformation.listUsers(intCounter).GetPass() Then
                MsgBox("log in successful")
                txtEmail.Clear()
                txtPassword.Clear()
                frmAccountInformation.currentUser = frmAccountInformation.listUsers(intCounter)
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