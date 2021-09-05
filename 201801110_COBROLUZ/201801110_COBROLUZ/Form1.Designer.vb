<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CMBServicio = New System.Windows.Forms.ComboBox()
        Me.LBTservicio = New System.Windows.Forms.Label()
        Me.CMBTarifa = New System.Windows.Forms.ComboBox()
        Me.LBTarifa = New System.Windows.Forms.Label()
        Me.LBConsumidor = New System.Windows.Forms.Label()
        Me.LBNIT = New System.Windows.Forms.Label()
        Me.LBconsumo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTconsumidor = New System.Windows.Forms.TextBox()
        Me.TXTNit = New System.Windows.Forms.TextBox()
        Me.TXTConsumo = New System.Windows.Forms.TextBox()
        Me.LTBServicio = New System.Windows.Forms.ListBox()
        Me.LBservicio = New System.Windows.Forms.Label()
        Me.LBTTtarifa = New System.Windows.Forms.Label()
        Me.LBMora = New System.Windows.Forms.Label()
        Me.LBDescuento = New System.Windows.Forms.Label()
        Me.LBSanterior = New System.Windows.Forms.Label()
        Me.LBpagoI = New System.Windows.Forms.Label()
        Me.LTBTarifa = New System.Windows.Forms.ListBox()
        Me.LTBsaldoA = New System.Windows.Forms.ListBox()
        Me.LTBInicial = New System.Windows.Forms.ListBox()
        Me.LTBMora = New System.Windows.Forms.ListBox()
        Me.LTBDescuento = New System.Windows.Forms.ListBox()
        Me.LTBPTotal = New System.Windows.Forms.ListBox()
        Me.LBTotal = New System.Windows.Forms.Label()
        Me.LBSaldoA = New System.Windows.Forms.Label()
        Me.TXTSALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LTBPparcial = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LTBPMora = New System.Windows.Forms.ListBox()
        Me.LTBCONSUMIDOR = New System.Windows.Forms.ListBox()
        Me.LbCLIENTE = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMBServicio
        '
        Me.CMBServicio.FormattingEnabled = True
        Me.CMBServicio.Items.AddRange(New Object() {"RESIDENCIAL", "INDUSTRIAL"})
        Me.CMBServicio.Location = New System.Drawing.Point(103, 30)
        Me.CMBServicio.Name = "CMBServicio"
        Me.CMBServicio.Size = New System.Drawing.Size(121, 23)
        Me.CMBServicio.TabIndex = 0
        '
        'LBTservicio
        '
        Me.LBTservicio.AutoSize = True
        Me.LBTservicio.Location = New System.Drawing.Point(6, 30)
        Me.LBTservicio.Name = "LBTservicio"
        Me.LBTservicio.Size = New System.Drawing.Size(91, 15)
        Me.LBTservicio.TabIndex = 1
        Me.LBTservicio.Text = "Tipo De Servicio"
        '
        'CMBTarifa
        '
        Me.CMBTarifa.FormattingEnabled = True
        Me.CMBTarifa.Items.AddRange(New Object() {"SOCIAL", "NO SOCIAL"})
        Me.CMBTarifa.Location = New System.Drawing.Point(103, 64)
        Me.CMBTarifa.Name = "CMBTarifa"
        Me.CMBTarifa.Size = New System.Drawing.Size(121, 23)
        Me.CMBTarifa.TabIndex = 2
        '
        'LBTarifa
        '
        Me.LBTarifa.AutoSize = True
        Me.LBTarifa.Location = New System.Drawing.Point(6, 67)
        Me.LBTarifa.Name = "LBTarifa"
        Me.LBTarifa.Size = New System.Drawing.Size(78, 15)
        Me.LBTarifa.TabIndex = 3
        Me.LBTarifa.Text = "Tipo De Tarifa"
        '
        'LBConsumidor
        '
        Me.LBConsumidor.AutoSize = True
        Me.LBConsumidor.Location = New System.Drawing.Point(24, 43)
        Me.LBConsumidor.Name = "LBConsumidor"
        Me.LBConsumidor.Size = New System.Drawing.Size(73, 15)
        Me.LBConsumidor.TabIndex = 4
        Me.LBConsumidor.Text = "Consumidor"
        '
        'LBNIT
        '
        Me.LBNIT.AutoSize = True
        Me.LBNIT.Location = New System.Drawing.Point(28, 78)
        Me.LBNIT.Name = "LBNIT"
        Me.LBNIT.Size = New System.Drawing.Size(25, 15)
        Me.LBNIT.TabIndex = 5
        Me.LBNIT.Text = "NIT"
        '
        'LBconsumo
        '
        Me.LBconsumo.AutoSize = True
        Me.LBconsumo.Location = New System.Drawing.Point(218, 78)
        Me.LBconsumo.Name = "LBconsumo"
        Me.LBconsumo.Size = New System.Drawing.Size(85, 15)
        Me.LBconsumo.TabIndex = 6
        Me.LBconsumo.Text = "Consumo Kwh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 7
        '
        'TXTconsumidor
        '
        Me.TXTconsumidor.Location = New System.Drawing.Point(103, 35)
        Me.TXTconsumidor.Name = "TXTconsumidor"
        Me.TXTconsumidor.Size = New System.Drawing.Size(100, 23)
        Me.TXTconsumidor.TabIndex = 8
        '
        'TXTNit
        '
        Me.TXTNit.Location = New System.Drawing.Point(103, 70)
        Me.TXTNit.Name = "TXTNit"
        Me.TXTNit.Size = New System.Drawing.Size(100, 23)
        Me.TXTNit.TabIndex = 9
        '
        'TXTConsumo
        '
        Me.TXTConsumo.Location = New System.Drawing.Point(309, 70)
        Me.TXTConsumo.Name = "TXTConsumo"
        Me.TXTConsumo.Size = New System.Drawing.Size(100, 23)
        Me.TXTConsumo.TabIndex = 10
        '
        'LTBServicio
        '
        Me.LTBServicio.FormattingEnabled = True
        Me.LTBServicio.ItemHeight = 15
        Me.LTBServicio.Location = New System.Drawing.Point(102, 40)
        Me.LTBServicio.Name = "LTBServicio"
        Me.LTBServicio.Size = New System.Drawing.Size(91, 109)
        Me.LTBServicio.TabIndex = 11
        '
        'LBservicio
        '
        Me.LBservicio.AutoSize = True
        Me.LBservicio.Location = New System.Drawing.Point(102, 19)
        Me.LBservicio.Name = "LBservicio"
        Me.LBservicio.Size = New System.Drawing.Size(91, 15)
        Me.LBservicio.TabIndex = 16
        Me.LBservicio.Text = "Tipo De Servicio"
        '
        'LBTTtarifa
        '
        Me.LBTTtarifa.AutoSize = True
        Me.LBTTtarifa.Location = New System.Drawing.Point(199, 19)
        Me.LBTTtarifa.Name = "LBTTtarifa"
        Me.LBTTtarifa.Size = New System.Drawing.Size(78, 15)
        Me.LBTTtarifa.TabIndex = 17
        Me.LBTTtarifa.Text = "Tipo De Tarifa"
        '
        'LBMora
        '
        Me.LBMora.AutoSize = True
        Me.LBMora.Location = New System.Drawing.Point(498, 22)
        Me.LBMora.Name = "LBMora"
        Me.LBMora.Size = New System.Drawing.Size(35, 15)
        Me.LBMora.TabIndex = 18
        Me.LBMora.Text = "Mora"
        '
        'LBDescuento
        '
        Me.LBDescuento.AutoSize = True
        Me.LBDescuento.Location = New System.Drawing.Point(789, 22)
        Me.LBDescuento.Name = "LBDescuento"
        Me.LBDescuento.Size = New System.Drawing.Size(63, 15)
        Me.LBDescuento.TabIndex = 19
        Me.LBDescuento.Text = "Descuento"
        '
        'LBSanterior
        '
        Me.LBSanterior.AutoSize = True
        Me.LBSanterior.Location = New System.Drawing.Point(295, 19)
        Me.LBSanterior.Name = "LBSanterior"
        Me.LBSanterior.Size = New System.Drawing.Size(82, 15)
        Me.LBSanterior.TabIndex = 20
        Me.LBSanterior.Text = "Saldo Anterior"
        '
        'LBpagoI
        '
        Me.LBpagoI.AutoSize = True
        Me.LBpagoI.Location = New System.Drawing.Point(398, 22)
        Me.LBpagoI.Name = "LBpagoI"
        Me.LBpagoI.Size = New System.Drawing.Size(68, 15)
        Me.LBpagoI.TabIndex = 21
        Me.LBpagoI.Text = "Pago Inicial"
        '
        'LTBTarifa
        '
        Me.LTBTarifa.FormattingEnabled = True
        Me.LTBTarifa.ItemHeight = 15
        Me.LTBTarifa.Location = New System.Drawing.Point(199, 40)
        Me.LTBTarifa.Name = "LTBTarifa"
        Me.LTBTarifa.Size = New System.Drawing.Size(90, 109)
        Me.LTBTarifa.TabIndex = 22
        '
        'LTBsaldoA
        '
        Me.LTBsaldoA.FormattingEnabled = True
        Me.LTBsaldoA.ItemHeight = 15
        Me.LTBsaldoA.Location = New System.Drawing.Point(295, 40)
        Me.LTBsaldoA.Name = "LTBsaldoA"
        Me.LTBsaldoA.Size = New System.Drawing.Size(97, 109)
        Me.LTBsaldoA.TabIndex = 23
        '
        'LTBInicial
        '
        Me.LTBInicial.FormattingEnabled = True
        Me.LTBInicial.ItemHeight = 15
        Me.LTBInicial.Location = New System.Drawing.Point(398, 40)
        Me.LTBInicial.Name = "LTBInicial"
        Me.LTBInicial.Size = New System.Drawing.Size(94, 109)
        Me.LTBInicial.TabIndex = 24
        '
        'LTBMora
        '
        Me.LTBMora.FormattingEnabled = True
        Me.LTBMora.ItemHeight = 15
        Me.LTBMora.Location = New System.Drawing.Point(498, 40)
        Me.LTBMora.Name = "LTBMora"
        Me.LTBMora.Size = New System.Drawing.Size(91, 109)
        Me.LTBMora.TabIndex = 25
        '
        'LTBDescuento
        '
        Me.LTBDescuento.FormattingEnabled = True
        Me.LTBDescuento.ItemHeight = 15
        Me.LTBDescuento.Location = New System.Drawing.Point(789, 40)
        Me.LTBDescuento.Name = "LTBDescuento"
        Me.LTBDescuento.Size = New System.Drawing.Size(89, 109)
        Me.LTBDescuento.TabIndex = 26
        '
        'LTBPTotal
        '
        Me.LTBPTotal.FormattingEnabled = True
        Me.LTBPTotal.ItemHeight = 15
        Me.LTBPTotal.Location = New System.Drawing.Point(884, 40)
        Me.LTBPTotal.Name = "LTBPTotal"
        Me.LTBPTotal.Size = New System.Drawing.Size(89, 109)
        Me.LTBPTotal.TabIndex = 27
        '
        'LBTotal
        '
        Me.LBTotal.AutoSize = True
        Me.LBTotal.Location = New System.Drawing.Point(884, 22)
        Me.LBTotal.Name = "LBTotal"
        Me.LBTotal.Size = New System.Drawing.Size(62, 15)
        Me.LBTotal.TabIndex = 28
        Me.LBTotal.Text = "Pago Total"
        '
        'LBSaldoA
        '
        Me.LBSaldoA.AutoSize = True
        Me.LBSaldoA.Location = New System.Drawing.Point(221, 38)
        Me.LBSaldoA.Name = "LBSaldoA"
        Me.LBSaldoA.Size = New System.Drawing.Size(82, 15)
        Me.LBSaldoA.TabIndex = 29
        Me.LBSaldoA.Text = "Saldo Anterior"
        '
        'TXTSALDOANTERIOR
        '
        Me.TXTSALDOANTERIOR.Location = New System.Drawing.Point(309, 30)
        Me.TXTSALDOANTERIOR.Name = "TXTSALDOANTERIOR"
        Me.TXTSALDOANTERIOR.Size = New System.Drawing.Size(100, 23)
        Me.TXTSALDOANTERIOR.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LBSaldoA)
        Me.GroupBox1.Controls.Add(Me.TXTSALDOANTERIOR)
        Me.GroupBox1.Controls.Add(Me.LBconsumo)
        Me.GroupBox1.Controls.Add(Me.TXTConsumo)
        Me.GroupBox1.Controls.Add(Me.TXTconsumidor)
        Me.GroupBox1.Controls.Add(Me.LBConsumidor)
        Me.GroupBox1.Controls.Add(Me.TXTNit)
        Me.GroupBox1.Controls.Add(Me.LBNIT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 117)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.LBTservicio)
        Me.GroupBox2.Controls.Add(Me.CMBServicio)
        Me.GroupBox2.Controls.Add(Me.LBTarifa)
        Me.GroupBox2.Controls.Add(Me.CMBTarifa)
        Me.GroupBox2.Location = New System.Drawing.Point(495, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 100)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1054, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.LTBPparcial)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LBTotal)
        Me.GroupBox3.Controls.Add(Me.LTBPMora)
        Me.GroupBox3.Controls.Add(Me.LTBPTotal)
        Me.GroupBox3.Controls.Add(Me.LTBCONSUMIDOR)
        Me.GroupBox3.Controls.Add(Me.LBDescuento)
        Me.GroupBox3.Controls.Add(Me.LTBDescuento)
        Me.GroupBox3.Controls.Add(Me.LbCLIENTE)
        Me.GroupBox3.Controls.Add(Me.LBservicio)
        Me.GroupBox3.Controls.Add(Me.LTBServicio)
        Me.GroupBox3.Controls.Add(Me.LBTTtarifa)
        Me.GroupBox3.Controls.Add(Me.LBSanterior)
        Me.GroupBox3.Controls.Add(Me.LTBMora)
        Me.GroupBox3.Controls.Add(Me.LTBTarifa)
        Me.GroupBox3.Controls.Add(Me.LTBInicial)
        Me.GroupBox3.Controls.Add(Me.LBMora)
        Me.GroupBox3.Controls.Add(Me.LTBsaldoA)
        Me.GroupBox3.Controls.Add(Me.LBpagoI)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1002, 183)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS"
        '
        'LTBPparcial
        '
        Me.LTBPparcial.FormattingEnabled = True
        Me.LTBPparcial.ItemHeight = 15
        Me.LTBPparcial.Location = New System.Drawing.Point(692, 40)
        Me.LTBPparcial.Name = "LTBPparcial"
        Me.LTBPparcial.Size = New System.Drawing.Size(91, 109)
        Me.LTBPparcial.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(692, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Pago Parcial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(595, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Pago Con Mora"
        '
        'LTBPMora
        '
        Me.LTBPMora.FormattingEnabled = True
        Me.LTBPMora.ItemHeight = 15
        Me.LTBPMora.Location = New System.Drawing.Point(595, 40)
        Me.LTBPMora.Name = "LTBPMora"
        Me.LTBPMora.Size = New System.Drawing.Size(91, 109)
        Me.LTBPMora.TabIndex = 35
        '
        'LTBCONSUMIDOR
        '
        Me.LTBCONSUMIDOR.FormattingEnabled = True
        Me.LTBCONSUMIDOR.ItemHeight = 15
        Me.LTBCONSUMIDOR.Location = New System.Drawing.Point(6, 40)
        Me.LTBCONSUMIDOR.Name = "LTBCONSUMIDOR"
        Me.LTBCONSUMIDOR.Size = New System.Drawing.Size(90, 109)
        Me.LTBCONSUMIDOR.TabIndex = 34
        '
        'LbCLIENTE
        '
        Me.LbCLIENTE.AutoSize = True
        Me.LbCLIENTE.Location = New System.Drawing.Point(6, 19)
        Me.LbCLIENTE.Name = "LbCLIENTE"
        Me.LbCLIENTE.Size = New System.Drawing.Size(85, 15)
        Me.LbCLIENTE.TabIndex = 21
        Me.LbCLIENTE.Text = "CONSUMIDOR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1054, 389)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CMBServicio As ComboBox
    Friend WithEvents LBTservicio As Label
    Friend WithEvents CMBTarifa As ComboBox
    Friend WithEvents LBTarifa As Label
    Friend WithEvents LBConsumidor As Label
    Friend WithEvents LBNIT As Label
    Friend WithEvents LBconsumo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTconsumidor As TextBox
    Friend WithEvents TXTNit As TextBox
    Friend WithEvents TXTConsumo As TextBox
    Friend WithEvents LTBServicio As ListBox
    Friend WithEvents LBservicio As Label
    Friend WithEvents LBTTtarifa As Label
    Friend WithEvents LBMora As Label
    Friend WithEvents LBDescuento As Label
    Friend WithEvents LBSanterior As Label
    Friend WithEvents LBpagoI As Label
    Friend WithEvents LTBTarifa As ListBox
    Friend WithEvents LTBsaldoA As ListBox
    Friend WithEvents LTBInicial As ListBox
    Friend WithEvents LTBMora As ListBox
    Friend WithEvents LTBDescuento As ListBox
    Friend WithEvents LTBPTotal As ListBox
    Friend WithEvents LBTotal As Label
    Friend WithEvents LBSaldoA As Label
    Friend WithEvents TXTSALDOANTERIOR As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LTBPparcial As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LTBPMora As ListBox
    Friend WithEvents LTBCONSUMIDOR As ListBox
    Friend WithEvents LbCLIENTE As Label
End Class
