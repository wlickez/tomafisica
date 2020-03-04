Public Class frmElecciones
    Public flogin As Form
    Private Sub btnCostos_Click(sender As Object, e As EventArgs) Handles btnCostos.Click
        Dim f As New frmCostos
        f.flogin = Me
        f.ShowDialog()
    End Sub

    Private Sub btnTomasFisicas_Click(sender As Object, e As EventArgs) Handles btnTomasFisicas.Click
        Dim f As New frmPrincipal
        f.flogin = Me
        f.ShowDialog()
    End Sub

    Private Sub frmElecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)
    End Sub

    Private Sub frmElecciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        flogin.Show()
        Me.Dispose()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        flogin.Show()
        Me.Dispose()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        Application.Exit()
    End Sub
End Class