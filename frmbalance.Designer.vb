<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmbalance))
        txtbalance = New TextBox()
        btnRefresh = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbalance
        ' 
        txtbalance.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtbalance.Location = New Point(-1, 268)
        txtbalance.Name = "txtbalance"
        txtbalance.PlaceholderText = "Remaining Balance"
        txtbalance.ReadOnly = True
        txtbalance.Size = New Size(706, 103)
        txtbalance.TabIndex = 11
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Goldenrod
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.Goldenrod
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.Black
        btnRefresh.Location = New Point(427, 476)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(266, 120)
        btnRefresh.TabIndex = 12
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Goldenrod
        Label2.Location = New Point(112, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(516, 74)
        Label2.TabIndex = 14
        Label2.Text = "Remaining Balance" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(171, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(349, 172)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' frmbalance
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(707, 623)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(btnRefresh)
        Controls.Add(txtbalance)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmbalance"
        Text = "frmbalance"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
