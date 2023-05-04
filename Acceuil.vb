Imports ProjetVente.Form1
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Acceuil
    Private Sub Acceuil_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Form1.MenuVertical.Width = "58"
        Form1.Panel3.Width = "53"
        Form1.PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("simple.pdf", FileMode.Create))
        pdfDoc.Open()
        pdfDoc.Add(New Paragraph("salut"))
        pdfDoc.Close()
    End Sub
End Class