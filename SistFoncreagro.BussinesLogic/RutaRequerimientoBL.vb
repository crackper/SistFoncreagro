Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class RutaRequerimientoBL : Implements IRutaRequerimientoBL

    Dim factoryRepository As IRutaRequerimientoRepository

    Sub New()
        factoryRepository = New RutaRequerimientoRepository
    End Sub

    Public Sub DeleteRutaRequerimiento(ByVal idRutaRequerimiento As Integer) Implements IRutaRequerimientoBL.DeleteRutaRequerimiento
        factoryRepository.DeleteRutaRequerimiento(idRutaRequerimiento)
    End Sub

    Public Function GetAllFromRutaRequerimiento() As System.Collections.Generic.List(Of BussinessEntities.RutaRequerimiento) Implements IRutaRequerimientoBL.GetAllFromRutaRequerimiento
        Return factoryRepository.GetAllFromRutaRequerimiento
    End Function

    Public Function GetRutaRequerimientoByIdRuta(ByVal idRutaRequerimiento As Integer) As BussinessEntities.RutaRequerimiento Implements IRutaRequerimientoBL.GetRutaRequerimientoByIdRuta
        Return factoryRepository.GetRutaRequerimientoByIdRuta(idRutaRequerimiento)
    End Function

    Public Sub SaveRutaRequerimiento(ByVal rutaRequerimiento As BussinessEntities.RutaRequerimiento) Implements IRutaRequerimientoBL.SaveRutaRequerimiento
        factoryRepository.SaveRutaRequerimiento(rutaRequerimiento)
    End Sub


End Class
