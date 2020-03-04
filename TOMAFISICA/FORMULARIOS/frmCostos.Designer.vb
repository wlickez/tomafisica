<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCostos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostos))
        Me.dgvCostos = New System.Windows.Forms.DataGridView()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.tlpDatosDetalle = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.bntConsultarCostos = New System.Windows.Forms.Button()
        Me.cmsMenuDgv = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.COSTOSTableAdapter = New TOMAFISICA.VISTASTableAdapters.COSTOSTableAdapter()
        CType(Me.dgvCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COSTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDatosDetalle.SuspendLayout()
        Me.cmsMenuDgv.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCostos
        '
        Me.dgvCostos.AllowUserToAddRows = False
        Me.dgvCostos.AutoGenerateColumns = False
        Me.dgvCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCostos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BodegaDataGridViewTextBoxColumn, Me.SucursalDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.Disponible})
        Me.dgvCostos.DataSource = Me.COSTOSBindingSource
        Me.dgvCostos.Location = New System.Drawing.Point(13, 37)
        Me.dgvCostos.Name = "dgvCostos"
        Me.dgvCostos.Size = New System.Drawing.Size(877, 682)
        Me.dgvCostos.TabIndex = 0
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.Width = 65
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.Width = 150
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.Width = 65
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre Producto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        Me.NombreProductoDataGridViewTextBoxColumn.Width = 350
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "Costo Promedio"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        '
        'Disponible
        '
        Me.Disponible.DataPropertyName = "Disponible"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Disponible.DefaultCellStyle = DataGridViewCellStyle2
        Me.Disponible.HeaderText = "Disponible"
        Me.Disponible.Name = "Disponible"
        '
        'COSTOSBindingSource
        '
        Me.COSTOSBindingSource.DataMember = "COSTOS"
        Me.COSTOSBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tlpDatosDetalle
        '
        Me.tlpDatosDetalle.ColumnCount = 6
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.tlpDatosDetalle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpDatosDetalle.Controls.Add(Me.btnAgregar, 3, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.Label3, 0, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.txtCodigoProducto, 1, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.txtNombreProducto, 2, 0)
        Me.tlpDatosDetalle.Controls.Add(Me.bntConsultarCostos, 4, 0)
        Me.tlpDatosDetalle.Location = New System.Drawing.Point(13, 2)
        Me.tlpDatosDetalle.Name = "tlpDatosDetalle"
        Me.tlpDatosDetalle.RowCount = 1
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpDatosDetalle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpDatosDetalle.Size = New System.Drawing.Size(810, 33)
        Me.tlpDatosDetalle.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(556, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 28)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Buscar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Producto"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(71, 3)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(104, 23)
        Me.txtCodigoProducto.TabIndex = 1
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(181, 3)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.ReadOnly = True
        Me.txtNombreProducto.Size = New System.Drawing.Size(369, 23)
        Me.txtNombreProducto.TabIndex = 2
        '
        'bntConsultarCostos
        '
        Me.bntConsultarCostos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntConsultarCostos.Location = New System.Drawing.Point(635, 3)
        Me.bntConsultarCostos.Name = "bntConsultarCostos"
        Me.bntConsultarCostos.Size = New System.Drawing.Size(72, 28)
        Me.bntConsultarCostos.TabIndex = 6
        Me.bntConsultarCostos.Text = "Costos"
        Me.bntConsultarCostos.UseVisualStyleBackColor = True
        '
        'cmsMenuDgv
        '
        Me.cmsMenuDgv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEditar})
        Me.cmsMenuDgv.Name = "ContextMenuStrip1"
        Me.cmsMenuDgv.Size = New System.Drawing.Size(105, 26)
        '
        'tsmEditar
        '
        Me.tsmEditar.Name = "tsmEditar"
        Me.tsmEditar.Size = New System.Drawing.Size(104, 22)
        Me.tsmEditar.Text = "Editar"
        '
        'COSTOSTableAdapter
        '
        Me.COSTOSTableAdapter.ClearBeforeFill = True
        '
        'frmCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 731)
        Me.Controls.Add(Me.tlpDatosDetalle)
        Me.Controls.Add(Me.dgvCostos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCostos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Administración de Costos"
        CType(Me.dgvCostos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COSTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDatosDetalle.ResumeLayout(False)
        Me.tlpDatosDetalle.PerformLayout()
        Me.cmsMenuDgv.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCostos As DataGridView
    Friend WithEvents COSTOSBindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents COSTOSTableAdapter As VISTASTableAdapters.COSTOSTableAdapter
    Friend WithEvents tlpDatosDetalle As TableLayoutPanel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents bntConsultarCostos As Button
    Friend WithEvents cmsMenuDgv As ContextMenuStrip
    Friend WithEvents tsmEditar As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Disponible As DataGridViewTextBoxColumn
End Class
