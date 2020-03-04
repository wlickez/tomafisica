Public Class frmLogin
    Private Sub btmLogin_Click(sender As Object, e As EventArgs) Handles btmLogin.Click
        iniciarSesion()
    End Sub
    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            iniciarSesion()
        ElseIf e.KeyCode = Keys.F6 Then
            Dim c As New cls_Imprimir
            c.s_imprimirTicket(New DataGridView)
        ElseIf e.KeyCode = Keys.F11 Then
            Dim c As New cls_obtenerHora
            MessageBox.Show(c.s_sincronizar(txtUsuario.Text, CInt(txtClave.Text)))
        End If
    End Sub
    Sub iniciarSesion()
        If cls_Data.f_loginUsuario(txtUsuario.Text, txtClave.Text, Me) Then
            g_usuario = txtUsuario.Text
            If (cls_Data.f_cosultaDatosUsuario(g_empresa, g_usuario, Me) = False) Then
                cls_Data.f_cosultaDatosUsuarioAdministrador(g_empresa, g_usuario, Me)
            End If
            Me.Hide()
            If cls_Data.f_adminCostos(g_empresa, txtUsuario.Text) Then
                Dim f1 As New frmElecciones
                f1.flogin = Me
                f1.ShowDialog()
                Exit Sub
            Else
                Dim f As New frmPrincipal
                f.flogin = Me
                f.ShowDialog()
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)
    End Sub
End Class