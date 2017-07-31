<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees_Details
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.comboyear = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Combosem = New System.Windows.Forms.ComboBox
        Me.Comborno = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblcodes = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblc = New System.Windows.Forms.Label
        Me.lblrno = New System.Windows.Forms.Label
        Me.stdimg = New System.Windows.Forms.PictureBox
        Me.lblsname = New System.Windows.Forms.Label
        Me.lblctgr = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblyear = New System.Windows.Forms.Label
        Me.lblgender = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.StudentId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecieptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TakenFor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TakenDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TuationFees = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LibraryFees = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Std_Act_Fees = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnionFees = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabFees = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lbltotal = New System.Windows.Forms.Label
        Me.txttotalr = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.lbltitle = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.stdimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.comboyear)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lbldate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Combosem)
        Me.GroupBox2.Controls.Add(Me.Comborno)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblcodes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblc)
        Me.GroupBox2.Controls.Add(Me.lblrno)
        Me.GroupBox2.Controls.Add(Me.stdimg)
        Me.GroupBox2.Controls.Add(Me.lblsname)
        Me.GroupBox2.Controls.Add(Me.lblctgr)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblyear)
        Me.GroupBox2.Controls.Add(Me.lblgender)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 291)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search  Student :"
        '
        'comboyear
        '
        Me.comboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboyear.FormattingEnabled = True
        Me.comboyear.Location = New System.Drawing.Point(195, 35)
        Me.comboyear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboyear.Name = "comboyear"
        Me.comboyear.Size = New System.Drawing.Size(106, 28)
        Me.comboyear.TabIndex = 24
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(30, 43)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(160, 20)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "Registration Year :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(29, 237)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 20)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Date :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(189, 237)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(19, 20)
        Me.lbldate.TabIndex = 19
        Me.lbldate.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Semester : "
        '
        'Combosem
        '
        Me.Combosem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combosem.FormattingEnabled = True
        Me.Combosem.Location = New System.Drawing.Point(193, 79)
        Me.Combosem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Combosem.Name = "Combosem"
        Me.Combosem.Size = New System.Drawing.Size(200, 28)
        Me.Combosem.TabIndex = 0
        '
        'Comborno
        '
        Me.Comborno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comborno.FormattingEnabled = True
        Me.Comborno.Location = New System.Drawing.Point(193, 120)
        Me.Comborno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Comborno.Name = "Comborno"
        Me.Comborno.Size = New System.Drawing.Size(200, 28)
        Me.Comborno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Student Id :"
        '
        'lblcodes
        '
        Me.lblcodes.AutoSize = True
        Me.lblcodes.Location = New System.Drawing.Point(189, 205)
        Me.lblcodes.Name = "lblcodes"
        Me.lblcodes.Size = New System.Drawing.Size(19, 20)
        Me.lblcodes.TabIndex = 18
        Me.lblcodes.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Roll No :"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Location = New System.Drawing.Point(29, 205)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(66, 20)
        Me.lblc.TabIndex = 17
        Me.lblc.Text = "Code : "
        '
        'lblrno
        '
        Me.lblrno.AutoSize = True
        Me.lblrno.Location = New System.Drawing.Point(189, 173)
        Me.lblrno.Name = "lblrno"
        Me.lblrno.Size = New System.Drawing.Size(19, 20)
        Me.lblrno.TabIndex = 8
        Me.lblrno.Text = "0"
        '
        'stdimg
        '
        Me.stdimg.Location = New System.Drawing.Point(692, 103)
        Me.stdimg.Name = "stdimg"
        Me.stdimg.Size = New System.Drawing.Size(135, 161)
        Me.stdimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stdimg.TabIndex = 16
        Me.stdimg.TabStop = False
        '
        'lblsname
        '
        Me.lblsname.AutoSize = True
        Me.lblsname.Location = New System.Drawing.Point(445, 79)
        Me.lblsname.Name = "lblsname"
        Me.lblsname.Size = New System.Drawing.Size(129, 20)
        Me.lblsname.TabIndex = 9
        Me.lblsname.Text = "Student Name "
        Me.lblsname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblctgr
        '
        Me.lblctgr.AutoSize = True
        Me.lblctgr.Location = New System.Drawing.Point(552, 244)
        Me.lblctgr.Name = "lblctgr"
        Me.lblctgr.Size = New System.Drawing.Size(46, 20)
        Me.lblctgr.TabIndex = 15
        Me.lblctgr.Text = "OBC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Year :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Catagory : "
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Location = New System.Drawing.Point(552, 128)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(49, 20)
        Me.lblyear.TabIndex = 11
        Me.lblyear.Text = "0000"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Location = New System.Drawing.Point(554, 185)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(47, 20)
        Me.lblgender.TabIndex = 13
        Me.lblgender.Text = "Male"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(447, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Gender :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentId, Me.RecieptNo, Me.TakenFor, Me.TakenDate, Me.TuationFees, Me.LibraryFees, Me.Std_Act_Fees, Me.UnionFees, Me.LabFees, Me.Total})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DataGridView1.Location = New System.Drawing.Point(12, 331)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1267, 322)
        Me.DataGridView1.TabIndex = 25
        '
        'StudentId
        '
        Me.StudentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.StudentId.HeaderText = "Student ID"
        Me.StudentId.Name = "StudentId"
        Me.StudentId.Width = 122
        '
        'RecieptNo
        '
        Me.RecieptNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.RecieptNo.HeaderText = "RecieptNo"
        Me.RecieptNo.Name = "RecieptNo"
        Me.RecieptNo.Width = 118
        '
        'TakenFor
        '
        Me.TakenFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TakenFor.HeaderText = "Taken For"
        Me.TakenFor.Name = "TakenFor"
        Me.TakenFor.Width = 115
        '
        'TakenDate
        '
        Me.TakenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TakenDate.HeaderText = "Taken Date"
        Me.TakenDate.Name = "TakenDate"
        Me.TakenDate.Width = 127
        '
        'TuationFees
        '
        Me.TuationFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.TuationFees.HeaderText = "Tuation Fees"
        Me.TuationFees.Name = "TuationFees"
        Me.TuationFees.Width = 139
        '
        'LibraryFees
        '
        Me.LibraryFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LibraryFees.HeaderText = "Library Fees"
        Me.LibraryFees.Name = "LibraryFees"
        Me.LibraryFees.Width = 133
        '
        'Std_Act_Fees
        '
        Me.Std_Act_Fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Std_Act_Fees.HeaderText = "Activity Fees"
        Me.Std_Act_Fees.Name = "Std_Act_Fees"
        Me.Std_Act_Fees.Width = 136
        '
        'UnionFees
        '
        Me.UnionFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.UnionFees.HeaderText = "Union Fees"
        Me.UnionFees.Name = "UnionFees"
        Me.UnionFees.Width = 126
        '
        'LabFees
        '
        Me.LabFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.LabFees.HeaderText = "Lab Fees"
        Me.LabFees.Name = "LabFees"
        Me.LabFees.Width = 109
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(893, 673)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(143, 20)
        Me.lbltotal.TabIndex = 26
        Me.lbltotal.Text = "Total Recieved : "
        '
        'txttotalr
        '
        Me.txttotalr.Location = New System.Drawing.Point(1042, 667)
        Me.txttotalr.Name = "txttotalr"
        Me.txttotalr.ReadOnly = True
        Me.txttotalr.Size = New System.Drawing.Size(156, 26)
        Me.txttotalr.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(759, 665)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 36)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Location = New System.Drawing.Point(12, 306)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(140, 20)
        Me.lbltitle.TabIndex = 29
        Me.lbltitle.Text = "Title Information"
        '
        'Fees_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 746)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotalr)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Fees_Details"
        Me.Text = "Fees_Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.stdimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combosem As System.Windows.Forms.ComboBox
    Friend WithEvents Comborno As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblcodes As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents lblrno As System.Windows.Forms.Label
    Friend WithEvents stdimg As System.Windows.Forms.PictureBox
    Friend WithEvents lblsname As System.Windows.Forms.Label
    Friend WithEvents lblctgr As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents comboyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents txttotalr As System.Windows.Forms.TextBox
    Friend WithEvents StudentId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecieptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakenFor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TakenDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TuationFees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibraryFees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Std_Act_Fees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnionFees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabFees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbltitle As System.Windows.Forms.Label
End Class
