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
    Public Sub SetIsPaid()
        txtDescription1.Clear()
        txtDescription2.Clear()
        txtDescription3.Clear()
        txtDescription4.Clear()
        txtDescription5.Clear()

        txtUnitPrice1.Text = 0
        txtUnitPrice2.Text = 0
        txtUnitPrice3.Text = 0
        txtUnitPrice4.Text = 0
        txtUnitPrice5.Text = 0

        txtQuantity1.Text = 0
        txtQuantity2.Text = 0
        txtQuantity3.Text = 0
        txtQuantity4.Text = 0
        txtQuantity5.Text = 0
    End Sub
    Public Sub ClearBillingFields()
        txtDescription1.Clear()
        txtDescription2.Clear()
        txtDescription3.Clear()
        txtDescription4.Clear()
        txtDescription5.Clear()

        txtUnitPrice1.Text = 0
        txtUnitPrice2.Text = 0
        txtUnitPrice3.Text = 0
        txtUnitPrice4.Text = 0
        txtUnitPrice5.Text = 0

        txtQuantity1.Text = 0
        txtQuantity2.Text = 0
        txtQuantity3.Text = 0
        txtQuantity4.Text = 0
        txtQuantity5.Text = 0
    End Sub

End Class