<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaEsperaCE
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSM = New System.Windows.Forms.RadioButton()
        Me.rbFK = New System.Windows.Forms.RadioButton()
        Me.rbCC = New System.Windows.Forms.RadioButton()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.gbFiltraje = New System.Windows.Forms.GroupBox()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.rbPaciente = New System.Windows.Forms.RadioButton()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.cboFecha = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAusente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAsistio = New System.Windows.Forms.Button()
        Me.dtgPacienteEspera = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1.SuspendLayout()
        Me.gbFiltraje.SuspendLayout()
        CType(Me.dtgPacienteEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSM)
        Me.GroupBox1.Controls.Add(Me.rbFK)
        Me.GroupBox1.Controls.Add(Me.rbCC)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 153)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Consulta"
        '
        'rbSM
        '
        Me.rbSM.AutoSize = True
        Me.rbSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSM.Location = New System.Drawing.Point(36, 111)
        Me.rbSM.Name = "rbSM"
        Me.rbSM.Size = New System.Drawing.Size(111, 22)
        Me.rbSM.TabIndex = 22
        Me.rbSM.TabStop = True
        Me.rbSM.Text = "Salud Mental"
        Me.rbSM.UseVisualStyleBackColor = True
        '
        'rbFK
        '
        Me.rbFK.AutoSize = True
        Me.rbFK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFK.Location = New System.Drawing.Point(36, 65)
        Me.rbFK.Name = "rbFK"
        Me.rbFK.Size = New System.Drawing.Size(136, 22)
        Me.rbFK.TabIndex = 21
        Me.rbFK.TabStop = True
        Me.rbFK.Text = "Fisiokinesiología"
        Me.rbFK.UseVisualStyleBackColor = True
        '
        'rbCC
        '
        Me.rbCC.AutoSize = True
        Me.rbCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCC.Location = New System.Drawing.Point(37, 19)
        Me.rbCC.Name = "rbCC"
        Me.rbCC.Size = New System.Drawing.Size(138, 22)
        Me.rbCC.TabIndex = 20
        Me.rbCC.TabStop = True
        Me.rbCC.Text = "Consulta Común"
        Me.rbCC.UseVisualStyleBackColor = True
        '
        'btnConsulta
        '
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Location = New System.Drawing.Point(683, 406)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(95, 43)
        Me.btnConsulta.TabIndex = 22
        Me.btnConsulta.Text = "INICIAR CONSULTA"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'gbFiltraje
        '
        Me.gbFiltraje.Controls.Add(Me.btnClean)
        Me.gbFiltraje.Controls.Add(Me.rbPaciente)
        Me.gbFiltraje.Controls.Add(Me.rbFecha)
        Me.gbFiltraje.Controls.Add(Me.btnFiltrar)
        Me.gbFiltraje.Controls.Add(Me.txtPaciente)
        Me.gbFiltraje.Controls.Add(Me.cboFecha)
        Me.gbFiltraje.Location = New System.Drawing.Point(240, 45)
        Me.gbFiltraje.Name = "gbFiltraje"
        Me.gbFiltraje.Size = New System.Drawing.Size(528, 154)
        Me.gbFiltraje.TabIndex = 19
        Me.gbFiltraje.TabStop = False
        Me.gbFiltraje.Text = "Filtrar Lista de Espera"
        '
        'btnClean
        '
        Me.btnClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClean.Location = New System.Drawing.Point(385, 93)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(116, 44)
        Me.btnClean.TabIndex = 9
        Me.btnClean.Text = "BLANQUEAR FILTRAJE"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'rbPaciente
        '
        Me.rbPaciente.AutoSize = True
        Me.rbPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPaciente.Location = New System.Drawing.Point(58, 105)
        Me.rbPaciente.Name = "rbPaciente"
        Me.rbPaciente.Size = New System.Drawing.Size(83, 22)
        Me.rbPaciente.TabIndex = 8
        Me.rbPaciente.TabStop = True
        Me.rbPaciente.Text = "Paciente"
        Me.rbPaciente.UseVisualStyleBackColor = True
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFecha.Location = New System.Drawing.Point(58, 45)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(67, 22)
        Me.rbFecha.TabIndex = 7
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Location = New System.Drawing.Point(385, 32)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(116, 40)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "FILTRAR"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtPaciente
        '
        Me.txtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaciente.Location = New System.Drawing.Point(182, 106)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(176, 24)
        Me.txtPaciente.TabIndex = 5
        '
        'cboFecha
        '
        Me.cboFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFecha.FormattingEnabled = True
        Me.cboFecha.Location = New System.Drawing.Point(182, 41)
        Me.cboFecha.Name = "cboFecha"
        Me.cboFecha.Size = New System.Drawing.Size(176, 26)
        Me.cboFecha.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(683, 486)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 38)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "VOLVER"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAusente
        '
        Me.btnAusente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAusente.Location = New System.Drawing.Point(683, 325)
        Me.btnAusente.Name = "btnAusente"
        Me.btnAusente.Size = New System.Drawing.Size(95, 44)
        Me.btnAusente.TabIndex = 16
        Me.btnAusente.Text = "AUSENTE"
        Me.btnAusente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Seleccione un paciente para realizar una accion: "
        '
        'btnAsistio
        '
        Me.btnAsistio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsistio.Location = New System.Drawing.Point(683, 236)
        Me.btnAsistio.Name = "btnAsistio"
        Me.btnAsistio.Size = New System.Drawing.Size(95, 43)
        Me.btnAsistio.TabIndex = 14
        Me.btnAsistio.Text = "ASISTIÓ"
        Me.btnAsistio.UseVisualStyleBackColor = True
        '
        'dtgPacienteEspera
        '
        Me.dtgPacienteEspera.AllowUserToOrderColumns = True
        Me.dtgPacienteEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPacienteEspera.Location = New System.Drawing.Point(38, 236)
        Me.dtgPacienteEspera.Name = "dtgPacienteEspera"
        Me.dtgPacienteEspera.Size = New System.Drawing.Size(626, 297)
        Me.dtgPacienteEspera.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Lista Pacientes en espera"
        '
        'ListaEsperaCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 634)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.gbFiltraje)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAusente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAsistio)
        Me.Controls.Add(Me.dtgPacienteEspera)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListaEsperaCE"
        Me.Text = "ListaEsperaCE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFiltraje.ResumeLayout(False)
        Me.gbFiltraje.PerformLayout()
        CType(Me.dtgPacienteEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSM As System.Windows.Forms.RadioButton
    Friend WithEvents rbFK As System.Windows.Forms.RadioButton
    Friend WithEvents rbCC As System.Windows.Forms.RadioButton
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents gbFiltraje As System.Windows.Forms.GroupBox
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents rbPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents cboFecha As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAusente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAsistio As System.Windows.Forms.Button
    Friend WithEvents dtgPacienteEspera As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
