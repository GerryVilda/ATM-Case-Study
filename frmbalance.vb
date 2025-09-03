Imports MySql.Data.MySqlClient
Public Class frmbalance
    Private Sub frmbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBalance()
    End Sub

    Private Sub DisplayBalance()
        Call Connection()
        sql = "SELECT Balance FROM management_table WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            txtbalance.Text = "₱ " & dr("Balance").ToString()
        Else
            txtbalance.Text = "No balance found."
        End If

        dr.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DisplayBalance()
    End Sub
End Class
