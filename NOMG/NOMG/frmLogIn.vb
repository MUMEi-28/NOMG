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

				frmMain.Show()
				Me.Hide()

				frmAccountInformation.strCurrentUser = frmAccountInformation.listUsers(intCounter)

				Return '' Make sure not to show the other msgBox
			End If
			intCounter += 1
		Loop

		MsgBox("Log in error: User not found")
		txtEmail.Clear()
		txtPassword.Clear()
	End Sub
End Class