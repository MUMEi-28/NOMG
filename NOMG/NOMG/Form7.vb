Public Class frmPayment
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim Change As Integer
        Dim Payment As Integer
        Dim Total As Integer
        If Integer.TryParse(txtPayment.Text, Payment) AndAlso Integer.TryParse(frmBilling.txtTotal.Text, Total) Then
            Change = Payment - Total
            If Total <= Payment Then
                MsgBox("Change: " & Change.ToString(), vbOKOnly, "Thank you")
                Me.Hide()
                frmBilling.Hide()
                frmMain.Show()
            Else
                MsgBox("Insufficient Amount", vbOKOnly + vbExclamation, "Error")
                txtPayment.Clear()
            End If
        Else
            MsgBox("Invalid payment amount or total", vbOKOnly + vbExclamation, "Error")

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmBilling.Show()
        Me.Hide()

    End Sub

    Private Sub txtPayment_TextChanged(sender As Object, e As EventArgs) Handles txtPayment.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class