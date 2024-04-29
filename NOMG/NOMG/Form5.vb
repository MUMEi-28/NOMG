Public Class frmCalendar
    Public Sub New()
        InitializeComponent()
        Me.BackColor = Color.FromArgb(255, 39, 36, 46)
        mclAppointments.SetCalendarDimensions(4, 3)

        For Each appointment In frmMain.listAppointment
            mclAppointments.AddBoldedDate(appointment)
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmRoutine.Show()
        Me.Hide()
    End Sub

End Class