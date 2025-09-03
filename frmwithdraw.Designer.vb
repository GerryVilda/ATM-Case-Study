<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwithdraw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwithdraw))
        btnwithdraw = New Button()
        txtwithdraw = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnwithdraw
        ' 
        btnwithdraw.BackColor = Color.Goldenrod
        btnwithdraw.FlatAppearance.BorderSize = 0
        btnwithdraw.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnwithdraw.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnwithdraw.FlatStyle = FlatStyle.Flat
        btnwithdraw.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnwithdraw.ForeColor = Color.Black
        btnwithdraw.Location = New Point(427, 476)
        btnwithdraw.Name = "btnwithdraw"
        btnwithdraw.Size = New Size(266, 120)
        btnwithdraw.TabIndex = 15
        btnwithdraw.Text = "Withdraw"
        btnwithdraw.UseVisualStyleBackColor = False
        ' 
        ' txtwithdraw
        ' 
        txtwithdraw.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtwithdraw.Location = New Point(-1, 260)
        txtwithdraw.Name = "txtwithdraw"
        txtwithdraw.PlaceholderText = "Enter Amount"
        txtwithdraw.Size = New Size(709, 103)
        txtwithdraw.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(2, 180)
        Label1.Name = "Label1"
        Label1.Size = New Size(697, 74)
        Label1.TabIndex = 13
        Label1.Text = "Enter amount to withdraw"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(171, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(349, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' frmwithdraw
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(705, 623)
        Controls.Add(PictureBox1)
        Controls.Add(btnwithdraw)
        Controls.Add(txtwithdraw)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmwithdraw"
        Text = "frmwithdraw"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnwithdraw As Button
    Friend WithEvents txtwithdraw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
