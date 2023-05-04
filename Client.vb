Imports System.Data.Odbc
Imports System.Data
Imports form1
Imports System.Text.RegularExpressions


Public Class Client
    Private Sub Client_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Form1.MenuVertical.Width = "58"
        Form1.Panel3.Width = "53"
        Form1.PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub listeClient()
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select *from client order by numClient asc;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader()
                Dim liste As ListViewItem
                While reader.Read()
                    liste = New ListViewItem({reader(0).ToString, reader(1).ToString})
                    tableauClient.Items.Add(liste)
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try

    End Sub
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listeClient()
    End Sub
    Private Sub AjoutClient(ByVal numCLient As String, ByVal nom As String)
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim requete As String = "insert into client values('" & numCLient & "','" & nom & "','');"
                Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                commande.ExecuteNonQuery()
                MsgBox("Le Client est ajoutee avec succes!")
            Catch ex As Exception
                MessageBox.Show("le numero du client est deja occupe! veuillez choisir un autre ", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            connection.Close()
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
    End Sub
    Private Sub AjouterBtn_Click(sender As Object, e As EventArgs) Handles AjouterBtn.Click
        Dim NumClient As String = numClientTxt.Text.ToString
        Dim nom As String = nomTxt.Text.ToString

        Erreur.Clear()

        If Regex.IsMatch(NumClient, "^(C)[0-9]{3,3}$") And Regex.IsMatch(nom, "^[A-Z][a-zA-Z]*$") Then
            AjoutClient(NumClient, nom)
            tableauClient.Items.Clear()
            listeClient()
            numClientTxt.Text = ""
            nomTxt.Text = ""
            Erreur.Clear()
        ElseIf Regex.IsMatch(NumClient, "^(C)[0-9]{3,3}$")
            Erreur.SetError(nomTxt, "verifier le nom d'abord")
        ElseIf Regex.IsMatch(nom, "^[A-Z][a-zA-Z]*$")
            Erreur.SetError(numClientTxt, "verifier le numClient d'abord")
        Else
            Erreur.SetError(nomTxt, "verifier le nom d'abord")
            Erreur.SetError(numClientTxt, "verifier le numClient d'abord")
        End If
    End Sub

    Private Sub tableauClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tableauClient.SelectedIndexChanged
        If tableauClient.SelectedItems.Count > 0 Then
            Dim selectione As ListViewItem = tableauClient.SelectedItems(0)
            numClientTxt.Text = selectione.SubItems(0).Text
            nomTxt.Text = selectione.SubItems(1).Text
        End If
    End Sub
    Private Sub ModifierClient(ByVal numClient As String, ByVal nom As String, ByVal ancien As String)
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim requete As String = "update client set numClient='" & numClient & "',nom='" & nom & "' where numClient='" & ancien & "';"
                Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                commande.ExecuteNonQuery()
                MsgBox("Le Client est modifie avec succes!")
            Catch ex As Exception
                MessageBox.Show("le numero du client est deja occupe! veuillez choisir un autre ", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            connection.Close()
        Catch es As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
    End Sub
    Private Sub SupprimerClient(ByVal numClient As String)
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim requete As String = "delete from client where numClient='" & numClient & "';"
                Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                commande.ExecuteNonQuery()
                Dim requete2 As String = "delete from achat where numClient='" & numClient & "';"
                Dim commande2 As OdbcCommand = New OdbcCommand(requete2, connection)
                commande2.ExecuteNonQuery()
                MsgBox("Le Client est supprime avec succes!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()
        Catch es As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
    End Sub
    Private Sub ModifierBtn_Click(sender As Object, e As EventArgs) Handles ModifierBtn.Click
        If tableauClient.SelectedItems.Count > 0 Then
            Dim numClientAncien As String = tableauClient.SelectedItems(0).SubItems(0).Text

            Erreur.Clear()

            If Regex.IsMatch(numClientTxt.Text.ToString, "^(C)[0-9]{3,3}$") And Regex.IsMatch(nomTxt.Text.ToString, "^[A-Z][a-zA-Z]*$") Then
                ModifierClient(numClientTxt.Text.ToString, nomTxt.Text.ToString, numClientAncien)
                tableauClient.Items.Clear()
                listeClient()
                numClientTxt.Text = ""
                nomTxt.Text = ""
                Erreur.Clear()
            ElseIf Regex.IsMatch(numClientTxt.Text.ToString, "^(C)[0-9]{3,3}$")
                Erreur.SetError(nomTxt, "verifier le nom d'abord")
            ElseIf Regex.IsMatch(nomTxt.Text.ToString, "^[A-Z][a-zA-Z]*$")
                Erreur.SetError(numClientTxt, "verifier le numClient d'abord")
            Else
                Erreur.SetError(nomTxt, "verifier le nom d'abord")
                Erreur.SetError(numClientTxt, "verifier le numClient d'abord")
            End If
        Else
            MessageBox.Show("Aucun Client n'a pas selectionne!!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SupprimerBtn_Click(sender As Object, e As EventArgs) Handles SupprimerBtn.Click
        If tableauClient.SelectedItems.Count > 0 Then
            SupprimerClient(numClientTxt.Text.ToString)
            tableauClient.Items.Clear()
            listeClient()
            numClientTxt.Text = ""
            nomTxt.Text = ""
        Else
            MessageBox.Show("Aucun Client n'a pas selectionne!!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub ChiffreLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ChiffreLink.LinkClicked
        Form1.CollerPage(New ChiffreAffaire())
    End Sub
End Class