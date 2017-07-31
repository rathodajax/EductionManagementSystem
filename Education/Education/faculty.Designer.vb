<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faculty
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
        Me.cmbbookid = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbsubject = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbsname = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BOOK_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOK_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BOOK_AUTHOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ALLOCATE = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RENEW = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SUBMIT = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.RSDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnrenew = New System.Windows.Forms.Button
        Me.btninsert = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbbookid
        '
        Me.cmbbookid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbookid.FormattingEnabled = True
        Me.cmbbookid.Location = New System.Drawing.Point(846, 37)
        Me.cmbbookid.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cmbbookid.Name = "cmbbookid"
        Me.cmbbookid.Size = New System.Drawing.Size(176, 22)
        Me.cmbbookid.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(685, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Select Book_ID :"
        '
        'cmbsubject
        '
        Me.cmbsubject.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubject.FormattingEnabled = True
        Me.cmbsubject.Location = New System.Drawing.Point(493, 37)
        Me.cmbsubject.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cmbsubject.Name = "cmbsubject"
        Me.cmbsubject.Size = New System.Drawing.Size(180, 22)
        Me.cmbsubject.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(342, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Select Subject :"
        '
        'cmbsname
        '
        Me.cmbsname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsname.FormattingEnabled = True
        Me.cmbsname.Items.AddRange(New Object() {"Amit Hariyani", "S R Dwivedi", "P M Doliya", "Disha Desani", "Jaypalsingh Gohil"})
        Me.cmbsname.Location = New System.Drawing.Point(155, 37)
        Me.cmbsname.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.cmbsname.Name = "cmbsname"
        Me.cmbsname.Size = New System.Drawing.Size(175, 22)
        Me.cmbsname.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Faculty Name : "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BOOK_ID, Me.BOOK_NAME, Me.BOOK_AUTHOR, Me.ALLOCATE, Me.IssueDate, Me.RENEW, Me.SUBMIT, Me.RSDATE})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 114)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1009, 219)
        Me.DataGridView1.TabIndex = 27
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
        'btnrenew
        '
        Me.btnrenew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrenew.Location = New System.Drawing.Point(439, 384)
        Me.btnrenew.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnrenew.Name = "btnrenew"
        Me.btnrenew.Size = New System.Drawing.Size(116, 47)
        Me.btnrenew.TabIndex = 30
        Me.btnrenew.Text = "Renew"
        Me.btnrenew.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(282, 384)
        Me.btninsert.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(116, 47)
        Me.btninsert.TabIndex = 29
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(589, 384)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 47)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 498)
        Me.Controls.Add(Me.btnrenew)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbbookid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbsubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbsname)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "faculty"
        Me.Text = "Faculty Book Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbbookid As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbsubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbsname As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BOOK_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOK_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BOOK_AUTHOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALLOCATE As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IssueDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RENEW As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SUBMIT As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RSDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnrenew As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
