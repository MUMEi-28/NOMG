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
        Me.lblReminders = New System.Windows.Forms.Label()
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(457, 673)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(365, 48)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'clbAppointments
        '
        Me.clbAppointments.CheckOnClick = True
        Me.clbAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbAppointments.FormattingEnabled = True
        Me.clbAppointments.Location = New System.Drawing.Point(35, 331)
        Me.clbAppointments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clbAppointments.Name = "clbAppointments"
        Me.clbAppointments.Size = New System.Drawing.Size(361, 279)
        Me.clbAppointments.TabIndex = 3
        '
        'ptbAppointments
        '
        Me.ptbAppointments.Image = Global.NOMG.My.Resources.Resources.NOMG_UI_5_Updated
        Me.ptbAppointments.Location = New System.Drawing.Point(0, 1)
        Me.ptbAppointments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ptbAppointments.Name = "ptbAppointments"
        Me.ptbAppointments.Size = New System.Drawing.Size(1280, 800)
        Me.ptbAppointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAppointments.TabIndex = 1
        Me.ptbAppointments.TabStop = False
        '
        'cbMed1
        '
        Me.cbMed1.AutoSize = True
        Me.cbMed1.BackColor = System.Drawing.Color.Transparent
        Me.cbMed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed1.Location = New System.Drawing.Point(479, 352)
        Me.cbMed1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMed1.Name = "cbMed1"
        Me.cbMed1.Size = New System.Drawing.Size(128, 33)
        Me.cbMed1.TabIndex = 4
        Me.cbMed1.Text = "Flu Vac"
        Me.cbMed1.UseVisualStyleBackColor = False
        '
        'cbMed2
        '
        Me.cbMed2.AutoSize = True
        Me.cbMed2.BackColor = System.Drawing.Color.Transparent
        Me.cbMed2.Enabled = False
        Me.cbMed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed2.Location = New System.Drawing.Point(479, 403)
        Me.cbMed2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMed2.Name = "cbMed2"
        Me.cbMed2.Size = New System.Drawing.Size(182, 33)
        Me.cbMed2.TabIndex = 5
        Me.cbMed2.Text = "Iron Vitamin"
        Me.cbMed2.UseVisualStyleBackColor = False
        '
        'cbMed3
        '
        Me.cbMed3.AutoSize = True
        Me.cbMed3.BackColor = System.Drawing.Color.Transparent
        Me.cbMed3.Enabled = False
        Me.cbMed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed3.Location = New System.Drawing.Point(479, 456)
        Me.cbMed3.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMed3.Name = "cbMed3"
        Me.cbMed3.Size = New System.Drawing.Size(168, 33)
        Me.cbMed3.TabIndex = 6
        Me.cbMed3.Text = "B Complex"
        Me.cbMed3.UseVisualStyleBackColor = False
        '
        'cbMed4
        '
        Me.cbMed4.AutoSize = True
        Me.cbMed4.BackColor = System.Drawing.Color.Transparent
        Me.cbMed4.Enabled = False
        Me.cbMed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMed4.Location = New System.Drawing.Point(479, 510)
        Me.cbMed4.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMed4.Name = "cbMed4"
        Me.cbMed4.Size = New System.Drawing.Size(91, 33)
        Me.cbMed4.TabIndex = 7
        Me.cbMed4.Text = "DHA"
        Me.cbMed4.UseVisualStyleBackColor = False
        '
        'lblReminders
        '
        Me.lblReminders.AutoSize = True
        Me.lblReminders.BackColor = System.Drawing.Color.Transparent
        Me.lblReminders.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReminders.Location = New System.Drawing.Point(871, 352)
        Me.lblReminders.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReminders.Name = "lblReminders"
        Me.lblReminders.Size = New System.Drawing.Size(341, 182)
        Me.lblReminders.TabIndex = 9
        Me.lblReminders.Text = "Iron Vitamin once a day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B Complex once a day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DHA 3 times a day" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Flu Vac o" &
    "nce during pregnancy"
        '
        'frmRoutine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 782)
        Me.Controls.Add(Me.lblReminders)
        Me.Controls.Add(Me.cbMed4)
        Me.Controls.Add(Me.cbMed3)
        Me.Controls.Add(Me.cbMed2)
        Me.Controls.Add(Me.cbMed1)
        Me.Controls.Add(Me.clbAppointments)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbAppointments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
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
    Friend WithEvents lblReminders As Label
End Class
