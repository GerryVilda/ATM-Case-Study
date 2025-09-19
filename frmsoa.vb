Imports MySql.Data.MySqlClient

Public Class frmsoa

    Private Sub frmsoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadTransactions(New DateTime(1900, 1, 1), New DateTime(2100, 12, 31, 23, 59, 59))
    End Sub


    Private Sub LoadTransactions(ByVal fromDate As DateTime, ByVal toDate As DateTime)
        Call Connection()

        sql = "SELECT t.TransactionType,
                      t.Amount,
                      t.TransactionDate
               FROM transactions t
               INNER JOIN management_table m ON t.userid = m.userid
               WHERE t.userid = @userid
               AND t.TransactionDate BETWEEN @fromDate AND @toDate
               ORDER BY t.TransactionDate DESC"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@userid", LoggedInUserId)
        cmd.Parameters.AddWithValue("@fromDate", fromDate.ToString("yyyy-MM-dd HH:mm:ss"))
        cmd.Parameters.AddWithValue("@toDate", toDate.ToString("yyyy-MM-dd HH:mm:ss"))

        dr = cmd.ExecuteReader()
        listviewsoa.Items.Clear()


        With listviewsoa
            .View = View.Details
            .Columns.Clear()
            .Columns.Add("Transaction Type", 150)
            .Columns.Add("Amount", 100)
            .Columns.Add("Transaction Date", 150)
        End With


        While dr.Read()
            Dim item As New ListViewItem(dr("TransactionType").ToString())
            item.SubItems.Add(FormatCurrency(dr("Amount")))
            item.SubItems.Add(Convert.ToDateTime(dr("TransactionDate")).ToString("yyyy-MM-dd HH:mm"))
            listviewsoa.Items.Add(item)
        End While

        dr.Close()
        cn.Close()
    End Sub


    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        If dtpfrom.Value > dtpto.Value Then
            MessageBox.Show("Start date cannot be later than end date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim fromDate As DateTime = dtpfrom.Value.Date
        Dim toDate As DateTime = dtpto.Value.Date.AddDays(1).AddSeconds(-1)

        LoadTransactions(fromDate, toDate)
    End Sub


    Private Sub dtpfrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpfrom.ValueChanged

    End Sub

    Private Sub dtpto_ValueChanged(sender As Object, e As EventArgs) Handles dtpto.ValueChanged

    End Sub


    Private Sub btngeneratereciept_Click(sender As Object, e As EventArgs) Handles btngeneratereciept.Click
        If listviewsoa.Items.Count = 0 Then
            MsgBox("No transactions to generate receipt.")
            Exit Sub
        End If

        Dim receipt As String = "Statement of Account" & vbCrLf
        receipt &= "Generated: " & Now.ToString("yyyy-MM-dd HH:mm") & vbCrLf & vbCrLf

        Dim total As Decimal = 0

        For Each item As ListViewItem In listviewsoa.Items
            receipt &= item.SubItems(0).Text & " | " & item.SubItems(1).Text & " | " & item.SubItems(2).Text & vbCrLf
            total += CDec(item.SubItems(1).Text.Replace("₱", "").Replace(",", ""))
        Next

        receipt &= vbCrLf & "Total Amount: " & FormatCurrency(total)

        MsgBox(receipt)
    End Sub
End Class
