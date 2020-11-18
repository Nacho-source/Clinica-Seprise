<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoriaClinicaCE
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
        Me.lstHistoriaClinica = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDatos = New System.Windows.Forms.TextBox()
        Me.rdbDni = New System.Windows.Forms.RadioButton()
        Me.rdbCodigo = New System.Windows.Forms.RadioButton()
        Me.cmdDatos = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtCodMed = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Historia Clinica de Pacientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Consultorios Externos"
        '
        'lstHistoriaClinica
        '
        Me.lstHistoriaClinica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHistoriaClinica.FormattingEnabled = True
        Me.lstHistoriaClinica.ItemHeight = 16
        Me.lstHistoriaClinica.Location = New System.Drawing.Point(25, 200)
        Me.lstHistoriaClinica.Name = "lstHistoriaClinica"
        Me.lstHistoriaClinica.Size = New System.Drawing.Size(715, 388)
        Me.lstHistoriaClinica.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(449, 630)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(202, 53)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "VOLVER"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(108, 630)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ADMINISTRACION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDatos)
        Me.GroupBox1.Controls.Add(Me.rdbDni)
        Me.GroupBox1.Controls.Add(Me.rdbCodigo)
        Me.GroupBox1.Controls.Add(Me.cmdDatos)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtCodMed)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 113)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Paciente"
        '
        'txtDatos
        '
        Me.txtDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatos.Location = New System.Drawing.Point(531, 20)
        Me.txtDatos.Multiline = True
        Me.txtDatos.Name = "txtDatos"
        Me.txtDatos.Size = New System.Drawing.Size(172, 78)
        Me.txtDatos.TabIndex = 24
        '
        'rdbDni
        '
        Me.rdbDni.AutoSize = True
        Me.rdbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDni.Location = New System.Drawing.Point(6, 63)
        Me.rdbDni.Name = "rdbDni"
        Me.rdbDni.Size = New System.Drawing.Size(175, 20)
        Me.rdbDni.TabIndex = 21
        Me.rdbDni.TabStop = True
        Me.rdbDni.Text = "Ingrese DNI del Paciente"
        Me.rdbDni.UseVisualStyleBackColor = True
        '
        'rdbCodigo
        '
        Me.rdbCodigo.AutoSize = True
        Me.rdbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCodigo.Location = New System.Drawing.Point(6, 21)
        Me.rdbCodigo.Name = "rdbCodigo"
        Me.rdbCodigo.Size = New System.Drawing.Size(193, 20)
        Me.rdbCodigo.TabIndex = 20
        Me.rdbCodigo.TabStop = True
        Me.rdbCodigo.Text = "Ingrese Codgo del Paciente"
        Me.rdbCodigo.UseVisualStyleBackColor = True
        '
        'cmdDatos
        '
        Me.cmdDatos.Location = New System.Drawing.Point(395, 32)
        Me.cmdDatos.Name = "cmdDatos"
        Me.cmdDatos.Size = New System.Drawing.Size(101, 51)
        Me.cmdDatos.TabIndex = 19
        Me.cmdDatos.Text = "BUSCAR"
        Me.cmdDatos.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(204, 61)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(167, 22)
        Me.txtDni.TabIndex = 17
        '
        'txtCodMed
        '
        Me.txtCodMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMed.Location = New System.Drawing.Point(205, 19)
        Me.txtCodMed.Name = "txtCodMed"
        Me.txtCodMed.Size = New System.Drawing.Size(167, 22)
        Me.txtCodMed.TabIndex = 15
        '
        'HistoriaClinicaCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 740)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstHistoriaClinica)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HistoriaClinicaCE"
        Me.Text = "HistoriaClinicaCE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstHistoriaClinica As System.Windows.Forms.ListBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDni As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents cmdDatos As System.Windows.Forms.Button
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtCodMed As System.Windows.Forms.TextBox
    Friend WithEvents txtDatos As System.Windows.Forms.TextBox
End Class
