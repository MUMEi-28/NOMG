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
        Me.lblNewOB = New System.Windows.Forms.Label()
        Me.panelLoadingBG = New System.Windows.Forms.Panel()
        Me.panelLoading = New System.Windows.Forms.Panel()
        Me.SplashScreenTImer = New System.Windows.Forms.Timer(Me.components)
        Me.lblNOMG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNewOB
        '
        Me.lblNewOB.AutoSize = True
        Me.lblNewOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNewOB.Location = New System.Drawing.Point(137, 130)
        Me.lblNewOB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewOB.Name = "lblNewOB"
        Me.lblNewOB.Size = New System.Drawing.Size(869, 76)
        Me.lblNewOB.TabIndex = 1
        Me.lblNewOB.Text = "New OB Master GYN Clinic"
        Me.lblNewOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelLoadingBG
        '
        Me.panelLoadingBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panelLoadingBG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.panelLoadingBG.Location = New System.Drawing.Point(15, 570)
        Me.panelLoadingBG.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLoadingBG.Name = "panelLoadingBG"
        Me.panelLoadingBG.Size = New System.Drawing.Size(1160, 38)
        Me.panelLoadingBG.TabIndex = 2
        '
        'panelLoading
        '
        Me.panelLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.panelLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelLoading.Location = New System.Drawing.Point(16, 570)
        Me.panelLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLoading.Name = "panelLoading"
        Me.panelLoading.Size = New System.Drawing.Size(17, 38)
        Me.panelLoading.TabIndex = 3
        '
        'SplashScreenTImer
        '
        Me.SplashScreenTImer.Enabled = True
        Me.SplashScreenTImer.Interval = 2
        '
        'lblNOMG
        '
        Me.lblNOMG.AutoSize = True
        Me.lblNOMG.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOMG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNOMG.Location = New System.Drawing.Point(469, 223)
        Me.lblNOMG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNOMG.Name = "lblNOMG"
        Me.lblNOMG.Size = New System.Drawing.Size(244, 76)
        Me.lblNOMG.TabIndex = 4
        Me.lblNOMG.Text = "NOMG"
        Me.lblNOMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1192, 623)
        Me.Controls.Add(Me.lblNOMG)
        Me.Controls.Add(Me.panelLoading)
        Me.Controls.Add(Me.panelLoadingBG)
        Me.Controls.Add(Me.lblNewOB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNewOB As Label
	Friend WithEvents panelLoadingBG As Panel
	Friend WithEvents panelLoading As Panel
	Friend WithEvents SplashScreenTImer As Timer
	Friend WithEvents lblNOMG As Label
End Class
