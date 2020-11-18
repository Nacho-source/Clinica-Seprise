<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMedicoTurno
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
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbDomingo = New System.Windows.Forms.CheckBox()
        Me.cbSabado = New System.Windows.Forms.CheckBox()
        Me.cbViernes = New System.Windows.Forms.CheckBox()
        Me.cbJueves = New System.Windows.Forms.CheckBox()
        Me.cbMiercoles = New System.Windows.Forms.CheckBox()
        Me.cbMartes = New System.Windows.Forms.CheckBox()
        Me.cbLunes = New System.Windows.Forms.CheckBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DomDuracion = New System.Windows.Forms.NumericUpDown()
        Me.DomMinutos = New System.Windows.Forms.NumericUpDown()
        Me.DomHora = New System.Windows.Forms.NumericUpDown()
        Me.SaDuracion = New System.Windows.Forms.NumericUpDown()
        Me.SaMinutos = New System.Windows.Forms.NumericUpDown()
        Me.SaHora = New System.Windows.Forms.NumericUpDown()
        Me.ViDuracion = New System.Windows.Forms.NumericUpDown()
        Me.ViMinutos = New System.Windows.Forms.NumericUpDown()
        Me.ViHora = New System.Windows.Forms.NumericUpDown()
        Me.JuDuracion = New System.Windows.Forms.NumericUpDown()
        Me.JuMinutos = New System.Windows.Forms.NumericUpDown()
        Me.JuHora = New System.Windows.Forms.NumericUpDown()
        Me.MiDuracion = New System.Windows.Forms.NumericUpDown()
        Me.MiMinutos = New System.Windows.Forms.NumericUpDown()
        Me.MiHora = New System.Windows.Forms.NumericUpDown()
        Me.MaDuracion = New System.Windows.Forms.NumericUpDown()
        Me.MaMinutos = New System.Windows.Forms.NumericUpDown()
        Me.MaHora = New System.Windows.Forms.NumericUpDown()
        Me.LDuracion = New System.Windows.Forms.NumericUpDown()
        Me.LMinutos = New System.Windows.Forms.NumericUpDown()
        Me.LHora = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DomDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DomHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JuHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaHora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMedico
        '
        Me.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(139, 76)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(384, 21)
        Me.cboMedico.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccionar medico"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbDomingo)
        Me.GroupBox1.Controls.Add(Me.cbSabado)
        Me.GroupBox1.Controls.Add(Me.cbViernes)
        Me.GroupBox1.Controls.Add(Me.cbJueves)
        Me.GroupBox1.Controls.Add(Me.cbMiercoles)
        Me.GroupBox1.Controls.Add(Me.cbMartes)
        Me.GroupBox1.Controls.Add(Me.cbLunes)
        Me.GroupBox1.Location = New System.Drawing.Point(139, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Dia"
        '
        'cbDomingo
        '
        Me.cbDomingo.AutoSize = True
        Me.cbDomingo.Location = New System.Drawing.Point(7, 162)
        Me.cbDomingo.Name = "cbDomingo"
        Me.cbDomingo.Size = New System.Drawing.Size(68, 17)
        Me.cbDomingo.TabIndex = 6
        Me.cbDomingo.Text = "Domingo"
        Me.cbDomingo.UseVisualStyleBackColor = True
        '
        'cbSabado
        '
        Me.cbSabado.AutoSize = True
        Me.cbSabado.Location = New System.Drawing.Point(7, 139)
        Me.cbSabado.Name = "cbSabado"
        Me.cbSabado.Size = New System.Drawing.Size(63, 17)
        Me.cbSabado.TabIndex = 5
        Me.cbSabado.Text = "Sabado"
        Me.cbSabado.UseVisualStyleBackColor = True
        '
        'cbViernes
        '
        Me.cbViernes.AutoSize = True
        Me.cbViernes.Location = New System.Drawing.Point(7, 116)
        Me.cbViernes.Name = "cbViernes"
        Me.cbViernes.Size = New System.Drawing.Size(61, 17)
        Me.cbViernes.TabIndex = 4
        Me.cbViernes.Text = "Viernes"
        Me.cbViernes.UseVisualStyleBackColor = True
        '
        'cbJueves
        '
        Me.cbJueves.AutoSize = True
        Me.cbJueves.Location = New System.Drawing.Point(7, 92)
        Me.cbJueves.Name = "cbJueves"
        Me.cbJueves.Size = New System.Drawing.Size(60, 17)
        Me.cbJueves.TabIndex = 3
        Me.cbJueves.Text = "Jueves"
        Me.cbJueves.UseVisualStyleBackColor = True
        '
        'cbMiercoles
        '
        Me.cbMiercoles.AutoSize = True
        Me.cbMiercoles.Location = New System.Drawing.Point(7, 68)
        Me.cbMiercoles.Name = "cbMiercoles"
        Me.cbMiercoles.Size = New System.Drawing.Size(71, 17)
        Me.cbMiercoles.TabIndex = 2
        Me.cbMiercoles.Text = "Miercoles"
        Me.cbMiercoles.UseVisualStyleBackColor = True
        '
        'cbMartes
        '
        Me.cbMartes.AutoSize = True
        Me.cbMartes.Location = New System.Drawing.Point(7, 44)
        Me.cbMartes.Name = "cbMartes"
        Me.cbMartes.Size = New System.Drawing.Size(58, 17)
        Me.cbMartes.TabIndex = 1
        Me.cbMartes.Text = "Martes"
        Me.cbMartes.UseVisualStyleBackColor = True
        '
        'cbLunes
        '
        Me.cbLunes.AutoSize = True
        Me.cbLunes.Location = New System.Drawing.Point(7, 20)
        Me.cbLunes.Name = "cbLunes"
        Me.cbLunes.Size = New System.Drawing.Size(55, 17)
        Me.cbLunes.TabIndex = 0
        Me.cbLunes.Text = "Lunes"
        Me.cbLunes.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(146, 364)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(148, 52)
        Me.btnAtras.TabIndex = 4
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(375, 364)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(148, 52)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DomDuracion)
        Me.GroupBox2.Controls.Add(Me.DomMinutos)
        Me.GroupBox2.Controls.Add(Me.DomHora)
        Me.GroupBox2.Controls.Add(Me.SaDuracion)
        Me.GroupBox2.Controls.Add(Me.SaMinutos)
        Me.GroupBox2.Controls.Add(Me.SaHora)
        Me.GroupBox2.Controls.Add(Me.ViDuracion)
        Me.GroupBox2.Controls.Add(Me.ViMinutos)
        Me.GroupBox2.Controls.Add(Me.ViHora)
        Me.GroupBox2.Controls.Add(Me.JuDuracion)
        Me.GroupBox2.Controls.Add(Me.JuMinutos)
        Me.GroupBox2.Controls.Add(Me.JuHora)
        Me.GroupBox2.Controls.Add(Me.MiDuracion)
        Me.GroupBox2.Controls.Add(Me.MiMinutos)
        Me.GroupBox2.Controls.Add(Me.MiHora)
        Me.GroupBox2.Controls.Add(Me.MaDuracion)
        Me.GroupBox2.Controls.Add(Me.MaMinutos)
        Me.GroupBox2.Controls.Add(Me.MaHora)
        Me.GroupBox2.Controls.Add(Me.LDuracion)
        Me.GroupBox2.Controls.Add(Me.LMinutos)
        Me.GroupBox2.Controls.Add(Me.LHora)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 186)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hora / Minutos / Duracion (Horas)"
        '
        'DomDuracion
        '
        Me.DomDuracion.Enabled = False
        Me.DomDuracion.Location = New System.Drawing.Point(172, 159)
        Me.DomDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.DomDuracion.Name = "DomDuracion"
        Me.DomDuracion.Size = New System.Drawing.Size(77, 20)
        Me.DomDuracion.TabIndex = 20
        '
        'DomMinutos
        '
        Me.DomMinutos.Enabled = False
        Me.DomMinutos.Location = New System.Drawing.Point(89, 159)
        Me.DomMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.DomMinutos.Name = "DomMinutos"
        Me.DomMinutos.Size = New System.Drawing.Size(77, 20)
        Me.DomMinutos.TabIndex = 19
        '
        'DomHora
        '
        Me.DomHora.Enabled = False
        Me.DomHora.Location = New System.Drawing.Point(6, 159)
        Me.DomHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.DomHora.Name = "DomHora"
        Me.DomHora.Size = New System.Drawing.Size(77, 20)
        Me.DomHora.TabIndex = 18
        '
        'SaDuracion
        '
        Me.SaDuracion.Enabled = False
        Me.SaDuracion.Location = New System.Drawing.Point(172, 136)
        Me.SaDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.SaDuracion.Name = "SaDuracion"
        Me.SaDuracion.Size = New System.Drawing.Size(77, 20)
        Me.SaDuracion.TabIndex = 17
        '
        'SaMinutos
        '
        Me.SaMinutos.Enabled = False
        Me.SaMinutos.Location = New System.Drawing.Point(89, 136)
        Me.SaMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.SaMinutos.Name = "SaMinutos"
        Me.SaMinutos.Size = New System.Drawing.Size(77, 20)
        Me.SaMinutos.TabIndex = 16
        '
        'SaHora
        '
        Me.SaHora.Enabled = False
        Me.SaHora.Location = New System.Drawing.Point(6, 136)
        Me.SaHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.SaHora.Name = "SaHora"
        Me.SaHora.Size = New System.Drawing.Size(77, 20)
        Me.SaHora.TabIndex = 15
        '
        'ViDuracion
        '
        Me.ViDuracion.Enabled = False
        Me.ViDuracion.Location = New System.Drawing.Point(172, 113)
        Me.ViDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.ViDuracion.Name = "ViDuracion"
        Me.ViDuracion.Size = New System.Drawing.Size(77, 20)
        Me.ViDuracion.TabIndex = 14
        '
        'ViMinutos
        '
        Me.ViMinutos.Enabled = False
        Me.ViMinutos.Location = New System.Drawing.Point(89, 113)
        Me.ViMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.ViMinutos.Name = "ViMinutos"
        Me.ViMinutos.Size = New System.Drawing.Size(77, 20)
        Me.ViMinutos.TabIndex = 13
        '
        'ViHora
        '
        Me.ViHora.Enabled = False
        Me.ViHora.Location = New System.Drawing.Point(6, 113)
        Me.ViHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.ViHora.Name = "ViHora"
        Me.ViHora.Size = New System.Drawing.Size(77, 20)
        Me.ViHora.TabIndex = 12
        '
        'JuDuracion
        '
        Me.JuDuracion.Enabled = False
        Me.JuDuracion.Location = New System.Drawing.Point(172, 90)
        Me.JuDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.JuDuracion.Name = "JuDuracion"
        Me.JuDuracion.Size = New System.Drawing.Size(77, 20)
        Me.JuDuracion.TabIndex = 11
        '
        'JuMinutos
        '
        Me.JuMinutos.Enabled = False
        Me.JuMinutos.Location = New System.Drawing.Point(89, 90)
        Me.JuMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.JuMinutos.Name = "JuMinutos"
        Me.JuMinutos.Size = New System.Drawing.Size(77, 20)
        Me.JuMinutos.TabIndex = 10
        '
        'JuHora
        '
        Me.JuHora.Enabled = False
        Me.JuHora.Location = New System.Drawing.Point(6, 90)
        Me.JuHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.JuHora.Name = "JuHora"
        Me.JuHora.Size = New System.Drawing.Size(77, 20)
        Me.JuHora.TabIndex = 9
        '
        'MiDuracion
        '
        Me.MiDuracion.Enabled = False
        Me.MiDuracion.Location = New System.Drawing.Point(172, 67)
        Me.MiDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.MiDuracion.Name = "MiDuracion"
        Me.MiDuracion.Size = New System.Drawing.Size(77, 20)
        Me.MiDuracion.TabIndex = 8
        '
        'MiMinutos
        '
        Me.MiMinutos.Enabled = False
        Me.MiMinutos.Location = New System.Drawing.Point(89, 67)
        Me.MiMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MiMinutos.Name = "MiMinutos"
        Me.MiMinutos.Size = New System.Drawing.Size(77, 20)
        Me.MiMinutos.TabIndex = 7
        '
        'MiHora
        '
        Me.MiHora.Enabled = False
        Me.MiHora.Location = New System.Drawing.Point(6, 67)
        Me.MiHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.MiHora.Name = "MiHora"
        Me.MiHora.Size = New System.Drawing.Size(77, 20)
        Me.MiHora.TabIndex = 6
        '
        'MaDuracion
        '
        Me.MaDuracion.Enabled = False
        Me.MaDuracion.Location = New System.Drawing.Point(172, 43)
        Me.MaDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.MaDuracion.Name = "MaDuracion"
        Me.MaDuracion.Size = New System.Drawing.Size(77, 20)
        Me.MaDuracion.TabIndex = 5
        '
        'MaMinutos
        '
        Me.MaMinutos.Enabled = False
        Me.MaMinutos.Location = New System.Drawing.Point(89, 43)
        Me.MaMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MaMinutos.Name = "MaMinutos"
        Me.MaMinutos.Size = New System.Drawing.Size(77, 20)
        Me.MaMinutos.TabIndex = 4
        '
        'MaHora
        '
        Me.MaHora.Enabled = False
        Me.MaHora.Location = New System.Drawing.Point(6, 43)
        Me.MaHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.MaHora.Name = "MaHora"
        Me.MaHora.Size = New System.Drawing.Size(77, 20)
        Me.MaHora.TabIndex = 3
        '
        'LDuracion
        '
        Me.LDuracion.Enabled = False
        Me.LDuracion.Location = New System.Drawing.Point(172, 20)
        Me.LDuracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.LDuracion.Name = "LDuracion"
        Me.LDuracion.Size = New System.Drawing.Size(77, 20)
        Me.LDuracion.TabIndex = 2
        '
        'LMinutos
        '
        Me.LMinutos.Enabled = False
        Me.LMinutos.Location = New System.Drawing.Point(89, 20)
        Me.LMinutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.LMinutos.Name = "LMinutos"
        Me.LMinutos.Size = New System.Drawing.Size(77, 20)
        Me.LMinutos.TabIndex = 1
        '
        'LHora
        '
        Me.LHora.Enabled = False
        Me.LHora.Location = New System.Drawing.Point(6, 20)
        Me.LHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(77, 20)
        Me.LHora.TabIndex = 0
        '
        'AgregarMedicoTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 464)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMedico)
        Me.Name = "AgregarMedicoTurno"
        Me.Text = "Agregar Horario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DomDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DomHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JuHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaHora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMedico As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents cbMartes As System.Windows.Forms.CheckBox
    Friend WithEvents cbLunes As System.Windows.Forms.CheckBox
    Friend WithEvents cbDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents cbSabado As System.Windows.Forms.CheckBox
    Friend WithEvents cbViernes As System.Windows.Forms.CheckBox
    Friend WithEvents cbJueves As System.Windows.Forms.CheckBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DomDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents DomMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents DomHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents SaDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents SaMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents SaHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents ViDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents ViMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents ViHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents JuDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents JuMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents JuHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents MiHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaHora As System.Windows.Forms.NumericUpDown
    Friend WithEvents LDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents LMinutos As System.Windows.Forms.NumericUpDown
    Friend WithEvents LHora As System.Windows.Forms.NumericUpDown
End Class
