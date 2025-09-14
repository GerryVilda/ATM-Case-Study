Imports MySql.Data.MySqlClient

Public Class Withdrawal

    Private Sub btnwithdraw_Click(sender As Object, e As EventArgs) Handles btnwithdraw.Click
        Dim withdrawAmount As Decimal = Val(txtwithdrawamount.Text)

        If withdrawAmount <= 0 Then
                MessageBox.Show("Please enter a valid withdrawal amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Call Connection()
            sql = "SELECT Balance FROM management_table WHERE Account_Number='" & frmLogin.txtloginusername.Text & "'"
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim currentBalance As Decimal = 0
            If dr.Read() Then
                currentBalance = dr("Balance")
            Else
                MessageBox.Show("Account not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dr.Close()
                Exit Sub
            End If
            dr.Close()

            If withdrawAmount > currentBalance Then
                MessageBox.Show("Insufficient funds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim newBalance As Decimal = currentBalance - withdrawAmount
            sql = "UPDATE management_table SET Balance=" & newBalance & " WHERE Account_Number='" & frmLogin.txtloginusername.Text & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            sql = "INSERT INTO transactions_table (Account_Number, Transaction_Type, Amount, Transaction_Date) " &
                  "VALUES ('" & frmLogin.txtloginusername.Text & "', 'Withdraw', " & withdrawAmount & ", NOW())"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Withdrawal successful! New balance: " & newBalance, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtwithdrawamount.Clear()

        cn.Close()
        End Sub

    End Class
