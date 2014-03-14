Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class PresupuestoBL : Implements IPresupuestoBL

    Dim factoryrepository As IPresupuestoRepository

    Public Sub New()
        factoryrepository = New PresupuestoRepository
    End Sub
    Public Sub eliminarpresupuesto(ByVal id As Integer) Implements IPresupuestoBL.eliminarpresupuesto
        factoryrepository.eliminarpresupuesto(id)
    End Sub

    Public Function GetAllFromPresupuesto() As System.Collections.Generic.List(Of BussinessEntities.Presupuesto) Implements IPresupuestoBL.GetAllFromPresupuesto
        Return factoryrepository.GetAllFromPresupuesto()
    End Function

    Public Function GetPRESUPUESTOByIdPresupuesto(ByVal id As System.IndexOutOfRangeException) As BussinessEntities.Presupuesto Implements IPresupuestoBL.GetPRESUPUESTOByIdPresupuesto
        Return factoryrepository.GetPRESUPUESTOByIdPresupuesto(id)
    End Function

    Public Sub RegistrarPresupuesto(ByVal presupesto As BussinessEntities.Presupuesto) Implements IPresupuestoBL.RegistrarPresupuesto
        factoryrepository.RegistrarPresupuesto(presupesto)
    End Sub
End Class
