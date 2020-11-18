<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgendaTurnos
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
        Me.gbTurno = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEspecificaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombreP = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cboObrasSociales = New System.Windows.Forms.ComboBox()
        Me.lblObraS = New System.Windows.Forms.Label()
        Me.cboEstudios = New System.Windows.Forms.ComboBox()
        Me.rbtNo = New System.Windows.Forms.RadioButton()
        Me.rbtSi = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEstudio = New System.Windows.Forms.Label()
        Me.cboHorario = New System.Windows.Forms.ComboBox()
        Me.dtpDia = New System.Windows.Forms.DateTimePicker()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.btnTurno = New System.Windows.Forms.Button()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.gbCTurno = New System.Windows.Forms.GroupBox()
        Me.lblNombreEstudio = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbTurno.SuspendLayout()
        Me.gbCTurno.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTurno
        '
        Me.gbTurno.Controls.Add(Me.btnCancelar)
        Me.gbTurno.Controls.Add(Me.cboMedico)
        Me.gbTurno.Controls.Add(Me.Label4)
        Me.gbTurno.Controls.Add(Me.Label3)
        Me.gbTurno.Controls.Add(Me.txtEspecificaciones)
        Me.gbTurno.Controls.Add(Me.Label1)
        Me.gbTurno.Controls.Add(Me.lblNombreP)
        Me.gbTurno.Controls.Add(Me.btnCalcular)
        Me.gbTurno.Controls.Add(Me.cboObrasSociales)
        Me.gbTurno.Controls.Add(Me.lblObraS)
        Me.gbTurno.Controls.Add(Me.cboEstudios)
        Me.gbTurno.Controls.Add(Me.rbtNo)
        Me.gbTurno.Controls.Add(Me.rbtSi)
        Me.gbTurno.Controls.Add(Me.Label2)
        Me.gbTurno.Controls.Add(Me.lblEstudio)
        Me.gbTurno.Controls.Add(Me.cboHorario)
        Me.gbTurno.Controls.Add(Me.dtpDia)
        Me.gbTurno.Controls.Add(Me.lblHorario)
        Me.gbTurno.Controls.Add(Me.lblDia)
        Me.gbTurno.Controls.Add(Me.btnTurno)
        Me.gbTurno.Controls.Add(Me.lblPaciente)
        Me.gbTurno.Location = New System.Drawing.Point(34, 32)
        Me.gbTurno.Name = "gbTurno"
        Me.gbTurno.Size = New System.Drawing.Size(605, 417)
        Me.gbTurno.TabIndex = 0
        Me.gbTurno.TabStop = False
        Me.gbTurno.Text = "Seleccionar turno"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(388, 347)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 32)
        Me.btnCancelar.TabIndex = 57
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cboMedico
        '
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(252, 100)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(152, 21)
        Me.cboMedico.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Medico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "*Si no hay especificaciones poner ""Sin especificaciones"""
        '
        'txtEspecificaciones
        '
        Me.txtEspecificaciones.Location = New System.Drawing.Point(105, 216)
        Me.txtEspecificaciones.Name = "txtEspecificaciones"
        Me.txtEspecificaciones.Size = New System.Drawing.Size(422, 20)
        Me.txtEspecificaciones.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Especificaciones: "
        '
        'lblNombreP
        '
        Me.lblNombreP.AutoSize = True
        Me.lblNombreP.Location = New System.Drawing.Point(62, 33)
        Me.lblNombreP.Name = "lblNombreP"
        Me.lblNombreP.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreP.TabIndex = 51
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(424, 162)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(103, 27)
        Me.btnCalcular.TabIndex = 26
        Me.btnCalcular.Text = "Calcular cobertura"
        Me.btnCalcular.UseVisualStyleBackColor = True
        Me.btnCalcular.Visible = False
        '
        'cboObrasSociales
        '
        Me.cboObrasSociales.FormattingEnabled = True
        Me.cboObrasSociales.Location = New System.Drawing.Point(252, 168)
        Me.cboObrasSociales.Name = "cboObrasSociales"
        Me.cboObrasSociales.Size = New System.Drawing.Size(152, 21)
        Me.cboObrasSociales.TabIndex = 25
        Me.cboObrasSociales.Visible = False
        '
        'lblObraS
        '
        Me.lblObraS.AutoSize = True
        Me.lblObraS.Location = New System.Drawing.Point(249, 139)
        Me.lblObraS.Name = "lblObraS"
        Me.lblObraS.Size = New System.Drawing.Size(121, 13)
        Me.lblObraS.TabIndex = 24
        Me.lblObraS.Text = "Seleccione Obra Social:"
        Me.lblObraS.Visible = False
        '
        'cboEstudios
        '
        Me.cboEstudios.FormattingEnabled = True
        Me.cboEstudios.ItemHeight = 13
        Me.cboEstudios.Location = New System.Drawing.Point(11, 100)
        Me.cboEstudios.Name = "cboEstudios"
        Me.cboEstudios.Size = New System.Drawing.Size(200, 21)
        Me.cboEstudios.TabIndex = 50
        '
        'rbtNo
        '
        Me.rbtNo.AutoSize = True
        Me.rbtNo.Location = New System.Drawing.Point(63, 168)
        Me.rbtNo.Name = "rbtNo"
        Me.rbtNo.Size = New System.Drawing.Size(39, 17)
        Me.rbtNo.TabIndex = 22
        Me.rbtNo.TabStop = True
        Me.rbtNo.Text = "No"
        Me.rbtNo.UseVisualStyleBackColor = True
        '
        'rbtSi
        '
        Me.rbtSi.AutoSize = True
        Me.rbtSi.Location = New System.Drawing.Point(15, 168)
        Me.rbtSi.Name = "rbtSi"
        Me.rbtSi.Size = New System.Drawing.Size(34, 17)
        Me.rbtSi.TabIndex = 21
        Me.rbtSi.TabStop = True
        Me.rbtSi.Text = "Si"
        Me.rbtSi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "¿Posee Obra Social? "
        '
        'lblEstudio
        '
        Me.lblEstudio.AutoSize = True
        Me.lblEstudio.Location = New System.Drawing.Point(12, 71)
        Me.lblEstudio.Name = "lblEstudio"
        Me.lblEstudio.Size = New System.Drawing.Size(90, 13)
        Me.lblEstudio.TabIndex = 19
        Me.lblEstudio.Text = "Estudio a realizar:"
        '
        'cboHorario
        '
        Me.cboHorario.FormattingEnabled = True
        Me.cboHorario.Location = New System.Drawing.Point(252, 310)
        Me.cboHorario.Name = "cboHorario"
        Me.cboHorario.Size = New System.Drawing.Size(152, 21)
        Me.cboHorario.TabIndex = 18
        '
        'dtpDia
        '
        Me.dtpDia.Location = New System.Drawing.Point(11, 311)
        Me.dtpDia.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(200, 20)
        Me.dtpDia.TabIndex = 17
        Me.dtpDia.Value = New Date(2017, 11, 6, 0, 0, 0, 0)
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(249, 280)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(106, 13)
        Me.lblHorario.TabIndex = 16
        Me.lblHorario.Text = "Seleccion el horario: "
        Me.lblHorario.Visible = False
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Location = New System.Drawing.Point(8, 280)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(94, 13)
        Me.lblDia.TabIndex = 15
        Me.lblDia.Text = "Seleccione el dia: "
        '
        'btnTurno
        '
        Me.btnTurno.Location = New System.Drawing.Point(493, 347)
        Me.btnTurno.Name = "btnTurno"
        Me.btnTurno.Size = New System.Drawing.Size(87, 34)
        Me.btnTurno.TabIndex = 8
        Me.btnTurno.Text = "Reservar"
        Me.btnTurno.UseVisualStyleBackColor = True
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(12, 33)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(55, 13)
        Me.lblPaciente.TabIndex = 0
        Me.lblPaciente.Text = "Paciente: "
        '
        'gbCTurno
        '
        Me.gbCTurno.Controls.Add(Me.lblNombreEstudio)
        Me.gbCTurno.Controls.Add(Me.btnImprimir)
        Me.gbCTurno.Controls.Add(Me.lblFecha)
        Me.gbCTurno.Controls.Add(Me.lblHora)
        Me.gbCTurno.Controls.Add(Me.Label8)
        Me.gbCTurno.Controls.Add(Me.Label7)
        Me.gbCTurno.Controls.Add(Me.Label6)
        Me.gbCTurno.Controls.Add(Me.Label5)
        Me.gbCTurno.Location = New System.Drawing.Point(34, 24)
        Me.gbCTurno.Name = "gbCTurno"
        Me.gbCTurno.Size = New System.Drawing.Size(598, 170)
        Me.gbCTurno.TabIndex = 1
        Me.gbCTurno.TabStop = False
        Me.gbCTurno.Text = "Comprobante de Turno"
        Me.gbCTurno.Visible = False
        '
        'lblNombreEstudio
        '
        Me.lblNombreEstudio.AutoSize = True
        Me.lblNombreEstudio.Location = New System.Drawing.Point(115, 41)
        Me.lblNombreEstudio.Name = "lblNombreEstudio"
        Me.lblNombreEstudio.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreEstudio.TabIndex = 7
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(516, 144)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 20)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(59, 62)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 5
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(69, 91)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(0, 13)
        Me.lblHora.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(363, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "*En caso de no poder asistir,se debe avisar con  24 horas con anticipación."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Horario: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Fecha: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Estudio a Realizar:"
        '
        'AgendaTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 481)
        Me.Controls.Add(Me.gbCTurno)
        Me.Controls.Add(Me.gbTurno)
        Me.Name = "AgendaTurnos"
        Me.Text = "Estudios"
        Me.gbTurno.ResumeLayout(False)
        Me.gbTurno.PerformLayout()
        Me.gbCTurno.ResumeLayout(False)
        Me.gbCTurno.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbTurno As System.Windows.Forms.GroupBox
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents btnTurno As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents cboObrasSociales As System.Windows.Forms.ComboBox
    Friend WithEvents lblObraS As System.Windows.Forms.Label
    Friend WithEvents cboEstudios As System.Windows.Forms.ComboBox
    Friend WithEvents rbtNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEstudio As System.Windows.Forms.Label
    Friend WithEvents cboHorario As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents lblNombreP As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEspecificaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbCTurno As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNombreEstudio As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
