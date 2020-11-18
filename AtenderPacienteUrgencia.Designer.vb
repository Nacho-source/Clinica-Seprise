<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtenderPacienteUrgencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.btnAtender = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seleccionar medico (se muestran solo los disponibles)"
        '
        'cboMedico
        '
        Me.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(138, 82)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(384, 21)
        Me.cboMedico.TabIndex = 2
        '
        'btnAtender
        '
        Me.btnAtender.Location = New System.Drawing.Point(374, 280)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(148, 52)
        Me.btnAtender.TabIndex = 6
        Me.btnAtender.Text = "Comenzar Atencion"
        Me.btnAtender.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(138, 280)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(148, 52)
        Me.btnAtras.TabIndex = 11
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(138, 176)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(153, 21)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Enviar a internación"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AtenderPacienteUrgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 463)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAtender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMedico)
        Me.Name = "AtenderPacienteUrgencia"
        Me.Text = "Atender Paciente de Urgencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboMedico As ComboBox
    Friend WithEvents btnAtender As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
