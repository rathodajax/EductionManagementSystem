Imports System.Data.OleDb
Module FristModule
    'Public con As OleDbConnection
    'Public cmd As New OleDbCommand
    'Public adpt As New OleDbDataAdapter
    'Public ds As New DataSet
    'Dim tbl As New DataTable
    'Public Function getdata(ByVal str As String) As DataTable
    '    Dim tbl As New DataTable
    '    adpt = New OleDbDataAdapter(str, con)
    '    adpt.Fill(tbl)
    '    Return tbl
    'End Function
    'Public Sub connect()
    '    con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT 1.mdb")
    '    Try
    '        If con.State <> ConnectionState.Open Then
    '            con.Open()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub
    Public Function getsinglefieldint(ByVal str As String) As Integer
        tbl = New DataTable
        adpt = New OleDbDataAdapter(str, con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Return tbl.Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function
    Public Function getsinglefieldstr(ByVal str As String) As String
        tbl = New DataTable
        adpt = New OleDbDataAdapter(str, con)
        adpt.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            Return tbl.Rows(0).Item(0).ToString
        Else
            Return 0
        End If
    End Function
    Public Sub exe_query(ByVal str As String)
        Call connect()
        cmd.CommandText = str
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.ExecuteNonQuery()
    End Sub
End Module
