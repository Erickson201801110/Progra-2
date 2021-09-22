Module Module1

    Public indice = 0

    Public placa(6)
    Public Marca_Auto(6)
    Public Dia_Alquiler(6)
    Public Descuento(6)
    Public pago_Parcial(6)
    Public FormaPago(6)
    Public pago_Final(6)
    Public Nit_Cliente(6)
    Public Const efectivo = 0.05
    Public Const tarjeta = 0.025  'recargo

    Public calculo_PagoParcial As Double = 0



    Sub LIMPIAR_ENTRADAS()

        Form1.CMBMARCA.Text = ""
        Form1.TXTDIAS.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTPLACA.Clear()
        Form1.TXTPLACA.Clear()
        Form1.TXTPORCEFECTIVO.Clear()

    End Sub

    Sub LIMPIAR_VECTORES()

        indice = 0

        Form1.LTBALQUIER.Items.Clear()
        Form1.LTBDESCUENTO.Items.Clear()
        Form1.LTBMARCA.Items.Clear()
        Form1.LTBPLACA.Items.Clear()
        Form1.LTBPARCIAL.Items.Clear()
        Form1.LTBFINAL.Items.Clear()
    End Sub

    Function calculopagoparcial(marca As String) As Double

        Select Case marca

            Case "HONDA"
                calculo_PagoParcial = 250
            Case "MERCEDEZ BENZ"
                calculo_PagoParcial = 450
            Case "TOYOTA"
                calculo_PagoParcial = 350
            Case "MAZDA"
                calculo_PagoParcial = 300

        End Select

        Return calculo_PagoParcial

    End Function

    Function calculoDescuentoRecargo() As Double
        Dim descuento As Double
        Dim recargo As Double

        If (Form1.CHBEFECTIVO.Checked) Then
            If Form1.TXTPORCEFECTIVO.Text = "100" Then
                FormaPago(indice) = Form1.CHBEFECTIVO.Text
                descuento = pago_Parcial(indice) * efectivo
                Return descuento * -1
            End If
        ElseIf (Form1.CHBTARJETA.Checked) Then
            If Form1.TXTPORCTARJETA.Text = "100" Then
                FormaPago(indice) = Form1.CHBTARJETA.Text
                recargo = pago_Parcial(indice) * tarjeta
                Return recargo
            End If

        End If

        Return 0

    End Function

    Function totalfinal() As Double

        totalfinal = pago_Parcial(indice) + Descuento(indice)
        Return totalfinal
    End Function


End Module
