Imports MySql.Data.MySqlClient


Public Class dashboard
    Private Sub ChildForm(ByVal form As Form)
        PanelShow.Controls.Clear()
        form.TopLevel = False
        PanelShow.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub BTNBALANCEINQUIRY_Click(sender As Object, e As EventArgs) Handles BTNBALANCEINQUIRY.Click
        ChildForm(frmbalance)
    End Sub

    Private Sub btndeposit_Click(sender As Object, e As EventArgs) Handles btndeposit.Click
        ChildForm(frmDeposit)
    End Sub

    Private Sub btnwithdrawal_Click(sender As Object, e As EventArgs) Handles btnwithdrawal.Click
        ChildForm(frmwithdraw)
    End Sub

    Private Sub btntransfer_Click(sender As Object, e As EventArgs) Handles btntransfer.Click
        ChildForm(frmtransfer)
    End Sub

    Private Sub btnstatementofaccount_Click(sender As Object, e As EventArgs) Handles btnstatementofaccount.Click
        ChildForm(frmsoa)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserName()
    End Sub

    Private Sub DisplayUserName()
        Call Connection()
        sql = "SELECT Name FROM management_table WHERE userid=@userid"
        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            lblusername.Text = "Welcome, " & dr("Name").ToString()
        Else
            lblusername.Text = "Welcome, User"
        End If

        dr.Close()
    End Sub
End Class




