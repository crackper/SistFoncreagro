Imports SistFoncreagro.BussinessEntities
Public Interface ITipoCambioBL
    Function GetAllFromTIPOCAMBIO() As List(Of TipoCambio)
    Function GetTIPOCAMBIOByAnioMes(ByVal Anio As Int32, ByVal Mes As Int32) As TipoCambio
    Function GetTIPOCAMBIOByAnio(ByVal Anio As Int32) As List(Of TipoCambio)
    Function GetTIPOCAMBIOByAnioMesDia(ByVal Anio As Int32, ByVal Mes As Int32, ByVal Dia As Int32) As Decimal
    Function GetTIPOCAMBIO1ByAnioMesDia(ByVal Anio As Int32, ByVal Mes As Int32, ByVal Dia As Int32) As Decimal
    Function GetNumeroRegistrosFromTIPOCAMBIOByAnioMes(ByVal Anio As Int32, ByVal Mes As Int32) As Int32
    Function GetTIPOCAMBIOByFecha(ByVal Fecha As DateTime) As Decimal
    Function GetTIPOCAMBIOByIdTipCambio(ByVal IdTipCambio As Int32) As TipoCambio
    Function SaveTIPOCAMBIO(ByVal _TipoCambio As TipoCambio) As Int32
    Function GetTIPOCAMBIOCompraByFecha(ByVal Fecha As DateTime) As Decimal
    Sub DeleteTIPOCAMBIO(ByVal idTipoCambio As Int32)
End Interface
