<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.nomTxt = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.titre = New System.Windows.Forms.Label()
        Me.ModifierBtn = New System.Windows.Forms.Button()
        Me.AjouterBtn = New System.Windows.Forms.Button()
        Me.numClientTxt = New System.Windows.Forms.TextBox()
        Me.nomLab = New System.Windows.Forms.Label()
        Me.NumClientLab = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupprimerBtn = New System.Windows.Forms.Button()
        Me.tableauClient = New System.Windows.Forms.ListView()
        Me.NumClient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomCli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ChiffreLink = New System.Windows.Forms.LinkLabel()
        Me.Erreur = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Erreur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.nomTxt)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.titre)
        Me.Panel1.Controls.Add(Me.ModifierBtn)
        Me.Panel1.Controls.Add(Me.AjouterBtn)
        Me.Panel1.Controls.Add(Me.numClientTxt)
        Me.Panel1.Controls.Add(Me.nomLab)
        Me.Panel1.Controls.Add(Me.NumClientLab)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 169)
        Me.Panel1.TabIndex = 7
        '
        'nomTxt
        '
        Me.nomTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nomTxt.BackColor = System.Drawing.Color.White
        Me.nomTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nomTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomTxt.ForeColor = System.Drawing.Color.DimGray
        Me.nomTxt.Location = New System.Drawing.Point(252, 119)
        Me.nomTxt.Name = "nomTxt"
        Me.nomTxt.Size = New System.Drawing.Size(220, 17)
        Me.nomTxt.TabIndex = 15
        Me.nomTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(252, 138)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(220, 1)
        Me.Panel5.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(252, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 1)
        Me.Panel2.TabIndex = 13
        '
        'titre
        '
        Me.titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Castellar", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.titre.Location = New System.Drawing.Point(176, 18)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(407, 25)
        Me.titre.TabIndex = 12
        Me.titre.Text = "INFORMATION SUR LES CLIENTS"
        '
        'ModifierBtn
        '
        Me.ModifierBtn.Location = New System.Drawing.Point(532, 119)
        Me.ModifierBtn.Name = "ModifierBtn"
        Me.ModifierBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModifierBtn.TabIndex = 11
        Me.ModifierBtn.Text = "Modifier"
        Me.ModifierBtn.UseVisualStyleBackColor = True
        '
        'AjouterBtn
        '
        Me.AjouterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AjouterBtn.Location = New System.Drawing.Point(532, 73)
        Me.AjouterBtn.Name = "AjouterBtn"
        Me.AjouterBtn.Size = New System.Drawing.Size(75, 23)
        Me.AjouterBtn.TabIndex = 10
        Me.AjouterBtn.Text = "Ajouter"
        Me.AjouterBtn.UseVisualStyleBackColor = True
        '
        'numClientTxt
        '
        Me.numClientTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numClientTxt.BackColor = System.Drawing.Color.White
        Me.numClientTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numClientTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numClientTxt.ForeColor = System.Drawing.Color.DimGray
        Me.numClientTxt.Location = New System.Drawing.Point(252, 70)
        Me.numClientTxt.Name = "numClientTxt"
        Me.numClientTxt.Size = New System.Drawing.Size(220, 17)
        Me.numClientTxt.TabIndex = 8
        Me.numClientTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nomLab
        '
        Me.nomLab.AutoSize = True
        Me.nomLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        Me.nomLab.Location = New System.Drawing.Point(134, 124)
        Me.nomLab.Name = "nomLab"
        Me.nomLab.Size = New System.Drawing.Size(95, 15)
        Me.nomLab.TabIndex = 7
        Me.nomLab.Text = "Nom du Client  :"
        '
        'NumClientLab
        '
        Me.NumClientLab.AutoSize = True
        Me.NumClientLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumClientLab.Location = New System.Drawing.Point(134, 73)
        Me.NumClientLab.Name = "NumClientLab"
        Me.NumClientLab.Size = New System.Drawing.Size(112, 15)
        Me.NumClientLab.TabIndex = 6
        Me.NumClientLab.Text = "Numero du Client  :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.SupprimerBtn)
        Me.Panel3.Controls.Add(Me.tableauClient)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 169)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(789, 412)
        Me.Panel3.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(329, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Liste des Clients"
        '
        'SupprimerBtn
        '
        Me.SupprimerBtn.Location = New System.Drawing.Point(614, 308)
        Me.SupprimerBtn.Name = "SupprimerBtn"
        Me.SupprimerBtn.Size = New System.Drawing.Size(75, 23)
        Me.SupprimerBtn.TabIndex = 8
        Me.SupprimerBtn.Text = "Supprimer"
        Me.SupprimerBtn.UseVisualStyleBackColor = True
        '
        'tableauClient
        '
        Me.tableauClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauClient.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauClient.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumClient, Me.NomCli})
        Me.tableauClient.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableauClient.ForeColor = System.Drawing.Color.Maroon
        Me.tableauClient.FullRowSelect = True
        Me.tableauClient.Location = New System.Drawing.Point(36, 64)
        Me.tableauClient.MinimumSize = New System.Drawing.Size(559, 137)
        Me.tableauClient.MultiSelect = False
        Me.tableauClient.Name = "tableauClient"
        Me.tableauClient.Size = New System.Drawing.Size(705, 222)
        Me.tableauClient.TabIndex = 7
        Me.tableauClient.UseCompatibleStateImageBehavior = False
        Me.tableauClient.View = System.Windows.Forms.View.Details
        '
        'NumClient
        '
        Me.NumClient.Text = "Numero du Client"
        Me.NumClient.Width = 350
        '
        'NomCli
        '
        Me.NomCli.Text = "Nom du Client"
        Me.NomCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NomCli.Width = 355
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.ChiffreLink)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 519)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(789, 62)
        Me.Panel4.TabIndex = 11
        '
        'ChiffreLink
        '
        Me.ChiffreLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChiffreLink.AutoSize = True
        Me.ChiffreLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChiffreLink.Location = New System.Drawing.Point(288, 22)
        Me.ChiffreLink.Name = "ChiffreLink"
        Me.ChiffreLink.Size = New System.Drawing.Size(206, 16)
        Me.ChiffreLink.TabIndex = 0
        Me.ChiffreLink.TabStop = True
        Me.ChiffreLink.Text = "Chiffre d'Affaire par Chaque Client"
        '
        'Erreur
        '
        Me.Erreur.ContainerControl = Me
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Client"
        Me.Text = "Client"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Erreur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ModifierBtn As Button
    Friend WithEvents AjouterBtn As Button
    Friend WithEvents numClientTxt As TextBox
    Friend WithEvents nomLab As Label
    Friend WithEvents NumClientLab As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SupprimerBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents titre As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nomTxt As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ChiffreLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents tableauClient As ListView
    Friend WithEvents NumClient As ColumnHeader
    Friend WithEvents NomCli As ColumnHeader
    Friend WithEvents Erreur As ErrorProvider
End Class
