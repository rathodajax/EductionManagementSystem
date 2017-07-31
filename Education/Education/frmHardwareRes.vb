Public Class frmHardwareRes

    Dim obj As New Concls
    Dim dt1, dt2 As New DataTable

    Dim i As Integer = 0
    Dim flag As Boolean
    Dim strStatus() As String

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt1.Clear()
        dt1 = obj.GetTableQury("SELECT A.*,B.STU_NAME,C.PC_NO,D.DEVICE_NAME,E.FAULT_DESC FROM REQUEST_DETAILS As A,STUDENT_MASTER As B,PC_MASTER As C,DEVICE_MASTER AS D,FAULT_MASTER AS E WHERE A.STUD_ID=B.STU_ID AND C.ID=A.P_ID AND A.D_ID=D.DEVICE_ID AND A.F_ID=E.F_ID Order by A.REQ_DATE DESC")
        dt2 = obj.GetTableQury("SELECT * FROM STATUS_MASTER")
        flag = False


        'DataGridView1.AutoGenerateColumns = False





        'Dim col1 As New DataGridViewTextBoxColumn
        'col1.DataPropertyName = "ID"
        'col1.HeaderText = "REQ_ID"
        'col1.Name = "ID"


        'DataGridView1.Columns.Add(col1)



        'Dim col2 As New DataGridViewTextBoxColumn
        'col2.DataPropertyName = "STU_NAME"
        'col2.HeaderText = "STUDENT_NAME"
        'col2.Name = "SNAME"

        'DataGridView1.Columns.Add(col2)

        'Dim col3 As New DataGridViewTextBoxColumn
        'col3.DataPropertyName = "PC_NO"
        'col3.HeaderText = "PC_NO"
        'col3.Name = "PNO"

        'DataGridView1.Columns.Add(col3)


        'Dim col4 As New DataGridViewTextBoxColumn
        'col4.DataPropertyName = "REQ_DESC"
        'col4.HeaderText = "REQ_DESC"
        'col4.Name = "RDESC"

        'DataGridView1.Columns.Add(col4)

        'Dim col5 As New DataGridViewComboBoxColumn
        'col5.DataPropertyName = "REQ_STATUS"

        'col5.DisplayMember = "REQ_STATUS"

        'col5.ValueMember = "REQ_STATUS"



        'col5.HeaderText = "REQ_DESC"
        'col5.Name = "RDESC"

        'DataGridView1.Columns.Add(col5)
        If dt1.Rows.Count > 0 Then
            Dim j, k As Integer
            Dim dbcell As New DataGridViewComboBoxCell
            For j = 0 To dt1.Rows.Count - 1



                dgvallrequests.Rows.Add()


                Dim uid As Integer = dt1.Rows(j).Item("USER_ID")
                Dim uname As String = obj.GetTableQuryExecScalarStr("SELECT USER_NAME FROM LOGIN_MASTER WHERE USER_ID=" & uid)


                dgvallrequests.Rows(j).Cells(0).Value = dt1.Rows(j).Item("ID").ToString
                dgvallrequests.Rows(j).Cells(1).Value = uname
                dgvallrequests.Rows(j).Cells(2).Value = dt1.Rows(j).Item("STU_NAME").ToString
                dgvallrequests.Rows(j).Cells(3).Value = dt1.Rows(j).Item("REQ_DATE").ToString
                dgvallrequests.Rows(j).Cells(4).Value = dt1.Rows(j).Item("PC_NO").ToString
                dgvallrequests.Rows(j).Cells(5).Value = dt1.Rows(j).Item("DEVICE_NAME").ToString
                dgvallrequests.Rows(j).Cells(6).Value = dt1.Rows(j).Item("FAULT_DESC").ToString
                dgvallrequests.Rows(j).Cells(7).Value = dt1.Rows(j).Item("REQ_DESC").ToString







                dbcell = dgvallrequests.Rows(j).Cells(8)

                dbcell.Items.Clear()

                For k = 0 To dt2.Rows.Count - 1

                    dbcell.Items.Add(dt2.Rows(k).Item("STATUS_NAME").ToString)
                Next
                'DataGridView1.Rows(j).Cells(4) = dbcell
                'Dim strSt As String = 


                Dim stid As Integer = dt1.Rows(j).Item("STATUS_ID")
                Dim strSt As String = obj.GetTableQuryExecScalarStr("SELECT STATUS_NAME FROM STATUS_MASTER WHERE ID=" & stid)
                Dim ind As Integer
                Try
                    ind = dbcell.Items.IndexOf(strSt)
                Catch ex As Exception

                End Try


                dbcell.Value = dbcell.Items(ind).ToString


                'strStatus(j) = dbcell.Items(0)

            Next


        End If

        'DataGridView1.Columns(3).DataPropertyName = "REQ_DESC"
        'DataGridView1.Columns(4).DisplayIndex = 4

        'Dim dbcell2 As New DataGridViewComboBoxCell
        'Dim x As Integer = 0
        'For x = 0 To DataGridView1.Rows.Count - 1
        '    dbcell2.Items.Clear()



        '    dbcell2 = DataGridView1.Rows(x).Cells(7)
        '    strStatus(x) = dbcell2.Items(0).ToString



        'Next










        'DataGridView1.DataSource = dt1


















        'For i = 0 To (dt1.Rows.Count - 1)
        '    Try
        '        DataGridView1.Rows(i).Cells(0).Value = dt1.Rows(0).Item(0).ToString
        '    Catch ex As Exception
        '        MsgBox(ex.Message.ToString)


        '    End Try

        'Next







        dgvallrequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvallrequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells












    End Sub

    Private Sub Form2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim i As Integer = 0
        Dim j As Integer = 0

        Me.Panel1.Width = Me.Width
        Me.Panel2.Width = Me.Width

        Dim wd As Integer = Me.Width
        wd = wd / 2
        Dim lwd As Integer = Me.Label5.Width
        lwd = lwd / 2
        Me.Label5.Location = New System.Drawing.Point((wd - lwd), 8)
        'Me.Panel2.Location = New System.Drawing.Point(0, (Me.Height - Me.Panel2.Height - 39))


        Me.btnsave.Location = New System.Drawing.Point((wd - 137), 15)
        Me.btnReport.Location = New System.Drawing.Point(Me.btnsave.Location.X + 100, 15)
        Me.btnExit.Location = New System.Drawing.Point(Me.btnReport.Location.X + 100, 15)

        i = Me.GroupBox2.Location.Y
        Me.GroupBox2.Location = New System.Drawing.Point((wd - (Me.GroupBox2.Width / 2) - 7), i)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        updateGrid()

    End Sub
    Public Sub updateGrid()
        Dim i As Integer = 0
        Dim cnt As Integer = 0
        For i = 0 To dgvallrequests.Rows.Count - 1
            Dim str As String = dgvallrequests.Rows(i).Cells(8).Value.ToString
            Dim strId As String = dgvallrequests.Rows(i).Cells(0).Value.ToString

            Dim id As Integer = obj.GetTableQuryExecScalar("SELECT ID FROM STATUS_MASTER WHERE STATUS_NAME='" & str & "'")
            Dim csid As Integer = obj.GetTableQuryExecScalar("SELECT STATUS_ID FROM REQUEST_DETAILS WHERE ID=" & Val(strId) & "")

            If csid <> id Then
                Dim ch As Integer = obj.updateData("UPDATE REQUEST_DETAILS SET STATUS_ID=" & id & " WHERE ID=" & Val(strId) & "")
                cnt += 1

            End If


        Next
        If cnt > 0 Then
            MsgBox("Data Updated Successfully")
        End If




    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvallrequests.CellContentClick

    End Sub


    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvallrequests.CellValueChanged

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvallrequests.SelectionChanged
        flag = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim dt As New DataTable
        'With dt
        '    .Columns.Add(DataGridView1.Columns(0).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(1).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(2).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(3).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(4).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(5).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(6).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(7).HeaderText)
        '    .Columns.Add(DataGridView1.Columns(8).HeaderText)
        'End With

        'For Each dr As DataGridViewRow In Me.DataGridView1.Rows
        '    dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value, dr.Cells(3).Value, dr.Cells(4).Value, dr.Cells(5).Value, dr.Cells(6).Value, dr.Cells(7).Value, dr.Cells(8).Value)

        'Next


        dt = obj.GetTableQury("SELECT * FROM VReportHE Order By REQ_DATE DESC,STATUS_NAME")


        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New rptHEReport

        rptDoc.SetDataSource(dt)
        '
        frmHEReport.crptv1.ReportSource = rptDoc
        frmHEReport.MdiParent = MDIMain
        frmHEReport.WindowState = FormWindowState.Maximized




        frmHEReport.Show()

    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown




    End Sub
End Class