<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearDieta
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
        Me.btnAgregarPlatoDieta = New System.Windows.Forms.Button()
        Me.btnCrearDieta = New System.Windows.Forms.Button()
        Me.lstPlatosDieta = New System.Windows.Forms.ListBox()
        Me.cboAgregarPlatoDieta = New System.Windows.Forms.ComboBox()
        Me.lblSeleccionPlato = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtAgregarNombreDieta = New System.Windows.Forms.TextBox()
        Me.lblAgregarNombreDieta = New System.Windows.Forms.Label()
        Me.lblExplicarAgregarPlato = New System.Windows.Forms.Label()
        Me.btnQuitarPlato = New System.Windows.Forms.Button()
        Me.btnQuitarTodoPlato = New System.Windows.Forms.Button()
        Me.lblConsistencia = New System.Windows.Forms.Label()
        Me.cboConsistencia = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAgregarPlatoDieta
        '
        Me.btnAgregarPlatoDieta.Enabled = False
        Me.btnAgregarPlatoDieta.Location = New System.Drawing.Point(418, 338)
        Me.btnAgregarPlatoDieta.Name = "btnAgregarPlatoDieta"
        Me.btnAgregarPlatoDieta.Size = New System.Drawing.Size(131, 23)
        Me.btnAgregarPlatoDieta.TabIndex = 9
        Me.btnAgregarPlatoDieta.Text = "Agregar Plato a la Dieta"
        Me.btnAgregarPlatoDieta.UseVisualStyleBackColor = True
        '
        'btnCrearDieta
        '
        Me.btnCrearDieta.Location = New System.Drawing.Point(418, 488)
        Me.btnCrearDieta.Name = "btnCrearDieta"
        Me.btnCrearDieta.Size = New System.Drawing.Size(131, 23)
        Me.btnCrearDieta.TabIndex = 8
        Me.btnCrearDieta.Text = "Crear Dieta"
        Me.btnCrearDieta.UseVisualStyleBackColor = True
        '
        'lstPlatosDieta
        '
        Me.lstPlatosDieta.FormattingEnabled = True
        Me.lstPlatosDieta.Location = New System.Drawing.Point(12, 51)
        Me.lstPlatosDieta.Name = "lstPlatosDieta"
        Me.lstPlatosDieta.Size = New System.Drawing.Size(537, 277)
        Me.lstPlatosDieta.TabIndex = 7
        '
        'cboAgregarPlatoDieta
        '
        Me.cboAgregarPlatoDieta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgregarPlatoDieta.FormattingEnabled = True
        Me.cboAgregarPlatoDieta.Location = New System.Drawing.Point(204, 340)
        Me.cboAgregarPlatoDieta.Name = "cboAgregarPlatoDieta"
        Me.cboAgregarPlatoDieta.Size = New System.Drawing.Size(203, 21)
        Me.cboAgregarPlatoDieta.TabIndex = 6
        '
        'lblSeleccionPlato
        '
        Me.lblSeleccionPlato.AutoSize = True
        Me.lblSeleccionPlato.Location = New System.Drawing.Point(9, 340)
        Me.lblSeleccionPlato.Name = "lblSeleccionPlato"
        Me.lblSeleccionPlato.Size = New System.Drawing.Size(189, 13)
        Me.lblSeleccionPlato.TabIndex = 5
        Me.lblSeleccionPlato.Text = "Seleccione el plato que desea agregar"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(462, 20)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(87, 24)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtAgregarNombreDieta
        '
        Me.txtAgregarNombreDieta.Location = New System.Drawing.Point(130, 20)
        Me.txtAgregarNombreDieta.Name = "txtAgregarNombreDieta"
        Me.txtAgregarNombreDieta.Size = New System.Drawing.Size(136, 20)
        Me.txtAgregarNombreDieta.TabIndex = 11
        '
        'lblAgregarNombreDieta
        '
        Me.lblAgregarNombreDieta.AutoSize = True
        Me.lblAgregarNombreDieta.Location = New System.Drawing.Point(9, 23)
        Me.lblAgregarNombreDieta.Name = "lblAgregarNombreDieta"
        Me.lblAgregarNombreDieta.Size = New System.Drawing.Size(88, 13)
        Me.lblAgregarNombreDieta.TabIndex = 12
        Me.lblAgregarNombreDieta.Text = "Nombre de dieta:"
        '
        'lblExplicarAgregarPlato
        '
        Me.lblExplicarAgregarPlato.AutoSize = True
        Me.lblExplicarAgregarPlato.Location = New System.Drawing.Point(12, 433)
        Me.lblExplicarAgregarPlato.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblExplicarAgregarPlato.Name = "lblExplicarAgregarPlato"
        Me.lblExplicarAgregarPlato.Size = New System.Drawing.Size(193, 39)
        Me.lblExplicarAgregarPlato.TabIndex = 13
        Me.lblExplicarAgregarPlato.Text = "Seleccione en la tabla el plato que desea quitar, y luego precione el boton ""Quit" & _
            "ar Plato"""
        '
        'btnQuitarPlato
        '
        Me.btnQuitarPlato.Location = New System.Drawing.Point(220, 433)
        Me.btnQuitarPlato.Name = "btnQuitarPlato"
        Me.btnQuitarPlato.Size = New System.Drawing.Size(134, 23)
        Me.btnQuitarPlato.TabIndex = 14
        Me.btnQuitarPlato.Text = "Quitar Plato"
        Me.btnQuitarPlato.UseVisualStyleBackColor = True
        '
        'btnQuitarTodoPlato
        '
        Me.btnQuitarTodoPlato.Location = New System.Drawing.Point(220, 488)
        Me.btnQuitarTodoPlato.Name = "btnQuitarTodoPlato"
        Me.btnQuitarTodoPlato.Size = New System.Drawing.Size(134, 23)
        Me.btnQuitarTodoPlato.TabIndex = 15
        Me.btnQuitarTodoPlato.Text = "Quitar Todo"
        Me.btnQuitarTodoPlato.UseVisualStyleBackColor = True
        '
        'lblConsistencia
        '
        Me.lblConsistencia.AutoSize = True
        Me.lblConsistencia.Location = New System.Drawing.Point(8, 380)
        Me.lblConsistencia.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblConsistencia.Name = "lblConsistencia"
        Me.lblConsistencia.Size = New System.Drawing.Size(197, 26)
        Me.lblConsistencia.TabIndex = 16
        Me.lblConsistencia.Text = "Seleccione el tipo de consistencia de la dieta"
        '
        'cboConsistencia
        '
        Me.cboConsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsistencia.FormattingEnabled = True
        Me.cboConsistencia.Location = New System.Drawing.Point(204, 385)
        Me.cboConsistencia.Name = "cboConsistencia"
        Me.cboConsistencia.Size = New System.Drawing.Size(203, 21)
        Me.cboConsistencia.TabIndex = 17
        '
        'frmCrearDieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 523)
        Me.Controls.Add(Me.cboConsistencia)
        Me.Controls.Add(Me.lblConsistencia)
        Me.Controls.Add(Me.btnQuitarTodoPlato)
        Me.Controls.Add(Me.btnQuitarPlato)
        Me.Controls.Add(Me.lblExplicarAgregarPlato)
        Me.Controls.Add(Me.lblAgregarNombreDieta)
        Me.Controls.Add(Me.txtAgregarNombreDieta)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarPlatoDieta)
        Me.Controls.Add(Me.btnCrearDieta)
        Me.Controls.Add(Me.lstPlatosDieta)
        Me.Controls.Add(Me.cboAgregarPlatoDieta)
        Me.Controls.Add(Me.lblSeleccionPlato)
        Me.Name = "frmCrearDieta"
        Me.Text = "Crear Dieta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarPlatoDieta As System.Windows.Forms.Button
    Friend WithEvents btnCrearDieta As System.Windows.Forms.Button
    Friend WithEvents lstPlatosDieta As System.Windows.Forms.ListBox
    Friend WithEvents cboAgregarPlatoDieta As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeleccionPlato As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtAgregarNombreDieta As System.Windows.Forms.TextBox
    Friend WithEvents lblAgregarNombreDieta As System.Windows.Forms.Label
    Friend WithEvents lblExplicarAgregarPlato As System.Windows.Forms.Label
    Friend WithEvents btnQuitarPlato As System.Windows.Forms.Button
    Friend WithEvents btnQuitarTodoPlato As System.Windows.Forms.Button
    Friend WithEvents lblConsistencia As System.Windows.Forms.Label
    Friend WithEvents cboConsistencia As System.Windows.Forms.ComboBox
End Class
