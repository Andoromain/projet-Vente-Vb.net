<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Achat
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dateTxt = New System.Windows.Forms.DateTimePicker()
        Me.QteTxt = New System.Windows.Forms.NumericUpDown()
        Me.ModifierBtn = New System.Windows.Forms.Button()
        Me.AjouterBtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.numMatTxt = New System.Windows.Forms.TextBox()
        Me.numCliTxt = New System.Windows.Forms.TextBox()
        Me.titre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumMatLab = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SupprimerBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tableauAchat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Erreur = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.QteTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Erreur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.dateTxt)
        Me.Panel3.Controls.Add(Me.QteTxt)
        Me.Panel3.Controls.Add(Me.ModifierBtn)
        Me.Panel3.Controls.Add(Me.AjouterBtn)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.numMatTxt)
        Me.Panel3.Controls.Add(Me.numCliTxt)
        Me.Panel3.Controls.Add(Me.titre)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.NumMatLab)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(789, 193)
        Me.Panel3.TabIndex = 2
        '
        'dateTxt
        '
        Me.dateTxt.Location = New System.Drawing.Point(528, 93)
        Me.dateTxt.MaxDate = New Date(2019, 10, 30, 0, 0, 0, 0)
        Me.dateTxt.MinDate = New Date(1909, 1, 1, 0, 0, 0, 0)
        Me.dateTxt.Name = "dateTxt"
        Me.dateTxt.Size = New System.Drawing.Size(220, 20)
        Me.dateTxt.TabIndex = 23
        Me.dateTxt.Value = New Date(2019, 10, 29, 0, 0, 0, 0)
        '
        'QteTxt
        '
        Me.QteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QteTxt.ForeColor = System.Drawing.Color.DimGray
        Me.QteTxt.Location = New System.Drawing.Point(528, 54)
        Me.QteTxt.Maximum = New Decimal(New Integer() {268435455, 1042612833, 542101086, 0})
        Me.QteTxt.Name = "QteTxt"
        Me.QteTxt.Size = New System.Drawing.Size(220, 16)
        Me.QteTxt.TabIndex = 21
        Me.QteTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModifierBtn
        '
        Me.ModifierBtn.Location = New System.Drawing.Point(412, 141)
        Me.ModifierBtn.Name = "ModifierBtn"
        Me.ModifierBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModifierBtn.TabIndex = 20
        Me.ModifierBtn.Text = "Modifier"
        Me.ModifierBtn.UseVisualStyleBackColor = True
        '
        'AjouterBtn
        '
        Me.AjouterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AjouterBtn.Location = New System.Drawing.Point(280, 141)
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
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(154, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(220, 1)
        Me.Panel7.TabIndex = 18
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
        Me.numMatTxt.Location = New System.Drawing.Point(154, 95)
        Me.numMatTxt.Name = "numMatTxt"
        Me.numMatTxt.Size = New System.Drawing.Size(220, 17)
        Me.numMatTxt.TabIndex = 17
        Me.numMatTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numCliTxt
        '
        Me.numCliTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numCliTxt.BackColor = System.Drawing.Color.White
        Me.numCliTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numCliTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCliTxt.ForeColor = System.Drawing.Color.DimGray
        Me.numCliTxt.Location = New System.Drawing.Point(154, 51)
        Me.numCliTxt.Name = "numCliTxt"
        Me.numCliTxt.Size = New System.Drawing.Size(220, 17)
        Me.numCliTxt.TabIndex = 17
        Me.numCliTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'titre
        '
        Me.titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Castellar", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.titre.Location = New System.Drawing.Point(190, 9)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(407, 25)
        Me.titre.TabIndex = 16
        Me.titre.Text = "INFORMATION SUR LES ACHATS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Numero de Materiel  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Quantite  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Date d'Achat  :"
        '
        'NumMatLab
        '
        Me.NumMatLab.AutoSize = True
        Me.NumMatLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumMatLab.Location = New System.Drawing.Point(27, 52)
        Me.NumMatLab.Name = "NumMatLab"
        Me.NumMatLab.Size = New System.Drawing.Size(108, 15)
        Me.NumMatLab.TabIndex = 13
        Me.NumMatLab.Text = "Numero du Client :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.SupprimerBtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tableauAchat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 388)
        Me.Panel1.TabIndex = 3
        '
        'SupprimerBtn
        '
        Me.SupprimerBtn.Location = New System.Drawing.Point(660, 323)
        Me.SupprimerBtn.Name = "SupprimerBtn"
        Me.SupprimerBtn.Size = New System.Drawing.Size(75, 23)
        Me.SupprimerBtn.TabIndex = 18
        Me.SupprimerBtn.Text = "Supprimer"
        Me.SupprimerBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(215, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Liste des Achats efectuées par les Clients"
        '
        'tableauAchat
        '
        Me.tableauAchat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauAchat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauAchat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.id})
        Me.tableauAchat.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableauAchat.ForeColor = System.Drawing.Color.Maroon
        Me.tableauAchat.FullRowSelect = True
        Me.tableauAchat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.tableauAchat.Location = New System.Drawing.Point(43, 72)
        Me.tableauAchat.MinimumSize = New System.Drawing.Size(559, 137)
        Me.tableauAchat.MultiSelect = False
        Me.tableauAchat.Name = "tableauAchat"
        Me.tableauAchat.Size = New System.Drawing.Size(705, 229)
        Me.tableauAchat.TabIndex = 16
        Me.tableauAchat.UseCompatibleStateImageBehavior = False
        Me.tableauAchat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numero du Client"
        Me.ColumnHeader1.Width = 158
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Numero du Materiel"
        Me.ColumnHeader2.Width = 226
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantite"
        Me.ColumnHeader3.Width = 142
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date d'Achat"
        Me.ColumnHeader4.Width = 178
        '
        'id
        '
        Me.id.Text = "id"
        '
        'Erreur
        '
        Me.Erreur.ContainerControl = Me
        '
        'Achat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Achat"
        Me.Text = "Achat"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.QteTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Erreur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents QteTxt As NumericUpDown
    Friend WithEvents ModifierBtn As Button
    Friend WithEvents AjouterBtn As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents numMatTxt As TextBox
    Friend WithEvents numCliTxt As TextBox
    Friend WithEvents titre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumMatLab As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tableauAchat As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents SupprimerBtn As Button
    Friend WithEvents dateTxt As DateTimePicker
    Friend WithEvents id As ColumnHeader
    Friend WithEvents Erreur As ErrorProvider
End Class
