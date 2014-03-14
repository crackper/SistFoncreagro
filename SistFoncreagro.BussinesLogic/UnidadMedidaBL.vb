Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class UnidadMedidaBL : Implements IUnidadMedidaBL

    Dim unidadMedidaRepository As IUnidadMedidaRepository
    Sub New()
        unidadMedidaRepository = New UnidadMedidaRepository
    End Sub
    Public Function GetAllFromUnidadMedidaByIdUnidadMedida(ByVal IdUnidadMedida As Integer) As BussinessEntities.UnidadMedida Implements IUnidadMedidaBL.GetAllFromUnidadMedidaByIdUnidadMedida
        Return unidadMedidaRepository.GetAllFromUnidadMedidaByIdUnidadMedida(IdUnidadMedida)
    End Function
    Public Function GetAllFromUnidadMedida() As System.Collections.Generic.List(Of BussinessEntities.UnidadMedida) Implements IUnidadMedidaBL.GetAllFromUnidadMedida
        Return unidadMedidaRepository.GetAllFromUnidadMedida
    End Function
    Public Sub SaveUnidadMedida(ByVal unidadMedida As BussinessEntities.UnidadMedida) Implements IUnidadMedidaBL.SaveUnidadMedida
        unidadMedidaRepository.SaveUnidadMedida(unidadMedida)
    End Sub
    Public Sub DeleteUnidadMedida(ByVal IdUnidaMedida As Integer) Implements IUnidadMedidaBL.DeleteUnidadMedida
        unidadMedidaRepository.DeleteUnidadMedida(IdUnidaMedida)
    End Sub
End Class
