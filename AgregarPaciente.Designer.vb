<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarPaciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPaciente = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoIngreso = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboUrgencia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccionar paciente"
        '
        'cboPaciente
        '
        Me.cboPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaciente.FormattingEnabled = True
        Me.cboPaciente.Location = New System.Drawing.Point(59, 55)
        Me.cboPaciente.Name = "cboPaciente"
        Me.cboPaciente.Size = New System.Drawing.Size(384, 21)
        Me.cboPaciente.TabIndex = 2
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(295, 402)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(148, 52)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(61, 402)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(148, 52)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tipo ingreso"
        '
        'cboTipoIngreso
        '
        Me.cboTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoIngreso.FormattingEnabled = True
        Me.cboTipoIngreso.Items.AddRange(New Object() {"Ambulancia", "Ambulatorio"})
        Me.cboTipoIngreso.Location = New System.Drawing.Point(59, 95)
        Me.cboTipoIngreso.Name = "cboTipoIngreso"
        Me.cboTipoIngreso.Size = New System.Drawing.Size(384, 21)
        Me.cboTipoIngreso.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Motivo"
        '
        'cboUrgencia
        '
        Me.cboUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUrgencia.FormattingEnabled = True
        Me.cboUrgencia.Location = New System.Drawing.Point(61, 291)
        Me.cboUrgencia.Name = "cboUrgencia"
        Me.cboUrgencia.Size = New System.Drawing.Size(384, 21)
        Me.cboUrgencia.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Seleccionar urgencia"
        '
        'cboEspecialidad
        '
        Me.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Location = New System.Drawing.Point(61, 331)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(384, 21)
        Me.cboEspecialidad.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Seleccionar especialidad"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(59, 135)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(599, 137)
        Me.txtMotivo.TabIndex = 17
        Me.txtMotivo.Text = ""
        '
        'AgregarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 459)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboEspecialidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboUrgencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTipoIngreso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPaciente)
        Me.Name = "AgregarPaciente"
        Me.Text = "AgregarPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboPaciente As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTipoIngreso As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboUrgencia As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEspecialidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMotivo As RichTextBox
End Class
