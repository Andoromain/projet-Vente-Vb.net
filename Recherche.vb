Imports clientPerso
Imports form1
Imports Recherche
Imports System.Data.Odbc
Public Class Recherche
    Private Sub entrerBtn_Click(sender As Object, e As EventArgs) Handles entrerBtn.Click
        If tableauRecherche.SelectedItems.Count > 0 Then
            Dim client As ListViewItem = tableauRecherche.SelectedItems(0)
            ClientPerso.nom.Text = client.SubItems(1).Text
            ClientPerso.numClient.Text = client.SubItems(0).Text
            Try
                Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                connection.Open()
                Try
                    Dim commande As OdbcCommand = New OdbcCommand("select image from client where numClient='" & client.SubItems(0).Text & "';", connection)
                    Dim reader As OdbcDataReader = commande.ExecuteReader()
                    If reader.Read() Then
                        ClientPerso.sary.Image = Image.FromFile(reader(0).ToString)
                    Else
                        ClientPerso.sary.Image = Image.FromFile("C:\Users\Romain\documents\visual studio 2015\Projects\ProjetVente\ProjetVente\Resources\avatar.png")
                    End If
                Catch

                End Try
            Catch
                MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
            End Try
            Form1.CollerPage(ClientPerso)
            ClientPerso.anneecombo.Text = ""
            ClientPerso.tableaulistMat.Items.Clear()

        Else
            MsgBox("Aucun n'a ete selectionne! ", vbExclamation)
        End If
    End Sub
End Class