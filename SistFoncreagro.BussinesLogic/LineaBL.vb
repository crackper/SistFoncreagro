Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class LineaBL : Implements ILineaBL
    Dim factoryrepository As ILineaRepository

    Public Sub New()
        factoryrepository = New LineaRepository
    End Sub

    Public Function GetAllFromLINEA() As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaBL.GetAllFromLINEA
        Return factoryrepository.GetAllFromLINEA()
    End Function

    Public Function GetLINEAByIdTransaccion(ByVal IdTransaccion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaBL.GetLINEAByIdTransaccion
        Return factoryrepository.GetLINEAByIdTransaccion(IdTransaccion)
    End Function

    Public Sub DeleteLINEA(ByVal IdLinea As Integer) Implements ILineaBL.DeleteLINEA
        factoryrepository.DeleteLINEA(IdLinea)
    End Sub

    Public Function GetLINEAByIdLinea(ByVal IdLinea As Integer) As BussinessEntities.Linea Implements ILineaBL.GetLINEAByIdLinea
        Return factoryrepository.GetLINEAByIdLinea(IdLinea)
    End Function
    Public Sub GenerarLINEA(ByVal IdTransaccion As Integer) Implements ILineaBL.GenerarLINEA
        factoryrepository.GenerarLINEA(IdTransaccion)
    End Sub
    Public Function GetNumeroRegistrosFromLINEA(ByVal IdTransaccion As Integer) As Integer Implements ILineaBL.GetNumeroRegistrosFromLINEA
        Return factoryrepository.GetNumeroRegistrosFromLINEA(IdTransaccion)
    End Function

    Public Sub DeleteLINEAByFlag(ByVal IdTransaccion As Integer) Implements ILineaBL.DeleteLINEAByFlag
        factoryrepository.DeleteLINEAByFlag(IdTransaccion)
    End Sub

    Public Function GetLINEAByIdTransaccionAndFlag(ByVal IdTransaccion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaBL.GetLINEAByIdTransaccionAndFlag
        Return factoryrepository.GetLINEAByIdTransaccionAndFlag(IdTransaccion)
    End Function

    Public Sub GenerarLINEACaja(ByVal IdTransaccion As Integer) Implements ILineaBL.GenerarLINEACaja
        factoryrepository.GenerarLINEACaja(IdTransaccion)
    End Sub
    Public Sub UpdateEstadoLINEA(ByVal IdLinea As Integer) Implements ILineaBL.UpdateEstadoLINEA
        factoryrepository.UpdateEstadoLINEA(IdLinea)
    End Sub
    Public Function SaveLINEA(ByVal _Linea As BussinessEntities.Linea) As Integer Implements ILineaBL.SaveLINEA
        Return factoryrepository.SaveLINEA(_Linea)
    End Function

    Public Function GetLINEACaja(ByVal Anio As Integer, ByVal IdProveedorCliente As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaBL.GetLINEACaja
        Return factoryrepository.GetLINEACaja(Anio, IdProveedorCliente, Flag)
    End Function

    Public Function GetLINEACajaMasivos(ByVal Anio As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaBL.GetLINEACajaMasivos
        Return factoryrepository.GetLINEACajaMasivos(Anio, Flag)
    End Function

    Public Function GetTRANSACCIONByIdLinea(ByVal IdLinea As Integer) As Integer Implements ILineaBL.GetTRANSACCIONByIdLinea
        Return factoryrepository.GetTRANSACCIONByIdLinea(IdLinea)
    End Function

    Public Function GetLINEADiario(ByVal Coa As Integer, ByVal OpFinan As Integer) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaBL.GetLINEADiario
        Return factoryrepository.GetLINEADiario(Coa, OpFinan)
    End Function

    Public Sub UpdateMontosLINEA(ByVal idLinea As Integer, ByVal monto As Decimal) Implements ILineaBL.UpdateMontosLINEA
        factoryrepository.UpdateMontosLINEA(idLinea, monto)
    End Sub

    Public Function GetLINEAByRegistro(ByVal Registro As String, ByVal Coa As String, ByVal Cuenta As String) As BussinessEntities.Linea Implements ILineaBL.GetLINEAByRegistro
        Return factoryrepository.GetLINEAByRegistro(Registro, Coa, Cuenta)
    End Function

    Public Function GetNumeroRegistrosFromLINEA1(ByVal IdTransaccion As Integer) As Integer Implements ILineaBL.GetNumeroRegistrosFromLINEA1
        Return factoryrepository.GetNumeroRegistrosFromLINEA1(IdTransaccion)
    End Function
End Class
