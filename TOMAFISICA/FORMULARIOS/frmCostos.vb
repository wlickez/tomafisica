Public Class frmCostos
    Public flogin As Form
    Private Sub s_consultaCostos(_codigoProducto As String)
        If String.IsNullOrEmpty(_codigoProducto) Then
            MessageBox.Show("No puede hacer búsquedas sin campos vacios")
            txtCodigoProducto.Focus()
        Else
            Me.COSTOSTableAdapter.Fill(Me.VISTAS.COSTOS, _codigoProducto, g_empresa)
            For Each f As DataGridViewRow In dgvCostos.Rows
                If CInt(f.Cells(4).Value <= 0) Then
                    f.DefaultCellStyle.BackColor = Color.LightGray
                    'For Each c As DataGridViewCell In f.Cells
                    '    c.Style.BackColor = Color.AliceBlue
                    'Next
                End If
            Next
        End If
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cls_FuncionesPrincipales.s_enviarObjetosParaBusqueda(Me, txtCodigoProducto, txtNombreProducto, 1)
        If txtCodigoProducto.Text <> "" Then
            txtCodigoProducto.Focus()
        End If
    End Sub

    Private Sub bntConsultarCostos_Click(sender As Object, e As EventArgs) Handles bntConsultarCostos.Click
        s_consultaCostos(txtCodigoProducto.Text)
    End Sub
    Private Sub txtCodigoProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigoProducto.Text = "" Or txtCodigoProducto.Text Is Nothing Then
                MessageBox.Show("Ingrese un [Código de Etiqueta Amarilla] o [Código Barra] ", "Campo vacio", MessageBoxButtons.OK)
            Else
                If cls_Data.f_consultarProducto(g_empresa, 1, "", txtCodigoProducto.Text, txtCodigoProducto, txtNombreProducto) Then
                    txtCodigoProducto.Focus()
                Else
                    MessageBox.Show("Ingrese un [Código de Etiqueta amarilla] o [CódigoBarra] correcto", "Código incorrecto", MessageBoxButtons.OK)
                End If

            End If
        End If
    End Sub
    Private Sub txtCodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoProducto.KeyPress
        cls_FuncionesPrincipales.s_digitarCantidadesEnteras(e, sender)
    End Sub

    Private Sub frmCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls_FuncionesPrincipales.f_devolverVersion(Me)
        Me.dgvCostos.ContextMenuStrip = Me.cmsMenuDgv

    End Sub

    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If dgvCostos.Rows.Count > 0 Then
            Try
                Dim valor As Double = InputBox("Costo nuevo", "Modificación")
                If valor <= 0 Then
                    MessageBox.Show("Ha ocurrido un error: No puede actualizar con cantidad cero (0)", "Seleccionar fila", MessageBoxButtons.OK)
                    Exit Sub
                End If
                Dim fila As DataGridViewRow = dgvCostos.CurrentRow
                If cls_Data.f_crudCostos(CStr(fila.Cells(2).Value), CInt(fila.Cells(0).Value), valor, 2) Then
                    s_consultaCostos(txtCodigoProducto.Text)
                    txtCodigoProducto.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ColorPickEdit1_ColorChanged(sender As Object, e As EventArgs)
        s_consultaCostos(txtCodigoProducto.Text)
    End Sub
    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        flogin.Show()
        Me.Dispose()
    End Sub
End Class