Public Class frmBilling
    Public Sub MainBilling()
        Dim AppointmentCount As Integer = frmAccountInformation.currentUser.GetListCheckedAppointments.Count

        If AppointmentCount = 0 Then
            ClearBillingFields()
        Else
            If frmAccountInformation.currentUser.GetListIsPaid(AppointmentCount - 1) = False Then
                setCheckUpBill()
                SetBillingFields()
                FluVac()
            Else
                ClearBillingFields()
            End If
        End If

        Calculate()
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmPayment.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()
    End Sub
    Public Sub setCheckUpBill()
        txtQuantity1.Text = 1
        If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = 1 Then
            ' Set initial check up bill
            txtDescription1.Text = "Initial Check up"
            txtUnitPrice1.Text = 2000
        Else
            txtDescription1.Text = "Follow up Check up"
            txtUnitPrice1.Text = 500
        End If
    End Sub

    Public Sub SetBillingFields()
        txtDescription2.Text = "Iron Vitamin"
        txtDescription3.Text = "B Complex"
        txtDescription4.Text = "DHA"

        txtUnitPrice2.Text = 15
        txtUnitPrice3.Text = 25
        txtUnitPrice4.Text = 20

        Dim dteInterval As TimeSpan = frmAccountInformation.currentUser.GetListAppointments(frmAccountInformation.currentUser.GetListCheckedAppointments.Count) - frmAccountInformation.currentUser.GetListAppointments(frmAccountInformation.currentUser.GetListCheckedAppointments.Count - 1)

        txtQuantity2.Text = dteInterval.Days
        txtQuantity3.Text = dteInterval.Days
        txtQuantity4.Text = dteInterval.Days * 3

        txtPendingAmount.Text = frmAccountInformation.currentUser.GetDblBill
    End Sub

    Public Sub FluVac()
        If frmRoutine.cbMed1.Checked = True Then
            frmRoutine.cbMed1.Checked = False
            frmRoutine.cbMed1.Enabled = False
            txtQuantity5.Text = 1
            txtDescription5.Text = "Flu Vac"
            txtUnitPrice5.Text = 1500
        Else
            txtQuantity5.Text = 0
            txtDescription5.Clear()
            txtUnitPrice5.Text = 0
            txtAmount5.Text = 0
        End If
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

        txtAmount1.Text = 0
        txtAmount2.Text = 0
        txtAmount3.Text = 0
        txtAmount4.Text = 0
        txtAmount5.Text = 0

        txtPendingAmount.Text = 0
        txtTotal.Text = 0
    End Sub

    Public Sub Calculate()
        txtAmount1.Text = (Val(txtQuantity1.Text) * Val(txtUnitPrice1.Text))
        txtAmount2.Text = (Val(txtQuantity2.Text) * Val(txtUnitPrice2.Text))
        txtAmount3.Text = (Val(txtQuantity3.Text) * Val(txtUnitPrice3.Text))
        txtAmount4.Text = (Val(txtQuantity4.Text) * Val(txtUnitPrice4.Text))
        txtAmount5.Text = (Val(txtQuantity5.Text) * Val(txtUnitPrice5.Text))
        frmAccountInformation.currentUser.SetDblBill(frmAccountInformation.currentUser.GetDblBill + (Val(txtAmount1.Text) + Val(txtAmount2.Text) + Val(txtAmount3.Text) + Val(txtAmount4.Text) + Val(txtAmount5.Text)))
        txtTotal.Text = frmAccountInformation.currentUser.GetDblBill
    End Sub
End Class