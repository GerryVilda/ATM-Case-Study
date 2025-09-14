<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdrawal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdrawal))
        Panel1 = New Panel()
        btnwithdraw = New Button()
        txtwithdrawamount = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(26), CByte(22), CByte(22))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnwithdraw)
        Panel1.Controls.Add(txtwithdrawamount)
        Panel1.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        Panel1.Location = New Point(34, 247)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 273)
        Panel1.TabIndex = 3
        ' 
        ' btnwithdraw
        ' 
        btnwithdraw.BackColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        btnwithdraw.FlatStyle = FlatStyle.Flat
        btnwithdraw.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnwithdraw.ForeColor = SystemColors.ActiveCaptionText
        btnwithdraw.Location = New Point(35, 158)
        btnwithdraw.Name = "btnwithdraw"
        btnwithdraw.Size = New Size(427, 71)
        btnwithdraw.TabIndex = 2
        btnwithdraw.Text = "Withdraw"
        btnwithdraw.UseVisualStyleBackColor = False
        ' 
        ' txtwithdrawamount
        ' 
        txtwithdrawamount.AccessibleName = "Username"
        txtwithdrawamount.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtwithdrawamount.Location = New Point(35, 52)
        txtwithdrawamount.Name = "txtwithdrawamount"
        txtwithdrawamount.PlaceholderText = "Enter Amount"
        txtwithdrawamount.Size = New Size(427, 55)
        txtwithdrawamount.TabIndex = 0
        txtwithdrawamount.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(587, 194)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Withdrawal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(584, 648)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Withdrawal"
        Text = "Withdrawal"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnwithdraw As Button
    Friend WithEvents txtwithdrawamount As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
