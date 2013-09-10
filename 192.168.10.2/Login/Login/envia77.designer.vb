<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class envia77
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(envia77))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.AxWinsock1 = New AxMSWinsockLib.AxWinsock()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbConversacion = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoLetraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegritaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayusculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinusculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimbolosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ΔTrianguloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ɮBetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormasDeCaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FelizToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorprendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Usuario:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(50, 263)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(175, 20)
        Me.TextBox4.TabIndex = 68
        '
        'AxWinsock1
        '
        Me.AxWinsock1.Enabled = True
        Me.AxWinsock1.Location = New System.Drawing.Point(496, 251)
        Me.AxWinsock1.Name = "AxWinsock1"
        Me.AxWinsock1.OcxState = CType(resources.GetObject("AxWinsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock1.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock1.TabIndex = 67
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 28)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Conectar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(276, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 45)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 145)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(258, 45)
        Me.TextBox2.TabIndex = 64
        '
        'tbConversacion
        '
        Me.tbConversacion.Location = New System.Drawing.Point(12, 30)
        Me.tbConversacion.Multiline = True
        Me.tbConversacion.Name = "tbConversacion"
        Me.tbConversacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbConversacion.Size = New System.Drawing.Size(392, 109)
        Me.tbConversacion.TabIndex = 63
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripDropDownButton2, Me.ToolStripSeparator2, Me.ToolStripDropDownButton3, Me.ToolStripSeparator3, Me.ToolStripDropDownButton4, Me.ToolStripSeparator4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(416, 25)
        Me.ToolStrip1.TabIndex = 78
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextoToolStripMenuItem, Me.FondoToolStripMenuItem, Me.SimbolosToolStripMenuItem, Me.FormasDeCaraToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.TipoLetraToolStripMenuItem, Me.NegritaToolStripMenuItem, Me.MayusculaToolStripMenuItem, Me.MinusculaToolStripMenuItem, Me.CentrarToolStripMenuItem})
        Me.TextoToolStripMenuItem.Image = CType(resources.GetObject("TextoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Image = CType(resources.GetObject("ColorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'TipoLetraToolStripMenuItem
        '
        Me.TipoLetraToolStripMenuItem.Image = CType(resources.GetObject("TipoLetraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TipoLetraToolStripMenuItem.Name = "TipoLetraToolStripMenuItem"
        Me.TipoLetraToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.TipoLetraToolStripMenuItem.Text = "Tipo letra"
        '
        'NegritaToolStripMenuItem
        '
        Me.NegritaToolStripMenuItem.Image = CType(resources.GetObject("NegritaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NegritaToolStripMenuItem.Name = "NegritaToolStripMenuItem"
        Me.NegritaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.NegritaToolStripMenuItem.Text = "Negrita"
        '
        'MayusculaToolStripMenuItem
        '
        Me.MayusculaToolStripMenuItem.Image = CType(resources.GetObject("MayusculaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MayusculaToolStripMenuItem.Name = "MayusculaToolStripMenuItem"
        Me.MayusculaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MayusculaToolStripMenuItem.Text = "Mayuscula"
        '
        'MinusculaToolStripMenuItem
        '
        Me.MinusculaToolStripMenuItem.Image = CType(resources.GetObject("MinusculaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MinusculaToolStripMenuItem.Name = "MinusculaToolStripMenuItem"
        Me.MinusculaToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MinusculaToolStripMenuItem.Text = "Minuscula"
        '
        'CentrarToolStripMenuItem
        '
        Me.CentrarToolStripMenuItem.Image = CType(resources.GetObject("CentrarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CentrarToolStripMenuItem.Name = "CentrarToolStripMenuItem"
        Me.CentrarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CentrarToolStripMenuItem.Text = "Centrar"
        '
        'FondoToolStripMenuItem
        '
        Me.FondoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem1})
        Me.FondoToolStripMenuItem.Image = CType(resources.GetObject("FondoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FondoToolStripMenuItem.Name = "FondoToolStripMenuItem"
        Me.FondoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FondoToolStripMenuItem.Text = "Fondo"
        '
        'ColorToolStripMenuItem1
        '
        Me.ColorToolStripMenuItem1.Image = CType(resources.GetObject("ColorToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ColorToolStripMenuItem1.Name = "ColorToolStripMenuItem1"
        Me.ColorToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ColorToolStripMenuItem1.Text = "Color"
        '
        'SimbolosToolStripMenuItem
        '
        Me.SimbolosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ΔTrianguloToolStripMenuItem, Me.ɮBetaToolStripMenuItem})
        Me.SimbolosToolStripMenuItem.Image = CType(resources.GetObject("SimbolosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SimbolosToolStripMenuItem.Name = "SimbolosToolStripMenuItem"
        Me.SimbolosToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SimbolosToolStripMenuItem.Text = "Simbolos"
        '
        'ΔTrianguloToolStripMenuItem
        '
        Me.ΔTrianguloToolStripMenuItem.Name = "ΔTrianguloToolStripMenuItem"
        Me.ΔTrianguloToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ΔTrianguloToolStripMenuItem.Text = "Δ - Triangulo"
        '
        'ɮBetaToolStripMenuItem
        '
        Me.ɮBetaToolStripMenuItem.Name = "ɮBetaToolStripMenuItem"
        Me.ɮBetaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ɮBetaToolStripMenuItem.Text = "ɮ  - Beta"
        '
        'FormasDeCaraToolStripMenuItem
        '
        Me.FormasDeCaraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FelizToolStripMenuItem, Me.SorprendidoToolStripMenuItem})
        Me.FormasDeCaraToolStripMenuItem.Image = CType(resources.GetObject("FormasDeCaraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FormasDeCaraToolStripMenuItem.Name = "FormasDeCaraToolStripMenuItem"
        Me.FormasDeCaraToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FormasDeCaraToolStripMenuItem.Text = "Formas de cara"
        '
        'FelizToolStripMenuItem
        '
        Me.FelizToolStripMenuItem.Name = "FelizToolStripMenuItem"
        Me.FelizToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.FelizToolStripMenuItem.Text = "\﻿ (•◡•) / - Feliz"
        '
        'SorprendidoToolStripMenuItem
        '
        Me.SorprendidoToolStripMenuItem.Name = "SorprendidoToolStripMenuItem"
        Me.SorprendidoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SorprendidoToolStripMenuItem.Text = "≧☉_☉≦ - Sorprendido"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EliminarToolStripMenuItem1})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton3.Text = "ToolStripDropDownButton3"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Image = CType(resources.GetObject("EliminarToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = CType(resources.GetObject("ToolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton4.Text = "ToolStripDropDownButton4"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Image = CType(resources.GetObject("VerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Δ"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "ɮ "
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "\﻿ (•◡•) / "
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "≧☉_☉≦"
        Me.Label5.Visible = False
        '
        'envia77
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(416, 198)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.AxWinsock1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbConversacion)
        Me.Name = "envia77"
        Me.Text = "ADST Messenger"
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents AxWinsock1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tbConversacion As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoLetraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NegritaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FondoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton4 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents MayusculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinusculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CentrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimbolosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormasDeCaraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ΔTrianguloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FelizToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SorprendidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ɮBetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
