Imports MySql.Data.MySqlClient

Public Class frmAccountCreation


    Private Sub btncreateaccount_Click(sender As Object, e As EventArgs) Handles btncreateaccount.Click


        If txtcreateuser.Text = "" Or txtcreatefirstname.Text = "" Or txtcreatelastname.Text = "" Or
           txtcreatecpnumber.Text = "" Or txtcreateaccounnt.Text = "" Or txtcreatepin.Text = "" Then
            MsgBox("Please fill in all fields before creating an account.", vbExclamation, "Missing Information")
            Exit Sub
        End If

        If Not IsNumeric(txtcreateaccounnt.Text) OrElse txtcreateaccounnt.Text.Length <> 10 Then
            MsgBox("Account Number must be exactly 10 digits.", vbExclamation, "Invalid Input")
            Exit Sub
        End If


        If Not IsNumeric(txtcreatepin.Text) OrElse txtcreatepin.Text.Length <> 8 Then
            MsgBox("PIN must be exactly 8 digits.", vbExclamation, "Invalid Input")
            Exit Sub
        End If


        If Not IsNumeric(txtcreatecpnumber.Text) OrElse txtcreatecpnumber.Text.Length <> 11 OrElse Not txtcreatecpnumber.Text.StartsWith("09") Then
            MsgBox("Cellphone number must be 11 digits and start with '09'.", vbExclamation, "Invalid Input")
            Exit Sub
        End If

        Call Connection()


        Dim result As DialogResult
        result = MsgBox("By creating an account, you agree to our Privacy Policy and Terms of Service." &
                        vbCrLf & "Do you want to continue?", vbQuestion + vbYesNo, "Privacy Notice")
        If result = DialogResult.No Then Exit Sub


        sql = "INSERT INTO management_table " &
              "(Account_Number, Name, username, firstname, lastname, birthdate, cellphone, Pin, Role, Attempts, Status, Balance) " &
              "VALUES (@AccountNumber, @Name, @username, @firstname, @lastname, @birthdate, @cellphone, @Pin, @Role, @Attempts, @Status, 0)"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AccountNumber", txtcreateaccounnt.Text)
            .Parameters.AddWithValue("@Name", txtcreateuser.Text.Trim())
            .Parameters.AddWithValue("@username", txtcreateuser.Text.Trim())
            .Parameters.AddWithValue("@firstname", txtcreatefirstname.Text.Trim())
            .Parameters.AddWithValue("@lastname", txtcreatelastname.Text.Trim())
            .Parameters.AddWithValue("@birthdate", dtpbirthday.Value.ToString("yyyy-MM-dd"))
            .Parameters.AddWithValue("@cellphone", txtcreatecpnumber.Text.Trim())
            .Parameters.AddWithValue("@Pin", txtcreatepin.Text.Trim())
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

    Private Sub frmAccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
