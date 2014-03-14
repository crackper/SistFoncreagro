Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class SubdiarioBL : Implements ISubdiarioBL
    Dim factoryrepository As ISubdiarioRepository

    Public Sub New()
        factoryrepository = New SubdiarioRepository
    End Sub
    Public Sub DeleteSUBDIARIO(ByVal IdSubdiario As Integer) Implements ISubdiarioBL.DeleteSUBDIARIO
        factoryrepository.DeleteSUBDIARIO(IdSubdiario)
    End Sub

    Public Function GetSUBDIARIOByIdSubDiario(ByVal IdSubDiario As Integer) As BussinessEntities.Subdiario Implements ISubdiarioBL.GetSUBDIARIOByIdSubDiario
        Return factoryrepository.GetSUBDIARIOByIdSubDiario(IdSubDiario)
    End Function

    Public Sub SaveSUBDIARIO(ByVal _Subdiario As BussinessEntities.Subdiario) Implements ISubdiarioBL.SaveSUBDIARIO
        factoryrepository.SaveSUBDIARIO(_Subdiario)
    End Sub
    Public Function GetSUBDIARIOInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioBL.GetSUBDIARIOInTransaccion
        Return factoryrepository.GetSUBDIARIOInTransaccion(Anio, Mes)
    End Function

    Public Function GetSUBDIARIOInTransaccionByFlag(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioBL.GetSUBDIARIOInTransaccionByFlag
        Return factoryrepository.GetSUBDIARIOInTransaccionByFlag(Anio, Mes, Flag)
    End Function
    Public Function GetAllSUBDIARIO() As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioBL.GetAllSUBDIARIO
        Return factoryrepository.GetAllSUBDIARIO()
    End Function

    Public Sub UpdateEstadoSUBDIARIO(ByVal IdSubdiario As Integer) Implements ISubdiarioBL.UpdateEstadoSUBDIARIO
        factoryrepository.UpdateEstadoSUBDIARIO(IdSubdiario)
    End Sub

    Public Function GetSUBDIARIOByIdOpFinanciera(ByVal IdOpFinanciera As Integer) As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioBL.GetSUBDIARIOByIdOpFinanciera
        Return factoryrepository.GetSUBDIARIOByIdOpFinanciera(IdOpFinanciera)
    End Function

    Public Function GetAllSUBDIARIOActivos() As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioBL.GetAllSUBDIARIOActivos
        Return factoryrepository.GetAllSUBDIARIOActivos()
    End Function
End Class
