Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class ReciboBL : Implements IReciboBL
    Dim factoryrepository As IReciboRepository

    Public Sub New()
        factoryrepository = New ReciboRepository
    End Sub
    Public Sub DeleteRECIBO(ByVal IdRecibo As Integer) Implements IReciboBL.DeleteRECIBO
        factoryrepository.DeleteRECIBO(IdRecibo)
    End Sub

    Public Function GetAllFromRECIBO() As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboBL.GetAllFromRECIBO
        Return factoryrepository.GetAllFromRECIBO
    End Function

    Public Function GetRECIBOByIdRecibo(ByVal IdRecibo As Integer) As BussinessEntities.Recibo Implements IReciboBL.GetRECIBOByIdRecibo
        Return factoryrepository.GetRECIBOByIdRecibo(IdRecibo)
    End Function
    Public Function GetRECIBOByIdProyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboBL.GetRECIBOByIdProyecto
        Return factoryrepository.GetRECIBOByIdProyecto(IdProyecto)
    End Function

    Public Sub UpdateEstadoRECIBO(ByVal IdRecibo As Integer, ByVal Estado As String) Implements IReciboBL.UpdateEstadoRECIBO
        factoryrepository.UpdateEstadoRECIBO(IdRecibo, Estado)
    End Sub

    Public Function GetRECIBOByEstado(ByVal Estado As String) As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboBL.GetRECIBOByEstado
        Return factoryrepository.GetRECIBOByEstado(Estado)
    End Function

    Public Function GetRECIBOPendientes() As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboBL.GetRECIBOPendientes
        Return factoryrepository.GetRECIBOPendientes()
    End Function

    Public Function GetRECIBOByIdReciboRendicion(ByVal IdReciboRendicion As Integer) As BussinessEntities.Recibo Implements IReciboBL.GetRECIBOByIdReciboRendicion
        Return factoryrepository.GetRECIBOByIdReciboRendicion(IdReciboRendicion)
    End Function

    Public Sub SaveRECIBO(ByVal _Recibo As BussinessEntities.Recibo) Implements IReciboBL.SaveRECIBO
        factoryrepository.SaveRECIBO(_Recibo)
    End Sub
End Class
