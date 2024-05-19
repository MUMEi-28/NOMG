Imports System.Runtime.CompilerServices

Public Class frmRoutine
    Dim intI As Integer
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
        ' Change comments into codes if the appointments can only be finished on the said date
        ' If clbAppointments.Items(e.Index) > Date.Today.Date Then
        ' MsgBox("The appointment can not be finished because its date is on the future.")
        ' e.NewValue = CheckState.Unchecked
        If e.NewValue = False Then
            MsgBox("Reset unavailable", vbOKCancel + vbCritical, "Error")
            e.NewValue = CheckState.Checked
        End If

        ' Checks if clbAppointments has a value so the code knows when if it can access a previous date
        If e.Index <> 0 Then
            If clbAppointments.GetItemChecked(e.Index - 1) = False Then
                MsgBox("The appointment can not be finished because the previous check up is not yet finished.", vbOKCancel + vbCritical, "Error")
                e.NewValue = CheckState.Unchecked
            Else
                If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = e.Index Then
                    frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                    frmAccountInformation.currentUser.GetListIsPaid.Add(False)

                    ' Unchecking of flu vac after it has been added to the bill and a new appointment is set
                    If cbxMed1.Checked Then
                        frmAccountInformation.currentUser.SetCBX1(frmAccountInformation.currentUser.GetCBX1() + 1)
                        If frmAccountInformation.currentUser.GetCBX1() > 1 Then
                            cbxMed1.Checked = False
                        End If
                    End If

                    If frmAccountInformation.currentUser.GetListAppointments.Count <> e.Index + 1 Then
                        ' Updates the billing for any finished or pressed appointment except the last
                        frmBilling.MainBilling()
                    Else
                        ' Updates the billing if the last appointment is clicked or completed
                        frmBilling.SetCheckUpBill()
                        frmBilling.txtPendingAmount.Text = frmAccountInformation.currentUser.GetBill
                        frmAccountInformation.currentUser.SetBill(frmAccountInformation.currentUser.GetBill + Val(frmBilling.txtAmount1.Text))
                        frmBilling.txtTotal.Text = frmAccountInformation.currentUser.GetBill
                    End If

                    frmMain.blnSavedBilling = False
                Else
                    ' Checking in the checkedlistbox previously checked appointments
                    frmAccountInformation.currentUser.GetListCheckedAppointments(e.Index) = e.Index
                End If
            End If
        Else
            If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = e.Index Then
                frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                frmAccountInformation.currentUser.GetListIsPaid.Add(False)

                ' Unchecking of flu vac after it has been added to the bill and a new appointment is set
                If cbxMed1.Checked Then
                    frmAccountInformation.currentUser.SetCBX1(frmAccountInformation.currentUser.GetCBX1() + 1)
                    If frmAccountInformation.currentUser.GetCBX1() > 1 Then
                        cbxMed1.Checked = False
                    End If
                End If

                frmBilling.MainBilling()
                frmMain.blnSavedBilling = False
            Else
                ' Checking in the checkedlistbox previously checked appointments
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
            frmMain.dtpFirstAppointment.Hide()
        Else
            frmMain.lblAppointment.Text = "Next Check Up: " & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(frmAccountInformation.currentUser.GetListCheckedAppointments.Count)
            frmMain.dtpFirstAppointment.Hide()
        End If
    End Sub

    Public Sub DailyMeds()
        If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = 0 Or frmAccountInformation.currentUser.GetListCheckedAppointments.Count = frmAccountInformation.currentUser.GetListAppointments.Count Or frmAccountInformation.currentUser.GetBill = 0 Then
            cbxMed2.Checked = False
            cbxMed3.Checked = False
            cbxMed4.Checked = False
        ElseIf frmAccountInformation.currentUser.GetListCheckedAppointments.Count > 0 Then
            cbxMed2.Checked = True
            cbxMed3.Checked = True
            cbxMed4.Checked = True
        End If
    End Sub

    Private Sub cbxMed1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMed1.CheckedChanged
        ' Flu Vac is added to the bill when an appointment is finished (clicked) after the flu vac has been selected
        If cbxMed1.Checked = True Then
            frmAccountInformation.currentUser.SetClickedFV(True)
            cbxMed1.Enabled = False
        End If
    End Sub
End Class