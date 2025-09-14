Imports MySql.Data.MySqlClient

Public Class frmwithdraw

    Private Sub frmwithdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnwithdraw_Click(sender As Object, e As EventArgs) Handles btnwithdraw.Click
        If txtwithdraw.Text = "" Or Not IsNumeric(txtwithdraw.Text) Then
            MsgBox("Please enter a valid amount.", vbExclamation, "Error")
            Exit Sub
        End If

        Dim withdrawAmount As Double = CDbl(txtwithdraw.Text)

        If withdrawAmount <= 0 Then
            MsgBox("Amount must be greater than zero.", vbExclamation, "Error")
            Exit Sub
        End If


        Call Connection()
        sql = "SELECT Balance FROM management_table WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        dr = cmd.ExecuteReader()

        Dim currentBalance As Double = 0
        If dr.Read() Then
            currentBalance = dr("Balance")
        End If
        dr.Close()

        If currentBalance < withdrawAmount Then
            MsgBox("Insufficient balance! Current Balance: ₱" & currentBalance.ToString("N2"), vbExclamation, "Error")
            Exit Sub
        End If


        sql = "UPDATE management_table SET Balance = Balance - @Amount WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Amount", withdrawAmount)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.ExecuteNonQuery()


        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) VALUES (@userid, 'Withdrawal', @Amount, NOW())"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.Parameters.AddWithValue("@Amount", withdrawAmount)
        cmd.ExecuteNonQuery()

        MsgBox("Withdrawal successful!" & vbCrLf &
               "Amount Withdrawn: ₱" & withdrawAmount.ToString("N2") & vbCrLf &
               "New Balance: ₱" & (currentBalance - withdrawAmount).ToString("N2"),
               vbInformation, "Transaction Complete")

        txtwithdraw.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class