Imports Attendance.GlobalVariable
Imports System.Data.OleDb

Public Class AttendanceViewEdit

    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
    'Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\my family\brinda\Attendance\DEPT.mdb")
    Dim query As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim tbl, tbl1 As DataTable
    Dim cmd As New OleDbCommand

    Private Sub AttendanceViewEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Not Connected")
        End Try

        'MsgBox(GlobalVariable.stdid.ToString + " " + GlobalVariable.dr.ToString)
        cmbRegYear.Enabled = False
        cmbSem.Enabled = False
        cmbSubject.Enabled = False
        dtp1.Enabled = False

        masterfill()
        detailfill()

        If GlobalVariable.dr = Windows.Forms.DialogResult.Yes Then
        ElseIf GlobalVariable.dr = Windows.Forms.DialogResult.No Then
            btnSave.Enabled = False
            DataGridView1.Enabled = False
        End If
        'detailfill()
    End Sub

    Public Sub masterfill()
        query = "select * from ATTENDANCE_MASTER where ATT_ID=" + GlobalVariable.stdid.ToString
        da = New OleDbDataAdapter(query, cnn)
        tbl = New DataTable
        da.Fill(tbl)
        cmbRegYear.Text = tbl.Rows(0).Item(1)

        query = "select SUBJECT_NAME from SUBJECT_MASTER where SUB_CODE = " + tbl.Rows(0).Item(3).ToString
        tbl1 = New DataTable
        da = New OleDbDataAdapter(query, cnn)
        da.Fill(tbl1)
        cmbSubject.Text = tbl1.Rows(0).Item(0) 'sub

        query = "select SEMESTER_NAME from SEMESTER_MASTER where SEMESTER_ID = " + tbl.Rows(0).Item(2).ToString
        tbl1 = New DataTable
        da = New OleDbDataAdapter(query, cnn)
        da.Fill(tbl1)
        cmbSem.Text = tbl1.Rows(0).Item(0) 'sem

        Dim st As String
        st = tbl.Rows(0).Item(4).ToString
        Dim ex As Date = Date.ParseExact(st, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        dtp1.Text = ex
    End Sub

    Public Sub detailfill()
        query = "select * from ATTENDANCE_DETAIL where ATT_ID=" + GlobalVariable.stdid.ToString
        da = New OleDbDataAdapter(query, cnn)
        tbl = New DataTable
        da.Fill(tbl)
        For i As Integer = 0 To tbl.Rows.Count - 1
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = i + 1
            query = "select STU_RNO,STU_NAME from STUDENT_MASTER where STU_ID=" + tbl.Rows(i).Item(2).ToString
            da = New OleDbDataAdapter(query, cnn)
            tbl1 = New DataTable
            da.Fill(tbl1)
            DataGridView1.Rows(i).Cells(1).Value = tbl1.Rows(0).Item(0).ToString
            DataGridView1.Rows(i).Cells(2).Value = tbl1.Rows(0).Item(1).ToString
            If tbl.Rows(i).Item(3).ToString = "True" Then
                DataGridView1.Rows(i).Cells(3).Value = True
            Else
                DataGridView1.Rows(i).Cells(3).Value = False
            End If
            DataGridView1.Rows(i).Cells(4).Value = tbl.Rows(i).Item(0)
        Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim frm As AttendanceSearch
        frm = New AttendanceSearch
        Me.Close()
        frm.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim f As Boolean = False
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(3).Value = True Then
                f = True
            End If
        Next
        If f = True Then
            For i As Integer = 0 To tbl.Rows.Count - 1
                query = "update ATTENDANCE_DETAIL set STATUS='" + DataGridView1.Rows(i).Cells(3).Value.ToString + "' where ID=" + DataGridView1.Rows(i).Cells(4).Value.ToString
                Dim cmd As New OleDbCommand(query, cnn)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Successfully Updated", MsgBoxStyle.Information)

            Dim frm As AttendanceSearch
            frm = New AttendanceSearch
            Me.Close()
            frm.Show()
        Else
            MsgBox("You must have to select attendance", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub AttendanceViewEdit_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim frm As AttendanceSearch
        frm = New AttendanceSearch
        frm.Show()
    End Sub
End Class