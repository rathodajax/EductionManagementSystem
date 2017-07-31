<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsearch
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
        Me.lblyear = New System.Windows.Forms.Label
        Me.cmbyear = New System.Windows.Forms.ComboBox
        Me.lblselect = New System.Windows.Forms.Label
        Me.cmbselect = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.rollno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.marit_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stud_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.b_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.phone_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mob_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.b_degree = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtselect = New System.Windows.Forms.TextBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.cmbvisible = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(43, 95)
        Me.lblyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(124, 25)
        Me.lblyear.TabIndex = 0
        Me.lblyear.Text = "Select Year"
        '
        'cmbyear
        '
        Me.cmbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Location = New System.Drawing.Point(170, 92)
        Me.cmbyear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(165, 33)
        Me.cmbyear.TabIndex = 1
        '
        'lblselect
        '
        Me.lblselect.AutoSize = True
        Me.lblselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselect.Location = New System.Drawing.Point(370, 95)
        Me.lblselect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblselect.Name = "lblselect"
        Me.lblselect.Size = New System.Drawing.Size(227, 25)
        Me.lblselect.TabIndex = 2
        Me.lblselect.Text = "Select Student Where "
        '
        'cmbselect
        '
        Me.cmbselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbselect.FormattingEnabled = True
        Me.cmbselect.Items.AddRange(New Object() {"ALL", "MARIT", "STUDENT NAME", "GENDER", "CATEGORY", "ADDRESS", "PHONE NO", "MOBILE NO", "EMAIL", "BECHLOR DEGREE", "FROM COLLEGE"})
        Me.cmbselect.Location = New System.Drawing.Point(600, 92)
        Me.cmbselect.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbselect.Name = "cmbselect"
        Me.cmbselect.Size = New System.Drawing.Size(301, 33)
        Me.cmbselect.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rollno, Me.marit_no, Me.stud_name, Me.gen, Me.category, Me.b_date, Me.address, Me.phone_no, Me.mob_no, Me.email, Me.b_degree})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 195)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1336, 459)
        Me.DataGridView1.TabIndex = 10
        '
        'rollno
        '
        Me.rollno.HeaderText = "ROLL_NO"
        Me.rollno.Name = "rollno"
        '
        'marit_no
        '
        Me.marit_no.HeaderText = "MARIT_NO"
        Me.marit_no.Name = "marit_no"
        '
        'stud_name
        '
        Me.stud_name.HeaderText = "STUDENT_NAME"
        Me.stud_name.Name = "stud_name"
        Me.stud_name.Width = 200
        '
        'gen
        '
        Me.gen.HeaderText = "GENDER"
        Me.gen.Name = "gen"
        '
        'category
        '
        Me.category.HeaderText = "CATEGORY"
        Me.category.Name = "category"
        '
        'b_date
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.b_date.DefaultCellStyle = DataGridViewCellStyle3
        Me.b_date.HeaderText = "BIRTH_DATE"
        Me.b_date.Name = "b_date"
        Me.b_date.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.b_date.ToolTipText = "MM/DD/YYYY"
        '
        'address
        '
        Me.address.HeaderText = "ADDRESS"
        Me.address.Name = "address"
        Me.address.Width = 200
        '
        'phone_no
        '
        Me.phone_no.HeaderText = "PHONE_NO"
        Me.phone_no.Name = "phone_no"
        '
        'mob_no
        '
        Me.mob_no.HeaderText = "MOBILE_NO"
        Me.mob_no.Name = "mob_no"
        '
        'email
        '
        Me.email.HeaderText = "EMAIL"
        Me.email.Name = "email"
        Me.email.Width = 150
        '
        'b_degree
        '
        Me.b_degree.HeaderText = "BACHLOR_DEGREE"
        Me.b_degree.Name = "b_degree"
        '
        'txtselect
        '
        Me.txtselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtselect.Location = New System.Drawing.Point(939, 89)
        Me.txtselect.Margin = New System.Windows.Forms.Padding(4)
        Me.txtselect.Name = "txtselect"
        Me.txtselect.Size = New System.Drawing.Size(311, 35)
        Me.txtselect.TabIndex = 6
        Me.txtselect.Visible = False
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(946, 142)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(101, 33)
        Me.btnprint.TabIndex = 7
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(1162, 141)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(114, 34)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(1054, 141)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(101, 34)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'cmbvisible
        '
        Me.cmbvisible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbvisible.FormattingEnabled = True
        Me.cmbvisible.Location = New System.Drawing.Point(939, 89)
        Me.cmbvisible.Name = "cmbvisible"
        Me.cmbvisible.Size = New System.Drawing.Size(338, 33)
        Me.cmbvisible.TabIndex = 5
        Me.cmbvisible.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(547, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 33)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SEARCH STUDENT"
        '
        'frmsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 678)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbvisible)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtselect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbselect)
        Me.Controls.Add(Me.lblselect)
        Me.Controls.Add(Me.cmbyear)
        Me.Controls.Add(Me.lblyear)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmsearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents lblselect As System.Windows.Forms.Label
    Friend WithEvents cmbselect As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtselect As System.Windows.Forms.TextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents cmbvisible As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rollno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marit_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stud_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents b_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents phone_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mob_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents b_degree As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
