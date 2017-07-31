Imports System
Imports System.Management
Imports System.Data.OleDb




Public Class frmStudentReq
    Dim dt As DateTime
    Dim dtstr As String
    Dim obj As New Concls
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Public uname As String
    Public uid As Integer
    Public envuname As String




    Dim objarr() As Object





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'DEPTDataSet.DEVICE_MASTER' table. You can move, or remove it, as needed.
        'Me.DEVICE_MASTERTableAdapter.Fill(Me.DEPTDataSet.DEVICE_MASTER)
        'Label3.Text = Environment.UserName
        dt = DateTime.Now.Date
        dtstr = dt.ToString("d")
















        dt1 = obj.GetTable("DEVICE_MASTER")
        dt2 = obj.GetTable("PC_MASTER")
        dt3 = obj.GetTable("FAULT_MASTER")










        cmbfaultname.DataSource = dt3

        'MsgBox(dt1.Rows.Count.ToString)
        cmbdevicename.DataSource = dt1
        cmbpcno.DataSource = dt2

        'ComboBox1.DataSource = dt2

        dt2 = obj.GetTable("STUDENT_MASTER")
        dt3 = obj.GetTableQury("SELECT DISTINCT REG_YEAR FROM STUDENT_MASTER")


        cmbregyear.DataSource = dt3
        'ComboBox6.DataSource = dt2




        'obj.setUname("Student")


        'Label12.Text = dt.Date
        'BindingSource1.DataSource = 
        uname = GlobalVariable.uname



        uid = obj.GetTableQuryExecScalar("SELECT USER_ID FROM LOGIN_MASTER WHERE USER_NAME='" + uname + "'")


        'MsgBox(uid.ToString)


        'dt1 = obj.GetTableQury("SELECT * FROM SEMESTER_MASTER")

        'ComboBox5.DataSource = dt1



        'ComboBox5.SelectedIndex = 0





        cmbregyear.Focus()





        envuname = Environment.UserName









    End Sub
    Public Sub checkStatusChange(ByVal ud As Integer)
        Dim dt As New DataTable
        dt.Clear()
        dt = obj.GetTableQury("SELECT * FROM REQUEST_DETAILS WHERE USER_ID=" & ud)
        Dim i As Integer
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If Val(dt.Rows(i).Item("STATUS_ID")) <> Val(dt.Rows(i).Item("IS_STATUS_CHANGE")) Then
                    Dim id As Integer = dt.Rows(i).Item("ID")
                    Dim stid As Integer = Val(dt.Rows(i).Item("STATUS_ID"))
                    Dim strSt As String = obj.GetTableQuryExecScalarStr("SELECT STATUS_NAME FROM STATUS_MASTER WHERE ID=" & stid)

                    Dim msg As String = "YOUR REQUEST_ID " + id.ToString + " WAS PROCESSED AND STATUS IS " + strSt + "."

                    Try
                        obj.updateData("UPDATE REQUEST_DETAILS SET IS_STATUS_CHANGE=" & stid & " WHERE ID=" & id)

                        MsgBox(msg, MsgBoxStyle.OkOnly, "Information")
                    Catch ex As Exception
                        MsgBox("Error in updating data.", MsgBoxStyle.OkOnly, "Information")


                    End Try



                End If
            Next


        End If

    End Sub

    Public Sub loadGrid(ByVal uidp As Integer)
        Dim dt As New DataTable
        dt.Clear()
        dt = obj.GetTableQury("SELECT a.ID,a.REQ_DATE,b.STU_NAME,c.PC_NO,a.REQ_DESC,d.STATUS_NAME FROM REQUEST_DETAILS AS a,STUDENT_MASTER As b,PC_MASTER As c,STATUS_MASTER As d WHERE a.STUD_ID=b.STU_ID AND c.ID=a.P_ID  AND a.STATUS_ID=d.ID AND a.USER_ID=" & uidp & " ORDER BY a.ID")
        If dt.Rows.Count > 0 Then

            dgvsentrequests.DataSource = dt
        Else
            MsgBox("No data found")
        End If


        dgvsentrequests.Columns(0).HeaderText = "REQ_ID"
        dgvsentrequests.Columns(2).HeaderText = "STUDENT_NAME"


        dgvsentrequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvsentrequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub


    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
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


        i = Me.GroupBox2.Location.Y
        Me.GroupBox2.Location = New System.Drawing.Point((wd - (Me.GroupBox2.Width / 2) - 7), i)
        j = Me.GroupBox2.Location.X



        i = Me.GroupBox3.Location.Y
        Me.GroupBox3.Location = New System.Drawing.Point(j, i)
        i = Me.GroupBox3.Location.Y
        Me.GroupBox4.Location = New System.Drawing.Point((j + Me.GroupBox3.Width + 7), i)





        Me.btnsend.Location = New System.Drawing.Point((wd - 137), 15)
        Me.btnrefresh.Location = New System.Drawing.Point(Me.btnsend.Location.X + 100, 15)
        Me.btnexit.Location = New System.Drawing.Point(Me.btnrefresh.Location.X + 100, 15)

        ''MsgBox(Me.Width.ToString)
        ''MsgBox(Me.GroupBox1.Width.ToString)


    End Sub






    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpcno.SelectedIndexChanged
        cmbdevicename.Focus()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        refreshForm()
    End Sub
    Public Sub refreshForm()
        cmbdevicename.SelectedIndex = 0
        Dim str As String = cmbdevicename.SelectedValue.ToString
        Dim did As Integer = obj.GetTableQuryExecScalar("SELECT DEVICE_ID FROM DEVICE_MASTER WHERE DEVICE_NAME='" & str & "'")
        loadFaults(did)
        txtfaultdesc.Text = ""



    End Sub

    Private Sub ComboBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfaultname.KeyDown
        If e.KeyCode = Keys.Enter And cmbfaultname.Text <> "" Then

            Dim strText As String = cmbfaultname.Text
            Dim dt As New DataTable
            dt.Clear()

            dt = obj.GetTableQury("SELECT FAULT_DESC FROM FAULT_MASTER WHERE FAULT_DESC='" & strText & "'")
            If dt.Rows.Count > 0 Then
                cmbfaultname.SelectedIndex = 0
                MsgBox("FAULT ALREADY EXIST")






            Else



                Dim str As String = cmbdevicename.SelectedValue.ToString
                Dim did As Integer = obj.GetTableQuryExecScalar("SELECT DEVICE_ID FROM DEVICE_MASTER WHERE DEVICE_NAME='" & str & "'")
                Dim i As Integer = obj.InsertData("INSERT INTO FAULT_MASTER (D_ID,FAULT_DESC) VALUES('" & did.ToString & "','" & strText & "')")
                loadFaults(did)

            End If
            cmbfaultname.DropDownStyle = ComboBoxStyle.DropDownList
















        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfaultname.SelectedIndexChanged


        If cmbfaultname.SelectedValue.ToString.Equals("Other") Then
            cmbfaultname.DropDownStyle = ComboBoxStyle.DropDown



            cmbfaultname.SelectedText = ""

        Else

            cmbfaultname.DropDownStyle = ComboBoxStyle.DropDownList

            txtfaultdesc.Focus()





        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsend.Click

        If txtfaultdesc.Text <> "" Then
            Dim pcid, did, fid As Integer

            Dim pname As String = cmbpcno.SelectedValue.ToString

            Dim dname As String = cmbdevicename.SelectedValue.ToString

            Dim fname As String = cmbfaultname.SelectedValue.ToString


            pcid = obj.GetTableQuryExecScalar("SELECT ID FROM PC_MASTER WHERE PC_NO='" & pname & "'")

            did = obj.GetTableQuryExecScalar("SELECT DEVICE_ID FROM DEVICE_MASTER WHERE DEVICE_NAME='" & dname & "'")


            fid = obj.GetTableQuryExecScalar("SELECT F_ID FROM FAULT_MASTER WHERE FAULT_DESC='" & fname & "'")

            Dim sname As String = cmbstudname.SelectedValue.ToString



            Dim sid As Integer = obj.GetTableQuryExecScalar("SELECT STU_ID FROM STUDENT_MASTER WHERE STU_NAME='" & sname & "'")




            obj.InsertData("INSERT INTO REQUEST_MASTER (STUD_ID) VALUES(" & sid & ")")

            Dim i As Integer = obj.InsertData("INSERT INTO REQUEST_DETAILS (STUD_ID,F_ID,D_ID,REQ_DESC,REQ_DATE,STATUS_ID,P_ID,IS_STATUS_CHANGE,USER_ID,ENV_UNAME) VALUES('" + sid.ToString + "','" + fid.ToString + "','" + did.ToString + "','" + txtfaultdesc.Text + "','" + dtstr + "','1','" + pcid.ToString + "','1','" + uid.ToString + "','" + envuname + "')")

            If i > 0 Then
                MsgBox("Request Sent Successfully.")
                loadGrid(uid)
                refreshForm()


            End If

        Else
            MsgBox("Enter Fault Description Must.")


        End If








    End Sub



    'Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
    '    'Dim strRegyear As String = ComboBox4.SelectedValue.ToString

    '    'loadStudnames(strRegyear)
    '    ComboBox6.Focus()




    'End Sub
    Public Sub loadStudnames(ByVal strry As String)
        Dim dt As New DataTable
        dt.Clear()



        dt = obj.GetTableQury("SELECT STU_NAME FROM STUDENT_MASTER WHERE REG_YEAR=" & Val(strry))


        cmbstudname.DataSource = dt




    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbregyear.SelectedIndexChanged

        Try
            Dim strRegyear As String = cmbregyear.SelectedValue.ToString

            loadStudnames(strRegyear)
            cmbstudname.Focus()


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim strRegyear As String = cmbregyear.SelectedValue.ToString

        loadStudnames(strRegyear)


        loadGrid(uid)
        checkStatusChange(uid)

        'MsgBox("User Id " + envuname)




    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdevicename.SelectedIndexChanged
        'Try
        Dim str As String = cmbdevicename.SelectedValue.ToString
        Dim did As Integer = obj.GetTableQuryExecScalar("SELECT DEVICE_ID FROM DEVICE_MASTER WHERE DEVICE_NAME='" & str & "'")
        loadFaults(did)
        cmbfaultname.Focus()



        'MsgBox(did.ToString)


        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)

        'End Try
    End Sub
    Public Sub loadFaults(ByVal d_id As Integer)
        Dim dt As New DataTable
        dt.Clear()
        dt = obj.GetTableQury("SELECT FAULT_DESC FROM FAULT_MASTER WHERE D_ID=" & d_id)
        dt.Rows.Add("Other")


        cmbfaultname.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsentrequests.CellContentClick

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstudname.SelectedIndexChanged
        cmbpcno.Focus()


    End Sub


    
    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
