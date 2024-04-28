Public Class frmAppointments
    Public Sub New()
        InitializeComponent()
        For Each appointment In frmMain.listAppointment
            clbAppointments.Items.Add(appointment)
        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

    End Sub

    Private Sub btnViewCalendar_Click(sender As Object, e As EventArgs) Handles btnViewCalendar.Click
        frmCalendar.Show()
        Me.Hide()

    End Sub
End Class