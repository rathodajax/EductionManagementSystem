Public Class Detail_Report
    Dim abc As New DetailRPT
    Dim tbl As DataTable
    Dim strsql As String

    Private Sub Detail_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strsql = "SELECT EVENT_ID,EVENT_NAME,EVENT_PLACE,EVENT_ORG,EVENT_DT FROM EVENT_MASTER"
        tbl = getdata(strsql)
        abc.SetDataSource(tbl)
        DetailReport.ReportSource = abc
    End Sub
End Class