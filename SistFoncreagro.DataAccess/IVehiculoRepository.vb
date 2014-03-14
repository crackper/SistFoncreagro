Imports SistFoncreagro.BussinessEntities
Public Interface IVehiculoRepository
    Function GetVEHICULOByIdVehiculo(ByVal IdVehiculo) As Vehiculo
    Function GetVEHICULOByIdDetalleEje(ByVal IdDetalleEje As Int32) As List(Of Vehiculo)
    Sub SaveVEHICULO(ByVal _Vehiculo As Vehiculo)
    Sub DeleteVEHICULO(ByVal IdVehiculo As Int32)
End Interface
