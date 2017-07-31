
Public Class frmadd
    Dim tbl As DataTable
    Dim chkpath, path, pathh, str As String
    Public k As Integer
    Dim id1, id2, id3, id4 As Integer
    Public Sub fillEvents()
        cmbevent.Items.Clear()
        tbl = getdata("SELECT * FROM EVENT_TYPE_MASTER")
        If tbl.Rows.Count > 0 Then
            Dim i As Int16
            For i = 0 To tbl.Rows.Count - 1
                cmbevent.Items.Add(tbl.Rows(i).Item(1).ToString)
            Next
        End If
    End Sub
    Private Sub frmadd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIMain

        connect()
        grpphoto.Enabled = False
        grpvideo.Enabled = False
        fillEvents()
        Call org()

        Dim i As Point
        i.X = 250
        i.Y = 200
        AxWindowsMediaPlayer1.MaximumSize = i
        AxWindowsMediaPlayer1.MinimumSize = i

    End Sub
    Public Sub org()
        str = "select event_org from event_master"
        tbl = getData(str)
        For i = 0 To tbl.Rows.Count - 1
            If Not cmborg.Items.Contains(tbl.Rows(i).Item("event_org").ToString) Then
                cmborg.Items.Add(tbl.Rows(i).Item("event_org").ToString)
            End If
        Next
    End Sub
    Private Sub cmbevent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If Not cmbevent.Items.Contains(cmbevent.Text) Then
        '        cmbevent.Items.Add(cmbevent.Text)
        '    End If
        'End If
    End Sub


    Private Sub select_photo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_photo.Click
        id3 = getid("SELECT MAX(PVID) FROM EVENT_DETAIL") + 1
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picevent.Image = Image.FromFile(OpenFileDialog1.FileName)
            chkpath = OpenFileDialog1.FileName

            If chkpath <> "" Then
                picevent.Image.Save(Application.StartupPath & "\photo\" & id3.ToString & ".jpg")
                path = ".\\photo\" & id3.ToString & ".jpg"
                chkpath = ""
            Else
                FileCopy(".\\photo\upload.jpg", Application.StartupPath & "\photo\" & id3.ToString & ".jpg")
                path = ".\\photo\" & id3.ToString & ".jpg"
                chkpath = ""
            End If
            ins()
            lstpath.Items.Add(path)
        Else

        End If

    End Sub
    Public Sub cleardata()
        txtplace.Clear()
        cmbevent.Text = ""
        cmborg.Text = ""
        dtp.Text = ""


    End Sub
    Private Sub e_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e_save.Click
        If e_save.Text = "Save" Then
            If Not txtplace.Text = "" Or cmbevent.Text = "" Or cmborg.Text = "" Or dtp.Value.ToString = "" Then
                insertData()
                fillEvents()
            Else
                MsgBox("Enter Proper Data")
                cleardata()
            End If
        Else

            If Not txtplace.Text = "" Or cmbevent.Text = "" Or cmborg.Text = "" Or dtp.Value = "" Then
                updatedata()
                fillEvents()
                e_save.Text = "Save"
            Else
                MsgBox("Enter Proper Data")
                cleardata()

            End If
        End If
    End Sub

    Public Sub updatedata()
        strsql = "UPDATE EVENT_MASTER SET EVENT_NAME='" & cmbevent.Text & "',EVENT_PLACE='" & txtplace.Text & "',EVENT_ORG='" & cmborg.Text & "',EVENT_DT= '" & dtp.Text & "' WHERE EVENT_ID=" & frmgrid.DataGridView1.CurrentRow.Cells(1).Value
        exe_qry(strsql)
        MsgBox("Data Updated Successfully")

        frmgrid.record_ref()
    End Sub
    Public Sub insertData()
        Dim dt As Integer = dtp.Value.Year
        connect()
        id1 = getid("SELECT MAX(EVENT_TYPE_ID) FROM EVENT_TYPE_MASTER") + 1
        id2 = getid("SELECT MAX(EVENT_ID) FROM EVENT_MASTER") + 1
        Dim e_id As Integer = getid("SELECT EVENT_TYPE_ID FROM EVENT_TYPE_MASTER WHERE EVENT_NAME='" & cmbevent.Text & "'")

        If cmbevent.Items.Contains(cmbevent.Text) Then
            strsql = "INSERT INTO EVENT_MASTER(EVENT_ID,EVENT_TYPE_ID,EVENT_NAME,EVENT_PLACE,EVENT_ORG,EVENT_DT,EVENT_YEAR) VALUES (" & id2 & "," & e_id & ",'" & cmbevent.Text & "','" & txtplace.Text & "','" & cmborg.Text & "','" & dtp.Value.Date & "'," & dt & ")"
            exe_qry(strsql)
            MsgBox("DATA INSERTED SUCCESSFULLY")

        Else
            Dim str As String = "INSERT INTO EVENT_TYPE_MASTER(EVENT_TYPE_ID,EVENT_NAME) VALUES ( " & id1 & ",'" & cmbevent.Text & "')"
            exe_qry(str)

            Dim eid As Integer = getid("SELECT EVENT_TYPE_ID FROM EVENT_TYPE_MASTER WHERE EVENT_NAME='" & cmbevent.Text & "'")

            strsql = "INSERT INTO EVENT_MASTER(EVENT_ID,EVENT_TYPE_ID,EVENT_NAME,EVENT_PLACE,EVENT_ORG,EVENT_DT,EVENT_YEAR) VALUES (" & id2 & "," & e_id & ",'" & cmbevent.Text & "','" & txtplace.Text & "','" & cmborg.Text & "','" & dtp.Value.Date & "'," & dt & ")"
            exe_qry(strsql)
            MsgBox("DATA INSERTED SUCCESSFULLY")
        End If
        Dim dirname As String = Application.StartupPath & "\video\" & id2.ToString
        My.Computer.FileSystem.CreateDirectory(dirname)
        frmgrid.record_ref()
    End Sub
    Public Sub ins()
        Dim e_id As Integer = getid("SELECT EVENT_ID FROM EVENT_MASTER WHERE EVENT_NAME='" & cmbevent.Text & "'")
        strsql = "INSERT INTO EVENT_DETAIL(PVID,EVENT_ID,EVENT_NAME,PVPATH,IS_PHOTO_VIDEO) values(" & id3 & "," & e_id & ",'" & cmbevent.Text & "','" & path & "', 1)"
        Call exe_qry(strsql)
        frmgrid.record_ref()
    End Sub
    Private Sub photo_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles photo_save.Click
        MsgBox("Photo Save Succesfully")
        picevent.Image = Nothing
        lstpath.Items.Clear()
    End Sub

    Public Sub insvideo()

        id3 = getid("SELECT MAX(PVID) FROM EVENT_DETAIL") + 1
        Dim e_id As Integer = getid("SELECT EVENT_ID FROM EVENT_MASTER WHERE EVENT_NAME='" & cmbevent.Text & "'")
        If pathh <> "" Then
            'AxWindowsMediaPlayer2.URL = Application.StartupPath & "\video\" & id3.ToString & ".wmv"
            path = ".\\video\" & e_id.ToString & "\" & id3.ToString & ".wmv"
            pathh = ""
        Else
            path = ".\\video\" & e_id.ToString & "\" & id3.ToString & ".wmv"
            pathh = ""
        End If

        My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Application.StartupPath & "\video\" & e_id.ToString & "\" & id3.ToString & ".wmv")
        strsql = "INSERT INTO EVENT_DETAIL(PVID,EVENT_ID,EVENT_NAME,PVPATH,IS_PHOTO_VIDEO) values(" & id3 & "," & e_id & ",'" & cmbevent.Text & "','" & path & "', 2)"
        Call exe_qry(strsql)

        lstvpath.Items.Add(path)
    End Sub

    Private Sub viewvideo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        view_video.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            grpphoto.Enabled = True
            cmborg.Enabled = False
            txtplace.Enabled = False
            e_save.Enabled = False

        Else
            grpphoto.Enabled = False
            cmborg.Enabled = True
            txtplace.Enabled = True
            e_save.Enabled = True

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            grpvideo.Enabled = True
            cmborg.Enabled = False
            txtplace.Enabled = False
            e_save.Enabled = False

        Else
            grpvideo.Enabled = False
            cmborg.Enabled = True
            txtplace.Enabled = True
            e_save.Enabled = True

        End If
    End Sub

    Private Sub AxWindowsMediaPlayer2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub select_video_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_video.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
            pathh = AxWindowsMediaPlayer1.URL.ToString
            insvideo()

            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Else
        End If
    End Sub

    Private Sub save_video_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_video.Click
        MsgBox("Video Save Succesfully")
        lstvpath.Items.Clear()
    End Sub

End Class
