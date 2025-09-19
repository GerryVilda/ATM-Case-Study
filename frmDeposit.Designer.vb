<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeposit))
        Label1 = New Label()
        txtdeposit = New TextBox()
        btndeposit = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(31, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(651, 74)
        Label1.TabIndex = 9
        Label1.Text = "Enter amount to deposit"
        ' 
        ' txtdeposit
        ' 
        txtdeposit.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtdeposit.Location = New Point(-1, 339)
        txtdeposit.Name = "txtdeposit"
        txtdeposit.PlaceholderText = "Enter Amount"
        txtdeposit.Size = New Size(703, 103)
        txtdeposit.TabIndex = 10
        ' 
        ' btndeposit
        ' 
        btndeposit.BackColor = Color.Goldenrod
        btndeposit.FlatAppearance.BorderSize = 0
        btndeposit.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btndeposit.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btndeposit.FlatStyle = FlatStyle.Flat
        btndeposit.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndeposit.ForeColor = Color.Black
        btndeposit.Location = New Point(427, 546)
        btndeposit.Name = "btndeposit"
        btndeposit.Size = New Size(266, 120)
        btndeposit.TabIndex = 11
        btndeposit.Text = "Deposit"
        btndeposit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(171, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(349, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(716, 701)
        Controls.Add(PictureBox1)
        Controls.Add(btndeposit)
        Controls.Add(txtdeposit)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDeposit"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtdeposit As TextBox
    Friend WithEvents btndeposit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
