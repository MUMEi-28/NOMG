Public Class frmLogIn



	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmStart.Show()
		Me.Hide()
	End Sub

	Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
		Console.WriteLine("Buttoan clickedd")

		Dim intCounter = 0
		Do While intCounter < frmAccountInformation.listUsers.Count
			If txtEmail.Text = frmAccountInformation.listUsers(intCounter).GetEmail() And txtPassword.Text = frmAccountInformation.listUsers(intCounter).GetPass() Then
				MsgBox("log in succesful")

				'	Form1.Show()

				frmMain.Show()
				Me.Hide()
				frmAccountInformation.strCurrentUser = frmAccountInformation.listUsers(intCounter)
			End If
			intCounter += 1
		Loop

		Return
		MsgBox("Log in error: User not found")
	End Sub
End Class