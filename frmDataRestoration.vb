Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class frmDataRestoration

    Private Sub frmDataRestoration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBackupData()
    End Sub


    Private Sub LoadBackupData()
        Call Connection()
        sql = "SELECT * FROM deleted_management_table"
        cmd = New MySqlCommand(sql, cn)
        dr = cmd.ExecuteReader
        ListViewbackup.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("userid").ToString())
            lv.SubItems.Add(dr("Account_Number").ToString())
            lv.SubItems.Add(dr("Name").ToString())
            lv.SubItems.Add(dr("Pin").ToString())
            lv.SubItems.Add(dr("Role").ToString())
            lv.SubItems.Add(dr("Status").ToString())
            lv.SubItems.Add(String.Format("₱ {0:N2}", dr("Balance")))
            lv.SubItems.Add(dr("Attempts").ToString())
            ListViewbackup.Items.Add(lv)
        End While
        dr.Close()
    End Sub


    Private Sub ListViewBackup_Click(sender As Object, e As EventArgs) Handles ListViewbackup.Click
        If ListViewbackup.SelectedItems.Count > 0 Then
            txtuseridbackup.Text = ListViewbackup.SelectedItems(0).SubItems(0).Text
            txtaccountnumberbackup.Text = ListViewbackup.SelectedItems(0).SubItems(1).Text
            txtnamebackup.Text = ListViewbackup.SelectedItems(0).SubItems(2).Text
            txtpinbackup.Text = ListViewbackup.SelectedItems(0).SubItems(3).Text
            cborolebackup.Text = ListViewbackup.SelectedItems(0).SubItems(4).Text
            cbostatusbackup.Text = ListViewbackup.SelectedItems(0).SubItems(5).Text
            btnbalancebackup.Text = ListViewbackup.SelectedItems(0).SubItems(6).Text
            txtattemptsbackup.Text = ListViewbackup.SelectedItems(0).SubItems(7).Text
        End If
    End Sub


    Private Sub txtsearchbackup_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbackup.TextChanged
        Call Connection()
        sql = "SELECT * FROM deleted_management_table WHERE `Name` LIKE @search OR `Account_Number` LIKE @search"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@search", "%" & txtsearchbackup.Text & "%")
        dr = cmd.ExecuteReader
        ListViewbackup.Items.Clear()
        While dr.Read()
            Dim lv As New ListViewItem(dr("userid").ToString())
            lv.SubItems.Add(dr("Account_Number").ToString())
            lv.SubItems.Add(dr("Name").ToString())
            lv.SubItems.Add(dr("Pin").ToString())
            lv.SubItems.Add(dr("Role").ToString())
            lv.SubItems.Add(dr("Status").ToString())
            lv.SubItems.Add(String.Format("₱ {0:N2}", dr("Balance")))
            lv.SubItems.Add(dr("Attempts").ToString())
            ListViewbackup.Items.Add(lv)
        End While
        dr.Close()
    End Sub


    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        Call Connection()

        If txtuseridbackup.Text = "" Then
            MsgBox("Please select a record to restore.", vbExclamation, "No Selection")
            Exit Sub
        End If

        If MsgBox("Restore this record to the main table?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            sql = "INSERT INTO management_table (userid, Account_Number, Name, Pin, Role, Status, Balance, Attempts) " &
                  "SELECT userid, Account_Number, Name, Pin, Role, Status, Balance, Attempts " &
                  "FROM deleted_management_table WHERE userid=@uid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@uid", txtuseridbackup.Text)
            cmd.ExecuteNonQuery()


            sql = "DELETE FROM deleted_management_table WHERE userid=@uid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@uid", txtuseridbackup.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Record restored successfully.", vbInformation, "Information")
            LoadBackupData()
        End If
    End Sub

    Private Sub btndeletebackup_Click(sender As Object, e As EventArgs) Handles btndeletebackup.Click
        Call Connection()

        If txtuseridbackup.Text = "" Then
            MsgBox("Please select a record to delete.", vbExclamation, "No Selection")
            Exit Sub
        End If


        sql = "SELECT Balance FROM deleted_management_table WHERE userid=@uid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@uid", txtuseridbackup.Text)
        dr = cmd.ExecuteReader
        Dim bal As Double = 0
        If dr.Read() Then
            bal = Convert.ToDouble(dr("Balance"))
        End If
        dr.Close()

        If bal > 0 Then
            MsgBox("This account still has a remaining balance of ₱ " & bal.ToString("N2") & ". You cannot delete it.", vbExclamation, "Cannot Delete")
            Exit Sub
        End If

        If MsgBox("Permanently delete this record?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            sql = "DELETE FROM deleted_management_table WHERE userid=@uid"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@uid", txtuseridbackup.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Record permanently deleted.", vbInformation, "Information")
            LoadBackupData()
        End If
    End Sub

End Class