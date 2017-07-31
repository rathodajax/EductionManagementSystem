Imports System.Data.OleDb

Public Class AttendanceReport1
    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
    'Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=U:\sem4\project\Attendance\Attendance\bin\x86\Debug\DEPT.mdb")
    Dim query As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim cnt As Integer
    Dim tbl, tbl1 As New DataTable

    Private Sub AttendanceReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim i As Integer
        For i = 1990 To Now.Year
            cmbRegYear.Items.Add(i)
        Next
        cmbRegYear.Text = Now.Year

        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Not Connected")
        End Try
        filldata()
    End Sub

    Public Sub filldata()
        Dim sid As Integer
        Dim total, p, a As Integer
        p = 0
        a = 0
        total = 0
        DataGridView1.Rows.Clear()
        query = "Select * from STUDENT_MASTER where REG_YEAR=" + cmbRegYear.Text
        da = New OleDbDataAdapter(query, cnn)
        tbl = New DataTable
        da.Fill(tbl)

        For i As Integer = 0 To tbl.Rows.Count - 1
            DataGridView1.Rows.Add()
            sid = tbl.Rows(i).Item(0)
            DataGridView1.Rows(i).Cells(0).Value = (i + 1)
            DataGridView1.Rows(i).Cells(1).Value = tbl.Rows(i).Item(4).ToString
            DataGridView1.Rows(i).Cells(2).Value = tbl.Rows(i).Item(5).ToString
            query = "Select STATUS from ATTENDANCE_DETAIL where STUD_ID=" + sid.ToString
            da = New OleDbDataAdapter(query, cnn)
            tbl1 = New DataTable
            da.Fill(tbl1)
            total = tbl1.Rows.Count
            If total <> 0 Then
                For j As Integer = 0 To tbl1.Rows.Count - 1
                    'MsgBox(tbl1.Rows(j).Item(0).ToString)
                    If tbl1.Rows(j).Item(0).ToString = "True" Then
                        p = p + 1
                    Else
                        a = a + 1
                    End If
                Next
                If ((100 * a) / total) = 100 Then
                    DataGridView1.Rows(i).Cells(3).Value = "-"
                Else
                    DataGridView1.Rows(i).Cells(3).Value = CInt(((100 * p) / total)).ToString + " %"
                End If


                If ((100 * p) / total) = 100 Then
                    DataGridView1.Rows(i).Cells(4).Value = "-"
                Else
                    DataGridView1.Rows(i).Cells(4).Value = CInt(((100 * a) / total)).ToString + " %"
                End If


                p = 0
                a = 0
                total = 0
            End If

        Next

    End Sub

    Private Sub cmbRegYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegYear.SelectedIndexChanged
        filldata()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        AttendanceSearch.Show()
    End Sub
    Private Sub AttendanceReport1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Me.Close()
        AttendanceSearch.Show()
    End Sub
End Class