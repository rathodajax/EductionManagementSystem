Imports System.Data.OleDb

Module EventModule
    'Public con As OleDbConnection
    ' Public adpt As New OleDbDataAdapter
    'Public cmd As New OleDbCommand
    ' Public ds As New DataSet
    Public strsql As String
    ' Public tbl As New DataTable
    'Public Sub connect()
    '    con = New Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT 1.mdb")
    '    con.Open()
    'End Sub

    Public Sub exe_qry(ByVal str As String)
        connect()
        cmd = New OleDbCommand

        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()
        'con.Close()
    End Sub

    'Public Function getdata(ByVal str As String) As DataTable
    '    connect()
    '    adpt = New Data.OleDb.OleDbDataAdapter(str, con)
    '    tbl = New DataTable
    '    adpt.Fill(tbl)
    '    Return tbl
    'End Function


    Public Function getid(ByVal str As String) As Integer
        'connect()

        tbl = New DataTable
        adpt = New OleDbDataAdapter(str, con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Return Val(tbl.Rows(0).Item(0).ToString)
        Else
            Return 0
        End If
    End Function

End Module
