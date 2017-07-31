Module mdlConnection
    Friend dbconnection As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
    Friend dbcmd As New OleDb.OleDbCommand()
    Friend dbda As New OleDb.OleDbDataAdapter
    Friend dbds As New DataSet
End Module
