Public Class Votos_ADSI
    Dim maxVotantes = 30
    Private Sub Votos_ADSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nEstudiantes.Focus()
    End Sub

    Private Sub VJ_Click(sender As Object, e As EventArgs) Handles vJ.Click
        VJUAN.Text = VJUAN.Text + 1
        votos.Text = votos.Text + 1
        Timer2.Enabled = True
        nEstudiantes.Enabled = False
    End Sub

    Private Sub VM_Click(sender As Object, e As EventArgs) Handles vM.Click
        VMIGUEL.Text = VMIGUEL.Text + 1
        votos.Text = votos.Text + 1
        Timer2.Enabled = True
        nEstudiantes.Enabled = False
    End Sub

    Private Sub VD_Click(sender As Object, e As EventArgs) Handles vD.Click
        VDIANA.Text = VDIANA.Text + 1
        votos.Text = votos.Text + 1
        Timer2.Enabled = True
        nEstudiantes.Enabled = False
    End Sub

    Private Sub VB_Click(sender As Object, e As EventArgs) Handles vB.Click
        VBLANCO.Text = VBLANCO.Text + 1
        votos.Text = votos.Text + 1
        Timer2.Enabled = True
        nEstudiantes.Enabled = False
    End Sub


    Private Sub nEstudiantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nEstudiantes.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Te recordamos que solo puede digitar números.")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Val(nEstudiantes.Text) > maxVotantes Then
            Timer1.Enabled = False
            MsgBox("El máximo de votantes debe ser 30, te haz excedido")
            nEstudiantes.Text = 30
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Val(votos.Text) = Val(nEstudiantes.Text)) Then
            vM.Enabled = False
            vJ.Enabled = False
            vD.Enabled = False
            vB.Enabled = False
            Button2.Enabled = True
            Button1.Enabled = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nEstudiantes.Text = 30
        vM.Enabled = True
        vJ.Enabled = True
        vD.Enabled = True
        vB.Enabled = True
        VJUAN.Text = "0"
        VMIGUEL.Text = "0"
        VDIANA.Text = "0"
        VBLANCO.Text = "0"
        votos.Text = "0"
        ganador.Text = "NONE"
        nEstudiantes.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(VJUAN.Text) > (Val(VMIGUEL.Text) + Val(VDIANA.Text) + Val(VBLANCO.Text)) Then
            ganador.Text = "Juan"
            MsgBox("El ganador ha sido JUAN")
        ElseIf Val(VMIGUEL.Text) > (Val(VJUAN.Text) + Val(VDIANA.Text) + Val(VBLANCO.Text)) Then
            ganador.Text = "Miguel"
            MsgBox("El ganador ha sido Miguel")
        ElseIf Val(VDIANA.Text) > (Val(VJUAN.Text) + Val(VMIGUEL.Text) + Val(VBLANCO.Text)) Then
            ganador.Text = "Yudex"
            MsgBox("El ganador ha sido YUDEX")
        ElseIf Val(VBLANCO.Text) > (Val(VJUAN.Text) + Val(VDIANA.Text) + Val(VMIGUEL.Text)) Then
            ganador.Text = "Voto en Blanco"
            MsgBox("El ganador ha sido el voto en BLANCO")
        End If
    End Sub
End Class