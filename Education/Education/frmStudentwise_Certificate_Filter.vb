Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmStudentwise_Certificate_Filter

    Dim dt, dt1, dtRecs As DataTable
    Dim sql As String = ""

    Dim rd As ReportDocument

    Dim dtStud As New DataTable

    Private Sub Certificate_Filter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dtpUptoDate.Enabled = False
        dtpToDate.Enabled = False
        dtpFromDate.Enabled = False

        For i As Integer = Now.Year To 1999 Step -1
            cmbRegYear.Items.Add(i)
        Next

        sql = "SELECT CERTIFICATE_ID,CERTIFICATE_NAME FROM CERTIFICATE_MASTER"
        dt = getRecs(sql)

        cmbCertiType.Items.Add("ALL")
        For i As Integer = 0 To dt.Rows.Count - 1
            cmbCertiType.Items.Add(dt.Rows(i)(1))
        Next

    End Sub

    Private Sub cmbCertiType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCertiType.SelectedIndexChanged

        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                sql = "SELECT CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE " _
                & "FROM STUD_CERTIFICATE_DETAILS"
            ElseIf cmbCertiType.SelectedIndex > 0 Then
                sql = "SELECT CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE " _
                & "FROM STUD_CERTIFICATE_DETAILS WHERE CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
            End If

            If cmbStudName.SelectedIndex <> -1 Then
                If cmbCertiType.SelectedIndex <> -1 And cmbCertiType.SelectedIndex = 0 Then
                    sql += " WHERE STUD_ID=" & dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                Else
                    sql += " and STUD_ID=" & dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                End If
            End If

            If rdbUptoDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                End If
            ElseIf rdbBetweenDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
            dt = getRecs(sql)
            FillGrid(dt)

        End If

    End Sub

    Private Sub cmbRegYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegYear.SelectedIndexChanged

        If cmbCertiType.SelectedIndex <> -1 Then

            If cmbCertiType.SelectedIndex = 0 Then
                sql = "SELECT CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE " _
                & "FROM STUD_CERTIFICATE_DETAILS"
            ElseIf cmbCertiType.SelectedIndex > 0 Then
                sql = "SELECT CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE " _
                & "FROM STUD_CERTIFICATE_DETAILS WHERE CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
            End If

            If rdbUptoDate.Checked = True Then
                If cmbCertiType.SelectedIndex = 0 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                ElseIf cmbCertiType.SelectedIndex > 0 Then
                    sql += " and CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                End If
            ElseIf rdbBetweenDate.Checked = True Then
                If cmbCertiType.SelectedIndex = 0 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                ElseIf cmbCertiType.SelectedIndex > 0 Then
                    sql += " and CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
            dt = getRecs(sql)
            FillGrid(dt)

        End If

        If cmbRegYear.SelectedIndex <> -1 Then

            dtStud = getRecs("SELECT STU_ID,REG_YEAR,STU_CMATNO,REG_DATE,STU_RNO,STU_NAME FROM STUDENT_MASTER WHERE REG_YEAR=" & cmbRegYear.SelectedItem)

            cmbStudName.Items.Clear()
            For i = 0 To dtStud.Rows.Count - 1
                cmbStudName.Items.Add(dtStud.Rows(i)(5))
            Next
        End If

    End Sub

    Private Sub cmbStudName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStudName.SelectedIndexChanged

        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
            Else
                sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString _
                & "and CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
            End If

            If rdbUptoDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                End If
            ElseIf rdbBetweenDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
            dt1 = getRecs(sql)

            If dt1.Rows.Count >= 0 Then
                FillGrid(dt1)
            Else
                grdCertiDetails.Rows.Clear()
                MsgBox("No Data Found")
            End If
        End If

    End Sub

    Private Sub dtpUptoDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpUptoDate.ValueChanged

        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS"
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                End If
            Else
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE" _
                & " CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString _
                & "and CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                End If
            End If

            If rdbUptoDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
        End If

        If cmbCertiType.SelectedIndex <> -1 Then
            dt = getRecs(sql)
            FillGrid(dt)
        End If

    End Sub

    Private Sub rdbUptoDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbUptoDate.CheckedChanged
        dtpUptoDate.Enabled = True
        dtpToDate.Enabled = False
        dtpFromDate.Enabled = False

        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS"
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                End If
            Else
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE" _
                & " CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString _
                & "and CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                End If
            End If

            If rdbUptoDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE<=#" & Format(dtpUptoDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
        End If

        If cmbCertiType.SelectedIndex <> -1 Then
            dt = getRecs(sql)
            FillGrid(dt)
        End If

    End Sub

    Private Sub rdbBetweenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbBetweenDate.CheckedChanged
        dtpUptoDate.Enabled = False
        dtpToDate.Enabled = True
        dtpFromDate.Enabled = True

        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS"
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                End If
            Else
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE" _
                & " CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString _
                & "and CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                End If
            End If

            If rdbBetweenDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
        End If

        If cmbCertiType.SelectedIndex <> -1 Then
            dt = getRecs(sql)
            FillGrid(dt)
        End If
    End Sub

    Private Sub dtpFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFromDate.ValueChanged

        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS"
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                End If
            Else
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE" _
                & " CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString _
                & "and CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                End If
            End If

            If rdbBetweenDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
        End If

        If cmbCertiType.SelectedIndex <> -1 Then
            dt = getRecs(sql)
            FillGrid(dt)
        End If
    End Sub

    Private Sub dtpToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpToDate.ValueChanged
        If cmbCertiType.SelectedIndex <> -1 Then
            If cmbCertiType.SelectedIndex = 0 Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS"
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString
                End If
            Else
                If cmbStudName.SelectedIndex = -1 Then
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE" _
                & " CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                Else
                    sql = "select CERTIFICATE_ID,STUD_ID,CERTIFICATE_NAME,STUD_NAME,REASON,CERTIFICATE_TAKEN_DATE from STUD_CERTIFICATE_DETAILS WHERE STUD_ID=" + dtStud.Rows(cmbStudName.SelectedIndex)(0).ToString _
                & "and CERTIFICATE_ID=" & cmbCertiType.SelectedIndex.ToString
                End If
            End If

            If rdbBetweenDate.Checked = True Then
                If cmbStudName.SelectedIndex = -1 Then
                    sql += " WHERE CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                Else
                    sql += " and CERTIFICATE_TAKEN_DATE between #" & Format(dtpFromDate.Value.Date, "M/d/yyyy") & "# and #" & Format(dtpToDate.Value.Date, "M/d/yyyy") & "#"
                End If
            End If

            sql += " ORDER BY CERTIFICATE_TAKEN_DATE DESC"
        End If

        If cmbCertiType.SelectedIndex <> -1 Then
            dt = getRecs(sql)
            FillGrid(dt)
        End If
    End Sub

    ' UDF subroutine
    Public Sub FillGrid(ByVal dt1 As DataTable)

        grdCertiDetails.Rows.Clear()
        For i As Integer = 0 To dt1.Rows.Count - 1
            grdCertiDetails.Rows.Add()
            grdCertiDetails.Rows(i).Cells(0).Value = i + 1
            grdCertiDetails.Rows(i).Cells(1).Value = dt1.Rows(i)(2)
            grdCertiDetails.Rows(i).Cells(2).Value = dt1.Rows(i)(3)
            grdCertiDetails.Rows(i).Cells(3).Value = dt1.Rows(i)(4)
            grdCertiDetails.Rows(i).Cells(4).Value = Format(dt1.Rows(i)(5), "dd/MM/yyyy")
        Next

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbCertiType.SelectedIndex = -1
        cmbRegYear.SelectedIndex = -1
        cmbStudName.SelectedIndex = -1
        rdbBetweenDate.Checked = False
        dtpFromDate.Enabled = False
        dtpToDate.Enabled = False
        rdbUptoDate.Checked = False
        dtpUptoDate.Enabled = False
        grdCertiDetails.Rows.Clear()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        dtRecs = New DataTable
        If grdCertiDetails.Rows.Count > 1 Then
            dtRecs.Columns.Add("REC_NO", GetType(System.Decimal))
            dtRecs.Columns.Add("CERTIFICATE_NAME", GetType(System.String))
            dtRecs.Columns.Add("STUD_NAME", GetType(System.String))
            dtRecs.Columns.Add("REASON", GetType(System.String))
            dtRecs.Columns.Add("CERTIFICATE_TAKEN_DATE", GetType(System.String))
            dtRecs.Rows.Add()

            For i As Integer = 0 To grdCertiDetails.Rows.Count - 2
                dtRecs.Rows.Add()
                dtRecs.Rows(i)(0) = CInt(grdCertiDetails.Rows(i).Cells(0).Value)
                dtRecs.Rows(i)(1) = grdCertiDetails.Rows(i).Cells(1).Value
                dtRecs.Rows(i)(2) = grdCertiDetails.Rows(i).Cells(2).Value
                dtRecs.Rows(i)(3) = grdCertiDetails.Rows(i).Cells(3).Value
                dtRecs.Rows(i)(4) = grdCertiDetails.Rows(i).Cells(4).Value.ToString
            Next

            rd = getRD("Reports\rptStudwise_Certi_Report.rpt")
            rd.SetDataSource(dtRecs)
            frmViewReports.Report_Viewer.ReportSource = rd
            frmViewReports.Show()
        Else
            MsgBox("Nothing To Print")
        End If
    End Sub


End Class