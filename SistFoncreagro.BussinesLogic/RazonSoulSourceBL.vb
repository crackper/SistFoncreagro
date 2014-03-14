Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class RazonSoulSourceBL : Implements IRazonSoulSourceBL
    Dim factoryrepository As IRazonSoulSourceRepository
    Public Sub New()
        factoryrepository = New RazonSoulSourceRepository
    End Sub

    Public Function GetAllFromRazones() As System.Collections.Generic.List(Of BussinessEntities.RazonSoulSource) Implements IRazonSoulSourceBL.GetAllFromRazones
        Return factoryrepository.GetAllFromRazones
    End Function

    Public Sub UpdateRazonCotizaconSoulSource(ByVal IdContizacion As Integer, ByVal IdRazon As Integer) Implements IRazonSoulSourceBL.UpdateRazonCotizaconSoulSource
        factoryrepository.UpdateRazonCotizaconSoulSource(IdContizacion, IdRazon)
    End Sub
End Class
