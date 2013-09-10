<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_cuenta = New System.Windows.Forms.Label()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_psw = New System.Windows.Forms.TextBox()
        Me.Lbl_reg = New System.Windows.Forms.Label()
        Me.Btn_registrate = New System.Windows.Forms.Button()
        Me.pcb_login = New System.Windows.Forms.PictureBox()
        Me.pcb_msn = New System.Windows.Forms.PictureBox()
        Me.tmr_login = New System.Windows.Forms.Timer(Me.components)
        Me.imglst_login = New System.Windows.Forms.ImageList(Me.components)
        Me.Lnk_psw = New System.Windows.Forms.LinkLabel()
        Me.btn_sesion = New System.Windows.Forms.Button()
        Me.Lst_box_1 = New System.Windows.Forms.ListBox()
        Me.Txt_1 = New System.Windows.Forms.TextBox()
        Me.Bt_3 = New System.Windows.Forms.Button()
        Me.AxWinsock1 = New AxMSWinsockLib.AxWinsock()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_grup = New System.Windows.Forms.Button()
        CType(Me.pcb_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcb_msn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cuenta
        '
        Me.lbl_cuenta.AutoSize = True
        Me.lbl_cuenta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cuenta.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuenta.Location = New System.Drawing.Point(387, 147)
        Me.lbl_cuenta.Name = "lbl_cuenta"
        Me.lbl_cuenta.Size = New System.Drawing.Size(77, 24)
        Me.lbl_cuenta.TabIndex = 1
        Me.lbl_cuenta.Text = "Cuenta"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(391, 174)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(213, 20)
        Me.Txt_Usuario.TabIndex = 1
        '
        'txt_psw
        '
        Me.txt_psw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_psw.Location = New System.Drawing.Point(391, 200)
        Me.txt_psw.Name = "txt_psw"
        Me.txt_psw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_psw.Size = New System.Drawing.Size(213, 22)
        Me.txt_psw.TabIndex = 2
        '
        'Lbl_reg
        '
        Me.Lbl_reg.AutoSize = True
        Me.Lbl_reg.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_reg.Location = New System.Drawing.Point(213, 400)
        Me.Lbl_reg.Name = "Lbl_reg"
        Me.Lbl_reg.Size = New System.Drawing.Size(251, 20)
        Me.Lbl_reg.TabIndex = 6
        Me.Lbl_reg.Text = "¿No dispones de una Cuenta?"
        '
        'Btn_registrate
        '
        Me.Btn_registrate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Btn_registrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_registrate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_registrate.Location = New System.Drawing.Point(480, 390)
        Me.Btn_registrate.Name = "Btn_registrate"
        Me.Btn_registrate.Size = New System.Drawing.Size(124, 30)
        Me.Btn_registrate.TabIndex = 7
        Me.Btn_registrate.Text = "REGISTRATE"
        Me.Btn_registrate.UseVisualStyleBackColor = False
        '
        'pcb_login
        '
        Me.pcb_login.BackColor = System.Drawing.Color.Transparent
        Me.pcb_login.ErrorImage = CType(resources.GetObject("pcb_login.ErrorImage"), System.Drawing.Image)
        Me.pcb_login.Image = CType(resources.GetObject("pcb_login.Image"), System.Drawing.Image)
        Me.pcb_login.Location = New System.Drawing.Point(371, 12)
        Me.pcb_login.Name = "pcb_login"
        Me.pcb_login.Size = New System.Drawing.Size(257, 99)
        Me.pcb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_login.TabIndex = 9
        Me.pcb_login.TabStop = False
        '
        'pcb_msn
        '
        Me.pcb_msn.Image = CType(resources.GetObject("pcb_msn.Image"), System.Drawing.Image)
        Me.pcb_msn.Location = New System.Drawing.Point(22, 31)
        Me.pcb_msn.Name = "pcb_msn"
        Me.pcb_msn.Size = New System.Drawing.Size(331, 333)
        Me.pcb_msn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_msn.TabIndex = 10
        Me.pcb_msn.TabStop = False
        '
        'tmr_login
        '
        Me.tmr_login.Enabled = True
        Me.tmr_login.Interval = 10000
        '
        'imglst_login
        '
        Me.imglst_login.ImageStream = CType(resources.GetObject("imglst_login.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst_login.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst_login.Images.SetKeyName(0, "skypemessenger.jpg")
        Me.imglst_login.Images.SetKeyName(1, "skyp11_tv_001_77B1878C.jpg")
        Me.imglst_login.Images.SetKeyName(2, "1033.skyp11_tv_002_3C500A08.jpg")
        '
        'Lnk_psw
        '
        Me.Lnk_psw.AutoSize = True
        Me.Lnk_psw.BackColor = System.Drawing.Color.Transparent
        Me.Lnk_psw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lnk_psw.LinkColor = System.Drawing.Color.Teal
        Me.Lnk_psw.Location = New System.Drawing.Point(408, 309)
        Me.Lnk_psw.Name = "Lnk_psw"
        Me.Lnk_psw.Size = New System.Drawing.Size(219, 20)
        Me.Lnk_psw.TabIndex = 11
        Me.Lnk_psw.TabStop = True
        Me.Lnk_psw.Text = "¿Olvidaste tu contraseña?"
        '
        'btn_sesion
        '
        Me.btn_sesion.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_sesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_sesion.Image = CType(resources.GetObject("btn_sesion.Image"), System.Drawing.Image)
        Me.btn_sesion.Location = New System.Drawing.Point(471, 237)
        Me.btn_sesion.Name = "btn_sesion"
        Me.btn_sesion.Size = New System.Drawing.Size(133, 45)
        Me.btn_sesion.TabIndex = 12
        Me.btn_sesion.Text = "Inicio de Sesión "
        Me.btn_sesion.UseVisualStyleBackColor = False
        '
        'Lst_box_1
        '
        Me.Lst_box_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_box_1.FormattingEnabled = True
        Me.Lst_box_1.ItemHeight = 16
        Me.Lst_box_1.Location = New System.Drawing.Point(44, 141)
        Me.Lst_box_1.Name = "Lst_box_1"
        Me.Lst_box_1.Size = New System.Drawing.Size(155, 244)
        Me.Lst_box_1.TabIndex = 13
        Me.Lst_box_1.Visible = False
        '
        'Txt_1
        '
        Me.Txt_1.Location = New System.Drawing.Point(844, 183)
        Me.Txt_1.Multiline = True
        Me.Txt_1.Name = "Txt_1"
        Me.Txt_1.Size = New System.Drawing.Size(90, 225)
        Me.Txt_1.TabIndex = 14
        Me.Txt_1.Visible = False
        '
        'Bt_3
        '
        Me.Bt_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bt_3.Location = New System.Drawing.Point(60, 102)
        Me.Bt_3.Name = "Bt_3"
        Me.Bt_3.Size = New System.Drawing.Size(122, 33)
        Me.Bt_3.TabIndex = 15
        Me.Bt_3.Text = "Conectados"
        Me.Bt_3.UseVisualStyleBackColor = True
        Me.Bt_3.Visible = False
        '
        'AxWinsock1
        '
        Me.AxWinsock1.Enabled = True
        Me.AxWinsock1.Location = New System.Drawing.Point(1070, 29)
        Me.AxWinsock1.Name = "AxWinsock1"
        Me.AxWinsock1.OcxState = CType(resources.GetObject("AxWinsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock1.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Btn_grup
        '
        Me.Btn_grup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_grup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btn_grup.Location = New System.Drawing.Point(60, 400)
        Me.Btn_grup.Name = "Btn_grup"
        Me.Btn_grup.Size = New System.Drawing.Size(122, 23)
        Me.Btn_grup.TabIndex = 18
        Me.Btn_grup.Text = "Chat en grupo"
        Me.Btn_grup.UseVisualStyleBackColor = True
        Me.Btn_grup.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(640, 441)
        Me.Controls.Add(Me.Btn_grup)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxWinsock1)
        Me.Controls.Add(Me.Bt_3)
        Me.Controls.Add(Me.Txt_1)
        Me.Controls.Add(Me.Lst_box_1)
        Me.Controls.Add(Me.btn_sesion)
        Me.Controls.Add(Me.Lnk_psw)
        Me.Controls.Add(Me.pcb_msn)
        Me.Controls.Add(Me.pcb_login)
        Me.Controls.Add(Me.Btn_registrate)
        Me.Controls.Add(Me.Lbl_reg)
        Me.Controls.Add(Me.txt_psw)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.lbl_cuenta)
        Me.Name = "Form1"
        Me.Text = "Login ADST"
        CType(Me.pcb_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcb_msn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cuenta As System.Windows.Forms.Label
    Friend WithEvents Txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_psw As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_reg As System.Windows.Forms.Label
    Friend WithEvents Btn_registrate As System.Windows.Forms.Button
    Friend WithEvents pcb_login As System.Windows.Forms.PictureBox
    Friend WithEvents pcb_msn As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_login As System.Windows.Forms.Timer
    Friend WithEvents imglst_login As System.Windows.Forms.ImageList
    Friend WithEvents Lnk_psw As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_sesion As System.Windows.Forms.Button
    Friend WithEvents Lst_box_1 As System.Windows.Forms.ListBox
    Friend WithEvents Txt_1 As System.Windows.Forms.TextBox
    Friend WithEvents Bt_3 As System.Windows.Forms.Button
    Friend WithEvents AxWinsock1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_grup As System.Windows.Forms.Button

End Class
