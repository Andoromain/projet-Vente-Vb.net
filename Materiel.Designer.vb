<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Materiel
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StockTxt = New System.Windows.Forms.NumericUpDown()
        Me.PuTxt = New System.Windows.Forms.NumericUpDown()
        Me.ModifierBtn = New System.Windows.Forms.Button()
        Me.AjouterBtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.designTxt = New System.Windows.Forms.TextBox()
        Me.numMatTxt = New System.Windows.Forms.TextBox()
        Me.titre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumMatLab = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SupprimerBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tableauMateriel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tableauMaterielVendu = New System.Windows.Forms.ListView()
        Me.NumClient = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomCli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.EtatStockLink = New System.Windows.Forms.LinkLabel()
        Me.Erreur = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.StockTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.Erreur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.StockTxt)
        Me.Panel1.Controls.Add(Me.PuTxt)
        Me.Panel1.Controls.Add(Me.ModifierBtn)
        Me.Panel1.Controls.Add(Me.AjouterBtn)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.designTxt)
        Me.Panel1.Controls.Add(Me.numMatTxt)
        Me.Panel1.Controls.Add(Me.titre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.NumMatLab)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 158)
        Me.Panel1.TabIndex = 0
        '
        'StockTxt
        '
        Me.StockTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StockTxt.ForeColor = System.Drawing.Color.DimGray
        Me.StockTxt.Location = New System.Drawing.Point(528, 96)
        Me.StockTxt.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.StockTxt.Name = "StockTxt"
        Me.StockTxt.Size = New System.Drawing.Size(220, 16)
        Me.StockTxt.TabIndex = 22
        Me.StockTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PuTxt
        '
        Me.PuTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PuTxt.ForeColor = System.Drawing.Color.DimGray
        Me.PuTxt.Location = New System.Drawing.Point(528, 54)
        Me.PuTxt.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.PuTxt.Name = "PuTxt"
        Me.PuTxt.Size = New System.Drawing.Size(220, 16)
        Me.PuTxt.TabIndex = 21
        Me.PuTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModifierBtn
        '
        Me.ModifierBtn.Location = New System.Drawing.Point(412, 121)
        Me.ModifierBtn.Name = "ModifierBtn"
        Me.ModifierBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModifierBtn.TabIndex = 20
        Me.ModifierBtn.Text = "Modifier"
        Me.ModifierBtn.UseVisualStyleBackColor = True
        '
        'AjouterBtn
        '
        Me.AjouterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AjouterBtn.Location = New System.Drawing.Point(288, 121)
        Me.AjouterBtn.Name = "AjouterBtn"
        Me.AjouterBtn.Size = New System.Drawing.Size(75, 23)
        Me.AjouterBtn.TabIndex = 19
        Me.AjouterBtn.Text = "Ajouter"
        Me.AjouterBtn.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(528, 70)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(220, 1)
        Me.Panel6.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(528, 114)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(220, 1)
        Me.Panel5.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(154, 114)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 1)
        Me.Panel4.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(154, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 1)
        Me.Panel3.TabIndex = 18
        '
        'designTxt
        '
        Me.designTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.designTxt.BackColor = System.Drawing.Color.White
        Me.designTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.designTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.designTxt.ForeColor = System.Drawing.Color.DimGray
        Me.designTxt.Location = New System.Drawing.Point(154, 95)
        Me.designTxt.Name = "designTxt"
        Me.designTxt.Size = New System.Drawing.Size(220, 17)
        Me.designTxt.TabIndex = 17
        Me.designTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numMatTxt
        '
        Me.numMatTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numMatTxt.BackColor = System.Drawing.Color.White
        Me.numMatTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numMatTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMatTxt.ForeColor = System.Drawing.Color.DimGray
        Me.numMatTxt.Location = New System.Drawing.Point(154, 51)
        Me.numMatTxt.Name = "numMatTxt"
        Me.numMatTxt.Size = New System.Drawing.Size(220, 17)
        Me.numMatTxt.TabIndex = 17
        Me.numMatTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'titre
        '
        Me.titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Castellar", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.titre.Location = New System.Drawing.Point(166, 9)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(441, 25)
        Me.titre.TabIndex = 16
        Me.titre.Text = "INFORMATION SUR LES MATERIELS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Design  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Prix Unitaire :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Stock :"
        '
        'NumMatLab
        '
        Me.NumMatLab.AutoSize = True
        Me.NumMatLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMatLab.Location = New System.Drawing.Point(27, 55)
        Me.NumMatLab.Name = "NumMatLab"
        Me.NumMatLab.Size = New System.Drawing.Size(121, 15)
        Me.NumMatLab.TabIndex = 13
        Me.NumMatLab.Text = "Numero du Materiel :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.SupprimerBtn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.tableauMateriel)
        Me.Panel2.Controls.Add(Me.tableauMaterielVendu)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 423)
        Me.Panel2.TabIndex = 1
        '
        'SupprimerBtn
        '
        Me.SupprimerBtn.Location = New System.Drawing.Point(624, 182)
        Me.SupprimerBtn.Name = "SupprimerBtn"
        Me.SupprimerBtn.Size = New System.Drawing.Size(75, 23)
        Me.SupprimerBtn.TabIndex = 17
        Me.SupprimerBtn.Text = "Supprimer"
        Me.SupprimerBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(295, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Liste des Materiels Vendus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(330, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Liste des Materiels"
        '
        'tableauMateriel
        '
        Me.tableauMateriel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauMateriel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauMateriel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.tableauMateriel.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableauMateriel.ForeColor = System.Drawing.Color.Maroon
        Me.tableauMateriel.FullRowSelect = True
        Me.tableauMateriel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.tableauMateriel.Location = New System.Drawing.Point(43, 23)
        Me.tableauMateriel.MinimumSize = New System.Drawing.Size(559, 137)
        Me.tableauMateriel.MultiSelect = False
        Me.tableauMateriel.Name = "tableauMateriel"
        Me.tableauMateriel.Size = New System.Drawing.Size(705, 153)
        Me.tableauMateriel.TabIndex = 14
        Me.tableauMateriel.UseCompatibleStateImageBehavior = False
        Me.tableauMateriel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numero du Materiel"
        Me.ColumnHeader1.Width = 158
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Design"
        Me.ColumnHeader2.Width = 226
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prix Unitaire"
        Me.ColumnHeader3.Width = 142
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock"
        Me.ColumnHeader4.Width = 173
        '
        'tableauMaterielVendu
        '
        Me.tableauMaterielVendu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauMaterielVendu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauMaterielVendu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumClient, Me.NomCli, Me.ColumnHeader5})
        Me.tableauMaterielVendu.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableauMaterielVendu.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tableauMaterielVendu.FullRowSelect = True
        Me.tableauMaterielVendu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.tableauMaterielVendu.Location = New System.Drawing.Point(43, 251)
        Me.tableauMaterielVendu.MinimumSize = New System.Drawing.Size(559, 137)
        Me.tableauMaterielVendu.MultiSelect = False
        Me.tableauMaterielVendu.Name = "tableauMaterielVendu"
        Me.tableauMaterielVendu.Size = New System.Drawing.Size(705, 140)
        Me.tableauMaterielVendu.TabIndex = 14
        Me.tableauMaterielVendu.UseCompatibleStateImageBehavior = False
        Me.tableauMaterielVendu.View = System.Windows.Forms.View.Details
        '
        'NumClient
        '
        Me.NumClient.Text = "Numero du Materiel"
        Me.NumClient.Width = 232
        '
        'NomCli
        '
        Me.NomCli.Text = "Design"
        Me.NomCli.Width = 293
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantité achetée"
        Me.ColumnHeader5.Width = 176
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.EtatStockLink)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 555)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(789, 26)
        Me.Panel7.TabIndex = 2
        '
        'EtatStockLink
        '
        Me.EtatStockLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EtatStockLink.AutoSize = True
        Me.EtatStockLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtatStockLink.Location = New System.Drawing.Point(365, 5)
        Me.EtatStockLink.Name = "EtatStockLink"
        Me.EtatStockLink.Size = New System.Drawing.Size(87, 16)
        Me.EtatStockLink.TabIndex = 1
        Me.EtatStockLink.TabStop = True
        Me.EtatStockLink.Text = "Etat de Stock"
        '
        'Erreur
        '
        Me.Erreur.ContainerControl = Me
        '
        'Materiel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Materiel"
        Me.Text = "Materiel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StockTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.Erreur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents titre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumMatLab As Label
    Friend WithEvents tableauMaterielVendu As ListView
    Friend WithEvents NumClient As ColumnHeader
    Friend WithEvents NomCli As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents designTxt As TextBox
    Friend WithEvents numMatTxt As TextBox
    Friend WithEvents ModifierBtn As Button
    Friend WithEvents AjouterBtn As Button
    Friend WithEvents tableauMateriel As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents EtatStockLink As LinkLabel
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents SupprimerBtn As Button
    Friend WithEvents StockTxt As NumericUpDown
    Friend WithEvents PuTxt As NumericUpDown
    Friend WithEvents Erreur As ErrorProvider
End Class
