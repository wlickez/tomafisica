<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministracionTomasFisicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministracionTomasFisicas))
        Me.tlpDatos = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.BODEGABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BODEGATableAdapter = New TOMAFISICA.VISTASTableAdapters.BODEGATableAdapter()
        Me.dgvTomasFisicas = New System.Windows.Forms.DataGridView()
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAnulacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FISICOMAESTROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.menucontextoDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevisandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnuladaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FISICO_MAESTROTableAdapter = New TOMAFISICA.VISTASTableAdapters.FISICO_MAESTROTableAdapter()
        Me.USUARIOTableAdapter = New TOMAFISICA.VISTASTableAdapters.USUARIOTableAdapter()
        Me.tlpDatos.SuspendLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTomasFisicas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menucontextoDGV.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpDatos
        '
        Me.tlpDatos.ColumnCount = 3
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDatos.Controls.Add(Me.Label5, 0, 0)
        Me.tlpDatos.Controls.Add(Me.cmbUsuario, 1, 4)
        Me.tlpDatos.Controls.Add(Me.Label4, 0, 4)
        Me.tlpDatos.Controls.Add(Me.txtObservaciones, 1, 3)
        Me.tlpDatos.Controls.Add(Me.cmbSucursal, 1, 2)
        Me.tlpDatos.Controls.Add(Me.txtFecha, 1, 1)
        Me.tlpDatos.Controls.Add(Me.btnGuardar, 2, 4)
        Me.tlpDatos.Controls.Add(Me.txtNumero, 1, 0)
        Me.tlpDatos.Controls.Add(Me.Label2, 0, 3)
        Me.tlpDatos.Controls.Add(Me.Label3, 0, 2)
        Me.tlpDatos.Controls.Add(Me.Label1, 0, 1)
        Me.tlpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tlpDatos.Location = New System.Drawing.Point(12, 12)
        Me.tlpDatos.Name = "tlpDatos"
        Me.tlpDatos.RowCount = 5
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDatos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDatos.Size = New System.Drawing.Size(468, 171)
        Me.tlpDatos.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Número"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DataSource = Me.USUARIOBindingSource
        Me.cmbUsuario.DisplayMember = "Nombre"
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(87, 137)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(261, 21)
        Me.cmbUsuario.TabIndex = 7
        Me.cmbUsuario.ValueMember = "Nombre"
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.VISTAS
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(87, 88)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(261, 43)
        Me.txtObservaciones.TabIndex = 5
        '
        'cmbSucursal
        '
        Me.cmbSucursal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbSucursal.DataSource = Me.BODEGABindingSource
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(87, 58)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(261, 24)
        Me.cmbSucursal.TabIndex = 3
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'BODEGABindingSource
        '
        Me.BODEGABindingSource.DataMember = "BODEGA"
        Me.BODEGABindingSource.DataSource = Me.VISTAS
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtFecha.Location = New System.Drawing.Point(87, 29)
        Me.txtFecha.Mask = "00/00/0000"
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 23)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.ValidatingType = GetType(Date)
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnGuardar.Location = New System.Drawing.Point(354, 138)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 28)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(87, 3)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observaciones"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
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
        Me.dgvTomasFisicas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaAnulacionDataGridViewTextBoxColumn, Me.DCortaDataGridViewTextBoxColumn})
        Me.dgvTomasFisicas.DataSource = Me.FISICOMAESTROBindingSource
        Me.dgvTomasFisicas.Location = New System.Drawing.Point(12, 189)
        Me.dgvTomasFisicas.Name = "dgvTomasFisicas"
        Me.dgvTomasFisicas.ReadOnly = True
        Me.dgvTomasFisicas.Size = New System.Drawing.Size(800, 424)
        Me.dgvTomasFisicas.TabIndex = 1
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 75
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 200
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 65
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 75
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAnulacionDataGridViewTextBoxColumn
        '
        Me.FechaAnulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAnulacion"
        Me.FechaAnulacionDataGridViewTextBoxColumn.HeaderText = "Fecha Anulación"
        Me.FechaAnulacionDataGridViewTextBoxColumn.Name = "FechaAnulacionDataGridViewTextBoxColumn"
        Me.FechaAnulacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DCortaDataGridViewTextBoxColumn
        '
        Me.DCortaDataGridViewTextBoxColumn.DataPropertyName = "DCorta"
        Me.DCortaDataGridViewTextBoxColumn.HeaderText = "DCorta"
        Me.DCortaDataGridViewTextBoxColumn.Name = "DCortaDataGridViewTextBoxColumn"
        Me.DCortaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DCortaDataGridViewTextBoxColumn.Visible = False
        '
        'FISICOMAESTROBindingSource
        '
        Me.FISICOMAESTROBindingSource.DataMember = "FISICO MAESTRO"
        Me.FISICOMAESTROBindingSource.DataSource = Me.VISTAS
        '
        'menucontextoDGV
        '
        Me.menucontextoDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.menucontextoDGV.Name = "ContextMenuStrip1"
        Me.menucontextoDGV.Size = New System.Drawing.Size(158, 48)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajandoToolStripMenuItem, Me.RevisandoToolStripMenuItem, Me.AnuladaToolStripMenuItem, Me.CerradaToolStripMenuItem})
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EliminarToolStripMenuItem.Text = "Cambiar estado"
        '
        'TrabajandoToolStripMenuItem
        '
        Me.TrabajandoToolStripMenuItem.Name = "TrabajandoToolStripMenuItem"
        Me.TrabajandoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.TrabajandoToolStripMenuItem.Text = "Trabajando"
        '
        'RevisandoToolStripMenuItem
        '
        Me.RevisandoToolStripMenuItem.Name = "RevisandoToolStripMenuItem"
        Me.RevisandoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RevisandoToolStripMenuItem.Text = "Revisando"
        '
        'AnuladaToolStripMenuItem
        '
        Me.AnuladaToolStripMenuItem.Name = "AnuladaToolStripMenuItem"
        Me.AnuladaToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AnuladaToolStripMenuItem.Text = "Anulada"
        '
        'CerradaToolStripMenuItem
        '
        Me.CerradaToolStripMenuItem.Name = "CerradaToolStripMenuItem"
        Me.CerradaToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CerradaToolStripMenuItem.Text = "Cerrada"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'FISICO_MAESTROTableAdapter
        '
        Me.FISICO_MAESTROTableAdapter.ClearBeforeFill = True
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'frmAdministracionTomasFisicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 649)
        Me.Controls.Add(Me.dgvTomasFisicas)
        Me.Controls.Add(Me.tlpDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdministracionTomasFisicas"
        Me.Text = "Administracion Tomas Fisicas"
        Me.tlpDatos.ResumeLayout(False)
        Me.tlpDatos.PerformLayout()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BODEGABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTomasFisicas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FISICOMAESTROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menucontextoDGV.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpDatos As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbSucursal As ComboBox
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents BODEGABindingSource As BindingSource
    Friend WithEvents BODEGATableAdapter As VISTASTableAdapters.BODEGATableAdapter
    Friend WithEvents dgvTomasFisicas As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents menucontextoDGV As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RevisandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnuladaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtFecha As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FISICOMAESTROBindingSource As BindingSource
    Friend WithEvents FISICO_MAESTROTableAdapter As VISTASTableAdapters.FISICO_MAESTROTableAdapter
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As VISTASTableAdapters.USUARIOTableAdapter
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaAnulacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DCortaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumero As TextBox
End Class
