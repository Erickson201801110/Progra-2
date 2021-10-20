Public Class Form1
    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        GUARDAR()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiar_Matrices()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If RadioButton1.Checked = True Then
            Pago_Inicial = Inscripcion_Basico + primera_basico
            If CMBFPAGO.SelectedItem = "TARJETA DE CREDITO" Then
                Pago_Final = Pago_Inicial + Pago_Inicial * 0.1

            End If
        Else
            Exit Sub

            If RadioButton2.Checked = True Then
                Pago_Inicial = inscripcion_diversificado + primera_diversificado
                If CMBFPAGO.SelectedItem = "TARJETA DE CREDITO" Then
                    Pago_Final = Pago_Inicial + Pago_Inicial * 0.1

                End If
            Else
                Exit Sub
            End If
        End If
    End Sub
End Class
