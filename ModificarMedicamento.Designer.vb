<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarMedicamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNombreInsumo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.txtPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.txtPP = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreInsumo
        '
        Me.lblNombreInsumo.AutoSize = True
        Me.lblNombreInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreInsumo.Location = New System.Drawing.Point(147, 13)
        Me.lblNombreInsumo.Name = "lblNombreInsumo"
        Me.lblNombreInsumo.Size = New System.Drawing.Size(50, 13)
        Me.lblNombreInsumo.TabIndex = 32
        Me.lblNombreInsumo.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Porcentaje"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Punto pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre medicamento:"
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(175, 291)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(157, 54)
        Me.btnCambiar.TabIndex = 24
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 291)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(157, 54)
        Me.btnAtras.TabIndex = 23
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(15, 149)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(79, 20)
        Me.txtPorcentaje.TabIndex = 41
        '
        'txtPP
        '
        Me.txtPP.Location = New System.Drawing.Point(15, 110)
        Me.txtPP.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(79, 20)
        Me.txtPP.TabIndex = 40
        '
        'ModificarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 362)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.txtPP)
        Me.Controls.Add(Me.lblNombreInsumo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "ModificarMedicamento"
        Me.Text = "ModificarMedicamento"
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreInsumo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCambiar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents txtPorcentaje As NumericUpDown
    Friend WithEvents txtPP As NumericUpDown
End Class
