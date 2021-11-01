Module Module1

    Public ETAPA(12) As Integer
    Public EQUIPO(12) As String
    Public KM_RECORRIDO(12) As Integer
    Public TIEMPO(12) As Integer
    Public NACIONALIDAD(12) As String
    Public PENALIZACION(12) As Integer
    Public TIEMPO_TOTAL(12) As Integer

    Public fila As Byte = 0
    Public I As Byte




    Sub SALIR()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else

            limpiar_entradas()
            limpiar_estadisticas()
        End If
    End Sub

    Sub LIMPIAR_ENTRADAS()

        Form1.TXTETAPA.Clear()
        Form1.TXTKM.Clear()
        Form1.TXTTIEMPO.Clear()
        Form1.RBEXTRA.Checked = False
        Form1.RBGUATE.Checked = False
        Form1.CMBEQUIPO.Text = ""
        Form1.TXTETAPA.Focus()

    End Sub

    Sub LIMPIAR_ESTADISTICAS()

        Form1.TXTE1.Clear()
        Form1.TXTE2.Clear()
        Form1.TXTE3.Clear()
        Form1.TXTE1.Focus()

    End Sub

    Sub MOSTRAR_VECTORES()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 12

            If (ETAPA(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(ETAPA(I)), EQUIPO(I), Str(KM_RECORRIDO(I)), Str(TIEMPO(I)), Str(PENALIZACION(I)), TIEMPO_TOTAL(I), NACIONALIDAD(I))
            Else

                Exit For
            End If
        Next I
    End Sub

    Sub LIMPIAR_VECTORES()
        Form1.DataGridView1.Rows.Clear()

        fila = 0

        For I = 0 To 12
            ETAPA(I) = Nothing
            EQUIPO(I) = Nothing
            KM_RECORRIDO(I) = Nothing
            TIEMPO(I) = Nothing
            NACIONALIDAD(I) = Nothing
            TIEMPO_TOTAL(I) = Nothing
            PENALIZACION(I) = Nothing
        Next I
    End Sub
End Module
