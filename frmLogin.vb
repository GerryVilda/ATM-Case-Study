Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call Connection()


        sql = "SELECT * FROM management_table WHERE `Account_Number`=@AccountNumber"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AccountNumber", txtloginusername.Text.Trim())
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Dim userId As Integer = dr("userid")
            Dim dbPin As String = dr("Pin").ToString()
            Dim attempts As Integer = Convert.ToInt32(dr("Attempts"))
            Dim status As String = dr("Status").ToString()
            dr.Close()


            If status = "Deactivated" Then
                MsgBox("Your account is Deactivated. Contact admin.", vbExclamation, "Error")
                txtloginpassword.Enabled = False
                Exit Sub
            End If


            If dbPin = txtloginpassword.Text.Trim() Then

                sql = "UPDATE management_table SET Attempts=3 WHERE userid=@uid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@uid", userId)
                cmd.ExecuteNonQuery()


                sql = "SELECT * FROM management_table WHERE userid=@uid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@uid", userId)
                dr = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim role As String = dr("Role").ToString()
                    Dim userName As String = dr("Name").ToString()
                    LoggedInUserId = dr("userid")

                    If role = "Admin" Then
                        MsgBox("Login Successful! Welcome Admin " & userName, vbInformation, "Success")
                        dr.Close()
                        UserManagement.Show()

                    ElseIf role = "User" Then
                        MsgBox("Login Successful! Welcome " & userName, vbInformation, "Success")
                        dr.Close()
                        dashboard.Show()

                    Else
                        MsgBox("Role not recognized. Contact admin.", vbExclamation, "Error")
                    End If
                End If

            Else

                attempts -= 1

                If attempts <= 0 Then
                    sql = "UPDATE management_table SET Attempts=0, Status='Deactivated' WHERE userid=@uid"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@uid", userId)
                    cmd.ExecuteNonQuery()

                    MsgBox("Account has been deactivated due to multiple failed login attempts.", vbCritical, "Account Locked")
                Else
                    sql = "UPDATE management_table SET Attempts=@att WHERE userid=@uid"
                    cmd = New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@att", attempts)
                    cmd.Parameters.AddWithValue("@uid", userId)
                    cmd.ExecuteNonQuery()

                    MsgBox("Invalid PIN. Remaining attempts: " & attempts, vbExclamation, "Login Failed")
                End If
            End If
        Else
            dr.Close()
            MsgBox("Account Number not found.", vbCritical, "Login Failed")
        End If

        dr.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lnklblAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAccount.LinkClicked
        frmAccountCreation.Show()
    End Sub
End Class


