Public Class frmStaff
    Dim i As Integer = 4
    Dim tltmessage As New ToolTip
    Dim query As String = "SELECT staff_master.staff_name, staff_type_master.staff_type, staff_master.staff_contact, staff_master.staff_joining_date FROM staff_master, staff_type_master where staff_master.staff_type_id=staff_type_master.ID"
    Private Sub setMessage()
        tltMessage.ToolTipIcon = ToolTipIcon.Info
        tltMessage.BackColor = Color.Yellow
        tltMessage.ForeColor = Color.Blue
        tltMessage.Active = True
        tltMessage.InitialDelay = 1000
        tltmessage.SetToolTip(DataGridView2, " To Double click on record for show its details")
        tltmessage.SetToolTip(DataGridView1, " To Double click on record for show its details")
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
        frmSalary.Show()
        Me.Close()
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        frmExpense.Show()
        Me.Close()
    End Sub
    Public Sub selectstaffdetail()
        TabControl1.SelectedTab = TabPage2
    End Sub
    Public Sub selectstaffreport()
        TabControl1.SelectedTab = TabPage5
    End Sub


    Private Sub staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain
        Label4.BackColor = Color.LightGreen
        Label4.ForeColor = Color.Black
        addstafftype.SelectedIndex = 0
        addupdatestafftype.SelectedIndex = 0
        loadstafftype(addstafftype)
        loadstafftype(cmbshowstaff)
        loadstafftype(addupdatestafftype)
        loadstaffname(addupdatestaffname)
        addupdatestaffname.SelectedIndex = 0
        addstaffjoingdate.MaxDate = Date.Now.AddDays(1)
        addstaffjoingdate.Text = Date.Now
        addstaffjoingdate.Format = DateTimePickerFormat.Custom
        addstaffjoingdate.CustomFormat = "dd/MM/yyyy"
        loadstaffdata(query)
        loadstafftypedata()
        selectstaffdetail()
        setMessage()
    End Sub

    Private Sub loadstaffdata(ByVal query As String)
        Dim dbds As New DataSet()
        DataGridView1.Update()
        Try

            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter(query, dbconnection)
            dbda.Fill(dbds, "staff_master")
            DataGridView1.DataSource = dbds
            DataGridView1.DataMember = "staff_master"
            dbconnection.Close()
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        staffcount.Text = DataGridView1.Rows.Count
    End Sub


    Private Sub loadstafftypedata()
        Dim dt As Data.DataTable
        Dim i As Integer
        DataGridView2.Update()
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("select * from staff_type_master", dbconnection)
            dt = New DataTable
            dbda.Fill(dt)
            'DataGridView2.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView2.Rows.Add()
                    DataGridView2.Rows(i).Cells(0).Value = dt.Rows(i).Item(1).ToString
                    DataGridView2.Rows(i).Cells(1).Value = dt.Rows(i).Item(2).ToString

                Next
            End If
            dbconnection.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click, updatestafftypecancel.Click, updatestaffcancel.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        Label4.ForeColor = Color.White
        Label4.BackColor = menupnl.BackColor
        i = 23
        sender.backcolor = Color.LightGreen
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then
            Me.Close()
        Else
            Label4.ForeColor = Color.Black
            Label4.BackColor = Color.LightGreen
            sender.BackColor = menupnl.BackColor
            sender.ForeColor = Color.White
            i = 4
        End If

    End Sub
    Public Sub loadstafftype(ByVal t As System.Object)
        t.Items.Clear()
        If t.Name.Equals("addupdatestafftype") Then
            t.Items.Add("Select staff type for update data")
        ElseIf t.Name.Equals("cmbshowstaff") Then
            t.Items.Add("Select all staff type")
        Else
            't.Items.Add("Select staff type")
        End If
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT STAFF_TYPE FROM STAFF_TYPE_MASTER", dbconnection)
            dbda.Fill(dbds, "STAFF_TYPE_MASTER")
            For i As Integer = 0 To dbds.Tables("STAFF_TYPE_MASTER").Rows.Count - 1
                t.Items.Add(dbds.Tables("STAFF_TYPE_MASTER")(i)(0))
            Next
            dbds.Tables.Clear()
            dbconnection.Close()
            t.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error Message")
        Finally
            dbconnection.Close()
        End Try
    End Sub
    Public Sub loadstaffname(ByVal t As System.Object)
        t.Items.Clear()
        If t.Name.Equals("addupdatestaffname") Then t.Items.Add("Select staff name for update data")
        If t.Name.Equals("cmbStaffNameSearch") Or t.Name.Equals("expensecmbstaffname") Then t.Items.Add("Show all staff data")
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT STAFF_NAME FROM STAFF_MASTER", dbconnection)
            dbda.Fill(dbds, "STAFF_MASTER")
            For i As Integer = 0 To dbds.Tables("STAFF_MASTER").Rows.Count - 1
                t.Items.Add(dbds.Tables("STAFF_MASTER")(i)(0))
            Next
            dbds.Tables.Clear()
            dbconnection.Close()
            t.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Load staffname Error Message")
        Finally
            dbconnection.Close()
        End Try
    End Sub
    Private Sub addstafftypesubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstafftypesubmit.Click
        If addstafftypetype.Text.Length > 0 Then
            If addupdatestafftype.SelectedIndex = 0 Then
                Try
                    dbconnection.Open()
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO STAFF_TYPE_MASTER (STAFF_TYPE,REMARK) VALUES (@ST,@SR)", dbconnection)
                    dbcmd.Parameters.AddWithValue("@ST", addstafftypetype.Text)
                    dbcmd.Parameters.AddWithValue("@SR", addstafftyperemark.Text)
                    dbcmd.ExecuteNonQuery()
                    addstafftypetype.Clear()
                    dbconnection.Close()
                    addstafftypetype.Clear()
                    addstafftyperemark.Clear()
                    loadstafftype(addupdatestafftype)
                    loadstafftype(addstafftype)
                    MsgBox("succefully data inserted ")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    dbconnection.Close()
                End Try
            Else
                Try
                    dbconnection.Open()
                    dbcmd = New OleDb.OleDbCommand("UPDATE STAFF_TYPE_MASTER SET STAFF_TYPE=@ST,REMARK=@SR WHERE STAFF_TYPE=@SST", dbconnection)
                    dbcmd.Parameters.AddWithValue("@ST", addstafftypetype.Text)
                    dbcmd.Parameters.AddWithValue("@SR", addstafftyperemark.Text)
                    dbcmd.Parameters.AddWithValue("@SST", addupdatestafftype.SelectedItem.ToString)
                    dbcmd.ExecuteNonQuery()
                    addstafftypetype.Clear()
                    dbconnection.Close()
                    addstafftypetype.Clear()
                    addstafftyperemark.Clear()
                    addupdatestafftype.SelectedIndex = 0
                    loadstafftype(addupdatestafftype)
                    loadstafftype(addupdatestafftype)
                    loadstafftype(addstafftype)
                    MsgBox("succefully data UPDATED ")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    dbconnection.Close()
                End Try

            End If
            loadstafftypedata()
            TabControl1.SelectedTab = TabPage4
        Else
            addstafftypetype.Focus()
        End If
    End Sub

    Private Sub addstafftypeclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstafftypeclear.Click
        addstafftypetype.Clear()
        addstafftyperemark.Clear()
        addupdatestafftype.SelectedIndex = 0
    End Sub
    Public Function getstaffmastertypeid(ByVal name As String) As Integer
        Dim t As Integer
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT STAFF_TYPE_ID FROM STAFF_MASTER WHERE STAFF_NAME=" & "'" & name & "'", dbconnection)
            dbda.Fill(dbds, "STAFF_MASTER")
            t = dbds.Tables("STAFF_MASTER")(0)(0)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETSTAFFTYPE ERROR")
        Finally
            dbconnection.Close()
        End Try
        Return t
    End Function
    Public Function getstafftype(ByVal id As Integer) As String
        Dim t As String = ""
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT STAFF_TYPE FROM STAFF_TYPE_MASTER WHERE ID=" & id, dbconnection)
            dbda.Fill(dbds, "STAFF_TYPE_MASTER")
            t = dbds.Tables("STAFF_TYPE_MASTER")(0)(0)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETSTAFFID  ERROR")
        Finally
            dbconnection.Close()
        End Try
        Return t
    End Function
    Public Function getstafftypeid(ByVal id As String) As Integer
        Dim t As Integer
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter("SELECT ID FROM STAFF_TYPE_MASTER WHERE STAFF_TYPE=" & "'" & id & "'", dbconnection)
            dbda.Fill(dbds, "STAFF_TYPE_MASTER")
            t = dbds.Tables("STAFF_TYPE_MASTER")(0)(0)
            dbds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETSTAFFID  ERROR")
        Finally
            dbconnection.Close()
        End Try
        Return t
    End Function

    Private Sub addstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstaff.Click
        If addstafffirstname.Text.Length > 0 And addstaffmiddlename.Text.Length > 0 And addstafflastname.Text.Length > 0 And addstaffcontact.Text.Length = 10 And addstaffemailid.Text.Length > 0 And addstafffixsalary.Text.Length > 0 Then
            Dim t As Integer = getstafftypeid(addstafftype.SelectedItem.ToString)
            Dim FNAME As String = addstafffirstname.Text & " " & addstaffmiddlename.Text & " " & addstafflastname.Text
            If addupdatestaffname.SelectedIndex = 0 Then
                ' MsgBox(t)
                Try
                    dbconnection.Open()
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO STAFF_MASTER (STAFF_TYPE_ID,STAFF_NAME,STAFF_CONTACT,STAFF_JOINING_DATE,STAFF_FIX_SALARY,STAFF_REMARK,STAFF_ADDRESS,STAFF_MAIL_ID) VALUES (@SI,@SN,@SC,@SJ,@SF,@SR,@SA,@SM)", dbconnection)
                    dbcmd.Parameters.AddWithValue("@SI", t)
                    dbcmd.Parameters.AddWithValue("@SN", FNAME)
                    dbcmd.Parameters.AddWithValue("@SC", addstaffcontact.Text)
                    dbcmd.Parameters.AddWithValue("@SJ", addstaffjoingdate.Text)
                    dbcmd.Parameters.AddWithValue("@SF", addstafffixsalary.Text)
                    dbcmd.Parameters.AddWithValue("@SR", addstaffremark.Text)
                    dbcmd.Parameters.AddWithValue("@SA", addstaffaddress.Text)
                    dbcmd.Parameters.AddWithValue("@SM", addstaffemailid.Text)
                    dbcmd.ExecuteNonQuery()
                    MsgBox("SUCCESSFULLY DATA INSERTED..")
                    CLEAR()
                    dbconnection.Close()
                    loadstaffname(addupdatestaffname)
                    loadstaffname(frmSalary.cmbStaffName)
                    loadstaffname(frmSalary.cmbStaffNameSearch)
                    loadstaffname(frmExpense.expensecmbstaffname)
                    loadstaffname(frmExpense.expensesstaffname)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ADD STAFF ERROR")
                Finally
                    dbconnection.Close()
                End Try
            Else
                Try
                    dbconnection.Open()
                    dbcmd = New OleDb.OleDbCommand("UPDATE STAFF_MASTER SET STAFF_TYPE_ID=@SI,STAFF_NAME=@SNN,STAFF_CONTACT=@SC,STAFF_JOINING_DATE=@SJ,STAFF_FIX_SALARY=@SFS,STAFF_REMARK=@SR,STAFF_ADDRESS=@SA,STAFF_MAIL_ID=@SM WHERE STAFF_NAME=@SN", dbconnection)
                    dbcmd.Parameters.AddWithValue("@SI", t)
                    dbcmd.Parameters.AddWithValue("@SNN", FNAME)
                    dbcmd.Parameters.AddWithValue("@SC", Val(addstaffcontact.Text))
                    dbcmd.Parameters.AddWithValue("@SJ", addstaffjoingdate.Text)
                    dbcmd.Parameters.AddWithValue("@SFS", Val(addstafffixsalary.Text))
                    dbcmd.Parameters.AddWithValue("@SR", addstaffremark.Text)
                    dbcmd.Parameters.AddWithValue("@SA", addstaffaddress.Text)
                    dbcmd.Parameters.AddWithValue("@SM", addstaffemailid.Text)
                    dbcmd.Parameters.AddWithValue("@SN", addupdatestaffname.SelectedItem.ToString)
                    If dbcmd.ExecuteNonQuery() = 1 Then
                        MsgBox("SUCESSFULLY UPDATED..")
                    End If
                    CLEAR()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "UPDATE STAFF ERROR")
                Finally
                    dbconnection.Close()
                End Try

            End If
            loadstaffname(addupdatestaffname)
            loadstaffname(frmSalary.cmbStaffName)
            loadstaffname(frmSalary.cmbStaffNameSearch)
            loadstaffname(frmExpense.expensecmbstaffname)
            loadstaffname(frmExpense.expensesstaffname)
            loadstaffdata(query)
            TabControl1.SelectedTab = TabPage2
        Else
            MsgBox("Enter proper data ")
        End If
    End Sub
    Private Sub CLEAR()
        addstafftype.SelectedIndex = 0
        addstaffjoingdate.Text = Date.Now
        addstafffirstname.Clear()
        addstaffmiddlename.Clear()
        addstafflastname.Clear()
        addstaffcontact.Clear()
        addstaffaddress.Clear()
        addstaffremark.Clear()
        addstaffemailid.Clear()
        addstafffixsalary.Clear()
        addupdatestaffname.SelectedIndex = 0
        lockfield(True)
    End Sub
    Private Sub lockfield(ByVal setvalue As Boolean)
        addstafftype.Enabled = setvalue
        addstaffjoingdate.Enabled = setvalue
        addstafffirstname.Enabled = setvalue
        addstaffmiddlename.Enabled = setvalue
        addstafflastname.Enabled = setvalue
        addstaffcontact.Enabled = setvalue
        addstaffaddress.Enabled = setvalue
        addstaffremark.Enabled = setvalue
        addstaffemailid.Enabled = setvalue
        addstafffixsalary.Enabled = setvalue
    End Sub

    Private Sub addstaffclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstaffclear.Click
        CLEAR()
    End Sub
    Private Sub getstaffdata(ByVal str As String)
        Dim A As Integer = getstaffmastertypeid(str)
        Dim type As Object = getstafftype(A)
        Dim name(), FNAME As String
        Dim QUERY2 As String = "SELECT * FROM STAFF_MASTER WHERE STAFF_NAME=" & "'" & str & "'"
        Dim s As Object = str
        Try
            dbconnection.Open()
            dbda = New OleDb.OleDbDataAdapter(QUERY2, dbconnection)
            dbda.Fill(dbds, "STAFF_MASTER")
            addupdatestaffname.SelectedItem = s
            addstafftype.SelectedItem = type
            FNAME = dbds.Tables("STAFF_MASTER")(0)(1)
            name = FNAME.Split(" ")
            addstafffirstname.Text = name(0)
            addstaffmiddlename.Text = name(1)
            addstafflastname.Text = name(2)
            addstaffcontact.Text = dbds.Tables("STAFF_MASTER")(0)(2)
            addstaffjoingdate.Text = dbds.Tables("STAFF_MASTER")(0)(3)
            addstafffixsalary.Text = dbds.Tables("STAFF_MASTER")(0)(4)
            addstaffremark.Text = dbds.Tables("STAFF_MASTER")(0)(5)
            addstaffaddress.Text = dbds.Tables("STAFF_MASTER")(0)(6)
            addstaffemailid.Text = dbds.Tables("STAFF_MASTER")(0)(7)
            dbds.Tables.Clear()
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SELECT STAFF DATA ERROR")
        Finally
            dbconnection.Close()
        End Try
        TabPage1.Focus()
    End Sub

    Private Sub addupdatestaffname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addupdatestaffname.SelectedIndexChanged
        If addupdatestaffname.SelectedIndex <> 0 Then
            getstaffdata(addupdatestaffname.SelectedItem.ToString)
            lockfield(False)
            Button1.Visible = True

        Else
            CLEAR()
            Button1.Visible = False
        End If
    End Sub



    Private Sub addupdatestafftype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addupdatestafftype.SelectedIndexChanged
        If addupdatestafftype.SelectedIndex = 0 Then
            addstafftypetype.Clear()
            addstafftyperemark.Clear()
        Else
            Try
                dbconnection.Open()
                dbda = New OleDb.OleDbDataAdapter("SELECT * FROM STAFF_TYPE_MASTER WHERE STAFF_TYPE=" & "'" & addupdatestafftype.SelectedItem.ToString & "'", dbconnection)
                dbda.Fill(dbds, "STAFF_TYPE_MASTER")
                addstafftypetype.Text = dbds.Tables("STAFF_TYPE_MASTER")(0)(1)
                addstafftyperemark.Text = dbds.Tables("STAFF_TYPE_MASTER")(0)(2)
                dbds.Tables.Clear()
                dbconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GET STAFF TYPE DATA ERROR")
            Finally
                dbconnection.Close()
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        TabControl1.SelectedTab = TabPage1
        addupdatestaffname.SelectedItem = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(0).Value
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        TabControl1.SelectedTab = TabPage3
        addupdatestafftype.SelectedItem = DataGridView2.Rows(DataGridView2.CurrentCell.RowIndex).Cells(0).Value
    End Sub

    Private Sub updatestafftype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updatestafftype.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub staffupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staffupdate.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lockfield(True)
        Button1.Visible = False
    End Sub

    Private Sub cmbshowstaff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbshowstaff.SelectedIndexChanged
        If cmbshowstaff.SelectedIndex <> 0 Then
            loadstaffdata(query + " and staff_master.staff_type_id=" + getstafftypeid(cmbshowstaff.SelectedItem.ToString).ToString)
        Else
            loadstaffdata(query)
        End If
        staffcount.Text = DataGridView1.Rows.Count
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        sender.BackColor = Color.LightGreen
        sender.ForeColor = Color.Black
        Label23.ForeColor = Color.White
        Label23.BackColor = menupnl.BackColor
        i = 4
    End Sub
End Class