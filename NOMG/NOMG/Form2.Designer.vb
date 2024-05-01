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
		Me.lblSetFirstAppointment = New System.Windows.Forms.Label()
		Me.btnSeeRoutine = New System.Windows.Forms.Button()
		Me.dtpLMC = New System.Windows.Forms.DateTimePicker()
		Me.dtpFirstAppointment = New System.Windows.Forms.DateTimePicker()
		Me.btnViewDoctors = New System.Windows.Forms.Button()
		Me.pnlClinicInfo = New System.Windows.Forms.Panel()
		Me.lblClinicInfo = New System.Windows.Forms.Label()
		Me.lblCIName = New System.Windows.Forms.Label()
		Me.lblCIAddress = New System.Windows.Forms.Label()
		Me.lblClOperationalDays = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtAddress = New System.Windows.Forms.TextBox()
		Me.txtOperationalDays = New System.Windows.Forms.TextBox()
		Me.lblLMC = New System.Windows.Forms.Label()
		Me.btnBillingInfo = New System.Windows.Forms.Button()
		Me.pnlPatientDetails = New System.Windows.Forms.Panel()
		Me.lblPatientDetails = New System.Windows.Forms.Label()
		Me.lblPDName = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.lblPDAddress = New System.Windows.Forms.Label()
		Me.lblPDAge = New System.Windows.Forms.Label()
		Me.lblPDFirstBaby = New System.Windows.Forms.Label()
		Me.lblPDGestationalAge = New System.Windows.Forms.Label()
		Me.lblPDAdditionalInfo = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnBack
		'
		Me.btnBack.Location = New System.Drawing.Point(9, 10)
		Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(54, 34)
		Me.btnBack.TabIndex = 1
		Me.btnBack.Text = "Back"
		Me.btnBack.UseVisualStyleBackColor = True
		'
		'lblSetFirstAppointment
		'
		Me.lblSetFirstAppointment.AutoSize = True
		Me.lblSetFirstAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSetFirstAppointment.ForeColor = System.Drawing.Color.Black
		Me.lblSetFirstAppointment.Location = New System.Drawing.Point(116, 133)
		Me.lblSetFirstAppointment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblSetFirstAppointment.Name = "lblSetFirstAppointment"
		Me.lblSetFirstAppointment.Size = New System.Drawing.Size(250, 26)
		Me.lblSetFirstAppointment.TabIndex = 3
		Me.lblSetFirstAppointment.Text = "Set First Appointment:"
		'
		'btnSeeRoutine
		'
		Me.btnSeeRoutine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSeeRoutine.Location = New System.Drawing.Point(159, 214)
		Me.btnSeeRoutine.Margin = New System.Windows.Forms.Padding(2)
		Me.btnSeeRoutine.Name = "btnSeeRoutine"
		Me.btnSeeRoutine.Size = New System.Drawing.Size(164, 37)
		Me.btnSeeRoutine.TabIndex = 4
		Me.btnSeeRoutine.Text = "See Routine"
		Me.btnSeeRoutine.UseVisualStyleBackColor = True
		'
		'dtpLMC
		'
		Me.dtpLMC.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpLMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpLMC.Location = New System.Drawing.Point(108, 77)
		Me.dtpLMC.Margin = New System.Windows.Forms.Padding(2)
		Me.dtpLMC.Name = "dtpLMC"
		Me.dtpLMC.Size = New System.Drawing.Size(259, 24)
		Me.dtpLMC.TabIndex = 7
		'
		'dtpFirstAppointment
		'
		Me.dtpFirstAppointment.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpFirstAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpFirstAppointment.Location = New System.Drawing.Point(110, 167)
		Me.dtpFirstAppointment.Margin = New System.Windows.Forms.Padding(2)
		Me.dtpFirstAppointment.Name = "dtpFirstAppointment"
		Me.dtpFirstAppointment.Size = New System.Drawing.Size(258, 24)
		Me.dtpFirstAppointment.TabIndex = 8
		'
		'btnViewDoctors
		'
		Me.btnViewDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnViewDoctors.Location = New System.Drawing.Point(89, 595)
		Me.btnViewDoctors.Margin = New System.Windows.Forms.Padding(2)
		Me.btnViewDoctors.Name = "btnViewDoctors"
		Me.btnViewDoctors.Size = New System.Drawing.Size(293, 41)
		Me.btnViewDoctors.TabIndex = 9
		Me.btnViewDoctors.Text = "View Doctors"
		Me.btnViewDoctors.UseVisualStyleBackColor = True
		'
		'pnlClinicInfo
		'
		Me.pnlClinicInfo.Location = New System.Drawing.Point(33, 266)
		Me.pnlClinicInfo.Margin = New System.Windows.Forms.Padding(2)
		Me.pnlClinicInfo.Name = "pnlClinicInfo"
		Me.pnlClinicInfo.Size = New System.Drawing.Size(406, 315)
		Me.pnlClinicInfo.TabIndex = 10
		'
		'lblClinicInfo
		'
		Me.lblClinicInfo.AutoSize = True
		Me.lblClinicInfo.BackColor = System.Drawing.Color.Transparent
		Me.lblClinicInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClinicInfo.ForeColor = System.Drawing.Color.Black
		Me.lblClinicInfo.Location = New System.Drawing.Point(94, 291)
		Me.lblClinicInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblClinicInfo.Name = "lblClinicInfo"
		Me.lblClinicInfo.Size = New System.Drawing.Size(283, 37)
		Me.lblClinicInfo.TabIndex = 12
		Me.lblClinicInfo.Text = "Clinic Information"
		'
		'lblCIName
		'
		Me.lblCIName.AutoSize = True
		Me.lblCIName.BackColor = System.Drawing.Color.Transparent
		Me.lblCIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCIName.ForeColor = System.Drawing.Color.Black
		Me.lblCIName.Location = New System.Drawing.Point(86, 349)
		Me.lblCIName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblCIName.Name = "lblCIName"
		Me.lblCIName.Size = New System.Drawing.Size(49, 17)
		Me.lblCIName.TabIndex = 13
		Me.lblCIName.Text = "Name"
		'
		'lblCIAddress
		'
		Me.lblCIAddress.AutoSize = True
		Me.lblCIAddress.BackColor = System.Drawing.Color.Transparent
		Me.lblCIAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCIAddress.ForeColor = System.Drawing.Color.Black
		Me.lblCIAddress.Location = New System.Drawing.Point(86, 419)
		Me.lblCIAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblCIAddress.Name = "lblCIAddress"
		Me.lblCIAddress.Size = New System.Drawing.Size(67, 17)
		Me.lblCIAddress.TabIndex = 14
		Me.lblCIAddress.Text = "Address"
		'
		'lblClOperationalDays
		'
		Me.lblClOperationalDays.AutoSize = True
		Me.lblClOperationalDays.BackColor = System.Drawing.Color.Transparent
		Me.lblClOperationalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblClOperationalDays.ForeColor = System.Drawing.Color.Black
		Me.lblClOperationalDays.Location = New System.Drawing.Point(86, 488)
		Me.lblClOperationalDays.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblClOperationalDays.Name = "lblClOperationalDays"
		Me.lblClOperationalDays.Size = New System.Drawing.Size(134, 17)
		Me.lblClOperationalDays.TabIndex = 15
		Me.lblClOperationalDays.Text = "Operational Days"
		'
		'txtName
		'
		Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtName.Location = New System.Drawing.Point(59, 370)
		Me.txtName.Margin = New System.Windows.Forms.Padding(2)
		Me.txtName.Multiline = True
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(354, 46)
		Me.txtName.TabIndex = 16
		Me.txtName.Text = "New OB Master GYN Clinic (NOMG)"
		Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtAddress
		'
		Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress.Location = New System.Drawing.Point(59, 440)
		Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
		Me.txtAddress.Multiline = True
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Size = New System.Drawing.Size(354, 46)
		Me.txtAddress.TabIndex = 17
		Me.txtAddress.Text = "San Isidro, Tarlac City"
		Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtOperationalDays
		'
		Me.txtOperationalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOperationalDays.Location = New System.Drawing.Point(59, 509)
		Me.txtOperationalDays.Margin = New System.Windows.Forms.Padding(2)
		Me.txtOperationalDays.Multiline = True
		Me.txtOperationalDays.Name = "txtOperationalDays"
		Me.txtOperationalDays.Size = New System.Drawing.Size(354, 46)
		Me.txtOperationalDays.TabIndex = 18
		Me.txtOperationalDays.Text = "Tuesday to Saturday"
		Me.txtOperationalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblLMC
		'
		Me.lblLMC.AutoSize = True
		Me.lblLMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLMC.ForeColor = System.Drawing.Color.Black
		Me.lblLMC.Location = New System.Drawing.Point(121, 42)
		Me.lblLMC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblLMC.Name = "lblLMC"
		Me.lblLMC.Size = New System.Drawing.Size(242, 26)
		Me.lblLMC.TabIndex = 19
		Me.lblLMC.Text = "Last Menstrual Cycle:"
		'
		'btnBillingInfo
		'
		Me.btnBillingInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBillingInfo.Location = New System.Drawing.Point(516, 554)
		Me.btnBillingInfo.Margin = New System.Windows.Forms.Padding(2)
		Me.btnBillingInfo.Name = "btnBillingInfo"
		Me.btnBillingInfo.Size = New System.Drawing.Size(368, 55)
		Me.btnBillingInfo.TabIndex = 20
		Me.btnBillingInfo.Text = "Billing Information"
		Me.btnBillingInfo.UseVisualStyleBackColor = True
		'
		'pnlPatientDetails
		'
		Me.pnlPatientDetails.Location = New System.Drawing.Point(472, 44)
		Me.pnlPatientDetails.Margin = New System.Windows.Forms.Padding(2)
		Me.pnlPatientDetails.Name = "pnlPatientDetails"
		Me.pnlPatientDetails.Size = New System.Drawing.Size(455, 481)
		Me.pnlPatientDetails.TabIndex = 11
		'
		'lblPatientDetails
		'
		Me.lblPatientDetails.AutoSize = True
		Me.lblPatientDetails.BackColor = System.Drawing.Color.Transparent
		Me.lblPatientDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPatientDetails.ForeColor = System.Drawing.Color.Black
		Me.lblPatientDetails.Location = New System.Drawing.Point(579, 58)
		Me.lblPatientDetails.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPatientDetails.Name = "lblPatientDetails"
		Me.lblPatientDetails.Size = New System.Drawing.Size(237, 37)
		Me.lblPatientDetails.TabIndex = 21
		Me.lblPatientDetails.Text = "Patient Details"
		'
		'lblPDName
		'
		Me.lblPDName.AutoSize = True
		Me.lblPDName.BackColor = System.Drawing.Color.Transparent
		Me.lblPDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPDName.ForeColor = System.Drawing.Color.Black
		Me.lblPDName.Location = New System.Drawing.Point(548, 142)
		Me.lblPDName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPDName.Name = "lblPDName"
		Me.lblPDName.Size = New System.Drawing.Size(49, 17)
		Me.lblPDName.TabIndex = 22
		Me.lblPDName.Text = "Name"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(516, 163)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(369, 46)
		Me.TextBox1.TabIndex = 23
		'
		'lblPDAddress
		'
		Me.lblPDAddress.AutoSize = True
		Me.lblPDAddress.BackColor = System.Drawing.Color.Transparent
		Me.lblPDAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPDAddress.ForeColor = System.Drawing.Color.Black
		Me.lblPDAddress.Location = New System.Drawing.Point(548, 212)
		Me.lblPDAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPDAddress.Name = "lblPDAddress"
		Me.lblPDAddress.Size = New System.Drawing.Size(67, 17)
		Me.lblPDAddress.TabIndex = 24
		Me.lblPDAddress.Text = "Address"
		'
		'lblPDAge
		'
		Me.lblPDAge.AutoSize = True
		Me.lblPDAge.BackColor = System.Drawing.Color.Transparent
		Me.lblPDAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPDAge.ForeColor = System.Drawing.Color.Black
		Me.lblPDAge.Location = New System.Drawing.Point(548, 290)
		Me.lblPDAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPDAge.Name = "lblPDAge"
		Me.lblPDAge.Size = New System.Drawing.Size(36, 17)
		Me.lblPDAge.TabIndex = 25
		Me.lblPDAge.Text = "Age"
		'
		'lblPDFirstBaby
		'
		Me.lblPDFirstBaby.AutoSize = True
		Me.lblPDFirstBaby.BackColor = System.Drawing.Color.Transparent
		Me.lblPDFirstBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPDFirstBaby.ForeColor = System.Drawing.Color.Black
		Me.lblPDFirstBaby.Location = New System.Drawing.Point(664, 290)
		Me.lblPDFirstBaby.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPDFirstBaby.Name = "lblPDFirstBaby"
		Me.lblPDFirstBaby.Size = New System.Drawing.Size(81, 17)
		Me.lblPDFirstBaby.TabIndex = 26
		Me.lblPDFirstBaby.Text = "First Baby"
		'
		'lblPDGestationalAge
		'
		Me.lblPDGestationalAge.AutoSize = True
		Me.lblPDGestationalAge.BackColor = System.Drawing.Color.Transparent
		Me.lblPDGestationalAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPDGestationalAge.ForeColor = System.Drawing.Color.Black
		Me.lblPDGestationalAge.Location = New System.Drawing.Point(778, 292)
		Me.lblPDGestationalAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPDGestationalAge.Name = "lblPDGestationalAge"
		Me.lblPDGestationalAge.Size = New System.Drawing.Size(108, 15)
		Me.lblPDGestationalAge.TabIndex = 27
		Me.lblPDGestationalAge.Text = "Gestational Age"
		'
		'lblPDAdditionalInfo
		'
		Me.lblPDAdditionalInfo.AutoSize = True
		Me.lblPDAdditionalInfo.BackColor = System.Drawing.Color.Transparent
		Me.lblPDAdditionalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPDAdditionalInfo.ForeColor = System.Drawing.Color.Black
		Me.lblPDAdditionalInfo.Location = New System.Drawing.Point(548, 368)
		Me.lblPDAdditionalInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.lblPDAdditionalInfo.Name = "lblPDAdditionalInfo"
		Me.lblPDAdditionalInfo.Size = New System.Drawing.Size(166, 17)
		Me.lblPDAdditionalInfo.TabIndex = 28
		Me.lblPDAdditionalInfo.Text = "Additional Information"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(516, 233)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(369, 46)
		Me.TextBox2.TabIndex = 29
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(516, 389)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox3.Multiline = True
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(369, 118)
		Me.TextBox3.TabIndex = 30
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(516, 311)
		Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox4.Multiline = True
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(116, 46)
		Me.TextBox4.TabIndex = 31
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(647, 311)
		Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox5.Multiline = True
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(102, 46)
		Me.TextBox5.TabIndex = 32
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(760, 311)
		Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox6.Multiline = True
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(126, 46)
		Me.TextBox6.TabIndex = 33
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(962, 651)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.lblPDAdditionalInfo)
		Me.Controls.Add(Me.lblPDGestationalAge)
		Me.Controls.Add(Me.lblPDFirstBaby)
		Me.Controls.Add(Me.lblPDAge)
		Me.Controls.Add(Me.lblPDAddress)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.lblPDName)
		Me.Controls.Add(Me.lblPatientDetails)
		Me.Controls.Add(Me.pnlPatientDetails)
		Me.Controls.Add(Me.btnBillingInfo)
		Me.Controls.Add(Me.dtpLMC)
		Me.Controls.Add(Me.lblLMC)
		Me.Controls.Add(Me.txtOperationalDays)
		Me.Controls.Add(Me.txtAddress)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.lblClOperationalDays)
		Me.Controls.Add(Me.lblCIAddress)
		Me.Controls.Add(Me.lblCIName)
		Me.Controls.Add(Me.lblClinicInfo)
		Me.Controls.Add(Me.btnViewDoctors)
		Me.Controls.Add(Me.pnlClinicInfo)
		Me.Controls.Add(Me.dtpFirstAppointment)
		Me.Controls.Add(Me.btnSeeRoutine)
		Me.Controls.Add(Me.lblSetFirstAppointment)
		Me.Controls.Add(Me.btnBack)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Main"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnBack As Button
    Friend WithEvents lblSetFirstAppointment As Label
    Friend WithEvents btnSeeRoutine As Button
    Friend WithEvents dtpLMC As DateTimePicker
    Friend WithEvents dtpFirstAppointment As DateTimePicker
    Friend WithEvents btnViewDoctors As Button
    Friend WithEvents pnlClinicInfo As Panel
    Friend WithEvents lblClinicInfo As Label
    Friend WithEvents lblCIName As Label
    Friend WithEvents lblCIAddress As Label
    Friend WithEvents lblClOperationalDays As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtOperationalDays As TextBox
    Friend WithEvents lblLMC As Label
    Friend WithEvents btnBillingInfo As Button
    Friend WithEvents pnlPatientDetails As Panel
    Friend WithEvents lblPatientDetails As Label
    Friend WithEvents lblPDName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblPDAddress As Label
    Friend WithEvents lblPDAge As Label
    Friend WithEvents lblPDFirstBaby As Label
    Friend WithEvents lblPDGestationalAge As Label
    Friend WithEvents lblPDAdditionalInfo As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
