Imports System.Runtime.CompilerServices

Public Class frmRoutine
    Dim intI As Integer
    Dim intFluVacCounter As Integer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

        intI = 0
        Dim Total As Integer = clbAppointments.Items.Count
        While intI < Total
            clbAppointments.Items.RemoveAt(0)
            intI = intI + 1
        End While
    End Sub

    Private Sub clbAppointments_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppointments.ItemCheck
        ' If clbAppointments.Items(e.Index) > Date.Today.Date Then
        ' MsgBox("The appointment can not be finished because its date is on the future.")
        ' e.NewValue = CheckState.Unchecked

        If e.Index <> 0 Then
            If clbAppointments.GetItemChecked(e.Index - 1) = False Then
                MsgBox("The appointment can not be finished because the previous check up is not yet finished.")
                e.NewValue = CheckState.Unchecked
            Else
                If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = e.Index Then
                    frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                    frmAccountInformation.currentUser.GetListIsPaid.Add(False)

                    If frmAccountInformation.currentUser.GetClickedFluVac = True Then
                        intFluVacCounter = intFluVacCounter + 1
                        If intFluVacCounter < 1 Then
                            frmAccountInformation.currentUser.SetClickedFluVac(False)
                        End If
                    End If

                    If frmAccountInformation.currentUser.GetListAppointments.Count <> e.Index + 1 Then
                        frmBilling.MainBilling()
                    Else
                        frmBilling.setCheckUpBill()
                        frmBilling.txtPendingAmount.Text = frmAccountInformation.currentUser.GetBill
                        frmAccountInformation.currentUser.SetBill(frmAccountInformation.currentUser.GetBill + Val(frmBilling.txtAmount1.Text))
                        frmBilling.txtTotal.Text = frmAccountInformation.currentUser.GetBill
                    End If
                    frmMain.blnSavedBilling = False
                Else
                    frmAccountInformation.currentUser.GetListCheckedAppointments(e.Index) = e.Index
                End If
            End If
        Else
            If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = e.Index Then
                frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                frmAccountInformation.currentUser.GetListIsPaid.Add(False)


                If frmAccountInformation.currentUser.GetClickedFluVac = True Then
                    intFluVacCounter = intFluVacCounter + 1
                    If intFluVacCounter < 1 Then
                        frmAccountInformation.currentUser.SetClickedFluVac(False)
                        cbMed1.Checked = False
                    End If
                End If

                If frmAccountInformation.currentUser.GetListAppointments.Count <> e.Index + 1 Then
                    frmBilling.MainBilling()

                    cbMed2.Checked = False
                    cbMed3.Checked = False
                    cbMed4.Checked = False
                Else
                    frmBilling.setCheckUpBill()
                    frmBilling.txtPendingAmount.Text = frmAccountInformation.currentUser.GetBill
                    frmAccountInformation.currentUser.SetBill(frmAccountInformation.currentUser.GetBill + Val(frmBilling.txtAmount1))
                    frmBilling.txtTotal.Text = frmAccountInformation.currentUser.GetBill
                End If
            Else
                frmAccountInformation.currentUser.GetListCheckedAppointments(e.Index) = e.Index
            End If
        End If

        If e.Index = clbAppointments.Items.Count - 1 Then
            frmMain.lblAppointment.Text = "All Check Ups" & vbCrLf & "are done."
        Else
            frmMain.lblAppointment.Text = "Next Check Up:" & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(e.Index + 1)
        End If

        DailyMeds()
    End Sub

    Public Sub getNextCheckUp()
        If frmAccountInformation.currentUser.GetListAppointments.Count = 0 Then
            frmMain.lblAppointment.Text = "First Check Up:"
            frmMain.dtpFirstAppointment.Show()
        ElseIf frmAccountInformation.currentUser.GetListCheckedAppointments.Count = frmAccountInformation.currentUser.GetListAppointments.Count Then
            frmMain.lblAppointment.Text = "All Check Ups" & vbCrLf & "are done."
        Else
            frmMain.lblAppointment.Text = "Next Check Up: " & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(frmAccountInformation.currentUser.GetListCheckedAppointments.Count)
        End If
    End Sub

    Public Sub DailyMeds()
        If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = frmAccountInformation.currentUser.GetListAppointments.Count Or frmAccountInformation.currentUser.GetBill = 0 Then
            cbMed2.Checked = False
            cbMed3.Checked = False
            cbMed4.Checked = False
        ElseIf frmAccountInformation.currentUser.GetListCheckedAppointments.Count > 0 Then
            cbMed2.Checked = True
            cbMed3.Checked = True
            cbMed4.Checked = True
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        DailyMeds()

        If frmAccountInformation.currentUser.GetHadFluVac Then
            cbMed1.Enabled = False
        End If
    End Sub

    Private Sub cbMed1_CheckedChanged(sender As Object, e As EventArgs) Handles cbMed1.CheckedChanged
        frmAccountInformation.currentUser.SetClickedFluVac(True)
    End Sub
End Class