Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class LocalBL : Implements ILocalBL
    Dim factoryrepository As ILocalRepository

    Public Sub New()
        factoryrepository = New LocalRepository
    End Sub

    Public Function GetAllFromLOCAL() As System.Collections.Generic.List(Of BussinessEntities.Local) Implements ILocalBL.GetAllFromLOCAL
        Return factoryrepository.GetAllFromLOCAL
    End Function

    Public Function GetLOCALByIdLocal(ByVal IdLocal As Integer) As BussinessEntities.Local Implements ILocalBL.GetLOCALByIdLocal
        Return factoryrepository.GetLOCALByIdLocal(IdLocal)
    End Function

    Public Sub SaveLOCAL(ByVal _Local As BussinessEntities.Local) Implements ILocalBL.SaveLOCAL
        factoryrepository.SaveLOCAL(_Local)
    End Sub

    Public Sub UpdateEstadoLOCAL(ByVal IdLocal As Integer) Implements ILocalBL.UpdateEstadoLOCAL
        factoryrepository.UpdateEstadoLOCAL(IdLocal)
    End Sub

    Public Sub DeleteLOCAL(ByVal IdLocal As Integer) Implements ILocalBL.DeleteLOCAL
        factoryrepository.DeleteLOCAL(IdLocal)
    End Sub
End Class
