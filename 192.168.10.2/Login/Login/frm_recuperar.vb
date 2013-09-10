Imports System.Data.Odbc 'Es el proveedor de datos .NET Framework para ODBC.

Public Class frm_recuperar
    Dim conexion = New OdbcConnection("DSN=OdbcConexion") ' Declaracion de odbc
    Dim seg As seguridad = New seguridad() 'Creamos variable que recibia e inicialize modulo seguridad para validar correcto electronico

    Public Sub oculto()
        panel.Visible = False 'Se oculta el panel al inicio del formulario
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oculto() 'Carga metodo oculto
    End Sub

    Private Sub btnsolicitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsolicitar.Click
        'Abrimos la conexion a la base de datos, se consulta si el correo existe o no
        Try
            conexion.Open()
            Dim mysqladapter As New OdbcDataAdapter
            Dim sqlquery = "SELECT *FROM tbDatuser WHERE tbDatuser_mail='" + txtcorreo.Text + "'"
            Dim comando As New OdbcCommand
            comando.Connection = conexion
            comando.CommandText = sqlquery
            mysqladapter.SelectCommand = comando
            Dim data As OdbcDataReader
            data = comando.ExecuteReader()
            'Control de Errores si el usuario ha sido registrado en la base de datos.
            If data.HasRows = 0 Then
                MsgBox("Usuario No Existe", MsgBoxStyle.Information, "Usuario No Existe en la Aplicacion")
                lblaviso.Text = "Usuario NO existe, Verifique..."
            Else
                panel.Visible = True
                lblaviso.Text = "Usuario Existente"
                Me.txtcorreo.Enabled = False
                Me.btnsolicitar.Enabled = False
            End If
            conexion.Close() 'Cerramos la conexion
        Catch ex As Exception
            MsgBox("ERROR EN LA CONECTIVIDAD DE BASE DE DATOS")
        End Try
    End Sub

    ' Evento click de el boton confirmar
    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        If (String.IsNullOrEmpty(txtclave.Text)) Or (String.IsNullOrEmpty(txtconfirmar.Text)) Then
            MsgBox("Complete todos los Campos", MsgBoxStyle.OkOnly, "Campos Vacios")
        ElseIf (txtclave.Text = txtconfirmar.Text) Then
            'Se Guardan los datos
            Dim query As String
            conexion.Open() 'Se abre la conexion y se ejecuta el query de update a la base de datos del campo contrasena de el usuario de correo
            query = "update tbDatuser set tbDatuser_psw='" + txtclave.Text + "'where tbDatuser_mail='" + txtcorreo.Text + "';"
            Dim comando As New OdbcCommand()
            comando.Connection = conexion
            comando.CommandText = query
            comando.ExecuteNonQuery()
            MsgBox("Guardado Exitoso", MsgBoxStyle.Information, "Contraseña Reestablecida")
            'Bloqueamos los controles
            Me.txtcorreo.Enabled = False
            Me.txtclave.Enabled = False
            Me.txtconfirmar.Enabled = False
            Me.btnconfirmar.Enabled = False
            conexion.Close() 'Cerramos la conexion
            Me.Close()
        Else
            'Control de errores de correo invalido
            MessageBox.Show("Confirmacion Invalido", "Confirmacion de Password Invalido", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation)
        End If
    End Sub

    ' Evento leave de el campo correo, control de errores de el formato correcto de correo electronico
    Private Sub txtcorreo_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcorreo.Leave
        If (seg.validar_Mail(txtcorreo.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no valida, el correo debe tener el formato: nombre@dominio.abc, " & _
     " por favor seleccione un correo valido", "Validación de correo electronico", MessageBoxButtons.OK,
     MessageBoxIcon.Exclamation)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        End If
    End Sub

    Private Sub Form4_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()

    End Sub

    Private Sub txtconfirmar_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirmar.Leave
        'Control d errores, ambas contrasenas deben coincidir
        If (txtclave.Text <> txtconfirmar.Text) Then
            MessageBox.Show("Confirmacion Invalido", "Confirmacion de Password Invalido", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class