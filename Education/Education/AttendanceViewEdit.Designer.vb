<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceViewEdit
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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbSem = New System.Windows.Forms.ComboBox
        Me.cmbRegYear = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.btnSave = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.stdno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdrollno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdat = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.stud_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbSubject = New System.Windows.Forms.ComboBox
        Me.STUDENTMASTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTMASTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(280, 611)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(407, 40)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(374, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(381, 39)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Attendance View / Edit"
        '
        'cmbSem
        '
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(645, 56)
        Me.cmbSem.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(357, 32)
        Me.cmbSem.TabIndex = 18
        Me.cmbSem.Tag = "111111111111"
        '
        'cmbRegYear
        '
        Me.cmbRegYear.FormattingEnabled = True
        Me.cmbRegYear.Location = New System.Drawing.Point(280, 56)
        Me.cmbRegYear.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(179, 32)
        Me.cmbRegYear.TabIndex = 17
        Me.cmbRegYear.Tag = "111111111111"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Select Registration Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Select Semester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(467, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Select Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Select Date"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd/MM/yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(280, 105)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(179, 29)
        Me.dtp1.TabIndex = 19
        Me.dtp1.Tag = "111111111111"
        Me.dtp1.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(280, 611)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(407, 40)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stdno, Me.stdrollno, Me.stdname, Me.stdat, Me.stud_id})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 154)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(976, 445)
        Me.DataGridView1.TabIndex = 26
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
        Me.stdat.HeaderText = "Present"
        Me.stdat.Name = "stdat"
        Me.stdat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stdat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'stud_id
        '
        Me.stud_id.HeaderText = "id"
        Me.stud_id.Name = "stud_id"
        Me.stud_id.Visible = False
        '
        'cmbSubject
        '
        Me.cmbSubject.FormattingEnabled = True
        Me.cmbSubject.Location = New System.Drawing.Point(645, 103)
        Me.cmbSubject.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(357, 32)
        Me.cmbSubject.TabIndex = 20
        Me.cmbSubject.Tag = "111111111111"
        '
        'STUDENTMASTERBindingSource
        '
        Me.STUDENTMASTERBindingSource.DataMember = "STUDENT_MASTER"
        '
        'AttendanceViewEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1364, 745)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSem)
        Me.Controls.Add(Me.cmbRegYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbSubject)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "AttendanceViewEdit"
        Me.Text = "ViewRecords"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTMASTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSem As System.Windows.Forms.ComboBox
    'Friend WithEvents STUDENT_MASTERTableAdapter As Attendance.DEPTDataSetTableAdapters.STUDENT_MASTERTableAdapter
    Friend WithEvents cmbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSubject As System.Windows.Forms.ComboBox
    'Friend WithEvents DEPTDataSet As Attendance.DEPTDataSet
    Friend WithEvents STUDENTMASTERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents stdno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdrollno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdat As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents stud_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
