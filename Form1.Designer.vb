<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.partie2 = New System.Windows.Forms.Panel()
        Me.pageAcceuil = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RechercheTxt = New System.Windows.Forms.TextBox()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.AideBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AproposBtn = New System.Windows.Forms.Button()
        Me.AchatBtn = New System.Windows.Forms.Button()
        Me.MaterielBtn = New System.Windows.Forms.Button()
        Me.ClientBtn = New System.Windows.Forms.Button()
        Me.AcceuilBtn = New System.Windows.Forms.Button()
        Me.partie2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'partie2
        '
        Me.partie2.Controls.Add(Me.pageAcceuil)
        Me.partie2.Controls.Add(Me.Panel2)
        Me.partie2.Location = New System.Drawing.Point(50, 0)
        Me.partie2.Margin = New System.Windows.Forms.Padding(0)
        Me.partie2.Name = "partie2"
        Me.partie2.Size = New System.Drawing.Size(789, 683)
        Me.partie2.TabIndex = 3
        '
        'pageAcceuil
        '
        Me.pageAcceuil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pageAcceuil.Location = New System.Drawing.Point(0, 102)
        Me.pageAcceuil.Name = "pageAcceuil"
        Me.pageAcceuil.Size = New System.Drawing.Size(789, 581)
        Me.pageAcceuil.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 102)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vente de Materiel Informatique"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RechercheTxt)
        Me.Panel5.Controls.Add(Me.Rechercher)
        Me.Panel5.Location = New System.Drawing.Point(541, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(234, 84)
        Me.Panel5.TabIndex = 3
        '
        'RechercheTxt
        '
        Me.RechercheTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RechercheTxt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.RechercheTxt.Location = New System.Drawing.Point(20, 32)
        Me.RechercheTxt.Margin = New System.Windows.Forms.Padding(0)
        Me.RechercheTxt.Name = "RechercheTxt"
        Me.RechercheTxt.Size = New System.Drawing.Size(133, 20)
        Me.RechercheTxt.TabIndex = 3
        '
        'Rechercher
        '
        Me.Rechercher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rechercher.BackColor = System.Drawing.Color.White
        Me.Rechercher.BackgroundImage = CType(resources.GetObject("Rechercher.BackgroundImage"), System.Drawing.Image)
        Me.Rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Rechercher.Location = New System.Drawing.Point(156, 21)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(75, 40)
        Me.Rechercher.TabIndex = 4
        Me.Rechercher.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.MenuVertical)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(50, 681)
        Me.Panel3.TabIndex = 4
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.AideBtn)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.AproposBtn)
        Me.MenuVertical.Controls.Add(Me.AchatBtn)
        Me.MenuVertical.Controls.Add(Me.MaterielBtn)
        Me.MenuVertical.Controls.Add(Me.ClientBtn)
        Me.MenuVertical.Controls.Add(Me.AcceuilBtn)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(50, 681)
        Me.MenuVertical.TabIndex = 2
        '
        'AideBtn
        '
        Me.AideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AideBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.AideBtn.FlatAppearance.BorderSize = 0
        Me.AideBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.AideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.AideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AideBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AideBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AideBtn.Image = CType(resources.GetObject("AideBtn.Image"), System.Drawing.Image)
        Me.AideBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AideBtn.Location = New System.Drawing.Point(0, 450)
        Me.AideBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AideBtn.Name = "AideBtn"
        Me.AideBtn.Size = New System.Drawing.Size(255, 70)
        Me.AideBtn.TabIndex = 5
        Me.AideBtn.Text = "Aide"
        Me.AideBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(256, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'AproposBtn
        '
        Me.AproposBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AproposBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.AproposBtn.FlatAppearance.BorderSize = 0
        Me.AproposBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.AproposBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.AproposBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AproposBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AproposBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AproposBtn.Image = CType(resources.GetObject("AproposBtn.Image"), System.Drawing.Image)
        Me.AproposBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AproposBtn.Location = New System.Drawing.Point(0, 380)
        Me.AproposBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AproposBtn.Name = "AproposBtn"
        Me.AproposBtn.Size = New System.Drawing.Size(255, 70)
        Me.AproposBtn.TabIndex = 4
        Me.AproposBtn.Text = "A Propos"
        Me.AproposBtn.UseVisualStyleBackColor = True
        '
        'AchatBtn
        '
        Me.AchatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AchatBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.AchatBtn.FlatAppearance.BorderSize = 0
        Me.AchatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.AchatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.AchatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AchatBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AchatBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AchatBtn.Image = CType(resources.GetObject("AchatBtn.Image"), System.Drawing.Image)
        Me.AchatBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AchatBtn.Location = New System.Drawing.Point(0, 310)
        Me.AchatBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AchatBtn.Name = "AchatBtn"
        Me.AchatBtn.Size = New System.Drawing.Size(255, 70)
        Me.AchatBtn.TabIndex = 4
        Me.AchatBtn.Text = "Achat"
        Me.AchatBtn.UseVisualStyleBackColor = True
        '
        'MaterielBtn
        '
        Me.MaterielBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MaterielBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.MaterielBtn.FlatAppearance.BorderSize = 0
        Me.MaterielBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.MaterielBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.MaterielBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterielBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterielBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.MaterielBtn.Image = CType(resources.GetObject("MaterielBtn.Image"), System.Drawing.Image)
        Me.MaterielBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterielBtn.Location = New System.Drawing.Point(-1, 240)
        Me.MaterielBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterielBtn.Name = "MaterielBtn"
        Me.MaterielBtn.Size = New System.Drawing.Size(255, 70)
        Me.MaterielBtn.TabIndex = 3
        Me.MaterielBtn.Text = "Materiel"
        Me.MaterielBtn.UseVisualStyleBackColor = True
        '
        'ClientBtn
        '
        Me.ClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientBtn.FlatAppearance.BorderSize = 0
        Me.ClientBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.ClientBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClientBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.ClientBtn.Image = CType(resources.GetObject("ClientBtn.Image"), System.Drawing.Image)
        Me.ClientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClientBtn.Location = New System.Drawing.Point(0, 170)
        Me.ClientBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ClientBtn.Name = "ClientBtn"
        Me.ClientBtn.Size = New System.Drawing.Size(255, 70)
        Me.ClientBtn.TabIndex = 2
        Me.ClientBtn.Text = "Client"
        Me.ClientBtn.UseVisualStyleBackColor = True
        '
        'AcceuilBtn
        '
        Me.AcceuilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AcceuilBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.AcceuilBtn.FlatAppearance.BorderSize = 0
        Me.AcceuilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.AcceuilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.AcceuilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AcceuilBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceuilBtn.ForeColor = System.Drawing.SystemColors.Control
        Me.AcceuilBtn.Image = CType(resources.GetObject("AcceuilBtn.Image"), System.Drawing.Image)
        Me.AcceuilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AcceuilBtn.Location = New System.Drawing.Point(-1, 100)
        Me.AcceuilBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AcceuilBtn.Name = "AcceuilBtn"
        Me.AcceuilBtn.Size = New System.Drawing.Size(255, 70)
        Me.AcceuilBtn.TabIndex = 1
        Me.AcceuilBtn.Text = "Acceuil"
        Me.AcceuilBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(834, 681)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.partie2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(850, 720)
        Me.MinimumSize = New System.Drawing.Size(850, 720)
        Me.Name = "Form1"
        Me.Text = "Vente de Materiel Informatique"
        Me.partie2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents partie2 As Panel
    Friend WithEvents pageAcceuil As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RechercheTxt As TextBox
    Friend WithEvents Rechercher As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents AideBtn As Button
    Friend WithEvents AproposBtn As Button
    Friend WithEvents AchatBtn As Button
    Friend WithEvents MaterielBtn As Button
    Friend WithEvents ClientBtn As Button
    Friend WithEvents AcceuilBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
