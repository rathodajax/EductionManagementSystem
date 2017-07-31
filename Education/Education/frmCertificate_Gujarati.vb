Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmCertificate_Gujarati
    Dim dt, dtStud, dtCerti, dttmp As New DataTable
    Dim sql As String

    Dim rd As ReportDocument

    Dim stu_id As Integer
    Dim rec_no As Integer

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Certificate_Gujarati_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtCerti = getRecs("SELECT CERTIFICATE_ID,CERTIFICATE_NAME FROM CERTIFICATE_MASTER WHERE CERTIFICATE_ID=5")

        For i As Integer = 0 To dtCerti.Rows.Count - 1
            cmbCertiType.Items.Add(dtCerti.Rows(i)(1))
        Next
        cmbCertiType.SelectedIndex = 0


        For i As Integer = Now.Year To 1999 Step -1
            cmbRegYear.Items.Add(i)
        Next

        dt = getRecs("SELECT SEMESTER_NAME FROM SEMESTER_MASTER")
        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlSTPassStudSem.Items.Add(dt.Rows(i)(0))
        Next
        cmbpnlSTPassStudSem.SelectedIndex = 0

        cmbpnlSTPassUniName.SelectedIndex = 0
        txtpnlpnlSTPassUniAdd.Text = "M.K. BHAVNAGAR UNIVERSITY" & vbCrLf & "Sardar Vallabbhai Patel Campus," & vbCrLf & "Gaurishankar  Lake Road," & vbCrLf & "Bhavnagar-364002."

    End Sub


    Private Sub cmbRegYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegYear.SelectedIndexChanged
        txtpnlSTPassStudRollNo.Text = ""

        If cmbRegYear.SelectedIndex <> -1 Then

            sql = "SELECT STU_ID,REG_YEAR,STU_CMATNO,REG_DATE,STU_RNO,STU_NAME,STU_ADD,STU_COR_ADD FROM STUDENT_MASTER WHERE REG_YEAR=" & cmbRegYear.SelectedItem
            dtStud = getRecs(sql)

            cmbpnlSTPassStudName.Items.Clear()
            For i = 0 To dtStud.Rows.Count - 1
                cmbpnlSTPassStudName.Items.Add(dtStud.Rows(i)(5))
            Next
        End If

    End Sub

    Private Sub cmbpnlSTPassStudName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlSTPassStudName.SelectedIndexChanged

        If cmbpnlSTPassStudName.SelectedIndex <> -1 Then
            stu_id = dtStud.Rows(cmbpnlSTPassStudName.SelectedIndex)(0)
            txtpnlSTPassStudRollNo.Text = dtStud.Rows(cmbpnlSTPassStudName.SelectedIndex)(4)
        End If

    End Sub


    Private Sub btnpnlSTPassSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlSTPassSave.Click

        If isSTPassRequireEmpty() Then

            sql = "SELECT max(REC_NO) FROM STUD_CERTIFICATE_DETAILS"
            dt = getRecs(sql)
            rec_no = CInt(dt.Rows(0)(0)) + 1

            sql = "INSERT INTO STUD_CERTIFICATE_DETAILS(REC_NO,CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,STUD_SEM,CERTIFICATE_TAKEN_DATE,STUD_DOB,UNI_NAME,UNI_ADD,STUD_AGE,DISTANCE,STP_FROM_DATE,STP_TO_DATE,JOB_SCHOLARSHIP_DETAILS,OTHER_TRA_DETAILS,FIRST_ST_PASS_NO,STUD_ADD,STUD_CORR_ADD,STUD_RNO) VALUES(" & rec_no & ",5," & stu_id & ",'" & _
                        cmbCertiType.SelectedItem & "','" & cmbpnlSTPassStudName.SelectedItem & "','" & cmbpnlSTPassStudSem.SelectedItem & "','" & _
                        Format(dtpDate.Value.Date, "MM/dd/yyyy").ToString & "','" & dtppnlSTPassStudDOB.Value.Date & "','" & cmbpnlSTPassUniName.SelectedItem & "','" & txtpnlpnlSTPassUniAdd.Text & "'," & txtpnlSTPassStudAge.Text & "," & txtpnlSTPassDistance.Text & ",'" & Format(dtppnlSTPassFromDate.Value.Date, "MM/dd/yyyy") & "','" & Format(dtppnlSTPassToDate.Value.Date, "MM/dd/yyyy") & "','" & txtpnlSTPassJob.Text & "','" & txtpnlSTPassOTD.Text & "','" & txtpnlSTPassFPN.Text & _
                        "','" & txtpnlSTPassStudAdd.Text & "','" & txtpnlSTPassStudCorrAdd.Text & "','" & txtpnlSTPassStudRollNo.Text & "')"

            performInsert(sql)

        End If
    End Sub

    Public Function isSTPassRequireEmpty() As Boolean
        If cmbRegYear.SelectedIndex = -1 Then
            MsgBox("Kindly Select Reg. Year")
            Return False
        ElseIf cmbpnlSTPassStudName.SelectedIndex = -1 Then
            MsgBox("Kindly Select Student Name")
            Return False
        ElseIf cmbpnlSTPassStudSem.SelectedIndex = -1 Then
            MsgBox("Kindly Select Student Semester")
            Return False
        ElseIf txtpnlSTPassStudAge.Text = "" Then
            MsgBox("Kindly Enter Student Age")
            Return False
        ElseIf IsNumeric(txtpnlSTPassStudAge.Text) = False Then
            MsgBox("Student Age Must Be Numeric")
            Return False
        ElseIf txtpnlSTPassDistance.Text = "" Then
            MsgBox("Kindly Enter Distance From Home / Hostel To Uni")
            Return False
        ElseIf IsNumeric(txtpnlSTPassDistance.Text) = False Then
            MsgBox("Distance From Home / Hostel To Uni Must Be Numeric")
            Return False
        Else
            Return True
        End If

    End Function


    Public Function isSTPassRequireEmpty1() As Boolean
        If cmbRegYear.SelectedIndex = -1 Then
            Return False
        ElseIf cmbpnlSTPassStudName.SelectedIndex = -1 Then
            Return False
        ElseIf cmbpnlSTPassStudSem.SelectedIndex = -1 Then
            Return False
        ElseIf txtpnlSTPassStudAge.Text = "" Then
            Return False
        ElseIf IsNumeric(txtpnlSTPassStudAge.Text) = False Then
            Return False
        ElseIf txtpnlSTPassDistance.Text = "" Then
            Return False
        ElseIf IsNumeric(txtpnlSTPassDistance.Text) = False Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbRegYear.SelectedIndex = -1
        cmbpnlSTPassStudName.SelectedIndex = -1
        txtpnlSTPassStudRollNo.Text = ""
        txtpnlSTPassStudAge.Text = ""
        txtpnlSTPassDistance.Text = ""
        txtpnlSTPassJob.Text = ""
        txtpnlSTPassOTD.Text = ""
        txtpnlSTPassFPN.Text = ""
        txtpnlSTPassStudAdd.Text = ""
        txtpnlSTPassStudCorrAdd.Text = ""
    End Sub

    Private Sub btnpnlSTPassPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlSTPassPrint.Click

        If isSTPassRequireEmpty1() = True Then

            dttmp = getRecs("SELECT DISTINCT * FROM STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" & stu_id & " AND CERTIFICATE_ID=5 AND STUD_SEM LIKE '" & cmbpnlSTPassStudSem.SelectedItem & "' AND CERTIFICATE_TAKEN_DATE=#" & Format(dtpDate.Value.Date, "MM/dd/yyyy") & "# AND STUD_DOB=#" & Format(dtppnlSTPassStudDOB.Value.Date, "MM/dd/yyyy") & "# AND STUD_AGE=" & txtpnlSTPassStudAge.Text & " AND DISTANCE=" & txtpnlSTPassDistance.Text & " AND STP_FROM_DATE=#" & Format(dtppnlSTPassFromDate.Value.Date, "MM/dd/yyyy") & "# AND STP_TO_DATE=#" & Format(dtppnlSTPassToDate.Value.Date, "MM/dd/yyyy") & "# AND JOB_SCHOLARSHIP_DETAILS='" & txtpnlSTPassJob.Text & "' AND OTHER_TRA_DETAILS='" & txtpnlSTPassOTD.Text & "' AND FIRST_ST_PASS_NO='" & txtpnlSTPassFPN.Text & "' AND STUD_ADD='" & txtpnlSTPassStudAdd.Text & "' AND STUD_CORR_ADD='" & txtpnlSTPassStudCorrAdd.Text & "'")

            If dttmp.Rows.Count > 0 Then
                rd = getRD("Reports\rptSTPass_Report.rpt")
                rd.SetDataSource(dttmp)
                frmViewReports.Report_Viewer.ReportSource = rd
                frmViewReports.Show()
            Else
                MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
            End If
        Else
            MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
        End If

    End Sub

End Class