<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceSearch
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
        Me.chkSub = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbSem = New System.Windows.Forms.ComboBox
        Me.cmbRegYear = New System.Windows.Forms.ComboBox
        Me.chkSem = New System.Windows.Forms.CheckBox
        Me.chkDate = New System.Windows.Forms.CheckBox
        Me.chkYear = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.stdno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.regyear = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subject = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.attdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnViewReports = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkSub
        '
        Me.chkSub.AutoSize = True
        Me.chkSub.Location = New System.Drawing.Point(997, 128)
        Me.chkSub.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkSub.Name = "chkSub"
        Me.chkSub.Size = New System.Drawing.Size(53, 28)
        Me.chkSub.TabIndex = 34
        Me.chkSub.Text = "All"
        Me.chkSub.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(389, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(323, 39)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Attendance Search"
        '
        'cmbSem
        '
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(669, 71)
        Me.cmbSem.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(313, 32)
        Me.cmbSem.TabIndex = 21
        Me.cmbSem.Tag = "111111111111"
        '
        'cmbRegYear
        '
        Me.cmbRegYear.FormattingEnabled = True
        Me.cmbRegYear.Location = New System.Drawing.Point(259, 71)
        Me.cmbRegYear.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(143, 32)
        Me.cmbRegYear.TabIndex = 20
        Me.cmbRegYear.Tag = "111111111111"
        Me.cmbRegYear.Text = "2017"
        '
        'chkSem
        '
        Me.chkSem.AutoSize = True
        Me.chkSem.Location = New System.Drawing.Point(997, 73)
        Me.chkSem.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkSem.Name = "chkSem"
        Me.chkSem.Size = New System.Drawing.Size(53, 28)
        Me.chkSem.TabIndex = 33
        Me.chkSem.Text = "All"
        Me.chkSem.UseVisualStyleBackColor = True
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Location = New System.Drawing.Point(417, 128)
        Me.chkDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(53, 28)
        Me.chkDate.TabIndex = 32
        Me.chkDate.Text = "All"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'chkYear
        '
        Me.chkYear.AutoSize = True
        Me.chkYear.Location = New System.Drawing.Point(417, 73)
        Me.chkYear.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.chkYear.Name = "chkYear"
        Me.chkYear.Size = New System.Drawing.Size(53, 28)
        Me.chkYear.TabIndex = 31
        Me.chkYear.Text = "All"
        Me.chkYear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Select Registration Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Select Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(487, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Select Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Select Date"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd/MM/yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(259, 125)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(143, 29)
        Me.dtp1.TabIndex = 22
        Me.dtp1.Tag = "111111111111"
        '
        'cmbSubject
        '
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(669, 125)
        Me.cmbSubject.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(313, 32)
        Me.cmbSubject.TabIndex = 23
        Me.cmbSubject.Tag = "111111111111"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stdno, Me.regyear, Me.sem, Me.subject, Me.attdate, Me.id})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 183)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 430)
        Me.DataGridView1.TabIndex = 27
        '
        'stdno
        '
        Me.stdno.HeaderText = "No"
        Me.stdno.Name = "stdno"
        Me.stdno.ReadOnly = True
        Me.stdno.Width = 75
        '
        'regyear
        '
        Me.regyear.HeaderText = "Registration Year"
        Me.regyear.Name = "regyear"
        Me.regyear.ReadOnly = True
        Me.regyear.Width = 125
        '
        'sem
        '
        Me.sem.HeaderText = "Semester"
        Me.sem.Name = "sem"
        Me.sem.ReadOnly = True
        Me.sem.Width = 200
        '
        'subject
        '
        Me.subject.HeaderText = "Subject"
        Me.subject.Name = "subject"
        Me.subject.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subject.Width = 350
        '
        'attdate
        '
        Me.attdate.HeaderText = "Attendance Date"
        Me.attdate.Name = "attdate"
        Me.attdate.Width = 125
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(23, 627)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(289, 42)
        Me.btnNew.TabIndex = 35
        Me.btnNew.Text = "Take New Attendance"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnViewReports
        '
        Me.btnViewReports.Location = New System.Drawing.Point(318, 627)
        Me.btnViewReports.Name = "btnViewReports"
        Me.btnViewReports.Size = New System.Drawing.Size(276, 42)
        Me.btnViewReports.TabIndex = 36
        Me.btnViewReports.Text = "Attendance Summary"
        Me.btnViewReports.UseVisualStyleBackColor = True
        '
        'AttendanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1364, 745)
        Me.Controls.Add(Me.btnViewReports)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.chkSub)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSem)
        Me.Controls.Add(Me.cmbRegYear)
        Me.Controls.Add(Me.chkSem)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.chkYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "AttendanceSearch"
        Me.Text = "FormSearch1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkSub As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents chkSem As System.Windows.Forms.CheckBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents chkYear As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents stdno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents regyear As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents attdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnViewReports As System.Windows.Forms.Button
End Class
