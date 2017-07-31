<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class display
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSem = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.p1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbETYPE = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbSearch = New System.Windows.Forms.ComboBox
        Me.p2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSeatNo = New System.Windows.Forms.TextBox
        Me.p3 = New System.Windows.Forms.Panel
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dis = New System.Windows.Forms.DataGridViewButtonColumn
        Me.year = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sem_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.e_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unique_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.seat_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.name1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.int_tot = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ext_tot = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.per = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.result = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.exam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.atkt = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.result_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.res_date1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.p3.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Semester:"
        '
        'cmbSem
        '
        Me.cmbSem.DisplayMember = "SEMESTER_NAME"
        Me.cmbSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Location = New System.Drawing.Point(344, 6)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(204, 32)
        Me.cmbSem.TabIndex = 6
        Me.cmbSem.ValueMember = "SEMESTER_NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Year:"
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(80, 5)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(137, 32)
        Me.cmbYear.TabIndex = 4
        '
        'dgv1
        '
        Me.dgv1.AllowUserToResizeColumns = False
        Me.dgv1.AllowUserToResizeRows = False
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dis, Me.year, Me.sem_id, Me.e_type, Me.unique_id, Me.seat_no, Me.name1, Me.int_tot, Me.ext_tot, Me.per, Me.result, Me.exam, Me.atkt, Me.result_id, Me.res_date1})
        Me.dgv1.Location = New System.Drawing.Point(17, 17)
        Me.dgv1.MultiSelect = False
        Me.dgv1.Name = "dgv1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv1.Size = New System.Drawing.Size(1196, 475)
        Me.dgv1.TabIndex = 8
        '
        'p1
        '
        Me.p1.Controls.Add(Me.Label5)
        Me.p1.Controls.Add(Me.cmbYear)
        Me.p1.Controls.Add(Me.cmbETYPE)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Controls.Add(Me.Label2)
        Me.p1.Controls.Add(Me.cmbSem)
        Me.p1.Location = New System.Drawing.Point(387, 5)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(839, 42)
        Me.p1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(587, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 24)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Type:"
        '
        'cmbETYPE
        '
        Me.cmbETYPE.DisplayMember = "SEMESTER_NAME"
        Me.cmbETYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbETYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbETYPE.FormattingEnabled = True
        Me.cmbETYPE.Location = New System.Drawing.Point(651, 6)
        Me.cmbETYPE.Name = "cmbETYPE"
        Me.cmbETYPE.Size = New System.Drawing.Size(175, 32)
        Me.cmbETYPE.TabIndex = 46
        Me.cmbETYPE.ValueMember = "SEMESTER_NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search By:"
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"All", "Year And Semester", "Student Unique ID", "Student Name", "ATKT"})
        Me.cmbSearch.Location = New System.Drawing.Point(120, 11)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(237, 32)
        Me.cmbSearch.TabIndex = 8
        '
        'p2
        '
        Me.p2.Controls.Add(Me.Label4)
        Me.p2.Controls.Add(Me.txtSeatNo)
        Me.p2.Location = New System.Drawing.Point(32, 106)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(839, 42)
        Me.p2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 24)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Enter Student Unique ID:"
        '
        'txtSeatNo
        '
        Me.txtSeatNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatNo.Location = New System.Drawing.Point(230, 6)
        Me.txtSeatNo.Name = "txtSeatNo"
        Me.txtSeatNo.Size = New System.Drawing.Size(380, 29)
        Me.txtSeatNo.TabIndex = 42
        '
        'p3
        '
        Me.p3.Controls.Add(Me.txtName)
        Me.p3.Controls.Add(Me.Label6)
        Me.p3.Location = New System.Drawing.Point(32, 154)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(839, 42)
        Me.p3.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(80, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(530, 29)
        Me.txtName.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Name:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(220, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(197, 34)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Collect Exam Fee"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(17, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 34)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Add Result"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1104, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 34)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.SystemColors.Window
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBottom.Controls.Add(Me.Button2)
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.Controls.Add(Me.Button3)
        Me.pnlBottom.Location = New System.Drawing.Point(70, 608)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1233, 53)
        Me.pnlBottom.TabIndex = 47
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbSearch)
        Me.Panel1.Controls.Add(Me.p1)
        Me.Panel1.Location = New System.Drawing.Point(70, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 58)
        Me.Panel1.TabIndex = 48
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.p3)
        Me.Panel2.Controls.Add(Me.p2)
        Me.Panel2.Controls.Add(Me.dgv1)
        Me.Panel2.Location = New System.Drawing.Point(70, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1233, 509)
        Me.Panel2.TabIndex = 48
        '
        'dis
        '
        Me.dis.HeaderText = "View"
        Me.dis.Name = "dis"
        Me.dis.Width = 58
        '
        'year
        '
        Me.year.HeaderText = "Year"
        Me.year.Name = "year"
        Me.year.ReadOnly = True
        Me.year.Visible = False
        Me.year.Width = 74
        '
        'sem_id
        '
        Me.sem_id.HeaderText = "Sem ID"
        Me.sem_id.Name = "sem_id"
        Me.sem_id.ReadOnly = True
        Me.sem_id.Visible = False
        Me.sem_id.Width = 96
        '
        'e_type
        '
        Me.e_type.HeaderText = "Exam Type"
        Me.e_type.Name = "e_type"
        Me.e_type.Visible = False
        Me.e_type.Width = 132
        '
        'unique_id
        '
        Me.unique_id.HeaderText = "Unique ID"
        Me.unique_id.Name = "unique_id"
        Me.unique_id.ReadOnly = True
        Me.unique_id.Width = 118
        '
        'seat_no
        '
        Me.seat_no.HeaderText = "Seat No"
        Me.seat_no.Name = "seat_no"
        Me.seat_no.ReadOnly = True
        Me.seat_no.Width = 102
        '
        'name1
        '
        Me.name1.HeaderText = "Name"
        Me.name1.Name = "name1"
        Me.name1.ReadOnly = True
        Me.name1.Width = 86
        '
        'int_tot
        '
        Me.int_tot.HeaderText = "Internal Total"
        Me.int_tot.Name = "int_tot"
        Me.int_tot.ReadOnly = True
        Me.int_tot.Width = 142
        '
        'ext_tot
        '
        Me.ext_tot.HeaderText = "External Total"
        Me.ext_tot.Name = "ext_tot"
        Me.ext_tot.ReadOnly = True
        Me.ext_tot.Width = 150
        '
        'per
        '
        Me.per.HeaderText = "%"
        Me.per.Name = "per"
        Me.per.ReadOnly = True
        Me.per.Width = 50
        '
        'result
        '
        Me.result.HeaderText = "Result"
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Width = 87
        '
        'exam
        '
        Me.exam.HeaderText = "Exam"
        Me.exam.Name = "exam"
        Me.exam.ReadOnly = True
        Me.exam.Width = 84
        '
        'atkt
        '
        Me.atkt.HeaderText = "ATKT"
        Me.atkt.Name = "atkt"
        Me.atkt.ReadOnly = True
        Me.atkt.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.atkt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.atkt.Visible = False
        Me.atkt.Width = 84
        '
        'result_id
        '
        Me.result_id.HeaderText = "Result ID"
        Me.result_id.Name = "result_id"
        Me.result_id.ReadOnly = True
        Me.result_id.Visible = False
        Me.result_id.Width = 109
        '
        'res_date1
        '
        Me.res_date1.HeaderText = "Date"
        Me.res_date1.Name = "res_date1"
        Me.res_date1.ReadOnly = True
        Me.res_date1.Width = 73
        '
        'display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1366, 745)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBottom)
        Me.KeyPreview = True
        Me.Name = "display"
        Me.Text = "Display Result"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents p1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents p2 As System.Windows.Forms.Panel
    Friend WithEvents p3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSeatNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbETYPE As System.Windows.Forms.ComboBox
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dis As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sem_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents e_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unique_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seat_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents int_tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ext_tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents per As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents result As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents atkt As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents result_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents res_date1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
