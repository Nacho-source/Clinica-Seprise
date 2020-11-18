<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtencionPacientes
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
        Me.dgvAtencionPacientes = New System.Windows.Forms.DataGridView()
        Me.btnInternar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnDerivarEstudios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.dgvInsumosSumi = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvMedicamentosSumi = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnSuministrar = New System.Windows.Forms.Button()
        CType(Me.dgvAtencionPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInsumosSumi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedicamentosSumi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAtencionPacientes
        '
        Me.dgvAtencionPacientes.AllowUserToAddRows = False
        Me.dgvAtencionPacientes.AllowUserToDeleteRows = False
        Me.dgvAtencionPacientes.AllowUserToResizeColumns = False
        Me.dgvAtencionPacientes.AllowUserToResizeRows = False
        Me.dgvAtencionPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAtencionPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAtencionPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvAtencionPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAtencionPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAtencionPacientes.EnableHeadersVisualStyles = False
        Me.dgvAtencionPacientes.Location = New System.Drawing.Point(12, 30)
        Me.dgvAtencionPacientes.MultiSelect = False
        Me.dgvAtencionPacientes.Name = "dgvAtencionPacientes"
        Me.dgvAtencionPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAtencionPacientes.Size = New System.Drawing.Size(652, 311)
        Me.dgvAtencionPacientes.TabIndex = 1
        '
        'btnInternar
        '
        Me.btnInternar.Location = New System.Drawing.Point(507, 347)
        Me.btnInternar.Name = "btnInternar"
        Me.btnInternar.Size = New System.Drawing.Size(157, 54)
        Me.btnInternar.TabIndex = 8
        Me.btnInternar.Text = "Internar paciente"
        Me.btnInternar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 347)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(157, 54)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnDerivarEstudios
        '
        Me.btnDerivarEstudios.Location = New System.Drawing.Point(344, 347)
        Me.btnDerivarEstudios.Name = "btnDerivarEstudios"
        Me.btnDerivarEstudios.Size = New System.Drawing.Size(157, 54)
        Me.btnDerivarEstudios.TabIndex = 6
        Me.btnDerivarEstudios.Text = "Derivar a estudios"
        Me.btnDerivarEstudios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Pacientes en guardia"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(172, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(160, 29)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Actualizar estado"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'dgvInsumosSumi
        '
        Me.dgvInsumosSumi.AllowUserToAddRows = False
        Me.dgvInsumosSumi.AllowUserToDeleteRows = False
        Me.dgvInsumosSumi.AllowUserToResizeColumns = False
        Me.dgvInsumosSumi.AllowUserToResizeRows = False
        Me.dgvInsumosSumi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInsumosSumi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInsumosSumi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvInsumosSumi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInsumosSumi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvInsumosSumi.EnableHeadersVisualStyles = False
        Me.dgvInsumosSumi.Location = New System.Drawing.Point(670, 30)
        Me.dgvInsumosSumi.MultiSelect = False
        Me.dgvInsumosSumi.Name = "dgvInsumosSumi"
        Me.dgvInsumosSumi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInsumosSumi.Size = New System.Drawing.Size(363, 158)
        Me.dgvInsumosSumi.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(666, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Insumos suministrados"
        '
        'dgvMedicamentosSumi
        '
        Me.dgvMedicamentosSumi.AllowUserToAddRows = False
        Me.dgvMedicamentosSumi.AllowUserToDeleteRows = False
        Me.dgvMedicamentosSumi.AllowUserToResizeColumns = False
        Me.dgvMedicamentosSumi.AllowUserToResizeRows = False
        Me.dgvMedicamentosSumi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMedicamentosSumi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMedicamentosSumi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgvMedicamentosSumi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentosSumi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMedicamentosSumi.EnableHeadersVisualStyles = False
        Me.dgvMedicamentosSumi.Location = New System.Drawing.Point(670, 211)
        Me.dgvMedicamentosSumi.MultiSelect = False
        Me.dgvMedicamentosSumi.Name = "dgvMedicamentosSumi"
        Me.dgvMedicamentosSumi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentosSumi.Size = New System.Drawing.Size(363, 190)
        Me.dgvMedicamentosSumi.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(670, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Medicamentos suministrados"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(504, 0)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(160, 29)
        Me.btnAlta.TabIndex = 16
        Me.btnAlta.Text = "Dar alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'btnSuministrar
        '
        Me.btnSuministrar.Location = New System.Drawing.Point(338, 0)
        Me.btnSuministrar.Name = "btnSuministrar"
        Me.btnSuministrar.Size = New System.Drawing.Size(160, 29)
        Me.btnSuministrar.TabIndex = 17
        Me.btnSuministrar.Text = "Suministrar"
        Me.btnSuministrar.UseVisualStyleBackColor = True
        '
        'AtencionPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 411)
        Me.Controls.Add(Me.btnSuministrar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvMedicamentosSumi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvInsumosSumi)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInternar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnDerivarEstudios)
        Me.Controls.Add(Me.dgvAtencionPacientes)
        Me.Name = "AtencionPacientes"
        Me.Text = "Atencion pacientes"
        CType(Me.dgvAtencionPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInsumosSumi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedicamentosSumi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAtencionPacientes As DataGridView
    Friend WithEvents btnInternar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnDerivarEstudios As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents dgvInsumosSumi As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvMedicamentosSumi As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnSuministrar As Button
End Class
