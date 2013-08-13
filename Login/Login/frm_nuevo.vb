
Public Class frm_nuevo


    Private Sub frm_nuevo_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If (e.KeyCode = Keys.Escape) Then

            Me.Close()

        End If


    End Sub

    Private Sub chb_condiciones_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chb_condiciones.CheckedChanged
        If chb_condiciones.Checked = True Then
            btn_registro.Enabled = True
            btn_registro.ForeColor = Color.White
        Else
            btn_registro.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_apellido.TextChanged

    End Sub

    Private Sub txt_terminoscond_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_terminoscond.TextChanged

    End Sub

    Private Sub btn_registro_Click(sender As System.Object, e As System.EventArgs) Handles btn_registro.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
