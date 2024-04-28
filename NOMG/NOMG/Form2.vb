Public Class Form2
    Public listAppointment As New List(Of Date)
    Dim dteLMC As Date
    Dim dteTracker As Date

    Private Sub dtpFirstAppointment_ValueChanged(sender As Object, e As EventArgs) Handles dtpFirstAppointment.ValueChanged
        If dtpFirstAppointment.Value.DayOfWeek = 0 Or dtpFirstAppointment.Value.DayOfWeek = 1 Then
            MsgBox("The date chosen is not allowed. Sunday and Monday are not available. Please pick again.", vbRetryCancel + vbCritical, "Error")
        ElseIf dtpFirstAppointment.Value.Date < Date.Today.Date Then
            MsgBox("Dates in the past can not be chosen. Please pick again.", vbRetryCancel + vbCritical, "Error")
        Else
            listAppointment(0) = dtpFirstAppointment.Value.Date
            dtpFirstAppointment.Enabled = False
        End If
    End Sub

    Private Sub btnViewAppointments_Click(sender As Object, e As EventArgs) Handles btnViewAppointments.Click
        dteTracker = listAppointment(0).Date

        Do While dteTracker <= dteLMC.AddMonths(9)
            If dteTracker <= dteLMC.AddMonths(3) Then
                If dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(30).DayOfWeek = 0 Or dteTracker.AddDays(30).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If
                dteTracker = dteTracker.AddDays(30)
                listAppointment.Add(dteTracker)
            ElseIf dteTracker <= dteLMC.AddMonths(6) Then
                If dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(20).DayOfWeek = 0 Or dteTracker.AddDays(20).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If
                dteTracker = dteTracker.AddDays(20)
                listAppointment.Add(dteTracker)
            Else
                If dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1 Then
                    Do While dteTracker.AddDays(10).DayOfWeek = 0 Or dteTracker.AddDays(10).DayOfWeek = 1
                        dteTracker = dteTracker.AddDays(1)
                    Loop
                End If
                dteTracker = dteTracker.AddDays(10)
                listAppointment.Add(dteTracker)
            End If
        Loop

        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub dtpLMC_ValueChanged(sender As Object, e As EventArgs) Handles dtpLMC.ValueChanged
        If dtpLMC.Value.Date > Date.Today.Date Then
            MsgBox("The date chosen is not allowed. Last Menstrual Cycle is not in the future. Please pick again.", vbRetryCancel + vbCritical, "Error")
        Else
            dteLMC = dtpLMC.Value.Date
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listAppointment.Add(dtpFirstAppointment.Value.Date)
        dteLMC = dtpLMC.Value.Date

    End Sub

    Private Sub btnViewDoctors_Click(sender As Object, e As EventArgs) Handles btnViewDoctors.Click
        Form4.Show()
        Me.Hide()

    End Sub
End Class