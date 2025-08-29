<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnlogin = New Button()
        txtloginpassword = New TextBox()
        txtloginusername = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(647, 275)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(26), CByte(22), CByte(22))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnlogin)
        Panel1.Controls.Add(txtloginpassword)
        Panel1.Controls.Add(txtloginusername)
        Panel1.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        Panel1.Location = New Point(63, 408)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(506, 368)
        Panel1.TabIndex = 1
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = SystemColors.ActiveCaptionText
        btnlogin.Location = New Point(35, 232)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(427, 71)
        btnlogin.TabIndex = 2
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtloginpassword
        ' 
        txtloginpassword.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtloginpassword.Location = New Point(35, 138)
        txtloginpassword.Name = "txtloginpassword"
        txtloginpassword.PlaceholderText = "Password"
        txtloginpassword.Size = New Size(427, 55)
        txtloginpassword.TabIndex = 1
        txtloginpassword.TabStop = False
        txtloginpassword.UseSystemPasswordChar = True
        ' 
        ' txtloginusername
        ' 
        txtloginusername.AccessibleName = "Username"
        txtloginusername.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtloginusername.Location = New Point(35, 52)
        txtloginusername.Name = "txtloginusername"
        txtloginusername.PlaceholderText = "Username"
        txtloginusername.Size = New Size(427, 55)
        txtloginusername.TabIndex = 0
        txtloginusername.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        ClientSize = New Size(640, 898)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.ButtonHighlight
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtloginpassword As TextBox
    Friend WithEvents txtloginusername As TextBox
    Friend WithEvents btnlogin As Button

End Class
