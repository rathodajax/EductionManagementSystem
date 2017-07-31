Public Class frmExpense
    Dim i As Integer = 5
    Dim flag As Boolean = True
    Dim STAFFID, EXPENSESID As Integer
    Dim q2 As String = ""
    Dim tltMessage As New ToolTip
    Dim query As String = "SELECT expenses_master.expenses_id, staff_master.staff_name, staff_type_master.staff_type, expenses_master.expenses_date,expenses_master.expenses_item_name,expenses_master.expenses_item_price, expenses_master.expenses_item_quantity, expenses_master.expenses_amount FROM expenses_master, staff_master, staff_type_master WHERE expenses_master.staff_id=staff_master.Id AND staff_master.staff_type_id=staff_type_master.ID "
    Private Sub setMessage()
        tltMessage.ToolTipIcon = ToolTipIcon.Info
        tltMessage.BackColor = Color.Yellow
        tltMessage.ForeColor = Color.Blue
        tltMessage.Active = True
        tltMessage.InitialDelay = 1000
        tltMessage.SetToolTip(DataGridView1, "To duoble click record for show its details")
        tltMessage.SetToolTip(expensecmbstaffname, "To select name for select data")
        tltMessage.SetToolTip(fromdate, "To select starting date for search records")
        tltMessage.SetToolTip(todate, "To select end date for search records")
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter, Label3.MouseEnter, Label4.MouseEnter, Label5.MouseEnter, Label23.MouseEnter
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave, Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave, Label23.MouseLeave
        If Not i = Val(sender.Name.ToString.Substring(5)) Then
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

        frmHome.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        'changecolor(sender)
        frmSalary.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        ' changecolor(sender)
        frmStaff.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        Label23.ForeColor = Color.White
        Label23.BackColor = menupnl.BackColor
        i = 5
    End Sub

    Private Sub expanse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.MdiParent = MainForm
        Label5.BackColor = Color.LightGreen
        frmStaff.loadstaffname(expensesstaffname)
        frmStaff.loadstaffname(expensecmbstaffname)
        expensesdate.Format = DateTimePickerFormat.Custom
        expensesdate.CustomFormat = "dd/MM/yyyy"
        loadexpensesdata(query)
        setMessage()
        Label5.ForeColor = Color.Black
        expensesdate.MaxDate = Date.Today.AddHours(12)
        todate.MaxDate = Date.Today.AddHours(12)
    End Sub
    Private Sub loadexpensesdata(ByVal query As String)
        Dim dt As Data.DataTable
        Dim etcount As Integer
        Dim i As New Integer
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter(query, dbconnection)
            dt = New DataTable
            dbda.Fill(dt)
            DataGridView1.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                    DataGridView1.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                    DataGridView1.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
                    DataGridView1.Rows(i).Cells(3).Value = Format(dt.Rows(i).Item(3), "dd-MMMM-yyyy")
                    DataGridView1.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
                    DataGridView1.Rows(i).Cells(5).Value = Format(dt.Rows(i).Item(5), "##,##,##0.00")
                    DataGridView1.Rows(i).Cells(6).Value = Format(dt.Rows(i).Item(6), "##,##,##0.00")
                    DataGridView1.Rows(i).Cells(7).Value = Format(dt.Rows(i).Item(7), "##,##,##0.00")
                    etcount += Val(dt.Rows(i).Item(7).ToString)
                Next
            End If
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        expensesrecord.Text = DataGridView1.Rows.Count
        totalexpenses.Text = Format(etcount, "##,##,##0.00")
    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click, Button5.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        Label5.ForeColor = Color.White
        Label5.BackColor = menupnl.BackColor
        i = 23
        sender.backcolor = Color.LightGreen
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Label5.ForeColor = Color.Black
            Label5.BackColor = Color.LightGreen
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White
            i = 5
        End If
    End Sub
    Private Sub expensesstaffname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles expensesstaffname.SelectedIndexChanged
        expensesstafftype.Text = frmStaff.getstafftype(frmStaff.getstaffmastertypeid(expensesstaffname.SelectedItem.ToString))
    End Sub
    Private Sub clearfield()
        expensesstaffname.SelectedIndex = 0
        expensesdate.Text = Date.Today
        expensesitmename.Clear()
        expensesquantity.Clear()
        expensesprice.Clear()
        expensesamount.Clear()
        expensesremark.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim STR As Integer = frmSalary.getID(expensesstaffname.SelectedItem.ToString)
        If flag Then
            Try
                dbconnection.Open()
                dbcmd = New OleDb.OleDbCommand("INSERT INTO expenses_MASTER (STAFF_ID,expenses_DATE,expenses_ITEM_NAME,expenses_ITEM_PRICE,expenses_ITEM_QUANTITY,expenses_AMOUNT,REMARK) VALUES (@SI,@ED,@EN,@EP,@EQ,@EA,@ER)", dbconnection)
                dbcmd.Parameters.AddWithValue("@SI", STR)
                dbcmd.Parameters.AddWithValue("@ED", expensesdate.Text)
                dbcmd.Parameters.AddWithValue("@EN", expensesitmename.Text)
                dbcmd.Parameters.AddWithValue("@EP", Val(expensesprice.Text))
                dbcmd.Parameters.AddWithValue("@EQ", Val(expensesquantity.Text))
                dbcmd.Parameters.AddWithValue("@EA", Val(expensesamount.Text))
                dbcmd.Parameters.AddWithValue("@EA", expensesremark.Text)
                dbcmd.ExecuteNonQuery()
                MsgBox("SUCCESSFULLY DATA INSERTED..")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ADDexpenses ERROR")
            Finally
                dbconnection.Close()
            End Try
            clearfield()
            loadexpensesdata(query)
            TabControl1.SelectedTab = TabPage3
        Else
            updaterecord()
        End If
    End Sub

    Private Sub expensesquantity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles expensesquantity.TextChanged, expensesprice.TextChanged
        If expensesquantity.Text <> "" Then
            expensesamount.Text = Val(expensesprice.Text) * Val(expensesquantity.Text)
        Else
            expensesamount.Text = expensesprice.Text
        End If
    End Sub
    Public Sub getexpensesdata(ByVal ID As Integer)
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT * FROM expenses_MASTER WHERE expenses_ID=" & ID, dbconnection)
            dbda.Fill(dbds, "expenses_MASTER")
            expensesdate.Text = dbds.Tables("expenses_MASTER")(0)(1)
            expensesitmename.Text = dbds.Tables("expenses_MASTER")(0)(2)
            expensesquantity.Text = dbds.Tables("expenses_MASTER")(0)(3)
            expensesamount.Text = dbds.Tables("expenses_MASTER")(0)(4)
            expensesremark.Text = dbds.Tables("expenses_MASTER")(0)(5)
            expensesprice.Text = dbds.Tables("expenses_MASTER")(0)(6)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETexpenses DATA ERROR")
        Finally
            dbconnection.Close()
        End Try

    End Sub
    Private Sub updaterecord()
        STAFFID = frmSalary.getID(expensesstaffname.SelectedItem)
        Try
            dbconnection.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE expenses_MASTER SET STAFF_ID=@STI,expenses_DATE=@ED,expenses_ITEM_NAME=@EN,expenses_ITEM_PRICE=@EP,expenses_ITEM_QUANTITY=@EQ,expenses_AMOUNT=@EA,REMARK=@ER WHERE expenses_ID=@SI", dbconnection)
            dbcmd.Parameters.AddWithValue("@STI", STAFFID)
            dbcmd.Parameters.AddWithValue("@ED", expensesdate.Text)
            dbcmd.Parameters.AddWithValue("@EN", expensesitmename.Text)
            dbcmd.Parameters.AddWithValue("@EP", Val(expensesprice.Text))
            dbcmd.Parameters.AddWithValue("@EQ", Val(expensesquantity.Text))
            dbcmd.Parameters.AddWithValue("@EA", Val(expensesamount.Text))
            dbcmd.Parameters.AddWithValue("@ER", expensesremark.Text)
            dbcmd.Parameters.AddWithValue("@SI", EXPENSESID)
            If dbcmd.ExecuteNonQuery() = 1 Then
                MsgBox("SUCESSFULLY UPDATED..")
            End If
            STAFFID = 0
            EXPENSESID = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbconnection.Close()
        End Try
        loadexpensesdata(query)
        flag = True
        TabControl1.SelectedTab = TabPage3
    End Sub
    Public Sub selectstaffreport()
        TabControl1.SelectedTab = TabPage2
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
            lblstafftype.Text = frmStaff.getstafftype(frmStaff.getstaffmastertypeid(expensecmbstaffname.SelectedItem.ToString))
            ' If DataGridView1.Rows.Count > 0 Then fromdate.Text = DataGridView1.Rows(0).Cells(6).Value
            loadexpensesdata(q2)
        Else
            q2 = query
            fromdate.Text = Date.Now
            loadexpensesdata(query)
            lblstafftype.Text = ""
        End If
    End Sub

    Private Sub fromdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fromdate.TextChanged, todate.TextChanged
        loadexpensesdata(q2 + " AND expenses_master.expenses_date between " + "#" + fromdate.Text + "#" + " AND " + "#" + todate.Text + "#")
    End Sub

    Private Sub expensesamount_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        TabControl1.SelectedTab = TabPage1
        expensesstaffname.SelectedItem = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(1).Value
        EXPENSESID = (DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value.ToString)
        getexpensesdata(EXPENSESID)
        flag = False
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        TabControl1.SelectedTab = TabPage2
        CrystalReportViewer1.Refresh()
    End Sub



    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class