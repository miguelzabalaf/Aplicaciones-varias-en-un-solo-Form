<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Votos_ADSI
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
        Me.components = New System.ComponentModel.Container()
        Me.vJ = New System.Windows.Forms.Button()
        Me.vM = New System.Windows.Forms.Button()
        Me.vD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nEstudiantes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vB = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VJUAN = New System.Windows.Forms.Label()
        Me.VMIGUEL = New System.Windows.Forms.Label()
        Me.VDIANA = New System.Windows.Forms.Label()
        Me.VBLANCO = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.votos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ganador = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'vJ
        '
        Me.vJ.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.vJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vJ.ForeColor = System.Drawing.Color.Black
        Me.vJ.Location = New System.Drawing.Point(12, 44)
        Me.vJ.Name = "vJ"
        Me.vJ.Size = New System.Drawing.Size(115, 60)
        Me.vJ.TabIndex = 0
        Me.vJ.Text = "JUAN"
        Me.vJ.UseVisualStyleBackColor = False
        '
        'vM
        '
        Me.vM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.vM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vM.ForeColor = System.Drawing.Color.Black
        Me.vM.Location = New System.Drawing.Point(133, 44)
        Me.vM.Name = "vM"
        Me.vM.Size = New System.Drawing.Size(115, 60)
        Me.vM.TabIndex = 1
        Me.vM.Text = "MIGUEL"
        Me.vM.UseVisualStyleBackColor = False
        '
        'vD
        '
        Me.vD.BackColor = System.Drawing.Color.Silver
        Me.vD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vD.ForeColor = System.Drawing.Color.Black
        Me.vD.Location = New System.Drawing.Point(254, 44)
        Me.vD.Name = "vD"
        Me.vD.Size = New System.Drawing.Size(115, 60)
        Me.vD.TabIndex = 2
        Me.vD.Text = "YUDEX"
        Me.vD.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Número de Estudiantes:"
        '
        'nEstudiantes
        '
        Me.nEstudiantes.Location = New System.Drawing.Point(135, 12)
        Me.nEstudiantes.Name = "nEstudiantes"
        Me.nEstudiantes.Size = New System.Drawing.Size(35, 20)
        Me.nEstudiantes.TabIndex = 4
        Me.nEstudiantes.Text = "30"
        Me.nEstudiantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(303, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Máximo de estudiantes posibles:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(468, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "30"
        '
        'vB
        '
        Me.vB.BackColor = System.Drawing.Color.White
        Me.vB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vB.ForeColor = System.Drawing.Color.Black
        Me.vB.Location = New System.Drawing.Point(375, 44)
        Me.vB.Name = "vB"
        Me.vB.Size = New System.Drawing.Size(115, 60)
        Me.vB.TabIndex = 7
        Me.vB.Text = "BLANCO"
        Me.vB.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(21, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "VOTOS A FAVOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(144, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "VOTOS A FAVOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(263, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "VOTOS A FAVOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(384, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "VOTOS A FAVOR"
        '
        'VJUAN
        '
        Me.VJUAN.AutoSize = True
        Me.VJUAN.BackColor = System.Drawing.SystemColors.Control
        Me.VJUAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VJUAN.Location = New System.Drawing.Point(60, 251)
        Me.VJUAN.Name = "VJUAN"
        Me.VJUAN.Size = New System.Drawing.Size(16, 16)
        Me.VJUAN.TabIndex = 12
        Me.VJUAN.Text = "0"
        Me.VJUAN.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VMIGUEL
        '
        Me.VMIGUEL.AutoSize = True
        Me.VMIGUEL.BackColor = System.Drawing.SystemColors.Control
        Me.VMIGUEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VMIGUEL.Location = New System.Drawing.Point(183, 251)
        Me.VMIGUEL.Name = "VMIGUEL"
        Me.VMIGUEL.Size = New System.Drawing.Size(16, 16)
        Me.VMIGUEL.TabIndex = 13
        Me.VMIGUEL.Text = "0"
        Me.VMIGUEL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VDIANA
        '
        Me.VDIANA.AutoSize = True
        Me.VDIANA.BackColor = System.Drawing.SystemColors.Control
        Me.VDIANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VDIANA.Location = New System.Drawing.Point(301, 251)
        Me.VDIANA.Name = "VDIANA"
        Me.VDIANA.Size = New System.Drawing.Size(16, 16)
        Me.VDIANA.TabIndex = 14
        Me.VDIANA.Text = "0"
        Me.VDIANA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VBLANCO
        '
        Me.VBLANCO.AutoSize = True
        Me.VBLANCO.BackColor = System.Drawing.SystemColors.Control
        Me.VBLANCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VBLANCO.Location = New System.Drawing.Point(423, 251)
        Me.VBLANCO.Name = "VBLANCO"
        Me.VBLANCO.Size = New System.Drawing.Size(16, 16)
        Me.VBLANCO.TabIndex = 15
        Me.VBLANCO.Text = "0"
        Me.VBLANCO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'votos
        '
        Me.votos.Enabled = False
        Me.votos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.votos.Location = New System.Drawing.Point(110, 128)
        Me.votos.Name = "votos"
        Me.votos.Size = New System.Drawing.Size(35, 20)
        Me.votos.TabIndex = 17
        Me.votos.Text = "0"
        Me.votos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(12, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Votos Realizados:"
        '
        'Timer2
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(130, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "EL GANADOR HA SIDO:"
        '
        'ganador
        '
        Me.ganador.Enabled = False
        Me.ganador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ganador.Location = New System.Drawing.Point(259, 283)
        Me.ganador.Name = "ganador"
        Me.ganador.Size = New System.Drawing.Size(146, 20)
        Me.ganador.TabIndex = 19
        Me.ganador.Text = "NONE"
        Me.ganador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(406, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 34)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(180, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 34)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "MOSTRAR RESULTADOS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Votos_ADSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 162)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ganador)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.votos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.VBLANCO)
        Me.Controls.Add(Me.VDIANA)
        Me.Controls.Add(Me.VMIGUEL)
        Me.Controls.Add(Me.VJUAN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.vB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nEstudiantes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vD)
        Me.Controls.Add(Me.vM)
        Me.Controls.Add(Me.vJ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Votos_ADSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONITOR ADSI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vJ As Button
    Friend WithEvents vM As Button
    Friend WithEvents vD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nEstudiantes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents vB As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VJUAN As Label
    Friend WithEvents VMIGUEL As Label
    Friend WithEvents VDIANA As Label
    Friend WithEvents VBLANCO As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents votos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents ganador As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
