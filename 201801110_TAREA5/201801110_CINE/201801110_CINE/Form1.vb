Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        MsgBox(calcularSubtotal("1", "A"))

        'verificacion de datos  ( elegir cine y funcion)
        If CMBCine.SelectedItem = "" Or CMBFuncion.SelectedItem = "" Or TXTentradas.Text = "" Then
            MsgBox("Los campos estan Vacios")

            Exit Sub
        End If

        'envio de la funcion y cine
        If indice < 9 Then
            Afuncion(indice) = CMBFuncion.SelectedItem
            ACine(indice) = CMBCine.SelectedItem
            ASubtotal_Pagar(indice) = Val(TXTentradas.Text) * calcularSubtotal(Afuncion(indice), ACine(indice))
            ADescuento1(indice) = ASubtotal_Pagar(indice) * CalculoDescuento1(Afuncion(indice), ACine(indice))
            ADescuento2(indice) = ASubtotal_Pagar(indice) * CalculoDescuento2((ASubtotal_Pagar(indice)))
            ATotal(indice) = ASubtotal_Pagar(indice) - (ADescuento1(indice) + ADescuento2(indice))

            LTBFuncion.Items.Add(Afuncion(indice))
            LTBCine.Items.Add(ACine(indice))
            LTBSubtotal.Items.Add(ASubtotal_Pagar(indice))
            LTBDescuento1.Items.Add(ADescuento1(indice))
            LTBDescuento2.Items.Add(ADescuento2(indice))
            LTBTotal.Items.Add(ATotal(indice))

        ElseIf indice >= 9 Then

        End If

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click

        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click

        indice = 0

        LTBCine.Items.Clear()
        LTBFuncion.Items.Clear()
        LTBDescuento1.Items.Clear()
        LTBDescuento2.Items.Clear()
        LTBSubtotal.Items.Clear()
        LTBTotal.Items.Clear()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub
End Class
