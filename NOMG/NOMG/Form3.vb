Public Class frmRoutine
    Public btnfrmRoutine As New List(Of Button)
    Dim intI As Integer = 0
    Public Sub New()
        InitializeComponent()

        For Each appointment In frmMain.listAppointment
            clbAppointments.Items.Add(appointment)
        Next

        btnfrmRoutine.Add(btnViewCalendar)
        btnfrmRoutine.Add(btnBack)
        For Each btn In btnfrmRoutine
            btn.BackColor = Color.FromArgb(255, 79, 45, 57)
            btn.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)
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

    Private Sub frmRoutine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class