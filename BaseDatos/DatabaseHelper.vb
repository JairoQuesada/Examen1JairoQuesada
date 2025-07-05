Imports System.Data.SqlClient

Public Class DatabaseHelper
    Private ReadOnly connectionString As String = ConfigurationManager.ConnectionStrings("conexionDB").ConnectionString
    Public Function CreateCliente(Cliente As Cliente) As String
        Try

            Dim query As String = "INSERT INTO Clientes (Nombre, Apellidos, Email, Telefono) 
            VALUES (@Nombre, @Apellidos, @Email, @Telefono)"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Nombre", Cliente.Nombre),
                New SqlParameter("@Apellidos", Cliente.Apellidos),
                New SqlParameter("@Email", Cliente.Email),
                New SqlParameter("@Telefono", Cliente.Telefono)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Cliente creado exitosamente."
        Catch ex As Exception
            Return "Error al crear el cliente: " & ex.Message
        End Try
    End Function

    Public Function EliminarCliente(id As Integer) As String

        Try
            Dim query As String = "DELETE FROM Clientes WHERE ClienteId = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return "No se encontró el cliente con el ID especificado."
                    End If
                End Using
            End Using
            Return "Cliente eliminado exitosamente."
        Catch ex As Exception
            Return "Error al eliminar el cliente: " & ex.Message
        End Try
    End Function

    Friend Function UpdateCliente(id As String, cliente As Cliente) As String
        Try
            Dim query As String = "UPDATE Clientes SET Nombre = @Nombre,
                                    Apellidos = @Apellidos, Email = @Email, Telefono = @Telefono WHERE EmpleadoID = @Id"
            Dim parameters As New List(Of SqlParameter) From {
                New SqlParameter("@Id", id),
                New SqlParameter("@Nombre", cliente.Nombre),
                New SqlParameter("@Apellidos", cliente.Apellidos),
                New SqlParameter("@Email", cliente.Email),
                New SqlParameter("@Telefono", cliente.Telefono)
            }
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return "Cliente actualizado exitosamente."
        Catch ex As Exception
            Return "Error al actualizar el cliente: " & ex.Message
        End Try
    End Function
End Class
