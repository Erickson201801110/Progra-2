<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTDEDUCIBLE = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CMBTALLER = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.TXTEDAD = New System.Windows.Forms.TextBox()
        Me.CMBCODIGO = New System.Windows.Forms.ComboBox()
        Me.CMBGENERO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SALIDA = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARESTADISTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUARDARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNESTADISTICAS = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTR1 = New System.Windows.Forms.TextBox()
        Me.TXTR2 = New System.Windows.Forms.TextBox()
        Me.TXTR3 = New System.Windows.Forms.TextBox()
        Me.TXTR4 = New System.Windows.Forms.TextBox()
        Me.TXTR5 = New System.Windows.Forms.TextBox()
        Me.TXTR6 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SALIDA.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TXTDEDUCIBLE)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.CMBTALLER)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTMONTO)
        Me.GroupBox1.Controls.Add(Me.TXTEDAD)
        Me.GroupBox1.Controls.Add(Me.CMBCODIGO)
        Me.GroupBox1.Controls.Add(Me.CMBGENERO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRADA"
        '
        'TXTDEDUCIBLE
        '
        Me.TXTDEDUCIBLE.Location = New System.Drawing.Point(398, 111)
        Me.TXTDEDUCIBLE.Name = "TXTDEDUCIBLE"
        Me.TXTDEDUCIBLE.Size = New System.Drawing.Size(121, 23)
        Me.TXTDEDUCIBLE.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(299, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "DEDUCIBLE"
        '
        'CMBTALLER
        '
        Me.CMBTALLER.FormattingEnabled = True
        Me.CMBTALLER.Items.AddRange(New Object() {"CONFIANZA", "ASEGURADORA"})
        Me.CMBTALLER.Location = New System.Drawing.Point(398, 73)
        Me.CMBTALLER.Name = "CMBTALLER"
        Me.CMBTALLER.Size = New System.Drawing.Size(121, 23)
        Me.CMBTALLER.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TALLER"
        '
        'TXTMONTO
        '
        Me.TXTMONTO.Location = New System.Drawing.Point(398, 28)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(121, 23)
        Me.TXTMONTO.TabIndex = 6
        '
        'TXTEDAD
        '
        Me.TXTEDAD.Location = New System.Drawing.Point(148, 28)
        Me.TXTEDAD.Name = "TXTEDAD"
        Me.TXTEDAD.Size = New System.Drawing.Size(121, 23)
        Me.TXTEDAD.TabIndex = 1
        '
        'CMBCODIGO
        '
        Me.CMBCODIGO.FormattingEnabled = True
        Me.CMBCODIGO.Items.AddRange(New Object() {"1", "0"})
        Me.CMBCODIGO.Location = New System.Drawing.Point(148, 111)
        Me.CMBCODIGO.Name = "CMBCODIGO"
        Me.CMBCODIGO.Size = New System.Drawing.Size(121, 23)
        Me.CMBCODIGO.TabIndex = 5
        '
        'CMBGENERO
        '
        Me.CMBGENERO.FormattingEnabled = True
        Me.CMBGENERO.Items.AddRange(New Object() {"M", "F"})
        Me.CMBGENERO.Location = New System.Drawing.Point(148, 68)
        Me.CMBGENERO.Name = "CMBGENERO"
        Me.CMBGENERO.Size = New System.Drawing.Size(121, 23)
        Me.CMBGENERO.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CODIGO REGISTRO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MONTO DAÑOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GENERO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDAD"
        '
        'SALIDA
        '
        Me.SALIDA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SALIDA.Controls.Add(Me.DataGridView1)
        Me.SALIDA.Location = New System.Drawing.Point(12, 205)
        Me.SALIDA.Name = "SALIDA"
        Me.SALIDA.Size = New System.Drawing.Size(542, 213)
        Me.SALIDA.TabIndex = 1
        Me.SALIDA.TabStop = False
        Me.SALIDA.Text = "SALIDA"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(513, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "EDAD"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "GENERO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "CODIGO R"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "MONTO DAÑOS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "TALLER"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "DEDUCIBLE"
        Me.Column6.Name = "Column6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.LIMPIARESTADISTICASToolStripMenuItem, Me.SALIRToolStripMenuItem, Me.GUARDARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1021, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'LIMPIARESTADISTICASToolStripMenuItem
        '
        Me.LIMPIARESTADISTICASToolStripMenuItem.Name = "LIMPIARESTADISTICASToolStripMenuItem"
        Me.LIMPIARESTADISTICASToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.LIMPIARESTADISTICASToolStripMenuItem.Text = "LIMPIAR ESTADISTICAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GUARDARToolStripMenuItem
        '
        Me.GUARDARToolStripMenuItem.Name = "GUARDARToolStripMenuItem"
        Me.GUARDARToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.GUARDARToolStripMenuItem.Text = "GUARDAR"
        '
        'BTNESTADISTICAS
        '
        Me.BTNESTADISTICAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNESTADISTICAS.Location = New System.Drawing.Point(774, 93)
        Me.BTNESTADISTICAS.Name = "BTNESTADISTICAS"
        Me.BTNESTADISTICAS.Size = New System.Drawing.Size(100, 23)
        Me.BTNESTADISTICAS.TabIndex = 3
        Me.BTNESTADISTICAS.Text = "ESTADISTICAS"
        Me.BTNESTADISTICAS.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(575, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "% de conductores < 25 años"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(575, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "% de conductores de género femenino"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(575, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(318, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "%  conductores de género masculino entre los 18 y 25 años"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(575, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "% de conductores con registro extranjero"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(575, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 15)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Total de conductores ingresados"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(575, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(268, 15)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Total (Q) de los montos de los daños ocasionados"
        '
        'TXTR1
        '
        Me.TXTR1.Location = New System.Drawing.Point(927, 155)
        Me.TXTR1.Name = "TXTR1"
        Me.TXTR1.Size = New System.Drawing.Size(68, 23)
        Me.TXTR1.TabIndex = 10
        '
        'TXTR2
        '
        Me.TXTR2.Location = New System.Drawing.Point(927, 192)
        Me.TXTR2.Name = "TXTR2"
        Me.TXTR2.Size = New System.Drawing.Size(68, 23)
        Me.TXTR2.TabIndex = 11
        '
        'TXTR3
        '
        Me.TXTR3.Location = New System.Drawing.Point(927, 224)
        Me.TXTR3.Name = "TXTR3"
        Me.TXTR3.Size = New System.Drawing.Size(68, 23)
        Me.TXTR3.TabIndex = 12
        '
        'TXTR4
        '
        Me.TXTR4.Location = New System.Drawing.Point(927, 259)
        Me.TXTR4.Name = "TXTR4"
        Me.TXTR4.Size = New System.Drawing.Size(68, 23)
        Me.TXTR4.TabIndex = 13
        '
        'TXTR5
        '
        Me.TXTR5.Location = New System.Drawing.Point(927, 297)
        Me.TXTR5.Name = "TXTR5"
        Me.TXTR5.Size = New System.Drawing.Size(68, 23)
        Me.TXTR5.TabIndex = 14
        '
        'TXTR6
        '
        Me.TXTR6.Location = New System.Drawing.Point(927, 333)
        Me.TXTR6.Name = "TXTR6"
        Me.TXTR6.Size = New System.Drawing.Size(68, 23)
        Me.TXTR6.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1021, 430)
        Me.Controls.Add(Me.TXTR6)
        Me.Controls.Add(Me.TXTR5)
        Me.Controls.Add(Me.TXTR4)
        Me.Controls.Add(Me.TXTR3)
        Me.Controls.Add(Me.TXTR2)
        Me.Controls.Add(Me.TXTR1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTNESTADISTICAS)
        Me.Controls.Add(Me.SALIDA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SALIDA.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMBTALLER As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTMONTO As TextBox
    Friend WithEvents TXTEDAD As TextBox
    Friend WithEvents CMBCODIGO As ComboBox
    Friend WithEvents CMBGENERO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SALIDA As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARESTADISTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTNESTADISTICAS As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTR1 As TextBox
    Friend WithEvents TXTR2 As TextBox
    Friend WithEvents TXTR3 As TextBox
    Friend WithEvents TXTR4 As TextBox
    Friend WithEvents TXTR5 As TextBox
    Friend WithEvents TXTR6 As TextBox
    Friend WithEvents GUARDARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTDEDUCIBLE As TextBox
    Friend WithEvents Label12 As Label
End Class
