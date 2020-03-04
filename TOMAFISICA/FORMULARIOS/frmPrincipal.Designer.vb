<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.dgvTomaFisica = New System.Windows.Forms.DataGridView()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAnulacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTARTOMAFISICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.tlpDatosDetalle = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.txtTop = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Físico = New System.Windows.Forms.Label()
        Me.txtFisico = New System.Windows.Forms.TextBox()
        Me.BODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FISICOMAESTROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.menucontextoDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTAR_TOMA_FISICATableAdapter = New TOMAFISICA.VISTASTableAdapters.CONSULTAR_TOMA_FISICATableAdapter()
        Me.FISICO_MAESTROTableAdapter = New TOMAFISICA.VISTASTableAdapters.FISICO_MAESTROTableAdapter()
        Me.BODEGATableAdapter = New TOMAFISICA.VISTASTableAdapters.BODEGATableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.txtObservacionesTomaFisica = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBodegas = New System.Windows.Forms.ComboBox()
        Me.cmbTomas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreAlmacen = New System.Windows.Forms.TextBox()
        Me.txtNumeroToma = New System.Windows.Forms.TextBox()
        Me.txtCodigoAlmacen = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MenuStripPrincipal = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiferenciasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBuscarPosicion = New System.Windows.Forms.TextBox()
        Me.btnBuscarPosicion = New System.Windows.Forms.Button()
        CType(Me.dgvTomaFisica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDatosDetalle.SuspendLayout()
        CType(Me.txtTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menucontextoDGV.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStripPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTomaFisica
        '
        Me.dgvTomaFisica.AllowUserToAddRows = False
        Me.dgvTomaFisica.AllowUserToDeleteRows = False
        Me.dgvTomaFisica.AllowUserToResizeColumns = False
        Me.dgvTomaFisica.AllowUserToResizeRows = False
        Me.dgvTomaFisica.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dgvTomaFisica.AutoGenerateColumns = False
        Me.dgvTomaFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTomaFisica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.FechaAnulacionDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.DBodegaDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.PosicionDataGridViewTextBoxColumn})
        Me.dgvTomaFisica.DataSource = Me.CONSULTARTOMAFISICABindingSource
        Me.dgvTomaFisica.Location = New System.Drawing.Point(12, 178)
        Me.dgvTomaFisica.Name = "dgvTomaFisica"
        Me.dgvTomaFisica.ReadOnly = True
        Me.dgvTomaFisica.Size = New System.Drawing.Size(713, 445)
        Me.dgvTomaFisica.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.dgvTomaFisica, "Detalle de la toma física por sección")
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'FechaAnulacionDataGridViewTextBoxColumn
        '
        Me.FechaAnulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.HeaderText = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.Name = "FechaAnulacionDataGridViewTextBoxColumn"
        Me.FechaAnulacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAnulacionDataGridViewTextBoxColumn.Visible = False
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Visible = False
        '
        'DBodegaDataGridViewTextBoxColumn
        '
        Me.DBodegaDataGridViewTextBoxColumn.DataPropertyName = "DBodega"
        Me.DBodegaDataGridViewTextBoxColumn.HeaderText = "DBodega"
        Me.DBodegaDataGridViewTextBoxColumn.Name = "DBodegaDataGridViewTextBoxColumn"
        Me.DBodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DBodegaDataGridViewTextBoxColumn.Visible = False
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "No."
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 40
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 75
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn.Width = 75
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 75
        '
        'PosicionDataGridViewTextBoxColumn
        '
        Me.PosicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        Me.PosicionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PosicionDataGridViewTextBoxColumn.HeaderText = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.Name = "PosicionDataGridViewTextBoxColumn"
        Me.PosicionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PosicionDataGridViewTextBoxColumn.Width = 75
        '
        'CONSULTARTOMAFISICABindingSource
        '
        Me.CONSULTARTOMAFISICABindingSource.DataMember = "CONSULTAR TOMA FISICA"
        Me.CONSULTARTOMAFISICABindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(544, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 28)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Puede presionar también F3")
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tlpDatosDetalle
        '
        Me.tlpDatosDetalle.ColumnCount = 5
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.Controls.Add(Me.btnAgregarDetalle, 3, 1)
        Me.tlpDatosDetalle.Controls.Add(Me.txtTop, 4, 1)
        Me.tlpDatosDetalle.Controls.Add(Me.btnAgregar, 3, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.Label3, 0, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.txtCodigoProducto, 1, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.txtNombreProducto, 2, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.Físico, 0, 1)
        Me.tlpDatosDetalle.Controls.Add(Me.txtFisico, 1, 1)
        Me.tlpDatosDetalle.Location = New System.Drawing.Point(12, 105)
        Me.tlpDatosDetalle.Name = "tlpDatosDetalle"
        Me.tlpDatosDetalle.RowCount = 2
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatosDetalle.Size = New System.Drawing.Size(686, 67)
        Me.tlpDatosDetalle.TabIndex = 1
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(544, 37)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(73, 28)
        Me.btnAgregarDetalle.TabIndex = 6
        Me.btnAgregarDetalle.Text = "Agregar"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'txtTop
        '
        Me.txtTop.Location = New System.Drawing.Point(623, 37)
        Me.txtTop.Maximum = New Decimal(New Integer() {700, 0, 0, 0})
        Me.txtTop.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(56, 20)
        Me.txtTop.TabIndex = 4
        Me.txtTop.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Producto"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(59, 3)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(104, 23)
        Me.txtCodigoProducto.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtCodigoProducto, "Presione Enter para confirmar búsqueda")
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(169, 3)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.ReadOnly = True
        Me.txtNombreProducto.Size = New System.Drawing.Size(369, 23)
        Me.txtNombreProducto.TabIndex = 2
        '
        'Físico
        '
        Me.Físico.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Físico.AutoSize = True
        Me.Físico.Location = New System.Drawing.Point(3, 44)
        Me.Físico.Name = "Físico"
        Me.Físico.Size = New System.Drawing.Size(36, 13)
        Me.Físico.TabIndex = 4
        Me.Físico.Text = "Físico"
        '
        'txtFisico
        '
        Me.txtFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFisico.Location = New System.Drawing.Point(59, 37)
        Me.txtFisico.MaxLength = 5
        Me.txtFisico.Name = "txtFisico"
        Me.txtFisico.Size = New System.Drawing.Size(104, 23)
        Me.txtFisico.TabIndex = 5
        '
        'BODEGABindingSource
        '
        Me.BODEGABindingSource.DataMember = "BODEGA"
        Me.BODEGABindingSource.DataSource = Me.VISTAS
        '
        'FISICOMAESTROBindingSource
        '
        Me.FISICOMAESTROBindingSource.DataMember = "FISICO MAESTRO"
        Me.FISICOMAESTROBindingSource.DataSource = Me.VISTAS
        '
        'menucontextoDGV
        '
        Me.menucontextoDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.menucontextoDGV.Name = "ContextMenuStrip1"
        Me.menucontextoDGV.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'CONSULTAR_TOMA_FISICATableAdapter
        '
        Me.CONSULTAR_TOMA_FISICATableAdapter.ClearBeforeFill = True
        '
        'FISICO_MAESTROTableAdapter
        '
        Me.FISICO_MAESTROTableAdapter.ClearBeforeFill = True
        '
        'BODEGATableAdapter
        '
        Me.BODEGATableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnReporte, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtObservacionesTomaFisica, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbBodegas, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTomas, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombreAlmacen, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumeroToma, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigoAlmacen, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(678, 68)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnReporte
        '
        Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnReporte.Location = New System.Drawing.Point(567, 3)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(73, 28)
        Me.btnReporte.TabIndex = 4
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'txtObservacionesTomaFisica
        '
        Me.txtObservacionesTomaFisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesTomaFisica.Location = New System.Drawing.Point(438, 37)
        Me.txtObservacionesTomaFisica.Name = "txtObservacionesTomaFisica"
        Me.txtObservacionesTomaFisica.ReadOnly = True
        Me.txtObservacionesTomaFisica.Size = New System.Drawing.Size(123, 23)
        Me.txtObservacionesTomaFisica.TabIndex = 8
        Me.txtObservacionesTomaFisica.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No. Toma"
        '
        'cmbBodegas
        '
        Me.cmbBodegas.DataSource = Me.BODEGABindingSource
        Me.cmbBodegas.DisplayMember = "Descripcion"
        Me.cmbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegas.Enabled = False
        Me.cmbBodegas.FormattingEnabled = True
        Me.cmbBodegas.Location = New System.Drawing.Point(110, 3)
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.Size = New System.Drawing.Size(322, 21)
        Me.cmbBodegas.TabIndex = 2
        Me.cmbBodegas.ValueMember = "Codigo"
        '
        'cmbTomas
        '
        Me.cmbTomas.DataSource = Me.FISICOMAESTROBindingSource
        Me.cmbTomas.DisplayMember = "Observaciones"
        Me.cmbTomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTomas.FormattingEnabled = True
        Me.cmbTomas.Location = New System.Drawing.Point(110, 37)
        Me.cmbTomas.Name = "cmbTomas"
        Me.cmbTomas.Size = New System.Drawing.Size(322, 21)
        Me.cmbTomas.TabIndex = 7
        Me.cmbTomas.ValueMember = "Numero"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sucursal"
        '
        'txtNombreAlmacen
        '
        Me.txtNombreAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAlmacen.Location = New System.Drawing.Point(438, 3)
        Me.txtNombreAlmacen.Name = "txtNombreAlmacen"
        Me.txtNombreAlmacen.ReadOnly = True
        Me.txtNombreAlmacen.Size = New System.Drawing.Size(123, 23)
        Me.txtNombreAlmacen.TabIndex = 3
        Me.txtNombreAlmacen.Visible = False
        '
        'txtNumeroToma
        '
        Me.txtNumeroToma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroToma.Location = New System.Drawing.Point(63, 37)
        Me.txtNumeroToma.Name = "txtNumeroToma"
        Me.txtNumeroToma.ReadOnly = True
        Me.txtNumeroToma.Size = New System.Drawing.Size(41, 23)
        Me.txtNumeroToma.TabIndex = 1
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(63, 3)
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.ReadOnly = True
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(41, 23)
        Me.txtCodigoAlmacen.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(123, 23)
        Me.TextBox1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BODEGABindingSource
        Me.ComboBox1.DisplayMember = "Descripcion"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(63, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(322, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "Codigo"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.FISICOMAESTROBindingSource
        Me.ComboBox2.DisplayMember = "Observaciones"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(63, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(322, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.ValueMember = "Numero"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(391, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(123, 23)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(63, 37)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(41, 23)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(63, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(41, 23)
        Me.TextBox4.TabIndex = 6
        '
        'MenuStripPrincipal
        '
        Me.MenuStripPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AdministrarToolStripMenuItem, Me.DiferenciasToolStripMenuItem1, Me.ImprimirToolStripMenuItem1})
        Me.MenuStripPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPrincipal.Name = "MenuStripPrincipal"
        Me.MenuStripPrincipal.Size = New System.Drawing.Size(769, 24)
        Me.MenuStripPrincipal.TabIndex = 5
        Me.MenuStripPrincipal.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Tag = "0"
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Tag = "0"
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AdministrarToolStripMenuItem.Tag = "1"
        Me.AdministrarToolStripMenuItem.Text = "Administrar"
        Me.AdministrarToolStripMenuItem.Visible = False
        '
        'DiferenciasToolStripMenuItem1
        '
        Me.DiferenciasToolStripMenuItem1.Name = "DiferenciasToolStripMenuItem1"
        Me.DiferenciasToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.DiferenciasToolStripMenuItem1.Tag = "1"
        Me.DiferenciasToolStripMenuItem1.Text = "Diferencias"
        Me.DiferenciasToolStripMenuItem1.Visible = False
        '
        'ImprimirToolStripMenuItem1
        '
        Me.ImprimirToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodasToolStripMenuItem, Me.SeleccionadasToolStripMenuItem})
        Me.ImprimirToolStripMenuItem1.Name = "ImprimirToolStripMenuItem1"
        Me.ImprimirToolStripMenuItem1.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem1.Tag = "1"
        Me.ImprimirToolStripMenuItem1.Text = "Imprimir"
        Me.ImprimirToolStripMenuItem1.Visible = False
        '
        'TodasToolStripMenuItem
        '
        Me.TodasToolStripMenuItem.Name = "TodasToolStripMenuItem"
        Me.TodasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TodasToolStripMenuItem.Text = "Todas"
        '
        'SeleccionadasToolStripMenuItem
        '
        Me.SeleccionadasToolStripMenuItem.Name = "SeleccionadasToolStripMenuItem"
        Me.SeleccionadasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SeleccionadasToolStripMenuItem.Text = "Seleccionadas"
        '
        'txtBuscarPosicion
        '
        Me.txtBuscarPosicion.Location = New System.Drawing.Point(731, 178)
        Me.txtBuscarPosicion.Name = "txtBuscarPosicion"
        Me.txtBuscarPosicion.Size = New System.Drawing.Size(26, 20)
        Me.txtBuscarPosicion.TabIndex = 6
        Me.txtBuscarPosicion.Visible = False
        '
        'btnBuscarPosicion
        '
        Me.btnBuscarPosicion.Location = New System.Drawing.Point(731, 204)
        Me.btnBuscarPosicion.Name = "btnBuscarPosicion"
        Me.btnBuscarPosicion.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscarPosicion.TabIndex = 7
        Me.btnBuscarPosicion.Text = "Ir"
        Me.btnBuscarPosicion.UseVisualStyleBackColor = True
        Me.btnBuscarPosicion.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 627)
        Me.Controls.Add(Me.btnBuscarPosicion)
        Me.Controls.Add(Me.txtBuscarPosicion)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.tlpDatosDetalle)
        Me.Controls.Add(Me.dgvTomaFisica)
        Me.Controls.Add(Me.MenuStripPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        CType(Me.dgvTomaFisica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDatosDetalle.ResumeLayout(False)
        Me.tlpDatosDetalle.PerformLayout()
        CType(Me.txtTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menucontextoDGV.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStripPrincipal.ResumeLayout(False)
        Me.MenuStripPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTomaFisica As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents tlpDatosDetalle As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents Físico As Label
    Friend WithEvents txtFisico As TextBox
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents PosicionFisicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONSULTARTOMAFISICABindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents CONSULTAR_TOMA_FISICATableAdapter As VISTASTableAdapters.CONSULTAR_TOMA_FISICATableAdapter
    Friend WithEvents menucontextoDGV As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAnulacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DBodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FISICOMAESTROBindingSource As BindingSource
    Friend WithEvents FISICO_MAESTROTableAdapter As VISTASTableAdapters.FISICO_MAESTROTableAdapter
    Friend WithEvents BODEGABindingSource As BindingSource
    Friend WithEvents BODEGATableAdapter As VISTASTableAdapters.BODEGATableAdapter
    Friend WithEvents txtTop As NumericUpDown
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnReporte As Button
    Friend WithEvents txtObservacionesTomaFisica As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbBodegas As ComboBox
    Friend WithEvents cmbTomas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreAlmacen As TextBox
    Friend WithEvents txtNumeroToma As TextBox
    Friend WithEvents txtCodigoAlmacen As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents MenuStripPrincipal As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtBuscarPosicion As TextBox
    Friend WithEvents btnBuscarPosicion As Button
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiferenciasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionadasToolStripMenuItem As ToolStripMenuItem
End Class
