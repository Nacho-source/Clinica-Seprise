<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioArticuloSector
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
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.lblPPP = New System.Windows.Forms.Label()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtPPP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPP
        '
        Me.txtPP.Location = New System.Drawing.Point(281, 207)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(168, 20)
        Me.txtPP.TabIndex = 38
        '
        'lblPP
        '
        Me.lblPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPP.Location = New System.Drawing.Point(26, 202)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(262, 26)
        Me.lblPP.TabIndex = 37
        Me.lblPP.Text = "Punto de Pedido:"
        Me.lblPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPPP
        '
        Me.lblPPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPP.Location = New System.Drawing.Point(30, 285)
        Me.lblPPP.Name = "lblPPP"
        Me.lblPPP.Size = New System.Drawing.Size(262, 26)
        Me.lblPPP.TabIndex = 35
        Me.lblPPP.Text = "Porcentaje de Pedido:"
        Me.lblPPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(285, 366)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(171, 56)
        Me.btnAccion.TabIndex = 34
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(5, 366)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(109, 56)
        Me.btnVolver.TabIndex = 33
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(281, 138)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(168, 20)
        Me.txtStock.TabIndex = 29
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(26, 133)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(262, 26)
        Me.lblStock.TabIndex = 25
        Me.lblStock.Text = "Stock:"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(1, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(451, 51)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPPP
        '
        Me.txtPPP.Location = New System.Drawing.Point(281, 285)
        Me.txtPPP.MaxLength = 2
        Me.txtPPP.Name = "txtPPP"
        Me.txtPPP.Size = New System.Drawing.Size(168, 20)
        Me.txtPPP.TabIndex = 39
        '
        'FormularioArticuloSector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 424)
        Me.Controls.Add(Me.txtPPP)
        Me.Controls.Add(Me.txtPP)
        Me.Controls.Add(Me.lblPP)
        Me.Controls.Add(Me.lblPPP)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FormularioArticuloSector"
        Me.Text = "ArticuloSector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPP As TextBox
    Friend WithEvents lblPP As Label
    Friend WithEvents lblPPP As Label
    Friend WithEvents btnAccion As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtPPP As TextBox
End Class
