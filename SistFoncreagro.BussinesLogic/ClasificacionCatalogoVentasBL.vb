Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ClasificacionCatalogoVentasBL : Implements IClasificacionCatalogoVentas
    Dim factoryrepository As IClasificacionCatalogoVentasRepository

    Public Sub New()
        factoryrepository = New ClasificacionCatalogoVentasRepository
    End Sub

    Public Function GetCLASIFICACIONCATALOGOVENTASById(ByVal IdClasificacion As Integer) As BussinessEntities.ClasificacionCatalogoVentas Implements IClasificacionCatalogoVentas.GetCLASIFICACIONCATALOGOVENTASById
        Return factoryrepository.GetCLASIFICACIONCATALOGOVENTASById(IdClasificacion)
    End Function

    Public Sub SaveCLASIFICACIONCATALOGOVENTAS(ByVal _ClasificacionCatalogoVentas As BussinessEntities.ClasificacionCatalogoVentas) Implements IClasificacionCatalogoVentas.SaveCLASIFICACIONCATALOGOVENTAS
        factoryrepository.SaveCLASIFICACIONCATALOGOVENTAS(_ClasificacionCatalogoVentas)
    End Sub

    Public Sub UpdateEstadoCLASIFICACIONCATALOGOVENTAS(ByVal IdClasificacion As Integer) Implements IClasificacionCatalogoVentas.UpdateEstadoCLASIFICACIONCATALOGOVENTAS
        factoryrepository.UpdateEstadoCLASIFICACIONCATALOGOVENTAS(IdClasificacion)
    End Sub
End Class
