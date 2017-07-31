<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHEReport
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
        Me.crptv1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbnotpossiable = New System.Windows.Forms.RadioButton
        Me.rbsolved = New System.Windows.Forms.RadioButton
        Me.rbinprogress = New System.Windows.Forms.RadioButton
        Me.rball = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crptv1
        '
        Me.crptv1.ActiveViewIndex = -1
        Me.crptv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crptv1.DisplayGroupTree = False
        Me.crptv1.Location = New System.Drawing.Point(0, 73)
        Me.crptv1.Name = "crptv1"
        Me.crptv1.SelectionFormula = ""
        Me.crptv1.Size = New System.Drawing.Size(984, 490)
        Me.crptv1.TabIndex = 0
        Me.crptv1.ViewTimeSelectionFormula = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbnotpossiable)
        Me.Panel1.Controls.Add(Me.rbsolved)
        Me.Panel1.Controls.Add(Me.rbinprogress)
        Me.Panel1.Controls.Add(Me.rball)
        Me.Panel1.Location = New System.Drawing.Point(138, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 32)
        Me.Panel1.TabIndex = 1
        '
        'rbnotpossiable
        '
        Me.rbnotpossiable.AutoSize = True
        Me.rbnotpossiable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnotpossiable.Location = New System.Drawing.Point(243, 7)
        Me.rbnotpossiable.Name = "rbnotpossiable"
        Me.rbnotpossiable.Size = New System.Drawing.Size(113, 21)
        Me.rbnotpossiable.TabIndex = 3
        Me.rbnotpossiable.TabStop = True
        Me.rbnotpossiable.Text = "Not Possiable"
        Me.rbnotpossiable.UseVisualStyleBackColor = True
        '
        'rbsolved
        '
        Me.rbsolved.AutoSize = True
        Me.rbsolved.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbsolved.Location = New System.Drawing.Point(168, 8)
        Me.rbsolved.Name = "rbsolved"
        Me.rbsolved.Size = New System.Drawing.Size(69, 21)
        Me.rbsolved.TabIndex = 2
        Me.rbsolved.TabStop = True
        Me.rbsolved.Text = "Solved"
        Me.rbsolved.UseVisualStyleBackColor = True
        '
        'rbinprogress
        '
        Me.rbinprogress.AutoSize = True
        Me.rbinprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbinprogress.Location = New System.Drawing.Point(64, 7)
        Me.rbinprogress.Name = "rbinprogress"
        Me.rbinprogress.Size = New System.Drawing.Size(98, 21)
        Me.rbinprogress.TabIndex = 1
        Me.rbinprogress.TabStop = True
        Me.rbinprogress.Text = "In Progress"
        Me.rbinprogress.UseVisualStyleBackColor = True
        '
        'rball
        '
        Me.rball.AutoSize = True
        Me.rball.Checked = True
        Me.rball.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rball.Location = New System.Drawing.Point(8, 5)
        Me.rball.Name = "rball"
        Me.rball.Size = New System.Drawing.Size(41, 21)
        Me.rball.TabIndex = 0
        Me.rball.TabStop = True
        Me.rball.Text = "All"
        Me.rball.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter By Status:"
        '
        'frmHEReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 535)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.crptv1)
        Me.Name = "frmHEReport"
        Me.Text = "Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crptv1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbnotpossiable As System.Windows.Forms.RadioButton
    Friend WithEvents rbsolved As System.Windows.Forms.RadioButton
    Friend WithEvents rbinprogress As System.Windows.Forms.RadioButton
    Friend WithEvents rball As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
