﻿Public Class Form2

    Private Sub Bt_guardarcon_Click(sender As System.Object, e As System.EventArgs) Handles Bt_guardarcon.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class