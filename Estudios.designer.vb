<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudios
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
        Me.gpoMenu = New System.Windows.Forms.GroupBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnBusqueda = New System.Windows.Forms.Button()
        Me.txtDocBusqueda = New System.Windows.Forms.TextBox()
        Me.lblDocBusqueda = New System.Windows.Forms.Label()
        Me.gbBotones = New System.Windows.Forms.GroupBox()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.btnTurno = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.gpoMenu.SuspendLayout()
        Me.gbBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoMenu
        '
        Me.gpoMenu.Controls.Add(Me.btnVolver)
        Me.gpoMenu.Controls.Add(Me.btnBusqueda)
        Me.gpoMenu.Controls.Add(Me.txtDocBusqueda)
        Me.gpoMenu.Controls.Add(Me.lblDocBusqueda)
        Me.gpoMenu.Location = New System.Drawing.Point(32, 25)
        Me.gpoMenu.Name = "gpoMenu"
        Me.gpoMenu.Size = New System.Drawing.Size(406, 192)
        Me.gpoMenu.TabIndex = 0
        Me.gpoMenu.TabStop = False
        Me.gpoMenu.Text = "Busqueda Paciente "
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(131, 73)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(111, 36)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnBusqueda
        '
        Me.btnBusqueda.Location = New System.Drawing.Point(266, 73)
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Size = New System.Drawing.Size(99, 35)
        Me.btnBusqueda.TabIndex = 20
        Me.btnBusqueda.Text = "Busqueda"
        Me.btnBusqueda.UseVisualStyleBackColor = True
        '
        'txtDocBusqueda
        '
        Me.txtDocBusqueda.Location = New System.Drawing.Point(131, 36)
        Me.txtDocBusqueda.Name = "txtDocBusqueda"
        Me.txtDocBusqueda.Size = New System.Drawing.Size(234, 20)
        Me.txtDocBusqueda.TabIndex = 19
        '
        'lblDocBusqueda
        '
        Me.lblDocBusqueda.AutoSize = True
        Me.lblDocBusqueda.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocBusqueda.Location = New System.Drawing.Point(25, 36)
        Me.lblDocBusqueda.Name = "lblDocBusqueda"
        Me.lblDocBusqueda.Size = New System.Drawing.Size(96, 19)
        Me.lblDocBusqueda.TabIndex = 0
        Me.lblDocBusqueda.Text = "NºDocumento"
        '
        'gbBotones
        '
        Me.gbBotones.Controls.Add(Me.btnPagar)
        Me.gbBotones.Controls.Add(Me.Label1)
        Me.gbBotones.Controls.Add(Me.btnRegistro)
        Me.gbBotones.Controls.Add(Me.btnTurno)
        Me.gbBotones.Location = New System.Drawing.Point(465, 25)
        Me.gbBotones.Name = "gbBotones"
        Me.gbBotones.Size = New System.Drawing.Size(144, 192)
        Me.gbBotones.TabIndex = 19
        Me.gbBotones.TabStop = False
        Me.gbBotones.Visible = False
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(23, 99)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(102, 36)
        Me.btnRegistro.TabIndex = 18
        Me.btnRegistro.Text = "Registro de Almacen"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'btnTurno
        '
        Me.btnTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnTurno.Location = New System.Drawing.Point(23, 47)
        Me.btnTurno.Name = "btnTurno"
        Me.btnTurno.Size = New System.Drawing.Size(102, 36)
        Me.btnTurno.TabIndex = 18
        Me.btnTurno.Text = "Agendar Turno "
        Me.btnTurno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "¿Que desea realizar? "
        '
        'btnPagar
        '
        Me.btnPagar.Location = New System.Drawing.Point(23, 151)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(102, 35)
        Me.btnPagar.TabIndex = 20
        Me.btnPagar.Text = "Pagar Estudio"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'Estudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 266)
        Me.Controls.Add(Me.gbBotones)
        Me.Controls.Add(Me.gpoMenu)
        Me.Name = "Estudios"
        Me.Text = "Estudios"
        Me.gpoMenu.ResumeLayout(False)
        Me.gpoMenu.PerformLayout()
        Me.gbBotones.ResumeLayout(False)
        Me.gbBotones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnBusqueda As System.Windows.Forms.Button
    Friend WithEvents txtDocBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblDocBusqueda As System.Windows.Forms.Label
    Friend WithEvents gbBotones As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents btnTurno As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
End Class
