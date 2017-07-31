Public Class staff
    Dim i As Integer = 4
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
        frmSalary.Show()
        frmSalary.Focus()
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        expanse.Show()
        expanse.Focus()
    End Sub

    Private Sub staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.BackColor = Color.LightGreen
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
        '  staffcount.Text = DataGridView1.Rows.Count
        addstaffjoingdate.CustomFormat = "dd/MM/yyyy"
        loadstaffdata("SELECT staff_master.staff_name, staff_type_master.staff_type, staff_master.staff_contact, staff_master.staff_joining_date FROM staff_master, staff_type_master where staff_master.staff_type_id=staff_type_master.ID")
        loadstafftypedata()
    End Sub

    Private Sub loadstaffdata(ByVal query As String)
        Dim ds As New DataSet()
        DataGridView1.Update()
        Try

            con.Open()
            da = New OleDb.OleDbDataAdapter(query, con)
            da.Fill(ds, "staff_master")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "staff_master"
            con.Close()
            ds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub loadstafftypedata()
        Dim dt As Data.DataTable
        Dim i As Integer
        DataGridView2.Update()
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("select * from staff_type_master", con)
            dt = New DataTable
            da.Fill(dt)
            'DataGridView2.Rows.Clear()
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    DataGridView2.Rows.Add()
                    DataGridView2.Rows(i).Cells(0).Value = dt.Rows(i).Item(1).ToString
                    DataGridView2.Rows(i).Cells(1).Value = dt.Rows(i).Item(2).ToString

                Next
            End If
            con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click, updatestafftypecancel.Click, updatestaffcancel.Click
        changecolor(sender)
        sender.backcolor = Color.LightGreen
        If MsgBox("DO YOU WANT TO EXIT?", MsgBoxStyle.YesNoCancel, "TERMINATATION CONFIRM") = MsgBoxResult.Yes Then frmStaffSalary.Close()
    End Sub
    Public Sub loadstafftype(ByVal t As System.Object)
        t.Items.Clear()
        If t.Name.Equals("addupdatestafftype") Then
            t.Items.Add("Select staff type for update data")
        ElseIf t.Name.Equals("cmbshowstaff") Then
            t.Items.Add("Select all staff type")
        Else
            t.Items.Add("Select staff type")
        End If
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT STAFF_TYPE FROM STAFF_TYPE_MASTER", con)
            da.Fill(ds, "STAFF_TYPE_MASTER")
            For i As Integer = 0 To ds.Tables("STAFF_TYPE_MASTER").Rows.Count - 1
                t.Items.Add(ds.Tables("STAFF_TYPE_MASTER")(i)(0))
            Next
            ds.Tables.Clear()
            con.Close()
            t.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error Message")
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub loadstaffname(ByVal t As System.Object)
        t.Items.Clear()
        If t.Name.Equals("addupdatestaffname") Then t.Items.Add("Select staff name for update data")
        If t.Name.Equals("cbxstaffname") Or t.Name.Equals("expensecmbstaffname") Then t.Items.Add("Show all staff data")
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT STAFF_NAME FROM STAFF_MASTER", con)
            da.Fill(ds, "STAFF_MASTER")
            For i As Integer = 0 To ds.Tables("STAFF_MASTER").Rows.Count - 1
                t.Items.Add(ds.Tables("STAFF_MASTER")(i)(0))
            Next
            ds.Tables.Clear()
            con.Close()
            t.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Load staffname Error Message")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub addstafftypesubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstafftypesubmit.Click
        If addstafftypetype.Text.Length > 0 Then
            If addupdatestafftype.SelectedIndex = 0 Then
                Try
                    con.Open()
                    cmd = New OleDb.OleDbCommand("INSERT INTO STAFF_TYPE_MASTER (STAFF_TYPE,REMARK) VALUES (@ST,@SR)", con)
                    cmd.Parameters.AddWithValue("@ST", addstafftypetype.Text)
                    cmd.Parameters.AddWithValue("@SR", addstafftyperemark.Text)
                    cmd.ExecuteNonQuery()
                    addstafftypetype.Clear()
                    con.Close()
                    addstafftypetype.Clear()
                    addstafftyperemark.Clear()
                    loadstafftype(addupdatestafftype)
                    loadstafftype(addstafftype)
                    MsgBox("succefully data inserted ")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                Try
                    con.Open()
                    cmd = New OleDb.OleDbCommand("UPDATE STAFF_TYPE_MASTER SET STAFF_TYPE=@ST,REMARK=@SR WHERE STAFF_TYPE=@SST", con)
                    cmd.Parameters.AddWithValue("@ST", addstafftypetype.Text)
                    cmd.Parameters.AddWithValue("@SR", addstafftyperemark.Text)
                    cmd.Parameters.AddWithValue("@SST", addupdatestafftype.SelectedItem.ToString)
                    cmd.ExecuteNonQuery()
                    addstafftypetype.Clear()
                    con.Close()
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
                    con.Close()
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
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT STAFF_TYPE_ID FROM STAFF_MASTER WHERE STAFF_NAME=" & "'" & name & "'", con)
            da.Fill(ds, "STAFF_MASTER")
            t = ds.Tables("STAFF_MASTER")(0)(0)
            ds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETSTAFFTYPE ERROR")
        Finally
            con.Close()
        End Try
        Return t
    End Function
    Public Function getstafftype(ByVal id As Integer) As String
        Dim t As String = ""
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT STAFF_TYPE FROM STAFF_TYPE_MASTER WHERE ID=" & id, con)
            da.Fill(ds, "STAFF_TYPE_MASTER")
            t = ds.Tables("STAFF_TYPE_MASTER")(0)(0)
            ds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETSTAFFID  ERROR")
        Finally
            con.Close()
        End Try
        Return t
    End Function
    Public Function getstafftypeid(ByVal id As String) As Integer
        Dim t As Integer
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT ID FROM STAFF_TYPE_MASTER WHERE STAFF_TYPE=" & "'" & id & "'", con)
            da.Fill(ds, "STAFF_TYPE_MASTER")
            t = ds.Tables("STAFF_TYPE_MASTER")(0)(0)
            ds.Tables.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GETSTAFFID  ERROR")
        Finally
            con.Close()
        End Try
        Return t
    End Function

    Private Sub addstaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addstaff.Click
        If addstafftype.SelectedIndex <> 0 And addstafffirstname.Text.Length > 0 And addstaffmiddlename.Text.Length > 0 And addstafflastname.Text.Length > 0 And addstaffcontact.Text.Length = 10 And addstaffemailid.Text.Length > 0 And addstafffixsalary.Text.Length > 0 Then
            Dim t As Integer = getstafftypeid(addstafftype.SelectedItem.ToString)
            Dim FNAME As String = addstafffirstname.Text & " " & addstaffmiddlename.Text & " " & addstafflastname.Text
            If addupdatestaffname.SelectedIndex = 0 Then
                ' MsgBox(t)
                Try
                    con.Open()
                    cmd = New OleDb.OleDbCommand("INSERT INTO STAFF_MASTER (STAFF_TYPE_ID,STAFF_NAME,STAFF_CONTACT,STAFF_JOINING_DATE,STAFF_FIX_SALARY,STAFF_REMARK,STAFF_ADDRESS,STAFF_MAIL_ID) VALUES (@SI,@SN,@SC,@SJ,@SF,@SR,@SA,@SM)", con)
                    cmd.Parameters.AddWithValue("@SI", t)
                    cmd.Parameters.AddWithValue("@SN", FNAME)
                    cmd.Parameters.AddWithValue("@SC", addstaffcontact.Text)
                    cmd.Parameters.AddWithValue("@SJ", addstaffjoingdate.Text)
                    cmd.Parameters.AddWithValue("@SF", addstafffixsalary.Text)
                    cmd.Parameters.AddWithValue("@SA", addstaffaddress.Text)
                    cmd.Parameters.AddWithValue("@SR", addstaffremark.Text)
                    cmd.Parameters.AddWithValue("@SR", addstaffemailid.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("SUCCESSFULLY DATA INSERTED..")
                    CLEAR()
                    con.Close()
                    loadstaffname(addupdatestaffname)
                    loadstaffname(frmSalary.cmbstaffname)
                    'loadstaffname(frmSalary.cbxstaffname)
                    loadstaffname(expanse.expensecmbstaffname)
                    loadstaffname(expanse.expansesstaffname)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ADD STAFF ERROR")
                Finally
                    con.Close()
                End Try
            Else
                Try
                    con.Open()
                    cmd = New OleDb.OleDbCommand("UPDATE STAFF_MASTER SET STAFF_TYPE_ID=@SI,STAFF_NAME=@SNN,STAFF_CONTACT=@SC,STAFF_JOINING_DATE=@SJ,STAFF_FIX_SALARY=@SFS,STAFF_REMARK=@SR,STAFF_ADDRESS=@SA,STAFF_MAIL_ID=@SM WHERE STAFF_NAME=@SN", con)
                    cmd.Parameters.AddWithValue("@SI", t)
                    cmd.Parameters.AddWithValue("@SNN", FNAME)
                    cmd.Parameters.AddWithValue("@SC", Val(addstaffcontact.Text))
                    cmd.Parameters.AddWithValue("@SJ", addstaffjoingdate.Text)
                    cmd.Parameters.AddWithValue("@SFS", Val(addstafffixsalary.Text))
                    cmd.Parameters.AddWithValue("@SR", addstaffremark.Text)
                    cmd.Parameters.AddWithValue("@SA", addstaffaddress.Text)
                    cmd.Parameters.AddWithValue("@SM", addstaffemailid.Text)
                    cmd.Parameters.AddWithValue("@SN", addupdatestaffname.SelectedItem.ToString)
                    If cmd.ExecuteNonQuery() = 1 Then
                        MsgBox("SUCESSFULLY UPDATED..")
                    End If
                    CLEAR()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "UPDATE STAFF ERROR")
                Finally
                    con.Close()
                End Try

            End If
            loadstaffname(addupdatestaffname)
            loadstaffname(frmSalary.cmbstaffname)
            'loadstaffname(frmSalary.cbxstaffname)
            loadstaffname(expanse.expensecmbstaffname)
            loadstaffname(expanse.expansesstaffname)
            loadstaffdata("SELECT staff_master.staff_name, staff_type_master.staff_type, staff_master.staff_contact, staff_master.staff_joining_date FROM staff_master, staff_type_master where staff_master.staff_type_id=staff_type_master.ID")
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
        Dim QUERY As String = "SELECT * FROM STAFF_MASTER WHERE STAFF_NAME=" & "'" & str & "'"
        Dim s As Object = str
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(QUERY, con)
            da.Fill(ds, "STAFF_MASTER")
            addupdatestaffname.SelectedItem = s
            addstafftype.SelectedItem = type
            FNAME = ds.Tables("STAFF_MASTER")(0)(1)
            name = FNAME.Split(" ")
            addstafffirstname.Text = name(0)
            addstaffmiddlename.Text = name(1)
            addstafflastname.Text = name(2)
            addstaffcontact.Text = ds.Tables("STAFF_MASTER")(0)(2)
            addstaffjoingdate.Text = ds.Tables("STAFF_MASTER")(0)(3)
            addstafffixsalary.Text = ds.Tables("STAFF_MASTER")(0)(4)
            addstaffremark.Text = ds.Tables("STAFF_MASTER")(0)(6)
            addstaffaddress.Text = ds.Tables("STAFF_MASTER")(0)(5)
            addstaffemailid.Text = ds.Tables("STAFF_MASTER")(0)(7)
            ds.Tables.Clear()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SELECT STAFF DATA ERROR")
        Finally
            con.Close()
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
                con.Open()
                da = New OleDb.OleDbDataAdapter("SELECT * FROM STAFF_TYPE_MASTER WHERE STAFF_TYPE=" & "'" & addupdatestafftype.SelectedItem.ToString & "'", con)
                da.Fill(ds, "STAFF_TYPE_MASTER")
                addstafftypetype.Text = ds.Tables("STAFF_TYPE_MASTER")(0)(1)
                addstafftyperemark.Text = ds.Tables("STAFF_TYPE_MASTER")(0)(2)
                ds.Tables.Clear()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "GET STAFF TYPE DATA ERROR")
            Finally
                con.Close()
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
            loadstaffdata("SELECT staff_master.staff_name, staff_type_master.staff_type, staff_master.staff_contact, staff_master.staff_joining_date FROM staff_master, staff_type_master where staff_master.staff_type_id=staff_type_master.ID and staff_master.staff_type_id=" + getstafftypeid(cmbshowstaff.SelectedItem.ToString).ToString)
        Else
            loadstaffdata("SELECT staff_master.staff_name, staff_type_master.staff_type, staff_master.staff_contact, staff_master.staff_joining_date FROM staff_master, staff_type_master where staff_master.staff_type_id=staff_type_master.ID")

        End If
        staffcount.Text = DataGridView1.Rows.Count
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

    End Sub
End Class