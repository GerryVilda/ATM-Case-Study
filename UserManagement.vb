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
            lv.SubItems.Add(dr("Account_Number").ToString())
            lv.SubItems.Add(dr("Name").ToString())
            lv.SubItems.Add(dr("Pin").ToString())
            lv.SubItems.Add(dr("Role").ToString())
            lv.SubItems.Add(dr("Status").ToString())
            lv.SubItems.Add(dr("Balance").ToString())
            lv.SubItems.Add(dr("Attempts").ToString())
            ListView1.Items.Add(lv)
        End While
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call Connection()
        sql = "SELECT * FROM management_table WHERE `Name` Like '%" & txtsearch.Text & "%' Or `Account_Number` Like '%" & txtsearch.Text & "%'"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListView1.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("userid").ToString())
            lv.SubItems.Add(dr("Account_Number").ToString())
            lv.SubItems.Add(dr("Name").ToString())
            lv.SubItems.Add(dr("Pin").ToString())
            lv.SubItems.Add(dr("Role").ToString())
            lv.SubItems.Add(dr("Status").ToString())
            lv.SubItems.Add(dr("Balance").ToString())
            lv.SubItems.Add(dr("Attempts").ToString())
            ListView1.Items.Add(lv)
        End While
    End Sub

    Private Sub CheckIfExist()
        Call Connection()
        sql = "SELECT * FROM management_table WHERE Account_Number='" & txtaccountnumber.Text & "'"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", txtuserid.Text)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            MsgBox("Account Number Already Exists", vbExclamation, "Error")
        Else
            Save()
        End If

    End Sub

    Private Sub Save()
        Call Connection()
        sql = "INSERT INTO management_table (Account_Number, Name, Pin, Role, Status, Attempts) VALUES (@AccountNumber, @Name, @Pin, @Role, @Status, @Attempts)"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AccountNumber", txtaccountnumber.Text)
            .Parameters.AddWithValue("@Name", txtname.Text)
            .Parameters.AddWithValue("@Pin", txtpin.Text)
            .Parameters.AddWithValue("@Role", cborole.Text)
            .Parameters.AddWithValue("@Status", cbostatus.Text)
            .Parameters.AddWithValue("@Balance", btnbalance.Text)
            .Parameters.AddWithValue("@Attempts", txtattempts.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Saved Successfully", vbInformation, "Information")
        Call LoadData()
        txtaccountnumber.Clear()
        txtname.Clear()
        txtpin.Clear()
        txtuserid.Clear()
        txtattempts.Clear()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If MsgBox("Do you want to save this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            CheckIfExist()
        Else

        End If
    End Sub


    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count > 0 Then
            txtuserid.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtaccountnumber.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtname.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtpin.Text = ListView1.SelectedItems(0).SubItems(3).Text
            cborole.Text = ListView1.SelectedItems(0).SubItems(4).Text
            cbostatus.Text = ListView1.SelectedItems(0).SubItems(5).Text
            btnbalance.Text = ListView1.SelectedItems(0).SubItems(6).Text
            txtattempts.Text = ListView1.SelectedItems(0).SubItems(7).Text
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If MsgBox("Do you want to update this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            UpdateTable()
        Else

        End If
    End Sub

    Private Sub UpdateTable()
        Call Connection()
        sql = "UPDATE management_table SET Account_Number=@AccountNumber, Name=@Name, Pin=@Pin, Role=@Role, Status=@Status, Attempts=@Attempts WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@AccountNumber", txtaccountnumber.Text)
            .Parameters.AddWithValue("@Name", txtname.Text)
            .Parameters.AddWithValue("@Pin", txtpin.Text)
            .Parameters.AddWithValue("@Role", cborole.Text)
            .Parameters.AddWithValue("@Status", cbostatus.Text)
            .Parameters.AddWithValue("@userid", txtuserid.Text)
            .Parameters.AddWithValue("@Attempts", txtattempts.Text)
            .ExecuteNonQuery()
        End With
        MsgBox("Record Updated Successfully", vbInformation, "Information")
        Call LoadData()
        txtaccountnumber.Clear()
        txtname.Clear()
        txtpin.Clear()
        txtuserid.Clear()
        txtattempts.Clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Call Connection()

        If MsgBox("Do you want to delete this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then


            sql = "INSERT INTO deleted_management_table " &
              "(Account_Number, Name, username, firstname, lastname, birthdate, cellphone, Pin, Role, Attempts, Status, Balance) " &
              "SELECT Account_Number, Name, username, firstname, lastname, birthdate, cellphone, Pin, Role, Attempts, Status, Balance " &
              "FROM management_table WHERE userid=@userid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", txtuserid.Text)
            cmd.ExecuteNonQuery()


            sql = "DELETE FROM management_table WHERE userid=@userid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@userid", txtuserid.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Record moved to Deleted table and removed from main table.", vbInformation, "Information")


            txtaccountnumber.Clear()
            txtname.Clear()
            txtpin.Clear()
            txtuserid.Clear()
            txtattempts.Clear()
            btnbalance.Clear()

            Call LoadData()
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDataRestoration.Show
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Call LoadData()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
    End Sub

End Class
