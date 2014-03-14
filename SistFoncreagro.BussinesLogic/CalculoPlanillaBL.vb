Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CalculoPlanillaBL
    Dim detalleConceptoBL As New DetalleConceptoBL
    Dim detConceptoPeriodoRepository As New DetalleConceptoPeriodoRepository
    Dim aportesPorPeriodoRepository As New AportesPorPeriodoRepository
    Dim detalleParametroLabBL As New DetalleParametroLabBL

    Sub CalculoRemuneracionGratificacion(ByVal listaPersonal As List(Of Personal), ByVal perini As String, ByVal perfin As String)
        'obtenemos listaEmpleado tipo Obrero
        Dim FI As Date
        Dim FF As Date
        Dim remMinima As New DetalleParametroLab
        'FI = "01/01/" & Year(Today)
        'FF = "30/06/" & Year(Today)

        FI = "perini" & Year(Today)
        FF = "perfin" & Year(Today)

        remMinima = detalleParametroLabBL.GetDetalleParametrosLabVigenteByIdParametroLab(1)

        For Each Personal As Personal In listaPersonal
            Dim meses As Decimal
            Dim remuneracionComputable As Decimal
            Dim RemuneracionNetaGratificacion As Decimal
            Dim RemuneracionTotalGratificacion As Decimal
            If Personal.periodoLaboralActualEntity.FechaInicio > FI Then
                FI = Personal.periodoLaboralActualEntity.FechaInicio
            End If

            If Personal.periodoLaboralActualEntity.FechaCese < FF Then
                FF = Personal.periodoLaboralActualEntity.FechaCese
            End If

            meses = DateDiff(DateInterval.Month, FI, FF)

            If meses > 1 Then

                If Personal.CorrespondeAsignacionFamiliar Then
                    remuneracionComputable = ((Personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Sueldo)) + _
                        Calculo0201(Personal, remMinima)
                Else
                    remuneracionComputable = ((Personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Sueldo))
                End If

                RemuneracionTotalGratificacion = (Calculo0312(Calculo0406(remuneracionComputable, meses)))

                RemuneracionNetaGratificacion = (Calculo0312(Calculo0406(remuneracionComputable, meses))) ' falta grabar.
            End If
        Next
    End Sub

    Sub CalculoRemuneracionCTS(ByVal listaPersonal As List(Of Personal), ByVal perini As String, ByVal perfin As String, ByVal periodo As Integer)
        'obtenemos listaEmpleado tipo Obrero
        Dim FI As Date
        Dim FF As Date
        Dim remMinima As New DetalleParametroLab
        'FI = "01/01/" & Year(Today)
        'FF = "30/06/" & Year(Today)

        If periodo = 1 Then
            FI = "perini" & Year(Today) - 1
            FF = "perfin" & Year(Today)
        ElseIf periodo = 2 Then
            FI = "perini" & Year(Today)
            FF = "perfin" & Year(Today)
        End If


        'For Each Personal As Personal In listaPersonal
        '    Dim meses As Decimal
        '    Dim remuneracionComputable As Decimal
        '    Dim RemuneracionNetaCTS As Decimal
        '    If Personal.periodoLaboralActualEntity.FechaInicio > FI Then
        '        FI = Personal.periodoLaboralActualEntity.FechaInicio
        '    End If

        '    If Personal.periodoLaboralActualEntity.FechaCese < FF Then
        '        FF = Personal.periodoLaboralActualEntity.FechaCese
        '    End If

        '    meses = DateDiff(DateInterval.Month, FI, FF)

        '    If meses > 1 Then

        '        If Personal.CorrespondeAsignacionFamiliar Then
        '            remuneracionComputable = ((Personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Sueldo)) + _
        '                Calculo0201(Personal, remMinima)
        '        Else
        '            remuneracionComputable = ((Personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Sueldo))
        '        End If


        '        'RemuneracionNetaGratificacion = (Calculo0312(Calculo0406(remuneracionComputable, meses))) ' falta grabar.
        '    End If
        'Next

    End Sub

    ' calculo de Remuneración Permanente 0122:
    Function Calculo0122(ByVal personal As Personal, ByVal jornadaLaboralPeriodo As JornadaLaboralPeriodo, ByVal jornadaOrdinaria As DetalleParametroLab) As Decimal
        Dim remuneracionPermanente As Decimal
        remuneracionPermanente = ((personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Sueldo / 30) / jornadaOrdinaria.Valor) * jornadaLaboralPeriodo.DiasEfecTrabajados
        Return remuneracionPermanente
    End Function

    'Calculo de la asignación familiar
    Function Calculo0201(ByVal personal As Personal, ByVal remMinima As DetalleParametroLab) As Decimal
        Dim asignacionFamiliar As Decimal
        Dim detalleConcepto As New DetalleConcepto
        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0201")
        'For Each remComputable In detalleConcepto.listaRemComputable
        '    remComputable.Naturaleza
        'Next  

        'Si personal tiene derechohabientes menores a 18 años
        asignacionFamiliar = detalleConcepto.FactorVigenteEntity.ValorFactor * remMinima.Valor
        'Si no
        asignacionFamiliar = 0

        Return asignacionFamiliar
    End Function

    'Sobretiempo 25
    Function Calculo0105(ByVal personal As Personal, ByVal jornadaLaboralPeriodo As JornadaLaboralPeriodo, ByVal remMinima As DetalleParametroLab) As Decimal
        Dim sobreTiempo25 As Decimal
        Dim detalleConcepto As New DetalleConcepto
        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0105")
        sobreTiempo25 = detalleConcepto.FactorVigenteEntity.ValorFactor * Calculo0201(personal, remMinima)
        Return sobreTiempo25
    End Function

    'Sobretiempo 35
    Function Calculo0106(ByVal personal As Personal, ByVal jornadaLaboralPeriodo As JornadaLaboralPeriodo, ByVal remMinima As DetalleParametroLab) As Decimal
        Dim sobreTiempo25 As Decimal
        Dim detalleConcepto As New DetalleConcepto
        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0106")
        sobreTiempo25 = detalleConcepto.FactorVigenteEntity.ValorFactor * Calculo0201(personal, remMinima)
        Return sobreTiempo25
    End Function

    'Remuneracion Vacacional
    Function Calculo0118(ByVal personal As Personal, ByVal jornadaLaboralPeriodo As JornadaLaboralPeriodo, ByVal jornadaOrdinaria As DetalleParametroLab) As Decimal
        Dim remVacacional As Decimal
        Dim detalleConcepto As New DetalleConcepto
        Dim ausenciaPeriodo As New AusenciaPeriodo
        Dim ausenciaPeriodoRepository As New AusenciaPeriodoRepository
        ausenciaPeriodo = ausenciaPeriodoRepository.GetAusenciasPeriodoByIdJornadaLaboralByAbreviatura(jornadaLaboralPeriodo.IdJornadaLaboral, "V")
        If Not ausenciaPeriodo Is Nothing Then
            detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0118")
            remVacacional = ((personal.periodoLaboralActualEntity.contratoActual.condicionesActualesDeContrato.Sueldo / 30) / jornadaOrdinaria.Valor) * ausenciaPeriodo.NroDias
        Else
            remVacacional = 0
        End If

        Return remVacacional
    End Function

    'Gratificacion por fiestas patrias y navidad 
    Function Calculo0401() As Decimal
        Dim gratificacion As Decimal
        Return gratificacion
    End Function

    'Gratificaciones truncas
    Function Calculo0405() As Decimal
        Dim gratificacionTrunca As Decimal
        Return gratificacionTrunca
    End Function

    'GRATIFICACIONES DE FIESTAS PATRIAS Y NAVIDAD – LEY 29351
    Function Calculo0406(ByVal remComputable As Decimal, ByVal NroMeses As Decimal) As Decimal
        Dim gratificacionLey29351 As Decimal
        gratificacionLey29351 = remComputable * NroMeses / 6

        Return gratificacionLey29351
    End Function

    'BONIFICACIÓN EXTRAORDINARIA TEMPORAL – LEY 29351
    Function Calculo0312(ByVal remComputable As Decimal) As Decimal
        Dim bonificacionLey29351 As Decimal
        Dim detalleConcepto As New DetalleConcepto
        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0312")
        bonificacionLey29351 = remComputable * detalleConcepto.FactorVigenteEntity.ValorFactor
        Return bonificacionLey29351
    End Function

    'GRATIFICACIONES PROPORCIONAL – LEY 29351
    Function Calculo0407() As Decimal
        Dim gratificacionTruncas As Decimal
        Return gratificacionTruncas
    End Function

    'BONIFICACIÓN EXTRAORDINARIA PROPORCIONAL – LEY 29351
    Function Calculo0313() As Decimal
        Dim gratificacionTruncas As Decimal
        Return gratificacionTruncas
    End Function

    'CANASTA DE NAVIDAD O SIMILARES

    'SISTEMA PRIVADO DE PENSIONES - COMISIÓN PORCENTUAL
    Function Calculo0601(ByVal IdPlanilla As Int32, ByVal IdPeriodoDeclaracion As Int32, ByVal personal As Personal)
        'Calculamos la remuneración afecta del siguiente modo:
        'Obtengo todos los detalleConceptoPeriodo para esta planilla, para este periodo, para este trabajador 
        'cuyo tipo concepto sea Ingreso y el detalle concepto esté afecto a este DetalleConcepto
        Dim comisionPorcentual As Decimal
        Dim remAfecta As Decimal
        Dim detalleConcepto As New DetalleConcepto
        Dim aportePorPeriodo As New AportesPorPeriodo

        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0601")
        remAfecta = detConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto("I", detalleConcepto.IdDetalleConcepto, IdPlanilla)

        If remAfecta > 0 Then
            aportePorPeriodo = aportesPorPeriodoRepository.GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(IdPeriodoDeclaracion, personal.AfiliacionSPEntity.IdSistemaPensiones, 2)
            comisionPorcentual = remAfecta * aportePorPeriodo.Porcentaje
        Else
            comisionPorcentual = 0
        End If

        Return comisionPorcentual
    End Function


    'SISTEMA PRIVADO DE PENSIONES - PRIMA DE SEGURO
    Function Calculo0606(ByVal IdPlanilla As Int32, ByVal IdPeriodoDeclaracion As Int32, ByVal personal As Personal) As Decimal
        'Calculamos la remuneración afecta del siguiente modo:
        'Obtengo todos los detalleConceptoPeriodo para esta planilla, para este periodo, para este trabajador 
        'cuyo tipo concepto sea Ingreso y el detalle concepto esté afecto a este DetalleConcepto
        Dim primaSeguros As Decimal
        Dim remAfecta As Decimal
        Dim detalleConcepto As New DetalleConcepto
        Dim aportePorPeriodo As New AportesPorPeriodo

        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0606")
        remAfecta = detConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto("I", detalleConcepto.IdDetalleConcepto, IdPlanilla)

        If remAfecta > 0 Then
            aportePorPeriodo = aportesPorPeriodoRepository.GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(IdPeriodoDeclaracion, personal.AfiliacionSPEntity.IdSistemaPensiones, 3)
            primaSeguros = remAfecta * aportePorPeriodo.Porcentaje
        Else
            primaSeguros = 0
        End If

        Return primaSeguros
    End Function

    'SISTEMA PRIVADO DE PENSIONES - APORTACIÓN OBLIGATORIA
    Function Calculo0608(ByVal IdPlanilla As Int32, ByVal IdPeriodoDeclaracion As Int32, ByVal personal As Personal) As Decimal
        'Calculamos la remuneración afecta del siguiente modo:
        'Obtengo todos los detalleConceptoPeriodo para esta planilla, para este periodo, para este trabajador 
        'cuyo tipo concepto sea Ingreso y el detalle concepto esté afecto a este DetalleConcepto
        Dim aporteobligatorio As Decimal
        Dim remAfecta As Decimal
        Dim detalleConcepto As New DetalleConcepto
        Dim aportePorPeriodo As New AportesPorPeriodo

        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0606")
        remAfecta = detConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto("I", detalleConcepto.IdDetalleConcepto, IdPlanilla)

        If remAfecta > 0 Then
            aportePorPeriodo = aportesPorPeriodoRepository.GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(IdPeriodoDeclaracion, personal.AfiliacionSPEntity.IdSistemaPensiones, 1)
            aporteobligatorio = remAfecta * aportePorPeriodo.Porcentaje
        Else
            aporteobligatorio = 0
        End If

        Return aporteobligatorio
    End Function


    'SISTEMA NACIONAL DE PENSIONES - D.L.19990
    Function Calculo0607(ByVal IdPlanilla As Int32, ByVal IdPeriodoDeclaracion As Int32, ByVal personal As Personal) As Decimal
        'Calculamos la remuneración afecta del siguiente modo:
        'Obtengo todos los detalleConceptoPeriodo para esta planilla, para este periodo, para este trabajador 
        'cuyo tipo concepto sea Ingreso y el detalle concepto esté afecto a este DetalleConcepto
        Dim aporteobligatorio As Decimal
        Dim remAfecta As Decimal
        Dim detalleConcepto As New DetalleConcepto
        Dim aportePorPeriodo As New AportesPorPeriodo

        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0607")
        remAfecta = detConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto("I", detalleConcepto.IdDetalleConcepto, IdPlanilla)

        If remAfecta > 0 Then
            aportePorPeriodo = aportesPorPeriodoRepository.GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(IdPeriodoDeclaracion, personal.AfiliacionSPEntity.IdSistemaPensiones, 1)
            aporteobligatorio = remAfecta * aportePorPeriodo.Porcentaje
        Else
            aporteobligatorio = 0
        End If

        Return aporteobligatorio
    End Function

    'RÉGIMEN PENSIONARIO - D.L. 20530
    Function Calculo0613(ByVal IdPlanilla As Int32, ByVal IdPeriodoDeclaracion As Int32, ByVal personal As Personal) As Decimal
        'Calculamos la remuneración afecta del siguiente modo:
        'Obtengo todos los detalleConceptoPeriodo para esta planilla, para este periodo, para este trabajador 
        'cuyo tipo concepto sea Ingreso y el detalle concepto esté afecto a este DetalleConcepto
        Dim aporteobligatorio As Decimal
        Dim remAfecta As Decimal
        Dim detalleConcepto As New DetalleConcepto
        Dim aportePorPeriodo As New AportesPorPeriodo

        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0613")
        remAfecta = detConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto("I", detalleConcepto.IdDetalleConcepto, IdPlanilla)

        If remAfecta > 0 Then
            aportePorPeriodo = aportesPorPeriodoRepository.GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(IdPeriodoDeclaracion, personal.AfiliacionSPEntity.IdSistemaPensiones, 1)
            aporteobligatorio = remAfecta * aportePorPeriodo.Porcentaje
        Else
            aporteobligatorio = 0
        End If

        Return aporteobligatorio
    End Function
    ''''ver luego crear tabla de adelantos
    'ADELANTO
    Function Calculo0701()

    End Function

    ''''ver luego como tratarlo
    'TARDANZAS
    Function Calculo0704()

    End Function

    ''''ver luego como tratarlo
    'INASISTENCIAS
    Function Calculo0705()

    End Function

    ''''Ver luego crear una tabla de otros descuentos no deducibles de la base imponible
    'OTROS DESCUENTOS NO DEDUCIBLES DE LA BASE IMPONIBLE 
    Function Calculo0706()

    End Function

    'ESSALUD (SEGURO REGULAR, CBBSP, AGRARIO/ACUICULTOR) - TRABAJADOR
    Function Calculo0804(ByVal IdPlanilla As Int32, ByVal IdPeriodoDeclaracion As Int32, ByVal personal As Personal)
        'Calculamos la remuneración afecta del siguiente modo:
        'Obtengo todos los detalleConceptoPeriodo para esta planilla, para este periodo, para este trabajador 
        'cuyo tipo concepto sea Ingreso y el detalle concepto esté afecto a este DetalleConcepto
        Dim EsSalud As Decimal
        Dim remAfecta As Decimal
        Dim detalleConcepto As New DetalleConcepto

        detalleConcepto = detalleConceptoBL.GetDetalleConceptoByCodTipoConcepto("0613")
        remAfecta = detConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto("I", detalleConcepto.IdDetalleConcepto, IdPlanilla)

        If remAfecta > 0 Then
            EsSalud = remAfecta * detalleConcepto.FactorVigenteEntity.ValorFactor
        Else
            EsSalud = 0
        End If

        Return EsSalud
    End Function
End Class
