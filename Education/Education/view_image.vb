
Public Class view_image
    Dim str, s As String
    Dim d() As Integer
    Dim img1 As Image
    Private Sub view_image_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillphoto()
    End Sub
    Public Sub fillphoto()
        str = "SELECT DISTINCT ed.PVPATH,em.EVENT_YEAR FROM EVENT_DETAIL ed, EVENT_MASTER em WHERE ed.EVENT_NAME='" & frmgrid.DataGridView1.CurrentRow.Cells(2).Value.ToString & "' and em.EVENT_YEAR=" & frmgrid.DataGridView1.CurrentRow.Cells(6).Value.ToString & " AND ED.IS_PHOTO_VIDEO = '1'"
        tbl = getdata(str)
        ListView1.View = View.LargeIcon
        Dim imglist1 As New ImageList With {.ImageSize = New Size(100, 100)}
        For i = 0 To tbl.Rows.Count - 1
            img1 = Image.FromFile(tbl.Rows(i).Item(0).ToString)
            imglist1.Images.Add(img1)
            Dim li1 As New ListViewItem(tbl.Rows(i).Item(0).ToString, i)
            ' Dim li1 As New ListViewItem("", i)
            ListView1.Items.Add(li1)
        Next
        ListView1.LargeImageList = imglist1
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        photo.Show()
        Me.Hide()
    End Sub
End Class