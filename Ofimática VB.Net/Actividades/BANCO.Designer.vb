<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BANCO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldia = New System.Windows.Forms.Label()
        Me.lbltotalgastos = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.lblmayorgasto = New System.Windows.Forms.Label()
        Me.lblmenorgasto = New System.Windows.Forms.Label()
        Me.lblpromedio = New System.Windows.Forms.Label()
        Me.txtegreso = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Día del Gasto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor del Gasto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(71, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Presione Enter Para Registrar Datos.."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Gastos de la Semana:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Saldo en Caja:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(69, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "El mayor Gasto fue el día:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "El Menor Gasto fue el día:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Promedio de Gastos:"
        '
        'lbldia
        '
        Me.lbldia.AutoSize = True
        Me.lbldia.Location = New System.Drawing.Point(198, 11)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(39, 13)
        Me.lbldia.TabIndex = 8
        Me.lbldia.Text = "Label9"
        '
        'lbltotalgastos
        '
        Me.lbltotalgastos.AutoSize = True
        Me.lbltotalgastos.Location = New System.Drawing.Point(261, 129)
        Me.lbltotalgastos.Name = "lbltotalgastos"
        Me.lbltotalgastos.Size = New System.Drawing.Size(39, 13)
        Me.lbltotalgastos.TabIndex = 9
        Me.lbltotalgastos.Text = "Label9"
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Location = New System.Drawing.Point(261, 156)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(39, 13)
        Me.lblsaldo.TabIndex = 10
        Me.lblsaldo.Text = "Label9"
        '
        'lblmayorgasto
        '
        Me.lblmayorgasto.AutoSize = True
        Me.lblmayorgasto.Location = New System.Drawing.Point(261, 185)
        Me.lblmayorgasto.Name = "lblmayorgasto"
        Me.lblmayorgasto.Size = New System.Drawing.Size(39, 13)
        Me.lblmayorgasto.TabIndex = 11
        Me.lblmayorgasto.Text = "Label9"
        '
        'lblmenorgasto
        '
        Me.lblmenorgasto.AutoSize = True
        Me.lblmenorgasto.Location = New System.Drawing.Point(261, 213)
        Me.lblmenorgasto.Name = "lblmenorgasto"
        Me.lblmenorgasto.Size = New System.Drawing.Size(39, 13)
        Me.lblmenorgasto.TabIndex = 12
        Me.lblmenorgasto.Text = "Label9"
        '
        'lblpromedio
        '
        Me.lblpromedio.AutoSize = True
        Me.lblpromedio.Location = New System.Drawing.Point(261, 241)
        Me.lblpromedio.Name = "lblpromedio"
        Me.lblpromedio.Size = New System.Drawing.Size(39, 13)
        Me.lblpromedio.TabIndex = 13
        Me.lblpromedio.Text = "Label9"
        '
        'txtegreso
        '
        Me.txtegreso.Location = New System.Drawing.Point(200, 34)
        Me.txtegreso.Name = "txtegreso"
        Me.txtegreso.Size = New System.Drawing.Size(100, 20)
        Me.txtegreso.TabIndex = 14
        '
        'BANCO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 115)
        Me.Controls.Add(Me.txtegreso)
        Me.Controls.Add(Me.lblpromedio)
        Me.Controls.Add(Me.lblmenorgasto)
        Me.Controls.Add(Me.lblmayorgasto)
        Me.Controls.Add(Me.lblsaldo)
        Me.Controls.Add(Me.lbltotalgastos)
        Me.Controls.Add(Me.lbldia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "BANCO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BANCO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbldia As Label
    Friend WithEvents lbltotalgastos As Label
    Friend WithEvents lblsaldo As Label
    Friend WithEvents lblmayorgasto As Label
    Friend WithEvents lblmenorgasto As Label
    Friend WithEvents lblpromedio As Label
    Friend WithEvents txtegreso As TextBox
End Class
