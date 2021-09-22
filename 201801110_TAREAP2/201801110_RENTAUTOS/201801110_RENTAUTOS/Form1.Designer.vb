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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTDIAS = New System.Windows.Forms.TextBox()
        Me.TXTPLACA = New System.Windows.Forms.TextBox()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMBMARCA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROCESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LTBDESCUENTO = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LTBPARCIAL = New System.Windows.Forms.ListBox()
        Me.LTBALQUIER = New System.Windows.Forms.ListBox()
        Me.LTBMARCA = New System.Windows.Forms.ListBox()
        Me.LTBPLACA = New System.Windows.Forms.ListBox()
        Me.LTBFINAL = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CHBEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.CHBTARJETA = New System.Windows.Forms.CheckBox()
        Me.TXTPORCTARJETA = New System.Windows.Forms.TextBox()
        Me.TXTPORCEFECTIVO = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTPORCEFECTIVO)
        Me.GroupBox1.Controls.Add(Me.TXTPORCTARJETA)
        Me.GroupBox1.Controls.Add(Me.CHBTARJETA)
        Me.GroupBox1.Controls.Add(Me.CHBEFECTIVO)
        Me.GroupBox1.Controls.Add(Me.TXTDIAS)
        Me.GroupBox1.Controls.Add(Me.TXTPLACA)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CMBMARCA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DATOS"
        '
        'TXTDIAS
        '
        Me.TXTDIAS.Location = New System.Drawing.Point(172, 87)
        Me.TXTDIAS.Name = "TXTDIAS"
        Me.TXTDIAS.Size = New System.Drawing.Size(100, 23)
        Me.TXTDIAS.TabIndex = 10
        '
        'TXTPLACA
        '
        Me.TXTPLACA.Location = New System.Drawing.Point(172, 57)
        Me.TXTPLACA.Name = "TXTPLACA"
        Me.TXTPLACA.Size = New System.Drawing.Size(100, 23)
        Me.TXTPLACA.TabIndex = 9
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(172, 28)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(100, 23)
        Me.TXTNIT.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(284, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 6
        '
        'CMBMARCA
        '
        Me.CMBMARCA.FormattingEnabled = True
        Me.CMBMARCA.Items.AddRange(New Object() {"HONDA", "MERCEDEZ BENZ", "TOYOTA", "MAZDA", " "})
        Me.CMBMARCA.Location = New System.Drawing.Point(391, 22)
        Me.CMBMARCA.Name = "CMBMARCA"
        Me.CMBMARCA.Size = New System.Drawing.Size(121, 23)
        Me.CMBMARCA.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "FORMA DE PAGO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CANTIDAD DIAS ALQUILER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MARCA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PLACA AUTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT CLIENTE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROCESOSToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROCESOSToolStripMenuItem
        '
        Me.PROCESOSToolStripMenuItem.Name = "PROCESOSToolStripMenuItem"
        Me.PROCESOSToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PROCESOSToolStripMenuItem.Text = "PROCESOS"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.LTBFINAL)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LTBDESCUENTO)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LTBPARCIAL)
        Me.GroupBox2.Controls.Add(Me.LTBALQUIER)
        Me.GroupBox2.Controls.Add(Me.LTBMARCA)
        Me.GroupBox2.Controls.Add(Me.LTBPLACA)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 194)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SALIDA DATOS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(440, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "DESCUENTO"
        '
        'LTBDESCUENTO
        '
        Me.LTBDESCUENTO.FormattingEnabled = True
        Me.LTBDESCUENTO.ItemHeight = 15
        Me.LTBDESCUENTO.Location = New System.Drawing.Point(440, 48)
        Me.LTBDESCUENTO.Name = "LTBDESCUENTO"
        Me.LTBDESCUENTO.Size = New System.Drawing.Size(83, 124)
        Me.LTBDESCUENTO.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(335, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "PAGO PARCIAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "DIAS ALQUILER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(122, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "MARCA AUTO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "PLACA"
        '
        'LTBPARCIAL
        '
        Me.LTBPARCIAL.FormattingEnabled = True
        Me.LTBPARCIAL.ItemHeight = 15
        Me.LTBPARCIAL.Location = New System.Drawing.Point(335, 48)
        Me.LTBPARCIAL.Name = "LTBPARCIAL"
        Me.LTBPARCIAL.Size = New System.Drawing.Size(83, 124)
        Me.LTBPARCIAL.TabIndex = 3
        '
        'LTBALQUIER
        '
        Me.LTBALQUIER.FormattingEnabled = True
        Me.LTBALQUIER.ItemHeight = 15
        Me.LTBALQUIER.Location = New System.Drawing.Point(226, 48)
        Me.LTBALQUIER.Name = "LTBALQUIER"
        Me.LTBALQUIER.Size = New System.Drawing.Size(83, 124)
        Me.LTBALQUIER.TabIndex = 2
        '
        'LTBMARCA
        '
        Me.LTBMARCA.FormattingEnabled = True
        Me.LTBMARCA.ItemHeight = 15
        Me.LTBMARCA.Location = New System.Drawing.Point(121, 48)
        Me.LTBMARCA.Name = "LTBMARCA"
        Me.LTBMARCA.Size = New System.Drawing.Size(83, 124)
        Me.LTBMARCA.TabIndex = 1
        '
        'LTBPLACA
        '
        Me.LTBPLACA.FormattingEnabled = True
        Me.LTBPLACA.ItemHeight = 15
        Me.LTBPLACA.Location = New System.Drawing.Point(21, 48)
        Me.LTBPLACA.Name = "LTBPLACA"
        Me.LTBPLACA.Size = New System.Drawing.Size(83, 124)
        Me.LTBPLACA.TabIndex = 0
        '
        'LTBFINAL
        '
        Me.LTBFINAL.FormattingEnabled = True
        Me.LTBFINAL.ItemHeight = 15
        Me.LTBFINAL.Location = New System.Drawing.Point(544, 48)
        Me.LTBFINAL.Name = "LTBFINAL"
        Me.LTBFINAL.Size = New System.Drawing.Size(83, 124)
        Me.LTBFINAL.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(544, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "PAGO FINAL"
        '
        'CHBEFECTIVO
        '
        Me.CHBEFECTIVO.AutoSize = True
        Me.CHBEFECTIVO.Location = New System.Drawing.Point(337, 78)
        Me.CHBEFECTIVO.Name = "CHBEFECTIVO"
        Me.CHBEFECTIVO.Size = New System.Drawing.Size(77, 19)
        Me.CHBEFECTIVO.TabIndex = 11
        Me.CHBEFECTIVO.Text = "EFECTIVO"
        Me.CHBEFECTIVO.UseVisualStyleBackColor = True
        '
        'CHBTARJETA
        '
        Me.CHBTARJETA.AutoSize = True
        Me.CHBTARJETA.Location = New System.Drawing.Point(337, 116)
        Me.CHBTARJETA.Name = "CHBTARJETA"
        Me.CHBTARJETA.Size = New System.Drawing.Size(69, 19)
        Me.CHBTARJETA.TabIndex = 12
        Me.CHBTARJETA.Text = "TARJETA"
        Me.CHBTARJETA.UseVisualStyleBackColor = True
        '
        'TXTPORCTARJETA
        '
        Me.TXTPORCTARJETA.Location = New System.Drawing.Point(412, 112)
        Me.TXTPORCTARJETA.Name = "TXTPORCTARJETA"
        Me.TXTPORCTARJETA.Size = New System.Drawing.Size(100, 23)
        Me.TXTPORCTARJETA.TabIndex = 13
        Me.TXTPORCTARJETA.Text = "0"
        '
        'TXTPORCEFECTIVO
        '
        Me.TXTPORCEFECTIVO.Location = New System.Drawing.Point(412, 76)
        Me.TXTPORCEFECTIVO.Name = "TXTPORCEFECTIVO"
        Me.TXTPORCEFECTIVO.Size = New System.Drawing.Size(100, 23)
        Me.TXTPORCEFECTIVO.TabIndex = 14
        Me.TXTPORCEFECTIVO.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(700, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTDIAS As TextBox
    Friend WithEvents TXTPLACA As TextBox
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CMBMARCA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PROCESOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LTBPARCIAL As ListBox
    Friend WithEvents LTBALQUIER As ListBox
    Friend WithEvents LTBMARCA As ListBox
    Friend WithEvents LTBPLACA As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LTBDESCUENTO As ListBox
    Friend WithEvents TXTPORCEFECTIVO As TextBox
    Friend WithEvents TXTPORCTARJETA As TextBox
    Friend WithEvents CHBTARJETA As CheckBox
    Friend WithEvents CHBEFECTIVO As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LTBFINAL As ListBox
End Class
