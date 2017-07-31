<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Info
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
        Me.lblsid = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lbldate = New System.Windows.Forms.Label
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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txttotalr = New System.Windows.Forms.TextBox
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.stdimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblsid)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lbldate)
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
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search  Student :"
        '
        'lblsid
        '
        Me.lblsid.AutoSize = True
        Me.lblsid.Location = New System.Drawing.Point(193, 59)
        Me.lblsid.Name = "lblsid"
        Me.lblsid.Size = New System.Drawing.Size(19, 20)
        Me.lblsid.TabIndex = 21
        Me.lblsid.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 244)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 20)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Date :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(193, 244)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(19, 20)
        Me.lbldate.TabIndex = 19
        Me.lbldate.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Student Id :"
        '
        'lblcodes
        '
        Me.lblcodes.AutoSize = True
        Me.lblcodes.Location = New System.Drawing.Point(193, 185)
        Me.lblcodes.Name = "lblcodes"
        Me.lblcodes.Size = New System.Drawing.Size(19, 20)
        Me.lblcodes.TabIndex = 18
        Me.lblcodes.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Roll No :"
        '
        'lblc
        '
        Me.lblc.AutoSize = True
        Me.lblc.Location = New System.Drawing.Point(33, 185)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(66, 20)
        Me.lblc.TabIndex = 17
        Me.lblc.Text = "Code : "
        '
        'lblrno
        '
        Me.lblrno.AutoSize = True
        Me.lblrno.Location = New System.Drawing.Point(193, 128)
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
        Me.lblsname.Location = New System.Drawing.Point(445, 59)
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 333)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(869, 229)
        Me.DataGridView1.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Receipt No"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 123
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column2.HeaderText = "Semester"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 111
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column3.HeaderText = "Taken Date"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 127
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 74
        '
        'txttotalr
        '
        Me.txttotalr.Location = New System.Drawing.Point(433, 584)
        Me.txttotalr.Name = "txttotalr"
        Me.txttotalr.ReadOnly = True
        Me.txttotalr.Size = New System.Drawing.Size(96, 26)
        Me.txttotalr.TabIndex = 29
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(284, 590)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(143, 20)
        Me.lbltotal.TabIndex = 28
        Me.lbltotal.Text = "Total Recieved : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 35)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Student_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 746)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotalr)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Student_Info"
        Me.Text = "Student_Info"
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
    Friend WithEvents lblsid As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txttotalr As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
