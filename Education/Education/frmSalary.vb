Public Class frmSalary
    Dim i As Integer = 3
    Dim tstaffsalary, tsalary, tleave, trecord1, trecord2 As Integer
    Dim flag As Boolean = True
    Dim sid As Integer
    Dim tltMessage As New ToolTip
    Dim q2 As String = ""
    Dim q1 As String = "SELECT salary_master.staff_id , Sum(salary_master.salary_amount) AS SumOfsalary_amount FROM salary_master GROUP BY salary_master.staff_id"
    Dim query As String = "SELECT salary_master.salary_id, staff_master.staff_name, staff_type_master.staff_type, salary_master.salary_amount, salary_master.salary_date, salary_master.salary_leave_amount, staff_master.staff_joining_date FROM salary_master, staff_master, staff_type_master WHERE salary_master.staff_id=staff_master.Id AND staff_master.staff_type_id=staff_type_master.ID "
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.MouseEnter, lbl3.MouseEnter, lbl2.MouseEnter, lbl4.MouseEnter, lbl5.MouseEnter
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.MouseLeave, lbl3.MouseLeave, lbl2.MouseLeave, lbl4.MouseLeave, lbl5.MouseLeave
        If Not i = Val(sender.Name.ToString.Substring(3)) Then
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White
        End If
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.MdiParent = MainForm
        lbl3.BackColor = Color.LightGreen
        lbl3.ForeColor = Color.Black
        frmStaff.loadstaffname(cmbStaffName)
        frmStaff.loadstaffname(cmbStaffNameSearch)
        addsalarydate.Format = DateTimePickerFormat.Custom
        loadstaffsalarydata()
        loadstaffsalarydata(query)
        cmbStaffNameSearch.SelectedIndex = 0
        tltMessage.AutomaticDelay = 500
        tltMessage.AutoPopDelay = 5000
        tltMessage.ShowAlways = True
        addsalarydate.MaxDate = Date.Today.AddHours(12)
        dtpToDate.MaxDate = Date.Today.AddHours(12)
        setMessage()
        dgvStaffTotalSalary.BringToFront()
        lbltotalleave.Visible = False
        lblTotalSalaryLeave.Visible = False
        btnTotalSalary.Text = "Staff Salary"
    End Sub
    Private Sub setMessage()
        tltMessage.ToolTipIcon = ToolTipIcon.Info
        tltMessage.BackColor = Color.Yellow
        tltMessage.ForeColor = Color.Blue
        tltMessage.Active = True
        tltMessage.InitialDelay = 1000
        tltMessage.SetToolTip(dgvStaffTotalSalary, " To select record for show its details")
        tltMessage.SetToolTip(dgvStaffSalary, "To duoble click record for show its details")
        tltMessage.SetToolTip(cmbStaffNameSearch, "To select name for select data")
        tltMessage.SetToolTip(dtpFromDate, "To select starting date for search records")
        tltMessage.SetToolTip(dtpToDate, "To select end date for search records")
    End Sub
    Private Function getstaffname(ByVal id As Integer) As String
        Dim t As String = ""
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT STAFF_NAME FROM STAFF_MASTER WHERE ID=" & id, dbconnection)
            dbda.Fill(dbds, "STAFF_MASTER")
            t = dbds.Tables("STAFF_MASTER")(0)(0)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GET STAFF NAME ERROR from salary")
        Finally
            dbconnection.Close()
        End Try
        Return t
    End Function
    Private Sub loadstaffsalarydata()
        Dim dt As Data.DataTable
        Dim i As New Integer
        tsalary = 0
        tleave = 0
        trecord1 = 0
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter(q1, dbconnection)
            dt = New DataTable
            dbda.Fill(dt)
            dbconnection.Close()
            dgvStaffTotalSalary.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dgvStaffTotalSalary.Rows.Add()
                    dgvStaffTotalSalary.Rows(i).Cells(0).Value = getstaffname(dt.Rows(i).Item(0).ToString)
                    dgvStaffTotalSalary.Rows(i).Cells(1).Value = frmStaff.getstafftype(frmStaff.getstaffmastertypeid(dgvStaffTotalSalary.Rows(i).Cells(0).Value))
                    dgvStaffTotalSalary.Rows(i).Cells(2).Value = Format(dt.Rows(i).Item(1), "##,##,##0.00")
                    tsalary += Val(dt.Rows(i).Item(1).ToString)
                Next
            End If

            ' con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lbltotalleave.Visible = False
        lblTotalSalaryLeave.Visible = False
        trecord2 = dgvStaffTotalSalary.Rows.Count
        setbuttomlabel(tsalary, 0, trecord2)
    End Sub
    Private Sub setbuttomlabel(ByVal tsalary As Integer, ByVal tleave As Integer, ByVal rcount As Integer)
        lblTotalSalaryRecord.Text = rcount.ToString
        lblTotalSalary.Text = Format(tsalary, "##,###.00")
        lblTotalSalaryLeave.Text = Format(tleave, "##,###.00")
    End Sub
    Private Sub loadstaffsalarydata(ByVal query As String)
        Dim dt As Data.DataTable
        Dim i As New Integer
        ' DataGridView1.Update()
        tstaffsalary = 0
        tleave = 0
        trecord1 = 0
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter(query, dbconnection)
            dt = New DataTable
            dbda.Fill(dt)
            dgvStaffSalary.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    dgvStaffSalary.Rows.Add()
                    dgvStaffSalary.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                    dgvStaffSalary.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                    dgvStaffSalary.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                    dgvStaffSalary.Rows(i).Cells(3).Value = Format(dt.Rows(i).Item(3), "##,##0.00")
                    tstaffsalary += Val(dt.Rows(i).Item(3).ToString)
                    dgvStaffSalary.Rows(i).Cells(4).Value = Format(dt.Rows(i).Item(4), "dd-MMMM-yyyy")
                    dgvStaffSalary.Rows(i).Cells(5).Value = Format(dt.Rows(i).Item(5), "##,##0.00")
                    tleave += Val(dt.Rows(i).Item(5).ToString)
                    dgvStaffSalary.Rows(i).Cells(6).Value = dt.Rows(i).Item(6).ToString
                Next
            End If

            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Load staff salary data (with parameter) from salary")
        End Try
        lbltotalleave.Visible = True
        lblTotalSalaryLeave.Visible = True
        trecord1 = dgvStaffSalary.Rows.Count
        setbuttomlabel(tstaffsalary, tleave, trecord1)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl1.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl2.Click
        frmStaff.Show()
        Me.Close()
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl4.Click
        frmExpense.Show()
        Me.Close()
    End Sub
    Private Sub fieldclear()
        addsalarydate.Text = Date.Today.AddHours(10)
        leaveamount.Clear()
        salaryamount.Clear()
        flag = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStaffName.SelectedIndexChanged
        fieldclear()
        cmbAddSalaryStaffType.Text = frmStaff.getstafftype(frmStaff.getstaffmastertypeid(cmbStaffName.SelectedItem.ToString))
        If flag Then getstafffixsalary(cmbStaffName.SelectedItem.ToString)
    End Sub
    Public Sub getstafffixsalary(ByVal Name As String)
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT STAFF_FIX_SALARY FROM STAFF_MASTER WHERE STAFF_NAME=" & "'" & Name & "'", dbconnection)
            dbda.Fill(dbds, "STAFF_MASTER")
            fixsalary.Text = dbds.Tables("STAFF_MASTER")(0)(0)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GET STAFFFIX SALARY ERROR (salary)")
        Finally
            dbconnection.Close()
        End Try
    End Sub
    Public Function getID(ByVal Name As String) As Integer
        Dim t As Integer
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT ID FROM STAFF_MASTER WHERE STAFF_NAME=" & "'" & Name & "'", dbconnection)
            dbda.Fill(dbds, "STAFF_MASTER")
            t = dbds.Tables("STAFF_MASTER")(0)(0)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETID ERROR (salary)")
        Finally
            dbconnection.Close()
        End Try
        Return t
    End Function
    Private Sub addsalary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addsalary.Click
        Dim staffname = cmbStaffName.SelectedItem
        Dim STR As Integer = getID(staffname)
        Dim leave As Integer = Val(leaveamount.Text)
        Dim d As Date = (addsalarydate.Text)
        If (leave >= 0 And leave <= Val(fixsalary.Text) And salaryamount.Text.Length > 0) Then
            If flag Then
                If isRecordInserted(STR, d) Then
                    Try
                        dbconnection.Open()
                        dbcmd = New OleDb.OleDbCommand("INSERT INTO SALARY_MASTER (STAFF_ID,SALARY_DATE,SALARY_AMOUNT,SALARY_LEAVE_AMOUNT) VALUES (@SI,@SD,@SA,@SS)", dbconnection)
                        dbcmd.Parameters.AddWithValue("@SI", STR)
                        dbcmd.Parameters.AddWithValue("@SD", addsalarydate.Text)
                        dbcmd.Parameters.AddWithValue("@SA", Val(salaryamount.Text))
                        dbcmd.Parameters.AddWithValue("@SS", Val(leaveamount.Text))
                        dbcmd.ExecuteNonQuery()
                        MsgBox("SUCCESSFULLY DATA INSERTED..")
                        'fieldclear()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ADDSALARY ERROR (salary)")
                    Finally
                        dbconnection.Close()
                    End Try
                Else
                    MsgBox("Enter proper date")
                    tltMessage.SetToolTip(addsalarydate, "Enter proper date")
                    Exit Sub
                End If
            Else

                updatesalary(sid)

            End If
            cmbStaffNameSearch.SelectedIndex = 0
            cmbStaffNameSearch.SelectedItem = cmbStaffName.SelectedItem
            ' dgvStaffSalary.Refresh()
            ' dgvStaffSalary.BringToFront()
            fieldclear()
        'loadstaffsalarydata(query)
        ' loadstaffsalarydata()
        tbcSalary.SelectedTab = TabPage2
        Else
        MsgBox("Enter proper leave amount")
        End If

    End Sub
    Private Sub leaveamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles leaveamount.TextChanged
        If Val(leaveamount.Text) >= 0 Then
            salaryamount.Text = (Val(fixsalary.Text) - Val(leaveamount.Text)).ToString
        Else
            salaryamount.Text = fixsalary.Text
        End If
    End Sub


    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        fieldclear()
    End Sub

    Private Sub updatesalary(ByVal sid As Integer)
        Try
            dbconnection.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE SALARY_MASTER SET SALARY_DATE=@ST,SALARY_AMOUNT=@SA,SALARY_LEAVE_AMOUNT=@SL WHERE SALARY_ID=@SI", dbconnection)
            dbcmd.Parameters.AddWithValue("@ST", addsalarydate.Text)
            '  dbcmd.Parameters.AddWithValue("@SM", M)
            dbcmd.Parameters.AddWithValue("@SA", Val(salaryamount.Text))
            dbcmd.Parameters.AddWithValue("@SL", Val(leaveamount.Text))
            dbcmd.Parameters.AddWithValue("@SI", sid)
            If dbcmd.ExecuteNonQuery() = 1 Then
                MsgBox("SUCESSFULLY UPDATED..")
                flag = True
            End If
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Update staff salary data from salary")
        Finally
            dbconnection.Close()
        End Try
        ' fieldclear()
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl5.Click, btnCancel.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        lbl3.ForeColor = Color.White
        lbl3.BackColor = menupnl.BackColor
        i = 5
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            lbl3.ForeColor = Color.Black
            lbl3.BackColor = Color.LightGreen
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White
            i = 3
        End If
    End Sub
    Public Sub selectstaffreport()
        tbcSalary.SelectedTab = TabPage3
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStaffNameSearch.SelectedIndexChanged
        If cmbStaffNameSearch.SelectedIndex <> 0 Then
            q2 = query + " AND staff_master.staff_name=" & "'" & cmbStaffNameSearch.SelectedItem.ToString & "'"
            lblStaffType.Text = frmStaff.getstafftype(frmStaff.getstaffmastertypeid(cmbStaffNameSearch.SelectedItem.ToString))
            If dgvStaffSalary.Rows.Count <> 0 Then
                dtpFromDate.MinDate = dgvStaffSalary.Rows(0).Cells(6).Value
                dtpFromDate.Text = dtpFromDate.MinDate.AddHours(10)
            End If
            loadstaffsalarydata(q2)
        Else
            q2 = query
            dtpFromDate.MinDate = "01-January-1980"
            dtpFromDate.Text = dtpFromDate.MinDate
            loadstaffsalarydata(query)
            lblStaffType.Text = ""
        End If

        dtpToDate.MaxDate = Date.Today.AddHours(12)
        dgvStaffSalary.BringToFront()
        setbuttomlabel(tstaffsalary, tleave, trecord1)
    End Sub
    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvStaffSalary.MouseDoubleClick
        Try
            tbcSalary.SelectedTab = TabPage1
            cmbStaffName.SelectedItem = dgvStaffSalary.Rows(dgvStaffSalary.CurrentCell.RowIndex).Cells(1).Value
            addsalarydate.Text = dgvStaffSalary.Rows(dgvStaffSalary.CurrentCell.RowIndex).Cells(4).Value
            leaveamount.Text = dgvStaffSalary.Rows(dgvStaffSalary.CurrentCell.RowIndex).Cells(5).Value
            sid = dgvStaffSalary.Rows(dgvStaffSalary.CurrentCell.RowIndex).Cells(0).Value
            ' MsgBox(Format(dgvStaffSalary.Rows(dgvStaffSalary.CurrentCell.RowIndex).Cells(3).Value), "#####") ' + Val(Format(dgvStaffSalary.Rows(dgvStaffSalary.CurrentCell.RowIndex).Cells(3).Value), ""))
            flag = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvStaffTotalSalary.CellMouseClick
        cmbStaffNameSearch.SelectedItem = dgvStaffTotalSalary.Rows(dgvStaffTotalSalary.CurrentCell.RowIndex).Cells(0).Value
        btnTotalSalary.Text = "Staff Total Salary"
    End Sub
    Private Sub fromdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFromDate.TextChanged, dtpToDate.TextChanged

        loadstaffsalarydata(q2 + " AND salary_master.salary_date between #" + dtpFromDate.Text + "# AND #" + dtpToDate.Text + "#")
        dgvStaffSalary.BringToFront()
        setbuttomlabel(tstaffsalary, tleave, trecord1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSalary.Click
        tbcSalary.SelectedTab = TabPage1
        fieldclear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalSalary.Click
        If btnTotalSalary.Text.Equals("Staff Total Salary") Then
            loadstaffsalarydata()
            dgvStaffTotalSalary.BringToFront()
            setbuttomlabel(tsalary, 0, trecord2)
            lbltotalleave.Visible = False
            lblTotalSalaryLeave.Visible = False
            btnTotalSalary.Text = "Staff Salary"
        Else
            dgvStaffSalary.BringToFront()
            btnTotalSalary.Text = "Staff Total Salary"
            setbuttomlabel(tstaffsalary, tleave, trecord1)
            lbltotalleave.Visible = True
            lblTotalSalaryLeave.Visible = True
        End If
    End Sub
    Private Function isRecordInserted(ByVal id As Integer, ByVal salarydate As Date) As Boolean
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT SALARY_DATE FROM SALARY_MASTER WHERE STAFF_ID=" & id, dbconnection)
            dbda.Fill(dbds, "SALARY_MASTER")
            For i As Integer = 0 To dbds.Tables("SALARY_MASTER").Rows.Count - 1
                Dim D As Date = dbds.Tables("SALARY_MASTER")(i)(0)
                If salarydate.Month = D.Month And salarydate.Year = D.Year Then Return False
            Next
            dbds.Tables.Clear()
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconnection.Close()
        End Try
        Return True
    End Function

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        tbcSalary.SelectedTab = TabPage3
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub tbcSalary_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcSalary.TabIndexChanged
        dgvStaffSalary.Refresh()
        dgvStaffTotalSalary.Refresh()
    End Sub

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl3.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        lbl5.ForeColor = Color.White
        lbl5.BackColor = menupnl.BackColor
        i = 3
    End Sub
End Class