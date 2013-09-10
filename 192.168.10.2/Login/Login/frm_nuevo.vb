Imports System.IO  'importaciones IO
Imports System.Data.Odbc 'Es el proveedor de datos .NET Framework para ODBC.
Imports System.Drawing.Drawing2D ''Proporciona  funciones de gráficos vectoriales y bidimensionales avanzadas.

Public Class frm_nuevo
    Dim seg As seguridad = New seguridad() 'Creamos e inicializamos la clase seguridad
    Dim conexion As OdbcConnection = New OdbcConnection("DSN=OdbcConexion") 'Declaracion variable odbc
    Dim cap As String

    Public Sub limpiar() 'funcion limpiar para que todos los TextBox inicien con los campos vacios
        Me.txt_pais.Text = String.Empty
        Me.txt_email.Text = String.Empty
        Me.txt_confpassword.Text = String.Empty
        Me.txt_password.Text = String.Empty
        Me.txt_nombre.Text = String.Empty
        Me.txt_apellido.Text = String.Empty
        Me.cmb_sexo.Text = String.Empty
        Me.txt_captcha.Text = String.Empty
    End Sub
  
    Private Sub chb_condiciones_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chb_condiciones.CheckedChanged
        If chb_condiciones.Checked = True Then 'Condicion de haber aceptado los terminos y condiciones del servicio, usando checkbox
            btn_registro.Enabled = True
            btn_registro.ForeColor = Color.White
        Else
            btn_registro.Enabled = False
        End If
    End Sub

    Private Sub btn_registro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registro.Click
        'Control de errores ya que los campos de registro deben tener informacion para poder continuar
        If ((String.IsNullOrEmpty(txt_pais.Text)) Or (String.IsNullOrEmpty(txt_email.Text)) Or (String.IsNullOrEmpty(txt_confpassword.Text)) Or _
            (String.IsNullOrEmpty(txt_password.Text)) Or (String.IsNullOrEmpty(txt_nombre.Text)) Or (String.IsNullOrEmpty(txt_apellido.Text)) Or _
            (String.IsNullOrEmpty(txt_captcha.Text))) Then
            MsgBox("Debe llenar todos los campos", MsgBoxStyle.Information, "Importante")
            cap = seg.captcha(PictureBox1) 'Nuevo Captcha a ingresar
            'Control de errores, los correos electronicos debe coincidir en ambos campos
        ElseIf (txt_email.Text <> txt_confemail.Text) Then
            MsgBox("Las Direcciones de correos no coinciden", MsgBoxStyle.Information, "Correo Invalido")
            cap = seg.captcha(PictureBox1) 'Nuevo Captcha a ingresar
            'Control de errores, las contraseñas debe coincidir en ambos campos
        ElseIf (txt_password.Text <> txt_confpassword.Text) Then
            MsgBox("Las Contraseñas no coinciden", MsgBoxStyle.Information, "Contraseñas Invalida")
            cap = seg.captcha(PictureBox1) 'Nuevo Captcha a ingresar
        ElseIf (txt_captcha.Text <> cap) Then
            cap = seg.captcha(PictureBox1) 'Nuevo Captcha a ingresar
            MsgBox("Captcha Incorrecto, Pruebe otra vez", MsgBoxStyle.Information, "Captcha Incorrecto")
        Else
            Dim query, query2, id As String 'Declaracion de variables para los queries y el id de usuario
            Dim foreing As String
            conexion.Open()  'Abrimos la conexion
            id = "SELECT MAX(tbUser_id) from tbUser" 'Select para obtener el dato maximo de la tabla tbUser_id
            'Query de insercion a la tabla tbUser
            query = "INSERT INTO tbUser(tbUser_nom,tbUser_apell,tbUser_genero) VALUES ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + cmb_sexo.Text + "')"
            Dim comando As New OdbcCommand()  'Declaracion comando odbc y la ejecucion de el query
            comando.Connection = conexion
            comando.CommandText = query
            comando.ExecuteNonQuery()
            comando.Connection = conexion
            comando.CommandText = id
            foreing = comando.ExecuteScalar() 'variable foreing recibe la columa de la tabla TbUser_id
            'Query de insercion a la tabla relacionado con TbUser_id, recibe la llave foranea que corresponde a la primaria de la tabla principal
            query2 = "INSERT INTO tbDatuser(tbDatuser_mail,tbDatuser_psw,tbUser_tbUser_id) VALUES ('" + txt_email.Text + "','" + txt_password.Text + "','" + foreing.ToString + "')"
            comando.Connection = conexion 'ejecucion de el query 2
            comando.CommandText = query2
            comando.ExecuteNonQuery()
            conexion.Close()
            limpiar() 'limpia los campos
            Me.Hide() 'oculta formulario y abre el inicial
            Form1.Show()
        End If


    End Sub

    Private Sub frm_nuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cap = seg.captcha(PictureBox1) 'carga captcha de inicio de formulario

    End Sub

   Private Sub txt_email_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_email.Leave
        'Control de errores, validacion de formato correcto de correo electronico
        If (seg.validar_Mail(txt_email.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.abc, " & _
     " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation)
            txt_email.Focus()
            txt_email.SelectAll()

        End If
    End Sub

    Private Sub txt_confemail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_confemail.Leave
        'Control de errores, validacion de formato correcto de correo electronico campo confirmacion correo
        If (seg.validar_Mail(txt_confemail.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.abc, " & _
     " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation)
            txt_confemail.Focus()
            txt_confemail.SelectAll()
        ElseIf (txt_confemail.Text <> txt_email.Text) Then
            MessageBox.Show("Confirmacion Invalido", "Confirmacion de correo electronico", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txt_confpassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_confpassword.Leave
        'Control de errores, validacion de contraseñas que no coinciden.
        If (txt_confpassword.Text <> txt_password.Text) Then
            MessageBox.Show("Confirmacion Invalido", "Confirmacion de Password Invalido", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

  
End Class
