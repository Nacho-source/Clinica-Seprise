<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarMedicoTurno
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
        Me.lblNombreMedico = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.NumericUpDown()
        Me.Minutos = New System.Windows.Forms.NumericUpDown()
        Me.Duracion = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDia = New System.Windows.Forms.Label()
        CType(Me.Hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Duracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreMedico
        '
        Me.lblNombreMedico.AutoSize = True
        Me.lblNombreMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMedico.Location = New System.Drawing.Point(122, 21)
        Me.lblNombreMedico.Name = "lblNombreMedico"
        Me.lblNombreMedico.Size = New System.Drawing.Size(50, 13)
        Me.lblNombreMedico.TabIndex = 32
        Me.lblNombreMedico.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Minutos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Hora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombre medico:"
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(168, 181)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(157, 54)
        Me.btnCambiar.TabIndex = 24
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(5, 181)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(157, 54)
        Me.btnAtras.TabIndex = 23
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Duracion"
        '
        'Hora
        '
        Me.Hora.Location = New System.Drawing.Point(18, 87)
        Me.Hora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(55, 20)
        Me.Hora.TabIndex = 35
        '
        'Minutos
        '
        Me.Minutos.Location = New System.Drawing.Point(107, 87)
        Me.Minutos.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(55, 20)
        Me.Minutos.TabIndex = 36
        '
        'Duracion
        '
        Me.Duracion.Location = New System.Drawing.Point(204, 87)
        Me.Duracion.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.Duracion.Name = "Duracion"
        Me.Duracion.Size = New System.Drawing.Size(55, 20)
        Me.Duracion.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Dia:"
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.Location = New System.Drawing.Point(122, 44)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(26, 13)
        Me.lblDia.TabIndex = 39
        Me.lblDia.Text = "Dia"
        '
        'ModificarMedicoTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 252)
        Me.Controls.Add(Me.lblDia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Duracion)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNombreMedico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "ModificarMedicoTurno"
        Me.Text = "Modificar Medico Turno"
        CType(Me.Hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Duracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreMedico As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCambiar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Hora As NumericUpDown
    Friend WithEvents Minutos As NumericUpDown
    Friend WithEvents Duracion As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDia As Label
End Class
