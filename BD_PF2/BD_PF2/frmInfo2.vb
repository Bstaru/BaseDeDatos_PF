Public Class frmInfo2

    Private Sub frmInfo2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim Imagen1 As Bitmap = New Bitmap("C:\Users\Usuario\Desktop\BD\BD_PF2\uno.png")
        Clipboard.SetImage(Imagen1)
        Dim PictureFormat As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)
        RichTextBox1.Paste(PictureFormat)

        Dim Imagen2 As Bitmap = New Bitmap("C:\Users\Usuario\Desktop\BD\BD_PF2\dos.png")
        Clipboard.SetImage(Imagen2)
        Dim PictureFormat2 As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)
        RichTextBox1.Paste(PictureFormat2)

        Dim Imagen3 As Bitmap = New Bitmap("C:\Users\Usuario\Desktop\BD\BD_PF2\tres.png")
        Clipboard.SetImage(Imagen3)
        Dim PictureFormat3 As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)
        RichTextBox1.Paste(PictureFormat3)

    End Sub

End Class