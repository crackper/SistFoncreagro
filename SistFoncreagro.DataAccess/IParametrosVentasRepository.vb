Imports SistFoncreagro.BussinessEntities
Public Interface IParametrosVentasRepository
    Sub UpdateEstadoPARAMETROSVENTAS(ByVal IdParametro As Int32)
    Sub SavePARAMETROSVENTAS(ByVal _Parametros As ParametrosVentas)
    Function GetAllFromPARAMETROSVENTAS() As List(Of ParametrosVentas)
End Interface
