Imports System.Data.Odbc
Imports form1
Imports materiel
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Stock
    Private Sub Stock(ByVal annee As Integer)
        Try
            Dim connection As OdbcConnection = New OdbcConnection("DSN=data;server=localhost;UID=root;database=ventedematerielinformatique")
            connection.Open()
            Try
                Dim da As OdbcDataAdapter = New OdbcDataAdapter("select distinct materiel.numMat,materiel.design,materiel.Stock,sum(achat.qte) as Sortie from materiel,achat where materiel.numMat=achat.numMat and year(achat.date_achat)=" & annee & " group by materiel.numMat;", connection)

                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                tableauEtatStock.DataSource = dt
                connection.Close()
                da.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox("on ne peut pas se connecter pour le moment (peut etre que le server est en panne ou eteint) ")
        End Try
    End Sub

    Private Sub anneeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles anneeCombo.SelectedIndexChanged
        Dim annee As Integer = Val(anneeCombo.Text.ToCharArray)
        Stock(annee)
    End Sub

    Private Sub retour_Click(sender As Object, e As EventArgs) Handles retour.Click
        Form1.CollerPage(Materiel)
    End Sub

    Private Sub PDFStock_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PDFStock.LinkClicked
        SaveFileChiffre.FileName = ""
        If anneeCombo.Text <> vbNullString And SaveFileChiffre.ShowDialog = DialogResult.OK Then
            Dim paragraph, paragraph2 As New Paragraph
            Dim pdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
            pdfFile.AddTitle(titre.Text)
            Dim write As PdfWriter = PdfWriter.GetInstance(pdfFile, New FileStream(SaveFileChiffre.FileName.ToString, FileMode.Create))
            pdfFile.Open()

            Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

            paragraph = New Paragraph(New Chunk(titre.Text, pTitle))
            paragraph.Alignment = Element.ALIGN_CENTER
            paragraph.SpacingAfter = 5.0F

            pdfFile.Add(paragraph)

            paragraph2 = New Paragraph(New Chunk("annee : " & anneeCombo.Text, pTable))
            paragraph2.Alignment = Element.ALIGN_LEFT
            paragraph2.SpacingAfter = 5.0F

            pdfFile.Add(paragraph2)

            Dim pdfTable As New PdfPTable(tableauEtatStock.Columns.Count)
            pdfTable.TotalWidth = 500.0F
            pdfTable.LockedWidth = True

            Dim widths(0 To tableauEtatStock.Columns.Count - 1) As Single
            For i As Integer = 0 To tableauEtatStock.Columns.Count - 1
                widths(i) = 1.0F
            Next

            pdfTable.SetWidths(widths)
            pdfTable.HorizontalAlignment = 0
            pdfTable.SpacingBefore = 5.0F

            Dim pdfcell As PdfPCell = New PdfPCell

            For i As Integer = 0 To tableauEtatStock.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(New Chunk(tableauEtatStock.Columns(i).HeaderText, pTable)))

                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                pdfTable.AddCell(pdfcell)

            Next

            'add data into pdf table

            For i As Integer = 0 To tableauEtatStock.Rows.Count - 1
                For j As Integer = 0 To tableauEtatStock.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(tableauEtatStock(j, i).Value.ToString(), pTable))
                    pdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    pdfTable.AddCell(pdfcell)
                Next
            Next

            'aa pdf table into pdf document

            pdfFile.Add(pdfTable)
            pdfFile.Close()

            MessageBox.Show("Le PDF a generee avec succes !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Le tableau est vide !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class