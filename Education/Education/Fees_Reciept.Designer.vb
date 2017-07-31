<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees_Reciept
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
        Me.Reciept_Viewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Report_Print_Receipt1 = New Education.Report_Print_Receipt
        Me.CrystalReport12 = New Education.Report_Print_Receipt
        Me.CrystalReport11 = New Education.Report_Print_Receipt
        Me.SuspendLayout()
        '
        'Reciept_Viewer
        '
        Me.Reciept_Viewer.ActiveViewIndex = -1
        Me.Reciept_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reciept_Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Reciept_Viewer.Location = New System.Drawing.Point(0, 0)
        Me.Reciept_Viewer.Name = "Reciept_Viewer"
        Me.Reciept_Viewer.Size = New System.Drawing.Size(984, 662)
        Me.Reciept_Viewer.TabIndex = 1
        '
        'Fees_Reciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.Reciept_Viewer)
        Me.Name = "Fees_Reciept"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Reciept_Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As Education.Report_Print_Receipt
    Friend WithEvents CrystalReport12 As Education.Report_Print_Receipt
    Friend WithEvents Report_Print_Receipt1 As Education.Report_Print_Receipt
End Class
