<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImpresionVarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImpresionVarias))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.txtObservacionesTomaFisica = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTomas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreAlmacen = New System.Windows.Forms.TextBox()
        Me.txtNumeroToma = New System.Windows.Forms.TextBox()
        Me.txtCodigoAlmacen = New System.Windows.Forms.TextBox()
        Me.cmbBodegas = New System.Windows.Forms.ComboBox()
        Me.BODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.BODEGATableAdapter = New TOMAFISICA.VISTASTableAdapters.BODEGATableAdapter()
        Me.dgvTomasFisicas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAnulacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FISICOMAESTROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FISICO_MAESTROTableAdapter = New TOMAFISICA.VISTASTableAdapters.FISICO_MAESTROTableAdapter()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTomasFisicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTomas, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNombreAlmacen, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNumeroToma, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCodigoAlmacen, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbBodegas, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(678, 68)
        Me.TableLayoutPanel1.TabIndex = 1
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
        Me.Label1.Visible = False
        '
        'cmbTomas
        '
        Me.cmbTomas.DisplayMember = "Observaciones"
        Me.cmbTomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTomas.FormattingEnabled = True
        Me.cmbTomas.Location = New System.Drawing.Point(110, 37)
        Me.cmbTomas.Name = "cmbTomas"
        Me.cmbTomas.Size = New System.Drawing.Size(322, 21)
        Me.cmbTomas.TabIndex = 7
        Me.cmbTomas.ValueMember = "Numero"
        Me.cmbTomas.Visible = False
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
        Me.txtNumeroToma.Visible = False
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
        'cmbBodegas
        '
        Me.cmbBodegas.DataSource = Me.BODEGABindingSource
        Me.cmbBodegas.DisplayMember = "Descripcion"
        Me.cmbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBodegas.FormattingEnabled = True
        Me.cmbBodegas.Location = New System.Drawing.Point(110, 3)
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
        'BODEGATableAdapter
        '
        Me.BODEGATableAdapter.ClearBeforeFill = True
        '
        'dgvTomasFisicas
        '
        Me.dgvTomasFisicas.AllowUserToAddRows = False
        Me.dgvTomasFisicas.AllowUserToDeleteRows = False
        Me.dgvTomasFisicas.AutoGenerateColumns = False
        Me.dgvTomasFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTomasFisicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.FechaAnulacionDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DCortaDataGridViewTextBoxColumn})
        Me.dgvTomasFisicas.DataSource = Me.FISICOMAESTROBindingSource
        Me.dgvTomasFisicas.Location = New System.Drawing.Point(18, 130)
        Me.dgvTomasFisicas.Name = "dgvTomasFisicas"
        Me.dgvTomasFisicas.ReadOnly = True
        Me.dgvTomasFisicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTomasFisicas.Size = New System.Drawing.Size(672, 256)
        Me.dgvTomasFisicas.TabIndex = 2
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAnulacionDataGridViewTextBoxColumn
        '
        Me.FechaAnulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.HeaderText = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.Name = "FechaAnulacionDataGridViewTextBoxColumn"
        Me.FechaAnulacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DCortaDataGridViewTextBoxColumn
        '
        Me.DCortaDataGridViewTextBoxColumn.DataPropertyName = "DCorta"
        Me.DCortaDataGridViewTextBoxColumn.HeaderText = "DCorta"
        Me.DCortaDataGridViewTextBoxColumn.Name = "DCortaDataGridViewTextBoxColumn"
        Me.DCortaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FISICOMAESTROBindingSource
        '
        Me.FISICOMAESTROBindingSource.DataMember = "FISICO MAESTRO"
        Me.FISICOMAESTROBindingSource.DataSource = Me.VISTAS
        '
        'FISICO_MAESTROTableAdapter
        '
        Me.FISICO_MAESTROTableAdapter.ClearBeforeFill = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(755, 25)
        Me.FillToolStrip.TabIndex = 3
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'frmImpresionVarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 432)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.dgvTomasFisicas)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImpresionVarias"
        Me.Text = "Imprimir varias"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTomasFisicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnReporte As Button
    Friend WithEvents txtObservacionesTomaFisica As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTomas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreAlmacen As TextBox
    Friend WithEvents txtNumeroToma As TextBox
    Friend WithEvents txtCodigoAlmacen As TextBox
    Friend WithEvents cmbBodegas As ComboBox
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents BODEGABindingSource As BindingSource
    Friend WithEvents BODEGATableAdapter As VISTASTableAdapters.BODEGATableAdapter
    Friend WithEvents dgvTomasFisicas As DataGridView
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAnulacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DCortaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FISICOMAESTROBindingSource As BindingSource
    Friend WithEvents FISICO_MAESTROTableAdapter As VISTASTableAdapters.FISICO_MAESTROTableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents FillToolStripButton As ToolStripButton
End Class
