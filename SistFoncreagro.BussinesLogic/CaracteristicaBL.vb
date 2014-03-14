Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class CaracteristicaBL : Implements ICaracteristicaBL
    Dim factoryrepository As ICaracteristicaRepository

    Public Sub New()
        factoryrepository = New CaracteristicaRepository
    End Sub

    Public Sub DeleteCARACTERISTICA(ByVal IdCaracteristica As Integer) Implements ICaracteristicaBL.DeleteCARACTERISTICA
        factoryrepository.DeleteCARACTERISTICA(IdCaracteristica)
    End Sub

    Public Function GetCARACTERISTICAByIdCaracteristica(ByVal IdCaracteristica As Integer) As BussinessEntities.Caracteristica Implements ICaracteristicaBL.GetCARACTERISTICAByIdCaracteristica
        Return factoryrepository.GetCARACTERISTICAByIdCaracteristica(IdCaracteristica)
    End Function

    Public Function GetCARACTERISTICAByIdFactor(ByVal IdFactor As Integer) As System.Collections.Generic.List(Of BussinessEntities.Caracteristica) Implements ICaracteristicaBL.GetCARACTERISTICAByIdFactor
        Return factoryrepository.GetCARACTERISTICAByIdFactor(IdFactor)
    End Function

    Public Sub SaveCARACTERISTICA(ByVal _Caracteristica As BussinessEntities.Caracteristica) Implements ICaracteristicaBL.SaveCARACTERISTICA
        factoryrepository.SaveCARACTERISTICA(_Caracteristica)
    End Sub
End Class
