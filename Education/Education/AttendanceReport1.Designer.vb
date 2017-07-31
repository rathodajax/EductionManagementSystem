<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceReport1
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
        Me.cmbRegYear = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stdname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.present = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.absent = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbRegYear
        '
        Me.cmbRegYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegYear.FormattingEnabled = True
        Me.cmbRegYear.Location = New System.Drawing.Point(276, 41)
        Me.cmbRegYear.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(301, 28)
        Me.cmbRegYear.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Year"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.rno, Me.stdname, Me.present, Me.absent})
        Me.DataGridView1.Location = New System.Drawing.Point(120, 114)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(790, 579)
        Me.DataGridView1.TabIndex = 2
        '
        'srno
        '
        Me.srno.HeaderText = "No"
        Me.srno.Name = "srno"
        Me.srno.Width = 50
        '
        'rno
        '
        Me.rno.HeaderText = "Roll No"
        Me.rno.Name = "rno"
        '
        'stdname
        '
        Me.stdname.HeaderText = "Name"
        Me.stdname.Name = "stdname"
        Me.stdname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stdname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.stdname.Width = 300
        '
        'present
        '
        Me.present.HeaderText = "Present (%)"
        Me.present.Name = "present"
        '
        'absent
        '
        Me.absent.HeaderText = "Absent (%)"
        Me.absent.Name = "absent"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(379, 44)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 20)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Button1"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AttendanceReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1360, 746)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRegYear)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AttendanceReport1"
        Me.Text = "ReportForm1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stdname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents present As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents absent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
