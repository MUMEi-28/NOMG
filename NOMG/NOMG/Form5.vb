Public Class frmCalendar
    Public Sub New()
        InitializeComponent()
        mclAppointments.SetCalendarDimensions(2, 2)

        For Each appointment In frmMain.listAppointment
            mclAppointments.AddBoldedDate(appointment)
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAppointments.Show()
        Me.Hide()

    End Sub
End Class