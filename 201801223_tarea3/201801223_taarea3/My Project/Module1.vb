Module Module1
    Const tcDolar = 7.69
    Const tcPM = 0.38
    Const tcEuro = 7.89
    Const tcCCR = 0.012
    Const ComisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100
    Dim compra As String
    Dim venta As String

    Sub limpiar()
        Form1.txtcompra.Clear()
        Form1.txtventa.Clear()
        Form1.cbcompra.Checked() = False
        Form1.cbventa.Checked() = False
        Form2.Label1.Text = "limpio"
    End Sub

    Sub salir()
        End
    End Sub
End Module
