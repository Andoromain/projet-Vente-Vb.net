Imports form1
Imports recherche
Imports System.Data.Odbc
Imports System.Data
Imports facture
Public Class ClientPerso
    Private Sub cam_Click_1(sender As Object, e As EventArgs) Handles cam.Click
        If ChoisirImage.ShowDialog = 1 Then
            Dim a As String() = ChoisirImage.FileName.Split("\")
            Dim i As Integer = 1
            Dim v As String
            v = a(0)
            While i < a.Count
                v = v + "\\" + a(i)
                i = i + 1
            End While
            Try
                Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                connection.Open()
                Try
                    Dim requete As String = "update client set image='" & v & "' where numClient='" & numClient.Text & "';"
                    Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                    commande.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch
                MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
            End Try
            sary.Image = Image.FromFile(ChoisirImage.FileName)
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        sary.Image = Image.FromFile("C:\Users\Romain\documents\visual studio 2015\Projects\ProjetVente\ProjetVente\Resources\avatar.png")
        Form1.CollerPage(Recherche)
    End Sub

    Private Sub anneecombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles anneecombo.SelectedIndexChanged
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select materiel.numMat,materiel.design from materiel,achat,client where materiel.numMat=achat.numMat and client.numClient=achat.numClient and client.numClient='" & numClient.Text & "' and year(achat.date_achat)=" & anneecombo.Text & " group by materiel.numMat;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader
                Dim liste As ListViewItem
                While reader.Read()
                    liste = New ListViewItem({reader(0).ToString, reader(1).ToString})
                    tableaulistMat.Items.Add(liste)
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
    End Sub

    Private Sub facturelink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles facturelink.LinkClicked

        If anneecombo.Text <> "" Then
            Form1.CollerPage(facture)
            facture.numCli.Text = numClient.Text
            facture.nom.Text = nom.Text
            facture.annee.Text = anneecombo.Text
            facture.numFact.Text = facture.numCli.Text & anneecombo.Text

            Try
                Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                connection.Open()
                Try
                    Dim da As OdbcDataAdapter = New OdbcDataAdapter("select distinct materiel.design,materiel.Pu,sum(achat.qte) as quantite,materiel.Pu*sum(achat.qte) as montant from materiel,client,achat where materiel.numMat=achat.numMat and client.numClient=achat.numClient and client.numClient='" & numClient.Text & "' and year(achat.date_achat)=" & anneecombo.Text & " group by materiel.design asc;", connection)

                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    facture.tableauFacture.DataSource = dt

                    Dim commande As OdbcCommand = New OdbcCommand("select sum(materiel.Pu*achat.qte) as Total from materiel,achat,client where materiel.numMat=achat.numMat and client.numClient=achat.numClient and client.numClient='" & numClient.Text & "' and year(achat.date_achat)=" & anneecombo.Text & ";", connection)
                    Dim reader As OdbcDataReader = commande.ExecuteReader()
                    While reader.Read
                        facture.total.Text = reader(0).ToString()

                    End While

                    connection.Close()
                    da.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
            End Try

        Else
            MessageBox.Show("L'annee est vide !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class