Public Class EventReport
    Dim rpt As New EventRPT
    Dim tbl As DataTable
    Dim strsql As String

    Private Sub EventCry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventCry.Load

    End Sub

    Private Sub EventReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        strsql = "SELECT * FROM EVENT_TYPE_MASTER"
        tbl = getdata(strsql)
        rpt.SetDataSource(tbl)
        EventCry.ReportSource = rpt
    End Sub
End Class