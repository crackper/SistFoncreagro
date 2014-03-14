Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class AportesBL : Implements IAportesBL
    Dim factoryRepository As IAportesSpRepository
    Sub New()
        factoryRepository = New AportesSpRepository
    End Sub
    Public Function GetAllFromAportesSp() As System.Collections.Generic.List(Of BussinessEntities.AporteSp) Implements IAportesBL.GetAllFromAportesSp
        Return factoryRepository.GetAllFromAportesSp()
    End Function

    Public Sub SaveAportesSp(ByVal aportes As BussinessEntities.AporteSp) Implements IAportesBL.SaveAportesSp
        'No se implementa borrar
    End Sub

    Public Function GetAllFromAporteAnterior(ByVal idSistema As Integer, ByVal idPerido As Integer) As Object Implements IAportesBL.GetAllFromAporteAnterior
        Return factoryRepository.GetAllFromAporteAnterior(idSistema, idPerido)
    End Function

    Public Function GetAllFromAporteGuardado(ByVal idSistema As Integer, ByVal idPerido As Integer) As Object Implements IAportesBL.GetAllFromAporteGuardado
        Return factoryRepository.GetAllFromAporteGuardado(idSistema, idPerido)
    End Function
End Class
