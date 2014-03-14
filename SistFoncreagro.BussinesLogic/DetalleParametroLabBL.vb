Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class DetalleParametroLabBL : Implements IDetalleParametroLabBL

    Dim factoryrepository As IDetalleParametroLabRepository

    Public Sub New()
        factoryrepository = New DetalleParametroLabRepository
    End Sub
    Public Sub DeleteDetalleParametroLab(ByVal IdDetalleParametroLab As Integer) Implements IDetalleParametroLabBL.DeleteDetalleParametroLab
        factoryrepository.DeleteDetalleParametroLab(IdDetalleParametroLab)
    End Sub

    Public Function GetDetalleParametrosLabByIdDetalleParametroLab(ByVal IdDetalleParametroLab As Integer) As BussinessEntities.DetalleParametroLab Implements IDetalleParametroLabBL.GetDetalleParametrosLabByIdDetalleParametroLab
        Return factoryrepository.GetDetalleParametrosLabByIdDetalleParametroLab(IdDetalleParametroLab)
    End Function

    Public Function GetDetalleParametrosLabByIdParametroLab(ByVal IdParametroLab As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleParametroLab) Implements IDetalleParametroLabBL.GetDetalleParametrosLabByIdParametroLab
        Return factoryrepository.GetDetalleParametrosLabByIdParametroLab(IdParametroLab)
    End Function

    Public Function SaveDetalleParametroLab(ByVal DetalleParametroLab As BussinessEntities.DetalleParametroLab) As Integer Implements IDetalleParametroLabBL.SaveDetalleParametroLab
        Return factoryrepository.SaveDetalleParametroLab(DetalleParametroLab)
    End Function

    Public Function GetDetalleParametrosLabVigenteByIdParametroLab(ByVal IdParametroLab As Integer) As BussinessEntities.DetalleParametroLab Implements IDetalleParametroLabBL.GetDetalleParametrosLabVigenteByIdParametroLab
        Return factoryrepository.GetDetalleParametrosLabVigenteByIdParametroLab(IdParametroLab)
    End Function
End Class
