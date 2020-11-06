Public Class persistenciaTelefono

    Dim listaTelefono As New List(Of Integer)
    Dim conection = New Npgsql.NpgsqlConnection

    Public Sub AgregarTelefono(ci As Integer, telefono As Integer)
        Try
            Dim clasCnn = New conection
            Dim resultado As Integer
            conection = clasCnn.abrirConexion()
            Dim cadenaDeComandos As String
            Dim cmd As New Npgsql.NpgsqlConnection()
            cademaDeComandos = "insert into telefono(cip,telefono) values (@cip, @telefono);"
            cmd.CommandText = cadenaDeComandos
            cmd.Connection = conection
            cmd.CommandText = cadenaDeComandos
            cmd.Parametrers.Add("@cip", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parametrers.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono

            resultado = cmd.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        Finally
            conection.close()
        End Try
    End Sub

    Public Function TraerTelefono(ci As Integer)
        Dim clasCnn As New conexion
        Dim cadenaDeComandos As String

        Dim reader As Npgsql.NpgsqlDataReader
        conection = clasCnn.abrirConexion()
        Dim cmd As New Npgsql.NpgsqlCommand()

        cmd.Connection = conection

        cadenaDeComandos = "select * from telefono where ci=@ci;"
        cmd.CommandText = cadenaDeComandos
        cmd.Parametrers.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
        reader = cmd.ExecuteReader

        Return reader

    End Function

    Public 

End Class
