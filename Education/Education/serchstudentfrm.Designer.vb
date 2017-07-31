<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serchstudentfrm
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
        Me.searchstudviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'searchstudviewer
        '
        Me.searchstudviewer.ActiveViewIndex = -1
        Me.searchstudviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchstudviewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchstudviewer.Location = New System.Drawing.Point(0, 0)
        Me.searchstudviewer.Name = "searchstudviewer"
        Me.searchstudviewer.SelectionFormula = ""
        Me.searchstudviewer.Size = New System.Drawing.Size(1116, 481)
        Me.searchstudviewer.TabIndex = 0
        Me.searchstudviewer.ViewTimeSelectionFormula = ""
        '
        'serchstudentfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 481)
        Me.Controls.Add(Me.searchstudviewer)
        Me.Name = "serchstudentfrm"
        Me.Text = "serchstudent"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchstudviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
