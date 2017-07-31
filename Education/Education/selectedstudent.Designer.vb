<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectedstudent
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
        Me.Grid_Company = New System.Windows.Forms.DataGridView
        Me.comp_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comp_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.arrival_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.batch_year = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Technology = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total_student = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.arrid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Grid_Student = New System.Windows.Forms.DataGridView
        Me.selectedstud = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.uniqid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.reg_yr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mob = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbcompid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.Grid_Selected_Student = New System.Windows.Forms.DataGridView
        Me.uid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.snm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.syr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.smno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.Grid_Company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Student, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Selected_Student, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid_Company
        '
        Me.Grid_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Company.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.comp_id, Me.comp_name, Me.arrival_date, Me.batch_year, Me.sem, Me.Technology, Me.total_student, Me.Purpose, Me.arrid})
        Me.Grid_Company.Location = New System.Drawing.Point(12, 70)
        Me.Grid_Company.Name = "Grid_Company"
        Me.Grid_Company.Size = New System.Drawing.Size(543, 576)
        Me.Grid_Company.TabIndex = 0
        '
        'comp_id
        '
        Me.comp_id.HeaderText = "Company_ID"
        Me.comp_id.Name = "comp_id"
        '
        'comp_name
        '
        Me.comp_name.HeaderText = "Name"
        Me.comp_name.Name = "comp_name"
        '
        'arrival_date
        '
        Me.arrival_date.HeaderText = "Arrival_Date"
        Me.arrival_date.Name = "arrival_date"
        '
        'batch_year
        '
        Me.batch_year.HeaderText = "Batch_Date"
        Me.batch_year.Name = "batch_year"
        '
        'sem
        '
        Me.sem.HeaderText = "Semester"
        Me.sem.Name = "sem"
        '
        'Technology
        '
        Me.Technology.HeaderText = "Technology"
        Me.Technology.Name = "Technology"
        '
        'total_student
        '
        Me.total_student.HeaderText = "Total_Student"
        Me.total_student.Name = "total_student"
        '
        'Purpose
        '
        Me.Purpose.HeaderText = "Purpose"
        Me.Purpose.Name = "Purpose"
        '
        'arrid
        '
        Me.arrid.HeaderText = "Arrival ID"
        Me.arrid.Name = "arrid"
        '
        'Grid_Student
        '
        Me.Grid_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Student.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectedstud, Me.uniqid, Me.reg_yr, Me.rno, Me.sname, Me.gen, Me.mob})
        Me.Grid_Student.Location = New System.Drawing.Point(574, 70)
        Me.Grid_Student.Name = "Grid_Student"
        Me.Grid_Student.Size = New System.Drawing.Size(533, 316)
        Me.Grid_Student.TabIndex = 1
        '
        'selectedstud
        '
        Me.selectedstud.HeaderText = "Selected_Student"
        Me.selectedstud.Name = "selectedstud"
        '
        'uniqid
        '
        Me.uniqid.HeaderText = "Unique_ID"
        Me.uniqid.Name = "uniqid"
        '
        'reg_yr
        '
        Me.reg_yr.HeaderText = "Year"
        Me.reg_yr.Name = "reg_yr"
        '
        'rno
        '
        Me.rno.HeaderText = "Roll_No"
        Me.rno.Name = "rno"
        '
        'sname
        '
        Me.sname.HeaderText = "Student_Name"
        Me.sname.Name = "sname"
        '
        'gen
        '
        Me.gen.HeaderText = "Gender"
        Me.gen.Name = "gen"
        '
        'mob
        '
        Me.mob.HeaderText = "Mobile_No"
        Me.mob.Name = "mob"
        '
        'cmbcompid
        '
        Me.cmbcompid.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcompid.FormattingEnabled = True
        Me.cmbcompid.Items.AddRange(New Object() {"All"})
        Me.cmbcompid.Location = New System.Drawing.Point(144, 9)
        Me.cmbcompid.Name = "cmbcompid"
        Me.cmbcompid.Size = New System.Drawing.Size(240, 33)
        Me.cmbcompid.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Select Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Arrived Companies For Recruitement Purpose"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(810, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Student Detail"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.Control
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(984, 33)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(123, 34)
        Me.btnsave.TabIndex = 58
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Grid_Selected_Student
        '
        Me.Grid_Selected_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Selected_Student.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uid, Me.snm, Me.srno, Me.syr, Me.smno})
        Me.Grid_Selected_Student.Location = New System.Drawing.Point(574, 405)
        Me.Grid_Selected_Student.Name = "Grid_Selected_Student"
        Me.Grid_Selected_Student.Size = New System.Drawing.Size(533, 241)
        Me.Grid_Selected_Student.TabIndex = 59
        '
        'uid
        '
        Me.uid.HeaderText = "Unique_ID"
        Me.uid.Name = "uid"
        '
        'snm
        '
        Me.snm.HeaderText = "Name"
        Me.snm.Name = "snm"
        '
        'srno
        '
        Me.srno.HeaderText = "Roll_No"
        Me.srno.Name = "srno"
        '
        'syr
        '
        Me.syr.HeaderText = "Year"
        Me.syr.Name = "syr"
        '
        'smno
        '
        Me.smno.HeaderText = "Mobile_No"
        Me.smno.Name = "smno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(787, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Selected Student"
        '
        'selectedstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1233, 648)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Grid_Selected_Student)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbcompid)
        Me.Controls.Add(Me.Grid_Student)
        Me.Controls.Add(Me.Grid_Company)
        Me.Name = "selectedstudent"
        Me.Text = "Selection_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid_Company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Student, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Selected_Student, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid_Company As System.Windows.Forms.DataGridView
    Friend WithEvents Grid_Student As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcompid As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Grid_Selected_Student As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comp_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arrival_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batch_year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Technology As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_student As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Purpose As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arrid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selectedstud As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents uniqid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents reg_yr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents snm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents syr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents smno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
