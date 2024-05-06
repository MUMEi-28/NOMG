Public Class frmRoutine
    Dim intI As Integer
    Public Sub New()
        InitializeComponent()
        btnBack.BackColor = Color.FromArgb(255, 79, 45, 57)
        btnBack.ForeColor = Color.FromArgb(255, 255, 255, 255)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)

        If frmAccountInformation.currentUser.GetBolHaveCheck() Then
            For Each appointment In frmAccountInformation.currentUser.GetListAppointments
                clbAppointments.SetItemChecked(frmAccountInformation.currentUser.GetListCheckedAppointments(intI), True)
            Next
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

        Dim total As Integer = clbAppointments.Items.Count
        While total <> 0
            clbAppointments.Items.RemoveAt(0)
            total = total - 1
        End While
    End Sub

    Private Sub clbAppointments_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppointments.ItemCheck
        ' If clbAppointments.Items(e.Index) > Date.Today.Date Then
        ' MsgBox("The appointment can not be finished because its date is on the future.")
        ' e.NewValue = CheckState.Unchecked

        If e.Index <> -1 Then
            If e.Index <> 0 Then
                If clbAppointments.Items(e.Index - 1).GetItemCheckState = CheckState.Unchecked Then
                    MsgBox("The appointment can not be finished because the previous check up is not yet finished.")
                    e.NewValue = CheckState.Unchecked
                Else
                    frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                    frmAccountInformation.currentUser.SetBolHaveCheck(True)
                End If
            Else
                frmAccountInformation.currentUser.GetListCheckedAppointments.Add(e.Index)
                frmAccountInformation.currentUser.SetBolHaveCheck(True)
            End If

            If frmAccountInformation.currentUser.GetListCheckedAppointments.Count <> frmAccountInformation.currentUser.GetListAppointments.Count Then
                frmMain.lblAppointment.Text = "Next Check Up:" & vbCrLf & getNextCheckUp()
            Else
                frmMain.lblAppointment.Text = "All Check Ups" & vbCrLf & "are done."
            End If
        End If
    End Sub

    Public Function getNextCheckUp() As Date
        Dim intI As Integer = 0
        If frmAccountInformation.currentUser.GetBolHaveCheck() Then
            While intI < frmAccountInformation.currentUser.GetListAppointments.Count

                If intI = frmAccountInformation.currentUser.GetListCheckedAppointments.Count Then
                    Return frmAccountInformation.currentUser.GetListAppointments(intI)
                End If

                MsgBox(clbAppointments.GetItemChecked(0))
                If clbAppointments.CheckedItems(intI) = frmAccountInformation.currentUser.GetListAppointments(intI) Then
                    intI = intI + 1
                Else
                    Return frmAccountInformation.currentUser.GetListAppointments(intI)
                End If
            End While
        Else
            Return frmAccountInformation.currentUser.GetListAppointments(0)
        End If
    End Function
End Class