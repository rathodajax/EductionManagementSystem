Imports System.Data
Imports System.Data.OleDb

Public Class Fees_Recieve
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
    Dim r As OleDbDataReader



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combosem.SelectedIndexChanged
        clean()


        sql = "select * FROM STUDENT_MASTER WHERE IS_ACTIVE=yes and STU_ID  NOT IN (SELECT STU_ID FROM FEES_MASTER WHERE taken_for='" & Combosem.SelectedItem & "') and CURRENTCLASS='" & Combosem.SelectedItem & "' and reg_year=" & comboyear.SelectedItem & "   "

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

        btnsave.Enabled = False
      
        
    End Sub


    Sub connect()
        connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb"
        cnn = New OleDbConnection(connetionString)
        command = New OleDbCommand()
        cnn.Open()
        da = New OleDbDataAdapter(sql, cnn)
        ds = New Data.DataSet
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim tf, libf, sactf, uf, labf, totf As Integer

        Dim fid As Integer
        Dim fdate As Date
        Dim takenfor As String
        Dim cnt As Integer
        Dim rno As String

        If txtrcptno.Text = "" Then
            MsgBox("Please Enter Reciept No.")
        ElseIf txtcm.Text = "" Then
            MsgBox("Please Enter Caution Money")
        ElseIf txtlabf.Text = "" Then
            MsgBox("Please Enter Lab Fees")
        ElseIf txtld.Text = "" Then
            MsgBox("Please Enter Library Deposite")
        ElseIf txtlf.Text = "" Then
            MsgBox("Please Enter Library Fees")
        ElseIf txtrf.Text = "" Then
            MsgBox("Please Enter Regestration Fees")
        ElseIf txtsaf.Text = "" Then
            MsgBox("Please Enter Student Activity Fees")
        ElseIf txttf.Text = "" Then
            MsgBox("Please Enter Tuation Fees")
        ElseIf txtuf.Text = "" Then
            MsgBox("Please Enter Union Fees")
        Else
            sql = "select * from fees_master"
            connect()
            da.Fill(ds, "fees_master")
            cnt = ds.Tables(0).Rows.Count
            cnn.Close()

            Dim index As Integer = Comborno.SelectedIndex
            sql = "select stu_id,stu_cast_id,admission_type from student_master where stu_id=" & Comborno.SelectedItem & ""
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



            sql = "select tui_fee,lib_fee,stu_act_fee,uni_fee,lab_fee from fee_code_master where code_no='" & str & "'"
            da = New OleDbDataAdapter(sql, cnn)

            ds = New DataSet
            da.Fill(ds, "student_master")



            fdate = Date.Now
            fid = cnt + 1
            takenfor = Combosem.SelectedItem.ToString

            rno = txtrcptno.Text
            tf = ds.Tables(0).Rows(0).Item("tui_fee")
            libf = ds.Tables(0).Rows(0).Item("lib_fee")
            sactf = ds.Tables(0).Rows(0).Item("stu_act_fee")
            uf = ds.Tables(0).Rows(0).Item("uni_fee")
            labf = ds.Tables(0).Rows(0).Item("lab_fee")

            totf = tf + libf + sactf + uf + labf

            sql = "insert into fees_master values(" & fid & "," & sid & ",'" & rno & "','" & takenfor & "','" & fdate & "'," & tf & "," & libf & "," & sactf & "," & uf & "," & labf & "," & totf & ", 'ABC' )"
            cmd = New OleDbCommand(sql, cnn)
            Dim i As Integer = cmd.ExecuteNonQuery()
            cnn.Close()
            Dim ans As Integer = MsgBox("Record Saved Successfully, Do You Want to Print ?", MsgBoxStyle.YesNo, "Fees Reciept")
            If ans = vbYes Then

                sql = "select student_master.stu_name,student_master.currentclass,fees_master.tui_fee,fees_master.lib_fee,fees_master.stu_act_fee,fees_master.uni_fee,fees_master.lab_fee,fees_master.fee_tot from student_master inner join fees_master on student_master.stu_id=fees_master.stu_id where fees_master.stu_id=" & Comborno.SelectedItem
                connect()
                Dim dt As New Data.DataTable
                da.Fill(dt)


                Dim rpt As New Report_Print_Receipt
                rpt.SetDataSource(dt)
                Fees_Reciept.Reciept_Viewer.ReportSource = rpt

                cnn.Close()
                Fees_Reciept.Show()
            End If




            cnn.Close()
            Comborno.Items.RemoveAt(index)


            clean()
            btnsave.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DateTime = Now
        lbldate.Text = Format(dt, "dd/MM/yyyy hh:mm:ss")

        Dim year As Integer = dt.Year

        For i As Integer = year To 2000 Step -1
            comboyear.Items.Add(i)
        Next
        comboyear.SelectedItem = year
        btnsave.Enabled = False
    End Sub


    Private Sub Comborno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comborno.SelectedIndexChanged

        Dim cnt As Integer


        sql = "select receipt_no from FEES_MASTER"
        connect()
        da.Fill(ds, "FEES_MASTER")
        cnt = ds.Tables(0).Rows.Count
       
        cnn.Close()

        Dim id As Integer = Comborno.SelectedItem
        Dim cast As Integer
        Dim dt As DateTime = Now
        lbldate.Text = Format(dt, "dd/MM/yyyy hh:mm:ss")

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

        txtcm.Text = ds.Tables(0).Rows(0).Item("cau_money")
        txtlabf.Text = ds.Tables(0).Rows(0).Item("lab_fee")
        txtld.Text = ds.Tables(0).Rows(0).Item("lib_deposite")
        txtlf.Text = ds.Tables(0).Rows(0).Item("lib_fee")
        txtrf.Text = ds.Tables(0).Rows(0).Item("reg_fee")
        txtsaf.Text = ds.Tables(0).Rows(0).Item("stu_act_fee")
        txtuf.Text = ds.Tables(0).Rows(0).Item("uni_fee")
        txttf.Text = ds.Tables(0).Rows(0).Item("tui_fee")

        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
        cnn.Close()

        If Comborno.SelectedValue <> -1 Then
            btnsave.Enabled = True
        Else
            btnsave.Enabled = False
        End If


    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtld.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldate.Click

    End Sub
    Sub clean()
        txtcm.Clear()
        txtlabf.Clear()
        txtld.Clear()
        txtlf.Clear()
        txtrcptno.Clear()
        txtrf.Clear()
        txtsaf.Clear()
        txttf.Clear()
        txttot.Clear()
        txtuf.Clear()
        lblcodes.Text = ""

        lblctgr.Text = ""
        lbldate.Text = ""
        lblgender.Text = ""
        lblrno.Text = ""
        lblsname.Text = ""
        lblyear.Text = ""
        stdimg.Load("Images/None.jpg")
        Comborno.Items.Clear()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Combosem.SelectedIndex = 0
        clean()
    End Sub

    Private Sub reportDocument1_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub lblrno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrno.Click

    End Sub

    Private Sub lblc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcode.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblroll.Click

    End Sub

    Private Sub lblcodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcodes.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldt.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

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

    End Sub

    Private Sub stdimg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdimg.Click

    End Sub

    Private Sub txtrf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrf.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub txtcm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcm.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub txttf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttf.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub txtlf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlf.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub txtsaf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsaf.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub txtuf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuf.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub

    Private Sub txtlabf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlabf.TextChanged
        txttot.Text = Val(txtcm.Text) + Val(txtlabf.Text) + Val(txtld.Text) + Val(txtlf.Text) + Val(txtrf.Text) + Val(txtsaf.Text) + Val(txttf.Text) + Val(txtuf.Text)
    End Sub
End Class









