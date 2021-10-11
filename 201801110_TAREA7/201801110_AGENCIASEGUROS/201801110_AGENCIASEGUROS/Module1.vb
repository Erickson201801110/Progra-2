Module Module1

    Public FILA As Byte = 0

    Public EDAD(7)
    Public GENERO(7)
    Public CODIGO_R(7)
    Public MONTO_DAÑOS(7)
    Public TALLER(7)
    Public MONTO_DEDUCIBLE(7)

    Sub inicializar_datos()

        Form1.TXTEDAD.Clear()
        Form1.TXTMONTO.Clear()
        Form1.CMBCODIGO.Text = ""
        Form1.CMBGENERO.Text = ""
        Form1.CMBTALLER.Text = ""
        Form1.TXTEDAD.Focus()

    End Sub

End Module
