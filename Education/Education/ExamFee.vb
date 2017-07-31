Public Class ExamFee

    Private Sub cmbYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbYear.KeyDown
        If e.KeyCode = Keys.Enter And cmbYear.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbYear.Text <> "" Then
            cmbSem.Focus()
        End If
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        LoadSem(cmbSem)
        LoadExamType(cmbEType)
        cmbSem.Enabled = True
        cmbEType.Enabled = False
        Me.Text = "Exam Fee - [" + cmbYear.SelectedItem.ToString + "]"
    End Sub
    Public Sub SetEnableMasterField(ByVal flag As Boolean)
        cmbYear.Enabled = flag
        cmbSem.Enabled = flag
        cmbEType.Enabled = flag
        btnConfirm.Enabled = flag
        btnRemove.Enabled = flag
        btnSelect1.Enabled = flag
        btnSelect2.Enabled = flag
        dgv1.Enabled = flag
        dgv2.Enabled = flag
    End Sub
    Public Sub ExamFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadYear(cmbYear)
        SetEnableMasterField(False)
        cmbYear.Enabled = True
        cmbYear.Focus()
        dgv1.Rows.Clear()
        dgv2.Rows.Clear()
    End Sub

    Private Sub cmbSem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSem.KeyDown
        If e.KeyCode = Keys.Enter And cmbSem.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbSem.Text <> "" Then
            cmbEType.Focus()
        End If
    End Sub

    Private Sub cmbSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSem.SelectedIndexChanged
        LoadExamType(cmbEType)
        cmbEType.Enabled = True
        Me.Text = "Exam Fee - [" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "]"
    End Sub

    Private Sub cmbEType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbEType.KeyDown
        If e.KeyCode = Keys.Enter And cmbEType.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbEType.Text <> "" Then
            dtpRDate.Focus()
        End If
    End Sub

    Private Sub cmbEType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEType.SelectedIndexChanged
        LoadStudentFromFee()
        If cmbEType.SelectedIndex = 0 Then
            SetQuery("SELECT UNIQUE_ID FROM STUDENT_MASTER WHERE STU_ID IN (SELECT STU_ID FROM FEES_MASTER WHERE YEAR(FEE_DATE) = " + cmbYear.SelectedItem.ToString + "AND TAKEN_FOR = '" + cmbSem.SelectedItem.ToString + "') ORDER BY UNIQUE_ID")
            LoadStudentForFee("STUDENT_MASTER")
        ElseIf cmbEType.SelectedIndex = 1 Then
            SetQuery("SELECT UNIQUE_ID FROM RESULT_MASTER WHERE SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND ATKT = " + True.ToString + " AND CURRENT_RESULT = " + True.ToString + " AND EXAM_YEAR <= '" + cmbYear.Text + "' ORDER BY UNIQUE_ID")
            LoadStudentForFee("RESULT_MASTER")
        End If
        Me.Text = "Exam Fee - [" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "] - [" + cmbEType.SelectedItem.ToString + "]"
    End Sub
    Private Function LoadStudentForFee(ByVal table As String) As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter(GetQuery(), con)
            ds.Clear()
            da.Fill(ds, table)
            da.Dispose()
            dgv1.Rows.Clear()
            Dim j As Integer = 0
            For i As Integer = 0 To ds.Tables(table).Rows.Count - 1
                Dim year As String = cmbYear.SelectedItem.ToString
                Dim sem_id As String = (cmbSem.SelectedIndex + 1).ToString
                Dim u_id As String = ds.Tables(table)(i)("UNIQUE_ID").ToString
                Dim name1 As String = GetString("SELECT STU_NAME FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + u_id + "'")
                Dim fee As String = GetString("SELECT AMOUNT FROM EXAM_FEE_AMOUNT WHERE EFA_ID = " + sem_id)
                If cmbEType.SelectedIndex = 0 Then
                    If Val(CheckStudent("SELECT COUNT(*) FROM EXAM_FEE_MASTER WHERE UNIQUE_ID = '" + u_id + "' AND EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND CURRENT_RESULT = " + True.ToString)) = 0 And Not CheckStudent1(u_id) Then
                        dgv1.Rows.Add(New String() {False, u_id, name1, fee})
                        If j Mod 2 = 0 Then
                            SetLineColor(dgv1, Color.Wheat, False, j, 3, 1)
                        Else
                            SetLineColor(dgv1, Color.White, False, j, 3, 1)
                        End If
                        j += 1
                    End If
                ElseIf cmbEType.SelectedIndex = 1 Then
                    If CheckStudent("SELECT EXAM_OVER FROM EXAM_FEE_MASTER WHERE UNIQUE_ID = '" + u_id + "' AND CURRENT_RESULT = " + True.ToString) And Not CheckStudent1(u_id) Then
                        dgv1.Rows.Add(New String() {False, u_id, name1, fee})
                        If j Mod 2 = 0 Then
                            SetLineColor(dgv1, Color.Wheat, False, j, 3, 1)
                        Else
                            SetLineColor(dgv1, Color.White, False, j, 3, 1)
                        End If
                        j += 1
                    End If
                End If
                
            Next
            If dgv1.Rows.Count > 1 Then
                btnConfirm.Enabled = True
                btnSelect1.Enabled = True
                dgv1.Enabled = True
            Else
                btnConfirm.Enabled = False
                btnSelect1.Enabled = False
                dgv1.Enabled = False
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "LoadStudentForFee")
        End Try
    End Function
    Private Function CheckStudent1(ByVal strid As String) As Boolean
        Try
            For i As Integer = 0 To dgv2.Rows.Count - 1
                If dgv2.Rows(i).Cells("u_id").Value.Equals(strid) Then
                    Return True
                End If
            Next
        Catch ex As Exception

        End Try
        Return False
    End Function

    
    Private Sub CheckAll(ByRef dgv As DataGridView, ByVal columnName As String)
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Cells(columnName).Value = True
        Next
    End Sub
    Private Sub UnCheckAll(ByRef dgv As DataGridView, ByVal columnName As String)
        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Cells(columnName).Value = False
        Next
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UnCheckAll(dgv1, "payment")
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        SaveRecordForFee()
        LoadStudentFromFee()
        cmbEType_SelectedIndexChanged(sender, e)
        btnSelect1.Text = "Select All"
    End Sub
    Private Sub LoadStudentFromFee()
        Try

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT EXAM_FEE_MASTER_ID, UNIQUE_ID, EXAM_FEE_AMOUNT_ID, EXAM_OVER FROM EXAM_FEE_MASTER WHERE EXAM_YEAR = '" + cmbYear.SelectedItem.ToString + "' AND EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND EXAM_TYPE_ID = " + (cmbEType.SelectedIndex + 1).ToString + "AND EXAM_OVER = " + False.ToString + " ORDER BY UNIQUE_ID", con)
            ds.Clear()
            da.Fill(ds, "EXAM_FEE_MASTER")
            da.Dispose()

            dgv2.Rows.Clear()
            For i As Integer = 0 To ds.Tables("EXAM_FEE_MASTER").Rows.Count - 1

                Dim u_id As String = ds.Tables("EXAM_FEE_MASTER").Rows(i)("UNIQUE_ID").ToString
                Dim name1 As String = GetString("SELECT STU_NAME FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + u_id + "'")
                Dim amount As Integer = GetString("SELECT AMOUNT FROM EXAM_FEE_AMOUNT WHERE EFA_ID = " + ds.Tables("EXAM_FEE_MASTER").Rows(i)("EXAM_FEE_AMOUNT_ID").ToString)
                Dim e_f_m_id As Integer = ds.Tables("EXAM_FEE_MASTER").Rows(i)("EXAM_FEE_MASTER_ID").ToString
                Dim result As Boolean = ds.Tables("EXAM_FEE_MASTER").Rows(i)("EXAM_OVER")
                dgv2.Rows.Add(New String() {False, u_id, name1, amount, result, e_f_m_id})
                If i Mod 2 = 0 Then
                    SetLineColor(dgv2, Color.Wheat, False, i, 5, 1)
                Else
                    SetLineColor(dgv2, Color.White, False, i, 5, 1)
                End If
            Next
            If dgv2.Rows.Count > 1 Then
                btnRemove.Enabled = True
                btnSelect2.Enabled = True
                dgv2.Enabled = True
            Else
                btnRemove.Enabled = False
                btnSelect2.Enabled = False
                dgv2.Enabled = False
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "LoadStudentFromFee")
        End Try
    End Sub
    Private Sub SaveRecordForFee()
        Try
            Dim index As Integer = 0
            While (index < dgv1.Rows.Count - 1)
                If dgv1.Rows(index).Cells("payment").Value Then
                    SetQuery("UPDATE EXAM_FEE_MASTER SET CURRENT_RESULT = " + False.ToString + " WHERE EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + dgv1.Rows(index).Cells(1).Value.ToString + "'")
                    SetCurrentRecord()
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    Dim e_f_m_id As Integer = 0
                    cmd = New OleDb.OleDbCommand("SELECT MAX(EXAM_FEE_MASTER_ID) FROM EXAM_FEE_MASTER", con)
                    If cmd.ExecuteScalar.ToString = "" Then
                        e_f_m_id = 1
                    Else
                        e_f_m_id = cmd.ExecuteScalar + 1
                    End If
                    cmd = New OleDb.OleDbCommand("INSERT INTO EXAM_FEE_MASTER VALUES(@ID,@E_YEAR,@AMOUNT_ID,@E_TYPE_ID,@U_ID,@E_DATE,@OVER,@CRESULT)", con)
                    cmd.Parameters.AddWithValue("@ID", e_f_m_id)
                    cmd.Parameters.AddWithValue("@E_YEAR", cmbYear.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("@AMOUNT_ID", cmbSem.SelectedIndex + 1)
                    cmd.Parameters.AddWithValue("@E_TYPE_ID", cmbEType.SelectedIndex + 1)
                    cmd.Parameters.AddWithValue("@U_ID", dgv1.Rows(index).Cells(1).Value.ToString)
                    cmd.Parameters.AddWithValue("@E_DATE", dtpRDate.Value.Date.ToShortDateString)
                    cmd.Parameters.AddWithValue("@OVER", False)
                    cmd.Parameters.AddWithValue("@CRESULT", True)
                    cmd.ExecuteNonQuery()
                    dgv1.Rows.RemoveAt(index)
                    con.Close()
                Else
                    index += 1
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "SaveRecordForFee")
        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        RemoveStudentFromFee()
        If cmbEType.SelectedIndex = 0 Then
            SetQuery("SELECT UNIQUE_ID FROM STUDENT_MASTER WHERE STU_ID IN (SELECT STU_ID FROM FEES_MASTER WHERE YEAR(FEE_DATE) = " + cmbYear.SelectedItem.ToString + "AND TAKEN_FOR = '" + cmbSem.SelectedItem.ToString + "')")
            LoadStudentForFee("STUDENT_MASTER")
        ElseIf cmbEType.SelectedIndex = 1 Then
            SetQuery("SELECT UNIQUE_ID FROM RESULT_MASTER WHERE SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND ATKT = " + True.ToString + " AND CURRENT_RESULT = " + True.ToString)
            LoadStudentForFee("RESULT_MASTER")
        End If

        LoadStudentFromFee()
        btnSelect2.Text = "Select All"
    End Sub
    Private Sub RemoveStudentFromFee()
        Try
            Dim index As Integer = 0
            While (index < dgv2.Rows.Count - 1)
                If dgv2.Rows(index).Cells("remove1").Value Then
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    con.Open()
                    cmd = New OleDb.OleDbCommand("DELETE FROM EXAM_FEE_MASTER WHERE EXAM_FEE_MASTER_ID = " + dgv2.Rows(index).Cells("id").Value.ToString, con)
                    SetQuery("SELECT MAX(EXAM_FEE_MASTER_ID) FROM EXAM_FEE_MASTER WHERE EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + dgv2.Rows(index).Cells("u_id").Value.ToString + "'")
                    cmd.ExecuteNonQuery()
                    UpdateCurrentResult()
                    dgv2.Rows.RemoveAt(index)
                Else
                    index += 1
                End If
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub UpdateCurrentResult()
        Try
            
            cmd = New OleDb.OleDbCommand(GetQuery, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim MAX_ID As Integer = Val(dr.Item(0).ToString)
                cmd.Dispose()
                cmd = New OleDb.OleDbCommand("UPDATE EXAM_FEE_MASTER SET CURRENT_RESULT = " + True.ToString + " WHERE EXAM_FEE_MASTER_ID = " + MAX_ID.ToString, con)
                cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Do you really want to Exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SetMode("Add")
        DisplayATKT.Close()
        AddResult.Show()
        AddResult.MarkEntry_Load(sender, e)
        AddResult.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        display.Show()
        display.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect1.Click
        If btnSelect1.Text.Equals("Select All") Then
            CheckAll(dgv1, "payment")
            btnSelect1.Text = "Deselect All"
        Else
            UnCheckAll(dgv1, "payment")
            btnSelect1.Text = "Select All"
        End If
    End Sub

    Private Sub btnSelect2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect2.Click
        If btnSelect2.Text.Equals("Select All") Then
            CheckAll(dgv2, "remove1")
            btnSelect2.Text = "Deselect All"
        Else
            UnCheckAll(dgv2, "remove1")
            btnSelect2.Text = "Select All"
        End If
    End Sub
End Class