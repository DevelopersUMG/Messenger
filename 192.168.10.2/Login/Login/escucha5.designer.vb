﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class escucha5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(escucha5))
        Me.AxWinsock1 = New AxMSWinsockLib.AxWinsock()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tbConversacion = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWinsock1
        '
        Me.AxWinsock1.Enabled = True
        Me.AxWinsock1.Location = New System.Drawing.Point(355, 12)
        Me.AxWinsock1.Name = "AxWinsock1"
        Me.AxWinsock1.OcxState = CType(resources.GetObject("AxWinsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWinsock1.Size = New System.Drawing.Size(28, 28)
        Me.AxWinsock1.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(261, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 41)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 175)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(243, 42)
        Me.TextBox2.TabIndex = 32
        '
        'tbConversacion
        '
        Me.tbConversacion.Location = New System.Drawing.Point(12, 63)
        Me.tbConversacion.Multiline = True
        Me.tbConversacion.Name = "tbConversacion"
        Me.tbConversacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbConversacion.Size = New System.Drawing.Size(371, 106)
        Me.tbConversacion.TabIndex = 31
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(243, 43)
        Me.ListBox1.TabIndex = 30
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 229)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(175, 20)
        Me.TextBox3.TabIndex = 35
        '
        'escucha5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(397, 229)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.AxWinsock1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbConversacion)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "escucha5"
        Me.Text = "ADST Messenger"
        CType(Me.AxWinsock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWinsock1 As AxMSWinsockLib.AxWinsock
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents tbConversacion As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
