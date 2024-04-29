Public Class frmDoctors
    Public lblFrmDoctors As New List(Of Label)
    Public pnlFrmDoctors As New List(Of Panel)
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Hide()

    End Sub

    Public Sub New()
        InitializeComponent()
        Me.BackColor = Color.FromArgb(255, 39, 36, 46)

        btnBack.BackColor = Color.FromArgb(255, 79, 45, 57)
        btnBack.ForeColor = Color.FromArgb(255, 255, 255, 255)
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderColor = Color.FromArgb(255, 79, 45, 57)

        pnlFrmDoctors.Add(pnlDr1)
        pnlFrmDoctors.Add(pnlDr2)
        pnlFrmDoctors.Add(pnlDr3)
        For Each pnl In pnlFrmDoctors
            pnl.BackColor = Color.FromArgb(255, 79, 45, 57)
        Next

        lblAdditionalInfo.ForeColor = Color.FromArgb(255, 244, 238, 224)
        lblAdditionalInfo.BackColor = Color.FromArgb(255, 39, 36, 46)

        lblFrmDoctors.Add(lblDr1)
        lblFrmDoctors.Add(lblDr1Name)
        lblFrmDoctors.Add(lblDr1Age)
        lblFrmDoctors.Add(lblDr1Gender)
        lblFrmDoctors.Add(lblDr1Address)
        lblFrmDoctors.Add(lblDr1Educ)

        lblFrmDoctors.Add(lblDr2)
        lblFrmDoctors.Add(lblDr2Name)
        lblFrmDoctors.Add(lblDr2Age)
        lblFrmDoctors.Add(lblDr2Gender)
        lblFrmDoctors.Add(lblDr2Address)
        lblFrmDoctors.Add(lblDr2Educ)

        lblFrmDoctors.Add(lblDr3)
        lblFrmDoctors.Add(lblDr3Name)
        lblFrmDoctors.Add(lblDr3Age)
        lblFrmDoctors.Add(lblDr3Gender)
        lblFrmDoctors.Add(lblDr3Address)
        lblFrmDoctors.Add(lblDr3Educ)

        For Each lbl In lblFrmDoctors
            lbl.ForeColor = Color.FromArgb(255, 244, 238, 224)
            lbl.BackColor = Color.FromArgb(255, 79, 45, 57)
        Next
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()

    End Sub
End Class