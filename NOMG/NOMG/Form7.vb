Public Class frmPayment
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim Change As Integer
        Change = txtPayment.Text - frmBilling.txtTotal.Text
        If frmBilling.txtTotal.Text <= txtPayment.Text Then
            MsgBox("Change: " + Change.ToString, vbOKOnly, "Thank you")
            Me.Hide()
            frmBilling.Hide()
            frmMain.Show()


        Else
            MsgBox("Insufficient Amount", vbOKOnly + vbExclamation, "Error")
            txtPayment.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmBilling.Show()
        Me.Hide()

    End Sub
End Class