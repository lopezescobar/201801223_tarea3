Public Class Form1
    Private Sub cbcompra_CheckedChanged(sender As Object, e As EventArgs) Handles cbcompra.CheckedChanged
        If cbcompra.Checked = True Then
            txtcompra.Enabled = True
        Else
            txtcompra.Enabled = False

        End If
    End Sub

    Private Sub cbventa_CheckedChanged(sender As Object, e As EventArgs) Handles cbventa.CheckedChanged
        If cbcompra.Checked = True Then
            txtventa.Enabled = True
        Else
            txtventa.Enabled = False

        End If
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub
End Class
