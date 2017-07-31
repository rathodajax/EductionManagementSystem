Public Class frmcompany
    Dim sql As String
    Dim tb1 As DataTable
    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click


        If btnsave.Text = "Save" Then
            txtcompname.Text = ""
            txtownername.Text = ""
            txtcontact.Text = ""
            txtadd.Text = ""
            cmbcity.SelectedIndex = -1
            txtcompcontact.Text = ""
            txtemailid.Text = ""
            txtwebsite.Text = ""
            txtotherdetail.Text = ""
            txtpersoncontact.Text = ""
        End If
        If btnsave.Text = "Update" Then
            txtcompname.Text = ""
            txtownername.Text = ""
            txtcontact.Text = ""
            txtadd.Text = ""
            cmbcity.SelectedIndex = -1
            txtcompcontact.Text = ""
            txtemailid.Text = ""
            txtwebsite.Text = ""
            txtotherdetail.Text = ""
            txtpersoncontact.Text = ""
        End If
       

    End Sub

    Private Sub cleardata()
        txtid.Text = ""
        txtcompname.Text = ""
        txtownername.Text = ""
        txtcontact.Text = ""
        txtadd.Text = ""
        cmbcity.SelectedIndex = -1
        txtcompcontact.Text = ""
        txtemailid.Text = ""
        txtwebsite.Text = ""
        txtotherdetail.Text = ""
        txtpersoncontact.Text = ""
        btnsave.Text = "Add New"
        DataGridView1.Visible = False
        btnmodify.Enabled = False
    End Sub

    Private Sub txtenablefalse()
        txtid.Enabled = False
        txtcompname.Enabled = False
        txtownername.Enabled = False
        txtcontact.Enabled = False
        txtadd.Enabled = False
        cmbcity.Enabled = False
        txtcompcontact.Enabled = False
        txtemailid.Enabled = False
        txtwebsite.Enabled = False
        txtotherdetail.Enabled = False
        txtpersoncontact.Enabled = False
        compdate.Enabled = False
    End Sub

    Private Sub txtenabletrue()
        txtid.Enabled = True
        txtcompname.Enabled = True
        txtownername.Enabled = True
        txtcontact.Enabled = True
        txtadd.Enabled = True
        cmbcity.Enabled = True
        txtcompcontact.Enabled = True
        txtemailid.Enabled = True
        txtwebsite.Enabled = True
        txtotherdetail.Enabled = True
        txtpersoncontact.Enabled = True
        compdate.Enabled = True
    End Sub

    Private Sub frmcompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If txtid.Enabled = True Then
            If e.KeyCode = Keys.F1 Then
                DataGridView1.Visible = True
            End If
        End If
        
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmcompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtenablefalse()
        sql = "select *from COMPANY_MASTER"
        tb1 = New DataTable
        tb1 = getdata(sql)
        btnmodify.Enabled = False

        btnclr.Enabled = False

        If (tb1.Rows.Count > 0) Then
            txtid.Enabled = True
            fillgrid()
            btnmodify.Enabled = True
        End If

        '-----------add into combobox--------------
        sql = "select *from CITY_MASTER"
        tb1 = New DataTable
        tb1 = getdata(sql)
        Dim i As Integer = 0
        If (tb1.Rows.Count > 0) Then
            'MsgBox("data found")
            Do While (i < tb1.Rows.Count - 1)
                cmbcity.Items.Add(tb1.Rows(i).Item(2).ToString)
                i += 1
            Loop
        End If
    End Sub

    Public Sub fillgrid()
        Dim i As Integer = 0
        sql = "select * from COMPANY_MASTER"
        tb1 = New DataTable
        tb1 = getdata(sql)
        Dim cnt As Integer = tb1.Rows.Count
        DataGridView1.Rows.Clear()

        If (tb1.Rows.Count > 0) Then

            While (i < tb1.Rows.Count)
                DataGridView1.Rows.Add(1)
                DataGridView1.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                DataGridView1.Rows(i).Cells(1).Value = tb1.Rows(i).Item(1).ToString
                i += 1
            End While
        End If
    End Sub

    Private Sub filldata()
        sql = "select * from COMPANY_MASTER where COMP_ID=" & Val(txtid.Text)
        tb1 = New DataTable
        tb1 = getdata(sql)
        If (tb1.Rows.Count > 0) Then

            txtcompname.Text = tb1.Rows(0).Item(1).ToString
            txtownername.Text = tb1.Rows(0).Item(2).ToString
            txtcontact.Text = tb1.Rows(0).Item(3).ToString
            txtadd.Text = tb1.Rows(0).Item(4).ToString
            cmbcity.Text = tb1.Rows(0).Item(5).ToString
            txtcompcontact.Text = tb1.Rows(0).Item(6).ToString
            txtemailid.Text = tb1.Rows(0).Item(7).ToString
            txtwebsite.Text = tb1.Rows(0).Item(8).ToString
            txtotherdetail.Text = tb1.Rows(0).Item(9).ToString
            txtpersoncontact.Text = tb1.Rows(0).Item(10).ToString
            compdate.Text = tb1.Rows(0).Item(11).ToString
            btnmodify.Enabled = True
            'Dim cityid As Integer
            'cityid = tb1.Rows(0).Item(5).ToString
            'sql = ("select CITY_ID from CITY_MASTER where [CITY_NAME]=" & cityid)
            'cmbcity.Text = getstr(sql)
        End If
        DataGridView1.Visible = False
    End Sub

    Private Sub btnmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodify.Click
        If Not txtid.Text = "" Then
            txtenabletrue()
            filldata()
            txtid.Enabled = False
            btnsave.Text = "Update"
            btnmodify.Enabled = False
            btnclr.Enabled = True
        End If
       
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        btnmodify.Enabled = True
        If (btnsave.Text = "Update") Then
            Dim city As String
            city = cmbcity.Text
            btnmodify.Enabled = False
            'fetch city name from city master
            'sql = ("select *from CITY_MASTER where [CITY_NAME]='" & city & "'")
            'Dim pos As Integer = getInt(sql)
            'update query

            If (txtcompname.Text = "") Then
                MsgBox("enter company name")
                txtcompname.Focus()
            ElseIf (txtownername.Text = "") Then
                MsgBox("enter owner name")
                txtownername.Focus()
            ElseIf (txtcontact.Text = "") Then
                MsgBox("enter owner contact ")
                txtcontact.Focus()
            ElseIf (txtpersoncontact.Text = "") Then
                MsgBox("enter contact persone number")
                txtpersoncontact.Focus()
            ElseIf (txtadd.Text = "") Then
                MsgBox("enter address")
                txtadd.Focus()
            ElseIf (cmbcity.Text = "") Then
                MsgBox("enter city")
                cmbcity.Focus()
            ElseIf (txtcompcontact.Text = "") Then
                MsgBox("enter company conatct")
                txtcompcontact.Focus()
            ElseIf (txtemailid.Text = "") Then
                MsgBox("enter email id")
                txtemailid.Focus()
            ElseIf (txtwebsite.Text = "") Then
                MsgBox("enter website name")
                txtwebsite.Focus()
            Else
                Dim dt As New Date(compdate.Value.Year, compdate.Value.Month, compdate.Value.Day)
                sql = "update COMPANY_MASTER set COMP_NAME='" & txtcompname.Text.ToUpper & "',COMP_OWNER='" & txtownername.Text & "',COMP_OWNER_CONTACT=" & Val(txtcontact.Text) & ",COMP_ADD='" & txtadd.Text.ToUpper & "',COMP_CITY='" & cmbcity.SelectedItem.ToString.ToUpper & "',COMP_CONTACT=" & Val(txtcompcontact.Text) & ",COMP_EMAIL='" & txtemailid.Text & "',COMP_WEBSITE='" & txtwebsite.Text & "',COMP_DETAILS='" & txtotherdetail.Text.ToUpper & "' ,COMP_CONTACT_PERSON=" & Val(txtpersoncontact.Text) & ",COMP_FOUND_DATE='" & dt.ToString & "' where COMP_ID=" & Val(txtid.Text)
                updateqry(sql)
                btnsave.Text = "Add New"
                cleardata()
                txtenablefalse()
                txtid.Enabled = True
                DataGridView1.Rows.Clear()
                fillgrid()
                btnmodify.Enabled = True
                btnmodify.Enabled = False
                btncancel.Enabled = True
                btnclr.Enabled = True
            End If

            
        ElseIf (btnsave.Text = "Add New") Then

            cleardata()
            sql = "SELECT MAX(COMP_ID) FROM COMPANY_MASTER"
            Dim maxid As Integer = getInt(sql)
            txtid.Text = maxid + 1
            btnsave.Text = "Save"
            txtenabletrue()
            txtid.Enabled = False
            btnmodify.Enabled = False
            btncancel.Enabled = True
            btnclr.Enabled = True
        ElseIf (btnsave.Text = "Save") Then

            If (txtcompname.Text = "") Then
                MsgBox("enter company name")
                txtcompname.Focus()
            ElseIf (txtownername.Text = "") Then
                MsgBox("enter owner name")
                txtownername.Focus()
            ElseIf (txtcontact.Text = "") Then
                MsgBox("enter owner contact ")
                txtcontact.Focus()
            ElseIf (txtpersoncontact.Text = "") Then
                MsgBox("enter contact persone number")
                txtpersoncontact.Focus()
            ElseIf (txtadd.Text = "") Then
                MsgBox("enter address")
                txtadd.Focus()
            ElseIf (cmbcity.Text = "") Then
                MsgBox("enter city")
                cmbcity.Focus()
            ElseIf (txtcompcontact.Text = "") Then
                MsgBox("enter company conatct")
                txtcompcontact.Focus()
            ElseIf (txtemailid.Text = "") Then
                MsgBox("enter email id")
                txtemailid.Focus()
            ElseIf (txtwebsite.Text = "") Then
                MsgBox("enter website name")
                txtwebsite.Focus()
            Else
                'sql = ("select CITY_ID from CITY_MASTER where [CITY_NAME]='" & cmbcity.Text & "'")
                'Dim c As String = getInt(sql)
                Dim dt As New Date(compdate.Value.Year, compdate.Value.Month, compdate.Value.Day)
                sql = "insert into COMPANY_MASTER values(" & Val(txtid.Text) & ",'" & txtcompname.Text.ToUpper & "','" & txtownername.Text.ToUpper & "'," & Val(txtcontact.Text) & ",'" & txtadd.Text.ToUpper & "','" & cmbcity.SelectedItem.ToString.ToUpper & "'," & Val(txtcompcontact.Text) & ",'" & txtemailid.Text & "','" & txtwebsite.Text & "','" & txtotherdetail.Text.ToUpper & "'," & Val(txtpersoncontact.Text) & ",'" & dt.ToString & "')"
                insertqry(sql)
                cleardata()
                btnsave.Text = "Add New"

                txtenablefalse()
                txtid.Enabled = True
                DataGridView1.Rows.Clear()
                fillgrid()
            End If
        End If
        DataGridView1.Visible = False
    End Sub

    Private Sub validate_it()
        If (txtcompname.Text = "") Then
            MsgBox("enter company name")
        ElseIf (txtownername.Text = "") Then
            MsgBox("enter owner name")
        ElseIf (txtcontact.Text = "") Then
            MsgBox("enter owner contact ")
        ElseIf (txtadd.Text = "") Then
            MsgBox("enter company name")
        ElseIf (cmbcity.Text = "") Then
            MsgBox("enter city")
        ElseIf (txtcompcontact.Text = "") Then
            MsgBox("enter company conatct")
        ElseIf (txtemailid.Text = "") Then
            MsgBox("enter email id")
        ElseIf (txtwebsite.Text = "") Then
            MsgBox("enter website name")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cleardata()
        DataGridView1.Visible = False
        txtenablefalse()
        txtid.Enabled = True
        fillgrid()
        btnmodify.Enabled = True
        btnsave.Text = "Add New"
        cmbcity.Items.Clear()
        sql = "select *from CITY_MASTER"
        tb1 = New DataTable
        tb1 = getdata(sql)
        Dim i As Integer = 0
        If (tb1.Rows.Count > 0) Then
            'MsgBox("data found")
            Do While (i < tb1.Rows.Count - 1)
                cmbcity.Items.Add(tb1.Rows(i).Item(2).ToString)
                i += 1
            Loop
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtid.Text = DataGridView1.Item(0, i).Value
        DataGridView1.Visible = False
    End Sub

    Private Sub DataGridView1_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.LostFocus
        filldata()
        DataGridView1.Visible = False
        txtid.Enabled = False
    End Sub

    Private Sub txtcompname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcompname.LostFocus
        If btnsave.Text = "Save" Then
            Dim nm = txtcompname.Text.Trim
            'MsgBox("" + nm)

            sql = "select * from COMPANY_MASTER where COMP_NAME='" & nm & "'"
            tb1 = New DataTable
            tb1 = getdata(sql)
            If (tb1.Rows.Count > 0) Then
                MsgBox("Company Already Exist !!" + vbCrLf + "You Can Not Add Company With Same Name ", MsgBoxStyle.Information, " Company_Master")
                Focus()

            End If
        End If
       
    End Sub

    Private Sub compdate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles compdate.LostFocus
        If btnsave.Text = "Save" Then
            Dim todt As Date
            todt = compdate.Value.ToString
            MsgBox(todt.ToString + " " + Date.Today.ToString)
            If (todt > Date.Today) Then
                MsgBox("Established Date Should Not Be Greater Than Today Date !!" + vbCrLf + "You Can Not Add Company With Same Name ", MsgBoxStyle.Information, " Company_Master")
                Focus()
            End If
        End If
    End Sub
  

    
  
End Class