<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioInsumo
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtPrecioproveedor = New System.Windows.Forms.TextBox()
        Me.lblPrecioProveedor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(136, 27)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(262, 51)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Insumo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 132)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(262, 26)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(12, 207)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(262, 26)
        Me.lblStock.TabIndex = 2
        Me.lblStock.Text = "Stock"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPP
        '
        Me.lblPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPP.Location = New System.Drawing.Point(12, 278)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(262, 26)
        Me.lblPP.TabIndex = 3
        Me.lblPP.Text = "Punto de Pedido"
        Me.lblPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioVenta.Location = New System.Drawing.Point(12, 353)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(262, 26)
        Me.lblPrecioVenta.TabIndex = 4
        Me.lblPrecioVenta.Text = "Precio de Venta"
        Me.lblPrecioVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(267, 137)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(267, 212)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(168, 20)
        Me.txtStock.TabIndex = 6
        '
        'txtPP
        '
        Me.txtPP.Location = New System.Drawing.Point(267, 283)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(168, 20)
        Me.txtPP.TabIndex = 7
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(267, 358)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(168, 20)
        Me.txtPrecioVenta.TabIndex = 8
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(341, 559)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(171, 56)
        Me.btnAccion.TabIndex = 21
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 559)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 56)
        Me.btnVolver.TabIndex = 20
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'cboProveedores
        '
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(267, 426)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(168, 21)
        Me.cboProveedores.TabIndex = 23
        '
        'lblProveedor
        '
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(12, 421)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(262, 26)
        Me.lblProveedor.TabIndex = 22
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecioproveedor
        '
        Me.txtPrecioproveedor.Location = New System.Drawing.Point(267, 497)
        Me.txtPrecioproveedor.Name = "txtPrecioproveedor"
        Me.txtPrecioproveedor.Size = New System.Drawing.Size(168, 20)
        Me.txtPrecioproveedor.TabIndex = 25
        '
        'lblPrecioProveedor
        '
        Me.lblPrecioProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioProveedor.Location = New System.Drawing.Point(12, 492)
        Me.lblPrecioProveedor.Name = "lblPrecioProveedor"
        Me.lblPrecioProveedor.Size = New System.Drawing.Size(262, 26)
        Me.lblPrecioProveedor.TabIndex = 24
        Me.lblPrecioProveedor.Text = "Precio Proveedor"
        Me.lblPrecioProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormularioInsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 627)
        Me.Controls.Add(Me.txtPrecioproveedor)
        Me.Controls.Add(Me.lblPrecioProveedor)
        Me.Controls.Add(Me.cboProveedores)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.txtPP)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblPrecioVenta)
        Me.Controls.Add(Me.lblPP)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FormularioInsumo"
        Me.Text = "FormularioInsumo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents lblPP As System.Windows.Forms.Label
    Friend WithEvents lblPrecioVenta As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents btnAccion As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents txtPrecioproveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioProveedor As System.Windows.Forms.Label
End Class
