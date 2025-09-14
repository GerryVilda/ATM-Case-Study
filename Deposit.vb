Imports MySql.Data.MySqlClient

Public Class Deposit

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btndeposit.Click
        Call Connection()

        sql = "UPDATE management_table SET Balance = Balance + @Amount WHERE Account_Number = @Account_Number"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Amount", txtdeposit.Text)
        cmd.Parameters.AddWithValue("@Account_Number", UserManagement.txtaccountnumber.Text)
        cmd.ExecuteNonQuery()

        sql = "SELECT userid FROM management_table WHERE Account_Number = @Account_Number"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Account_Number", UserManagement.txtaccountnumber.Text)
        Dim userid As Integer = cmd.ExecuteScalar()

        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) VALUES (@userid, 'Deposit', @Amount, NOW())"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", userid)
        cmd.Parameters.AddWithValue("@Amount", txtdeposit.Text)
        cmd.ExecuteNonQuery()

        MsgBox("Deposit successful", vbInformation, "Success")
    End Sub

End Class


