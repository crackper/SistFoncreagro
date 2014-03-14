Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports System.Data.SqlClient
Public Class TipoDocumentoIdentidadRepository : Inherits MasterDataAccess : Implements ITipodocumentoIdentidad
    Public Function GetAllFromTipoDocumentoIdentidad() As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipodocumentoIdentidad.GetAllFromTipoDocumentoIdentidad
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTipoDocidentidad")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTipoDocumentoIdentidadByIdNacionalidad(ByVal idNacionalidad As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipodocumentoIdentidad.GetTipoDocumentoIdentidadByIdNacionalidad
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoDocumentoIdentidadByIdNacionalidad")
        command.Parameters.AddWithValue("idNacionalidad", idNacionalidad)
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoDocumentoIdentidad)
        Dim lista As New List(Of TipoDocumentoIdentidad)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New TipoDocumentoIdentidad
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoDI")) Then
                    entity.IdTipoDI = reader.GetValue(reader.GetOrdinal("IdTipoDI"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If
                Dim tipoDI As New TipoDocumentoIdentidad
                Dim tipoDIFactory As New TipoDocumentoRepository
                lista.Add(entity)
            End While
        End Using
        Return lista
    End Function

    Public Function GetTipoDocumentoIdentidadByTipoPersona(ByVal tipoPersona As String) As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipodocumentoIdentidad.GetTipoDocumentoIdentidadByTipoPersona
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTipoDocumentoIdentidadByTipoPersona")
        command.Parameters.AddWithValue("TipoPersona", tipoPersona)
        Return SelectObjectFactory(command)
    End Function
End Class
