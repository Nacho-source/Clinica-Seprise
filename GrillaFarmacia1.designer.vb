<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrillaFarmacia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvGrillaFarmacia = New System.Windows.Forms.DataGridView()
        Me.dgvGrillaFarmacia2 = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEliminar2 = New System.Windows.Forms.Button()
        Me.btnModificar2 = New System.Windows.Forms.Button()
        Me.btnAgregar2 = New System.Windows.Forms.Button()
        Me.lbltitulo1 = New System.Windows.Forms.Label()
        Me.lbltitulo2 = New System.Windows.Forms.Label()
        Me.lbltitulo3 = New System.Windows.Forms.Label()
        CType(Me.dgvGrillaFarmacia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrillaFarmacia2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGrillaFarmacia
        '
        Me.dgvGrillaFarmacia.AllowUserToResizeColumns = False
        Me.dgvGrillaFarmacia.AllowUserToResizeRows = False
        Me.dgvGrillaFarmacia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGrillaFarmacia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrillaFarmacia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrillaFarmacia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaFarmacia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrillaFarmacia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaFarmacia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrillaFarmacia.EnableHeadersVisualStyles = False
        Me.dgvGrillaFarmacia.Location = New System.Drawing.Point(21, 82)
        Me.dgvGrillaFarmacia.MultiSelect = False
        Me.dgvGrillaFarmacia.Name = "dgvGrillaFarmacia"
        Me.dgvGrillaFarmacia.ReadOnly = True
        Me.dgvGrillaFarmacia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrillaFarmacia.ShowEditingIcon = False
        Me.dgvGrillaFarmacia.Size = New System.Drawing.Size(430, 310)
        Me.dgvGrillaFarmacia.TabIndex = 0
        '
        'dgvGrillaFarmacia2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaFarmacia2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrillaFarmacia2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaFarmacia2.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrillaFarmacia2.Location = New System.Drawing.Point(526, 82)
        Me.dgvGrillaFarmacia2.Name = "dgvGrillaFarmacia2"
        Me.dgvGrillaFarmacia2.Size = New System.Drawing.Size(431, 310)
        Me.dgvGrillaFarmacia2.TabIndex = 1
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 535)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(150, 49)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(837, 422)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 49)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(685, 422)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(120, 49)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(526, 422)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 49)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEliminar2
        '
        Me.btnEliminar2.Location = New System.Drawing.Point(21, 422)
        Me.btnEliminar2.Name = "btnEliminar2"
        Me.btnEliminar2.Size = New System.Drawing.Size(120, 49)
        Me.btnEliminar2.TabIndex = 8
        Me.btnEliminar2.Text = "Eliminar"
        Me.btnEliminar2.UseVisualStyleBackColor = True
        '
        'btnModificar2
        '
        Me.btnModificar2.Location = New System.Drawing.Point(174, 422)
        Me.btnModificar2.Name = "btnModificar2"
        Me.btnModificar2.Size = New System.Drawing.Size(120, 49)
        Me.btnModificar2.TabIndex = 7
        Me.btnModificar2.Text = "Modificar"
        Me.btnModificar2.UseVisualStyleBackColor = True
        '
        'btnAgregar2
        '
        Me.btnAgregar2.Location = New System.Drawing.Point(331, 422)
        Me.btnAgregar2.Name = "btnAgregar2"
        Me.btnAgregar2.Size = New System.Drawing.Size(120, 49)
        Me.btnAgregar2.TabIndex = 6
        Me.btnAgregar2.Text = "Agregar"
        Me.btnAgregar2.UseVisualStyleBackColor = True
        '
        'lbltitulo1
        '
        Me.lbltitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo1.Location = New System.Drawing.Point(29, 27)
        Me.lbltitulo1.Name = "lbltitulo1"
        Me.lbltitulo1.Size = New System.Drawing.Size(422, 33)
        Me.lbltitulo1.TabIndex = 9
        Me.lbltitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbltitulo1.Visible = False
        '
        'lbltitulo2
        '
        Me.lbltitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo2.Location = New System.Drawing.Point(523, 27)
        Me.lbltitulo2.Name = "lbltitulo2"
        Me.lbltitulo2.Size = New System.Drawing.Size(434, 33)
        Me.lbltitulo2.TabIndex = 10
        Me.lbltitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbltitulo2.Visible = False
        '
        'lbltitulo3
        '
        Me.lbltitulo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo3.Location = New System.Drawing.Point(331, 27)
        Me.lbltitulo3.Name = "lbltitulo3"
        Me.lbltitulo3.Size = New System.Drawing.Size(315, 33)
        Me.lbltitulo3.TabIndex = 11
        Me.lbltitulo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbltitulo3.Visible = False
        '
        'GrillaFarmacia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 582)
        Me.Controls.Add(Me.lbltitulo3)
        Me.Controls.Add(Me.lbltitulo2)
        Me.Controls.Add(Me.lbltitulo1)
        Me.Controls.Add(Me.btnEliminar2)
        Me.Controls.Add(Me.btnModificar2)
        Me.Controls.Add(Me.btnAgregar2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvGrillaFarmacia2)
        Me.Controls.Add(Me.dgvGrillaFarmacia)
        Me.Name = "GrillaFarmacia"
        Me.Text = "Grilla"
        CType(Me.dgvGrillaFarmacia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrillaFarmacia2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvGrillaFarmacia As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGrillaFarmacia2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar2 As System.Windows.Forms.Button
    Friend WithEvents btnModificar2 As System.Windows.Forms.Button
    Friend WithEvents btnAgregar2 As System.Windows.Forms.Button
    Friend WithEvents lbltitulo1 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo2 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo3 As System.Windows.Forms.Label

End Class
