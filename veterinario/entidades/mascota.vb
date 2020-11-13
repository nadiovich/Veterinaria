Public Class mascota
    Private nombre_ As String
    Private dueño_ As person
    Private añonacimiento_ As Integer
    Private id_ As Integer

    Public Property nombre As String
        Get
            Return nombre_
        End Get
        Set(value As String)
            nombre_ = value
        End Set
    End Property

    Public Property Dueño As person
        Get
            Return dueño_
        End Get
        Set(value As person)
            dueño_ = value
        End Set
    End Property

    Public Property añonacimiento As Integer
        Get
            Return añonacimiento_
        End Get
        Set(value As Integer)
            añonacimiento_ = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return id_
        End Get
        Set(value As Integer)
            id_ = value
        End Set
    End Property

    Public Sub mascotas()

    End Sub

    Public Sub mascotas(_nombre, _dueño, _añonacimiento, _id)
        nombre = _nombre
        Dueño = _dueño
        añonacimiento = _añonacimiento
        Id = id
    End Sub
End Class
