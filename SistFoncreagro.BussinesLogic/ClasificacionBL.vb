Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ClasificacionBL : Implements IClasificacionBL
    Dim factoryrepository As IClasificacionRepository
    Public Sub New()
        factoryrepository = New ClasificacionRepository
    End Sub

    Public Function GetAllFromClasificacion() As System.Collections.Generic.List(Of BussinessEntities.Clasificacion) Implements IClasificacionBL.GetAllFromClasificacion
        Return factoryrepository.GetAllFromClasificacion
    End Function

    Public Function GetFromClasificacionById(ByVal _id As Integer) As BussinessEntities.Clasificacion Implements IClasificacionBL.GetFromClasificacionById
        Return factoryrepository.GetFromClasificacionById(_id)
    End Function

    Public Sub SaveClasificacion(ByVal _Clasificacion As BussinessEntities.Clasificacion) Implements IClasificacionBL.SaveClasificacion
        factoryrepository.SaveClasificacion(_Clasificacion)
    End Sub

    Public Sub DeleteClasificacion(ByVal _id As Integer) Implements IClasificacionBL.DeleteClasificacion
        factoryrepository.DeleteClasificacion(_id)
    End Sub

    Public Function GetFromClasificacionByTipo(ByVal _Tipo As Integer) As System.Collections.Generic.List(Of BussinessEntities.Clasificacion) Implements IClasificacionBL.GetFromClasificacionByTipo
        Return factoryrepository.GetFromClasificacionByTipo(_Tipo)
    End Function

    Public Function GetCLASIFICACIONByIdCatalogo(ByVal IdCatalogo As Integer) As BussinessEntities.Clasificacion Implements IClasificacionBL.GetCLASIFICACIONByIdCatalogo
        Return factoryrepository.GetCLASIFICACIONByIdCatalogo(IdCatalogo)

    End Function
End Class
