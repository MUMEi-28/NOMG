<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRoutine
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.clbAppointments = New System.Windows.Forms.CheckedListBox()
        Me.ptbAppointments = New System.Windows.Forms.PictureBox()
        Me.cbMed1 = New System.Windows.Forms.CheckBox()
        Me.cbMed2 = New System.Windows.Forms.CheckBox()
        Me.cbMed3 = New System.Windows.Forms.CheckBox()
        Me.cbMed4 = New System.Windows.Forms.CheckBox()
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(343, 547)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(274, 39)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'clbAppointments
        '
        Me.clbAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAppointments.FormattingEnabled = True
        Me.clbAppointments.Location = New System.Drawing.Point(26, 269)
        Me.clbAppointments.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clbAppointments.Name = "clbAppointments"
        Me.clbAppointments.Size = New System.Drawing.Size(272, 214)
        Me.clbAppointments.TabIndex = 3
        '
        'ptbAppointments
        '
        Me.ptbAppointments.Image = Global.NOMG.My.Resources.Resources._5
        Me.ptbAppointments.Location = New System.Drawing.Point(0, 1)
        Me.ptbAppointments.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ptbAppointments.Name = "ptbAppointments"
        Me.ptbAppointments.Size = New System.Drawing.Size(960, 650)
        Me.ptbAppointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAppointments.TabIndex = 1
        Me.ptbAppointments.TabStop = False
        '
        'cbMed1
        '
        Me.cbMed1.AutoSize = True
        Me.cbMed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed1.Location = New System.Drawing.Point(359, 284)
        Me.cbMed1.Name = "cbMed1"
        Me.cbMed1.Size = New System.Drawing.Size(98, 29)
        Me.cbMed1.TabIndex = 4
        Me.cbMed1.Text = "Flu Vac"
        Me.cbMed1.UseVisualStyleBackColor = True
        '
        'cbMed2
        '
        Me.cbMed2.AutoSize = True
        Me.cbMed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed2.Location = New System.Drawing.Point(359, 327)
        Me.cbMed2.Name = "cbMed2"
        Me.cbMed2.Size = New System.Drawing.Size(134, 29)
        Me.cbMed2.TabIndex = 5
        Me.cbMed2.Text = "Iron Vitamin"
        Me.cbMed2.UseVisualStyleBackColor = True
        '
        'cbMed3
        '
        Me.cbMed3.AutoSize = True
        Me.cbMed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed3.Location = New System.Drawing.Point(359, 370)
        Me.cbMed3.Name = "cbMed3"
        Me.cbMed3.Size = New System.Drawing.Size(127, 29)
        Me.cbMed3.TabIndex = 6
        Me.cbMed3.Text = "B Complex"
        Me.cbMed3.UseVisualStyleBackColor = True
        '
        'cbMed4
        '
        Me.cbMed4.AutoSize = True
        Me.cbMed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed4.Location = New System.Drawing.Point(359, 414)
        Me.cbMed4.Name = "cbMed4"
        Me.cbMed4.Size = New System.Drawing.Size(73, 29)
        Me.cbMed4.TabIndex = 7
        Me.cbMed4.Text = "DHA"
        Me.cbMed4.UseVisualStyleBackColor = True
        '
        'frmRoutine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 635)
        Me.Controls.Add(Me.cbMed4)
        Me.Controls.Add(Me.cbMed3)
        Me.Controls.Add(Me.cbMed2)
        Me.Controls.Add(Me.cbMed1)
        Me.Controls.Add(Me.clbAppointments)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbAppointments)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmRoutine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Routine"
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbAppointments As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents clbAppointments As CheckedListBox
    Friend WithEvents cbMed1 As CheckBox
    Friend WithEvents cbMed2 As CheckBox
    Friend WithEvents cbMed3 As CheckBox
    Friend WithEvents cbMed4 As CheckBox
End Class
