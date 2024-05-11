Public Class frmBilling
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmPayment.Show()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

    End Sub
End Class