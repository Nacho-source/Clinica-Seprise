<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeLiquidacionSueldo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtCCA = New System.Windows.Forms.TextBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.lblCC = New System.Windows.Forms.Label()
        Me.txtCFK = New System.Windows.Forms.TextBox()
        Me.lblCFK = New System.Windows.Forms.Label()
        Me.txtCFKA = New System.Windows.Forms.TextBox()
        Me.lblCFKA = New System.Windows.Forms.Label()
        Me.txtCSMA = New System.Windows.Forms.TextBox()
        Me.lblCSMA = New System.Windows.Forms.Label()
        Me.txtCSM = New System.Windows.Forms.TextBox()
        Me.lblCSM = New System.Windows.Forms.Label()
        Me.txtTotalConsultasAsistidas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalConsultas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtPorcen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe de Liquidación de Honorario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(Médico:"
        '
        'lblMedico
        '
        Me.lblMedico.AutoSize = True
        Me.lblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedico.Location = New System.Drawing.Point(84, 29)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(71, 18)
        Me.lblMedico.TabIndex = 2
        Me.lblMedico.Text = "lblmedico"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 72)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(188, 16)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Consultas Comunes Asistidas:"
        '
        'txtCCA
        '
        Me.txtCCA.Enabled = False
        Me.txtCCA.Location = New System.Drawing.Point(206, 71)
        Me.txtCCA.Name = "txtCCA"
        Me.txtCCA.Size = New System.Drawing.Size(42, 20)
        Me.txtCCA.TabIndex = 4
        '
        'txtCC
        '
        Me.txtCC.Enabled = False
        Me.txtCC.Location = New System.Drawing.Point(206, 98)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(42, 20)
        Me.txtCC.TabIndex = 6
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCC.Location = New System.Drawing.Point(12, 99)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(179, 16)
        Me.lblCC.TabIndex = 5
        Me.lblCC.Text = "Consultas Comunes Totales:"
        '
        'txtCFK
        '
        Me.txtCFK.Enabled = False
        Me.txtCFK.Location = New System.Drawing.Point(242, 172)
        Me.txtCFK.Name = "txtCFK"
        Me.txtCFK.Size = New System.Drawing.Size(42, 20)
        Me.txtCFK.TabIndex = 8
        '
        'lblCFK
        '
        Me.lblCFK.AutoSize = True
        Me.lblCFK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFK.Location = New System.Drawing.Point(12, 172)
        Me.lblCFK.Name = "lblCFK"
        Me.lblCFK.Size = New System.Drawing.Size(224, 16)
        Me.lblCFK.TabIndex = 7
        Me.lblCFK.Text = "Consultas Fisiokinesiología Totales:"
        '
        'txtCFKA
        '
        Me.txtCFKA.Enabled = False
        Me.txtCFKA.Location = New System.Drawing.Point(242, 140)
        Me.txtCFKA.Name = "txtCFKA"
        Me.txtCFKA.Size = New System.Drawing.Size(42, 20)
        Me.txtCFKA.TabIndex = 10
        '
        'lblCFKA
        '
        Me.lblCFKA.AutoSize = True
        Me.lblCFKA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFKA.Location = New System.Drawing.Point(12, 144)
        Me.lblCFKA.Name = "lblCFKA"
        Me.lblCFKA.Size = New System.Drawing.Size(233, 16)
        Me.lblCFKA.TabIndex = 9
        Me.lblCFKA.Text = "Consultas Fisiokinesiología Asistidas:"
        '
        'txtCSMA
        '
        Me.txtCSMA.Enabled = False
        Me.txtCSMA.Location = New System.Drawing.Point(227, 210)
        Me.txtCSMA.Name = "txtCSMA"
        Me.txtCSMA.Size = New System.Drawing.Size(42, 20)
        Me.txtCSMA.TabIndex = 14
        '
        'lblCSMA
        '
        Me.lblCSMA.AutoSize = True
        Me.lblCSMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSMA.Location = New System.Drawing.Point(12, 211)
        Me.lblCSMA.Name = "lblCSMA"
        Me.lblCSMA.Size = New System.Drawing.Size(209, 16)
        Me.lblCSMA.TabIndex = 13
        Me.lblCSMA.Text = "Consultas Salud Mental Asistidas:"
        '
        'txtCSM
        '
        Me.txtCSM.Enabled = False
        Me.txtCSM.Location = New System.Drawing.Point(227, 238)
        Me.txtCSM.Name = "txtCSM"
        Me.txtCSM.Size = New System.Drawing.Size(42, 20)
        Me.txtCSM.TabIndex = 12
        '
        'lblCSM
        '
        Me.lblCSM.AutoSize = True
        Me.lblCSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSM.Location = New System.Drawing.Point(12, 239)
        Me.lblCSM.Name = "lblCSM"
        Me.lblCSM.Size = New System.Drawing.Size(200, 16)
        Me.lblCSM.TabIndex = 11
        Me.lblCSM.Text = "Consultas Salud Mental Totales:"
        '
        'txtTotalConsultasAsistidas
        '
        Me.txtTotalConsultasAsistidas.Enabled = False
        Me.txtTotalConsultasAsistidas.Location = New System.Drawing.Point(282, 272)
        Me.txtTotalConsultasAsistidas.Name = "txtTotalConsultasAsistidas"
        Me.txtTotalConsultasAsistidas.Size = New System.Drawing.Size(42, 20)
        Me.txtTotalConsultasAsistidas.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(103, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total de Consultas Asistidas:"
        '
        'txtTotalConsultas
        '
        Me.txtTotalConsultas.Enabled = False
        Me.txtTotalConsultas.Location = New System.Drawing.Point(282, 300)
        Me.txtTotalConsultas.Name = "txtTotalConsultas"
        Me.txtTotalConsultas.Size = New System.Drawing.Size(42, 20)
        Me.txtTotalConsultas.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Total de Consultas:"
        '
        'txtPlus
        '
        Me.txtPlus.Enabled = False
        Me.txtPlus.Location = New System.Drawing.Point(312, 335)
        Me.txtPlus.Name = "txtPlus"
        Me.txtPlus.Size = New System.Drawing.Size(42, 20)
        Me.txtPlus.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Plus de salario mensual:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(312, 363)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(42, 20)
        Me.txtTotal.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Salario final:"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 428)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(78, 39)
        Me.btnVolver.TabIndex = 23
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(352, 428)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(78, 39)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtPorcen
        '
        Me.txtPorcen.Enabled = False
        Me.txtPorcen.Location = New System.Drawing.Point(352, 402)
        Me.txtPorcen.Name = "txtPorcen"
        Me.txtPorcen.Size = New System.Drawing.Size(42, 20)
        Me.txtPorcen.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Porcentaje de Consultas Asistidas:"
        '
        'InformeLiquidacionSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 479)
        Me.Controls.Add(Me.txtPorcen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtPlus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalConsultasAsistidas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalConsultas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCSMA)
        Me.Controls.Add(Me.lblCSMA)
        Me.Controls.Add(Me.txtCSM)
        Me.Controls.Add(Me.lblCSM)
        Me.Controls.Add(Me.txtCFKA)
        Me.Controls.Add(Me.lblCFKA)
        Me.Controls.Add(Me.txtCFK)
        Me.Controls.Add(Me.lblCFK)
        Me.Controls.Add(Me.txtCC)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.txtCCA)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InformeLiquidacionSueldo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMedico As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtCCA As System.Windows.Forms.TextBox
    Friend WithEvents txtCC As System.Windows.Forms.TextBox
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents txtCFK As System.Windows.Forms.TextBox
    Friend WithEvents lblCFK As System.Windows.Forms.Label
    Friend WithEvents txtCFKA As System.Windows.Forms.TextBox
    Friend WithEvents lblCFKA As System.Windows.Forms.Label
    Friend WithEvents txtCSMA As System.Windows.Forms.TextBox
    Friend WithEvents lblCSMA As System.Windows.Forms.Label
    Friend WithEvents txtCSM As System.Windows.Forms.TextBox
    Friend WithEvents lblCSM As System.Windows.Forms.Label
    Friend WithEvents txtTotalConsultasAsistidas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalConsultas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPlus As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents txtPorcen As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
