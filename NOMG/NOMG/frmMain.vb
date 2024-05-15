Imports System.Drawing.Drawing2D

Public Class frmMain
    Dim dteTracker As Date
    Public txtFrmMainPD As New List(Of TextBox)
    Public txtFrmMainCI As New List(Of TextBox)

    Dim blnLogOut As Boolean
    Dim intI As Integer
    Dim counter As Integer

    Private Sub dtpFirstAppointment_ValueChanged(sender As Object, e As EventArgs) Handles dtpFirstAppointment.ValueChanged
        If blnLogOut = False And frmAccountInformation.currentUser.GetListAppointments.Count = 0 Then
            If dtpFirstAppointment.Value.DayOfWeek = 0 Or dtpFirstAppointment.Value.DayOfWeek = 1 Then
                MsgBox("The date chosen is not allowed. Sunday and Monday are not available. Please pick again.", vbRetryCancel + vbCritical, "Error")
            ElseIf dtpFirstAppointment.Value.Date < Date.Today.Date Then
                MsgBox("Dates in the past can not be chosen. Please pick again.", vbRetryCancel + vbCritical, "Error")
            Else
                intI = 0
                counter = 0
                Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                    If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dtpFirstAppointment.Value Then
                        counter = counter + 1
                    End If

                    intI = intI + 1
                Loop

                ' Checks if higher than 4 because the other 1 of the 5 is the date being set
                If counter > 4 Then
                    MsgBox("The date is fully booked.")
                Else
                    frmAccountInformation.currentUser.GetListAppointments.Add(dtpFirstAppointment.Value.Date)
                    frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dtpFirstAppointment.Value.Date)
                    dtpFirstAppointment.Hide()
                    lblAppointment.Text = "Next Check Up: " & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(0)
                End If
            End If
        End If
    End Sub

    Private Sub btnViewDoctors_Click(sender As Object, e As EventArgs) Handles btnViewDoctors.Click
        frmDoctors.Show()
        Me.Hide()
    End Sub

    Public Sub New()
        InitializeComponent()
        blnLogOut = False

        txtFrmMainCI.Add(txtCIName)
        txtFrmMainCI.Add(txtCIAddress)
        txtFrmMainCI.Add(txtCIOperationalDays)
        For Each txt In txtFrmMainCI
            txt.Font = New Font("Nunito", 12, FontStyle.Bold)
            txt.TextAlign = HorizontalAlignment.Center
            txt.Enabled = False
        Next

        txtFrmMainPD.Add(txtPDName)
        txtFrmMainPD.Add(txtPDAddress)
        txtFrmMainPD.Add(txtPDAge)
        txtFrmMainPD.Add(txtPDFirstBaby)
        txtFrmMainPD.Add(txtPDGestationalAge)
        txtFrmMainPD.Add(txtPDAdditionalInfo)
        For Each txt In txtFrmMainPD
            txt.Font = New Font("Nunito", 12, FontStyle.Bold)
            txt.TextAlign = HorizontalAlignment.Center
            txt.Enabled = False
        Next
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmStart.Show()
        Me.Hide()
        blnLogOut = True
        ' It is not set to current date because if it is set to the said date, users could not set it to the current date.
        dtpFirstAppointment.Value = New Date(Date.Today.Year, Date.Today.Month, Date.Today.Day - 1)
    End Sub

    Private Sub btnSeeRoutine_Click(sender As Object, e As EventArgs) Handles btnSeeRoutine.Click
        If frmAccountInformation.currentUser.GetListAppointments.Count > 0 Then
            ' Checks if the user has appointments to prevent setting more
            If frmAccountInformation.currentUser.GetListAppointments.Count < 2 Then

                frmAccountInformation.currentUser.SetDteLMC(frmAccountInformation_Continuation.dtpLMC.Value.Date)
                dteTracker = frmAccountInformation.currentUser.GetListAppointments(0)

                Do While dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(9)
                    If dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(3) Then
                        ' Checks if the clinic is open
                        Do While dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1
                            dteTracker = dteTracker.AddDays(1)
                        Loop

                        ' Checks if the doctor is fully booked
                        counter = 0
                        intI = 0
                        Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                            If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
                                counter = counter + 1
                            End If

                            intI = intI + 1
                        Loop

                        ' Checks if higher than 4 because the other 1 of the 5 is the date being set
                        If counter > 4 Then
                            MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
                            dteTracker = dteTracker.AddDays(1)
                        Else
                            dteTracker = dteTracker.AddDays(30)
                            frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
                            frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                        End If

                    ElseIf dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(6) Then
                        ' Checks if the clinic is open
                        Do While dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1
                            dteTracker = dteTracker.AddDays(1)
                        Loop

                        ' Checks if the doctor is fully booked
                        counter = 0
                        intI = 0
                        Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                            If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
                                counter = counter + 1
                            End If

                            intI = intI + 1
                        Loop

                        ' Checks if higher than 4 because the other 1 of the 5 is the date being set
                        If counter > 4 Then
                            MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
                            dteTracker = dteTracker.AddDays(1)
                        Else
                            dteTracker = dteTracker.AddDays(20)
                            frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
                            frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                        End If
                    Else
                        ' Checks if the clinic is open
                        If dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1 Then
                            Do While dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1
                                dteTracker = dteTracker.AddDays(1)
                            Loop
                        End If

                        ' Checks if the doctor is fully booked
                        counter = 0
                        intI = 0
                        Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                            If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
                                counter = counter + 1
                            End If

                            intI = intI + 1
                        Loop

                        ' Checks if higher than 4 because the other 1 of the 5 is the date being set
                        If counter > 4 Then
                            MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
                            dteTracker = dteTracker.AddDays(1)
                        Else
                            dteTracker = dteTracker.AddDays(10)
                            frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
                            frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                        End If
                    End If
                Loop
            End If

            For Each appointment In frmAccountInformation.currentUser.GetListAppointments
                frmRoutine.clbAppointments.Items.Add(appointment)
            Next

            If frmAccountInformation.currentUser.GetListCheckedAppointments.Count > 0 Then
                Dim total As Integer = frmAccountInformation.currentUser.GetListCheckedAppointments.Count
                Dim intI As Integer = 0

                While intI < total
                    frmRoutine.clbAppointments.SetItemChecked(intI, True)
                    intI = intI + 1

                End While
            End If

            frmRoutine.Show()
            Me.Hide()
        Else
            MsgBox("First appointment is not set.", vbRetryCancel + vbCritical, "Error")
        End If
    End Sub

    Private Sub btnBillingInfo_Click(sender As Object, e As EventArgs) Handles btnBillingInfo.Click
        frmBilling.Show()
        Dim AppointmentCount As Integer = frmAccountInformation.currentUser.GetListCheckedAppointments.Count

        If AppointmentCount = 0 Then
            frmBilling.ClearBillingFields()
        Else
            If frmAccountInformation.currentUser.GetListIsPaid(AppointmentCount - 1) = False Then
                If AppointmentCount = 1 Then
                    frmBilling.SetBillingFieldsForFirstAppointment()
                ElseIf AppointmentCount = 2 Or AppointmentCount = 3 Then
                    frmBilling.SetBillingFieldsForSecondorThirdAppointment()
                ElseIf AppointmentCount >= 4 AndAlso AppointmentCount <= 8 Then
                    frmBilling.SetBillingFieldsForForthtoEightAppointment()
                Else
                    frmBilling.SetBillingFieldsForMorethanEightAppointment()
                End If
            Else
                frmBilling.ClearBillingFields()
            End If
        End If


        Me.Hide()



        If frmRoutine.cbMed1.Checked = True Then
            frmRoutine.cbMed1.Checked = False
            frmRoutine.cbMed1.Enabled = False
            frmBilling.txtQuantity5.Text = 1
            frmBilling.txtDescription5.Text = "Flu Vac"
            frmBilling.txtUnitPrice5.Text = 1500
        Else
            frmBilling.txtQuantity5.Text = 0
            frmBilling.txtDescription5.Clear()
            frmBilling.txtUnitPrice5.Text = 0

        End If

        frmBilling.txtAmount1.Text = (Val(frmBilling.txtQuantity1.Text) * Val(frmBilling.txtUnitPrice1.Text))
        frmBilling.txtAmount2.Text = (Val(frmBilling.txtQuantity2.Text) * Val(frmBilling.txtUnitPrice2.Text))
        frmBilling.txtAmount3.Text = (Val(frmBilling.txtQuantity3.Text) * Val(frmBilling.txtUnitPrice3.Text))
        frmBilling.txtAmount4.Text = (Val(frmBilling.txtQuantity4.Text) * Val(frmBilling.txtUnitPrice4.Text))
        frmBilling.txtAmount5.Text = (Val(frmBilling.txtQuantity5.Text) * Val(frmBilling.txtUnitPrice5.Text))
        frmBilling.txtTotal.Text = (Val(frmBilling.txtAmount1.Text) + Val(frmBilling.txtAmount2.Text) + Val(frmBilling.txtAmount3.Text) + Val(frmBilling.txtAmount4.Text) + Val(frmBilling.txtAmount5.Text))

        frmBilling.txtName.Text = frmAccountInformation.currentUser.GetName()

        Me.Hide()

    End Sub
End Class