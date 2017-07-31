<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentReq
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbpcno = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtfaultdesc = New System.Windows.Forms.TextBox
        Me.cmbfaultname = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbdevicename = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnrefresh = New System.Windows.Forms.Button
        Me.btnsend = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbstudname = New System.Windows.Forms.ComboBox
        Me.cmbregyear = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvsentrequests = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvsentrequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 60)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(386, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 36)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Device Fault Request"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbpcno)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtfaultdesc)
        Me.GroupBox3.Controls.Add(Me.cmbfaultname)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbdevicename)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox3.Location = New System.Drawing.Point(15, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(505, 239)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Send Request"
        '
        'cmbpcno
        '
        Me.cmbpcno.DisplayMember = "PC_NO"
        Me.cmbpcno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpcno.FormattingEnabled = True
        Me.cmbpcno.Location = New System.Drawing.Point(212, 37)
        Me.cmbpcno.Name = "cmbpcno"
        Me.cmbpcno.Size = New System.Drawing.Size(270, 28)
        Me.cmbpcno.TabIndex = 4
        Me.cmbpcno.ValueMember = "PC_NO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Select PC:"
        '
        'txtfaultdesc
        '
        Me.txtfaultdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfaultdesc.Location = New System.Drawing.Point(212, 145)
        Me.txtfaultdesc.Multiline = True
        Me.txtfaultdesc.Name = "txtfaultdesc"
        Me.txtfaultdesc.Size = New System.Drawing.Size(270, 68)
        Me.txtfaultdesc.TabIndex = 7
        '
        'cmbfaultname
        '
        Me.cmbfaultname.DisplayMember = "FAULT_DESC"
        Me.cmbfaultname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfaultname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfaultname.FormattingEnabled = True
        Me.cmbfaultname.Location = New System.Drawing.Point(212, 105)
        Me.cmbfaultname.Name = "cmbfaultname"
        Me.cmbfaultname.Size = New System.Drawing.Size(270, 28)
        Me.cmbfaultname.TabIndex = 6
        Me.cmbfaultname.ValueMember = "FAULT_DESC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Select Fault:"
        '
        'cmbdevicename
        '
        Me.cmbdevicename.DisplayMember = "DEVICE_NAME"
        Me.cmbdevicename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdevicename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdevicename.FormattingEnabled = True
        Me.cmbdevicename.Location = New System.Drawing.Point(212, 71)
        Me.cmbdevicename.Name = "cmbdevicename"
        Me.cmbdevicename.Size = New System.Drawing.Size(270, 28)
        Me.cmbdevicename.TabIndex = 5
        Me.cmbdevicename.ValueMember = "DEVICE_NAME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Select Device:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Fault Description:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnexit)
        Me.Panel2.Controls.Add(Me.btnrefresh)
        Me.Panel2.Controls.Add(Me.btnsend)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(0, 475)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1204, 60)
        Me.Panel2.TabIndex = 0
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.Control
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnexit.Location = New System.Drawing.Point(592, 15)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 30)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnrefresh.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnrefresh.Location = New System.Drawing.Point(492, 15)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 30)
        Me.btnrefresh.TabIndex = 1
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnsend
        '
        Me.btnsend.BackColor = System.Drawing.SystemColors.Control
        Me.btnsend.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsend.Location = New System.Drawing.Point(392, 15)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(75, 30)
        Me.btnsend.TabIndex = 8
        Me.btnsend.Text = "Send"
        Me.btnsend.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbstudname)
        Me.GroupBox2.Controls.Add(Me.cmbregyear)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1174, 108)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Student"
        '
        'cmbstudname
        '
        Me.cmbstudname.DisplayMember = "STU_NAME"
        Me.cmbstudname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstudname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstudname.FormattingEnabled = True
        Me.cmbstudname.Location = New System.Drawing.Point(212, 66)
        Me.cmbstudname.Name = "cmbstudname"
        Me.cmbstudname.Size = New System.Drawing.Size(311, 28)
        Me.cmbstudname.TabIndex = 3
        Me.cmbstudname.ValueMember = "STU_NAME"
        '
        'cmbregyear
        '
        Me.cmbregyear.DisplayMember = "REG_YEAR"
        Me.cmbregyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbregyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbregyear.FormattingEnabled = True
        Me.cmbregyear.Location = New System.Drawing.Point(212, 22)
        Me.cmbregyear.Name = "cmbregyear"
        Me.cmbregyear.Size = New System.Drawing.Size(150, 28)
        Me.cmbregyear.TabIndex = 1
        Me.cmbregyear.ValueMember = "REG_YEAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Student Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reg. Year:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvsentrequests)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(526, 207)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(662, 239)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sent Requests"
        '
        'dgvsentrequests
        '
        Me.dgvsentrequests.AllowUserToAddRows = False
        Me.dgvsentrequests.AllowUserToDeleteRows = False
        Me.dgvsentrequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsentrequests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvsentrequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsentrequests.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvsentrequests.Location = New System.Drawing.Point(3, 22)
        Me.dgvsentrequests.Name = "dgvsentrequests"
        Me.dgvsentrequests.ReadOnly = True
        Me.dgvsentrequests.Size = New System.Drawing.Size(656, 214)
        Me.dgvsentrequests.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "REQ_ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "REQ_DATE"
        Me.Column2.HeaderText = "REQ_DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "STU_NAME"
        Me.Column3.HeaderText = "STUDENT_NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "PC_NO"
        Me.Column4.HeaderText = "PC_NO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "REQ_DESC"
        Me.Column5.HeaderText = "REQ_DESC"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "STATUS_NAME"
        Me.Column6.HeaderText = "REQ_STATUS"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frmStudentReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1207, 535)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStudentReq"
        Me.Text = "Student Registraion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvsentrequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btnsend As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbdevicename As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbfaultname As System.Windows.Forms.ComboBox
    Friend WithEvents dgvsentrequests As System.Windows.Forms.DataGridView
    Friend WithEvents txtfaultdesc As System.Windows.Forms.TextBox


    Friend WithEvents cmbpcno As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbregyear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstudname As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
