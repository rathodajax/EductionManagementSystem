<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmview
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
        Me.dgviewstudent = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stud_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmat_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stud_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ad_type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clg_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.comboadmissiontype = New System.Windows.Forms.ComboBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.combostudentin = New System.Windows.Forms.ComboBox
        Me.comboafterround = New System.Windows.Forms.ComboBox
        Me.comboselectyear = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgviewstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgviewstudent
        '
        Me.dgviewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviewstudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.stud_id, Me.cmat_no, Me.roll_no, Me.stud_name, Me.ad_type, Me.clg_name})
        Me.dgviewstudent.Location = New System.Drawing.Point(7, 153)
        Me.dgviewstudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgviewstudent.Name = "dgviewstudent"
        Me.dgviewstudent.Size = New System.Drawing.Size(1349, 573)
        Me.dgviewstudent.TabIndex = 0
        '
        'srno
        '
        Me.srno.HeaderText = "SR NO"
        Me.srno.Name = "srno"
        Me.srno.ReadOnly = True
        '
        'stud_id
        '
        Me.stud_id.HeaderText = "STUD ID"
        Me.stud_id.Name = "stud_id"
        Me.stud_id.ReadOnly = True
        '
        'cmat_no
        '
        Me.cmat_no.HeaderText = "CMAT NO"
        Me.cmat_no.Name = "cmat_no"
        Me.cmat_no.ReadOnly = True
        '
        'roll_no
        '
        Me.roll_no.HeaderText = "ROLL NO"
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        '
        'stud_name
        '
        Me.stud_name.HeaderText = "STUDENT NAME"
        Me.stud_name.Name = "stud_name"
        Me.stud_name.ReadOnly = True
        Me.stud_name.Width = 300
        '
        'ad_type
        '
        Me.ad_type.HeaderText = "ADMISSION TYPE"
        Me.ad_type.Name = "ad_type"
        Me.ad_type.ReadOnly = True
        Me.ad_type.Width = 200
        '
        'clg_name
        '
        Me.clg_name.HeaderText = "COLLEGE NAME"
        Me.clg_name.Name = "clg_name"
        Me.clg_name.ReadOnly = True
        Me.clg_name.Width = 380
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.comboadmissiontype)
        Me.Panel1.Controls.Add(Me.combostudentin)
        Me.Panel1.Controls.Add(Me.comboafterround)
        Me.Panel1.Controls.Add(Me.comboselectyear)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 70)
        Me.Panel1.TabIndex = 1
        '
        'comboadmissiontype
        '
        Me.comboadmissiontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboadmissiontype.FormattingEnabled = True
        Me.comboadmissiontype.Location = New System.Drawing.Point(1188, 9)
        Me.comboadmissiontype.Name = "comboadmissiontype"
        Me.comboadmissiontype.Size = New System.Drawing.Size(153, 28)
        Me.comboadmissiontype.TabIndex = 9
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(530, 107)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(97, 28)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(814, 107)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 28)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'combostudentin
        '
        Me.combostudentin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combostudentin.FormattingEnabled = True
        Me.combostudentin.Location = New System.Drawing.Point(844, 7)
        Me.combostudentin.Name = "combostudentin"
        Me.combostudentin.Size = New System.Drawing.Size(154, 28)
        Me.combostudentin.TabIndex = 8
        '
        'comboafterround
        '
        Me.comboafterround.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboafterround.FormattingEnabled = True
        Me.comboafterround.Location = New System.Drawing.Point(539, 9)
        Me.comboafterround.Name = "comboafterround"
        Me.comboafterround.Size = New System.Drawing.Size(145, 28)
        Me.comboafterround.TabIndex = 7
        '
        'comboselectyear
        '
        Me.comboselectyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboselectyear.FormattingEnabled = True
        Me.comboselectyear.Location = New System.Drawing.Point(173, 12)
        Me.comboselectyear.Name = "comboselectyear"
        Me.comboselectyear.Size = New System.Drawing.Size(145, 28)
        Me.comboselectyear.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1026, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ADMISSION TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(710, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "STUDENT IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AFTER ROUND"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELECT YEAR "
        '
        'frmview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.dgviewstudent)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmview"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgviewstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgviewstudent As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboadmissiontype As System.Windows.Forms.ComboBox
    Friend WithEvents combostudentin As System.Windows.Forms.ComboBox
    Friend WithEvents comboafterround As System.Windows.Forms.ComboBox
    Friend WithEvents comboselectyear As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stud_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmat_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stud_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ad_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clg_name As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
