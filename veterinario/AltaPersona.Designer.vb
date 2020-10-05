<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPersona
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
        Me.personaText = New System.Windows.Forms.Label()
        Me.ciText = New System.Windows.Forms.Label()
        Me.nombrePText = New System.Windows.Forms.Label()
        Me.telefonoText = New System.Windows.Forms.Label()
        Me.direcText = New System.Windows.Forms.Label()
        Me.ciTextBox = New System.Windows.Forms.TextBox()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.telefTextBox = New System.Windows.Forms.TextBox()
        Me.direcTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cancelarPButton = New System.Windows.Forms.Button()
        Me.aceptarPButton = New System.Windows.Forms.Button()
        Me.telefBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personaText
        '
        Me.personaText.AutoSize = True
        Me.personaText.Font = New System.Drawing.Font("Corbel", 26.25!)
        Me.personaText.Location = New System.Drawing.Point(202, 62)
        Me.personaText.Name = "personaText"
        Me.personaText.Size = New System.Drawing.Size(133, 42)
        Me.personaText.TabIndex = 0
        Me.personaText.Text = "Persona"
        '
        'ciText
        '
        Me.ciText.AutoSize = True
        Me.ciText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ciText.Location = New System.Drawing.Point(207, 135)
        Me.ciText.Name = "ciText"
        Me.ciText.Size = New System.Drawing.Size(29, 16)
        Me.ciText.TabIndex = 1
        Me.ciText.Text = "C.I.:"
        '
        'nombrePText
        '
        Me.nombrePText.AutoSize = True
        Me.nombrePText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.nombrePText.Location = New System.Drawing.Point(176, 168)
        Me.nombrePText.Name = "nombrePText"
        Me.nombrePText.Size = New System.Drawing.Size(60, 16)
        Me.nombrePText.TabIndex = 2
        Me.nombrePText.Text = "Nombre:"
        '
        'telefonoText
        '
        Me.telefonoText.AutoSize = True
        Me.telefonoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.telefonoText.Location = New System.Drawing.Point(171, 207)
        Me.telefonoText.Name = "telefonoText"
        Me.telefonoText.Size = New System.Drawing.Size(65, 16)
        Me.telefonoText.TabIndex = 3
        Me.telefonoText.Text = "Teléfono:"
        '
        'direcText
        '
        Me.direcText.AutoSize = True
        Me.direcText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.direcText.Location = New System.Drawing.Point(168, 246)
        Me.direcText.Name = "direcText"
        Me.direcText.Size = New System.Drawing.Size(68, 16)
        Me.direcText.TabIndex = 4
        Me.direcText.Text = "Dirección:"
        '
        'ciTextBox
        '
        Me.ciTextBox.Location = New System.Drawing.Point(249, 131)
        Me.ciTextBox.Name = "ciTextBox"
        Me.ciTextBox.Size = New System.Drawing.Size(107, 20)
        Me.ciTextBox.TabIndex = 6
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(249, 167)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(107, 20)
        Me.nombreTextBox.TabIndex = 7
        '
        'telefTextBox
        '
        Me.telefTextBox.Location = New System.Drawing.Point(249, 206)
        Me.telefTextBox.Name = "telefTextBox"
        Me.telefTextBox.Size = New System.Drawing.Size(107, 20)
        Me.telefTextBox.TabIndex = 8
        Me.telefTextBox.Text = "jhadsg"
        '
        'direcTextBox
        '
        Me.direcTextBox.Location = New System.Drawing.Point(249, 245)
        Me.direcTextBox.Name = "direcTextBox"
        Me.direcTextBox.Size = New System.Drawing.Size(107, 20)
        Me.direcTextBox.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.veterinario.My.Resources.Resources.persona
        Me.PictureBox1.Location = New System.Drawing.Point(392, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'cancelarPButton
        '
        Me.cancelarPButton.Location = New System.Drawing.Point(41, 306)
        Me.cancelarPButton.Name = "cancelarPButton"
        Me.cancelarPButton.Size = New System.Drawing.Size(93, 23)
        Me.cancelarPButton.TabIndex = 10
        Me.cancelarPButton.Text = "Cancelar"
        Me.cancelarPButton.UseVisualStyleBackColor = True
        '
        'aceptarPButton
        '
        Me.aceptarPButton.Location = New System.Drawing.Point(402, 306)
        Me.aceptarPButton.Name = "aceptarPButton"
        Me.aceptarPButton.Size = New System.Drawing.Size(90, 23)
        Me.aceptarPButton.TabIndex = 11
        Me.aceptarPButton.Text = "Aceptar"
        Me.aceptarPButton.UseVisualStyleBackColor = True
        '
        'telefBtn
        '
        Me.telefBtn.Location = New System.Drawing.Point(362, 206)
        Me.telefBtn.Name = "telefBtn"
        Me.telefBtn.Size = New System.Drawing.Size(30, 23)
        Me.telefBtn.TabIndex = 12
        Me.telefBtn.Text = "+"
        Me.telefBtn.UseVisualStyleBackColor = True
        '
        'AltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 367)
        Me.Controls.Add(Me.telefBtn)
        Me.Controls.Add(Me.aceptarPButton)
        Me.Controls.Add(Me.cancelarPButton)
        Me.Controls.Add(Me.direcTextBox)
        Me.Controls.Add(Me.telefTextBox)
        Me.Controls.Add(Me.nombreTextBox)
        Me.Controls.Add(Me.ciTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.direcText)
        Me.Controls.Add(Me.telefonoText)
        Me.Controls.Add(Me.nombrePText)
        Me.Controls.Add(Me.ciText)
        Me.Controls.Add(Me.personaText)
        Me.Name = "AltaPersona"
        Me.Text = "persona"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents personaText As Label
    Friend WithEvents ciText As Label
    Friend WithEvents nombrePText As Label
    Friend WithEvents telefonoText As Label
    Friend WithEvents direcText As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ciTextBox As TextBox
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents telefTextBox As TextBox
    Friend WithEvents direcTextBox As TextBox
    Friend WithEvents cancelarPButton As Button
    Friend WithEvents aceptarPButton As Button
    Friend WithEvents telefBtn As Button
End Class
