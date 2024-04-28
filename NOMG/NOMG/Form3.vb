Public Class Form3
    Public Sub New()
        InitializeComponent()
        For Each appointment In Form2.listAppointment
            clbAppointments.Items.Add(appointment)
        Next

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class