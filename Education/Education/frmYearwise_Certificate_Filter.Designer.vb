<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearwise_Certificate_Filter
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblYear = New System.Windows.Forms.Label
        Me.dtpUptoDate = New System.Windows.Forms.DateTimePicker
        Me.grbDateCrit = New System.Windows.Forms.GroupBox
        Me.lblUptodate = New System.Windows.Forms.Label
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.lblToDate = New System.Windows.Forms.Label
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.lblFromDate = New System.Windows.Forms.Label
        Me.rdbUptoDate = New System.Windows.Forms.RadioButton
        Me.rdbBetweenDate = New System.Windows.Forms.RadioButton
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.lblCertiType = New System.Windows.Forms.Label
        Me.cmbCertiType = New System.Windows.Forms.ComboBox
        Me.grdCertiDetails = New System.Windows.Forms.DataGridView
        Me.Sr_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CERTIFICATE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STUD_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REASON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TAKEN_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.grbDateCrit.SuspendLayout()
        CType(Me.grdCertiDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(695, 25)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(84, 26)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year ="
        '
        'dtpUptoDate
        '
        Me.dtpUptoDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpUptoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpUptoDate.Location = New System.Drawing.Point(426, 85)
        Me.dtpUptoDate.Name = "dtpUptoDate"
        Me.dtpUptoDate.Size = New System.Drawing.Size(159, 32)
        Me.dtpUptoDate.TabIndex = 7
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
        Me.grbDateCrit.Location = New System.Drawing.Point(51, 69)
        Me.grbDateCrit.Name = "grbDateCrit"
        Me.grbDateCrit.Size = New System.Drawing.Size(986, 132)
        Me.grbDateCrit.TabIndex = 4
        Me.grbDateCrit.TabStop = False
        Me.grbDateCrit.Text = "Date Criteria"
        '
        'lblUptodate
        '
        Me.lblUptodate.AutoSize = True
        Me.lblUptodate.Location = New System.Drawing.Point(270, 85)
        Me.lblUptodate.Name = "lblUptodate"
        Me.lblUptodate.Size = New System.Drawing.Size(150, 26)
        Me.lblUptodate.TabIndex = 6
        Me.lblUptodate.Text = "Select Date :"
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(742, 36)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(159, 32)
        Me.dtpToDate.TabIndex = 4
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(613, 36)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(109, 26)
        Me.lblToDate.TabIndex = 3
        Me.lblToDate.Text = "To Date :"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(426, 36)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(159, 32)
        Me.dtpFromDate.TabIndex = 2
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(270, 36)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(138, 26)
        Me.lblFromDate.TabIndex = 1
        Me.lblFromDate.Text = "From Date :"
        '
        'rdbUptoDate
        '
        Me.rdbUptoDate.AutoSize = True
        Me.rdbUptoDate.Location = New System.Drawing.Point(56, 81)
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
        Me.rdbBetweenDate.Location = New System.Drawing.Point(56, 36)
        Me.rdbBetweenDate.Name = "rdbBetweenDate"
        Me.rdbBetweenDate.Size = New System.Drawing.Size(179, 30)
        Me.rdbBetweenDate.TabIndex = 0
        Me.rdbBetweenDate.TabStop = True
        Me.rdbBetweenDate.Text = "Between Date"
        Me.rdbBetweenDate.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.Location = New System.Drawing.Point(785, 22)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(133, 33)
        Me.cmbYear.TabIndex = 3
        '
        'lblCertiType
        '
        Me.lblCertiType.AutoSize = True
        Me.lblCertiType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCertiType.Location = New System.Drawing.Point(57, 22)
        Me.lblCertiType.Name = "lblCertiType"
        Me.lblCertiType.Size = New System.Drawing.Size(200, 26)
        Me.lblCertiType.TabIndex = 0
        Me.lblCertiType.Text = "Certificate Type ="
        '
        'cmbCertiType
        '
        Me.cmbCertiType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCertiType.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCertiType.Location = New System.Drawing.Point(263, 22)
        Me.cmbCertiType.Name = "cmbCertiType"
        Me.cmbCertiType.Size = New System.Drawing.Size(388, 33)
        Me.cmbCertiType.TabIndex = 1
        '
        'grdCertiDetails
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdCertiDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCertiDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdCertiDetails.ColumnHeadersHeight = 30
        Me.grdCertiDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sr_no, Me.CERTIFICATE_NAME, Me.STUD_NAME, Me.REASON, Me.TAKEN_DATE})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCertiDetails.DefaultCellStyle = DataGridViewCellStyle7
        Me.grdCertiDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdCertiDetails.Location = New System.Drawing.Point(51, 219)
        Me.grdCertiDetails.Name = "grdCertiDetails"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCertiDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdCertiDetails.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grdCertiDetails.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        Me.grdCertiDetails.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdCertiDetails.Size = New System.Drawing.Size(1126, 406)
        Me.grdCertiDetails.TabIndex = 5
        '
        'Sr_no
        '
        Me.Sr_no.HeaderText = "SR. No"
        Me.Sr_no.Name = "Sr_no"
        '
        'CERTIFICATE_NAME
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CERTIFICATE_NAME.DefaultCellStyle = DataGridViewCellStyle3
        Me.CERTIFICATE_NAME.FillWeight = 200.0!
        Me.CERTIFICATE_NAME.HeaderText = "CERTIFICATE NAME"
        Me.CERTIFICATE_NAME.Name = "CERTIFICATE_NAME"
        Me.CERTIFICATE_NAME.Width = 270
        '
        'STUD_NAME
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STUD_NAME.DefaultCellStyle = DataGridViewCellStyle4
        Me.STUD_NAME.FillWeight = 200.0!
        Me.STUD_NAME.HeaderText = "STUDENT NAME"
        Me.STUD_NAME.Name = "STUD_NAME"
        Me.STUD_NAME.Width = 270
        '
        'REASON
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REASON.DefaultCellStyle = DataGridViewCellStyle5
        Me.REASON.FillWeight = 220.0!
        Me.REASON.HeaderText = "REASON"
        Me.REASON.Name = "REASON"
        Me.REASON.Width = 270
        '
        'TAKEN_DATE
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAKEN_DATE.DefaultCellStyle = DataGridViewCellStyle6
        Me.TAKEN_DATE.HeaderText = "DATE"
        Me.TAKEN_DATE.Name = "TAKEN_DATE"
        Me.TAKEN_DATE.Width = 150
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(873, 635)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 34)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1041, 635)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 34)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(700, 635)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(136, 34)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmYearwise_Certificate_Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1366, 714)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.grbDateCrit)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lblCertiType)
        Me.Controls.Add(Me.cmbCertiType)
        Me.Controls.Add(Me.grdCertiDetails)
        Me.KeyPreview = True
        Me.Name = "frmYearwise_Certificate_Filter"
        Me.Text = "Yearwise Certificate Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbDateCrit.ResumeLayout(False)
        Me.grbDateCrit.PerformLayout()
        CType(Me.grdCertiDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents dtpUptoDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbDateCrit As System.Windows.Forms.GroupBox
    Friend WithEvents lblUptodate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents rdbUptoDate As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBetweenDate As System.Windows.Forms.RadioButton
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblCertiType As System.Windows.Forms.Label
    Friend WithEvents cmbCertiType As System.Windows.Forms.ComboBox
    Friend WithEvents grdCertiDetails As System.Windows.Forms.DataGridView
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Sr_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CERTIFICATE_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STUD_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REASON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAKEN_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
