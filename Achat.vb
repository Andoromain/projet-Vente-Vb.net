Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class Achat
    Private Sub Achat_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Form1.MenuVertical.Width = "58"
        Form1.Panel3.Width = "53"
        Form1.PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub ListedAchat()
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select *from achat order by numClient asc;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader()
                Dim liste As ListViewItem
                While reader.Read()
                    liste = New ListViewItem({reader(0).ToString, reader(1).ToString, reader(2).ToString, reader(3).ToString, reader(4), ToString()})
                    tableauAchat.Items.Add(liste)
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
    End Sub
    Private Sub Achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListedAchat()
    End Sub
    Private Sub AjoutAchat()
        If Regex.IsMatch(numCliTxt.Text, "^(C)[0-9]{3,3}$") Then
            If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") Then
                If QteTxt.Value > 0 Then
                    Dim numClient As String = numCliTxt.Text.ToString
                    Dim numMat As String = numMatTxt.Text.ToString
                    Dim Qte As Integer = QteTxt.Value
                    Dim dati As String = DateValue(dateTxt.Value.Date)
                    Dim a As String() = dati.Split("/")
                    Dim i As Integer = a.Count - 2
                    Dim v As String
                    v = a(a.Count - 1)
                    While i >= 0
                        v = v + "-" + a(i)
                        i = i - 1
                    End While
                    Try
                        Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                        connection.Open()
                        Try
                            Dim commande As OdbcCommand = New OdbcCommand("insert into achat values('" & numClient & "','" & numMat & "'," & Qte & ",'" & v & "','');", connection)
                            commande.ExecuteNonQuery()
                            Dim commande2 As OdbcCommand = New OdbcCommand("update materiel set stock=stock-" & Qte & " where numMat='" & numMat & "';", connection)
                            commande2.ExecuteNonQuery()
                            connection.Close()

                            numCliTxt.Text = ""
                            numMatTxt.Text = ""
                            QteTxt.Value = 0
                            dateTxt.Value = Date.Now.Date
                        Catch ex As Exception
                            MessageBox.Show("Veuillez Choisir un autre", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End Try
                    Catch ex As Exception
                        MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub verificationAuBase()


        Dim a As Boolean = False
        Dim b As Boolean = False
        Dim c As Boolean = False
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select numClient from client;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader
                Dim commande2 As OdbcCommand = New OdbcCommand("select numMat from materiel;", connection)
                Dim reader2 = commande2.ExecuteReader
                Dim commande3 As OdbcCommand = New OdbcCommand("select stock from materiel where numMat='" & numMatTxt.Text & "';", connection)
                Dim reader3 = commande3.ExecuteReader

                While reader.Read
                    If numCliTxt.Text = reader(0).ToString Then
                        a = True
                    End If
                End While
                While reader2.Read
                    If numMatTxt.Text = reader2(0).ToString Then
                        b = True
                    End If
                End While
                While reader3.Read
                    If QteTxt.Value <= Val(reader3(0).ToString) Then
                        c = True
                    End If
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try

        If a = True And b = True And c = True Then
            AjoutAchat()
            tableauAchat.Items.Clear()
            ListedAchat()
        Else
            If a = False And b = False And c = False Then
                MessageBox.Show("Le client et le materiel ne sont pas dans la base de donnee!! et Le materiel demande est insuffisant", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                numCliTxt.Text = ""
                numMatTxt.Text = ""
                QteTxt.Value = 0
                dateTxt.Value = Date.Now.Date
            Else
                If a = False Then
                    MessageBox.Show("Le client n'est pas dans la base de donnee", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                End If
                If b = False Then
                    MessageBox.Show("Le materiel n'est pas dans la base de donnee", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                End If
                If c = False Then
                    MessageBox.Show("Le materiel demande est insuffisant", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                End If
            End If
        End If
    End Sub
    Private Sub AjouterBtn_Click(sender As Object, e As EventArgs) Handles AjouterBtn.Click
        Erreur.Clear()
        If Regex.IsMatch(numCliTxt.Text, "^(C)[0-9]{3,3}$") = False Then
            Erreur.SetError(numCliTxt, "verifier le numClient saisi")
        End If
        If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") = False Then
            Erreur.SetError(numMatTxt, "verifier le numMat saisi")
        End If
        If QteTxt.Value <= 0 Then
            Erreur.SetError(QteTxt, "verifier le Qte saisi")
        End If
        If numCliTxt.Text <> "" And numMatTxt.Text <> "" And QteTxt.Value > 0 Then
            verificationAuBase()
        End If
    End Sub

    Private Sub tableauAchat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tableauAchat.SelectedIndexChanged
        If tableauAchat.SelectedItems.Count > 0 Then
            Dim liste As ListViewItem = tableauAchat.SelectedItems(0)
            numCliTxt.Text = liste.SubItems(0).Text
            numMatTxt.Text = liste.SubItems(1).Text
            QteTxt.Value = Val(liste.SubItems(2).Text)
            dateTxt.Value = DateValue(liste.SubItems(3).Text)
        Else
            numCliTxt.Text = ""
            numMatTxt.Text = ""
            QteTxt.Value = 0
            dateTxt.Value = Date.Now.Date
        End If
    End Sub



    Private Sub SupprimerBtn_Click(sender As Object, e As EventArgs) Handles SupprimerBtn.Click
        If tableauAchat.SelectedItems.Count > 0 Then
            Dim listeSupr = tableauAchat.SelectedItems(0)
            Dim id As Integer = Val(listeSupr.SubItems(4).Text)
            Try
                Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                connection.Open()
                Try
                    Dim commande As OdbcCommand = New OdbcCommand("delete from achat where id=" & id & ";", connection)
                    commande.ExecuteNonQuery()
                    Dim commande1 As OdbcCommand = New OdbcCommand("update materiel set stock=stock+" & Val(listeSupr.SubItems(2).Text) & " where numMat='" & listeSupr.SubItems(1).Text & "';", connection)
                    commande1.ExecuteNonQuery()
                    MsgBox("L'achat est suprime avec succes!")
                    connection.Close()

                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("On ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
            End Try
        Else
            MessageBox.Show("Aucun Achat n'a pas selectionne!!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        tableauAchat.Items.Clear()
        ListedAchat()
    End Sub
    Private Sub ModifierAchat(ByVal id As Integer, ByVal qteAncien As Integer)

        If Regex.IsMatch(numCliTxt.Text, "^(C)[0-9]{3,3}$") Then
            If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") Then
                If QteTxt.Value > 0 Then
                    Try
                        Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
                        connection.Open()
                        Try
                            Dim dati As String = DateValue(dateTxt.Value.Date)
                            Dim a As String() = dati.Split("/")
                            Dim i As Integer = a.Count - 2
                            Dim v As String
                            v = a(a.Count - 1)
                            While i >= 0
                                v = v + "-" + a(i)
                                i = i - 1
                            End While
                            Dim commande As OdbcCommand = New OdbcCommand("update achat set numClient='" & numCliTxt.Text & "',numMat='" & numMatTxt.Text & "',qte=" & QteTxt.Value & ",date_achat='" & v & "' where id='" & id & "';", connection)
                            commande.ExecuteNonQuery()
                            Dim qteReste As Integer = qteAncien - QteTxt.Value
                            Dim commande2 As OdbcCommand = New OdbcCommand("update materiel set Stock=Stock+" & qteReste & " where numMat='" & numMatTxt.Text & "';", connection)
                            commande2.ExecuteNonQuery()

                            MsgBox("L'achat est modifie avec succes!")
                            connection.Close()

                            numCliTxt.Text = ""
                            numMatTxt.Text = ""
                            QteTxt.Value = 0
                            dateTxt.Value = Date.Now.Date
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Catch ex As Exception
                        MsgBox("On ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub ModifierBtn_Click(sender As Object, e As EventArgs) Handles ModifierBtn.Click
        If tableauAchat.SelectedItems.Count > 0 Then

            Erreur.Clear()
            If Regex.IsMatch(numCliTxt.Text, "^(C)[0-9]{3,3}$") = False Then
                Erreur.SetError(numCliTxt, "verifier le numClient saisi")
            End If
            If Regex.IsMatch(numMatTxt.Text, "^(M)[0-9]{3,3}$") = False Then
                Erreur.SetError(numMatTxt, "verifier le numMat saisi")
            End If
            If QteTxt.Value <= 0 Then
                Erreur.SetError(QteTxt, "verifier le Qte saisi")
            End If
            If numCliTxt.Text <> "" And numMatTxt.Text <> "" And QteTxt.Value > 0 Then
                VerificationAuBaseModif()

            End If
        Else
            MessageBox.Show("Aucun achat n'a pas selectionne!!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub VerificationAuBaseModif()

        Dim liste As ListViewItem = tableauAchat.SelectedItems(0)
        Dim id As Integer = Val(liste.SubItems(4).Text)
        Dim qteAncien As Integer = Val(liste.SubItems(2).Text)
        Dim a As Boolean = False
        Dim b As Boolean = False
        Dim c As Boolean = False
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim commande As OdbcCommand = New OdbcCommand("select numClient from client;", connection)
                Dim reader As OdbcDataReader = commande.ExecuteReader
                Dim commande2 As OdbcCommand = New OdbcCommand("select numMat from materiel;", connection)
                Dim reader2 = commande2.ExecuteReader
                Dim commande3 As OdbcCommand = New OdbcCommand("select stock from materiel where numMat='" & numMatTxt.Text & "';", connection)
                Dim reader3 = commande3.ExecuteReader

                While reader.Read
                    If numCliTxt.Text = reader(0).ToString Then
                        a = True
                    End If
                End While
                While reader2.Read
                    If numMatTxt.Text = reader2(0).ToString Then
                        b = True
                    End If
                End While
                While reader3.Read
                    If QteTxt.Value <= Val(reader3(0).ToString) Then
                        c = True
                    End If
                End While
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try

        If a = True And b = True And c = True Then
            ModifierAchat(id, qteAncien)
            tableauAchat.Items.Clear()
            ListedAchat()
        Else
            If a = False And b = False And c = False Then
                MessageBox.Show("Le client et le materiel ne sont pas dans la base de donnee!! et Le materiel demande est insuffisant", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                numCliTxt.Text = ""
                numMatTxt.Text = ""
                QteTxt.Value = 0
                dateTxt.Value = Date.Now.Date
            Else
                If a = False Then
                    MessageBox.Show("Le client n'est pas dans la base de donnee", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                End If
                If b = False Then
                    MessageBox.Show("Le materiel n'est pas dans la base de donnee", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                End If
                If c = False Then
                    MessageBox.Show("Le materiel demande est insuffisant", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    numCliTxt.Text = ""
                    numMatTxt.Text = ""
                    QteTxt.Value = 0
                    dateTxt.Value = Date.Now.Date
                End If
            End If
        End If
    End Sub
End Class