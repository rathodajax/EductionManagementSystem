<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReports
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
        Me.Report_Viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Report_Viewer
        '
        Me.Report_Viewer.ActiveViewIndex = -1
        Me.Report_Viewer.AutoSize = True
        Me.Report_Viewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Report_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Report_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Report_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.Report_Viewer.Name = "Report_Viewer"
        Me.Report_Viewer.SelectionFormula = ""
        Me.Report_Viewer.Size = New System.Drawing.Size(810, 519)
        Me.Report_Viewer.TabIndex = 0
        Me.Report_Viewer.ViewTimeSelectionFormula = ""
        '
        'ViewReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 519)
        Me.Controls.Add(Me.Report_Viewer)
        Me.KeyPreview = True
        Me.Name = "ViewReports"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Report_Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
