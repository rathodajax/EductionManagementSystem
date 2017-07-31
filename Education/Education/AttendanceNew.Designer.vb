<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceNew
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
        Me.components = New System.ComponentModel.Container
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.stdno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdrollno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdat = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.stud_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STUDENTMASTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbRegYear = New System.Windows.Forms.ComboBox
        Me.cmbSem = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.optPresent = New System.Windows.Forms.RadioButton
        Me.optAbsent = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTMASTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(696, 152)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(190, 40)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(297, 653)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(407, 40)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stdno, Me.stdrollno, Me.stdname, Me.stdat, Me.stud_id})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 196)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(976, 445)
        Me.DataGridView1.TabIndex = 7
        '
        'stdno
        '
        Me.stdno.HeaderText = "No"
        Me.stdno.Name = "stdno"
        Me.stdno.ReadOnly = True
        '
        'stdrollno
        '
        Me.stdrollno.HeaderText = "RollNo"
        Me.stdrollno.Name = "stdrollno"
        Me.stdrollno.ReadOnly = True
        Me.stdrollno.Width = 150
        '
        'stdname
        '
        Me.stdname.HeaderText = "Student Name"
        Me.stdname.Name = "stdname"
        Me.stdname.ReadOnly = True
        Me.stdname.Width = 300
        '
        'stdat
        '
        Me.stdat.HeaderText = "Present/Absent"
        Me.stdat.Name = "stdat"
        Me.stdat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stdat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.stdat.Width = 170
        '
        'stud_id
        '
        Me.stud_id.HeaderText = "id"
        Me.stud_id.Name = "stud_id"
        Me.stud_id.Visible = False
        '
        'STUDENTMASTERBindingSource
        '
        Me.STUDENTMASTERBindingSource.DataMember = "STUDENT_MASTER"
        '
        'cmbSubject
        '
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(639, 110)
        Me.cmbSubject.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(357, 32)
        Me.cmbSubject.TabIndex = 3
        Me.cmbSubject.Tag = "111111111111"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd/MM/yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(274, 112)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(179, 29)
        Me.dtp1.TabIndex = 2
        Me.dtp1.Tag = "111111111111"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select Semester"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Select Registration Year"
        '
        'cmbRegYear
        '
        Me.cmbRegYear.FormattingEnabled = True
        Me.cmbRegYear.Location = New System.Drawing.Point(274, 63)
        Me.cmbRegYear.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(179, 32)
        Me.cmbRegYear.TabIndex = 0
        Me.cmbRegYear.Tag = "111111111111"
        '
        'cmbSem
        '
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(639, 63)
        Me.cmbSem.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(357, 32)
        Me.cmbSem.TabIndex = 1
        Me.cmbSem.Tag = "111111111111"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Select Attendance Type"
        '
        'optPresent
        '
        Me.optPresent.AutoSize = True
        Me.optPresent.Location = New System.Drawing.Point(281, 158)
        Me.optPresent.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.optPresent.Name = "optPresent"
        Me.optPresent.Size = New System.Drawing.Size(99, 28)
        Me.optPresent.TabIndex = 4
        Me.optPresent.TabStop = True
        Me.optPresent.Text = "Present"
        Me.optPresent.UseVisualStyleBackColor = True
        '
        'optAbsent
        '
        Me.optAbsent.AutoSize = True
        Me.optAbsent.Location = New System.Drawing.Point(397, 158)
        Me.optAbsent.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.optAbsent.Name = "optAbsent"
        Me.optAbsent.Size = New System.Drawing.Size(93, 28)
        Me.optAbsent.TabIndex = 5
        Me.optAbsent.TabStop = True
        Me.optAbsent.Text = "Absent"
        Me.optAbsent.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(374, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 39)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Attendance Register"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(19, 653)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(268, 40)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(517, 159)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(117, 28)
        Me.chkSelectAll.TabIndex = 16
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(714, 653)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(280, 40)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search Attendance"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(696, 152)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(190, 40)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AttendanceNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1364, 745)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.optAbsent)
        Me.Controls.Add(Me.optPresent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSem)
        Me.Controls.Add(Me.cmbRegYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.cmbSubject)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "AttendanceNew"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTMASTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents optPresent As System.Windows.Forms.RadioButton
    Friend WithEvents optAbsent As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    'Friend WithEvents DEPTDataSet As Attendance.DEPTDataSet
    Friend WithEvents STUDENTMASTERBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents STUDENT_MASTERTableAdapter As Attendance.DEPTDataSetTableAdapters.STUDENT_MASTERTableAdapter
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents stdno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdrollno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdat As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents stud_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
