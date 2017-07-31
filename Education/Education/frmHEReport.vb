Public Class frmHEReport

    Dim obj As New Concls

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rball.CheckedChanged
        If rball.Checked = True Then
            showReport(rball.Text)
        End If
    End Sub
    Public Sub showReport(ByVal pv As String)
        Dim dt As New DataTable
        Dim str As String

        If pv = "All" Then
            str = "SELECT * FROM VReportHE Order By REQ_DATE DESC,STATUS_NAME"
        Else
            str = "SELECT * FROM VReportHE WHERE STATUS_NAME='" + pv + "'Order By REQ_DATE DESC,STATUS_NAME"

        End If

        dt = obj.GetTableQury(str)


        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New rptHEReport

        rptDoc.SetDataSource(dt)
        '
        crptv1.ReportSource = rptDoc






    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbinprogress.CheckedChanged
        If rbinprogress.Checked = True Then
            showReport(rbinprogress.Text)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsolved.CheckedChanged
        If rbsolved.Checked = True Then
            showReport(rbsolved.Text)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnotpossiable.CheckedChanged
        If rbnotpossiable.Checked = True Then
            showReport(rbnotpossiable.Text)
        End If
    End Sub

    Private Sub frmHEReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crptv1.Width = Me.Width - 18

        crptv1.Height = Me.Height - 110






    End Sub
End Class