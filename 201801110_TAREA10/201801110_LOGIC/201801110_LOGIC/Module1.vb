Module Module1

    Public INDICE As Integer = 0

    Public DPI(6) As String
    Public NOMBRE_CLIENTE(6) As String
    Public VALOR_ARTICULO(6) As String
    Public MESES(6) As String
    Public TASA(6) As String
    Public MONTO_PARCIAL(6) As String
    Public MONTO_FINAL(6) As String

    Public I As Byte


    Public Function OPERAR(MESESR As Integer, VALORR As Decimal) As Decimal
        If MESESR < 12 And VALORR > 8000 Then
            Return 0.02
        ElseIf MESESR > 12 And MESESR <= 24 Then
            Return 0.045
        ElseIf MESESR > 24 And MESESR <= 36 Then
            Return 0.055
        ElseIf MESESR >= 36 Then
            Return 0.062
        ElseIf MESESR <= 12 Then
            Return 0.03
        End If

        Return 0

    End Function

    Sub LIMPIAR_ENTRADAS()

        Form1.TXTCLIENTE.Clear()
        Form1.TXTDPI.Clear()
        Form1.TXTMESES.Clear()
        Form1.TXTVALOR.Clear()

    End Sub

    Sub salir()

        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            LIMPIAR_ENTRADAS()
        End If

    End Sub

    Sub MOSTRAR_VECTORES()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 7

            If (DPI(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(DPI(I), NOMBRE_CLIENTE(I), VALOR_ARTICULO(I), MESES(I), TASA(I), MONTO_FINAL(I))
            Else
                Exit For
            End If
        Next I
    End Sub
    Sub LIMPIAR_VECTORES()

        Form1.DataGridView1.Rows.Clear()

        INDICE = 0
        
        For I = 0 To 6
            DPI(I) = Nothing
            NOMBRE_CLIENTE(I) = Nothing
            VALOR_ARTICULO(I) = Nothing
            MESES(I) = Nothing
            TASA(I) = Nothing
            MONTO_FINAL(I) = Nothing
        Next I
    End Sub
End Module
