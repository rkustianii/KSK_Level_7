Imports System.Data.OleDb
Module modkoneksi
    Public conn As OleDbConnection
    Public dtadapter, adp, da As New OleDbDataAdapter
    Public dtset, ds As DataSet
    Public cmd As OleDbCommand
    Public dtreader, rd As OleDbDataReader
    Public sql, str As String
    Public Function App_Path()
        Return System.AppDomain.CurrentDomain.BaseDirectory
    End Function
    Public Sub koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Microsoft\OneDrive\Documents\KSK Level 7\dbindekspenyakit.accdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module

