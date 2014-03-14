Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PeriodoLaboralBL : Implements IPeriodoLaboralBL

    Dim factoryrepository As IPeriodoLaboralRepository

    Public Sub New()
        factoryrepository = New PeriodoLaboralRepository
    End Sub

    Public Sub DeletePeriodoLaboral(ByVal IdPeriodoLaboral As Integer) Implements IPeriodoLaboralBL.DeletePeriodoLaboral
        factoryrepository.DeletePeriodoLaboral(IdPeriodoLaboral)
    End Sub

    Public Function GetAllFromPERIODOLABORAL(ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralBL.GetAllFromPERIODOLABORAL
        Return factoryrepository.GetAllFromPERIODOLABORAL(argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALActualActivoByIdPersonal(ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralBL.GetPERIODOLABORALActualActivoByIdPersonal
        Return factoryrepository.GetPERIODOLABORALActualActivoByIdPersonal(IdPersonal, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALAUltimoByIdPersonal(ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralBL.GetPERIODOLABORALAUltimoByIdPersonal
        Return factoryrepository.GetPERIODOLABORALAUltimoByIdPersonal(IdPersonal, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALAValidosByFecha(ByVal Fecha As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralBL.GetPERIODOLABORALAValidosByFecha
        Return factoryrepository.GetPERIODOLABORALAValidosByFecha(Fecha, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALAValidosByFechaAndByIdPersonal(ByVal Fecha As Date, ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralBL.GetPERIODOLABORALAValidosByFechaAndByIdPersonal
        Return factoryrepository.GetPERIODOLABORALAValidosByFechaAndByIdPersonal(Fecha, IdPersonal, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALByIdPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As BussinessEntities.PeriodoLaboral Implements IPeriodoLaboralBL.GetPERIODOLABORALByIdPeriodoLaboral
        Return factoryrepository.GetPERIODOLABORALByIdPeriodoLaboral(IdPeriodoLaboral, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALByIdPersonal(ByVal IdPersonal As Integer, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralBL.GetPERIODOLABORALByIdPersonal
        Return factoryrepository.GetPERIODOLABORALByIdPersonal(IdPersonal, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALDeBajaPorLiquidar(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralBL.GetPERIODOLABORALDeBajaPorLiquidar
        Return factoryrepository.GetPERIODOLABORALDeBajaPorLiquidar(Fecha1, Fecha2, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALLiquidadosPendientesDePago(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralBL.GetPERIODOLABORALLiquidadosPendientesDePago
        Return factoryrepository.GetPERIODOLABORALLiquidadosPendientesDePago(Fecha1, Fecha2, argPeriodoLaboral)
    End Function

    Public Function GetPERIODOLABORALLiquidadosPorRangoFecha(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal argPeriodoLaboral As BussinessEntities.ArgumentosPeriodolaboral) As System.Collections.Generic.List(Of BussinessEntities.PeriodoLaboral) Implements IPeriodoLaboralBL.GetPERIODOLABORALLiquidadosPorRangoFecha
        Return factoryrepository.GetPERIODOLABORALLiquidadosPorRangoFecha(Fecha1, Fecha2, argPeriodoLaboral)
    End Function

    Public Function GetUltimaFechcaFinPERIODOLABORALByIdPersonal(ByVal IdPeriodoLaboral As Integer) As String Implements IPeriodoLaboralBL.GetUltimaFechcaFinPERIODOLABORALByIdPersonal
        Return factoryrepository.GetUltimaFechcaFinPERIODOLABORALByIdPersonal(IdPeriodoLaboral)
    End Function

    Public Function SavePERIODOLABORAL(ByVal periodoLaboral As BussinessEntities.PeriodoLaboral) As Integer Implements IPeriodoLaboralBL.SavePERIODOLABORAL
        Return factoryrepository.SavePERIODOLABORAL(periodoLaboral)
    End Function

    Public Sub UpdateTelefonosPeriodoLaboral(ByVal IdPeriodoLaboral As Integer, ByVal EmailCoorporativo As String, ByVal TelefCoorp As String) Implements IPeriodoLaboralBL.UpdateTelefonosPeriodoLaboral
        factoryrepository.UpdateTelefonosPeriodoLaboral(IdPeriodoLaboral, EmailCoorporativo, TelefCoorp)
    End Sub
End Class
