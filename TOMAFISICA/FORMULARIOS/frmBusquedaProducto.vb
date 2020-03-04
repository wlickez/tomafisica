
Public Class frmBusquedaProducto
    Public p_sucursal As Integer
    Public p_txtCodigoProducto As TextBox
    Public p_txtNombreProducto As TextBox
    Private Sub fmrBusquedaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cls_FuncionesPrincipales.f_devolverVersion(Me)
            txtBusquedaProducto.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If txtBusquedaProducto.Text <> "" Or txtBusquedaProducto.Text <> Nothing Then
                Me.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter.CONSULTAREXISTENCIAS(Me.VISTAS.CONSULTAR_PRODUCTOS_EXISTENCIAS, g_empresa, p_sucursal, txtBusquedaProducto.Text, "")
                If dgvDatosProducto.RowCount > 0 Then
                    dgvDatosProducto.Focus()
                End If
            Else
                txtBusquedaProducto.Focus()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmBusquedaProducto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub txtBusquedaProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusquedaProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsultar_Click(sender, e)
        End If
    End Sub


    Private Sub dgvDatosProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvDatosProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvDatosProducto.Rows.Count > 0 Then
                Try
                    p_txtCodigoProducto.Text = CStr(dgvDatosProducto.CurrentRow.Cells(0).Value)
                    p_txtNombreProducto.Text = CStr(dgvDatosProducto.CurrentRow.Cells(1).Value)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    Me.Dispose()
                End Try


            End If
        End If
    End Sub

    Private Sub dgvDatosProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatosProducto.CellDoubleClick
        If dgvDatosProducto.Rows.Count > 0 Then
            Try
                p_txtCodigoProducto.Text = CStr(dgvDatosProducto.CurrentRow.Cells(0).Value)
                p_txtNombreProducto.Text = CStr(dgvDatosProducto.CurrentRow.Cells(1).Value)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.Dispose()
            End Try


        End If
    End Sub

End Class