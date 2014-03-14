Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoCtaBancariaBL : Implements ITipoCtaBancariaBL
    Dim factoryrepository As ITipoCtaBancariaRepository
    Public Sub New()
        factoryrepository = New TipoCtaBancariaRepository
    End Sub
    Public Function GetAllFromTIPOCTABANCARIA() As System.Collections.Generic.List(Of BussinessEntities.TipoCtaBancaria) Implements ITipoCtaBancariaBL.GetAllFromTIPOCTABANCARIA
        Return factoryrepository.GetAllFromTIPOCTABANCARIA
    End Function

    Public Function GetTIPOCTABANCARIAByIdTipoCtaBancaria(ByVal IdTipoCtaBancaria As Integer) As BussinessEntities.TipoCtaBancaria Implements ITipoCtaBancariaBL.GetTIPOCTABANCARIAByIdTipoCtaBancaria
        Return factoryrepository.GetTIPOCTABANCARIAByIdTipoCtaBancaria(IdTipoCtaBancaria)
    End Function
End Class
