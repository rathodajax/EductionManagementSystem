<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stud
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
        Me.cmbbatch = New System.Windows.Forms.ComboBox
        Me.cmbsem = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbsname = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BOOK_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOK_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOK_AUTHOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ALLOCATE = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RENEW = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SUBMIT = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.RSDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbsubject = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbbookid = New System.Windows.Forms.ComboBox
        Me.btninsert = New System.Windows.Forms.Button
        Me.btnrenew = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(711, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Semester : "
        '
        'cmbbatch
        '
        Me.cmbbatch.FormattingEnabled = True
        Me.cmbbatch.Location = New System.Drawing.Point(170, 55)
        Me.cmbbatch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbbatch.Name = "cmbbatch"
        Me.cmbbatch.Size = New System.Drawing.Size(160, 22)
        Me.cmbbatch.TabIndex = 1
        '
        'cmbsem
        '
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Location = New System.Drawing.Point(821, 51)
        Me.cmbsem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(160, 22)
        Me.cmbsem.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(363, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Student Name : "
        '
        'cmbsname
        '
        Me.cmbsname.FormattingEnabled = True
        Me.cmbsname.Location = New System.Drawing.Point(532, 51)
        Me.cmbsname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbsname.Name = "cmbsname"
        Me.cmbsname.Size = New System.Drawing.Size(160, 22)
        Me.cmbsname.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOK_ID, Me.BOOK_NAME, Me.BOOK_AUTHOR, Me.ALLOCATE, Me.IssueDate, Me.RENEW, Me.SUBMIT, Me.RSDATE})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 204)
        Me.DataGridView1.TabIndex = 11
        '
        'BOOK_ID
        '
        Me.BOOK_ID.HeaderText = "BOOK_ID"
        Me.BOOK_ID.Name = "BOOK_ID"
        Me.BOOK_ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'BOOK_NAME
        '
        Me.BOOK_NAME.HeaderText = "BOOK_NAME"
        Me.BOOK_NAME.Name = "BOOK_NAME"
        Me.BOOK_NAME.Width = 150
        '
        'BOOK_AUTHOR
        '
        Me.BOOK_AUTHOR.HeaderText = "BOOK_AUTHOR"
        Me.BOOK_AUTHOR.Name = "BOOK_AUTHOR"
        Me.BOOK_AUTHOR.Width = 150
        '
        'ALLOCATE
        '
        Me.ALLOCATE.HeaderText = "ALLOCATE"
        Me.ALLOCATE.Name = "ALLOCATE"
        Me.ALLOCATE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALLOCATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IssueDate
        '
        Me.IssueDate.HeaderText = "ISSUE_DAET"
        Me.IssueDate.Name = "IssueDate"
        '
        'RENEW
        '
        Me.RENEW.HeaderText = "RENEW"
        Me.RENEW.Name = "RENEW"
        Me.RENEW.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RENEW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SUBMIT
        '
        Me.SUBMIT.HeaderText = "SUBMIT"
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SUBMIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RSDATE
        '
        Me.RSDATE.HeaderText = "RENEW/SUBMIT_DATE"
        Me.RSDATE.Name = "RSDATE"
        Me.RSDATE.Width = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Select Subject :"
        '
        'cmbsubject
        '
        Me.cmbsubject.FormattingEnabled = True
        Me.cmbsubject.Location = New System.Drawing.Point(170, 127)
        Me.cmbsubject.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbsubject.Name = "cmbsubject"
        Me.cmbsubject.Size = New System.Drawing.Size(160, 22)
        Me.cmbsubject.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(559, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 127)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Select Book_ID :"
        '
        'cmbbookid
        '
        Me.cmbbookid.FormattingEnabled = True
        Me.cmbbookid.Location = New System.Drawing.Point(532, 127)
        Me.cmbbookid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbbookid.Name = "cmbbookid"
        Me.cmbbookid.Size = New System.Drawing.Size(160, 22)
        Me.cmbbookid.TabIndex = 5
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(367, 469)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(87, 43)
        Me.btninsert.TabIndex = 21
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnrenew
        '
        Me.btnrenew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrenew.Location = New System.Drawing.Point(460, 469)
        Me.btnrenew.Name = "btnrenew"
        Me.btnrenew.Size = New System.Drawing.Size(87, 43)
        Me.btnrenew.TabIndex = 22
        Me.btnrenew.Text = "Renew"
        Me.btnrenew.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(668, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 43)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Show Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'stud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 524)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnrenew)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.cmbbookid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbsubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbsname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbsem)
        Me.Controls.Add(Me.cmbbatch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "stud"
        Me.Text = "Student Book Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbbatch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsem As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbsname As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbsubject As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbbookid As System.Windows.Forms.ComboBox
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnrenew As System.Windows.Forms.Button
    Friend WithEvents BOOK_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOK_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOK_AUTHOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALLOCATE As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RENEW As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SUBMIT As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
