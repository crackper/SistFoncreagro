Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class TipocambioBL : Implements ITipoCambioBL

    Dim factoryrepository As ITipoCambioRepository

    Public Sub New()
        factoryrepository = New TipoCambioRepository
    End Sub

    Public Sub DeleteTIPOCAMBIO(ByVal IdTipCambio As Integer) Implements ITipoCambioBL.DeleteTIPOCAMBIO
        factoryrepository.DeleteTIPOCAMBIO(IdTipCambio)

    End Sub

    Public Function GetAllFromTIPOCAMBIO() As System.Collections.Generic.List(Of BussinessEntities.TipoCambio) Implements ITipoCambioBL.GetAllFromTIPOCAMBIO
        Return factoryrepository.GetAllFromTIPOCAMBIO()
    End Function

    Public Function GetTIPOCAMBIOByIdTipCambio(ByVal IdTipoCambio As Integer) As BussinessEntities.TipoCambio Implements ITipoCambioBL.GetTIPOCAMBIOByIdTipCambio
        Return factoryrepository.GetTIPOCAMBIOByIdTipCambio(IdTipoCambio)
    End Function

    Public Function GetTIPOCAMBIOByFecha(ByVal Fecha As Date) As Decimal Implements ITipoCambioBL.GetTIPOCAMBIOByFecha
        Return factoryrepository.GetTIPOCAMBIOByFecha(Fecha)
    End Function

    Public Function GetTIPOCAMBIOByAnioMes(ByVal Anio As Integer, ByVal Mes As Integer) As BussinessEntities.TipoCambio Implements ITipoCambioBL.GetTIPOCAMBIOByAnioMes
        Return factoryrepository.GetTIPOCAMBIOByAnioMes(Anio, Mes)
    End Function

    Public Function GetNumeroRegistrosFromTIPOCAMBIOByAnioMes(ByVal Anio As Integer, ByVal Mes As Integer) As Integer Implements ITipoCambioBL.GetNumeroRegistrosFromTIPOCAMBIOByAnioMes
        Return factoryrepository.GetNumeroRegistrosFromTIPOCAMBIOByAnioMes(Anio, Mes)
    End Function

    Public Function GetTIPOCAMBIOByAnioMesDia(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As Decimal Implements ITipoCambioBL.GetTIPOCAMBIOByAnioMesDia
        Return factoryrepository.GetTIPOCAMBIOByAnioMesDia(Anio, Mes, Dia)
    End Function

    Public Function GetTIPOCAMBIOByAnio(ByVal Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoCambio) Implements ITipoCambioBL.GetTIPOCAMBIOByAnio
        Return factoryrepository.GetTIPOCAMBIOByAnio(Anio)
    End Function

    Public Function SaveTIPOCAMBIO(ByVal _TipoCambio As BussinessEntities.TipoCambio) As Integer Implements ITipoCambioBL.SaveTIPOCAMBIO
        Return factoryrepository.SaveTIPOCAMBIO(_TipoCambio)
    End Function

    Public Function GetTIPOCAMBIOCompraByFecha(ByVal Fecha As Date) As Decimal Implements ITipoCambioBL.GetTIPOCAMBIOCompraByFecha
        Return factoryrepository.GetTIPOCAMBIOCompraByFecha(Fecha)
    End Function

    Public Function GetTIPOCAMBIO1ByAnioMesDia(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As Decimal Implements ITipoCambioBL.GetTIPOCAMBIO1ByAnioMesDia
        Return factoryrepository.GetTIPOCAMBIO1ByAnioMesDia(Anio, Mes, Dia)
    End Function
End Class
