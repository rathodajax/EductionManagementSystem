Imports System.Data.OleDb
Module ProjectModule
    'Public con As OleDbConnection
    'Dim cmd As OleDbCommand
    'Dim adpt As OleDbDataAdapter
    'Dim tbl As DataTable
    'Public Sub connect()
    '    'con=New OleDbConnection (" Provider=Microsoft.Jet.OLEDB.4.0;Data Source="F:\mca_vb_net\Nfolder\project_management2\project_management\ProjectDB.mdb";Persist Security Info=True")
    '    con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\ProjectDB.mdb;Persist Security Info=True")
    '    'con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\mca_vb_net\Nfolder\project_management2\project_management\ProjectDB.mdb;Persist Security Info=True")
    '    Try
    '        con.Open()
    '        '  MsgBox("Connected")
    '    Catch ex As Exception
    '        MsgBox("Not Connected")
    '    End Try
    'End Sub
    Public Sub FillCmb(ByVal qry As String, ByVal cmb As ComboBox)
        Try
            connect()
            Dim mytable As New DataTable
            mytable = getData(qry)
            If mytable.Rows.Count > 0 Then
                For j As Integer = 0 To mytable.Rows.Count - 1
                    cmb.Items.Add(mytable.Rows(j).Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    'Public Function getdata(ByVal qry As String) As DataTable
    '    connect()
    '    adpt = New OleDbDataAdapter(qry, con)
    '    tbl = New DataTable
    '    adpt.Fill(tbl)
    '    Return tbl

    'End Function
    Public Sub executeinsert(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
            'MsgBox("inserted")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub executeupdated(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
            'cmd.ExecuteScalar()
            MsgBox("updated")
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub
    Public Sub executedelete(ByVal qry As String)
        connect()
        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteScalar()
            MsgBox("deleteded")
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    'Public Function getsinglefieldint(ByVal qry As String) As Integer
    '    connect()
    '    adpt = New OleDbDataAdapter(qry, con)
    '    tbl = New DataTable()
    '    adpt.Fill(tbl)
    '    If tbl.Rows.Count > 0 Then
    '        Return Val(tbl.Rows(0).Item(0).ToString)
    '    Else
    '        Return 0
    '    End If
    'End Function
End Module
