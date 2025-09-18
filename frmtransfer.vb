Imports MySql.Data.MySqlClient

Public Class frmtransfer

    Private Sub frmtransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntransfer_Click(sender As Object, e As EventArgs) Handles btntransfer.Click
        If txttransfer.Text = "" OrElse txtamount.Text = "" OrElse Not IsNumeric(txtamount.Text) Then
            MsgBox("Please enter a valid account number and amount.", vbExclamation, "Error")
            Exit Sub
        End If

        Dim toAccount As String = txttransfer.Text.Trim()
        Dim transferAmount As Double = CDbl(txtamount.Text)
        Dim totalDeduction As Double = transferAmount + 15

        If transferAmount <= 0 Then
            MsgBox("Amount must be greater than zero.", vbExclamation, "Error")
            Exit Sub
        End If

        Call Connection()


        sql = "SELECT Balance, PIN FROM management_table WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        dr = cmd.ExecuteReader()

        Dim senderBalance As Double = 0
        Dim correctPin As String = ""
        If dr.Read() Then
            senderBalance = dr("Balance")
            correctPin = dr("PIN").ToString()
        End If
        dr.Close()

        If senderBalance < totalDeduction Then
            MsgBox("Insufficient balance! You need at least ₱" & totalDeduction.ToString("N2"), vbExclamation, "Error")
            Exit Sub
        End If


        sql = "SELECT userid FROM management_table WHERE Account_Number=@AccountNumber"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AccountNumber", toAccount)
        Dim recipientId As Object = cmd.ExecuteScalar()

        If recipientId Is Nothing Then
            MsgBox("Recipient account not found.", vbExclamation, "Error")
            Exit Sub
        End If

        If recipientId = LoggedInUserId Then
            MsgBox("You cannot transfer money to your own account.", vbExclamation, "Error")
            Exit Sub
        End If


        Dim enteredPin As String = InputBox("Please enter your PIN to confirm the transfer:", "PIN Confirmation")
        If enteredPin = "" Then
            MsgBox("Transfer cancelled. No PIN entered.", vbExclamation, "Cancelled")
            Exit Sub
        End If

        If enteredPin <> correctPin Then
            MsgBox("Invalid PIN. Transfer cancelled.", vbCritical, "Error")
            Exit Sub
        End If


        sql = "UPDATE management_table SET Balance = Balance - @Amount WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Amount", totalDeduction)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.ExecuteNonQuery()


        sql = "UPDATE management_table SET Balance = Balance + @Amount WHERE userid=@RecipientId"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@Amount", transferAmount)
        cmd.Parameters.AddWithValue("@RecipientId", recipientId)
        cmd.ExecuteNonQuery()


        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate, Remarks) " &
              "VALUES (@userid, 'Transfer Sent', @Amount, NOW(), 'Includes ₱15 fee')"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.Parameters.AddWithValue("@Amount", transferAmount)
        cmd.ExecuteNonQuery()


        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) " &
              "VALUES (@userid, 'Transfer Received', @Amount, NOW())"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", recipientId)
        cmd.Parameters.AddWithValue("@Amount", transferAmount)
        cmd.ExecuteNonQuery()

        MsgBox("Transfer successful!" & vbCrLf &
               "Amount: ₱" & transferAmount.ToString("N2") & vbCrLf &
               "Fee: ₱15.00" & vbCrLf &
               "To Account: " & toAccount & vbCrLf &
               "Your New Balance: ₱" & (senderBalance - totalDeduction).ToString("N2"),
               vbInformation, "Transfer Complete")

        txttransfer.Clear()
        txtamount.Clear()
    End Sub

End Class
