Imports System.Data.OleDb
Module Module1
    'Public con As OleDbConnection
    'Public cmd As New OleDbCommand
    'Public adpt As New OleDbDataAdapter
    'Public ds As New DataSet
    Public tbl As New DataTable
    Public Sub connection()

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")

        Try
            If con.State <> ConnectionState.Open Then
                con.Open()
                ' MsgBox("Succed")
            End If
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub
    Public Sub connectionCon()

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")

        Try
            If con.State <> ConnectionState.Open Then
                con.Open()
                ' MsgBox("Succed")
            End If
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub exc_qry(ByVal str As String)
        Call connection()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = str
        cmd.ExecuteNonQuery()


    End Sub
    'Public Function getsinglefield(ByVal qry As String) As DataTable
    '    connection()
    '    adpt = New OleDbDataAdapter(qry, con)
    '    tbl = New DataTable
    '    adpt.Fill(tbl)

    'End Function
End Module
