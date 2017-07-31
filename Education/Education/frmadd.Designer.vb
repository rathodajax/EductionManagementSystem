<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadd
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmadd))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtplace = New System.Windows.Forms.TextBox
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.cmbevent = New System.Windows.Forms.ComboBox
        Me.grp_e_info = New System.Windows.Forms.GroupBox
        Me.grpvideo = New System.Windows.Forms.GroupBox
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.save_video = New System.Windows.Forms.Button
        Me.select_video = New System.Windows.Forms.Button
        Me.lstvpath = New System.Windows.Forms.ListBox
        Me.cmborg = New System.Windows.Forms.ComboBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.e_save = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.grpphoto = New System.Windows.Forms.GroupBox
        Me.lstpath = New System.Windows.Forms.ListBox
        Me.picevent = New System.Windows.Forms.PictureBox
        Me.photo_save = New System.Windows.Forms.Button
        Me.select_photo = New System.Windows.Forms.Button
        Me.grp_e_info.SuspendLayout()
        Me.grpvideo.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpphoto.SuspendLayout()
        CType(Me.picevent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(100, 100)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtplace
        '
        Me.txtplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplace.Location = New System.Drawing.Point(203, 167)
        Me.txtplace.Multiline = True
        Me.txtplace.Name = "txtplace"
        Me.txtplace.Size = New System.Drawing.Size(185, 32)
        Me.txtplace.TabIndex = 22
        '
        'dtp
        '
        Me.dtp.CustomFormat = "dd-MM-yyyy"
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(203, 73)
        Me.dtp.MinimumSize = New System.Drawing.Size(4, 10)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(185, 30)
        Me.dtp.TabIndex = 18
        Me.dtp.Value = New Date(2017, 3, 25, 0, 0, 0, 0)
        '
        'cmbevent
        '
        Me.cmbevent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbevent.FormattingEnabled = True
        Me.cmbevent.Location = New System.Drawing.Point(203, 26)
        Me.cmbevent.Name = "cmbevent"
        Me.cmbevent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbevent.Size = New System.Drawing.Size(185, 33)
        Me.cmbevent.TabIndex = 16
        '
        'grp_e_info
        '
        Me.grp_e_info.Controls.Add(Me.grpvideo)
        Me.grp_e_info.Controls.Add(Me.cmborg)
        Me.grp_e_info.Controls.Add(Me.txtplace)
        Me.grp_e_info.Controls.Add(Me.CheckBox2)
        Me.grp_e_info.Controls.Add(Me.CheckBox1)
        Me.grp_e_info.Controls.Add(Me.e_save)
        Me.grp_e_info.Controls.Add(Me.dtp)
        Me.grp_e_info.Controls.Add(Me.Label5)
        Me.grp_e_info.Controls.Add(Me.Label6)
        Me.grp_e_info.Controls.Add(Me.cmbevent)
        Me.grp_e_info.Controls.Add(Me.Label7)
        Me.grp_e_info.Controls.Add(Me.Label8)
        Me.grp_e_info.Controls.Add(Me.grpphoto)
        Me.grp_e_info.Location = New System.Drawing.Point(12, 22)
        Me.grp_e_info.Name = "grp_e_info"
        Me.grp_e_info.Size = New System.Drawing.Size(1312, 586)
        Me.grp_e_info.TabIndex = 21
        Me.grp_e_info.TabStop = False
        Me.grp_e_info.Text = "Event Information"
        '
        'grpvideo
        '
        Me.grpvideo.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.grpvideo.Controls.Add(Me.save_video)
        Me.grpvideo.Controls.Add(Me.select_video)
        Me.grpvideo.Controls.Add(Me.lstvpath)
        Me.grpvideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpvideo.Location = New System.Drawing.Point(796, 19)
        Me.grpvideo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpvideo.Name = "grpvideo"
        Me.grpvideo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpvideo.Size = New System.Drawing.Size(493, 353)
        Me.grpvideo.TabIndex = 24
        Me.grpvideo.TabStop = False
        Me.grpvideo.Text = "Videos"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(23, 24)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(245, 201)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        '
        'save_video
        '
        Me.save_video.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_video.Location = New System.Drawing.Point(286, 268)
        Me.save_video.Name = "save_video"
        Me.save_video.Size = New System.Drawing.Size(165, 39)
        Me.save_video.TabIndex = 3
        Me.save_video.Text = "Save Video"
        Me.save_video.UseVisualStyleBackColor = True
        '
        'select_video
        '
        Me.select_video.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_video.Location = New System.Drawing.Point(23, 268)
        Me.select_video.Margin = New System.Windows.Forms.Padding(4)
        Me.select_video.Name = "select_video"
        Me.select_video.Size = New System.Drawing.Size(165, 40)
        Me.select_video.TabIndex = 2
        Me.select_video.Text = "Select Video"
        Me.select_video.UseVisualStyleBackColor = True
        '
        'lstvpath
        '
        Me.lstvpath.FormattingEnabled = True
        Me.lstvpath.Location = New System.Drawing.Point(286, 24)
        Me.lstvpath.Margin = New System.Windows.Forms.Padding(4)
        Me.lstvpath.Name = "lstvpath"
        Me.lstvpath.Size = New System.Drawing.Size(199, 199)
        Me.lstvpath.TabIndex = 1
        '
        'cmborg
        '
        Me.cmborg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmborg.FormattingEnabled = True
        Me.cmborg.Location = New System.Drawing.Point(203, 116)
        Me.cmborg.Name = "cmborg"
        Me.cmborg.Size = New System.Drawing.Size(185, 33)
        Me.cmborg.TabIndex = 23
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(27, 278)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(234, 17)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Select If You Want To Add Videos Of Event"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(27, 250)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(236, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Select If You Want To Add Images Of Event"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'e_save
        '
        Me.e_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_save.Location = New System.Drawing.Point(284, 253)
        Me.e_save.Name = "e_save"
        Me.e_save.Size = New System.Drawing.Size(101, 42)
        Me.e_save.TabIndex = 10
        Me.e_save.Text = "Save"
        Me.e_save.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Place Of Event"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Organised By"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Select Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Event Name"
        '
        'grpphoto
        '
        Me.grpphoto.Controls.Add(Me.lstpath)
        Me.grpphoto.Controls.Add(Me.picevent)
        Me.grpphoto.Controls.Add(Me.photo_save)
        Me.grpphoto.Controls.Add(Me.select_photo)
        Me.grpphoto.Location = New System.Drawing.Point(403, 19)
        Me.grpphoto.Name = "grpphoto"
        Me.grpphoto.Size = New System.Drawing.Size(386, 353)
        Me.grpphoto.TabIndex = 1
        Me.grpphoto.TabStop = False
        Me.grpphoto.Text = "Photos"
        '
        'lstpath
        '
        Me.lstpath.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstpath.ItemHeight = 19
        Me.lstpath.Location = New System.Drawing.Point(204, 24)
        Me.lstpath.Name = "lstpath"
        Me.lstpath.Size = New System.Drawing.Size(162, 232)
        Me.lstpath.TabIndex = 14
        '
        'picevent
        '
        Me.picevent.Location = New System.Drawing.Point(18, 24)
        Me.picevent.Name = "picevent"
        Me.picevent.Size = New System.Drawing.Size(158, 224)
        Me.picevent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picevent.TabIndex = 13
        Me.picevent.TabStop = False
        '
        'photo_save
        '
        Me.photo_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photo_save.Location = New System.Drawing.Point(204, 266)
        Me.photo_save.Name = "photo_save"
        Me.photo_save.Size = New System.Drawing.Size(162, 42)
        Me.photo_save.TabIndex = 11
        Me.photo_save.Text = "Save"
        Me.photo_save.UseVisualStyleBackColor = True
        '
        'select_photo
        '
        Me.select_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_photo.Location = New System.Drawing.Point(18, 266)
        Me.select_photo.Name = "select_photo"
        Me.select_photo.Size = New System.Drawing.Size(171, 42)
        Me.select_photo.TabIndex = 11
        Me.select_photo.Text = "Select Photo"
        Me.select_photo.UseVisualStyleBackColor = True
        '
        'frmadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 620)
        Me.Controls.Add(Me.grp_e_info)
        Me.Name = "frmadd"
        Me.Text = "ADD EVENT"
        Me.grp_e_info.ResumeLayout(False)
        Me.grp_e_info.PerformLayout()
        Me.grpvideo.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpphoto.ResumeLayout(False)
        CType(Me.picevent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtplace As System.Windows.Forms.TextBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbevent As System.Windows.Forms.ComboBox
    Friend WithEvents grp_e_info As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents e_save As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grpphoto As System.Windows.Forms.GroupBox
    Friend WithEvents photo_save As System.Windows.Forms.Button
    Friend WithEvents select_photo As System.Windows.Forms.Button
    Friend WithEvents picevent As System.Windows.Forms.PictureBox
    Friend WithEvents cmborg As System.Windows.Forms.ComboBox
    Friend WithEvents lstpath As System.Windows.Forms.ListBox
    Friend WithEvents grpvideo As System.Windows.Forms.GroupBox
    Friend WithEvents save_video As System.Windows.Forms.Button
    Friend WithEvents select_video As System.Windows.Forms.Button
    Friend WithEvents lstvpath As System.Windows.Forms.ListBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer


End Class
