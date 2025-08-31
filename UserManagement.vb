Imports MySql.Data.MySqlClient

Public Class UserManagement

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadData()
    End Sub

    Private Sub LoadData()
        Call Connection()
        sql = "SELECT * FROM management_table"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("userid").ToString())
            lv.SubItems.Add(dr("Account_Number").ToString()) ' ✅ fixed
            lv.SubItems.Add(dr("Name").ToString())
            lv.SubItems.Add(dr("Pin").ToString())
            lv.SubItems.Add(dr("Role").ToString())
            lv.SubItems.Add(dr("Status").ToString())
            ListView1.Items.Add(lv)
        End While
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call Connection()
        sql = "SELECT * FROM management_table WHERE `Name` LIKE '%" & txtsearch.Text & "%' OR `Account_Number` LIKE '%" & txtsearch.Text & "%'" ' ✅ fixed
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("userid").ToString())
            lv.SubItems.Add(dr("Account_Number").ToString()) ' ✅ fixed
            lv.SubItems.Add(dr("Name").ToString())
            lv.SubItems.Add(dr("Pin").ToString())
            lv.SubItems.Add(dr("Role").ToString())
            lv.SubItems.Add(dr("Status").ToString())
            ListView1.Items.Add(lv)
        End While
    End Sub

    Private Sub CheckIfExist()
        Call Connection()
        sql = "SELECT * FROM management_table WHERE Account_Number = @AccountNumber" ' ✅ fixed
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@AccountNumber", txtaccountnumber.Text)
        dr = cmd.ExecuteReader
        If dr.Read() = True Then
            MessageBox.Show("Account Number Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtaccountnumber.Clear()
            txtaccountnumber.Focus()
        End If
        dr.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If MsgBox("Do you want to save this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Save()
        Else
            CheckIfExist()
        End If
    End Sub

    Private Sub Save()
        Call Connection()
        sql = "INSERT INTO management_table (Account_Number, Name, Pin, Role, Status) VALUES (@AccountNumber, @Name, @Pin, @Role, @Status)" ' ✅ fixed
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AccountNumber", txtaccountnumber.Text)
            .Parameters.AddWithValue("@Name", txtname.Text)
            .Parameters.AddWithValue("@Pin", txtpin.Text)
            .Parameters.AddWithValue("@Role", cborole.Text)
            .Parameters.AddWithValue("@Status", cbostatus.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Saved Successfully", vbInformation, "Information")
        Call LoadData()
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            txtuserid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtaccountnumber.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtpin.Text = ListView1.SelectedItems(0).SubItems(3).Text
            cborole.Text = ListView1.SelectedItems(0).SubItems(4).Text
            cbostatus.Text = ListView1.SelectedItems(0).SubItems(5).Text
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If MsgBox("Do you want to update this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            UpdateTable()
        Else
            CheckIfExist()
        End If
    End Sub

    Private Sub UpdateTable()
        Call Connection()
        sql = "UPDATE management_table SET Account_Number=@AccountNumber, Name=@Name, Pin=@Pin, Role=@Role, Status=@Status WHERE userid=@userid" ' ✅ fixed
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AccountNumber", txtaccountnumber.Text)
            .Parameters.AddWithValue("@Name", txtname.Text)
            .Parameters.AddWithValue("@Pin", txtpin.Text)
            .Parameters.AddWithValue("@Role", cborole.Text)
            .Parameters.AddWithValue("@Status", cbostatus.Text)
            .Parameters.AddWithValue("@userid", txtuserid.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Updated Successfully", vbInformation, "Information")
        Call LoadData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Connection()
        If MsgBox("Do you want to delete this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            sql = "DELETE FROM management_table WHERE userid=@userid"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@userid", txtuserid.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Record Deleted Successfully", vbInformation, "Information")
            Call LoadData()
        End If
    End Sub

End Class
