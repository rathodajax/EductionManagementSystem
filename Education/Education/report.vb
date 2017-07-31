Public Class report
    Dim table As New DataSet

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New CrystalReport1
        SetQuery("SELECT UNIQUE_ID,PER, SEAT_NO, EXAM_YEAR, EXT_TOT, INT_TOT, RESULT FROM RESULT_MASTER WHERE RESULT_ID = " + AddResult.lblResultID.Text)
        LoadData("RESULT_MASTER")
        SetQuery("SELECT STU_NAME FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + AddResult.cmbUniqueId.SelectedItem.ToString + "'")
        LoadData("STUDENT_MASTER")
        SetQuery("SELECT SEMESTER_NAME FROM SEMESTER_MASTER WHERE SEMESTER_ID = " + (AddResult.cmbSem.SelectedIndex + 1).ToString)
        LoadData("SEMESTER_MASTER")
        SetQuery("DELETE * FROM RESULT_REPORT")
        ExecuteNonQuery()
        InsertRecordInResultReport()
        SetQuery("SELECT * FROM RESULT_REPORT ORDER BY ID")
        LoadData("RESULT_REPORT")
        rpt.Refresh()
        rpt.SetDataSource(table)
        CrystalReportViewer1.ReportSource = rpt

    End Sub
    Private Sub InsertRecordInResultReport()
        SetQuery("SELECT SUB_CODE, SUB_NO, SUB_NAME FROM SUBJECT_MASTER WHERE SEM_ID = " + (AddResult.cmbSem.SelectedIndex + 1).ToString + " ORDER BY SUB_CODE")
        Dim tb As DataTable = GetTable()
        SetQuery("SELECT INT_MARK, EXT_MARK FROM RESULT_DETAIL WHERE RESULT_ID = " + AddResult.lblResultID.Text + " ORDER BY RESULT_DETAIL_ID")
        Dim tb2 As DataTable = GetTable()

        For i As Integer = 0 To tb.Rows.Count - 1
            Dim sub_name As String = tb.Rows(i).Item("SUB_CODE").ToString + " - " + tb.Rows(i).Item("SUB_NO").ToString + " - " + tb.Rows(i).Item("SUB_NAME").ToString
            Dim int_mark As String = ""
            Dim ext_mark As String = ""
            If i <> 4 Then
                int_mark = tb2.Rows(i).Item("INT_MARK").ToString + " / 30"
            End If
            If i <> 4 Then
                ext_mark = tb2.Rows(i).Item("EXT_MARK").ToString + " / 70"
            Else
                ext_mark = tb2.Rows(i).Item("EXT_MARK").ToString + " / 100"
            End If

            SetQuery("INSERT INTO RESULT_REPORT (SUBJECT_NAME, INT_MARK, EXT_MARK) VALUES('" + sub_name + "','" + int_mark + "', '" + ext_mark + "')")
            ExecuteNonQuery()
        Next

    End Sub
    Public Sub LoadData(ByVal STR As String)
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        da = New OleDb.OleDbDataAdapter(GetQuery, con)
        da.Fill(table, STR)
        da.Dispose()
    End Sub
End Class