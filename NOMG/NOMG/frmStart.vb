Public Class frmStart
	Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
		frmAccountInformation.Show()
		Me.Hide()
	End Sub

	Private Sub btnExisting_Click(sender As Object, e As EventArgs) Handles btnExisting.Click
		frmLogIn.Show()
		Me.Hide()
	End Sub
End Class