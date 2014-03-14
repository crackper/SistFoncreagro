Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class ActivarPresupuestoBL : Implements IActivarPresupuestoBL

    Dim factoryrepository As IActivarPresupuestoRepository

    Public Sub New()
        factoryrepository = New ActivarPresupuestoRepository
    End Sub

    Public Function GetACTIVARPRESUPByIdEjerPresup(ByVal _IdEjerPresup As Integer) As System.Collections.Generic.List(Of BussinessEntities.ActivarPresupuesto) Implements IActivarPresupuestoBL.GetACTIVARPRESUPByIdEjerPresup
        Return factoryrepository.GetACTIVARPRESUPByIdEjerPresup(_IdEjerPresup)
    End Function

    Public Sub NueActivarPresup(ByVal _IdEjerPresup As Integer) Implements IActivarPresupuestoBL.NueActivarPresup
        factoryrepository.NueActivarPresup(_IdEjerPresup)
    End Sub

    Public Sub UpdateActivarPresup(ByVal _ActivarPresup As BussinessEntities.ActivarPresupuesto) Implements IActivarPresupuestoBL.UpdateActivarPresup
        factoryrepository.UpdateActivarPresup(_ActivarPresup)
    End Sub

    Public Sub UpdateActivarPresup1(ByVal _ActivarPresup As System.Collections.Generic.List(Of BussinessEntities.ActivarPresupuesto)) Implements IActivarPresupuestoBL.UpdateActivarPresup1
        factoryrepository.UpdateActivarPresup1(_ActivarPresup)
    End Sub

    Public Function GetACTIVARPRESUPByIdProyAndIdEjerPresup(ByVal _IdEjerPresup As Integer, ByVal _IdProyecto As Integer) As BussinessEntities.ActivarPresupuesto Implements IActivarPresupuestoBL.GetACTIVARPRESUPByIdProyAndIdEjerPresup
        Return factoryrepository.GetACTIVARPRESUPByIdProyAndIdEjerPresup(_IdEjerPresup, _IdProyecto)
    End Function
End Class
