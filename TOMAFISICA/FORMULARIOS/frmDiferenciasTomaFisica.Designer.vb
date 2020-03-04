<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiferenciasTomaFisica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiferenciasTomaFisica))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBodegas = New System.Windows.Forms.ComboBox()
        Me.BODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreAlmacen = New System.Windows.Forms.TextBox()
        Me.txtCodigoAlmacen = New System.Windows.Forms.TextBox()
        Me.cmbTipoDiferencia = New System.Windows.Forms.ComboBox()
        Me.TipoDiferenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDiferencias = New System.Windows.Forms.DataGridView()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionGeneralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SistemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FisicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSULTARDIFERENCIASTOMAFISICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDiferenciaTableAdapter = New TOMAFISICA.VISTASTableAdapters.TipoDiferenciaTableAdapter()
        Me.BODEGATableAdapter = New TOMAFISICA.VISTASTableAdapters.BODEGATableAdapter()
        Me.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter = New TOMAFISICA.VISTASTableAdapters.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDiferenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDiferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTARDIFERENCIASTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbBodegas, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombreAlmacen, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigoAlmacen, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTipoDiferencia, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(678, 68)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tipo"
        '
        'cmbBodegas
        '
        Me.cmbBodegas.DataSource = Me.BODEGABindingSource
        Me.cmbBodegas.DisplayMember = "Descripcion"
        Me.cmbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegas.Enabled = False
        Me.cmbBodegas.FormattingEnabled = True
        Me.cmbBodegas.Location = New System.Drawing.Point(104, 3)
        Me.cmbBodegas.Name = "cmbBodegas"
        Me.cmbBodegas.Size = New System.Drawing.Size(322, 21)
        Me.cmbBodegas.TabIndex = 2
        Me.cmbBodegas.ValueMember = "Codigo"
        '
        'BODEGABindingSource
        '
        Me.BODEGABindingSource.DataMember = "BODEGA"
        Me.BODEGABindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sucursal"
        '
        'txtNombreAlmacen
        '
        Me.txtNombreAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreAlmacen.Location = New System.Drawing.Point(432, 3)
        Me.txtNombreAlmacen.Name = "txtNombreAlmacen"
        Me.txtNombreAlmacen.ReadOnly = True
        Me.txtNombreAlmacen.Size = New System.Drawing.Size(123, 23)
        Me.txtNombreAlmacen.TabIndex = 3
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(57, 3)
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.ReadOnly = True
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(41, 23)
        Me.txtCodigoAlmacen.TabIndex = 6
        '
        'cmbTipoDiferencia
        '
        Me.cmbTipoDiferencia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbTipoDiferencia.DataSource = Me.TipoDiferenciaBindingSource
        Me.cmbTipoDiferencia.DisplayMember = "Descripcion"
        Me.cmbTipoDiferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDiferencia.FormattingEnabled = True
        Me.cmbTipoDiferencia.Location = New System.Drawing.Point(104, 38)
        Me.cmbTipoDiferencia.Name = "cmbTipoDiferencia"
        Me.cmbTipoDiferencia.Size = New System.Drawing.Size(199, 21)
        Me.cmbTipoDiferencia.TabIndex = 7
        Me.cmbTipoDiferencia.ValueMember = "Codigo"
        '
        'TipoDiferenciaBindingSource
        '
        Me.TipoDiferenciaBindingSource.DataMember = "TipoDiferencia"
        Me.TipoDiferenciaBindingSource.DataSource = Me.VISTAS
        '
        'dgvDiferencias
        '
        Me.dgvDiferencias.AllowUserToAddRows = False
        Me.dgvDiferencias.AllowUserToDeleteRows = False
        Me.dgvDiferencias.AutoGenerateColumns = False
        Me.dgvDiferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoDataGridViewTextBoxColumn, Me.DescripcionGeneralDataGridViewTextBoxColumn, Me.SistemaDataGridViewTextBoxColumn, Me.FisicoDataGridViewTextBoxColumn, Me.CostoPromedioDataGridViewTextBoxColumn, Me.DiferenciaDataGridViewTextBoxColumn})
        Me.dgvDiferencias.DataSource = Me.CONSULTARDIFERENCIASTOMAFISICABindingSource
        Me.dgvDiferencias.Location = New System.Drawing.Point(12, 86)
        Me.dgvDiferencias.Name = "dgvDiferencias"
        Me.dgvDiferencias.ReadOnly = True
        Me.dgvDiferencias.Size = New System.Drawing.Size(748, 579)
        Me.dgvDiferencias.TabIndex = 2
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 75
        '
        'DescripcionGeneralDataGridViewTextBoxColumn
        '
        Me.DescripcionGeneralDataGridViewTextBoxColumn.DataPropertyName = "Descripcion General"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.Name = "DescripcionGeneralDataGridViewTextBoxColumn"
        Me.DescripcionGeneralDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionGeneralDataGridViewTextBoxColumn.Width = 250
        '
        'SistemaDataGridViewTextBoxColumn
        '
        Me.SistemaDataGridViewTextBoxColumn.DataPropertyName = "Sistema"
        Me.SistemaDataGridViewTextBoxColumn.HeaderText = "Sistema"
        Me.SistemaDataGridViewTextBoxColumn.Name = "SistemaDataGridViewTextBoxColumn"
        Me.SistemaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SistemaDataGridViewTextBoxColumn.Width = 75
        '
        'FisicoDataGridViewTextBoxColumn
        '
        Me.FisicoDataGridViewTextBoxColumn.DataPropertyName = "Fisico"
        Me.FisicoDataGridViewTextBoxColumn.HeaderText = "Fisico"
        Me.FisicoDataGridViewTextBoxColumn.Name = "FisicoDataGridViewTextBoxColumn"
        Me.FisicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FisicoDataGridViewTextBoxColumn.Width = 75
        '
        'CostoPromedioDataGridViewTextBoxColumn
        '
        Me.CostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "Costo Promedio"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio"
        Me.CostoPromedioDataGridViewTextBoxColumn.Name = "CostoPromedioDataGridViewTextBoxColumn"
        Me.CostoPromedioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiferenciaDataGridViewTextBoxColumn
        '
        Me.DiferenciaDataGridViewTextBoxColumn.DataPropertyName = "Diferencia"
        DataGridViewCellStyle2.Format = "n0"
        Me.DiferenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DiferenciaDataGridViewTextBoxColumn.HeaderText = "Diferencia"
        Me.DiferenciaDataGridViewTextBoxColumn.Name = "DiferenciaDataGridViewTextBoxColumn"
        Me.DiferenciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONSULTARDIFERENCIASTOMAFISICABindingSource
        '
        Me.CONSULTARDIFERENCIASTOMAFISICABindingSource.DataMember = "CONSULTAR DIFERENCIAS TOMA FISICA"
        Me.CONSULTARDIFERENCIASTOMAFISICABindingSource.DataSource = Me.VISTAS
        '
        'TipoDiferenciaTableAdapter
        '
        Me.TipoDiferenciaTableAdapter.ClearBeforeFill = True
        '
        'BODEGATableAdapter
        '
        Me.BODEGATableAdapter.ClearBeforeFill = True
        '
        'CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter
        '
        Me.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter.ClearBeforeFill = True
        '
        'frmDiferenciasTomaFisica
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 677)
        Me.Controls.Add(Me.dgvDiferencias)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiferenciasTomaFisica"
        Me.Text = "Diferencias Toma Fisica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDiferenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDiferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTARDIFERENCIASTOMAFISICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cmbBodegas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreAlmacen As TextBox
    Friend WithEvents txtCodigoAlmacen As TextBox
    Friend WithEvents dgvDiferencias As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTipoDiferencia As ComboBox
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents TipoDiferenciaBindingSource As BindingSource
    Friend WithEvents TipoDiferenciaTableAdapter As VISTASTableAdapters.TipoDiferenciaTableAdapter
    Friend WithEvents BODEGABindingSource As BindingSource
    Friend WithEvents BODEGATableAdapter As VISTASTableAdapters.BODEGATableAdapter
    Friend WithEvents CONSULTARDIFERENCIASTOMAFISICABindingSource As BindingSource
    Friend WithEvents CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter As VISTASTableAdapters.CONSULTAR_DIFERENCIAS_TOMA_FISICATableAdapter
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionGeneralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SistemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FisicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoPromedioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
