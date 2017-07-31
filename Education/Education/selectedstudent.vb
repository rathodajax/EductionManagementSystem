Public Class selectedstudent
    Dim tb1 As DataTable
    Dim tb2 As DataTable
    Dim sql As String
    Dim sql2 As String
    Dim cid As Integer
    Dim yr As Integer


    Private Sub selectedstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        alldata()
        Dim i As Integer = 0
        sql2 = "select *from COMPANY_MASTER"
        tb2 = getdata(sql2)
        If (tb2.Rows.Count > 0) Then
            While (i < tb2.Rows.Count)
                cmbcompid.Items.Add(tb2.Rows(i).Item(1).ToString)
                i += 1
            End While
        End If
    End Sub

    Private Sub alldata()
        sql = "SELECT * FROM COMPANY_ARRIVAL_MASTER WHERE ARR_PURPOSE='INTERVIEW' OR ARR_PURPOSE='PLACEMENT' OR ARR_PURPOSE='RECRUITEMENT' OR ARR_PURPOSE='PROJECT' OR ARR_PURPOSE='JOB'"
        tb1 = getdata(sql)
        Dim i As Integer
        Dim cnt As Integer = tb1.Rows.Count
        Grid_Company.Rows.Clear()

        i = 0
        If (tb1.Rows.Count > 0) Then
            Grid_Company.Rows.Add(cnt)
            While (i < tb1.Rows.Count)
                Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(1).ToString
                sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(6).ToString
                Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(4).ToString
                Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString
                Grid_Company.Rows(i).Cells(8).Value = tb1.Rows(i).Item(0).ToString

                i += 1
            End While
        End If
    End Sub

    Private Sub Grid_Company_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Company.CellClick
        Dim j As Integer
        j = Grid_Company.CurrentRow.Index

        yr = Grid_Company.Item(3, j).Value

        cid = Grid_Company.Rows(j).Cells(8).Value

        Grid_Student.Rows.Clear()
        Grid_Selected_Student.Rows.Clear()
        checkdata()


    End Sub

    Private Sub cmbcompid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcompid.SelectedIndexChanged
        If (cmbcompid.Text = "All") Then
            alldata()
        Else
            sql = "select COMP_ID from COMPANY_MASTER WHERE COMP_NAME='" & cmbcompid.Text & "'"
            Dim idint As Integer = getInt(sql)
            ' MsgBox("" + id.ToString)

            sql = "select *from COMPANY_ARRIVAL_MASTER where COMP_ID=" & idint
            tb1 = getdata(sql)
            Dim i As Integer
            Dim cnt As Integer = tb1.Rows.Count + 1
            Grid_Company.Rows.Clear()
            Grid_Company.Rows.Add(cnt)
            i = 0
            If (tb1.Rows.Count > 0) Then
                While (i < tb1.Rows.Count)
                    Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(1).ToString
                    sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                    Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                    Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                    Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                    Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(4).ToString
                    Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                    Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(6).ToString
                    Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString
                    i += 1
                End While
            End If
        End If


    End Sub

    Private Sub checkdata()
        sql = "select *from STUDENT_MASTER where REG_YEAR=" & yr
        tb1 = New DataTable
        tb1 = getdata(sql)


        sql2 = "select *from STUDENT_SELECTED where COMP_ARR_ID=" & cid
        tb2 = New DataTable
        tb2 = getdata(sql2)

        If (Not tb2.Rows.Count > 0) Then
            Dim i As Integer = 0
            Grid_Student.Rows.Clear()
            If (tb1.Rows.Count > 0) Then
                While (i < tb1.Rows.Count)
                    Grid_Student.Rows.Add(1)
                    Grid_Student.Rows(i).Cells(1).Value = tb1.Rows(i).Item(19).ToString
                    'DataGridView2.Rows(i).Cells(2).Value = tb1.Rows(i).Item(0).ToString
                    Grid_Student.Rows(i).Cells(2).Value = tb1.Rows(i).Item(1).ToString
                    Grid_Student.Rows(i).Cells(3).Value = tb1.Rows(i).Item(4).ToString
                    Grid_Student.Rows(i).Cells(4).Value = tb1.Rows(i).Item(5).ToString
                    Grid_Student.Rows(i).Cells(5).Value = tb1.Rows(i).Item(6).ToString
                    Grid_Student.Rows(i).Cells(6).Value = tb1.Rows(i).Item(11).ToString

                    i += 1
                End While
            End If

        ElseIf (tb2.Rows.Count > 0) Then
            Dim j As Integer = 0
            Dim k As Integer = 0
            Grid_Selected_Student.Rows.Clear()
            Grid_Student.Rows.Clear()
            Dim c, cnt2 As Integer
            c = 0
            cnt2 = 0
            Dim flag As Boolean = False
            While (j < tb1.Rows.Count)
                k = 0
                flag = False
                While (k < tb2.Rows.Count)
                    If (tb1.Rows(j).Item(19).ToString = tb2.Rows(k).Item(2).ToString) Then
                        flag = True
                        Exit While

                    End If
                    k += 1
                End While
                If (flag = True) Then
                    Grid_Selected_Student.Rows.Add(1)
                    Grid_Selected_Student.Rows(c).Cells(0).Value = tb1.Rows(c).Item(19).ToString()
                    Grid_Selected_Student.Rows(c).Cells(1).Value = tb1.Rows(c).Item(5).ToString()
                    Grid_Selected_Student.Rows(c).Cells(2).Value = tb1.Rows(c).Item(4).ToString()
                    Grid_Selected_Student.Rows(c).Cells(3).Value = tb1.Rows(c).Item(1).ToString()
                    Grid_Selected_Student.Rows(c).Cells(4).Value = tb1.Rows(c).Item(11).ToString()
                    'Grid_Selected_Student.Rows(c).Cells(5).Value = tb1.Rows(c).Item(1).ToString()
                    'Grid_Selected_Student.Rows(c).Cells(6).Value = tb1.Rows(c).Item(11).ToString()
                    c += 1
                Else
                    Grid_Student.Rows.Add(1)
                    Grid_Student.Rows(cnt2).Cells(1).Value = tb1.Rows(j).Item(19).ToString
                    'DataGridView2.Rows(cnt2).Cells(2).Value = tb1.Rows(j).Item(0).ToString
                    Grid_Student.Rows(cnt2).Cells(2).Value = tb1.Rows(j).Item(1).ToString
                    Grid_Student.Rows(cnt2).Cells(3).Value = tb1.Rows(j).Item(4).ToString
                    Grid_Student.Rows(cnt2).Cells(4).Value = tb1.Rows(j).Item(5).ToString
                    Grid_Student.Rows(cnt2).Cells(5).Value = tb1.Rows(j).Item(6).ToString
                    Grid_Student.Rows(cnt2).Cells(6).Value = tb1.Rows(j).Item(11).ToString
                    cnt2 += 1
                End If
                j += 1
            End While
        End If

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim i As Integer
        For i = 0 To Grid_Student.Rows.Count - 1


            If (Grid_Student.Rows(i).Cells(0).Value = True) Then
                sql = "SELECT MAX(S_ID) FROM STUDENT_SELECTED"
                Dim maxid As Integer = getInt(sql)

                sql = "insert into STUDENT_SELECTED values(" & Val(maxid + 1) & "," & cid & ",'" & Grid_Student.Rows(i).Cells(1).Value & "')"
                insertqry2(sql)
                
            End If

        Next
        MsgBox("data inserted.....")
        checkdata()
    End Sub

   
    Private Sub Grid_Company_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Company.CellContentClick

    End Sub

    Private Sub Grid_Student_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Student.CellContentClick

    End Sub
End Class