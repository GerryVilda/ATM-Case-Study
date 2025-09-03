Imports MySql.Data.MySqlClient

Public Class frmtransfer

    Private Sub frmtransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub btntransfer_Click(sender As Object, e As EventArgs) Handles btntransfer.Click

        If txttransfer.Text = "" Or txtamount.Text = "" Or Not IsNumeric(txtamount.Text) Then
                MsgBox("Please enter a valid account number and amount.", vbExclamation, "Error")
                Exit Sub
            End If

            Dim toAccount As String = txttransfer.Text
            Dim transferAmount As Double = CDbl(txtamount.Text)

            If transferAmount <= 0 Then
                MsgBox("Amount must be greater than zero.", vbExclamation, "Error")
                Exit Sub
            End If


        Call Connection()
            sql = "SELECT Balance FROM management_table WHERE userid=@userid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
            dr = cmd.ExecuteReader()

            Dim senderBalance As Double = 0
            If dr.Read() Then
                senderBalance = dr("Balance")
            End If
            dr.Close()

            If senderBalance < transferAmount Then
                MsgBox("Insufficient balance! Current Balance: ₱" & senderBalance.ToString("N2"), vbExclamation, "Error")
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


        sql = "UPDATE management_table SET Balance = Balance - @Amount WHERE userid=@userid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
            cmd.ExecuteNonQuery()


        sql = "UPDATE management_table SET Balance = Balance + @Amount WHERE userid=@RecipientId"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.Parameters.AddWithValue("@RecipientId", recipientId)
            cmd.ExecuteNonQuery()


        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) VALUES (@userid, 'Transfer Out', @Amount, NOW())"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.ExecuteNonQuery()


        sql = "INSERT INTO transactions (userid, TransactionType, Amount, TransactionDate) VALUES (@userid, 'Transfer In', @Amount, NOW())"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", recipientId)
            cmd.Parameters.AddWithValue("@Amount", transferAmount)
            cmd.ExecuteNonQuery()

            MsgBox("Transfer successful!" & vbCrLf &
                   "Amount: ₱" & transferAmount.ToString("N2") & vbCrLf &
                   "To Account: " & toAccount & vbCrLf &
                   "Your New Balance: ₱" & (senderBalance - transferAmount).ToString("N2"),
                   vbInformation, "Transfer Complete")

            txttransfer.Clear()
            txtamount.Clear()
        End Sub
    End Class
