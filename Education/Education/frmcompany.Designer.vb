<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcompany
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtcompname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtownername = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtadd = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtcompcontact = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtemailid = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtwebsite = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtotherdetail = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbcity = New System.Windows.Forms.ComboBox
        Me.btnmodify = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnclr = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtpersoncontact = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.compdate = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.cId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(467, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Master"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Company ID"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(453, 72)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(261, 32)
        Me.txtid.TabIndex = 0
        '
        'txtcompname
        '
        Me.txtcompname.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompname.Location = New System.Drawing.Point(453, 110)
        Me.txtcompname.Name = "txtcompname"
        Me.txtcompname.Size = New System.Drawing.Size(261, 32)
        Me.txtcompname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(311, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Comapny name"
        '
        'txtownername
        '
        Me.txtownername.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownername.Location = New System.Drawing.Point(453, 152)
        Me.txtownername.Name = "txtownername"
        Me.txtownername.Size = New System.Drawing.Size(261, 32)
        Me.txtownername.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Owner name"
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(453, 192)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(261, 32)
        Me.txtcontact.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Owner contact"
        '
        'txtadd
        '
        Me.txtadd.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd.Location = New System.Drawing.Point(453, 308)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(261, 88)
        Me.txtadd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(405, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "City"
        '
        'txtcompcontact
        '
        Me.txtcompcontact.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcompcontact.Location = New System.Drawing.Point(453, 440)
        Me.txtcompcontact.Name = "txtcompcontact"
        Me.txtcompcontact.Size = New System.Drawing.Size(261, 32)
        Me.txtcompcontact.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Company contact"
        '
        'txtemailid
        '
        Me.txtemailid.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemailid.Location = New System.Drawing.Point(453, 478)
        Me.txtemailid.Name = "txtemailid"
        Me.txtemailid.Size = New System.Drawing.Size(261, 32)
        Me.txtemailid.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 481)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Email Id"
        '
        'txtwebsite
        '
        Me.txtwebsite.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwebsite.Location = New System.Drawing.Point(453, 516)
        Me.txtwebsite.Name = "txtwebsite"
        Me.txtwebsite.Size = New System.Drawing.Size(261, 32)
        Me.txtwebsite.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(368, 516)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Website"
        '
        'txtotherdetail
        '
        Me.txtotherdetail.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtotherdetail.Location = New System.Drawing.Point(453, 554)
        Me.txtotherdetail.Multiline = True
        Me.txtotherdetail.Name = "txtotherdetail"
        Me.txtotherdetail.Size = New System.Drawing.Size(261, 81)
        Me.txtotherdetail.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(329, 557)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Other Details"
        '
        'cmbcity
        '
        Me.cmbcity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcity.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcity.FormattingEnabled = True
        Me.cmbcity.Location = New System.Drawing.Point(453, 402)
        Me.cmbcity.Name = "cmbcity"
        Me.cmbcity.Size = New System.Drawing.Size(261, 33)
        Me.cmbcity.Sorted = True
        Me.cmbcity.TabIndex = 7
        '
        'btnmodify
        '
        Me.btnmodify.BackColor = System.Drawing.SystemColors.Control
        Me.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodify.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodify.Location = New System.Drawing.Point(733, 74)
        Me.btnmodify.Name = "btnmodify"
        Me.btnmodify.Size = New System.Drawing.Size(123, 56)
        Me.btnmodify.TabIndex = 12
        Me.btnmodify.Text = "Modify"
        Me.btnmodify.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.Control
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(733, 148)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(123, 56)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "Add New"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.Control
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(733, 374)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(123, 56)
        Me.btnexit.TabIndex = 16
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnclr
        '
        Me.btnclr.BackColor = System.Drawing.SystemColors.Control
        Me.btnclr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclr.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclr.Location = New System.Drawing.Point(733, 223)
        Me.btnclr.Name = "btnclr"
        Me.btnclr.Size = New System.Drawing.Size(123, 56)
        Me.btnclr.TabIndex = 14
        Me.btnclr.Text = "Clear"
        Me.btnclr.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.Control
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(733, 298)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(123, 56)
        Me.btncancel.TabIndex = 15
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(218, 274)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(226, 25)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Company Established Date"
        '
        'txtpersoncontact
        '
        Me.txtpersoncontact.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpersoncontact.Location = New System.Drawing.Point(453, 230)
        Me.txtpersoncontact.Name = "txtpersoncontact"
        Me.txtpersoncontact.Size = New System.Drawing.Size(261, 32)
        Me.txtpersoncontact.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(283, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 25)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Contact Person No"
        '
        'compdate
        '
        Me.compdate.CalendarFont = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compdate.CustomFormat = "dd-MM-yyyy"
        Me.compdate.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.compdate.Location = New System.Drawing.Point(453, 270)
        Me.compdate.Name = "compdate"
        Me.compdate.Size = New System.Drawing.Size(261, 29)
        Me.compdate.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cId, Me.cName})
        Me.DataGridView1.Location = New System.Drawing.Point(453, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(261, 150)
        Me.DataGridView1.TabIndex = 32
        Me.DataGridView1.Visible = False
        '
        'cId
        '
        Me.cId.HeaderText = "ID"
        Me.cId.Name = "cId"
        '
        'cName
        '
        Me.cName.HeaderText = "Name"
        Me.cName.Name = "cName"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(499, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 14)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Press F1 To Select Company."
        '
        'frmcompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1020, 647)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.compdate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpersoncontact)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclr)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnmodify)
        Me.Controls.Add(Me.cmbcity)
        Me.Controls.Add(Me.txtotherdetail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtwebsite)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtemailid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcompcontact)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtadd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtownername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcompname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmcompany"
        Me.Text = "companymaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtcompname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtownername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcompcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtemailid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtwebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtotherdetail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbcity As System.Windows.Forms.ComboBox
    Friend WithEvents btnmodify As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnclr As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpersoncontact As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents compdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
