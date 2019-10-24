Public Class VentaDVD
    Private Sub VentaDVD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        marca.Items.Add("3M")
        marca.Items.Add("SAMSUNG")
        marca.Items.Add("NCR")
        marca.Items.Add("IMATION")
        marca.Items.Add("RIDEX")
        marca.Items.Add("SONY")
        marca.Items.Add("TDK")
    End Sub
    Private Sub Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles marca.SelectedIndexChanged
        Static unidad As Integer
        unidad = valor.Text

        Dim desc As Decimal
        desc = 0.1


        Select Case marca.SelectedIndex
            Case 0
                descuento.Text = CStr(10) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.1)) * cantidad.Value
                sale.Text = (unidad * 0.1) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 1
                descuento.Text = CStr(12) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.12)) * cantidad.Value
                sale.Text = (unidad * 0.12) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 2
                descuento.Text = CStr(15) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.15)) * cantidad.Value
                sale.Text = (unidad * 0.15) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 3
                descuento.Text = CStr(20) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.2)) * cantidad.Value
                sale.Text = (unidad * 0.2) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 4
                descuento.Text = CStr(25) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                desc = 0.25
                precio.Text = (unidad - (unidad * 0.25)) * cantidad.Value
                sale.Text = (unidad * 0.25) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 5
                descuento.Text = CStr(30) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                desc = 0.3
                precio.Text = (unidad - (unidad * 0.3)) * cantidad.Value
                sale.Text = (unidad * 0.3) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 6
                descuento.Text = CStr(35) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.35)) * cantidad.Value
                sale.Text = (unidad * 0.35) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
        End Select
    End Sub

    Private Sub Cantidad_ValueChanged(sender As Object, e As EventArgs) Handles cantidad.ValueChanged
        Static unidad As Integer
        unidad = valor.Text

        Dim desc As Decimal
        desc = 0.1


        Select Case marca.SelectedIndex
            Case 0
                descuento.Text = CStr(10) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.1)) * cantidad.Value
                sale.Text = (unidad * 0.1) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 1
                descuento.Text = CStr(12) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.12)) * cantidad.Value
                sale.Text = (unidad * 0.12) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 2
                descuento.Text = CStr(15) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.15)) * cantidad.Value
                sale.Text = (unidad * 0.15) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 3
                descuento.Text = CStr(20) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.2)) * cantidad.Value
                sale.Text = (unidad * 0.2) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 4
                descuento.Text = CStr(25) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                desc = 0.25
                precio.Text = (unidad - (unidad * 0.25)) * cantidad.Value
                sale.Text = (unidad * 0.25) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 5
                descuento.Text = CStr(30) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                desc = 0.3
                precio.Text = (unidad - (unidad * 0.3)) * cantidad.Value
                sale.Text = (unidad * 0.3) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
            Case 6
                descuento.Text = CStr(35) + "%"
                cantidad.Enabled = True
                info.ForeColor = Color.Red
                info.Text = "Valor a pagar:"
                precio.Text = (unidad - (unidad * 0.35)) * cantidad.Value
                sale.Text = (unidad * 0.35) * cantidad.Value
                total.Text = unidad * cantidad.Value
                valor.Enabled = True
        End Select
    End Sub

    Private Sub Valor_TextChanged(sender As Object, e As EventArgs) Handles valor.TextChanged
        If valor.Text = "" Then
            MsgBox("Ha ocurrido un error, has borrado por completo el valor del precio, vuelve a abrir la aplicación")
            Me.Close()
        Else
            Static unidad As Integer
            unidad = valor.Text

            Dim desc As Decimal
            desc = 0.1


            Select Case marca.SelectedIndex
                Case 0
                    descuento.Text = CStr(10) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    precio.Text = (unidad - (unidad * 0.1)) * cantidad.Value
                    sale.Text = (unidad * 0.1) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
                Case 1
                    descuento.Text = CStr(12) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    precio.Text = (unidad - (unidad * 0.12)) * cantidad.Value
                    sale.Text = (unidad * 0.12) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
                Case 2
                    descuento.Text = CStr(15) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    precio.Text = (unidad - (unidad * 0.15)) * cantidad.Value
                    sale.Text = (unidad * 0.15) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
                Case 3
                    descuento.Text = CStr(20) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    precio.Text = (unidad - (unidad * 0.2)) * cantidad.Value
                    sale.Text = (unidad * 0.2) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
                Case 4
                    descuento.Text = CStr(25) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    desc = 0.25
                    precio.Text = (unidad - (unidad * 0.25)) * cantidad.Value
                    sale.Text = (unidad * 0.25) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
                Case 5
                    descuento.Text = CStr(30) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    desc = 0.3
                    precio.Text = (unidad - (unidad * 0.3)) * cantidad.Value
                    sale.Text = (unidad * 0.3) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
                Case 6
                    descuento.Text = CStr(35) + "%"
                    cantidad.Enabled = True
                    info.ForeColor = Color.Red
                    info.Text = "Valor a pagar:"
                    precio.Text = (unidad - (unidad * 0.35)) * cantidad.Value
                    sale.Text = (unidad * 0.35) * cantidad.Value
                    total.Text = unidad * cantidad.Value
                    valor.Enabled = True
            End Select
        End If
    End Sub
End Class