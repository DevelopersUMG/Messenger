﻿Public Class envia7

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWinsock1.RemotePort = 5056
        AxWinsock1.RemoteHost = "192.168.10.7"
        AxWinsock1.Connect()
        Me.Hide()
        envia77.Show()
    End Sub

    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim A As Object = Nothing
        Dim NovaString As String = ""
        Dim Caractere As Byte
        AxWinsock1.GetData(A)
        For Each Caractere In A
            NovaString = String.Concat(NovaString, Chr(Caractere))
        Next
        TextBox1.Text = String.Concat(TextBox1.Text, vbNewLine, NovaString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWinsock1.SendData(TextBox4.Text & ": " & TextBox2.Text)
        TextBox1.Text = String.Concat(TextBox1.Text, vbNewLine & TextBox4.Text & ": " & TextBox2.Text)
        TextBox2.Text = ""
    End Sub
End Class