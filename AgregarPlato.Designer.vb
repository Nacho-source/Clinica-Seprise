<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrAgregarPlato
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
        Me.btnAgregarIngredientePlato = New System.Windows.Forms.Button()
        Me.lblAgregarNombrePlato = New System.Windows.Forms.Label()
        Me.txtAgregarNombrePlato = New System.Windows.Forms.TextBox()
        Me.txtAgregarIngredientePlato = New System.Windows.Forms.Label()
        Me.cboIngrediente = New System.Windows.Forms.ComboBox()
        Me.btnVolverAgregarPlato = New System.Windows.Forms.Button()
        Me.btnQuitarPlatoAgregarPlato = New System.Windows.Forms.Button()
        Me.lblExplicarAgregarPlato = New System.Windows.Forms.Label()
        Me.btnAgregarAgregarPlato = New System.Windows.Forms.Button()
        Me.lstAgregarPlato = New System.Windows.Forms.ListBox()
        Me.btnQuitarTodoAgregarPlato = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregarIngredientePlato
        '
        Me.btnAgregarIngredientePlato.Enabled = False
        Me.btnAgregarIngredientePlato.Location = New System.Drawing.Point(223, 369)
        Me.btnAgregarIngredientePlato.Name = "btnAgregarIngredientePlato"
        Me.btnAgregarIngredientePlato.Size = New System.Drawing.Size(134, 23)
        Me.btnAgregarIngredientePlato.TabIndex = 0
        Me.btnAgregarIngredientePlato.Text = "Agregar Ingrediente"
        Me.btnAgregarIngredientePlato.UseVisualStyleBackColor = True
        '
        'lblAgregarNombrePlato
        '
        Me.lblAgregarNombrePlato.AutoSize = True
        Me.lblAgregarNombrePlato.Location = New System.Drawing.Point(12, 35)
        Me.lblAgregarNombrePlato.Name = "lblAgregarNombrePlato"
        Me.lblAgregarNombrePlato.Size = New System.Drawing.Size(91, 13)
        Me.lblAgregarNombrePlato.TabIndex = 1
        Me.lblAgregarNombrePlato.Text = "Nombre de plato: "
        '
        'txtAgregarNombrePlato
        '
        Me.txtAgregarNombrePlato.Location = New System.Drawing.Point(109, 35)
        Me.txtAgregarNombrePlato.Name = "txtAgregarNombrePlato"
        Me.txtAgregarNombrePlato.Size = New System.Drawing.Size(136, 20)
        Me.txtAgregarNombrePlato.TabIndex = 2
        '
        'txtAgregarIngredientePlato
        '
        Me.txtAgregarIngredientePlato.AutoSize = True
        Me.txtAgregarIngredientePlato.Location = New System.Drawing.Point(12, 369)
        Me.txtAgregarIngredientePlato.Name = "txtAgregarIngredientePlato"
        Me.txtAgregarIngredientePlato.Size = New System.Drawing.Size(63, 13)
        Me.txtAgregarIngredientePlato.TabIndex = 3
        Me.txtAgregarIngredientePlato.Text = "Ingrediente:"
        '
        'cboIngrediente
        '
        Me.cboIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIngrediente.FormattingEnabled = True
        Me.cboIngrediente.Location = New System.Drawing.Point(81, 369)
        Me.cboIngrediente.Name = "cboIngrediente"
        Me.cboIngrediente.Size = New System.Drawing.Size(136, 21)
        Me.cboIngrediente.TabIndex = 4
        '
        'btnVolverAgregarPlato
        '
        Me.btnVolverAgregarPlato.Location = New System.Drawing.Point(433, 26)
        Me.btnVolverAgregarPlato.Name = "btnVolverAgregarPlato"
        Me.btnVolverAgregarPlato.Size = New System.Drawing.Size(94, 28)
        Me.btnVolverAgregarPlato.TabIndex = 6
        Me.btnVolverAgregarPlato.Text = "Volver"
        Me.btnVolverAgregarPlato.UseVisualStyleBackColor = True
        '
        'btnQuitarPlatoAgregarPlato
        '
        Me.btnQuitarPlatoAgregarPlato.Location = New System.Drawing.Point(223, 413)
        Me.btnQuitarPlatoAgregarPlato.Name = "btnQuitarPlatoAgregarPlato"
        Me.btnQuitarPlatoAgregarPlato.Size = New System.Drawing.Size(134, 23)
        Me.btnQuitarPlatoAgregarPlato.TabIndex = 8
        Me.btnQuitarPlatoAgregarPlato.Text = "Quitar Ingrediente"
        Me.btnQuitarPlatoAgregarPlato.UseVisualStyleBackColor = True
        '
        'lblExplicarAgregarPlato
        '
        Me.lblExplicarAgregarPlato.AutoSize = True
        Me.lblExplicarAgregarPlato.Location = New System.Drawing.Point(12, 413)
        Me.lblExplicarAgregarPlato.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblExplicarAgregarPlato.Name = "lblExplicarAgregarPlato"
        Me.lblExplicarAgregarPlato.Size = New System.Drawing.Size(199, 39)
        Me.lblExplicarAgregarPlato.TabIndex = 9
        Me.lblExplicarAgregarPlato.Text = "Seleccione en la tabla el ingrediente que desea quitar, y luego precione el boton" & _
            " ""Quitar Ingrediente"""
        '
        'btnAgregarAgregarPlato
        '
        Me.btnAgregarAgregarPlato.Location = New System.Drawing.Point(435, 452)
        Me.btnAgregarAgregarPlato.Name = "btnAgregarAgregarPlato"
        Me.btnAgregarAgregarPlato.Size = New System.Drawing.Size(94, 28)
        Me.btnAgregarAgregarPlato.TabIndex = 10
        Me.btnAgregarAgregarPlato.Text = "Agregar Plato"
        Me.btnAgregarAgregarPlato.UseVisualStyleBackColor = True
        '
        'lstAgregarPlato
        '
        Me.lstAgregarPlato.FormattingEnabled = True
        Me.lstAgregarPlato.Location = New System.Drawing.Point(12, 61)
        Me.lstAgregarPlato.Name = "lstAgregarPlato"
        Me.lstAgregarPlato.Size = New System.Drawing.Size(517, 290)
        Me.lstAgregarPlato.TabIndex = 11
        '
        'btnQuitarTodoAgregarPlato
        '
        Me.btnQuitarTodoAgregarPlato.Location = New System.Drawing.Point(223, 452)
        Me.btnQuitarTodoAgregarPlato.Name = "btnQuitarTodoAgregarPlato"
        Me.btnQuitarTodoAgregarPlato.Size = New System.Drawing.Size(134, 23)
        Me.btnQuitarTodoAgregarPlato.TabIndex = 12
        Me.btnQuitarTodoAgregarPlato.Text = "Quitar Todo"
        Me.btnQuitarTodoAgregarPlato.UseVisualStyleBackColor = True
        '
        'fmrAgregarPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 492)
        Me.Controls.Add(Me.btnQuitarTodoAgregarPlato)
        Me.Controls.Add(Me.lstAgregarPlato)
        Me.Controls.Add(Me.btnAgregarAgregarPlato)
        Me.Controls.Add(Me.lblExplicarAgregarPlato)
        Me.Controls.Add(Me.btnQuitarPlatoAgregarPlato)
        Me.Controls.Add(Me.btnVolverAgregarPlato)
        Me.Controls.Add(Me.cboIngrediente)
        Me.Controls.Add(Me.txtAgregarIngredientePlato)
        Me.Controls.Add(Me.txtAgregarNombrePlato)
        Me.Controls.Add(Me.lblAgregarNombrePlato)
        Me.Controls.Add(Me.btnAgregarIngredientePlato)
        Me.Name = "fmrAgregarPlato"
        Me.Text = "Agregar Plato Nuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarIngredientePlato As System.Windows.Forms.Button
    Friend WithEvents lblAgregarNombrePlato As System.Windows.Forms.Label
    Friend WithEvents txtAgregarNombrePlato As System.Windows.Forms.TextBox
    Friend WithEvents txtAgregarIngredientePlato As System.Windows.Forms.Label
    Friend WithEvents cboIngrediente As System.Windows.Forms.ComboBox
    Friend WithEvents btnVolverAgregarPlato As System.Windows.Forms.Button
    Friend WithEvents btnQuitarPlatoAgregarPlato As System.Windows.Forms.Button
    Friend WithEvents lblExplicarAgregarPlato As System.Windows.Forms.Label
    Friend WithEvents btnAgregarAgregarPlato As System.Windows.Forms.Button
    Friend WithEvents lstAgregarPlato As System.Windows.Forms.ListBox
    Friend WithEvents btnQuitarTodoAgregarPlato As System.Windows.Forms.Button
End Class
