Public Class q2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        q3.show()
        Me.Close()

    End Sub

    Private Sub q2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.Enabled = False
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        RadioButton2.Enabled = False
        RadioButton1.Enabled = False
        RadioButton4.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
        RadioButton1.Enabled = False
        Button1.Enabled = True
    End Sub
End Class