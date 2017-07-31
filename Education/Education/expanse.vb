Public Class expanse
    Dim i As Integer = 5
    Dim flag As Boolean = True
    Dim STAFFID, EXPENSESID As Integer
    Dim q2 As String = ""
    Dim query As String = "SELECT expanses_master.expanses_id, staff_master.staff_name, staff_type_master.staff_type, expanses_master.expanses_date,expanses_master.expanses_item_name,expanses_master.expanses_item_price, expanses_master.expanses_item_quantity, expanses_master.expanses_amount FROM expanses_master, staff_master, staff_type_master WHERE expanses_master.staff_id=staff_master.Id AND staff_master.staff_type_id=staff_type_master.ID "

    Public Sub changecolor(ByVal s As System.Object)
        Label2.BackColor = menupnl.BackColor
        Label3.BackColor = menupnl.BackColor
        Label4.BackColor = menupnl.BackColor
        Label5.BackColor = menupnl.BackColor
        Label23.BackColor = menupnl.BackColor
        i = Val(s.Name.ToString.Substring(5))
        s.BackColor = Color.LightGreen
    End Sub
    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseHover, Label3.MouseHover, Label4.MouseHover, Label5.MouseHover, Label23.MouseHover
        sender.BackColor = Color.LightGreen
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave, Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave, Label23.MouseLeave
        If Not i = Val(sender.Name.ToString.Substring(5)) Then
            sender.BackColor = menupnl.BackColor
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        frmStaffSalary.Show()
        frmStaffSalary.Focus()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        'changecolor(sender)
        frmSalary.Show()
        frmSalary.Focus()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        ' changecolor(sender)
        staff.Show()
        staff.Focus()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        changecolor(sender)
    End Sub

    Private Sub expanse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.BackColor = Color.LightGreen
        staff.loadstaffname(expansesstaffname)
        staff.loadstaffname(expensecmbstaffname)
        expansesdate.Format = DateTimePickerFormat.Custom
        expansesdate.CustomFormat = "dd/MM/yyyy"
        loadexpansesdata(query)
    End Sub
    Private Sub loadexpansesdata(ByVal query As String)
        Dim dt As Data.DataTable
        Dim etcount As Integer
        Dim i As New Integer
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(query, con)
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                    DataGridView1.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                    DataGridView1.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                    DataGridView1.Rows(i).Cells(3).Value = Format(dt.Rows(i).Item(3), "dd-MM-yyyy")
                    DataGridView1.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                    DataGridView1.Rows(i).Cells(5).Value = Format(dt.Rows(i).Item(5), "##,##,##0.00")
                    DataGridView1.Rows(i).Cells(6).Value = Format(dt.Rows(i).Item(6), "##,##,##0.00")
                    DataGridView1.Rows(i).Cells(7).Value = Format(dt.Rows(i).Item(7), "##,##,##0.00")
                    etcount += Val(dt.Rows(i).Item(7).ToString)
                Next
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        expensesrecord.Text = DataGridView1.Rows.Count
        totalexpenses.Text = Format(etcount, "##,##,##0.00")
    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click, Button5.Click
        changecolor(sender)
        sender.backcolor = Color.LightGreen
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then frmStaffSalary.Close()
    End Sub
    Private Sub expansesstaffname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expansesstaffname.SelectedIndexChanged
        expansesstafftype.Text = staff.getstafftype(staff.getstaffmastertypeid(expansesstaffname.SelectedItem.ToString))
    End Sub
    Private Sub clearfield()
        expansesstaffname.SelectedIndex = 0
        expansesdate.Text = Date.Now
        expansesitmename.Clear()
        expansesquantity.Clear()
        expansesprice.Clear()
        expansesamount.Clear()
        expansesremark.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim STR As Integer = frmSalary.getID(expansesstaffname.SelectedItem.ToString)
        If flag Then
            Try
                con.Open()
                cmd = New OleDb.OleDbCommand("INSERT INTO EXPANSES_MASTER (STAFF_ID,EXPANSES_DATE,EXPANSES_ITEM_NAME,EXPANSES_ITEM_PRICE,EXPANSES_ITEM_QUANTITY,EXPANSES_AMOUNT,REMARK) VALUES (@SI,@ED,@EN,@EP,@EQ,@EA,@ER)", con)
                cmd.Parameters.AddWithValue("@SI", STR)
                cmd.Parameters.AddWithValue("@ED", expansesdate.Text)
                cmd.Parameters.AddWithValue("@EN", expansesitmename.Text)
                cmd.Parameters.AddWithValue("@EP", Val(expansesprice.Text))
                cmd.Parameters.AddWithValue("@EQ", Val(expansesquantity.Text))
                cmd.Parameters.AddWithValue("@EA", Val(expansesamount.Text))
                cmd.Parameters.AddWithValue("@EA", expansesremark.Text)
                cmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DATA INSERTED..")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ADDEXPANSES ERROR")
            Finally
                con.Close()
            End Try
            clearfield()
            loadexpansesdata(query)
            TabControl1.SelectedTab = TabPage3
        Else
            updaterecord()
        End If
    End Sub

    Private Sub expansesquantity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles expansesquantity.TextChanged
        If expansesquantity.Text <> "" Then
            expansesamount.Text = Val(expansesprice.Text) * Val(expansesquantity.Text)
        Else
            expansesamount.Text = expansesprice.Text
        End If
    End Sub
    Public Sub getexpansesdata(ByVal ID As Integer)
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT * FROM EXPANSES_MASTER WHERE EXPANSES_ID=" & ID, con)
            da.Fill(ds, "EXPANSES_MASTER")
            expansesdate.Text = ds.Tables("EXPANSES_MASTER")(0)(1)
            expansesitmename.Text = ds.Tables("EXPANSES_MASTER")(0)(2)
            expansesquantity.Text = ds.Tables("EXPANSES_MASTER")(0)(3)
            expansesamount.Text = ds.Tables("EXPANSES_MASTER")(0)(4)
            expansesremark.Text = ds.Tables("EXPANSES_MASTER")(0)(5)
            expansesprice.Text = ds.Tables("EXPANSES_MASTER")(0)(6)
            ds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETEXPANSES DATA ERROR")
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub updaterecord()
        STAFFID = frmSalary.getID(expansesstaffname.SelectedItem)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand("UPDATE EXPANSES_MASTER SET STAFF_ID=@STI,EXPANSES_DATE=@ED,EXPANSES_ITEM_NAME=@EN,EXPANSES_ITEM_PRICE=@EP,EXPANSES_ITEM_QUANTITY=@EQ,EXPANSES_AMOUNT=@EA,REMARK=@ER WHERE EXPANSES_ID=@SI", con)
            cmd.Parameters.AddWithValue("@STI", STAFFID)
            cmd.Parameters.AddWithValue("@ED", expansesdate.Text)
            cmd.Parameters.AddWithValue("@EN", expansesitmename.Text)
            cmd.Parameters.AddWithValue("@EP", Val(expansesprice.Text))
            cmd.Parameters.AddWithValue("@EQ", Val(expansesquantity.Text))
            cmd.Parameters.AddWithValue("@EA", Val(expansesamount.Text))
            cmd.Parameters.AddWithValue("@ER", expansesremark.Text)
            cmd.Parameters.AddWithValue("@SI", EXPENSESID)
            If cmd.ExecuteNonQuery() = 1 Then
                MsgBox("SUCESSFULLY UPDATED..")
            End If
            STAFFID = 0
            EXPENSESID = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        loadexpansesdata(query)
        flag = True
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        clearfield()
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clearfield()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedTab = TabPage3
    End Sub
    Private Sub cbxstaffname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expensecmbstaffname.SelectedIndexChanged
        If expensecmbstaffname.SelectedIndex <> 0 Then
            q2 = query + " AND staff_master.staff_name=" & "'" & expensecmbstaffname.SelectedItem.ToString & "'"
            lblstafftype.Text = staff.getstafftype(staff.getstaffmastertypeid(expensecmbstaffname.SelectedItem.ToString))
            ' If DataGridView1.Rows.Count > 0 Then fromdate.Text = DataGridView1.Rows(0).Cells(6).Value
            loadexpansesdata(q2)
        Else
            q2 = query
            fromdate.Text = Date.Now
            loadexpansesdata(query)
            lblstafftype.Text = ""
        End If
    End Sub

    Private Sub fromdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromdate.TextChanged, todate.TextChanged
        loadexpansesdata(q2 + " AND expanses_master.expanses_date between " + "#" + fromdate.Text + "#" + " AND " + "#" + todate.Text + "#")
    End Sub

    Private Sub expansesamount_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        TabControl1.SelectedTab = TabPage1
        expansesstaffname.SelectedItem = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        EXPENSESID = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString)
        getexpansesdata(EXPENSESID)
        flag = False
    End Sub

    Private Sub todate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todate.ValueChanged

    End Sub
End Class