Imports MySql.Data.MySqlClient


Public Class frmbalance

    Private Sub DisplayBalance()
        Call Connection()
        sql = "SELECT Balance, Status FROM management_table WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Dim balance As Decimal = 0
            If Not IsDBNull(dr("Balance")) Then
                balance = Convert.ToDecimal(dr("Balance"))
            End If

            txtbalance.Text = "₱ " & balance.ToString("N2")

            Dim status As String = dr("Status").ToString()
            dr.Close()

            If balance < 200 AndAlso status <> "Inactive" Then
                MessageBox.Show("Balance is below ₱200. Your account will be deactivated.", "Minimum Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                sql = "UPDATE management_table SET Status='Inactive' WHERE userid=@userid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
                cmd.ExecuteNonQuery()

                txtbalance.Text = "Account Deactivated."
                btnRefresh.Enabled = False
            End If
        Else
            dr.Close()
            txtbalance.Text = "No balance found."
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DisplayBalance()
    End Sub

    Private Sub frmbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBalance()
    End Sub

End Class


