Imports System.Runtime.InteropServices
Imports System.Data.Odbc
Imports System.Data
Imports Recherche
Imports clientPerso
Public Class Form1
    Public Sub CollerPage(forme As Object)
        If Me.pageAcceuil.Controls.Count > 0 Then
            Me.pageAcceuil.Controls.RemoveAt(0)
        End If
        Dim page As Form = forme
        page.TopLevel = False
        page.Dock = DockStyle.Fill
        Me.pageAcceuil.Controls.Add(page)
        Me.pageAcceuil.Tag = page
        page.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CollerPage(New Acceuil())
        Panel3.Width = "53"
        MenuVertical.Width = "58"
        AcceuilBtn.BackColor = Color.DimGray
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If MenuVertical.Width = "250" Then
            MenuVertical.Width = "58"
            Panel3.Width = "53"
            PictureBox1.BackColor = Color.Transparent

        Else
            MenuVertical.Width = "250"
            Panel3.Width = "250"
            PictureBox1.BackColor = Color.FromArgb(26, 26, 26)

        End If
    End Sub

    Private Sub AcceuilBtn_Click_1(sender As Object, e As EventArgs) Handles AcceuilBtn.Click
        CollerPage(New Acceuil())
        AcceuilBtn.BackColor = Color.DimGray
        ClientBtn.BackColor = Color.Transparent
        MaterielBtn.BackColor = Color.Transparent
        AchatBtn.BackColor = Color.Transparent
        AideBtn.BackColor = Color.Transparent
        AproposBtn.BackColor = Color.Transparent
    End Sub

    Private Sub ClientBtn_Click_1(sender As Object, e As EventArgs) Handles ClientBtn.Click
        CollerPage(New Client())
        AcceuilBtn.BackColor = Color.Transparent
        ClientBtn.BackColor = Color.DimGray
        MaterielBtn.BackColor = Color.Transparent
        AchatBtn.BackColor = Color.Transparent
        AideBtn.BackColor = Color.Transparent
        AproposBtn.BackColor = Color.Transparent
    End Sub

    Private Sub MaterielBtn_Click_1(sender As Object, e As EventArgs) Handles MaterielBtn.Click
        CollerPage(New Materiel())
        AcceuilBtn.BackColor = Color.Transparent
        ClientBtn.BackColor = Color.Transparent
        MaterielBtn.BackColor = Color.DimGray
        AchatBtn.BackColor = Color.Transparent
        AideBtn.BackColor = Color.Transparent
        AproposBtn.BackColor = Color.Transparent
    End Sub

    Private Sub AchatBtn_Click_1(sender As Object, e As EventArgs) Handles AchatBtn.Click
        CollerPage(New Achat())
        AcceuilBtn.BackColor = Color.Transparent
        ClientBtn.BackColor = Color.Transparent
        MaterielBtn.BackColor = Color.Transparent
        AchatBtn.BackColor = Color.DimGray
        AideBtn.BackColor = Color.Transparent
        AproposBtn.BackColor = Color.Transparent
    End Sub

    Private Sub AproposBtn_Click_1(sender As Object, e As EventArgs) Handles AproposBtn.Click
        CollerPage(New Apropos())
        AcceuilBtn.BackColor = Color.Transparent
        ClientBtn.BackColor = Color.Transparent
        MaterielBtn.BackColor = Color.Transparent
        AchatBtn.BackColor = Color.Transparent
        AideBtn.BackColor = Color.Transparent
        AproposBtn.BackColor = Color.DimGray
    End Sub

    Private Sub AideBtn_Click_1(sender As Object, e As EventArgs) Handles AideBtn.Click
        CollerPage(New Aide())
        AcceuilBtn.BackColor = Color.Transparent
        ClientBtn.BackColor = Color.Transparent
        MaterielBtn.BackColor = Color.Transparent
        AchatBtn.BackColor = Color.Transparent
        AideBtn.BackColor = Color.DimGray
        AproposBtn.BackColor = Color.Transparent

    End Sub

    Private Sub pageAcceuil_MouseClick(sender As Object, e As MouseEventArgs) Handles pageAcceuil.MouseClick
        MenuVertical.Width = "58"
        Panel3.Width = "53"
        PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        MenuVertical.Width = "58"
        Panel3.Width = "53"
        PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Rechercher_Click(sender As Object, e As EventArgs) Handles Rechercher.Click
        Recherche.tableauRecherche.Items.Clear()
        ClientPerso.sary.Image = Image.FromFile("C:\Users\Romain\documents\visual studio 2015\Projects\ProjetVente\ProjetVente\Resources\avatar.png")

        Dim motRecherche As String = RechercheTxt.Text.ToString

        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                If motRecherche = vbNullString Then
                    Recherche.vide.Visible = True
                Else
                    Recherche.vide.Visible = False
                    Dim commande As OdbcCommand = New OdbcCommand("select numClient,nom from client where numClient like '%" & motRecherche & "%'Or nom like '%" & motRecherche & "%' order by numClient asc;", connection)
                    Dim reader As OdbcDataReader = commande.ExecuteReader()
                    Dim liste As ListViewItem
                    Recherche.tableauRecherche.Items.Clear()

                    'misy amboarina ni eo ambani

                    If reader.Read() = vbNull Then
                        Recherche.vide.Visible = True
                    Else
                        reader.Close()
                        reader = commande.ExecuteReader()
                        While reader.Read()
                            liste = New ListViewItem({reader(0).ToString, reader(1).ToString})
                            Recherche.tableauRecherche.Items.Add(liste)
                        End While
                    End If

                    'jsq'a eto
                    connection.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
        CollerPage(Recherche)
        RechercheTxt.Clear()
    End Sub

    Private Sub MenuVertical_MouseLeave(sender As Object, e As EventArgs) Handles MenuVertical.MouseLeave
        MenuVertical.Width = "58"
        Panel3.Width = "53"
    End Sub

    ' Private Sub RechercheTxt_TextChanged(sender As Object, e As EventArgs) Handles RechercheTxt.TextChanged
    '    Recherche.tableauRecherche.Items.Clear()
    '    ClientPerso.sary.Image = Image.FromFile("C:\Users\Romain\documents\visual studio 2015\Projects\ProjetVente\ProjetVente\Resources\avatar.png")

    'Dim motRecherche As String = RechercheTxt.Text.ToString

    'Try
    'Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
    ' connection.Open()
    'Try
    'If motRecherche = vbNullString Then

    'Else
    'Dim commande As OdbcCommand = New OdbcCommand("select numClient,nom from client where numClient like '%" & motRecherche & "%'Or nom like '%" '& motRecherche & "%';", connection)
    'Dim reader As OdbcDataReader = commande.ExecuteReader()
    'Dim liste As ListViewItem
    '                Recherche.tableauRecherche.Items.Clear()
    'While reader.Read()
    '                   liste = New ListViewItem({reader(0).ToString, reader(1).ToString})
    '                  Recherche.tableauRecherche.Items.Add(liste)
    'End While
    '               connection.Close()
    '           End If
    '      Catch ex As Exception
    '         MsgBox(ex.Message)
    '    End Try
    'Catch ex As Exception
    '   MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
    'End Try
    'End Sub
End Class
