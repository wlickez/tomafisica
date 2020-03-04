Imports System.ComponentModel.ComponentResourceManager
Public Class cls_FuncionesPrincipales
    Public Shared Sub s_keyDownFormulariosFacturacion(_sender As Object, _e As KeyEventArgs, _formulario As Form, _txtCodigoProducto As TextBox, _txtNombreProducto As TextBox, _sucursal As Integer, _dgv As DataGridView)
        If _e.KeyCode = Keys.Escape Then
            _formulario.Dispose()
        ElseIf _e.KeyCode = Keys.F3 Then
            Dim f As New frmBusquedaProducto
            f.p_sucursal = _sucursal
            f.p_txtCodigoProducto = _txtCodigoProducto
            f.p_txtNombreProducto = _txtNombreProducto
            f.ShowDialog()
        ElseIf _e.KeyCode = Keys.F6 Then
            Dim c As New cls_Imprimir
            c.s_imprimirTicket(_dgv)
        End If
    End Sub
    Public Shared Sub s_enviarObjetosParaBusqueda(_frm As Form, _txtCodigoProducto As TextBox, _txtNombreProducto As TextBox, _sucursal As Integer)
        Dim f As New frmBusquedaProducto
        f.p_sucursal = _sucursal
        f.p_txtCodigoProducto = _txtCodigoProducto
        f.p_txtNombreProducto = _txtNombreProducto
        f.ShowDialog()
    End Sub

    Public Shared Sub s_digitarCantidadesEnteras(_e As KeyPressEventArgs, _sender As Object)
        _e.Handled = Not IsNumeric(_e.KeyChar) And Not Char.IsControl(_e.KeyChar)
    End Sub


    Public Shared Sub s_vaciarValoresNuevaFacturaCredito(_tablaContenedoraMontos As TableLayoutPanel)
        Try

            For Each control1 As Control In _tablaContenedoraMontos.Controls
                If TypeOf control1 Is TextBox Then
                    control1.Text = ""
                End If
            Next
        Catch ex As Exception
            Dim st As New System.Diagnostics.StackTrace()

            MsgBox(ex.Message, vbCritical, "Facturación")
        End Try
    End Sub
    Public Shared Sub f_devolverVersion(_frm As Form)
        _frm.Text = _frm.Text & " /" & g_usuario & " v" & My.Application.Info.Version.ToString
        Dim c As New ComponentModel.ComponentResourceManager
        _frm.Icon = c.GetObject("toma_fisica.icon")
    End Sub

End Class
