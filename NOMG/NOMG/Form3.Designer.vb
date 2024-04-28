<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.ptbAppointments = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.clbAppointments = New System.Windows.Forms.CheckedListBox()
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbAppointments
        '
        Me.ptbAppointments.BackgroundImage = Global.NOMG.My.Resources.Resources.View_Appointments
        Me.ptbAppointments.Location = New System.Drawing.Point(-8, -41)
        Me.ptbAppointments.Name = "ptbAppointments"
        Me.ptbAppointments.Size = New System.Drawing.Size(1280, 720)
        Me.ptbAppointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbAppointments.TabIndex = 1
        Me.ptbAppointments.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(34, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'clbAppointments
        '
        Me.clbAppointments.FormattingEnabled = True
        Me.clbAppointments.Location = New System.Drawing.Point(838, 242)
        Me.clbAppointments.Name = "clbAppointments"
        Me.clbAppointments.Size = New System.Drawing.Size(251, 225)
        Me.clbAppointments.TabIndex = 3
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.clbAppointments)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbAppointments)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.ptbAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ptbAppointments As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents clbAppointments As CheckedListBox
End Class
