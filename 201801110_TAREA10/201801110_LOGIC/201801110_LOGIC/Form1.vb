Public Class Form1
    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If TXTDPI.Text = Nothing Or TXTCLIENTE.Text = Nothing Or TXTVALOR.Text = Nothing Or TXTMESES.Text = Nothing Then
            MsgBox("LOS CAMPOS SE ENCUENTRAN VACIOS")
            Exit Sub
        End If


        If INDICE < 7 Then

            DPI(INDICE) = TXTDPI.Text
            NOMBRE_CLIENTE(INDICE) = TXTCLIENTE.Text
            VALOR_ARTICULO(INDICE) = TXTVALOR.Text
            MESES(INDICE) = TXTMESES.Text

            TASA(INDICE) = OPERAR(Val(TXTMESES.Text), Val(TXTVALOR.Text))
            MONTO_FINAL(INDICE) = Val(TXTVALOR.Text) + Val(TASA(INDICE)) * Val(TXTVALOR.Text)
            INDICE = INDICE + 1
        Else
            MsgBox("LOS VECTORES ESTAN LLENOS")

        End If
    End Sub

    Private Sub ORDENARDESCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDESCENDENTEToolStripMenuItem.Click
        Dim X As Byte
        Dim J As Byte
        Dim TEMP1
        Dim TEMP2
        Dim TEMP3
        Dim TEMP4
        Dim TEMP5
        Dim TEMP6

        For X = 0 To 6
            For J = X + 1 To 7
                If (DPI(J) <> Nothing) Then
                    If (DPI(X) > DPI(J)) Then
                        TEMP1 = DPI(X)
                        DPI(X) = DPI(J)
                        DPI(J) = TEMP1

                        TEMP2 = NOMBRE_CLIENTE(X)
                        NOMBRE_CLIENTE(X) = NOMBRE_CLIENTE(J)
                        NOMBRE_CLIENTE(J) = TEMP2

                        TEMP3 = VALOR_ARTICULO(X)
                        VALOR_ARTICULO(X) = VALOR_ARTICULO(J)
                        VALOR_ARTICULO(J) = TEMP3

                        TEMP4 = MESES(X)
                        MESES(X) = MESES(J)
                        MESES(J) = TEMP4

                        TEMP5 = TASA(X)
                        TASA(X) = TASA(J)
                        TASA(J) = TEMP5

                        TEMP6 = MONTO_FINAL(X)
                        MONTO_FINAL(X) = MONTO_FINAL(J)
                        MONTO_FINAL(J) = TEMP6

                    End If
                Else
                    Exit For
                End If
            Next J
        Next X

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MOSTRAR_VECTORES()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LIMPIAR_VECTORES()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir()
    End Sub
End Class