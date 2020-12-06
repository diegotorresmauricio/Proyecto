<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXBnum = New System.Windows.Forms.TextBox()
        Me.TXBapell = New System.Windows.Forms.TextBox()
        Me.TXBdire = New System.Windows.Forms.TextBox()
        Me.TXBcat = New System.Windows.Forms.TextBox()
        Me.TXBsexo = New System.Windows.Forms.TextBox()
        Me.TXBnom = New System.Windows.Forms.TextBox()
        Me.TXBcelu = New System.Windows.Forms.TextBox()
        Me.TXBmail = New System.Windows.Forms.TextBox()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de socio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Categoría"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Celular"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mail"
        '
        'TXBnum
        '
        Me.TXBnum.Location = New System.Drawing.Point(135, 28)
        Me.TXBnum.Name = "TXBnum"
        Me.TXBnum.Size = New System.Drawing.Size(100, 20)
        Me.TXBnum.TabIndex = 9
        '
        'TXBapell
        '
        Me.TXBapell.Location = New System.Drawing.Point(135, 58)
        Me.TXBapell.Name = "TXBapell"
        Me.TXBapell.Size = New System.Drawing.Size(100, 20)
        Me.TXBapell.TabIndex = 10
        '
        'TXBdire
        '
        Me.TXBdire.Location = New System.Drawing.Point(135, 90)
        Me.TXBdire.Name = "TXBdire"
        Me.TXBdire.Size = New System.Drawing.Size(100, 20)
        Me.TXBdire.TabIndex = 11
        '
        'TXBcat
        '
        Me.TXBcat.Location = New System.Drawing.Point(135, 150)
        Me.TXBcat.Name = "TXBcat"
        Me.TXBcat.Size = New System.Drawing.Size(100, 20)
        Me.TXBcat.TabIndex = 12
        '
        'TXBsexo
        '
        Me.TXBsexo.Location = New System.Drawing.Point(399, 150)
        Me.TXBsexo.Name = "TXBsexo"
        Me.TXBsexo.Size = New System.Drawing.Size(100, 20)
        Me.TXBsexo.TabIndex = 13
        '
        'TXBnom
        '
        Me.TXBnom.Location = New System.Drawing.Point(399, 58)
        Me.TXBnom.Name = "TXBnom"
        Me.TXBnom.Size = New System.Drawing.Size(100, 20)
        Me.TXBnom.TabIndex = 14
        '
        'TXBcelu
        '
        Me.TXBcelu.Location = New System.Drawing.Point(135, 186)
        Me.TXBcelu.Name = "TXBcelu"
        Me.TXBcelu.Size = New System.Drawing.Size(100, 20)
        Me.TXBcelu.TabIndex = 15
        '
        'TXBmail
        '
        Me.TXBmail.Location = New System.Drawing.Point(399, 185)
        Me.TXBmail.Name = "TXBmail"
        Me.TXBmail.Size = New System.Drawing.Size(100, 20)
        Me.TXBmail.TabIndex = 16
        '
        'DTP1
        '
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP1.Location = New System.Drawing.Point(135, 117)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(200, 20)
        Me.DTP1.TabIndex = 17
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(35, 275)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuardar.TabIndex = 18
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(135, 275)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificar.TabIndex = 19
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(238, 275)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 20
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(333, 274)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 21
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(585, 274)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 22
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.TXBmail)
        Me.Controls.Add(Me.TXBcelu)
        Me.Controls.Add(Me.TXBnom)
        Me.Controls.Add(Me.TXBsexo)
        Me.Controls.Add(Me.TXBcat)
        Me.Controls.Add(Me.TXBdire)
        Me.Controls.Add(Me.TXBapell)
        Me.Controls.Add(Me.TXBnum)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
    Friend WithEvents Label9 As Label
    Friend WithEvents TXBnum As TextBox
    Friend WithEvents TXBapell As TextBox
    Friend WithEvents TXBdire As TextBox
    Friend WithEvents TXBcat As TextBox
    Friend WithEvents TXBsexo As TextBox
    Friend WithEvents TXBnom As TextBox
    Friend WithEvents TXBcelu As TextBox
    Friend WithEvents TXBmail As TextBox
    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonSalir As Button
End Class
