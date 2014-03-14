Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class CCostoBL : Implements ICCostoBL
    Dim factoryrepository As ICCostoRepository
    Public Sub New()
        factoryrepository = New CCostoRepository
    End Sub

    Public Function GetAllFromCCosto() As System.Collections.Generic.List(Of BussinessEntities.CCosto) Implements ICCostoBL.GetAllFromCCosto
        Return factoryrepository.GetAllFromCCosto
    End Function

    Public Function GetCCOSTOByIdCCosto(ByVal _IdCCosto As Integer) As BussinessEntities.CCosto Implements ICCostoBL.GetCCOSTOByIdCCosto
        Return factoryrepository.GetCCOSTOByIdCCosto(_IdCCosto)
    End Function

    Public Function GetCCOSTOByIdProyecto(ByVal _IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.CCosto) Implements ICCostoBL.GetCCOSTOByIdProyecto
        Return factoryrepository.GetCCOSTOByIdProyecto(_IdProyecto)
    End Function

    Public Function DeleteCCosto(ByVal _IdCCosto As Integer) As String Implements ICCostoBL.DeleteCCosto
        Return factoryrepository.DeleteCCostos(_IdCCosto)
    End Function

    Public Function SaveCCosto(ByVal _CCosto As BussinessEntities.CCosto) As String Implements ICCostoBL.SaveCCosto
        Return factoryrepository.SaveCCosto(_CCosto)
    End Function

    Public Function GetCCOSTOByIdOrdenCompra(ByVal IdOrden As Integer) As System.Collections.Generic.List(Of BussinessEntities.CCosto) Implements ICCostoBL.GetCCOSTOByIdOrdenCompra
        Return factoryrepository.GetCCOSTOByIdOrdenCompra(IdOrden)
    End Function
End Class
