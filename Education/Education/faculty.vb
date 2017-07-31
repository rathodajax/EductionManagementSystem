Imports System.Data.OleDb
Public Class faculty

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub faculty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        SUBJ()

    End Sub

    Private Sub cmbsubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsubject.SelectedIndexChanged
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

    Private Sub cmbsname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsname.SelectedIndexChanged
    End Sub
    Private Sub SUBJ()
        cmbsubject.Items.Clear()


        cmbsubject.Items.Add("OR")
        cmbsubject.Items.Add("C")
        cmbsubject.Items.Add("HTML")
        cmbsubject.Items.Add("CO")

        cmbsubject.Items.Add("SAD")
        cmbsubject.Items.Add("C++")
        cmbsubject.Items.Add("CN")
        cmbsubject.Items.Add("DS")

        cmbsubject.Items.Add("OS")
        cmbsubject.Items.Add("JAVA")
        cmbsubject.Items.Add("CG")
        cmbsubject.Items.Add("ORACLE")

        cmbsubject.Items.Add("PHP")
        cmbsubject.Items.Add("ADVANCED JAVA")
        cmbsubject.Items.Add("SE")
        cmbsubject.Items.Add("VB.NET")

        cmbsubject.Items.Add("AI")
        cmbsubject.Items.Add("LINUX")
        cmbsubject.Items.Add("WEB PROGRAMMING-2")

    End Sub

    Private Sub btnrenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrenew.Click
        DataGridView1.Columns(5).Visible = True
        DataGridView1.Columns(6).Visible = True
        DataGridView1.Columns(7).Visible = True
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
                    MsgBox("data available")
                End Try



            End If

        Next

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmbbookid.Text = ""
        cmbsubject.Text = ""
        cmbsname.Text = ""


        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class