Public Class frmBilling
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmPayment.Show()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

    End Sub
    Public Sub SetBillingFieldsForFirstAppointment()
        txtDescription1.Text = "Initial Check up"
        txtDescription2.Text = "Iron Vitamin"
        txtDescription3.Text = "B Complex"
        txtDescription4.Text = "DHA"

        txtUnitPrice1.Text = 2000
        txtUnitPrice2.Text = 15
        txtUnitPrice3.Text = 25
        txtUnitPrice4.Text = 20

        txtQuantity1.Text = 1
        txtQuantity2.Text = 30
        txtQuantity3.Text = 30
        txtQuantity4.Text = 90
    End Sub
    Public Sub SetBillingFieldsForSecondorThirdAppointment()
        txtDescription1.Text = "Follow up Check up"
        txtDescription2.Text = "Iron Vitamin"
        txtDescription3.Text = "B Complex"
        txtDescription4.Text = "DHA"

        txtUnitPrice1.Text = 500
        txtUnitPrice2.Text = 15
        txtUnitPrice3.Text = 25
        txtUnitPrice4.Text = 20

        txtQuantity1.Text = 1
        txtQuantity2.Text = 30
        txtQuantity3.Text = 30
        txtQuantity4.Text = 90
    End Sub
    Public Sub SetBillingFieldsForForthtoEightAppointment()
        txtDescription1.Text = "Follow up Check up"
        txtDescription2.Text = "Iron Vitamin"
        txtDescription3.Text = "B Complex"
        txtDescription4.Text = "DHA"

        txtUnitPrice1.Text = 500
        txtUnitPrice2.Text = 15
        txtUnitPrice3.Text = 25
        txtUnitPrice4.Text = 20

        txtQuantity1.Text = 1
        txtQuantity2.Text = 20
        txtQuantity3.Text = 20
        txtQuantity4.Text = 60
    End Sub
    Public Sub SetBillingFieldsForMorethanEightAppointment()
        txtDescription1.Text = "Follow up Check up"
        txtDescription2.Text = "Iron Vitamin"
        txtDescription3.Text = "B Complex"
        txtDescription4.Text = "DHA"

        txtUnitPrice1.Text = 500
        txtUnitPrice2.Text = 15
        txtUnitPrice3.Text = 25
        txtUnitPrice4.Text = 20

        txtQuantity1.Text = 1
        txtQuantity2.Text = 10
        txtQuantity3.Text = 10
        txtQuantity4.Text = 10
    End Sub

End Class