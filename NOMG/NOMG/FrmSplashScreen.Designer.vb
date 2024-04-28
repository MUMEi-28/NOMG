<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplashScreen
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
		Me.components = New System.ComponentModel.Container()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.panelLoadingBG = New System.Windows.Forms.Panel()
		Me.panelLoading = New System.Windows.Forms.Panel()
		Me.SplashScreenTImer = New System.Windows.Forms.Timer(Me.components)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(39, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Label1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label2.Location = New System.Drawing.Point(103, 106)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(710, 63)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "New OB Master GYN Clinic"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'panelLoadingBG
		'
		Me.panelLoadingBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.panelLoadingBG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.panelLoadingBG.Location = New System.Drawing.Point(12, 463)
		Me.panelLoadingBG.Name = "panelLoadingBG"
		Me.panelLoadingBG.Size = New System.Drawing.Size(870, 31)
		Me.panelLoadingBG.TabIndex = 2
		'
		'panelLoading
		'
		Me.panelLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(121, Byte), Integer))
		Me.panelLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
		Me.panelLoading.Location = New System.Drawing.Point(12, 463)
		Me.panelLoading.Name = "panelLoading"
		Me.panelLoading.Size = New System.Drawing.Size(13, 31)
		Me.panelLoading.TabIndex = 3
		'
		'SplashScreenTImer
		'
		Me.SplashScreenTImer.Enabled = True
		Me.SplashScreenTImer.Interval = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
		Me.Label3.Location = New System.Drawing.Point(352, 181)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(199, 63)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "NOMG"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmSplashScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(72, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(894, 506)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.panelLoading)
		Me.Controls.Add(Me.panelLoadingBG)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FrmSplashScreen"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmSplashScreen"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents panelLoadingBG As Panel
	Friend WithEvents panelLoading As Panel
	Friend WithEvents SplashScreenTImer As Timer
	Friend WithEvents Label3 As Label
End Class
