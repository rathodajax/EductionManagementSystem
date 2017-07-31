Imports System.Data.OleDb
Public Class stud
    Public Sub fillsem()
        cmbsem.Items.Clear()
        connection()
        tbl = New DataTable
        adpt = New OleDbDataAdapter("SELECT * FROM SEMESTER_MASTER", con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                cmbsem.Items.Add(tbl.Rows(i).Item(1).ToString)
            Next
        End If

    End Sub
    Dim i As Integer
    Public Sub fillbatch()
        cmbbatch.Items.Clear()
        Dim i As Integer
        For i = Val(Now.Year) To 2000 Step -1
            cmbbatch.Items.Add(i.ToString)
        Next
    End Sub
    'Public Sub fillstud()
    '    cmbsname.Items.Clear()

    '    connection()
    '    tbl = New DataTable
    '    adpt = New OleDbDataAdapter("SELECT * FROM STUDENT_MASTER", con)
    '    adpt.Fill(tbl)
    '    If tbl.Rows.Count > 0 Then
    '        Dim i As Integer
    '        For i = 0 To tbl.Rows.Count - 1
    '            cmbsname.Items.Add(tbl.Rows(i).Item(5).ToString)
    '        Next
    '    End If
    'End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillbatch()
        fillsem()
        'fillstud()
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
    End Sub





    Private Sub cmbsem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsem.SelectedIndexChanged
        cmbsubject.Items.Clear()

        If cmbsem.SelectedIndex = 0 Then
            cmbsubject.Items.Add("OR")
            cmbsubject.Items.Add("C")
            cmbsubject.Items.Add("HTML")
            cmbsubject.Items.Add("CO")
        ElseIf cmbsem.SelectedIndex = 1 Then
            cmbsubject.Items.Add("SAD")
            cmbsubject.Items.Add("C++")
            cmbsubject.Items.Add("CN")
            cmbsubject.Items.Add("DS")
        ElseIf cmbsem.SelectedIndex = 2 Then
            cmbsubject.Items.Add("OS")
            cmbsubject.Items.Add("JAVA")
            cmbsubject.Items.Add("CG")
            cmbsubject.Items.Add("ORACLE")
        ElseIf cmbsem.SelectedIndex = 3 Then
            cmbsubject.Items.Add("PHP")
            cmbsubject.Items.Add("ADVANCED JAVA")
            cmbsubject.Items.Add("SE")
            cmbsubject.Items.Add("VB.NET")
        ElseIf cmbsem.SelectedIndex = 4 Then
            cmbsubject.Items.Add("AI")
            cmbsubject.Items.Add("LINUX")
            cmbsubject.Items.Add("WEB PROGRAMMING-2")

        End If
    End Sub







    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub cmbbatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbatch.SelectedIndexChanged
        cmbsname.Items.Clear()

        If cmbbatch.SelectedIndex = 2 Then

            connection()
            tbl = New DataTable
            adpt = New OleDbDataAdapter("SELECT * FROM STUDENT_MASTER WHERE REG_YEAR=" & cmbbatch.Text, con)
            adpt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                Dim i As Integer
                For i = 0 To tbl.Rows.Count - 1
                    cmbsname.Items.Add(tbl.Rows(i).Item(5).ToString)
                Next
            End If
        End If
    End Sub

    Private Sub cmbbookid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbookid.SelectedIndexChanged

        DataGridView1.Rows.Clear()

        connection()
        tbl = New DataTable
        adpt = New OleDbDataAdapter("SELECT * FROM LIBRARY WHERE BOOK_ID=" & cmbbookid.Text, con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = tbl.Rows(i).Item(1).ToString
                DataGridView1.Rows(i).Cells(1).Value = tbl.Rows(i).Item(2).ToString
                DataGridView1.Rows(i).Cells(2).Value = tbl.Rows(i).Item(3).ToString


            Next

        End If




    End Sub

    Private Sub cmbsubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubject.SelectedIndexChanged
        ' DataGridView1.ClearSelection()
        cmbbookid.Items.Clear()
        connection()
        tbl = New DataTable
        adpt = New OleDbDataAdapter("SELECT * FROM LIBRARY WHERE BOOK_NAME='" & cmbsubject.Text & "'", con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                cmbbookid.Items.Add(tbl.Rows(i).Item(1).ToString)


            Next
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(3).Value = True Then
                DataGridView1.Rows(i).Cells(4).Value = Now.Date.ToString
            Else
                DataGridView1.Rows(i).Cells(4).Value = ""
            End If

            If DataGridView1.Rows(i).Cells(5).Value = True Then
                DataGridView1.Columns(6).Visible = False
                DataGridView1.Rows(i).Cells(7).Value = Now.Date.ToString
                'cmd = New OleDbCommand("DELETE FROM STUD_BOOK_DETAIL WHERE BOOK_ID=" & cmbbookid.Text, con)
                'cmd.ExecuteScalar()
                cmd = New OleDbCommand("UPDATE STUD_BOOK_DETAIL Set STUD_NAME='" & cmbsname.SelectedItem.ToString & "', BOOK_ID=" & DataGridView1.Rows(i).Cells(0).Value & ", BOOK_NAME='" & DataGridView1.Rows(i).Cells(1).Value & "', BOOK_AUTHOR='" & DataGridView1.Rows(i).Cells(2).Value & "', ISSUE_DATE='" & DataGridView1.Rows(i).Cells(7).Value & "' WHERE BOOK_ID=" & cmbbookid.Text, con)
                cmd.ExecuteScalar()

                MsgBox("Renewed")
            Else
                DataGridView1.Rows(i).Cells(7).Value = ""
            End If
            If DataGridView1.Rows(i).Cells(6).Value = True Then
                DataGridView1.Columns(5).Visible = False
                DataGridView1.Rows(i).Cells(7).Value = Now.Date.ToString
                cmd = New OleDbCommand("DELETE FROM STUD_BOOK_DETAIL WHERE BOOK_ID=" & cmbbookid.Text, con)
                cmd.ExecuteScalar()


                MsgBox("Submitted")
            Else
                DataGridView1.Rows(i).Cells(7).Value = ""
            End If
        Next



    End Sub






    Private Sub btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        tbl = New DataTable
        adpt = New OleDbDataAdapter("SELECT * FROM STUD_BOOK_DETAIL", con)
        Dim qry As String = ""
        For i = 0 To DataGridView1.Rows.Count - 1

            If Val(DataGridView1.Rows(i).Cells(0).Value) <> 0 Then


                Try
                    qry = "INSERT INTO STUD_BOOK_DETAIL Values('" & cmbsname.SelectedItem.ToString & "'," & DataGridView1.Rows(i).Cells(0).Value & ",'" & DataGridView1.Rows(i).Cells(1).Value & "','" & DataGridView1.Rows(i).Cells(2).Value & "','" & DataGridView1.Rows(i).Cells(4).Value & "')"
                    cmd = New OleDbCommand(qry, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inserted")
                Catch ex As Exception
                    MsgBox("Book is already allocated")
                End Try



            End If

        Next

    End Sub

    Private Sub btnrenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrenew.Click
        DataGridView1.Columns(5).Visible = True
        DataGridView1.Columns(6).Visible = True
        DataGridView1.Columns(7).Visible = True
    End Sub

    Private Sub cmbsubject_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbsubject.SelectedValueChanged





    End Sub

    Private Sub cmbbookid_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbbookid.SelectedValueChanged
        DataGridView1.ClearSelection()
        DataGridView1.Rows.Clear()

        tbl = New DataTable
        adpt = New OleDbDataAdapter("select * from STUD_BOOK_DETAIL", con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                DataGridView1.Rows.Add()
                If cmbbookid.SelectedItem.ToString = tbl.Rows(i).Item(1).ToString Then

                    DataGridView1.Rows(i).Cells(0).Value = tbl.Rows(i).Item(1).ToString
                    DataGridView1.Rows(i).Cells(1).Value = tbl.Rows(i).Item(2).ToString
                    DataGridView1.Rows(i).Cells(2).Value = tbl.Rows(i).Item(3).ToString
                    DataGridView1.Rows(i).Cells(3).Value = True
                    DataGridView1.Rows(i).Cells(4).Value = tbl.Rows(i).Item(4).ToString

                End If
            Next

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        cmbbookid.Text = ""

        cmbsubject.Text = ""
        cmbsem.Text = ""
        cmbbatch.Text = ""
        cmbsname.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        stud_report.Show()

    End Sub
End Class
