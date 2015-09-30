Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.Green Then
            MyBase.BackColor = Color.Blue
        Else : MyBase.BackColor = Color.Green
        End If
    End Sub
End Class
