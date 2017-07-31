<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventReport
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
        Me.EventCry = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'EventCry
        '
        Me.EventCry.ActiveViewIndex = -1
        Me.EventCry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EventCry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EventCry.Location = New System.Drawing.Point(0, 0)
        Me.EventCry.Name = "EventCry"
        Me.EventCry.SelectionFormula = ""
        Me.EventCry.Size = New System.Drawing.Size(1009, 411)
        Me.EventCry.TabIndex = 0
        Me.EventCry.ViewTimeSelectionFormula = ""
        '
        'EventReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 411)
        Me.Controls.Add(Me.EventCry)
        Me.Name = "EventReport"
        Me.Text = "EventReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EventCry As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
