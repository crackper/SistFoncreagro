Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SituacionEspecialRepository : Inherits MasterDataAccess : Implements ISituacionEspecialRepository

    Public Function GetAllSituacionEspecial() As System.Collections.Generic.List(Of BussinessEntities.SituacionEspecial) Implements ISituacionEspecialRepository.GetAllSituacionEspecial
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromSITUACIONESPECIAL")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetSituacionEspecialByIdSituacionespecial(ByVal idSituacionEspecial As Integer) As BussinessEntities.SituacionEspecial Implements ISituacionEspecialRepository.GetSituacionEspecialByIdSituacionespecial
        Return New SituacionEspecial
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of SituacionEspecial)
        Dim lista As New List(Of SituacionEspecial)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New SituacionEspecial

                If Not reader.IsDBNull(reader.GetOrdinal("IdSituacionEspecial")) Then
                    entity.IdSituacionEspecial = reader.GetValue(reader.GetOrdinal("IdSituacionEspecial"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
End Class
