<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalary
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tbcSalary = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvStaffTotalSalary = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.totalsalaryamount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpbSalaryAddUpdate = New System.Windows.Forms.GroupBox
        Me.btnAddSalary = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnTotalSalary = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTotalSalaryRecord = New System.Windows.Forms.Label
        Me.lblTotalSalaryLeave = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lbltotalleave = New System.Windows.Forms.Label
        Me.lblTotalSalary = New System.Windows.Forms.Label
        Me.gpbSalarySearch = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblStaffType = New System.Windows.Forms.Label
        Me.cmbStaffNameSearch = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.dgvStaffSalary = New System.Windows.Forms.DataGridView
        Me.salary_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staff_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staff_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.salary_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.salary_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.salary_leave_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staff_joining_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cmbStaffName = New System.Windows.Forms.ComboBox
        Me.salaryamount = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.addsalarydate = New System.Windows.Forms.DateTimePicker
        Me.clear = New System.Windows.Forms.Button
        Me.addsalary = New System.Windows.Forms.Button
        Me.leaveamount = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.fixsalary = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbAddSalaryStaffType = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.menupnl = New System.Windows.Forms.Panel
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbcSalary.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvStaffTotalSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbSalaryAddUpdate.SuspendLayout()
        Me.gpbSalarySearch.SuspendLayout()
        CType(Me.dgvStaffSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.menupnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcSalary
        '
        Me.tbcSalary.Controls.Add(Me.TabPage2)
        Me.tbcSalary.Controls.Add(Me.TabPage1)
        Me.tbcSalary.Controls.Add(Me.TabPage3)
        Me.tbcSalary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcSalary.Location = New System.Drawing.Point(201, 77)
        Me.tbcSalary.Name = "tbcSalary"
        Me.tbcSalary.SelectedIndex = 0
        Me.tbcSalary.Size = New System.Drawing.Size(1097, 588)
        Me.tbcSalary.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.gpbSalaryAddUpdate)
        Me.TabPage2.Controls.Add(Me.gpbSalarySearch)
        Me.TabPage2.Controls.Add(Me.dgvStaffSalary)
        Me.TabPage2.Controls.Add(Me.dgvStaffTotalSalary)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1089, 550)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salary details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvStaffTotalSalary
        '
        Me.dgvStaffTotalSalary.AllowUserToAddRows = False
        Me.dgvStaffTotalSalary.AllowUserToDeleteRows = False
        Me.dgvStaffTotalSalary.AllowUserToResizeColumns = False
        Me.dgvStaffTotalSalary.AllowUserToResizeRows = False
        Me.dgvStaffTotalSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStaffTotalSalary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStaffTotalSalary.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaffTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStaffTotalSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStaffTotalSalary.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStaffTotalSalary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvStaffTotalSalary.ColumnHeadersHeight = 58
        Me.dgvStaffTotalSalary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.totalsalaryamount})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaffTotalSalary.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvStaffTotalSalary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaffTotalSalary.EnableHeadersVisualStyles = False
        Me.dgvStaffTotalSalary.Location = New System.Drawing.Point(3, 3)
        Me.dgvStaffTotalSalary.MultiSelect = False
        Me.dgvStaffTotalSalary.Name = "dgvStaffTotalSalary"
        Me.dgvStaffTotalSalary.ReadOnly = True
        Me.dgvStaffTotalSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStaffTotalSalary.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvStaffTotalSalary.RowHeadersVisible = False
        Me.dgvStaffTotalSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStaffTotalSalary.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvStaffTotalSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvStaffTotalSalary.ShowCellErrors = False
        Me.dgvStaffTotalSalary.ShowCellToolTips = False
        Me.dgvStaffTotalSalary.ShowEditingIcon = False
        Me.dgvStaffTotalSalary.ShowRowErrors = False
        Me.dgvStaffTotalSalary.Size = New System.Drawing.Size(1083, 544)
        Me.dgvStaffTotalSalary.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Staff Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Staff Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 133
        '
        'totalsalaryamount
        '
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.totalsalaryamount.DefaultCellStyle = DataGridViewCellStyle10
        Me.totalsalaryamount.HeaderText = "Total Salary Amount"
        Me.totalsalaryamount.Name = "totalsalaryamount"
        Me.totalsalaryamount.ReadOnly = True
        Me.totalsalaryamount.Width = 227
        '
        'gpbSalaryAddUpdate
        '
        Me.gpbSalaryAddUpdate.Controls.Add(Me.btnAddSalary)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.btnPrint)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.btnCancel)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.btnTotalSalary)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.Label6)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.lblTotalSalaryRecord)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.lblTotalSalaryLeave)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.Label16)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.lbltotalleave)
        Me.gpbSalaryAddUpdate.Controls.Add(Me.lblTotalSalary)
        Me.gpbSalaryAddUpdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpbSalaryAddUpdate.Location = New System.Drawing.Point(3, 361)
        Me.gpbSalaryAddUpdate.Name = "gpbSalaryAddUpdate"
        Me.gpbSalaryAddUpdate.Size = New System.Drawing.Size(1083, 186)
        Me.gpbSalaryAddUpdate.TabIndex = 45
        Me.gpbSalaryAddUpdate.TabStop = False
        '
        'btnAddSalary
        '
        Me.btnAddSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddSalary.Location = New System.Drawing.Point(292, 118)
        Me.btnAddSalary.Name = "btnAddSalary"
        Me.btnAddSalary.Size = New System.Drawing.Size(186, 37)
        Me.btnAddSalary.TabIndex = 15
        Me.btnAddSalary.Text = "Add Salary"
        Me.btnAddSalary.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(649, 118)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 37)
        Me.btnPrint.TabIndex = 44
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(498, 118)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 37)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTotalSalary
        '
        Me.btnTotalSalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTotalSalary.Location = New System.Drawing.Point(794, 118)
        Me.btnTotalSalary.Name = "btnTotalSalary"
        Me.btnTotalSalary.Size = New System.Drawing.Size(267, 37)
        Me.btnTotalSalary.TabIndex = 43
        Me.btnTotalSalary.Text = "Staff Total Salary"
        Me.btnTotalSalary.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Total Record : "
        '
        'lblTotalSalaryRecord
        '
        Me.lblTotalSalaryRecord.AutoSize = True
        Me.lblTotalSalaryRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSalaryRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSalaryRecord.ForeColor = System.Drawing.Color.Black
        Me.lblTotalSalaryRecord.Location = New System.Drawing.Point(188, 16)
        Me.lblTotalSalaryRecord.Name = "lblTotalSalaryRecord"
        Me.lblTotalSalaryRecord.Size = New System.Drawing.Size(27, 27)
        Me.lblTotalSalaryRecord.TabIndex = 30
        Me.lblTotalSalaryRecord.Text = "0"
        '
        'lblTotalSalaryLeave
        '
        Me.lblTotalSalaryLeave.AutoSize = True
        Me.lblTotalSalaryLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSalaryLeave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSalaryLeave.Location = New System.Drawing.Point(923, 16)
        Me.lblTotalSalaryLeave.Name = "lblTotalSalaryLeave"
        Me.lblTotalSalaryLeave.Size = New System.Drawing.Size(27, 27)
        Me.lblTotalSalaryLeave.TabIndex = 39
        Me.lblTotalSalaryLeave.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(269, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 25)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Total salary :"
        '
        'lbltotalleave
        '
        Me.lbltotalleave.AutoSize = True
        Me.lbltotalleave.Location = New System.Drawing.Point(633, 16)
        Me.lbltotalleave.Name = "lbltotalleave"
        Me.lbltotalleave.Size = New System.Drawing.Size(234, 25)
        Me.lbltotalleave.TabIndex = 38
        Me.lbltotalleave.Text = "Total Leave amount :"
        '
        'lblTotalSalary
        '
        Me.lblTotalSalary.AutoSize = True
        Me.lblTotalSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSalary.Location = New System.Drawing.Point(465, 16)
        Me.lblTotalSalary.Name = "lblTotalSalary"
        Me.lblTotalSalary.Size = New System.Drawing.Size(27, 27)
        Me.lblTotalSalary.TabIndex = 37
        Me.lblTotalSalary.Text = "0"
        '
        'gpbSalarySearch
        '
        Me.gpbSalarySearch.Controls.Add(Me.Label10)
        Me.gpbSalarySearch.Controls.Add(Me.lblStaffType)
        Me.gpbSalarySearch.Controls.Add(Me.cmbStaffNameSearch)
        Me.gpbSalarySearch.Controls.Add(Me.Label11)
        Me.gpbSalarySearch.Controls.Add(Me.dtpFromDate)
        Me.gpbSalarySearch.Controls.Add(Me.Label13)
        Me.gpbSalarySearch.Controls.Add(Me.dtpToDate)
        Me.gpbSalarySearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpbSalarySearch.Location = New System.Drawing.Point(3, 3)
        Me.gpbSalarySearch.Name = "gpbSalarySearch"
        Me.gpbSalarySearch.Size = New System.Drawing.Size(1083, 111)
        Me.gpbSalarySearch.TabIndex = 42
        Me.gpbSalarySearch.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(114, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Staff Name"
        '
        'lblStaffType
        '
        Me.lblStaffType.AutoSize = True
        Me.lblStaffType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStaffType.Location = New System.Drawing.Point(783, 29)
        Me.lblStaffType.Name = "lblStaffType"
        Me.lblStaffType.Size = New System.Drawing.Size(113, 25)
        Me.lblStaffType.TabIndex = 19
        Me.lblStaffType.Text = "Staff type"
        '
        'cmbStaffNameSearch
        '
        Me.cmbStaffNameSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbStaffNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStaffNameSearch.FormattingEnabled = True
        Me.cmbStaffNameSearch.Items.AddRange(New Object() {"All Staff Name"})
        Me.cmbStaffNameSearch.Location = New System.Drawing.Point(320, 25)
        Me.cmbStaffNameSearch.Name = "cmbStaffNameSearch"
        Me.cmbStaffNameSearch.Size = New System.Drawing.Size(335, 33)
        Me.cmbStaffNameSearch.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 25)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "From Salary Date"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "dd-MMMM-yyyy"
        Me.dtpFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(320, 70)
        Me.dtpFromDate.MaxDate = New Date(2099, 11, 30, 0, 0, 0, 0)
        Me.dtpFromDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFromDate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(252, 33)
        Me.dtpFromDate.TabIndex = 31
        Me.dtpFromDate.Value = New Date(2017, 3, 17, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(652, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 25)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "To "
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "dd-MMMM-yyyy"
        Me.dtpToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(783, 70)
        Me.dtpToDate.MaxDate = New Date(2110, 12, 1, 0, 0, 0, 0)
        Me.dtpToDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpToDate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(231, 33)
        Me.dtpToDate.TabIndex = 33
        Me.dtpToDate.Value = New Date(2017, 3, 17, 0, 0, 0, 0)
        '
        'dgvStaffSalary
        '
        Me.dgvStaffSalary.AllowUserToAddRows = False
        Me.dgvStaffSalary.AllowUserToDeleteRows = False
        Me.dgvStaffSalary.AllowUserToResizeColumns = False
        Me.dgvStaffSalary.AllowUserToResizeRows = False
        Me.dgvStaffSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvStaffSalary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvStaffSalary.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaffSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStaffSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStaffSalary.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStaffSalary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStaffSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffSalary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.salary_id, Me.staff_name, Me.staff_type, Me.salary_amount, Me.salary_date, Me.salary_leave_amount, Me.staff_joining_date})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStaffSalary.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStaffSalary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStaffSalary.EnableHeadersVisualStyles = False
        Me.dgvStaffSalary.Location = New System.Drawing.Point(3, 3)
        Me.dgvStaffSalary.MultiSelect = False
        Me.dgvStaffSalary.Name = "dgvStaffSalary"
        Me.dgvStaffSalary.ReadOnly = True
        Me.dgvStaffSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStaffSalary.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvStaffSalary.RowHeadersVisible = False
        Me.dgvStaffSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStaffSalary.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvStaffSalary.ShowCellErrors = False
        Me.dgvStaffSalary.ShowCellToolTips = False
        Me.dgvStaffSalary.ShowEditingIcon = False
        Me.dgvStaffSalary.ShowRowErrors = False
        Me.dgvStaffSalary.Size = New System.Drawing.Size(1083, 544)
        Me.dgvStaffSalary.TabIndex = 0
        '
        'salary_id
        '
        Me.salary_id.HeaderText = "salary Id"
        Me.salary_id.Name = "salary_id"
        Me.salary_id.ReadOnly = True
        Me.salary_id.Visible = False
        Me.salary_id.Width = 108
        '
        'staff_name
        '
        Me.staff_name.HeaderText = "Staff Name"
        Me.staff_name.Name = "staff_name"
        Me.staff_name.ReadOnly = True
        Me.staff_name.Width = 140
        '
        'staff_type
        '
        Me.staff_type.HeaderText = "Staff Type"
        Me.staff_type.Name = "staff_type"
        Me.staff_type.ReadOnly = True
        Me.staff_type.Width = 133
        '
        'salary_amount
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.salary_amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.salary_amount.HeaderText = "Salary Amount"
        Me.salary_amount.Name = "salary_amount"
        Me.salary_amount.ReadOnly = True
        Me.salary_amount.Width = 173
        '
        'salary_date
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.salary_date.DefaultCellStyle = DataGridViewCellStyle3
        Me.salary_date.HeaderText = "Salary Date"
        Me.salary_date.Name = "salary_date"
        Me.salary_date.ReadOnly = True
        Me.salary_date.Width = 146
        '
        'salary_leave_amount
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.salary_leave_amount.DefaultCellStyle = DataGridViewCellStyle4
        Me.salary_leave_amount.HeaderText = "Leave Amount"
        Me.salary_leave_amount.Name = "salary_leave_amount"
        Me.salary_leave_amount.ReadOnly = True
        Me.salary_leave_amount.Width = 170
        '
        'staff_joining_date
        '
        DataGridViewCellStyle5.Format = "dd/mm/yyyy"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.staff_joining_date.DefaultCellStyle = DataGridViewCellStyle5
        Me.staff_joining_date.HeaderText = "Joining Date"
        Me.staff_joining_date.Name = "staff_joining_date"
        Me.staff_joining_date.ReadOnly = True
        Me.staff_joining_date.Visible = False
        Me.staff_joining_date.Width = 154
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmbStaffName)
        Me.TabPage1.Controls.Add(Me.salaryamount)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.addsalarydate)
        Me.TabPage1.Controls.Add(Me.clear)
        Me.TabPage1.Controls.Add(Me.addsalary)
        Me.TabPage1.Controls.Add(Me.leaveamount)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.fixsalary)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cmbAddSalaryStaffType)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1089, 550)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add  Update Salary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmbStaffName
        '
        Me.cmbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStaffName.Items.AddRange(New Object() {"Select staff type"})
        Me.cmbStaffName.Location = New System.Drawing.Point(320, 25)
        Me.cmbStaffName.Name = "cmbStaffName"
        Me.cmbStaffName.Size = New System.Drawing.Size(335, 33)
        Me.cmbStaffName.TabIndex = 32
        '
        'salaryamount
        '
        Me.salaryamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.salaryamount.Location = New System.Drawing.Point(320, 236)
        Me.salaryamount.Name = "salaryamount"
        Me.salaryamount.ReadOnly = True
        Me.salaryamount.Size = New System.Drawing.Size(252, 31)
        Me.salaryamount.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Salary Amount"
        '
        'addsalarydate
        '
        Me.addsalarydate.CustomFormat = "dd-MMMM-yyyy"
        Me.addsalarydate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addsalarydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.addsalarydate.Location = New System.Drawing.Point(320, 79)
        Me.addsalarydate.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.addsalarydate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.addsalarydate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.addsalarydate.Name = "addsalarydate"
        Me.addsalarydate.Size = New System.Drawing.Size(252, 33)
        Me.addsalarydate.TabIndex = 1
        Me.addsalarydate.Value = New Date(2017, 3, 17, 0, 0, 0, 0)
        '
        'clear
        '
        Me.clear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.clear.Location = New System.Drawing.Point(608, 363)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(125, 37)
        Me.clear.TabIndex = 6
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'addsalary
        '
        Me.addsalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addsalary.Location = New System.Drawing.Point(463, 363)
        Me.addsalary.Name = "addsalary"
        Me.addsalary.Size = New System.Drawing.Size(125, 37)
        Me.addsalary.TabIndex = 5
        Me.addsalary.Text = "Submit"
        Me.addsalary.UseVisualStyleBackColor = True
        '
        'leaveamount
        '
        Me.leaveamount.Location = New System.Drawing.Point(320, 183)
        Me.leaveamount.Name = "leaveamount"
        Me.leaveamount.Size = New System.Drawing.Size(252, 31)
        Me.leaveamount.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(131, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(162, 25)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Leave Amount"
        '
        'fixsalary
        '
        Me.fixsalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fixsalary.Location = New System.Drawing.Point(320, 131)
        Me.fixsalary.Name = "fixsalary"
        Me.fixsalary.ReadOnly = True
        Me.fixsalary.Size = New System.Drawing.Size(252, 31)
        Me.fixsalary.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fix Salary"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Salary Date"
        '
        'cmbAddSalaryStaffType
        '
        Me.cmbAddSalaryStaffType.AutoSize = True
        Me.cmbAddSalaryStaffType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbAddSalaryStaffType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cmbAddSalaryStaffType.Location = New System.Drawing.Point(783, 29)
        Me.cmbAddSalaryStaffType.Name = "cmbAddSalaryStaffType"
        Me.cmbAddSalaryStaffType.Size = New System.Drawing.Size(115, 27)
        Me.cmbAddSalaryStaffType.TabIndex = 2
        Me.cmbAddSalaryStaffType.Text = "Staff type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Staff Name"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1089, 550)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1089, 550)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(-1, 150)
        Me.lbl4.MaximumSize = New System.Drawing.Size(100, 50)
        Me.lbl4.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(200, 50)
        Me.lbl4.TabIndex = 6
        Me.lbl4.Text = "Expenses"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(-1, 50)
        Me.lbl2.MaximumSize = New System.Drawing.Size(100, 50)
        Me.lbl2.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(200, 50)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "Staff Detail"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(0, 100)
        Me.lbl3.MaximumSize = New System.Drawing.Size(100, 50)
        Me.lbl3.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(200, 50)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "Salary"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'menupnl
        '
        Me.menupnl.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.menupnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menupnl.Controls.Add(Me.lbl5)
        Me.menupnl.Controls.Add(Me.lbl4)
        Me.menupnl.Controls.Add(Me.lbl2)
        Me.menupnl.Controls.Add(Me.lbl1)
        Me.menupnl.Controls.Add(Me.lbl3)
        Me.menupnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.menupnl.Location = New System.Drawing.Point(0, 77)
        Me.menupnl.Name = "menupnl"
        Me.menupnl.Size = New System.Drawing.Size(201, 588)
        Me.menupnl.TabIndex = 4
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(-1, 200)
        Me.lbl5.MaximumSize = New System.Drawing.Size(100, 50)
        Me.lbl5.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(200, 50)
        Me.lbl5.TabIndex = 8
        Me.lbl5.Text = "Exit"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(-1, 0)
        Me.lbl1.MaximumSize = New System.Drawing.Size(100, 50)
        Me.lbl1.MinimumSize = New System.Drawing.Size(200, 50)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(200, 50)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Home"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1298, 77)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1298, 665)
        Me.Controls.Add(Me.tbcSalary)
        Me.Controls.Add(Me.menupnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmSalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbcSalary.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvStaffTotalSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbSalaryAddUpdate.ResumeLayout(False)
        Me.gpbSalaryAddUpdate.PerformLayout()
        Me.gpbSalarySearch.ResumeLayout(False)
        Me.gpbSalarySearch.PerformLayout()
        CType(Me.dgvStaffSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.menupnl.ResumeLayout(False)
        Me.menupnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents menupnl As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbcSalary As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbAddSalaryStaffType As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents addsalary As System.Windows.Forms.Button
    Friend WithEvents leaveamount As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents fixsalary As System.Windows.Forms.TextBox
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents addsalarydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents salaryamount As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAddSalary As System.Windows.Forms.Button
    Friend WithEvents lblStaffType As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbStaffNameSearch As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalSalaryRecord As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSalary As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSalaryLeave As System.Windows.Forms.Label
    Friend WithEvents lbltotalleave As System.Windows.Forms.Label
    Friend WithEvents dgvStaffTotalSalary As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalsalaryamount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvStaffSalary As System.Windows.Forms.DataGridView
    Friend WithEvents gpbSalarySearch As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStaffName As System.Windows.Forms.ComboBox
    Friend WithEvents salary_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salary_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salary_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salary_leave_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_joining_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTotalSalary As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents gpbSalaryAddUpdate As System.Windows.Forms.GroupBox
    ' Friend WithEvents SalaryReport1 As clgmanagement.SalaryReport
End Class
