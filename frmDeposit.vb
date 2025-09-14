Imports MySql.Data.MySqlClient

Public Class frmDeposit

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim amount As Double = Val(txtdeposit.Text)

        If amount <= 0 Then
            MsgBox("Please enter a valid amount.", vbExclamation, "Error")
            Exit Sub
        End If


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

        MsgBox("Deposit successful! ₱" & amount.ToString("N2"), vbInformation, "Deposit")
        txtdeposit.Clear()
    End Sub

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
