Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class InsumosBL : Implements IInsumosBL
    Dim factoryrepository As IInsumosRepository
    Public Sub New()
        factoryrepository = New InsumosRepository
    End Sub

    Public Sub DeleteINSUMOS(ByVal IdInsumo As Integer) Implements IInsumosBL.DeleteINSUMOS
        factoryrepository.DeleteINSUMOS(IdInsumo)
    End Sub

    Public Function GetINSUMOSByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Insumos) Implements IInsumosBL.GetINSUMOSByIdControl
        Return factoryrepository.GetINSUMOSByIdControl(IdControl)
    End Function

    Public Function GetINSUMOSByIdInsumo(ByVal IdInsumo As Integer) As BussinessEntities.Insumos Implements IInsumosBL.GetINSUMOSByIdInsumo
        Return factoryrepository.GetINSUMOSByIdInsumo(IdInsumo)
    End Function

    Public Sub SaveINSUMOS(ByVal _Insumos As BussinessEntities.Insumos) Implements IInsumosBL.SaveINSUMOS
        factoryrepository.SaveINSUMOS(_Insumos)
    End Sub
End Class
