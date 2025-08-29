<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Panel1 = New Panel()
        Button6 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        BTNBALANCEINQUIRY = New Button()
        Panel3 = New Panel()
        lblwelcomeuser = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(277, 754)
        Panel1.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ActiveCaptionText
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.Cursor = Cursors.Hand
        Button6.Dock = DockStyle.Bottom
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(73), CByte(73))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Button6.ForeColor = Color.Goldenrod
        Button6.Location = New Point(0, 657)
        Button6.Name = "Button6"
        Button6.Size = New Size(277, 97)
        Button6.TabIndex = 6
        Button6.Text = "LOGOUT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Goldenrod
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        Button1.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(0, 172)
        Button1.Name = "Button1"
        Button1.Size = New Size(277, 97)
        Button1.TabIndex = 1
        Button1.Text = "STATEMENT OF" & vbCrLf & "ACCOUNT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(277, 172)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(277, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Goldenrod
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.Cursor = Cursors.Hand
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        Button5.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(23, 343)
        Button5.Name = "Button5"
        Button5.Size = New Size(510, 97)
        Button5.TabIndex = 5
        Button5.Text = "TRANSFER"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Goldenrod
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        Button4.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(23, 240)
        Button4.Name = "Button4"
        Button4.Size = New Size(510, 97)
        Button4.TabIndex = 4
        Button4.Text = "WITHDRAWAL"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Goldenrod
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        Button3.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(23, 134)
        Button3.Name = "Button3"
        Button3.Size = New Size(510, 97)
        Button3.TabIndex = 3
        Button3.Text = "DEPOSIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' BTNBALANCEINQUIRY
        ' 
        BTNBALANCEINQUIRY.BackColor = Color.Goldenrod
        BTNBALANCEINQUIRY.BackgroundImageLayout = ImageLayout.None
        BTNBALANCEINQUIRY.Cursor = Cursors.Hand
        BTNBALANCEINQUIRY.FlatAppearance.BorderSize = 0
        BTNBALANCEINQUIRY.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        BTNBALANCEINQUIRY.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        BTNBALANCEINQUIRY.FlatStyle = FlatStyle.Flat
        BTNBALANCEINQUIRY.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        BTNBALANCEINQUIRY.ForeColor = Color.Black
        BTNBALANCEINQUIRY.Location = New Point(23, 31)
        BTNBALANCEINQUIRY.Name = "BTNBALANCEINQUIRY"
        BTNBALANCEINQUIRY.Size = New Size(510, 97)
        BTNBALANCEINQUIRY.TabIndex = 2
        BTNBALANCEINQUIRY.Text = "BALANCE INQUIRY"
        BTNBALANCEINQUIRY.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(26), CByte(22), CByte(22))
        Panel3.BackgroundImageLayout = ImageLayout.None
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Button5)
        Panel3.Controls.Add(BTNBALANCEINQUIRY)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        Panel3.Location = New Point(313, 256)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(566, 465)
        Panel3.TabIndex = 6
        ' 
        ' lblwelcomeuser
        ' 
        lblwelcomeuser.AutoSize = True
        lblwelcomeuser.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblwelcomeuser.ForeColor = SystemColors.ButtonHighlight
        lblwelcomeuser.Location = New Point(291, 19)
        lblwelcomeuser.Name = "lblwelcomeuser"
        lblwelcomeuser.Size = New Size(102, 38)
        lblwelcomeuser.TabIndex = 7
        lblwelcomeuser.Text = "Label1"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(916, 754)
        Controls.Add(lblwelcomeuser)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BTNBALANCEINQUIRY As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblwelcomeuser As Label
End Class
