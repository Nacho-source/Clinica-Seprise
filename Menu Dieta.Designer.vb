<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuDieta
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAgregarPlatoNuevo = New System.Windows.Forms.Button()
        Me.dgvDieta = New System.Windows.Forms.DataGridView()
        Me.btnEliminarDieta = New System.Windows.Forms.Button()
        Me.btnModificarDieta = New System.Windows.Forms.Button()
        Me.btnAgregarDieta = New System.Windows.Forms.Button()
        Me.dgvDetalleDieta = New System.Windows.Forms.DataGridView()
        Me.lblAsignarPaciente = New System.Windows.Forms.Button()
        CType(Me.dgvDieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleDieta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(699, 11)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 19)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAgregarPlatoNuevo
        '
        Me.btnAgregarPlatoNuevo.Location = New System.Drawing.Point(12, 408)
        Me.btnAgregarPlatoNuevo.Name = "btnAgregarPlatoNuevo"
        Me.btnAgregarPlatoNuevo.Size = New System.Drawing.Size(140, 32)
        Me.btnAgregarPlatoNuevo.TabIndex = 10
        Me.btnAgregarPlatoNuevo.Text = "Agregar o Modificar Plato"
        Me.btnAgregarPlatoNuevo.UseVisualStyleBackColor = True
        '
        'dgvDieta
        '
        Me.dgvDieta.AllowUserToAddRows = False
        Me.dgvDieta.AllowUserToDeleteRows = False
        Me.dgvDieta.AllowUserToResizeColumns = False
        Me.dgvDieta.AllowUserToResizeRows = False
        Me.dgvDieta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDieta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDieta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDieta.Location = New System.Drawing.Point(12, 36)
        Me.dgvDieta.Name = "dgvDieta"
        Me.dgvDieta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDieta.Size = New System.Drawing.Size(377, 366)
        Me.dgvDieta.TabIndex = 9
        '
        'btnEliminarDieta
        '
        Me.btnEliminarDieta.Location = New System.Drawing.Point(648, 408)
        Me.btnEliminarDieta.Name = "btnEliminarDieta"
        Me.btnEliminarDieta.Size = New System.Drawing.Size(140, 32)
        Me.btnEliminarDieta.TabIndex = 8
        Me.btnEliminarDieta.Text = "Eliminar Dieta"
        Me.btnEliminarDieta.UseVisualStyleBackColor = True
        '
        'btnModificarDieta
        '
        Me.btnModificarDieta.Location = New System.Drawing.Point(490, 408)
        Me.btnModificarDieta.Name = "btnModificarDieta"
        Me.btnModificarDieta.Size = New System.Drawing.Size(140, 32)
        Me.btnModificarDieta.TabIndex = 7
        Me.btnModificarDieta.Text = "Modificar Dieta"
        Me.btnModificarDieta.UseVisualStyleBackColor = True
        '
        'btnAgregarDieta
        '
        Me.btnAgregarDieta.Location = New System.Drawing.Point(170, 408)
        Me.btnAgregarDieta.Name = "btnAgregarDieta"
        Me.btnAgregarDieta.Size = New System.Drawing.Size(140, 32)
        Me.btnAgregarDieta.TabIndex = 6
        Me.btnAgregarDieta.Text = "Agregar Dieta"
        Me.btnAgregarDieta.UseVisualStyleBackColor = True
        '
        'dgvDetalleDieta
        '
        Me.dgvDetalleDieta.AllowUserToAddRows = False
        Me.dgvDetalleDieta.AllowUserToDeleteRows = False
        Me.dgvDetalleDieta.AllowUserToResizeColumns = False
        Me.dgvDetalleDieta.AllowUserToResizeRows = False
        Me.dgvDetalleDieta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetalleDieta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalleDieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleDieta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetalleDieta.Location = New System.Drawing.Point(416, 36)
        Me.dgvDetalleDieta.Name = "dgvDetalleDieta"
        Me.dgvDetalleDieta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleDieta.Size = New System.Drawing.Size(372, 366)
        Me.dgvDetalleDieta.TabIndex = 12
        '
        'lblAsignarPaciente
        '
        Me.lblAsignarPaciente.Location = New System.Drawing.Point(329, 408)
        Me.lblAsignarPaciente.Name = "lblAsignarPaciente"
        Me.lblAsignarPaciente.Size = New System.Drawing.Size(140, 32)
        Me.lblAsignarPaciente.TabIndex = 13
        Me.lblAsignarPaciente.Text = "Asignar Dieta"
        Me.lblAsignarPaciente.UseVisualStyleBackColor = True
        '
        'frmMenuDieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 460)
        Me.Controls.Add(Me.lblAsignarPaciente)
        Me.Controls.Add(Me.dgvDetalleDieta)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarPlatoNuevo)
        Me.Controls.Add(Me.dgvDieta)
        Me.Controls.Add(Me.btnEliminarDieta)
        Me.Controls.Add(Me.btnModificarDieta)
        Me.Controls.Add(Me.btnAgregarDieta)
        Me.Name = "frmMenuDieta"
        Me.Text = "Menu Dieta"
        CType(Me.dgvDieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleDieta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPlatoNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvDieta As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminarDieta As System.Windows.Forms.Button
    Friend WithEvents btnModificarDieta As System.Windows.Forms.Button
    Friend WithEvents btnAgregarDieta As System.Windows.Forms.Button
    Friend WithEvents dgvDetalleDieta As System.Windows.Forms.DataGridView
    Friend WithEvents lblAsignarPaciente As Button
End Class
