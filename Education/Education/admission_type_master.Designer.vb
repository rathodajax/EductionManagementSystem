<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admission_type_master
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
        Me.lblAdmsnType = New System.Windows.Forms.Label
        Me.lblAdmsnDetail = New System.Windows.Forms.Label
        Me.lblRemark = New System.Windows.Forms.Label
        Me.lblSelectAdmsnType = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblAdmsnMaster = New System.Windows.Forms.Label
        Me.txtadmsnDetail = New System.Windows.Forms.TextBox
        Me.txtAdmsnType = New System.Windows.Forms.TextBox
        Me.txtAdmsnRemark = New System.Windows.Forms.TextBox
        Me.cmbAdmsnSelectType = New System.Windows.Forms.ComboBox
        Me.btnAdmsnSave = New System.Windows.Forms.Button
        Me.btnAdmsnClear = New System.Windows.Forms.Button
        Me.btnAdmsnCancle = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAdmsnType
        '
        Me.lblAdmsnType.AutoSize = True
        Me.lblAdmsnType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmsnType.Location = New System.Drawing.Point(72, 110)
        Me.lblAdmsnType.Name = "lblAdmsnType"
        Me.lblAdmsnType.Size = New System.Drawing.Size(149, 20)
        Me.lblAdmsnType.TabIndex = 0
        Me.lblAdmsnType.Text = "Admission Type : "
        '
        'lblAdmsnDetail
        '
        Me.lblAdmsnDetail.AutoSize = True
        Me.lblAdmsnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmsnDetail.Location = New System.Drawing.Point(72, 202)
        Me.lblAdmsnDetail.Name = "lblAdmsnDetail"
        Me.lblAdmsnDetail.Size = New System.Drawing.Size(66, 20)
        Me.lblAdmsnDetail.TabIndex = 1
        Me.lblAdmsnDetail.Text = "Detail :"
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark.Location = New System.Drawing.Point(72, 354)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(86, 20)
        Me.lblRemark.TabIndex = 2
        Me.lblRemark.Text = "Remark : "
        '
        'lblSelectAdmsnType
        '
        Me.lblSelectAdmsnType.AutoSize = True
        Me.lblSelectAdmsnType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectAdmsnType.Location = New System.Drawing.Point(706, 213)
        Me.lblSelectAdmsnType.Name = "lblSelectAdmsnType"
        Me.lblSelectAdmsnType.Size = New System.Drawing.Size(118, 20)
        Me.lblSelectAdmsnType.TabIndex = 3
        Me.lblSelectAdmsnType.Text = "Select Type : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(706, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current User : "
        '
        'lblAdmsnMaster
        '
        Me.lblAdmsnMaster.AutoSize = True
        Me.lblAdmsnMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmsnMaster.Location = New System.Drawing.Point(464, 21)
        Me.lblAdmsnMaster.Name = "lblAdmsnMaster"
        Me.lblAdmsnMaster.Size = New System.Drawing.Size(386, 31)
        Me.lblAdmsnMaster.TabIndex = 5
        Me.lblAdmsnMaster.Text = "ADMISSION TYPE MASTER"
        '
        'txtadmsnDetail
        '
        Me.txtadmsnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadmsnDetail.Location = New System.Drawing.Point(257, 171)
        Me.txtadmsnDetail.Multiline = True
        Me.txtadmsnDetail.Name = "txtadmsnDetail"
        Me.txtadmsnDetail.Size = New System.Drawing.Size(339, 110)
        Me.txtadmsnDetail.TabIndex = 2
        '
        'txtAdmsnType
        '
        Me.txtAdmsnType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmsnType.Location = New System.Drawing.Point(257, 110)
        Me.txtAdmsnType.Name = "txtAdmsnType"
        Me.txtAdmsnType.Size = New System.Drawing.Size(197, 24)
        Me.txtAdmsnType.TabIndex = 1
        '
        'txtAdmsnRemark
        '
        Me.txtAdmsnRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmsnRemark.Location = New System.Drawing.Point(257, 321)
        Me.txtAdmsnRemark.Multiline = True
        Me.txtAdmsnRemark.Name = "txtAdmsnRemark"
        Me.txtAdmsnRemark.Size = New System.Drawing.Size(339, 118)
        Me.txtAdmsnRemark.TabIndex = 3
        '
        'cmbAdmsnSelectType
        '
        Me.cmbAdmsnSelectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAdmsnSelectType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAdmsnSelectType.FormattingEnabled = True
        Me.cmbAdmsnSelectType.Location = New System.Drawing.Point(871, 213)
        Me.cmbAdmsnSelectType.Name = "cmbAdmsnSelectType"
        Me.cmbAdmsnSelectType.Size = New System.Drawing.Size(202, 26)
        Me.cmbAdmsnSelectType.TabIndex = 4
        '
        'btnAdmsnSave
        '
        Me.btnAdmsnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmsnSave.Location = New System.Drawing.Point(305, 462)
        Me.btnAdmsnSave.Name = "btnAdmsnSave"
        Me.btnAdmsnSave.Size = New System.Drawing.Size(83, 37)
        Me.btnAdmsnSave.TabIndex = 6
        Me.btnAdmsnSave.Text = "Save"
        Me.btnAdmsnSave.UseVisualStyleBackColor = True
        '
        'btnAdmsnClear
        '
        Me.btnAdmsnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmsnClear.Location = New System.Drawing.Point(488, 462)
        Me.btnAdmsnClear.Name = "btnAdmsnClear"
        Me.btnAdmsnClear.Size = New System.Drawing.Size(83, 37)
        Me.btnAdmsnClear.TabIndex = 7
        Me.btnAdmsnClear.Text = "Clear"
        Me.btnAdmsnClear.UseVisualStyleBackColor = True
        '
        'btnAdmsnCancle
        '
        Me.btnAdmsnCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdmsnCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmsnCancle.Location = New System.Drawing.Point(676, 462)
        Me.btnAdmsnCancle.Name = "btnAdmsnCancle"
        Me.btnAdmsnCancle.Size = New System.Drawing.Size(83, 37)
        Me.btnAdmsnCancle.TabIndex = 8
        Me.btnAdmsnCancle.Text = "Cancle"
        Me.btnAdmsnCancle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(710, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 105)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INSTRUCTIONS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DROP DOWN LIST[F4]     SAVE[F3]    EXIT FOR FORM[ESC]"
        '
        'admission_type_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAdmsnCancle
        Me.ClientSize = New System.Drawing.Size(1364, 746)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdmsnCancle)
        Me.Controls.Add(Me.btnAdmsnClear)
        Me.Controls.Add(Me.btnAdmsnSave)
        Me.Controls.Add(Me.cmbAdmsnSelectType)
        Me.Controls.Add(Me.txtAdmsnRemark)
        Me.Controls.Add(Me.txtAdmsnType)
        Me.Controls.Add(Me.txtadmsnDetail)
        Me.Controls.Add(Me.lblAdmsnMaster)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSelectAdmsnType)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.lblAdmsnDetail)
        Me.Controls.Add(Me.lblAdmsnType)
        Me.KeyPreview = True
        Me.Name = "admission_type_master"
        Me.Text = "admission_type_master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAdmsnType As System.Windows.Forms.Label
    Friend WithEvents lblAdmsnDetail As System.Windows.Forms.Label
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents lblSelectAdmsnType As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAdmsnMaster As System.Windows.Forms.Label
    Friend WithEvents txtadmsnDetail As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmsnType As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmsnRemark As System.Windows.Forms.TextBox
    Friend WithEvents cmbAdmsnSelectType As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdmsnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdmsnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdmsnCancle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
