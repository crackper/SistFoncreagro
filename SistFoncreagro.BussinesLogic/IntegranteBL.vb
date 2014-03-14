Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class IntegranteBL : Implements IIntegranteBL
    Dim factoryrepository As IIntegranteRepository
    Public Sub New()
        factoryrepository = New IntegranteRepository
    End Sub

    Public Sub DeleteINTEGRANTE(ByVal IdIntegrante As Integer) Implements IIntegranteBL.DeleteINTEGRANTE
        factoryrepository.DeleteINTEGRANTE(IdIntegrante)
    End Sub

    Public Function GetINTEGRANTEByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Integrante) Implements IIntegranteBL.GetINTEGRANTEByIdDetalleEje
        Return factoryrepository.GetINTEGRANTEByIdDetalleEje(IdDetalleEje)
    End Function

    Public Function GetINTEGRANTEByIdIntegrante(ByVal IdIntegrante As Integer) As BussinessEntities.Integrante Implements IIntegranteBL.GetINTEGRANTEByIdIntegrante
        Return factoryrepository.GetINTEGRANTEByIdIntegrante(IdIntegrante)
    End Function

    Public Sub SaveINTEGRANTE(ByVal _Integrante As BussinessEntities.Integrante) Implements IIntegranteBL.SaveINTEGRANTE
        factoryrepository.SaveINTEGRANTE(_Integrante)
    End Sub
End Class
