Public Class frmBilling
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmPayment.Show()
        Me.Hide()

    End Sub
End Class