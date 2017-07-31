Imports System.Data.OleDb
Module Module5    
    'Public cmd As New OleDbCommand
    'Public da As New OleDbDataAdapter
    'Public ds As New DataSet
    'Public dr As OleDbDataReader
    Public query As String = ""
    Public mode As String = ""
    Public eventFlag As Boolean
    Public r_m_id As Integer
    Public arr_res_id As String = ""
    Public tos As Integer = 0
    Public tlb As New DataTable
    Public LastQuery As String = ""
    Public backcolor As Color
    Public forecolor As Color
    Public Sub ADD_RESULT_ID(ByVal value As String)
        arr_res_id += value
    End Sub
    Public Sub SetBackColor(ByVal clr As Color)
        backcolor = clr
    End Sub
    Public Function GetBackColor() As Color
        Return backcolor
    End Function
    Public Sub SetForeColor(ByVal clr As Color)
        forecolor = clr
    End Sub
    Public Function GetForeColor() As Color
        Return forecolor
    End Function
    Public Function GET_RESULT_IDS() As String
        Return arr_res_id
    End Function
    Public Sub CLEAR_RESULT_ID()
        arr_res_id = ""
    End Sub
    Public Function GET_RESULT_ID_BY_INDEX(ByVal index As Integer) As String
        Dim str() As String = arr_res_id.Split(",")
        Return str(index)
    End Function
    Public Function COUNT_RESULT_ID() As Integer
        Return (arr_res_id.Split(",")).Count
    End Function
    Public Sub SetResultMasterID(ByVal id As Integer)
        r_m_id = id
    End Sub
    Public Function GetResultMasterID() As Integer
        Return r_m_id
    End Function
    Public Sub SetMode(ByVal strMode As String)
        mode = strMode
    End Sub
    Public Function GetMode() As String
        Return mode
    End Function
    Public Sub LoadYear(ByRef cmb As ComboBox)
        cmb.Items.Clear()
        For Year As Integer = DateTime.Now.Year To 2000 Step -1
            cmb.Items.Add(Year.ToString)
        Next
    End Sub
    Public Sub SetCurrentRecord()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand(GetQuery, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub LoadSem(ByRef cmb As ComboBox)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT SEMESTER_NAME FROM SEMESTER_MASTER", con)
            ds.Clear()
            da.Fill(ds, "SEMESTER_MASTER")
            cmb.Items.Clear()
            For i As Integer = 0 To ds.Tables("SEMESTER_MASTER").Rows.Count - 1
                cmb.Items.Add(ds.Tables("SEMESTER_MASTER")(i)(0))
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadExamType(ByRef cmb As ComboBox)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT EXAM_TYPE FROM EXAM_TYPE_MASTER", con)
            ds.Clear()
            da.Fill(ds, "EXAM_TYPE_MASTER")
            cmb.Items.Clear()
            For i As Integer = 0 To ds.Tables("EXAM_TYPE_MASTER").Rows.Count - 1
                cmb.Items.Add(ds.Tables("EXAM_TYPE_MASTER")(i)(0))
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadStudentID(ByRef cmb As ComboBox, ByVal tableName As String)
        Try
            Dim query As String = GetQuery()
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter(query, con)
            ds.Clear()
            da.Fill(ds, tableName)
            cmb.Items.Clear()
            For i As Integer = 0 To ds.Tables(tableName).Rows.Count - 1
                cmb.Items.Add(ds.Tables(tableName)(i)("UNIQUE_ID").ToString)
            Next
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function GetString(ByVal query As String) As String
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Return dr.Item(0).ToString
            Else
                Return ""
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        End Try
    End Function
    Public Sub SetLineColor(ByVal dgv As DataGridView, ByVal clr As Color, ByVal atkt As Boolean, ByVal r As Integer, ByVal c As Integer, ByVal flag As Integer)
        Try
            If flag = 0 Then
                If atkt Then
                    For j As Integer = 0 To c
                        dgv.Rows(r).Cells(j).Style.ForeColor = clr
                    Next
                End If
            ElseIf flag = 1 Then
                For j As Integer = 0 To c
                    dgv.Rows(r).Cells(j).Style.BackColor = clr
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SetQuery(ByVal q As String)
        query = q
    End Sub
    Public Function GetQuery() As String
        Return query
    End Function
    Public Sub SetLastQuery(ByVal q As String)
        LastQuery = q
    End Sub
    Public Function GetLastQuery() As String
        Return LastQuery
    End Function
    Public Function CheckStudent(ByVal query As String) As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand(query, con)
            dr = cmd.ExecuteReader
            If dr.Read() Then
                Dim over As Boolean = dr.Item(0)
                Return over
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "CheckStudent")
        End Try
        Return False
    End Function
    Public Function GetTable() As DataTable
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            da = New OleDb.OleDbDataAdapter(GetQuery, con)
            tlb = New DataTable()
            da.Fill(tlb)
            da.Dispose()
            Return tlb
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "GetTable")
            Return Nothing
        End Try
    End Function
    Public Function ExecuteNonQuery() As Boolean
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            cmd = New OleDb.OleDbCommand(GetQuery, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "ExecuteInsertQuery")
            Return False
        End Try
    End Function
End Module
