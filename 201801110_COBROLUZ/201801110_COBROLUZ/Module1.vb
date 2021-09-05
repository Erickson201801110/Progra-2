Module Module1

    Public Const residencialUno As Double = 0.99
    Public Const residencialDos As Double = 1.2
    Public Const residencialTres As Double = 3.0

    Public Const IndustrialUno As Double = 1.99
    Public Const IndustrialDos As Double = 2.2
    Public Const IndustrialTres As Double = 4.0


    Public DATOS As Byte = 0

    Public Total_PInicial As Double
    Public Total_Pparcial As Double
    Public Total_Pparcial1 As Double
    Public Total_Pfinal As Double
    Public Total_Pfinal1 As Double
    Public Total_mora As Double
    Public Total_recargo As Double
    Public Total_tarifa As Double
    Public MoraAplicado As Double = 0.02

    Public DescuentoSocial = 0.2
    Public DescuentoNosocial = 0.1

    Public consumidor(11) As String
    Public SERVICIO(11) As String
    Public TARIFA(11) As String
    Public SALDOANTERIOR(11) As Double
    Public PAGOINICIAL(11) As Double
    Public MORA(11) As Double
    Public PAGOMORA(11) As Integer
    Public PAGOPARCIAL(11) As Double
    Public DESCUENTO(11) As Integer
    Public PAGOTOTAL(11) As Double


    Sub LIMPIAR_ENTRADAS()
        Form1.TXTconsumidor.Clear()
        Form1.TXTConsumo.Clear()
        Form1.TXTNit.Clear()
        Form1.TXTSALDOANTERIOR.Clear()
        Form1.TXTconsumidor.Focus()

    End Sub

    Sub mostrar_vectores()
        'SE MUESTRA EL CONTENIDO DEL VECTOR EN LISTBOX
        Form1.LTBCONSUMIDOR.Items.Add(consumidor(DATOS))
        Form1.LTBServicio.Items.Add(SERVICIO(DATOS))
        Form1.LTBTarifa.Items.Add(TARIFA(DATOS))
        Form1.LTBsaldoA.Items.Add(SALDOANTERIOR(DATOS))
        Form1.LTBInicial.Items.Add(PAGOINICIAL(DATOS))
        Form1.LTBMora.Items.Add(MORA(DATOS))
        Form1.LTBPMora.Items.Add(PAGOMORA(DATOS))
        Form1.LTBPparcial.Items.Add(PAGOPARCIAL(DATOS))
        Form1.LTBDescuento.Items.Add(DESCUENTO(DATOS))
        Form1.LTBPTotal.Items.Add(PAGOTOTAL(DATOS))




    End Sub

    Sub LIMPIAR_VECTORES()

        Form1.LTBCONSUMIDOR.Items.Clear()
        Form1.LTBServicio.Items.Clear()
        Form1.LTBTarifa.Items.Clear()
        Form1.LTBsaldoA.Items.Clear()
        Form1.LTBInicial.Items.Clear()
        Form1.LTBMora.Items.Clear()
        Form1.LTBPMora.Items.Clear()
        Form1.LTBPparcial.Items.Clear()
        Form1.LTBDescuento.Items.Clear()
        Form1.LTBPTotal.Items.Clear()

        DATOS = 0
    End Sub
End Module
