Imports MySql.Data.MySqlClient
Public Class dashboard
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub BTNBALANCEINQUIRY_Click(sender As Object, e As EventArgs) Handles BTNBALANCEINQUIRY.Click

    End Sub

    Private Sub btndeposit_Click(sender As Object, e As EventArgs) Handles btndeposit.Click
        Call Connection()
        Dim amount As String
        amount = InputBox("Enter amount to deposit:", "Deposit")

        If amount = "" Then Exit Sub

        Call Connection()

        sql = "UPDATE management_table SET Balance = Balance + @Amount WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Amount", amount)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.ExecuteNonQuery()

        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) VALUES (@userid, 'Deposit', @Amount, NOW())"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.Parameters.AddWithValue("@Amount", amount)
        cmd.ExecuteNonQuery()

        MsgBox("Deposit successful! Amount: " & amount, vbInformation, "Deposit")
    End Sub

    Private Sub btnwithdrawal_Click(sender As Object, e As EventArgs) Handles btnwithdrawal.Click
        MsgBox("Logged in as UserID: " & LoggedInUserId)
    End Sub

    Private Sub btntransfer_Click(sender As Object, e As EventArgs) Handles btntransfer.Click

    End Sub

    Private Sub btnstatementofaccount_Click(sender As Object, e As EventArgs) Handles btnstatementofaccount.Click

    End Sub
End Class
