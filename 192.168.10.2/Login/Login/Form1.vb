Imports System.Data.Odbc
Imports ConexionSQL
Imports ODBCMySqlConnect 'importamos la DLL creada para la conexion de odbc con Mysql 

Public Class Form1
    Dim seg As seguridad = New seguridad()
    Dim db As New DBConnect("OdbcConexion") ' se realiza la creacion de la variable que llevara la conexion y se hace referencia a la ruta

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub limpiar()
        Me.Txt_Usuario.Text = String.Empty
        Me.txt_psw.Text = String.Empty
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_cuenta.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Form2.Show()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_psw.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_reg.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_registrate.Click
        frm_nuevo.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_login.Tick
        Static noe
        noe = noe + 1
        pcb_msn.Image = imglst_login.Images(noe)
        If noe = 2 Then
            noe = 0
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sesion.Click
        Dim s As String = "select tbDatuser_mail,tbDatuser_psw from tbDatuser where tbDatuser_mail = '" + Txt_Usuario.Text + "' and tbDatuser_psw= '" + txt_psw.Text + "'" 'En esta área manejamos lo que es el select para evaluar lo que es el usuario y la contraseña de la base de datos
        Dim array As System.Collections.ArrayList = db.consultar(s) 'En esta área evaluamos los array en cual contiene los diccionarios de datos 
        For Each dict As Dictionary(Of String, String) In array
            'MessageBox.Show(dict.Item("tbDatuser_mail"))
            'MessageBox.Show("Password: " + dict.Item("tbDatuser_psw"))
        Next
        If array.Count = 1 Then

            Form2.Show()
            AxWinsock1.RemotePort = 5055
            AxWinsock1.RemoteHost = "192.168.10.1"
            AxWinsock1.Connect()

            MessageBox.Show("Bienvenido a ADST Messenger")
            pcb_msn.Visible = False
            Lbl_reg.Visible = False
            Btn_registrate.Visible = False
            Lnk_psw.Visible = False
            btn_sesion.Visible = False
            txt_psw.Visible = False
            Txt_Usuario.Visible = False
            lbl_cuenta.Visible = False
            Me.Size = New System.Drawing.Size(250, 468)

            Me.Text = "ADST Messenger"
            PictureBox1.Visible = True
            Lst_box_1.Visible = True
            Bt_3.Visible = True

        Else
            MessageBox.Show("Usuario o Contraseña son incorrectos", "Ingreso Usuario", MessageBoxButtons.OK,
   MessageBoxIcon.Exclamation)
            txt_psw.Text = ""
            Txt_Usuario.Text = ""
            Txt_Usuario.Focus()
        End If


    End Sub

    Private Sub pcb_msn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcb_msn.Click

    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcb_login.Click

    End Sub
    Private Sub nametxt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Usuario.Leave
        If (String.IsNullOrEmpty(Txt_Usuario.Text)) Then
            Txt_Usuario.Text = String.Empty
        ElseIf (seg.validar_Mail(Txt_Usuario.Text)) = False Then
            MessageBox.Show("Formato de correo electronico es incorrecto, debe ser: nombre@dominio.abc, " & _
     " Por favor ingrese una direccion valida", "Validación de correo electronico", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation)
            Txt_Usuario.Text = ""
            Txt_Usuario.Focus()
        End If
    End Sub

    Private Sub Lnk_psw_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Lnk_psw.LinkClicked
        frm_recuperar.Show()
        Me.Hide()
    End Sub

    Private Sub Bt_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_3.Click
        Lst_box_1.Text = ""
        Dim a() As String
        Dim i As Integer
        a = Split(Txt_1.Text, vbCrLf)
        For i = 0 To UBound(a)
            Lst_box_1.Items.Add(a(i))
        Next
    End Sub

    Private Sub Txt_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_1.TextChanged
        Txt_1.Text = Replace(Txt_1.Text, "192.168.10.2", "Mauricio Carias")
        Txt_1.Text = Replace(Txt_1.Text, "192.168.10.3", "Noelia Zapeta")
        Txt_1.Text = Replace(Txt_1.Text, "192.168.10.4", "David Garcia")
        Txt_1.Text = Replace(Txt_1.Text, "192.168.10.5", "Sara Gomez")
        Txt_1.Text = Replace(Txt_1.Text, "192.168.10.6", "Rony Caracun")
        Txt_1.Text = Replace(Txt_1.Text, "192.168.10.7", "Mario Chanquin")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lst_box_1.SelectedIndexChanged

        If Lst_box_1.Text = "Mauricio Carias" Then
            envia2.Show()

        ElseIf Lst_box_1.Text = "Noelia Zapeta" Then
            envia3.Show()

        ElseIf Lst_box_1.Text = "David Garcia" Then
            envia4.Show()

        ElseIf Lst_box_1.Text = "Sara Gomez" Then
            envia5.Show()

        ElseIf Lst_box_1.Text = "Rony Caracun" Then
            envia6.Show()

        ElseIf Lst_box_1.Text = "Mario Chanquin" Then
            envia7.Show()

        ElseIf Lst_box_1.Text = "192.168.10.8" Then
            envia8.Show()


        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim A As Object = Nothing
        Dim NovaString As String = ""
        Dim Caractere As Byte
        AxWinsock1.GetData(A)
        For Each Caractere In A
            NovaString = String.Concat(NovaString, Chr(Caractere))
        Next
        Txt_1.Text = String.Concat(Txt_1.Text, vbNewLine, NovaString)
    End Sub

    Private Sub Btn_grup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_grup.Click
        Process.Start("C:\Users\Mario Chanquin\Desktop\ultima modificacion rony\Listo Viernes\192.168.10.2\ADST_CHAT.exe", AppWinStyle.MaximizedFocus)
    End Sub
End Class