Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class AdjMonitBL : Implements IAdjmonitBL

    Dim factoryrepository As IAdjMonitRepository

    Public Sub New()
        factoryrepository = New AdjMonitRepository
    End Sub

    Public Sub DeleteAdjMonit(ByVal _id As Integer) Implements IAdjmonitBL.DeleteAdjMonit
        factoryrepository.DeleteAdjMonit(_id)
    End Sub

    Public Function GetADJMONITByIdAdjMonit(ByVal _id As Integer) As BussinessEntities.AdjMonit Implements IAdjmonitBL.GetADJMONITByIdAdjMonit
        Return factoryrepository.GetADJMONITByIdAdjMonit(_id)
    End Function

    Public Function GetADJMONITByIdAndTabla(ByVal _Id As Integer, ByVal _Tabla As String) As System.Collections.Generic.List(Of BussinessEntities.AdjMonit) Implements IAdjmonitBL.GetADJMONITByIdAndTabla
        Return factoryrepository.GetADJMONITByIdAndTabla(_Id, _Tabla)
    End Function

    Public Function GetAllFromAdjMonit() As System.Collections.Generic.List(Of BussinessEntities.AdjMonit) Implements IAdjmonitBL.GetAllFromAdjMonit
        Return factoryrepository.GetAllFromAdjMonit
    End Function

    Public Function SaveAdjMonit(ByVal _AdjMonit As BussinessEntities.AdjMonit) As Integer Implements IAdjmonitBL.SaveAdjMonit
        Return factoryrepository.SaveAdjMonit(_AdjMonit)
    End Function
End Class
