Imports MySql.Data.MySqlClient

Public Class frmsoa

    Private Sub frmsoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()
    End Sub

    Private Sub LoadTransactions()
        Call Connection()


        sql = "SELECT t.TransactionType,
                      t.Amount,
                      t.TransactionDate
               FROM transactions t
               INNER JOIN management_table m ON t.userid = m.userid
               WHERE t.userid = @userid
               ORDER BY t.TransactionDate DESC"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)

        dr = cmd.ExecuteReader()
        ListView1.Items.Clear()


        With ListView1
            .View = View.Details
            .Columns.Clear()
            .Columns.Add("Transaction Type", 150)
            .Columns.Add("Amount", 100)
            .Columns.Add("Transaction Date", 150)
        End With


        While dr.Read()
            Dim item As New ListViewItem(dr("TransactionType").ToString())
            item.SubItems.Add(FormatCurrency(dr("Amount")))
            item.SubItems.Add(
                Convert.ToDateTime(dr("TransactionDate")).ToString("yyyy-MM-dd HH:mm")
            )
            ListView1.Items.Add(item)
        End While

        dr.Close()
    End Sub

End Class
