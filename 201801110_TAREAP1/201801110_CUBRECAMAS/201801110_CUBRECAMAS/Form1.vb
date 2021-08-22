Public Class Form1
    Private Sub HCRUDO_CheckedChanged(sender As Object, e As EventArgs) Handles HCRUDO.CheckedChanged
        If HCRUDO.Checked = True Then
            TXTHILO.Enabled = True
            TXTHILO.Text = 0
        Else
            TXTHILO.Enabled = False
            TXTHILO.Text = 0
        End If
    End Sub

    Private Sub SEDA_CheckedChanged(sender As Object, e As EventArgs) Handles SEDA.CheckedChanged
        If SEDA.Checked = True Then
            TXTSEDA.Enabled = True
            TXTSEDA.Text = 0
        Else
            TXTSEDA.Enabled = False
            TXTSEDA.Text = 0
        End If
    End Sub

    Private Sub ALGODON_CheckedChanged(sender As Object, e As EventArgs) Handles ALGODON.CheckedChanged
        If ALGODON.Checked = True Then
            TXTALGODON.Enabled = True
            TXTALGODON.Text = 0
        Else
            TXTALGODON.Enabled = False
            TXTALGODON.Text = 0
        End If
    End Sub

    Private Sub LINO_CheckedChanged(sender As Object, e As EventArgs) Handles LINO.CheckedChanged
        If LINO.Checked = True Then
            LINO.Enabled = True
            LINO.Text = 0
        End If
    End Sub

    Private Sub BTNAceptar_Click(sender As Object, e As EventArgs) Handles BTNAceptar.Click
        LBPrecioCosto.Text = "0.00"
        precioTotal = 0.00

        SumaYardas = Val(TXTLINO.Text) + Val(TXTHILO.Text) + Val(TXTSEDA.Text) + Val(TXTALGODON.Text)


        If RBKing.Checked = True Then
            If SumaYardas = matking Then
                precioTotal = precioKing + Val(TXTLINO.Text) * precioLino + Val(TXTHILO.Text) * precioHilo + Val(TXTSEDA.Text) * Precioseda + Val(TXTALGODON.Text) * precioAlgodon
            Else MsgBox("No es la cantidad Necesario Para Hacerlo")
            End If

        ElseIf RBQueen.Checked = True Then
            If SumaYardas = matQueen Then
                precioTotal = precioqueen + Val(TXTLINO.Text) * precioLino + Val(TXTHILO.Text) * precioHilo + Val(TXTSEDA.Text)
            Else MsgBox("No es la cantidad Necesario Para Hacerlo")
            End If

        ElseIf RBMatrimonial.Checked = True Then
            If SumaYardas = matMat Then
                precioTotal = Preciomatrimonial + Val(TXTLINO.Text) * precioLino + Val(TXTHILO.Text) * precioHilo + Val(TXTSEDA.Text)
            Else MsgBox("No es la cantidad Necesario Para Hacerlo")
            End If

        ElseIf RBImperial.Checked = True Then
            If SumaYardas = matImp Then
                precioTotal = precioimperial + Val(TXTLINO.Text) * precioLino + Val(TXTHILO.Text) * precioHilo + Val(TXTSEDA.Text)
            Else MsgBox("No es la cantidad Necesario Para Hacerlo")
            End If
        End If

        precioVenta = precioTotal * 0.65
        LBPrecioCosto.Text = Str(precioTotal)
        LBPrecioVenta.Text = Str(precioTotal + precioVenta)




    End Sub

    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiar.Click

    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        'LA SIGUIENTE INSTRUCCION SE UTILIZA PARA SALIR DEL PROGRAMA
        If MsgBox("Desea salir de la aplicacion", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
