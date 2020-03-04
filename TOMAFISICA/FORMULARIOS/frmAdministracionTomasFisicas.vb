Public Class frmAdministracionTomasFisicas
    Dim l_numero As Integer
    Private Sub frmAdministracionTomasFisicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)
        Me.BODEGATableAdapter.Fill(Me.VISTAS.BODEGA, g_empresa)
        Me.USUARIOTableAdapter.Fill(Me.VISTAS.USUARIO)
        cmbSucursal.SelectedIndex = 0
        Me.dgvTomasFisicas.ContextMenuStrip = Me.menucontextoDGV
        s_consultarTomaFisicoMaestro(sender, e)
    End Sub
    Private Sub s_consultarTomaFisicoMaestro(sender As Object, e As EventArgs)
        Try
            Me.FISICO_MAESTROTableAdapter.Fill(Me.VISTAS.FISICO_MAESTRO, g_empresa, cmbSucursal.SelectedValue, g_usuario)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmbSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSucursal.SelectedIndexChanged
        s_consultarTomaFisicoMaestro(sender, e)
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim f As New frmReporte
        f.p_numero = dgvTomasFisicas.CurrentRow.Cells(0).Value
        f.p_usuario = dgvTomasFisicas.CurrentRow.Cells(4).Value
        f.p_bodega = dgvTomasFisicas.CurrentRow.Cells(5).Value
        f.ShowDialog()
    End Sub
    Private Sub AnuladaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnuladaToolStripMenuItem.Click
        If cls_Data.f_crudTomaFisicaMaestro(g_empresa, dgvTomasFisicas.CurrentRow.Cells(0).Value, txtFecha.Text, txtObservaciones.Text, "A", cmbUsuario.SelectedValue, DateTime.Now, cmbSucursal.SelectedValue, 3) Then
            s_consultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub RevisandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisandoToolStripMenuItem.Click
        If cls_Data.f_crudTomaFisicaMaestro(g_empresa, dgvTomasFisicas.CurrentRow.Cells(0).Value, txtFecha.Text, txtObservaciones.Text, "R", cmbUsuario.SelectedValue, "01-01-2000", cmbSucursal.SelectedValue, 3) Then
            s_consultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub CerradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerradaToolStripMenuItem.Click
        If cls_Data.f_crudTomaFisicaMaestro(g_empresa, dgvTomasFisicas.CurrentRow.Cells(0).Value, txtFecha.Text, txtObservaciones.Text, "C", cmbUsuario.SelectedValue, "01-01-2000", cmbSucursal.SelectedValue, 3) Then
            s_consultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub TrabajandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajandoToolStripMenuItem.Click
        If cls_Data.f_crudTomaFisicaMaestro(g_empresa, dgvTomasFisicas.CurrentRow.Cells(0).Value, txtFecha.Text, txtObservaciones.Text, "G", cmbUsuario.SelectedValue, "01-01-2000", cmbSucursal.SelectedValue, 3) Then
            s_consultarTomaFisicoMaestro(sender, e)
        End If
    End Sub
    Private Sub dgvTomasFisicas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTomasFisicas.CellClick
        Try
            If dgvTomasFisicas.RowCount > 0 Then
                txtFecha.Text = dgvTomasFisicas.CurrentRow.Cells(1).Value
                txtObservaciones.Text = dgvTomasFisicas.CurrentRow.Cells(2).Value
                cmbUsuario.SelectedText = dgvTomasFisicas.CurrentRow.Cells(4).Value
                l_numero = dgvTomasFisicas.CurrentRow.Cells(0).Value
                txtNumero.Text = l_numero
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim tipo As Integer = 1
        If cmbSucursal.SelectedValue <> 0 And IsDate(txtFecha.Text) And txtObservaciones.Text <> "" Then
            For Each d As DataGridViewRow In dgvTomasFisicas.Rows
                If (txtNumero.Text) = CInt(d.Cells(0).Value) Then
                    tipo = 2
                End If
            Next
            If cls_Data.f_crudTomaFisicaMaestro(g_empresa, CInt(txtNumero.Text), txtFecha.Text, txtObservaciones.Text, "G", cmbUsuario.SelectedValue, "01-01-2010", cmbSucursal.SelectedValue, tipo) Then
                s_consultarTomaFisicoMaestro(sender, e)
            End If
        End If
    End Sub
    Private Sub dgvTomasFisicas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTomasFisicas.CellDoubleClick
        Dim f As New frmReporte
        f.p_numero = CInt(dgvTomasFisicas.CurrentRow.Cells(0).Value)
        f.p_usuario = g_usuario
        f.p_bodega = CInt(dgvTomasFisicas.CurrentRow.Cells(5).Value)
        f.ShowDialog()
    End Sub
End Class