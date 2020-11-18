<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoMedicoCE
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.rdbDni = New System.Windows.Forms.RadioButton()
        Me.rdbCodigo = New System.Windows.Forms.RadioButton()
        Me.cmdDatos = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtCodMed = New System.Windows.Forms.TextBox()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.rdbAusente = New System.Windows.Forms.RadioButton()
        Me.rdbPrecente = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Validación Ingreso de Medico y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Asignación Insumos y Medicamentos"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(538, 449)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(128, 67)
        Me.cmdAceptar.TabIndex = 9
        Me.cmdAceptar.Text = "VALIDAR ASISTENCIA"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(116, 449)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(128, 67)
        Me.cmdBack.TabIndex = 10
        Me.cmdBack.Text = "VOLVER"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.rdbDni)
        Me.GroupBox1.Controls.Add(Me.rdbCodigo)
        Me.GroupBox1.Controls.Add(Me.cmdDatos)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtCodMed)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 166)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso Diario de Medico"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(458, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 22
        Me.lblFecha.Text = "Label2"
        '
        'rdbDni
        '
        Me.rdbDni.AutoSize = True
        Me.rdbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDni.Location = New System.Drawing.Point(47, 59)
        Me.rdbDni.Name = "rdbDni"
        Me.rdbDni.Size = New System.Drawing.Size(167, 20)
        Me.rdbDni.TabIndex = 21
        Me.rdbDni.TabStop = True
        Me.rdbDni.Text = "Ingrese DNI del Medico"
        Me.rdbDni.UseVisualStyleBackColor = True
        '
        'rdbCodigo
        '
        Me.rdbCodigo.AutoSize = True
        Me.rdbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCodigo.Location = New System.Drawing.Point(47, 17)
        Me.rdbCodigo.Name = "rdbCodigo"
        Me.rdbCodigo.Size = New System.Drawing.Size(182, 20)
        Me.rdbCodigo.TabIndex = 20
        Me.rdbCodigo.TabStop = True
        Me.rdbCodigo.Text = "Ingrese Codgo de Medico"
        Me.rdbCodigo.UseVisualStyleBackColor = True
        '
        'cmdDatos
        '
        Me.cmdDatos.Location = New System.Drawing.Point(172, 109)
        Me.cmdDatos.Name = "cmdDatos"
        Me.cmdDatos.Size = New System.Drawing.Size(101, 51)
        Me.cmdDatos.TabIndex = 19
        Me.cmdDatos.Text = "ACEPTAR"
        Me.cmdDatos.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(235, 57)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(167, 22)
        Me.txtDni.TabIndex = 17
        '
        'txtCodMed
        '
        Me.txtCodMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMed.Location = New System.Drawing.Point(235, 14)
        Me.txtCodMed.Name = "txtCodMed"
        Me.txtCodMed.Size = New System.Drawing.Size(167, 22)
        Me.txtCodMed.TabIndex = 15
        '
        'txtDatos
        '
        Me.txtDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatos.Location = New System.Drawing.Point(163, 35)
        Me.txtDatos.Multiline = True
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(461, 93)
        Me.txtDatos.TabIndex = 22
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatos.Location = New System.Drawing.Point(327, 16)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(117, 16)
        Me.lblDatos.TabIndex = 18
        Me.lblDatos.Text = "Datos del Medico:"
        '
        'rdbAusente
        '
        Me.rdbAusente.AutoSize = True
        Me.rdbAusente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAusente.Location = New System.Drawing.Point(8, 99)
        Me.rdbAusente.Name = "rdbAusente"
        Me.rdbAusente.Size = New System.Drawing.Size(123, 20)
        Me.rdbAusente.TabIndex = 23
        Me.rdbAusente.TabStop = True
        Me.rdbAusente.Text = "Medico Ausente"
        Me.rdbAusente.UseVisualStyleBackColor = True
        '
        'rdbPrecente
        '
        Me.rdbPrecente.AutoSize = True
        Me.rdbPrecente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPrecente.Location = New System.Drawing.Point(8, 30)
        Me.rdbPrecente.Name = "rdbPrecente"
        Me.rdbPrecente.Size = New System.Drawing.Size(128, 20)
        Me.rdbPrecente.TabIndex = 22
        Me.rdbPrecente.TabStop = True
        Me.rdbPrecente.Text = "Medico Precente"
        Me.rdbPrecente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDatos)
        Me.GroupBox2.Controls.Add(Me.rdbAusente)
        Me.GroupBox2.Controls.Add(Me.rdbPrecente)
        Me.GroupBox2.Controls.Add(Me.lblDatos)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 152)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asistencia"
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(314, 449)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(128, 67)
        Me.btnAsignar.TabIndex = 15
        Me.btnAsignar.Text = "ASIGNAR INSUMOS Y MEDICAMENTOS"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'IngresoMedicoCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 564)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IngresoMedicoCE"
        Me.Text = "IngresoMedicosExterno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDni As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents cmdDatos As System.Windows.Forms.Button
    Friend WithEvents lblDatos As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodMed As System.Windows.Forms.TextBox
    Friend WithEvents rdbAusente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPrecente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
End Class
