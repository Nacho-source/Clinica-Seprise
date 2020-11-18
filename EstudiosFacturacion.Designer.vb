<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstudiosFacturacion
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
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblObraSocial = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbFacturacion = New System.Windows.Forms.GroupBox()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDire = New System.Windows.Forms.Label()
        Me.lblNombrePaciente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.gbFormaPago = New System.Windows.Forms.GroupBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.rbDebito = New System.Windows.Forms.RadioButton()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.gbTarjeta = New System.Windows.Forms.GroupBox()
        Me.btnAbonar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFechaVto = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtNroTarjeta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbFacturacion.SuspendLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFormaPago.SuspendLayout()
        Me.gbTarjeta.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidad.Location = New System.Drawing.Point(326, 134)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(0, 16)
        Me.lblLocalidad.TabIndex = 14
        '
        'lblObraSocial
        '
        Me.lblObraSocial.AutoSize = True
        Me.lblObraSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObraSocial.Location = New System.Drawing.Point(105, 196)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(0, 16)
        Me.lblObraSocial.TabIndex = 12
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(99, 164)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(0, 16)
        Me.lblCelular.TabIndex = 11
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(99, 134)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(0, 16)
        Me.lblDireccion.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Obra Social: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(247, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Localidad: "
        '
        'gbFacturacion
        '
        Me.gbFacturacion.Controls.Add(Me.dgvResumen)
        Me.gbFacturacion.Controls.Add(Me.lblLocalidad)
        Me.gbFacturacion.Controls.Add(Me.lblObraSocial)
        Me.gbFacturacion.Controls.Add(Me.lblCelular)
        Me.gbFacturacion.Controls.Add(Me.lblDireccion)
        Me.gbFacturacion.Controls.Add(Me.Label6)
        Me.gbFacturacion.Controls.Add(Me.Label5)
        Me.gbFacturacion.Controls.Add(Me.Label4)
        Me.gbFacturacion.Controls.Add(Me.lblDire)
        Me.gbFacturacion.Controls.Add(Me.lblNombrePaciente)
        Me.gbFacturacion.Controls.Add(Me.Label3)
        Me.gbFacturacion.Controls.Add(Me.Label2)
        Me.gbFacturacion.Controls.Add(Me.Label1)
        Me.gbFacturacion.Controls.Add(Me.PictureBox1)
        Me.gbFacturacion.Controls.Add(Me.lblFecha)
        Me.gbFacturacion.Location = New System.Drawing.Point(26, 25)
        Me.gbFacturacion.Name = "gbFacturacion"
        Me.gbFacturacion.Size = New System.Drawing.Size(482, 398)
        Me.gbFacturacion.TabIndex = 16
        Me.gbFacturacion.TabStop = False
        '
        'dgvResumen
        '
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResumen.Location = New System.Drawing.Point(17, 237)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.Size = New System.Drawing.Size(430, 53)
        Me.dgvResumen.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Celular: "
        '
        'lblDire
        '
        Me.lblDire.AutoSize = True
        Me.lblDire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDire.Location = New System.Drawing.Point(14, 134)
        Me.lblDire.Name = "lblDire"
        Me.lblDire.Size = New System.Drawing.Size(71, 16)
        Me.lblDire.TabIndex = 6
        Me.lblDire.Text = "Direccion: "
        '
        'lblNombrePaciente
        '
        Me.lblNombrePaciente.AutoSize = True
        Me.lblNombrePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePaciente.Location = New System.Drawing.Point(99, 107)
        Me.lblNombrePaciente.Name = "lblNombrePaciente"
        Me.lblNombrePaciente.Size = New System.Drawing.Size(0, 16)
        Me.lblNombrePaciente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Paciente: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clinica SePrise"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clinica_SePriSe_Mora_y_Mendez.My.Resources.Resources.Logo_Final
        Me.PictureBox1.Location = New System.Drawing.Point(17, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(410, 46)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 0
        '
        'gbFormaPago
        '
        Me.gbFormaPago.Controls.Add(Me.btnSiguiente)
        Me.gbFormaPago.Controls.Add(Me.rbDebito)
        Me.gbFormaPago.Controls.Add(Me.rbCredito)
        Me.gbFormaPago.Controls.Add(Me.rbEfectivo)
        Me.gbFormaPago.Location = New System.Drawing.Point(32, 22)
        Me.gbFormaPago.Name = "gbFormaPago"
        Me.gbFormaPago.Size = New System.Drawing.Size(356, 107)
        Me.gbFormaPago.TabIndex = 21
        Me.gbFormaPago.TabStop = False
        Me.gbFormaPago.Text = "Forma de Pago"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(254, 73)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(81, 29)
        Me.btnSiguiente.TabIndex = 4
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'rbDebito
        '
        Me.rbDebito.AutoSize = True
        Me.rbDebito.Location = New System.Drawing.Point(228, 39)
        Me.rbDebito.Name = "rbDebito"
        Me.rbDebito.Size = New System.Drawing.Size(107, 17)
        Me.rbDebito.TabIndex = 3
        Me.rbDebito.TabStop = True
        Me.rbDebito.Text = "Tarjeta de Debito"
        Me.rbDebito.UseVisualStyleBackColor = True
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Location = New System.Drawing.Point(105, 39)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(109, 17)
        Me.rbCredito.TabIndex = 2
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "Tarjeta de Credito"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Location = New System.Drawing.Point(21, 39)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbEfectivo.TabIndex = 1
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "Efectivo"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'gbTarjeta
        '
        Me.gbTarjeta.Controls.Add(Me.btnAbonar)
        Me.gbTarjeta.Controls.Add(Me.Label11)
        Me.gbTarjeta.Controls.Add(Me.txtFechaVto)
        Me.gbTarjeta.Controls.Add(Me.txtClave)
        Me.gbTarjeta.Controls.Add(Me.txtNroTarjeta)
        Me.gbTarjeta.Controls.Add(Me.Label10)
        Me.gbTarjeta.Controls.Add(Me.Label9)
        Me.gbTarjeta.Controls.Add(Me.Label8)
        Me.gbTarjeta.Location = New System.Drawing.Point(26, 438)
        Me.gbTarjeta.Name = "gbTarjeta"
        Me.gbTarjeta.Size = New System.Drawing.Size(304, 225)
        Me.gbTarjeta.TabIndex = 20
        Me.gbTarjeta.TabStop = False
        Me.gbTarjeta.Text = "Datos Tarjeta"
        Me.gbTarjeta.Visible = False
        '
        'btnAbonar
        '
        Me.btnAbonar.Location = New System.Drawing.Point(191, 181)
        Me.btnAbonar.Name = "btnAbonar"
        Me.btnAbonar.Size = New System.Drawing.Size(86, 30)
        Me.btnAbonar.TabIndex = 7
        Me.btnAbonar.Text = "Abonar"
        Me.btnAbonar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Año/Mes"
        '
        'txtFechaVto
        '
        Me.txtFechaVto.Location = New System.Drawing.Point(123, 116)
        Me.txtFechaVto.Name = "txtFechaVto"
        Me.txtFechaVto.Size = New System.Drawing.Size(90, 20)
        Me.txtFechaVto.TabIndex = 5
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(123, 79)
        Me.txtClave.MaxLength = 4
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(155, 20)
        Me.txtClave.TabIndex = 4
        '
        'txtNroTarjeta
        '
        Me.txtNroTarjeta.Location = New System.Drawing.Point(123, 39)
        Me.txtNroTarjeta.MaxLength = 16
        Me.txtNroTarjeta.Name = "txtNroTarjeta"
        Me.txtNroTarjeta.Size = New System.Drawing.Size(155, 20)
        Me.txtNroTarjeta.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Fecha Vencimiento: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Clave: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Numero de Tarjeta: "
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(412, 434)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(95, 30)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(413, 434)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(95, 30)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        Me.btnVolver.Visible = False
        '
        'EstudiosFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 534)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gbFormaPago)
        Me.Controls.Add(Me.gbTarjeta)
        Me.Controls.Add(Me.gbFacturacion)
        Me.Name = "EstudiosFacturacion"
        Me.Text = "Estudios"
        Me.gbFacturacion.ResumeLayout(False)
        Me.gbFacturacion.PerformLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFormaPago.ResumeLayout(False)
        Me.gbFormaPago.PerformLayout()
        Me.gbTarjeta.ResumeLayout(False)
        Me.gbTarjeta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbFacturacion As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDire As System.Windows.Forms.Label
    Friend WithEvents lblNombrePaciente As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents gbTarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents btnAbonar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVto As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtNroTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents rbDebito As System.Windows.Forms.RadioButton
    Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
