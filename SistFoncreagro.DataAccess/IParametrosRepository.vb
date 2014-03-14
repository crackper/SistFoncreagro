Imports SistFoncreagro.BussinessEntities
Public Interface IParametrosRepository
    Function GetPARAMETROSByNombre(ByVal Nombre As String) As Parametros
    Function GetValorUIT(ByVal Fecha As DateTime) As Parametros
    Function GetAllfromPARAMETROS() As List(Of Parametros)
    Function GetPARAMETROSByIdParametro(ByVal IdParametro As Int32) As Parametros
    Sub SavePARAMETROS(ByVal _Parametros As Parametros)
    Sub UpdateEstadoPARAMETROS(ByVal IdParametro As Int32)
    Function GetPorcentajeSistemaPenciones(IdSistemaPensiones As Int32, monto As Decimal) As Decimal
End Interface
