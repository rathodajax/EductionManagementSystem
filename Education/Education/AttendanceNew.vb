Imports System.Data.OleDb
Imports Attendance.GlobalVariable

Public Class AttendanceNew

    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")

    Dim query As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim cnt As Integer

    Private Sub AttendanceNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkSelectAll.Enabled = False

        'Me.STUDENT_MASTERTableAdapter.Fill(Me.DEPTDataSet.STUDENT_MASTER)

        Me.WindowState = FormWindowState.Maximized

        'To fill the combobox for year
        Dim i As Integer
        For i = 1990 To Now.Year
            cmbRegYear.Items.Add(i)
        Next
        cmbRegYear.Text = 1990

        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Not Conneted")
        End Try


        Dim tbl As New DataTable
        da = New OleDbDataAdapter("SELECT * FROM SEMESTER_MASTER", cnn)
        da.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            cmbSem.Items.Clear()
            For j As Integer = 0 To tbl.Rows.Count - 1
                cmbSem.Items.Add(tbl.Rows(j).Item(1).ToString)
            Next
        End If
        cmbSem.Text = cmbSem.Items(0).ToString
        cmbRegYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRegYear.Text = Now.Year
        optPresent.Checked = True
        btnSave.Enabled = False
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim x As DialogResult
        chkSelectAll.Enabled = True

        Dim f1 As Boolean = False
        Dim tbl3 As New DataTable

        Dim semid As Integer
        Dim tbl As New DataTable
        query = "select SEMESTER_ID from SEMESTER_MASTER where SEMESTER_NAME='" + cmbSem.Text + "'"
        da = New OleDbDataAdapter(query, cnn)
        da.Fill(tbl)
        semid = tbl.Rows.Count
        semid = tbl.Rows(semid - 1).Item(0)

        Dim subid As Integer
        Dim tbl1 As New DataTable
        query = "select SUB_CODE from SUBJECT_MASTER where SUBJECT_NAME='" + cmbSubject.Text + "'"
        da = New OleDbDataAdapter(query, cnn)
        da.Fill(tbl1)
        subid = tbl1.Rows.Count
        subid = tbl1.Rows(subid - 1).Item(0)

        da = New OleDbDataAdapter("SELECT * FROM ATTENDANCE_MASTER", cnn)
        da.Fill(tbl3)
        If tbl3.Rows.Count > 0 Then
            For j As Integer = 0 To tbl3.Rows.Count - 1
                If tbl3.Rows(j).Item(1) = cmbRegYear.Text And tbl3.Rows(j).Item(2) = semid And tbl3.Rows(j).Item(3) = subid And tbl3.Rows(j).Item(4) = dtp1.Text Then
                    f1 = True
                    GlobalVariable.stdid = tbl3.Rows(j).Item(0)
                    'MsgBox(tbl3.Rows(j).Item(1).ToString + " " + tbl3.Rows(j).Item(2).ToString + " " + tbl3.Rows(j).Item(3).ToString + " " + tbl3.Rows(j).Item(4).ToString)
                End If
            Next
        End If

        If f1 = True Then

            x = MsgBox("Attendance for the same year, semester, subject and date is already taken!" + vbNewLine + "Do You Want to Update this Attendance??", MsgBoxStyle.YesNoCancel, "Attendance Already Taken")
            GlobalVariable.dr = x
            If x = Windows.Forms.DialogResult.No Then
                cmbRegYear.Enabled = True
                cmbSem.Enabled = True
                cmbSubject.Enabled = True
                dtp1.Enabled = True
                DataGridView1.Rows.Clear()
                btnSave.Enabled = False
                cmbSubject.Focus()

                AttendanceViewEdit.Show()
                Me.Close()
            ElseIf x = Windows.Forms.DialogResult.Yes Then
                AttendanceViewEdit.Show()
                Me.Close()
            ElseIf x = Windows.Forms.DialogResult.Cancel Then
                btnShow.Enabled = True
            End If
        Else
            tbl = New DataTable
            query = "select * from STUDENT_MASTER where REG_YEAR=" + cmbRegYear.Text
            da = New OleDbDataAdapter(query, cnn)
            da.Fill(tbl)
            DataGridView1.Rows.Clear()
            cnt = tbl.Rows.Count - 1

            If tbl.Rows.Count > 0 Then

                For j As Integer = 0 To tbl.Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(j).Cells(0).Value = (j + 1)
                    DataGridView1.Rows(j).Cells(1).Value = tbl.Rows(j).Item(4).ToString
                    DataGridView1.Rows(j).Cells(2).Value = tbl.Rows(j).Item(5).ToString
                    DataGridView1.Rows(j).Cells(4).Value = tbl.Rows(j).Item(0).ToString
                Next

                btnSave.Enabled = True
                cmbRegYear.Enabled = False
                cmbSem.Enabled = False
                cmbSubject.Enabled = False
                dtp1.Enabled = False
            Else
                MsgBox("No Records Available")
            End If
        End If
        btnShow.Enabled = False
        If x = Windows.Forms.DialogResult.Cancel Then
            btnShow.Enabled = True
            cmbRegYear.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim f As Boolean = False

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(3).Value = True Then
                f = True
            End If
        Next

        If f = True Then
            Dim semid As Integer
            Dim tbl As New DataTable
            query = "select SEMESTER_ID from SEMESTER_MASTER where SEMESTER_NAME='" + cmbSem.Text + "'"
            da = New OleDbDataAdapter(query, cnn)
            da.Fill(tbl)
            semid = tbl.Rows.Count
            semid = tbl.Rows(semid - 1).Item(0)

            Dim subid As Integer
            Dim tbl1 As New DataTable
            query = "select SUB_CODE from SUBJECT_MASTER where SUBJECT_NAME='" + cmbSubject.Text + "'"
            da = New OleDbDataAdapter(query, cnn)
            da.Fill(tbl1)
            subid = tbl1.Rows.Count
            subid = tbl1.Rows(subid - 1).Item(0)

            query = "insert into ATTENDANCE_MASTER(REG_YEAR,SEMESTER,SUBJECT,ATT_DATE) values(" & cmbRegYear.Text & "," & semid & "," & subid & ",'" & dtp1.Text & "')"
            Dim cmd As New OleDbCommand(query, cnn)
            cmd.ExecuteNonQuery()

            Dim tbl2 As New DataTable
            'query = "select Att_Id from ATTENDANCE_MASTER where SEMESTER='" + cmbSem.Text + "'"
            query = "select ATT_ID from ATTENDANCE_MASTER"
            da = New OleDbDataAdapter(query, cnn)
            da.Fill(tbl2)
            Dim no As Integer
            no = tbl2.Rows.Count
            no = tbl2.Rows(no - 1).Item(0)
            'MsgBox(no.ToString)

            'detail table
            For i As Integer = 0 To cnt
                Dim studid As Integer = DataGridView1.Rows(i).Cells(4).Value
                Dim status As String = DataGridView1.Rows(i).Cells(3).Value
                If optPresent.Checked = True Then
                    If status = "True" Then
                        status = "True"
                    Else
                        status = "False"
                    End If
                ElseIf optAbsent.Checked = True Then
                    If status = "True" Then
                        status = "False"
                    Else
                        status = "True"
                    End If
                End If

                query = "insert into ATTENDANCE_DETAIL(ATT_ID,STUD_ID,STATUS) values(" & no & "," & studid.ToString & ",'" & status & "')"
                cmd = New OleDbCommand(query, cnn)
                cmd.ExecuteNonQuery()
            Next

            MsgBox("Successfully Inserted ! ")
            'DataGridView1.Rows.Clear()
            'cmbRegYear.Enabled = True
            'cmbSem.Enabled = True
            'cmbSubject.Enabled = True
            'dtp1.Enabled = True
            'btnSave.Enabled = False

            Dim frm As AttendanceSearch
            frm = New AttendanceSearch
            frm.Show()
            Me.Close()
        Else
            MsgBox("You must have to select attendance", MsgBoxStyle.Critical)
        End If

        chkSelectAll.Enabled = False
        chkSelectAll.Checked = False
        btnShow.Enabled = True
    End Sub

    Public Sub detailfill()
        Dim tbl, tbl1 As DataTable
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

    Private Sub cmbSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSem.SelectedIndexChanged
        Dim no As Integer

        Dim tbl As New DataTable

        query = "select SEMESTER_ID from SEMESTER_MASTER where SEMESTER_NAME='" + cmbSem.Text + "'"
        da = New OleDbDataAdapter(query, cnn)
        da.Fill(tbl)
        no = tbl.Rows.Count
        no = tbl.Rows(no - 1).Item(0)


        query = "select SUBJECT_NAME from SUBJECT_MASTER where SEMESTER_ID = " + no.ToString

        da = New OleDbDataAdapter(query, cnn)
        tbl = New DataTable
        da.Fill(tbl)
        cmbSubject.Items.Clear()

        For j As Integer = 0 To tbl.Rows.Count - 1
            cmbSubject.Items.Add(tbl.Rows(j).Item(0).ToString)
        Next

        cmbSubject.Text = cmbSubject.Items(0).ToString
    End Sub

    Private Sub cmbRegYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegYear.SelectedIndexChanged
        btnSave.Enabled = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        chkSelectAll.Checked = False
        chkSelectAll.Enabled = False
        btnShow.Enabled = True
        cmbRegYear.Enabled = True
        cmbSubject.Enabled = True
        cmbSem.Enabled = True
        dtp1.Enabled = True
        btnSave.Enabled = False
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub chkSelectAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSelectAll.Click
        If chkSelectAll.Checked = True Then
            For i As Integer = 0 To cnt
                DataGridView1.Rows(i).Cells(3).Value = True
            Next
        Else
            For i As Integer = 0 To cnt
                DataGridView1.Rows(i).Cells(3).Value = False
            Next
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As AttendanceSearch
        frm = New AttendanceSearch
        Me.Close()
        frm.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim frm As AttendanceSearch
        frm = New AttendanceSearch
        Me.Close()
        frm.Show()
    End Sub

    Private Sub AttendanceNew_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim frm As AttendanceSearch
        frm = New AttendanceSearch
        frm.Show()
    End Sub
End Class