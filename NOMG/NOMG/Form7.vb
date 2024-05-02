Public Class frmPayment
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim Change As Integer
        Change = frmBilling.txtTotal.Text - txtPayment.Text
        If frmBilling.txtTotal.Text > txtPayment.Text Then
            MsgBox("Insufficient Amount", vbOKOnly + vbExclamation, "Error")
        Else
            MsgBox("Change: " + Change.ToString, vbOKOnly, "Thank you")
        End If
    End Sub
End Class