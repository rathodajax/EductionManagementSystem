Public Class frmStaffSalary
    Dim i As Integer = 2
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.BackColor = Color.LightGreen
        frmSalary.Show()
        staff.Show()
        expanse.Show()
    End Sub
    Public Sub changecolor()
        Label2.BackColor = menupnl.BackColor
        Label3.BackColor = menupnl.BackColor
        Label4.BackColor = menupnl.BackColor
        Label5.BackColor = menupnl.BackColor
        Label9.BackColor = menupnl.BackColor
    End Sub
    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover, Label3.MouseHover, Label4.MouseHover, Label5.MouseHover, Label9.MouseHover
        sender.BackColor = Color.LightGreen
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave, Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave, Label9.MouseLeave
        If Not i = Val(sender.Name.ToString.Substring(5)) Then
            sender.BackColor = menupnl.BackColor
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        i = Val(sender.Name.ToString.Substring(5))
        changecolor()
        sender.BackColor = Color.LightGreen
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, LinkLabel3.LinkClicked
        Dim t As Integer = Date.DaysInMonth(Date.Today.Year, Date.Today.Month)
        frmSalary.Show()
        frmSalary.Focus()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click, LinkLabel1.LinkClicked

        staff.Show()
        staff.Focus()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click, LinkLabel2.LinkClicked

        expanse.Show()
        expanse.Focus()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        i = Val(sender.Name.ToString.Substring(5))
        changecolor()
        sender.BackColor = Color.LightGreen
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then Me.Close()
    End Sub
End Class
