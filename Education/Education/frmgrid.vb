Public Class frmgrid
    Dim str, s As String
    Dim d() As Integer
    Dim img1 As Image
    Public Sub record_ref()
        strsql = "SELECT * FROM EVENT_MASTER"
        tbl = getdata(strsql)
        If tbl.Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
            For i As Integer = 0 To tbl.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = tbl.Rows(i).Item(0).ToString
                DataGridView1.Rows(i).Cells(1).Value = tbl.Rows(i).Item(1).ToString

                DataGridView1.Rows(i).Cells(2).Value = tbl.Rows(i).Item(2).ToString
                DataGridView1.Rows(i).Cells(3).Value = tbl.Rows(i).Item(3).ToString

                DataGridView1.Rows(i).Cells(4).Value = tbl.Rows(i).Item(4).ToString
                DataGridView1.Rows(i).Cells(5).Value = Convert.ToDateTime(tbl.Rows(i).Item(5).ToString).ToString("dd/MM/yyyy")
                DataGridView1.Rows(i).Cells(6).Value = tbl.Rows(i).Item(6).ToString

            Next
        End If
    End Sub

    Private Sub frmgrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.MdiParent = MDIMain

        record_ref()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim r As Integer = e.RowIndex
        Dim c As Integer = e.ColumnIndex

        If c = 7 Then
            view_image.Show()
        End If
        If c = 8 Then
            view_video.Show()
        End If 
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        frmadd.cmbevent.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        'frmadd.dtp.Value = CDate(Format(Convert.ToDateTime(DataGridView1.CurrentRow.Cells(5).Value.ToString)))
        'DataGridView1.CurrentRow.Cells(5).Value.ToString()
        frmadd.cmborg.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        frmadd.txtplace.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        frmadd.e_save.Text = "update"
        frmadd.Show()
    End Sub

    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        EventReport.Show()
    End Sub

    Private Sub btndetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndetail.Click
        Detail_Report.Show()

    End Sub
End Class