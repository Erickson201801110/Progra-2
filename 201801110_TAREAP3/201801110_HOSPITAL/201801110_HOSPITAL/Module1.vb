Module Module1

    Public MATRIZ(6, 9) As String

    Public INDEX = 0


    Sub SALIR()
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If

    End Sub

    Sub LIMPIAR_ENTRADAS()

        Form1.TXTDIAS.Text = ""
        Form1.TXTNIT.Text = ""
        Form1.TXTHONORARIOS.Text = ""
        Form1.TXTNOMBRE.Text = ""
        Form1.CMBHABITACION.Text = ""
        Form1.CMBPAGO.Text = ""

    End Sub
End Module
