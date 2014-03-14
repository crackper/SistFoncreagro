Imports SistFoncreagro.BussinessEntities
Public Interface IControlAsistenciaRepository
    Function GetControlAsistenciaByIdPeriodoLaboralAndByFecha(ByVal IdPeriodoLaboral As Int32, ByVal Fecha As Date) As List(Of ControlAsistencia)
    Function GetControlAsistenciaByIdPeriodoLaboralAndByFechaAndTipo(ByVal IdPeriodoLaboral As Int32, ByVal Fecha As Date, ByVal Tipo As String) As List(Of ControlAsistencia)
    Function GetControlAsistenciaByIdPeriodoLaboralAndRagoFecha(ByVal IdPeriodoLaboral As Int32, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime) As List(Of ControlAsistencia)
    Function SaveCONTROLASISTENCIA(ByVal controlAsistencia As ControlAsistencia) As Int32
    Sub SaveDatosRealesEnCONTROLASISTENCIAByIdPeriodoLaboralAndRangoFecha(ByVal controlAsistencia As ControlAsistencia, ByVal FechaInicial As DateTime, ByVal FechaFinal As DateTime)
    Sub DeleteControlAsistenciaByIdPeriodoLaboralByIdFechaByTipo(ByVal IdPeriodoLaboral As Int32, ByVal Fecha As DateTime, ByVal tipo As String)
    Sub UpdateCONTROLASISTENCIA(ByVal _controlAsistencia As ControlAsistencia)
    Function GetControlAsistenciaByIdPersonalAndByFecha(ByVal IdPersonal As Int32, ByVal Fecha As DateTime) As List(Of ControlAsistencia)
End Interface
