<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recuperar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recuperar))
        Me.panel = New System.Windows.Forms.Panel()
        Me.lblconfirmar = New System.Windows.Forms.Label()
        Me.txtconfirmar = New System.Windows.Forms.TextBox()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.btnconfirmar = New System.Windows.Forms.Button()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.btnsolicitar = New System.Windows.Forms.Button()
        Me.lblcorreo = New System.Windows.Forms.Label()
        Me.lblaviso = New System.Windows.Forms.Label()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.Controls.Add(Me.lblconfirmar)
        Me.panel.Controls.Add(Me.txtconfirmar)
        Me.panel.Controls.Add(Me.txtclave)
        Me.panel.Controls.Add(Me.btnconfirmar)
        Me.panel.Controls.Add(Me.lblclave)
        Me.panel.Location = New System.Drawing.Point(20, 112)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(382, 127)
        Me.panel.TabIndex = 0
        '
        'lblconfirmar
        '
        Me.lblconfirmar.AutoSize = True
        Me.lblconfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirmar.Location = New System.Drawing.Point(-21, 50)
        Me.lblconfirmar.Name = "lblconfirmar"
        Me.lblconfirmar.Size = New System.Drawing.Size(166, 17)
        Me.lblconfirmar.TabIndex = 4
        Me.lblconfirmar.Text = "Confirmar Contraseña"
        '
        'txtconfirmar
        '
        Me.txtconfirmar.Location = New System.Drawing.Point(151, 50)
        Me.txtconfirmar.Name = "txtconfirmar"
        Me.txtconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmar.Size = New System.Drawing.Size(215, 20)
        Me.txtconfirmar.TabIndex = 3
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(151, 26)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(215, 20)
        Me.txtclave.TabIndex = 2
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconfirmar.Location = New System.Drawing.Point(274, 90)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(91, 33)
        Me.btnconfirmar.TabIndex = 1
        Me.btnconfirmar.Text = "Guardar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclave.Location = New System.Drawing.Point(3, 24)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(142, 17)
        Me.lblclave.TabIndex = 0
        Me.lblclave.Text = "Nueva Contraseña"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(13, 34)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(253, 20)
        Me.txtcorreo.TabIndex = 1
        '
        'btnsolicitar
        '
        Me.btnsolicitar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsolicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsolicitar.Location = New System.Drawing.Point(286, 24)
        Me.btnsolicitar.Name = "btnsolicitar"
        Me.btnsolicitar.Size = New System.Drawing.Size(116, 37)
        Me.btnsolicitar.TabIndex = 2
        Me.btnsolicitar.Text = "Solicitar"
        Me.btnsolicitar.UseVisualStyleBackColor = False
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.BackColor = System.Drawing.Color.Transparent
        Me.lblcorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.Location = New System.Drawing.Point(10, 7)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(221, 17)
        Me.lblcorreo.TabIndex = 3
        Me.lblcorreo.Text = "Ingresa tu Correo Electronico"
        '
        'lblaviso
        '
        Me.lblaviso.AutoSize = True
        Me.lblaviso.BackColor = System.Drawing.Color.Transparent
        Me.lblaviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaviso.Location = New System.Drawing.Point(20, 93)
        Me.lblaviso.Name = "lblaviso"
        Me.lblaviso.Size = New System.Drawing.Size(143, 17)
        Me.lblaviso.TabIndex = 4
        Me.lblaviso.Text = "Correo Electronico"
        '
        'frm_recuperar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(431, 262)
        Me.Controls.Add(Me.lblaviso)
        Me.Controls.Add(Me.lblcorreo)
        Me.Controls.Add(Me.btnsolicitar)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.panel)
        Me.MaximizeBox = False
        Me.Name = "frm_recuperar"
        Me.Text = "Recuperacion de Contraseña"
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents lblconfirmar As System.Windows.Forms.Label
    Friend WithEvents txtconfirmar As System.Windows.Forms.TextBox
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents txtcorreo As System.Windows.Forms.TextBox
    Friend WithEvents btnsolicitar As System.Windows.Forms.Button
    Friend WithEvents lblcorreo As System.Windows.Forms.Label
    Friend WithEvents lblaviso As System.Windows.Forms.Label
End Class
