Public Class frmDiferenciasTomaFisica
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmDiferenciasTomaFisica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)
        Me.BODEGATableAdapter.Fill(Me.VISTAS.BODEGA, g_empresa)
        Me.TipoDiferenciaTableAdapter.Fill(Me.VISTAS.TipoDiferencia)
        If (g_usuario.ToLower = "wlickez" Or g_usuario.ToLower = "dtrujillo") Then
            cmbBodegas.Enabled = True
            cmbBodegas.SelectedValue = 1

        End If
        s_consultarDiferencias(CInt(cmbBodegas.SelectedValue), CInt(cmbTipoDiferencia.SelectedValue))
    End Sub

    Private Sub s_consultarDiferencias(_bodega As Integer, _tipo As Integer)
        Try
            Me.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter.Fill(Me.VISTAS.CONSULTAR_DIFERENCIAS_TOMA_FISICA, _bodega, _tipo)
            txtNombreAlmacen.Text = dgvDiferencias.Rows.Count
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmbBodegas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBodegas.SelectedValueChanged
        s_consultarDiferencias(CInt(cmbBodegas.SelectedValue), CInt(cmbTipoDiferencia.SelectedValue))
    End Sub

    Private Sub cmbTipoDiferencia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipoDiferencia.SelectedValueChanged
        s_consultarDiferencias(CInt(cmbBodegas.SelectedValue), CInt(cmbTipoDiferencia.SelectedValue))

    End Sub
End Class