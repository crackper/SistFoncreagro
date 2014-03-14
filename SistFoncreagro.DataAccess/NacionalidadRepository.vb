Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class NacionalidadRepository : Inherits MasterDataAccess : Implements INacionalidadRepository


    Public Sub DeleNacionalidad(ByVal idNacionalidad As Integer) Implements INacionalidadRepository.DeleNacionalidad

    End Sub

    Public Function GetAllFromNacionalidad() As System.Collections.Generic.List(Of BussinessEntities.Nacionalidad) Implements INacionalidadRepository.GetAllFromNacionalidad
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromNACIONALIDAD")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetNacionalidadByIdNacionalidad(ByVal idNacionalidad As Integer) As BussinessEntities.Nacionalidad Implements INacionalidadRepository.GetNacionalidadByIdNacionalidad
        Dim nacionalidad As New Nacionalidad
        Return nacionalidad
    End Function

    Public Sub SaveNacionalidad(ByVal nacionalidad As BussinessEntities.Nacionalidad) Implements INacionalidadRepository.SaveNacionalidad

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Nacionalidad)
        Dim lista As New List(Of Nacionalidad)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New Nacionalidad

                If Not reader.IsDBNull(reader.GetOrdinal("IdNacionalidad")) Then
                    entity.IdNacionalidad = reader.GetValue(reader.GetOrdinal("IdNacionalidad"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Nacionalidad")) Then
                    entity.Nacionalidad = reader.GetValue(reader.GetOrdinal("Nacionalidad"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("CodSunat")) Then
                    entity.CodSunat = reader.GetValue(reader.GetOrdinal("CodSunat"))
                End If

                Dim tipoDIFactory As New TipoDocumentoIdentidadRepository

                entity.ListaTipoDI = tipoDIFactory.GetTipoDocumentoIdentidadByIdNacionalidad(entity.IdNacionalidad)

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
End Class
