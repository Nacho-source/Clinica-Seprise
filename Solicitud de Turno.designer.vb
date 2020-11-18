<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolicitudTurno
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
        Me.lblTurnoConsulta = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.txtPaciente = New System.Windows.Forms.TextBox()
        Me.lblFH = New System.Windows.Forms.Label()
        Me.cboFH = New System.Windows.Forms.ComboBox()
        Me.lblTipoTurno = New System.Windows.Forms.Label()
        Me.rbSM = New System.Windows.Forms.RadioButton()
        Me.rbFK = New System.Windows.Forms.RadioButton()
        Me.rbCC = New System.Windows.Forms.RadioButton()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnSolicitud = New System.Windows.Forms.Button()
        Me.btnMedico = New System.Windows.Forms.Button()
        Me.btnSobreTurno = New System.Windows.Forms.Button()
        Me.txtMedico = New System.Windows.Forms.TextBox()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTurnoConsulta
        '
        Me.lblTurnoConsulta.AutoSize = True
        Me.lblTurnoConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnoConsulta.Location = New System.Drawing.Point(33, 26)
        Me.lblTurnoConsulta.Name = "lblTurnoConsulta"
        Me.lblTurnoConsulta.Size = New System.Drawing.Size(476, 29)
        Me.lblTurnoConsulta.TabIndex = 0
        Me.lblTurnoConsulta.Text = "Solicitud de Turno de Consulta Externa:"
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaciente.Location = New System.Drawing.Point(35, 87)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(107, 20)
        Me.lblPaciente.TabIndex = 3
        Me.lblPaciente.Text = "DNI Paciente:"
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(148, 87)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(142, 20)
        Me.txtPaciente.TabIndex = 4
        '
        'lblFH
        '
        Me.lblFH.AutoSize = True
        Me.lblFH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFH.Location = New System.Drawing.Point(35, 124)
        Me.lblFH.Name = "lblFH"
        Me.lblFH.Size = New System.Drawing.Size(105, 20)
        Me.lblFH.TabIndex = 5
        Me.lblFH.Text = "Fecha y hora:"
        '
        'cboFH
        '
        Me.cboFH.FormattingEnabled = True
        Me.cboFH.Location = New System.Drawing.Point(146, 126)
        Me.cboFH.Name = "cboFH"
        Me.cboFH.Size = New System.Drawing.Size(144, 21)
        Me.cboFH.TabIndex = 11
        '
        'lblTipoTurno
        '
        Me.lblTipoTurno.AutoSize = True
        Me.lblTipoTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoTurno.Location = New System.Drawing.Point(36, 187)
        Me.lblTipoTurno.Name = "lblTipoTurno"
        Me.lblTipoTurno.Size = New System.Drawing.Size(104, 18)
        Me.lblTipoTurno.TabIndex = 20
        Me.lblTipoTurno.Text = "Tipo de Turno:"
        '
        'rbSM
        '
        Me.rbSM.AutoSize = True
        Me.rbSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSM.Location = New System.Drawing.Point(38, 328)
        Me.rbSM.Name = "rbSM"
        Me.rbSM.Size = New System.Drawing.Size(111, 22)
        Me.rbSM.TabIndex = 19
        Me.rbSM.TabStop = True
        Me.rbSM.Text = "Salud Mental"
        Me.rbSM.UseVisualStyleBackColor = True
        '
        'rbFK
        '
        Me.rbFK.AutoSize = True
        Me.rbFK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFK.Location = New System.Drawing.Point(38, 282)
        Me.rbFK.Name = "rbFK"
        Me.rbFK.Size = New System.Drawing.Size(136, 22)
        Me.rbFK.TabIndex = 18
        Me.rbFK.TabStop = True
        Me.rbFK.Text = "Fisiokinesiología"
        Me.rbFK.UseVisualStyleBackColor = True
        '
        'rbCC
        '
        Me.rbCC.AutoSize = True
        Me.rbCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCC.Location = New System.Drawing.Point(39, 236)
        Me.rbCC.Name = "rbCC"
        Me.rbCC.Size = New System.Drawing.Size(138, 22)
        Me.rbCC.TabIndex = 17
        Me.rbCC.TabStop = True
        Me.rbCC.Text = "Consulta Común"
        Me.rbCC.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 369)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(128, 43)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSolicitud
        '
        Me.btnSolicitud.Location = New System.Drawing.Point(368, 359)
        Me.btnSolicitud.Name = "btnSolicitud"
        Me.btnSolicitud.Size = New System.Drawing.Size(141, 63)
        Me.btnSolicitud.TabIndex = 10
        Me.btnSolicitud.Text = "SOLICITAR TURNO"
        Me.btnSolicitud.UseVisualStyleBackColor = True
        '
        'btnMedico
        '
        Me.btnMedico.Location = New System.Drawing.Point(350, 78)
        Me.btnMedico.Name = "btnMedico"
        Me.btnMedico.Size = New System.Drawing.Size(148, 41)
        Me.btnMedico.TabIndex = 23
        Me.btnMedico.Text = "¿Desea solicitar un medico en particular?"
        Me.btnMedico.UseVisualStyleBackColor = True
        '
        'btnSobreTurno
        '
        Me.btnSobreTurno.Location = New System.Drawing.Point(210, 228)
        Me.btnSobreTurno.Name = "btnSobreTurno"
        Me.btnSobreTurno.Size = New System.Drawing.Size(111, 40)
        Me.btnSobreTurno.TabIndex = 22
        Me.btnSobreTurno.Text = "Solicitar sobreturno"
        Me.btnSobreTurno.UseVisualStyleBackColor = True
        '
        'txtMedico
        '
        Me.txtMedico.Enabled = False
        Me.txtMedico.Location = New System.Drawing.Point(350, 144)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.Size = New System.Drawing.Size(148, 20)
        Me.txtMedico.TabIndex = 24
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedico.Location = New System.Drawing.Point(347, 122)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(153, 18)
        Me.lblMedico.TabIndex = 25
        Me.lblMedico.Text = "Médico seleccionado:"
        '
        'SolicitudTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 446)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.txtMedico)
        Me.Controls.Add(Me.btnMedico)
        Me.Controls.Add(Me.btnSobreTurno)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTipoTurno)
        Me.Controls.Add(Me.rbSM)
        Me.Controls.Add(Me.rbFK)
        Me.Controls.Add(Me.rbCC)
        Me.Controls.Add(Me.cboFH)
        Me.Controls.Add(Me.btnSolicitud)
        Me.Controls.Add(Me.lblFH)
        Me.Controls.Add(Me.txtPaciente)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lblTurnoConsulta)
        Me.Enabled = False
        Me.Name = "SolicitudTurno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTurnoConsulta As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents lblFH As System.Windows.Forms.Label
    Friend WithEvents cboFH As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoTurno As System.Windows.Forms.Label
    Friend WithEvents rbSM As System.Windows.Forms.RadioButton
    Friend WithEvents rbFK As System.Windows.Forms.RadioButton
    Friend WithEvents rbCC As System.Windows.Forms.RadioButton
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnSolicitud As System.Windows.Forms.Button
    Friend WithEvents btnMedico As System.Windows.Forms.Button
    Friend WithEvents btnSobreTurno As System.Windows.Forms.Button
    Friend WithEvents txtMedico As System.Windows.Forms.TextBox
    Friend WithEvents lblMedico As System.Windows.Forms.Label

End Class
