Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ObjWcfOperaciones As New WsOperaciones.ServiceClient
        Me.TextBox3.Text = ObjWcfOperaciones.Opsuma(Me.TextBox1.Text, Me.TextBox2.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ObjWcfOperaciones As New WsOperaciones.ServiceClient
        Me.TextBox3.Text = ObjWcfOperaciones.OpResta(Me.TextBox1.Text, Me.TextBox2.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ObjWcfOperaciones As New WsOperaciones.ServiceClient
        Me.TextBox3.Text = ObjWcfOperaciones.OpMultiplica(Me.TextBox1.Text, Me.TextBox2.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ObjWcfOperaciones As New WsOperaciones.ServiceClient
        Me.TextBox3.Text = ObjWcfOperaciones.OpDivide(Me.TextBox1.Text, Me.TextBox2.Text)
    End Sub
End Class
