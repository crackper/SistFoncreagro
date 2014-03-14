Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Interface IControlAsistenciaBL
    Function GetControlAsistenciaByIdPeriodoLaboralAndByFecha(ByVal IdPeriodoLaboral As Int32, ByVal Fecha As Date) As List(Of ControlAsistencia)
    Function GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(ByVal IdPeriodoLaboral As Int32, ByVal Fecha As Date, ByVal Tipo As String) As List(Of ControlAsistencia)
    Function SaveCONTROLASISTENCIA(ByVal controlAsistencia As ControlAsistencia) As Int32
    Function GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha(ByVal IdPeriodoLaboral As Int32, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime) As List(Of ControlAsistencia)
    Function GenerarControlAsistenciaByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32, ByVal FechaIni As DateTime, ByVal FechaFin As DateTime) As List(Of ControlAsistencia)
    Sub DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(ByVal IdPeriodoLaboral As Int32, ByVal Fecha As DateTime, ByVal tipo As String)
    Sub SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha(ByVal controlAsistencia As ControlAsistencia, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime)
    Function GetControlAsistenciaByIdPersonalAndByFecha(ByVal IdPersonal As Int32, ByVal Fecha As DateTime) As List(Of ControlAsistencia)
    Sub UpdateCONTROLASISTENCIA(ByVal _controlAsistencia As ControlAsistencia)
End Interface
