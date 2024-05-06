Imports System.Drawing.Drawing2D

Public Class frmMain
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
        ElseIf dtpFirstAppointment.Value.Date < Date.Today.Date Then
            MsgBox("Dates in the past can not be chosen. Please pick again.", vbRetryCancel + vbCritical, "Error")
        Else
            Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dtpFirstAppointment.Value Then
                    counter = counter + 1
                End If

                If counter > 5 Then
                    MsgBox("The date is fully booked.")
                    blnFullyBooked = True
                End If

                intI = intI + 1
            Loop

            If blnFullyBooked = False Then
                frmAccountInformation.currentUser.GetListAppointments.Add(dtpFirstAppointment.Value.Date)
                frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dtpFirstAppointment.Value.Date)
                dtpFirstAppointment.Hide()
                lblAppointment.Text = "Next Check Up: " & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(0)
                frmAccountInformation.currentUser.SetBolIsFirst(True)
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

        btnFrmMain.Add(btnLogOut)
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

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeeRoutine_Click(sender As Object, e As EventArgs) Handles btnSeeRoutine.Click
        If frmAccountInformation.currentUser.GetBolIsFirst Then
            blnFullyBooked = False
            dteTracker = frmAccountInformation.currentUser.GetListAppointments(0)
            MsgBox(dteTracker)

            intI = 0
            For Each dr In frmAccountInformation.listDoctors
                Do While intI < dr.listDrAppointments.Count
                    If dr.listDrAppointments(intI) < Today.Date Then
                        dr.listDrAppointments.Remove(dr.listDrAppointments(intI))
                    End If
                    intI = intI + 1
                Loop
            Next

            Do While dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(9)
                If dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(3) Then
                    ' Checks if the clinic is open
                    Do While dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop

                    ' Checks if the doctor is fully booked
                    Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                        If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
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
                        frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
                        frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                    Else
                        dteTracker = dteTracker.AddDays(1)
                        blnFullyBooked = False
                    End If

                ElseIf dteTracker <= frmAccountInformation.currentUser.GetDteLMC.AddMonths(6) Then
                    ' Checks if the clinic is open
                    Do While dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop

                    ' Checks if the doctor is fully booked
                    Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                        If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
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
                        frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
                        frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
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
                    Do While intI < frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Count
                        If frmAccountInformation.currentUser.GetDoctor.listDrAppointments(intI) = dteTracker.AddDays(30) Then
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
                        frmAccountInformation.currentUser.GetListAppointments.Add(dteTracker)
                        frmAccountInformation.currentUser.GetDoctor.listDrAppointments.Add(dteTracker)
                    Else
                        dteTracker = dteTracker.AddDays(1)
                        blnFullyBooked = False
                    End If
                End If
            Loop

            MsgBox(frmAccountInformation.currentUser.GetListAppointments(2))
            frmRoutine.Show()
            Me.Hide()
        Else
            MsgBox("First appointment is not set.", vbRetryCancel + vbCritical, "Error")
        End If
    End Sub
    Dim VisitCount As Integer
    Private Sub btnBillingInfo_Click(sender As Object, e As EventArgs) Handles btnBillingInfo.Click
        frmBilling.Show()
        VisitCount += 1
        Select Case VisitCount
            Case 1
                frmBilling.txtDescription1.Text = "Initial Check up"
                frmBilling.txtDescription2.Text = "Iron Vitamin"
                frmBilling.txtDescription3.Text = "B Complex"
                frmBilling.txtDescription4.Text = "DHA"

                frmBilling.txtUnitPrice1.Text = 2000
                frmBilling.txtUnitPrice2.Text = 15
                frmBilling.txtUnitPrice3.Text = 25
                frmBilling.txtUnitPrice4.Text = 20

                frmBilling.txtQuantity1.Text = 1
                frmBilling.txtQuantity2.Text = 30
                frmBilling.txtQuantity3.Text = 30
                frmBilling.txtQuantity4.Text = 90
            Case 2, 3
                frmBilling.txtDescription1.Text = "Follow up Check up"
                frmBilling.txtDescription2.Text = "Iron Vitamin"
                frmBilling.txtDescription3.Text = "B Complex"
                frmBilling.txtDescription4.Text = "DHA"
                frmBilling.txtUnitPrice1.Text = 500
                frmBilling.txtUnitPrice2.Text = 15
                frmBilling.txtUnitPrice3.Text = 25
                frmBilling.txtUnitPrice4.Text = 20
                frmBilling.txtQuantity1.Text = 1
                frmBilling.txtQuantity2.Text = 30
                frmBilling.txtQuantity3.Text = 30
                frmBilling.txtQuantity4.Text = 90
            Case 4 To 6
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
            Case 7 To 9
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



        End Select
        If frmRoutine.cbMed1.Checked = True Then
            frmBilling.txtQuantity5.Text = 1
            frmBilling.txtDescription5.Text = "Flu Vac"
            frmBilling.txtUnitPrice5.Text = 1500
        End If

        frmBilling.txtAmount1.Text = (Val(frmBilling.txtQuantity1.Text) * Val(frmBilling.txtUnitPrice1.Text))
        frmBilling.txtAmount2.Text = (Val(frmBilling.txtQuantity2.Text) * Val(frmBilling.txtUnitPrice2.Text))
        frmBilling.txtAmount3.Text = (Val(frmBilling.txtQuantity3.Text) * Val(frmBilling.txtUnitPrice3.Text))
        frmBilling.txtAmount4.Text = (Val(frmBilling.txtQuantity4.Text) * Val(frmBilling.txtUnitPrice4.Text))
        frmBilling.txtAmount5.Text = (Val(frmBilling.txtQuantity5.Text) * Val(frmBilling.txtUnitPrice5.Text))
        frmBilling.txtTotal.Text = (Val(frmBilling.txtAmount1.Text) + Val(frmBilling.txtAmount2.Text) + Val(frmBilling.txtAmount3.Text) + Val(frmBilling.txtAmount4.Text) + Val(frmBilling.txtAmount5.Text))

        frmBilling.txtName.Text = frmAccountInformation.txtName.Text

        Me.Hide()

    End Sub
End Class