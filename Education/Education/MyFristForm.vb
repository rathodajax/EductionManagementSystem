Public Class MyFristForm
    Public str As String = ""
    Public str1 As String = ""
    Public chkpath As String = ""
    Public j As Integer
    Public id, id1 As Integer

    Private Sub MyFristForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.SuppressKeyPress = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancle.Click
        Me.Close()
    End Sub

    Private Sub txtStudId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudId.KeyDown
        If e.KeyCode = Keys.Enter And txtStudId.Text <> "" Then
            e.SuppressKeyPress = True
            cmbRegYear.Focus()
        End If
    End Sub
    Private Sub cmbRegYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbRegYear.KeyDown
        If e.KeyCode = Keys.Enter And cmbRegYear.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbRegYear.Text <> "" Then
            e.SuppressKeyPress = True
            txtCmatNo.Focus()
        End If
    End Sub
    Private Sub txtCmatNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCmatNo.KeyDown
        If e.KeyCode = Keys.Enter And txtCmatNo.Text <> "" Then
            e.SuppressKeyPress = True
            DateTimePicker2.Focus()
        End If
    End Sub


    Private Sub txtUniqueId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUniqueId.KeyDown
        If e.KeyCode = Keys.Enter And txtUniqueId.Text <> "" Then
            e.SuppressKeyPress = True
            txtFeesTot.Focus()
        End If
    End Sub
    Private Sub DateTimePicker2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtUniqueId.Focus()
        End If
    End Sub

    Private Sub txtFeesTot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFeesTot.KeyDown
        If e.KeyCode = Keys.Enter And txtFeesTot.Text <> "" Then
            e.SuppressKeyPress = True
            cmbAdType.Focus()
        End If
    End Sub
    Private Sub cmbAdType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAdType.KeyDown
        If e.KeyCode = Keys.Enter And cmbAdType.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbAdType.Text <> "" Then
            cmbBechDegreeName.Focus()
        End If
    End Sub

    Private Sub cmbBechDegreeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBechDegreeName.KeyDown
        If e.KeyCode = Keys.Enter And cmbBechDegreeName.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbBechDegreeName.Text <> "" Then
            txtBechDegreePer.Focus()
        End If
    End Sub

    Private Sub txtBechDegreePer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBechDegreePer.KeyDown
        If e.KeyCode = Keys.Enter And txtBechDegreePer.Text <> "" Then
            e.SuppressKeyPress = True
            cmbBechDegreeClg.Focus()
        End If
    End Sub

    Private Sub cmbBechDegreeClg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBechDegreeClg.KeyDown
        If e.KeyCode = Keys.Enter And cmbBechDegreeClg.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbBechDegreeClg.Text <> "" Then
            txtRollNo.Focus()
        End If
    End Sub

    Private Sub txtRollNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRollNo.KeyDown
        If e.KeyCode = Keys.Enter And txtRollNo.Text <> "" Then
            e.SuppressKeyPress = True
            txtName.Focus()
        End If
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter And txtName.Text <> "" Then
            e.SuppressKeyPress = True
            rbMale.Focus()
        End If
    End Sub

    Private Sub rbMale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rbMale.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            rbFemale.Focus()
        End If
    End Sub

    Private Sub rbFemale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rbFemale.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cmbCast.Focus()
        End If
    End Sub

    Private Sub cmbCast_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCast.KeyDown
        If e.KeyCode = Keys.Enter And cmbCast.Text = "" Then
            e.SuppressKeyPress = True
            SendKeys.Send("{F4}")
        ElseIf e.KeyCode = Keys.Enter And cmbCast.Text <> "" Then
            txtAdd.Focus()
        End If
    End Sub

    Private Sub txtAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAdd.KeyDown
        If e.KeyCode = Keys.Enter And txtAdd.Text <> "" Then
            e.SuppressKeyPress = True
            txtCAdd.Focus()
        End If
    End Sub

    Private Sub txtCAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCAdd.KeyDown
        If e.KeyCode = Keys.Enter And txtCAdd.Text <> "" Then
            e.SuppressKeyPress = True
            txtPhoneNo.Focus()
        End If
    End Sub

    Private Sub txtPhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhoneNo.KeyDown
        If e.KeyCode = Keys.Enter And txtPhoneNo.Text <> "" Then
            e.SuppressKeyPress = True
            txtMobNo.Focus()
        End If
    End Sub

    Private Sub txtMobNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobNo.KeyDown
        If e.KeyCode = Keys.Enter And txtMobNo.Text <> "" Then
            e.SuppressKeyPress = True
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter And txtEmail.Text <> "" Then
            e.SuppressKeyPress = True
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        connect()
        Dim pname As String = ""
        Dim sname As String = ""
        Dim n1 As String = ""
        pname = Application.StartupPath & "\images\ " & txtStudId.Text.ToString & ".jpg"
        FileCopy(chkpath, pname)
        sname = "\images\ " & txtStudId.Text.ToString & ".jpg"
        If rbMale.Checked Then
            If Me.RadioButton1.Checked Then
                str = "INSERT INTO STUDENT_MASTER Values(" & id & "," & Me.cmbRegYear.Text & "," & Me.txtCmatNo.Text & ",'" & Me.DateTimePicker2.Value & "','" & Me.txtRollNo.Text & "','" & Me.txtName.Text & "','" & Me.rbMale.Text & "'," & Me.cmbCast.SelectedIndex + 1 & ",'" & Me.txtAdd.Text & "','" & Me.txtCAdd.Text & "','" & Me.txtPhoneNo.Text & "'," & Me.txtMobNo.Text & ",'" & Me.txtEmail.Text & "','" & Me.DateTimePicker1.Value & "'," & Me.cmbBechDegreeName.SelectedIndex + 1 & "," & Me.txtBechDegreePer.Text & "," & Me.cmbBechDegreeClg.SelectedIndex + 1 & ",'" & sname & "','" & Me.txtUniqueId.Text & "'," & Me.cmbAdType.SelectedIndex + 1 & "," & Me.txtFeesTot.Text & ",'" & n1 & "'," & Me.RadioButton1.Text & ")"
            Else
                str = "INSERT INTO STUDENT_MASTER Values(" & id & "," & Me.cmbRegYear.Text & "," & Me.txtCmatNo.Text & ",'" & Me.DateTimePicker2.Value & "','" & Me.txtRollNo.Text & "','" & Me.txtName.Text & "','" & Me.rbMale.Text & "'," & Me.cmbCast.SelectedIndex + 1 & ",'" & Me.txtAdd.Text & "','" & Me.txtCAdd.Text & "','" & Me.txtPhoneNo.Text & "'," & Me.txtMobNo.Text & ",'" & Me.txtEmail.Text & "','" & Me.DateTimePicker1.Value & "'," & Me.cmbBechDegreeName.SelectedIndex + 1 & "," & Me.txtBechDegreePer.Text & "," & Me.cmbBechDegreeClg.SelectedIndex + 1 & ",'" & sname & "','" & Me.txtUniqueId.Text & "'," & Me.cmbAdType.SelectedIndex + 1 & "," & Me.txtFeesTot.Text & ", '" & n1 & "'," & Me.RadioButton2.Text & ")"

            End If
        Else
            If Me.RadioButton1.Checked Then
                str = "INSERT INTO STUDENT_MASTER Values(" & id & "," & Me.cmbRegYear.Text & "," & Me.txtCmatNo.Text & ",'" & Me.DateTimePicker2.Value & "','" & Me.txtRollNo.Text & "','" & Me.txtName.Text & "','" & Me.rbFemale.Text & "'," & Me.cmbCast.SelectedIndex + 1 & ",'" & Me.txtAdd.Text & "','" & Me.txtCAdd.Text & "','" & Me.txtPhoneNo.Text & "'," & Me.txtMobNo.Text & ",'" & Me.txtEmail.Text & "','" & Me.DateTimePicker1.Value & "'," & Me.cmbBechDegreeName.SelectedIndex + 1 & "," & Me.txtBechDegreePer.Text & "," & Me.cmbBechDegreeClg.SelectedIndex + 1 & ",'" & sname & "','" & Me.txtUniqueId.Text & "'," & Me.cmbAdType.SelectedIndex + 1 & "," & Me.txtFeesTot.Text & ",'" & n1 & "'," & Me.RadioButton1.Text & ")"
            Else
                str = "INSERT INTO STUDENT_MASTER Values(" & id & "," & Me.cmbRegYear.Text & "," & Me.txtCmatNo.Text & ",'" & Me.DateTimePicker2.Value & "','" & Me.txtRollNo.Text & "','" & Me.txtName.Text & "','" & Me.rbFemale.Text & "'," & Me.cmbCast.SelectedIndex + 1 & ",'" & Me.txtAdd.Text & "','" & Me.txtCAdd.Text & "','" & Me.txtPhoneNo.Text & "'," & Me.txtMobNo.Text & ",'" & Me.txtEmail.Text & "','" & Me.DateTimePicker1.Value & "'," & Me.cmbBechDegreeName.SelectedIndex + 1 & "," & Me.txtBechDegreePer.Text & "," & Me.cmbBechDegreeClg.SelectedIndex + 1 & ",'" & sname & "','" & Me.txtUniqueId.Text & "'," & Me.cmbAdType.SelectedIndex + 1 & "," & Me.txtFeesTot.Text & ",'" & n1 & "'," & Me.RadioButton2.Text & ")"
            End If

        End If
        Dim n As Integer = 1
        id1 = getsinglefieldint("SELECT MAX(ALO_ID) FROM SEAT_ALLOTMENT_MASTER") + 1
        str1 = "INSERT INTO SEAT_ALLOTMENT_MASTER Values (" & id1 & ",'" & Me.DateTimePicker2.Value & "'," & n & "," & Me.txtStudId.Text & "," & Me.cmbAdType.SelectedIndex + 1 & "," & n & ")"
        Call exe_query(str1)

        Call exe_query(str)
        MsgBox("Data Inserted")
        clearform()
        id = getsinglefieldint("SELECT MAX(STU_ID) FROM STUDENT_MASTER") + 1
        Me.txtStudId.Text = id
        con.Close()

    End Sub

    Private Sub btnBrawse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrawse.Click
        With OpenFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                picUploadImg.Image = Image.FromFile(.FileName)
                chkpath = .FileName
            Else
                MsgBox("Select File First")
            End If
        End With
    End Sub

    Private Sub btnUploadDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadDoc.Click
        With OpenFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                picUploadDoc.Image = Image.FromFile(.FileName)
                chkpath = .FileName
            Else
                MsgBox("Select File First")
            End If
        End With
    End Sub


    Private Sub GrpBoxRegInfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpBoxRegInfo.Enter

    End Sub

    Private Sub GrpBoxPrsnlDetail_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpBoxPrsnlDetail.Enter

    End Sub

    Public Sub loadAdmissiontype()
        Dim tbl As New DataTable
        cmbAdType.Items.Clear()
        connect()
        str = "select AT_NAME from ADMISSION_TYPE_MASTER"
        adpt = New Data.OleDb.OleDbDataAdapter(str, con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                cmbAdType.Items.Add(tbl.Rows(i).Item(0).ToString)
            Next
        End If

    End Sub
    Public Sub loadCast()
        cmbCast.Items.Clear()
        Dim tbl As New DataTable
        connect()
        adpt = New OleDb.OleDbDataAdapter("SELECT CAST_NAME FROM CAST_MASTER", con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                cmbCast.Items.Add(tbl.Rows(i).Item(0).ToString)
            Next
        End If
    End Sub
    Public Sub loadYear()
        Me.cmbRegYear.Items.Clear()
        Dim d1 As Date = Today
        For k As Integer = d1.Year To 2000 Step -1
            Me.cmbRegYear.Items().Add(k.ToString)
        Next

    End Sub
    Public Sub loadCollege()
        cmbBechDegreeClg.Items.Clear()
        Dim tbl As New DataTable
        connect()
        adpt = New OleDb.OleDbDataAdapter("SELECT COLLEGE_NAME FROM COLLEGE_MASTER WHERE COLLEGE_ID <> 1", con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                cmbBechDegreeClg.Items.Add(tbl.Rows(i).Item(0).ToString)
            Next
        End If
    End Sub
    Public Sub loadDegree()
        cmbBechDegreeName.Items.Clear()
        Dim tbl As New DataTable
        connect()
        adpt = New OleDb.OleDbDataAdapter("SELECT DEGREE_NAME FROM DEGREE_MASTER", con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To tbl.Rows.Count - 1
                cmbBechDegreeName.Items.Add(tbl.Rows(i).Item(0).ToString)
            Next
        End If
    End Sub
    Public Sub clearform()
        Me.txtAdd.Text = ""
        Me.txtBechDegreePer.Text = ""
        Me.txtCAdd.Text = ""
        Me.txtCmatNo.Text = ""
        Me.txtEmail.Text = ""
        Me.txtFeesTot.Text = ""
        Me.txtMobNo.Text = ""
        Me.txtName.Text = ""
        Me.txtPhoneNo.Text = ""
        Me.txtRollNo.Text = ""
        Me.txtStudId.Text = ""
        Me.txtUniqueId.Text = ""
    End Sub
    Private Sub MyFristForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        connect()
        clearform()
        Me.rbMale.Checked = True
        Me.RadioButton1.Checked = True
        id = getsinglefieldint("SELECT MAX(STU_ID) FROM STUDENT_MASTER") + 1
        Me.txtStudId.Text = id

        loadAdmissiontype()
        loadCast()
        loadYear()
        loadCollege()
        loadDegree()
        con.Close()
    End Sub
   End Class
