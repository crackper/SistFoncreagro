Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ContabilizacionVentaBL : Implements IContabilizacionVentaBL
    Dim factoryrepository As IContabilizacionVentaRepository
    Public Sub New()
        factoryrepository = New ContabilizacionVentaRepository
    End Sub
    Public Function GetAllFromCONTABILIZACIONVENTA() As System.Collections.Generic.List(Of BussinessEntities.ContabilizacionVenta) Implements IContabilizacionVentaBL.GetAllFromCONTABILIZACIONVENTA
        Return factoryrepository.GetAllFromCONTABILIZACIONVENTA
    End Function

    Public Function GetCONTABILIZACIONVENTAByIdContaVenta(ByVal IdContaVenta As Integer) As BussinessEntities.ContabilizacionVenta Implements IContabilizacionVentaBL.GetCONTABILIZACIONVENTAByIdContaVenta
        Return factoryrepository.GetCONTABILIZACIONVENTAByIdContaVenta(IdContaVenta)
    End Function

    Public Sub SaveCONTABILIZACIONVENTA(ByVal _ContabilizacionVenta As BussinessEntities.ContabilizacionVenta) Implements IContabilizacionVentaBL.SaveCONTABILIZACIONVENTA
        factoryrepository.SaveCONTABILIZACIONVENTA(_ContabilizacionVenta)
    End Sub

    Public Sub UpdateEstadoCONTABILIZACIONVENTA(ByVal IdContaVenta As Integer) Implements IContabilizacionVentaBL.UpdateEstadoCONTABILIZACIONVENTA
        factoryrepository.UpdateEstadoCONTABILIZACIONVENTA(IdContaVenta)
    End Sub
End Class
