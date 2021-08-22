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
        Me.RBImperial = New System.Windows.Forms.RadioButton()
        Me.RBMatrimonial = New System.Windows.Forms.RadioButton()
        Me.RBQueen = New System.Windows.Forms.RadioButton()
        Me.RBKing = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTLINO = New System.Windows.Forms.TextBox()
        Me.LINO = New System.Windows.Forms.CheckBox()
        Me.TXTALGODON = New System.Windows.Forms.TextBox()
        Me.ALGODON = New System.Windows.Forms.CheckBox()
        Me.TXTSEDA = New System.Windows.Forms.TextBox()
        Me.SEDA = New System.Windows.Forms.CheckBox()
        Me.TXTHILO = New System.Windows.Forms.TextBox()
        Me.HCRUDO = New System.Windows.Forms.CheckBox()
        Me.BTNAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBPrecioCosto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBPrecioVenta = New System.Windows.Forms.Label()
        Me.BTNLimpiar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RBImperial)
        Me.GroupBox1.Controls.Add(Me.RBMatrimonial)
        Me.GroupBox1.Controls.Add(Me.RBQueen)
        Me.GroupBox1.Controls.Add(Me.RBKing)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑO"
        '
        'RBImperial
        '
        Me.RBImperial.AutoSize = True
        Me.RBImperial.Location = New System.Drawing.Point(6, 97)
        Me.RBImperial.Name = "RBImperial"
        Me.RBImperial.Size = New System.Drawing.Size(76, 19)
        Me.RBImperial.TabIndex = 3
        Me.RBImperial.TabStop = True
        Me.RBImperial.Text = "IMPERIAL"
        Me.RBImperial.UseVisualStyleBackColor = True
        '
        'RBMatrimonial
        '
        Me.RBMatrimonial.AutoSize = True
        Me.RBMatrimonial.Location = New System.Drawing.Point(6, 72)
        Me.RBMatrimonial.Name = "RBMatrimonial"
        Me.RBMatrimonial.Size = New System.Drawing.Size(105, 19)
        Me.RBMatrimonial.TabIndex = 2
        Me.RBMatrimonial.TabStop = True
        Me.RBMatrimonial.Text = "MATRIMONIAL"
        Me.RBMatrimonial.UseVisualStyleBackColor = True
        '
        'RBQueen
        '
        Me.RBQueen.AutoSize = True
        Me.RBQueen.Location = New System.Drawing.Point(6, 47)
        Me.RBQueen.Name = "RBQueen"
        Me.RBQueen.Size = New System.Drawing.Size(63, 19)
        Me.RBQueen.TabIndex = 1
        Me.RBQueen.TabStop = True
        Me.RBQueen.Text = "QUEEN"
        Me.RBQueen.UseVisualStyleBackColor = True
        '
        'RBKing
        '
        Me.RBKing.AutoSize = True
        Me.RBKing.Location = New System.Drawing.Point(6, 22)
        Me.RBKing.Name = "RBKing"
        Me.RBKing.Size = New System.Drawing.Size(52, 19)
        Me.RBKing.TabIndex = 0
        Me.RBKing.TabStop = True
        Me.RBKing.Text = "KING"
        Me.RBKing.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TXTLINO)
        Me.GroupBox2.Controls.Add(Me.LINO)
        Me.GroupBox2.Controls.Add(Me.TXTALGODON)
        Me.GroupBox2.Controls.Add(Me.ALGODON)
        Me.GroupBox2.Controls.Add(Me.TXTSEDA)
        Me.GroupBox2.Controls.Add(Me.SEDA)
        Me.GroupBox2.Controls.Add(Me.TXTHILO)
        Me.GroupBox2.Controls.Add(Me.HCRUDO)
        Me.GroupBox2.Location = New System.Drawing.Point(177, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MATERIAL"
        '
        'TXTLINO
        '
        Me.TXTLINO.Enabled = False
        Me.TXTLINO.Location = New System.Drawing.Point(126, 102)
        Me.TXTLINO.Name = "TXTLINO"
        Me.TXTLINO.Size = New System.Drawing.Size(100, 23)
        Me.TXTLINO.TabIndex = 5
        Me.TXTLINO.Text = "0"
        '
        'LINO
        '
        Me.LINO.AutoSize = True
        Me.LINO.Location = New System.Drawing.Point(6, 94)
        Me.LINO.Name = "LINO"
        Me.LINO.Size = New System.Drawing.Size(53, 19)
        Me.LINO.TabIndex = 3
        Me.LINO.Text = "LINO"
        Me.LINO.UseVisualStyleBackColor = True
        '
        'TXTALGODON
        '
        Me.TXTALGODON.Enabled = False
        Me.TXTALGODON.Location = New System.Drawing.Point(126, 73)
        Me.TXTALGODON.Name = "TXTALGODON"
        Me.TXTALGODON.Size = New System.Drawing.Size(100, 23)
        Me.TXTALGODON.TabIndex = 4
        Me.TXTALGODON.Text = "0"
        '
        'ALGODON
        '
        Me.ALGODON.AutoSize = True
        Me.ALGODON.Location = New System.Drawing.Point(6, 69)
        Me.ALGODON.Name = "ALGODON"
        Me.ALGODON.Size = New System.Drawing.Size(83, 19)
        Me.ALGODON.TabIndex = 2
        Me.ALGODON.Text = "ALGODON"
        Me.ALGODON.UseVisualStyleBackColor = True
        '
        'TXTSEDA
        '
        Me.TXTSEDA.Enabled = False
        Me.TXTSEDA.Location = New System.Drawing.Point(126, 44)
        Me.TXTSEDA.Name = "TXTSEDA"
        Me.TXTSEDA.Size = New System.Drawing.Size(100, 23)
        Me.TXTSEDA.TabIndex = 3
        Me.TXTSEDA.Text = "0"
        '
        'SEDA
        '
        Me.SEDA.AutoSize = True
        Me.SEDA.Location = New System.Drawing.Point(6, 44)
        Me.SEDA.Name = "SEDA"
        Me.SEDA.Size = New System.Drawing.Size(54, 19)
        Me.SEDA.TabIndex = 1
        Me.SEDA.Text = "SEDA"
        Me.SEDA.UseVisualStyleBackColor = True
        '
        'TXTHILO
        '
        Me.TXTHILO.Enabled = False
        Me.TXTHILO.Location = New System.Drawing.Point(126, 15)
        Me.TXTHILO.Name = "TXTHILO"
        Me.TXTHILO.Size = New System.Drawing.Size(100, 23)
        Me.TXTHILO.TabIndex = 2
        Me.TXTHILO.Text = "0"
        '
        'HCRUDO
        '
        Me.HCRUDO.AutoSize = True
        Me.HCRUDO.Location = New System.Drawing.Point(6, 19)
        Me.HCRUDO.Name = "HCRUDO"
        Me.HCRUDO.Size = New System.Drawing.Size(96, 19)
        Me.HCRUDO.TabIndex = 0
        Me.HCRUDO.Text = "HILO CRUDO"
        Me.HCRUDO.UseVisualStyleBackColor = True
        '
        'BTNAceptar
        '
        Me.BTNAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNAceptar.Location = New System.Drawing.Point(161, 230)
        Me.BTNAceptar.Name = "BTNAceptar"
        Me.BTNAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BTNAceptar.TabIndex = 2
        Me.BTNAceptar.Text = "Aceptar"
        Me.BTNAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio De Costo: Q"
        '
        'LBPrecioCosto
        '
        Me.LBPrecioCosto.AutoSize = True
        Me.LBPrecioCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBPrecioCosto.Location = New System.Drawing.Point(139, 192)
        Me.LBPrecioCosto.Name = "LBPrecioCosto"
        Me.LBPrecioCosto.Size = New System.Drawing.Size(28, 15)
        Me.LBPrecioCosto.TabIndex = 4
        Me.LBPrecioCosto.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(198, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Precio De Venta; Q"
        '
        'LBPrecioVenta
        '
        Me.LBPrecioVenta.AutoSize = True
        Me.LBPrecioVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBPrecioVenta.Location = New System.Drawing.Point(308, 192)
        Me.LBPrecioVenta.Name = "LBPrecioVenta"
        Me.LBPrecioVenta.Size = New System.Drawing.Size(28, 15)
        Me.LBPrecioVenta.TabIndex = 6
        Me.LBPrecioVenta.Text = "0.00"
        '
        'BTNLimpiar
        '
        Me.BTNLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNLimpiar.Location = New System.Drawing.Point(10, 230)
        Me.BTNLimpiar.Name = "BTNLimpiar"
        Me.BTNLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BTNLimpiar.TabIndex = 7
        Me.BTNLimpiar.Text = "Limpiar"
        Me.BTNLimpiar.UseVisualStyleBackColor = False
        '
        'BTNSalir
        '
        Me.BTNSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNSalir.Location = New System.Drawing.Point(303, 230)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTNSalir.TabIndex = 8
        Me.BTNSalir.Text = "Salir"
        Me.BTNSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(431, 268)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.BTNLimpiar)
        Me.Controls.Add(Me.LBPrecioVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBPrecioCosto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBImperial As RadioButton
    Friend WithEvents RBMatrimonial As RadioButton
    Friend WithEvents RBQueen As RadioButton
    Friend WithEvents RBKing As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LINO As CheckBox
    Friend WithEvents ALGODON As CheckBox
    Friend WithEvents SEDA As CheckBox
    Friend WithEvents HCRUDO As CheckBox
    Friend WithEvents TXTLINO As TextBox
    Friend WithEvents TXTALGODON As TextBox
    Friend WithEvents TXTSEDA As TextBox
    Friend WithEvents TXTHILO As TextBox
    Friend WithEvents BTNAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBPrecioCosto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBPrecioVenta As Label
    Friend WithEvents BTNLimpiar As Button
    Friend WithEvents BTNSalir As Button
End Class
