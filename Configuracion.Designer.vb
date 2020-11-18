<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.gboPanel = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gboPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboPanel
        '
        Me.gboPanel.Controls.Add(Me.Button1)
        Me.gboPanel.Location = New System.Drawing.Point(12, 45)
        Me.gboPanel.Name = "gboPanel"
        Me.gboPanel.Size = New System.Drawing.Size(559, 379)
        Me.gboPanel.TabIndex = 0
        Me.gboPanel.TabStop = False
        Me.gboPanel.Text = "Panel de Control"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar Estudios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 475)
        Me.Controls.Add(Me.gboPanel)
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        Me.gboPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboPanel As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
