<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtransfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtransfer))
        PictureBox1 = New PictureBox()
        btntransfer = New Button()
        txttransfer = New TextBox()
        Label1 = New Label()
        txtamount = New TextBox()
        Label2 = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(160, -12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(349, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' btntransfer
        ' 
        btntransfer.BackColor = Color.Goldenrod
        btntransfer.FlatAppearance.BorderSize = 0
        btntransfer.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btntransfer.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btntransfer.FlatStyle = FlatStyle.Flat
        btntransfer.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntransfer.ForeColor = Color.Black
        btntransfer.Location = New Point(416, 459)
        btntransfer.Name = "btntransfer"
        btntransfer.Size = New Size(266, 120)
        btntransfer.TabIndex = 19
        btntransfer.Text = "Transfer"
        btntransfer.UseVisualStyleBackColor = False
        ' 
        ' txttransfer
        ' 
        txttransfer.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txttransfer.Location = New Point(-3, 218)
        txttransfer.Name = "txttransfer"
        txttransfer.PlaceholderText = "Enter Account Number"
        txttransfer.Size = New Size(709, 66)
        txttransfer.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(5, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 60)
        Label1.TabIndex = 17
        Label1.Text = "Send to"
        ' 
        ' txtamount
        ' 
        txtamount.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtamount.Location = New Point(-3, 366)
        txtamount.Name = "txtamount"
        txtamount.PlaceholderText = "Enter Amount"
        txtamount.Size = New Size(709, 66)
        txtamount.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(5, 298)
        Label2.Name = "Label2"
        Label2.Size = New Size(517, 60)
        Label2.TabIndex = 21
        Label2.Text = "Enter amount to transfer"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' frmtransfer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(705, 623)
        Controls.Add(txtamount)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(btntransfer)
        Controls.Add(txttransfer)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmtransfer"
        Text = "frmtransfer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btntransfer As Button
    Friend WithEvents txttransfer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class
