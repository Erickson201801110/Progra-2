Public Class Form1
    Private Sub PROCESOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESOSToolStripMenuItem.Click

        'verificacion de datos 
        If CMBMARCA.SelectedItem = "" Or TXTDIAS.Text = "" Or TXTNIT.Text = "" Or TXTPLACA.Text = "" Then
            MsgBox("VERIFICAR LOS DATOS INGRESADOS, EXISTEN CAMPOS VACIOS")
        End If

        If TXTPORCEFECTIVO.Text = "" Or TXTPORCTARJETA.Text = "" Then
            MsgBox("INDICAR PORCENTAJE A PAGAR")
        End If

        If Val(TXTPORCEFECTIVO.Text) + Val(TXTPORCTARJETA.Text) = 100.0 Then
        Else
            MsgBox("La suma de los porcentajes no da 100")
        End If

        'envio de DATOS

        If indice < 6 Then
            Marca_Auto(indice) = CMBMARCA.SelectedItem
            pago_Parcial(indice) = Val(TXTDIAS.Text) * calculopagoparcial(Marca_Auto(indice))
            Descuento(indice) = calculoDescuentoRecargo()
            pago_Final(indice) = totalfinal()
            Dia_Alquiler(indice) = TXTDIAS.Text
            placa(indice) = TXTPLACA.Text



            LTBALQUIER.Items.Add(Dia_Alquiler(indice))
            LTBDESCUENTO.Items.Add(Descuento(indice))
            LTBMARCA.Items.Add(Marca_Auto(indice))
            LTBPARCIAL.Items.Add(pago_Parcial(indice))
            LTBPLACA.Items.Add(placa(indice))
            LTBFINAL.Items.Add(pago_Final(indice))


        ElseIf indice >= 6 Then

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
