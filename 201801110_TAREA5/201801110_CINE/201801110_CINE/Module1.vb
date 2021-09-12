Module Module1

    Public ASubtotal_Pagar(8)
    Public ADescuento1(8)
    Public ADescuento2(8)
    Public ATotal(8)
    Public Afuncion(8)
    Public ACine(8)

    Public indice = 0

    Public calculo_Subtotal As Double = 0
    Public calculo_Descuento1 As Double = 0
    Public calculo_Descuento2 As Double = 0


    Function calcularSubtotal(funcion As String, cine As String) As Double

        Select Case cine

            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_Subtotal = 30
                    Case "2"
                        calculo_Subtotal = 35
                    Case Else
                        calculo_Subtotal = 40
                End Select

            Case "B"

                Select Case funcion
                    Case "1"
                        calculo_Subtotal = 24
                    Case "2"
                        calculo_Subtotal = 34
                    Case Else
                        calculo_Subtotal = 44
                End Select

            Case "C"

                Select Case funcion
                    Case "1"
                        calculo_Subtotal = 35
                    Case "2"
                        calculo_Subtotal = 40
                    Case Else
                        calculo_Subtotal = 50
                End Select

        End Select

        Return calculo_Subtotal

    End Function

    Function CalculoDescuento1(funcion As String, cine As String) As Double

        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculo_Descuento1 = 0.055

        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculo_Descuento1 = 0.03
        ElseIf (funcion = "2") And (cine = "A") Then
            calculo_Descuento1 = 0.015
        End If


        Return calculo_Descuento1
    End Function

    Function CalculoDescuento2(subtotal1 As Double)

        If subtotal1 >= 100 And subtotal1 <= 300 Then
            calculo_Descuento2 = 0.02
        ElseIf subtotal1 > 300 And subtotal1 <= 500 Then
            calculo_Descuento2 = 0.04
        ElseIf subtotal1 > 500 And subtotal1 <= 1000 Then
            calculo_Descuento2 = 0.06

        End If

        Return calculo_Descuento2


    End Function

    Sub LIMPIAR_ENTRADAS()

        Form1.CMBCine.Text = ""
        Form1.CMBFuncion.Text = ""
        Form1.TXTentradas.Clear()
        Form1.TXTentradas.Focus()

    End Sub

End Module
