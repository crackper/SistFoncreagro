Imports SistFoncreagro.BussinessEntities
Public Interface IClimaSocialRepository
    Function GetCLIMASOCIALByIdUbigeoandIdProyecto(ByVal Cubigeo As String, ByVal IdProyecto As Int32) As List(Of ClimaSocial)
    Function GetCLIMASOCIALByIdClima(ByVal IdClima As Int32) As ClimaSocial
    Sub DeleteCLIMASOCIAL(ByVal IdClima As Int32)
    Function SaveCLIMASOCIAL(ByVal _Clima As ClimaSocial) As Int32
End Interface
