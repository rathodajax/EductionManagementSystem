Imports System.Data
Imports System.Data.OleDb

Public Class Fees_Details
    Dim cnn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As Data.DataSet


    Dim connetionString As String = Nothing
    Dim connection As OleDbConnection
    Dim command As OleDbCommand
    Dim adapter As New OleDbDataAdapter()

    Dim i As Integer = 0
    Dim sql As String = Nothing
    Dim imgstr As String

    Dim tot As Integer = 0
    Public id As Integer
    Dim myflag As Boolean
    Dim setflag As Integer = 0

    Private Sub Combosem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combosem.SelectedIndexChanged

        myflag = False


        lbltitle.Text = "Student Information For " & Combosem.SelectedItem
        Button1.Enabled = True
        clean()
        fee_detail_false()
        DataGridView1.Refresh()
        Comborno.Items.Clear()
        Try
            For j As Integer = 0 To DataGridView1.Rows.Count
                DataGridView1.Rows.RemoveAt(0)
            Next
        Catch ex As Exception

        End Try
        sql = "select * FROM STUDENT_MASTER WHERE  STU_ID IN (SELECT STU_ID FROM FEES_MASTER where taken_for='" & Combosem.SelectedItem & "') and CURRENTCLASS='" & Combosem.SelectedItem & "' and reg_year=" & comboyear.SelectedItem

        connect()
        da.Fill(ds, "STUDENT_MASTER")

        Dim dt As DataTable
        dt = ds.Tables("STUDENT_MASTER")
        Dim dr As DataRow
        Dim i As Integer

        For i = 0 To dt.Rows.Count - 1
            dr = dt.Rows(i)
            Comborno.Items.Add(dr("STU_ID").ToString)

        Next

        cnn.Close()

        sql = "select stu_id,receipt_no,taken_for,fee_date,tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee,fee_tot from fees_master where stu_id in(select stu_id from student_master where reg_year=" & comboyear.SelectedItem & ") and taken_for='" & Combosem.SelectedItem & "'"
        connect()
        da.Fill(ds, "FEES_MASTER")




        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Dim arr(10) As Object
            For k As Integer = 0 To 9 Step 1
                arr(k) = ds.Tables(0).Rows(j).Item(k).ToString

            Next
            DataGridView1.Rows.Add(arr)

        Next
        tot = 0
        For c As Integer = 0 To ds.Tables(0).Rows.Count - 1
            tot = tot + ds.Tables(0).Rows(c).Item("fee_tot")
        Next
        txttotalr.Text = tot.ToString
        cnn.Close()
    End Sub
    Sub connect()
        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb"
        cnn = New OleDbConnection(connetionString)
        command = New OleDbCommand()
        cnn.Open()
        da = New OleDbDataAdapter(sql, cnn)
        ds = New Data.DataSet
    End Sub
    Sub clean()
      
        lblcodes.Text = ""

        lblctgr.Text = ""
        lbldate.Text = ""
        lblgender.Text = ""
        lblrno.Text = ""
        lblsname.Text = ""
        lblyear.Text = ""
        stdimg.Load("Images/None.jpg")
    End Sub

    Private Sub Comborno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comborno.SelectedIndexChanged
        Dim id As Integer = Comborno.SelectedItem
        Dim cast As Integer
        Dim dt As DateTime = Now
        Button1.Enabled = False

        lbltitle.Text = "Student Information "
        lbldate.Text = Format(dt, "dd/MM/yyyy hh:mm:ss")

        Try
            For j As Integer = 0 To DataGridView1.Rows.Count
                DataGridView1.Rows.RemoveAt(0)
            Next
        Catch ex As Exception

        End Try

        stdimg.Load("Images/None.jpg")
        sql = "select * from student_master where stu_id=" & id & " and currentclass='" & Combosem.SelectedItem & "'"
        connect()
        da.Fill(ds, "STUDENT_MASTER")

        lblsname.Text = ds.Tables(0).Rows(0).Item("stu_name")
        lblyear.Text = ds.Tables(0).Rows(0).Item("reg_year")
        lblrno.Text = ds.Tables(0).Rows(0).Item("stu_rno")
        lblgender.Text = ds.Tables(0).Rows(0).Item("stu_gen")

        cast = ds.Tables(0).Rows(0).Item("stu_cast_id")


        Try
            imgstr = ds.Tables(0).Rows(0).Item("stu_photo").ToString
            If imgstr <> "" Then
                stdimg.Load(imgstr)
            End If
        Catch ex As Exception

        End Try
        
        sql = "select cast_name from cast_master where cast_id=" & cast & " "
        cnn.Close()
        connect()
        da.Fill(ds, "cast_master")
        lblctgr.Text = ds.Tables(0).Rows(0).Item("CAST_NAME")
        cnn.Close()


        Dim index As Integer = Comborno.SelectedIndex
        sql = "select stu_id,stu_cast_id,admission_type from student_master where stu_id=" & Comborno.SelectedItem
        connect()
        da.Fill(ds, "student_master")

        Dim str As String = ""
        Dim sid As Integer
        Dim flag As Integer
        str += (Combosem.SelectedIndex + 1).ToString
        sid = ds.Tables(0).Rows(0).Item("STU_ID")
        str += ds.Tables(0).Rows(0).Item("STU_CAST_ID").ToString
        flag = ds.Tables(0).Rows(0).Item("admission_type").ToString
        If flag = 1 Or flag = 3 Then
            str += "G"
        Else
            str += "S"
        End If
        cnn.Close()

        sql = "select * from fee_code_master where code_no='" & str & "'"
        connect()
        da.Fill(ds, "fee_code_master")
        lblcodes.Text = ds.Tables(0).Rows(0).Item("code_detail")

        cnn.Close()

        sql = "select stu_id,receipt_no,taken_for,fee_date,tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee,fee_tot from fees_master where stu_id in(select stu_id from student_master where stu_id=" & Comborno.SelectedItem & ") and taken_for='" & Combosem.SelectedItem & "'"
        connect()
        da.Fill(ds, "fees_master")
        DataGridView1.Refresh()
        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Dim arr(10) As Object
            For k As Integer = 0 To 9 Step 1
                arr(k) = ds.Tables(0).Rows(j).Item(k).ToString
            Next
            DataGridView1.Rows.Add(arr)

        Next


        tot = 0
        For c As Integer = 0 To ds.Tables(0).Rows.Count - 1
            tot = tot + ds.Tables(0).Rows(c).Item("fee_tot")
        Next
        txttotalr.Text = tot.ToString
        cnn.Close()

        fee_detail_true()

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Fees_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myflag = True
        Dim dt As DateTime = Now
        lbldate.Text = Format(dt, "dd/MM/yyyy hh:mm:ss")


        Dim year As Integer = dt.Year

        For i As Integer = year To 2000 Step -1
            comboyear.Items.Add(i)
        Next
        comboyear.SelectedItem = year
        fee_detail_false()
    End Sub
    Sub fee_detail_true()
        Label3.Visible = True
        lblc.Visible = True
        Label17.Visible = True
        lblrno.Visible = True
        lblcodes.Visible = True
        lbldate.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label8.Visible = True
        lblsname.Visible = True
        lblyear.Visible = True
        lblgender.Visible = True
        lblctgr.Visible = True
        stdimg.Visible = True
    End Sub
    Sub fee_detail_false()

        Label3.Visible = False
        lblc.Visible = False
        Label17.Visible = False
        lblrno.Visible = False
        lblcodes.Visible = False
        lbldate.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        lblsname.Visible = False
        lblyear.Visible = False
        lblgender.Visible = False
        lblctgr.Visible = False
        stdimg.Visible = False

    End Sub
    Private Sub lbltotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotal.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotalr.TextChanged

    End Sub

    
    Private Sub comboyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboyear.SelectedIndexChanged
        clean()
        ' Combosem.SelectedIndex = 0
        Combosem.Items.Clear()
        sql = "select semester_name from semester_master"
        connect()
        da.Fill(ds, "semester_master")

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Combosem.Items.Add(ds.Tables(0).Rows(i).Item("semester_name").ToString)
        Next
        cnn.Close()

        myflag = True
        setflag = 0

        Try
            For j As Integer = 0 To DataGridView1.Rows.Count
                DataGridView1.Rows.RemoveAt(0)
            Next
        Catch ex As Exception

        End Try

        sql = "select stu_id,receipt_no,taken_for,fee_date,tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee,fee_tot from fees_master where stu_id in (select stu_id from student_master where reg_year=" & comboyear.SelectedItem & ")"
        connect()
        da.Fill(ds, "FEES_MASTER")

        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Dim arr(10) As Object
            For k As Integer = 0 To 9 Step 1
                arr(k) = ds.Tables(0).Rows(j).Item(k).ToString

            Next

            DataGridView1.Rows.Add(arr)

        Next
        tot = 0
        For c As Integer = 0 To ds.Tables(0).Rows.Count - 1
            tot = tot + ds.Tables(0).Rows(c).Item("fee_tot")
        Next
        txttotalr.Text = tot.ToString
        cnn.Close()

        lbltitle.Text = "Student Information For " & comboyear.SelectedItem
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim r As Integer = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1.Rows(r).Cells(0).Value
        Dim ans As Integer = MsgBox("Are You Sure You Want to Show Details", MsgBoxStyle.YesNo)
        If ans = vbYes Then
            Student_Info.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rpt As New Report_Semesterwise
        If setflag = 0 Then
            myflag = True
            setflag = 1
        End If
        If myflag = False Then
            sql = "select stu_id,receipt_no,taken_for,fee_date,tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee,fee_tot from fees_master where stu_id in(select stu_id from student_master where reg_year=" & comboyear.SelectedItem & " and currentclass='" & Combosem.SelectedItem & "') and taken_for='" & Combosem.SelectedItem & "'"
        Else
            sql = "select stu_id,receipt_no,taken_for,fee_date,tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee,fee_tot from fees_master where stu_id in (select stu_id from student_master where reg_year=" & comboyear.SelectedItem & ")"


        End If

        connect()
        da.Fill(ds, "FEES_MASTER")
        rpt.SetDataSource(ds)
        Show_SemesterWise.Crystal_SemesterWise.ReportSource = rpt
        Show_SemesterWise.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class