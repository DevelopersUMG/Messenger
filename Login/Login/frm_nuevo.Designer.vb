<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_nuevo))
        Me.gbox_datos = New System.Windows.Forms.GroupBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.lbl_captcha2 = New System.Windows.Forms.Label()
        Me.txt_captcha = New System.Windows.Forms.TextBox()
        Me.lbl_captcha = New System.Windows.Forms.Label()
        Me.lbl_captcha1 = New System.Windows.Forms.Label()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_confpassword = New System.Windows.Forms.TextBox()
        Me.lbl_confpassword = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_confemail = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_confirmarcorreo = New System.Windows.Forms.Label()
        Me.lbl_correo = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.picb_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_ingreseinformacion = New System.Windows.Forms.Label()
        Me.btn_registro = New System.Windows.Forms.Button()
        Me.gbox_terminos = New System.Windows.Forms.GroupBox()
        Me.txt_terminoscond = New System.Windows.Forms.TextBox()
        Me.gb_perfil = New System.Windows.Forms.GroupBox()
        Me.lbl_imagencta = New System.Windows.Forms.Label()
        Me.txt_usuario1 = New System.Windows.Forms.TextBox()
        Me.lbl_usuario1 = New System.Windows.Forms.Label()
        Me.picb_foto = New System.Windows.Forms.PictureBox()
        Me.chb_condiciones = New System.Windows.Forms.CheckBox()
        Me.gbox_datos.SuspendLayout()
        CType(Me.picb_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbox_terminos.SuspendLayout()
        Me.gb_perfil.SuspendLayout()
        CType(Me.picb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbox_datos
        '
        Me.gbox_datos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbox_datos.BackColor = System.Drawing.Color.Transparent
        Me.gbox_datos.Controls.Add(Me.txt_apellido)
        Me.gbox_datos.Controls.Add(Me.lbl_captcha2)
        Me.gbox_datos.Controls.Add(Me.txt_captcha)
        Me.gbox_datos.Controls.Add(Me.lbl_captcha)
        Me.gbox_datos.Controls.Add(Me.lbl_captcha1)
        Me.gbox_datos.Controls.Add(Me.cmb_sexo)
        Me.gbox_datos.Controls.Add(Me.lbl_sexo)
        Me.gbox_datos.Controls.Add(Me.txt_nombre)
        Me.gbox_datos.Controls.Add(Me.txt_confpassword)
        Me.gbox_datos.Controls.Add(Me.lbl_confpassword)
        Me.gbox_datos.Controls.Add(Me.lbl_apellido)
        Me.gbox_datos.Controls.Add(Me.lbl_nombre)
        Me.gbox_datos.Controls.Add(Me.txt_password)
        Me.gbox_datos.Controls.Add(Me.txt_confemail)
        Me.gbox_datos.Controls.Add(Me.txt_email)
        Me.gbox_datos.Controls.Add(Me.lbl_password)
        Me.gbox_datos.Controls.Add(Me.lbl_confirmarcorreo)
        Me.gbox_datos.Controls.Add(Me.lbl_correo)
        Me.gbox_datos.Controls.Add(Me.txt_usuario)
        Me.gbox_datos.Controls.Add(Me.lbl_usuario)
        Me.gbox_datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbox_datos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.gbox_datos.Location = New System.Drawing.Point(14, 104)
        Me.gbox_datos.Margin = New System.Windows.Forms.Padding(2)
        Me.gbox_datos.Name = "gbox_datos"
        Me.gbox_datos.Padding = New System.Windows.Forms.Padding(2)
        Me.gbox_datos.Size = New System.Drawing.Size(365, 443)
        Me.gbox_datos.TabIndex = 0
        Me.gbox_datos.TabStop = False
        Me.gbox_datos.Text = "Datos de Usuario"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(164, 261)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(193, 23)
        Me.txt_apellido.TabIndex = 24
        '
        'lbl_captcha2
        '
        Me.lbl_captcha2.AutoSize = True
        Me.lbl_captcha2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_captcha2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_captcha2.Location = New System.Drawing.Point(14, 348)
        Me.lbl_captcha2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_captcha2.Name = "lbl_captcha2"
        Me.lbl_captcha2.Size = New System.Drawing.Size(101, 17)
        Me.lbl_captcha2.TabIndex = 23
        Me.lbl_captcha2.Text = "en la imagen"
        '
        'txt_captcha
        '
        Me.txt_captcha.Location = New System.Drawing.Point(164, 375)
        Me.txt_captcha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_captcha.Name = "txt_captcha"
        Me.txt_captcha.Size = New System.Drawing.Size(193, 23)
        Me.txt_captcha.TabIndex = 22
        '
        'lbl_captcha
        '
        Me.lbl_captcha.AutoSize = True
        Me.lbl_captcha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_captcha.Font = New System.Drawing.Font("Pristina", 19.8!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_captcha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_captcha.Location = New System.Drawing.Point(11, 375)
        Me.lbl_captcha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_captcha.Name = "lbl_captcha"
        Me.lbl_captcha.Size = New System.Drawing.Size(133, 35)
        Me.lbl_captcha.TabIndex = 21
        Me.lbl_captcha.Text = "CAPTCHA"
        '
        'lbl_captcha1
        '
        Me.lbl_captcha1.AutoSize = True
        Me.lbl_captcha1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_captcha1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_captcha1.Location = New System.Drawing.Point(14, 332)
        Me.lbl_captcha1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_captcha1.Name = "lbl_captcha1"
        Me.lbl_captcha1.Size = New System.Drawing.Size(142, 17)
        Me.lbl_captcha1.TabIndex = 20
        Me.lbl_captcha1.Text = "Escribe lo que ves"
        '
        'cmb_sexo
        '
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Location = New System.Drawing.Point(164, 300)
        Me.cmb_sexo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(193, 25)
        Me.cmb_sexo.TabIndex = 19
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sexo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_sexo.Location = New System.Drawing.Point(14, 306)
        Me.lbl_sexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(43, 17)
        Me.lbl_sexo.TabIndex = 18
        Me.lbl_sexo.Text = "Sexo"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(164, 224)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(193, 23)
        Me.txt_nombre.TabIndex = 13
        '
        'txt_confpassword
        '
        Me.txt_confpassword.Location = New System.Drawing.Point(164, 185)
        Me.txt_confpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_confpassword.Name = "txt_confpassword"
        Me.txt_confpassword.Size = New System.Drawing.Size(193, 23)
        Me.txt_confpassword.TabIndex = 11
        '
        'lbl_confpassword
        '
        Me.lbl_confpassword.AutoSize = True
        Me.lbl_confpassword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confpassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_confpassword.Location = New System.Drawing.Point(14, 191)
        Me.lbl_confpassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_confpassword.Name = "lbl_confpassword"
        Me.lbl_confpassword.Size = New System.Drawing.Size(147, 15)
        Me.lbl_confpassword.TabIndex = 10
        Me.lbl_confpassword.Text = "Confirmar Contraseña"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.BackColor = System.Drawing.Color.Transparent
        Me.lbl_apellido.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_apellido.Location = New System.Drawing.Point(15, 263)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(66, 17)
        Me.lbl_apellido.TabIndex = 9
        Me.lbl_apellido.Text = "Apellido"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_nombre.Location = New System.Drawing.Point(15, 230)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(64, 17)
        Me.lbl_nombre.TabIndex = 8
        Me.lbl_nombre.Text = "Nombre"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(164, 150)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(193, 23)
        Me.txt_password.TabIndex = 7
        '
        'txt_confemail
        '
        Me.txt_confemail.Location = New System.Drawing.Point(164, 112)
        Me.txt_confemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_confemail.Name = "txt_confemail"
        Me.txt_confemail.Size = New System.Drawing.Size(193, 23)
        Me.txt_confemail.TabIndex = 6
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(164, 73)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(193, 23)
        Me.txt_email.TabIndex = 5
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_password.Location = New System.Drawing.Point(14, 156)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(91, 17)
        Me.lbl_password.TabIndex = 4
        Me.lbl_password.Text = "Contraseña"
        '
        'lbl_confirmarcorreo
        '
        Me.lbl_confirmarcorreo.AutoSize = True
        Me.lbl_confirmarcorreo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirmarcorreo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_confirmarcorreo.Location = New System.Drawing.Point(14, 118)
        Me.lbl_confirmarcorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_confirmarcorreo.Name = "lbl_confirmarcorreo"
        Me.lbl_confirmarcorreo.Size = New System.Drawing.Size(128, 17)
        Me.lbl_confirmarcorreo.TabIndex = 3
        Me.lbl_confirmarcorreo.Text = "Confirmar E-mail"
        '
        'lbl_correo
        '
        Me.lbl_correo.AutoSize = True
        Me.lbl_correo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_correo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_correo.Location = New System.Drawing.Point(14, 79)
        Me.lbl_correo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_correo.Name = "lbl_correo"
        Me.lbl_correo.Size = New System.Drawing.Size(53, 17)
        Me.lbl_correo.TabIndex = 2
        Me.lbl_correo.Text = "E-mail"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(164, 36)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(193, 23)
        Me.txt_usuario.TabIndex = 1
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_usuario.Location = New System.Drawing.Point(14, 36)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(64, 17)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario"
        '
        'picb_logo
        '
        Me.picb_logo.BackColor = System.Drawing.Color.Transparent
        Me.picb_logo.ErrorImage = CType(resources.GetObject("picb_logo.ErrorImage"), System.Drawing.Image)
        Me.picb_logo.Image = CType(resources.GetObject("picb_logo.Image"), System.Drawing.Image)
        Me.picb_logo.Location = New System.Drawing.Point(468, 7)
        Me.picb_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.picb_logo.Name = "picb_logo"
        Me.picb_logo.Size = New System.Drawing.Size(218, 84)
        Me.picb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picb_logo.TabIndex = 3
        Me.picb_logo.TabStop = False
        '
        'lbl_ingreseinformacion
        '
        Me.lbl_ingreseinformacion.AutoSize = True
        Me.lbl_ingreseinformacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ingreseinformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ingreseinformacion.Location = New System.Drawing.Point(9, 49)
        Me.lbl_ingreseinformacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_ingreseinformacion.Name = "lbl_ingreseinformacion"
        Me.lbl_ingreseinformacion.Size = New System.Drawing.Size(368, 24)
        Me.lbl_ingreseinformacion.TabIndex = 4
        Me.lbl_ingreseinformacion.Text = "Ingrese los Datos para Nuevo Usuario "
        '
        'btn_registro
        '
        Me.btn_registro.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_registro.Enabled = False
        Me.btn_registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registro.Location = New System.Drawing.Point(554, 573)
        Me.btn_registro.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_registro.Name = "btn_registro"
        Me.btn_registro.Size = New System.Drawing.Size(125, 38)
        Me.btn_registro.TabIndex = 5
        Me.btn_registro.Text = "Registrarse"
        Me.btn_registro.UseVisualStyleBackColor = False
        '
        'gbox_terminos
        '
        Me.gbox_terminos.BackColor = System.Drawing.Color.Transparent
        Me.gbox_terminos.Controls.Add(Me.txt_terminoscond)
        Me.gbox_terminos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbox_terminos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.gbox_terminos.Location = New System.Drawing.Point(393, 365)
        Me.gbox_terminos.Margin = New System.Windows.Forms.Padding(2)
        Me.gbox_terminos.Name = "gbox_terminos"
        Me.gbox_terminos.Padding = New System.Windows.Forms.Padding(2)
        Me.gbox_terminos.Size = New System.Drawing.Size(286, 182)
        Me.gbox_terminos.TabIndex = 6
        Me.gbox_terminos.TabStop = False
        Me.gbox_terminos.Text = "Terminos y Condiciones"
        '
        'txt_terminoscond
        '
        Me.txt_terminoscond.Location = New System.Drawing.Point(16, 39)
        Me.txt_terminoscond.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_terminoscond.Multiline = True
        Me.txt_terminoscond.Name = "txt_terminoscond"
        Me.txt_terminoscond.Size = New System.Drawing.Size(252, 126)
        Me.txt_terminoscond.TabIndex = 26
        Me.txt_terminoscond.Text = "TERMINOS DE SERVICIO                   1. Información legal"
        '
        'gb_perfil
        '
        Me.gb_perfil.BackColor = System.Drawing.Color.Transparent
        Me.gb_perfil.Controls.Add(Me.lbl_imagencta)
        Me.gb_perfil.Controls.Add(Me.txt_usuario1)
        Me.gb_perfil.Controls.Add(Me.lbl_usuario1)
        Me.gb_perfil.Controls.Add(Me.picb_foto)
        Me.gb_perfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_perfil.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.gb_perfil.Location = New System.Drawing.Point(393, 104)
        Me.gb_perfil.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_perfil.Name = "gb_perfil"
        Me.gb_perfil.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_perfil.Size = New System.Drawing.Size(293, 240)
        Me.gb_perfil.TabIndex = 7
        Me.gb_perfil.TabStop = False
        Me.gb_perfil.Text = "Datos Perfil"
        '
        'lbl_imagencta
        '
        Me.lbl_imagencta.AutoSize = True
        Me.lbl_imagencta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_imagencta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_imagencta.Location = New System.Drawing.Point(14, 172)
        Me.lbl_imagencta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_imagencta.Name = "lbl_imagencta"
        Me.lbl_imagencta.Size = New System.Drawing.Size(157, 17)
        Me.lbl_imagencta.TabIndex = 25
        Me.lbl_imagencta.Text = "Imagen de la Cuenta"
        '
        'txt_usuario1
        '
        Me.txt_usuario1.Location = New System.Drawing.Point(149, 79)
        Me.txt_usuario1.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario1.Name = "txt_usuario1"
        Me.txt_usuario1.Size = New System.Drawing.Size(140, 23)
        Me.txt_usuario1.TabIndex = 24
        '
        'lbl_usuario1
        '
        Me.lbl_usuario1.AutoSize = True
        Me.lbl_usuario1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_usuario1.Location = New System.Drawing.Point(177, 58)
        Me.lbl_usuario1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_usuario1.Name = "lbl_usuario1"
        Me.lbl_usuario1.Size = New System.Drawing.Size(64, 17)
        Me.lbl_usuario1.TabIndex = 24
        Me.lbl_usuario1.Text = "Usuario"
        '
        'picb_foto
        '
        Me.picb_foto.Location = New System.Drawing.Point(16, 21)
        Me.picb_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.picb_foto.Name = "picb_foto"
        Me.picb_foto.Size = New System.Drawing.Size(117, 139)
        Me.picb_foto.TabIndex = 0
        Me.picb_foto.TabStop = False
        '
        'chb_condiciones
        '
        Me.chb_condiciones.AutoSize = True
        Me.chb_condiciones.BackColor = System.Drawing.Color.Transparent
        Me.chb_condiciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chb_condiciones.Location = New System.Drawing.Point(72, 583)
        Me.chb_condiciones.Margin = New System.Windows.Forms.Padding(2)
        Me.chb_condiciones.Name = "chb_condiciones"
        Me.chb_condiciones.Size = New System.Drawing.Size(478, 21)
        Me.chb_condiciones.TabIndex = 8
        Me.chb_condiciones.Text = "He leido y acepto las condiciones generales de este servicio. "
        Me.chb_condiciones.UseVisualStyleBackColor = False
        '
        'frm_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(700, 621)
        Me.Controls.Add(Me.chb_condiciones)
        Me.Controls.Add(Me.gb_perfil)
        Me.Controls.Add(Me.gbox_terminos)
        Me.Controls.Add(Me.btn_registro)
        Me.Controls.Add(Me.lbl_ingreseinformacion)
        Me.Controls.Add(Me.picb_logo)
        Me.Controls.Add(Me.gbox_datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADST Messenger "
        Me.TopMost = True
        Me.gbox_datos.ResumeLayout(False)
        Me.gbox_datos.PerformLayout()
        CType(Me.picb_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbox_terminos.ResumeLayout(False)
        Me.gbox_terminos.PerformLayout()
        Me.gb_perfil.ResumeLayout(False)
        Me.gb_perfil.PerformLayout()
        CType(Me.picb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbox_datos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents lbl_correo As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents txt_confemail As System.Windows.Forms.TextBox
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_confirmarcorreo As System.Windows.Forms.Label
    Friend WithEvents picb_logo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_ingreseinformacion As System.Windows.Forms.Label
    Friend WithEvents btn_registro As System.Windows.Forms.Button
    Friend WithEvents gbox_terminos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_confpassword As System.Windows.Forms.TextBox
    Friend WithEvents lbl_confpassword As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents gb_perfil As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_captcha As System.Windows.Forms.Label
    Friend WithEvents lbl_captcha1 As System.Windows.Forms.Label
    Friend WithEvents chb_condiciones As System.Windows.Forms.CheckBox
    Friend WithEvents txt_captcha As System.Windows.Forms.TextBox
    Friend WithEvents lbl_captcha2 As System.Windows.Forms.Label
    Friend WithEvents lbl_imagencta As System.Windows.Forms.Label
    Friend WithEvents txt_usuario1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_usuario1 As System.Windows.Forms.Label
    Friend WithEvents picb_foto As System.Windows.Forms.PictureBox
    Friend WithEvents txt_terminoscond As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
End Class
