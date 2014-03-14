Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoCtaContableBL : Implements ITipoCtaContableBL
    Dim factoryrepository As ITipoCtaContableRepository

    Public Sub New()
        factoryrepository = New TipoCtaContableRepository
    End Sub
    Public Function GetAllFromTIPOCTACONTABLE() As System.Collections.Generic.List(Of BussinessEntities.TipoCtaContable) Implements ITipoCtaContableBL.GetAllFromTIPOCTACONTABLE
        Return factoryrepository.GetAllFromTIPOCTACONTABLE
    End Function
End Class
