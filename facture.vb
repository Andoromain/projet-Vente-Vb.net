Imports form1
Imports clientPerso
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class facture
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.CollerPage(ClientPerso)
    End Sub

    Private Sub PDFFacture_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PDFFacture.LinkClicked
        SaveFileChiffre.FileName = ""
        If annee.Text <> vbNullString And SaveFileChiffre.ShowDialog = DialogResult.OK Then
            Dim paragraph, paragraph2, paragraph3, paragraph4, paragraph5, paragraph6 As New Paragraph
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

            paragraph2 = New Paragraph(New Chunk("Facture N o : " & numFact.Text, pTable))
            paragraph2.Alignment = Element.ALIGN_CENTER
            paragraph2.SpacingAfter = 5.0F

            pdfFile.Add(paragraph2)

            paragraph3 = New Paragraph(New Chunk("NumClient : " & numCli.Text, pTable))
            paragraph3.Alignment = Element.ALIGN_LEFT
            paragraph3.SpacingAfter = 1.0F

            pdfFile.Add(paragraph3)

            paragraph4 = New Paragraph(New Chunk("annee : " & annee.Text, pTable))
            paragraph4.Alignment = Element.ALIGN_RIGHT
            paragraph4.SpacingAfter = 1.0F

            pdfFile.Add(paragraph4)

            paragraph5 = New Paragraph(New Chunk("Nom : " & nom.Text, pTable))
            paragraph5.Alignment = Element.ALIGN_LEFT
            paragraph5.SpacingAfter = 5.0F

            pdfFile.Add(paragraph5)



            Dim pdfTable As New PdfPTable(tableauFacture.Columns.Count)
            pdfTable.TotalWidth = 500.0F
            pdfTable.LockedWidth = True

            Dim widths(0 To tableauFacture.Columns.Count - 1) As Single
            For i As Integer = 0 To tableauFacture.Columns.Count - 1
                widths(i) = 1.0F
            Next

            pdfTable.SetWidths(widths)
            pdfTable.HorizontalAlignment = 0
            pdfTable.SpacingBefore = 5.0F

            Dim pdfcell As PdfPCell = New PdfPCell

            For i As Integer = 0 To tableauFacture.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(New Chunk(tableauFacture.Columns(i).HeaderText, pTable)))

                pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT

                pdfTable.AddCell(pdfcell)

            Next

            'add data into pdf table

            For i As Integer = 0 To tableauFacture.Rows.Count - 1
                For j As Integer = 0 To tableauFacture.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(tableauFacture(j, i).Value.ToString(), pTable))
                    pdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    pdfTable.AddCell(pdfcell)
                Next
            Next

            'aa pdf table into pdf document

            pdfFile.Add(pdfTable)

            paragraph6 = New Paragraph(New Chunk("TOTAL : " & total.Text, pTable))
            paragraph6.Alignment = Element.ALIGN_RIGHT
            paragraph6.SpacingAfter = 1.0F

            pdfFile.Add(paragraph6)

            pdfFile.Close()

            MessageBox.Show("Le PDF a generee avec succes !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("la generation du PDF est annule!", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
End Class