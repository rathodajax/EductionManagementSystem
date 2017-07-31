Module connectionvb
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\DEPT.mdb")
    'Public cmd As New OleDb.OleDbCommand()
    Public da As New OleDb.OleDbDataAdapter
    Public dr As OleDb.OleDbDataReader
    Public ds As New DataSet
End Module
