<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaEspera
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
        Me.dgvListaEspera = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.dgvMedicosDisponibles = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvUrgencias = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminarNormal = New System.Windows.Forms.Button()
        Me.btnAtenderListaNormal = New System.Windows.Forms.Button()
        Me.btnAtenderListaUrgencia = New System.Windows.Forms.Button()
        Me.btnEliminarUrgencia = New System.Windows.Forms.Button()
        CType(Me.dgvListaEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedicosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUrgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaEspera
        '
        Me.dgvListaEspera.AllowUserToAddRows = False
        Me.dgvListaEspera.AllowUserToDeleteRows = False
        Me.dgvListaEspera.AllowUserToResizeColumns = False
        Me.dgvListaEspera.AllowUserToResizeRows = False
        Me.dgvListaEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListaEspera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaEspera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListaEspera.EnableHeadersVisualStyles = False
        Me.dgvListaEspera.Location = New System.Drawing.Point(16, 210)
        Me.dgvListaEspera.MultiSelect = False
        Me.dgvListaEspera.Name = "dgvListaEspera"
        Me.dgvListaEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaEspera.Size = New System.Drawing.Size(641, 176)
        Me.dgvListaEspera.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(194, 392)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(172, 54)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar a lista"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(16, 392)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(172, 54)
        Me.btnAtras.TabIndex = 2
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'dgvMedicosDisponibles
        '
        Me.dgvMedicosDisponibles.AllowUserToAddRows = False
        Me.dgvMedicosDisponibles.AllowUserToDeleteRows = False
        Me.dgvMedicosDisponibles.AllowUserToResizeColumns = False
        Me.dgvMedicosDisponibles.AllowUserToResizeRows = False
        Me.dgvMedicosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMedicosDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMedicosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicosDisponibles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMedicosDisponibles.EnableHeadersVisualStyles = False
        Me.dgvMedicosDisponibles.Location = New System.Drawing.Point(663, 29)
        Me.dgvMedicosDisponibles.MultiSelect = False
        Me.dgvMedicosDisponibles.Name = "dgvMedicosDisponibles"
        Me.dgvMedicosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicosDisponibles.Size = New System.Drawing.Size(308, 357)
        Me.dgvMedicosDisponibles.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(659, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Medicos disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Lista de espera"
        '
        'dgvUrgencias
        '
        Me.dgvUrgencias.AllowUserToAddRows = False
        Me.dgvUrgencias.AllowUserToDeleteRows = False
        Me.dgvUrgencias.AllowUserToResizeColumns = False
        Me.dgvUrgencias.AllowUserToResizeRows = False
        Me.dgvUrgencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUrgencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUrgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUrgencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUrgencias.EnableHeadersVisualStyles = False
        Me.dgvUrgencias.Location = New System.Drawing.Point(16, 29)
        Me.dgvUrgencias.MultiSelect = False
        Me.dgvUrgencias.Name = "dgvUrgencias"
        Me.dgvUrgencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUrgencias.Size = New System.Drawing.Size(641, 151)
        Me.dgvUrgencias.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lista de urgencias"
        '
        'btnEliminarNormal
        '
        Me.btnEliminarNormal.Location = New System.Drawing.Point(486, 181)
        Me.btnEliminarNormal.Name = "btnEliminarNormal"
        Me.btnEliminarNormal.Size = New System.Drawing.Size(171, 26)
        Me.btnEliminarNormal.TabIndex = 9
        Me.btnEliminarNormal.Text = "Eliminar paciente de la lista"
        Me.btnEliminarNormal.UseVisualStyleBackColor = True
        '
        'btnAtenderListaNormal
        '
        Me.btnAtenderListaNormal.Location = New System.Drawing.Point(157, 181)
        Me.btnAtenderListaNormal.Name = "btnAtenderListaNormal"
        Me.btnAtenderListaNormal.Size = New System.Drawing.Size(184, 26)
        Me.btnAtenderListaNormal.TabIndex = 10
        Me.btnAtenderListaNormal.Text = "Atender Paciente"
        Me.btnAtenderListaNormal.UseVisualStyleBackColor = True
        '
        'btnAtenderListaUrgencia
        '
        Me.btnAtenderListaUrgencia.Location = New System.Drawing.Point(157, 0)
        Me.btnAtenderListaUrgencia.Name = "btnAtenderListaUrgencia"
        Me.btnAtenderListaUrgencia.Size = New System.Drawing.Size(184, 26)
        Me.btnAtenderListaUrgencia.TabIndex = 11
        Me.btnAtenderListaUrgencia.Text = "Atender Paciente"
        Me.btnAtenderListaUrgencia.UseVisualStyleBackColor = True
        '
        'btnEliminarUrgencia
        '
        Me.btnEliminarUrgencia.Location = New System.Drawing.Point(486, 0)
        Me.btnEliminarUrgencia.Name = "btnEliminarUrgencia"
        Me.btnEliminarUrgencia.Size = New System.Drawing.Size(171, 26)
        Me.btnEliminarUrgencia.TabIndex = 12
        Me.btnEliminarUrgencia.Text = "Eliminar paciente de la lista"
        Me.btnEliminarUrgencia.UseVisualStyleBackColor = True
        '
        'frmListaEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 458)
        Me.Controls.Add(Me.btnEliminarUrgencia)
        Me.Controls.Add(Me.btnAtenderListaUrgencia)
        Me.Controls.Add(Me.btnAtenderListaNormal)
        Me.Controls.Add(Me.btnEliminarNormal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvUrgencias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMedicosDisponibles)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvListaEspera)
        Me.Name = "frmListaEspera"
        Me.Text = "ListaEspera"
        CType(Me.dgvListaEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedicosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUrgencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListaEspera As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents dgvMedicosDisponibles As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvUrgencias As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarNormal As Button
    Friend WithEvents btnAtenderListaNormal As Button
    Friend WithEvents btnAtenderListaUrgencia As Button
    Friend WithEvents btnEliminarUrgencia As Button
End Class
