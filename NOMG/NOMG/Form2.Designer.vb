<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewAppointments = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpLMC = New System.Windows.Forms.DateTimePicker()
        Me.dtpFirstAppointment = New System.Windows.Forms.DateTimePicker()
        Me.btnViewDoctors = New System.Windows.Forms.Button()
        Me.ptbMainDr1 = New System.Windows.Forms.PictureBox()
        CType(Me.ptbMainDr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(34, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 42)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(282, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Set First Appointment:"
        '
        'btnViewAppointments
        '
        Me.btnViewAppointments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAppointments.Location = New System.Drawing.Point(238, 295)
        Me.btnViewAppointments.Name = "btnViewAppointments"
        Me.btnViewAppointments.Size = New System.Drawing.Size(276, 42)
        Me.btnViewAppointments.TabIndex = 4
        Me.btnViewAppointments.Text = "View Appointments"
        Me.btnViewAppointments.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 630)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Menstrual Cycle:"
        '
        'dtpLMC
        '
        Me.dtpLMC.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLMC.Location = New System.Drawing.Point(218, 626)
        Me.dtpLMC.Name = "dtpLMC"
        Me.dtpLMC.Size = New System.Drawing.Size(303, 28)
        Me.dtpLMC.TabIndex = 7
        '
        'dtpFirstAppointment
        '
        Me.dtpFirstAppointment.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFirstAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFirstAppointment.Location = New System.Drawing.Point(207, 234)
        Me.dtpFirstAppointment.Name = "dtpFirstAppointment"
        Me.dtpFirstAppointment.Size = New System.Drawing.Size(342, 28)
        Me.dtpFirstAppointment.TabIndex = 8
        '
        'btnViewDoctors
        '
        Me.btnViewDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDoctors.Location = New System.Drawing.Point(883, 419)
        Me.btnViewDoctors.Name = "btnViewDoctors"
        Me.btnViewDoctors.Size = New System.Drawing.Size(137, 35)
        Me.btnViewDoctors.TabIndex = 9
        Me.btnViewDoctors.Text = "View Doctors"
        Me.btnViewDoctors.UseVisualStyleBackColor = True
        '
        'ptbMainDr1
        '
        Me.ptbMainDr1.Image = Global.NOMG.My.Resources.Resources.V3_Main___Doctor_1
        Me.ptbMainDr1.Location = New System.Drawing.Point(-9, -37)
        Me.ptbMainDr1.Name = "ptbMainDr1"
        Me.ptbMainDr1.Size = New System.Drawing.Size(1280, 720)
        Me.ptbMainDr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbMainDr1.TabIndex = 0
        Me.ptbMainDr1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btnViewDoctors)
        Me.Controls.Add(Me.dtpFirstAppointment)
        Me.Controls.Add(Me.dtpLMC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnViewAppointments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ptbMainDr1)
        Me.Name = "frmMain"
        Me.Text = "Main"
        CType(Me.ptbMainDr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewAppointments As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpLMC As DateTimePicker
    Friend WithEvents dtpFirstAppointment As DateTimePicker
    Friend WithEvents btnViewDoctors As Button
    Friend WithEvents ptbMainDr1 As PictureBox
End Class
