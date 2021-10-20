Module Module1

    Public Fila As Byte = 0

    Public nivel_estudio(7, 9) As String
    Public Nombre_usario
    Public Carnet
    Public Nivel
    Public Carrera
    Public Cuota_Inscripcion
    Public Primera_Cuota
    Public Forma_pago
    Public Pago_Inicial
    Public Pago_Final
    Public Const Inscripcion_Basico = 350
    Public Const inscripcion_diversificado = 450
    Public Const primera_basico = 250
    Public Const primera_diversificado = 350


    Sub limpiar_entradas()

        Form1.TXTcarnet.Text = ""
        Form1.TXTUsuario.Text = ""
        Form1.TXTPrimera.Text = ""
        Form1.TXTinscripcion.Text = ""
        Form1.CMBCARRERA.Text = ""
        Form1.CMBFPAGO.Text = ""
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False

    End Sub
    Sub Limpiar_Totales()

        Form1.TXTFPAGO.Clear()
        Form1.TXTGENERAL.Clear()
        Form1.TXTNIVEL.Clear()
        Form1.TXTINSCRITOS.Clear()

    End Sub

    Sub salir()

        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If

    End Sub
    Sub mostrar()

        Dim i As Byte

        For i = 0 To 6

            If Nivel_Estudio(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Nivel_Estudio(i, 0), Nivel_Estudio(i, 1), Nivel_Estudio(i, 2), Nivel_Estudio(i, 3), Nivel_Estudio(i, 4), Nivel_Estudio(i, 5), Nivel_Estudio(i, 6), Nivel_Estudio(i, 7), Nivel_Estudio(i, 8))
            Else
                'instrucción que hace que se haga una salida forzada del ciclo for en dado caso la condición 
                'del if es falsa
                Exit For
            End If
        Next i
    End Sub

    Sub limpiar_Matrices()

        Dim i As Byte, j As Byte

        For i = 0 To 6
            For j = 0 To 7
                Nivel_Estudio(i, j) = Nothing
            Next j
        Next i

    End Sub
    Sub GUARDAR()

        If (Fila <= 6) Then
            nivel_estudio(Fila, 0) = Form1.TXTUsuario.Text
            nivel_estudio(Fila, 1) = Val(Form1.TXTcarnet.Text)
            nivel_estudio(Fila, 3) = Form1.CMBCARRERA.Text
            nivel_estudio(Fila, 6) = Form1.CMBFPAGO.Text
            nivel_estudio(Fila, 7) = Pago_Inicial
            nivel_estudio(Fila, 8) = Pago_Final

            If Form1.RadioButton1.Checked Then
                nivel_estudio(Fila, 2) = Form1.RadioButton1.Text
            ElseIf Form1.RadioButton2.Checked Then
                nivel_estudio(Fila, 2) = Form1.RadioButton2.Text
            End If

            If Form1.RadioButton1.Checked Then
                nivel_estudio(Fila, 4) = Inscripcion_Basico
            ElseIf Form1.RadioButton2.Checked Then
                nivel_estudio(Fila, 4) = inscripcion_diversificado
            End If

            If Form1.RadioButton1.Checked Then
                nivel_estudio(Fila, 5) = primera_basico
            ElseIf Form1.RadioButton2.Checked Then
                nivel_estudio(Fila, 2) = primera_diversificado
            End If

            Fila = Fila + 1

            If (Fila = 7) Then
                MsgBox("MATRIZ LLENA")
            End If

        End If
    End Sub

End Module
