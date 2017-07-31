<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjMng
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.lblDate = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.txtPlatform = New System.Windows.Forms.TextBox
        Me.rdbthree = New System.Windows.Forms.RadioButton
        Me.lblPlatform = New System.Windows.Forms.Label
        Me.rdbtwo = New System.Windows.Forms.RadioButton
        Me.lblnoofstud = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.cmbGrp = New System.Windows.Forms.ComboBox
        Me.lblGroup = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.lblYr = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSem = New System.Windows.Forms.ComboBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lblSem = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.grpGrid = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.btnInsert = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnPrev = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.lblstud1 = New System.Windows.Forms.Label
        Me.lblstud2 = New System.Windows.Forms.Label
        Me.lblstud3 = New System.Windows.Forms.Label
        Me.cmbstud1 = New System.Windows.Forms.ComboBox
        Me.cmbstud2 = New System.Windows.Forms.ComboBox
        Me.cmbstud3 = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.grpGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.txtCompany)
        Me.Panel1.Controls.Add(Me.lblCompany)
        Me.Panel1.Controls.Add(Me.txtPlatform)
        Me.Panel1.Controls.Add(Me.rdbthree)
        Me.Panel1.Controls.Add(Me.lblPlatform)
        Me.Panel1.Controls.Add(Me.rdbtwo)
        Me.Panel1.Controls.Add(Me.lblnoofstud)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.cmbGrp)
        Me.Panel1.Controls.Add(Me.lblGroup)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.txtDesc)
        Me.Panel1.Controls.Add(Me.lblYr)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbSem)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblSem)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Location = New System.Drawing.Point(12, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1323, 169)
        Me.Panel1.TabIndex = 2
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(1132, 13)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(153, 26)
        Me.txtDate.TabIndex = 45
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1075, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(49, 19)
        Me.lblDate.TabIndex = 44
        Me.lblDate.Text = "Date:"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(125, 98)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(303, 26)
        Me.txtCompany.TabIndex = 6
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(12, 98)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(86, 19)
        Me.lblCompany.TabIndex = 42
        Me.lblCompany.Text = "Company:"
        '
        'txtPlatform
        '
        Me.txtPlatform.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatform.Location = New System.Drawing.Point(537, 57)
        Me.txtPlatform.Name = "txtPlatform"
        Me.txtPlatform.Size = New System.Drawing.Size(229, 26)
        Me.txtPlatform.TabIndex = 4
        '
        'rdbthree
        '
        Me.rdbthree.AutoSize = True
        Me.rdbthree.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbthree.Location = New System.Drawing.Point(217, 140)
        Me.rdbthree.Name = "rdbthree"
        Me.rdbthree.Size = New System.Drawing.Size(70, 23)
        Me.rdbthree.TabIndex = 9
        Me.rdbthree.TabStop = True
        Me.rdbthree.Text = "Three"
        Me.rdbthree.UseVisualStyleBackColor = True
        '
        'lblPlatform
        '
        Me.lblPlatform.AutoSize = True
        Me.lblPlatform.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlatform.Location = New System.Drawing.Point(444, 57)
        Me.lblPlatform.Name = "lblPlatform"
        Me.lblPlatform.Size = New System.Drawing.Size(76, 19)
        Me.lblPlatform.TabIndex = 40
        Me.lblPlatform.Text = "Platform:"
        '
        'rdbtwo
        '
        Me.rdbtwo.AutoSize = True
        Me.rdbtwo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtwo.Location = New System.Drawing.Point(145, 139)
        Me.rdbtwo.Name = "rdbtwo"
        Me.rdbtwo.Size = New System.Drawing.Size(57, 23)
        Me.rdbtwo.TabIndex = 8
        Me.rdbtwo.TabStop = True
        Me.rdbtwo.Text = "Two"
        Me.rdbtwo.UseVisualStyleBackColor = True
        '
        'lblnoofstud
        '
        Me.lblnoofstud.AutoSize = True
        Me.lblnoofstud.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoofstud.Location = New System.Drawing.Point(12, 140)
        Me.lblnoofstud.Name = "lblnoofstud"
        Me.lblnoofstud.Size = New System.Drawing.Size(124, 19)
        Me.lblnoofstud.TabIndex = 35
        Me.lblnoofstud.Text = "No Of Students:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(127, 54)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(288, 26)
        Me.txtTitle.TabIndex = 3
        '
        'cmbGrp
        '
        Me.cmbGrp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbGrp.DropDownHeight = 100
        Me.cmbGrp.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrp.FormattingEnabled = True
        Me.cmbGrp.IntegralHeight = False
        Me.cmbGrp.Location = New System.Drawing.Point(537, 95)
        Me.cmbGrp.MaxLength = 10
        Me.cmbGrp.Name = "cmbGrp"
        Me.cmbGrp.Size = New System.Drawing.Size(244, 27)
        Me.cmbGrp.TabIndex = 7
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.Location = New System.Drawing.Point(447, 101)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(62, 19)
        Me.lblGroup.TabIndex = 27
        Me.lblGroup.Text = "Group:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(100, 19)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Project Title:"
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbYear.DropDownHeight = 100
        Me.cmbYear.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.Location = New System.Drawing.Point(852, 13)
        Me.cmbYear.MaxLength = 10
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(178, 27)
        Me.cmbYear.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(953, 61)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(358, 26)
        Me.txtDesc.TabIndex = 5
        '
        'lblYr
        '
        Me.lblYr.AutoSize = True
        Me.lblYr.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYr.Location = New System.Drawing.Point(776, 17)
        Me.lblYr.Name = "lblYr"
        Me.lblYr.Size = New System.Drawing.Size(49, 19)
        Me.lblYr.TabIndex = 20
        Me.lblYr.Text = "Year:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(791, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Project Discription:"
        '
        'cmbSem
        '
        Me.cmbSem.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbSem.DropDownHeight = 100
        Me.cmbSem.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.IntegralHeight = False
        Me.cmbSem.Location = New System.Drawing.Point(537, 13)
        Me.cmbSem.MaxLength = 10
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(178, 27)
        Me.cmbSem.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(130, 10)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(153, 26)
        Me.txtId.TabIndex = 0
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(437, 13)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(83, 19)
        Me.lblSem.TabIndex = 1
        Me.lblSem.Text = "Semester:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(8, 13)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(84, 19)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Project Id:"
        '
        'grpGrid
        '
        Me.grpGrid.Controls.Add(Me.DataGridView1)
        Me.grpGrid.Font = New System.Drawing.Font("Cambria", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGrid.Location = New System.Drawing.Point(16, 351)
        Me.grpGrid.Name = "grpGrid"
        Me.grpGrid.Size = New System.Drawing.Size(1388, 290)
        Me.grpGrid.TabIndex = 10
        Me.grpGrid.TabStop = False
        Me.grpGrid.Text = "Recently Added"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column7, Me.Column9, Me.Column10, Me.Column6, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(1, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1389, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'Column2
        '
        Me.Column2.HeaderText = "Project Id"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 90
        '
        'Column7
        '
        Me.Column7.HeaderText = "Project Title"
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.Width = 230
        '
        'Column9
        '
        Me.Column9.HeaderText = "Company"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 200
        '
        'Column10
        '
        Me.Column10.HeaderText = "Platform"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "Group Faculty"
        Me.Column6.Name = "Column6"
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column6.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Student Name"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInsert.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.Location = New System.Drawing.Point(197, 655)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(195, 33)
        Me.btnInsert.TabIndex = 13
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(841, 654)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(201, 33)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLast.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(692, 655)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(63, 33)
        Me.btnLast.TabIndex = 17
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(617, 655)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(63, 33)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrev.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(532, 655)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(63, 33)
        Me.btnPrev.TabIndex = 15
        Me.btnPrev.Text = "<<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFirst.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(458, 654)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(63, 33)
        Me.btnFirst.TabIndex = 14
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'lblstud1
        '
        Me.lblstud1.AutoSize = True
        Me.lblstud1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstud1.Location = New System.Drawing.Point(24, 213)
        Me.lblstud1.Name = "lblstud1"
        Me.lblstud1.Size = New System.Drawing.Size(83, 19)
        Me.lblstud1.TabIndex = 34
        Me.lblstud1.Text = "Student 1:"
        '
        'lblstud2
        '
        Me.lblstud2.AutoSize = True
        Me.lblstud2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstud2.Location = New System.Drawing.Point(24, 255)
        Me.lblstud2.Name = "lblstud2"
        Me.lblstud2.Size = New System.Drawing.Size(83, 19)
        Me.lblstud2.TabIndex = 36
        Me.lblstud2.Text = "Student 2:"
        '
        'lblstud3
        '
        Me.lblstud3.AutoSize = True
        Me.lblstud3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstud3.Location = New System.Drawing.Point(24, 296)
        Me.lblstud3.Name = "lblstud3"
        Me.lblstud3.Size = New System.Drawing.Size(83, 19)
        Me.lblstud3.TabIndex = 38
        Me.lblstud3.Text = "Student 3:"
        '
        'cmbstud1
        '
        Me.cmbstud1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbstud1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbstud1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbstud1.DropDownHeight = 100
        Me.cmbstud1.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstud1.FormattingEnabled = True
        Me.cmbstud1.IntegralHeight = False
        Me.cmbstud1.Location = New System.Drawing.Point(126, 210)
        Me.cmbstud1.MaxLength = 10
        Me.cmbstud1.Name = "cmbstud1"
        Me.cmbstud1.Size = New System.Drawing.Size(301, 27)
        Me.cmbstud1.TabIndex = 10
        '
        'cmbstud2
        '
        Me.cmbstud2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbstud2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbstud2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbstud2.DropDownHeight = 100
        Me.cmbstud2.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstud2.FormattingEnabled = True
        Me.cmbstud2.IntegralHeight = False
        Me.cmbstud2.Location = New System.Drawing.Point(126, 252)
        Me.cmbstud2.MaxLength = 10
        Me.cmbstud2.Name = "cmbstud2"
        Me.cmbstud2.Size = New System.Drawing.Size(301, 27)
        Me.cmbstud2.TabIndex = 11
        '
        'cmbstud3
        '
        Me.cmbstud3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbstud3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbstud3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbstud3.DropDownHeight = 100
        Me.cmbstud3.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstud3.FormattingEnabled = True
        Me.cmbstud3.IntegralHeight = False
        Me.cmbstud3.Location = New System.Drawing.Point(126, 293)
        Me.cmbstud3.MaxLength = 10
        Me.cmbstud3.Name = "cmbstud3"
        Me.cmbstud3.Size = New System.Drawing.Size(301, 27)
        Me.cmbstud3.TabIndex = 12
        '
        'frmProjectDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1175, 709)
        Me.Controls.Add(Me.cmbstud3)
        Me.Controls.Add(Me.cmbstud2)
        Me.Controls.Add(Me.cmbstud1)
        Me.Controls.Add(Me.lblstud3)
        Me.Controls.Add(Me.lblstud2)
        Me.Controls.Add(Me.lblstud1)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.grpGrid)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProjectDetail"
        Me.Text = "PROJECT DETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpGrid.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblYr As System.Windows.Forms.Label
    Friend WithEvents cmbSem As System.Windows.Forms.ComboBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblSem As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents cmbGrp As System.Windows.Forms.ComboBox
    Friend WithEvents grpGrid As System.Windows.Forms.GroupBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblstud1 As System.Windows.Forms.Label
    Friend WithEvents lblstud2 As System.Windows.Forms.Label
    Friend WithEvents lblstud3 As System.Windows.Forms.Label
    Friend WithEvents rdbtwo As System.Windows.Forms.RadioButton
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbthree As System.Windows.Forms.RadioButton
    Friend WithEvents lblnoofstud As System.Windows.Forms.Label
    Friend WithEvents txtPlatform As System.Windows.Forms.TextBox
    Friend WithEvents lblPlatform As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmbstud1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstud2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstud3 As System.Windows.Forms.ComboBox
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
