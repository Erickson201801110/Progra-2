Public Class Form1

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        SALIR()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        LIMPIAR_ESTADISTICAS()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR_VECTORES()
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click

        If (fila <= 12) Then
            ETAPA(fila) = Val(TXTETAPA.Text)
            EQUIPO(fila) = CMBEQUIPO.Text
            KM_RECORRIDO(fila) = Val(TXTKM.Text)
            TIEMPO(fila) = Val(TXTTIEMPO.Text)

            fila = fila + 1

            If (fila = 12) Then
                MsgBox("VECTORES LLENOS")
            End If

        End If
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click

        Dim existe As Boolean = True


        I = 0

        While (I <= 12) And (existe)

            If (ETAPA(I) = Val(TXTNUMEROET.Text)) Then
                existe = False
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Carnet no encontrado")
            TXTNUMEROET.Focus()
        Else
            MsgBox("Registro Encontrado exitosamente")

            TXTETAPA.Text = Str(ETAPA(I))
            TXTKM.Text = Str(KM_RECORRIDO(I))
            TXTTIEMPO.Text = Str(TIEMPO(I))
            RBEXTRA.Text = NACIONALIDAD(I)
            RBGUATE.Text = NACIONALIDAD(I)
            CMBEQUIPO.Text = EQUIPO(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(EQUIPO(I)), NACIONALIDAD(I), Str(ETAPA(I)), Str(KM_RECORRIDO(I)), Str(TIEMPO(I)), Str(TIEMPO_TOTAL(I)), Str(PENALIZACION(I)))

            fila = I
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click

        ETAPA(fila) = Val(TXTETAPA.Text)
        EQUIPO(fila) = CMBEQUIPO.Text
        KM_RECORRIDO(fila) = Val(TXTKM.Text)
        TIEMPO(fila) = Val(TXTTIEMPO.Text)
        TIEMPO_TOTAL(fila) = TIEMPO(fila) + PENALIZACION(fila)

        MsgBox("Registro actualizado correctamente en los vectores")

        fila = 12
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click

        ETAPA(fila) = Nothing
        EQUIPO(fila) = Nothing
        KM_RECORRIDO(fila) = Nothing
        TIEMPO(fila) = Nothing
        NACIONALIDAD(fila) = Nothing
        PENALIZACION(fila) = Nothing
        TIEMPO_TOTAL(fila) = Nothing

        For I = fila To 12

            ETAPA(I) = ETAPA(I + 1)
            EQUIPO(I) = EQUIPO(I + 1)
            KM_RECORRIDO(I) = KM_RECORRIDO(I + 1)
            TIEMPO(I) = TIEMPO(I + 1)
            NACIONALIDAD(I) = NACIONALIDAD(I + 1)
            PENALIZACION(I) = PENALIZACION(I + 1)
            TIEMPO_TOTAL(I) = TIEMPO_TOTAL(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        ETAPA(fila) = Nothing
        EQUIPO(fila) = Nothing
        KM_RECORRIDO(fila) = Nothing
        TIEMPO(fila) = Nothing
        NACIONALIDAD(fila) = Nothing
        PENALIZACION(fila) = Nothing
        TIEMPO_TOTAL(fila) = Nothing

        fila = I
        LIMPIAR_ENTRADAS()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADISTICASToolStripMenuItem.Click

        Dim E1 = 0
        Dim E2 = 0
        Dim E3 = 0

        Select Case RBGUATE.Checked
            Case "GUATEMALTECO"
                If NACIONALIDAD(fila) = "GUATEMALTECO " Then
                    NACIONALIDAD(fila) = Val(NACIONALIDAD(fila) + 1)
                    E1 = E1 + 1
                End If
        End Select

        Select Case CMBEQUIPO.Text
            Case "MOVISTAR"
                E2 = Val(TXTE2.Text) + NACIONALIDAD(fila)
            Case "SKY"
                E2 = Val(TXTE2.Text) + NACIONALIDAD(fila)
            Case "PRO CYCLING"
                E2 = Val(TXTE2.Text) + NACIONALIDAD(fila)
            Case "PRO TEAM"
                E2 = Val(TXTE2.Text) + NACIONALIDAD(fila)
        End Select
    End Sub
End Class
