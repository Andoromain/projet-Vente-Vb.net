<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.retour = New System.Windows.Forms.PictureBox()
        Me.titre = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tableauEtatStock = New System.Windows.Forms.DataGridView()
        Me.anneeCombo = New System.Windows.Forms.ComboBox()
        Me.NumClientLab = New System.Windows.Forms.Label()
        Me.PDFStock = New System.Windows.Forms.LinkLabel()
        Me.SaveFileChiffre = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.retour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tableauEtatStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.retour)
        Me.Panel1.Controls.Add(Me.titre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 100)
        Me.Panel1.TabIndex = 0
        '
        'retour
        '
        Me.retour.BackColor = System.Drawing.Color.Transparent
        Me.retour.Image = Global.ProjetVente.My.Resources.Resources.retour
        Me.retour.Location = New System.Drawing.Point(27, 27)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(40, 36)
        Me.retour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.retour.TabIndex = 17
        Me.retour.TabStop = False
        '
        'titre
        '
        Me.titre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Castellar", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.titre.Location = New System.Drawing.Point(191, 48)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(401, 25)
        Me.titre.TabIndex = 16
        Me.titre.Text = "ETAT DE STOCK DES MATERIELS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PDFStock)
        Me.Panel2.Controls.Add(Me.tableauEtatStock)
        Me.Panel2.Controls.Add(Me.anneeCombo)
        Me.Panel2.Controls.Add(Me.NumClientLab)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 481)
        Me.Panel2.TabIndex = 1
        '
        'tableauEtatStock
        '
        Me.tableauEtatStock.AllowUserToAddRows = False
        Me.tableauEtatStock.AllowUserToDeleteRows = False
        Me.tableauEtatStock.AllowUserToResizeColumns = False
        Me.tableauEtatStock.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableauEtatStock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.tableauEtatStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauEtatStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableauEtatStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.tableauEtatStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauEtatStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tableauEtatStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableauEtatStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tableauEtatStock.ColumnHeadersHeight = 30
        Me.tableauEtatStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableauEtatStock.DefaultCellStyle = DataGridViewCellStyle8
        Me.tableauEtatStock.EnableHeadersVisualStyles = False
        Me.tableauEtatStock.GridColor = System.Drawing.SystemColors.HotTrack
        Me.tableauEtatStock.Location = New System.Drawing.Point(59, 127)
        Me.tableauEtatStock.MultiSelect = False
        Me.tableauEtatStock.Name = "tableauEtatStock"
        Me.tableauEtatStock.ReadOnly = True
        Me.tableauEtatStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableauEtatStock.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.tableauEtatStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.tableauEtatStock.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.tableauEtatStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tableauEtatStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableauEtatStock.ShowEditingIcon = False
        Me.tableauEtatStock.Size = New System.Drawing.Size(671, 226)
        Me.tableauEtatStock.TabIndex = 21
        '
        'anneeCombo
        '
        Me.anneeCombo.FormattingEnabled = True
        Me.anneeCombo.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "Autre"})
        Me.anneeCombo.Location = New System.Drawing.Point(136, 52)
        Me.anneeCombo.Name = "anneeCombo"
        Me.anneeCombo.Size = New System.Drawing.Size(121, 21)
        Me.anneeCombo.TabIndex = 20
        '
        'NumClientLab
        '
        Me.NumClientLab.AutoSize = True
        Me.NumClientLab.BackColor = System.Drawing.Color.Transparent
        Me.NumClientLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumClientLab.Location = New System.Drawing.Point(58, 54)
        Me.NumClientLab.Name = "NumClientLab"
        Me.NumClientLab.Size = New System.Drawing.Size(51, 15)
        Me.NumClientLab.TabIndex = 19
        Me.NumClientLab.Text = "Annee  :"
        '
        'PDFStock
        '
        Me.PDFStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDFStock.AutoSize = True
        Me.PDFStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDFStock.Location = New System.Drawing.Point(343, 424)
        Me.PDFStock.Name = "PDFStock"
        Me.PDFStock.Size = New System.Drawing.Size(105, 16)
        Me.PDFStock.TabIndex = 22
        Me.PDFStock.TabStop = True
        Me.PDFStock.Text = "Generer du PDF"
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(789, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(789, 581)
        Me.MinimumSize = New System.Drawing.Size(789, 581)
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.retour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tableauEtatStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents retour As PictureBox
    Friend WithEvents titre As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents anneeCombo As ComboBox
    Friend WithEvents NumClientLab As Label
    Friend WithEvents tableauEtatStock As DataGridView
    Friend WithEvents PDFStock As LinkLabel
    Friend WithEvents SaveFileChiffre As SaveFileDialog
End Class
