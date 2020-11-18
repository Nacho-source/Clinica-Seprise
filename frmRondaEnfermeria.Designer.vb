<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRondaEnfermeria
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtNR = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPaciente = New System.Windows.Forms.ComboBox()
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cboInsumo = New System.Windows.Forms.ComboBox()
        Me.cboMedicamento = New System.Windows.Forms.ComboBox()
        Me.rbInsumo = New System.Windows.Forms.RadioButton()
        Me.rbMedicamento = New System.Windows.Forms.RadioButton()
        Me.gbInsumo = New System.Windows.Forms.GroupBox()
        Me.cantI = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.horasI = New System.Windows.Forms.ComboBox()
        Me.chkLI = New System.Windows.Forms.CheckBox()
        Me.chkMI = New System.Windows.Forms.CheckBox()
        Me.chkMMI = New System.Windows.Forms.CheckBox()
        Me.chkJI = New System.Windows.Forms.CheckBox()
        Me.chkVI = New System.Windows.Forms.CheckBox()
        Me.chkSI = New System.Windows.Forms.CheckBox()
        Me.chkDI = New System.Windows.Forms.CheckBox()
        Me.gbMedic = New System.Windows.Forms.GroupBox()
        Me.cantM = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.horasM = New System.Windows.Forms.ComboBox()
        Me.chkDM = New System.Windows.Forms.CheckBox()
        Me.chkLM = New System.Windows.Forms.CheckBox()
        Me.chkSM = New System.Windows.Forms.CheckBox()
        Me.chkMM = New System.Windows.Forms.CheckBox()
        Me.chkVM = New System.Windows.Forms.CheckBox()
        Me.chkMMM = New System.Windows.Forms.CheckBox()
        Me.chkJM = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.gbInsumo.SuspendLayout()
        Me.gbMedic.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NroRonda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IdMedico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "IdPaciente"
        '
        'txtDia
        '
        Me.txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDia.Location = New System.Drawing.Point(323, 223)
        Me.txtDia.MaxLength = 2
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(35, 29)
        Me.txtDia.TabIndex = 6
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(160, 142)
        Me.txtObs.MaxLength = 100
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(566, 53)
        Me.txtObs.TabIndex = 3
        '
        'txtNR
        '
        Me.txtNR.Enabled = False
        Me.txtNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNR.Location = New System.Drawing.Point(160, 21)
        Me.txtNR.Name = "txtNR"
        Me.txtNR.Size = New System.Drawing.Size(103, 29)
        Me.txtNR.TabIndex = 8
        '
        'txtMes
        '
        Me.txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.Location = New System.Drawing.Point(260, 223)
        Me.txtMes.MaxLength = 2
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(39, 29)
        Me.txtMes.TabIndex = 5
        '
        'txtAño
        '
        Me.txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.Location = New System.Drawing.Point(165, 223)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(67, 29)
        Me.txtAño.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(238, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "/"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "/"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(180, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Año"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Dia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(248, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Mes"
        '
        'cboPaciente
        '
        Me.cboPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaciente.FormattingEnabled = True
        Me.cboPaciente.Location = New System.Drawing.Point(160, 65)
        Me.cboPaciente.Name = "cboPaciente"
        Me.cboPaciente.Size = New System.Drawing.Size(130, 32)
        Me.cboPaciente.TabIndex = 1
        '
        'cboMedico
        '
        Me.cboMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(160, 105)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(130, 32)
        Me.cboMedico.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(534, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Minutos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(475, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 18)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Hora"
        '
        'txtMinutos
        '
        Me.txtMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutos.Location = New System.Drawing.Point(537, 223)
        Me.txtMinutos.MaxLength = 2
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.Size = New System.Drawing.Size(39, 29)
        Me.txtMinutos.TabIndex = 8
        '
        'txtHora
        '
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Location = New System.Drawing.Point(473, 223)
        Me.txtHora.MaxLength = 2
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(39, 29)
        Me.txtHora.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(518, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 24)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = ":"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(301, 507)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(164, 76)
        Me.cmdGuardar.TabIndex = 32
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cboInsumo
        '
        Me.cboInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInsumo.FormattingEnabled = True
        Me.cboInsumo.Location = New System.Drawing.Point(6, 19)
        Me.cboInsumo.Name = "cboInsumo"
        Me.cboInsumo.Size = New System.Drawing.Size(197, 32)
        Me.cboInsumo.TabIndex = 11
        Me.cboInsumo.Text = "Seleccionar insumo"
        '
        'cboMedicamento
        '
        Me.cboMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedicamento.FormattingEnabled = True
        Me.cboMedicamento.Location = New System.Drawing.Point(15, 19)
        Me.cboMedicamento.Name = "cboMedicamento"
        Me.cboMedicamento.Size = New System.Drawing.Size(244, 32)
        Me.cboMedicamento.TabIndex = 22
        Me.cboMedicamento.Text = "Seleccionar medicamento"
        '
        'rbInsumo
        '
        Me.rbInsumo.AutoSize = True
        Me.rbInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInsumo.Location = New System.Drawing.Point(134, 18)
        Me.rbInsumo.Name = "rbInsumo"
        Me.rbInsumo.Size = New System.Drawing.Size(96, 28)
        Me.rbInsumo.TabIndex = 9
        Me.rbInsumo.TabStop = True
        Me.rbInsumo.Text = "Insumo"
        Me.rbInsumo.UseVisualStyleBackColor = True
        '
        'rbMedicamento
        '
        Me.rbMedicamento.AutoSize = True
        Me.rbMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMedicamento.Location = New System.Drawing.Point(45, 19)
        Me.rbMedicamento.Name = "rbMedicamento"
        Me.rbMedicamento.Size = New System.Drawing.Size(154, 28)
        Me.rbMedicamento.TabIndex = 21
        Me.rbMedicamento.TabStop = True
        Me.rbMedicamento.Text = "Medicamento"
        Me.rbMedicamento.UseVisualStyleBackColor = True
        '
        'gbInsumo
        '
        Me.gbInsumo.Controls.Add(Me.cantI)
        Me.gbInsumo.Controls.Add(Me.Label15)
        Me.gbInsumo.Controls.Add(Me.horasI)
        Me.gbInsumo.Controls.Add(Me.chkLI)
        Me.gbInsumo.Controls.Add(Me.chkMI)
        Me.gbInsumo.Controls.Add(Me.chkMMI)
        Me.gbInsumo.Controls.Add(Me.chkJI)
        Me.gbInsumo.Controls.Add(Me.chkVI)
        Me.gbInsumo.Controls.Add(Me.chkSI)
        Me.gbInsumo.Controls.Add(Me.chkDI)
        Me.gbInsumo.Controls.Add(Me.cboInsumo)
        Me.gbInsumo.Location = New System.Drawing.Point(30, 52)
        Me.gbInsumo.Name = "gbInsumo"
        Me.gbInsumo.Size = New System.Drawing.Size(300, 170)
        Me.gbInsumo.TabIndex = 30
        Me.gbInsumo.TabStop = False
        Me.gbInsumo.Text = "Insumo"
        '
        'cantI
        '
        Me.cantI.Enabled = False
        Me.cantI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantI.Location = New System.Drawing.Point(104, 116)
        Me.cantI.Name = "cantI"
        Me.cantI.Size = New System.Drawing.Size(103, 29)
        Me.cantI.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Cantidad"
        '
        'horasI
        '
        Me.horasI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horasI.FormattingEnabled = True
        Me.horasI.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.horasI.Location = New System.Drawing.Point(6, 83)
        Me.horasI.Name = "horasI"
        Me.horasI.Size = New System.Drawing.Size(220, 26)
        Me.horasI.TabIndex = 19
        Me.horasI.Text = "Seleccione periodo de horas"
        '
        'chkLI
        '
        Me.chkLI.AutoSize = True
        Me.chkLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLI.Location = New System.Drawing.Point(42, 57)
        Me.chkLI.Name = "chkLI"
        Me.chkLI.Size = New System.Drawing.Size(35, 20)
        Me.chkLI.TabIndex = 13
        Me.chkLI.Text = "L"
        Me.chkLI.UseVisualStyleBackColor = True
        '
        'chkMI
        '
        Me.chkMI.AutoSize = True
        Me.chkMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMI.Location = New System.Drawing.Point(78, 57)
        Me.chkMI.Name = "chkMI"
        Me.chkMI.Size = New System.Drawing.Size(39, 20)
        Me.chkMI.TabIndex = 14
        Me.chkMI.Text = "M"
        Me.chkMI.UseVisualStyleBackColor = True
        '
        'chkMMI
        '
        Me.chkMMI.AutoSize = True
        Me.chkMMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMMI.Location = New System.Drawing.Point(123, 57)
        Me.chkMMI.Name = "chkMMI"
        Me.chkMMI.Size = New System.Drawing.Size(39, 20)
        Me.chkMMI.TabIndex = 15
        Me.chkMMI.Text = "M"
        Me.chkMMI.UseVisualStyleBackColor = True
        '
        'chkJI
        '
        Me.chkJI.AutoSize = True
        Me.chkJI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJI.Location = New System.Drawing.Point(168, 57)
        Me.chkJI.Name = "chkJI"
        Me.chkJI.Size = New System.Drawing.Size(35, 20)
        Me.chkJI.TabIndex = 16
        Me.chkJI.Text = "J"
        Me.chkJI.UseVisualStyleBackColor = True
        '
        'chkVI
        '
        Me.chkVI.AutoSize = True
        Me.chkVI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVI.Location = New System.Drawing.Point(209, 57)
        Me.chkVI.Name = "chkVI"
        Me.chkVI.Size = New System.Drawing.Size(37, 20)
        Me.chkVI.TabIndex = 17
        Me.chkVI.Text = "V"
        Me.chkVI.UseVisualStyleBackColor = True
        '
        'chkSI
        '
        Me.chkSI.AutoSize = True
        Me.chkSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSI.Location = New System.Drawing.Point(252, 57)
        Me.chkSI.Name = "chkSI"
        Me.chkSI.Size = New System.Drawing.Size(37, 20)
        Me.chkSI.TabIndex = 18
        Me.chkSI.Text = "S"
        Me.chkSI.UseVisualStyleBackColor = True
        '
        'chkDI
        '
        Me.chkDI.AutoSize = True
        Me.chkDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDI.Location = New System.Drawing.Point(6, 57)
        Me.chkDI.Name = "chkDI"
        Me.chkDI.Size = New System.Drawing.Size(38, 20)
        Me.chkDI.TabIndex = 12
        Me.chkDI.Text = "D"
        Me.chkDI.UseVisualStyleBackColor = True
        '
        'gbMedic
        '
        Me.gbMedic.Controls.Add(Me.cantM)
        Me.gbMedic.Controls.Add(Me.Label16)
        Me.gbMedic.Controls.Add(Me.cboMedicamento)
        Me.gbMedic.Controls.Add(Me.horasM)
        Me.gbMedic.Controls.Add(Me.chkDM)
        Me.gbMedic.Controls.Add(Me.chkLM)
        Me.gbMedic.Controls.Add(Me.chkSM)
        Me.gbMedic.Controls.Add(Me.chkMM)
        Me.gbMedic.Controls.Add(Me.chkVM)
        Me.gbMedic.Controls.Add(Me.chkMMM)
        Me.gbMedic.Controls.Add(Me.chkJM)
        Me.gbMedic.Location = New System.Drawing.Point(13, 53)
        Me.gbMedic.Name = "gbMedic"
        Me.gbMedic.Size = New System.Drawing.Size(295, 165)
        Me.gbMedic.TabIndex = 31
        Me.gbMedic.TabStop = False
        Me.gbMedic.Text = "Medicamento"
        '
        'cantM
        '
        Me.cantM.Enabled = False
        Me.cantM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantM.Location = New System.Drawing.Point(109, 116)
        Me.cantM.Name = "cantM"
        Me.cantM.Size = New System.Drawing.Size(103, 29)
        Me.cantM.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 20)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Cantidad"
        '
        'horasM
        '
        Me.horasM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horasM.FormattingEnabled = True
        Me.horasM.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.horasM.Location = New System.Drawing.Point(11, 83)
        Me.horasM.Name = "horasM"
        Me.horasM.Size = New System.Drawing.Size(220, 26)
        Me.horasM.TabIndex = 30
        Me.horasM.Text = "Seleccione periodo de horas"
        '
        'chkDM
        '
        Me.chkDM.AutoSize = True
        Me.chkDM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDM.Location = New System.Drawing.Point(11, 57)
        Me.chkDM.Name = "chkDM"
        Me.chkDM.Size = New System.Drawing.Size(38, 20)
        Me.chkDM.TabIndex = 23
        Me.chkDM.Text = "D"
        Me.chkDM.UseVisualStyleBackColor = True
        '
        'chkLM
        '
        Me.chkLM.AutoSize = True
        Me.chkLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLM.Location = New System.Drawing.Point(53, 57)
        Me.chkLM.Name = "chkLM"
        Me.chkLM.Size = New System.Drawing.Size(35, 20)
        Me.chkLM.TabIndex = 24
        Me.chkLM.Text = "L"
        Me.chkLM.UseVisualStyleBackColor = True
        '
        'chkSM
        '
        Me.chkSM.AutoSize = True
        Me.chkSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSM.Location = New System.Drawing.Point(257, 57)
        Me.chkSM.Name = "chkSM"
        Me.chkSM.Size = New System.Drawing.Size(37, 20)
        Me.chkSM.TabIndex = 29
        Me.chkSM.Text = "S"
        Me.chkSM.UseVisualStyleBackColor = True
        '
        'chkMM
        '
        Me.chkMM.AutoSize = True
        Me.chkMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMM.Location = New System.Drawing.Point(88, 57)
        Me.chkMM.Name = "chkMM"
        Me.chkMM.Size = New System.Drawing.Size(39, 20)
        Me.chkMM.TabIndex = 25
        Me.chkMM.Text = "M"
        Me.chkMM.UseVisualStyleBackColor = True
        '
        'chkVM
        '
        Me.chkVM.AutoSize = True
        Me.chkVM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVM.Location = New System.Drawing.Point(220, 57)
        Me.chkVM.Name = "chkVM"
        Me.chkVM.Size = New System.Drawing.Size(37, 20)
        Me.chkVM.TabIndex = 28
        Me.chkVM.Text = "V"
        Me.chkVM.UseVisualStyleBackColor = True
        '
        'chkMMM
        '
        Me.chkMMM.AutoSize = True
        Me.chkMMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMMM.Location = New System.Drawing.Point(131, 57)
        Me.chkMMM.Name = "chkMMM"
        Me.chkMMM.Size = New System.Drawing.Size(39, 20)
        Me.chkMMM.TabIndex = 26
        Me.chkMMM.Text = "M"
        Me.chkMMM.UseVisualStyleBackColor = True
        '
        'chkJM
        '
        Me.chkJM.AutoSize = True
        Me.chkJM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJM.Location = New System.Drawing.Point(176, 57)
        Me.chkJM.Name = "chkJM"
        Me.chkJM.Size = New System.Drawing.Size(35, 20)
        Me.chkJM.TabIndex = 27
        Me.chkJM.Text = "J"
        Me.chkJM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbInsumo)
        Me.GroupBox1.Controls.Add(Me.rbInsumo)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 236)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbMedic)
        Me.GroupBox2.Controls.Add(Me.rbMedicamento)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 237)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(540, 533)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(171, 50)
        Me.cmdVolver.TabIndex = 33
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmRondaEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 592)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtMinutos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboMedico)
        Me.Controls.Add(Me.cboPaciente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtNR)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRondaEnfermeria"
        Me.Text = "Alta de ronda"
        Me.gbInsumo.ResumeLayout(False)
        Me.gbInsumo.PerformLayout()
        Me.gbMedic.ResumeLayout(False)
        Me.gbMedic.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents txtNR As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents cboMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMinutos As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cboInsumo As System.Windows.Forms.ComboBox
    Friend WithEvents cboMedicamento As System.Windows.Forms.ComboBox
    Friend WithEvents rbInsumo As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedicamento As System.Windows.Forms.RadioButton
    Friend WithEvents gbInsumo As System.Windows.Forms.GroupBox
    Friend WithEvents gbMedic As System.Windows.Forms.GroupBox
    Friend WithEvents horasI As System.Windows.Forms.ComboBox
    Friend WithEvents chkLI As System.Windows.Forms.CheckBox
    Friend WithEvents chkMI As System.Windows.Forms.CheckBox
    Friend WithEvents chkMMI As System.Windows.Forms.CheckBox
    Friend WithEvents chkJI As System.Windows.Forms.CheckBox
    Friend WithEvents chkVI As System.Windows.Forms.CheckBox
    Friend WithEvents chkSI As System.Windows.Forms.CheckBox
    Friend WithEvents chkDI As System.Windows.Forms.CheckBox
    Friend WithEvents cantI As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cantM As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents horasM As ComboBox
    Friend WithEvents chkDM As CheckBox
    Friend WithEvents chkLM As CheckBox
    Friend WithEvents chkSM As CheckBox
    Friend WithEvents chkMM As CheckBox
    Friend WithEvents chkVM As CheckBox
    Friend WithEvents chkMMM As CheckBox
    Friend WithEvents chkJM As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdVolver As Button
End Class
