Public Class frmcompnayArrival

    Dim sql As String
    Dim tb1 As DataTable
    
    Private Sub frmcompnayArrival_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Grid_Select_Company.Visible = True
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmcompnayArrival_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnenablefalse()
        fillgrid()
        'Grid_Select_Company.Sort(Grid_Select_Company.Columns(0))
    End Sub


    Private Sub fillgrid()
        Dim i As Integer = 0
        sql = "select * from COMPANY_MASTER"
        tb1 = New DataTable
        tb1 = getdata(sql)
        Dim cnt As Integer = tb1.Rows.Count
        txtid.Enabled = False
        If (tb1.Rows.Count > 0) Then
            Grid_Select_Company.Rows.Add(cnt)
            txtid.Enabled = True
            While (i < tb1.Rows.Count)
                Grid_Select_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                Grid_Select_Company.Rows(i).Cells(1).Value = tb1.Rows(i).Item(1).ToString
                i += 1
            End While
        Else
            MsgBox("There Is No Company Records To Display" + vbCrLf + "Please Add The Record First In Company Master", MsgBoxStyle.Information, "Company Arrival Master")
        End If

    End Sub


    Private Sub DataGridView2_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Select_Company.CellClick
        Dim i As Integer
        i = Grid_Select_Company.CurrentRow.Index
        txtid.Text = Grid_Select_Company.Item(0, i).Value
        txtcompname.Text = Grid_Select_Company.Item(1, i).Value
        txtcompname.Enabled = False
        txtid.Enabled = False
        Grid_Select_Company.Visible = False
    End Sub
    Private Sub cleardata()
        txtid.Text = ""
        txtcompname.Text = ""
        txtpurpose.Text = ""
        txttech.Text = ""
        txttot.Text = ""
        cmbbatch.SelectedIndex = -1
        cmbsem.SelectedIndex = -1
        txtid.Enabled = True
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        sql = "SELECT MAX(COMP_ARR_Id) FROM COMPANY_ARRIVAL_MASTER"
        Dim maxid As Integer = getInt(sql) + 1
        'MsgBox(maxid.ToString)

        If (cmbsem.Text = "") Then
            MsgBox("enter semester")
            cmbsem.Focus()
        ElseIf cmbbatch.Text = "" Then
            MsgBox("enter batch name")
            cmbbatch.Focus()
        ElseIf txtpurpose.Text = "" Then
            MsgBox("enter purpose")
            txtpurpose.Focus()
        ElseIf txttot.Text = "" Then
            MsgBox("enter total of student ")
            txttot.Focus()
        ElseIf txttech.Text = "" Then
            MsgBox("enter technology")
            txttech.Focus()
        Else
            Dim purp As String = txtpurpose.Text.TrimStart.ToUpper
            Dim dt As New Date(compdate.Value.Year, compdate.Value.Month, compdate.Value.Day)
            sql = "insert into COMPANY_ARRIVAL_MASTER values(" & maxid & "," & Val(txtid.Text) & ",'" & dt.ToString & "','" & purp & "'," & Val(txttot.Text) & ",'" & txttech.Text.ToUpper & "','" & cmbsem.Text & "'," & Val(cmbbatch.Text) & ")"
            insertqry(sql)
            cleardata()
            btnenablefalse()
            txtid.Enabled = True
        End If
    End Sub

    Private Sub btnenablefalse()
        btnadd.Enabled = False
        btncancel.Enabled = False
        btnclr.Enabled = False
    End Sub
    Private Sub btnenabletrue()
        btnadd.Enabled = True
        btncancel.Enabled = True
        btnclr.Enabled = True
    End Sub

    Private Sub DataGridView2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_Select_Company.LostFocus
        btnenabletrue()
    End Sub

    Private Sub btnclr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclr.Click
        cleardata()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cleardata()
        btnenablefalse()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub compdate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles compdate.LostFocus

        Dim todt As Date
        todt = compdate.Value.ToString
        'MsgBox(todt.ToString + " " + Date.Today.ToString)
        If (todt > Date.Today.AddDays(1)) Then
            MsgBox("Arrival Date Should Not Be Greater Than Today Date !!", MsgBoxStyle.Information, " Company_Master")

            compdate.Focus()
        End If

    End Sub

   
    Private Sub compdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles compdate.ValueChanged

    End Sub
End Class