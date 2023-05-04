Imports System.Windows.Forms.DataVisualization.Charting

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiffreAffaire
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

    Friend Shared Function Palette() As ChartColorPalette
        Throw New NotImplementedException()
    End Function

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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.titre = New System.Windows.Forms.Label()
        Me.NumClientLab = New System.Windows.Forms.Label()
        Me.anneeCombo = New System.Windows.Forms.ComboBox()
        Me.tableauChiffreAff = New System.Windows.Forms.DataGridView()
        Me.ChiffreLink = New System.Windows.Forms.LinkLabel()
        Me.SaveFileChiffre = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tableauChiffreAff, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(773, 91)
        Me.Panel1.TabIndex = 14
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
        Me.titre.Location = New System.Drawing.Point(109, 35)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(540, 25)
        Me.titre.TabIndex = 14
        Me.titre.Text = "CHIFFRE D' AFFAIRE PAR CHAQUE CLIENTS"
        '
        'NumClientLab
        '
        Me.NumClientLab.AutoSize = True
        Me.NumClientLab.BackColor = System.Drawing.Color.Transparent
        Me.NumClientLab.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumClientLab.Location = New System.Drawing.Point(46, 140)
        Me.NumClientLab.Name = "NumClientLab"
        Me.NumClientLab.Size = New System.Drawing.Size(51, 15)
        Me.NumClientLab.TabIndex = 16
        Me.NumClientLab.Text = "Annee  :"
        '
        'anneeCombo
        '
        Me.anneeCombo.FormattingEnabled = True
        Me.anneeCombo.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "Autre"})
        Me.anneeCombo.Location = New System.Drawing.Point(124, 138)
        Me.anneeCombo.Name = "anneeCombo"
        Me.anneeCombo.Size = New System.Drawing.Size(121, 21)
        Me.anneeCombo.TabIndex = 17
        '
        'tableauChiffreAff
        '
        Me.tableauChiffreAff.AllowUserToAddRows = False
        Me.tableauChiffreAff.AllowUserToDeleteRows = False
        Me.tableauChiffreAff.AllowUserToResizeColumns = False
        Me.tableauChiffreAff.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableauChiffreAff.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.tableauChiffreAff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableauChiffreAff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableauChiffreAff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.tableauChiffreAff.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.tableauChiffreAff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tableauChiffreAff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableauChiffreAff.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.tableauChiffreAff.ColumnHeadersHeight = 30
        Me.tableauChiffreAff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableauChiffreAff.DefaultCellStyle = DataGridViewCellStyle8
        Me.tableauChiffreAff.EnableHeadersVisualStyles = False
        Me.tableauChiffreAff.GridColor = System.Drawing.SystemColors.HotTrack
        Me.tableauChiffreAff.Location = New System.Drawing.Point(49, 218)
        Me.tableauChiffreAff.MultiSelect = False
        Me.tableauChiffreAff.Name = "tableauChiffreAff"
        Me.tableauChiffreAff.ReadOnly = True
        Me.tableauChiffreAff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tableauChiffreAff.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.tableauChiffreAff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.tableauChiffreAff.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.tableauChiffreAff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tableauChiffreAff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tableauChiffreAff.ShowEditingIcon = False
        Me.tableauChiffreAff.Size = New System.Drawing.Size(671, 226)
        Me.tableauChiffreAff.TabIndex = 18
        '
        'ChiffreLink
        '
        Me.ChiffreLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChiffreLink.AutoSize = True
        Me.ChiffreLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChiffreLink.Location = New System.Drawing.Point(314, 504)
        Me.ChiffreLink.Name = "ChiffreLink"
        Me.ChiffreLink.Size = New System.Drawing.Size(105, 16)
        Me.ChiffreLink.TabIndex = 19
        Me.ChiffreLink.TabStop = True
        Me.ChiffreLink.Text = "Generer du PDF"
        '
        'ChiffreAffaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 542)
        Me.Controls.Add(Me.ChiffreLink)
        Me.Controls.Add(Me.tableauChiffreAff)
        Me.Controls.Add(Me.anneeCombo)
        Me.Controls.Add(Me.NumClientLab)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChiffreAffaire"
        Me.Text = "ChiffreAffaire"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tableauChiffreAff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents titre As Label
    Friend WithEvents NumClientLab As Label
    Friend WithEvents anneeCombo As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tableauChiffreAff As DataGridView
    Friend WithEvents ChiffreLink As LinkLabel
    Friend WithEvents SaveFileChiffre As SaveFileDialog
End Class
