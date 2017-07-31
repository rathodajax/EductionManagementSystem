Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports System.Data.OleDb

Public Class frmCertificates

    Dim dt, tmp, dtCerti As New DataTable
    Dim dtStud As New DataTable

    Dim sql As String

    Dim rd As New ReportDocument

    Dim rec_no As Integer
    Dim stu_id As Integer
    Dim addfrm As Boolean = False

    Private Sub Certificate_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtCerti = getRecs("SELECT CERTIFICATE_ID,CERTIFICATE_NAME FROM CERTIFICATE_MASTER WHERE CERTIFICATE_ID<=4")

        For i As Integer = 0 To dtCerti.Rows.Count - 1
            cmbCertiType.Items.Add(dtCerti.Rows(i)(1))
        Next
        cmbCertiType.SelectedIndex = 0


        dt = getRecs("SELECT DEGREE_NAME FROM DEGREE_MASTER")

        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlTCBachDegree.Items.Add(dt.Rows(i)(0))
            cmbpnlAddFormStuBatchDegree.Items.Add(dt.Rows(i)(0))
        Next
        cmbpnlTCBachDegree.SelectedIndex = 0
        cmbpnlAddFormStuBatchDegree.SelectedIndex = 0


        dt = getRecs("SELECT SEMESTER_NAME FROM SEMESTER_MASTER")

        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlAddFormAddSem.Items.Add(dt.Rows(i)(0))
            cmbpnlBonaStudSem.Items.Add(dt.Rows(i)(0))
        Next
        cmbpnlAddFormAddSem.SelectedIndex = 0
        cmbpnlBonaStudSem.SelectedIndex = 0


        dt = getRecs("SELECT CAST_NAME FROM CAST_MASTER")

        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlAddFormStuCast.Items.Add(dt.Rows(i)(0))
        Next
        cmbpnlAddFormStuCast.SelectedIndex = 0


        dt = getRecs("SELECT STATE_ID,STATE_NAME FROM STATE_MASTER")

        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlAddFormGraState.Items.Add(dt.Rows(i)(1))
        Next
        cmbpnlAddFormGraState.SelectedIndex = 0


        dt = getRecs("SELECT UNIVERSITY_ID,UNIVERSITY_NAME FROM UNIVERSITY_MASTER")

        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlAddFormGraUni.Items.Add(dt.Rows(i)(1))
        Next
        cmbpnlAddFormGraUni.SelectedIndex = 0


        For i As Integer = Now.Year To 1999 Step -1
            cmbRegYear.Items.Add(i)
        Next


        sql = "SELECT * FROM SEMESTER_MASTER"
        dt = getRecs(sql)

        cmbpnlAddFormATKTExSem.Items.Add("")
        cmbpnlAddFormAppATKTExSem.Items.Add("")
        For i As Integer = 0 To dt.Rows.Count - 1
            cmbpnlAddFormPassedExSem.Items.Add(dt.Rows(i)(1))
            cmbpnlAddFormATKTExSem.Items.Add(dt.Rows(i)(1))
            cmbpnlAddFormAppExSem.Items.Add(dt.Rows(i)(1))
            cmbpnlAddFormAppATKTExSem.Items.Add(dt.Rows(i)(1))
        Next

        cmbpnlAddFormATKTExSem.SelectedIndex = 0
        cmbpnlAddFormATKTPaperNo.SelectedIndex = 0
        cmbpnlAddFormAppATKTExSem.SelectedIndex = 0
        cmbpnlAddFormAppATKTExType.SelectedIndex = 0

        cmbpnlAddFormAppExType.Enabled = False

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbCertiType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCertiType.SelectedIndexChanged
        If cmbCertiType.SelectedIndex <> -1 Then
            setPanelsVisible(cmbCertiType.SelectedIndex)
        End If

        If cmbCertiType.SelectedIndex = 0 Then
            cmbpnlBonaStudName.Items.Clear()
        ElseIf cmbCertiType.SelectedIndex = 1 Then
            cmbpnlTCStudName.Items.Clear()
        ElseIf cmbCertiType.SelectedIndex = 2 Then
            cmbpnlFACStudName.Items.Clear()
        Else
            cmbpnlAddFormStudName.Items.Clear()
        End If
        cmbRegYear.SelectedIndex = -1
    End Sub

    '  UDF Subroutine
    Public Sub setPanelsVisible(ByVal selectedP As Integer)
        If selectedP = 0 Then
            setPanelVisibleFlags(True, False, False, False)
        ElseIf selectedP = 1 Then
            setPanelVisibleFlags(False, True, False, False)
        ElseIf selectedP = 2 Then
            setPanelVisibleFlags(False, False, True, False)
        Else
            setPanelVisibleFlags(False, False, False, True)
        End If
    End Sub

    '  UDF Subroutine
    Public Sub setPanelVisibleFlags(ByVal pBona As Boolean, ByVal pTC As Boolean, ByVal pFAC As Boolean, ByVal pAddForm As Boolean)
        pnlBonafied.Visible = pBona
        pnlTC.Visible = pTC
        pnlFAC.Visible = pFAC
        pnlAddForm.Visible = pAddForm
    End Sub

    Private Sub btnpnlFACPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlFACPrint.Click

        If cmbpnlFACStudName.SelectedIndex <> -1 Or msktxtpnlFACBatchYear.Text <> "" Then
            dt = getRecs("select distinct * from STUD_CERTIFICATE_DETAILS where STUD_ID=" & stu_id & " AND MCA_BATCH_YEAR LIKE '" & msktxtpnlFACBatchYear.Text & "' AND REASON='" & txtpnlFACRemark.Text & "' AND CERTIFICATE_TAKEN_DATE=#" & Format(dtpDate.Value.Date, "dd/MM/yyyy") & "#")

            If dt.Rows.Count > 0 Then
                rd = getRD("Reports\rptFirst_Attempt_Certificate.rpt")
                rd.SetDataSource(dt)
                frmViewReports.Report_Viewer.ReportSource = rd
                frmViewReports.Show()
            Else
                MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
            End If
        Else
            MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
        End If


    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegYear.SelectedIndexChanged

        If pnlAddForm.Visible = True Then
            txtpnlAddFormRollNo.Clear()
        End If

        If cmbRegYear.SelectedIndex <> -1 Then

            sql = "SELECT STU_ID,REG_YEAR,STU_CMATNO,REG_DATE,STU_RNO,STU_NAME FROM STUDENT_MASTER WHERE REG_YEAR=" & cmbRegYear.SelectedItem
            dtStud = getRecs(sql)

            If cmbCertiType.SelectedIndex = 0 Then
                cmbpnlBonaStudName.Items.Clear()
            ElseIf cmbCertiType.SelectedIndex = 1 Then
                cmbpnlTCStudName.Items.Clear()
            ElseIf cmbCertiType.SelectedIndex = 2 Then
                cmbpnlFACStudName.Items.Clear()
            Else
                cmbpnlAddFormStudName.Items.Clear()
            End If

            For i = 0 To dtStud.Rows.Count - 1
                If cmbCertiType.SelectedIndex = 0 Then
                    cmbpnlBonaStudName.Items.Add(dtStud.Rows(i)(5))
                ElseIf cmbCertiType.SelectedIndex = 1 Then
                    cmbpnlTCStudName.Items.Add(dtStud.Rows(i)(5))
                ElseIf cmbCertiType.SelectedIndex = 2 Then
                    cmbpnlFACStudName.Items.Add(dtStud.Rows(i)(5))
                Else
                    cmbpnlAddFormStudName.Items.Add(dtStud.Rows(i)(5))
                End If
            Next
        End If

    End Sub



    Private Sub btnpnlBonaPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlBonaPrint.Click

        If cmbpnlBonaStudName.SelectedIndex <> -1 Or txtpnlBonaReason.Text <> "" Then

            dt = getRecs("select distinct * from STUD_CERTIFICATE_DETAILS where STUD_ID=" & stu_id & " AND STUD_SEM LIKE '" & cmbpnlBonaStudSem.SelectedItem & "' AND REASON='" & txtpnlBonaReason.Text & "' AND CERTIFICATE_TAKEN_DATE=#" & Format(dtpDate.Value.Date, "dd/MM/yyyy") & "#")

            If dt.Rows.Count > 0 Then
                rd = getRD("Reports\rptBonafide_Certificate.rpt")
                rd.SetDataSource(dt)
                frmViewReports.Report_Viewer.ReportSource = rd
                frmViewReports.Show()
            Else
                MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
            End If
        Else
            MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
        End If

        '  Use To Directly Print The Report To Printer

        'rd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rd.PrintToPrinter(1, False, 1, 1)

        '       OR

        ''ViewReports.CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btnpnlTCPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlTCPrint.Click

        dt = getRecs("SELECT * FROM TC_DETAILS WHERE STUD_ID=" & stu_id)

        If dt.Rows.Count > 0 Then
            Dim res As Integer
            res = MsgBox("You Had Already Taken The Transfer Certificate,Do You Want To Take Print", MsgBoxStyle.YesNo, "Transfer Certificate")

            If res = vbYes Then
                rd = getRD("Reports\rptTransfer_Certificate.rpt")
                rd.SetDataSource(dt)
                frmViewReports.Report_Viewer.ReportSource = rd
                frmViewReports.Show()
            Else

            End If
        Else
            dt = getRecs("SELECT * FROM TC_DETAILS WHERE STUD_ID=" & stu_id)
            If dt.Rows.Count <= 0 Then
                MsgBox("Please Save The Data First")
            Else
                rd = getRD("Reports\rptTransfer_Certificate.rpt")
                rd.SetDataSource(dt)
                frmViewReports.Report_Viewer.ReportSource = rd
                frmViewReports.Show()
            End If
        End If
    End Sub

    Public Function isTCRuquiredEmpty() As Boolean
        If cmbRegYear.SelectedIndex = -1 Then
            MsgBox("Kindly Select Reg. Year")
            Return False
        ElseIf cmbpnlTCStudName.SelectedIndex = -1 Then
            MsgBox("Kindly Select Student Name")
            Return False
        ElseIf msktxtpnlTCEX_M_Y.Text.Split("/")(0).ToString.Length <> 2 Or msktxtpnlTCEX_M_Y.Text.Split("/")(1).ToString.Length <> 4 Then
            MsgBox("Kindly Enter Exam Month And Year")
            Return False
        ElseIf txtpnlTCSeatNo.Text = "" Then
            MsgBox("Kindly Enter Seat No")
            Return False
        ElseIf IsNumeric(txtpnlTCSeatNo.Text) = False Then
            MsgBox("Seat No Must Be Numeric")
            Return False
        ElseIf cmbpnlTCResult.SelectedIndex = -1 Then
            MsgBox("Kindly Select Result")
            Return False
        ElseIf txtpnlTCEnrollNo.Text = "" Then
            MsgBox("Kindly Enter Enrollment No")
            Return False
        ElseIf txtpnlTCTOAdd.Text = "" Then
            MsgBox("Kindly Enter To Address")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlAddFormATKTExSem.SelectedIndexChanged
        If cmbpnlAddFormATKTExSem.SelectedIndex = 0 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            cmbpnlAddFormATKTPaperNo.Items.Add("")
            cmbpnlAddFormATKTPaperNo.SelectedIndex = 0
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex = 1 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            For i As Integer = 101 To 105
                cmbpnlAddFormATKTPaperNo.Items.Add(i)
            Next
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex = 2 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            For i As Integer = 201 To 205
                cmbpnlAddFormATKTPaperNo.Items.Add(i)
            Next
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex = 3 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            For i As Integer = 301 To 305
                cmbpnlAddFormATKTPaperNo.Items.Add(i)
            Next
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex = 4 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            For i As Integer = 401 To 405
                cmbpnlAddFormATKTPaperNo.Items.Add(i)
            Next
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex = 5 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            For i As Integer = 501 To 505
                cmbpnlAddFormATKTPaperNo.Items.Add(i)
            Next
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex = 6 Then
            cmbpnlAddFormATKTPaperNo.Items.Clear()
            cmbpnlAddFormATKTPaperNo.Items.Add(601)
        End If
    End Sub

    Private Sub cmbpnlAddFormStudName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlAddFormStudName.SelectedIndexChanged
        If cmbpnlAddFormStudName.SelectedIndex <> -1 Then
            txtpnlAddFormRollNo.Text = dtStud.Rows(cmbpnlAddFormStudName.SelectedIndex)(4)
            stu_id = dtStud.Rows(cmbpnlAddFormStudName.SelectedIndex)(0)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If cmbpnlAddFormStudName.SelectedIndex <> -1 And cmbpnlAddFormAddSem.SelectedIndex <> -1 Then
            tmp = getRecs("select * from ADMISSION_FORM_DETAILS where STUD_ID=" & stu_id & " and ADDMISSION_SEM like '" & cmbpnlAddFormAddSem.SelectedItem & "'")

            If tmp.Rows.Count <= 0 Then
                MsgBox("Please Save The Data First")

            Else

                sql = "select * from ADMISSION_FORM_DETAILS where STUD_ID=" & stu_id & " and ADDMISSION_SEM like '" & cmbpnlAddFormAddSem.SelectedItem & "'"
                dt = getRecs(sql)

                If dt.Rows.Count > 0 Then
                    rd = getRD("Reports\rptAdmission_Form.rpt")
                    rd.SetDataSource(dt)
                    frmViewReports.Report_Viewer.ReportSource = rd
                    frmViewReports.Show()
                End If

            End If
        Else
            MsgBox("Either Data Is Not Saved Or " & vbCrLf & " Provided Information Is Not Sufficient Or Not Correct To Print")
        End If
    End Sub

    Public Function isAllAddFormEmpty() As Boolean
        If cmbRegYear.SelectedIndex = -1 And _
            cmbpnlAddFormStudName.SelectedIndex = -1 And _
            cmbpnlAddFormStuGen.SelectedIndex = -1 And _
            txtpnlAddFormStuAdd.Text = "" And _
            txtpnlAddFormStuPNO.Text = "" And _
            txtpnlAddFormStuMNO.Text = "" And _
            txtpnlAddFormStuEmail.Text = "" And _
            txtpnlAddFormStuCorrAdd.Text = "" And _
            cmbpnlAddFormPassedExSem.SelectedIndex = -1 And _
            cmbpnlAddFormATKTPaperNo.SelectedIndex = 0 And _
            cmbpnlAddFormAppExSem.SelectedIndex = -1 And _
            cmbpnlAddFormAppExType.SelectedIndex = -1 And _
            cmbpnlAddFormAppATKTExSem.SelectedIndex = 0 And _
            cmbpnlAddFormAppATKTExType.SelectedIndex = 0 And _
            cmbpnlAddFormATKTExSem.SelectedIndex = 0 And _
            txtpnlAddFormPlace.Text = "" Then

            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmbpnlTCStudName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlTCStudName.SelectedIndexChanged
        If cmbpnlTCStudName.SelectedIndex <> -1 Then
            stu_id = dtStud.Rows(cmbpnlTCStudName.SelectedIndex)(0)
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlAddFormAppATKTExSem.SelectedIndexChanged
        If cmbpnlAddFormAppATKTExSem.SelectedIndex = 0 Then
            cmbpnlAddFormAppATKTExType.Items.Clear()
            cmbpnlAddFormAppATKTExType.Items.Add("")
            cmbpnlAddFormAppATKTExType.SelectedIndex = 0
        Else
            cmbpnlAddFormAppATKTExType.Items.Clear()
            cmbpnlAddFormAppATKTExType.Items.Add("ATKT")
            cmbpnlAddFormAppATKTExType.Items.Add("PART")
        End If
    End Sub

    Private Sub btnpnlAddFromSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlAddFromSave.Click
        addfrm = False

        If cmbpnlAddFormStudName.SelectedIndex <> -1 And cmbpnlAddFormAddSem.SelectedIndex <> -1 Then

            tmp = getRecs("SELECT * FROM ADMISSION_FORM_DETAILS WHERE STUD_ID=" & stu_id & " AND ADDMISSION_SEM LIKE '" & cmbpnlAddFormAddSem.SelectedItem & "'")
            If tmp.Rows.Count > 0 Then
                MsgBox("You Had Already Filled The Admission Form For This Semester" & vbCrLf & "Click Print To Take Printout")
                addfrm = True
            End If
        End If

        If Not addfrm Then
            If isAddFormRuquiredEmpty() Then

                sql = "SELECT max(REC_NO) FROM STUD_CERTIFICATE_DETAILS"
                dt = getRecs(sql)
                rec_no = CInt(dt.Rows(0)(0)) + 1


                sql = "INSERT INTO STUD_CERTIFICATE_DETAILS(REC_NO,CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,STUD_BACHELOR_DEGREE,CERTIFICATE_TAKEN_DATE) VALUES(" & rec_no & "," & (cmbCertiType.SelectedIndex + 1) & "," & stu_id & ",'" & _
                    cmbCertiType.SelectedItem & "','" & cmbpnlAddFormStudName.SelectedItem & "','" & _
                    cmbpnlAddFormStuBatchDegree.SelectedItem & "','" & Format(dtpDate.Value.Date, "MM/dd/yyyy").ToString & "')"

                performInsert1(sql)


                sql = "INSERT INTO ADMISSION_FORM_DETAILS VALUES(" & rec_no & "," & stu_id & ",'" & cmbpnlAddFormAddSem.SelectedItem & _
                "','" & cmbpnlAddFormStudName.SelectedItem & "','" & txtpnlAddFormRollNo.Text & "','" & cmbpnlAddFormStuGen.SelectedItem & _
                "','" & cmbpnlAddFormStuCast.SelectedItem & "','" & txtpnlAddFormStuAdd.Text & "','" & txtpnlAddFormStuPNO.Text & "'," & txtpnlAddFormStuMNO.Text & _
                ",'" & txtpnlAddFormStuEmail.Text & "','" & txtpnlAddFormStuCorrAdd.Text & "','" & Format(dtppnlAddFormStudDOB.Value.Date, "MM/dd/yyyy").ToString & _
                "','" & cmbpnlAddFormGraUni.SelectedItem & "','" & cmbpnlAddFormGraState.SelectedItem & "','" & cmbpnlAddFormStuBatchDegree.SelectedItem & _
                "','" & cmbpnlAddFormPassedExSem.SelectedItem & "','" & cmbpnlAddFormATKTExSem.SelectedItem & "','" & cmbpnlAddFormATKTPaperNo.SelectedItem & "','" & _
                cmbpnlAddFormAppExSem.SelectedItem & "','" & cmbpnlAddFormAppExType.SelectedItem & "','" & cmbpnlAddFormAppATKTExSem.SelectedItem & "','" & _
                cmbpnlAddFormAppATKTExType.SelectedItem & "','" & Format(dtpDate.Value.Date, "MM/dd/yyyy").ToString & "','" & txtpnlAddFormPlace.Text & "')"

                performInsert(sql)

            End If
        End If

    End Sub
    Public Function isAddFormRuquiredEmpty() As Boolean

        If cmbRegYear.SelectedIndex = -1 Then
            MsgBox("Kindly Select Reg. Year")
            Return False
        ElseIf cmbpnlAddFormStudName.SelectedIndex = -1 Then
            MsgBox("Kindly Select Student Name")
            Return False
        ElseIf cmbpnlAddFormAddSem.SelectedIndex = -1 Then
            MsgBox("Kindly Select Addmission Semester")
            Return False
        ElseIf cmbpnlAddFormStuGen.SelectedIndex = -1 Then
            MsgBox("Kindly Select Gender")
            Return False
        ElseIf txtpnlAddFormStuAdd.Text = "" Then
            MsgBox("Kindly Enter Permanent Address")
            Return False
        ElseIf txtpnlAddFormStuMNO.Text = "" Then
            MsgBox("Kindly Enter Mobile No")
            Return False
        ElseIf IsNumeric(txtpnlAddFormStuMNO.Text) = False Then
            MsgBox("Mobile No Must Contain Only Digits")
            Return False
        ElseIf txtpnlAddFormStuEmail.Text = "" Then
            MsgBox("Kindly Enter Email ID")
            Return False
        ElseIf txtpnlAddFormStuCorrAdd.Text = "" Then
            MsgBox("Kindly Enter Correspondance Address")
            Return False
        ElseIf cmbpnlAddFormStuBatchDegree.SelectedIndex = -1 Then
            MsgBox("Kindly Select Bachelor Degree")
            Return False
        ElseIf cmbpnlAddFormPassedExSem.SelectedIndex = -1 Then
            MsgBox("Kindly Select Passed Exam Semester")
            Return False
        ElseIf cmbpnlAddFormATKTExSem.SelectedIndex > 0 Then
            If cmbpnlAddFormATKTPaperNo.SelectedIndex = -1 Then
                MsgBox("Kindly Select Paper No For ATKT/FAIL")
                Return False
            End If
        ElseIf cmbpnlAddFormAppExSem.SelectedIndex = -1 Then
            MsgBox("Kindly Select Appeared Exam Semester")
            Return False
        ElseIf cmbpnlAddFormAppATKTExSem.SelectedIndex > 0 Then
            If cmbpnlAddFormAppATKTExType.SelectedIndex = -1 Then
                MsgBox("Kindly Select Type Of Appeared Exam(ATKT/PART)")
                Return False
            End If
            If cmbpnlAddFormAppATKTExSem.SelectedIndex > 0 And cmbpnlAddFormATKTExSem.SelectedIndex <= 0 Then
                MsgBox("Kindly Select Semester of ATKT/FAILED")
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlAddFormAppExSem.SelectedIndexChanged
        If cmbpnlAddFormAppExSem.SelectedIndex >= 0 Then
            cmbpnlAddFormAppExType.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If pnlAddForm.Visible = True Then
            clearAllpnlAddForm()
        ElseIf pnlTC.Visible = True Then
            clearAllpnlTC()
        ElseIf pnlBonafied.Visible = True Then
            clearAllpnlBona()
        ElseIf pnlFAC.Visible = True Then
            clearAllpnlFAC()
        End If
    End Sub

    Public Sub clearAllpnlAddForm()

        cmbRegYear.SelectedIndex = -1
        cmbpnlAddFormStudName.SelectedIndex = -1
        cmbpnlAddFormStuGen.SelectedIndex = -1
        txtpnlAddFormStuAdd.Text = ""
        txtpnlAddFormStuPNO.Text = ""
        txtpnlAddFormStuMNO.Text = ""
        txtpnlAddFormStuEmail.Text = ""
        txtpnlAddFormStuCorrAdd.Text = ""
        cmbpnlAddFormPassedExSem.SelectedIndex = -1
        cmbpnlAddFormATKTPaperNo.SelectedIndex = 0
        cmbpnlAddFormAppExSem.SelectedIndex = -1
        cmbpnlAddFormAppExType.SelectedIndex = -1
        cmbpnlAddFormAppATKTExSem.SelectedIndex = 0
        cmbpnlAddFormAppATKTExType.SelectedIndex = 0
        cmbpnlAddFormATKTExSem.SelectedIndex = 0
        txtpnlAddFormPlace.Text = ""

    End Sub

    Public Sub clearAllpnlTC()
        cmbRegYear.SelectedIndex = -1
        cmbpnlTCStudName.SelectedIndex = -1
        msktxtpnlTCEX_M_Y.Clear()
        txtpnlTCSeatNo.Text = ""
        cmbpnlTCResult.SelectedIndex = -1
        txtpnlTCEnrollNo.Text = ""
        txtpnlTCTOAdd.Text = ""
    End Sub

    Public Sub clearAllpnlBona()
        cmbRegYear.SelectedIndex = -1
        cmbpnlBonaStudName.SelectedIndex = -1
        txtpnlBonaReason.Text = ""
    End Sub
    Public Sub clearAllpnlFAC()
        cmbRegYear.SelectedIndex = -1
        cmbpnlFACStudName.SelectedIndex = -1
        msktxtpnlFACBatchYear.Clear()
        txtpnlFACRemark.Text = ""
    End Sub
    Private Sub btnpnlTCSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlTCSave.Click
        Dim tc As Boolean = False

        If cmbpnlTCStudName.SelectedIndex <> -1 Then
            dt = getRecs("SELECT * FROM TC_DETAILS WHERE STUD_ID=" & stu_id)
            If dt.Rows.Count > 0 Then
                Dim res As Integer
                res = MsgBox("You Had Already Taken The Transfer Certificate,Click Print To Take Printout")
                tc = True
            End If
        End If

        If Not tc Then
            If isTCRuquiredEmpty() Then

                sql = "SELECT max(REC_NO) FROM STUD_CERTIFICATE_DETAILS"
                dt = getRecs(sql)
                rec_no = CInt(dt.Rows(0)(0)) + 1


                sql = "INSERT INTO STUD_CERTIFICATE_DETAILS(REC_NO,CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,STUD_BACHELOR_DEGREE,CERTIFICATE_TAKEN_DATE) VALUES(" & rec_no & "," & (cmbCertiType.SelectedIndex + 1) & "," & stu_id & ",'" & _
                cmbCertiType.SelectedItem & "','" & cmbpnlTCStudName.SelectedItem & "','" & _
                cmbpnlTCBachDegree.SelectedItem & "','" & Format(dtpDate.Value.Date, "MM/dd/yyyy").ToString & "')"

                performInsert1(sql)


                sql = "INSERT INTO TC_DETAILS  VALUES(" & rec_no & ",2," & stu_id & ",'" & cmbCertiType.SelectedItem & "','" & cmbpnlTCBachDegree.SelectedItem & "','" & cmbpnlTCStudName.SelectedItem & "','" & Format(pnlTCDTP1.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP2.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP3.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP4.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP5.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP6.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP7.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP8.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP9.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP10.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP11.Value.Date, "MM/dd/yyyy") & "','" & Format(pnlTCDTP12.Value.Date, "MM/dd/yyyy") & "'," & Val(msktxtpnlTCEX_M_Y.Text.Split("/")(0)) & "," & Val(msktxtpnlTCEX_M_Y.Text.Split("/")(1)) & ",'" & Format(DateTimePicker1.Value.Date, "MM/dd/yyyy") & "'," & Val(txtpnlTCSeatNo.Text) & ",'" & cmbpnlTCResult.SelectedItem & "'," & Val(txtpnlTCEnrollNo.Text) & ",'" & txtpnlTCTOAdd.Text & "','" & Format(dtpDate.Value.Date, "MM/dd/yyyy") & "')"
                performInsert(sql)

            End If
        End If
    End Sub

    Private Sub btnpnlBonaSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlBonaSave.Click

        If cmbpnlBonaStudName.SelectedIndex = -1 Or txtpnlBonaReason.Text = "" Then
            MsgBox("Kindly Enter Your Details")
        Else

            sql = "SELECT max(REC_NO) FROM STUD_CERTIFICATE_DETAILS"
            dt = getRecs(sql)
            rec_no = CInt(dt.Rows(0)(0)) + 1


            sql = "INSERT INTO STUD_CERTIFICATE_DETAILS(REC_NO,CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,STUD_SEM,REASON,CERTIFICATE_TAKEN_DATE) VALUES(" & rec_no & "," & (cmbCertiType.SelectedIndex + 1) & "," & stu_id & ",'" & _
            cmbCertiType.SelectedItem & "','" & cmbpnlBonaStudName.SelectedItem & "','" & _
            cmbpnlBonaStudSem.SelectedItem & "','" & txtpnlBonaReason.Text.ToString & "','" & Format(dtpDate.Value.Date, "MM/dd/yyyy").ToString & "')"

            performInsert(sql)

        End If
    End Sub

    Private Sub cmbpnlBonaStudName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlBonaStudName.SelectedIndexChanged
        If cmbpnlBonaStudName.SelectedIndex <> -1 Then
            stu_id = dtStud.Rows(cmbpnlBonaStudName.SelectedIndex)(0)
        End If
    End Sub

    Private Sub btnpnlFACSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpnlFACSave.Click
        If cmbpnlFACStudName.SelectedIndex = -1 Or msktxtpnlFACBatchYear.Text = "" Then
            MsgBox("Kindly Enter Your Details")
        Else

            sql = "SELECT max(REC_NO) FROM STUD_CERTIFICATE_DETAILS"
            dt = getRecs(sql)
            rec_no = CInt(dt.Rows(0)(0)) + 1


            sql = "INSERT INTO STUD_CERTIFICATE_DETAILS(REC_NO,CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,MCA_BATCH_YEAR,REASON,CERTIFICATE_TAKEN_DATE) VALUES(" & rec_no & "," & (cmbCertiType.SelectedIndex + 1) & "," & stu_id & ",'" & _
           cmbCertiType.SelectedItem & "','" & cmbpnlFACStudName.SelectedItem.ToString & "','" & _
           msktxtpnlFACBatchYear.Text.ToString & "','" & txtpnlFACRemark.Text.ToString & "','" & Format(dtpDate.Value.Date, "MM/dd/yyyy") & "')"

            performInsert(sql)

        End If
    End Sub

    Private Sub cmbpnlFACStudName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpnlFACStudName.SelectedIndexChanged
        If cmbpnlBonaStudName.SelectedIndex <> -1 Then
            stu_id = dtStud.Rows(cmbpnlBonaStudName.SelectedIndex)(0)
        End If
    End Sub


End Class