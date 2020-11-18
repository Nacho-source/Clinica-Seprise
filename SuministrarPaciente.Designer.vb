<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuministrarPaciente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvInsumos = New System.Windows.Forms.DataGridView()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSuministrarInsumos = New System.Windows.Forms.Button()
        Me.txtCantIns = New System.Windows.Forms.NumericUpDown()
        Me.btnSuministrarMedicamentos = New System.Windows.Forms.Button()
        Me.txtCantMeds = New System.Windows.Forms.NumericUpDown()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.dgvInsumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantIns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantMeds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insumos disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(364, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Medicamentos disponibles"
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
        Me.dgvInsumos.Location = New System.Drawing.Point(31, 70)
        Me.dgvInsumos.MultiSelect = False
        Me.dgvInsumos.Name = "dgvInsumos"
        Me.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInsumos.Size = New System.Drawing.Size(330, 241)
        Me.dgvInsumos.TabIndex = 13
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
        Me.dgvMedicamentos.Location = New System.Drawing.Point(367, 70)
        Me.dgvMedicamentos.MultiSelect = False
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentos.Size = New System.Drawing.Size(326, 241)
        Me.dgvMedicamentos.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cantidad"
        '
        'btnSuministrarInsumos
        '
        Me.btnSuministrarInsumos.Location = New System.Drawing.Point(204, 395)
        Me.btnSuministrarInsumos.Name = "btnSuministrarInsumos"
        Me.btnSuministrarInsumos.Size = New System.Drawing.Size(157, 54)
        Me.btnSuministrarInsumos.TabIndex = 19
        Me.btnSuministrarInsumos.Text = "Suministrar Insumo"
        Me.btnSuministrarInsumos.UseVisualStyleBackColor = True
        '
        'txtCantIns
        '
        Me.txtCantIns.Location = New System.Drawing.Point(224, 344)
        Me.txtCantIns.Name = "txtCantIns"
        Me.txtCantIns.Size = New System.Drawing.Size(137, 20)
        Me.txtCantIns.TabIndex = 20
        '
        'btnSuministrarMedicamentos
        '
        Me.btnSuministrarMedicamentos.Location = New System.Drawing.Point(536, 395)
        Me.btnSuministrarMedicamentos.Name = "btnSuministrarMedicamentos"
        Me.btnSuministrarMedicamentos.Size = New System.Drawing.Size(157, 54)
        Me.btnSuministrarMedicamentos.TabIndex = 21
        Me.btnSuministrarMedicamentos.Text = "Suministrar Medicamento"
        Me.btnSuministrarMedicamentos.UseVisualStyleBackColor = True
        '
        'txtCantMeds
        '
        Me.txtCantMeds.Location = New System.Drawing.Point(556, 344)
        Me.txtCantMeds.Name = "txtCantMeds"
        Me.txtCantMeds.Size = New System.Drawing.Size(137, 20)
        Me.txtCantMeds.TabIndex = 22
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(12, 395)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(117, 54)
        Me.btnAtras.TabIndex = 23
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'SuministrarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 461)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.txtCantMeds)
        Me.Controls.Add(Me.btnSuministrarMedicamentos)
        Me.Controls.Add(Me.txtCantIns)
        Me.Controls.Add(Me.btnSuministrarInsumos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.Controls.Add(Me.dgvInsumos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SuministrarPaciente"
        Me.Text = "SuministrarPaciente"
        CType(Me.dgvInsumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantIns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantMeds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvInsumos As DataGridView
    Friend WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSuministrarInsumos As Button
    Friend WithEvents txtCantIns As NumericUpDown
    Friend WithEvents btnSuministrarMedicamentos As Button
    Friend WithEvents txtCantMeds As NumericUpDown
    Friend WithEvents btnAtras As Button
End Class
