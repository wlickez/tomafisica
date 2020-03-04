<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.visor = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VISTAS = New TOMAFISICA.VISTAS()
        Me.CONSULTAR_TOMA_FISICABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONSULTAR_TOMA_FISICATableAdapter = New TOMAFISICA.VISTASTableAdapters.CONSULTAR_TOMA_FISICATableAdapter()
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONSULTAR_TOMA_FISICABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'visor
        '
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TOMAFISICA"
        ReportDataSource1.Value = Me.CONSULTAR_TOMA_FISICABindingSource
        Me.visor.LocalReport.DataSources.Add(ReportDataSource1)
        Me.visor.LocalReport.ReportEmbeddedResource = "TOMAFISICA.rptTomaFisica.rdlc"
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Name = "visor"
        Me.visor.Size = New System.Drawing.Size(973, 572)
        Me.visor.TabIndex = 0
        '
        'VISTAS
        '
        Me.VISTAS.DataSetName = "VISTAS"
        Me.VISTAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONSULTAR_TOMA_FISICABindingSource
        '
        Me.CONSULTAR_TOMA_FISICABindingSource.DataMember = "CONSULTAR TOMA FISICA"
        Me.CONSULTAR_TOMA_FISICABindingSource.DataSource = Me.VISTAS
        '
        'CONSULTAR_TOMA_FISICATableAdapter
        '
        Me.CONSULTAR_TOMA_FISICATableAdapter.ClearBeforeFill = True
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 572)
        Me.Controls.Add(Me.visor)
        Me.Name = "frmReporte"
        Me.Text = "Reporte"
        CType(Me.VISTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONSULTAR_TOMA_FISICABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents visor As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CONSULTAR_TOMA_FISICABindingSource As BindingSource
    Friend WithEvents VISTAS As VISTAS
    Friend WithEvents CONSULTAR_TOMA_FISICATableAdapter As VISTASTableAdapters.CONSULTAR_TOMA_FISICATableAdapter
End Class
