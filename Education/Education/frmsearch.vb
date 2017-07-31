Public Class frmsearch
    Public str As String
    Dim tbl As DataTable

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub frmsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN, B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A , CAST_MASTER B ,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID"

        record_ref(str) 'DISPLAY DATA IN GRID AT FORM LOAD TIME

        'fetch data into cmbyear-------------------------------

        str = "SELECT REG_YEAR FROM STUDENT_MASTER ORDER BY REG_YEAR DESC"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "STUDENT_MASTER")

        Dim j As Integer
        For j = 0 To ds.Tables("STUDENT_MASTER").Rows.Count - 1

            If cmbyear.Items.Contains(ds.Tables("STUDENT_MASTER").Rows(j).Item("REG_YEAR").ToString) = True Then
            Else
                Me.cmbyear.Items.Add(ds.Tables("STUDENT_MASTER").Rows(j).Item("REG_YEAR").ToString)
            End If

        Next



    End Sub

    Private Sub cmbselect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbselect.Click


    End Sub


    'TEXTBOX COMBOBOX VISIBLE TRUE / FALSE CODE--------------------------------------------------------------------------------------------------

    Private Sub cmbselect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbselect.SelectedIndexChanged

        txtselect.Clear()
        If cmbselect.SelectedItem.ToString = "MARIT" Then
            cmbvisible.Visible = False
            txtselect.Visible = True

        ElseIf cmbselect.SelectedItem.ToString = "STUDENT NAME" Then
            cmbvisible.Visible = False
            txtselect.Visible = True

        ElseIf cmbselect.SelectedItem.ToString = "GENDER" Then
            txtselect.Visible = False
            cmbvisible.Visible = True
            Me.cmbvisible.Items.Clear()
            Me.cmbvisible.Items.Add("MALE")
            Me.cmbvisible.Items.Add("FEMALE")


        ElseIf cmbselect.SelectedItem.ToString = "CATEGORY" Then
            Me.cmbvisible.Items.Clear()
            txtselect.Visible = False
            cmbvisible.Visible = True
            connect()

            adpt = New Data.OleDb.OleDbDataAdapter("SELECT CAST_NAME from CAST_MASTER", con)
            adpt.Fill(ds, "CAST_MASTER")

            Dim j As Integer
            For j = 0 To ds.Tables("CAST_MASTER").Rows.Count - 1
                If cmbvisible.Items.Contains(ds.Tables("CAST_MASTER").Rows(j).Item("CAST_NAME").ToString) = True Then
                Else
                    Me.cmbvisible.Items.Add(ds.Tables("CAST_MASTER").Rows(j).Item("CAST_NAME").ToString)
                End If
            Next

        ElseIf cmbselect.SelectedItem.ToString = "ADDRESS" Then
            txtselect.Visible = True
            cmbvisible.Visible = False

        ElseIf cmbselect.SelectedItem.ToString = "PHONE NO" Then
            txtselect.Visible = True
            cmbvisible.Visible = False

        ElseIf cmbselect.SelectedItem.ToString = "MOBILE NO" Then
            cmbvisible.Visible = False
            txtselect.Visible = True


        ElseIf cmbselect.SelectedItem.ToString = "EMAIL" Then
            cmbvisible.Visible = False
            txtselect.Visible = True

        ElseIf cmbselect.SelectedItem.ToString = "BIRTH DATE" Then
            cmbvisible.Visible = False
            txtselect.Visible = False

        ElseIf cmbselect.SelectedItem.ToString = "BECHLOR DEGREE" Then
            txtselect.Visible = False
            cmbvisible.Visible = True
            connect()
            adpt = New Data.OleDb.OleDbDataAdapter("SELECT DEGREE_NAME from DEGREE_MASTER", con)
            adpt.Fill(ds, "DEGREE_MASTER")
            Me.cmbvisible.Items.Clear()
            Dim j As Integer
            For j = 0 To ds.Tables("DEGREE_MASTER").Rows.Count - 1
                If cmbvisible.Items.Contains(ds.Tables("DEGREE_MASTER").Rows(j).Item("DEGREE_NAME").ToString) = True Then
                Else
                    Me.cmbvisible.Items.Add(ds.Tables("DEGREE_MASTER").Rows(j).Item("DEGREE_NAME").ToString)
                End If
            Next


        ElseIf cmbselect.SelectedItem.ToString = "FROM COLLEGE" Then
            cmbvisible.Visible = True
            txtselect.Visible = False
            connect()
            adpt = New Data.OleDb.OleDbDataAdapter("SELECT COLLEGE_NAME from COLLEGE_MASTER", con)
            adpt.Fill(ds, "COLLEGE_MASTER")
            Me.cmbvisible.Items.Clear()
            Dim j As Integer
            For j = 0 To ds.Tables("COLLEGE_MASTER").Rows.Count - 1
                If cmbvisible.Items.Contains(ds.Tables("COLLEGE_MASTER").Rows(j).Item("COLLEGE_NAME").ToString) = True Then
                Else
                    Me.cmbvisible.Items.Add(ds.Tables("COLLEGE_MASTER").Rows(j).Item("COLLEGE_NAME").ToString)
                End If
            Next


        ElseIf cmbselect.SelectedItem.ToString = "ALL" Then
            txtselect.Visible = False
            cmbvisible.Visible = False
            str = ""
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.REG_YEAR=" & Val(Me.cmbyear.Text)
            End If
            record_ref(str)

        End If
    End Sub


    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cmbyear.Items.Clear()
        cmbselect.Items.Clear()
        txtselect.Clear()

        DataGridView1.Rows.Clear()
        txtselect.Visible = False
        cmbvisible.Visible = False

        'COMBOBOX OF SELECT FIELD IS REFILL AFTER CLEAR--------------------------

        Me.cmbselect.Items.Add("ALL")
        Me.cmbselect.Items.Add("MARIT")
        Me.cmbselect.Items.Add("STUDENT NAME")
        Me.cmbselect.Items.Add("GENDER")
        Me.cmbselect.Items.Add("CATEGORY")
        Me.cmbselect.Items.Add("ADDRESS")
        Me.cmbselect.Items.Add("PHONE NO")
        Me.cmbselect.Items.Add("MOBILE NO")
        Me.cmbselect.Items.Add("EMAIL")
        Me.cmbselect.Items.Add("BECHLOR DEGREE")
        Me.cmbselect.Items.Add("FROM COLLEGE")

    End Sub

    'FUNCTION OF DIAPLAY DATA IN GRID------------------------------------------------------------------------------------------------

    Public Sub record_ref(ByRef str1 As String)

        tbl = getdata(str1)
        If tbl.Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
            For i As Integer = 0 To tbl.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = tbl.Rows(i).Item(0).ToString
                DataGridView1.Rows(i).Cells(1).Value = tbl.Rows(i).Item(1).ToString
                DataGridView1.Rows(i).Cells(2).Value = tbl.Rows(i).Item(2).ToString
                DataGridView1.Rows(i).Cells(3).Value = tbl.Rows(i).Item(3).ToString
                DataGridView1.Rows(i).Cells(4).Value = tbl.Rows(i).Item(4).ToString
                DataGridView1.Rows(i).Cells(5).Value = Convert.ToDateTime(tbl.Rows(i).Item(5).ToString).ToString("dd/MM/yyyy")
                DataGridView1.Rows(i).Cells(6).Value = tbl.Rows(i).Item(6).ToString
                DataGridView1.Rows(i).Cells(7).Value = tbl.Rows(i).Item(7).ToString
                DataGridView1.Rows(i).Cells(8).Value = tbl.Rows(i).Item(8).ToString
                DataGridView1.Rows(i).Cells(9).Value = tbl.Rows(i).Item(9).ToString
                DataGridView1.Rows(i).Cells(10).Value = tbl.Rows(i).Item(10).ToString
            Next
        End If

    End Sub




    'ENTER KEY CODE --------------------------------------------------------------------------------------

    Private Sub cmbyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbyear.KeyDown
        If e.KeyCode = Keys.Enter And cmbyear.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f4}")
        ElseIf e.KeyCode = Keys.Enter And cmbyear.Text <> "" Then
            cmbselect.Focus()
        End If
    End Sub


    Private Sub cmbselect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbselect.KeyDown
        If e.KeyCode = Keys.Enter And cmbselect.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f4}")
        ElseIf e.KeyCode = Keys.Enter And cmbselect.Text <> "" Then
            If cmbselect.Text = "ALL" Then
                btnprint.Focus()
            ElseIf cmbselect.Text = "GENDER" Or cmbselect.Text = "CATEGORY" Or cmbselect.Text = "BECHLOR DEGREE" Or cmbselect.Text = "FROM COLLEGE" Then
                cmbvisible.Focus()
            Else
                txtselect.Focus()
            End If
        End If
    End Sub

    Private Sub cmbvisible_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbvisible.KeyDown
        If e.KeyCode = Keys.Enter And cmbvisible.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f4}")
        ElseIf e.KeyCode = Keys.Enter And cmbvisible.Text <> "" Then
            btnprint.Focus()
        End If
    End Sub

    Private Sub txtselect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtselect.KeyDown
        If e.KeyCode = Keys.Enter And txtselect.Text <> "" Then
            ' e.SuppressKeyPress = True
            btnprint.Focus()
        End If
    End Sub


    Private Sub btnprint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnprint.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnclear.Focus()
        End If
    End Sub

    Private Sub btnclear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnclear.KeyDown
        If e.KeyCode = Keys.Left Then
            btncancel.Focus()
        ElseIf e.KeyCode = Keys.Right Then
            btnprint.Focus()
        End If
    End Sub


    'YEAR WISE DATA DISPLAY IN GRID------------------------------------------------------------------------------------------

    Private Sub cmbyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbyear.SelectedIndexChanged
        str = ""
        str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.REG_YEAR=" & Val(cmbyear.Text)

        txtselect.Visible = False
        cmbvisible.Visible = False
        cmbselect.Text = ""
        txtselect.Clear()
        record_ref(str)

    End Sub

    Private Sub cmbyear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbyear.Click
        'fetch data into cmbyear AFTER CLEAR-------------------------------

        str = "SELECT REG_YEAR FROM STUDENT_MASTER ORDER BY REG_YEAR DESC"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "STUDENT_MASTER")

        Dim j As Integer
        For j = 0 To ds.Tables("STUDENT_MASTER").Rows.Count - 1

            If cmbyear.Items.Contains(ds.Tables("STUDENT_MASTER").Rows(j).Item("REG_YEAR").ToString) = True Then
            Else
                Me.cmbyear.Items.Add(ds.Tables("STUDENT_MASTER").Rows(j).Item("REG_YEAR").ToString)
            End If

        Next

    End Sub



    'QUERY FOR DISPLAY DATA IN GRID (COMBOBOX)----------------------------------------------------------------------------------

    Private Sub cmbvisible_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbvisible.SelectedIndexChanged

        If Me.cmbselect.Text = "GENDER" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_GEN='" & cmbvisible.SelectedItem.ToString & "'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_GEN='" & cmbvisible.SelectedItem.ToString & "' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf Me.cmbselect.Text = "CATEGORY" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_CAST_ID=" & Val(cmbvisible.SelectedIndex) + 1
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_CAST_ID=" & Val(cmbvisible.SelectedIndex) + 1 & " AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf Me.cmbselect.Text = "BECHLOR DEGREE" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_BDEGREE_ID=" & Val(cmbvisible.SelectedIndex) + 1
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_BDEGREE_ID=" & Val(cmbvisible.SelectedIndex) + 1 & " AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf Me.cmbselect.Text = "FROM COLLEGE" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_BDEGREE_COL_ID=" & Val(cmbvisible.SelectedIndex) + 1
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND A.STU_BDEGREE_COL_ID=" & Val(cmbvisible.SelectedIndex) + 1 & " AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)

        End If

    End Sub

    'QUERY FOR DISPLAY DATA IN GRID (TEXTBOX)-------------------------------------------------------------------------------------

    Private Sub txtselect_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtselect.TextChanged
        If cmbselect.Text = "MARIT" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_CMATNO] LIKE '" & Val(txtselect.Text) & "%'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_CMATNO] LIKE '" & Val(txtselect.Text) & "%' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf cmbselect.Text = "STUDENT NAME" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_NAME] LIKE '%" & txtselect.Text & "%'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_NAME] LIKE '%" & txtselect.Text & "%' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf cmbselect.Text = "ADDRESS" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_ADD] LIKE '%" & txtselect.Text & "%'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_ADD] LIKE '%" & txtselect.Text & "%' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)



        ElseIf cmbselect.Text = "PHONE NO" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_PHNO] LIKE'" & txtselect.Text & "%'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_PHNO] LIKE'" & txtselect.Text & "%' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf cmbselect.Text = "MOBILE NO" Then
            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_MOBNO] LIKE '" & Val(txtselect.Text) & "%'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_MOBNO] LIKE '" & Val(txtselect.Text) & "%' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        ElseIf cmbselect.Text = "EMAIL" Then

            If cmbyear.Text = "" Then
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_EMAIL] LIKE '%" & txtselect.Text & "%'"
            Else
                str = "SELECT A.STU_RNO,A.STU_CMATNO,A.STU_NAME,A.STU_GEN,B.CAST_NAME,A.STU_DOB,A.STU_ADD,A.STU_PHNO,A.STU_MOBNO,A.STU_EMAIL,C.DEGREE_NAME FROM STUDENT_MASTER A,CAST_MASTER B,DEGREE_MASTER C WHERE A.STU_CAST_ID=B.CAST_ID AND A.STU_BDEGREE_ID=C.DEGREE_ID AND [A.STU_EMAIL] LIKE '%" & txtselect.Text & "%' AND A.REG_YEAR=" & Val(cmbyear.Text)
            End If
            record_ref(str)


        End If
    End Sub

 
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        serchstudentfrm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
