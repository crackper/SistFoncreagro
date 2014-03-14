Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class AvanceFisicoBL : Implements IAvanceFisicoBL

    Dim factoryrepository As IAvanceFisicoRepository

    Public Sub New()
        factoryrepository = New AvanceFisicoRepository
    End Sub

    Public Function DeleteAvanceFisico(ByVal _id As Integer) As String Implements IAvanceFisicoBL.DeleteAvanceFisico
        Return factoryrepository.DeleteAvanceFisico(_id)
    End Function

    Public Function SaveAvanceFisico(ByVal _AvanceFisico As BussinessEntities.AvanceFisico) As Integer Implements IAvanceFisicoBL.SaveAvanceFisico
        Return factoryrepository.SaveAvanceFisico(_AvanceFisico)
    End Function

    Public Function GetAvanceFisicoByIdProyecto(ByVal _IdProyecto As Integer, ByVal _Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.AvanceFisico) Implements IAvanceFisicoBL.GetAvanceFisicoByIdProyecto
        Return factoryrepository.GetAvanceFisicoByIdProyecto(_IdProyecto, _Mes)
    End Function

    Public Sub NewAvanceFisico(ByVal _IdProyecto As Integer, ByVal _Anio As Integer, ByVal _Mes As Integer) Implements IAvanceFisicoBL.NewAvanceFisico
        factoryrepository.NewAvanceFisico(_IdProyecto, _Anio, _Mes)
    End Sub
End Class
