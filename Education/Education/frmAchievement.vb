Imports System.Data.OleDb

Public Class frmAchievement

    Dim tbl As DataTable
    Dim cnt As Integer = 0
    Dim qry As String

    'Dim con As New OleDbConnection
    Dim adpt As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim rpt As New CrystalReport1

    Dim dt As Date
    Dim org1 As String
    Dim plc As String

    Dim yr1 As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Hide()
        Panel2.Hide()
        LoadYear(cmbYear)
        EnableField(False)
        cmbYear.Enabled = True
        txtAno.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Panel1.Show()
        Panel2.Hide()
        LoadYear(cmbYearAdd)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Panel2.Show()
        Panel1.Hide()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIns.Click
        If txtAch.Text = "" Then
            MsgBox("Enter Achievement!")
        ElseIf txtDes.Text = "" Then
            MsgBox("Enter Description Of Achievement!")
        Else
            Dim y As String = cmbYearAdd.SelectedItem.ToString
            'qry = "INSERT INTO ACHIEVEMENT_MASTER Values(" + txtAno.Text + ",'" + cmbEname.SelectedItem + "','" + txtAch.Text + "','" + txtDes.Text + "')"
            'qry = "INSERT INTO ACHIEVEMENT_MASTER Values(" + txtAno.Text + ",'" + cmbEname.SelectedItem + "','" + txtAch.Text + "','" + txtDes.Text + "','" + cmbYearAdd.SelectedItem + "')"
            qry = "INSERT INTO ACHIEVEMENT_MASTER Values(" + txtAno.Text + ",'" + cmbEname.SelectedItem + "','" + txtAch.Text + "','" + txtDes.Text + "','" + dt + "','" + org1 + "','" + plc + "','" + yr1 + "')"
            executeInsert(qry)
            txtAno.Text = ""
            cmbEname.Items.Clear()
            LoadYear(cmbYearAdd)
            txtAch.Text = ""
            txtDes.Text = ""
        End If
    End Sub
    Private Sub LoadYear(ByVal cmb As ComboBox)
        Dim yr As Integer = Now.Date.Year
        cmb.Items.Clear()
        For i As Integer = yr To 2000 Step -1
            cmb.Items.Add(i)
        Next
    End Sub
    Private Sub btnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClr.Click
        txtAno.Text = ""
        cmbEname.Items.Clear()
        LoadYear(cmbYearAdd)
        txtAch.Text = ""
        txtDes.Text = ""
    End Sub

    Private Sub cmbYearAdd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYearAdd.SelectedIndexChanged
        tbl = New DataTable
        Dim ano As Integer = getsinglefieldint("SELECT MAX(ANO) FROM ACHIEVEMENT_MASTER") + 1
        txtAno.Text = ano
        Dim yr As String = cmbYearAdd.SelectedItem
        qry = "SELECT id, event,dat,org,place,YR FROM EVENT WHERE YR=" + yr
        tbl = getdata(qry)
        Dim i As Integer
        cmbEname.Items.Clear()
        For i = 0 To tbl.Rows.Count - 1
            If cmbYearAdd.Items.Contains(tbl.Rows(i).Item("EVENT").ToString) = True Then
            Else
                Me.cmbEname.Items.Add(tbl.Rows(i).Item("EVENT").ToString)
                dt = tbl.Rows(i).Item("dat").ToString
                org1 = tbl.Rows(i).Item("org").ToString
                plc = tbl.Rows(i).Item("place").ToString
                yr1 = tbl.Rows(i).Item("YR").ToString
            End If
        Next
        cmbEname.Enabled = True
        btnIns.Enabled = False
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        tbl = New DataTable
        Dim yr2 As String = cmbYear.SelectedItem.ToString
        qry = "SELECT ANO,ENAME,ACHIEVEMENT,DESCRIPTION,dat,org,place FROM ACHIEVEMENT_MASTER WHERE YR = " + yr2.ToString + " ORDER BY ANO"
        'qry = "SELECT ACHIEVEMENT_MASTER.ANO,ACHIEVEMENT_MASTER.ANAME,ACHIEVEMENT_MASTER.ACHIEVEMENT,ACHIEVEMENT_MASTER.DESCRIPTION,EVENT.dat,EVENT.org,EVENT.place FROM ACHIEVEMENT_MASTER,EVENT WHERE EVENT.YR=" + yr.ToString
        'qry = "SELECT" + ds.Tables("ACHIEVEMENT_MASTER").Columns("ANO").ToString + ",'" + ds.Tables("ACHIEVEMENT_MASTER").Columns("ENAME").ToString + "','" + ds.Tables("ACHIEVEMENT_MASTER").Columns("ACHIEVEMENT").ToString + "','" + ds.Tables("ACHIEVEMENT_MASTER").Columns("DESCRIPTION").ToString + "','" + ds.Tables("EVENT").Columns("dat").ToString + "','" + ds.Tables("EVENT").Columns("org").ToString + "','" + ds.Tables("EVENT").Columns("place").ToString + "' FROM ACHIEVEMENT_MASTER,EVENT WHERE " + ds.Tables("ACHIEVEMENT_MASTER").Columns("YR").ToString + yr.ToString
        'qry = "SELECT" + ds.Tables("ACHIEVEMENT_MASTER").Columns("ANO").ToString + ",'" + ds.Tables("ACHIEVEMENT_MASTER").Columns("ENAME").ToString + "','" + ds.Tables("ACHIEVEMENT_MASTER").Columns("ACHIEVEMENT").ToString + "','" + ds.Tables("ACHIEVEMENT_MASTER").Columns("DESCRIPTION").ToString + "','" + ds.Tables("EVENT").Columns("dat").ToString + "','" + ds.Tables("EVENT").Columns("org").ToString + "','" + ds.Tables("EVENT").Columns("place").ToString + "' FROM " + ds.Tables("ACHIEVEMENT_MASTER") + "," + ds.Tables("EVENT") + "WHERE " + ds.Tables("ACHIEVEMENT_MASTER").Columns("YR").ToString + "=" + yr.ToString
        'qry = "SELECT A.*,B.dat,B.org,B.place FROM ACHIEVEMENT_MASTER AS A,EVENT AS B WHERE B.YR=" + yr.ToString
        tbl = getdata(qry)
        rpt.SetDataSource(tbl)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
    Private Sub EnableField(ByVal flag As Boolean)
        cmbYear.Enabled = flag
        cmbEname.Enabled = flag
        txtAch.Enabled = flag
        txtDes.Enabled = flag
        btnIns.Enabled = flag
    End Sub

    Private Sub cmbEname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEname.SelectedIndexChanged

        txtAch.Enabled = True
        txtDes.Enabled = True
    End Sub

    Private Sub txtDes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDes.TextChanged
        btnIns.Enabled = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

