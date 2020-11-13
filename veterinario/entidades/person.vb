Public Class person
    Private nombre As String
    Private ci As Integer
    Private direccion As String
    Private telefono As Integer

    Public Sub personas(ci As Integer, nombre As String, direccion As String, telefono As Integer)
        ci = ci
        nombre = nombre
        direccion = direccion
        telefono = telefono
    End Sub

    Public Property Ci As Integer
        Get
            Return Ci
        End Get
        Set(value As Integer)
            ci = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return telefono
        End Get
        Set(value As Integer)
            telefono = value
        End Set
    End Property

    Public Sub personas()

    End Sub


End Class
