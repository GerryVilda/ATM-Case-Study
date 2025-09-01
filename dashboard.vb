Imports MySql.Data.MySqlClient


Public Class dashboard


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            Me.Close()
        End Sub

        Private Sub BTNBALANCEINQUIRY_Click(sender As Object, e As EventArgs) Handles BTNBALANCEINQUIRY.Click
            CheckBalance()
        End Sub

        Private Sub btndeposit_Click(sender As Object, e As EventArgs) Handles btndeposit.Click
            Call Connection()
            Dim input As String = InputBox("Enter amount to deposit:", "Deposit")

            If input = "" Or IsNumeric(input) = False Then
                MsgBox("Please enter a valid number.", vbExclamation, "Error")
                Exit Sub
            End If

            Dim amount As Double = CDbl(input)

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

            MsgBox("Deposit successful! Amount: ₱" & amount.ToString("N2"), vbInformation, "Deposit")
        End Sub

        Private Sub btnwithdrawal_Click(sender As Object, e As EventArgs) Handles btnwithdrawal.Click
            Call Connection()
            Dim input As String = InputBox("Enter amount to withdraw:", "Withdrawal")

            If input = "" Or IsNumeric(input) = False Then
                MsgBox("Please enter a valid number.", vbExclamation, "Error")
                Exit Sub
            End If

            Dim withdrawAmount As Double = CDbl(input)

            If withdrawAmount <= 0 Then
                MsgBox("Amount must be greater than zero.", vbExclamation, "Error")
                Exit Sub
            End If

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
                MsgBox("Insufficient balance! Your current balance is: ₱" & currentBalance.ToString("N2"), vbExclamation, "Error")
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
               "Previous Balance: ₱" & currentBalance.ToString("N2") & vbCrLf &
               "New Balance: ₱" & (currentBalance - withdrawAmount).ToString("N2"),
               vbInformation, "Transaction Complete")
        End Sub

        Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btntransfer.Click
            Call Connection()
            Dim toAccount As String = InputBox("Enter recipient account number:", "Destination Account")
            If toAccount = "" Then Exit Sub

            Dim input As String = InputBox("Enter amount to transfer:", "Amount")
            If input = "" Or IsNumeric(input) = False Then
                MsgBox("Please enter a valid number.", vbExclamation, "Error")
                Exit Sub
            End If

            Dim transferAmount As Double = CDbl(input)

            If transferAmount <= 0 Then
                MsgBox("Amount must be greater than zero.", vbExclamation, "Error")
                Exit Sub
            End If

            Dim fromAccount As String = LoggedInUserId

            sql = "SELECT Balance FROM management_table WHERE userid=@FromAccount"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@FromAccount", fromAccount)
            dr = cmd.ExecuteReader()

            Dim fromBalance As Double = 0
            If dr.Read() Then
                fromBalance = dr("Balance")
            Else
                MsgBox("Sender account not found.", vbExclamation, "Error")
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            If fromBalance < transferAmount Then
                MsgBox("Insufficient balance.", vbExclamation, "Error")
                Exit Sub
            End If

            sql = "SELECT userid FROM management_table WHERE Account_Number=@ToAccount"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@ToAccount", toAccount)
            Dim recipientId As Object = cmd.ExecuteScalar()
            If recipientId Is Nothing Then
                MsgBox("Recipient account not found.", vbExclamation, "Error")
                Exit Sub
            End If

            ' Deduct from sender
            sql = "UPDATE management_table SET Balance = Balance - @Amount WHERE userid=@FromAccount"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.Parameters.AddWithValue("@FromAccount", fromAccount)
            cmd.ExecuteNonQuery()

            ' Add to recipient
            sql = "UPDATE management_table SET Balance = Balance + @Amount WHERE userid=@ToUserId"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.Parameters.AddWithValue("@ToUserId", recipientId)
            cmd.ExecuteNonQuery()

            ' Record transactions
            sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) VALUES (@userid, @Type, @Amount, NOW())"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", fromAccount)
            cmd.Parameters.AddWithValue("@Type", "Transfer Out")
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", recipientId)
            cmd.Parameters.AddWithValue("@Type", "Transfer In")
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.ExecuteNonQuery()

            MsgBox("Transfer successful!" & vbCrLf &
               "Amount: ₱" & transferAmount.ToString("N2") & vbCrLf &
               "To: " & toAccount & vbCrLf &
               "Your New Balance: ₱" & (fromBalance - transferAmount).ToString("N2"),
               vbInformation, "Success")
        End Sub

        Private Sub btnstatementofaccount_Click(sender As Object, e As EventArgs) Handles btnstatementofaccount.Click
            Call Connection()
            sql = "SELECT TransactionType, Amount, TransactionDate FROM transactions WHERE userid=@userid ORDER BY TransactionDate DESC LIMIT 5"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
            dr = cmd.ExecuteReader()

            Dim statement As String = "=== Last 5 Transactions ===" & vbCrLf & vbCrLf
            Dim totalTransactions As Integer = 0

            While dr.Read()
                statement &= dr("TransactionDate").ToString() & " - " & dr("TransactionType").ToString() & " - ₱" & CDbl(dr("Amount")).ToString("N2") & vbCrLf
                totalTransactions += 1
            End While
            dr.Close()

            If totalTransactions = 0 Then
                MsgBox("No transactions found for your account.", vbInformation, "Statement of Account")
            Else
                MsgBox(statement, vbInformation, "Statement of Account")
            End If
        End Sub

        Private Sub CheckBalance()
            Call Connection()
            sql = "SELECT Balance FROM management_table WHERE userid=@userid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim currentBalance As Double = dr("Balance")
                dr.Close()
                MsgBox("Your current balance is: ₱" & currentBalance.ToString("N2"), vbInformation, "Balance Inquiry")
            Else
                dr.Close()
                MsgBox("User not found!", vbCritical, "Error")
            End If
        End Sub

    End Class

