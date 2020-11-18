<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuFarmacia
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
        Me.btnOrdDeCompra = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnMedIns = New System.Windows.Forms.Button()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.btnPedidos = New System.Windows.Forms.Button()
        Me.btnContPaq = New System.Windows.Forms.Button()
        Me.btnFactProv = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnControlArtSec = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOrdDeCompra
        '
        Me.btnOrdDeCompra.Location = New System.Drawing.Point(751, 144)
        Me.btnOrdDeCompra.Name = "btnOrdDeCompra"
        Me.btnOrdDeCompra.Size = New System.Drawing.Size(167, 71)
        Me.btnOrdDeCompra.TabIndex = 0
        Me.btnOrdDeCompra.Text = "Realizar Orden de Compra"
        Me.btnOrdDeCompra.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(751, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 71)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Controlar stock de sectores"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnMedIns
        '
        Me.btnMedIns.Location = New System.Drawing.Point(751, 18)
        Me.btnMedIns.Name = "btnMedIns"
        Me.btnMedIns.Size = New System.Drawing.Size(167, 71)
        Me.btnMedIns.TabIndex = 2
        Me.btnMedIns.Text = "Control Medicamenos e Insumos"
        Me.btnMedIns.UseVisualStyleBackColor = True
        '
        'btnProveedor
        '
        Me.btnProveedor.Location = New System.Drawing.Point(519, 18)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(167, 71)
        Me.btnProveedor.TabIndex = 3
        Me.btnProveedor.Text = "Control proveedores"
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.Location = New System.Drawing.Point(519, 144)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Size = New System.Drawing.Size(167, 71)
        Me.btnPedidos.TabIndex = 4
        Me.btnPedidos.Text = "Control de pedidos"
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'btnContPaq
        '
        Me.btnContPaq.Location = New System.Drawing.Point(279, 144)
        Me.btnContPaq.Name = "btnContPaq"
        Me.btnContPaq.Size = New System.Drawing.Size(167, 71)
        Me.btnContPaq.TabIndex = 5
        Me.btnContPaq.Text = "Control de Paquetes"
        Me.btnContPaq.UseVisualStyleBackColor = True
        '
        'btnFactProv
        '
        Me.btnFactProv.Location = New System.Drawing.Point(519, 260)
        Me.btnFactProv.Name = "btnFactProv"
        Me.btnFactProv.Size = New System.Drawing.Size(167, 71)
        Me.btnFactProv.TabIndex = 6
        Me.btnFactProv.Text = "Control de Facturas de Proveedor"
        Me.btnFactProv.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 71)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(12, 260)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 71)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnControlArtSec
        '
        Me.btnControlArtSec.Location = New System.Drawing.Point(279, 260)
        Me.btnControlArtSec.Name = "btnControlArtSec"
        Me.btnControlArtSec.Size = New System.Drawing.Size(167, 71)
        Me.btnControlArtSec.TabIndex = 9
        Me.btnControlArtSec.Text = "Controlar Articulo de sectores"
        Me.btnControlArtSec.UseVisualStyleBackColor = True
        '
        'MenuFarmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 353)
        Me.Controls.Add(Me.btnControlArtSec)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFactProv)
        Me.Controls.Add(Me.btnContPaq)
        Me.Controls.Add(Me.btnPedidos)
        Me.Controls.Add(Me.btnProveedor)
        Me.Controls.Add(Me.btnMedIns)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOrdDeCompra)
        Me.Name = "MenuFarmacia"
        Me.Text = "Menu Sector Farmacia"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOrdDeCompra As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnMedIns As System.Windows.Forms.Button
    Friend WithEvents btnProveedor As System.Windows.Forms.Button
    Friend WithEvents btnPedidos As System.Windows.Forms.Button
    Friend WithEvents btnContPaq As Button
    Friend WithEvents btnFactProv As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnControlArtSec As Button
End Class
