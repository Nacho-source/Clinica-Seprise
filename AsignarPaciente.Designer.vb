<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrAsignarPaciente
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
        Me.btnAsignarPaciente = New System.Windows.Forms.Button()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lblDieta = New System.Windows.Forms.Label()
        Me.lblDetallePlato = New System.Windows.Forms.Label()
        Me.lblExplicacion = New System.Windows.Forms.Label()
        Me.dgvPaciente = New System.Windows.Forms.DataGridView()
        Me.dgvDieta = New System.Windows.Forms.DataGridView()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(556, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(76, 27)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAsignarPaciente
        '
        Me.btnAsignarPaciente.Location = New System.Drawing.Point(222, 661)
        Me.btnAsignarPaciente.Name = "btnAsignarPaciente"
        Me.btnAsignarPaciente.Size = New System.Drawing.Size(196, 33)
        Me.btnAsignarPaciente.TabIndex = 4
        Me.btnAsignarPaciente.Text = "Continuar"
        Me.btnAsignarPaciente.UseVisualStyleBackColor = True
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaciente.Location = New System.Drawing.Point(98, 90)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(96, 25)
        Me.lblPaciente.TabIndex = 5
        Me.lblPaciente.Text = "Paciente"
        '
        'lblDieta
        '
        Me.lblDieta.AutoSize = True
        Me.lblDieta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDieta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDieta.Location = New System.Drawing.Point(456, 90)
        Me.lblDieta.Name = "lblDieta"
        Me.lblDieta.Size = New System.Drawing.Size(62, 25)
        Me.lblDieta.TabIndex = 6
        Me.lblDieta.Text = "Dieta"
        '
        'lblDetallePlato
        '
        Me.lblDetallePlato.AutoSize = True
        Me.lblDetallePlato.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDetallePlato.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetallePlato.Location = New System.Drawing.Point(240, 437)
        Me.lblDetallePlato.Name = "lblDetallePlato"
        Me.lblDetallePlato.Size = New System.Drawing.Size(178, 25)
        Me.lblDetallePlato.TabIndex = 7
        Me.lblDetallePlato.Text = "Platos de la dieta"
        '
        'lblExplicacion
        '
        Me.lblExplicacion.AutoSize = True
        Me.lblExplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplicacion.Location = New System.Drawing.Point(30, 52)
        Me.lblExplicacion.Name = "lblExplicacion"
        Me.lblExplicacion.Size = New System.Drawing.Size(575, 16)
        Me.lblExplicacion.TabIndex = 8
        Me.lblExplicacion.Text = "Seleccione el paciente y la dieta que desee asignar y precione el boton Continuar" & _
            ""
        '
        'dgvPaciente
        '
        Me.dgvPaciente.AllowUserToAddRows = False
        Me.dgvPaciente.AllowUserToDeleteRows = False
        Me.dgvPaciente.AllowUserToResizeColumns = False
        Me.dgvPaciente.AllowUserToResizeRows = False
        Me.dgvPaciente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPaciente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaciente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPaciente.Location = New System.Drawing.Point(15, 118)
        Me.dgvPaciente.Name = "dgvPaciente"
        Me.dgvPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaciente.Size = New System.Drawing.Size(289, 316)
        Me.dgvPaciente.TabIndex = 10
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
        Me.dgvDieta.Location = New System.Drawing.Point(341, 118)
        Me.dgvDieta.Name = "dgvDieta"
        Me.dgvDieta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDieta.Size = New System.Drawing.Size(291, 316)
        Me.dgvDieta.TabIndex = 11
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToResizeColumns = False
        Me.dgvDetalle.AllowUserToResizeRows = False
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDetalle.Location = New System.Drawing.Point(15, 465)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(617, 179)
        Me.dgvDetalle.TabIndex = 12
        '
        'fmrAsignarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(650, 582)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.dgvDieta)
        Me.Controls.Add(Me.dgvPaciente)
        Me.Controls.Add(Me.lblExplicacion)
        Me.Controls.Add(Me.lblDetallePlato)
        Me.Controls.Add(Me.lblDieta)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.btnAsignarPaciente)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "fmrAsignarPaciente"
        Me.Text = "Estudios"
        CType(Me.dgvPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnAsignarPaciente As Button
    Friend WithEvents lblPaciente As Label
    Friend WithEvents lblDieta As Label
    Friend WithEvents lblDetallePlato As Label
    Friend WithEvents lblExplicacion As Label
    Friend WithEvents dgvPaciente As DataGridView
    Friend WithEvents dgvDieta As DataGridView
    Friend WithEvents dgvDetalle As DataGridView
End Class
