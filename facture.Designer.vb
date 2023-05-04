<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class facture
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.titre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.numFact = New System.Windows.Forms.TextBox()
        Me.annee = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.numCli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumClientLab = New System.Windows.Forms.Label()
        Me.PDFFacture = New System.Windows.Forms.LinkLabel()
        Me.tableauFacture = New System.Windows.Forms.DataGridView()
        Me.SaveFileChiffre = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tableauFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.titre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 91)
        Me.Panel1.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetVente.My.Resources.Resources.retour
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'titre
        '
        Me.titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Castellar", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.titre.Location = New System.Drawing.Point(316, 38)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(125, 25)
        Me.titre.TabIndex = 14
        Me.titre.Text = "FACTURE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.total)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.numFact)
        Me.Panel2.Controls.Add(Me.annee)
        Me.Panel2.Controls.Add(Me.nom)
        Me.Panel2.Controls.Add(Me.numCli)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.NumClientLab)
        Me.Panel2.Controls.Add(Me.PDFFacture)
        Me.Panel2.Controls.Add(Me.tableauFacture)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 412)
        Me.Panel2.TabIndex = 22
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(606, 334)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(0, 13)
        Me.total.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(495, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "TOTAL    :"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(383, 45)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(115, 1)
        Me.Panel6.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(609, 93)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(82, 1)
        Me.Panel5.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(99, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(82, 1)
        Me.Panel4.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(159, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(82, 1)
        Me.Panel3.TabIndex = 25
        '
        'numFact
        '
        Me.numFact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numFact.BackColor = System.Drawing.Color.White
        Me.numFact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numFact.Enabled = False
        Me.numFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFact.ForeColor = System.Drawing.Color.DimGray
        Me.numFact.Location = New System.Drawing.Point(383, 26)
        Me.numFact.Name = "numFact"
        Me.numFact.Size = New System.Drawing.Size(115, 17)
        Me.numFact.TabIndex = 24
        '
        'annee
        '
        Me.annee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.annee.BackColor = System.Drawing.Color.White
        Me.annee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.annee.Enabled = False
        Me.annee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annee.ForeColor = System.Drawing.Color.DimGray
        Me.annee.Location = New System.Drawing.Point(609, 74)
        Me.annee.Name = "annee"
        Me.annee.Size = New System.Drawing.Size(82, 17)
        Me.annee.TabIndex = 24
        '
        'nom
        '
        Me.nom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nom.BackColor = System.Drawing.Color.White
        Me.nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nom.Enabled = False
        Me.nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom.ForeColor = System.Drawing.Color.DimGray
        Me.nom.Location = New System.Drawing.Point(99, 109)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(82, 17)
        Me.nom.TabIndex = 24
        '
        'numCli
        '
        Me.numCli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numCli.BackColor = System.Drawing.Color.White
        Me.numCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numCli.Enabled = False
        Me.numCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCli.ForeColor = System.Drawing.Color.DimGray
        Me.numCli.Location = New System.Drawing.Point(159, 77)
        Me.numCli.Name = "numCli"
        Me.numCli.Size = New System.Drawing.Size(82, 17)
        Me.numCli.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nom  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Annee :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Numero du Facture  :"
        '
        'NumClientLab
        '
        Me.NumClientLab.AutoSize = True
        Me.NumClientLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumClientLab.Location = New System.Drawing.Point(41, 77)
        Me.NumClientLab.Name = "NumClientLab"
        Me.NumClientLab.Size = New System.Drawing.Size(112, 15)
        Me.NumClientLab.TabIndex = 23
        Me.NumClientLab.Text = "Numero du Client  :"
        '
        'PDFFacture
        '
        Me.PDFFacture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDFFacture.AutoSize = True
        Me.PDFFacture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDFFacture.Location = New System.Drawing.Point(336, 387)
        Me.PDFFacture.Name = "PDFFacture"
        Me.PDFFacture.Size = New System.Drawing.Size(105, 16)
        Me.PDFFacture.TabIndex = 22
        Me.PDFFacture.TabStop = True
        Me.PDFFacture.Text = "Generer du PDF"
        '
        'tableauFacture
        '
        Me.tableauFacture.AllowUserToAddRows = False
        Me.tableauFacture.AllowUserToDeleteRows = False
        Me.tableauFacture.AllowUserToResizeColumns = False
        Me.tableauFacture.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableauFacture.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tableauFacture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauFacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableauFacture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.tableauFacture.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauFacture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tableauFacture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableauFacture.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tableauFacture.ColumnHeadersHeight = 30
        Me.tableauFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableauFacture.DefaultCellStyle = DataGridViewCellStyle3
        Me.tableauFacture.EnableHeadersVisualStyles = False
        Me.tableauFacture.GridColor = System.Drawing.SystemColors.HotTrack
        Me.tableauFacture.Location = New System.Drawing.Point(44, 148)
        Me.tableauFacture.MaximumSize = New System.Drawing.Size(671, 164)
        Me.tableauFacture.MinimumSize = New System.Drawing.Size(671, 164)
        Me.tableauFacture.MultiSelect = False
        Me.tableauFacture.Name = "tableauFacture"
        Me.tableauFacture.ReadOnly = True
        Me.tableauFacture.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableauFacture.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tableauFacture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.tableauFacture.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.tableauFacture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tableauFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableauFacture.ShowEditingIcon = False
        Me.tableauFacture.Size = New System.Drawing.Size(671, 164)
        Me.tableauFacture.TabIndex = 21
        '
        'facture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(757, 503)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "facture"
        Me.Text = "facture"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tableauFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents titre As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PDFFacture As LinkLabel
    Friend WithEvents tableauFacture As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumClientLab As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents numFact As TextBox
    Friend WithEvents annee As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents numCli As TextBox
    Friend WithEvents total As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveFileChiffre As SaveFileDialog
End Class
