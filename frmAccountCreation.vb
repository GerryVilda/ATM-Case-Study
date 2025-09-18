Imports MySql.Data.MySqlClient

Public Class frmAccountCreation

    Private Sub btncreateaccount_Click(sender As Object, e As EventArgs) Handles btncreateaccount.Click

        If txtcreateuser.Text = "" Or txtcreatefirstname.Text = "" Or txtcreatelastname.Text = "" Or
               txtcreatecpnumber.Text = "" Or txtcreateaccounnt.Text = "" Or txtcreatepin.Text = "" Then
                MsgBox("Please fill in all fields before creating an account.", vbExclamation, "Missing Information")
                Exit Sub
            End If

        Dim result As DialogResult
            result = MsgBox("By creating an account, you agree to our Privacy Policy and Terms of Service." &
                            vbCrLf & "Do you want to continue?", vbQuestion + vbYesNo, "Privacy Notice")

            If result = DialogResult.No Then

            Exit Sub
            End If

        Call Connection()

            sql = "INSERT INTO management_table " &
                  "(Account_Number, Name, username, firstname, lastname, birthdate, cellphone, Pin, Role, Attempts, Status, Balance) " &
                  "VALUES (@AccountNumber, @Name, @username, @firstname, @lastname, @birthdate, @cellphone, @Pin, @Role, @Attempts, @Status, 0)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@AccountNumber", txtcreateaccounnt.Text)
                .Parameters.AddWithValue("@Name", txtcreateuser.Text)
                .Parameters.AddWithValue("@username", txtcreateuser.Text)
                .Parameters.AddWithValue("@firstname", txtcreatefirstname.Text)
                .Parameters.AddWithValue("@lastname", txtcreatelastname.Text)
                .Parameters.AddWithValue("@birthdate", dtpbirthday.Value)
                .Parameters.AddWithValue("@cellphone", txtcreatecpnumber.Text)
                .Parameters.AddWithValue("@Pin", txtcreatepin.Text)
                .Parameters.AddWithValue("@Role", "User")
                .Parameters.AddWithValue("@Attempts", 3)
                .Parameters.AddWithValue("@Status", "Active")
                .ExecuteNonQuery()
            End With

            MsgBox("Account created successfully.", vbInformation, "Saved")

        txtcreateuser.Clear()
            txtcreatefirstname.Clear()
            txtcreatelastname.Clear()
            txtcreatecpnumber.Clear()
            txtcreateaccounnt.Clear()
            txtcreatepin.Clear()
            dtpbirthday.Value = DateTime.Today
        End Sub
    End Class
