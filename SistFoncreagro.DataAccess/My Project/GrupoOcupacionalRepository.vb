Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class GrupoOcupacionalRepository : Inherits MasterDataAccess : Implements IGrupoOcupacionalRepository

    Public Function GetAllFromGrupoOcupacional() As System.Collections.Generic.List(Of BussinessEntities.GrupoOcupacional) Implements IGrupoOcupacionalRepository.GetAllFromGrupoOcupacional
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromGrupoOcupacional")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetGrupoOcupacionalByDisponible() As System.Collections.Generic.List(Of BussinessEntities.GrupoOcupacional) Implements IGrupoOcupacionalRepository.GetGrupoOcupacionalByDisponible
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetGrupoOcupacionalByDisponible")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetGrupoOcupacionalByIdGrupoOcupacional(ByVal IdGrupoOcupacinal As Integer) As BussinessEntities.GrupoOcupacional Implements IGrupoOcupacionalRepository.GetGrupoOcupacionalByIdGrupoOcupacional
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetGrupoOcupacionalByIdGrupoOcupacional")
        command.Parameters.AddWithValue("IdGrupoOcupacional", IdGrupoOcupacinal)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of GrupoOcupacional)
        Dim lista As New List(Of GrupoOcupacional)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New GrupoOcupacional
                If Not reader.IsDBNull(reader.GetOrdinal("IdGrupoOcupacional")) Then
                    entity.IdGrupoOcupacional = reader.GetValue(reader.GetOrdinal("IdGrupoOcupacional"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodigoNO")) Then
                    entity.CodigoNO = reader.GetValue(reader.GetOrdinal("CodigoNO"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Disponible")) Then
                    entity.Disponible = reader.GetValue(reader.GetOrdinal("Disponible"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
