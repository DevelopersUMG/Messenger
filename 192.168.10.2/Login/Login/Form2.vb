Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWinsock1.LocalPort = 5056
        AxWinsock1.Listen()
        ListBox1.Items.Add("Servidor Online")
    End Sub



    Private Sub AxWinsock1_ConnectionRequest(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles AxWinsock1.ConnectionRequest
        AxWinsock1.Close()
        ListBox1.Items.Add("Obteniendo Conexion")
        AxWinsock1.Accept(e.requestID)

        If AxWinsock1.RemoteHostIP = "192.168.10.2" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha2.Show()
            Me.Close()

        ElseIf AxWinsock1.RemoteHostIP = "192.168.10.3" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha3.Show()
            Me.Close()


        ElseIf AxWinsock1.RemoteHostIP = "192.168.10.4" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha4.Show()
            Me.Close()

        ElseIf AxWinsock1.RemoteHostIP = "192.168.10.5" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha5.Show()
            Me.Close()

        ElseIf AxWinsock1.RemoteHostIP = "192.168.10.6" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha6.Show()
            Me.Close()

        ElseIf AxWinsock1.RemoteHostIP = "192.168.10.7" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha7.Show()
            Me.Close()

        ElseIf AxWinsock1.RemoteHostIP = "192.168.10.8" Then
            ListBox1.Items.Add("Cliente Conectado")
            escucha8.Show()
            Me.Close()

        
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWinsock1.SendData("Servidor: " & TextBox2.Text)
        TextBox1.Text = String.Concat(TextBox1.Text, vbNewLine & "Servidor: " & TextBox2.Text)
        TextBox2.Text = ""
        ListBox1.Items.Add("Mensaje enviado")
    End Sub

    Private Sub AxWinsock1_DataArrival(ByVal sender As Object, ByVal e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        Dim A As Object = Nothing
        Dim NovaString As String = ""
        Dim Caractere As Byte
        ListBox1.Items.Add("Mensaje recibido")
        AxWinsock1.GetData(A)
        For Each Caractere In A
            NovaString = String.Concat(NovaString, Chr(Caractere))
        Next
        TextBox1.Text = String.Concat(TextBox1.Text, vbNewLine, NovaString)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim datos As String
        datos = AxWinsock1.RemoteHostIP
        ListBox2.Items.Add(datos)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


End Class