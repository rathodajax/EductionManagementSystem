Imports System.Data.OleDb
Public Class frm_update
    Dim allchecked As Boolean = False
    Dim tb1 As DataTable
    Dim str As String
    Private Sub frm_update_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Me.KeyPreview = True
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F5 Then
            PrintDialog1.ShowDialog()
        End If
    End Sub

    Private Sub frm_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_year.DropDownStyle = ComboBoxStyle.DropDownList
        connect()
        cmb_year.Focus()
        Dim str As String
        'insert data from round_master table into combobox2(cmb_round) at run time

        str = "select ROUND_NAME from ROUND_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "ROUND_MASTER")
        Dim j As Integer
        For j = 0 To ds.Tables("ROUND_MASTER").Rows.Count - 1
            Me.cmb_round.Items.Add(ds.Tables("ROUND_MASTER").Rows(j).Item("ROUND_NAME").ToString)
        Next

        'insert data from ADMISSION_TYPE_master table into combobox4(cmb_TYPE) at run time

        str = "select AT_NAME from ADMISSION_TYPE_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "ADMISSION_TYPE_MASTER")

        For j = 0 To ds.Tables("ADMISSION_TYPE_MASTER").Rows.Count - 1
            Me.cmb_type.Items.Add(ds.Tables("ADMISSION_TYPE_MASTER").Rows(j).Item("AT_NAME").ToString)
        Next
        str = "SELECT STU_ID,STU_CMATNO,STU_RNO,STU_NAME FROM STUDENT_MASTER"
        exe_query(str)
        fill_grid(str)
    End Sub
    Public Sub fill_grid(ByVal str As String)
        Dim j As Integer = 1
        tb1 = New DataTable
        Dim cha As Char() = {" "}
        Dim sa As String = ""
        Dim str1 As String()
        Dim str2 As String
       
        tb1 = getdata(str)
        If tb1.Rows.Count > 0 Then
            DataGridView1.Rows.Clear()
            For i As Integer = 0 To tb1.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(1).Value = j
                DataGridView1.Rows(i).Cells(2).Value = tb1.Rows(i).Item(0).ToString
                DataGridView1.Rows(i).Cells(3).Value = tb1.Rows(i).Item(1).ToString
                DataGridView1.Rows(i).Cells(4).Value = tb1.Rows(i).Item(2).ToString
                DataGridView1.Rows(i).Cells(5).Value = tb1.Rows(i).Item(3).ToString

                str2 = tb1.Rows(i).Item(3).ToString
                str1 = str2.Split(cha, 3)

                DataGridView1.Rows(i).Cells(6).Value = str1(0).ToString
                DataGridView1.Rows(i).Cells(8).Value = str1(1).ToString

                j = j + 1
            Next
        End If
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DataGridView1.Rows.Clear()
        cmb_round.Text = ""
        cmb_year.Text = ""
        cmb_stud_in.Text = ""
        cmb_type.Text = ""

    End Sub

    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        If allchecked Then

            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells(0).Value = False
                allchecked = False
            Next
            btn_select.Text = "Select"
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells(0).Value = True
                allchecked = True
            Next
            btn_select.Text = "DeSelect"
        End If
    End Sub

    Private Sub cmb_round_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            cmb_round.Focus()
            cmb_round.DroppedDown = True

        ElseIf e.KeyCode = Keys.Enter And cmb_year.Text <> "" Then
            cmb_stud_in.Focus()
        End If
    End Sub

    Private Sub cmb_type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            cmb_type.Focus()
            cmb_type.DroppedDown = True
        ElseIf e.KeyCode = Keys.Enter And cmb_type.Text <> "" Then
            btn_select.Focus()
        End If
    End Sub

    Private Sub cmb_stud_in_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            cmb_stud_in.Focus()
            cmb_stud_in.DroppedDown = True

        ElseIf e.KeyCode = Keys.Enter And cmb_year.Text <> "" Then
            cmb_type.Focus()
        End If
    End Sub

    Private Sub cmb_year_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_year.KeyDown
        DataGridView1.Rows.Clear()
        If e.KeyCode = Keys.Enter And cmb_year.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F1}")
        ElseIf e.KeyCode = Keys.Enter And cmb_year.Text <> "" Then
            cmb_round.Focus()
        End If
    End Sub

    Private Sub cmb_year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_year.SelectedIndexChanged
        str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME from STUDENT_MASTER s ,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID=s.STU_ID and s.REG_YEAR=" & (cmb_year.Text).ToString
        fill_grid(str)
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_type.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        If cmb_type.SelectedItem.Equals("3 YEAR GIA") Then
            If cmb_stud_in.SelectedItem.Equals("DEPARTMENT") Then
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s,SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 1 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID=" & 1
            Else
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE  sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 1 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID >" & 1
            End If

        ElseIf cmb_type.SelectedItem.Equals("3 YEAR SFI") Then
            If cmb_stud_in.SelectedItem.Equals("DEPARTMENT") Then
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 2 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID=" & 1
            Else
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and  s.ADMISSION_TYPE= " & 2 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID >" & 1
            End If

        ElseIf cmb_type.SelectedItem.Equals("LETERAL GIA") Then
            If cmb_stud_in.SelectedItem.Equals("DEPARTMENT") Then
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 3 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID = " & 1
            Else
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 3 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID > " & 1
            End If
        ElseIf cmb_type.SelectedItem.Equals("LETERAL SFI") Then
            If cmb_stud_in.SelectedItem.Equals("DEPARTMENT") Then
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 4 & " and s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID = " & 1
            Else
                DataGridView1.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s,SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 4 & " and  s.REG_YEAR= " & Val(cmb_year.Text) & " and sa.COLLEGE_ID > " & 1
        End If
        End If
        fill_grid(str)
    End Sub

    Private Sub cmb_stud_in_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_stud_in.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        If cmb_stud_in.SelectedItem.Equals("DEPARTMENT") Then
            DataGridView1.Rows.Clear()
            str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and sa.COLLEGE_ID= " & 1 & " and s.REG_YEAR= " & Val(cmb_year.Text)

        ElseIf cmb_stud_in.SelectedItem.Equals("OTHER COLLEGE") Then
            DataGridView1.Rows.Clear()
            str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and sa.COLLEGE_ID > " & 1 & " and s.REG_YEAR= " & Val(cmb_year.Text)

        Else
            DataGridView1.Rows.Clear()
            str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME FROM STUDENT_MASTER s,SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.REG_YEAR= " & Val(cmb_year.Text)
        End If

        fill_grid(str)
    End Sub

    Private Sub cmb_round_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_round.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Dim STR1 As String
        STR1 = "SELECT ROUND_ID FROM ROUND_MASTER"
        Dim dt As New DataTable
        dt = getdata(STR1)
        If cmb_round.SelectedItem.Equals("ROUND 1") Then
            DataGridView1.Rows.Clear()
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME from STUDENT_MASTER s ,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID=s.STU_ID and sa.ROUND_ID >=" & 1 & " and s.REG_YEAR=" & (cmb_year.Text).ToString
        Else
            DataGridView1.Rows.Clear()
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME from STUDENT_MASTER s ,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID=s.STU_ID and  sa.ROUND_ID= " & (cmb_round.SelectedIndex + 1) & "and s.REG_YEAR=" & (cmb_year.Text).ToString
        End If
        
        fill_grid(str)
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Data Not Available")
        Else
            For i As Integer = 0 To tb1.Rows.Count - 1
                str = "UPDATE STUDENT_MASTER s SET s.STU_RNO= " & DataGridView1.Rows(i).Cells(4).Value & " WHERE s.STU_ID= " & DataGridView1.Rows(i).Cells(2).Value.ToString
                exe_query(str)
            Next
            MsgBox("Roll No Updated SucessFully")
        End If
    End Sub


    Private Sub btn_fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fill.Click
       

    End Sub

    
  
    Private Sub btn_replace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_replace.Click
        str = "SELECT STU_ID,STU_CMATNO,STU_RNO,STU_NAME FROM STUDENT_MASTER WHERE (REG_YEAR= " & Val(cmb_year.SelectedItem) & ") "

        exe_query(str)
        Dim j As Integer = Val(TextBox1.Text)
        tb1 = New DataTable
        tb1 = getdata(str)
        For i As Integer = 0 To tb1.Rows.Count - 1
            DataGridView1.Rows(i).Cells(4).Value = j
            j = j + 1
        Next
    End Sub
End Class
