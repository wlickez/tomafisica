Public Class frmPrincipal
    Public flogin As Form
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cls_FuncionesPrincipales.s_enviarObjetosParaBusqueda(Me, txtCodigoProducto, txtNombreProducto, CInt(cmbBodegas.SelectedValue))
        If txtCodigoProducto.Text <> "" Then
            txtFisico.Focus()
        End If
    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        cls_FuncionesPrincipales.s_keyDownFormulariosFacturacion(sender, e, Me, txtCodigoProducto, txtNombreProducto, CInt(cmbBodegas.SelectedValue), dgvTomaFisica)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)

        txtTop.Value = 10
        Me.BODEGATableAdapter.Fill(Me.VISTAS.BODEGA, g_empresa)
        txtCodigoAlmacen.Text = g_sucursal
        txtNombreAlmacen.Text = g_nombreSucursal
        txtNumeroToma.Text = g_numeroTomaFisica
        txtObservacionesTomaFisica.Text = g_observacionesTomaFisica
        's_cargarDatosFisicoDetalle(txtNumeroToma.Text, g_usuario, g_sucursal)

        Me.dgvTomaFisica.ContextMenuStrip = Me.menucontextoDGV

        cmbBodegas.SelectedValue = g_sucursal

        If (g_usuario.ToLower = "wlickez" Or g_usuario.ToLower = "dtrujillo" Or g_usuario.ToLower = "dchen") Then

            cmbBodegas.Enabled = True
            cmbBodegas.SelectedValue = 1
            txtBuscarPosicion.Visible = True
            btnBuscarPosicion.Visible = True
            For Each t As ToolStripMenuItem In Me.MenuStripPrincipal.Items
                If t.Tag = "1" Then
                    t.Visible = True
                End If
            Next
        End If

    End Sub

    Private Sub txtFisico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFisico.KeyPress
        cls_FuncionesPrincipales.s_digitarCantidadesEnteras(e, sender)
    End Sub
    Private Sub txtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        cls_FuncionesPrincipales.s_digitarCantidadesEnteras(e, sender)
    End Sub

    Private Sub btnAgregarDetalle_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalle.Click

        'hacer el insert a la base de datos
        'leer el registro de la base de datos y mostrarlo en el dgv
        If (txtCodigoProducto.Text <> "" And txtNombreProducto.Text <> "" And txtFisico.Text <> "") Then
            'dgvTomaFisica.Rows.Add()
            'Dim cantFilas As Integer = dgvTomaFisica.Rows.Count - 1
            'dgvTomaFisica.Rows(cantFilas).Cells(0).Value = txtCodigoProducto.Text
            'dgvTomaFisica.Rows(cantFilas).Cells(1).Value = txtNombreProducto.Text
            'dgvTomaFisica.Rows(cantFilas).Cells(2).Value = txtFisico.Text
            'If cls_Data.f_crudTomaFisicaDetalle(CInt(txtNumeroToma.Text), txtCodigoProducto.Text, 1, 1, CInt(txtFisico.Text), CInt(txtCodigoAlmacen.Text), 1, 0) Then
            If cls_Data.f_crudTomaFisicaDetalle(CInt(cmbTomas.SelectedValue), txtCodigoProducto.Text, 1, g_empresa, CInt(txtFisico.Text), CInt(cmbBodegas.SelectedValue), 1, 0, g_fechaTomaFisica) Then
                cls_FuncionesPrincipales.s_vaciarValoresNuevaFacturaCredito(tlpDatosDetalle)
                s_cargarDatosFisicoDetalle(CInt(cmbTomas.SelectedValue), g_usuario, CInt(cmbBodegas.SelectedValue), txtTop.Value)
                Me.txtCodigoProducto.Focus()
            End If
        Else
            MessageBox.Show("Algún dato importante falta, por favor verifique", "Datos importante", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        flogin.Show()
        Me.Dispose()
    End Sub

    Private Sub s_cargarDatosFisicoDetalle(_numeroToma As Integer, _usuario As String, _sucursal As Integer, _top As Integer)
        Try
            Me.CONSULTAR_TOMA_FISICATableAdapter.Fill(Me.VISTAS.CONSULTAR_TOMA_FISICA, g_empresa, _numeroToma, _usuario, _sucursal, _top, 2)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCodigoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigoProducto.Text = "" Or txtCodigoProducto.Text Is Nothing Then
                MessageBox.Show("Ingrese un [Código de Etiqueta Amarilla] o [Código Barra] ", "Campo vacio", MessageBoxButtons.OK)

            Else
                If cls_Data.f_consultarProducto(g_empresa, CInt(cmbBodegas.SelectedValue), "", txtCodigoProducto.Text, txtCodigoProducto, txtNombreProducto) Then
                    txtFisico.Focus()
                Else
                    MessageBox.Show("Ingrese un [Código de Etiqueta amarilla] o [CódigoBarra] correcto", "Código incorrecto", MessageBoxButtons.OK)

                End If

            End If
        End If
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim f As New frmReporte
        f.p_numero = CInt(cmbTomas.SelectedValue)
        f.p_usuario = g_usuario
        f.p_bodega = CInt(cmbBodegas.SelectedValue)
        f.ShowDialog()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If dgvTomaFisica.Rows.Count > 0 Then
            Try
                Dim valor As Integer = InputBox("Cantidad", "Modificación")
                If valor = 0 Then
                    MessageBox.Show("Ha ocurrido un error: No puede actualizar con cantidad cero (0)", "Seleccionar fila", MessageBoxButtons.OK)
                    Exit Sub
                End If

                Dim fila As DataGridViewRow = dgvTomaFisica.CurrentRow
                'If cls_Data.f_crudTomaFisicaDetalle(CInt(fila.Cells(7).Value), fila.Cells(8).Value, 1, 1, valor, CInt(fila.Cells(5).Value), 2, CInt(fila.Cells(12).Value)) Then
                If cls_Data.f_crudTomaFisicaDetalle(CInt(fila.Cells(7).Value), fila.Cells(8).Value, 1, g_empresa, valor, CInt(fila.Cells(5).Value), 2, CInt(fila.Cells(12).Value), g_fechaTomaFisica) Then
                    s_cargarDatosFisicoDetalle(CInt(cmbTomas.SelectedValue), g_usuario, CInt(cmbBodegas.SelectedValue), txtTop.Value)
                    Me.txtCodigoProducto.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error: " & ex.Message, "Seleccionar fila", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If dgvTomaFisica.Rows.Count > 0 Then
            Dim fila As DataGridViewRow = dgvTomaFisica.CurrentRow
            If cls_Data.f_crudTomaFisicaDetalle(CInt(fila.Cells(7).Value), fila.Cells(8).Value, 1, g_empresa, 0, CInt(fila.Cells(5).Value), 3, CInt(fila.Cells(12).Value), g_fechaTomaFisica) Then
                s_cargarDatosFisicoDetalle(CInt(cmbTomas.SelectedValue), g_usuario, CInt(cmbBodegas.SelectedValue), txtTop.Value)
                Me.txtCodigoProducto.Focus()
            End If
        End If
    End Sub

    Private Sub AdministrarTomasFísicasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New frmAdministracionTomasFisicas
        f.ShowDialog()
    End Sub

    Private Sub cmbBodegas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBodegas.SelectedValueChanged
        Me.FISICO_MAESTROTableAdapter.Fill(Me.VISTAS.FISICO_MAESTRO, g_empresa, cmbBodegas.SelectedValue, g_usuario)
        txtCodigoAlmacen.Text = cmbBodegas.SelectedValue
    End Sub

    Private Sub cmbTomas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTomas.SelectedValueChanged
        s_cargarDatosFisicoDetalle(cmbTomas.SelectedValue, g_usuario, cmbBodegas.SelectedValue, txtTop.Value)
        txtNumeroToma.Text = cmbTomas.SelectedValue
    End Sub

    Private Sub txtTop_ValueChanged(sender As Object, e As EventArgs) Handles txtTop.ValueChanged
        s_cargarDatosFisicoDetalle(cmbTomas.SelectedValue, g_usuario, cmbBodegas.SelectedValue, txtTop.Value)
    End Sub

    Private Sub DiferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New frmDiferenciasTomaFisica
        f.ShowDialog()
    End Sub

    Private Sub VariasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New frmImpresionVarias
        f.p_numero = CInt(cmbTomas.SelectedValue)
        f.p_usuario = g_usuario
        f.p_bodega = CInt(cmbBodegas.SelectedValue)
        f.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        flogin.Show()
        Me.Dispose()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub btnBuscarPosicion_Click(sender As Object, e As EventArgs) Handles btnBuscarPosicion.Click
        Dim contadoras As Integer = 0
        Try
            For Each d As DataGridViewRow In dgvTomaFisica.Rows
                'MessageBox.Show(d.Cells(12).Value.ToString)
                If d.Cells(12).Value.ToString = txtBuscarPosicion.Text Then
                    dgvTomaFisica.CurrentCell = dgvTomaFisica.Item(d.Cells(12).ColumnIndex, contadoras)
                    Exit For
                End If
                contadoras = contadoras + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        Dim f As New frmAdministracionTomasFisicas
        f.ShowDialog()
    End Sub
    Private Sub SeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionadasToolStripMenuItem.Click
        Dim f As New frmImpresionVarias
        f.p_numero = CInt(cmbTomas.SelectedValue)
        f.p_usuario = g_usuario
        f.p_bodega = CInt(cmbBodegas.SelectedValue)
        f.ShowDialog()
    End Sub


End Class
