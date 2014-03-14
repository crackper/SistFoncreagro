Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class NivelEducativoRepository : Inherits MasterDataAccess : Implements INivelEducativoRepository

    Public Sub DeleNivelEducativo(ByVal idNivelEducativo As Integer) Implements INivelEducativoRepository.DeleNivelEducativo

    End Sub

    Public Function GetAllFromNivelEducativo() As System.Collections.Generic.List(Of BussinessEntities.NivelEducativo) Implements INivelEducativoRepository.GetAllFromNivelEducativo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromNivelEducativo")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetNivelEducativoByIdNivelEducativo(ByVal idNivelEducativo As Integer) As BussinessEntities.NivelEducativo Implements INivelEducativoRepository.GetNivelEducativoByIdNivelEducativo
        Dim nivelEducativo As New NivelEducativo
        Return nivelEducativo
    End Function

    Public Sub SaveNivelEducativo(ByVal nivelEducativo As BussinessEntities.NivelEducativo) Implements INivelEducativoRepository.SaveNivelEducativo

    End Sub


    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of NivelEducativo)
        Dim lista As New List(Of NivelEducativo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New NivelEducativo

                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdNivelEducativo")) Then
                    entity.IdNivelEducativo = reader.GetValue(reader.GetOrdinal("IdNivelEducativo"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function


End Class
