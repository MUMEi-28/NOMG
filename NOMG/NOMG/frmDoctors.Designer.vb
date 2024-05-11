<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDoctors
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
        Me.lblAdditionalInfo = New System.Windows.Forms.Label()
        Me.pnlDr1 = New System.Windows.Forms.Panel()
        Me.txtDr1Name = New System.Windows.Forms.TextBox()
        Me.lblDr1Name = New System.Windows.Forms.Label()
        Me.lblDr1Age = New System.Windows.Forms.Label()
        Me.txtDr1Age = New System.Windows.Forms.TextBox()
        Me.txtDr1Gender = New System.Windows.Forms.TextBox()
        Me.txtDr1Address = New System.Windows.Forms.TextBox()
        Me.lblDr1Address = New System.Windows.Forms.Label()
        Me.lblDr1Gender = New System.Windows.Forms.Label()
        Me.lblDr1Educ = New System.Windows.Forms.Label()
        Me.txtDr1Educ = New System.Windows.Forms.TextBox()
        Me.lblDr1 = New System.Windows.Forms.Label()
        Me.lblDr2 = New System.Windows.Forms.Label()
        Me.lblDr3 = New System.Windows.Forms.Label()
        Me.lblDr2Name = New System.Windows.Forms.Label()
        Me.txtDr2Name = New System.Windows.Forms.TextBox()
        Me.lblDr2Age = New System.Windows.Forms.Label()
        Me.lblDr2Gender = New System.Windows.Forms.Label()
        Me.txtDr2Age = New System.Windows.Forms.TextBox()
        Me.txtDr2Gender = New System.Windows.Forms.TextBox()
        Me.lblDr2Address = New System.Windows.Forms.Label()
        Me.txtDr2Address = New System.Windows.Forms.TextBox()
        Me.txtDr2Educ = New System.Windows.Forms.TextBox()
        Me.lblDr2Educ = New System.Windows.Forms.Label()
        Me.pnlDr2 = New System.Windows.Forms.Panel()
        Me.lblDr3Name = New System.Windows.Forms.Label()
        Me.txtDr3Name = New System.Windows.Forms.TextBox()
        Me.lblDr3Age = New System.Windows.Forms.Label()
        Me.lblDr3Gender = New System.Windows.Forms.Label()
        Me.txtDr3Age = New System.Windows.Forms.TextBox()
        Me.txtDr3Gender = New System.Windows.Forms.TextBox()
        Me.txtDr3Address = New System.Windows.Forms.TextBox()
        Me.lblDr3Address = New System.Windows.Forms.Label()
        Me.lblDr3Educ = New System.Windows.Forms.Label()
        Me.txtDr3Educ = New System.Windows.Forms.TextBox()
        Me.pnlDr3 = New System.Windows.Forms.Panel()
        Me.lblMaxPatients = New System.Windows.Forms.Label()
        Me.pbxDr1 = New System.Windows.Forms.PictureBox()
        Me.pbxDr2 = New System.Windows.Forms.PictureBox()
        Me.pbxDr3 = New System.Windows.Forms.PictureBox()
        Me.pnlDr1.SuspendLayout()
        Me.pnlDr2.SuspendLayout()
        Me.pnlDr3.SuspendLayout()
        CType(Me.pbxDr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDr3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Nunito ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(457, 673)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(366, 48)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblAdditionalInfo
        '
        Me.lblAdditionalInfo.AutoSize = True
        Me.lblAdditionalInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblAdditionalInfo.Font = New System.Drawing.Font("Nunito Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblAdditionalInfo.Location = New System.Drawing.Point(402, 28)
        Me.lblAdditionalInfo.Name = "lblAdditionalInfo"
        Me.lblAdditionalInfo.Size = New System.Drawing.Size(469, 55)
        Me.lblAdditionalInfo.TabIndex = 22
        Me.lblAdditionalInfo.Text = "Additional Information"
        '
        'pnlDr1
        '
        Me.pnlDr1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pnlDr1.Controls.Add(Me.pbxDr1)
        Me.pnlDr1.Controls.Add(Me.lblDr1)
        Me.pnlDr1.Controls.Add(Me.lblDr1Name)
        Me.pnlDr1.Controls.Add(Me.lblDr1Age)
        Me.pnlDr1.Controls.Add(Me.lblDr1Gender)
        Me.pnlDr1.Controls.Add(Me.lblDr1Address)
        Me.pnlDr1.Controls.Add(Me.lblDr1Educ)
        Me.pnlDr1.Location = New System.Drawing.Point(80, 176)
        Me.pnlDr1.Name = "pnlDr1"
        Me.pnlDr1.Size = New System.Drawing.Size(335, 454)
        Me.pnlDr1.TabIndex = 23
        '
        'txtDr1Name
        '
        Me.txtDr1Name.Enabled = False
        Me.txtDr1Name.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr1Name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDr1Name.Location = New System.Drawing.Point(120, 366)
        Me.txtDr1Name.Multiline = True
        Me.txtDr1Name.Name = "txtDr1Name"
        Me.txtDr1Name.Size = New System.Drawing.Size(256, 43)
        Me.txtDr1Name.TabIndex = 24
        Me.txtDr1Name.Text = "Dr. Richard U. Aganon"
        '
        'lblDr1Name
        '
        Me.lblDr1Name.AutoSize = True
        Me.lblDr1Name.BackColor = System.Drawing.Color.Transparent
        Me.lblDr1Name.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr1Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr1Name.Location = New System.Drawing.Point(41, 172)
        Me.lblDr1Name.Name = "lblDr1Name"
        Me.lblDr1Name.Size = New System.Drawing.Size(43, 18)
        Me.lblDr1Name.TabIndex = 29
        Me.lblDr1Name.Text = "Name"
        '
        'lblDr1Age
        '
        Me.lblDr1Age.AutoSize = True
        Me.lblDr1Age.BackColor = System.Drawing.Color.Transparent
        Me.lblDr1Age.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr1Age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr1Age.Location = New System.Drawing.Point(41, 237)
        Me.lblDr1Age.Name = "lblDr1Age"
        Me.lblDr1Age.Size = New System.Drawing.Size(33, 18)
        Me.lblDr1Age.TabIndex = 30
        Me.lblDr1Age.Text = "Age"
        '
        'txtDr1Age
        '
        Me.txtDr1Age.Enabled = False
        Me.txtDr1Age.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr1Age.Location = New System.Drawing.Point(120, 433)
        Me.txtDr1Age.Multiline = True
        Me.txtDr1Age.Name = "txtDr1Age"
        Me.txtDr1Age.Size = New System.Drawing.Size(120, 43)
        Me.txtDr1Age.TabIndex = 31
        Me.txtDr1Age.Text = "36"
        '
        'txtDr1Gender
        '
        Me.txtDr1Gender.Enabled = False
        Me.txtDr1Gender.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr1Gender.Location = New System.Drawing.Point(256, 433)
        Me.txtDr1Gender.Multiline = True
        Me.txtDr1Gender.Name = "txtDr1Gender"
        Me.txtDr1Gender.Size = New System.Drawing.Size(120, 43)
        Me.txtDr1Gender.TabIndex = 32
        Me.txtDr1Gender.Text = "Male"
        '
        'txtDr1Address
        '
        Me.txtDr1Address.Enabled = False
        Me.txtDr1Address.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr1Address.Location = New System.Drawing.Point(120, 499)
        Me.txtDr1Address.Multiline = True
        Me.txtDr1Address.Name = "txtDr1Address"
        Me.txtDr1Address.Size = New System.Drawing.Size(256, 43)
        Me.txtDr1Address.TabIndex = 33
        Me.txtDr1Address.Text = "Niña's Ville Subdivision, Tarlac City"
        '
        'lblDr1Address
        '
        Me.lblDr1Address.AutoSize = True
        Me.lblDr1Address.BackColor = System.Drawing.Color.Transparent
        Me.lblDr1Address.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr1Address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr1Address.Location = New System.Drawing.Point(41, 303)
        Me.lblDr1Address.Name = "lblDr1Address"
        Me.lblDr1Address.Size = New System.Drawing.Size(58, 18)
        Me.lblDr1Address.TabIndex = 34
        Me.lblDr1Address.Text = "Address"
        '
        'lblDr1Gender
        '
        Me.lblDr1Gender.AutoSize = True
        Me.lblDr1Gender.BackColor = System.Drawing.Color.Transparent
        Me.lblDr1Gender.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr1Gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr1Gender.Location = New System.Drawing.Point(177, 237)
        Me.lblDr1Gender.Name = "lblDr1Gender"
        Me.lblDr1Gender.Size = New System.Drawing.Size(53, 18)
        Me.lblDr1Gender.TabIndex = 35
        Me.lblDr1Gender.Text = "Gender"
        '
        'lblDr1Educ
        '
        Me.lblDr1Educ.AutoSize = True
        Me.lblDr1Educ.BackColor = System.Drawing.Color.Transparent
        Me.lblDr1Educ.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr1Educ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr1Educ.Location = New System.Drawing.Point(41, 369)
        Me.lblDr1Educ.Name = "lblDr1Educ"
        Me.lblDr1Educ.Size = New System.Drawing.Size(68, 18)
        Me.lblDr1Educ.TabIndex = 36
        Me.lblDr1Educ.Text = "Education"
        '
        'txtDr1Educ
        '
        Me.txtDr1Educ.Enabled = False
        Me.txtDr1Educ.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr1Educ.Location = New System.Drawing.Point(120, 567)
        Me.txtDr1Educ.Multiline = True
        Me.txtDr1Educ.Name = "txtDr1Educ"
        Me.txtDr1Educ.Size = New System.Drawing.Size(256, 43)
        Me.txtDr1Educ.TabIndex = 37
        Me.txtDr1Educ.Text = "Angeles University Foundation"
        '
        'lblDr1
        '
        Me.lblDr1.AutoSize = True
        Me.lblDr1.BackColor = System.Drawing.Color.Transparent
        Me.lblDr1.Font = New System.Drawing.Font("Nunito Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr1.Location = New System.Drawing.Point(97, 7)
        Me.lblDr1.Name = "lblDr1"
        Me.lblDr1.Size = New System.Drawing.Size(146, 41)
        Me.lblDr1.TabIndex = 38
        Me.lblDr1.Text = "Doctor 1"
        '
        'lblDr2
        '
        Me.lblDr2.AutoSize = True
        Me.lblDr2.BackColor = System.Drawing.Color.Transparent
        Me.lblDr2.Font = New System.Drawing.Font("Nunito Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr2.Location = New System.Drawing.Point(100, 6)
        Me.lblDr2.Name = "lblDr2"
        Me.lblDr2.Size = New System.Drawing.Size(146, 41)
        Me.lblDr2.TabIndex = 39
        Me.lblDr2.Text = "Doctor 2"
        '
        'lblDr3
        '
        Me.lblDr3.AutoSize = True
        Me.lblDr3.BackColor = System.Drawing.Color.Transparent
        Me.lblDr3.Font = New System.Drawing.Font("Nunito Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr3.Location = New System.Drawing.Point(96, 6)
        Me.lblDr3.Name = "lblDr3"
        Me.lblDr3.Size = New System.Drawing.Size(146, 41)
        Me.lblDr3.TabIndex = 40
        Me.lblDr3.Text = "Doctor 3"
        '
        'lblDr2Name
        '
        Me.lblDr2Name.AutoSize = True
        Me.lblDr2Name.BackColor = System.Drawing.Color.Transparent
        Me.lblDr2Name.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr2Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr2Name.Location = New System.Drawing.Point(41, 171)
        Me.lblDr2Name.Name = "lblDr2Name"
        Me.lblDr2Name.Size = New System.Drawing.Size(43, 18)
        Me.lblDr2Name.TabIndex = 41
        Me.lblDr2Name.Text = "Name"
        '
        'txtDr2Name
        '
        Me.txtDr2Name.Enabled = False
        Me.txtDr2Name.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr2Name.Location = New System.Drawing.Point(515, 366)
        Me.txtDr2Name.Multiline = True
        Me.txtDr2Name.Name = "txtDr2Name"
        Me.txtDr2Name.Size = New System.Drawing.Size(256, 43)
        Me.txtDr2Name.TabIndex = 42
        Me.txtDr2Name.Text = "Dr. Maya Grace S. Ramos"
        '
        'lblDr2Age
        '
        Me.lblDr2Age.AutoSize = True
        Me.lblDr2Age.BackColor = System.Drawing.Color.Transparent
        Me.lblDr2Age.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr2Age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr2Age.Location = New System.Drawing.Point(41, 237)
        Me.lblDr2Age.Name = "lblDr2Age"
        Me.lblDr2Age.Size = New System.Drawing.Size(33, 18)
        Me.lblDr2Age.TabIndex = 43
        Me.lblDr2Age.Text = "Age"
        '
        'lblDr2Gender
        '
        Me.lblDr2Gender.AutoSize = True
        Me.lblDr2Gender.BackColor = System.Drawing.Color.Transparent
        Me.lblDr2Gender.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr2Gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr2Gender.Location = New System.Drawing.Point(179, 237)
        Me.lblDr2Gender.Name = "lblDr2Gender"
        Me.lblDr2Gender.Size = New System.Drawing.Size(53, 18)
        Me.lblDr2Gender.TabIndex = 44
        Me.lblDr2Gender.Text = "Gender"
        '
        'txtDr2Age
        '
        Me.txtDr2Age.Enabled = False
        Me.txtDr2Age.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr2Age.Location = New System.Drawing.Point(515, 433)
        Me.txtDr2Age.Multiline = True
        Me.txtDr2Age.Name = "txtDr2Age"
        Me.txtDr2Age.Size = New System.Drawing.Size(120, 43)
        Me.txtDr2Age.TabIndex = 45
        Me.txtDr2Age.Text = "35"
        '
        'txtDr2Gender
        '
        Me.txtDr2Gender.Enabled = False
        Me.txtDr2Gender.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr2Gender.Location = New System.Drawing.Point(651, 433)
        Me.txtDr2Gender.Multiline = True
        Me.txtDr2Gender.Name = "txtDr2Gender"
        Me.txtDr2Gender.Size = New System.Drawing.Size(120, 43)
        Me.txtDr2Gender.TabIndex = 46
        Me.txtDr2Gender.Text = "Female"
        '
        'lblDr2Address
        '
        Me.lblDr2Address.AutoSize = True
        Me.lblDr2Address.BackColor = System.Drawing.Color.Transparent
        Me.lblDr2Address.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr2Address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr2Address.Location = New System.Drawing.Point(41, 302)
        Me.lblDr2Address.Name = "lblDr2Address"
        Me.lblDr2Address.Size = New System.Drawing.Size(58, 18)
        Me.lblDr2Address.TabIndex = 47
        Me.lblDr2Address.Text = "Address"
        '
        'txtDr2Address
        '
        Me.txtDr2Address.Enabled = False
        Me.txtDr2Address.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr2Address.Location = New System.Drawing.Point(515, 499)
        Me.txtDr2Address.Multiline = True
        Me.txtDr2Address.Name = "txtDr2Address"
        Me.txtDr2Address.Size = New System.Drawing.Size(256, 43)
        Me.txtDr2Address.TabIndex = 48
        Me.txtDr2Address.Text = "Macabulos Drive, Tarlac City"
        '
        'txtDr2Educ
        '
        Me.txtDr2Educ.Enabled = False
        Me.txtDr2Educ.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr2Educ.Location = New System.Drawing.Point(515, 567)
        Me.txtDr2Educ.Multiline = True
        Me.txtDr2Educ.Name = "txtDr2Educ"
        Me.txtDr2Educ.Size = New System.Drawing.Size(256, 43)
        Me.txtDr2Educ.TabIndex = 49
        Me.txtDr2Educ.Text = "University of the Philippines Manila"
        '
        'lblDr2Educ
        '
        Me.lblDr2Educ.AutoSize = True
        Me.lblDr2Educ.BackColor = System.Drawing.Color.Transparent
        Me.lblDr2Educ.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr2Educ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr2Educ.Location = New System.Drawing.Point(41, 369)
        Me.lblDr2Educ.Name = "lblDr2Educ"
        Me.lblDr2Educ.Size = New System.Drawing.Size(68, 18)
        Me.lblDr2Educ.TabIndex = 50
        Me.lblDr2Educ.Text = "Education"
        '
        'pnlDr2
        '
        Me.pnlDr2.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pnlDr2.Controls.Add(Me.pbxDr2)
        Me.pnlDr2.Controls.Add(Me.lblDr2)
        Me.pnlDr2.Controls.Add(Me.lblDr2Name)
        Me.pnlDr2.Controls.Add(Me.lblDr2Age)
        Me.pnlDr2.Controls.Add(Me.lblDr2Address)
        Me.pnlDr2.Controls.Add(Me.lblDr2Educ)
        Me.pnlDr2.Controls.Add(Me.lblDr2Gender)
        Me.pnlDr2.Location = New System.Drawing.Point(475, 176)
        Me.pnlDr2.Name = "pnlDr2"
        Me.pnlDr2.Size = New System.Drawing.Size(335, 454)
        Me.pnlDr2.TabIndex = 24
        '
        'lblDr3Name
        '
        Me.lblDr3Name.AutoSize = True
        Me.lblDr3Name.BackColor = System.Drawing.Color.Transparent
        Me.lblDr3Name.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr3Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr3Name.Location = New System.Drawing.Point(40, 169)
        Me.lblDr3Name.Name = "lblDr3Name"
        Me.lblDr3Name.Size = New System.Drawing.Size(43, 18)
        Me.lblDr3Name.TabIndex = 51
        Me.lblDr3Name.Text = "Name"
        '
        'txtDr3Name
        '
        Me.txtDr3Name.Enabled = False
        Me.txtDr3Name.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr3Name.Location = New System.Drawing.Point(908, 366)
        Me.txtDr3Name.Multiline = True
        Me.txtDr3Name.Name = "txtDr3Name"
        Me.txtDr3Name.Size = New System.Drawing.Size(256, 43)
        Me.txtDr3Name.TabIndex = 52
        Me.txtDr3Name.Text = "Dr. Maria D. Lopez"
        '
        'lblDr3Age
        '
        Me.lblDr3Age.AutoSize = True
        Me.lblDr3Age.BackColor = System.Drawing.Color.Transparent
        Me.lblDr3Age.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr3Age.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr3Age.Location = New System.Drawing.Point(40, 235)
        Me.lblDr3Age.Name = "lblDr3Age"
        Me.lblDr3Age.Size = New System.Drawing.Size(33, 18)
        Me.lblDr3Age.TabIndex = 53
        Me.lblDr3Age.Text = "Age"
        '
        'lblDr3Gender
        '
        Me.lblDr3Gender.AutoSize = True
        Me.lblDr3Gender.BackColor = System.Drawing.Color.Transparent
        Me.lblDr3Gender.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr3Gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr3Gender.Location = New System.Drawing.Point(177, 236)
        Me.lblDr3Gender.Name = "lblDr3Gender"
        Me.lblDr3Gender.Size = New System.Drawing.Size(53, 18)
        Me.lblDr3Gender.TabIndex = 54
        Me.lblDr3Gender.Text = "Gender"
        '
        'txtDr3Age
        '
        Me.txtDr3Age.Enabled = False
        Me.txtDr3Age.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr3Age.Location = New System.Drawing.Point(908, 432)
        Me.txtDr3Age.Multiline = True
        Me.txtDr3Age.Name = "txtDr3Age"
        Me.txtDr3Age.Size = New System.Drawing.Size(120, 43)
        Me.txtDr3Age.TabIndex = 55
        Me.txtDr3Age.Text = "38"
        '
        'txtDr3Gender
        '
        Me.txtDr3Gender.Enabled = False
        Me.txtDr3Gender.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr3Gender.Location = New System.Drawing.Point(1044, 432)
        Me.txtDr3Gender.Multiline = True
        Me.txtDr3Gender.Name = "txtDr3Gender"
        Me.txtDr3Gender.Size = New System.Drawing.Size(120, 43)
        Me.txtDr3Gender.TabIndex = 56
        Me.txtDr3Gender.Text = "Female"
        '
        'txtDr3Address
        '
        Me.txtDr3Address.Enabled = False
        Me.txtDr3Address.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr3Address.Location = New System.Drawing.Point(908, 499)
        Me.txtDr3Address.Multiline = True
        Me.txtDr3Address.Name = "txtDr3Address"
        Me.txtDr3Address.Size = New System.Drawing.Size(256, 43)
        Me.txtDr3Address.TabIndex = 57
        Me.txtDr3Address.Text = "San Sebastian Village, Tarlac City"
        '
        'lblDr3Address
        '
        Me.lblDr3Address.AutoSize = True
        Me.lblDr3Address.BackColor = System.Drawing.Color.Transparent
        Me.lblDr3Address.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr3Address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr3Address.Location = New System.Drawing.Point(40, 302)
        Me.lblDr3Address.Name = "lblDr3Address"
        Me.lblDr3Address.Size = New System.Drawing.Size(58, 18)
        Me.lblDr3Address.TabIndex = 58
        Me.lblDr3Address.Text = "Address"
        '
        'lblDr3Educ
        '
        Me.lblDr3Educ.AutoSize = True
        Me.lblDr3Educ.BackColor = System.Drawing.Color.Transparent
        Me.lblDr3Educ.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDr3Educ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblDr3Educ.Location = New System.Drawing.Point(40, 370)
        Me.lblDr3Educ.Name = "lblDr3Educ"
        Me.lblDr3Educ.Size = New System.Drawing.Size(68, 18)
        Me.lblDr3Educ.TabIndex = 59
        Me.lblDr3Educ.Text = "Education"
        '
        'txtDr3Educ
        '
        Me.txtDr3Educ.Enabled = False
        Me.txtDr3Educ.Font = New System.Drawing.Font("Nunito", 7.799999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr3Educ.Location = New System.Drawing.Point(908, 567)
        Me.txtDr3Educ.Multiline = True
        Me.txtDr3Educ.Name = "txtDr3Educ"
        Me.txtDr3Educ.Size = New System.Drawing.Size(256, 43)
        Me.txtDr3Educ.TabIndex = 60
        Me.txtDr3Educ.Text = "Saint Louis University"
        '
        'pnlDr3
        '
        Me.pnlDr3.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pnlDr3.Controls.Add(Me.pbxDr3)
        Me.pnlDr3.Controls.Add(Me.lblDr3)
        Me.pnlDr3.Controls.Add(Me.lblDr3Educ)
        Me.pnlDr3.Controls.Add(Me.lblDr3Name)
        Me.pnlDr3.Controls.Add(Me.lblDr3Address)
        Me.pnlDr3.Controls.Add(Me.lblDr3Age)
        Me.pnlDr3.Controls.Add(Me.lblDr3Gender)
        Me.pnlDr3.Location = New System.Drawing.Point(869, 176)
        Me.pnlDr3.Name = "pnlDr3"
        Me.pnlDr3.Size = New System.Drawing.Size(335, 454)
        Me.pnlDr3.TabIndex = 25
        '
        'lblMaxPatients
        '
        Me.lblMaxPatients.AutoSize = True
        Me.lblMaxPatients.BackColor = System.Drawing.Color.Transparent
        Me.lblMaxPatients.Font = New System.Drawing.Font("Nunito", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPatients.ForeColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblMaxPatients.Location = New System.Drawing.Point(436, 83)
        Me.lblMaxPatients.Name = "lblMaxPatients"
        Me.lblMaxPatients.Size = New System.Drawing.Size(403, 23)
        Me.lblMaxPatients.TabIndex = 61
        Me.lblMaxPatients.Text = "Doctors can accomodate up to 5 patients per day."
        '
        'pbxDr1
        '
        Me.pbxDr1.Image = Global.NOMG.My.Resources.Resources.Dr_1_Profile
        Me.pbxDr1.Location = New System.Drawing.Point(106, 47)
        Me.pbxDr1.Name = "pbxDr1"
        Me.pbxDr1.Size = New System.Drawing.Size(124, 124)
        Me.pbxDr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDr1.TabIndex = 0
        Me.pbxDr1.TabStop = False
        '
        'pbxDr2
        '
        Me.pbxDr2.Image = Global.NOMG.My.Resources.Resources.Dr_2_Profile
        Me.pbxDr2.Location = New System.Drawing.Point(107, 47)
        Me.pbxDr2.Name = "pbxDr2"
        Me.pbxDr2.Size = New System.Drawing.Size(124, 124)
        Me.pbxDr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDr2.TabIndex = 0
        Me.pbxDr2.TabStop = False
        '
        'pbxDr3
        '
        Me.pbxDr3.Image = Global.NOMG.My.Resources.Resources.Dr_3_Profile
        Me.pbxDr3.Location = New System.Drawing.Point(105, 47)
        Me.pbxDr3.Name = "pbxDr3"
        Me.pbxDr3.Size = New System.Drawing.Size(124, 124)
        Me.pbxDr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDr3.TabIndex = 0
        Me.pbxDr3.TabStop = False
        '
        'frmDoctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1282, 801)
        Me.Controls.Add(Me.lblMaxPatients)
        Me.Controls.Add(Me.txtDr3Educ)
        Me.Controls.Add(Me.txtDr3Address)
        Me.Controls.Add(Me.txtDr3Gender)
        Me.Controls.Add(Me.txtDr3Age)
        Me.Controls.Add(Me.txtDr3Name)
        Me.Controls.Add(Me.txtDr2Educ)
        Me.Controls.Add(Me.txtDr2Address)
        Me.Controls.Add(Me.txtDr2Gender)
        Me.Controls.Add(Me.txtDr2Age)
        Me.Controls.Add(Me.txtDr2Name)
        Me.Controls.Add(Me.txtDr1Educ)
        Me.Controls.Add(Me.txtDr1Address)
        Me.Controls.Add(Me.txtDr1Gender)
        Me.Controls.Add(Me.txtDr1Age)
        Me.Controls.Add(Me.txtDr1Name)
        Me.Controls.Add(Me.pnlDr1)
        Me.Controls.Add(Me.lblAdditionalInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pnlDr2)
        Me.Controls.Add(Me.pnlDr3)
        Me.Name = "frmDoctors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctors"
        Me.pnlDr1.ResumeLayout(False)
        Me.pnlDr1.PerformLayout()
        Me.pnlDr2.ResumeLayout(False)
        Me.pnlDr2.PerformLayout()
        Me.pnlDr3.ResumeLayout(False)
        Me.pnlDr3.PerformLayout()
        CType(Me.pbxDr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDr3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents lblAdditionalInfo As Label
    Friend WithEvents pnlDr1 As Panel
    Friend WithEvents txtDr1Name As TextBox
    Friend WithEvents lblDr1Name As Label
    Friend WithEvents lblDr1Age As Label
    Friend WithEvents txtDr1Age As TextBox
    Friend WithEvents txtDr1Gender As TextBox
    Friend WithEvents txtDr1Address As TextBox
    Friend WithEvents lblDr1Address As Label
    Friend WithEvents lblDr1Gender As Label
    Friend WithEvents lblDr1Educ As Label
    Friend WithEvents txtDr1Educ As TextBox
    Friend WithEvents lblDr1 As Label
    Friend WithEvents pbxDr1 As PictureBox
    Friend WithEvents lblDr2 As Label
    Friend WithEvents lblDr3 As Label
    Friend WithEvents lblDr2Name As Label
    Friend WithEvents txtDr2Name As TextBox
    Friend WithEvents lblDr2Age As Label
    Friend WithEvents lblDr2Gender As Label
    Friend WithEvents txtDr2Age As TextBox
    Friend WithEvents txtDr2Gender As TextBox
    Friend WithEvents lblDr2Address As Label
    Friend WithEvents txtDr2Address As TextBox
    Friend WithEvents txtDr2Educ As TextBox
    Friend WithEvents lblDr2Educ As Label
    Friend WithEvents pnlDr2 As Panel
    Friend WithEvents pbxDr2 As PictureBox
    Friend WithEvents lblDr3Name As Label
    Friend WithEvents txtDr3Name As TextBox
    Friend WithEvents lblDr3Age As Label
    Friend WithEvents lblDr3Gender As Label
    Friend WithEvents txtDr3Age As TextBox
    Friend WithEvents txtDr3Gender As TextBox
    Friend WithEvents txtDr3Address As TextBox
    Friend WithEvents lblDr3Address As Label
    Friend WithEvents lblDr3Educ As Label
    Friend WithEvents txtDr3Educ As TextBox
    Friend WithEvents pnlDr3 As Panel
    Friend WithEvents pbxDr3 As PictureBox
    Friend WithEvents lblMaxPatients As Label
End Class
