Public Class Inversiones
    Dim FormasDePago As Integer
    Private Sub txtmonto_LostFocus(sender As Object, e As EventArgs) Handles txtmonto.LostFocus
        If txtmonto.Text <> "" Then
            If Val(txtmonto.Text) <= 2000000 And Val(txtmonto.Text) >= 500000 Then
                txtmonto.Text = Format(Math.Round(Val(txtmonto.Text)), "###.###.###")
            Else
                MsgBox("El Monto debe estar entre $ 500.000 y $ 2.000.000")
                txtmonto.Text = ""
                txtmonto.Focus()
            End If
        End If
    End Sub

    Private Sub Diario_CheckedChanged(sender As Object, e As EventArgs) Handles diario.CheckedChanged
        FormasDePago = 30
        ToolStripButton1_Click(e, e)
    End Sub

    Private Sub Mes_CheckedChanged(sender As Object, e As EventArgs) Handles mes.CheckedChanged
        FormasDePago = 1
        ToolStripButton1_Click(e, e)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        pagar.Text = ((((Val(txtmonto.Text) + ((Val(txtmonto.Text) * (+Val(interes.Text))) / 100))) / FormasDePago) / Val(duracion.Text))
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        txtmonto.Text = ""
        interes.Text = 1
        duracion.Value = 1
    End Sub

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Te recordamos que solo puede digitar números.")
        End If
    End Sub

    Private Sub CortarToolStripButton_Click(sender As Object, e As EventArgs) Handles CortarToolStripButton.Click
        Me.Close()
    End Sub

    Private Sub Inversiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripButton1.Visible = False
    End Sub
End Class