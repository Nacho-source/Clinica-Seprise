<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioRemitoProveedor
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
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblFechaRem = New System.Windows.Forms.Label()
        Me.lblNRem = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNRemito = New System.Windows.Forms.Label()
        Me.lblFdeRemito = New System.Windows.Forms.Label()
        Me.lblNOrdComp = New System.Windows.Forms.Label()
        Me.txtNOrdComp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(330, 454)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(171, 56)
        Me.btnAccion.TabIndex = 41
        Me.btnAccion.Text = "Registrar Remito"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(0, 454)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 56)
        Me.btnVolver.TabIndex = 40
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblFechaRem
        '
        Me.lblFechaRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRem.Location = New System.Drawing.Point(10, 214)
        Me.lblFechaRem.Name = "lblFechaRem"
        Me.lblFechaRem.Size = New System.Drawing.Size(262, 26)
        Me.lblFechaRem.TabIndex = 37
        Me.lblFechaRem.Text = "Fecha:"
        Me.lblFechaRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNRem
        '
        Me.lblNRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRem.Location = New System.Drawing.Point(10, 140)
        Me.lblNRem.Name = "lblNRem"
        Me.lblNRem.Size = New System.Drawing.Size(262, 26)
        Me.lblNRem.TabIndex = 36
        Me.lblNRem.Text = "N°Remito:"
        Me.lblNRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(125, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(262, 51)
        Me.lblTitulo.TabIndex = 35
        Me.lblTitulo.Text = "Remito"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNRemito
        '
        Me.lblNRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNRemito.Location = New System.Drawing.Point(265, 140)
        Me.lblNRemito.Name = "lblNRemito"
        Me.lblNRemito.Size = New System.Drawing.Size(168, 26)
        Me.lblNRemito.TabIndex = 44
        Me.lblNRemito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFdeRemito
        '
        Me.lblFdeRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFdeRemito.Location = New System.Drawing.Point(265, 214)
        Me.lblFdeRemito.Name = "lblFdeRemito"
        Me.lblFdeRemito.Size = New System.Drawing.Size(168, 26)
        Me.lblFdeRemito.TabIndex = 46
        Me.lblFdeRemito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNOrdComp
        '
        Me.lblNOrdComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOrdComp.Location = New System.Drawing.Point(10, 289)
        Me.lblNOrdComp.Name = "lblNOrdComp"
        Me.lblNOrdComp.Size = New System.Drawing.Size(262, 26)
        Me.lblNOrdComp.TabIndex = 47
        Me.lblNOrdComp.Text = "Numero de Orden de Compra:"
        Me.lblNOrdComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNOrdComp
        '
        Me.txtNOrdComp.Location = New System.Drawing.Point(269, 294)
        Me.txtNOrdComp.Name = "txtNOrdComp"
        Me.txtNOrdComp.Size = New System.Drawing.Size(163, 20)
        Me.txtNOrdComp.TabIndex = 48
        Me.txtNOrdComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormularioRemitoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 531)
        Me.Controls.Add(Me.txtNOrdComp)
        Me.Controls.Add(Me.lblNOrdComp)
        Me.Controls.Add(Me.lblFdeRemito)
        Me.Controls.Add(Me.lblNRemito)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblFechaRem)
        Me.Controls.Add(Me.lblNRem)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FormularioRemitoProveedor"
        Me.Text = "FormularioRemitoProveedor:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAccion As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblFechaRem As Label
    Friend WithEvents lblNRem As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNRemito As Label
    Friend WithEvents lblFdeRemito As Label
    Friend WithEvents lblNOrdComp As Label
    Friend WithEvents txtNOrdComp As TextBox
End Class
