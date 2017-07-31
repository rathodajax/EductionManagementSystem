<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyFristForm
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
        Me.TabMainForm = New System.Windows.Forms.TabControl
        Me.TabGenDetail = New System.Windows.Forms.TabPage
        Me.GrpBoxRegInfo = New System.Windows.Forms.GroupBox
        Me.cmbAdType = New System.Windows.Forms.ComboBox
        Me.lblAdType = New System.Windows.Forms.Label
        Me.cmbRegYear = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.txtFeesTot = New System.Windows.Forms.TextBox
        Me.txtUniqueId = New System.Windows.Forms.TextBox
        Me.txtCmatNo = New System.Windows.Forms.TextBox
        Me.txtStudId = New System.Windows.Forms.TextBox
        Me.GrpBecDegInfo = New System.Windows.Forms.GroupBox
        Me.cmbBechDegreeClg = New System.Windows.Forms.ComboBox
        Me.cmbBechDegreeName = New System.Windows.Forms.ComboBox
        Me.txtBechDegreePer = New System.Windows.Forms.TextBox
        Me.LblBechDegreeClg = New System.Windows.Forms.Label
        Me.LblBechDegreePer = New System.Windows.Forms.Label
        Me.LblBechDegreeName = New System.Windows.Forms.Label
        Me.LblFeesTot = New System.Windows.Forms.Label
        Me.LblUniqueId = New System.Windows.Forms.Label
        Me.LblStudId = New System.Windows.Forms.Label
        Me.LblRegYear = New System.Windows.Forms.Label
        Me.LblCmatNo = New System.Windows.Forms.Label
        Me.LblRegDate = New System.Windows.Forms.Label
        Me.GrpBoxPrsnlDetail = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtMobNo = New System.Windows.Forms.TextBox
        Me.txtPhoneNo = New System.Windows.Forms.TextBox
        Me.txtCAdd = New System.Windows.Forms.TextBox
        Me.txtAdd = New System.Windows.Forms.TextBox
        Me.cmbCast = New System.Windows.Forms.ComboBox
        Me.rbFemale = New System.Windows.Forms.RadioButton
        Me.rbMale = New System.Windows.Forms.RadioButton
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtRollNo = New System.Windows.Forms.TextBox
        Me.LblDOB = New System.Windows.Forms.Label
        Me.LblEmail = New System.Windows.Forms.Label
        Me.LblMobNo = New System.Windows.Forms.Label
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblCAdd = New System.Windows.Forms.Label
        Me.LblAdd = New System.Windows.Forms.Label
        Me.LblCast = New System.Windows.Forms.Label
        Me.LblGender = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.Label
        Me.LblRollNo = New System.Windows.Forms.Label
        Me.TabPhotoUpload = New System.Windows.Forms.TabPage
        Me.btnPayFees = New System.Windows.Forms.Button
        Me.btnUploadDoc = New System.Windows.Forms.Button
        Me.btnBrawse = New System.Windows.Forms.Button
        Me.picUploadDoc = New System.Windows.Forms.PictureBox
        Me.picUploadImg = New System.Windows.Forms.PictureBox
        Me.LblTitle = New System.Windows.Forms.Label
        Me.TabConfirm = New System.Windows.Forms.TabPage
        Me.btnCancle = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.LblConfirm = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabMainForm.SuspendLayout()
        Me.TabGenDetail.SuspendLayout()
        Me.GrpBoxRegInfo.SuspendLayout()
        Me.GrpBecDegInfo.SuspendLayout()
        Me.GrpBoxPrsnlDetail.SuspendLayout()
        Me.TabPhotoUpload.SuspendLayout()
        CType(Me.picUploadDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUploadImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConfirm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabMainForm
        '
        Me.TabMainForm.Controls.Add(Me.TabGenDetail)
        Me.TabMainForm.Controls.Add(Me.TabPhotoUpload)
        Me.TabMainForm.Controls.Add(Me.TabConfirm)
        Me.TabMainForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMainForm.Location = New System.Drawing.Point(1, 1)
        Me.TabMainForm.Name = "TabMainForm"
        Me.TabMainForm.SelectedIndex = 0
        Me.TabMainForm.Size = New System.Drawing.Size(1342, 695)
        Me.TabMainForm.TabIndex = 0
        '
        'TabGenDetail
        '
        Me.TabGenDetail.BackColor = System.Drawing.Color.White
        Me.TabGenDetail.Controls.Add(Me.GrpBoxRegInfo)
        Me.TabGenDetail.Controls.Add(Me.GrpBoxPrsnlDetail)
        Me.TabGenDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabGenDetail.Location = New System.Drawing.Point(4, 27)
        Me.TabGenDetail.Name = "TabGenDetail"
        Me.TabGenDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGenDetail.Size = New System.Drawing.Size(1334, 664)
        Me.TabGenDetail.TabIndex = 0
        Me.TabGenDetail.Text = "General Details"
        '
        'GrpBoxRegInfo
        '
        Me.GrpBoxRegInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrpBoxRegInfo.Controls.Add(Me.cmbAdType)
        Me.GrpBoxRegInfo.Controls.Add(Me.lblAdType)
        Me.GrpBoxRegInfo.Controls.Add(Me.cmbRegYear)
        Me.GrpBoxRegInfo.Controls.Add(Me.DateTimePicker2)
        Me.GrpBoxRegInfo.Controls.Add(Me.txtFeesTot)
        Me.GrpBoxRegInfo.Controls.Add(Me.txtUniqueId)
        Me.GrpBoxRegInfo.Controls.Add(Me.txtCmatNo)
        Me.GrpBoxRegInfo.Controls.Add(Me.txtStudId)
        Me.GrpBoxRegInfo.Controls.Add(Me.GrpBecDegInfo)
        Me.GrpBoxRegInfo.Controls.Add(Me.LblFeesTot)
        Me.GrpBoxRegInfo.Controls.Add(Me.LblUniqueId)
        Me.GrpBoxRegInfo.Controls.Add(Me.LblStudId)
        Me.GrpBoxRegInfo.Controls.Add(Me.LblRegYear)
        Me.GrpBoxRegInfo.Controls.Add(Me.LblCmatNo)
        Me.GrpBoxRegInfo.Controls.Add(Me.LblRegDate)
        Me.GrpBoxRegInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxRegInfo.Location = New System.Drawing.Point(7, 4)
        Me.GrpBoxRegInfo.Name = "GrpBoxRegInfo"
        Me.GrpBoxRegInfo.Size = New System.Drawing.Size(623, 654)
        Me.GrpBoxRegInfo.TabIndex = 7
        Me.GrpBoxRegInfo.TabStop = False
        Me.GrpBoxRegInfo.Text = "Regstration Info"
        '
        'cmbAdType
        '
        Me.cmbAdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdType.FormattingEnabled = True
        Me.cmbAdType.Location = New System.Drawing.Point(228, 383)
        Me.cmbAdType.Name = "cmbAdType"
        Me.cmbAdType.Size = New System.Drawing.Size(200, 26)
        Me.cmbAdType.TabIndex = 9
        '
        'lblAdType
        '
        Me.lblAdType.AutoSize = True
        Me.lblAdType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdType.Location = New System.Drawing.Point(21, 386)
        Me.lblAdType.Name = "lblAdType"
        Me.lblAdType.Size = New System.Drawing.Size(127, 18)
        Me.lblAdType.TabIndex = 8
        Me.lblAdType.Text = "Admission Type"
        '
        'cmbRegYear
        '
        Me.cmbRegYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegYear.FormattingEnabled = True
        Me.cmbRegYear.Location = New System.Drawing.Point(228, 95)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(205, 26)
        Me.cmbRegYear.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(228, 207)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker2.TabIndex = 4
        '
        'txtFeesTot
        '
        Me.txtFeesTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeesTot.Location = New System.Drawing.Point(228, 327)
        Me.txtFeesTot.Name = "txtFeesTot"
        Me.txtFeesTot.Size = New System.Drawing.Size(205, 24)
        Me.txtFeesTot.TabIndex = 6
        '
        'txtUniqueId
        '
        Me.txtUniqueId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUniqueId.Location = New System.Drawing.Point(228, 261)
        Me.txtUniqueId.Name = "txtUniqueId"
        Me.txtUniqueId.Size = New System.Drawing.Size(205, 24)
        Me.txtUniqueId.TabIndex = 5
        '
        'txtCmatNo
        '
        Me.txtCmatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmatNo.Location = New System.Drawing.Point(228, 152)
        Me.txtCmatNo.Name = "txtCmatNo"
        Me.txtCmatNo.Size = New System.Drawing.Size(205, 24)
        Me.txtCmatNo.TabIndex = 3
        '
        'txtStudId
        '
        Me.txtStudId.Enabled = False
        Me.txtStudId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudId.Location = New System.Drawing.Point(228, 39)
        Me.txtStudId.Name = "txtStudId"
        Me.txtStudId.Size = New System.Drawing.Size(205, 24)
        Me.txtStudId.TabIndex = 1
        '
        'GrpBecDegInfo
        '
        Me.GrpBecDegInfo.Controls.Add(Me.cmbBechDegreeClg)
        Me.GrpBecDegInfo.Controls.Add(Me.cmbBechDegreeName)
        Me.GrpBecDegInfo.Controls.Add(Me.txtBechDegreePer)
        Me.GrpBecDegInfo.Controls.Add(Me.LblBechDegreeClg)
        Me.GrpBecDegInfo.Controls.Add(Me.LblBechDegreePer)
        Me.GrpBecDegInfo.Controls.Add(Me.LblBechDegreeName)
        Me.GrpBecDegInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBecDegInfo.Location = New System.Drawing.Point(6, 432)
        Me.GrpBecDegInfo.Name = "GrpBecDegInfo"
        Me.GrpBecDegInfo.Size = New System.Drawing.Size(611, 208)
        Me.GrpBecDegInfo.TabIndex = 6
        Me.GrpBecDegInfo.TabStop = False
        Me.GrpBecDegInfo.Text = "Becholor Degree Info"
        '
        'cmbBechDegreeClg
        '
        Me.cmbBechDegreeClg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBechDegreeClg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBechDegreeClg.FormattingEnabled = True
        Me.cmbBechDegreeClg.Location = New System.Drawing.Point(222, 151)
        Me.cmbBechDegreeClg.Name = "cmbBechDegreeClg"
        Me.cmbBechDegreeClg.Size = New System.Drawing.Size(353, 26)
        Me.cmbBechDegreeClg.TabIndex = 9
        '
        'cmbBechDegreeName
        '
        Me.cmbBechDegreeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBechDegreeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBechDegreeName.FormattingEnabled = True
        Me.cmbBechDegreeName.Location = New System.Drawing.Point(222, 38)
        Me.cmbBechDegreeName.Name = "cmbBechDegreeName"
        Me.cmbBechDegreeName.Size = New System.Drawing.Size(205, 26)
        Me.cmbBechDegreeName.TabIndex = 7
        '
        'txtBechDegreePer
        '
        Me.txtBechDegreePer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBechDegreePer.Location = New System.Drawing.Point(222, 93)
        Me.txtBechDegreePer.Name = "txtBechDegreePer"
        Me.txtBechDegreePer.Size = New System.Drawing.Size(205, 24)
        Me.txtBechDegreePer.TabIndex = 8
        '
        'LblBechDegreeClg
        '
        Me.LblBechDegreeClg.AutoSize = True
        Me.LblBechDegreeClg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBechDegreeClg.Location = New System.Drawing.Point(22, 154)
        Me.LblBechDegreeClg.Name = "LblBechDegreeClg"
        Me.LblBechDegreeClg.Size = New System.Drawing.Size(86, 18)
        Me.LblBechDegreeClg.TabIndex = 2
        Me.LblBechDegreeClg.Text = "COLLEGE"
        '
        'LblBechDegreePer
        '
        Me.LblBechDegreePer.AutoSize = True
        Me.LblBechDegreePer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBechDegreePer.Location = New System.Drawing.Point(22, 99)
        Me.LblBechDegreePer.Name = "LblBechDegreePer"
        Me.LblBechDegreePer.Size = New System.Drawing.Size(121, 18)
        Me.LblBechDegreePer.TabIndex = 1
        Me.LblBechDegreePer.Text = "PERCENTAGE"
        '
        'LblBechDegreeName
        '
        Me.LblBechDegreeName.AutoSize = True
        Me.LblBechDegreeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBechDegreeName.Location = New System.Drawing.Point(21, 46)
        Me.LblBechDegreeName.Name = "LblBechDegreeName"
        Me.LblBechDegreeName.Size = New System.Drawing.Size(130, 18)
        Me.LblBechDegreeName.TabIndex = 0
        Me.LblBechDegreeName.Text = "DEGREE NAME"
        '
        'LblFeesTot
        '
        Me.LblFeesTot.AutoSize = True
        Me.LblFeesTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFeesTot.Location = New System.Drawing.Point(18, 330)
        Me.LblFeesTot.Name = "LblFeesTot"
        Me.LblFeesTot.Size = New System.Drawing.Size(108, 18)
        Me.LblFeesTot.TabIndex = 5
        Me.LblFeesTot.Text = "FEES TOTAL"
        '
        'LblUniqueId
        '
        Me.LblUniqueId.AutoSize = True
        Me.LblUniqueId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUniqueId.Location = New System.Drawing.Point(18, 267)
        Me.LblUniqueId.Name = "LblUniqueId"
        Me.LblUniqueId.Size = New System.Drawing.Size(93, 18)
        Me.LblUniqueId.TabIndex = 4
        Me.LblUniqueId.Text = "UNIQUE ID"
        '
        'LblStudId
        '
        Me.LblStudId.AutoSize = True
        Me.LblStudId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudId.Location = New System.Drawing.Point(18, 40)
        Me.LblStudId.Name = "LblStudId"
        Me.LblStudId.Size = New System.Drawing.Size(107, 18)
        Me.LblStudId.TabIndex = 0
        Me.LblStudId.Text = "STUDENT ID"
        '
        'LblRegYear
        '
        Me.LblRegYear.AutoSize = True
        Me.LblRegYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegYear.Location = New System.Drawing.Point(18, 95)
        Me.LblRegYear.Name = "LblRegYear"
        Me.LblRegYear.Size = New System.Drawing.Size(168, 18)
        Me.LblRegYear.TabIndex = 1
        Me.LblRegYear.Text = "REGISTRAION YEAR"
        '
        'LblCmatNo
        '
        Me.LblCmatNo.AutoSize = True
        Me.LblCmatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCmatNo.Location = New System.Drawing.Point(18, 152)
        Me.LblCmatNo.Name = "LblCmatNo"
        Me.LblCmatNo.Size = New System.Drawing.Size(131, 18)
        Me.LblCmatNo.TabIndex = 2
        Me.LblCmatNo.Text = "CMAT NUMBER"
        '
        'LblRegDate
        '
        Me.LblRegDate.AutoSize = True
        Me.LblRegDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegDate.Location = New System.Drawing.Point(18, 215)
        Me.LblRegDate.Name = "LblRegDate"
        Me.LblRegDate.Size = New System.Drawing.Size(178, 18)
        Me.LblRegDate.TabIndex = 3
        Me.LblRegDate.Text = "REGISTRATION DATE"
        '
        'GrpBoxPrsnlDetail
        '
        Me.GrpBoxPrsnlDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.GroupBox1)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.Label1)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.DateTimePicker1)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtEmail)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtMobNo)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtPhoneNo)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtCAdd)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtAdd)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.cmbCast)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.rbFemale)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.rbMale)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtName)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.txtRollNo)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblDOB)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblEmail)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblMobNo)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblPhoneNo)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblCAdd)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblAdd)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblCast)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblGender)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblName)
        Me.GrpBoxPrsnlDetail.Controls.Add(Me.LblRollNo)
        Me.GrpBoxPrsnlDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxPrsnlDetail.Location = New System.Drawing.Point(637, 5)
        Me.GrpBoxPrsnlDetail.Name = "GrpBoxPrsnlDetail"
        Me.GrpBoxPrsnlDetail.Size = New System.Drawing.Size(667, 653)
        Me.GrpBoxPrsnlDetail.TabIndex = 6
        Me.GrpBoxPrsnlDetail.TabStop = False
        Me.GrpBoxPrsnlDetail.Text = "Personal Detail"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(159, 16)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(51, 22)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "NO"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 22)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "YES"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 585)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "IS ACTIVE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(242, 535)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker1.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(242, 491)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(206, 24)
        Me.txtEmail.TabIndex = 19
        '
        'txtMobNo
        '
        Me.txtMobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobNo.Location = New System.Drawing.Point(242, 448)
        Me.txtMobNo.Name = "txtMobNo"
        Me.txtMobNo.Size = New System.Drawing.Size(204, 24)
        Me.txtMobNo.TabIndex = 18
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(242, 409)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(204, 24)
        Me.txtPhoneNo.TabIndex = 17
        '
        'txtCAdd
        '
        Me.txtCAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCAdd.Location = New System.Drawing.Point(242, 332)
        Me.txtCAdd.Multiline = True
        Me.txtCAdd.Name = "txtCAdd"
        Me.txtCAdd.Size = New System.Drawing.Size(385, 58)
        Me.txtCAdd.TabIndex = 16
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(242, 249)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(385, 64)
        Me.txtAdd.TabIndex = 15
        '
        'cmbCast
        '
        Me.cmbCast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCast.FormattingEnabled = True
        Me.cmbCast.Location = New System.Drawing.Point(242, 206)
        Me.cmbCast.Name = "cmbCast"
        Me.cmbCast.Size = New System.Drawing.Size(180, 26)
        Me.cmbCast.TabIndex = 14
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFemale.Location = New System.Drawing.Point(390, 156)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(91, 22)
        Me.rbFemale.TabIndex = 13
        Me.rbFemale.Text = "FEMALE"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Checked = True
        Me.rbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMale.Location = New System.Drawing.Point(242, 156)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(70, 22)
        Me.rbMale.TabIndex = 12
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "MALE"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(242, 90)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 24)
        Me.txtName.TabIndex = 11
        '
        'txtRollNo
        '
        Me.txtRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRollNo.Location = New System.Drawing.Point(242, 34)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(196, 24)
        Me.txtRollNo.TabIndex = 10
        '
        'LblDOB
        '
        Me.LblDOB.AutoSize = True
        Me.LblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDOB.Location = New System.Drawing.Point(35, 540)
        Me.LblDOB.Name = "LblDOB"
        Me.LblDOB.Size = New System.Drawing.Size(133, 18)
        Me.LblDOB.TabIndex = 16
        Me.LblDOB.Text = "DATE OF BIRTH"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(35, 497)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(61, 18)
        Me.LblEmail.TabIndex = 15
        Me.LblEmail.Text = "EMAIL "
        '
        'LblMobNo
        '
        Me.LblMobNo.AutoSize = True
        Me.LblMobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMobNo.Location = New System.Drawing.Point(35, 454)
        Me.LblMobNo.Name = "LblMobNo"
        Me.LblMobNo.Size = New System.Drawing.Size(147, 18)
        Me.LblMobNo.TabIndex = 14
        Me.LblMobNo.Text = "MOBILE NUMBER"
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNo.Location = New System.Drawing.Point(35, 412)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(144, 18)
        Me.LblPhoneNo.TabIndex = 13
        Me.LblPhoneNo.Text = "PHONE NUMBER"
        '
        'LblCAdd
        '
        Me.LblCAdd.AutoSize = True
        Me.LblCAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCAdd.Location = New System.Drawing.Point(26, 332)
        Me.LblCAdd.Name = "LblCAdd"
        Me.LblCAdd.Size = New System.Drawing.Size(156, 36)
        Me.LblCAdd.TabIndex = 12
        Me.LblCAdd.Text = "CORRESPONDING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADDRESS"
        '
        'LblAdd
        '
        Me.LblAdd.AutoSize = True
        Me.LblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdd.Location = New System.Drawing.Point(35, 278)
        Me.LblAdd.Name = "LblAdd"
        Me.LblAdd.Size = New System.Drawing.Size(87, 18)
        Me.LblAdd.TabIndex = 11
        Me.LblAdd.Text = "ADDRESS"
        '
        'LblCast
        '
        Me.LblCast.AutoSize = True
        Me.LblCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCast.Location = New System.Drawing.Point(35, 214)
        Me.LblCast.Name = "LblCast"
        Me.LblCast.Size = New System.Drawing.Size(51, 18)
        Me.LblCast.TabIndex = 10
        Me.LblCast.Text = "CAST"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGender.Location = New System.Drawing.Point(32, 158)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(79, 18)
        Me.LblGender.TabIndex = 9
        Me.LblGender.Text = "GENDER"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(32, 95)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(55, 18)
        Me.LblName.TabIndex = 8
        Me.LblName.Text = "NAME"
        '
        'LblRollNo
        '
        Me.LblRollNo.AutoSize = True
        Me.LblRollNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRollNo.Location = New System.Drawing.Point(32, 40)
        Me.LblRollNo.Name = "LblRollNo"
        Me.LblRollNo.Size = New System.Drawing.Size(81, 18)
        Me.LblRollNo.TabIndex = 7
        Me.LblRollNo.Text = "ROLL NO"
        '
        'TabPhotoUpload
        '
        Me.TabPhotoUpload.BackColor = System.Drawing.Color.White
        Me.TabPhotoUpload.Controls.Add(Me.btnPayFees)
        Me.TabPhotoUpload.Controls.Add(Me.btnUploadDoc)
        Me.TabPhotoUpload.Controls.Add(Me.btnBrawse)
        Me.TabPhotoUpload.Controls.Add(Me.picUploadDoc)
        Me.TabPhotoUpload.Controls.Add(Me.picUploadImg)
        Me.TabPhotoUpload.Controls.Add(Me.LblTitle)
        Me.TabPhotoUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPhotoUpload.Location = New System.Drawing.Point(4, 27)
        Me.TabPhotoUpload.Name = "TabPhotoUpload"
        Me.TabPhotoUpload.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPhotoUpload.Size = New System.Drawing.Size(1334, 691)
        Me.TabPhotoUpload.TabIndex = 1
        Me.TabPhotoUpload.Text = "Photos Upload"
        '
        'btnPayFees
        '
        Me.btnPayFees.Location = New System.Drawing.Point(792, 448)
        Me.btnPayFees.Name = "btnPayFees"
        Me.btnPayFees.Size = New System.Drawing.Size(147, 50)
        Me.btnPayFees.TabIndex = 5
        Me.btnPayFees.Text = "Pay Fees"
        Me.btnPayFees.UseVisualStyleBackColor = True
        '
        'btnUploadDoc
        '
        Me.btnUploadDoc.Location = New System.Drawing.Point(579, 448)
        Me.btnUploadDoc.Name = "btnUploadDoc"
        Me.btnUploadDoc.Size = New System.Drawing.Size(148, 50)
        Me.btnUploadDoc.TabIndex = 4
        Me.btnUploadDoc.Text = "Upload Document"
        Me.btnUploadDoc.UseVisualStyleBackColor = True
        '
        'btnBrawse
        '
        Me.btnBrawse.Location = New System.Drawing.Point(361, 448)
        Me.btnBrawse.Name = "btnBrawse"
        Me.btnBrawse.Size = New System.Drawing.Size(136, 50)
        Me.btnBrawse.TabIndex = 3
        Me.btnBrawse.Text = "Brawse"
        Me.btnBrawse.UseVisualStyleBackColor = True
        '
        'picUploadDoc
        '
        Me.picUploadDoc.Location = New System.Drawing.Point(579, 252)
        Me.picUploadDoc.Name = "picUploadDoc"
        Me.picUploadDoc.Size = New System.Drawing.Size(148, 155)
        Me.picUploadDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUploadDoc.TabIndex = 2
        Me.picUploadDoc.TabStop = False
        '
        'picUploadImg
        '
        Me.picUploadImg.Location = New System.Drawing.Point(361, 253)
        Me.picUploadImg.Name = "picUploadImg"
        Me.picUploadImg.Size = New System.Drawing.Size(136, 155)
        Me.picUploadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUploadImg.TabIndex = 1
        Me.picUploadImg.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Red
        Me.LblTitle.Location = New System.Drawing.Point(340, 76)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(405, 34)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "UPLOAD YOUR FILES HERE"
        '
        'TabConfirm
        '
        Me.TabConfirm.Controls.Add(Me.btnCancle)
        Me.TabConfirm.Controls.Add(Me.btnSave)
        Me.TabConfirm.Controls.Add(Me.LblConfirm)
        Me.TabConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConfirm.Location = New System.Drawing.Point(4, 27)
        Me.TabConfirm.Name = "TabConfirm"
        Me.TabConfirm.Size = New System.Drawing.Size(1334, 664)
        Me.TabConfirm.TabIndex = 2
        Me.TabConfirm.Text = "Confirm Registration Form"
        Me.TabConfirm.UseVisualStyleBackColor = True
        '
        'btnCancle
        '
        Me.btnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancle.Location = New System.Drawing.Point(685, 329)
        Me.btnCancle.Name = "btnCancle"
        Me.btnCancle.Size = New System.Drawing.Size(171, 52)
        Me.btnCancle.TabIndex = 2
        Me.btnCancle.Text = "Cancle"
        Me.btnCancle.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(413, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(179, 52)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LblConfirm
        '
        Me.LblConfirm.AutoSize = True
        Me.LblConfirm.ForeColor = System.Drawing.Color.Red
        Me.LblConfirm.Location = New System.Drawing.Point(391, 163)
        Me.LblConfirm.Name = "LblConfirm"
        Me.LblConfirm.Size = New System.Drawing.Size(465, 54)
        Me.LblConfirm.TabIndex = 0
        Me.LblConfirm.Text = "Are You Sure About The  Data Entered By You Are Correct ? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "After Clicking On Sav" & _
            "e You Does Not Change Any Thing.." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conform Then Click On Save Otherwise Cancle"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 565)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 44)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'MyFristForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 746)
        Me.Controls.Add(Me.TabMainForm)
        Me.KeyPreview = True
        Me.Name = "MyFristForm"
        Me.Text = "Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabMainForm.ResumeLayout(False)
        Me.TabGenDetail.ResumeLayout(False)
        Me.GrpBoxRegInfo.ResumeLayout(False)
        Me.GrpBoxRegInfo.PerformLayout()
        Me.GrpBecDegInfo.ResumeLayout(False)
        Me.GrpBecDegInfo.PerformLayout()
        Me.GrpBoxPrsnlDetail.ResumeLayout(False)
        Me.GrpBoxPrsnlDetail.PerformLayout()
        Me.TabPhotoUpload.ResumeLayout(False)
        Me.TabPhotoUpload.PerformLayout()
        CType(Me.picUploadDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUploadImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConfirm.ResumeLayout(False)
        Me.TabConfirm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabMainForm As System.Windows.Forms.TabControl
    Friend WithEvents TabGenDetail As System.Windows.Forms.TabPage
    Friend WithEvents TabPhotoUpload As System.Windows.Forms.TabPage
    Friend WithEvents LblFeesTot As System.Windows.Forms.Label
    Friend WithEvents LblUniqueId As System.Windows.Forms.Label
    Friend WithEvents LblRegDate As System.Windows.Forms.Label
    Friend WithEvents LblCmatNo As System.Windows.Forms.Label
    Friend WithEvents LblRegYear As System.Windows.Forms.Label
    Friend WithEvents LblStudId As System.Windows.Forms.Label
    Friend WithEvents GrpBoxPrsnlDetail As System.Windows.Forms.GroupBox
    Friend WithEvents TabConfirm As System.Windows.Forms.TabPage
    Friend WithEvents GrpBoxRegInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBecDegInfo As System.Windows.Forms.GroupBox
    Friend WithEvents LblBechDegreeClg As System.Windows.Forms.Label
    Friend WithEvents LblBechDegreePer As System.Windows.Forms.Label
    Friend WithEvents LblBechDegreeName As System.Windows.Forms.Label
    Friend WithEvents LblDOB As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents LblMobNo As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblCAdd As System.Windows.Forms.Label
    Friend WithEvents LblAdd As System.Windows.Forms.Label
    Friend WithEvents LblCast As System.Windows.Forms.Label
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblRollNo As System.Windows.Forms.Label
    Friend WithEvents txtFeesTot As System.Windows.Forms.TextBox
    Friend WithEvents txtUniqueId As System.Windows.Forms.TextBox
    Friend WithEvents txtCmatNo As System.Windows.Forms.TextBox
    Friend WithEvents txtStudId As System.Windows.Forms.TextBox
    Friend WithEvents cmbBechDegreeClg As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBechDegreeName As System.Windows.Forms.ComboBox
    Friend WithEvents txtBechDegreePer As System.Windows.Forms.TextBox
    Friend WithEvents cmbCast As System.Windows.Forms.ComboBox
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtRollNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMobNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents picUploadImg As System.Windows.Forms.PictureBox
    Friend WithEvents picUploadDoc As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrawse As System.Windows.Forms.Button
    Friend WithEvents btnUploadDoc As System.Windows.Forms.Button
    Friend WithEvents btnPayFees As System.Windows.Forms.Button
    Friend WithEvents btnCancle As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents LblConfirm As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdType As System.Windows.Forms.Label
    Friend WithEvents cmbAdType As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
