Public Class frmMain
    Public listAppointment As New List(Of Date)
    Dim dteLMC As Date
    Dim dteTracker As Date

    Public lblFrmMainPnl As New List(Of Label)
    Public lblFrmMainTtl As New List(Of Label)
    Public pnlFrmMain As New List(Of Panel)
    Public btnFrmMain As New List(Of Button)

    Private Sub dtpFirstAppointment_ValueChanged(sender As Object, e As EventArgs) Handles dtpFirstAppointment.ValueChanged
        If dtpFirstAppointment.Value.DayOfWeek = 0 Or dtpFirstAppointment.Value.DayOfWeek = 1 Then
            MsgBox("The date chosen is not allowed. Sunday and Monday are not available. Please pick again.", vbRetryCancel + vbCritical, "Error")
        ElseIf dtpFirstAppointment.Value.Date < Date.Today.Date Then
            MsgBox("Dates in the past can not be chosen. Please pick again.", vbRetryCancel + vbCritical, "Error")
        Else
            listAppointment(0) = dtpFirstAppointment.Value.Date
            dtpFirstAppointment.Enabled = False
        End If
    End Sub

    Private Sub dtpLMC_ValueChanged(sender As Object, e As EventArgs) Handles dtpLMC.ValueChanged
        If dtpLMC.Value.Date > Date.Today.Date Then
            MsgBox("The date chosen is not allowed. Last Menstrual Cycle is not in the future. Please pick again.", vbRetryCancel + vbCritical, "Error")
        Else
            dteLMC = dtpLMC.Value.Date
        End If
    End Sub

    Private Sub btnViewDoctors_Click(sender As Object, e As EventArgs) Handles btnViewDoctors.Click
        frmDoctors.Show()
        Me.Hide()

    End Sub

    Public Sub New()
        InitializeComponent()
        listAppointment.Add(dtpFirstAppointment.Value.Date)
        dteLMC = dtpLMC.Value.Date

        Me.BackColor = Color.FromArgb(255, 39, 36, 46)

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

        lblFrmMainTtl.Add(lblLMC)
        lblFrmMainTtl.Add(lblSetFirstAppointment)
        For Each lbl In lblFrmMainTtl
            lbl.ForeColor = Color.FromArgb(255, 244, 238, 224)
            lbl.BackColor = Color.FromArgb(255, 39, 36, 46)
        Next

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
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeeRoutine_Click(sender As Object, e As EventArgs) Handles btnSeeRoutine.Click
        dteTracker = listAppointment(0).Date

        Do While dteTracker <= dteLMC.AddMonths(9)
            If dteTracker <= dteLMC.AddMonths(3) Then
                If dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If
                dteTracker = dteTracker.AddDays(30)
                listAppointment.Add(dteTracker)
            ElseIf dteTracker <= dteLMC.AddMonths(6) Then
                If dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If
                dteTracker = dteTracker.AddDays(20)
                listAppointment.Add(dteTracker)
            Else
                If dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If
                dteTracker = dteTracker.AddDays(10)
                listAppointment.Add(dteTracker)
            End If
        Loop

        frmRoutine.Show()
        Me.Hide()
    End Sub

    Private Sub btnBillingInfo_Click(sender As Object, e As EventArgs) Handles btnBillingInfo.Click
        frmBilling.Show()

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
        frmBilling.txtAmount6.Text = (Val(frmBilling.txtQuantity6.Text) * Val(frmBilling.txtUnitPrice6.Text))
        frmBilling.txtTotal.Text = (Val(frmBilling.txtAmount1.Text) + Val(frmBilling.txtAmount2.Text) + Val(frmBilling.txtAmount3.Text) + Val(frmBilling.txtAmount4.Text) + Val(frmBilling.txtAmount5.Text) + Val(frmBilling.txtAmount6.Text))
        Me.Hide()

    End Sub
End Class