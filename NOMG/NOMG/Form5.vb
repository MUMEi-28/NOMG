Public Class frmCalendar
    Public Sub New()
        InitializeComponent()
        Me.BackColor = Color.FromArgb(255, 39, 36, 46)

        For Each appointment In frmAccountInformation.strCurrentUser.GetListAppointments
            mclAppointments.AddBoldedDate(appointment)
        Next

        btnBack.BackColor = Color.FromArgb(255, 79, 45, 57)
        btnBack.ForeColor = Color.FromArgb(255, 255, 255, 255)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmRoutine.Show()
        Me.Hide()
    End Sub

End Class