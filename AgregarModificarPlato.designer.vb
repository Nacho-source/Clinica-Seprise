<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarModificarPlato
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
        Me.dgvPlatos = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvPlatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(502, 388)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(119, 43)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'dgvPlatos
        '
        Me.dgvPlatos.AllowUserToAddRows = False
        Me.dgvPlatos.AllowUserToDeleteRows = False
        Me.dgvPlatos.AllowUserToResizeColumns = False
        Me.dgvPlatos.AllowUserToResizeRows = False
        Me.dgvPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPlatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPlatos.Location = New System.Drawing.Point(12, 12)
        Me.dgvPlatos.Name = "dgvPlatos"
        Me.dgvPlatos.Size = New System.Drawing.Size(609, 346)
        Me.dgvPlatos.TabIndex = 3
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(255, 388)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(119, 43)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(12, 388)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 43)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmAgregarModificarPlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 443)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dgvPlatos)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "frmAgregarModificarPlato"
        Me.Text = "Agregar o Modificar Plato"
        CType(Me.dgvPlatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dgvPlatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button

End Class
