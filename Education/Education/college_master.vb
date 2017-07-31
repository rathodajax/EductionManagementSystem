Public Class college_master
    Public str As String
    Public id As Integer
    Private Sub college_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'insert data from COLLEGE_MASTER table into combobox3 at run time
        str = "select COLLEGE_NAME from COLLEGE_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "COLLEGE_MASTER")
        Dim j As Integer
        For j = 0 To ds.Tables("COLLEGE_MASTER").Rows.Count - 1
            If Me.ComboBox3.Items.Contains(ds.Tables("COLLEGE_MASTER").Rows(j).Item("COLLEGE_NAME").ToString) = True Then
            Else
                Me.ComboBox3.Items.Add(ds.Tables("COLLEGE_MASTER").Rows(j).Item("COLLEGE_NAME").ToString)
            End If
        Next

        'insert data from CITY_MASTER table into combobox2 at run time
        str = "select CITY_NAME from CITY_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "CITY_MASTER")

        For j = 0 To ds.Tables("CITY_MASTER").Rows.Count - 1
            If Me.ComboBox2.Items.Contains(ds.Tables("CITY_MASTER").Rows(j).Item("CITY_NAME").ToString) = True Then
            Else
                Me.ComboBox2.Items.Add(ds.Tables("CITY_MASTER").Rows(j).Item("CITY_NAME").ToString)
            End If
        Next

        'insert data from UNIVERSITY_MASTER table into combobox1 at run time
        str = "select UNIVERSITY_NAME from UNIVERSITY_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "UNIVERSITY_MASTER")

        For j = 0 To ds.Tables("UNIVERSITY_MASTER").Rows.Count - 1
            If Me.ComboBox1.Items.Contains(ds.Tables("UNIVERSITY_MASTER").Rows(j).Item("UNIVERSITY_NAME").ToString) = True Then
            Else
                Me.ComboBox1.Items.Add(ds.Tables("UNIVERSITY_MASTER").Rows(j).Item("UNIVERSITY_NAME").ToString)
            End If
        Next
        con.Close()
    End Sub
    Private Sub college_master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter And Me.ComboBox1.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And ComboBox1.Text <> "" Then
            Me.ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connect()
        Dim i, id As Integer

        'inserting data into COLLEGE_MASTER table and also adding into combobox
        id = getsinglefieldint("SELECT MAX(COLLEGE_ID) FROM COLLEGE_MASTER") + 1

        Dim flag As Boolean = False
        For i = 0 To Me.ComboBox3.Items.Count - 1
            If (Me.ComboBox3.Items(i).ToString <> Me.TextBox1.Text) And (Me.TextBox1.Text <> "") Then
                flag = True
            End If
        Next
        If flag = True Then
            Me.ComboBox3.Items.Add(Me.TextBox1.Text)
        End If
        For i = 0 To Me.ComboBox3.Items.Count - 1
            If (Me.ComboBox3.Text = "") And (Me.TextBox1.Text <> "") Then

                str = "INSERT INTO COLLEGE_MASTER Values(" & id & "," & Me.ComboBox1.SelectedIndex + 1 & "," & Me.ComboBox2.SelectedIndex + 1 & ",'" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "')"
                MsgBox("Data Inserted")
                Exit For
            ElseIf Me.ComboBox3.Text <> "" Then
                str = "update COLLEGE_MASTER SET UNIVERSITY_ID=" & Me.ComboBox1.SelectedIndex + 1 & ",CITY_ID=" & Me.ComboBox2.SelectedIndex + 1 & ",COLLEGE_NAME='" & Me.TextBox1.Text & "',COLLEGE_DETAIL='" & Me.TextBox2.Text & "',REMARKS='" & Me.TextBox3.Text & "' WHERE(COLLEGE_MASTER.COLLEGE_ID=" & Me.ComboBox3.SelectedIndex + 1 & ")"
                MsgBox("Data Updated")
                Exit For
            End If
        Next
        Call exe_query(str.ToUpper)
        con.Close()
    End Sub

    Private Sub ComboBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter And Me.ComboBox2.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And ComboBox2.Text <> "" Then
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox3.KeyDown
        If e.KeyCode = Keys.Enter And Me.ComboBox3.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And ComboBox3.Text <> "" Then
            Me.Button1.Focus()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Me.TextBox1.Text = Me.ComboBox3.SelectedItem
        Dim temp As String = getsinglefieldstr("select COLLEGE_DETAIL from COLLEGE_MASTER where COLLEGE_ID= " & Me.ComboBox3.SelectedIndex + 1)
        Me.TextBox2.Text = temp
        temp = ""
        temp = getsinglefieldstr("select REMARKS from COLLEGE_MASTER where COLLEGE_ID= " & Me.ComboBox3.SelectedIndex + 1)
        Me.TextBox3.Text = temp

        Dim t As Integer = getsinglefieldint("select UNIVERSITY_ID from COLLEGE_MASTER where COLLEGE_ID=" & Me.ComboBox3.SelectedIndex)
        temp = ""
        temp = getsinglefieldstr("select UNIVERSITY_NAME from UNIVERSITY_MASTER where UNIVERSITY_ID= " & t)
        Me.ComboBox1.Text = temp

        t = getsinglefieldint("select CITY_ID from COLLEGE_MASTER where COLLEGE_ID=" & Me.ComboBox3.SelectedIndex)
        temp = ""
        temp = getsinglefieldstr("select CITY_NAME from CITY_MASTER where CITY_ID= " & t).ToString
        Me.ComboBox2.Text = temp
    End Sub
End Class
