Public Class frmAccountInformation

	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmStart.Show()
		Me.Hide()

	End Sub

	Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
		Form1.Show()
		Me.Hide()
	End Sub
End Class