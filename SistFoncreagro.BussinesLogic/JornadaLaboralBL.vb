Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class JornadaLaboralBL : Implements IJornadaLaboralBL

    Dim factoryrepository As IJornadaLaboralRepository

    Public Sub New()
        factoryrepository = New JornadaLaboralRepository
    End Sub

    Public Function GetJornadaLaboralPeriodoByIdPeriodoLaboralByIdPeriodoDeclaracion(ByVal IdPeriodoLaboral As Integer, ByVal IdPeriodoDeclaracion As Integer) As BussinessEntities.JornadaLaboralPeriodo Implements IJornadaLaboralBL.GetJornadaLaboralPeriodoByIdPeriodoLaboralByIdPeriodoDeclaracion
        Return factoryrepository.GetJornadaLaboralPeriodoByIdPeriodoLaboralByIdPeriodoDeclaracion(IdPeriodoLaboral, IdPeriodoDeclaracion)
    End Function

    Public Function SaveJORNADALABORALPERIODO(ByVal JornadaLaboralPeriodo As BussinessEntities.JornadaLaboralPeriodo) As Integer Implements IJornadaLaboralBL.SaveJORNADALABORALPERIODO
        Return factoryrepository.SaveJORNADALABORALPERIODO(JornadaLaboralPeriodo)
    End Function

    Public Function SaveCrearJornadaLaboralPorPersonayControlAsistencia(ByVal IdPeriodoLaboral As Integer, ByVal IdPeriodoDeclaracion As Integer) As Integer Implements IJornadaLaboralBL.SaveCrearJornadaLaboralPorPersonayControlAsistencia
        Dim jornadaLaboralPeriodo As New JornadaLaboralPeriodo
        Dim periodoDeclaracion As New PeriodoDeclaracion
        Dim periodoDeclaracionBL As New PeriodoDeclaracionBL
        Dim motivoAusenciaBL As New MotivoAusenciaBL
        Dim ausenciaPeriodoRepository As New AusenciaPeriodoRepository
        Dim parametroLaboralBL As New ParametroLaboralBL
        Dim detalleParametroLabBL As New DetalleParametroLabBL
        Dim DetMinHE25 As New DetalleParametroLab
        Dim DetMaxHE25 As New DetalleParametroLab
        Dim listaMotivoAusencia As New List(Of MotivoAusencia)
        Dim IdJornadaLaboralPeriodo As Int32
        Dim mes As String
        Dim anio As String
        Dim FI As Date
        Dim FF As Date

        jornadaLaboralPeriodo.IdPeriodoDeclaracion = IdPeriodoDeclaracion
        jornadaLaboralPeriodo.IdPeriodoLaboral = IdPeriodoLaboral

        IdJornadaLaboralPeriodo = factoryrepository.SaveJORNADALABORALPERIODO(jornadaLaboralPeriodo)

        periodoDeclaracion = periodoDeclaracionBL.GetPeriodoDeclaracionByIdPeriodoDeclaracion(IdPeriodoDeclaracion)

        mes = periodoDeclaracion.Mes
        anio = periodoDeclaracion.Anio

        FI = "01/" & mes & "/" & anio
        FI = DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, FI))

        listaMotivoAusencia = motivoAusenciaBL.GetMotivoAusenciaByFechasByIdPeriodoLaboral(FI, FF, IdPeriodoLaboral)

        For Each MotivoAusencia As MotivoAusencia In listaMotivoAusencia
            ausenciaPeriodoRepository.SaveAUSENCIASPERIODO(IdPeriodoLaboral, IdJornadaLaboralPeriodo, MotivoAusencia.IdMotivoAusencia, MotivoAusencia.Abreviatura, FI, FF)
        Next

        'Dias efectivamente trabajados
        jornadaLaboralPeriodo.DiasEfecTrabajados = DateDiff(DateInterval.Day, FI, FF) - ausenciaPeriodoRepository.GetSumAusenciasPeriodoNoPagadas(IdJornadaLaboralPeriodo)
        jornadaLaboralPeriodo.DiasDescanso = factoryrepository.GetDiasDescansoEnControlAsistenciaByRangoFechas(IdPeriodoLaboral, FI, FF)
        jornadaLaboralPeriodo.DiasFeriados = factoryrepository.GetDiasFeriadosEnControlAsistenciaByRangoFechas(IdPeriodoLaboral, FI, FF)
        jornadaLaboralPeriodo.DiasNoSubsidiados = factoryrepository.GetDiasNoLaboradosNoSubsidiadosByIdJornadaLaboral(IdJornadaLaboralPeriodo)
        jornadaLaboralPeriodo.DiasSubsidiados = factoryrepository.GetDiasNoLaboradosSubsidiadosByIdJornadaLaboral(IdJornadaLaboralPeriodo)

        'Horas(extra)
        DetMinHE25 = detalleParametroLabBL.GetDetalleParametrosLabVigenteByIdParametroLab(2)
        DetMaxHE25 = detalleParametroLabBL.GetDetalleParametrosLabVigenteByIdParametroLab(3)

        jornadaLaboralPeriodo.HorasExtraordinarias25 = factoryrepository.GetSumHExtra25ControlAsistByFechasByIdPeriodoLaboral(IdPeriodoLaboral, DetMinHE25.Valor, DetMaxHE25.Valor, FI, FF)
        jornadaLaboralPeriodo.HorasExtraordinarias35 = factoryrepository.GetSumHExtra35ControlAsistByFechasByIdPeriodoLaboral(IdPeriodoLaboral, DetMaxHE25.Valor, FI, FF)

        Return SaveJORNADALABORALPERIODO(jornadaLaboralPeriodo)

    End Function

End Class
