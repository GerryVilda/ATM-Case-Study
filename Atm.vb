Imports MySql.Data.MySqlClient

Module Atm

    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub Connection()
        cn.Close()
        cn.ConnectionString = "server=localhost;user=root;password=;database=atm"
        cn.Open()
    End Sub

End Module
