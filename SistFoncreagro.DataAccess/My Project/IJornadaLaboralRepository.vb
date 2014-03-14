Imports SistFoncreagro.BussinessEntities
Public Interface IJornadaLaboralRepository
    Function SaveJORNADALABORALPERIODO(ByVal JornadaLaboralPeriodo As JornadaLaboralPeriodo) As Int32
    Function GetJornadaLaboralPeriodoByIdPeriodoLaboralByIdPeriodoDeclaracion(ByVal IdPeriodoLaboral As Int32, ByVal IdPeriodoDeclaracion As Int32) As JornadaLaboralPeriodo
    Function GetDiasDescansoEnControlAsistenciaByRangoFechas(ByVal IdPeriodoLaboral As Int32, ByVal FI As Date, ByVal FF As Date) As Decimal
    Function GetDiasFeriadosEnControlAsistenciaByRangoFechas(ByVal IdPeriodoLaboral As Int32, ByVal FI As Date, ByVal FF As Date) As Decimal
    Function GetDiasNoLaboradosNoSubsidiadosByIdJornadaLaboral(ByVal IdJornalaLaboral As Int32) As Decimal
    Function GetDiasNoLaboradosSubsidiadosByIdJornadaLaboral(ByVal IdJornalaLaboral As Int32) As Decimal
    Function GetSumHExtra25ControlAsistByFechasByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32, ByVal MinHE25 As Decimal, ByVal MaxHE25 As Decimal, ByVal FI As Date, ByVal FF As Date) As Decimal
    Function GetSumHExtra35ControlAsistByFechasByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Int32, ByVal MaxHE25 As Decimal, ByVal FI As Date, ByVal FF As Date) As Decimal
End Interface
