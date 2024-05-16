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
        ' If clbAppointments.Items(e.Index) > Date.Today.Date Then
        ' MsgBox("The appointment can not be finished because its date is on the future.")
        ' e.NewValue = CheckState.Unchecked
        If e.Index <> 0 Then
            If clbAppointments.GetItemChecked(e.Index - 1) = False Then
                MsgBox("The appointment can not be finished because the previous check up is not yet finished.")
                e.NewValue = CheckState.Unchecked
            Else
                If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = 0 Or e.Index = frmAccountInformation.currentUser.GetListCheckedAppointments.Count Then
                    frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                    frmAccountInformation.currentUser.GetListIsPaid.Add(False)
                Else
                    frmAccountInformation.currentUser.GetListCheckedAppointments(e.Index) = e.Index
                    frmAccountInformation.currentUser.GetListIsPaid(e.Index) = False
                End If
            End If
        Else
            If frmAccountInformation.currentUser.GetListCheckedAppointments.Count = 0 Or e.Index = frmAccountInformation.currentUser.GetListCheckedAppointments.Count Then
                frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                frmAccountInformation.currentUser.GetListIsPaid.Add(False)
            Else
                frmAccountInformation.currentUser.GetListCheckedAppointments(e.Index) = e.Index
                frmAccountInformation.currentUser.GetListIsPaid(e.Index) = False
            End If
        End If

        If e.Index = clbAppointments.Items.Count - 1 Then
            frmMain.lblAppointment.Text = "All Check Ups" & vbCrLf & "are done."
        Else
            frmMain.lblAppointment.Text = "Next Check Up:" & vbCrLf & frmAccountInformation.currentUser.GetListAppointments(e.Index + 1)
        End If
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

    Private Sub ptbAppointments_Click(sender As Object, e As EventArgs) Handles ptbAppointments.Click

    End Sub
End Class