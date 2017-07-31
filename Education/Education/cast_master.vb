﻿Public Class cast_master
    Public str As String
    Public id As Integer
    Private Sub cast_master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cast_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'insert data from CAST_MASTER table into combobox1(cmbAdmsnSelectType) at run time
        str = "select CAST_NAME from CAST_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "CAST_MASTER")
        Dim j As Integer
        For j = 0 To ds.Tables("CAST_MASTER").Rows.Count - 1
            If Me.ComboBox1.Items.Contains(ds.Tables("CAST_MASTER").Rows(j).Item("CAST_NAME").ToString) = True Then
            Else
                Me.ComboBox1.Items.Add(ds.Tables("CAST_MASTER").Rows(j).Item("CAST_NAME").ToString)
            End If
        Next

        con.Close()
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
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TextBox1.Text = Me.ComboBox1.SelectedItem
        Dim temp As String = getsinglefieldstr("select CAST_DETAIL from CAST_MASTER where CAST_ID= " & Me.ComboBox1.SelectedIndex + 1)
        Me.TextBox2.Text = temp
        temp = ""
        temp = getsinglefieldstr("select REMARKS from CAST_MASTER where CAST_ID= " & Me.ComboBox1.SelectedIndex + 1)
        Me.TextBox3.Text = temp
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connect()
        Dim i, id As Integer

        'inserting data into CAST_MASTER table and also adding into combobox
        id = getsinglefieldint("SELECT MAX(CAST_ID) FROM CAST_MASTER") + 1

        Dim flag As Boolean = False
        For i = 0 To Me.ComboBox1.Items.Count - 1
            If (Me.ComboBox1.Items(i).ToString <> Me.TextBox1.Text) And (Me.TextBox1.Text <> "") Then
                flag = True
            End If
        Next
        If flag = True Then
            Me.ComboBox1.Items.Add(Me.TextBox1.Text)
        End If
        For i = 0 To Me.ComboBox1.Items.Count - 1
            If (Me.ComboBox1.Items(i).ToString <> Me.TextBox1.Text) And (Me.ComboBox1.Text = "") And (Me.TextBox1.Text <> "") Then

                str = "INSERT INTO CAST_MASTER Values(" & id & ",'" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "')"
                MsgBox("Data Inserted")
                Exit For
            ElseIf Me.ComboBox1.Text <> "" Then
                str = "update CAST_MASTER SET CAST_NAME='" & Me.TextBox1.Text & "',CAST_DETAIL='" & Me.TextBox2.Text & "',REMARKS='" & Me.TextBox3.Text & "' WHERE(CAST_MASTER.CAST_ID=" & Me.ComboBox1.SelectedIndex + 1 & ")"
                MsgBox("Data Updated")
                Exit For
            End If
        Next
        Call exe_query(str)
        con.Close()
    End Sub
End Class
