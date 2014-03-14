Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class TipoTrabajadorRepository : Inherits MasterDataAccess : Implements ITipoTrabajadorRepository

    Public Sub DeleteTipoTrabajador(ByVal idTipoTrabajador As Integer, ByVal idCategoria As Integer) Implements ITipoTrabajadorRepository.DeleteTipoTrabajador

    End Sub

    Public Function GetAllFromTipoTrabajador() As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorRepository.GetAllFromTipoTrabajador
        Dim listaTipotrabajador As New List(Of TipoTrabajador)
        Return listaTipotrabajador
    End Function

    Public Function GetTipoTrabajadorByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorRepository.GetTipoTrabajadorByIdCategoria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTrabajadorByIdCategoriaRrhh")
        command.Parameters.AddWithValue("idCategoriaRrhh", idCategoria)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTipoTrabajadorByIdCategoriaYDisponibles(ByVal idCategoria As Integer, ByVal disponible As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorRepository.GetTipoTrabajadorByIdCategoriaYDisponibles
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTrabajadorByIdCategoriaYDisponible")
        command.Parameters.AddWithValue("idCategoriaRrhh", idCategoria)
        command.Parameters.AddWithValue("Disponible", disponible)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTipoTrabajadorByIdTipoTrabajadorIdCategoria(ByVal idTipoTrabajador As Integer, ByVal idCategoria As Integer) As BussinessEntities.TipoTrabajador Implements ITipoTrabajadorRepository.GetTipoTrabajadorByIdTipoTrabajadorIdCategoria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTrabajadorByIdCategoriaRrhhByIdTipoTrabajador")
        command.Parameters.AddWithValue("idCategoriaRrhh", idCategoria)
        command.Parameters.AddWithValue("idTipoTrabajador", idTipoTrabajador)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetTipoTrabajadorByDisponible(ByVal Disponible As Boolean) As System.Collections.Generic.List(Of BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorRepository.GetTipoTrabajadorByDisponible
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoTrabajadorByDisponible")
        command.Parameters.AddWithValue("Disponible", Disponible)
        Return SelectObjectFactory2(command)
    End Function

    Public Sub SaveTipoTrabajador(ByVal tipoTrabajador As BussinessEntities.TipoTrabajador) Implements ITipoTrabajadorRepository.SaveTipoTrabajador

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoTrabajador)
        Dim lista As New List(Of TipoTrabajador)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New TipoTrabajador

                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripción")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripción"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Disponible")) Then
                    entity.Disponible = reader.GetValue(reader.GetOrdinal("Disponible"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTrabajador")) Then
                    entity.IdTipoTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoTrabajador"))
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand) As List(Of TipoTrabajador)
        Dim lista As New List(Of TipoTrabajador)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New TipoTrabajador

                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripción")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripción"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Disponible")) Then
                    entity.Disponible = reader.GetValue(reader.GetOrdinal("Disponible"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoTrabajador")) Then
                    entity.IdTipoTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoTrabajador"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdCategoria")) Then
                    entity.IdCategoria = reader.GetValue(reader.GetOrdinal("IdCategoria"))
                    'Dim categoriaRrhhRepository As New CategoriaRrhhRepository
                    'Dim categoriaRrhh As New CategoriaRrhh
                    'categoriaRrhh = categoriaRrhhRepository.GetCategoriaRrhhByIdCategoria(entity.IdCategoria)
                    'entity.categoriaRrhh = categoriaRrhh
                End If
                    lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
End Class
