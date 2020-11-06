Imports Npgsql

Public Class PersistenciaPersona
    Dim conexion As Npgsql.NpgsqlConnection
    Public Sub Altapersona(personita As Persona)
        Try
            Dim classcnn = New ConexionPostgres
            conexion = classcnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenadecomandos As String
            cadenadecomandos = "insert into persona(cedulapersona, nombreyapellido, direccion) values (@ci, @nombre, @direccion);"
            cmd.CommandText = cadenadecomandos

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personita.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personita.Direccion

            Dim Resultado As Integer

            Resultado = cmd.ExecuteNonQuery

            If Resultado = 1 Then
                Dim i = 0
                While i < personita.ListaTelefono.Count
                    cadenadecomandos = "insert into telefono (ci, telefono) values (@ci, @telefono);"
                    cmd.CommandText = cadenadecomandos

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = personita.ListaTelefono.Item(i)

                    Resultado = cmd.ExecuteNonQuery()
                    i = i + 1
                End While
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()

        End Try

    Public Function Listarpersonas() As List(Of Persona)
        Try
            Dim listaPersonas As List(Of Persona)

            Dim conexionbd As New ConexionPostgres

            conexion = conexionbd.AbrirConexion()
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenaDeComandos = "SELECT * FROM PERSONA"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()

                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try

    End Function


    Public Sub ModificarPersona(Personita As Persona)
        Try
            Dim cadenadecomandos
            Dim Resultado As Integer
            Dim classcnn = New ConexionPostgres
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            cadenadecomandos = "delete from telefono where ci = @ci"
            cmd.CommandText = cadenadecomandos

            cadenadecomandos = "update persona set nombre=@nombre, direccion = @direccion where ci = @ci"
            cmd.CommandText = cadenadecomandos

            Resultado = cmd.ExecuteNonQuery
            If Resultado = 1 Then
                Dim i = 0
                While i < Personita.ListaTelefono.Count
                    cadenadecomandos = "insert into telefono (ci, telefono) values (@ci, @telefono);"
                    cmd.CommandText = cadenadecomandos

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = Personita.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = Personita.ListaTelefono.Item(i)

                    Resultado = cmd.ExecuteNonQuery()
                    i = i + 1
                End While
            End If

        Catch ex As Exception

        End Try

    End Sub


    Public Function BuscarPersona(ci As Integer) As Persona
        Dim personaBuscada As New Persona
        Try

            Dim claseConexion As New ConexionPostgres

            conexion = claseConexion.AbrirConexion
            Dim cmd As New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim cadenaDeComandos = "Select * from persona where ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                Lector.Read()

                personaBuscada.Ci = Convert.ToInt32(Lector(0).ToString)
                personaBuscada.Nombre = Lector(1).ToString
                personaBuscada.Direccion = Lector(2).ToString
            End If

        Catch ex As Exception

        End Try

        Return personaBuscada

    End Function
End Class
