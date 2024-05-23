<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountInformation_Continuation
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ptbDr = New System.Windows.Forms.PictureBox()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.pnlMain = New System.Windows.Forms.Panel()
		Me.lblCycle = New System.Windows.Forms.Label()
		Me.dtpLMC = New System.Windows.Forms.DateTimePicker()
		Me.txtFirstBaby = New System.Windows.Forms.TextBox()
		Me.txtAge = New System.Windows.Forms.TextBox()
		Me.btnDoctorChoosing = New System.Windows.Forms.Button()
		Me.btnBackToStart = New System.Windows.Forms.Button()
		Me.lblAdditonalInfo = New System.Windows.Forms.Label()
		Me.lblBaby = New System.Windows.Forms.Label()
		Me.lblGesAge = New System.Windows.Forms.Label()
		Me.txtGasAge = New System.Windows.Forms.TextBox()
		Me.lblAge = New System.Windows.Forms.Label()
		CType(Me.ptbDr, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(191, 22)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(148, 46)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "NOMG"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ptbDr
		'
		Me.ptbDr.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ptbDr.Image = Global.NOMG.My.Resources.Resources.drLogin_2
		Me.ptbDr.Location = New System.Drawing.Point(489, -15)
		Me.ptbDr.Name = "ptbDr"
		Me.ptbDr.Size = New System.Drawing.Size(521, 765)
		Me.ptbDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.ptbDr.TabIndex = 12
		Me.ptbDr.TabStop = False
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblTitle.Location = New System.Drawing.Point(194, 19)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(148, 46)
		Me.lblTitle.TabIndex = 13
		Me.lblTitle.Text = "NOMG"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pnlMain
		'
		Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.pnlMain.Controls.Add(Me.lblCycle)
		Me.pnlMain.Controls.Add(Me.dtpLMC)
		Me.pnlMain.Controls.Add(Me.txtFirstBaby)
		Me.pnlMain.Controls.Add(Me.txtAge)
		Me.pnlMain.Controls.Add(Me.btnDoctorChoosing)
		Me.pnlMain.Controls.Add(Me.btnBackToStart)
		Me.pnlMain.Controls.Add(Me.lblAdditonalInfo)
		Me.pnlMain.Controls.Add(Me.lblBaby)
		Me.pnlMain.Controls.Add(Me.lblGesAge)
		Me.pnlMain.Controls.Add(Me.txtGasAge)
		Me.pnlMain.Controls.Add(Me.lblAge)
		Me.pnlMain.Location = New System.Drawing.Point(12, 101)
		Me.pnlMain.Name = "pnlMain"
		Me.pnlMain.Size = New System.Drawing.Size(474, 473)
		Me.pnlMain.TabIndex = 14
		'
		'lblCycle
		'
		Me.lblCycle.AutoSize = True
		Me.lblCycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCycle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblCycle.Location = New System.Drawing.Point(17, 121)
		Me.lblCycle.Name = "lblCycle"
		Me.lblCycle.Size = New System.Drawing.Size(139, 17)
		Me.lblCycle.TabIndex = 17
		Me.lblCycle.Text = "Last Menstrual Cycle"
		'
		'dtpLMC
		'
		Me.dtpLMC.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpLMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpLMC.Location = New System.Drawing.Point(20, 140)
		Me.dtpLMC.Margin = New System.Windows.Forms.Padding(2)
		Me.dtpLMC.Name = "dtpLMC"
		Me.dtpLMC.Size = New System.Drawing.Size(258, 24)
		Me.dtpLMC.TabIndex = 1
		'
		'txtFirstBaby
		'
		Me.txtFirstBaby.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtFirstBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirstBaby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtFirstBaby.Location = New System.Drawing.Point(172, 205)
		Me.txtFirstBaby.MaxLength = 1
		Me.txtFirstBaby.Name = "txtFirstBaby"
		Me.txtFirstBaby.Size = New System.Drawing.Size(134, 23)
		Me.txtFirstBaby.TabIndex = 3
		'
		'txtAge
		'
		Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtAge.Location = New System.Drawing.Point(20, 205)
		Me.txtAge.Name = "txtAge"
		Me.txtAge.Size = New System.Drawing.Size(134, 23)
		Me.txtAge.TabIndex = 2
		'
		'btnDoctorChoosing
		'
		Me.btnDoctorChoosing.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnDoctorChoosing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnDoctorChoosing.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDoctorChoosing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnDoctorChoosing.Location = New System.Drawing.Point(259, 321)
		Me.btnDoctorChoosing.Name = "btnDoctorChoosing"
		Me.btnDoctorChoosing.Size = New System.Drawing.Size(190, 59)
		Me.btnDoctorChoosing.TabIndex = 6
		Me.btnDoctorChoosing.Text = "Choose Doctor"
		Me.btnDoctorChoosing.UseVisualStyleBackColor = False
		'
		'btnBackToStart
		'
		Me.btnBackToStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
		Me.btnBackToStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.btnBackToStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBackToStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.btnBackToStart.Location = New System.Drawing.Point(18, 321)
		Me.btnBackToStart.Name = "btnBackToStart"
		Me.btnBackToStart.Size = New System.Drawing.Size(190, 59)
		Me.btnBackToStart.TabIndex = 5
		Me.btnBackToStart.Text = "BACK"
		Me.btnBackToStart.UseVisualStyleBackColor = False
		'
		'lblAdditonalInfo
		'
		Me.lblAdditonalInfo.AutoSize = True
		Me.lblAdditonalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAdditonalInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblAdditonalInfo.Location = New System.Drawing.Point(107, 43)
		Me.lblAdditonalInfo.Name = "lblAdditonalInfo"
		Me.lblAdditonalInfo.Size = New System.Drawing.Size(276, 31)
		Me.lblAdditonalInfo.TabIndex = 10
		Me.lblAdditonalInfo.Text = "Additional Information"
		Me.lblAdditonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblBaby
		'
		Me.lblBaby.AutoSize = True
		Me.lblBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBaby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblBaby.Location = New System.Drawing.Point(173, 185)
		Me.lblBaby.Name = "lblBaby"
		Me.lblBaby.Size = New System.Drawing.Size(102, 17)
		Me.lblBaby.TabIndex = 11
		Me.lblBaby.Text = "First Baby? y/n"
		'
		'lblGesAge
		'
		Me.lblGesAge.AutoSize = True
		Me.lblGesAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGesAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblGesAge.Location = New System.Drawing.Point(312, 185)
		Me.lblGesAge.Name = "lblGesAge"
		Me.lblGesAge.Size = New System.Drawing.Size(109, 17)
		Me.lblGesAge.TabIndex = 9
		Me.lblGesAge.Text = "Gestational Age"
		'
		'txtGasAge
		'
		Me.txtGasAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
		Me.txtGasAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGasAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.txtGasAge.Location = New System.Drawing.Point(315, 205)
		Me.txtGasAge.Name = "txtGasAge"
		Me.txtGasAge.Size = New System.Drawing.Size(134, 23)
		Me.txtGasAge.TabIndex = 4
		'
		'lblAge
		'
		Me.lblAge.AutoSize = True
		Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.lblAge.Location = New System.Drawing.Point(17, 185)
		Me.lblAge.Name = "lblAge"
		Me.lblAge.Size = New System.Drawing.Size(33, 17)
		Me.lblAge.TabIndex = 7
		Me.lblAge.Text = "Age"
		'
		'frmAccountInformation_Continuation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(987, 689)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.pnlMain)
		Me.Controls.Add(Me.ptbDr)
		Me.Controls.Add(Me.Label2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.Name = "frmAccountInformation_Continuation"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmAccountInformation_Continuation"
		CType(Me.ptbDr, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlMain.ResumeLayout(False)
		Me.pnlMain.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents ptbDr As PictureBox
	Friend WithEvents lblTitle As Label
	Friend WithEvents pnlMain As Panel
	Friend WithEvents lblCycle As Label
	Friend WithEvents dtpLMC As DateTimePicker
	Friend WithEvents txtFirstBaby As TextBox
	Friend WithEvents txtAge As TextBox
	Friend WithEvents btnDoctorChoosing As Button
	Friend WithEvents btnBackToStart As Button
	Friend WithEvents lblAdditonalInfo As Label
	Friend WithEvents lblBaby As Label
	Friend WithEvents lblGesAge As Label
	Friend WithEvents txtGasAge As TextBox
	Friend WithEvents lblAge As Label
End Class
