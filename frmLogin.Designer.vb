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
        btnlogin = New Button()
        txtloginpassword = New TextBox()
        txtloginusername = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = SystemColors.ActiveCaptionText
        btnlogin.Location = New Point(742, 667)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(474, 71)
        btnlogin.TabIndex = 2
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtloginpassword
        ' 
        txtloginpassword.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtloginpassword.Location = New Point(742, 483)
        txtloginpassword.Name = "txtloginpassword"
        txtloginpassword.PlaceholderText = "Password"
        txtloginpassword.Size = New Size(474, 55)
        txtloginpassword.TabIndex = 1
        txtloginpassword.TabStop = False
        txtloginpassword.UseSystemPasswordChar = True
        ' 
        ' txtloginusername
        ' 
        txtloginusername.AccessibleName = "Username"
        txtloginusername.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtloginusername.Location = New Point(742, 377)
        txtloginusername.Name = "txtloginusername"
        txtloginusername.PlaceholderText = "Username"
        txtloginusername.Size = New Size(474, 55)
        txtloginusername.TabIndex = 0
        txtloginusername.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(715, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(541, 192)
        Label1.TabIndex = 3
        Label1.Text = "Sign in to your " & vbCrLf & "      account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(45, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(616, 573)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        ClientSize = New Size(1297, 805)
        Controls.Add(Label1)
        Controls.Add(btnlogin)
        Controls.Add(txtloginpassword)
        Controls.Add(PictureBox1)
        Controls.Add(txtloginusername)
        ForeColor = SystemColors.ButtonHighlight
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtloginpassword As TextBox
    Friend WithEvents txtloginusername As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
