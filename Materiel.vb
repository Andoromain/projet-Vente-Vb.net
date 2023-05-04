Imports System.Data.Odbc
Imports System.Data
Imports form1
Imports stock
Imports System.Text.RegularExpressions

Public Class Materiel
    Private Sub Materiel_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Form1.MenuVertical.Width = "58"
        Form1.Panel3.Width = "53"
        Form1.PictureBox1.BackColor = Color.Transparent
    End Sub
    Private Sub ListeMateriel()
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select *from materiel;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader()
                Dim liste As ListViewItem
                While reader.Read()
                    liste = New ListViewItem({reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString})
                    tableauMateriel.Items.Add(liste)
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try

    End Sub
    Private Sub ListeMaterielVendus()
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select distinct materiel.numMat,materiel.design,sum(achat.qte) as quantite from materiel,achat ,client where materiel.numMat=achat.numMat and client.numClient=achat.numClient group by materiel.numMat;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader()
                Dim liste As ListViewItem
                While reader.Read()
                    liste = New ListViewItem({reader(0).ToString, reader(1).ToString, reader(2).ToString})
                    tableauMaterielVendu.Items.Add(liste)
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try

    End Sub
    Private Sub Materiel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListeMateriel()
        ListeMaterielVendus()
    End Sub
    Private Sub ajoutMateriel()
        If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") Then
            If Regex.IsMatch(designTxt.Text, "^[a-zA-Z\s\ ]+$") Then
                If PuTxt.Value > 0 Then
                    If StockTxt.Value > 0 Then
                        Try
                            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                            connection.Open()
                            Try
                                Dim requete As String = "insert into materiel values('" & numMatTxt.Text & "','" & designTxt.Text & "'," & PuTxt.Value & "," & StockTxt.Value & ");"
                                Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                                commande.ExecuteNonQuery()
                                MsgBox("Le materiel est ajoutee avec succes!")
                            Catch ex As Exception
                                MessageBox.Show("Le numero du materiel est deja enregistre ! Veuillez Choisir un autre", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End Try
                            connection.Close()
                        Catch ex As Exception
                            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
                        End Try
                        tableauMateriel.Items.Clear()
                        ListeMateriel()
                        numMatTxt.Text = ""
                        designTxt.Text = ""
                        PuTxt.Value = 0
                        StockTxt.Value = 0
                    End If
                End If
            End If
        End If


    End Sub
    Private Sub AjouterBtn_Click(sender As Object, e As EventArgs) Handles AjouterBtn.Click

        Erreur.Clear()

        If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") = False Then
            Erreur.SetError(numMatTxt, "Verifier le numMat d'abord")
        End If
        If Regex.IsMatch(designTxt.Text, "^[a-zA-Z\s\ ]+$") = False Then
            Erreur.SetError(designTxt, "Verifier le design d'abord")
        End If
        If PuTxt.Value <= 0 Then
            Erreur.SetError(PuTxt, "Verifier le prix d'abord")
        End If
        If StockTxt.Value <= 0 Then
            Erreur.SetError(StockTxt, "Verifier le stock d'abord")
        End If

        ajoutMateriel()
        tableauMateriel.Items.Clear()
        ListeMateriel()

    End Sub
    Private Sub ModifierMateriel(ByVal ancien As String)

        If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") Then
            If Regex.IsMatch(designTxt.Text, "^[a-zA-Z\s\ ]+$") Then
                If PuTxt.Value > 0 Then
                    If StockTxt.Value > 0 Then
                        Try
                            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                            connection.Open()
                            Try
                                Dim requete As String = "update materiel set numMat='" & numMatTxt.Text & "',design='" & designTxt.Text & "',Pu=" & PuTxt.Value & ",Stock=" & StockTxt.Value & " where numMat='" & ancien & "';"
                                Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                                commande.ExecuteNonQuery()
                                MsgBox("Le materiel est modifie avec succes!")
                            Catch ex As Exception
                                MessageBox.Show("Le numero du materiel est deja enregistre ! Veuillez Choisir un autre", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End Try
                            connection.Close()
                        Catch es As Exception
                            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
                        End Try
                        tableauMateriel.Items.Clear()
                        ListeMateriel()
                        numMatTxt.Text = ""
                        designTxt.Text = ""
                        PuTxt.Value = 0
                        StockTxt.Value = 0
                    End If
                End If
            End If
        End If


    End Sub
    Private Sub ModifierBtn_Click(sender As Object, e As EventArgs) Handles ModifierBtn.Click
        If tableauMateriel.SelectedItems.Count > 0 Then
            Erreur.Clear()

            If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") = False Then
                Erreur.SetError(numMatTxt, "Verifier le numMat d'abord")
            End If
            If Regex.IsMatch(designTxt.Text, "^[a-zA-Z\s\ ]+$") = False Then
                Erreur.SetError(designTxt, "Verifier le design d'abord")
            End If
            If PuTxt.Value <= 0 Then
                Erreur.SetError(PuTxt, "Verifier le prix d'abord")
            End If
            If StockTxt.Value <= 0 Then
                Erreur.SetError(StockTxt, "Verifier le stock d'abord")
            End If



            Dim selectione As ListViewItem = tableauMateriel.SelectedItems(0)
            ModifierMateriel(selectione.SubItems(0).Text)
            tableauMateriel.Items.Clear()
            ListeMateriel()
        Else
            MessageBox.Show("Aucun Materiel n'a pas selectionne!!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SupprimerBtn_Click(sender As Object, e As EventArgs) Handles SupprimerBtn.Click
        If tableauMateriel.SelectedItems.Count > 0 Then
            Try
                Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                connection.Open()
                Try
                    Dim requete As String = "delete from materiel where numMat='" & tableauMateriel.SelectedItems(0).SubItems(0).Text & "';"
                    Dim commande As OdbcCommand = New OdbcCommand(requete, connection)
                    commande.ExecuteNonQuery()
                    ' Dim commande1 As OdbcCommand = New OdbcCommand("delete from achat where numMat='" & tableauMateriel.SelectedItems(0).SubItems(0).Text & "';", connection)
                    'commande1.ExecuteNonQuery()
                    MsgBox("Le materiel est supprime avec succes!")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                connection.Close()
            Catch es As Exception
                MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
            End Try
            tableauMateriel.Items.Clear()
            ListeMateriel()
            numMatTxt.Text = ""
            designTxt.Text = ""
            PuTxt.Value = 0
            StockTxt.Value = 0
        Else
            MessageBox.Show("Aucun Materiel n'a pas selectionne!!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub tableauMateriel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tableauMateriel.SelectedIndexChanged
        If tableauMateriel.SelectedItems.Count > 0 Then
            Dim selectione As ListViewItem = tableauMateriel.SelectedItems(0)
            numMatTxt.Text = selectione.SubItems(0).Text
            designTxt.Text = selectione.SubItems(1).Text
            PuTxt.Value = Val(selectione.SubItems(2).Text)
            StockTxt.Value = Val(selectione.SubItems(3).Text)
        Else
            numMatTxt.Text = ""
            designTxt.Text = ""
            PuTxt.Value = 0
            StockTxt.Value = 0
        End If

    End Sub

    Private Sub EtatStockLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EtatStockLink.LinkClicked
        Form1.CollerPage(Stock)
    End Sub
End Class