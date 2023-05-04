<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recherche
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.vide = New System.Windows.Forms.Label()
        Me.entrerBtn = New System.Windows.Forms.Button()
        Me.tableauRecherche = New System.Windows.Forms.ListView()
        Me.NumClient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomCli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 86)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resultat de Votre Recherche"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.vide)
        Me.Panel2.Controls.Add(Me.entrerBtn)
        Me.Panel2.Controls.Add(Me.tableauRecherche)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 495)
        Me.Panel2.TabIndex = 2
        '
        'vide
        '
        Me.vide.AutoSize = True
        Me.vide.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vide.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.vide.Location = New System.Drawing.Point(209, 20)
        Me.vide.Name = "vide"
        Me.vide.Size = New System.Drawing.Size(355, 15)
        Me.vide.TabIndex = 10
        Me.vide.Text = "Desole ,il n'y a pas de client correspomdant sur votre recherche"
        Me.vide.Visible = False
        '
        'entrerBtn
        '
        Me.entrerBtn.Location = New System.Drawing.Point(656, 356)
        Me.entrerBtn.Name = "entrerBtn"
        Me.entrerBtn.Size = New System.Drawing.Size(75, 23)
        Me.entrerBtn.TabIndex = 9
        Me.entrerBtn.Text = "Entrer"
        Me.entrerBtn.UseVisualStyleBackColor = True
        '
        'tableauRecherche
        '
        Me.tableauRecherche.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauRecherche.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauRecherche.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumClient, Me.NomCli})
        Me.tableauRecherche.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableauRecherche.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tableauRecherche.FullRowSelect = True
        Me.tableauRecherche.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.tableauRecherche.Location = New System.Drawing.Point(47, 57)
        Me.tableauRecherche.MinimumSize = New System.Drawing.Size(559, 137)
        Me.tableauRecherche.MultiSelect = False
        Me.tableauRecherche.Name = "tableauRecherche"
        Me.tableauRecherche.Size = New System.Drawing.Size(705, 261)
        Me.tableauRecherche.TabIndex = 8
        Me.tableauRecherche.UseCompatibleStateImageBehavior = False
        Me.tableauRecherche.View = System.Windows.Forms.View.Details
        '
        'NumClient
        '
        Me.NumClient.Text = "Numero du Client"
        Me.NumClient.Width = 334
        '
        'NomCli
        '
        Me.NomCli.Text = "Nom du Client"
        Me.NomCli.Width = 366
        '
        'Recherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjetVente.My.Resources.Resources.fond_ecran_wallpaper_image_abstrait_bleu_09
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recherche"
        Me.Text = "Recherche"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumClient As ColumnHeader
    Friend WithEvents NomCli As ColumnHeader
    Public WithEvents tableauRecherche As ListView
    Friend WithEvents entrerBtn As Button
    Friend WithEvents vide As Label
End Class
