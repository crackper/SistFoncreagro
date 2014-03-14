Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class HabilidadesRepository : Inherits MasterDataAccess : Implements IHabilidadesRepository

    Public Function GetAllFromHABILIDADES() As System.Collections.Generic.List(Of BussinessEntities.Habilidades) Implements IHabilidadesRepository.GetAllFromHABILIDADES
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromHABILIDADES")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetHABILIDAESByIdHabilidadAndIdPosicion(ByVal IdHabilidad As Integer, ByVal IdPosicion As Integer) As BussinessEntities.Habilidades Implements IHabilidadesRepository.GetHABILIDAESByIdHabilidadAndIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetHABILIDADESByIdHabilidadAndIdPosicion")
        command.Parameters.AddWithValue("IdHabilidad", IdHabilidad)
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetHABILIDAESByIdPosicion(ByVal IdPosicion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Habilidades) Implements IHabilidadesRepository.GetHABILIDAESByIdPosicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetHABILIDADESByIdPosicion")
        command.Parameters.AddWithValue("IdPosicion", IdPosicion)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveHABILIDADES(ByVal habilidades As BussinessEntities.Habilidades) As Integer Implements IHabilidadesRepository.SaveHABILIDADES
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveHABILIDADES")
        command.Parameters.AddWithValue("IdHabilidad", habilidades.IdHabilidad)
        command.Parameters.AddWithValue("IdPosicion", habilidades.IdPosicion)
        command.Parameters.AddWithValue("Descripcion", habilidades.Descripcion)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output
        'MyBase.ExecuteNonQuery(command)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using
        Return i
        'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    End Function

    Public Sub DeleteHabilidades(ByVal idHabilidad As Integer) Implements IHabilidadesRepository.DeleteHabilidades

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Habilidades)
        Dim lista As New List(Of Habilidades)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Habilidades
                If Not reader.IsDBNull(reader.GetOrdinal("IdHabilidad")) Then
                    entity.IdHabilidad = reader.GetValue(reader.GetOrdinal("IdHabilidad"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPosicion")) Then
                    entity.IdPosicion = reader.GetValue(reader.GetOrdinal("IdPosicion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
