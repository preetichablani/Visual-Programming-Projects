Imports System.Data.SqlClient
Imports MySql.Data
Imports MySql.Data.MySqlClient

Module Module1

    Public con As MySqlConnection
    Public Sub connect()
        con = New MySqlConnection("Server = localhost;Database=student_db;Uid=root;Pwd=;")
    End Sub
End Module
