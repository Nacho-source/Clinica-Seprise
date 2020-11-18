<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrModificarPlato
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
        Me.lblModificarNombrePlato = New System.Windows.Forms.Label()
        Me.txtModificarNombrePlato = New System.Windows.Forms.TextBox()
        Me.btnVolverModificarPlato = New System.Windows.Forms.Button()
        Me.lstModificarPlato = New System.Windows.Forms.ListBox()
        Me.txtModificarIngredientePlato = New System.Windows.Forms.Label()
        Me.cboIngredienteMod = New System.Windows.Forms.ComboBox()
        Me.lblExplicarAgregarPlato = New System.Windows.Forms.Label()
        Me.btnModificarIngredientePlato = New System.Windows.Forms.Button()
        Me.btnQuitarPlatoModificarPlato = New System.Windows.Forms.Button()
        Me.btnQuitarTodoModificarPlato = New System.Windows.Forms.Button()
        Me.btnModificarModificarPlato = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblModificarNombrePlato
        '
        Me.lblModificarNombrePlato.AutoSize = True
        Me.lblModificarNombrePlato.Location = New System.Drawing.Point(12, 31)
        Me.lblModificarNombrePlato.Name = "lblModificarNombrePlato"
        Me.lblModificarNombrePlato.Size = New System.Drawing.Size(91, 13)
        Me.lblModificarNombrePlato.TabIndex = 2
        Me.lblModificarNombrePlato.Text = "Nombre de plato: "
        '
        'txtModificarNombrePlato
        '
        Me.txtModificarNombrePlato.Location = New System.Drawing.Point(109, 31)
        Me.txtModificarNombrePlato.Name = "txtModificarNombrePlato"
        Me.txtModificarNombrePlato.Size = New System.Drawing.Size(136, 20)
        Me.txtModificarNombrePlato.TabIndex = 3
        '
        'btnVolverModificarPlato
        '
        Me.btnVolverModificarPlato.Location = New System.Drawing.Point(435, 31)
        Me.btnVolverModificarPlato.Name = "btnVolverModificarPlato"
        Me.btnVolverModificarPlato.Size = New System.Drawing.Size(94, 28)
        Me.btnVolverModificarPlato.TabIndex = 7
        Me.btnVolverModificarPlato.Text = "Volver"
        Me.btnVolverModificarPlato.UseVisualStyleBackColor = True
        '
        'lstModificarPlato
        '
        Me.lstModificarPlato.FormattingEnabled = True
        Me.lstModificarPlato.Location = New System.Drawing.Point(15, 65)
        Me.lstModificarPlato.Name = "lstModificarPlato"
        Me.lstModificarPlato.Size = New System.Drawing.Size(517, 290)
        Me.lstModificarPlato.TabIndex = 12
        '
        'txtModificarIngredientePlato
        '
        Me.txtModificarIngredientePlato.AutoSize = True
        Me.txtModificarIngredientePlato.Location = New System.Drawing.Point(12, 373)
        Me.txtModificarIngredientePlato.Name = "txtModificarIngredientePlato"
        Me.txtModificarIngredientePlato.Size = New System.Drawing.Size(63, 13)
        Me.txtModificarIngredientePlato.TabIndex = 13
        Me.txtModificarIngredientePlato.Text = "Ingrediente:"
        '
        'cboIngredienteMod
        '
        Me.cboIngredienteMod.FormattingEnabled = True
        Me.cboIngredienteMod.Location = New System.Drawing.Point(78, 373)
        Me.cboIngredienteMod.Name = "cboIngredienteMod"
        Me.cboIngredienteMod.Size = New System.Drawing.Size(136, 21)
        Me.cboIngredienteMod.TabIndex = 14
        '
        'lblExplicarAgregarPlato
        '
        Me.lblExplicarAgregarPlato.AutoSize = True
        Me.lblExplicarAgregarPlato.Location = New System.Drawing.Point(9, 431)
        Me.lblExplicarAgregarPlato.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblExplicarAgregarPlato.Name = "lblExplicarAgregarPlato"
        Me.lblExplicarAgregarPlato.Size = New System.Drawing.Size(199, 39)
        Me.lblExplicarAgregarPlato.TabIndex = 15
        Me.lblExplicarAgregarPlato.Text = "Seleccione en la tabla el ingrediente que desea quitar, y luego precione el boton" &
    " ""Quitar Ingrediente"""
        '
        'btnModificarIngredientePlato
        '
        Me.btnModificarIngredientePlato.Enabled = False
        Me.btnModificarIngredientePlato.Location = New System.Drawing.Point(220, 373)
        Me.btnModificarIngredientePlato.Name = "btnModificarIngredientePlato"
        Me.btnModificarIngredientePlato.Size = New System.Drawing.Size(134, 23)
        Me.btnModificarIngredientePlato.TabIndex = 16
        Me.btnModificarIngredientePlato.Text = "Agregar Ingrediente"
        Me.btnModificarIngredientePlato.UseVisualStyleBackColor = True
        '
        'btnQuitarPlatoModificarPlato
        '
        Me.btnQuitarPlatoModificarPlato.Location = New System.Drawing.Point(220, 417)
        Me.btnQuitarPlatoModificarPlato.Name = "btnQuitarPlatoModificarPlato"
        Me.btnQuitarPlatoModificarPlato.Size = New System.Drawing.Size(134, 23)
        Me.btnQuitarPlatoModificarPlato.TabIndex = 17
        Me.btnQuitarPlatoModificarPlato.Text = "Quitar Ingrediente"
        Me.btnQuitarPlatoModificarPlato.UseVisualStyleBackColor = True
        '
        'btnQuitarTodoModificarPlato
        '
        Me.btnQuitarTodoModificarPlato.Location = New System.Drawing.Point(220, 457)
        Me.btnQuitarTodoModificarPlato.Name = "btnQuitarTodoModificarPlato"
        Me.btnQuitarTodoModificarPlato.Size = New System.Drawing.Size(134, 23)
        Me.btnQuitarTodoModificarPlato.TabIndex = 18
        Me.btnQuitarTodoModificarPlato.Text = "Quitar Todo"
        Me.btnQuitarTodoModificarPlato.UseVisualStyleBackColor = True
        '
        'btnModificarModificarPlato
        '
        Me.btnModificarModificarPlato.Location = New System.Drawing.Point(438, 452)
        Me.btnModificarModificarPlato.Name = "btnModificarModificarPlato"
        Me.btnModificarModificarPlato.Size = New System.Drawing.Size(94, 28)
        Me.btnModificarModificarPlato.TabIndex = 19
        Me.btnModificarModificarPlato.Text = "Modificar Plato"
        Me.btnModificarModificarPlato.UseVisualStyleBackColor = True
        '
        'fmrModificarPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 494)
        Me.Controls.Add(Me.btnModificarModificarPlato)
        Me.Controls.Add(Me.btnQuitarTodoModificarPlato)
        Me.Controls.Add(Me.btnQuitarPlatoModificarPlato)
        Me.Controls.Add(Me.btnModificarIngredientePlato)
        Me.Controls.Add(Me.lblExplicarAgregarPlato)
        Me.Controls.Add(Me.cboIngredienteMod)
        Me.Controls.Add(Me.txtModificarIngredientePlato)
        Me.Controls.Add(Me.lstModificarPlato)
        Me.Controls.Add(Me.btnVolverModificarPlato)
        Me.Controls.Add(Me.txtModificarNombrePlato)
        Me.Controls.Add(Me.lblModificarNombrePlato)
        Me.Name = "fmrModificarPlato"
        Me.Text = "ModificarPlato.vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblModificarNombrePlato As Label
    Friend WithEvents txtModificarNombrePlato As TextBox
    Friend WithEvents btnVolverModificarPlato As Button
    Friend WithEvents lstModificarPlato As ListBox
    Friend WithEvents txtModificarIngredientePlato As Label
    Friend WithEvents cboIngredienteMod As ComboBox
    Friend WithEvents lblExplicarAgregarPlato As Label
    Friend WithEvents btnModificarIngredientePlato As Button
    Friend WithEvents btnQuitarPlatoModificarPlato As Button
    Friend WithEvents btnQuitarTodoModificarPlato As Button
    Friend WithEvents btnModificarModificarPlato As Button
End Class
