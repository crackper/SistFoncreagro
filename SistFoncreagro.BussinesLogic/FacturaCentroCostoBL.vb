Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class FacturaCentroCostoBL : Implements IFacturaCentroCostoBL
    Dim facturaRepository As IFacturaCentroCostoRepository
    Sub New()
        facturaRepository = New FacturaCentroCostoRepository
    End Sub
    Public Sub DeleteFacturaCentroCosto(ByVal IdFacturaCentroCosto As Integer) Implements IFacturaCentroCostoBL.DeleteFacturaCentroCosto
        facturaRepository.DeleteFacturaCentroCosto(IdFacturaCentroCosto)
    End Sub

    Public Function GetAllFromFacturaCentroCostoByIdOrdenCentroCosto(ByVal IdOrdenCentroCosto As Integer) As System.Collections.Generic.List(Of BussinessEntities.FacturaCentroCosto) Implements IFacturaCentroCostoBL.GetAllFromFacturaCentroCostoByIdOrdenCentroCosto
        Return facturaRepository.GetAllFromFacturaCentroCostoByIdOrdenCentroCosto(IdOrdenCentroCosto)
    End Function

    Public Sub SaveFacturaCentroCosto(ByVal facturaCCosto As BussinessEntities.FacturaCentroCosto) Implements IFacturaCentroCostoBL.SaveFacturaCentroCosto
        facturaRepository.SaveFacturaCentroCosto(facturaCCosto)
    End Sub
End Class
