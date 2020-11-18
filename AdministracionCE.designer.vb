<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministracionCE
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
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.cmdTurno = New System.Windows.Forms.Button()
        Me.cmdIngreso = New System.Windows.Forms.Button()
        Me.cmdRecepcion = New System.Windows.Forms.Button()
        Me.cmdHonorario = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(12, 360)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(73, 30)
        Me.cmdVolver.TabIndex = 1
        Me.cmdVolver.Text = "VOLVER"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'cmdTurno
        '
        Me.cmdTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTurno.Location = New System.Drawing.Point(224, 255)
        Me.cmdTurno.Name = "cmdTurno"
        Me.cmdTurno.Size = New System.Drawing.Size(119, 63)
        Me.cmdTurno.TabIndex = 2
        Me.cmdTurno.Text = "SOLICITAR TURNO"
        Me.cmdTurno.UseVisualStyleBackColor = True
        '
        'cmdIngreso
        '
        Me.cmdIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIngreso.Location = New System.Drawing.Point(403, 156)
        Me.cmdIngreso.Name = "cmdIngreso"
        Me.cmdIngreso.Size = New System.Drawing.Size(119, 63)
        Me.cmdIngreso.TabIndex = 3
        Me.cmdIngreso.Text = "VALIDAR INGRESO A MEDICOS"
        Me.cmdIngreso.UseVisualStyleBackColor = True
        '
        'cmdRecepcion
        '
        Me.cmdRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRecepcion.Location = New System.Drawing.Point(224, 156)
        Me.cmdRecepcion.Name = "cmdRecepcion"
        Me.cmdRecepcion.Size = New System.Drawing.Size(119, 63)
        Me.cmdRecepcion.TabIndex = 4
        Me.cmdRecepcion.Text = "LISTA DE TURNOS"
        Me.cmdRecepcion.UseVisualStyleBackColor = True
        '
        'cmdHonorario
        '
        Me.cmdHonorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHonorario.Location = New System.Drawing.Point(559, 309)
        Me.cmdHonorario.Name = "cmdHonorario"
        Me.cmdHonorario.Size = New System.Drawing.Size(119, 63)
        Me.cmdHonorario.TabIndex = 5
        Me.cmdHonorario.Text = "LIQUIDAR HONORARIOS DE MEDICOS"
        Me.cmdHonorario.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(135, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(512, 124)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "» CONSULTORIOS EXTERNOS"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(403, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 63)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "HISTORIA CLINICA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdministracionCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 402)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdHonorario)
        Me.Controls.Add(Me.cmdRecepcion)
        Me.Controls.Add(Me.cmdIngreso)
        Me.Controls.Add(Me.cmdTurno)
        Me.Controls.Add(Me.cmdVolver)
        Me.Name = "AdministracionCE"
        Me.Text = "Administracion Consultorios Externos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents cmdTurno As System.Windows.Forms.Button
    Friend WithEvents cmdIngreso As System.Windows.Forms.Button
    Friend WithEvents cmdRecepcion As System.Windows.Forms.Button
    Friend WithEvents cmdHonorario As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
