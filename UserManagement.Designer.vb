<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagement))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        txtsearch = New TextBox()
        Label2 = New Label()
        btnsave = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtuserid = New TextBox()
        txtaccountnumber = New TextBox()
        txtname = New TextBox()
        txtpin = New TextBox()
        cborole = New ComboBox()
        cbostatus = New ComboBox()
        btnbalance = New TextBox()
        Label9 = New Label()
        txtattempts = New TextBox()
        Label10 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuText
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.ImeMode = ImeMode.Hiragana
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1895, 90)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
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
        Label1.Name = "Label1"
        Label1.Size = New Size(406, 60)
        Label1.TabIndex = 0
        Label1.Text = "User Management"
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = SystemColors.InactiveCaptionText
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader4, ColumnHeader8})
        ListView1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListView1.ForeColor = SystemColors.Window
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(13, 181)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1652, 371)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "User ID"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Account Number"
        ColumnHeader2.Width = 220
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Name"
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Pin"
        ColumnHeader5.Width = 150
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Role"
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Status"
        ColumnHeader7.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Balance"
        ColumnHeader4.Width = 150
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Attempts"
        ColumnHeader8.Width = 100
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtsearch.Location = New Point(165, 115)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(413, 45)
        txtsearch.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(12, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 38)
        Label2.TabIndex = 4
        Label2.Text = "Search By:"
        ' 
        ' btnsave
        ' 
        btnsave.AutoSize = True
        btnsave.BackColor = Color.Goldenrod
        btnsave.FlatAppearance.BorderSize = 0
        btnsave.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnsave.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnsave.FlatStyle = FlatStyle.Flat
        btnsave.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnsave.ForeColor = SystemColors.ActiveCaptionText
        btnsave.Location = New Point(915, 834)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(246, 106)
        btnsave.TabIndex = 5
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.AutoSize = True
        btnupdate.BackColor = Color.Goldenrod
        btnupdate.FlatAppearance.BorderSize = 0
        btnupdate.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnupdate.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnupdate.FlatStyle = FlatStyle.Flat
        btnupdate.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnupdate.ForeColor = SystemColors.ActiveCaptionText
        btnupdate.Location = New Point(1167, 834)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(246, 106)
        btnupdate.TabIndex = 6
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.AutoSize = True
        btndelete.BackColor = Color.Goldenrod
        btndelete.FlatAppearance.BorderSize = 0
        btndelete.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btndelete.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btndelete.FlatStyle = FlatStyle.Flat
        btndelete.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btndelete.ForeColor = SystemColors.ActiveCaptionText
        btndelete.Location = New Point(1419, 834)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(246, 106)
        btndelete.TabIndex = 7
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label3.ForeColor = Color.Goldenrod
        Label3.Location = New Point(19, 565)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 38)
        Label3.TabIndex = 8
        Label3.Text = "User ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label4.ForeColor = Color.Goldenrod
        Label4.Location = New Point(19, 648)
        Label4.Name = "Label4"
        Label4.Size = New Size(233, 38)
        Label4.TabIndex = 9
        Label4.Text = "Account Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label5.ForeColor = Color.Goldenrod
        Label5.Location = New Point(19, 729)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 38)
        Label5.TabIndex = 10
        Label5.Text = "Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label6.ForeColor = Color.Goldenrod
        Label6.Location = New Point(1049, 721)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 38)
        Label6.TabIndex = 13
        Label6.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label7.ForeColor = Color.Goldenrod
        Label7.Location = New Point(1049, 640)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 38)
        Label7.TabIndex = 12
        Label7.Text = "Role"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label8.ForeColor = Color.Goldenrod
        Label8.Location = New Point(1049, 565)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 38)
        Label8.TabIndex = 11
        Label8.Text = "Pin"
        ' 
        ' txtuserid
        ' 
        txtuserid.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtuserid.Location = New Point(258, 558)
        txtuserid.Name = "txtuserid"
        txtuserid.ReadOnly = True
        txtuserid.Size = New Size(405, 45)
        txtuserid.TabIndex = 14
        ' 
        ' txtaccountnumber
        ' 
        txtaccountnumber.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtaccountnumber.Location = New Point(258, 640)
        txtaccountnumber.Name = "txtaccountnumber"
        txtaccountnumber.Size = New Size(405, 45)
        txtaccountnumber.TabIndex = 15
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtname.Location = New Point(258, 717)
        txtname.Name = "txtname"
        txtname.Size = New Size(405, 45)
        txtname.TabIndex = 16
        ' 
        ' txtpin
        ' 
        txtpin.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtpin.Location = New Point(1260, 558)
        txtpin.Name = "txtpin"
        txtpin.Size = New Size(405, 45)
        txtpin.TabIndex = 17
        ' 
        ' cborole
        ' 
        cborole.Font = New Font("Segoe UI", 14F)
        cborole.FormattingEnabled = True
        cborole.Items.AddRange(New Object() {"Admin", "User"})
        cborole.Location = New Point(1260, 640)
        cborole.Name = "cborole"
        cborole.Size = New Size(405, 46)
        cborole.TabIndex = 18
        ' 
        ' cbostatus
        ' 
        cbostatus.Font = New Font("Segoe UI", 14F)
        cbostatus.FormattingEnabled = True
        cbostatus.Items.AddRange(New Object() {"Active", "Deactivated"})
        cbostatus.Location = New Point(1260, 721)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(405, 46)
        cbostatus.TabIndex = 19
        ' 
        ' btnbalance
        ' 
        btnbalance.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnbalance.Location = New Point(258, 798)
        btnbalance.Name = "btnbalance"
        btnbalance.ReadOnly = True
        btnbalance.Size = New Size(405, 45)
        btnbalance.TabIndex = 21
        btnbalance.Text = vbCrLf
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label9.ForeColor = Color.Goldenrod
        Label9.Location = New Point(19, 801)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 38)
        Label9.TabIndex = 20
        Label9.Text = "Balance" & vbCrLf
        ' 
        ' txtattempts
        ' 
        txtattempts.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        txtattempts.Location = New Point(258, 873)
        txtattempts.Name = "txtattempts"
        txtattempts.Size = New Size(405, 45)
        txtattempts.TabIndex = 23
        txtattempts.Text = vbCrLf
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label10.ForeColor = Color.Goldenrod
        Label10.Location = New Point(19, 876)
        Label10.Name = "Label10"
        Label10.Size = New Size(135, 38)
        Label10.TabIndex = 22
        Label10.Text = "Attempts"
        ' 
        ' UserManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1895, 964)
        Controls.Add(txtattempts)
        Controls.Add(Label10)
        Controls.Add(btnbalance)
        Controls.Add(Label9)
        Controls.Add(cbostatus)
        Controls.Add(cborole)
        Controls.Add(txtpin)
        Controls.Add(txtname)
        Controls.Add(txtaccountnumber)
        Controls.Add(txtuserid)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnsave)
        Controls.Add(Label2)
        Controls.Add(txtsearch)
        Controls.Add(ListView1)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ButtonHighlight
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "UserManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UserManagement"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents txtaccountnumber As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpin As TextBox
    Friend WithEvents cborole As ComboBox
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnbalance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtattempts As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
