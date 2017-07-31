<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrivalComapnyReport
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbcomp = New System.Windows.Forms.ComboBox
        Me.cmbbatch = New System.Windows.Forms.ComboBox
        Me.cmbsem = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnshow = New System.Windows.Forms.Button
        Me.comp_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comp_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.arrival_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.batch_year = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Technology = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total_student = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Grid_Company, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid_Company
        '
        Me.Grid_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Company.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.comp_id, Me.comp_name, Me.arrival_date, Me.batch_year, Me.sem, Me.Technology, Me.total_student, Me.Purpose})
        Me.Grid_Company.Location = New System.Drawing.Point(12, 148)
        Me.Grid_Company.Name = "Grid_Company"
        Me.Grid_Company.Size = New System.Drawing.Size(846, 591)
        Me.Grid_Company.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Select Company"
        '
        'cmbcomp
        '
        Me.cmbcomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcomp.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcomp.FormattingEnabled = True
        Me.cmbcomp.Items.AddRange(New Object() {"All"})
        Me.cmbcomp.Location = New System.Drawing.Point(147, 46)
        Me.cmbcomp.Name = "cmbcomp"
        Me.cmbcomp.Size = New System.Drawing.Size(174, 24)
        Me.cmbcomp.TabIndex = 62
        '
        'cmbbatch
        '
        Me.cmbbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbatch.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbatch.FormattingEnabled = True
        Me.cmbbatch.Items.AddRange(New Object() {"2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000"})
        Me.cmbbatch.Location = New System.Drawing.Point(147, 12)
        Me.cmbbatch.Name = "cmbbatch"
        Me.cmbbatch.Size = New System.Drawing.Size(174, 24)
        Me.cmbbatch.TabIndex = 60
        '
        'cmbsem
        '
        Me.cmbsem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsem.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Items.AddRange(New Object() {"Sem5", "Sem6"})
        Me.cmbsem.Location = New System.Drawing.Point(147, 82)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(174, 24)
        Me.cmbsem.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Select Sem"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Select Year"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.cmbsem)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbcomp)
        Me.GroupBox1.Controls.Add(Me.cmbbatch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 120)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.SystemColors.Control
        Me.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshow.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(747, 104)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(111, 28)
        Me.btnshow.TabIndex = 67
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'comp_id
        '
        Me.comp_id.HeaderText = "No"
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
        'frmArrivalComapnyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 727)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid_Company)
        Me.Name = "frmArrivalComapnyReport"
        Me.Text = "frmArrivalComapnyReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid_Company, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid_Company As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcomp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbatch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsem As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents comp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comp_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents arrival_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batch_year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Technology As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_student As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Purpose As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
