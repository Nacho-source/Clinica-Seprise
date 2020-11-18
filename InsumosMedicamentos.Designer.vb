<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsumosMedicamentos
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
        Me.dgvInsumos = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.btnCambiarMed = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInsumos
        '
        Me.dgvInsumos.AllowUserToAddRows = False
        Me.dgvInsumos.AllowUserToDeleteRows = False
        Me.dgvInsumos.AllowUserToResizeColumns = False
        Me.dgvInsumos.AllowUserToResizeRows = False
        Me.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInsumos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInsumos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvInsumos.EnableHeadersVisualStyles = False
        Me.dgvInsumos.Location = New System.Drawing.Point(29, 32)
        Me.dgvInsumos.MultiSelect = False
        Me.dgvInsumos.Name = "dgvInsumos"
        Me.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInsumos.Size = New System.Drawing.Size(458, 309)
        Me.dgvInsumos.TabIndex = 2
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 347)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(157, 54)
        Me.btnAtras.TabIndex = 11
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(315, 347)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(172, 54)
        Me.btnCambiar.TabIndex = 12
        Me.btnCambiar.Text = "Modificar Insumo"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToAddRows = False
        Me.dgvMedicamentos.AllowUserToDeleteRows = False
        Me.dgvMedicamentos.AllowUserToResizeColumns = False
        Me.dgvMedicamentos.AllowUserToResizeRows = False
        Me.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMedicamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMedicamentos.EnableHeadersVisualStyles = False
        Me.dgvMedicamentos.Location = New System.Drawing.Point(501, 32)
        Me.dgvMedicamentos.MultiSelect = False
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentos.Size = New System.Drawing.Size(458, 309)
        Me.dgvMedicamentos.TabIndex = 13
        '
        'btnCambiarMed
        '
        Me.btnCambiarMed.Location = New System.Drawing.Point(787, 347)
        Me.btnCambiarMed.Name = "btnCambiarMed"
        Me.btnCambiarMed.Size = New System.Drawing.Size(172, 54)
        Me.btnCambiarMed.TabIndex = 14
        Me.btnCambiarMed.Text = "Modificar Medicamento"
        Me.btnCambiarMed.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Insumos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(497, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Medicamentos"
        '
        'InsumosMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCambiarMed)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvInsumos)
        Me.Name = "InsumosMedicamentos"
        Me.Text = "Insumos Guardia"
        CType(Me.dgvInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvInsumos As DataGridView
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnCambiar As Button
    Friend WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents btnCambiarMed As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
