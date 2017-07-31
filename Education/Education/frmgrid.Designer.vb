<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgrid
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.EVENT_TYPE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENT_PALCE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENT_ORG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENT_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EVENT_YEAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHOTOS = New System.Windows.Forms.DataGridViewButtonColumn
        Me.VIDEOS = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnreport = New System.Windows.Forms.Button
        Me.btndetail = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EVENT_TYPE_ID, Me.EVENT_ID, Me.EVENT_NAME, Me.EVENT_PALCE, Me.EVENT_ORG, Me.EVENT_DATE, Me.EVENT_YEAR, Me.PHOTOS, Me.VIDEOS})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1181, 277)
        Me.DataGridView1.TabIndex = 20
        '
        'EVENT_TYPE_ID
        '
        Me.EVENT_TYPE_ID.HeaderText = "EVENT_TYPE_ID"
        Me.EVENT_TYPE_ID.Name = "EVENT_TYPE_ID"
        '
        'EVENT_ID
        '
        Me.EVENT_ID.HeaderText = "EVENT_ID"
        Me.EVENT_ID.Name = "EVENT_ID"
        '
        'EVENT_NAME
        '
        Me.EVENT_NAME.HeaderText = "EVENT_NAME"
        Me.EVENT_NAME.Name = "EVENT_NAME"
        '
        'EVENT_PALCE
        '
        Me.EVENT_PALCE.HeaderText = "EVENT_PALCE"
        Me.EVENT_PALCE.Name = "EVENT_PALCE"
        '
        'EVENT_ORG
        '
        Me.EVENT_ORG.HeaderText = "EVENT_ORG"
        Me.EVENT_ORG.Name = "EVENT_ORG"
        '
        'EVENT_DATE
        '
        Me.EVENT_DATE.HeaderText = "EVENT_DATE"
        Me.EVENT_DATE.Name = "EVENT_DATE"
        '
        'EVENT_YEAR
        '
        Me.EVENT_YEAR.HeaderText = "EVENT_YEAR"
        Me.EVENT_YEAR.Name = "EVENT_YEAR"
        '
        'PHOTOS
        '
        Me.PHOTOS.HeaderText = "PHOTOS"
        Me.PHOTOS.Name = "PHOTOS"
        Me.PHOTOS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PHOTOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PHOTOS.Text = "Clicl Here"
        Me.PHOTOS.UseColumnTextForButtonValue = True
        '
        'VIDEOS
        '
        Me.VIDEOS.HeaderText = "VIDEOS"
        Me.VIDEOS.Name = "VIDEOS"
        Me.VIDEOS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VIDEOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.VIDEOS.Text = "Click Here"
        Me.VIDEOS.UseColumnTextForButtonValue = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(174, 330)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(154, 23)
        Me.btnreport.TabIndex = 21
        Me.btnreport.Text = "Report Of Total Event"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btndetail
        '
        Me.btndetail.Location = New System.Drawing.Point(367, 330)
        Me.btndetail.Name = "btndetail"
        Me.btndetail.Size = New System.Drawing.Size(154, 23)
        Me.btndetail.TabIndex = 22
        Me.btndetail.Text = "Report Of  Events Detail"
        Me.btndetail.UseVisualStyleBackColor = True
        '
        'frmgrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 476)
        Me.Controls.Add(Me.btndetail)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmgrid"
        Me.Text = "Show Events"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents EVENT_TYPE_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENT_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENT_PALCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENT_ORG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENT_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENT_YEAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHOTOS As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents VIDEOS As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents btndetail As System.Windows.Forms.Button
End Class
