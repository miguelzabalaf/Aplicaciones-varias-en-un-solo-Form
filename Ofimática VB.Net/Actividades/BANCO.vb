Public Class BANCO
    Dim dia As Integer = 1
    Dim caja As Double = 0
    Dim totalegresos As Double = 0
    Dim mayorgasto As Double = 0
    Dim menorgasto As Double = 5000000
    Dim dmayor As String
    Dim dmenor As String

    Private Sub txtegreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtegreso.KeyPress
        If Asc(e.KeyChar) = 13 Then
            totalegresos = totalegresos + Val(txtegreso.Text)
            caja = 700000 + (caja - Val(txtegreso.Text))
            If Val(txtegreso.Text) > mayorgasto Then
                dmayor = lbldia.Text
                mayorgasto = Val(txtegreso.Text)
            End If
            If Val(txtegreso.Text) < menorgasto Then
                dmenor = lbldia.Text
                menorgasto = Val(txtegreso.Text)
            End If
            dia = dia + 1
            txtegreso.Clear()
        End If
        Select Case dia
            Case 2 : lbldia.Text = "MARTES"
            Case 3 : lbldia.Text = "MIERCOLES"
            Case 4 : lbldia.Text = "JUEVES"
            Case 5 : lbldia.Text = "VIERNES"
            Case 6 : lbldia.Text = "SABADO"
            Case 7 : lbldia.Text = "DOMINGO"
            Case 8 : MsgBox("Cierre de la SEMANA", MsgBoxStyle.Information, "BLANCO S.A.")
                Me.Height = 292
                lblpromedio.Text = FormatCurrency(totalegresos / 7)
                lbltotalgastos.Text = FormatCurrency(totalegresos, 0)
                lblsaldo.Text = FormatCurrency(caja)
                lblmayorgasto.Text = dmayor
                lblmenorgasto.Text = dmenor
                lbldia.Text = Nothing
                txtegreso.Visible = False
        End Select


    End Sub

    Private Sub From1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldia.Text = "LUNES"
    End Sub
End Class