<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentwise_Certificate_Filter
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblCertiType = New System.Windows.Forms.Label
        Me.cmbCertiType = New System.Windows.Forms.ComboBox
        Me.grbStudCrit = New System.Windows.Forms.GroupBox
        Me.cmbStudName = New System.Windows.Forms.ComboBox
        Me.lblStudName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbRegYear = New System.Windows.Forms.ComboBox
        Me.grdCertiDetails = New System.Windows.Forms.DataGridView
        Me.Sr_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CERTIFICATE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STUD_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REASON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TAKEN_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grbDateCrit = New System.Windows.Forms.GroupBox
        Me.dtpUptoDate = New System.Windows.Forms.DateTimePicker
        Me.lblUptodate = New System.Windows.Forms.Label
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.lblToDate = New System.Windows.Forms.Label
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.lblFromDate = New System.Windows.Forms.Label
        Me.rdbUptoDate = New System.Windows.Forms.RadioButton
        Me.rdbBetweenDate = New System.Windows.Forms.RadioButton
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.grbStudCrit.SuspendLayout()
        CType(Me.grdCertiDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDateCrit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCertiType
        '
        Me.lblCertiType.AutoSize = True
        Me.lblCertiType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCertiType.Location = New System.Drawing.Point(59, 15)
        Me.lblCertiType.Name = "lblCertiType"
        Me.lblCertiType.Size = New System.Drawing.Size(200, 26)
        Me.lblCertiType.TabIndex = 0
        Me.lblCertiType.Text = "Certificate Type ="
        '
        'cmbCertiType
        '
        Me.cmbCertiType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCertiType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCertiType.Location = New System.Drawing.Point(265, 15)
        Me.cmbCertiType.Name = "cmbCertiType"
        Me.cmbCertiType.Size = New System.Drawing.Size(388, 33)
        Me.cmbCertiType.TabIndex = 1
        '
        'grbStudCrit
        '
        Me.grbStudCrit.Controls.Add(Me.cmbStudName)
        Me.grbStudCrit.Controls.Add(Me.lblStudName)
        Me.grbStudCrit.Controls.Add(Me.Label1)
        Me.grbStudCrit.Controls.Add(Me.cmbRegYear)
        Me.grbStudCrit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbStudCrit.Location = New System.Drawing.Point(52, 52)
        Me.grbStudCrit.Name = "grbStudCrit"
        Me.grbStudCrit.Size = New System.Drawing.Size(986, 121)
        Me.grbStudCrit.TabIndex = 2
        Me.grbStudCrit.TabStop = False
        Me.grbStudCrit.Text = "Student Criteria"
        '
        'cmbStudName
        '
        Me.cmbStudName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStudName.Location = New System.Drawing.Point(306, 77)
        Me.cmbStudName.Name = "cmbStudName"
        Me.cmbStudName.Size = New System.Drawing.Size(414, 33)
        Me.cmbStudName.TabIndex = 3
        '
        'lblStudName
        '
        Me.lblStudName.AutoSize = True
        Me.lblStudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudName.Location = New System.Drawing.Point(56, 76)
        Me.lblStudName.Name = "lblStudName"
        Me.lblStudName.Size = New System.Drawing.Size(178, 26)
        Me.lblStudName.TabIndex = 2
        Me.lblStudName.Text = "Student Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Reg. Year :"
        '
        'cmbRegYear
        '
        Me.cmbRegYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegYear.Location = New System.Drawing.Point(306, 32)
        Me.cmbRegYear.Name = "cmbRegYear"
        Me.cmbRegYear.Size = New System.Drawing.Size(133, 33)
        Me.cmbRegYear.TabIndex = 1
        '
        'grdCertiDetails
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdCertiDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCertiDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdCertiDetails.ColumnHeadersHeight = 30
        Me.grdCertiDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr_No, Me.CERTIFICATE_NAME, Me.STUD_NAME, Me.REASON, Me.TAKEN_DATE})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCertiDetails.DefaultCellStyle = DataGridViewCellStyle16
        Me.grdCertiDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdCertiDetails.Location = New System.Drawing.Point(53, 308)
        Me.grdCertiDetails.Name = "grdCertiDetails"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCertiDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdCertiDetails.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.grdCertiDetails.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.grdCertiDetails.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdCertiDetails.Size = New System.Drawing.Size(1126, 324)
        Me.grdCertiDetails.TabIndex = 4
        '
        'Sr_No
        '
        Me.Sr_No.HeaderText = "SR. No"
        Me.Sr_No.Name = "Sr_No"
        '
        'CERTIFICATE_NAME
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CERTIFICATE_NAME.DefaultCellStyle = DataGridViewCellStyle12
        Me.CERTIFICATE_NAME.FillWeight = 200.0!
        Me.CERTIFICATE_NAME.HeaderText = "CERTIFICATE NAME"
        Me.CERTIFICATE_NAME.Name = "CERTIFICATE_NAME"
        Me.CERTIFICATE_NAME.Width = 270
        '
        'STUD_NAME
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STUD_NAME.DefaultCellStyle = DataGridViewCellStyle13
        Me.STUD_NAME.FillWeight = 200.0!
        Me.STUD_NAME.HeaderText = "STUDENT NAME"
        Me.STUD_NAME.Name = "STUD_NAME"
        Me.STUD_NAME.Width = 270
        '
        'REASON
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REASON.DefaultCellStyle = DataGridViewCellStyle14
        Me.REASON.FillWeight = 220.0!
        Me.REASON.HeaderText = "REASON"
        Me.REASON.Name = "REASON"
        Me.REASON.Width = 270
        '
        'TAKEN_DATE
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAKEN_DATE.DefaultCellStyle = DataGridViewCellStyle15
        Me.TAKEN_DATE.HeaderText = "DATE"
        Me.TAKEN_DATE.Name = "TAKEN_DATE"
        Me.TAKEN_DATE.Width = 150
        '
        'grbDateCrit
        '
        Me.grbDateCrit.Controls.Add(Me.dtpUptoDate)
        Me.grbDateCrit.Controls.Add(Me.lblUptodate)
        Me.grbDateCrit.Controls.Add(Me.dtpToDate)
        Me.grbDateCrit.Controls.Add(Me.lblToDate)
        Me.grbDateCrit.Controls.Add(Me.dtpFromDate)
        Me.grbDateCrit.Controls.Add(Me.lblFromDate)
        Me.grbDateCrit.Controls.Add(Me.rdbUptoDate)
        Me.grbDateCrit.Controls.Add(Me.rdbBetweenDate)
        Me.grbDateCrit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDateCrit.Location = New System.Drawing.Point(52, 177)
        Me.grbDateCrit.Name = "grbDateCrit"
        Me.grbDateCrit.Size = New System.Drawing.Size(986, 119)
        Me.grbDateCrit.TabIndex = 3
        Me.grbDateCrit.TabStop = False
        Me.grbDateCrit.Text = "Date Criteria"
        '
        'dtpUptoDate
        '
        Me.dtpUptoDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpUptoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpUptoDate.Location = New System.Drawing.Point(426, 76)
        Me.dtpUptoDate.Name = "dtpUptoDate"
        Me.dtpUptoDate.Size = New System.Drawing.Size(159, 32)
        Me.dtpUptoDate.TabIndex = 7
        '
        'lblUptodate
        '
        Me.lblUptodate.AutoSize = True
        Me.lblUptodate.Location = New System.Drawing.Point(269, 76)
        Me.lblUptodate.Name = "lblUptodate"
        Me.lblUptodate.Size = New System.Drawing.Size(150, 26)
        Me.lblUptodate.TabIndex = 6
        Me.lblUptodate.Text = "Select Date :"
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(742, 32)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(159, 32)
        Me.dtpToDate.TabIndex = 4
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(613, 32)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(109, 26)
        Me.lblToDate.TabIndex = 3
        Me.lblToDate.Text = "To Date :"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(426, 32)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(159, 32)
        Me.dtpFromDate.TabIndex = 2
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(270, 32)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(138, 26)
        Me.lblFromDate.TabIndex = 1
        Me.lblFromDate.Text = "From Date :"
        '
        'rdbUptoDate
        '
        Me.rdbUptoDate.AutoSize = True
        Me.rdbUptoDate.Location = New System.Drawing.Point(56, 72)
        Me.rdbUptoDate.Name = "rdbUptoDate"
        Me.rdbUptoDate.Size = New System.Drawing.Size(137, 30)
        Me.rdbUptoDate.TabIndex = 5
        Me.rdbUptoDate.TabStop = True
        Me.rdbUptoDate.Text = "Upto Date"
        Me.rdbUptoDate.UseVisualStyleBackColor = True
        '
        'rdbBetweenDate
        '
        Me.rdbBetweenDate.AutoSize = True
        Me.rdbBetweenDate.Location = New System.Drawing.Point(56, 32)
        Me.rdbBetweenDate.Name = "rdbBetweenDate"
        Me.rdbBetweenDate.Size = New System.Drawing.Size(179, 30)
        Me.rdbBetweenDate.TabIndex = 0
        Me.rdbBetweenDate.TabStop = True
        Me.rdbBetweenDate.Text = "Between Date"
        Me.rdbBetweenDate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(702, 639)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 34)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(875, 639)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 34)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1043, 639)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 34)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmStudentwise_Certificate_Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1366, 694)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grbDateCrit)
        Me.Controls.Add(Me.grdCertiDetails)
        Me.Controls.Add(Me.grbStudCrit)
        Me.Controls.Add(Me.lblCertiType)
        Me.Controls.Add(Me.cmbCertiType)
        Me.KeyPreview = True
        Me.Name = "frmStudentwise_Certificate_Filter"
        Me.Text = "Studentwise Certificate Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbStudCrit.ResumeLayout(False)
        Me.grbStudCrit.PerformLayout()
        CType(Me.grdCertiDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDateCrit.ResumeLayout(False)
        Me.grbDateCrit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCertiType As System.Windows.Forms.Label
    Friend WithEvents grbStudCrit As System.Windows.Forms.GroupBox
    Friend WithEvents grdCertiDetails As System.Windows.Forms.DataGridView
    Friend WithEvents grbDateCrit As System.Windows.Forms.GroupBox
    Friend WithEvents dtpUptoDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUptodate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents rdbUptoDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBetweenDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbRegYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStudName As System.Windows.Forms.ComboBox
    Friend WithEvents lblStudName As System.Windows.Forms.Label
    Friend WithEvents cmbCertiType As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Sr_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CERTIFICATE_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STUD_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REASON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAKEN_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
