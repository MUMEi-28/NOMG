﻿Public Class frmMain
    Dim dteTracker As Date

    Public lblFrmMainPnl As New List(Of Label)

    Public txtFrmMainPD As New List(Of TextBox)
    Public txtFrmMainCI As New List(Of TextBox)

    Public pnlFrmMain As New List(Of Panel)
    Public btnFrmMain As New List(Of Button)

    Dim intI As Integer = 0
    Dim blnFullyBooked As Boolean = False
    Dim counter As Integer = 0

    Private Sub dtpFirstAppointment_ValueChanged(sender As Object, e As EventArgs) Handles dtpFirstAppointment.ValueChanged
        If dtpFirstAppointment.Value.DayOfWeek = 0 Or dtpFirstAppointment.Value.DayOfWeek = 1 Then
            MsgBox("The date chosen is not allowed. Sunday and Monday are not available. Please pick again.", vbRetryCancel + vbCritical, "Error")
            dtpFirstAppointment.Value = New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day)
        ElseIf dtpFirstAppointment.Value.Date < Date.Today.Date Then
            MsgBox("Dates in the past can not be chosen. Please pick again.", vbRetryCancel + vbCritical, "Error")
            dtpFirstAppointment.Value = New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day)
        Else
            Do While intI < frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Count
                If frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments(intI) = dtpFirstAppointment.Value Then
                    counter = counter + 1
                End If

                If counter > 5 Then
                    MsgBox("The date is fully booked.")
                    blnFullyBooked = True
                End If

                intI = intI + 1
            Loop

            If blnFullyBooked = False Then
                frmAccountInformation.strCurrentUser.GetListAppointments.Add(dtpFirstAppointment.Value.Date)
                frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Add(dtpFirstAppointment.Value.Date)
                dtpFirstAppointment.Hide()
                lblAppointment.Text = "Next Check Up:" & vbCrLf & frmAccountInformation.strCurrentUser.GetListAppointments(0)
            End If
        End If
    End Sub

    Private Sub btnViewDoctors_Click(sender As Object, e As EventArgs) Handles btnViewDoctors.Click
        frmDoctors.Show()
        Me.Hide()

    End Sub

    Public Sub New()
        InitializeComponent()
        Me.BackColor = Color.FromArgb(255, 39, 36, 46)
        If frmAccountInformation.strCurrentUser.GetListAppointments(0) = Nothing Then
            dtpFirstAppointment.Show()
            dtpFirstAppointment.Value = New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day)
            lblAppointment.Text = "First Check Up:"
        End If

        btnFrmMain.Add(btnBack)
        btnFrmMain.Add(btnSeeRoutine)
        btnFrmMain.Add(btnViewDoctors)
        btnFrmMain.Add(btnBillingInfo)
        For Each btn In btnFrmMain
            btn.BackColor = Color.FromArgb(255, 79, 45, 57)
            btn.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)
        Next

        pnlFrmMain.Add(pnlClinicInfo)
        pnlFrmMain.Add(pnlPatientDetails)
        For Each pnl In pnlFrmMain
            pnl.BackColor = Color.FromArgb(255, 79, 45, 57)
        Next

        lblAppointment.ForeColor = Color.FromArgb(255, 244, 238, 224)
        lblAppointment.BackColor = Color.FromArgb(255, 39, 36, 46)

        lblFrmMainPnl.Add(lblClinicInfo)
        lblFrmMainPnl.Add(lblCIName)
        lblFrmMainPnl.Add(lblCIAddress)
        lblFrmMainPnl.Add(lblClOperationalDays)
        lblFrmMainPnl.Add(lblPatientDetails)
        lblFrmMainPnl.Add(lblPDName)
        lblFrmMainPnl.Add(lblPDAddress)
        lblFrmMainPnl.Add(lblPDAge)
        lblFrmMainPnl.Add(lblPDFirstBaby)
        lblFrmMainPnl.Add(lblPDGestationalAge)
        lblFrmMainPnl.Add(lblPDAdditionalInfo)
        For Each lbl In lblFrmMainPnl
            lbl.ForeColor = Color.FromArgb(255, 244, 238, 224)
            lbl.BackColor = Color.FromArgb(255, 79, 45, 57)
        Next

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeeRoutine_Click(sender As Object, e As EventArgs) Handles btnSeeRoutine.Click
        ' In case the date is not changed anymore because the input is today.
        frmAccountInformation.strCurrentUser.SetDteLMC(frmAccountInformation_Continuation.dtpLMC.Value.Date)

        frmAccountInformation.strCurrentUser.GetListAppointments.Add(dtpFirstAppointment.Value.Date)
        dteTracker = frmAccountInformation.strCurrentUser.GetListAppointments(0).Date

        blnFullyBooked = False

        intI = 0
        For Each dr In frmAccountInformation.listDoctors
            Do While intI < dr.listDrAppointments.Count
                If dr.listDrAppointments(intI) < Today.Date Then
                    dr.listDrAppointments.Remove(dr.listDrAppointments(intI))
                End If
                intI = intI + 1
            Loop
        Next

        Do While dteTracker <= frmAccountInformation.strCurrentUser.GetDteLMC.AddMonths(9)
            If dteTracker <= frmAccountInformation.strCurrentUser.GetDteLMC.AddMonths(3) Then
                ' Checks if the clinic is open
                Do While dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1
                    dteTracker = dteTracker.AddDays(1)
                Loop

                ' Checks if the doctor is fully booked
                Do While intI < frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Count
                    If frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
                        counter = counter + 1
                    End If

                    If counter > 5 Then
                        MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
                        blnFullyBooked = True
                    End If

                    intI = intI + 1
                Loop

                If blnFullyBooked = False Then
                    dteTracker = dteTracker.AddDays(30)
                    frmAccountInformation.strCurrentUser.GetListAppointments.Add(dteTracker)
                    frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                Else
                    dteTracker = dteTracker.AddDays(1)
                    blnFullyBooked = False
                End If

            ElseIf dteTracker <= frmAccountInformation.strCurrentUser.GetDteLMC.AddMonths(6) Then
                ' Checks if the clinic is open
                Do While dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1
                    dteTracker = dteTracker.AddDays(1)
                Loop

                ' Checks if the doctor is fully booked
                Do While intI < frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Count
                    If frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
                        counter = counter + 1
                    End If

                    If counter > 5 Then
                        MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
                        blnFullyBooked = True
                    End If

                    intI = intI + 1
                Loop

                If blnFullyBooked = False Then
                    dteTracker = dteTracker.AddDays(20)
                    frmAccountInformation.strCurrentUser.GetListAppointments.Add(dteTracker)
                    frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                Else
                    dteTracker = dteTracker.AddDays(1)
                    blnFullyBooked = False
                End If
            Else
                ' Checks if the clinic is open
                If dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If

                ' Checks if the doctor is fully booked
                Do While intI < frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Count
                    If frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
                        counter = counter + 1
                    End If

                    If counter > 5 Then
                        MsgBox("One of the appointments is set in a later date because the doctor is fully booked on the former date.")
                        blnFullyBooked = True
                    End If

                    intI = intI + 1
                Loop

                If blnFullyBooked = False Then
                    dteTracker = dteTracker.AddDays(10)
                    frmAccountInformation.strCurrentUser.GetListAppointments.Add(dteTracker)
                    frmAccountInformation.strCurrentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                Else
                    dteTracker = dteTracker.AddDays(1)
                    blnFullyBooked = False
                End If
            End If
        Loop

        frmRoutine.Show()
        Me.Hide()

    End Sub

    Private Sub btnBillingInfo_Click(sender As Object, e As EventArgs) Handles btnBillingInfo.Click
        frmBilling.Show()
        If dteTracker <= frmAccountInformation.strCurrentUser.GetDteLMC.AddMonths(3) Then


            frmBilling.txtDescription1.Text = "Initial Check up"
            frmBilling.txtDescription2.Text = "Iron Vitamin"
            frmBilling.txtDescription3.Text = "B Complex"
            frmBilling.txtDescription4.Text = "DHA"
            frmBilling.txtDescription5.Text = "Flu Vac"
            frmBilling.txtUnitPrice1.Text = 2000
            frmBilling.txtUnitPrice2.Text = 15
            frmBilling.txtUnitPrice3.Text = 25
            frmBilling.txtUnitPrice4.Text = 20
            frmBilling.txtUnitPrice5.Text = 1500
            frmBilling.txtQuantity1.Text = 1
            frmBilling.txtQuantity2.Text = 30
            frmBilling.txtQuantity3.Text = 30
            frmBilling.txtQuantity4.Text = 90
            frmBilling.txtQuantity5.Text = 1
            frmBilling.txtAmount1.Text = (Val(frmBilling.txtQuantity1.Text) * Val(frmBilling.txtUnitPrice1.Text))
            frmBilling.txtAmount2.Text = (Val(frmBilling.txtQuantity2.Text) * Val(frmBilling.txtUnitPrice2.Text))
            frmBilling.txtAmount3.Text = (Val(frmBilling.txtQuantity3.Text) * Val(frmBilling.txtUnitPrice3.Text))
            frmBilling.txtAmount4.Text = (Val(frmBilling.txtQuantity4.Text) * Val(frmBilling.txtUnitPrice4.Text))
            frmBilling.txtAmount5.Text = (Val(frmBilling.txtQuantity5.Text) * Val(frmBilling.txtUnitPrice5.Text))
            frmBilling.txtTotal.Text = (Val(frmBilling.txtAmount1.Text) + Val(frmBilling.txtAmount2.Text) + Val(frmBilling.txtAmount3.Text) + Val(frmBilling.txtAmount4.Text) + Val(frmBilling.txtAmount5.Text))
        ElseIf dteTracker <= frmAccountInformation.strCurrentUser.GetDteLMC.AddMonths(6) Then
            frmBilling.txtDescription1.Text = "Follow up Check up"
            frmBilling.txtDescription2.Text = "Iron Vitamin"
            frmBilling.txtDescription3.Text = "B Complex"
            frmBilling.txtDescription4.Text = "DHA"
            frmBilling.txtUnitPrice1.Text = 500
            frmBilling.txtUnitPrice2.Text = 15
            frmBilling.txtUnitPrice3.Text = 25
            frmBilling.txtUnitPrice4.Text = 20
            frmBilling.txtQuantity1.Text = 1
            frmBilling.txtQuantity2.Text = 20
            frmBilling.txtQuantity3.Text = 20
            frmBilling.txtQuantity4.Text = 60
            frmBilling.txtAmount1.Text = (Val(frmBilling.txtQuantity1.Text) * Val(frmBilling.txtUnitPrice1.Text))
            frmBilling.txtAmount2.Text = (Val(frmBilling.txtQuantity2.Text) * Val(frmBilling.txtUnitPrice2.Text))
            frmBilling.txtAmount3.Text = (Val(frmBilling.txtQuantity3.Text) * Val(frmBilling.txtUnitPrice3.Text))
            frmBilling.txtAmount4.Text = (Val(frmBilling.txtQuantity4.Text) * Val(frmBilling.txtUnitPrice4.Text))
            frmBilling.txtAmount5.Text = (Val(frmBilling.txtQuantity5.Text) * Val(frmBilling.txtUnitPrice5.Text))
            frmBilling.txtTotal.Text = (Val(frmBilling.txtAmount1.Text) + Val(frmBilling.txtAmount2.Text) + Val(frmBilling.txtAmount3.Text) + Val(frmBilling.txtAmount4.Text) + Val(frmBilling.txtAmount5.Text))
        Else
            frmBilling.txtDescription1.Text = "Follow up Check up"
            frmBilling.txtDescription2.Text = "Iron Vitamin"
            frmBilling.txtDescription3.Text = "B Complex"
            frmBilling.txtDescription4.Text = "DHA"
            frmBilling.txtUnitPrice1.Text = 500
            frmBilling.txtUnitPrice2.Text = 15
            frmBilling.txtUnitPrice3.Text = 25
            frmBilling.txtUnitPrice4.Text = 20
            frmBilling.txtQuantity1.Text = 1
            frmBilling.txtQuantity2.Text = 10
            frmBilling.txtQuantity3.Text = 10
            frmBilling.txtQuantity4.Text = 30
            frmBilling.txtAmount1.Text = (Val(frmBilling.txtQuantity1.Text) * Val(frmBilling.txtUnitPrice1.Text))
            frmBilling.txtAmount2.Text = (Val(frmBilling.txtQuantity2.Text) * Val(frmBilling.txtUnitPrice2.Text))
            frmBilling.txtAmount3.Text = (Val(frmBilling.txtQuantity3.Text) * Val(frmBilling.txtUnitPrice3.Text))
            frmBilling.txtAmount4.Text = (Val(frmBilling.txtQuantity4.Text) * Val(frmBilling.txtUnitPrice4.Text))
            frmBilling.txtAmount5.Text = (Val(frmBilling.txtQuantity5.Text) * Val(frmBilling.txtUnitPrice5.Text))
            frmBilling.txtTotal.Text = (Val(frmBilling.txtAmount1.Text) + Val(frmBilling.txtAmount2.Text) + Val(frmBilling.txtAmount3.Text) + Val(frmBilling.txtAmount4.Text) + Val(frmBilling.txtAmount5.Text))
        End If
        Me.Hide()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class