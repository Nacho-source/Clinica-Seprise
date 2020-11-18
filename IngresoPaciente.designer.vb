<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoPaciente
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
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.gboPaciente = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblGrupoS = New System.Windows.Forms.Label()
        Me.lblOS = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.gboContactos = New System.Windows.Forms.GroupBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.gboUbicacion = New System.Windows.Forms.GroupBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.gboDatosMedic = New System.Windows.Forms.GroupBox()
        Me.cboObrasSociales = New System.Windows.Forms.ComboBox()
        Me.rbtNo = New System.Windows.Forms.RadioButton()
        Me.rbtSi = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboGS = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboPaciente.SuspendLayout()
        Me.gboContactos.SuspendLayout()
        Me.gboUbicacion.SuspendLayout()
        Me.gboDatosMedic.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(18, 126)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(29, 19)
        Me.lblCP.TabIndex = 1
        Me.lblCP.Text = "CP"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(16, 24)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(67, 19)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Direccion"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(16, 56)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(69, 19)
        Me.lblLocalidad.TabIndex = 3
        Me.lblLocalidad.Text = "Localidad"
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacionalidad.Location = New System.Drawing.Point(16, 90)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(89, 19)
        Me.lblNacionalidad.TabIndex = 4
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(24, 94)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(138, 19)
        Me.lblFechaNac.TabIndex = 5
        Me.lblFechaNac.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nº Documento"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDoc.Location = New System.Drawing.Point(302, 57)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(129, 19)
        Me.lblTipoDoc.TabIndex = 7
        Me.lblTipoDoc.Text = "Tipo de Documento"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(302, 18)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(60, 19)
        Me.lblApellido.TabIndex = 8
        Me.lblApellido.Text = "Apellido"
        '
        'gboPaciente
        '
        Me.gboPaciente.Controls.Add(Me.lblAño)
        Me.gboPaciente.Controls.Add(Me.txtFecha)
        Me.gboPaciente.Controls.Add(Me.txtNumDoc)
        Me.gboPaciente.Controls.Add(Me.cboTipoDoc)
        Me.gboPaciente.Controls.Add(Me.txtApellido)
        Me.gboPaciente.Controls.Add(Me.txtNombre)
        Me.gboPaciente.Controls.Add(Me.Label1)
        Me.gboPaciente.Controls.Add(Me.lblApellido)
        Me.gboPaciente.Controls.Add(Me.lblTipoDoc)
        Me.gboPaciente.Controls.Add(Me.Label7)
        Me.gboPaciente.Controls.Add(Me.lblFechaNac)
        Me.gboPaciente.Location = New System.Drawing.Point(12, 12)
        Me.gboPaciente.Name = "gboPaciente"
        Me.gboPaciente.Size = New System.Drawing.Size(619, 130)
        Me.gboPaciente.TabIndex = 9
        Me.gboPaciente.TabStop = False
        Me.gboPaciente.Text = "Paciente"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(168, 95)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(81, 20)
        Me.txtFecha.TabIndex = 21
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(130, 58)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(119, 20)
        Me.txtNumDoc.TabIndex = 18
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(437, 58)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(152, 21)
        Me.cboTipoDoc.TabIndex = 17
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(368, 19)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(152, 20)
        Me.txtApellido.TabIndex = 16
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(89, 17)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(23, 25)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 19)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'lblGrupoS
        '
        Me.lblGrupoS.AutoSize = True
        Me.lblGrupoS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupoS.Location = New System.Drawing.Point(23, 110)
        Me.lblGrupoS.Name = "lblGrupoS"
        Me.lblGrupoS.Size = New System.Drawing.Size(114, 19)
        Me.lblGrupoS.TabIndex = 10
        Me.lblGrupoS.Text = "Grupo Sanguineo"
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOS.Location = New System.Drawing.Point(23, 67)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(82, 19)
        Me.lblOS.TabIndex = 12
        Me.lblOS.Text = "Seleccionar:"
        Me.lblOS.Visible = False
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(23, 58)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 19)
        Me.lblTelefono.TabIndex = 13
        Me.lblTelefono.Text = "Telefono"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(23, 91)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(52, 19)
        Me.lblCelular.TabIndex = 14
        Me.lblCelular.Text = "Celular"
        '
        'gboContactos
        '
        Me.gboContactos.Controls.Add(Me.txtCelular)
        Me.gboContactos.Controls.Add(Me.txtTelefono)
        Me.gboContactos.Controls.Add(Me.txtEmail)
        Me.gboContactos.Controls.Add(Me.lblEmail)
        Me.gboContactos.Controls.Add(Me.lblTelefono)
        Me.gboContactos.Controls.Add(Me.lblCelular)
        Me.gboContactos.Location = New System.Drawing.Point(12, 148)
        Me.gboContactos.Name = "gboContactos"
        Me.gboContactos.Size = New System.Drawing.Size(293, 120)
        Me.gboContactos.TabIndex = 10
        Me.gboContactos.TabStop = False
        Me.gboContactos.Text = "Contactos"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(89, 90)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(141, 20)
        Me.txtCelular.TabIndex = 18
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(90, 59)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(140, 20)
        Me.txtTelefono.TabIndex = 17
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(89, 24)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(141, 20)
        Me.txtEmail.TabIndex = 16
        '
        'gboUbicacion
        '
        Me.gboUbicacion.Controls.Add(Me.txtNacionalidad)
        Me.gboUbicacion.Controls.Add(Me.txtCP)
        Me.gboUbicacion.Controls.Add(Me.txtLocalidad)
        Me.gboUbicacion.Controls.Add(Me.txtDireccion)
        Me.gboUbicacion.Controls.Add(Me.lblDireccion)
        Me.gboUbicacion.Controls.Add(Me.lblCP)
        Me.gboUbicacion.Controls.Add(Me.lblLocalidad)
        Me.gboUbicacion.Controls.Add(Me.lblNacionalidad)
        Me.gboUbicacion.Location = New System.Drawing.Point(12, 289)
        Me.gboUbicacion.Name = "gboUbicacion"
        Me.gboUbicacion.Size = New System.Drawing.Size(293, 157)
        Me.gboUbicacion.TabIndex = 11
        Me.gboUbicacion.TabStop = False
        Me.gboUbicacion.Text = "Ubicación"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(111, 89)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(139, 20)
        Me.txtNacionalidad.TabIndex = 18
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(111, 125)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(139, 20)
        Me.txtCP.TabIndex = 18
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(109, 57)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(140, 20)
        Me.txtLocalidad.TabIndex = 17
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(109, 24)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(141, 20)
        Me.txtDireccion.TabIndex = 16
        '
        'gboDatosMedic
        '
        Me.gboDatosMedic.Controls.Add(Me.cboObrasSociales)
        Me.gboDatosMedic.Controls.Add(Me.rbtNo)
        Me.gboDatosMedic.Controls.Add(Me.rbtSi)
        Me.gboDatosMedic.Controls.Add(Me.Label2)
        Me.gboDatosMedic.Controls.Add(Me.cboGS)
        Me.gboDatosMedic.Controls.Add(Me.lblOS)
        Me.gboDatosMedic.Controls.Add(Me.lblGrupoS)
        Me.gboDatosMedic.Location = New System.Drawing.Point(338, 151)
        Me.gboDatosMedic.Name = "gboDatosMedic"
        Me.gboDatosMedic.Size = New System.Drawing.Size(293, 181)
        Me.gboDatosMedic.TabIndex = 12
        Me.gboDatosMedic.TabStop = False
        Me.gboDatosMedic.Text = "Datos Medicos"
        '
        'cboObrasSociales
        '
        Me.cboObrasSociales.FormattingEnabled = True
        Me.cboObrasSociales.Location = New System.Drawing.Point(111, 65)
        Me.cboObrasSociales.Name = "cboObrasSociales"
        Me.cboObrasSociales.Size = New System.Drawing.Size(152, 21)
        Me.cboObrasSociales.TabIndex = 26
        Me.cboObrasSociales.Visible = False
        '
        'rbtNo
        '
        Me.rbtNo.AutoSize = True
        Me.rbtNo.Location = New System.Drawing.Point(194, 35)
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
        Me.rbtSi.Location = New System.Drawing.Point(156, 35)
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
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Posee Obra Social: "
        '
        'cboGS
        '
        Me.cboGS.FormattingEnabled = True
        Me.cboGS.Location = New System.Drawing.Point(143, 110)
        Me.cboGS.Name = "cboGS"
        Me.cboGS.Size = New System.Drawing.Size(93, 21)
        Me.cboGS.TabIndex = 19
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(380, 374)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 35)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(495, 374)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(96, 35)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(256, 101)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(114, 13)
        Me.lblAño.TabIndex = 22
        Me.lblAño.Text = "dia/mes/año-completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "En caso de no poseer algun dato coloque ""-"""
        '
        'IngresoPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 483)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gboDatosMedic)
        Me.Controls.Add(Me.gboUbicacion)
        Me.Controls.Add(Me.gboContactos)
        Me.Controls.Add(Me.gboPaciente)
        Me.Name = "IngresoPaciente"
        Me.Text = "Registro"
        Me.gboPaciente.ResumeLayout(False)
        Me.gboPaciente.PerformLayout()
        Me.gboContactos.ResumeLayout(False)
        Me.gboContactos.PerformLayout()
        Me.gboUbicacion.ResumeLayout(False)
        Me.gboUbicacion.PerformLayout()
        Me.gboDatosMedic.ResumeLayout(False)
        Me.gboDatosMedic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents lblFechaNac As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents gboPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents lblGrupoS As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents gboContactos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents gboUbicacion As System.Windows.Forms.GroupBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents gboDatosMedic As System.Windows.Forms.GroupBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents cboGS As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents rbtNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSi As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboObrasSociales As System.Windows.Forms.ComboBox
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
