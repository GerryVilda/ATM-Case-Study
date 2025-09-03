Imports MySql.Data.MySqlClient
Public Class frmsoa

    Private Sub frmsoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadTransactions()
        End Sub

        Private Sub LoadTransactions()
            Call Connection()
            sql = "SELECT m.Account_Number, m.Name, t.TransactionType, t.TransactionDate 
               FROM transactions t
               INNER JOIN management_table m ON t.userid = m.userid
               WHERE t.userid=@userid
               ORDER BY t.TransactionDate DESC"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
            dr = cmd.ExecuteReader()
            ListView1.Items.Clear()

            While dr.Read()

                Dim item As New ListViewItem(dr("Account_Number").ToString())
                item.SubItems.Add(dr("Name").ToString())
                item.SubItems.Add(dr("TransactionType").ToString())
                item.SubItems.Add(dr("TransactionDate").ToString())
                ListView1.Items.Add(item)
            End While

            dr.Close()
        End Sub
    End Class

