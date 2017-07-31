Public Class view_video
    Dim str, s As String
    Dim d() As Integer
    Dim img1 As Image

    Private Sub cmbevent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' AxWindowsMediaPlayer1.URL = cmbvid.SelectedItem.ToString
    End Sub

    Private Sub view_video_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        'strsql = "select * from event_detail"

        'adpt = New Data.OleDb.OleDbDataAdapter(strsql, con)
        'adpt.Fill(ds, "event_detail")
        'For j As Integer = 0 To ds.Tables("event_detail").Rows.Count - 1
        '    If Not cmbvid.Items.Contains(ds.Tables("event_detail").Rows(j).Item("pvpath").ToString) Then
        '        If ds.Tables("event_detail").Rows(j).Item("is_photo_video") = 2 Then
        '            Me.cmbvid.Items.Add(ds.Tables("event_detail").Rows(j).Item("pvpath").ToString)
        '        End If
        '    End If

        'Next
        fillvideo()
    End Sub

    Public Sub fillvideo()
       
        'str = "SELECT DISTINCT ed.PVPATH,em.EVENT_YEAR FROM EVENT_DETAIL ed, EVENT_MASTER em WHERE ed.EVENT_NAME='" & frmgrid.DataGridView1.CurrentRow.Cells(2).Value.ToString & "' and em.EVENT_YEAR=" & frmgrid.DataGridView1.CurrentRow.Cells(6).Value.ToString & " AND ED.IS_PHOTO_VIDEO = '2'"
        str = "SELECT em.EVENT_ID, ed.EVENT_NAME FROM EVENT_MASTER em, EVENT_DETAIL ed WHERE ed.EVENT_NAME='" & frmgrid.DataGridView1.CurrentRow.Cells(2).Value.ToString & "' AND ED.IS_PHOTO_VIDEO = '2'"

        tbl = getdata(str)
        ListView1.Items.Clear()
        ListView1.View = View.LargeIcon
        Dim imglist As New ImageList With {.ImageSize = New Size(50, 50)}
        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\video\" & tbl.Rows(0).Item(0).ToString & "\")

        Dim arrfi As IO.FileInfo() = di.GetFiles("*.*")

        Dim fi As IO.FileInfo

        Dim i As Integer = 0
        For Each fi In arrfi
            Dim ico As Icon = Icon.ExtractAssociatedIcon(fi.FullName)
            imglist.Images.Add(ico)
            ListView1.Items.Add(fi.FullName, i)
            i = i + 1
        Next

        ListView1.LargeImageList = imglist
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        frmvideo.Show()
    End Sub
End Class