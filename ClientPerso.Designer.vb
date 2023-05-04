<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientPerso
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
        Me.ChoisirImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cam = New System.Windows.Forms.PictureBox()
        Me.numClient = New System.Windows.Forms.Label()
        Me.sary = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nom = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tableaulistMat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.facturelink = New System.Windows.Forms.LinkLabel()
        Me.anneecombo = New System.Windows.Forms.ComboBox()
        Me.NumClientLab = New System.Windows.Forms.Label()
        Me.titre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.cam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChoisirImage
        '
        Me.ChoisirImage.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.cam)
        Me.Panel1.Controls.Add(Me.numClient)
        Me.Panel1.Controls.Add(Me.sary)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 121)
        Me.Panel1.TabIndex = 20
        '
        'cam
        '
        Me.cam.BackColor = System.Drawing.SystemColors.Highlight
        Me.cam.Image = Global.ProjetVente.My.Resources.Resources.splashscreen_contrast_white_scale_180
        Me.cam.Location = New System.Drawing.Point(444, 65)
        Me.cam.Name = "cam"
        Me.cam.Size = New System.Drawing.Size(32, 27)
        Me.cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cam.TabIndex = 24
        Me.cam.TabStop = False
        '
        'numClient
        '
        Me.numClient.AutoSize = True
        Me.numClient.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numClient.Location = New System.Drawing.Point(293, 95)
        Me.numClient.Name = "numClient"
        Me.numClient.Size = New System.Drawing.Size(69, 24)
        Me.numClient.TabIndex = 23
        Me.numClient.Text = "Label1"
        '
        'sary
        '
        Me.sary.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.sary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sary.Image = Global.ProjetVente.My.Resources.Resources.avatar
        Me.sary.Location = New System.Drawing.Point(322, 3)
        Me.sary.Name = "sary"
        Me.sary.Size = New System.Drawing.Size(116, 89)
        Me.sary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sary.TabIndex = 22
        Me.sary.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.ProjetVente.My.Resources.Resources.retour
        Me.PictureBox1.Location = New System.Drawing.Point(25, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'nom
        '
        Me.nom.AutoSize = True
        Me.nom.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.Location = New System.Drawing.Point(407, 95)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(69, 24)
        Me.nom.TabIndex = 20
        Me.nom.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.tableaulistMat)
        Me.Panel2.Controls.Add(Me.facturelink)
        Me.Panel2.Controls.Add(Me.anneecombo)
        Me.Panel2.Controls.Add(Me.NumClientLab)
        Me.Panel2.Controls.Add(Me.titre)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 460)
        Me.Panel2.TabIndex = 21
        '
        'tableaulistMat
        '
        Me.tableaulistMat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableaulistMat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableaulistMat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
        Me.tableaulistMat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableaulistMat.ForeColor = System.Drawing.Color.Maroon
        Me.tableaulistMat.FullRowSelect = True
        Me.tableaulistMat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.tableaulistMat.Location = New System.Drawing.Point(34, 149)
        Me.tableaulistMat.MinimumSize = New System.Drawing.Size(559, 137)
        Me.tableaulistMat.MultiSelect = False
        Me.tableaulistMat.Name = "tableaulistMat"
        Me.tableaulistMat.Size = New System.Drawing.Size(705, 229)
        Me.tableaulistMat.TabIndex = 21
        Me.tableaulistMat.UseCompatibleStateImageBehavior = False
        Me.tableaulistMat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numero du Materiel"
        Me.ColumnHeader1.Width = 365
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Design"
        Me.ColumnHeader3.Width = 433
        '
        'facturelink
        '
        Me.facturelink.AutoSize = True
        Me.facturelink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facturelink.Location = New System.Drawing.Point(369, 418)
        Me.facturelink.Name = "facturelink"
        Me.facturelink.Size = New System.Drawing.Size(107, 16)
        Me.facturelink.TabIndex = 20
        Me.facturelink.TabStop = True
        Me.facturelink.Text = "Facture du Client"
        '
        'anneecombo
        '
        Me.anneecombo.FormattingEnabled = True
        Me.anneecombo.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "Autre"})
        Me.anneecombo.Location = New System.Drawing.Point(103, 86)
        Me.anneecombo.Name = "anneecombo"
        Me.anneecombo.Size = New System.Drawing.Size(121, 21)
        Me.anneecombo.TabIndex = 19
        '
        'NumClientLab
        '
        Me.NumClientLab.AutoSize = True
        Me.NumClientLab.BackColor = System.Drawing.Color.Transparent
        Me.NumClientLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumClientLab.Location = New System.Drawing.Point(31, 92)
        Me.NumClientLab.Name = "NumClientLab"
        Me.NumClientLab.Size = New System.Drawing.Size(51, 15)
        Me.NumClientLab.TabIndex = 18
        Me.NumClientLab.Text = "Annee  :"
        '
        'titre
        '
        Me.titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Castellar", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.titre.Location = New System.Drawing.Point(126, 29)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(546, 25)
        Me.titre.TabIndex = 16
        Me.titre.Text = "LISTE DE MATERIEL ACHETE PAR LE CLIENT"
        '
        'ClientPerso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientPerso"
        Me.Text = "ClientPerso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChoisirImage As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cam As PictureBox
    Friend WithEvents numClient As Label
    Friend WithEvents sary As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents nom As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titre As Label
    Friend WithEvents anneecombo As ComboBox
    Friend WithEvents NumClientLab As Label
    Friend WithEvents facturelink As LinkLabel
    Friend WithEvents tableaulistMat As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
