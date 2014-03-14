Imports SistFoncreagro.BussinessEntities
Imports System.Data
Imports System.Data.SqlClient
Public Class TipoDocumentoIdentidadRepository : Inherits MasterDataAccess : Implements ITipodocumentoIdentidad

    Public Function GetAllFromTipoDocumentoIdentidad() As System.Collections.Generic.List(Of BussinessEntities.TipoDocumentoIdentidad) Implements ITipodocumentoIdentidad.GetAllFromTipoDocumentoIdentidad
        Return New List(Of TipoDocumentoIdentidad)()
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
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
End Class
