<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPaquete
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
        Me.lblCantR = New System.Windows.Forms.Label()
        Me.lblCantP = New System.Windows.Forms.Label()
        Me.lbltitulo2 = New System.Windows.Forms.Label()
        Me.lbltitulo1 = New System.Windows.Forms.Label()
        Me.btnRegArt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegM = New System.Windows.Forms.Button()
        Me.lblCantIng = New System.Windows.Forms.Label()
        Me.lblCantRest = New System.Windows.Forms.Label()
        Me.lblCantPed = New System.Windows.Forms.Label()
        Me.txtCantIng = New System.Windows.Forms.TextBox()
        Me.dgvGrillaPedidoM = New System.Windows.Forms.DataGridView()
        Me.btnRegI = New System.Windows.Forms.Button()
        Me.dgvGrillaPedidoI = New System.Windows.Forms.DataGridView()
        CType(Me.dgvGrillaPedidoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrillaPedidoI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantR
        '
        Me.lblCantR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantR.Location = New System.Drawing.Point(724, 210)
        Me.lblCantR.Name = "lblCantR"
        Me.lblCantR.Size = New System.Drawing.Size(153, 18)
        Me.lblCantR.TabIndex = 39
        Me.lblCantR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCantP
        '
        Me.lblCantP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantP.Location = New System.Drawing.Point(587, 210)
        Me.lblCantP.Name = "lblCantP"
        Me.lblCantP.Size = New System.Drawing.Size(131, 18)
        Me.lblCantP.TabIndex = 38
        Me.lblCantP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo2
        '
        Me.lbltitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo2.Location = New System.Drawing.Point(258, 59)
        Me.lbltitulo2.Name = "lbltitulo2"
        Me.lbltitulo2.Size = New System.Drawing.Size(290, 33)
        Me.lbltitulo2.TabIndex = 37
        Me.lbltitulo2.Text = "Medicamentos"
        Me.lbltitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo1
        '
        Me.lbltitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo1.Location = New System.Drawing.Point(12, 59)
        Me.lbltitulo1.Name = "lbltitulo1"
        Me.lbltitulo1.Size = New System.Drawing.Size(221, 33)
        Me.lbltitulo1.TabIndex = 36
        Me.lbltitulo1.Text = "Insumos"
        Me.lbltitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegArt
        '
        Me.btnRegArt.Location = New System.Drawing.Point(672, 424)
        Me.btnRegArt.Name = "btnRegArt"
        Me.btnRegArt.Size = New System.Drawing.Size(120, 49)
        Me.btnRegArt.TabIndex = 35
        Me.btnRegArt.Text = "Registrar Articulo"
        Me.btnRegArt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(879, 50)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Control de Paquetes"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegM
        '
        Me.btnRegM.Location = New System.Drawing.Point(361, 424)
        Me.btnRegM.Name = "btnRegM"
        Me.btnRegM.Size = New System.Drawing.Size(104, 49)
        Me.btnRegM.TabIndex = 33
        Me.btnRegM.Text = "Registrar Medicamento"
        Me.btnRegM.UseVisualStyleBackColor = True
        '
        'lblCantIng
        '
        Me.lblCantIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantIng.Location = New System.Drawing.Point(587, 296)
        Me.lblCantIng.Name = "lblCantIng"
        Me.lblCantIng.Size = New System.Drawing.Size(139, 50)
        Me.lblCantIng.TabIndex = 32
        Me.lblCantIng.Text = "Indicar la cantidad que desea registrar: "
        Me.lblCantIng.Visible = False
        '
        'lblCantRest
        '
        Me.lblCantRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantRest.Location = New System.Drawing.Point(724, 184)
        Me.lblCantRest.Name = "lblCantRest"
        Me.lblCantRest.Size = New System.Drawing.Size(153, 26)
        Me.lblCantRest.TabIndex = 31
        Me.lblCantRest.Text = "Cantidad en Almacen:"
        Me.lblCantRest.Visible = False
        '
        'lblCantPed
        '
        Me.lblCantPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantPed.Location = New System.Drawing.Point(584, 184)
        Me.lblCantPed.Name = "lblCantPed"
        Me.lblCantPed.Size = New System.Drawing.Size(134, 26)
        Me.lblCantPed.TabIndex = 30
        Me.lblCantPed.Text = "Cantidad Faltante:"
        Me.lblCantPed.Visible = False
        '
        'txtCantIng
        '
        Me.txtCantIng.Location = New System.Drawing.Point(732, 315)
        Me.txtCantIng.Name = "txtCantIng"
        Me.txtCantIng.Size = New System.Drawing.Size(100, 20)
        Me.txtCantIng.TabIndex = 29
        Me.txtCantIng.Visible = False
        '
        'dgvGrillaPedidoM
        '
        Me.dgvGrillaPedidoM.AllowUserToResizeColumns = False
        Me.dgvGrillaPedidoM.AllowUserToResizeRows = False
        Me.dgvGrillaPedidoM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGrillaPedidoM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrillaPedidoM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrillaPedidoM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaPedidoM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrillaPedidoM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaPedidoM.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrillaPedidoM.EnableHeadersVisualStyles = False
        Me.dgvGrillaPedidoM.Location = New System.Drawing.Point(258, 95)
        Me.dgvGrillaPedidoM.MultiSelect = False
        Me.dgvGrillaPedidoM.Name = "dgvGrillaPedidoM"
        Me.dgvGrillaPedidoM.ReadOnly = True
        Me.dgvGrillaPedidoM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrillaPedidoM.ShowEditingIcon = False
        Me.dgvGrillaPedidoM.Size = New System.Drawing.Size(290, 310)
        Me.dgvGrillaPedidoM.TabIndex = 28
        '
        'btnRegI
        '
        Me.btnRegI.Location = New System.Drawing.Point(65, 424)
        Me.btnRegI.Name = "btnRegI"
        Me.btnRegI.Size = New System.Drawing.Size(120, 49)
        Me.btnRegI.TabIndex = 26
        Me.btnRegI.Text = "Registrar Insumo"
        Me.btnRegI.UseVisualStyleBackColor = True
        '
        'dgvGrillaPedidoI
        '
        Me.dgvGrillaPedidoI.AllowUserToResizeColumns = False
        Me.dgvGrillaPedidoI.AllowUserToResizeRows = False
        Me.dgvGrillaPedidoI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGrillaPedidoI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrillaPedidoI.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrillaPedidoI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaPedidoI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGrillaPedidoI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaPedidoI.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGrillaPedidoI.EnableHeadersVisualStyles = False
        Me.dgvGrillaPedidoI.Location = New System.Drawing.Point(12, 95)
        Me.dgvGrillaPedidoI.MultiSelect = False
        Me.dgvGrillaPedidoI.Name = "dgvGrillaPedidoI"
        Me.dgvGrillaPedidoI.ReadOnly = True
        Me.dgvGrillaPedidoI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrillaPedidoI.ShowEditingIcon = False
        Me.dgvGrillaPedidoI.Size = New System.Drawing.Size(221, 310)
        Me.dgvGrillaPedidoI.TabIndex = 25
        '
        'FormularioPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 478)
        Me.Controls.Add(Me.lblCantR)
        Me.Controls.Add(Me.lblCantP)
        Me.Controls.Add(Me.lbltitulo2)
        Me.Controls.Add(Me.lbltitulo1)
        Me.Controls.Add(Me.btnRegArt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegM)
        Me.Controls.Add(Me.lblCantIng)
        Me.Controls.Add(Me.lblCantRest)
        Me.Controls.Add(Me.lblCantPed)
        Me.Controls.Add(Me.txtCantIng)
        Me.Controls.Add(Me.dgvGrillaPedidoM)
        Me.Controls.Add(Me.btnRegI)
        Me.Controls.Add(Me.dgvGrillaPedidoI)
        Me.Name = "FormularioPaquete"
        Me.Text = "FormularioPaquete"
        CType(Me.dgvGrillaPedidoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrillaPedidoI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantR As Label
    Friend WithEvents lblCantP As Label
    Friend WithEvents lbltitulo2 As Label
    Friend WithEvents lbltitulo1 As Label
    Friend WithEvents btnRegArt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegM As Button
    Friend WithEvents lblCantIng As Label
    Friend WithEvents lblCantRest As Label
    Friend WithEvents lblCantPed As Label
    Friend WithEvents txtCantIng As TextBox
    Friend WithEvents dgvGrillaPedidoM As DataGridView
    Friend WithEvents btnRegI As Button
    Friend WithEvents dgvGrillaPedidoI As DataGridView
End Class
