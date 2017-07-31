Public Class admission_type_master
    Public str As String

    Private Sub admission_type_master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.F3 Then
            e.SuppressKeyPress = True
            btnAdmsnSave_Click(sender, e)
        End If
    End Sub

    Private Sub admission_type_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'insert data from ADMISSION_TYPE_MASTER table into combobox1(cmbAdmsnSelectType) at run time
        str = "select AT_NAME from ADMISSION_TYPE_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(ds, "ADMISSION_TYPE_MASTER")
        Dim j As Integer
        For j = 0 To ds.Tables("ADMISSION_TYPE_MASTER").Rows.Count - 1
            If Me.cmbAdmsnSelectType.Items.Contains(ds.Tables("ADMISSION_TYPE_MASTER").Rows(j).Item("AT_NAME").ToString) = True Then
            Else
                Me.cmbAdmsnSelectType.Items.Add(ds.Tables("ADMISSION_TYPE_MASTER").Rows(j).Item("AT_NAME").ToString)
            End If
        Next

    End Sub

    Private Sub cmbAdmsnSelectType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAdmsnSelectType.KeyDown
        If e.KeyCode = Keys.Enter And cmbAdmsnSelectType.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbAdmsnSelectType.Text <> "" Then
            Me.txtadmsnDetail.Focus()
        End If
    End Sub

    Private Sub cmbAdmsnSelectType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAdmsnSelectType.SelectedIndexChanged
        Me.txtAdmsnType.Text = cmbAdmsnSelectType.SelectedItem
        Dim temp As String = getsinglefieldstr("select AT_DETAIL from ADMISSION_TYPE_MASTER where AT_ID= " & Me.cmbAdmsnSelectType.SelectedIndex + 1)
        Me.txtadmsnDetail.Text = temp
        temp = ""
        temp = getsinglefieldstr("select REMARKS from ADMISSION_TYPE_MASTER where AT_ID= " & Me.cmbAdmsnSelectType.SelectedIndex + 1)
        Me.txtAdmsnRemark.Text = temp
    End Sub

    Private Sub txtAdmsnType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAdmsnType.KeyDown
        If e.KeyCode = Keys.Enter And txtAdmsnType.Text <> "" Then
            e.SuppressKeyPress = True
            Me.txtadmsnDetail.Focus()
        End If
    End Sub

    Private Sub btnAdmsnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmsnClear.Click
        txtAdmsnType.Text = " "
        txtadmsnDetail.Text = " "
        txtAdmsnRemark.Text = " "
    End Sub

    Private Sub btnAdmsnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmsnCancle.Click
        Me.Close()
    End Sub

    Private Sub btnAdmsnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmsnSave.Click
        connect()
        Dim i, id As Integer
        'generating AT_ID dynamically

        id = getsinglefieldint("SELECT MAX(AT_ID) FROM ADMISSION_TYPE_MASTER") + 1

        'inserting data into ADMISSION_TYPE_MASTER table and also adding into combobox
        Dim flag As Boolean = False
        For i = 0 To Me.cmbAdmsnSelectType.Items.Count - 1
            If (Me.cmbAdmsnSelectType.Items(i).ToString <> Me.txtAdmsnType.Text) And (txtAdmsnType.Text <> "") Then
                flag = True
            End If
        Next
        If flag = True Then
            Me.cmbAdmsnSelectType.Items.Add(txtAdmsnType.Text)
        End If
        For i = 0 To Me.cmbAdmsnSelectType.Items.Count - 1
            If (Me.cmbAdmsnSelectType.Items(i).ToString <> Me.txtAdmsnType.Text) And (cmbAdmsnSelectType.Text = "") And (txtAdmsnType.Text <> "") Then

                str = "INSERT INTO ADMISSION_TYPE_MASTER Values(" & id & ",'" & Me.txtAdmsnType.Text & "','" & Me.txtadmsnDetail.Text & "','" & Me.txtAdmsnRemark.Text & "')"
                MsgBox("Data Inserted")
                Exit For
            ElseIf cmbAdmsnSelectType.Text <> "" Then
                str = "update ADMISSION_TYPE_MASTER SET AT_NAME='" & Me.txtAdmsnType.Text & "',AT_DETAIL='" & Me.txtadmsnDetail.Text & "',REMARKS='" & Me.txtAdmsnRemark.Text & "' WHERE(ADMISSION_TYPE_MASTER.AT_ID=" & Me.cmbAdmsnSelectType.SelectedIndex + 1 & ")"
                MsgBox("Data Updated")
                Exit For
            End If
        Next
        Call exe_query(str)
        con.Close()
    End Sub
End Class