Imports System.Data.OleDb

Public Class frmProjMng
    ' Dim con As OleDbConnection
    Dim dbcell As New DataGridViewComboBoxCell
    Dim cmd As OleDbCommand
    Dim adpt As OleDbDataAdapter
    Dim ds As Data.DataSet
    Dim pid As Integer
    Dim cnt As Integer = 0
    Dim qry, qry1 As String
    Dim tbl, tbl2 As DataTable
    Dim dt, dt1, dt2 As New DataTable
    Public Sub loadData()
        tbl = New DataTable
        tbl = getdata("SELECT * FROM Project_Master")
        tbl2 = getdata("SELECT * FROM Project_Detail")
        If tbl.Rows.Count > 0 Then
            txtId.Text = tbl.Rows(0).Item(0).ToString
            cmbYear.Text = tbl.Rows(0).Item(1).ToString
            cmbSem.Text = tbl.Rows(0).Item(2).ToString
            cmbGrp.Text = tbl.Rows(0).Item(3).ToString
            txtDate.Text = tbl2.Rows(0).Item(1).ToString
            cmbstud1.Text = tbl2.Rows(0).Item(2).ToString
            cmbstud2.Text = tbl2.Rows(0).Item(3).ToString
            cmbstud3.Text = tbl2.Rows(0).Item(4).ToString
            txtTitle.Text = tbl2.Rows(0).Item(5).ToString
            txtPlatform.Text = tbl2.Rows(0).Item(6).ToString
            txtDesc.Text = tbl2.Rows(0).Item(7).ToString
            txtCompany.Text = tbl2.Rows(0).Item(8).ToString

            'txtContact.Text = tbl.Rows(0).Item(4).ToString
        End If
    End Sub
    Public Sub loadDataCnt()
        tbl = New DataTable
        tbl = getdata("SELECT * FROM Project_Master")
        tbl2 = getdata("SELECT * FROM Project_Detail")
        ' cnt = cnt - 1
        If tbl.Rows.Count > 0 Then
            txtId.Text = tbl.Rows(cnt).Item(0).ToString
            cmbYear.Text = tbl.Rows(cnt).Item(1).ToString
            cmbSem.Text = tbl.Rows(cnt).Item(2).ToString
            cmbGrp.Text = tbl.Rows(cnt).Item(3).ToString
            txtDate.Text = tbl2.Rows(cnt).Item(1).ToString
            cmbstud1.Text = tbl2.Rows(cnt).Item(2).ToString
            cmbstud2.Text = tbl2.Rows(cnt).Item(3).ToString
            cmbstud3.Text = tbl2.Rows(cnt).Item(4).ToString
            txtTitle.Text = tbl2.Rows(cnt).Item(5).ToString
            txtPlatform.Text = tbl2.Rows(cnt).Item(6).ToString
            txtDesc.Text = tbl2.Rows(cnt).Item(7).ToString
            txtCompany.Text = tbl2.Rows(cnt).Item(8).ToString

            'txtContact.Text = tbl.Rows(cnt).Item(4).ToString
        End If
    End Sub

    Private Sub frmProjectDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        txtDate.Enabled = False
        'MsgBox("Connected")
        txtDate.Text = CDate(Now.Date)
        For i As Integer = 1 To 30
            If (i < 9) Then
                cmbYear.Items.Add("200" + i.ToString) '+ "-" + "200" + (i + 1).ToString)
            End If
            If (i = 9) Then
                cmbYear.Items.Add("200" + i.ToString) '+ "-" + "20" + (i + 1).ToString)
            End If
            If (i > 9) Then
                cmbYear.Items.Add("20" + i.ToString) '+ "-" + "20" + (i + 1).ToString)
            End If
        Next
        'connect()

        FillCmb("SELECT  Grp_Faculty FROM Group_Master", cmbGrp)
        FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Selected ='no'", cmbstud1)
        FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Selected ='no'", cmbstud2)
        FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Selected ='no'", cmbstud3)
        'FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Stud_Name<>'" & cmbstud1.SelectedItem & "'", cmbstud2)
        'FillCmb("SELECT Prj_Stud_Name FROM Project_Student", cmbstud3)
        cmbSem.Items.Add("MCA Sem-5")
        cmbSem.Items.Add("MCA Sem-6")

        cmbstud2.Enabled = False
        cmbstud3.Enabled = False
        lblstud2.Enabled = False
        lblstud3.Enabled = False
        FillGrid()
        pid = getsinglefieldint("SELECT MAX(Prj_ID) FROM Project_Master") + 1
        txtId.Text = pid.ToString
        cnt = pid
        'removecmbitem()
        'loadData()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        'pid = getsinglefieldint("SELECT MAX(Prj_ID) FROM Project_Master") + 1
        'MsgBox(pid)
        Dim qry2 As String
        If btnInsert.Text = "Insert" Then
            qry = "INSERT INTO Project_Master Values(" & pid.ToString & " ," & cmbYear.SelectedItem & ",'" & cmbSem.SelectedItem.ToString & "'," & (cmbGrp.SelectedIndex) + 1 & ")"
            executeinsert(qry)
            ' qry = "INSERT INTO Project_Detail Values(" & pid.ToString & ", '" & txtDate.Text & "','" & txtstud1.Text & "','" & txtstud2.Text & "','" & txtstud3.Text & "','" & txtTitle.Text & "','" & txtPlatform.Text & "','" & txtDesc.Text & "','" & txtCompany.Text & "')"
            If rdbthree.Checked Then
                qry = "INSERT INTO Project_Detail Values(" & pid.ToString & ", '" & txtDate.Text & "','" & cmbstud1.SelectedItem & "','" & cmbstud2.SelectedItem & "','" & cmbstud3.SelectedItem & "','" & txtTitle.Text & "','" & txtPlatform.Text & "','" & txtDesc.Text & "','" & txtCompany.Text & "')"
                qry2 = "Update Project_Student SET Prj_Selected='Yes' Where Prj_Stud_Name='" & cmbstud1.SelectedItem & "'"
                executeupdated(qry2)
                qry2 = "Update Project_Student SET Prj_Selected='Yes' Where Prj_Stud_Name='" & cmbstud2.SelectedItem & "'"
                executeupdated(qry2)
                qry2 = "Update Project_Student SET Prj_Selected='Yes' Where Prj_Stud_Name='" & cmbstud3.SelectedItem & "'"
                executeupdated(qry2)
            ElseIf rdbtwo.Checked Then
                qry = "INSERT INTO Project_Detail Values(" & pid.ToString & ", '" & txtDate.Text & "','" & cmbstud1.SelectedItem & "','" & cmbstud2.SelectedItem & "',' - ','" & txtTitle.Text & "','" & txtPlatform.Text & "','" & txtDesc.Text & "','" & txtCompany.Text & "')"
                qry2 = "Update Project_Student SET Prj_Selected='Yes' Where Prj_Stud_Name='" & cmbstud1.SelectedItem & "'"
                executeupdated(qry2)
                qry2 = "Update Project_Student SET Prj_Selected='Yes' Where Prj_Stud_Name='" & cmbstud2.SelectedItem & "'"
                executeupdated(qry2)
            Else
                qry = "INSERT INTO Project_Detail Values(" & pid.ToString & ", '" & txtDate.Text & "','" & cmbstud1.SelectedItem & "','-','-','" & txtTitle.Text & "','" & txtPlatform.Text & "','" & txtDesc.Text & "','" & txtCompany.Text & "')"
                qry2 = "Update Project_Student SET Prj_Selected='Yes' Where Prj_Stud_Name='" & cmbstud1.SelectedItem & "'"
                executeupdated(qry2)

            End If
            'qry = "INSERT INTO MyTable Values(" + rno.ToString + ",'" + txtName.Text + "','" + txtAdd.Text + "'," + txtPincode.Text + "," + txtContact.Text + ")"
            executeinsert(qry)
        ElseIf btnInsert.Text = "Update" Then
            qry = "UPDATE Project_Master SET Prj_Batch=" & cmbYear.SelectedItem & ",Prj_Sem='" & cmbSem.SelectedItem & "',Prj_Group_ID=" & (cmbGrp.SelectedIndex) + 1 & " WHERE Prj_ID=" & txtId.Text
            executeupdated(qry)
            '  qry = "UPDATE Project_Detail SET Prj_Stud1=" & cmbYear.SelectedItem & ",Prj_Sem='" & cmbSem.SelectedItem & "',Prj_Group_ID=" & (cmbGrp.SelectedIndex) + 1 & " WHERE Prj_ID=" & txtId.Text
        End If

        ' removecmbitem()
        FillGrid()
    End Sub
    Public Sub removecmbitem()
        cmbstud1.Items.Remove(cmbstud1.SelectedItem)
        cmbstud2.Items.Remove(cmbstud1.SelectedItem)
        cmbstud3.Items.Remove(cmbstud1.SelectedItem)
        cmbstud2.Items.Remove(cmbstud2.SelectedItem)
        cmbstud1.Items.Remove(cmbstud2.SelectedItem)
        cmbstud3.Items.Remove(cmbstud2.SelectedItem)
        cmbstud3.Items.Remove(cmbstud3.SelectedItem)
        cmbstud2.Items.Remove(cmbstud3.SelectedItem)
        cmbstud1.Items.Remove(cmbstud3.SelectedItem)
    End Sub

    Private Sub rdbtwo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtwo.CheckedChanged
        cmbstud2.Enabled = True
        lblstud2.Enabled = True
        cmbstud3.Enabled = False
        lblstud3.Enabled = False

    End Sub

    Private Sub rdbthree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbthree.CheckedChanged
        cmbstud2.Enabled = True
        lblstud2.Enabled = True
        cmbstud3.Enabled = True
        lblstud3.Enabled = True

    End Sub
    Public Sub FillGrid()
        dt = getdata("select distinct Prj_ID,Prj_Title,Prj_Company,prj_Platform from Project_Detail ")
        '  DataGridView1.DataSource = dt
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                'MsgBox(dt.Rows(i).Item(0).ToString)
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
                DataGridView1.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
                DataGridView1.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
                DataGridView1.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)

                Dim id As Integer = dt.Rows(i).Item("Prj_ID")
                dt1.Clear()

                dt1 = getdata("select Prj_Stud1,Prj_Stud2,Prj_Stud3 from Project_Detail where Prj_ID=" & id)

                Dim dbcell As DataGridViewComboBoxCell


                dbcell = DataGridView1.Rows(i).Cells(5)
                dbcell.Items.Clear()
                dbcell.Items.Add(dt1.Rows(0).Item(0))
                dbcell.Items.Add(dt1.Rows(0).Item(1))
                dbcell.Items.Add(dt1.Rows(0).Item(2))
                dbcell.Value = dbcell.Items(0)

                'For k = 0 To dt1.Rows.Count - 1

                '    dbcell.Items.Add(dt1.Rows(i).Item(k).ToString)
                '    dbcell.Value() = dbcell.Items(0)
                'Next


                dt1.Clear()
                dt1 = getdata("select Prj_Group_ID from Project_Master where Prj_ID=" & id)
                id = 0
                id = dt1.Rows(0).Item(0)
                dt2 = getdata("select Grp_Faculty from Group_Master where Grp_ID=" & id)
                ' DataGridView1.Rows(i).Cells(4).Value = dt2.Rows(0).Item(0).ToString
                dt1.Clear()
                dt2.Clear()
            Next
        End If
    End Sub
    Public Sub clearAllText()
        txtCompany.Text = ""
        txtTitle.Text = ""
        txtDesc.Text = ""
        txtPlatform.Text = ""
        cmbstud1.Text = ""
        cmbstud2.Text = ""
        cmbstud3.Text = ""
        cmbGrp.Text = ""
        cmbYear.Text = ""
        cmbSem.Text = ""
        'txt.Text = ""
    End Sub


    Private Sub cmbstud1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud1.SelectedIndexChanged
        FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Stud_Name<>'" & cmbstud1.SelectedItem & "'", cmbstud2)
        'FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Stud_Name<>'" & cmbstud1.SelectedItem & "'", cmbstud3)

    End Sub

    Private Sub cmbstud2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud2.SelectedIndexChanged
        FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Stud_Name<>'" & cmbstud1.SelectedItem & "' AND Prj_Stud_Name<>'" & cmbstud2.SelectedItem & "'", cmbstud3)
        cmbstud1.Items.Remove(cmbstud2.SelectedItem)

        ' FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Stud_Name<>'" & cmbstud1.SelectedItem & "' AND Prj_Stud_Name<>'" & cmbstud2.SelectedItem & "'", cmbstud1)
    End Sub

    Private Sub cmbstud3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstud3.SelectedIndexChanged
        ' FillCmb("SELECT Prj_Stud_Name FROM Project_Student where Prj_Stud_Name<>'" & cmbstud2.SelectedItem & "' AND Prj_Stud_Name<>'" & cmbstud3.SelectedItem & "'", cmbstud1)
        '        cmbstud1.Items.Remove(cmbstud2.SelectedItem)
        cmbstud1.Items.Remove(cmbstud3.SelectedItem)
        cmbstud2.Items.Remove(cmbstud3.SelectedItem)

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        btnInsert.Text = "Update"
        Dim noofrows As Integer = getsinglefieldint("SELECT COUNT(*) FROM Project_Master")
        If noofrows > 0 Then
            If cnt = 0 Then
                MsgBox("Already On First Record")
                Exit Sub
            End If
            loadData()
            cnt = 0
        Else
            MsgBox("No Data Found")
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        btnInsert.Text = "Update"
        cnt = cnt - 1
        Dim noofrows As Integer = getsinglefieldint("SELECT COUNT(*) FROM Project_Master")
        If noofrows > 0 Then
            If cnt = 0 Then
                MsgBox("Already On First Record")
                Exit Sub
            End If
            cnt = cnt - 1
            loadDataCnt()
        Else
            MsgBox("No Data Found")
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        btnInsert.Text = "Update"
        Dim noofrows As Integer = getsinglefieldint("SELECT COUNT(*) FROM Project_Master")
        If noofrows > 0 Then
            If cnt = noofrows - 1 Then
                MsgBox("Already On Last Record")
                Exit Sub
            End If
            cnt = cnt + 1
            loadDataCnt()
        Else
            MsgBox("No Data Found")
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        btnInsert.Text = "Update"
        Dim noofrows As Integer = getsinglefieldint("SELECT COUNT(*) FROM Project_Master")
        If noofrows > 0 Then
            If cnt = noofrows - 1 Then
                MsgBox("Already on last record")
                Exit Sub
            End If
            cnt = noofrows - 1
            loadDataCnt()
        Else
            MsgBox("No Data Found")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        btnInsert.Text = "Insert"
        ' Application.Restart()
        clearAllText()
        txtId.Text = pid
        rdbthree.Checked = False
        rdbtwo.Checked = False
        cmbstud2.Enabled = False
        lblstud2.Enabled = False
        cmbstud3.Enabled = False
        lblstud3.Enabled = False

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
