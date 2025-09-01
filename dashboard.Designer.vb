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
        btnstatementofaccount = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btntransfer = New Button()
        btnwithdrawal = New Button()
        btndeposit = New Button()
        BTNBALANCEINQUIRY = New Button()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(btnstatementofaccount)
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
        ' btnstatementofaccount
        ' 
        btnstatementofaccount.BackColor = Color.Goldenrod
        btnstatementofaccount.BackgroundImageLayout = ImageLayout.None
        btnstatementofaccount.Cursor = Cursors.Hand
        btnstatementofaccount.Dock = DockStyle.Top
        btnstatementofaccount.FlatAppearance.BorderSize = 0
        btnstatementofaccount.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnstatementofaccount.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnstatementofaccount.FlatStyle = FlatStyle.Flat
        btnstatementofaccount.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnstatementofaccount.ForeColor = Color.Black
        btnstatementofaccount.Location = New Point(0, 172)
        btnstatementofaccount.Name = "btnstatementofaccount"
        btnstatementofaccount.Size = New Size(277, 97)
        btnstatementofaccount.TabIndex = 1
        btnstatementofaccount.Text = "STATEMENT OF" & vbCrLf & "ACCOUNT"
        btnstatementofaccount.UseVisualStyleBackColor = False
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
        ' btntransfer
        ' 
        btntransfer.BackColor = Color.Goldenrod
        btntransfer.BackgroundImageLayout = ImageLayout.None
        btntransfer.Cursor = Cursors.Hand
        btntransfer.FlatAppearance.BorderSize = 0
        btntransfer.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btntransfer.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btntransfer.FlatStyle = FlatStyle.Flat
        btntransfer.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        btntransfer.ForeColor = Color.Black
        btntransfer.Location = New Point(23, 340)
        btntransfer.Name = "btntransfer"
        btntransfer.Size = New Size(510, 97)
        btntransfer.TabIndex = 5
        btntransfer.Text = "TRANSFER"
        btntransfer.UseVisualStyleBackColor = False
        ' 
        ' btnwithdrawal
        ' 
        btnwithdrawal.BackColor = Color.Goldenrod
        btnwithdrawal.BackgroundImageLayout = ImageLayout.None
        btnwithdrawal.Cursor = Cursors.Hand
        btnwithdrawal.FlatAppearance.BorderSize = 0
        btnwithdrawal.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnwithdrawal.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnwithdrawal.FlatStyle = FlatStyle.Flat
        btnwithdrawal.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        btnwithdrawal.ForeColor = Color.Black
        btnwithdrawal.Location = New Point(23, 237)
        btnwithdrawal.Name = "btnwithdrawal"
        btnwithdrawal.Size = New Size(510, 97)
        btnwithdrawal.TabIndex = 4
        btnwithdrawal.Text = "WITHDRAWAL"
        btnwithdrawal.UseVisualStyleBackColor = False
        ' 
        ' btndeposit
        ' 
        btndeposit.BackColor = Color.Goldenrod
        btndeposit.BackgroundImageLayout = ImageLayout.None
        btndeposit.Cursor = Cursors.Hand
        btndeposit.FlatAppearance.BorderSize = 0
        btndeposit.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btndeposit.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btndeposit.FlatStyle = FlatStyle.Flat
        btndeposit.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        btndeposit.ForeColor = Color.Black
        btndeposit.Location = New Point(23, 134)
        btndeposit.Name = "btndeposit"
        btndeposit.Size = New Size(510, 97)
        btndeposit.TabIndex = 3
        btndeposit.Text = "DEPOSIT"
        btndeposit.UseVisualStyleBackColor = False
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
        Panel3.Controls.Add(btntransfer)
        Panel3.Controls.Add(BTNBALANCEINQUIRY)
        Panel3.Controls.Add(btnwithdrawal)
        Panel3.Controls.Add(btndeposit)
        Panel3.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        Panel3.Location = New Point(313, 256)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(566, 465)
        Panel3.TabIndex = 6
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(916, 754)
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
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents btntransfer As Button
    Friend WithEvents btnwithdrawal As Button
    Friend WithEvents btndeposit As Button
    Friend WithEvents BTNBALANCEINQUIRY As Button
    Friend WithEvents btnstatementofaccount As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
End Class
