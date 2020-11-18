<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioFacturaProv
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
        Me.txtMontoFactProv = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblNRemito = New System.Windows.Forms.Label()
        Me.lblNombredelProv = New System.Windows.Forms.Label()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblNRem = New System.Windows.Forms.Label()
        Me.lblCoddeFact = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNProveedor = New System.Windows.Forms.Label()
        Me.txtCodFact = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMontoFactProv
        '
        Me.txtMontoFactProv.Location = New System.Drawing.Point(269, 366)
        Me.txtMontoFactProv.Name = "txtMontoFactProv"
        Me.txtMontoFactProv.Size = New System.Drawing.Size(163, 20)
        Me.txtMontoFactProv.TabIndex = 59
        Me.txtMontoFactProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMonto
        '
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.Location = New System.Drawing.Point(10, 361)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(262, 26)
        Me.lblMonto.TabIndex = 58
        Me.lblMonto.Text = "Monto:"
        Me.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNRemito
        '
        Me.lblNRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRemito.Location = New System.Drawing.Point(265, 286)
        Me.lblNRemito.Name = "lblNRemito"
        Me.lblNRemito.Size = New System.Drawing.Size(168, 26)
        Me.lblNRemito.TabIndex = 57
        Me.lblNRemito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombredelProv
        '
        Me.lblNombredelProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombredelProv.Location = New System.Drawing.Point(10, 216)
        Me.lblNombredelProv.Name = "lblNombredelProv"
        Me.lblNombredelProv.Size = New System.Drawing.Size(262, 26)
        Me.lblNombredelProv.TabIndex = 55
        Me.lblNombredelProv.Text = "Nombre del Proveedor:"
        Me.lblNombredelProv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(268, 461)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(171, 56)
        Me.btnAccion.TabIndex = 54
        Me.btnAccion.Text = "Registrar Factura"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(0, 461)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 56)
        Me.btnVolver.TabIndex = 53
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblNRem
        '
        Me.lblNRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRem.Location = New System.Drawing.Point(10, 286)
        Me.lblNRem.Name = "lblNRem"
        Me.lblNRem.Size = New System.Drawing.Size(262, 26)
        Me.lblNRem.TabIndex = 52
        Me.lblNRem.Text = "IdRemito:"
        Me.lblNRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCoddeFact
        '
        Me.lblCoddeFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoddeFact.Location = New System.Drawing.Point(10, 147)
        Me.lblCoddeFact.Name = "lblCoddeFact"
        Me.lblCoddeFact.Size = New System.Drawing.Size(262, 26)
        Me.lblCoddeFact.TabIndex = 51
        Me.lblCoddeFact.Text = "Codigo de Factura:"
        Me.lblCoddeFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 27)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(439, 51)
        Me.lblTitulo.TabIndex = 50
        Me.lblTitulo.Text = "Factura del Proveedor"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNProveedor
        '
        Me.lblNProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNProveedor.Location = New System.Drawing.Point(264, 216)
        Me.lblNProveedor.Name = "lblNProveedor"
        Me.lblNProveedor.Size = New System.Drawing.Size(168, 26)
        Me.lblNProveedor.TabIndex = 60
        Me.lblNProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodFact
        '
        Me.txtCodFact.Location = New System.Drawing.Point(269, 147)
        Me.txtCodFact.Name = "txtCodFact"
        Me.txtCodFact.Size = New System.Drawing.Size(163, 20)
        Me.txtCodFact.TabIndex = 61
        Me.txtCodFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormularioFacturaProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 516)
        Me.Controls.Add(Me.txtCodFact)
        Me.Controls.Add(Me.lblNProveedor)
        Me.Controls.Add(Me.txtMontoFactProv)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblNRemito)
        Me.Controls.Add(Me.lblNombredelProv)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblNRem)
        Me.Controls.Add(Me.lblCoddeFact)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FormularioFacturaProv"
        Me.Text = "FormularioFacturaProv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMontoFactProv As TextBox
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblNRemito As Label
    Friend WithEvents lblNombredelProv As Label
    Friend WithEvents btnAccion As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblNRem As Label
    Friend WithEvents lblCoddeFact As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNProveedor As Label
    Friend WithEvents txtCodFact As TextBox
End Class
