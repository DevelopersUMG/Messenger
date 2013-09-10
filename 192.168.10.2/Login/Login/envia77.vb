Imports System.IO 'Libreria Necesaria para funcion de lectura y escritura de archivos.
Imports System.Data.Odbc
Public Class envia77
    Dim conexion As OdbcConnection = New OdbcConnection("DSN=OdbcConexion")
    Dim direc As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWinsock1.RemotePort = 5057
        AxWinsock1.RemoteHost = "192.168.10.7"
        AxWinsock1.Connect()
    End Sub

    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim A As Object = Nothing
        Dim NovaString As String = ""
        Dim Caractere As Byte
        AxWinsock1.GetData(A)
        For Each Caractere In A
            NovaString = String.Concat(NovaString, Chr(Caractere))
        Next
        tbConversacion.Text = String.Concat(tbConversacion.Text, vbNewLine, NovaString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWinsock1.SendData(TextBox4.Text & ": " & TextBox2.Text)
        tbConversacion.Text = String.Concat(tbConversacion.Text, vbNewLine & TextBox4.Text & ": " & TextBox2.Text)
        TextBox2.Text = ""

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

    Private Sub envia77_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox4.Text = Form1.Txt_Usuario.Text
        AxWinsock1.RemotePort = 5057
        AxWinsock1.RemoteHost = "192.168.10.7"
        AxWinsock1.Connect()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbConversacion.ForeColor = ColorDialog1.Color
            TextBox2.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub TipoLetraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoLetraToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            tbConversacion.Font = FontDialog1.Font
            TextBox2.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub NegritaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NegritaToolStripMenuItem.Click
        tbConversacion.Font = New Font(tbConversacion.Font, FontStyle.Bold)
        TextBox2.Font = New Font(tbConversacion.Font, FontStyle.Bold)
    End Sub

    Private Sub ColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub MayusculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MayusculaToolStripMenuItem.Click
        tbConversacion.Text = tbConversacion.Text.ToUpper
        TextBox2.Text = TextBox2.Text.ToUpper
    End Sub

    Private Sub MinusculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinusculaToolStripMenuItem.Click
        tbConversacion.Text = tbConversacion.Text.ToLower
        TextBox2.Text = TextBox2.Text.ToLower
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        direc = "C:\Users\Samaria\Desktop\messenger - copia\Cliente 192.168.10.5 - Copy\Cliente\Cliente\ayuda\help_msn_sm.chm"
        Help.ShowHelp(Me, direc)
    End Sub

    Private Sub CentrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentrarToolStripMenuItem.Click
        tbConversacion.TextAlign = HorizontalAlignment.Center
        TextBox2.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub ɮBetaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox2.Text = Label1.Text()
    End Sub

    Private Sub ΔTrianguloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ΔTrianguloToolStripMenuItem.Click
        TextBox2.Text = Label2.Text
    End Sub

    Private Sub SorprendidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SorprendidoToolStripMenuItem.Click
        TextBox2.Text = Label5.Text
    End Sub

    Private Sub ɮBetaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ɮBetaToolStripMenuItem.Click
        TextBox2.Text = Label3.Text
    End Sub

    Private Sub FelizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FelizToolStripMenuItem.Click
        TextBox2.Text = Label4.Text
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
            stPathArchivo = "C:\HISTORIAL DE MESSENGER\Archivo-Mauricio y Mario" & "-" & Format(Today.Date, "ddMMyyyy") & ".txt" 'Hace referencia al lugar o ubicacion de donde sera almacenada la conversacion.

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