<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class expanse
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.totalexpenses = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.expensesrecord = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblstafftype = New System.Windows.Forms.Label
        Me.expensecmbstaffname = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.todate = New System.Windows.Forms.DateTimePicker
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.expense_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staff_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.staff_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.expense_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.itme_price = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.item_amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button6 = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.expansesamount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.expansesremark = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.expansesstafftype = New System.Windows.Forms.Label
        Me.expansesstaffname = New System.Windows.Forms.ComboBox
        Me.expansesdate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.expansesitmename = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.expansesquantity = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.expansesprice = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.menupnl = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.menupnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(204, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1137, 565)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.totalexpenses)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.expensesrecord)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1129, 527)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Show"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'totalexpenses
        '
        Me.totalexpenses.AutoSize = True
        Me.totalexpenses.Location = New System.Drawing.Point(912, 446)
        Me.totalexpenses.Name = "totalexpenses"
        Me.totalexpenses.Size = New System.Drawing.Size(25, 25)
        Me.totalexpenses.TabIndex = 51
        Me.totalexpenses.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(707, 446)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 25)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Total Expenses :"
        '
        'expensesrecord
        '
        Me.expensesrecord.AutoSize = True
        Me.expensesrecord.Location = New System.Drawing.Point(206, 446)
        Me.expensesrecord.Name = "expensesrecord"
        Me.expensesrecord.Size = New System.Drawing.Size(25, 25)
        Me.expensesrecord.TabIndex = 49
        Me.expensesrecord.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 25)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Total Record :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblstafftype)
        Me.GroupBox1.Controls.Add(Me.expensecmbstaffname)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.fromdate)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.todate)
        Me.GroupBox1.Location = New System.Drawing.Point(6, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(977, 111)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Staff Name"
        '
        'lblstafftype
        '
        Me.lblstafftype.AutoSize = True
        Me.lblstafftype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblstafftype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblstafftype.Location = New System.Drawing.Point(735, 19)
        Me.lblstafftype.Name = "lblstafftype"
        Me.lblstafftype.Size = New System.Drawing.Size(115, 27)
        Me.lblstafftype.TabIndex = 19
        Me.lblstafftype.Text = "Staff type"
        '
        'expensecmbstaffname
        '
        Me.expensecmbstaffname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expensecmbstaffname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.expensecmbstaffname.FormattingEnabled = True
        Me.expensecmbstaffname.Items.AddRange(New Object() {"All Staff Name"})
        Me.expensecmbstaffname.Location = New System.Drawing.Point(243, 16)
        Me.expensecmbstaffname.Name = "expensecmbstaffname"
        Me.expensecmbstaffname.Size = New System.Drawing.Size(461, 33)
        Me.expensecmbstaffname.TabIndex = 28
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(38, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(195, 25)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "From Salary Date"
        '
        'fromdate
        '
        Me.fromdate.CustomFormat = "dd-MMM-yy"
        Me.fromdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromdate.Location = New System.Drawing.Point(243, 65)
        Me.fromdate.MaxDate = New Date(2099, 11, 30, 0, 0, 0, 0)
        Me.fromdate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.fromdate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.fromdate.Name = "fromdate"
        Me.fromdate.Size = New System.Drawing.Size(252, 33)
        Me.fromdate.TabIndex = 31
        Me.fromdate.Value = New Date(2017, 3, 17, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(535, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(169, 25)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "To Salary Date"
        '
        'todate
        '
        Me.todate.CustomFormat = "dd-MMM-yy"
        Me.todate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.todate.Location = New System.Drawing.Point(735, 65)
        Me.todate.MaxDate = New Date(2017, 3, 17, 0, 0, 0, 0)
        Me.todate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.todate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.todate.Name = "todate"
        Me.todate.Size = New System.Drawing.Size(231, 33)
        Me.todate.TabIndex = 33
        Me.todate.Value = New Date(2017, 3, 17, 0, 0, 0, 0)
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Navy
        Me.Button5.Location = New System.Drawing.Point(500, 487)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 37)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.expense_id, Me.staff_name, Me.staff_type, Me.expense_date, Me.item_name, Me.itme_price, Me.item_quantity, Me.item_amount})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1125, 316)
        Me.DataGridView1.TabIndex = 0
        '
        'expense_id
        '
        Me.expense_id.HeaderText = "Id"
        Me.expense_id.Name = "expense_id"
        Me.expense_id.Width = 56
        '
        'staff_name
        '
        Me.staff_name.HeaderText = "Staff name"
        Me.staff_name.Name = "staff_name"
        Me.staff_name.Width = 137
        '
        'staff_type
        '
        Me.staff_type.HeaderText = "Staff type"
        Me.staff_type.Name = "staff_type"
        Me.staff_type.Width = 86
        '
        'expense_date
        '
        Me.expense_date.HeaderText = "Date of expense"
        Me.expense_date.Name = "expense_date"
        Me.expense_date.Width = 190
        '
        'item_name
        '
        Me.item_name.HeaderText = "Item name"
        Me.item_name.Name = "item_name"
        Me.item_name.Width = 133
        '
        'itme_price
        '
        Me.itme_price.HeaderText = "Item Price"
        Me.itme_price.Name = "itme_price"
        Me.itme_price.Width = 130
        '
        'item_quantity
        '
        Me.item_quantity.HeaderText = "Item Quantity"
        Me.item_quantity.Name = "item_quantity"
        Me.item_quantity.Width = 160
        '
        'item_amount
        '
        Me.item_amount.HeaderText = "Total amount"
        Me.item_amount.Name = "item_amount"
        Me.item_amount.Width = 159
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Location = New System.Drawing.Point(283, 487)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(193, 37)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "Add Exapanse "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.expansesamount)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.expansesremark)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.expansesstafftype)
        Me.TabPage1.Controls.Add(Me.expansesstaffname)
        Me.TabPage1.Controls.Add(Me.expansesdate)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.expansesitmename)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.expansesquantity)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.expansesprice)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1058, 527)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Expanse"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'expansesamount
        '
        Me.expansesamount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expansesamount.Location = New System.Drawing.Point(760, 258)
        Me.expansesamount.Name = "expansesamount"
        Me.expansesamount.ReadOnly = True
        Me.expansesamount.Size = New System.Drawing.Size(270, 31)
        Me.expansesamount.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(600, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 50)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Expanses " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        '
        'expansesremark
        '
        Me.expansesremark.Location = New System.Drawing.Point(760, 91)
        Me.expansesremark.Multiline = True
        Me.expansesremark.Name = "expansesremark"
        Me.expansesremark.Size = New System.Drawing.Size(270, 97)
        Me.expansesremark.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(600, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 25)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Remarks"
        '
        'expansesstafftype
        '
        Me.expansesstafftype.AutoSize = True
        Me.expansesstafftype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expansesstafftype.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.expansesstafftype.Location = New System.Drawing.Point(760, 35)
        Me.expansesstafftype.Name = "expansesstafftype"
        Me.expansesstafftype.Size = New System.Drawing.Size(115, 27)
        Me.expansesstafftype.TabIndex = 36
        Me.expansesstafftype.Text = "Staff type"
        '
        'expansesstaffname
        '
        Me.expansesstaffname.FormattingEnabled = True
        Me.expansesstaffname.Location = New System.Drawing.Point(290, 32)
        Me.expansesstaffname.Name = "expansesstaffname"
        Me.expansesstaffname.Size = New System.Drawing.Size(415, 33)
        Me.expansesstaffname.TabIndex = 0
        '
        'expansesdate
        '
        Me.expansesdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expansesdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.expansesdate.Location = New System.Drawing.Point(291, 91)
        Me.expansesdate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.expansesdate.Name = "expansesdate"
        Me.expansesdate.Size = New System.Drawing.Size(270, 33)
        Me.expansesdate.TabIndex = 1
        Me.expansesdate.Value = New Date(2017, 3, 18, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(101, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Staff Name"
        '
        'expansesitmename
        '
        Me.expansesitmename.Location = New System.Drawing.Point(291, 150)
        Me.expansesitmename.Name = "expansesitmename"
        Me.expansesitmename.Size = New System.Drawing.Size(270, 31)
        Me.expansesitmename.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(560, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 37)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(415, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'expansesquantity
        '
        Me.expansesquantity.Location = New System.Drawing.Point(291, 264)
        Me.expansesquantity.Name = "expansesquantity"
        Me.expansesquantity.Size = New System.Drawing.Size(270, 31)
        Me.expansesquantity.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Quantity"
        '
        'expansesprice
        '
        Me.expansesprice.Location = New System.Drawing.Point(291, 207)
        Me.expansesprice.Name = "expansesprice"
        Me.expansesprice.Size = New System.Drawing.Size(270, 31)
        Me.expansesprice.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(101, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 25)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Price"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(101, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(159, 25)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Expanse Date"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(101, 143)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 25)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Item Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-1, 151)
        Me.Label5.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Label5.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 50)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Expenses"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 51)
        Me.Label4.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Label4.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 50)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Staff Detail"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(215, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(830, 435)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "College Mangement System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 101)
        Me.Label3.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Label3.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 50)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Salary"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'menupnl
        '
        Me.menupnl.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.menupnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menupnl.Controls.Add(Me.Label23)
        Me.menupnl.Controls.Add(Me.Label5)
        Me.menupnl.Controls.Add(Me.Label4)
        Me.menupnl.Controls.Add(Me.Panel3)
        Me.menupnl.Controls.Add(Me.Label2)
        Me.menupnl.Controls.Add(Me.Label3)
        Me.menupnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.menupnl.Location = New System.Drawing.Point(0, 77)
        Me.menupnl.Name = "menupnl"
        Me.menupnl.Size = New System.Drawing.Size(201, 606)
        Me.menupnl.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(0, 201)
        Me.Label23.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Label23.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(200, 50)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Exit"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-1, 1)
        Me.Label2.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Label2.MinimumSize = New System.Drawing.Size(200, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Home"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1326, 77)
        Me.Panel1.TabIndex = 3
        '
        'expanse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 683)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.menupnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "expanse"
        Me.Text = "expanse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.menupnl.ResumeLayout(False)
        Me.menupnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents menupnl As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents expansesitmename As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents expansesquantity As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents expansesprice As System.Windows.Forms.TextBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents expansesdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents expansesstafftype As System.Windows.Forms.Label
    Friend WithEvents expansesstaffname As System.Windows.Forms.ComboBox
    Friend WithEvents expansesamount As System.Windows.Forms.TextBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents expansesremark As System.Windows.Forms.TextBox
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblstafftype As System.Windows.Forms.Label
    Friend WithEvents expensecmbstaffname As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents expense_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents staff_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expense_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itme_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expensesrecord As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents totalexpenses As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
