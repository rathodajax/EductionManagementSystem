<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Report
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
        Me.DetailReport = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'DetailReport
        '
        Me.DetailReport.ActiveViewIndex = -1
        Me.DetailReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DetailReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailReport.Location = New System.Drawing.Point(0, 0)
        Me.DetailReport.Name = "DetailReport"
        Me.DetailReport.SelectionFormula = ""
        Me.DetailReport.Size = New System.Drawing.Size(1210, 465)
        Me.DetailReport.TabIndex = 0
        Me.DetailReport.ViewTimeSelectionFormula = ""
        '
        'Detail_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 465)
        Me.Controls.Add(Me.DetailReport)
        Me.Name = "Detail_Report"
        Me.Text = "Detail_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DetailReport As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
