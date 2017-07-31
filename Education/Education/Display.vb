Public Class display
    Public f As Boolean = False
    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        LoadSem(cmbSem)
        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE EXAM_YEAR = '" + cmbYear.SelectedItem.ToString + "' AND CURRENT_RESULT = " + True.ToString + " ORDER BY SEM_ID, RESULT_ID")
        LoadResult(dgv1)
        SetLastQuery(GetQuery)
        Me.Text = "Display Result - [" + cmbYear.SelectedItem.ToString + "]"
    End Sub
    Private Sub cmbSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSem.SelectedIndexChanged
        LoadExamType(cmbETYPE)
        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE EXAM_YEAR = '" + cmbYear.SelectedItem.ToString + "' AND SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND CURRENT_RESULT = " + True.ToString + " ORDER BY RESULT_ID")
        LoadResult(dgv1)
        SetLastQuery(GetQuery)
        Me.Text = "Display Result - [" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "]"
    End Sub

    Private Sub display_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            DisplayATKT.Close()
            dgv1.Focus()
        End If
    End Sub

    Private Sub Display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetPanel()
        cmbSearch.Focus()
        cmbSearch.SelectedIndex = 0
        cmbSearch.BackColor = GetBackColor()
    End Sub
    Private Sub SetPanel()
        Panel1.Controls.Add(p2)
        Panel1.Controls.Add(p3)
        p2.Location = p1.Location
        p3.Location = p1.Location
    End Sub
    Private Sub ShowPanel(ByVal f1 As Boolean, ByVal f2 As Boolean, ByVal f3 As Boolean)
        If f1 Then
            p1.Show()
        Else
            p1.Hide()
        End If
        If f2 Then
            p2.Show()
        Else
            p2.Hide()
        End If
        If f3 Then
            p3.Show()
        Else
            p3.Hide()
        End If
    End Sub
    Public Sub LoadResult(ByRef dgv As DataGridView)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter(GetQuery(), con)
            ds.Clear()
            da.Fill(ds, "RESULT_MASTER")
            da.Dispose()
            dgv.Rows.Clear()
            CLEAR_RESULT_ID()
            For i As Integer = 0 To ds.Tables("RESULT_MASTER").Rows.Count - 1
                Dim res_id As Integer = ds.Tables("RESULT_MASTER")(i)("RESULT_ID")
                Dim stu_id As String = ds.Tables("RESULT_MASTER")(i)("UNIQUE_ID")
                Dim sem_id As Integer = ds.Tables("RESULT_MASTER")(i)("SEM_ID")
                Dim e_t As Integer = ds.Tables("RESULT_MASTER")(i)("EXAM_TYPE_ID")
                Dim y As Integer = ds.Tables("RESULT_MASTER")(i)("EXAM_YEAR")
                Dim seat_no As Integer = ds.Tables("RESULT_MASTER")(i)("SEAT_NO")
                Dim itot As Integer = ds.Tables("RESULT_MASTER")(i)("INT_TOT")
                Dim etot As Integer = ds.Tables("RESULT_MASTER")(i)("EXT_TOT")
                Dim per As Double = ds.Tables("RESULT_MASTER")(i)("PER")
                Dim res As String = ds.Tables("RESULT_MASTER")(i)("RESULT")
                Dim exam As String = GetString("SELECT SEMESTER_NAME FROM SEMESTER_MASTER WHERE SEMESTER_ID = " + ds.Tables("RESULT_MASTER")(i)("SEM_ID").ToString)
                Dim atkt As Boolean = ds.Tables("RESULT_MASTER")(i)("ATKT")
                Dim sname As String = GetString("SELECT STU_NAME FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + stu_id + "'")
                Dim res_date2 As String = ds.Tables("RESULT_MASTER")(i)("RESULT_DATE").ToString
                dgv.Rows.Add(New String() {"View", y, sem_id, e_t, stu_id, seat_no, sname, itot, etot, per, res, exam, atkt, res_id, res_date2})
                If i = 0 Then
                    ADD_RESULT_ID(res_id.ToString)
                Else
                    ADD_RESULT_ID("," + res_id.ToString)
                End If
                SetLineColor(dgv, Color.Red, atkt, i, 14, 0)
                SetLineColor(dgv, Color.Green, Not atkt, i, 14, 0)
                If i Mod 2 = 0 Then
                    SetLineColor(dgv, Color.Wheat, False, i, 14, 1)
                Else
                    SetLineColor(dgv, Color.White, False, i, 14, 1)
                End If
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        Try
            If dgv1.Rows.Count > 1 Then
                Dim r As Integer = dgv1.CurrentCell.RowIndex
                Dim c As Integer = dgv1.CurrentCell.ColumnIndex
                If c = 0 Then
                    If f Then
                        f = False
                        DisplayATKT.Close()
                        SetQuery(GetLastQuery)
                        LoadResult(dgv1)
                    ElseIf Val((dgv1.Rows(r).Cells(3).Value)) = 1 Then
                        tos = r
                        SetMode("View")
                        SetResultMasterID(Val(dgv1.Rows(r).Cells(13).Value))
                        AddResult.Show()
                        AddResult.MarkEntry_Load(New Object, New System.EventArgs)
                        AddResult.ViewMode()
                        AddResult.Button1.Enabled = True
                        AddResult.Focus()
                    ElseIf Val((dgv1.Rows(r).Cells(3).Value)) = 2 Then
                        Try
                            DisplayATKT.Text = "ATKT Result Viewer - [" + dgv1.Rows(r).Cells(11).Value + "] - [" + dgv1.Rows(r).Cells(6).Value + "]"
                            DisplayATKT.Show()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                        DisplayATKT.Focus()
                        f = True
                        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE SEM_ID = " + Val(dgv1.Rows(r).Cells(2).Value).ToString + " AND UNIQUE_ID = '" + dgv1.Rows(r).Cells(4).Value.ToString + "' ORDER BY RESULT_ID")
                        LoadResult(DisplayATKT.dgv2)
                        DisplayATKT.lblAttempt.Text = DisplayATKT.dgv2.Rows.Count - 1
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            ShowPanel(False, False, False)
        ElseIf cmbSearch.SelectedIndex = 1 Then
            LoadYear(cmbYear)
            ShowPanel(True, False, False)
        ElseIf cmbSearch.SelectedIndex = 2 Then
            ShowPanel(False, True, False)
        ElseIf cmbSearch.SelectedIndex = 3 Then
            ShowPanel(False, False, True)
        End If
        If cmbSearch.SelectedIndex <> 1 Then
            cmbYear.Items.Clear()
            cmbSem.Items.Clear()
            cmbETYPE.Items.Clear()
        End If
        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE CURRENT_RESULT = " + True.ToString + " ORDER BY EXAM_YEAR, SEM_ID, RESULT_ID")
        LoadResult(dgv1)
        SetLastQuery(GetQuery)
        If cmbSearch.SelectedItem.ToString.Equals("ATKT") Then
            ShowPanel(False, False, False)
            SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT,RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE CURRENT_RESULT = " + True.ToString + " AND EXAM_TYPE_ID = 2 ORDER BY EXAM_YEAR, SEM_ID, RESULT_ID")
            LoadResult(dgv1)
            SetLastQuery(GetQuery)
        End If
        Me.Text = "Display Result - [" + cmbSearch.SelectedItem.ToString + "]"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SetMode("Add")
        AddResult.Show()
        AddResult.MarkEntry_Load(sender, e)
        AddResult.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ExamFee.Show()
        ExamFee.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Do you really want to Exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub txtSeatNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSeatNo.TextChanged
        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE UNIQUE_ID LIKE ('%" + txtSeatNo.Text.ToString + "%') AND CURRENT_RESULT = " + True.ToString + " ORDER BY RESULT_ID")
        LoadResult(dgv1)
        SetLastQuery(GetQuery)
        Me.Text = "Display Result-[" + cmbSearch.SelectedItem.ToString + "] - [" + txtSeatNo.Text.ToString + "]"
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE UNIQUE_ID IN (SELECT UNIQUE_ID FROM STUDENT_MASTER WHERE STU_NAME LIKE ('%" + txtName.Text.ToString + "%')) AND CURRENT_RESULT = " + True.ToString)
        LoadResult(dgv1)
        SetLastQuery(GetQuery)
        Me.Text = "Display Result-[" + cmbSearch.SelectedItem.ToString + "] - [" + txtName.Text.ToString + "]"
    End Sub

    Private Sub dgv2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        f = False
        DisplayATKT.Close()
        dgv1.Focus()
        SetQuery(GetLastQuery)
        LoadResult(dgv1)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbETYPE.SelectedIndexChanged
        SetQuery("SELECT UNIQUE_ID, EXAM_TYPE_ID, SEM_ID, EXAM_YEAR, SEAT_NO, INT_TOT, EXT_TOT, PER, RESULT, ATKT, RESULT_ID, RESULT_DATE FROM RESULT_MASTER WHERE EXAM_YEAR = '" + cmbYear.SelectedItem.ToString + "' AND SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + "AND EXAM_TYPE_ID = " + (cmbETYPE.SelectedIndex + 1).ToString + " AND CURRENT_RESULT = " + True.ToString + " ORDER BY RESULT_ID")
        LoadResult(dgv1)
        SetLastQuery(GetQuery)
        Me.Text = "Display Result-[" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "] - [" + cmbETYPE.SelectedItem.ToString + "]"
    End Sub
End Class