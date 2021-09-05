Public Class Form1

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click

        If (TXTconsumidor.Text = "") Then
            MsgBox("INGESE NOMBRRE, POR FAVOR", vbQuestion)

            LIMPIAR_ENTRADAS()

            Exit Sub

            TXTconsumidor.Focus()
        End If

        If (TXTNit.Text = "") Then
            MsgBox("INGESE NIT, POR FAVOR", vbQuestion)

            LIMPIAR_ENTRADAS()

            Exit Sub

            TXTconsumidor.Focus()
        End If

        If (TXTConsumo.Text = "") Then
            MsgBox("INGESE CONSUMO EN KILOWATTS, POR FAVOR", vbQuestion)

            LIMPIAR_ENTRADAS()

            Exit Sub

            TXTconsumidor.Focus()
        End If

        If (TXTSALDOANTERIOR.Text = "") Then
            MsgBox("INGESE SALDO ANTERIOR, POR FAVOR, DE NO EXISTIR COLOCAR 0", vbQuestion)

            LIMPIAR_ENTRADAS()

            Exit Sub

            TXTSALDOANTERIOR.Focus()
        End If

        If (DATOS <= 11) Then

            consumidor(DATOS) = TXTconsumidor.Text
            SERVICIO(DATOS) = CMBServicio.Text
            TARIFA(DATOS) = CMBTarifa.Text
            SALDOANTERIOR(DATOS) = TXTSALDOANTERIOR.Text


            If Str(CMBServicio.Text = "RESIDENCIAL") Then

                Select Case Val(TXTConsumo.Text)
                    Case 1 To 100
                        Total_PInicial = Val(TXTConsumo.Text) * residencialUno
                    Case 101 To 300
                        Total_PInicial = Val(TXTConsumo.Text) * residencialDos
                    Case >= 301
                        Total_PInicial = Val(TXTConsumo.Text) * residencialTres
                End Select

                PAGOINICIAL(DATOS) = Math.Round(Total_PInicial, 2)

            End If

            If Str(CMBServicio.Text = "INDUSTRIAL") Then

                Select Case Val(TXTConsumo.Text)
                    Case 1 To 100
                        Total_PInicial = Val(TXTConsumo.Text) * residencialUno
                    Case 101 To 300
                        Total_PInicial = Val(TXTConsumo.Text) * residencialDos
                    Case >= 301
                        Total_PInicial = Val(TXTConsumo.Text) * residencialTres
                End Select

                PAGOINICIAL(DATOS) = Math.Round(Total_PInicial, 2)

            End If

            If Val(TXTSALDOANTERIOR.Text) > 0 Then

                Total_recargo = (Val(TXTSALDOANTERIOR.Text) * MoraAplicado)
                MORA(DATOS) = (MoraAplicado * 100).ToString + "%"


            ElseIf Val(TXTSALDOANTERIOR.Text) <= 0 Then
                MORA(DATOS) = "NO SE APLICA MORA"

            End If

            Total_mora = Val(TXTSALDOANTERIOR.Text) + Total_recargo
            PAGOMORA(DATOS) = Math.Round(Total_mora, 2)


            Select Case CMBTarifa.Text
                Case "SOCIAL"

                    Total_Pparcial = Val((TXTSALDOANTERIOR.Text) + Total_PInicial) + Total_recargo
                    PAGOPARCIAL(DATOS) = Total_Pparcial

                    Total_tarifa = Total_Pparcial * DescuentoSocial
                    DESCUENTO(DATOS) = (DescuentoSocial * 100).ToString + "%"

                    Total_Pfinal = Total_Pparcial - Total_tarifa
                    PAGOPARCIAL(DATOS) = Math.Round(Total_Pfinal, 2)


                Case "NO SOCIAL"

                    Total_tarifa = Total_PInicial - (Total_PInicial * DescuentoNosocial)
                    DESCUENTO(DATOS) = (DescuentoNosocial * 100).ToString + "%"

                    PAGOINICIAL(DATOS) = Math.Round(Total_tarifa, 2)

                    Total_Pparcial = Total_tarifa + Total_mora
                    PAGOPARCIAL(DATOS) = Math.Round(Total_PInicial, 2)

                    MsgBox("RECUERDE EL DESCUENTO ES APLICADO A SU TARIFA EN EL PAGO INICIAL DEL MES")

            End Select

            mostrar_vectores()

            DATOS = DATOS + 1

        End If


    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub
End Class
