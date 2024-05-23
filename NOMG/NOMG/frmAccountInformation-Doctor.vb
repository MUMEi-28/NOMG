Public Class frmAccountInformation_Doctor
	Dim tempDoctor2 As frmAccountInformation.Doctor


	Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		frmAccountInformation_Continuation.Show()
		Me.Hide()
	End Sub

	Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
		' Create a new user instance
		Dim newUser As New frmAccountInformation.User()
		newUser.SetUserCredentials(frmAccountInformation.txtName.Text, frmAccountInformation.txtAddress.Text,
								   frmAccountInformation.txtEmail.Text, frmAccountInformation.txtPassword.Text,
								   Val(frmAccountInformation_Continuation.txtAge.Text), frmAccountInformation_Continuation.txtFirstBaby.Text,
								   Val(frmAccountInformation_Continuation.txtGasAge.Text), tempDoctor2, frmAccountInformation_Continuation.dtpLMC.Value)

		frmAccountInformation.listUsers.Add(newUser)

		' Set the currentUser to the new user
		frmAccountInformation.currentUser = newUser

		' Call ExportFileData
		frmMain.ExportFileData()

		' Clear all TextBoxes
		frmAccountInformation.txtName.Clear()
		frmAccountInformation.txtAddress.Clear()
		frmAccountInformation.txtEmail.Clear()
		frmAccountInformation.txtPassword.Clear()
		frmAccountInformation_Continuation.txtAge.Clear()
		frmAccountInformation_Continuation.txtFirstBaby.Clear()
		frmAccountInformation_Continuation.txtGasAge.Clear()
		tempDoctor2 = Nothing
		frmAccountInformation_Continuation.dtpLMC.Value = New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day)



		' Hide the current form and show the login form
		Me.Hide()
		frmLogIn.Show()

	End Sub

	Private Sub btnDoctor1_Click(sender As Object, e As EventArgs) Handles btnDoctor1.Click
		MsgBox(frmAccountInformation.listDoctors(0).GetName & " is selected.")
		tempDoctor2 = frmAccountInformation.listDoctors(0)
	End Sub

	Private Sub btnDoctor2_Click(sender As Object, e As EventArgs) Handles btnDoctor2.Click
		MsgBox(frmAccountInformation.listDoctors(1).GetName & " is selected.")
		tempDoctor2 = frmAccountInformation.listDoctors(1)
	End Sub

	Private Sub btnDoctor3_Click(sender As Object, e As EventArgs) Handles btnDoctor3.Click
		MsgBox(frmAccountInformation.listDoctors(2).GetName & " is selected.")
		tempDoctor2 = frmAccountInformation.listDoctors(2)
	End Sub
End Class