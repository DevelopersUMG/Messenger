Public Class Form2
    Dim direc As String
    Private Sub Bt_guardarcon_Click(sender As System.Object, e As System.EventArgs) Handles Bt_guardarcon.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub AMayusculasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AMayusculasToolStripMenuItem.Click
        TextBox1.Text = TextBox2.Text.ToUpper
        TextBox2.Text = TextBox2.Text.ToUpper
    End Sub

    Private Sub AMinusculasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AMinusculasToolStripMenuItem.Click
        TextBox1.Text = TextBox2.Text.ToLower
        TextBox2.Text = TextBox2.Text.ToLower
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        direc = "C:\Users\Samaria\Documents\GitHub\Messenger\Login\Login\ayuda\help_msn_sm.chm"

        Help.ShowHelp(Me, direc)
    End Sub
End Class