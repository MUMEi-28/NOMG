<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mclAppointments = New System.Windows.Forms.MonthCalendar()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mclAppointments
        '
        Me.mclAppointments.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.mclAppointments.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mclAppointments.Location = New System.Drawing.Point(113, 91)
        Me.mclAppointments.Name = "mclAppointments"
        Me.mclAppointments.TabIndex = 2
        Me.mclAppointments.TrailingForeColor = System.Drawing.Color.Gray
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Nunito ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(463, 674)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(359, 48)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 801)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.mclAppointments)
        Me.Name = "frmCalendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mclAppointments As MonthCalendar
    Friend WithEvents btnBack As Button
End Class
