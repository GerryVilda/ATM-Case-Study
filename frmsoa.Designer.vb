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
        ListView1 = New ListView()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader2, ColumnHeader3, ColumnHeader1, ColumnHeader5, ColumnHeader4, ColumnHeader6})
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 0)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(709, 623)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
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
        ' frmsoa
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(705, 623)
        Controls.Add(ListView1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmsoa"
        Text = "frmsoa"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
