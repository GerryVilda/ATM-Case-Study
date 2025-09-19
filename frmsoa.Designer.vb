<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsoa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        listviewsoa = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        btngeneratereciept = New Button()
        dtpfrom = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        dtpto = New DateTimePicker()
        btnfilter = New Button()
        SuspendLayout()
        ' 
        ' listviewsoa
        ' 
        listviewsoa.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader3, ColumnHeader1, ColumnHeader5, ColumnHeader4, ColumnHeader6})
        listviewsoa.FullRowSelect = True
        listviewsoa.GridLines = True
        listviewsoa.Location = New Point(0, 80)
        listviewsoa.Name = "listviewsoa"
        listviewsoa.Size = New Size(707, 532)
        listviewsoa.TabIndex = 0
        listviewsoa.UseCompatibleStateImageBehavior = False
        listviewsoa.View = View.Details
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.DisplayIndex = 1
        ColumnHeader2.Text = "Name"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.DisplayIndex = 2
        ColumnHeader3.Text = "Transaction"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.DisplayIndex = 0
        ColumnHeader1.Text = "Account Number"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.DisplayIndex = 5
        ColumnHeader5.Text = "Transaction Date"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.DisplayIndex = 3
        ColumnHeader4.Text = "Sent To"
        ColumnHeader4.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.DisplayIndex = 4
        ColumnHeader6.Text = "Amount"
        ColumnHeader6.Width = 100
        ' 
        ' btngeneratereciept
        ' 
        btngeneratereciept.BackColor = Color.Goldenrod
        btngeneratereciept.FlatAppearance.BorderSize = 0
        btngeneratereciept.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btngeneratereciept.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btngeneratereciept.FlatStyle = FlatStyle.Flat
        btngeneratereciept.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btngeneratereciept.ForeColor = Color.Black
        btngeneratereciept.Location = New Point(467, 617)
        btngeneratereciept.Margin = New Padding(2)
        btngeneratereciept.Name = "btngeneratereciept"
        btngeneratereciept.Size = New Size(240, 76)
        btngeneratereciept.TabIndex = 1
        btngeneratereciept.Text = "Generate Receipt"
        btngeneratereciept.UseVisualStyleBackColor = False
        ' 
        ' dtpfrom
        ' 
        dtpfrom.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        dtpfrom.Location = New Point(0, 40)
        dtpfrom.Name = "dtpfrom"
        dtpfrom.Size = New Size(313, 34)
        dtpfrom.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 28)
        Label1.TabIndex = 3
        Label1.Text = "From:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(354, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 28)
        Label2.TabIndex = 5
        Label2.Text = "To:"
        ' 
        ' dtpto
        ' 
        dtpto.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic)
        dtpto.Location = New Point(354, 40)
        dtpto.Name = "dtpto"
        dtpto.Size = New Size(313, 34)
        dtpto.TabIndex = 4
        ' 
        ' btnfilter
        ' 
        btnfilter.BackColor = Color.Goldenrod
        btnfilter.FlatAppearance.BorderSize = 0
        btnfilter.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnfilter.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnfilter.FlatStyle = FlatStyle.Flat
        btnfilter.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnfilter.ForeColor = SystemColors.ActiveCaptionText
        btnfilter.Location = New Point(0, 617)
        btnfilter.Margin = New Padding(2)
        btnfilter.Name = "btnfilter"
        btnfilter.Size = New Size(240, 76)
        btnfilter.TabIndex = 6
        btnfilter.Text = "Filter"
        btnfilter.UseVisualStyleBackColor = False
        ' 
        ' frmsoa
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(716, 701)
        Controls.Add(btnfilter)
        Controls.Add(Label2)
        Controls.Add(dtpto)
        Controls.Add(Label1)
        Controls.Add(dtpfrom)
        Controls.Add(btngeneratereciept)
        Controls.Add(listviewsoa)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmsoa"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmsoa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents listviewsoa As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btngeneratereciept As Button
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents btnfilter As Button
End Class
