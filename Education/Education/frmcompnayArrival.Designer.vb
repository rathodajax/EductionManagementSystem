<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcompnayArrival
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.compdate = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.txttot = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txttech = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtpurpose = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcompname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbsem = New System.Windows.Forms.ComboBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclr = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.cmbbatch = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Grid_Select_Company = New System.Windows.Forms.DataGridView
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.Grid_Select_Company, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Company Arrival Detail"
        '
        'compdate
        '
        Me.compdate.CustomFormat = "dd-MM-yyyy"
        Me.compdate.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.compdate.Location = New System.Drawing.Point(353, 198)
        Me.compdate.Name = "compdate"
        Me.compdate.Size = New System.Drawing.Size(261, 29)
        Me.compdate.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(298, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 25)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Date"
        '
        'txttot
        '
        Me.txttot.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttot.Location = New System.Drawing.Point(353, 350)
        Me.txttot.Name = "txttot"
        Me.txttot.Size = New System.Drawing.Size(261, 32)
        Me.txttot.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(156, 353)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(194, 25)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Total Attended Student"
        '
        'txttech
        '
        Me.txttech.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttech.Location = New System.Drawing.Point(353, 388)
        Me.txttech.Multiline = True
        Me.txttech.Name = "txttech"
        Me.txttech.Size = New System.Drawing.Size(261, 88)
        Me.txttech.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Technology"
        '
        'txtpurpose
        '
        Me.txtpurpose.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurpose.Location = New System.Drawing.Point(353, 312)
        Me.txtpurpose.Name = "txtpurpose"
        Me.txtpurpose.Size = New System.Drawing.Size(261, 32)
        Me.txtpurpose.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(269, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Purpose"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Semester"
        '
        'txtcompname
        '
        Me.txtcompname.Enabled = False
        Me.txtcompname.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompname.Location = New System.Drawing.Point(353, 160)
        Me.txtcompname.Name = "txtcompname"
        Me.txtcompname.Size = New System.Drawing.Size(261, 32)
        Me.txtcompname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Comapny Name"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(353, 120)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(261, 32)
        Me.txtid.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Company ID"
        '
        'cmbsem
        '
        Me.cmbsem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsem.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Items.AddRange(New Object() {"Sem5", "Sem6"})
        Me.cmbsem.Location = New System.Drawing.Point(353, 272)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(261, 33)
        Me.cmbsem.TabIndex = 3
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.Control
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(636, 185)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(123, 34)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.Control
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(636, 324)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(123, 34)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.SystemColors.Control
        Me.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclr.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.Location = New System.Drawing.Point(636, 251)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(123, 34)
        Me.btnclr.TabIndex = 8
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.Control
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(636, 391)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(123, 34)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'cmbbatch
        '
        Me.cmbbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbatch.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbatch.FormattingEnabled = True
        Me.cmbbatch.Items.AddRange(New Object() {"2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000"})
        Me.cmbbatch.Location = New System.Drawing.Point(353, 233)
        Me.cmbbatch.Name = "cmbbatch"
        Me.cmbbatch.Size = New System.Drawing.Size(261, 33)
        Me.cmbbatch.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Select Batch Year"
        '
        'Grid_Select_Company
        '
        Me.Grid_Select_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Select_Company.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cName})
        Me.Grid_Select_Company.Location = New System.Drawing.Point(353, 158)
        Me.Grid_Select_Company.Name = "Grid_Select_Company"
        Me.Grid_Select_Company.Size = New System.Drawing.Size(261, 191)
        Me.Grid_Select_Company.TabIndex = 55
        Me.Grid_Select_Company.Visible = False
        '
        'cId
        '
        Me.cId.HeaderText = "ID"
        Me.cId.Name = "cId"
        '
        'cName
        '
        Me.cName.HeaderText = "Company_Name"
        Me.cName.Name = "cName"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(398, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(179, 14)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Press F1 To Select Company."
        '
        'frmcompnayArrival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1020, 683)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Grid_Select_Company)
        Me.Controls.Add(Me.cmbbatch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.cmbsem)
        Me.Controls.Add(Me.compdate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txttot)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txttech)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpurpose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcompname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmcompnayArrival"
        Me.Text = "Company_Arrival_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid_Select_Company, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents compdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttech As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcompname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbsem As System.Windows.Forms.ComboBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents cmbbatch As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Grid_Select_Company As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
