Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DerechoHabienteBL : Implements IDerechoHabienteBL
    Dim factoryrepository As IDerechoHabienteRepository

    Public Sub New()
        factoryrepository = New DerechoHabienteRepository
    End Sub

    Public Function SaveDERECHOHABIENTE(ByVal derechoHabiente As BussinessEntities.DerechoHabiente) As Integer Implements IDerechoHabienteBL.SaveDERECHOHABIENTE
        Return factoryrepository.SaveDERECHOHABIENTE(derechoHabiente)
    End Function

    Public Function GetDERECHOHABIENTEConyugueByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.DerechoHabiente) Implements IDerechoHabienteBL.GetDERECHOHABIENTEConyugueByIdPersonal
        Return factoryrepository.GetDERECHOHABIENTEConyugueByIdPersonal(IdPersonal)
    End Function

    Public Function GetDERECHOHABIENTEHijoByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.DerechoHabiente) Implements IDerechoHabienteBL.GetDERECHOHABIENTEHijoByIdPersonal
        Return factoryrepository.GetDERECHOHABIENTEHijoByIdPersonal(IdPersonal)
    End Function

    Public Function GetDERECHOHABIENTEOtrosVinculosByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.DerechoHabiente) Implements IDerechoHabienteBL.GetDERECHOHABIENTEOtrosVinculosByIdPersonal
        Return factoryrepository.GetDERECHOHABIENTEOtrosVinculosByIdPersonal(IdPersonal)
    End Function

    Public Sub DeleteDerechoHabiente(ByVal IdPersonal As Integer, ByVal IdDerechoHabiente As Integer) Implements IDerechoHabienteBL.DeleteDerechoHabiente
        factoryrepository.DeleteDerechoHabiente(IdPersonal, IdDerechoHabiente)
    End Sub
End Class
