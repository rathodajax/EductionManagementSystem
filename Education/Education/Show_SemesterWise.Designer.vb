<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_SemesterWise
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
        Me.Crystal_SemesterWise = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Report_Semesterwise1 = New Education.Report_Semesterwise
        Me.SuspendLayout()
        '
        'Crystal_SemesterWise
        '
        Me.Crystal_SemesterWise.ActiveViewIndex = -1
        Me.Crystal_SemesterWise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crystal_SemesterWise.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crystal_SemesterWise.Location = New System.Drawing.Point(0, 0)
        Me.Crystal_SemesterWise.Name = "Crystal_SemesterWise"
        Me.Crystal_SemesterWise.SelectionFormula = ""
        Me.Crystal_SemesterWise.Size = New System.Drawing.Size(473, 403)
        Me.Crystal_SemesterWise.TabIndex = 0
        Me.Crystal_SemesterWise.ViewTimeSelectionFormula = ""
        '
        'Show_SemesterWise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 403)
        Me.Controls.Add(Me.Crystal_SemesterWise)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Show_SemesterWise"
        Me.Text = "Show_SemesterWise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Crystal_SemesterWise As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Report_Semesterwise1 As Education.Report_Semesterwise
End Class
