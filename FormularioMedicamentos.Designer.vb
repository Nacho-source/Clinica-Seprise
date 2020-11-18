<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioMedicamentos
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
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.txtPresentacion = New System.Windows.Forms.TextBox()
        Me.lblPresentacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(292, 449)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(168, 20)
        Me.txtPrecioVenta.TabIndex = 17
        '
        'txtPP
        '
        Me.txtPP.Location = New System.Drawing.Point(292, 374)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(168, 20)
        Me.txtPP.TabIndex = 16
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(292, 303)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(168, 20)
        Me.txtStock.TabIndex = 15
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(292, 164)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 14
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioVenta.Location = New System.Drawing.Point(37, 444)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(262, 26)
        Me.lblPrecioVenta.TabIndex = 13
        Me.lblPrecioVenta.Text = "Precio de Venta"
        Me.lblPrecioVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPP
        '
        Me.lblPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPP.Location = New System.Drawing.Point(37, 369)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(262, 26)
        Me.lblPP.TabIndex = 12
        Me.lblPP.Text = "Punto de Pedido"
        Me.lblPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(37, 298)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(262, 26)
        Me.lblStock.TabIndex = 11
        Me.lblStock.Text = "Stock"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(37, 159)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(262, 26)
        Me.lblNombre.TabIndex = 10
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(128, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(262, 51)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Medicamento"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 605)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 56)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(332, 605)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(171, 56)
        Me.btnAccion.TabIndex = 19
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'lblProveedor
        '
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(37, 524)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(262, 26)
        Me.lblProveedor.TabIndex = 20
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboProveedores
        '
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(292, 529)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(168, 21)
        Me.cboProveedores.TabIndex = 21
        '
        'txtPresentacion
        '
        Me.txtPresentacion.Location = New System.Drawing.Point(292, 233)
        Me.txtPresentacion.Name = "txtPresentacion"
        Me.txtPresentacion.Size = New System.Drawing.Size(168, 20)
        Me.txtPresentacion.TabIndex = 23
        '
        'lblPresentacion
        '
        Me.lblPresentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentacion.Location = New System.Drawing.Point(37, 228)
        Me.lblPresentacion.Name = "lblPresentacion"
        Me.lblPresentacion.Size = New System.Drawing.Size(262, 26)
        Me.lblPresentacion.TabIndex = 22
        Me.lblPresentacion.Text = "Presentacion"
        Me.lblPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormularioMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 673)
        Me.Controls.Add(Me.txtPresentacion)
        Me.Controls.Add(Me.lblPresentacion)
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
        Me.Name = "FormularioMedicamentos"
        Me.Text = "FormularioMedicamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioVenta As System.Windows.Forms.Label
    Friend WithEvents lblPP As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAccion As System.Windows.Forms.Button
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents txtPresentacion As TextBox
    Friend WithEvents lblPresentacion As Label
End Class
