Public Class AddResult
    Public Sub SetEnableMasterField(ByVal flag As Boolean)
        cmbYear.Enabled = flag
        cmbSem.Enabled = flag
        cmbUniqueId.Enabled = flag
        cmbEType.Enabled = flag
    End Sub
    Public Sub MarkEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GetMode.Equals("View") Then
            Button4.Visible = False
            Me.Text = "View Result"
            LoadYear(cmbYear)
            SetQuery("SELECT * FROM RESULT_MASTER WHERE RESULT_ID = " + GetResultMasterID().ToString)
            LoadResult()
            SetEnableMasterField(False)
            EnabledField(False)
            btnEdit.Enabled = False
            Button1.Enabled = True
            SetEvent(False)
            ApplyFormat()
        ElseIf GetMode.Equals("Add") Then
            Button4.Visible = True
            Me.Text = "Add Result"
            ClearAllField()
            LoadYear(cmbYear)
            SetNavigationEnabled(False)
            cmbYear.Enabled = True
            EnabledField(False)
            SetEnableMasterField(False)
            cmbYear.Enabled = True
            btnEdit.Enabled = False
            lblMode.Text = GetMode() + " Result"
            cmbYear.Focus()
        End If
        Button4.Enabled = False
        Button4.Text = "Lock"
    End Sub
    Public Sub ClearAllField()
        cmbEType.Items.Clear()
        cmbYear.Items.Clear()
        cmbSem.Items.Clear()
        cmbUniqueId.Items.Clear()
        ClearField()
        dgv1.Rows.Clear()
    End Sub
    Public Sub ViewMode()
        SetEnableMasterField(False)
        EnabledField(False)
        btnEdit.Enabled = False
    End Sub
    Public Sub SetEvent(ByVal flag As Boolean)
        eventFlag = flag
    End Sub
    Private Function isEvent() As Boolean
        Return eventFlag
    End Function
    Public Sub LoadSubject(ByVal s_id As String)
        Try
            Dim query As String = "SELECT SUB_CODE,SUB_NO, SUB_NAME  FROM SUBJECT_MASTER WHERE SEM_ID = " + s_id
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter(query, con)
            ds.Clear()
            dgv1.AllowUserToAddRows = True
            da.Fill(ds, "SUBJECT_MASTER")
            dgv1.Rows.Clear()
            dgv1.Enabled = True
            For i As Integer = 0 To ds.Tables("SUBJECT_MASTER").Rows.Count - 1
                dgv1.Rows.Add(New String() {ds.Tables("SUBJECT_MASTER")(i)(0).ToString, ds.Tables("SUBJECT_MASTER")(i)(1).ToString + " - " + ds.Tables("SUBJECT_MASTER")(i)(2).ToString, 0, 0, True})
                Cells(i, 2).Style.ForeColor = Color.Red
                Cells(i, 3).Style.ForeColor = Color.Red
                If i Mod 2 = 0 Then
                    SetLineColor(dgv1, Color.Wheat, False, i, 4, 1)
                Else
                    SetLineColor(dgv1, Color.White, False, i, 4, 1)
                End If
            Next
            dgv1.Rows.Add(New String() {"", "", "", "", False})
            dgv1.Rows(5).ReadOnly = True
            dgv1.Rows(0).Cells(2).Selected = True
            dgv1.AllowUserToAddRows = False
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ClearField()
        txtSeatNo.Clear()
        lblExtTot.Text = "000"
        lblIntTot.Text = "000"
        lblPer.Text = "000.00"
        lblResult.ForeColor = Color.Red
        lblExtTot.ForeColor = Color.Red
        lblIntTot.ForeColor = Color.Red
        lblPer.ForeColor = Color.Red
        lblResult.Text = "FAIL"
        lblFeeID.Text = "0"
        lblResultID.Text = "0"
        PictureBox1.Image = Nothing
        txtName.Clear()
        lblCountResult.Text = "0 OF 0"
        btnSave.Enabled = False
        btnEdit.Enabled = False
        btnSave.Text = "Save"
        btnEdit.Text = "Edit"
    End Sub

    Private Function AllSet() As Boolean
        If txtSeatNo.Text.Equals("") Then
            MsgBox("Please Insert Seat No..")
            txtSeatNo.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub UpdateResult()
        'Dude, Baki che haji hooo
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand("UPDATE RESULT_MASTER SET SEAT_NO = @S_NO , INT_TOT = @I_TOT, EXT_TOT = @E_TOT, PER =@P, RESULT = @R, RESULT_DATE = @R_DATE, ATKT = @A WHERE RESULT_ID = @R_ID", con)
            cmd.Parameters.AddWithValue("@S_NO", Val(txtSeatNo.Text))
            cmd.Parameters.AddWithValue("@I_TOT", Val(lblIntTot.Text))
            cmd.Parameters.AddWithValue("@E_TOT", Val(lblExtTot.Text))
            cmd.Parameters.AddWithValue("@P", Val(lblPer.Text))
            cmd.Parameters.AddWithValue("@R", lblResult.Text)
            cmd.Parameters.AddWithValue("@R_DATE", dtpRDate.Value.ToShortDateString)
            cmd.Parameters.AddWithValue("@A", CheckATKT())
            cmd.Parameters.AddWithValue("@R_ID", GetResultMasterID())
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            ' update RESULT_DETAIL table

            For i As Integer = 0 To dgv1.Rows.Count - 2
                cmd = New OleDb.OleDbCommand("UPDATE RESULT_DETAIL SET INT_MARK = @I_MARK, EXT_MARK = @E_MARK, ISATKT = @IA WHERE RESULT_ID = @R_ID AND SUB_ID = @S_ID", con)
                cmd.Parameters.AddWithValue("@I_MARK", Val(Cells(i, 2).Value))
                cmd.Parameters.AddWithValue("@E_MARK", Val(Cells(i, 3).Value))
                cmd.Parameters.AddWithValue("@IA", Val(Cells(i, 4).Value))
                cmd.Parameters.AddWithValue("@R_ID", GetResultMasterID())
                cmd.Parameters.AddWithValue("@S_ID", Val(Cells(i, 0).Value))
                cmd.ExecuteNonQuery()
            Next
            MsgBox("Record successfully updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub SaveResult()
        Try
            SetQuery("UPDATE RESULT_MASTER SET CURRENT_RESULT = " + False.ToString + " WHERE SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "'")
            SetCurrentRecord()
            
            'Save Master Record
            Dim r_m_id As Integer
            Dim r_d_id As Integer
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand("SELECT MAX(RESULT_ID) FROM RESULT_MASTER", con)
            If cmd.ExecuteScalar.ToString = "" Then
                r_m_id = 1
            Else
                r_m_id = cmd.ExecuteScalar + 1
            End If
            cmd = New OleDb.OleDbCommand("INSERT INTO RESULT_MASTER VALUES(@R_ID,@E_YEAR,@SEM_ID,@ET_ID,@U_ID,@S_NO,@INT_TOT,@EXT_TOT,@PER,@RESULT,@R_DATE,@ATKT,@COMP,@CUR,@EFID)", con)
            cmd.Parameters.AddWithValue("@R_ID", r_m_id)
            cmd.Parameters.AddWithValue("@E_YEAR", cmbYear.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@SEM_ID", cmbSem.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@ET_ID", cmbEType.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@U_ID", cmbUniqueId.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@S_NO", Val(txtSeatNo.Text))
            cmd.Parameters.AddWithValue("@INT_TOT", Val(lblIntTot.Text))
            cmd.Parameters.AddWithValue("@EXT_TOT", Val(lblExtTot.Text))
            cmd.Parameters.AddWithValue("@PER", Val(lblPer.Text))
            cmd.Parameters.AddWithValue("@RESULT", lblResult.Text)
            cmd.Parameters.AddWithValue("@R_DATE", dtpRDate.Value.ToShortDateString)
            cmd.Parameters.AddWithValue("@ATKT", CheckATKT())
            cmd.Parameters.AddWithValue("@COMP", Not CheckATKT())
            cmd.Parameters.AddWithValue("@CUR", True)
            cmd.Parameters.AddWithValue("@EFID", Val(lblFeeID.Text))
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'Save Detail Record

            For i As Integer = 0 To dgv1.Rows.Count - 2
                cmd = New OleDb.OleDbCommand("SELECT MAX(RESULT_DETAIL_ID) FROM RESULT_DETAIL", con)
                If cmd.ExecuteScalar.ToString = "" Then
                    r_d_id = 1
                Else
                    r_d_id = cmd.ExecuteScalar + 1
                End If
                cmd = New OleDb.OleDbCommand("INSERT INTO RESULT_DETAIL VALUES(@R_D_ID,@R_M_ID,@S_CODE,@I_MARK,@E_MARK,@IS_ATKT)", con)
                cmd.Parameters.AddWithValue("@R_D_ID", r_d_id)
                cmd.Parameters.AddWithValue("@R_M_ID", r_m_id)
                cmd.Parameters.AddWithValue("@S_CODE", Val(Cells(i, 0).Value))
                cmd.Parameters.AddWithValue("@I_MARK", Val(Cells(i, 2).Value))
                cmd.Parameters.AddWithValue("@E_MARK", Val(Cells(i, 3).Value))
                cmd.Parameters.AddWithValue("@IS_ATKT", Val(Cells(i, 4).Value))
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next
            UpdateExamFeeOverField(lblFeeID.Text.ToString)
            MsgBox("Record Inserted Successfully")
            If Not CheckATKT() Then
                SetQuery("UPDATE RESULT_MASTER SET COMPLETE = " + True.ToString + " WHERE SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "'")
                UpdateATKTStatus()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub UpdateExamFeeOverField(ByVal e_m_f_id As String)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand("UPDATE EXAM_FEE_MASTER SET EXAM_OVER = " + True.ToString + " WHERE EXAM_FEE_MASTER_ID = " + e_m_f_id, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "UpadateExamFeeOverField")
        End Try
    End Sub
    
    Private Sub UpdateATKTStatus()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand(GetQuery, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Function CheckATKT() As Boolean
        For i As Integer = 0 To dgv1.Rows.Count - 2
            If dgv1.Rows(i).Cells(4).Value Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function LoadResult() As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter(GetQuery(), con)
            tlb.Clear()
            da.Fill(tlb)
            da.Dispose()
            If tlb.Rows.Count = 0 Then
                Return False
            Else
                SetResultMasterID(tlb.Rows(0)("RESULT_ID"))
                lblResult.Text = tlb.Rows(0)("RESULT_ID").ToString
                txtSeatNo.Text = tlb.Rows(0)("SEAT_NO").ToString
                lblIntTot.Text = tlb.Rows(0)("INT_TOT").ToString
                lblExtTot.Text = tlb.Rows(0)("EXT_TOT").ToString
                lblPer.Text = tlb.Rows(0)("PER").ToString
                lblResult.Text = tlb.Rows(0)("RESULT").ToString
                Try
                    dtpRDate.Value = tlb.Rows(0)("RESULT_DATE")
                Catch ex As Exception

                End Try

                If GetMode.Equals("Add") Then
                    lblFeeID.Text = GetString("SELECT EXAM_FEE_MASTER_ID FROM EXAM_FEE_MASTER WHERE EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.Text.ToString + "' AND CURRENT_RESULT = " + True.ToString)
                    lblResultID.Text = tlb.Rows(0)("RESULT_ID").ToString
                ElseIf GetMode.Equals("View") Then
                    lblFeeID.Text = tlb.Rows(0)("EXAM_FEE_MASTER_ID").ToString
                    lblResultID.Text = tlb.Rows(0)("RESULT_ID").ToString
                    cmbYear.Text = tlb.Rows(0)("EXAM_YEAR").ToString
                    cmbSem.SelectedIndex = tlb.Rows(0)("SEM_ID") - 1
                    cmbEType.SelectedIndex = tlb.Rows(0)("EXAM_TYPE_ID") - 1
                    cmbUniqueId.Text = tlb.Rows(0)("UNIQUE_ID").ToString
                    lblMode.Text = GetMode() + " Result"
            End If
                SetEvent(False)
                txtName.Text = GetString("SELECT STU_NAME FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "'")
                Try
                    PictureBox1.Image = Image.FromFile(Application.StartupPath + GetString("SELECT STU_PHOTO FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "'"))
                Catch ex As Exception
                    PictureBox1.Image = Image.FromFile(Application.StartupPath + "\Images\default.jpg")
                End Try
                da = New OleDb.OleDbDataAdapter("SELECT SUB_ID, INT_MARK, EXT_MARK, ISATKT FROM RESULT_DETAIL WHERE RESULT_ID = " + GetResultMasterID.ToString + " ORDER BY SUB_ID", con)
                ds.Clear()
                da.Fill(ds, "RESULT_DETAIL")
                da.Dispose()
                dgv1.Rows.Clear()
                For i As Integer = 0 To ds.Tables("RESULT_DETAIL").Rows.Count - 1
                    Dim sub_id As Integer = Val(ds.Tables("RESULT_DETAIL")(i)(0).ToString)
                    Dim sub_name As String = GetString("SELECT SUB_NO FROM SUBJECT_MASTER WHERE SUB_CODE = " + sub_id.ToString) + " - " + GetString("SELECT SUB_NAME FROM SUBJECT_MASTER WHERE SUB_CODE = " + sub_id.ToString)
                    Dim int_mark As Integer = Val(ds.Tables("RESULT_DETAIL")(i)(1).ToString)
                    Dim ext_mark As Integer = Val(ds.Tables("RESULT_DETAIL")(i)(2).ToString)
                    Dim atkt As Boolean = ds.Tables("RESULT_DETAIL")(i)(3)
                    dgv1.Rows.Add(New String() {sub_id, sub_name, int_mark, ext_mark, atkt})
                    If i Mod 2 = 0 Then
                        SetLineColor(dgv1, Color.Wheat, False, i, 4, 1)
                    Else
                        SetLineColor(dgv1, Color.White, False, i, 4, 1)
                    End If
                Next
                dgv1.Rows.Add(New String() {"", "", "", "", False})
                dgv1.Rows(dgv1.Rows.Count - 1).ReadOnly = True
                dgv1.AllowUserToAddRows = False
            End If
            SetQuery("UPDATE EXAM_FEE_MASTER SET EXAM_OVER = " + True.ToString + " WHERE EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "' AND EXAM_TYPE_ID = " + (cmbEType.SelectedIndex + 1).ToString + "AND EXAM_YEAR = " + cmbYear.SelectedItem.ToString)
            con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Public Sub EnabledField(ByVal flag As Boolean)
        dgv1.Enabled = flag
        txtSeatNo.Enabled = flag
        dtpRDate.Enabled = flag
        btnSave.Enabled = flag
        btnEdit.Enabled = Not flag
        Button1.Enabled = flag
    End Sub
    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv1.KeyDown
        Dim r As Integer = dgv1.CurrentCell.RowIndex
        Dim c As Integer = dgv1.CurrentCell.ColumnIndex
        If e.KeyCode = Keys.Enter Then
            If r = 4 And c = 2 Then
                dgv1.Rows(0).Cells(3).Selected = True
                e.SuppressKeyPress = True
                SendKeys.Send("{UP}")
            ElseIf r = 5 And c = 3 Then
                btnSave.Focus()
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEndEdit
        If dgv1.Rows.Count = 6 And isEvent() Then
            Dim r, c As Integer
            r = dgv1.CurrentCell.RowIndex
            c = dgv1.CurrentCell.ColumnIndex
            Cells(4, 2).ReadOnly = True
            Try
                If r <> 4 Then
                    If c = 2 Then
                        If Cells(r, c).Value < 12 Then
                            SetColor(r, c, Color.Red)
                            If Not isEmpty(r, c) Then
                                SetEndValue(r, c, "/ 30")
                            End If
                        ElseIf Cells(r, c).Value >= 12 Then
                            If Cells(r, c).Value > 30 Then
                                Cells(r, c).Value = ""
                                MsgBox("Pease Enter Mark Less Then 30", MsgBoxStyle.Critical)
                            Else
                                SetColor(r, c, Color.Green)
                                If Not isEmpty(r, c) Then
                                    SetEndValue(r, c, "/ 30")
                                End If
                            End If
                        End If
                    ElseIf c = 3 Then
                        If Cells(r, c).Value < 28 Then
                            SetColor(r, c, Color.Red)
                            If Not isEmpty(r, c) Then
                                SetEndValue(r, c, "/ 70")
                            End If
                        ElseIf Cells(r, c).Value >= 28 Then
                            If Cells(r, c).Value > 70 Then
                                Cells(r, c).Value = ""
                                MsgBox("Pease Enter Mark Less Then 70", MsgBoxStyle.Critical)
                            Else
                                SetColor(r, c, Color.Green)
                                If Not isEmpty(r, c) Then
                                    SetEndValue(r, c, "/ 70")
                                End If
                            End If
                        End If
                    End If
                ElseIf r = 4 Then
                    If Cells(r, c).Value < 40 Then
                        SetColor(r, c, Color.Red)
                        If Not isEmpty(r, c) Then
                            SetEndValue(r, c, "/ 100")
                        End If
                    ElseIf Cells(r, c).Value >= 40 Then
                        If Cells(r, c).Value > 100 Then
                            Cells(r, c).Value = ""
                            MsgBox("Pease Enter Mark Less Then 100", MsgBoxStyle.Critical)
                        Else
                            SetColor(r, c, Color.Green)
                            If Not isEmpty(r, c) Then
                                SetEndValue(r, c, "/ 100")
                            End If
                        End If
                    End If
                End If
                If Cells(r, 2).Style.ForeColor = Color.Red Or Cells(r, 3).Style.ForeColor = Color.Red Or isEmpty(r, 2) Or isEmpty(r, 3) Then
                    SetATKT(r, True)
                Else
                    SetATKT(r, False)
                End If
                If Cells(4, 3).Style.ForeColor = Color.Red Then
                    SetATKT(4, True)
                Else
                    SetATKT(4, False)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Function Cells(ByVal r As Integer, ByVal c As Integer) As DataGridViewCell
        Return dgv1.Rows(r).Cells(c)
    End Function
    Private Sub SetEndValue(ByVal r As Integer, ByVal c As Integer, ByVal str As String)
        Cells(r, c).Value = Cells(r, c).Value + str
    End Sub
    Private Sub SetColor(ByVal r As Integer, ByVal c As Integer, ByVal clr As Color)
        Cells(r, c).Style.ForeColor = clr
    End Sub
    Private Sub SetATKT(ByVal r As Integer, ByVal f As Boolean)
        Cells(r, 4).Value = f
    End Sub
    Private Function isEmpty(ByVal r As Integer, ByVal c As Integer) As Boolean
        If Cells(r, c).Value.ToString.Equals("") Then
            Return True
        End If
        Return False
    End Function
    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv1.CurrentCellChanged
        If dgv1.Rows.Count = 6 And isEvent() Then
            Dim per As Double = 0D
            Dim int_tot As Integer = 0
            Dim ext_tot As Integer = 0
            Dim f1 As Boolean = True
            Dim f2 As Boolean = True

            Dim practical As Integer = Val(Cells(4, 3).Value)
            For i As Integer = 0 To 4
                int_tot += Val(Cells(i, 2).Value)
                ext_tot += Val(Cells(i, 3).Value)
            Next

            'Internal Check
            For i As Integer = 0 To 3
                If Val(dgv1.Rows(i).Cells(2).Value) < 12 Then
                    f1 = False
                    Exit For
                End If
            Next
            'External Check
            For i As Integer = 0 To 3
                If Val(dgv1.Rows(i).Cells(3).Value) < 28 Then
                    f2 = False
                    Exit For
                End If
            Next
            lblIntTot.Text = Format(int_tot, "000")
            lblExtTot.Text = Format(ext_tot, "000")
            per = ext_tot / 3.8
            If f1 And f2 And practical >= 40 Then
                lblResult.ForeColor = Color.Green
                lblExtTot.ForeColor = Color.Green
                lblIntTot.ForeColor = Color.Green
                lblPer.ForeColor = Color.Green
                If per >= 70 Then
                    lblResult.Text = "DISTINCTION"
                ElseIf per >= 60 Then
                    lblResult.Text = "FIRST CLASS"
                ElseIf per >= 50 Then
                    lblResult.Text = "SECOND CLASS"
                Else
                    lblResult.Text = "PASS"
                End If
            Else
                lblResult.ForeColor = Color.Red
                lblExtTot.ForeColor = Color.Red
                lblIntTot.ForeColor = Color.Red
                lblPer.ForeColor = Color.Red
                lblResult.Text = "FAIL"
            End If
            If per <> 0 Then
                If per.ToString.Length > 5 Then
                    lblPer.Text = Format(per, "000.00")
                Else
                    lblPer.Text = per.ToString
                End If
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MsgBox("Do you really want to Exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
    Public Sub ApplyFormat()
        For i As Integer = 0 To 3
            If Val(Cells(i, 2).Value) < 12 Then
                Cells(i, 2).Style.ForeColor = Color.Red
                Cells(i, 4).Value = True
            Else
                Cells(i, 2).Style.ForeColor = Color.Green
                Cells(i, 4).Value = False
            End If
            If Cells(i, 3).Value < 28 Then
                Cells(i, 3).Style.ForeColor = Color.Red
                Cells(i, 4).Value = True
            Else
                Cells(i, 3).Style.ForeColor = Color.Green
                Cells(i, 4).Value = False
            End If
            SetEndValue(i, 2, "/ 30")
            SetEndValue(i, 3, "/ 70")
        Next
        If Cells(4, 3).Value < 40 Then
            Cells(4, 3).Style.ForeColor = Color.Red
            Cells(4, 4).Value = True
        Else
            Cells(4, 3).Style.ForeColor = Color.Green
            Cells(4, 4).Value = False
        End If
        SetEndValue(4, 3, "/ 100")
        If lblResult.Text.Equals("FAIL") Then
            lblResult.ForeColor = Color.Red
            lblExtTot.ForeColor = Color.Red
            lblIntTot.ForeColor = Color.Red
            lblPer.ForeColor = Color.Red
        Else
            lblResult.ForeColor = Color.Green
            lblExtTot.ForeColor = Color.Green
            lblIntTot.ForeColor = Color.Green
            lblPer.ForeColor = Color.Green
        End If
        lblExtTot.Text = Format(Val(lblExtTot.Text), "000")
        lblIntTot.Text = Format(Val(lblIntTot.Text), "000")
        lblPer.Text = Format(Val(lblPer.Text), "000.00")
        Cells(4, 2).Value = ""
        Cells(4, 2).Style.BackColor = Color.BurlyWood
    End Sub
    Public Sub ApplyATKTFormat()
        For i As Integer = 0 To 3
            If Cells(i, 2).Value < 12 Then
                Cells(i, 2).Style.ForeColor = Color.Red
                Cells(i, 4).Value = True
            Else
                Cells(i, 2).Style.ForeColor = Color.Green
                Cells(i, 4).Value = False
                Cells(i, 2).ReadOnly = True
            End If
            If Cells(i, 3).Value < 28 Then
                Cells(i, 3).Style.ForeColor = Color.Red
                Cells(i, 4).Value = True
            Else
                Cells(i, 3).Style.ForeColor = Color.Green
                Cells(i, 3).ReadOnly = True
                Cells(i, 4).Value = False
            End If
            SetEndValue(i, 2, "/ 30")
            SetEndValue(i, 3, "/ 70")
        Next
        If Cells(4, 3).Value < 40 Then
            Cells(4, 3).Style.ForeColor = Color.Red
            Cells(4, 4).Value = True
        Else
            Cells(4, 3).Style.ForeColor = Color.Green
            Cells(4, 3).ReadOnly = True
            Cells(4, 4).Value = False
        End If
        SetEndValue(4, 3, "/ 100")
        If lblResult.Text.Equals("FAIL") Then
            lblResult.ForeColor = Color.Red
            lblExtTot.ForeColor = Color.Red
            lblIntTot.ForeColor = Color.Red
            lblPer.ForeColor = Color.Red
        Else
            lblResult.ForeColor = Color.Green
            lblExtTot.ForeColor = Color.Green
            lblIntTot.ForeColor = Color.Green
            lblPer.ForeColor = Color.Green
        End If
        lblExtTot.Text = Format(Val(lblExtTot.Text), "000")
        lblIntTot.Text = Format(Val(lblIntTot.Text), "000")
        lblPer.Text = Format(Val(lblPer.Text), "000.00")
        Cells(4, 2).Value = ""
        Cells(4, 2).Style.BackColor = Color.BurlyWood

        dgv1.Rows(5).ReadOnly = True
    End Sub
    Private Sub NextResult()
        Dim index As Integer = cmbUniqueId.SelectedIndex + 1
        If index = cmbUniqueId.Items.Count Then
            index = 0
        End If
        If GetMode.Equals("View") Then
            tos += 1
            If tos = COUNT_RESULT_ID() Then
                tos = 0
            End If
            SetResultMasterID(GET_RESULT_ID_BY_INDEX(tos))
            cmbUniqueId_SelectedIndexChanged_1(New Object, New System.EventArgs)
        End If
        cmbUniqueId.SelectedItem = cmbUniqueId.Items.Item(index)
        If cmbUniqueId.Items.Count = 1 Then
            EnabledField(False)
        End If
    End Sub
    Private Sub PrevResult()
        Dim index As Integer = cmbUniqueId.SelectedIndex - 1
        If index = -1 Then
            index = cmbUniqueId.Items.Count - 1
        End If
        If GetMode.Equals("View") Then
            tos -= 1
            If tos = -1 Then
                tos = COUNT_RESULT_ID() - 1
            End If
            'MsgBox(GET_RESULT_IDS() + " - Result Id : " + GET_RESULT_ID_BY_INDEX(tos) + " Index : " + tos.ToString + " , Total Result : " + cmbUniqueId.Items.Count.ToString)
            SetResultMasterID(GET_RESULT_ID_BY_INDEX(tos))
            cmbUniqueId_SelectedIndexChanged_1(New Object, New System.EventArgs)
        End If
        cmbUniqueId.SelectedItem = cmbUniqueId.Items.Item(index)
    End Sub
    Private Sub cmbSem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSem.KeyDown
        If e.KeyCode = Keys.Enter And cmbSem.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbSem.Text <> "" Then
            cmbEType.Focus()
        End If
    End Sub
    Private Sub cmbSem_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSem.SelectedIndexChanged
        cmbEType.Enabled = True
        LoadExamType(cmbEType)
        ClearField()
        dgv1.Rows.Clear()
        cmbUniqueId.Items.Clear()
        Me.Text = resetName() + " - [" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "]"
    End Sub
    Private Sub cmbYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbYear.KeyDown
        If e.KeyCode = Keys.Enter And cmbYear.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbYear.Text <> "" Then
            cmbSem.Focus()
        End If
    End Sub
    Private Sub cmbYear_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        cmbSem.Enabled = True
        LoadSem(cmbSem)
        LoadExamType(cmbEType)
        cmbUniqueId.Items.Clear()
        Me.Text = resetName() + " - [" + cmbYear.SelectedItem.ToString + "]"
    End Sub
    Private Function resetName() As String
        If GetMode.Equals("Add") Then
            Return "Add Result"
        End If
        Return "View Result"
    End Function
    Private Sub cmbUniqueId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbUniqueId.KeyDown
        If e.KeyCode = Keys.Enter And cmbUniqueId.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbUniqueId.Text <> "" Then
            txtSeatNo.Focus()
        End If
    End Sub
    Private Sub cmbUniqueId_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUniqueId.SelectedIndexChanged
        If cmbUniqueId.Items.Count > 0 Then
            If GetMode.Equals("Add") Then
                If cmbEType.SelectedIndex = 0 Then
                    SetQuery("SELECT * FROM RESULT_MASTER WHERE EXAM_YEAR = '" + cmbYear.SelectedItem.ToString + "' AND SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "' AND CURRENT_RESULT = " + True.ToString)
                    If (LoadResult()) Then
                        SetEvent(False)
                        EnabledField(False)
                        ApplyFormat()
                    Else
                        SetEvent(True)
                        txtSeatNo.Focus()
                        ClearField()
                        EnabledField(True)
                        Button1.Enabled = False
                        btnSave.Text = "Save"
                        dtpRDate.Value = Date.Now
                        txtName.Text = GetString("SELECT STU_NAME FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "'")
                        lblFeeID.Text = GetString("SELECT EXAM_FEE_MASTER_ID FROM EXAM_FEE_MASTER WHERE EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.Text.ToString + "'")
                        Try
                            PictureBox1.Image = Image.FromFile(Application.StartupPath + GetString("SELECT STU_PHOTO FROM STUDENT_MASTER WHERE UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "'"))
                        Catch ex As Exception
                            PictureBox1.Image = Image.FromFile(Application.StartupPath + "\Images\default.jpg")
                        End Try
                        LoadSubject((cmbSem.SelectedIndex + 1).ToString)
                        ApplyFormat()
                    End If
                ElseIf cmbEType.SelectedIndex = 1 Then
                    SetQuery("SELECT * FROM RESULT_MASTER WHERE  SEM_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND UNIQUE_ID = '" + cmbUniqueId.SelectedItem.ToString + "' AND CURRENT_RESULT = " + True.ToString)
                    If LoadResult() Then
                        SetQuery("SELECT COUNT(*) FROM RESULT_MASTER WHERE EXAM_FEE_MASTER_ID = " + lblFeeID.Text)
                        ApplyATKTFormat()
                        SetEvent(True)
                        If CheckResultExist() Then
                            EnabledField(False)
                        Else
                            EnabledField(True)
                        End If
                    End If
                    Button1.Enabled = False
                End If
                Button4.Enabled = True
                lblCountResult.Text = (cmbUniqueId.SelectedIndex + 1).ToString + " OF " + cmbUniqueId.Items.Count.ToString
            ElseIf GetMode.Equals("View") Then
                SetQuery("SELECT * FROM RESULT_MASTER WHERE RESULT_ID = " + GetResultMasterID().ToString)
                LoadResult()
                SetEnableMasterField(False)
                EnabledField(False)
                btnEdit.Enabled = False
                Button1.Enabled = True
                SetEvent(False)
                ApplyFormat()
                lblCountResult.Text = (tos + 1).ToString + " OF " + COUNT_RESULT_ID.ToString
            End If
            Me.Text = resetName() + " - [" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "] - [" + cmbEType.SelectedItem.ToString + "] - [" + txtName.Text + "]"

        End If
    End Sub
    Public Function CheckResultExist() As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand(GetQuery(), con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                If dr.Item(0).ToString.Equals("0") Then
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "CheckResultExist")
        End Try
        Return True
    End Function
    Private Sub txtSeatNo_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSeatNo.KeyDown
        If e.KeyCode = Keys.Enter And txtSeatNo.Text = "" Then
            e.SuppressKeyPress = True
            txtSeatNo.Focus()
        ElseIf e.KeyCode = Keys.Enter And txtSeatNo.Text <> "" Then
            dgv1.Focus()
        End If
    End Sub

    Private Sub cmbEType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbEType.KeyDown
        If e.KeyCode = Keys.Enter And cmbEType.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbEType.Text <> "" Then
            cmbUniqueId.Focus()
        End If
    End Sub

    Private Sub cmbEType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEType.SelectedIndexChanged
        If GetMode.Equals("Add") Then
            If cmbEType.SelectedIndex = 0 Then
                cmbUniqueId.Enabled = True
                SetQuery("SELECT UNIQUE_ID FROM EXAM_FEE_MASTER WHERE EXAM_YEAR = '" + cmbYear.SelectedItem.ToString + "' AND EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND EXAM_TYPE_ID = " + (cmbEType.SelectedIndex + 1).ToString + " ORDER BY UNIQUE_ID")
                LoadStudentID(cmbUniqueId, "EXAM_FEE_MASTER")
                dgv1.Rows.Clear()
                ClearField()
            ElseIf cmbEType.SelectedIndex = 1 Then
                cmbUniqueId.Enabled = True
                SetQuery("SELECT UNIQUE_ID FROM EXAM_FEE_MASTER WHERE EXAM_FEE_AMOUNT_ID = " + (cmbSem.SelectedIndex + 1).ToString + " AND EXAM_TYPE_ID = " + (cmbEType.SelectedIndex + 1).ToString + " AND CURRENT_RESULT = " + True.ToString + " AND EXAM_YEAR <= '" + cmbYear.Text + "' ORDER BY UNIQUE_ID")
                LoadStudentID(cmbUniqueId, "EXAM_FEE_MASTER")
                dgv1.Rows.Clear()
                ClearField()
            End If
        ElseIf GetMode.Equals("View") Then
            SetQuery("SELECT UNIQUE_ID FROM RESULT_MASTER WHERE RESULT_ID IN (" + GET_RESULT_IDS() + ")")
            LoadStudentID(cmbUniqueId, "RESULT_MASTER")
            cmbUniqueId.Enabled = True
        End If
        If cmbUniqueId.Items.Count > 1 Then
            SetNavigationEnabled(True)
        Else
            SetNavigationEnabled(False)
        End If
        Me.Text = resetName() + " - [" + cmbYear.SelectedItem.ToString + "] - [" + cmbSem.SelectedItem.ToString + "] - [" + cmbEType.SelectedItem.ToString + "]"
    End Sub
    Public Sub SetNavigationEnabled(ByVal flag As Boolean)
        btnNext.Enabled = flag
        btnPrev.Enabled = flag
        btnLast.Enabled = flag
        btnFirst.Enabled = flag
    End Sub
    Private Sub btnFirst_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        If GetMode.Equals("View") Then
            tos = 0
            SetResultMasterID(GET_RESULT_ID_BY_INDEX(tos))
            cmbUniqueId_SelectedIndexChanged_1(New Object, New System.EventArgs)
        End If
        cmbUniqueId.SelectedItem = cmbUniqueId.Items.Item(0)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If btnEdit.Text.Equals("Edit") Then
            EnabledField(True)
            Button1.Enabled = False
            btnEdit.Text = "Cancel"
            btnEdit.Enabled = True
            SetEvent(True)
            btnSave.Text = "Update"
        Else
            EnabledField(False)
            btnEdit.Text = "Edit"
            SetEvent(False)
            btnSave.Text = "Save"
            cmbUniqueId_SelectedIndexChanged_1(sender, e)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If AllSet() Then
            If btnSave.Text.Equals("Save") Then
                SaveResult()
                NextResult()
            ElseIf btnSave.Text.Equals("Update") Then
                UpdateResult()
                btnSave.Text = "Save"
                btnEdit.Text = "Edit"
                EnabledField(False)
            End If
        End If
    End Sub

    Private Sub btnPrev_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        PrevResult()
    End Sub

    Private Sub btnLast_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        If GetMode.Equals("View") Then
            tos = COUNT_RESULT_ID() - 1
            SetResultMasterID(GET_RESULT_ID_BY_INDEX(tos))
            cmbUniqueId_SelectedIndexChanged_1(New Object, New System.EventArgs)
        End If
        cmbUniqueId.SelectedItem = cmbUniqueId.Items.Item(cmbUniqueId.Items.Count - 1)
    End Sub
    Private Sub btnNext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        NextResult()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        display.Show()
        display.Focus()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ExamFee.Show()
        ExamFee.Focus()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        report.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text.Equals("Lock") Then
            SetEnableMasterField(False)
            Button4.Text = "Unlock"
        Else
            SetEnableMasterField(True)
            Button4.Text = "Lock"
        End If
    End Sub
End Class
