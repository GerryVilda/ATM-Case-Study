<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deposit))
        txtdeposit = New TextBox()
        Panel1 = New Panel()
        btndeposit = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtdeposit
        ' 
        txtdeposit.AccessibleName = "Username"
        txtdeposit.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtdeposit.Location = New Point(35, 52)
        txtdeposit.Name = "txtdeposit"
        txtdeposit.PlaceholderText = "Enter Amount"
        txtdeposit.Size = New Size(427, 55)
        txtdeposit.TabIndex = 0
        txtdeposit.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(26), CByte(22), CByte(22))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btndeposit)
        Panel1.Controls.Add(txtdeposit)
        Panel1.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        Panel1.Location = New Point(84, 312)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 273)
        Panel1.TabIndex = 5
        ' 
        ' btndeposit
        ' 
        btndeposit.BackColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        btndeposit.FlatStyle = FlatStyle.Flat
        btndeposit.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndeposit.ForeColor = SystemColors.ActiveCaptionText
        btndeposit.Location = New Point(35, 158)
        btndeposit.Name = "btndeposit"
        btndeposit.Size = New Size(427, 71)
        btndeposit.TabIndex = 2
        btndeposit.Text = "Deposit"
        btndeposit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 61)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(587, 194)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Deposit
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(690, 641)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "Deposit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deposit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtdeposit As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndeposit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
