Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.Odbc

Public Class Apropos
    Private Sub Apropos_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Form1.MenuVertical.Width = "58"
        Form1.Panel3.Width = "53"
        Form1.PictureBox1.BackColor = Color.Transparent
    End Sub
End Class