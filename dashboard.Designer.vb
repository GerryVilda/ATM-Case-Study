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
        btnlogout = New Button()
        btnstatementofaccount = New Button()
        PictureBox1 = New PictureBox()
        btntransfer = New Button()
        btnwithdrawal = New Button()
        btndeposit = New Button()
        BTNBALANCEINQUIRY = New Button()
        PanelButtons = New Panel()
        PanelShow = New Panel()
        lblusername = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = SystemColors.ActiveCaptionText
        btnlogout.BackgroundImageLayout = ImageLayout.None
        btnlogout.Cursor = Cursors.Hand
        btnlogout.FlatAppearance.BorderSize = 0
        btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(73), CByte(73))
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnlogout.ForeColor = Color.Goldenrod
        btnlogout.Location = New Point(1036, 12)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(277, 97)
        btnlogout.TabIndex = 6
        btnlogout.Text = "LOGOUT"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' btnstatementofaccount
        ' 
        btnstatementofaccount.BackColor = Color.Goldenrod
        btnstatementofaccount.BackgroundImageLayout = ImageLayout.None
        btnstatementofaccount.Cursor = Cursors.Hand
        btnstatementofaccount.FlatAppearance.BorderSize = 0
        btnstatementofaccount.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnstatementofaccount.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnstatementofaccount.FlatStyle = FlatStyle.Flat
        btnstatementofaccount.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnstatementofaccount.ForeColor = Color.Black
        btnstatementofaccount.Location = New Point(25, 498)
        btnstatementofaccount.Name = "btnstatementofaccount"
        btnstatementofaccount.Size = New Size(510, 89)
        btnstatementofaccount.TabIndex = 1
        btnstatementofaccount.Text = "STATEMENT OF ACCOUNT"
        btnstatementofaccount.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(428, 282)
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
        btntransfer.Location = New Point(25, 380)
        btntransfer.Name = "btntransfer"
        btntransfer.Size = New Size(510, 89)
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
        btnwithdrawal.Location = New Point(25, 263)
        btnwithdrawal.Name = "btnwithdrawal"
        btnwithdrawal.Size = New Size(510, 89)
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
        btndeposit.Location = New Point(25, 143)
        btndeposit.Name = "btndeposit"
        btndeposit.Size = New Size(510, 89)
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
        BTNBALANCEINQUIRY.Location = New Point(25, 25)
        BTNBALANCEINQUIRY.Name = "BTNBALANCEINQUIRY"
        BTNBALANCEINQUIRY.Size = New Size(510, 90)
        BTNBALANCEINQUIRY.TabIndex = 2
        BTNBALANCEINQUIRY.Text = "BALANCE INQUIRY"
        BTNBALANCEINQUIRY.UseVisualStyleBackColor = False
        ' 
        ' PanelButtons
        ' 
        PanelButtons.BackColor = Color.FromArgb(CByte(26), CByte(22), CByte(22))
        PanelButtons.BackgroundImageLayout = ImageLayout.None
        PanelButtons.BorderStyle = BorderStyle.Fixed3D
        PanelButtons.Controls.Add(btnstatementofaccount)
        PanelButtons.Controls.Add(btntransfer)
        PanelButtons.Controls.Add(BTNBALANCEINQUIRY)
        PanelButtons.Controls.Add(btnwithdrawal)
        PanelButtons.Controls.Add(btndeposit)
        PanelButtons.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        PanelButtons.Location = New Point(19, 300)
        PanelButtons.Name = "PanelButtons"
        PanelButtons.Size = New Size(563, 623)
        PanelButtons.TabIndex = 6
        ' 
        ' PanelShow
        ' 
        PanelShow.BackColor = Color.FromArgb(CByte(26), CByte(22), CByte(22))
        PanelShow.BackgroundImageLayout = ImageLayout.None
        PanelShow.BorderStyle = BorderStyle.Fixed3D
        PanelShow.ForeColor = Color.FromArgb(CByte(212), CByte(175), CByte(55))
        PanelShow.Location = New Point(588, 300)
        PanelShow.Name = "PanelShow"
        PanelShow.Size = New Size(716, 623)
        PanelShow.TabIndex = 7
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblusername.ForeColor = Color.Goldenrod
        lblusername.Location = New Point(466, 16)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(190, 74)
        lblusername.TabIndex = 8
        lblusername.Text = "Label1"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1316, 935)
        Controls.Add(lblusername)
        Controls.Add(PanelShow)
        Controls.Add(btnlogout)
        Controls.Add(PictureBox1)
        Controls.Add(PanelButtons)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelButtons.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnlogout As Button
    Friend WithEvents btntransfer As Button
    Friend WithEvents btnwithdrawal As Button
    Friend WithEvents btndeposit As Button
    Friend WithEvents BTNBALANCEINQUIRY As Button
    Friend WithEvents btnstatementofaccount As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents PanelShow As Panel
    Friend WithEvents lblusername As Label
End Class
