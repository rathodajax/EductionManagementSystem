Public Class serchstudentfrm
    Dim rpt As New searchstudent


    Private Sub searchstudviewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchstudviewer.Load
        connect()
        Dim tbl As New DataTable
        Dim strq As String = ""
        strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER"

        If frmsearch.cmbselect.Text = "GENDER" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_GEN='" & frmsearch.cmbvisible.Text & "'"

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_GEN='" & frmsearch.cmbvisible.Text & "' AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If


        ElseIf frmsearch.cmbselect.Text = "CATEGORY" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_CAST_ID=" & Val(frmsearch.cmbvisible.SelectedIndex) + 1

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_CAST_ID=" & Val(frmsearch.cmbvisible.SelectedIndex) + 1 & " AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        ElseIf frmsearch.cmbselect.Text = "BECHLOR DEGREE" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_BDEGREE_ID=" & Val(frmsearch.cmbvisible.SelectedIndex) + 1

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_BDEGREE_ID=" & Val(frmsearch.cmbvisible.SelectedIndex) + 1 & " AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        ElseIf frmsearch.cmbselect.Text = "FROM COLLEGE" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_BDEGREE_COL_ID=" & Val(frmsearch.cmbvisible.SelectedIndex) + 1

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_BDEGREE_COL_ID=" & Val(frmsearch.cmbvisible.SelectedIndex) + 1 & " AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        ElseIf frmsearch.cmbselect.Text = "MARIT" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_CMATNO=" & Val(frmsearch.txtselect.Text)

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_CMATNO=" & Val(frmsearch.txtselect.Text) & " AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        ElseIf frmsearch.cmbselect.Text = "STUDENT NAME" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_NAME='" & frmsearch.txtselect.Text & "'"

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_NAME='" & frmsearch.txtselect.Text & "' AND REG_YEAR='" & frmsearch.cmbyear.Text & "'"
            End If

        ElseIf frmsearch.cmbselect.Text = "ADDRESS" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_ADD='" & frmsearch.txtselect.Text & "'"

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_ADD='" & frmsearch.txtselect.Text & "' AND REG_YEAR='" & frmsearch.cmbyear.Text & "'"
            End If


        ElseIf frmsearch.cmbselect.Text = "PHONE NO" Then

            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_PHNO='" & frmsearch.txtselect.Text & "'"

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_PHNO='" & frmsearch.txtselect.Text & "' AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        ElseIf frmsearch.cmbselect.Text = "MOBILE NO" Then
            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_MOBNO=" & Val(frmsearch.txtselect.Text)

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_MOBNO=" & Val(frmsearch.txtselect.Text) & " AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        ElseIf frmsearch.cmbselect.Text = "EMAIL" Then

            If frmsearch.cmbyear.Text = "" Then
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_EMAIL='" & frmsearch.txtselect.Text & "'"

            Else
                strq = "SELECT DISTINCT STU_RNO,STU_NAME,STU_GEN,STU_DOB,STU_MOBNO,STU_ADD FROM STUDENT_MASTER WHERE STU_EMAIL= '" & frmsearch.txtselect.Text & "' AND REG_YEAR=" & Val(frmsearch.cmbyear.Text)
            End If

        End If

        tbl = getdata(strq)
        rpt.SetDataSource(tbl)
        searchstudviewer.ReportSource = rpt

    End Sub

    Private Sub serchstudentfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class