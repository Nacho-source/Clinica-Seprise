<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarArtOrdCompra
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblCantP = New System.Windows.Forms.Label()
        Me.lblCantF = New System.Windows.Forms.Label()
        Me.lbltitulo2 = New System.Windows.Forms.Label()
        Me.lbltitulo1 = New System.Windows.Forms.Label()
        Me.btnRegArt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegM = New System.Windows.Forms.Button()
        Me.lblCantIng = New System.Windows.Forms.Label()
        Me.lblCantPedida = New System.Windows.Forms.Label()
        Me.lblCantFal = New System.Windows.Forms.Label()
        Me.txtCantIng = New System.Windows.Forms.TextBox()
        Me.dgvGrillaDetOrdCompM = New System.Windows.Forms.DataGridView()
        Me.btnRegI = New System.Windows.Forms.Button()
        Me.dgvGrillaDetOrdCompI = New System.Windows.Forms.DataGridView()
        CType(Me.dgvGrillaDetOrdCompM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrillaDetOrdCompI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantP
        '
        Me.lblCantP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantP.Location = New System.Drawing.Point(713, 202)
        Me.lblCantP.Name = "lblCantP"
        Me.lblCantP.Size = New System.Drawing.Size(153, 18)
        Me.lblCantP.TabIndex = 53
        Me.lblCantP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCantF
        '
        Me.lblCantF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantF.Location = New System.Drawing.Point(576, 202)
        Me.lblCantF.Name = "lblCantF"
        Me.lblCantF.Size = New System.Drawing.Size(131, 18)
        Me.lblCantF.TabIndex = 52
        Me.lblCantF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo2
        '
        Me.lbltitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo2.Location = New System.Drawing.Point(247, 51)
        Me.lbltitulo2.Name = "lbltitulo2"
        Me.lbltitulo2.Size = New System.Drawing.Size(290, 33)
        Me.lbltitulo2.TabIndex = 51
        Me.lbltitulo2.Text = "Medicamentos"
        Me.lbltitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltitulo1
        '
        Me.lbltitulo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo1.Location = New System.Drawing.Point(1, 51)
        Me.lbltitulo1.Name = "lbltitulo1"
        Me.lbltitulo1.Size = New System.Drawing.Size(221, 33)
        Me.lbltitulo1.TabIndex = 50
        Me.lbltitulo1.Text = "Insumos"
        Me.lbltitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegArt
        '
        Me.btnRegArt.Location = New System.Drawing.Point(661, 416)
        Me.btnRegArt.Name = "btnRegArt"
        Me.btnRegArt.Size = New System.Drawing.Size(120, 49)
        Me.btnRegArt.TabIndex = 49
        Me.btnRegArt.Text = "Registrar Articulo"
        Me.btnRegArt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(879, 50)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Control de de articulos de la Orden de Compra"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRegM
        '
        Me.btnRegM.Location = New System.Drawing.Point(350, 416)
        Me.btnRegM.Name = "btnRegM"
        Me.btnRegM.Size = New System.Drawing.Size(104, 49)
        Me.btnRegM.TabIndex = 47
        Me.btnRegM.Text = "Registrar Medicamento"
        Me.btnRegM.UseVisualStyleBackColor = True
        '
        'lblCantIng
        '
        Me.lblCantIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantIng.Location = New System.Drawing.Point(576, 288)
        Me.lblCantIng.Name = "lblCantIng"
        Me.lblCantIng.Size = New System.Drawing.Size(139, 50)
        Me.lblCantIng.TabIndex = 46
        Me.lblCantIng.Text = "Indicar la cantidad que desea registrar: "
        Me.lblCantIng.Visible = False
        '
        'lblCantPedida
        '
        Me.lblCantPedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantPedida.Location = New System.Drawing.Point(713, 176)
        Me.lblCantPedida.Name = "lblCantPedida"
        Me.lblCantPedida.Size = New System.Drawing.Size(153, 26)
        Me.lblCantPedida.TabIndex = 45
        Me.lblCantPedida.Text = "Cantidad Pedida:"
        Me.lblCantPedida.Visible = False
        '
        'lblCantFal
        '
        Me.lblCantFal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantFal.Location = New System.Drawing.Point(573, 176)
        Me.lblCantFal.Name = "lblCantFal"
        Me.lblCantFal.Size = New System.Drawing.Size(134, 26)
        Me.lblCantFal.TabIndex = 44
        Me.lblCantFal.Text = "Cantidad Faltante:"
        Me.lblCantFal.Visible = False
        '
        'txtCantIng
        '
        Me.txtCantIng.Location = New System.Drawing.Point(721, 307)
        Me.txtCantIng.Name = "txtCantIng"
        Me.txtCantIng.Size = New System.Drawing.Size(100, 20)
        Me.txtCantIng.TabIndex = 43
        Me.txtCantIng.Visible = False
        '
        'dgvGrillaDetOrdCompM
        '
        Me.dgvGrillaDetOrdCompM.AllowUserToResizeColumns = False
        Me.dgvGrillaDetOrdCompM.AllowUserToResizeRows = False
        Me.dgvGrillaDetOrdCompM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGrillaDetOrdCompM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrillaDetOrdCompM.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrillaDetOrdCompM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaDetOrdCompM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvGrillaDetOrdCompM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaDetOrdCompM.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvGrillaDetOrdCompM.EnableHeadersVisualStyles = False
        Me.dgvGrillaDetOrdCompM.Location = New System.Drawing.Point(247, 87)
        Me.dgvGrillaDetOrdCompM.MultiSelect = False
        Me.dgvGrillaDetOrdCompM.Name = "dgvGrillaDetOrdCompM"
        Me.dgvGrillaDetOrdCompM.ReadOnly = True
        Me.dgvGrillaDetOrdCompM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrillaDetOrdCompM.ShowEditingIcon = False
        Me.dgvGrillaDetOrdCompM.Size = New System.Drawing.Size(290, 310)
        Me.dgvGrillaDetOrdCompM.TabIndex = 42
        '
        'btnRegI
        '
        Me.btnRegI.Location = New System.Drawing.Point(54, 416)
        Me.btnRegI.Name = "btnRegI"
        Me.btnRegI.Size = New System.Drawing.Size(120, 49)
        Me.btnRegI.TabIndex = 41
        Me.btnRegI.Text = "Registrar Insumo"
        Me.btnRegI.UseVisualStyleBackColor = True
        '
        'dgvGrillaDetOrdCompI
        '
        Me.dgvGrillaDetOrdCompI.AllowUserToResizeColumns = False
        Me.dgvGrillaDetOrdCompI.AllowUserToResizeRows = False
        Me.dgvGrillaDetOrdCompI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGrillaDetOrdCompI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrillaDetOrdCompI.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrillaDetOrdCompI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrillaDetOrdCompI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvGrillaDetOrdCompI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrillaDetOrdCompI.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvGrillaDetOrdCompI.EnableHeadersVisualStyles = False
        Me.dgvGrillaDetOrdCompI.Location = New System.Drawing.Point(1, 87)
        Me.dgvGrillaDetOrdCompI.MultiSelect = False
        Me.dgvGrillaDetOrdCompI.Name = "dgvGrillaDetOrdCompI"
        Me.dgvGrillaDetOrdCompI.ReadOnly = True
        Me.dgvGrillaDetOrdCompI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrillaDetOrdCompI.ShowEditingIcon = False
        Me.dgvGrillaDetOrdCompI.Size = New System.Drawing.Size(221, 310)
        Me.dgvGrillaDetOrdCompI.TabIndex = 40
        '
        'RegistrarArtOrdCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 473)
        Me.Controls.Add(Me.lblCantP)
        Me.Controls.Add(Me.lblCantF)
        Me.Controls.Add(Me.lbltitulo2)
        Me.Controls.Add(Me.lbltitulo1)
        Me.Controls.Add(Me.btnRegArt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRegM)
        Me.Controls.Add(Me.lblCantIng)
        Me.Controls.Add(Me.lblCantPedida)
        Me.Controls.Add(Me.lblCantFal)
        Me.Controls.Add(Me.txtCantIng)
        Me.Controls.Add(Me.dgvGrillaDetOrdCompM)
        Me.Controls.Add(Me.btnRegI)
        Me.Controls.Add(Me.dgvGrillaDetOrdCompI)
        Me.Name = "RegistrarArtOrdCompra"
        Me.Text = "RegistrarArtOrdCompra"
        CType(Me.dgvGrillaDetOrdCompM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrillaDetOrdCompI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantP As Label
    Friend WithEvents lblCantF As Label
    Friend WithEvents lbltitulo2 As Label
    Friend WithEvents lbltitulo1 As Label
    Friend WithEvents btnRegArt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegM As Button
    Friend WithEvents lblCantIng As Label
    Friend WithEvents lblCantPedida As Label
    Friend WithEvents lblCantFal As Label
    Friend WithEvents txtCantIng As TextBox
    Friend WithEvents dgvGrillaDetOrdCompM As DataGridView
    Friend WithEvents btnRegI As Button
    Friend WithEvents dgvGrillaDetOrdCompI As DataGridView
End Class
