Public Class LogicaPersona
    Public Sub altapersona(personita As AltaPersona)
        Dim persistencia_ As New PersistenciaPersona
        persistencia_.Altapersona(personita)
    End Sub
    Public Function buscarPersona(ci As Integer) As AltaPersona
        Dim persistencia_ As New PersistenciaPersona
        Return persistencia_.Buscarpersona(ci)

    End Function

End Class
