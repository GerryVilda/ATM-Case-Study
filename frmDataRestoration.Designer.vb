<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataRestoration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataRestoration))
        txtattemptsbackup = New TextBox()
        Label10 = New Label()
        btnbalancebackup = New TextBox()
        Label9 = New Label()
        cbostatusbackup = New ComboBox()
        cborolebackup = New ComboBox()
        txtpinbackup = New TextBox()
        txtnamebackup = New TextBox()
        txtaccountnumberbackup = New TextBox()
        txtuseridbackup = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btndeletebackup = New Button()
        btnrestore = New Button()
        Label2 = New Label()
        txtsearchbackup = New TextBox()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        ListViewbackup = New ListView()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtattemptsbackup
        ' 
        txtattemptsbackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtattemptsbackup.Location = New Point(258, 886)
        txtattemptsbackup.Margin = New Padding(2)
        txtattemptsbackup.Name = "txtattemptsbackup"
        txtattemptsbackup.Size = New Size(405, 45)
        txtattemptsbackup.TabIndex = 46
        txtattemptsbackup.Text = vbCrLf
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label10.ForeColor = Color.Goldenrod
        Label10.Location = New Point(19, 890)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 38)
        Label10.TabIndex = 45
        Label10.Text = "Attempts"
        ' 
        ' btnbalancebackup
        ' 
        btnbalancebackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnbalancebackup.Location = New Point(258, 812)
        btnbalancebackup.Margin = New Padding(2)
        btnbalancebackup.Name = "btnbalancebackup"
        btnbalancebackup.ReadOnly = True
        btnbalancebackup.Size = New Size(405, 45)
        btnbalancebackup.TabIndex = 44
        btnbalancebackup.Text = vbCrLf
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label9.ForeColor = Color.Goldenrod
        Label9.Location = New Point(19, 815)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 38)
        Label9.TabIndex = 43
        Label9.Text = "Balance" & vbCrLf
        ' 
        ' cbostatusbackup
        ' 
        cbostatusbackup.Font = New Font("Segoe UI", 14F)
        cbostatusbackup.FormattingEnabled = True
        cbostatusbackup.Items.AddRange(New Object() {"Active", "Deactivated"})
        cbostatusbackup.Location = New Point(1260, 735)
        cbostatusbackup.Margin = New Padding(2)
        cbostatusbackup.Name = "cbostatusbackup"
        cbostatusbackup.Size = New Size(405, 46)
        cbostatusbackup.TabIndex = 42
        ' 
        ' cborolebackup
        ' 
        cborolebackup.Font = New Font("Segoe UI", 14F)
        cborolebackup.FormattingEnabled = True
        cborolebackup.Items.AddRange(New Object() {"Admin", "User"})
        cborolebackup.Location = New Point(1260, 654)
        cborolebackup.Margin = New Padding(2)
        cborolebackup.Name = "cborolebackup"
        cborolebackup.Size = New Size(405, 46)
        cborolebackup.TabIndex = 41
        ' 
        ' txtpinbackup
        ' 
        txtpinbackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtpinbackup.Location = New Point(1260, 572)
        txtpinbackup.Margin = New Padding(2)
        txtpinbackup.Name = "txtpinbackup"
        txtpinbackup.Size = New Size(405, 45)
        txtpinbackup.TabIndex = 40
        ' 
        ' txtnamebackup
        ' 
        txtnamebackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtnamebackup.Location = New Point(258, 732)
        txtnamebackup.Margin = New Padding(2)
        txtnamebackup.Name = "txtnamebackup"
        txtnamebackup.Size = New Size(405, 45)
        txtnamebackup.TabIndex = 39
        ' 
        ' txtaccountnumberbackup
        ' 
        txtaccountnumberbackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtaccountnumberbackup.Location = New Point(258, 654)
        txtaccountnumberbackup.Margin = New Padding(2)
        txtaccountnumberbackup.Name = "txtaccountnumberbackup"
        txtaccountnumberbackup.Size = New Size(405, 45)
        txtaccountnumberbackup.TabIndex = 38
        ' 
        ' txtuseridbackup
        ' 
        txtuseridbackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtuseridbackup.Location = New Point(258, 572)
        txtuseridbackup.Margin = New Padding(2)
        txtuseridbackup.Name = "txtuseridbackup"
        txtuseridbackup.ReadOnly = True
        txtuseridbackup.Size = New Size(405, 45)
        txtuseridbackup.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label6.ForeColor = Color.Goldenrod
        Label6.Location = New Point(1049, 735)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 38)
        Label6.TabIndex = 36
        Label6.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label7.ForeColor = Color.Goldenrod
        Label7.Location = New Point(1049, 654)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 38)
        Label7.TabIndex = 35
        Label7.Text = "Role"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label8.ForeColor = Color.Goldenrod
        Label8.Location = New Point(1049, 579)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 38)
        Label8.TabIndex = 34
        Label8.Text = "Pin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label5.ForeColor = Color.Goldenrod
        Label5.Location = New Point(19, 743)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 38)
        Label5.TabIndex = 33
        Label5.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label4.ForeColor = Color.Goldenrod
        Label4.Location = New Point(19, 662)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(233, 38)
        Label4.TabIndex = 32
        Label4.Text = "Account Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.Goldenrod
        Label3.Location = New Point(19, 579)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 38)
        Label3.TabIndex = 31
        Label3.Text = "User ID"
        ' 
        ' btndeletebackup
        ' 
        btndeletebackup.AutoSize = True
        btndeletebackup.BackColor = Color.Goldenrod
        btndeletebackup.FlatAppearance.BorderSize = 0
        btndeletebackup.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btndeletebackup.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btndeletebackup.FlatStyle = FlatStyle.Flat
        btndeletebackup.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btndeletebackup.ForeColor = SystemColors.ActiveCaptionText
        btndeletebackup.Location = New Point(1419, 848)
        btndeletebackup.Margin = New Padding(2)
        btndeletebackup.Name = "btndeletebackup"
        btndeletebackup.Size = New Size(246, 106)
        btndeletebackup.TabIndex = 30
        btndeletebackup.Text = "Delete"
        btndeletebackup.UseVisualStyleBackColor = False
        ' 
        ' btnrestore
        ' 
        btnrestore.AutoSize = True
        btnrestore.BackColor = Color.Goldenrod
        btnrestore.FlatAppearance.BorderSize = 0
        btnrestore.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnrestore.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnrestore.FlatStyle = FlatStyle.Flat
        btnrestore.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnrestore.ForeColor = SystemColors.ActiveCaptionText
        btnrestore.Location = New Point(1148, 848)
        btnrestore.Margin = New Padding(2)
        btnrestore.Name = "btnrestore"
        btnrestore.Size = New Size(246, 106)
        btnrestore.TabIndex = 28
        btnrestore.Text = "Restore"
        btnrestore.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(12, 129)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 38)
        Label2.TabIndex = 27
        Label2.Text = "Search By:"
        ' 
        ' txtsearchbackup
        ' 
        txtsearchbackup.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtsearchbackup.Location = New Point(165, 129)
        txtsearchbackup.Margin = New Padding(2)
        txtsearchbackup.Name = "txtsearchbackup"
        txtsearchbackup.PlaceholderText = "Account Number or Name"
        txtsearchbackup.Size = New Size(413, 45)
        txtsearchbackup.TabIndex = 26
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Attempts"
        ColumnHeader8.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Balance"
        ColumnHeader4.Width = 150
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Status"
        ColumnHeader7.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Role"
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Pin"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Name"
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Account Number"
        ColumnHeader2.Width = 220
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "User ID"
        ColumnHeader1.Width = 150
        ' 
        ' ListViewbackup
        ' 
        ListViewbackup.BackColor = SystemColors.InactiveCaptionText
        ListViewbackup.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader4, ColumnHeader8})
        ListViewbackup.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListViewbackup.ForeColor = SystemColors.Window
        ListViewbackup.FullRowSelect = True
        ListViewbackup.GridLines = True
        ListViewbackup.Location = New Point(12, 195)
        ListViewbackup.Margin = New Padding(2)
        ListViewbackup.Name = "ListViewbackup"
        ListViewbackup.Size = New Size(1652, 372)
        ListViewbackup.TabIndex = 25
        ListViewbackup.UseCompatibleStateImageBehavior = False
        ListViewbackup.View = View.Details
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(286, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Goldenrod
        Label1.Location = New Point(728, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 60)
        Label1.TabIndex = 0
        Label1.Text = "Data Restoration"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuText
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.ImeMode = ImeMode.Hiragana
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1899, 90)
        Panel1.TabIndex = 24
        ' 
        ' frmDataRestoration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1899, 968)
        Controls.Add(txtattemptsbackup)
        Controls.Add(Label10)
        Controls.Add(btnbalancebackup)
        Controls.Add(Label9)
        Controls.Add(cbostatusbackup)
        Controls.Add(cborolebackup)
        Controls.Add(txtpinbackup)
        Controls.Add(txtnamebackup)
        Controls.Add(txtaccountnumberbackup)
        Controls.Add(txtuseridbackup)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btndeletebackup)
        Controls.Add(btnrestore)
        Controls.Add(Label2)
        Controls.Add(txtsearchbackup)
        Controls.Add(ListViewbackup)
        Controls.Add(Panel1)
        Name = "frmDataRestoration"
        Text = "frmDataRestoration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtattemptsbackup As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnbalancebackup As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbostatusbackup As ComboBox
    Friend WithEvents cborolebackup As ComboBox
    Friend WithEvents txtpinbackup As TextBox
    Friend WithEvents txtnamebackup As TextBox
    Friend WithEvents txtaccountnumberbackup As TextBox
    Friend WithEvents txtuseridbackup As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btndeletebackup As Button
    Friend WithEvents btnrestore As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsearchbackup As TextBox
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ListViewbackup As ListView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
