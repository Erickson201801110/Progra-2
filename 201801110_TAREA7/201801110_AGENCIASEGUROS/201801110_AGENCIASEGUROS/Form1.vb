Public Class Form1
    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click

        If (FILA <= 7) Then
            EDAD(FILA) = Val(TXTEDAD.Text)
            GENERO(FILA) = CMBGENERO.Text
            CODIGO_R(FILA) = CMBCODIGO.Text
            MONTO_DAÑOS(FILA) = Val(TXTMONTO.Text)
            TALLER(FILA) = CMBTALLER.Text
            MONTO_DEDUCIBLE(FILA) = Val(TXTDEDUCIBLE.Text)

            FILA = FILA + 1

            inicializar_datos()
            If (FILA = 8) Then
                MsgBox("VECTORES LLENOS")
            End If

        End If

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click

        Dim X As Byte

        DataGridView1.Rows.Clear()
        For X = 0 To 7
            If EDAD(X) <> Nothing Then
                DataGridView1.Rows.Add(Str(EDAD(X)), GENERO(X), CODIGO_R(X), MONTO_DAÑOS(X), TALLER(X), MONTO_DEDUCIBLE(X))
            Else
                Exit For
            End If
        Next X

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click

        Dim J As Byte

        For J = 0 To 7

            EDAD(J) = Nothing
            GENERO(J) = Nothing
            CODIGO_R(J) = Nothing
            MONTO_DAÑOS(J) = Nothing
            TALLER(J) = Nothing
            MONTO_DEDUCIBLE(J) = Nothing

        Next J
        DataGridView1.Rows.Clear()

        FILA = 0

    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click

        TXTR1.Clear()
        TXTR2.Clear()
        TXTR3.Clear()
        TXTR4.Clear()
        TXTR5.Clear()
        TXTR6.Clear()

        FILA = 0

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click

        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click

        If FILA < 7 Then

            TXTDEDUCIBLE.Text = Val(TXTMONTO.Text) * 0.06

        End If
    End Sub

    Private Sub BTNESTADISTICAS_Click(sender As Object, e As EventArgs) Handles BTNESTADISTICAS.Click

        Dim K As Byte
        Dim R1 As Byte = 0
        Dim R2 As Byte = 0
        Dim R3 As Byte = 0
        Dim R4 As Byte = 0
        Dim R5 As Integer = 0
        Dim R6 As Integer = 0

        For K = 0 To DataGridView1.Rows.Count
            If (EDAD(K) < 25 And EDAD(K) > 0) Then
                R1 = R1 + 1
            End If
            If (GENERO(K) = "F") Then
                R2 = R2 + 1
            End If
            If (EDAD(K) > 18 And EDAD(K) < 25 And GENERO(K) = "M") Then
                R3 = R3 + 1
            End If
            If (CODIGO_R(K) = "0") Then
                R4 = R4 + 1
            End If
            If (MONTO_DAÑOS(K) <> 0) Then
                R6 = R6 + MONTO_DAÑOS(K)
            End If
        Next
        TXTR1.Text = Str(R1)
        TXTR2.Text = Str(R2)
        TXTR3.Text = Str(R3)
        TXTR4.Text = Str(R4)
        TXTR5.Text = Str(DataGridView1.Rows.Count - 1)
        TXTR6.Text = Str(R6)

    End Sub
End Class
