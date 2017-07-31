Imports System.Data.OleDb
Public Class frmview
    Dim str As String
    Dim s As Integer
    Dim j As Integer = 1
    

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        dgviewstudent.Rows.Clear()
        comboafterround.Items.Clear()
        comboselectyear.Items.Clear()
        combostudentin.Items.Clear()
        comboadmissiontype.Items.Clear()
        dept1()
    End Sub
    Private Sub btnclear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnclear.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btncancel.Focus()
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub btncancel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btncancel.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            comboselectyear.Focus()
        End If
    End Sub

    Sub FillGrid(ByVal str1 As String)
        Dim flag As Boolean = True
        Dim adpt As New OleDbDataAdapter(str1, con)
        Dim dt As New DataTable
        adpt.Fill(dt)
        dgviewstudent.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgviewstudent.Rows.Add()
            dgviewstudent.Rows(i).Cells(0).Value = j 'sr_no
            dgviewstudent.Rows(i).Cells(1).Value = dt.Rows(i).Item(0) 'stud_id
            dgviewstudent.Rows(i).Cells(2).Value = dt.Rows(i).Item(1) 'cmat_no 
            dgviewstudent.Rows(i).Cells(3).Value = dt.Rows(i).Item(2) 'roll_no
            dgviewstudent.Rows(i).Cells(4).Value = dt.Rows(i).Item(3) 'stud_name
            dgviewstudent.Rows(i).Cells(5).Value = dt.Rows(i).Item(4) 'ad_type
            dgviewstudent.Rows(i).Cells(6).Value = dt.Rows(i).Item(5) 'clg_name
            j = j + 1
        Next
        j = 1
    End Sub

    'LOAD YEAR FROM DATABASE
    Private Sub comboselectyear_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboselectyear.DropDown
        ds.Clear()
        strsql = "select * from STUDENT_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(strsql, con)
        adpt.Fill(ds, "STUDENT_MASTER")
        For k As Integer = 0 To ds.Tables("STUDENT_MASTER").Rows.Count - 1
            comboselectyear.Sorted = False

            If Me.comboselectyear.Items.Contains(ds.Tables("STUDENT_MASTER").Rows(k).Item("REG_YEAR").ToString) = True Then
            Else
                Me.comboselectyear.Items.Add(ds.Tables("STUDENT_MASTER").Rows(k).Item("REG_YEAR").ToString)
            End If
        Next
    End Sub

    Private Sub comboselectyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboselectyear.SelectedIndexChanged
        dgviewstudent.Rows.Clear()
        If comboselectyear.SelectedItem = (comboselectyear.SelectedItem) Then
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME from STUDENT_MASTER s ,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c where s.ADMISSION_TYPE=a.AT_ID and s.STU_BDEGREE_COL_ID=c.COLLEGE_ID and s.REG_YEAR = " & comboselectyear.SelectedItem.ToString
            FillGrid(str)
        End If
    End Sub
    Private Sub comboselectyear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboselectyear.KeyDown
        If e.KeyCode = Keys.Enter And comboselectyear.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f1}")
        ElseIf e.KeyCode = Keys.Enter And comboselectyear.Text <> "" Then
            combostudentin.Focus()
        End If
    End Sub

    'LOAD ROUND FROM DATABASE
    Private Sub comboafterround_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboafterround.DropDown
        ds.Clear()
        strsql = "select * from ROUND_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(strsql, con)
        adpt.Fill(ds, "ROUND_MASTER")
        For k As Integer = 0 To ds.Tables("ROUND_MASTER").Rows.Count - 1
            If Me.comboafterround.Items.Contains(ds.Tables("ROUND_MASTER").Rows(k).Item("ROUND_NAME").ToString) = True Then
            Else
                Me.comboafterround.Items.Add(ds.Tables("ROUND_MASTER").Rows(k).Item("ROUND_NAME").ToString)
            End If
        Next
    End Sub

    Private Sub comboafterround_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboafterround.SelectedIndexChanged
        dgviewstudent.Rows.Clear()
        Dim strsql As String
        Dim clg_id1 As String = "select COLLEGE_ID from SEAT_ALLOTMENT_MASTER"

        strsql = "select ROUND_ID from ROUND_MASTER "
        Dim adpt As New OleDbDataAdapter(strsql, con)
        Dim dt As New DataTable
        adpt.Fill(dt)
        If clg_id1 = "1" Then
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME from STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID=s.STU_ID and sa.AT_ID=s.ADMISSION_TYPE and sa.AT_ID=a.AT_ID and sa.AT_ID=s.ADMISSION_TYPE and sa.COLLEGE_ID=" & 1 & " and sa.ROUND_ID = " + (comboafterround.SelectedIndex + 1).ToString & " and s.REG_YEAR = " & comboselectyear.SelectedItem.ToString
            FillGrid(str)
        Else
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME from STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID=s.STU_ID and sa.AT_ID=s.ADMISSION_TYPE and sa.AT_ID=a.AT_ID and sa.AT_ID=s.ADMISSION_TYPE and sa.COLLEGE_ID=c.COLLEGE_ID and sa.ROUND_ID = " + (comboafterround.SelectedIndex + 1).ToString & " and s.REG_YEAR = " & comboselectyear.SelectedItem.ToString
            FillGrid(str)
        End If

    End Sub
    Private Sub comboafterround_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboafterround.KeyDown
        If e.KeyCode = Keys.Enter And comboafterround.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f1}")
        ElseIf e.KeyCode = Keys.Enter And comboafterround.Text <> "" Then
            comboadmissiontype.Focus()
        End If
    End Sub
    Public Sub dept1()
        Dim clg() As String = {"DEPARTMENT", "OTHER COLLEGES", "ALL"}
        For k As Integer = 0 To clg.Length - 1
            If Me.combostudentin.Items.Contains(clg(k)) Then
            Else
                Me.combostudentin.Items.Add(clg(k).ToString).ToString()
            End If
        Next
    End Sub

    Private Sub combostudentin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combostudentin.SelectedIndexChanged
        dgviewstudent.Rows.Clear()
        If combostudentin.SelectedItem = "DEPARTMENT" Then
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME from STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c ,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID = s.STU_ID and c.COLLEGE_ID = 1 and sa.COLLEGE_ID = c.COLLEGE_ID and sa.AT_ID = a.AT_ID and sa.AT_ID = s.ADMISSION_TYPE and s.ADMISSION_TYPE = a.AT_ID and s.REG_YEAR = " & comboselectyear.SelectedItem.ToString
            FillGrid(str)
        ElseIf combostudentin.SelectedItem = "OTHER COLLEGES" Then
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME from STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c ,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID = s.STU_ID and c.COLLEGE_ID <> 1 and sa.COLLEGE_ID = c.COLLEGE_ID and sa.AT_ID = a.AT_ID and sa.AT_ID = s.ADMISSION_TYPE and s.ADMISSION_TYPE = a.AT_ID and s.REG_YEAR = " & comboselectyear.SelectedItem.ToString
            FillGrid(str)
        ElseIf combostudentin.SelectedItem = "ALL" Then
            str = "select s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME from STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c ,SEAT_ALLOTMENT_MASTER sa where sa.STU_ID = s.STU_ID and c.COLLEGE_ID >= 1 and sa.COLLEGE_ID = c.COLLEGE_ID and sa.AT_ID = a.AT_ID and sa.AT_ID = s.ADMISSION_TYPE and s.ADMISSION_TYPE = a.AT_ID and s.REG_YEAR = " & comboselectyear.SelectedItem.ToString
            FillGrid(str)
        End If
    End Sub
    Private Sub combostudentin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles combostudentin.KeyDown
        If e.KeyCode = Keys.Enter And combostudentin.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f1}")
        ElseIf e.KeyCode = Keys.Enter And combostudentin.Text <> "" Then
            comboafterround.Focus()
        End If
    End Sub

    'LOAD ADMISSION TYPE FROM DATABASE
    Private Sub comboadmissiontype_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboadmissiontype.DropDown
        ds.Clear()
        strsql = "select * from ADMISSION_TYPE_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(strsql, con)
        adpt.Fill(ds, "ADMISSION_TYPE_MASTER")
        For k As Integer = 0 To ds.Tables("ADMISSION_TYPE_MASTER").Rows.Count - 1
            If Me.comboadmissiontype.Items.Contains(ds.Tables("ADMISSION_TYPE_MASTER").Rows(k).Item("AT_NAME").ToString) = True Then
            Else
                Me.comboadmissiontype.Items.Add(ds.Tables("ADMISSION_TYPE_MASTER").Rows(k).Item("AT_NAME").ToString)
            End If
        Next
    End Sub

    Private Sub comboadmissiontype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboadmissiontype.SelectedIndexChanged
        dgviewstudent.Rows.Clear()
        If comboadmissiontype.SelectedItem.Equals("3 YEAR GIA") Then
            If combostudentin.SelectedItem.Equals("DEPARTMENT") Then
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c,SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 1 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID=" & 1
            Else
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c, SEAT_ALLOTMENT_MASTER sa WHERE  sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 1 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID >" & 1
            End If

        ElseIf comboadmissiontype.SelectedItem.Equals("3 YEAR SFI") Then
            If combostudentin.SelectedItem.Equals("DEPARTMENT") Then
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 2 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID=" & 1
            Else
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and  s.ADMISSION_TYPE= " & 2 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID >" & 1
            End If

        ElseIf comboadmissiontype.SelectedItem.Equals("LETERAL GIA") Then
            If combostudentin.SelectedItem.Equals("DEPARTMENT") Then
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 3 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID = " & 1
            Else
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c, SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 3 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID > " & 1
            End If
        ElseIf comboadmissiontype.SelectedItem.Equals("LETERAL SFI") Then
            If combostudentin.SelectedItem.Equals("DEPARTMENT") Then
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c,SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 4 & " and s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID = " & 1
            Else
                dgviewstudent.Rows.Clear()
                str = "SELECT s.STU_ID,s.STU_CMATNO,s.STU_RNO,s.STU_NAME,a.AT_NAME,c.COLLEGE_NAME FROM STUDENT_MASTER s,ADMISSION_TYPE_MASTER a,COLLEGE_MASTER c,SEAT_ALLOTMENT_MASTER sa WHERE sa.STU_ID=s.STU_ID and s.ADMISSION_TYPE= " & 4 & " and  s.REG_YEAR= " & Val(comboselectyear.Text) & " and sa.COLLEGE_ID > " & 1
            End If
        End If
        FillGrid(str)
    End Sub
    Private Sub comboadmissiontype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboadmissiontype.KeyDown
        If e.KeyCode = Keys.Enter And comboadmissiontype.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{f1}")
        ElseIf e.KeyCode = Keys.Enter And comboadmissiontype.Text <> "" Then
            btnclear.Focus()
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        comboselectyear.Focus()
        dept1()
    End Sub
End Class