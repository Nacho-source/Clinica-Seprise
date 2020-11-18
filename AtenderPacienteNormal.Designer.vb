<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtenderPacienteNormal
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
        Me.btnAtender = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAtender
        '
        Me.btnAtender.Location = New System.Drawing.Point(377, 276)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(148, 52)
        Me.btnAtender.TabIndex = 9
        Me.btnAtender.Text = "Comenzar Atencion"
        Me.btnAtender.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Seleccionar medico (se muestran solo los disponibles)"
        '
        'cboMedico
        '
        Me.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(141, 82)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(384, 21)
        Me.cboMedico.TabIndex = 7
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(141, 276)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(148, 52)
        Me.btnAtras.TabIndex = 10
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'AtenderPacienteNormal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 450)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnAtender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMedico)
        Me.Name = "AtenderPacienteNormal"
        Me.Text = "Atender Paciente Normal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtender As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMedico As ComboBox
    Friend WithEvents btnAtras As Button
End Class
