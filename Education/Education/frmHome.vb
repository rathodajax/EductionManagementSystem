Public Class frmHome
    Dim i As Integer = 2
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.BackColor = Color.LightGreen
        Label2.ForeColor = Color.Black
        Me.MdiParent = MDIMain
        frmStaff.p1 = Me.p1
        frmSalary.tbcSalary.Location = Me.p1.Location
        frmExpense.TabControl1.Location = Me.p1.Location
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter, Label3.MouseEnter, Label4.MouseEnter, Label5.MouseEnter, Label9.MouseEnter
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave, Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave, Label9.MouseLeave
        If Not i = Val(sender.Name.ToString.Substring(5)) Then
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        Label9.ForeColor = Color.White
        Label9.BackColor = menupnl.BackColor
        i = 2
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, salarydetaillink.LinkClicked

        'salary.MdiParent = MainForm
        frmSalary.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click, expensesdetaillink.LinkClicked
        ' expense.MdiParent = MainForm
        frmExpense.Show()
        Me.Close()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        Label2.ForeColor = Color.White
        Label2.BackColor = menupnl.BackColor
        i = 9
        sender.backcolor = Color.LightGreen
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Label2.ForeColor = Color.Black
            Label2.BackColor = Color.LightGreen
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White
            i = 2
        End If
    End Sub

    Private Sub menupnl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles menupnl.Paint
        frmStaff.menupnl = Me.menupnl
        frmSalary.menupnl = Me.menupnl
        frmExpense.menupnl = Me.menupnl
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'salary.MdiParent = MainForm
        frmStaff.Show()
        frmStaff.selectstaffreport()
        Me.Close()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        'salary.MdiParent = MainForm
        frmSalary.Show()
        frmSalary.selectstaffreport()
        Me.Close()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        'salary.MdiParent = MainForm
        frmExpense.Show()
        frmExpense.selectstaffreport()
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        '  staff.MdiParent = MainForm
        frmStaff.Show()
        Me.Close()
    End Sub

    Private Sub staffdetaillink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles staffdetaillink.LinkClicked
        'salary.MdiParent = MainForm
        frmStaff.Show()
        ' staff.selectstaffdetail()
        Me.Close()
    End Sub
End Class
