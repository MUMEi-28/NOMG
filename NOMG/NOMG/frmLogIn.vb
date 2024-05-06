Public Class frmLogIn



	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmStart.Show()
		Me.Hide()
	End Sub

	Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

		Dim intCounter = 0
		Do While intCounter < frmAccountInformation.listUsers.Count
			If txtEmail.Text = frmAccountInformation.listUsers(intCounter).GetEmail() And txtPassword.Text = frmAccountInformation.listUsers(intCounter).GetPass() Then
				MsgBox("log in succesful")

				txtEmail.Clear()
				txtPassword.Clear()

				frmAccountInformation.currentUser = frmAccountInformation.listUsers(intCounter)

				frmMain.txtPDName.Text = frmAccountInformation.currentUser.GetName()
				frmMain.txtPDAddress.Text = frmAccountInformation.currentUser.GetAddress()
				frmMain.txtPDAge.Text = frmAccountInformation.currentUser.GetAge()
				frmMain.txtPDFirstBaby.Text = frmAccountInformation.currentUser.GetIsFirstBaby()
				frmMain.txtPDGestationalAge.Text = frmAccountInformation.currentUser.GetGestationalAge()
				frmMain.txtPDAdditionalInfo.Text = "The patient's doctor is " & frmAccountInformation.currentUser.GetDoctor.GetName & "."

				If frmAccountInformation.currentUser.GetBolIsFirst = False Then
					frmMain.dtpFirstAppointment.Show()
					frmMain.lblAppointment.Text = "First Check Up:"
				Else
					frmMain.lblAppointment.Text = "Next Check Up: " & vbCrLf & frmRoutine.getNextCheckUp
				End If

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