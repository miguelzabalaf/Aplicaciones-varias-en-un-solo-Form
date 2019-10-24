Public Class Promedios
    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        TextBox2.Text = ""
        TextBox2.ForeColor = Color.Black
        Timer1.Enabled = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer3.Enabled = True
        Timer2.Enabled = False
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        nota.Text = ""
        info.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        user.Text = TextBox2.Text
        Me.Text = "Promedio de Notas - USER: " + TextBox2.Text
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox3.Text) = "" Then
            MsgBox("Lo sentimos, no podemos calcular tu promedio si no haz ingrasado las notas", MsgBoxStyle.Information, "¡Alerta!")
        Else
            Timer3.Enabled = False
            Timer2.Enabled = True
            nota.Text = Val(TextBox3.Text * 0.2) + Val(TextBox4.Text * 0.3) + Val(TextBox5.Text * 0.5)
            If (nota.Text) < 3 Then
                nota.ForeColor = Color.Red
                info.ForeColor = Color.Red
                info.Text = "Haz reprobado, inténtalo de nuevo."
            Else
                nota.ForeColor = Color.Green
                info.ForeColor = Color.Green
                info.Text = "Haz Aprobado, ¡Bien hecho!"
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Height += 3
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Height -= 3
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If (Val(TextBox3.Text)) > 5 Then
            TextBox3.Text = ""
            MsgBox("Te recordamos que las notas solo pueden ser entre 0 y 5", MsgBoxStyle.Information, "¡Corrige!")
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If (Val(TextBox4.Text)) > 5 Then
            TextBox4.Text = ""
            MsgBox("Te recordamos que las notas solo pueden ser entre 0 y 5", MsgBoxStyle.Information, "¡Corrige!")
        End If
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If (Val(TextBox5.Text)) > 5 Then
            TextBox5.Text = ""
            MsgBox("Te recordamos que las notas solo pueden ser entre 0 y 5", MsgBoxStyle.Information, "¡Corrige!")
        End If
    End Sub
End Class