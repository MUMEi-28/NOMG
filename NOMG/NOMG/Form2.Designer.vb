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
        Me.txtCIName = New System.Windows.Forms.TextBox()
        Me.txtCIAddress = New System.Windows.Forms.TextBox()
        Me.txtCIOperationalDays = New System.Windows.Forms.TextBox()
        Me.lblLMC = New System.Windows.Forms.Label()
        Me.btnBillingInfo = New System.Windows.Forms.Button()
        Me.pnlPatientDetails = New System.Windows.Forms.Panel()
        Me.lblPatientDetails = New System.Windows.Forms.Label()
        Me.lblPDName = New System.Windows.Forms.Label()
        Me.txtPDName = New System.Windows.Forms.TextBox()
        Me.lblPDAddress = New System.Windows.Forms.Label()
        Me.lblPDAge = New System.Windows.Forms.Label()
        Me.lblPDFirstBaby = New System.Windows.Forms.Label()
        Me.lblPDGestationalAge = New System.Windows.Forms.Label()
        Me.lblPDAdditionalInfo = New System.Windows.Forms.Label()
        Me.txtPDAddress = New System.Windows.Forms.TextBox()
        Me.txtPDAdditionalInfo = New System.Windows.Forms.TextBox()
        Me.txtPDAge = New System.Windows.Forms.TextBox()
        Me.txtPDFirstBaby = New System.Windows.Forms.TextBox()
        Me.txtPDGestationalAge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(72, 42)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblSetFirstAppointment
        '
        Me.lblSetFirstAppointment.AutoSize = True
        Me.lblSetFirstAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetFirstAppointment.ForeColor = System.Drawing.Color.Black
        Me.lblSetFirstAppointment.Location = New System.Drawing.Point(155, 164)
        Me.lblSetFirstAppointment.Name = "lblSetFirstAppointment"
        Me.lblSetFirstAppointment.Size = New System.Drawing.Size(317, 32)
        Me.lblSetFirstAppointment.TabIndex = 3
        Me.lblSetFirstAppointment.Text = "Set First Appointment:"
        '
        'btnSeeRoutine
        '
        Me.btnSeeRoutine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeeRoutine.Location = New System.Drawing.Point(212, 263)
        Me.btnSeeRoutine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSeeRoutine.Name = "btnSeeRoutine"
        Me.btnSeeRoutine.Size = New System.Drawing.Size(219, 46)
        Me.btnSeeRoutine.TabIndex = 4
        Me.btnSeeRoutine.Text = "See Routine"
        Me.btnSeeRoutine.UseVisualStyleBackColor = True
        '
        'dtpLMC
        '
        Me.dtpLMC.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLMC.Location = New System.Drawing.Point(144, 95)
        Me.dtpLMC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpLMC.Name = "dtpLMC"
        Me.dtpLMC.Size = New System.Drawing.Size(344, 28)
        Me.dtpLMC.TabIndex = 7
        '
        'dtpFirstAppointment
        '
        Me.dtpFirstAppointment.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.799999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFirstAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFirstAppointment.Location = New System.Drawing.Point(147, 206)
        Me.dtpFirstAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFirstAppointment.Name = "dtpFirstAppointment"
        Me.dtpFirstAppointment.Size = New System.Drawing.Size(343, 28)
        Me.dtpFirstAppointment.TabIndex = 8
        '
        'btnViewDoctors
        '
        Me.btnViewDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDoctors.Location = New System.Drawing.Point(119, 732)
        Me.btnViewDoctors.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewDoctors.Name = "btnViewDoctors"
        Me.btnViewDoctors.Size = New System.Drawing.Size(391, 50)
        Me.btnViewDoctors.TabIndex = 9
        Me.btnViewDoctors.Text = "View Doctors"
        Me.btnViewDoctors.UseVisualStyleBackColor = True
        '
        'pnlClinicInfo
        '
        Me.pnlClinicInfo.Location = New System.Drawing.Point(44, 327)
        Me.pnlClinicInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlClinicInfo.Name = "pnlClinicInfo"
        Me.pnlClinicInfo.Size = New System.Drawing.Size(541, 388)
        Me.pnlClinicInfo.TabIndex = 10
        '
        'lblClinicInfo
        '
        Me.lblClinicInfo.AutoSize = True
        Me.lblClinicInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblClinicInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinicInfo.ForeColor = System.Drawing.Color.Black
        Me.lblClinicInfo.Location = New System.Drawing.Point(125, 358)
        Me.lblClinicInfo.Name = "lblClinicInfo"
        Me.lblClinicInfo.Size = New System.Drawing.Size(347, 46)
        Me.lblClinicInfo.TabIndex = 12
        Me.lblClinicInfo.Text = "Clinic Information"
        '
        'lblCIName
        '
        Me.lblCIName.AutoSize = True
        Me.lblCIName.BackColor = System.Drawing.Color.Transparent
        Me.lblCIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIName.ForeColor = System.Drawing.Color.Black
        Me.lblCIName.Location = New System.Drawing.Point(115, 430)
        Me.lblCIName.Name = "lblCIName"
        Me.lblCIName.Size = New System.Drawing.Size(57, 20)
        Me.lblCIName.TabIndex = 13
        Me.lblCIName.Text = "Name"
        '
        'lblCIAddress
        '
        Me.lblCIAddress.AutoSize = True
        Me.lblCIAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblCIAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIAddress.ForeColor = System.Drawing.Color.Black
        Me.lblCIAddress.Location = New System.Drawing.Point(115, 516)
        Me.lblCIAddress.Name = "lblCIAddress"
        Me.lblCIAddress.Size = New System.Drawing.Size(78, 20)
        Me.lblCIAddress.TabIndex = 14
        Me.lblCIAddress.Text = "Address"
        '
        'lblClOperationalDays
        '
        Me.lblClOperationalDays.AutoSize = True
        Me.lblClOperationalDays.BackColor = System.Drawing.Color.Transparent
        Me.lblClOperationalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClOperationalDays.ForeColor = System.Drawing.Color.Black
        Me.lblClOperationalDays.Location = New System.Drawing.Point(115, 601)
        Me.lblClOperationalDays.Name = "lblClOperationalDays"
        Me.lblClOperationalDays.Size = New System.Drawing.Size(155, 20)
        Me.lblClOperationalDays.TabIndex = 15
        Me.lblClOperationalDays.Text = "Operational Days"
        '
        'txtCIName
        '
        Me.txtCIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIName.Location = New System.Drawing.Point(79, 455)
        Me.txtCIName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCIName.Multiline = True
        Me.txtCIName.Name = "txtCIName"
        Me.txtCIName.Size = New System.Drawing.Size(471, 56)
        Me.txtCIName.TabIndex = 16
        Me.txtCIName.Text = "New OB Master GYN Clinic (NOMG)"
        Me.txtCIName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCIAddress
        '
        Me.txtCIAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIAddress.Location = New System.Drawing.Point(79, 542)
        Me.txtCIAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCIAddress.Multiline = True
        Me.txtCIAddress.Name = "txtCIAddress"
        Me.txtCIAddress.Size = New System.Drawing.Size(471, 56)
        Me.txtCIAddress.TabIndex = 17
        Me.txtCIAddress.Text = "San Isidro, Tarlac City"
        Me.txtCIAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCIOperationalDays
        '
        Me.txtCIOperationalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIOperationalDays.Location = New System.Drawing.Point(79, 626)
        Me.txtCIOperationalDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCIOperationalDays.Multiline = True
        Me.txtCIOperationalDays.Name = "txtCIOperationalDays"
        Me.txtCIOperationalDays.Size = New System.Drawing.Size(471, 56)
        Me.txtCIOperationalDays.TabIndex = 18
        Me.txtCIOperationalDays.Text = "Tuesday to Saturday"
        Me.txtCIOperationalDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLMC
        '
        Me.lblLMC.AutoSize = True
        Me.lblLMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMC.ForeColor = System.Drawing.Color.Black
        Me.lblLMC.Location = New System.Drawing.Point(161, 52)
        Me.lblLMC.Name = "lblLMC"
        Me.lblLMC.Size = New System.Drawing.Size(307, 32)
        Me.lblLMC.TabIndex = 19
        Me.lblLMC.Text = "Last Menstrual Cycle:"
        '
        'btnBillingInfo
        '
        Me.btnBillingInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillingInfo.Location = New System.Drawing.Point(688, 682)
        Me.btnBillingInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBillingInfo.Name = "btnBillingInfo"
        Me.btnBillingInfo.Size = New System.Drawing.Size(491, 68)
        Me.btnBillingInfo.TabIndex = 20
        Me.btnBillingInfo.Text = "Billing Information"
        Me.btnBillingInfo.UseVisualStyleBackColor = True
        '
        'pnlPatientDetails
        '
        Me.pnlPatientDetails.Location = New System.Drawing.Point(629, 54)
        Me.pnlPatientDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlPatientDetails.Name = "pnlPatientDetails"
        Me.pnlPatientDetails.Size = New System.Drawing.Size(607, 592)
        Me.pnlPatientDetails.TabIndex = 11
        '
        'lblPatientDetails
        '
        Me.lblPatientDetails.AutoSize = True
        Me.lblPatientDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblPatientDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientDetails.ForeColor = System.Drawing.Color.Black
        Me.lblPatientDetails.Location = New System.Drawing.Point(772, 71)
        Me.lblPatientDetails.Name = "lblPatientDetails"
        Me.lblPatientDetails.Size = New System.Drawing.Size(292, 46)
        Me.lblPatientDetails.TabIndex = 21
        Me.lblPatientDetails.Text = "Patient Details"
        '
        'lblPDName
        '
        Me.lblPDName.AutoSize = True
        Me.lblPDName.BackColor = System.Drawing.Color.Transparent
        Me.lblPDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDName.ForeColor = System.Drawing.Color.Black
        Me.lblPDName.Location = New System.Drawing.Point(731, 175)
        Me.lblPDName.Name = "lblPDName"
        Me.lblPDName.Size = New System.Drawing.Size(57, 20)
        Me.lblPDName.TabIndex = 22
        Me.lblPDName.Text = "Name"
        '
        'txtPDName
        '
        Me.txtPDName.Location = New System.Drawing.Point(688, 201)
        Me.txtPDName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPDName.Multiline = True
        Me.txtPDName.Name = "txtPDName"
        Me.txtPDName.Size = New System.Drawing.Size(491, 56)
        Me.txtPDName.TabIndex = 23
        '
        'lblPDAddress
        '
        Me.lblPDAddress.AutoSize = True
        Me.lblPDAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblPDAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDAddress.ForeColor = System.Drawing.Color.Black
        Me.lblPDAddress.Location = New System.Drawing.Point(731, 261)
        Me.lblPDAddress.Name = "lblPDAddress"
        Me.lblPDAddress.Size = New System.Drawing.Size(78, 20)
        Me.lblPDAddress.TabIndex = 24
        Me.lblPDAddress.Text = "Address"
        '
        'lblPDAge
        '
        Me.lblPDAge.AutoSize = True
        Me.lblPDAge.BackColor = System.Drawing.Color.Transparent
        Me.lblPDAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDAge.ForeColor = System.Drawing.Color.Black
        Me.lblPDAge.Location = New System.Drawing.Point(731, 357)
        Me.lblPDAge.Name = "lblPDAge"
        Me.lblPDAge.Size = New System.Drawing.Size(41, 20)
        Me.lblPDAge.TabIndex = 25
        Me.lblPDAge.Text = "Age"
        '
        'lblPDFirstBaby
        '
        Me.lblPDFirstBaby.AutoSize = True
        Me.lblPDFirstBaby.BackColor = System.Drawing.Color.Transparent
        Me.lblPDFirstBaby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDFirstBaby.ForeColor = System.Drawing.Color.Black
        Me.lblPDFirstBaby.Location = New System.Drawing.Point(885, 357)
        Me.lblPDFirstBaby.Name = "lblPDFirstBaby"
        Me.lblPDFirstBaby.Size = New System.Drawing.Size(96, 20)
        Me.lblPDFirstBaby.TabIndex = 26
        Me.lblPDFirstBaby.Text = "First Baby"
        '
        'lblPDGestationalAge
        '
        Me.lblPDGestationalAge.AutoSize = True
        Me.lblPDGestationalAge.BackColor = System.Drawing.Color.Transparent
        Me.lblPDGestationalAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDGestationalAge.ForeColor = System.Drawing.Color.Black
        Me.lblPDGestationalAge.Location = New System.Drawing.Point(1037, 359)
        Me.lblPDGestationalAge.Name = "lblPDGestationalAge"
        Me.lblPDGestationalAge.Size = New System.Drawing.Size(127, 18)
        Me.lblPDGestationalAge.TabIndex = 27
        Me.lblPDGestationalAge.Text = "Gestational Age"
        '
        'lblPDAdditionalInfo
        '
        Me.lblPDAdditionalInfo.AutoSize = True
        Me.lblPDAdditionalInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblPDAdditionalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPDAdditionalInfo.ForeColor = System.Drawing.Color.Black
        Me.lblPDAdditionalInfo.Location = New System.Drawing.Point(731, 453)
        Me.lblPDAdditionalInfo.Name = "lblPDAdditionalInfo"
        Me.lblPDAdditionalInfo.Size = New System.Drawing.Size(192, 20)
        Me.lblPDAdditionalInfo.TabIndex = 28
        Me.lblPDAdditionalInfo.Text = "Additional Information"
        '
        'txtPDAddress
        '
        Me.txtPDAddress.Location = New System.Drawing.Point(688, 287)
        Me.txtPDAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPDAddress.Multiline = True
        Me.txtPDAddress.Name = "txtPDAddress"
        Me.txtPDAddress.Size = New System.Drawing.Size(491, 56)
        Me.txtPDAddress.TabIndex = 29
        '
        'txtPDAdditionalInfo
        '
        Me.txtPDAdditionalInfo.Location = New System.Drawing.Point(688, 479)
        Me.txtPDAdditionalInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPDAdditionalInfo.Multiline = True
        Me.txtPDAdditionalInfo.Name = "txtPDAdditionalInfo"
        Me.txtPDAdditionalInfo.Size = New System.Drawing.Size(491, 144)
        Me.txtPDAdditionalInfo.TabIndex = 30
        '
        'txtPDAge
        '
        Me.txtPDAge.Location = New System.Drawing.Point(688, 383)
        Me.txtPDAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPDAge.Multiline = True
        Me.txtPDAge.Name = "txtPDAge"
        Me.txtPDAge.Size = New System.Drawing.Size(153, 56)
        Me.txtPDAge.TabIndex = 31
        '
        'txtPDFirstBaby
        '
        Me.txtPDFirstBaby.Location = New System.Drawing.Point(863, 383)
        Me.txtPDFirstBaby.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPDFirstBaby.Multiline = True
        Me.txtPDFirstBaby.Name = "txtPDFirstBaby"
        Me.txtPDFirstBaby.Size = New System.Drawing.Size(135, 56)
        Me.txtPDFirstBaby.TabIndex = 32
        '
        'txtPDGestationalAge
        '
        Me.txtPDGestationalAge.Location = New System.Drawing.Point(1013, 383)
        Me.txtPDGestationalAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPDGestationalAge.Multiline = True
        Me.txtPDGestationalAge.Name = "txtPDGestationalAge"
        Me.txtPDGestationalAge.Size = New System.Drawing.Size(167, 56)
        Me.txtPDGestationalAge.TabIndex = 33
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 801)
        Me.Controls.Add(Me.txtPDGestationalAge)
        Me.Controls.Add(Me.txtPDFirstBaby)
        Me.Controls.Add(Me.txtPDAge)
        Me.Controls.Add(Me.txtPDAdditionalInfo)
        Me.Controls.Add(Me.txtPDAddress)
        Me.Controls.Add(Me.lblPDAdditionalInfo)
        Me.Controls.Add(Me.lblPDGestationalAge)
        Me.Controls.Add(Me.lblPDFirstBaby)
        Me.Controls.Add(Me.lblPDAge)
        Me.Controls.Add(Me.lblPDAddress)
        Me.Controls.Add(Me.txtPDName)
        Me.Controls.Add(Me.lblPDName)
        Me.Controls.Add(Me.lblPatientDetails)
        Me.Controls.Add(Me.pnlPatientDetails)
        Me.Controls.Add(Me.btnBillingInfo)
        Me.Controls.Add(Me.dtpLMC)
        Me.Controls.Add(Me.lblLMC)
        Me.Controls.Add(Me.txtCIOperationalDays)
        Me.Controls.Add(Me.txtCIAddress)
        Me.Controls.Add(Me.txtCIName)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents txtCIName As TextBox
    Friend WithEvents txtCIAddress As TextBox
    Friend WithEvents txtCIOperationalDays As TextBox
    Friend WithEvents lblLMC As Label
    Friend WithEvents btnBillingInfo As Button
    Friend WithEvents pnlPatientDetails As Panel
    Friend WithEvents lblPatientDetails As Label
    Friend WithEvents lblPDName As Label
    Friend WithEvents txtPDName As TextBox
    Friend WithEvents lblPDAddress As Label
    Friend WithEvents lblPDAge As Label
    Friend WithEvents lblPDFirstBaby As Label
    Friend WithEvents lblPDGestationalAge As Label
    Friend WithEvents lblPDAdditionalInfo As Label
    Friend WithEvents txtPDAddress As TextBox
    Friend WithEvents txtPDAdditionalInfo As TextBox
    Friend WithEvents txtPDAge As TextBox
    Friend WithEvents txtPDFirstBaby As TextBox
    Friend WithEvents txtPDGestationalAge As TextBox
End Class
