<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarDieta
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
        Me.btnAgregarPlato = New System.Windows.Forms.Button()
        Me.lblDietaModif = New System.Windows.Forms.Label()
        Me.dgvDietaModif = New System.Windows.Forms.DataGridView()
        Me.cboPlatoDietaModif = New System.Windows.Forms.ComboBox()
        Me.btnEliminarPlato = New System.Windows.Forms.Button()
        Me.dgvDetalleDietaModif = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDietaModif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleDietaModif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(453, 10)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAgregarPlato
        '
        Me.btnAgregarPlato.Location = New System.Drawing.Point(12, 389)
        Me.btnAgregarPlato.Name = "btnAgregarPlato"
        Me.btnAgregarPlato.Size = New System.Drawing.Size(255, 23)
        Me.btnAgregarPlato.TabIndex = 8
        Me.btnAgregarPlato.Text = "Agregar Plato"
        Me.btnAgregarPlato.UseVisualStyleBackColor = True
        '
        'lblDietaModif
        '
        Me.lblDietaModif.AutoSize = True
        Me.lblDietaModif.Location = New System.Drawing.Point(9, 38)
        Me.lblDietaModif.Name = "lblDietaModif"
        Me.lblDietaModif.Size = New System.Drawing.Size(520, 13)
        Me.lblDietaModif.TabIndex = 7
        Me.lblDietaModif.Text = "Seleccione la dieta y el plato que desea modificar, elija el nuevo plato en el co" &
    "mbo y luego presione un boton"
        '
        'dgvDietaModif
        '
        Me.dgvDietaModif.AllowUserToAddRows = False
        Me.dgvDietaModif.AllowUserToDeleteRows = False
        Me.dgvDietaModif.AllowUserToResizeColumns = False
        Me.dgvDietaModif.AllowUserToResizeRows = False
        Me.dgvDietaModif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDietaModif.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDietaModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDietaModif.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDietaModif.Location = New System.Drawing.Point(12, 64)
        Me.dgvDietaModif.Name = "dgvDietaModif"
        Me.dgvDietaModif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDietaModif.Size = New System.Drawing.Size(255, 268)
        Me.dgvDietaModif.TabIndex = 6
        '
        'cboPlatoDietaModif
        '
        Me.cboPlatoDietaModif.FormattingEnabled = True
        Me.cboPlatoDietaModif.Location = New System.Drawing.Point(12, 338)
        Me.cboPlatoDietaModif.Name = "cboPlatoDietaModif"
        Me.cboPlatoDietaModif.Size = New System.Drawing.Size(519, 21)
        Me.cboPlatoDietaModif.TabIndex = 5
        '
        'btnEliminarPlato
        '
        Me.btnEliminarPlato.Location = New System.Drawing.Point(276, 389)
        Me.btnEliminarPlato.Name = "btnEliminarPlato"
        Me.btnEliminarPlato.Size = New System.Drawing.Size(255, 23)
        Me.btnEliminarPlato.TabIndex = 10
        Me.btnEliminarPlato.Text = "Eliminar Plato"
        Me.btnEliminarPlato.UseVisualStyleBackColor = True
        '
        'dgvDetalleDietaModif
        '
        Me.dgvDetalleDietaModif.AllowUserToAddRows = False
        Me.dgvDetalleDietaModif.AllowUserToDeleteRows = False
        Me.dgvDetalleDietaModif.AllowUserToResizeColumns = False
        Me.dgvDetalleDietaModif.AllowUserToResizeRows = False
        Me.dgvDetalleDietaModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleDietaModif.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetalleDietaModif.Location = New System.Drawing.Point(276, 64)
        Me.dgvDetalleDietaModif.Name = "dgvDetalleDietaModif"
        Me.dgvDetalleDietaModif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleDietaModif.Size = New System.Drawing.Size(255, 268)
        Me.dgvDetalleDietaModif.TabIndex = 11
        '
        'frmModificarDieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 432)
        Me.Controls.Add(Me.dgvDetalleDietaModif)
        Me.Controls.Add(Me.btnEliminarPlato)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregarPlato)
        Me.Controls.Add(Me.lblDietaModif)
        Me.Controls.Add(Me.dgvDietaModif)
        Me.Controls.Add(Me.cboPlatoDietaModif)
        Me.Name = "frmModificarDieta"
        Me.Text = "Modificar Dieta"
        CType(Me.dgvDietaModif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleDietaModif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPlato As System.Windows.Forms.Button
    Friend WithEvents lblDietaModif As System.Windows.Forms.Label
    Friend WithEvents dgvDietaModif As System.Windows.Forms.DataGridView
    Friend WithEvents cboPlatoDietaModif As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminarPlato As System.Windows.Forms.Button
    Friend WithEvents dgvDetalleDietaModif As System.Windows.Forms.DataGridView
End Class
