<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioProveedor
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
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(137, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(262, 51)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Proveedor"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(22, 151)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(262, 26)
        Me.lblNombre.TabIndex = 25
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(22, 290)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(262, 26)
        Me.lblTel.TabIndex = 26
        Me.lblTel.Text = "Numero"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(277, 156)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 28
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(277, 295)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(168, 20)
        Me.txtTel.TabIndex = 29
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 465)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 56)
        Me.btnVolver.TabIndex = 31
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(342, 465)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(171, 56)
        Me.btnAccion.TabIndex = 32
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'lblDomicilio
        '
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.Location = New System.Drawing.Point(22, 220)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(262, 26)
        Me.lblDomicilio.TabIndex = 33
        Me.lblDomicilio.Text = "Domicilio"
        Me.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(277, 225)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(168, 20)
        Me.txtDomicilio.TabIndex = 34
        '
        'FormularioProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 533)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FormularioProveedor"
        Me.Text = "FormularioProveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAccion As Button
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents txtDomicilio As TextBox
End Class
