<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlmacenEstudio
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
        Me.gbRegistro = New System.Windows.Forms.GroupBox()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.rbRetirar = New System.Windows.Forms.RadioButton()
        Me.rbIngresar = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.gbRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRegistro
        '
        Me.gbRegistro.Controls.Add(Me.btnTerminar)
        Me.gbRegistro.Controls.Add(Me.rbRetirar)
        Me.gbRegistro.Controls.Add(Me.rbIngresar)
        Me.gbRegistro.Controls.Add(Me.Label4)
        Me.gbRegistro.Controls.Add(Me.lblFecha)
        Me.gbRegistro.Controls.Add(Me.lblFechaIngreso)
        Me.gbRegistro.Location = New System.Drawing.Point(28, 57)
        Me.gbRegistro.Name = "gbRegistro"
        Me.gbRegistro.Size = New System.Drawing.Size(359, 173)
        Me.gbRegistro.TabIndex = 1
        Me.gbRegistro.TabStop = False
        Me.gbRegistro.Text = "Registro del Estudio "
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(220, 128)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(97, 28)
        Me.btnTerminar.TabIndex = 6
        Me.btnTerminar.UseVisualStyleBackColor = True
        Me.btnTerminar.Visible = False
        '
        'rbRetirar
        '
        Me.rbRetirar.AutoSize = True
        Me.rbRetirar.Location = New System.Drawing.Point(129, 53)
        Me.rbRetirar.Name = "rbRetirar"
        Me.rbRetirar.Size = New System.Drawing.Size(56, 17)
        Me.rbRetirar.TabIndex = 5
        Me.rbRetirar.Text = "Retirar"
        Me.rbRetirar.UseVisualStyleBackColor = True
        '
        'rbIngresar
        '
        Me.rbIngresar.AutoSize = True
        Me.rbIngresar.Location = New System.Drawing.Point(51, 53)
        Me.rbIngresar.Name = "rbIngresar"
        Me.rbIngresar.Size = New System.Drawing.Size(63, 17)
        Me.rbIngresar.TabIndex = 4
        Me.rbIngresar.Text = "Ingresar"
        Me.rbIngresar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "¿Desea ingresar o retirar estudio? "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(114, 101)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Visible = False
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Location = New System.Drawing.Point(9, 101)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(96, 13)
        Me.lblFechaIngreso.TabIndex = 0
        Me.lblFechaIngreso.Text = "Fecha de Ingreso: "
        Me.lblFechaIngreso.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(248, 246)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(97, 28)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        Me.btnVolver.Visible = False
        '
        'AlmacenEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 441)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.gbRegistro)
        Me.Name = "AlmacenEstudio"
        Me.Text = "Estudios"
        Me.gbRegistro.ResumeLayout(False)
        Me.gbRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
    Friend WithEvents btnTerminar As System.Windows.Forms.Button
    Friend WithEvents rbRetirar As System.Windows.Forms.RadioButton
    Friend WithEvents rbIngresar As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
