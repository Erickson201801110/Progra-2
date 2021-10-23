Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (TXTNIT.Text = "") Or (TXTNOMBRE.Text = "") Or (TXTDIAS.Text = "") Or (TXTHONORARIOS.Text = "") Then
            MsgBox("LOS CAMPOS ESTAN VACIOS, INGRESAR DATOS")
        End If

        If (CMBHABITACION.SelectedIndex = -1) Or (CMBPAGO.SelectedIndex = -1) Then
            MsgBox("SELECCIONAR UNA OPCION")
        End If

        For FILA As Integer = 0 To 5
            If (MATRIZ(FILA, 0) <> Nothing) Then
                If (MATRIZ(FILA, 0) = TXTNIT.Text) Then
                    MsgBox("No. NIT EXISTENTEN EN REGISTRO, COLOCAR NUEVO")
                    Exit Sub
                End If
            End If
        Next

        If INDEX < 6 Then
            MATRIZ(INDEX, 0) = TXTNIT.Text
            MATRIZ(INDEX, 1) = TXTNOMBRE.Text
            MATRIZ(INDEX, 2) = TXTDIAS.Text
            MATRIZ(INDEX, 3) = TXTHONORARIOS.Text
            MATRIZ(INDEX, 4) = CMBHABITACION.Text
            MATRIZ(INDEX, 5) = CMBPAGO.Text

            Select Case CMBHABITACION.Text
                Case "PRIVADA"
                    MATRIZ(INDEX, 6) = Val(TXTDIAS.Text) * 350
                Case "SEMIPRIVADA"
                    MATRIZ(INDEX, 6) = Val(TXTDIAS.Text) * 250
                Case "NO PRIVADA"
                    MATRIZ(INDEX, 6) = Val(TXTDIAS.Text) * 150
            End Select


            Select Case CMBPAGO.Text
                Case "Efectivo"
                    MATRIZ(INDEX, 7) = Val(MATRIZ(INDEX, 6)) * 0.1 * -1
                Case "Depósito"
                    MATRIZ(INDEX, 7) = Val(MATRIZ(INDEX, 6)) * 0.1 * -1
                Case "Transferencia"
                    MATRIZ(INDEX, 7) = Val(MATRIZ(INDEX, 6)) * 0.08 * -1
                Case "Tarjeta"
                    MATRIZ(INDEX, 7) = Val(MATRIZ(INDEX, 6)) * 0.015
            End Select



            MATRIZ(INDEX, 8) = Val(MATRIZ(INDEX, 6)) + Val(MATRIZ(INDEX, 7))

        MsgBox("Se almacenarán los siguientes valores " + MATRIZ(INDEX, 0) + MATRIZ(INDEX, 1) + MATRIZ(INDEX, 2) + MATRIZ(INDEX, 3) + MATRIZ(INDEX, 4) + MATRIZ(INDEX, 5) + MATRIZ(INDEX, 6) + MATRIZ(INDEX, 7) + MATRIZ(INDEX, 8))

            INDEX = INDEX + 1

        Else

        MsgBox("La matriz llegó al límite de pacientes, limpiarla para más registros")
        End If

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        Dim fila As Integer = 0
        While fila < 6
            If (MATRIZ(fila, 0) <> Nothing) Then
                DataGridView1.Rows.Add(MATRIZ(fila, 0), MATRIZ(fila, 1), MATRIZ(fila, 2), MATRIZ(fila, 3), MATRIZ(fila, 4), MATRIZ(fila, 5), MATRIZ(fila, 6), MATRIZ(fila, 7), MATRIZ(fila, 8))
            End If
            fila = fila + 1
        End While

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click

        If TXTNIT.Text = "" Then
            MsgBox("No seleccionó NIT")
            Exit Sub
        End If

        Dim encontro = False

        For fila As Integer = 0 To 5
            If (MATRIZ(fila, 0) <> Nothing) Then
                If (MATRIZ(fila, 0) = TXTNIT.Text) Then
                    TXTNOMBRE.Text = MATRIZ(fila, 1)
                    TXTDIAS.Text = MATRIZ(fila, 2)
                    TXTHONORARIOS.Text = MATRIZ(fila, 3)
                    CMBHABITACION.Text = MATRIZ(fila, 4)
                    CMBPAGO.Text = MATRIZ(fila, 5)
                    encontro = True
                End If
            End If
        Next

        If (encontro = False) Then
            MsgBox("No se encontró el paciente")
        ElseIf encontro = True Then
            MsgBox("Se encontró el paciente")
        End If
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        Dim fila As Byte
        Dim columna As Byte

        For fila = 0 To 5
            For columna = 0 To 8
                MATRIZ(fila, columna) = Nothing
            Next
        Next

        DataGridView1.Rows.Clear()

        INDEX = 0

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click

        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fila As Integer = 0

        Dim E1 = 0
        Dim E2 = 0
        Dim E3 = 0

        While fila < 6
            If (MATRIZ(fila, 0) <> Nothing) Then

                If MATRIZ(fila, 4) = "Privada" Then
                    E1 = E1 + 1
                End If

                If MATRIZ(fila, 5) = "Transferencia" Then
                    E2 = E2 + Val(MATRIZ(fila, 8))
                End If

                If MATRIZ(fila, 4) = "No privada" Then
                    E3 = E3 + Val(MATRIZ(fila, 2))
                End If
            End If
            fila = fila + 1
        End While


        TXTPACIENTE.Text = E1
        TXTTRANSFERENCIA.Text = E2
        TXTDNPRIVADA.Text = E3
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click

        SALIR()

    End Sub
End Class
