Public Class frmLogIn


	Private Sub btnBackToStart_Click(sender As Object, e As EventArgs) Handles btnBackToStart.Click
		frmStart.Show()
		Me.Hide()
	End Sub

	Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click



		Form1.Show()
		Me.Hide()
	End Sub

	Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class