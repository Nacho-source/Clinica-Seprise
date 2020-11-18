<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaVisitaPeriodEnfermeria
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
        Me.cmdVovler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVEK = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdVovler
        '
        Me.cmdVovler.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdVovler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVovler.Location = New System.Drawing.Point(500, 330)
        Me.cmdVovler.Name = "cmdVovler"
        Me.cmdVovler.Size = New System.Drawing.Size(137, 45)
        Me.cmdVovler.TabIndex = 0
        Me.cmdVovler.Text = "Volver"
        Me.cmdVovler.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 24)
        Me.Label1.TabIndex = 12
        '
        'txtVEK
        '
        Me.txtVEK.Enabled = False
        Me.txtVEK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVEK.Location = New System.Drawing.Point(171, 35)
        Me.txtVEK.Name = "txtVEK"
        Me.txtVEK.Size = New System.Drawing.Size(148, 26)
        Me.txtVEK.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "IdVisitaEnf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "IdPaciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "IdEmpleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Observaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 24)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Hora"
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(171, 161)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(385, 62)
        Me.txtObs.TabIndex = 20
        '
        'txtIP
        '
        Me.txtIP.Enabled = False
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(171, 79)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(148, 26)
        Me.txtIP.TabIndex = 21
        '
        'txtF
        '
        Me.txtF.Enabled = False
        Me.txtF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF.Location = New System.Drawing.Point(171, 242)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(148, 26)
        Me.txtF.TabIndex = 22
        '
        'txtH
        '
        Me.txtH.Enabled = False
        Me.txtH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtH.Location = New System.Drawing.Point(171, 288)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(148, 26)
        Me.txtH.TabIndex = 23
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(171, 320)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(190, 64)
        Me.cmdGuardar.TabIndex = 24
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cboMedico
        '
        Me.cboMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(171, 119)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(254, 32)
        Me.cboMedico.TabIndex = 25
        Me.cboMedico.Text = "Seleccionar Enfermero"
        '
        'frmAltaVisitaPeriodEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 400)
        Me.Controls.Add(Me.cboMedico)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVEK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVovler)
        Me.Name = "frmAltaVisitaPeriodEnfermeria"
        Me.Text = "Alta de visita periodica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdVovler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVEK As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtF As TextBox
    Friend WithEvents txtH As TextBox
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cboMedico As ComboBox
End Class
