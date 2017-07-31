Imports System.Data.OleDb
Imports System.Data
Public Class Student_All_Semester
    Dim cnn As OleDbConnection
    Dim Command As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As Data.DataSet
    Dim sql As String

    Dim connetionString As String = Nothing
    Dim tot As Integer = 0
    Sub connect()
        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb"
        cnn = New OleDbConnection(connetionString)
        Command = New OleDbCommand()
        cnn.Open()
        da = New OleDbDataAdapter(sql, cnn)
        ds = New Data.DataSet
    End Sub
    Private Sub Student_All_Semester_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select * from student_master where stu_id=" & Fees_Details.id & ""
        Dim cast As Integer
        Dim dt As DateTime = Now
        lbldate.Text = Format(dt, "dd/MM/yyyy hh:mm:ss")

        Try
            For j As Integer = 0 To DataGridView1.Rows.Count
                DataGridView1.Rows.RemoveAt(0)
            Next
        Catch ex As Exception

        End Try

        connect()
        da.Fill(ds, "STUDENT_MASTER")

        lblsname.Text = ds.Tables(0).Rows(0).Item("stu_name")
        lblyear.Text = ds.Tables(0).Rows(0).Item("reg_year")
        lblrno.Text = ds.Tables(0).Rows(0).Item("stu_rno")
        lblgender.Text = ds.Tables(0).Rows(0).Item("stu_gen")
        lblsid.Text = ds.Tables(0).Rows(0).Item("stu_id")
        cast = ds.Tables(0).Rows(0).Item("stu_cast_id")
        Try
            Dim imgstr As String = ds.Tables(0).Rows(0).Item("stu_photo").ToString
            If imgstr <> "" Then
                stdimg.Load(imgstr)
            Else
                stdimg.Load("Images/None.jpg")
            End If
        Catch ex As Exception

        End Try
       
        sql = "select cast_name from cast_master where cast_id=" & cast & " "
        cnn.Close()
        connect()
        da.Fill(ds, "cast_master")
        lblctgr.Text = ds.Tables(0).Rows(0).Item("CAST_NAME")
        cnn.Close()


        Dim index As Integer = Val(lblrno.Text)
        sql = "select stu_id,stu_cast_id,admission_type,currentclass from student_master where stu_rno='" & lblrno.Text & "' "
        connect()
        da.Fill(ds, "student_master")

        Dim str As String = ""
        Dim sid As Integer
        Dim flag As Integer

        str = ds.Tables(0).Rows(0).Item("CURRENTCLASS").ToString
        str = str.Substring(str.Length - 1)

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

        sql = "select receipt_no,taken_for,fee_date,tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee,fee_tot from fees_master where stu_id=" & lblsid.Text & " and taken_for='" & Student_Info.sem & "' "
        connect()
        da.Fill(ds, "fees_master")
        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Dim arr(10) As Object
            For k As Integer = 0 To 8 Step 1
                arr(k) = ds.Tables(0).Rows(j).Item(k).ToString
            Next
            DataGridView1.Rows.Add(arr)

        Next

        'tot = 0
        'For c As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '    tot = tot + ds.Tables(0).Rows(c).Item("fee_tot")
        'Next
        'txttotalr.Text = tot.ToString
        cnn.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class