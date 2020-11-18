<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuEnfermeria
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
        Me.cmdEgresoPac = New System.Windows.Forms.Button()
        Me.cmdVisPeriod = New System.Windows.Forms.Button()
        Me.cmdAltaRonda = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdEgresoPac
        '
        Me.cmdEgresoPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEgresoPac.Location = New System.Drawing.Point(25, 24)
        Me.cmdEgresoPac.Name = "cmdEgresoPac"
        Me.cmdEgresoPac.Size = New System.Drawing.Size(162, 78)
        Me.cmdEgresoPac.TabIndex = 0
        Me.cmdEgresoPac.Text = "Egreso de paciente"
        Me.cmdEgresoPac.UseVisualStyleBackColor = True
        '
        'cmdVisPeriod
        '
        Me.cmdVisPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVisPeriod.Location = New System.Drawing.Point(215, 24)
        Me.cmdVisPeriod.Name = "cmdVisPeriod"
        Me.cmdVisPeriod.Size = New System.Drawing.Size(162, 78)
        Me.cmdVisPeriod.TabIndex = 1
        Me.cmdVisPeriod.Text = "Visitas periodicas a pacientes"
        Me.cmdVisPeriod.UseVisualStyleBackColor = True
        '
        'cmdAltaRonda
        '
        Me.cmdAltaRonda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAltaRonda.Location = New System.Drawing.Point(400, 24)
        Me.cmdAltaRonda.Name = "cmdAltaRonda"
        Me.cmdAltaRonda.Size = New System.Drawing.Size(162, 78)
        Me.cmdAltaRonda.TabIndex = 2
        Me.cmdAltaRonda.Text = "Alta de ronda"
        Me.cmdAltaRonda.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(215, 121)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(162, 48)
        Me.cmdVolver.TabIndex = 3
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmMenuEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 185)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdAltaRonda)
        Me.Controls.Add(Me.cmdVisPeriod)
        Me.Controls.Add(Me.cmdEgresoPac)
        Me.Name = "frmMenuEnfermeria"
        Me.Text = "Menu de enfermeria"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEgresoPac As Button
    Friend WithEvents cmdVisPeriod As Button
    Friend WithEvents cmdAltaRonda As Button
    Friend WithEvents cmdVolver As Button
End Class
