<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaMascota
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
        Me.mascotaText = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.nacimientoTextBox = New System.Windows.Forms.TextBox()
        Me.idText = New System.Windows.Forms.Label()
        Me.nombreMText = New System.Windows.Forms.Label()
        Me.nacimientoText = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mascotaText
        '
        Me.mascotaText.AutoSize = True
        Me.mascotaText.Font = New System.Drawing.Font("Corbel", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mascotaText.Location = New System.Drawing.Point(209, 86)
        Me.mascotaText.Name = "mascotaText"
        Me.mascotaText.Size = New System.Drawing.Size(141, 42)
        Me.mascotaText.TabIndex = 0
        Me.mascotaText.Text = "Mascota"
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(257, 167)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(107, 20)
        Me.idTextBox.TabIndex = 1
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(257, 219)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(107, 20)
        Me.nombreTextBox.TabIndex = 2
        '
        'nacimientoTextBox
        '
        Me.nacimientoTextBox.Location = New System.Drawing.Point(257, 268)
        Me.nacimientoTextBox.Name = "nacimientoTextBox"
        Me.nacimientoTextBox.Size = New System.Drawing.Size(107, 20)
        Me.nacimientoTextBox.TabIndex = 3
        '
        'idText
        '
        Me.idText.AutoSize = True
        Me.idText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idText.Location = New System.Drawing.Point(226, 171)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(24, 16)
        Me.idText.TabIndex = 4
        Me.idText.Text = "ID:"
        '
        'nombreMText
        '
        Me.nombreMText.AutoSize = True
        Me.nombreMText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreMText.Location = New System.Drawing.Point(191, 219)
        Me.nombreMText.Name = "nombreMText"
        Me.nombreMText.Size = New System.Drawing.Size(60, 16)
        Me.nombreMText.TabIndex = 5
        Me.nombreMText.Text = "Nombre:"
        '
        'nacimientoText
        '
        Me.nacimientoText.AutoSize = True
        Me.nacimientoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nacimientoText.Location = New System.Drawing.Point(121, 272)
        Me.nacimientoText.Name = "nacimientoText"
        Me.nacimientoText.Size = New System.Drawing.Size(130, 16)
        Me.nacimientoText.TabIndex = 6
        Me.nacimientoText.Text = "Año de naciemiento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.veterinario.My.Resources.Resources.mascota
        Me.PictureBox1.Location = New System.Drawing.Point(391, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'mascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 367)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.nacimientoText)
        Me.Controls.Add(Me.nombreMText)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.nacimientoTextBox)
        Me.Controls.Add(Me.nombreTextBox)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.mascotaText)
        Me.Name = "mascota"
        Me.Text = "mascota"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mascotaText As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents nacimientoTextBox As TextBox
    Friend WithEvents idText As Label
    Friend WithEvents nombreMText As Label
    Friend WithEvents nacimientoText As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
