Public Class res


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cont = 0
        iniciar.Show()
        Me.Close()

    End Sub

    Private Sub res_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = cont

    End Sub
End Class