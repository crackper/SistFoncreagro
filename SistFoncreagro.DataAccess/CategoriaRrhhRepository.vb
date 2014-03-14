Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CategoriaRrhhRepository : Inherits MasterDataAccess : Implements ICategoriaRrhhRepository


    Public Sub DeleteCategoriaRrhh(ByVal idCategoria As Integer) Implements ICategoriaRrhhRepository.DeleteCategoriaRrhh

    End Sub

    Public Function GetAllFromCategoriaRrhh() As System.Collections.Generic.List(Of BussinessEntities.CategoriaRrhh) Implements ICategoriaRrhhRepository.GetAllFromCategoriaRrhh
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCATEGORIARRHH")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCategoriaRrhhByIdCategoria(ByVal idCategoria As Integer) As BussinessEntities.CategoriaRrhh Implements ICategoriaRrhhRepository.GetCategoriaRrhhByIdCategoria
        Dim cateoriaRrhh As New CategoriaRrhh
        Return cateoriaRrhh

    End Function

    Public Sub SaveCategoriaRrhh(ByVal categoriaRrhh As BussinessEntities.CategoriaRrhh) Implements ICategoriaRrhhRepository.SaveCategoriaRrhh

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CategoriaRrhh)
        Dim lista As New List(Of CategoriaRrhh)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim entity As New CategoriaRrhh

                If Not reader.IsDBNull(reader.GetOrdinal("IdCategoria")) Then
                    entity.IdCategoria = reader.GetValue(reader.GetOrdinal("IdCategoria"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdLegislacion")) Then
                    entity.IdLegislacion = reader.GetValue(reader.GetOrdinal("IdLegislacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Nombre")) Then
                    entity.Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
End Class
