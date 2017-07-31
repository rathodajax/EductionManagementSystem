Public Class frmArrivalComapnyReport
    Dim sql As String
    Dim tb1 As DataTable


    Private Sub frmArrivalComapnyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        companyfill()
        sql = "SELECT * FROM COMPANY_ARRIVAL_MASTER"
        tb1 = getdata(sql)
        Dim i As Integer
        Dim cnt As Integer = tb1.Rows.Count
        Grid_Company.Rows.Clear()

        i = 0
        If (tb1.Rows.Count > 0) Then
            Grid_Company.Rows.Add(cnt)
            While (i < tb1.Rows.Count)
                Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(6).ToString
                Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(4).ToString
                Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString


                i += 1
            End While
        End If
        'CrystalReportViewer1.Height = Me.Height
        'CrystalReportViewer1.Width = Me.Width

        'sql = "select *from COMPANY_ARRIVAL_MASTER"
        'tb = New DataTable
        'tb = getdata(sql)

        'rpt.SetDataSource(tb)
        'CrystalReportViewer1.ReportSource = rpt

    End Sub



    Private Sub companyfill()
        sql = "select COMP_NAME from COMPANY_MASTER"
        tb1 = New DataTable
        tb1 = getdata(sql)
        Dim i As Integer = 0
        If (tb1.Rows.Count > 0) Then
            ' MsgBox("data found")
            Do While (i < tb1.Rows.Count - 1)
                cmbcomp.Items.Add(tb1.Rows(i).Item(0).ToString)
                i += 1
            Loop
        End If
    End Sub

    Private Sub cmbbatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbatch.SelectedIndexChanged
        Dim yr As String
        yr = cmbbatch.SelectedItem.ToString
        ' MsgBox("" + yr.ToString)


        sql = "SELECT * FROM COMPANY_ARRIVAL_MASTER where BATCH_YEAR=" & Val(yr)
        tb1 = getdata(sql)
        Dim i As Integer
        Dim cnt As Integer = tb1.Rows.Count
        Grid_Company.Rows.Clear()

        i = 0
        If (tb1.Rows.Count > 0) Then
            'MsgBox("data found")
            Grid_Company.Rows.Add(cnt)
            While (i < tb1.Rows.Count)
                Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(6).ToString
                Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(4).ToString
                Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString


                i += 1
            End While
        End If
    End Sub

    Private Sub cmbsem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsem.SelectedIndexChanged
        Dim sem As String
        sem = cmbsem.SelectedItem.ToString
        ' MsgBox("" + yr.ToString)


        sql = "SELECT * FROM COMPANY_ARRIVAL_MASTER where SEM='" & (sem) & "'"
        tb1 = getdata(sql)
        Dim i As Integer
        Dim cnt As Integer = tb1.Rows.Count
        Grid_Company.Rows.Clear()

        i = 0
        If (tb1.Rows.Count > 0) Then
            'MsgBox("data found")
            Grid_Company.Rows.Add(cnt)
            While (i < tb1.Rows.Count)
                Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(6).ToString
                Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(4).ToString
                Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString


                i += 1
            End While
        End If
    End Sub

    Private Sub cmbcomp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcomp.SelectedIndexChanged
        Dim cname As String
        Dim cid As Integer
        cname = cmbcomp.SelectedItem.ToString
        'MsgBox("" + cname.ToString)


        If cname = "All" Then
            sql = "SELECT * FROM COMPANY_ARRIVAL_MASTER"
            tb1 = getdata(sql)
            Dim i As Integer
            Dim cnt As Integer = tb1.Rows.Count
            Grid_Company.Rows.Clear()

            i = 0
            If (tb1.Rows.Count > 0) Then
                Grid_Company.Rows.Add(cnt)
                While (i < tb1.Rows.Count)
                    Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                    sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                    Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                    Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                    Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                    Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(6).ToString
                    Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                    Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(4).ToString
                    Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString
                    
                    i += 1
                End While
            End If
        Else
            sql = "select COMP_ID from COMPANY_MASTER where COMP_NAME='" & cname & "'"
            cid = getInt(sql)

            sql = "SELECT * FROM COMPANY_ARRIVAL_MASTER where COMP_ARR_Id=" & cid
            tb1 = getdata(sql)
            Dim i As Integer
            Dim cnt As Integer = tb1.Rows.Count
            Grid_Company.Rows.Clear()

            i = 0
            If (tb1.Rows.Count > 0) Then
                'MsgBox("data found")
                Grid_Company.Rows.Add(cnt)
                While (i < tb1.Rows.Count)
                    Grid_Company.Rows(i).Cells(0).Value = tb1.Rows(i).Item(0).ToString
                    sql = "select COMP_NAME from COMPANY_MASTER WHERE COMP_ID=" & tb1.Rows(i).Item(1)
                    Grid_Company.Rows(i).Cells(1).Value = getstr(sql)

                    Grid_Company.Rows(i).Cells(2).Value = tb1.Rows(i).Item(2).ToString
                    Grid_Company.Rows(i).Cells(3).Value = tb1.Rows(i).Item(7).ToString
                    Grid_Company.Rows(i).Cells(4).Value = tb1.Rows(i).Item(6).ToString
                    Grid_Company.Rows(i).Cells(5).Value = tb1.Rows(i).Item(5).ToString
                    Grid_Company.Rows(i).Cells(6).Value = tb1.Rows(i).Item(4).ToString
                    Grid_Company.Rows(i).Cells(7).Value = tb1.Rows(i).Item(3).ToString


                    i += 1
                End While
            End If
        End If


        
    End Sub

    Private Sub Grid_Company_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid_Company.CellClick
        Dim i As Integer
        i = Grid_Company.CurrentRow.Index


    End Sub
End Class