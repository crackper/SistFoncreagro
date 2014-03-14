Imports SistFoncreagro.BussinessEntities
Public Interface IPeriodoLaboralRepository
    Function GetAllFromPERIODOLABORAL(ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
    Function GetPERIODOLABORALByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As PeriodoLaboral
    Function SavePERIODOLABORAL(ByVal periodoLaboral As PeriodoLaboral) As Int32
    Function GetPERIODOLABORALByIdPersonal(ByVal IdPersonal As Int32, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
    Function GetPERIODOLABORALAValidosByFecha(ByVal Fecha As DateTime, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
    Function GetPERIODOLABORALLiquidadosPorRangoFecha(ByVal Fecha1 As DateTime, ByVal Fecha2 As DateTime, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
    Function GetPERIODOLABORALLiquidadosPendientesDePago(ByVal Fecha1 As DateTime, ByVal Fecha2 As DateTime, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
    Function GetPERIODOLABORALDeBajaPorLiquidar(ByVal Fecha1 As DateTime, ByVal Fecha2 As DateTime, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As List(Of PeriodoLaboral)
    Function GetPERIODOLABORALActualActivoByIdPersonal(ByVal IdPersonal As Int32, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As PeriodoLaboral
    Function GetPERIODOLABORALAUltimoByIdPersonal(ByVal IdPersonal As Int32, ByVal argPeriodoLaboral As ArgumentosPeriodolaboral) As PeriodoLaboral
    Function GetPERIODOLABORALAValidosByFechaAndByIdPersonal(ByVal Fecha As DateTime, ByVal IdPersonal As Int32, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As PeriodoLaboral
    Function GetUltimaFechcaFinPERIODOLABORALByIdPersonal(ByVal idPersonal As Int32) As String
    Sub DeletePeriodoLaboral(ByVal IdPeriodoLaboral As Int32)
    Sub UpdateTelefonosPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal EmailCoorporativo As String, ByVal TelefCoorp As String)

    'Function GetPeriodoLaboralIdEmpleado(ByVal idPersonal As Int32) As List(Of PeriodoLaboral) 'ELIMINAR
    'Function GetPeriodoLaboralActualByIdEmpleado(ByVal idPersonal As Int32) 'ELIMINAR
  
End Interface
