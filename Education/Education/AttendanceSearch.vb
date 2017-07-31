Imports System.Data.OleDb

Public Class AttendanceSearch
    Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
    'Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=U:\sem4\project\Attendance\Attendance\bin\x86\Debug\DEPT.mdb")
    Dim query As String
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim cnt As Integer
    Dim tbl As New DataTable
    Dim flag1 As Boolean = True
    Dim flag2 As Boolean = True
    Dim flag3 As Boolean = True
    Dim flag4 As Boolean = True
    Dim flaggrid As Boolean = False

    Private Sub AttendanceSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim i As Integer
        For i = 1990 To Now.Year
            cmbRegYear.Items.Add(i)
        Next
        'cmbRegYear.Text = Now.Year
        Try
            cnn.Open()
        Catch ex As Exception
            MsgBox("Not Connected")
        End Try


        'Filling the Combobox for Semeter
        Dim tbl As New DataTable
        da = New OleDbDataAdapter("SELECT * FROM SEMESTER_MASTER", cnn)
        da.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            cmbSem.Items.Clear()
            For j As Integer = 0 To tbl.Rows.Count - 1
                cmbSem.Items.Add(tbl.Rows(j).Item(1).ToString)
            Next
        End If
        'cmbSem.Text = cmbSem.Items(0).ToString

        'Filling the DataGridView
        Dim tbl1 As New DataTable
        query = "select * from ATTENDANCE_MASTER"
        da = New OleDbDataAdapter(query, cnn)
        da.Fill(tbl1)
        DataGridView1.Rows.Clear()
        cnt = tbl1.Rows.Count - 1
        If tbl1.Rows.Count > 0 Then
            For j As Integer = 0 To tbl1.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(j).Cells(0).Value = (j + 1)
                DataGridView1.Rows(j).Cells(1).Value = tbl1.Rows(j).Item(1).ToString
                DataGridView1.Rows(j).Cells(2).Value = tbl1.Rows(j).Item(2).ToString
                DataGridView1.Rows(j).Cells(3).Value = tbl1.Rows(j).Item(3).ToString
                DataGridView1.Rows(j).Cells(4).Value = tbl1.Rows(j).Item(4).ToString
                DataGridView1.Rows(j).Cells(5).Value = tbl1.Rows(j).Item(0).ToString
            Next
        Else
            MsgBox("No Records Available")
        End If

        chkDate.Checked = True
        chkSem.Checked = True
        chkSub.Checked = True
        chkYear.Checked = True

        cmbRegYear.Enabled = False
        cmbSem.Enabled = False
        cmbSubject.Enabled = False
        dtp1.Enabled = False
        cmbRegYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRegYear.Text = Now.Year

        cmbSem.Text = cmbSem.Items(0).ToString
        flaggrid = True
    End Sub

    Private Sub chkYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYear.CheckedChanged
        If chkYear.Checked = True Then
            cmbRegYear.Enabled = False
        Else
            cmbRegYear.Enabled = True
            cmbRegYear.Focus()
        End If

        If flag1 = False Then
            changeGrid()
        End If
        flag1 = False
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        If chkDate.Checked = True Then
            dtp1.Enabled = False
        ElseIf chkDate.Checked = False Then
            dtp1.Enabled = True
            dtp1.Focus()
        End If

        If flag2 = False Then
            changeGrid()
        End If
        flag2 = False
    End Sub

    Private Sub chkSem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSem.CheckedChanged
        If chkSem.Checked = True Then
            cmbSem.Enabled = False
            chkSem.Checked = True
            cmbSubject.Enabled = False
            chkSub.Checked = True
            chkSub.Enabled = False
        Else
            cmbSem.Enabled = True
            cmbSem.Focus()
            chkSub.Enabled = True
        End If

        If flag3 = False Then
            changeGrid()
        End If
        flag3 = False
    End Sub

    Private Sub chkSub_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSub.CheckedChanged
        If chkSub.Checked = True Then
            cmbSubject.Enabled = False
        Else
            cmbSubject.Enabled = True
            cmbSubject.Focus()
        End If

        If flag4 = False Then
            changeGrid()
        End If
        flag4 = False
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

        changeGrid()
    End Sub

    Public Sub changeGrid()
        Dim no1, no2 As Integer
        Dim query1 As String = ""
        query1 = "select * from ATTENDANCE_MASTER"
        If chkYear.Checked = False Or chkSem.Checked = False Or chkSub.Checked = False Or chkDate.Checked = False Then
            query1 = query1 + " where "
            If chkYear.Checked = False Then
                'If chkDate.Checked = True Or chkSem.Checked = True Or chkSub.Checked = True Then
                query1 = query1 + "REG_YEAR = " + cmbRegYear.Text
                'Else
                '    query1 = query1 + " and REG_YEAR = " + cmbRegYear.Text
                'End If
            End If

            If chkDate.Checked = False Then
                If chkYear.Checked = True Then
                    query1 = query1 + "ATT_DATE = '" + dtp1.Text + "'"
                Else
                    query1 = query1 + " and ATT_DATE = '" + dtp1.Text + "'"
                End If
            End If

            If chkSem.Checked = False Then
                query = "select SEMESTER_ID from SEMESTER_MASTER where SEMESTER_NAME='" + cmbSem.Text + "'"
                da = New OleDbDataAdapter(query, cnn)
                tbl = New DataTable
                da.Fill(tbl)
                no1 = tbl.Rows.Count
                no1 = tbl.Rows(no1 - 1).Item(0)
                If chkYear.Checked = True And chkDate.Checked = True Then
                    query1 = query1 + "SEMESTER = " + no1.ToString
                Else
                    query1 = query1 + " and SEMESTER = " + no1.ToString
                End If
            End If

            If chkSub.Checked = False Then
                query = "select SUB_CODE from SUBJECT_MASTER where SUBJECT_NAME='" + cmbSubject.Text + "'"
                da = New OleDbDataAdapter(query, cnn)
                tbl = New DataTable

                da.Fill(tbl)
                no2 = tbl.Rows.Count
                no2 = tbl.Rows(no2 - 1).Item(0)
                If chkYear.Checked = True And chkSem.Checked = True And chkDate.Checked = True Then
                    query1 = query1 + "SUBJECT = " + no2.ToString
                Else
                    query1 = query1 + " and SUBJECT = " + no2.ToString
                End If
            End If

        End If

        Dim tbl2 As New DataTable
        DataGridView1.Rows.Clear()
        da = New OleDbDataAdapter(query1, cnn)

        da.Fill(tbl2)
        DataGridView1.Rows.Clear()
        cnt = tbl2.Rows.Count - 1

        If tbl2.Rows.Count > 0 Then
            For j As Integer = 0 To tbl2.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(j).Cells(0).Value = (j + 1)
                DataGridView1.Rows(j).Cells(1).Value = tbl2.Rows(j).Item(1).ToString

                query = "select SEMESTER_NAME from SEMESTER_MASTER where SEMESTER_ID = " + tbl2.Rows(j).Item(2).ToString
                tbl = New DataTable
                da = New OleDbDataAdapter(query, cnn)
                da.Fill(tbl)
                DataGridView1.Rows(j).Cells(2).Value = tbl.Rows(0).Item(0) 'sem

                query = "select SUBJECT_NAME from SUBJECT_MASTER where SUB_CODE = " + tbl2.Rows(j).Item(3).ToString
                tbl = New DataTable
                da = New OleDbDataAdapter(query, cnn)
                da.Fill(tbl)
                DataGridView1.Rows(j).Cells(3).Value = tbl.Rows(0).Item(0) 'sub
                DataGridView1.Rows(j).Cells(4).Value = tbl2.Rows(j).Item(4).ToString
                DataGridView1.Rows(j).Cells(5).Value = tbl2.Rows(j).Item(0).ToString
            Next
        Else
            If flaggrid = True Then
                MsgBox("No Records Available")
            End If
        End If
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
        changeGrid()
    End Sub

    Private Sub dtp1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp1.TextChanged
        changeGrid()
    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged
        changeGrid()
    End Sub

    Private Sub cmbRegYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegYear.SelectedIndexChanged
        changeGrid()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim r, c As Integer
        r = DataGridView1.CurrentCell.RowIndex
        c = DataGridView1.CurrentCell.ColumnIndex
        GlobalVariable.stdid = DataGridView1.Rows(r).Cells(5).Value
        GlobalVariable.dr = MsgBox("Do you want to make changes in this attendence?", MsgBoxStyle.YesNo, "View/Edit Record")
        Me.Hide()
        AttendanceViewEdit.Show()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        AttendanceNew.Show()
        Me.Hide()
    End Sub

    Private Sub AttendanceSearch_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub

    Private Sub btnViewReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReports.Click
        Me.Hide()
        AttendanceReport1.Show()
    End Sub
End Class