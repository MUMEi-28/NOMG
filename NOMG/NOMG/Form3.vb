Public Class frmRoutine
    Dim intI As Integer
    Dim bolHaveCheckedListCA As Boolean = False
    Dim bolHaveChecked As Boolean = False
    Public Sub New()
        InitializeComponent()
        btnBack.BackColor = Color.FromArgb(255, 79, 45, 57)
        btnBack.ForeColor = Color.FromArgb(255, 255, 255, 255)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)

        For Each appointment In frmAccountInformation.currentUser.GetListAppointments
            clbAppointments.Items.Add(appointment)
        Next

        '  If bolHaveCheckedListCA Then
        ' For Each appointment In frmAccountInformation.currentUser.GetListAppointments
        ' clbAppointments.SetItemChecked(frmAccountInformation.currentUser.GetListCheckedAppointments(intI), True)
        ' Next
        ' End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

        ' intI = 0
        ' While intI < clbAppointments.CheckedIndices.Count
        ' frmAccountInformation.currentUser.GetListCheckedAppointments(intI) = clbAppointments.CheckedIndices(intI)
        ' intI = intI + 1
        ' bolHaveCheckedListCA = True
        ' End While

        intI = 0
        While intI < clbAppointments.Items.Count
            clbAppointments.Items.Remove(0)
            intI = intI + 1
        End While
    End Sub

    Private Sub clbAppointments_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppointments.ItemCheck
        If clbAppointments.Items(e.Index) > Date.Today.Date Then
            MsgBox("The appointment has not yet finished because its date is on the future.")
            e.NewValue = CheckState.Unchecked
        Else
            bolHaveChecked = True
        End If

        If clbAppointments.Items.Count <> frmAccountInformation.currentUser.GetListAppointments.Count Then
            frmMain.lblAppointment.Text = "Next Check Up:" & vbCrLf & getNextCheckUp()
        Else
            frmMain.lblAppointment.Text = "Check Ups Done"
        End If
    End Sub

    Public Function getNextCheckUp() As Date
        Dim intI As Integer = 0
        If bolHaveChecked Then
            While intI < clbAppointments.Items.Count
                If clbAppointments.CheckedItems(intI) = clbAppointments.Items(intI) Then
                    intI = intI + 1
                Else
                    Return clbAppointments.Items(intI)
                End If

                If clbAppointments.CheckedItems.Count = intI Then
                    Return clbAppointments.Items(intI)
                End If
            End While
        Else
            Return clbAppointments.Items(0)
        End If
    End Function
End Class