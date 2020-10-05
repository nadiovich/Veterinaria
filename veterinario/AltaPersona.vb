Public Class AltaPersona
    Public Property CI As Integer
    Public Property Nombre As String
    Public Property Direccion As String
    Public Property ListaTelefono As Object

    Private Sub cancelarPButton_Click(sender As Object, e As EventArgs) Handles cancelarPButton.Click
        inicio.Show()

    End Sub

    Private Sub aceptarPButton_Click(sender As Object, e As EventArgs) Handles aceptarPButton.Click
        Try
            Dim CI As Integer
            CI = ciTextBox.Text

            Dim Nombre As String
            Nombre = nombreTextBox.Text

            Dim Telefono As String
            Telefono = telefTextBox.Text

            Dim Direccion As String
            Direccion = direcTextBox.Text

            Dim newAltaPersona As New AltaPersona()
            newAltaPersona.CI = CI
            newAltaPersona.Nombre = Nombre
            newAltaPersona.Direccion = Direccion
            newAltaPersona.ListaTelefono = listaTelefono
            'La segunda empieza en minuscula'

            'Aca deberiamos llamar a la logica'
            Dim logica As New LogicaPersona
            logica.altapersona(newAltaPersona)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ciTextBox_TextChanged(sender As Object, e As EventArgs) Handles ciTextBox.TextChanged
        Dim cedula As Integer
        cedula = ciTextBox.Text
        Dim personaNueva As AltaPersona
        Dim logica As New LogicaPersona
        personaNueva = logica.buscarPersona(cedula)

        If IsNothing(personaNueva) Then
        Else
            nombreTextBox.Text = personaNueva.Nombre
            direcTextBox.Text = personaNueva.Direccion
        End If
    End Sub

    'Private Sub MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MToolStripMenuItem.Click
    '   inicioMascota.Show()
    'End Sub

    'Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
    '    inicio.ShowDialog()
    'End Sub

    Private Sub telefBtn_Click(sender As Object, e As EventArgs) Handles telefBtn.Click
        Dim telefono As Integer
        telefono = telefTextBox.Text

        ListaTelefono.Items.Add(telefono)
        ListaTelefono.Add(telefono)

        telefTextBox.Text = ""
    End Sub
End Class

'Private Sub ListBox1(listaTelefonos(el name))_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaTelefonos.SelectedIndexChanged
'Try
'   Dim telefonoEscritorio As String
'   Dim telefonoEliminado As Integer
'   telefonoEscritorio = ListBox1(listaTelefonos -> nombre del coso).SelectedItems(0).SubItems(0).Text
'   telefonoEliminado = Convert.ToInt32(telefonoEscritorio)

'   Dim iterador As Integer = 0
'   While iterador < ListBox1.Count
'       If telefonoEliminado = listaTelefono.Item(iterador) Then
'           listaTelefono.Remove(telefonoEliminado)
'           iterador = listaTelefono.Count
'       End If
'       iterador = iterador + 1
'   End While
'   listaTelefonos.Clear()
'   iterador = 0
'   While iterador < listaTelefono.Count
'       listaTelefonos.Items.Add(listaTelefono.Item(iterador))
'       iterador = iterador + 1
'   End While

'Catch ex As Exception

'   MsgBox("tuviste alto error " + ex.Message)

'End Try
'End Sub
'End Class xd