Imports System.IO 'Libreria Necesaria para funcion de lectura y escritura de archivos.
Imports System.Data.Odbc
Public Class escucha6
    Dim conexion As OdbcConnection = New OdbcConnection("DSN=OdbcConexion")
    Private Sub Form7_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Form2.Show()
    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = Form1.Txt_Usuario.Text
        AxWinsock1.LocalPort = 9057
        AxWinsock1.Listen()
        ListBox1.Items.Add("Servidor Online")
    End Sub

    Private Sub AxWinsock1_ConnectionRequest(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles AxWinsock1.ConnectionRequest
        AxWinsock1.Close()
        ListBox1.Items.Add("Obteniendo Conexion")
        AxWinsock1.Accept(e.requestID)
        ListBox1.Items.Add("Cliente Conectado")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWinsock1.SendData(TextBox3.Text & ": " & TextBox2.Text)
        tbConversacion.Text = String.Concat(tbConversacion.Text, vbNewLine & TextBox3.Text & ": " & TextBox2.Text)
        TextBox2.Text = ""
        ListBox1.Items.Add("Mensaje enviado")

        Dim query As String
        conexion.Open()
        query = "INSERT INTO tbhistorial(historial) VALUES ('" + tbConversacion.Text + "')"
        Dim comando As New OdbcCommand()
        comando.Connection = conexion
        comando.CommandText = query
        comando.ExecuteNonQuery()
        comando.Connection = conexion

        conexion.Close()
    End Sub

    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim A As Object = Nothing
        Dim NovaString As String = ""
        Dim Caractere As Byte
        ListBox1.Items.Add("Mensaje recibido")
        AxWinsock1.GetData(A)
        For Each Caractere In A
            NovaString = String.Concat(NovaString, Chr(Caractere))
        Next
        tbConversacion.Text = String.Concat(tbConversacion.Text, vbNewLine, NovaString)
    End Sub

    Private Sub tbConversacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbConversacion.TextChanged
        Dim StRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim stContenidoArchivo As String = Nothing 'Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim stPathArchivo As String

        Try

            If Directory.Exists("C:\HISTORIAL DE MESSENGER") = False Then 'Verifica que la carpeta HISTORIAL DE MESSENGER exista, y si no la crea inmediatamente al iniciar la conversacion.
                Directory.CreateDirectory("C:\HISTORIAL DE MESSENGER") ' Linea que crea la carpeta en el Disco C.
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            stPathArchivo = "C:\HISTORIAL DE MESSENGER\Archivo-Mauricio y Rony" & ListBox1.Text & "-" & Format(Today.Date, "ddMMyyyy") & ".txt" 'Hace referencia al lugar o ubicacion de donde sera almacenada la conversacion.

            If File.Exists(stPathArchivo) Then 'Verificamos si el archivo existe y si no lo crea.    Format(TimeOfDay, "hhmm") &
                strStreamW = File.Open(stPathArchivo, FileMode.Open) 'Abrimos el archivo.
            Else
                strStreamW = File.Create(stPathArchivo) ' lo creamos.
            End If

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura.
            strStreamWriter.WriteLine(tbConversacion.Text) 'Escribimos en el archivo.
            strStreamWriter.Close() ' cerramos.

        Catch ex As Exception
            MsgBox("Error al Guardar la informacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName) 'Nos da la opcion si hubo algun problema a la hora de guardar la conversacion.
            strStreamWriter.Close() ' cerramos.
        End Try
        'TERMINA PROGRAMACION DE AUTOGUARDADO DE CADA CONVERSACION.
        '---------------------------------------------------------------------------------
    End Sub
End Class