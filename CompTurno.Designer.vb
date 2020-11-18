<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompTurno))
        Me.lblNomMed = New System.Windows.Forms.Label()
        Me.lblNomMedico = New System.Windows.Forms.Label()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.lblSala = New System.Windows.Forms.Label()
        Me.lblidTurno = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFH = New System.Windows.Forms.Label()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNomMed
        '
        Me.lblNomMed.AutoSize = True
        Me.lblNomMed.BackColor = System.Drawing.Color.White
        Me.lblNomMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomMed.Location = New System.Drawing.Point(125, 260)
        Me.lblNomMed.Name = "lblNomMed"
        Me.lblNomMed.Size = New System.Drawing.Size(49, 16)
        Me.lblNomMed.TabIndex = 38
        Me.lblNomMed.Text = "Label5"
        '
        'lblNomMedico
        '
        Me.lblNomMedico.AutoSize = True
        Me.lblNomMedico.BackColor = System.Drawing.Color.White
        Me.lblNomMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomMedico.Location = New System.Drawing.Point(63, 260)
        Me.lblNomMedico.Name = "lblNomMedico"
        Me.lblNomMedico.Size = New System.Drawing.Size(56, 16)
        Me.lblNomMedico.TabIndex = 37
        Me.lblNomMedico.Text = "Médico:"
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.BackColor = System.Drawing.Color.White
        Me.lblSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSal.Location = New System.Drawing.Point(161, 288)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(49, 16)
        Me.lblSal.TabIndex = 36
        Me.lblSal.Text = "Label5"
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.BackColor = System.Drawing.Color.White
        Me.lblSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.Location = New System.Drawing.Point(63, 288)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(86, 16)
        Me.lblSala.TabIndex = 35
        Me.lblSala.Text = "id de la Sala:"
        '
        'lblidTurno
        '
        Me.lblidTurno.AutoSize = True
        Me.lblidTurno.BackColor = System.Drawing.Color.White
        Me.lblidTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidTurno.Location = New System.Drawing.Point(161, 11)
        Me.lblidTurno.Name = "lblidTurno"
        Me.lblidTurno.Size = New System.Drawing.Size(57, 20)
        Me.lblidTurno.TabIndex = 32
        Me.lblidTurno.Text = "Label5"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.BackColor = System.Drawing.Color.White
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(60, 11)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(95, 20)
        Me.lblTurno.TabIndex = 31
        Me.lblTurno.Text = "id del Turno:"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.BackColor = System.Drawing.Color.White
        Me.lblNom.Location = New System.Drawing.Point(356, 130)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(39, 13)
        Me.lblNom.TabIndex = 30
        Me.lblNom.Text = "Label1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(356, 130)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblNombre.TabIndex = 29
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.BackColor = System.Drawing.Color.White
        Me.lblDNI.Location = New System.Drawing.Point(95, 155)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(39, 13)
        Me.lblDNI.TabIndex = 28
        Me.lblDNI.Text = "Label6"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(217, 155)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(39, 13)
        Me.lblID.TabIndex = 27
        Me.lblID.Text = "Label6"
        '
        'lblFH
        '
        Me.lblFH.AutoSize = True
        Me.lblFH.BackColor = System.Drawing.Color.White
        Me.lblFH.Location = New System.Drawing.Point(107, 205)
        Me.lblFH.Name = "lblFH"
        Me.lblFH.Size = New System.Drawing.Size(39, 13)
        Me.lblFH.TabIndex = 26
        Me.lblFH.Text = "Label6"
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.BackColor = System.Drawing.Color.White
        Me.lblConsulta.Location = New System.Drawing.Point(230, 181)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(39, 13)
        Me.lblConsulta.TabIndex = 25
        Me.lblConsulta.Text = "Label6"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(193, 230)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 24
        Me.lblFecha.Text = "Label6"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(470, 339)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 23
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(15, 339)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'CompTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(560, 372)
        Me.Controls.Add(Me.lblNomMed)
        Me.Controls.Add(Me.lblNomMedico)
        Me.Controls.Add(Me.lblSal)
        Me.Controls.Add(Me.lblSala)
        Me.Controls.Add(Me.lblidTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblFH)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "CompTurno"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNomMed As System.Windows.Forms.Label
    Friend WithEvents lblNomMedico As System.Windows.Forms.Label
    Friend WithEvents lblSal As System.Windows.Forms.Label
    Friend WithEvents lblSala As System.Windows.Forms.Label
    Friend WithEvents lblidTurno As System.Windows.Forms.Label
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblFH As System.Windows.Forms.Label
    Friend WithEvents lblConsulta As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
