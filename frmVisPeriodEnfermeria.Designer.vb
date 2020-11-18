<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisPeriodEnfermeria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVisPeriodM = New System.Windows.Forms.DataGridView()
        Me.DGVisPeriodI = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdVolver = New System.Windows.Forms.Button()
        CType(Me.DGVisPeriodM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVisPeriodI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVisPeriodM
        '
        Me.DGVisPeriodM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVisPeriodM.Location = New System.Drawing.Point(261, 12)
        Me.DGVisPeriodM.Name = "DGVisPeriodM"
        Me.DGVisPeriodM.Size = New System.Drawing.Size(522, 225)
        Me.DGVisPeriodM.TabIndex = 0
        '
        'DGVisPeriodI
        '
        Me.DGVisPeriodI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVisPeriodI.Location = New System.Drawing.Point(261, 261)
        Me.DGVisPeriodI.Name = "DGVisPeriodI"
        Me.DGVisPeriodI.Size = New System.Drawing.Size(522, 225)
        Me.DGVisPeriodI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Visitas con medicamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Visitas con insumo"
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Location = New System.Drawing.Point(313, 508)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(179, 38)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmVisPeriodEnfermeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 558)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVisPeriodI)
        Me.Controls.Add(Me.DGVisPeriodM)
        Me.Name = "frmVisPeriodEnfermeria"
        Me.Text = "Visitas a realizar en el dia de la fecha"
        CType(Me.DGVisPeriodM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVisPeriodI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVisPeriodM As DataGridView
    Friend WithEvents DGVisPeriodI As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdVolver As Button
End Class
