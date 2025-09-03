Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call Connection()

        sql = "SELECT * FROM management_table WHERE `Account_Number`=@AccountNumber AND Pin=@Pin"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AccountNumber", txtloginusername.Text.Trim())
        cmd.Parameters.AddWithValue("@Pin", txtloginpassword.Text.Trim())

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            If dr("Status").ToString() = "Active" Then
                Dim role As String = dr("Role").ToString()
                LoggedInUserId = dr("userid")
                Dim userName As String = dr("Name").ToString()

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

            Else
                MsgBox("Your account is Deactivated. Contact admin.", vbExclamation, "Error")
            End If
        Else
            MsgBox("Invalid Account Number or Pin.", vbCritical, "Login Failed")
        End If

        dr.Close()
    End Sub
End Class

