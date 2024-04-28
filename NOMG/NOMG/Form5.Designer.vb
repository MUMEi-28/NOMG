<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ptbMainDr1 = New System.Windows.Forms.PictureBox()
        Me.mclAppointments = New System.Windows.Forms.MonthCalendar()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.ptbMainDr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbMainDr1
        '
        Me.ptbMainDr1.Image = Global.NOMG.My.Resources.Resources.View_Calendar
        Me.ptbMainDr1.Location = New System.Drawing.Point(-5, -35)
        Me.ptbMainDr1.Name = "ptbMainDr1"
        Me.ptbMainDr1.Size = New System.Drawing.Size(1280, 720)
        Me.ptbMainDr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbMainDr1.TabIndex = 1
        Me.ptbMainDr1.TabStop = False
        '
        'mclAppointments
        '
        Me.mclAppointments.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.mclAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mclAppointments.Location = New System.Drawing.Point(371, 180)
        Me.mclAppointments.Name = "mclAppointments"
        Me.mclAppointments.TabIndex = 2
        Me.mclAppointments.TrailingForeColor = System.Drawing.Color.Gray
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(34, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.mclAppointments)
        Me.Controls.Add(Me.ptbMainDr1)
        Me.Name = "frmCalendar"
        Me.Text = "Calendar"
        CType(Me.ptbMainDr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ptbMainDr1 As PictureBox
    Friend WithEvents mclAppointments As MonthCalendar
    Friend WithEvents btnBack As Button
End Class
