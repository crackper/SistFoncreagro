Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class TipoContratoRepository : Inherits MasterDataAccess : Implements ITipoContratoRepository


    Public Sub DeleteTipoContrato(ByVal idTipoContrato As Integer) Implements ITipoContratoRepository.DeleteTipoContrato

    End Sub

    Public Function GetAllFromTipoContrato() As System.Collections.Generic.List(Of BussinessEntities.TipoContrato) Implements ITipoContratoRepository.GetAllFromTipoContrato
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOCONTRATO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTipoContratoByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoContrato) Implements ITipoContratoRepository.GetTipoContratoByIdCategoria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoContratoByIdCategoria")
        command.Parameters.AddWithValue("IdCategoria", idCategoria)
        Return SelectObjectFactory(command)

    End Function

    Public Function GetTipoContratoByIdTipoContrato(ByVal idTipoContrato As Integer) As BussinessEntities.TipoContrato Implements ITipoContratoRepository.GetTipoContratoByIdTipoContrato
        Dim tipoContrato As New TipoContrato
        Return tipoContrato
    End Function

    Public Sub SaveTipoContrato(ByVal tipoContrato As BussinessEntities.TipoContrato) Implements ITipoContratoRepository.SaveTipoContrato

    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoContrato)
        Dim lista As New List(Of TipoContrato)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New TipoContrato

                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoContrato")) Then
                    entity.IdTipoContrato = reader.GetValue(reader.GetOrdinal("IdTipoContrato"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("ModeloContrato")) Then
                    entity.ModeloContrato = reader.GetValue(reader.GetOrdinal("ModeloContrato"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function

End Class
