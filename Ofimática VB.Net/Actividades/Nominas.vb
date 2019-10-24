Public Class Nominas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCargo.Items.Add("Gerente")
        cboCargo.Items.Add("Administrador")
        cboCargo.Items.Add("Contador")
    End Sub

    Private Sub CboCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCargo.SelectedIndexChanged
        Select Case cboCargo.SelectedIndex
            Case 0
                txtSueldo.Text = CStr(1600000)
            Case 1
                txtSueldo.Text = CStr(1200000)
            Case 2
                txtSueldo.Text = CStr(900000)
        End Select

        Dim Mensaje, Titulo, Rpta As String
        Mensaje = "¿Solicitará Adelanto?"
        Titulo = "Adelanto del Empleado"
        Rpta = CStr(MsgBox(Mensaje, MsgBoxStyle.YesNo, Titulo))
        If Val(Rpta) = vbYes Then
            MsgBox("tu Respuesta fue 'Si'")
            txtAdelanto.Enabled = True
            txtAdelanto.Focus()
        Else
            MsgBox("tu Respuesta fue 'No'")
            txtAdelanto.Enabled = False
            txtBonificacion.Focus()
        End If


    End Sub

    Private Sub TxtAdelanto_TextChanged(sender As Object, e As EventArgs) Handles txtAdelanto.TextChanged
        Dim Maxsueldo As Double
        Maxsueldo = Val(txtSueldo.Text) * 0.25
        If Val(txtAdelanto.Text) > Maxsueldo Then
            MsgBox("el adelanto no es permitido…")
            txtAdelanto.Text = ""
            txtAdelanto.Focus()
        End If
    End Sub

    Private Sub Chkfonavi_Click(sender As Object, e As EventArgs) Handles Chkfonavi.Click
        If Chkfonavi.Checked = True Then ' Si esta chequeado Fonavi realiza el calculo
            txtFonavi.Text = CStr(Val(txtHonorarios.Text) * 0.07)
        Else
            txtFonavi.Text = CStr(0)
        End If
    End Sub

    Private Sub Chkrenta_Click(sender As Object, e As EventArgs) Handles Chkrenta.Click
        If Chkrenta.Checked = True Then
            txtRenta.Text = CStr(Val(txtHonorarios.Text) * 0.1)
        Else
            txtRenta.Text = CStr(0)
        End If

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = "" : txtApellidos.Text = ""
        txtNombres.Text = "" : txtSueldo.Text = ""
        txtAdelanto.Text = "" : txtBonificacion.Text = ""
        txtHonorarios.Text = "" : txtFonavi.Text = ""
        txtRenta.Text = "" : txtNeto.Text = ""
        cboCargo.Text = ""
        RbtnCatA1.Checked = False : RbtnCatA2.Checked = False
        RbtnCatA3.Checked = False : Chkfonavi.Checked = False
        Chkrenta.Checked = False : txtCodigo.Focus()

    End Sub

    Private Sub RbtnCatA1_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCatA1.CheckedChanged
        txtBonificacion.Text = CStr(Val(txtSueldo.Text) * 0.1)
    End Sub

    Private Sub RbtnCatA2_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCatA2.CheckedChanged
        txtBonificacion.Text = CStr(Val(txtSueldo.Text) * 0.15)
    End Sub

    Private Sub RbtnCatA3_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCatA3.CheckedChanged
        txtBonificacion.Text = CStr(Val(txtSueldo.Text) * 0.2)
    End Sub

    Private Sub TxtBonificacion_TextChanged(sender As Object, e As EventArgs) Handles txtBonificacion.TextChanged
        txtHonorarios.Text = CStr(Val(txtSueldo.Text) + Val(txtBonificacion.Text))
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim desc As Double
        desc = Val(txtAdelanto.Text) + Val(txtFonavi.Text) + Val(txtRenta.Text)
        txtNeto.Text = CStr(Val(txtHonorarios.Text) - desc)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class