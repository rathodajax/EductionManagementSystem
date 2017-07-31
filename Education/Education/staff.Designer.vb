<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff
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
        Me.p1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.staff_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.updatestafftypecancel = New System.Windows.Forms.Button
        Me.updatestafftype = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.addupdatestafftype = New System.Windows.Forms.ComboBox
        Me.addstafftypeclear = New System.Windows.Forms.Button
        Me.addstafftypesubmit = New System.Windows.Forms.Button
        Me.addstafftypetype = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.addstafftyperemark = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.staffcount = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbshowstaff = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.updatestaffcancel = New System.Windows.Forms.Button
        Me.staffupdate = New System.Windows.Forms.Button
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.addstaffemailid = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.addupdatestaffname = New System.Windows.Forms.ComboBox
        Me.addstaffjoingdate = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.addstafffixsalary = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.addstaffcontact = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.addstaffremark = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.addstafflastname = New System.Windows.Forms.TextBox
        Me.addstaffmiddlename = New System.Windows.Forms.TextBox
        Me.addstaffclear = New System.Windows.Forms.Button
        Me.addstaff = New System.Windows.Forms.Button
        Me.addstaffaddress = New System.Windows.Forms.TextBox
        Me.addstafffirstname = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.addstafftype = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.menupnl = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.p1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.menupnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.White
        Me.p1.Controls.Add(Me.TabControl1)
        Me.p1.Controls.Add(Me.Label6)
        Me.p1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p1.Location = New System.Drawing.Point(201, 77)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(1077, 592)
        Me.p1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(1077, 592)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Controls.Add(Me.updatestafftypecancel)
        Me.TabPage4.Controls.Add(Me.updatestafftype)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1069, 554)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Staff Type"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.staff_type, Me.remark})
        Me.DataGridView2.Location = New System.Drawing.Point(5, 70)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1059, 429)
        Me.DataGridView2.TabIndex = 32
        '
        'staff_type
        '
        Me.staff_type.HeaderText = "Staff Type"
        Me.staff_type.Name = "staff_type"
        Me.staff_type.Width = 145
        '
        'remark
        '
        Me.remark.HeaderText = "Remark"
        Me.remark.Name = "remark"
        Me.remark.Width = 117
        '
        'updatestafftypecancel
        '
        Me.updatestafftypecancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.updatestafftypecancel.Location = New System.Drawing.Point(549, 500)
        Me.updatestafftypecancel.Name = "updatestafftypecancel"
        Me.updatestafftypecancel.Size = New System.Drawing.Size(125, 37)
        Me.updatestafftypecancel.TabIndex = 31
        Me.updatestafftypecancel.Text = "Cancel"
        Me.updatestafftypecancel.UseVisualStyleBackColor = True
        '
        'updatestafftype
        '
        Me.updatestafftype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.updatestafftype.Location = New System.Drawing.Point(400, 500)
        Me.updatestafftype.Name = "updatestafftype"
        Me.updatestafftype.Size = New System.Drawing.Size(125, 37)
        Me.updatestafftype.TabIndex = 30
        Me.updatestafftype.Text = "Add staff"
        Me.updatestafftype.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.addupdatestafftype)
        Me.TabPage3.Controls.Add(Me.addstafftypeclear)
        Me.TabPage3.Controls.Add(Me.addstafftypesubmit)
        Me.TabPage3.Controls.Add(Me.addstafftypetype)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.addstafftyperemark)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1069, 554)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Add Update Staff Type"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'addupdatestafftype
        '
        Me.addupdatestafftype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addupdatestafftype.FormattingEnabled = True
        Me.addupdatestafftype.Items.AddRange(New Object() {"Select Staff type for update data"})
        Me.addupdatestafftype.Location = New System.Drawing.Point(115, 35)
        Me.addupdatestafftype.Name = "addupdatestafftype"
        Me.addupdatestafftype.Size = New System.Drawing.Size(465, 33)
        Me.addupdatestafftype.TabIndex = 35
        '
        'addstafftypeclear
        '
        Me.addstafftypeclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addstafftypeclear.Location = New System.Drawing.Point(558, 500)
        Me.addstafftypeclear.Name = "addstafftypeclear"
        Me.addstafftypeclear.Size = New System.Drawing.Size(125, 37)
        Me.addstafftypeclear.TabIndex = 25
        Me.addstafftypeclear.Text = "Clear"
        Me.addstafftypeclear.UseVisualStyleBackColor = True
        '
        'addstafftypesubmit
        '
        Me.addstafftypesubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addstafftypesubmit.Location = New System.Drawing.Point(400, 500)
        Me.addstafftypesubmit.Name = "addstafftypesubmit"
        Me.addstafftypesubmit.Size = New System.Drawing.Size(125, 37)
        Me.addstafftypesubmit.TabIndex = 24
        Me.addstafftypesubmit.Text = "Submit"
        Me.addstafftypesubmit.UseVisualStyleBackColor = True
        '
        'addstafftypetype
        '
        Me.addstafftypetype.Location = New System.Drawing.Point(324, 118)
        Me.addstafftypetype.Name = "addstafftypetype"
        Me.addstafftypetype.Size = New System.Drawing.Size(251, 31)
        Me.addstafftypetype.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(110, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 25)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Staff Type"
        '
        'addstafftyperemark
        '
        Me.addstafftyperemark.Location = New System.Drawing.Point(324, 172)
        Me.addstafftyperemark.Multiline = True
        Me.addstafftyperemark.Name = "addstafftyperemark"
        Me.addstafftyperemark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.addstafftyperemark.Size = New System.Drawing.Size(251, 75)
        Me.addstafftyperemark.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(110, 193)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 25)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Remarks"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.staffcount)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.cmbshowstaff)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.updatestaffcancel)
        Me.TabPage2.Controls.Add(Me.staffupdate)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1069, 554)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Staff Detail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'staffcount
        '
        Me.staffcount.AutoSize = True
        Me.staffcount.Location = New System.Drawing.Point(144, 474)
        Me.staffcount.Name = "staffcount"
        Me.staffcount.Size = New System.Drawing.Size(25, 25)
        Me.staffcount.TabIndex = 33
        Me.staffcount.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 474)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 25)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Total staff: "
        '
        'cmbshowstaff
        '
        Me.cmbshowstaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbshowstaff.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbshowstaff.Items.AddRange(New Object() {"Select staff type"})
        Me.cmbshowstaff.Location = New System.Drawing.Point(300, 25)
        Me.cmbshowstaff.Name = "cmbshowstaff"
        Me.cmbshowstaff.Size = New System.Drawing.Size(251, 33)
        Me.cmbshowstaff.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(110, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 25)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Type of Staff"
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
        Me.DataGridView1.Location = New System.Drawing.Point(5, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1063, 385)
        Me.DataGridView1.TabIndex = 29
        '
        'updatestaffcancel
        '
        Me.updatestaffcancel.ForeColor = System.Drawing.Color.Navy
        Me.updatestaffcancel.Location = New System.Drawing.Point(550, 500)
        Me.updatestaffcancel.Name = "updatestaffcancel"
        Me.updatestaffcancel.Size = New System.Drawing.Size(125, 37)
        Me.updatestaffcancel.TabIndex = 28
        Me.updatestaffcancel.Text = "Cancel"
        Me.updatestaffcancel.UseVisualStyleBackColor = True
        '
        'staffupdate
        '
        Me.staffupdate.ForeColor = System.Drawing.Color.Navy
        Me.staffupdate.Location = New System.Drawing.Point(400, 500)
        Me.staffupdate.Name = "staffupdate"
        Me.staffupdate.Size = New System.Drawing.Size(125, 37)
        Me.staffupdate.TabIndex = 27
        Me.staffupdate.Text = "Add Staff"
        Me.staffupdate.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.addstaffemailid)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.addupdatestaffname)
        Me.TabPage1.Controls.Add(Me.addstaffjoingdate)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.addstafffixsalary)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.addstaffcontact)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.addstaffremark)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.addstafflastname)
        Me.TabPage1.Controls.Add(Me.addstaffmiddlename)
        Me.TabPage1.Controls.Add(Me.addstaffclear)
        Me.TabPage1.Controls.Add(Me.addstaff)
        Me.TabPage1.Controls.Add(Me.addstaffaddress)
        Me.TabPage1.Controls.Add(Me.addstafffirstname)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.addstafftype)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1069, 554)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add  Update Staff"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(300, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 37)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'addstaffemailid
        '
        Me.addstaffemailid.Location = New System.Drawing.Point(300, 332)
        Me.addstaffemailid.Name = "addstaffemailid"
        Me.addstaffemailid.Size = New System.Drawing.Size(251, 31)
        Me.addstaffemailid.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(110, 332)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 25)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Email-ID"
        '
        'addupdatestaffname
        '
        Me.addupdatestaffname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addupdatestaffname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.addupdatestaffname.FormattingEnabled = True
        Me.addupdatestaffname.Items.AddRange(New Object() {"Select Staff Name for update data"})
        Me.addupdatestaffname.Location = New System.Drawing.Point(600, 30)
        Me.addupdatestaffname.Name = "addupdatestaffname"
        Me.addupdatestaffname.Size = New System.Drawing.Size(461, 33)
        Me.addupdatestaffname.TabIndex = 27
        '
        'addstaffjoingdate
        '
        Me.addstaffjoingdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addstaffjoingdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.addstaffjoingdate.Location = New System.Drawing.Point(300, 83)
        Me.addstaffjoingdate.MaxDate = New Date(2099, 10, 24, 0, 0, 0, 0)
        Me.addstaffjoingdate.MinimumSize = New System.Drawing.Size(151, 33)
        Me.addstaffjoingdate.Name = "addstaffjoingdate"
        Me.addstaffjoingdate.Size = New System.Drawing.Size(251, 33)
        Me.addstaffjoingdate.TabIndex = 1
        Me.addstaffjoingdate.Value = New Date(2017, 2, 16, 23, 24, 59, 0)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(110, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 25)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Joining Date"
        '
        'addstafffixsalary
        '
        Me.addstafffixsalary.Location = New System.Drawing.Point(300, 388)
        Me.addstafffixsalary.Name = "addstafffixsalary"
        Me.addstafffixsalary.Size = New System.Drawing.Size(251, 31)
        Me.addstafffixsalary.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(110, 388)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 25)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Fix Salary"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(110, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 25)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Last Name"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(110, 177)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(149, 25)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Middle Name"
        '
        'addstaffcontact
        '
        Me.addstaffcontact.Location = New System.Drawing.Point(300, 277)
        Me.addstaffcontact.Name = "addstaffcontact"
        Me.addstaffcontact.Size = New System.Drawing.Size(251, 31)
        Me.addstaffcontact.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(110, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Contact No"
        '
        'addstaffremark
        '
        Me.addstaffremark.Location = New System.Drawing.Point(729, 325)
        Me.addstaffremark.Multiline = True
        Me.addstaffremark.Name = "addstaffremark"
        Me.addstaffremark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.addstaffremark.Size = New System.Drawing.Size(332, 88)
        Me.addstaffremark.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(595, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Remarks"
        '
        'addstafflastname
        '
        Me.addstafflastname.Location = New System.Drawing.Point(300, 229)
        Me.addstafflastname.Name = "addstafflastname"
        Me.addstafflastname.Size = New System.Drawing.Size(251, 31)
        Me.addstafflastname.TabIndex = 4
        '
        'addstaffmiddlename
        '
        Me.addstaffmiddlename.Location = New System.Drawing.Point(300, 181)
        Me.addstaffmiddlename.Name = "addstaffmiddlename"
        Me.addstaffmiddlename.Size = New System.Drawing.Size(251, 31)
        Me.addstaffmiddlename.TabIndex = 3
        '
        'addstaffclear
        '
        Me.addstaffclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addstaffclear.Location = New System.Drawing.Point(589, 494)
        Me.addstaffclear.Name = "addstaffclear"
        Me.addstaffclear.Size = New System.Drawing.Size(125, 37)
        Me.addstaffclear.TabIndex = 14
        Me.addstaffclear.Text = "Clear"
        Me.addstaffclear.UseVisualStyleBackColor = True
        '
        'addstaff
        '
        Me.addstaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addstaff.Location = New System.Drawing.Point(444, 494)
        Me.addstaff.Name = "addstaff"
        Me.addstaff.Size = New System.Drawing.Size(125, 37)
        Me.addstaff.TabIndex = 13
        Me.addstaff.Text = "Submit"
        Me.addstaff.UseVisualStyleBackColor = True
        '
        'addstaffaddress
        '
        Me.addstaffaddress.Location = New System.Drawing.Point(729, 118)
        Me.addstaffaddress.Multiline = True
        Me.addstaffaddress.Name = "addstaffaddress"
        Me.addstaffaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.addstaffaddress.Size = New System.Drawing.Size(332, 168)
        Me.addstaffaddress.TabIndex = 8
        '
        'addstafffirstname
        '
        Me.addstafffirstname.Location = New System.Drawing.Point(300, 133)
        Me.addstafffirstname.Name = "addstafffirstname"
        Me.addstafffirstname.Size = New System.Drawing.Size(251, 31)
        Me.addstafffirstname.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(595, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Address "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "First Name"
        '
        'addstafftype
        '
        Me.addstafftype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.addstafftype.FormattingEnabled = True
        Me.addstafftype.Items.AddRange(New Object() {"Select staff type"})
        Me.addstafftype.Location = New System.Drawing.Point(300, 33)
        Me.addstafftype.Name = "addstafftype"
        Me.addstafftype.Size = New System.Drawing.Size(251, 33)
        Me.addstafftype.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Type of Staff"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 1)
        Me.Label6.MinimumSize = New System.Drawing.Size(1070, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1070, 50)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Staff  Management"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label3.Location = New System.Drawing.Point(-1, 101)
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
        Me.menupnl.Size = New System.Drawing.Size(201, 592)
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
        Me.Label23.Location = New System.Drawing.Point(-1, 201)
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
        Me.Panel1.Size = New System.Drawing.Size(1278, 77)
        Me.Panel1.TabIndex = 3
        '
        'staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 669)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.menupnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "staff"
        Me.Text = "staff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.menupnl.ResumeLayout(False)
        Me.menupnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents p1 As System.Windows.Forms.Panel
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
    Friend WithEvents addstaffclear As System.Windows.Forms.Button
    Friend WithEvents addstaff As System.Windows.Forms.Button
    Friend WithEvents addstaffaddress As System.Windows.Forms.TextBox
    Friend WithEvents addstafffirstname As System.Windows.Forms.TextBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents addstafftype As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents addstafflastname As System.Windows.Forms.TextBox
    Friend WithEvents addstaffmiddlename As System.Windows.Forms.TextBox
    Friend WithEvents addstaffcontact As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents addstaffremark As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents addstaffjoingdate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents addstafffixsalary As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents addstafftypetype As System.Windows.Forms.TextBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents addstafftyperemark As System.Windows.Forms.TextBox
    Private WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents addstafftypeclear As System.Windows.Forms.Button
    Friend WithEvents addstafftypesubmit As System.Windows.Forms.Button
    Friend WithEvents updatestafftypecancel As System.Windows.Forms.Button
    Friend WithEvents updatestafftype As System.Windows.Forms.Button
    Friend WithEvents addupdatestaffname As System.Windows.Forms.ComboBox
    Friend WithEvents addstaffemailid As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents addupdatestafftype As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents updatestaffcancel As System.Windows.Forms.Button
    Friend WithEvents staffupdate As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbshowstaff As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents staffcount As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents staff_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents remark As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
