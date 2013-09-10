
Imports System.IO  'Lectura y Escritura
Imports System.Data.Odbc 'Es el proveedor de datos .NET Framework para ODBC.
Imports System.Drawing.Drawing2D  'Proporciona  funciones de gráficos vectoriales y bidimensionales avanzadas.
Imports System.Text.RegularExpressions 'Importacion de libreria Expresion Regular


Public Class seguridad  'Nombre de la Clase 
    Public Function captcha(ByVal PictureBox1 As PictureBox) As String 'Funcion para generar el CAPTCHA aleatorio
        Dim alfanumerio As String = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'String de Abecedario y numeros 0-9
        Dim str As String = ""
        Dim r As New Random     'Variable Aleatoria
        For i As Integer = 0 To 3
            str = str + alfanumerio(r.Next(0, 34))
        Next
        Dim b As New Bitmap(156, 90, Imaging.PixelFormat.Format32bppArgb) 'Dibuja el mapa de bits de la imagen
        Dim gr As Graphics = Graphics.FromImage(b)
        Dim hb As New HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(255, 128, 0), Color.Black)
        gr.FillRectangle(hb, New Rectangle(0, 0, 180, 95))
        gr.DrawString(str, New Font("Arial", 25, FontStyle.Strikeout, GraphicsUnit.Point), Brushes.White, 2, 1)
        PictureBox1.Image = b
        Return str
    End Function

    Public Function validar_Mail(ByVal sMail As String) As Boolean 'Funcion Para reconocer el formato de correo electronico
        ' Devuelve el valor sea falso o verdadero  
        Return Regex.IsMatch(sMail, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$") 'Expresion regular
    End Function

End Class