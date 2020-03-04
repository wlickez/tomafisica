<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusquedaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusquedaProducto))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusquedaProducto = New System.Windows.Forms.TextBox()
        Me.dgvDatosProducto = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionGeneralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisponibleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AfectaExistenciaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter = New TOMAFISICA.VISTASTableAdapters.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvDatosProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.41467!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.19918!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38614!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnConsultar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBusquedaProducto, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 29)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(675, 46)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(445, 7)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(45, 32)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar por"
        '
        'txtBusquedaProducto
        '
        Me.txtBusquedaProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusquedaProducto.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusquedaProducto.Location = New System.Drawing.Point(154, 7)
        Me.txtBusquedaProducto.Name = "txtBusquedaProducto"
        Me.txtBusquedaProducto.Size = New System.Drawing.Size(285, 32)
        Me.txtBusquedaProducto.TabIndex = 0
        '
        'dgvDatosProducto
        '
        Me.dgvDatosProducto.AccessibleName = "dgvListadoProductosBuscados"
        Me.dgvDatosProducto.AllowUserToAddRows = False
        Me.dgvDatosProducto.AllowUserToDeleteRows = False
        Me.dgvDatosProducto.AutoGenerateColumns = False
        Me.dgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionGeneralDataGridViewTextBoxColumn, Me.CasaDataGridViewTextBoxColumn, Me.DisponibleDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.AfectaExistenciaDataGridViewCheckBoxColumn})
        Me.dgvDatosProducto.DataSource = Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource
        Me.dgvDatosProducto.Location = New System.Drawing.Point(12, 81)
        Me.dgvDatosProducto.Name = "dgvDatosProducto"
        Me.dgvDatosProducto.ReadOnly = True
        Me.dgvDatosProducto.Size = New System.Drawing.Size(689, 308)
        Me.dgvDatosProducto.TabIndex = 3
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 65
        '
        'DescripcionGeneralDataGridViewTextBoxColumn
        '
        Me.DescripcionGeneralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionGeneralDataGridViewTextBoxColumn.DataPropertyName = "Descripcion General"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.HeaderText = "Descripcion General"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.Name = "DescripcionGeneralDataGridViewTextBoxColumn"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CasaDataGridViewTextBoxColumn
        '
        Me.CasaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CasaDataGridViewTextBoxColumn.DataPropertyName = "Casa"
        Me.CasaDataGridViewTextBoxColumn.HeaderText = "Casa"
        Me.CasaDataGridViewTextBoxColumn.Name = "CasaDataGridViewTextBoxColumn"
        Me.CasaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DisponibleDataGridViewTextBoxColumn
        '
        Me.DisponibleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DisponibleDataGridViewTextBoxColumn.DataPropertyName = "Disponible"
        Me.DisponibleDataGridViewTextBoxColumn.HeaderText = "Disponible"
        Me.DisponibleDataGridViewTextBoxColumn.Name = "DisponibleDataGridViewTextBoxColumn"
        Me.DisponibleDataGridViewTextBoxColumn.ReadOnly = True
        Me.DisponibleDataGridViewTextBoxColumn.Width = 81
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 62
        '
        'AfectaExistenciaDataGridViewCheckBoxColumn
        '
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.DataPropertyName = "Afecta Existencia"
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.HeaderText = "Afecta Existencia"
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.Name = "AfectaExistenciaDataGridViewCheckBoxColumn"
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AfectaExistenciaDataGridViewCheckBoxColumn.Visible = False
        '
        'CONSULTARPRODUCTOSEXISTENCIASBindingSource
        '
        Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource.DataMember = "CONSULTAR PRODUCTOS EXISTENCIAS"
        Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter
        '
        Me.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'frmBusquedaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 403)
        Me.Controls.Add(Me.dgvDatosProducto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBusquedaProducto"
        Me.Text = "Búsqueda de Producto"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvDatosProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARPRODUCTOSEXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBusquedaProducto As TextBox
    Friend WithEvents dgvDatosProducto As DataGridView
    Friend WithEvents CONSULTARPRODUCTOSEXISTENCIASBindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter As VISTASTableAdapters.CONSULTAR_PRODUCTOS_EXISTENCIASTableAdapter
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionGeneralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisponibleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AfectaExistenciaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
