﻿Public Class frmRoutine
    Dim intI As Integer = 0
    Public Sub New()
        InitializeComponent()
        btnBack.BackColor = Color.FromArgb(255, 79, 45, 57)
        btnBack.ForeColor = Color.FromArgb(255, 255, 255, 255)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)

        For Each appointment In frmAccountInformation.strCurrentUser.GetListAppointments
            clbAppointments.Items.Add(appointment)
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

    End Sub

    Private Sub clbAppointments_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppointments.ItemCheck
        If clbAppointments.Items(e.Index) > Date.Today.Date Then
            MsgBox("The appointment has not yet finished because its date is on the future.")
            e.NewValue = CheckState.Unchecked
        End If
    End Sub

    Public Function getNextCheckUp() As Date
        Dim intI As Integer = 0
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
    End Function

    Private Sub clbAppointments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbAppointments.SelectedIndexChanged
        If clbAppointments.Items.Count <> frmAccountInformation.strCurrentUser.GetListAppointments.Count Then
            frmMain.lblAppointment.Text = "Next Check Up:" & vbCrLf & getNextCheckUp()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbMed1.CheckedChanged

    End Sub
End Class