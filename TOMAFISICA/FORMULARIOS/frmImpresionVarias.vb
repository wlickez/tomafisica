Public Class frmImpresionVarias
    Public p_numero As Integer
    Public p_usuario As String
    Public p_bodega As Integer

    Private Sub cargarFisicoMaestro(_bodega As Integer, _usuario As String)

        Try
            Me.FISICO_MAESTROTableAdapter.Fill(Me.VISTAS.FISICO_MAESTRO, g_empresa, _bodega, _usuario)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cargarBodega()
        Try
            Me.BODEGATableAdapter.Fill(Me.VISTAS.BODEGA, g_empresa)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmImpresionVarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)
        cargarBodega()
        txtCodigoAlmacen.Text = g_sucursal
        txtNombreAlmacen.Text = g_nombreSucursal
        txtNumeroToma.Text = g_numeroTomaFisica
        txtObservacionesTomaFisica.Text = g_observacionesTomaFisica
        cmbBodegas.SelectedValue = g_sucursal
        cargarFisicoMaestro(cmbBodegas.SelectedValue, p_usuario)

        cmbBodegas.SelectedValue = g_sucursal

        If (g_usuario.ToLower = "wlickez" Or g_usuario.ToLower = "dtrujillo") Then
            cmbBodegas.Enabled = True
            cmbBodegas.SelectedValue = 1

        End If
    End Sub
    Private Sub cmbBodegas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBodegas.SelectedValueChanged
        cargarFisicoMaestro(cmbBodegas.SelectedValue, p_usuario)
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click


    End Sub
End Class