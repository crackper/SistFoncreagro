Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoAjusteBL : Implements ITipoAjusteBL
    Dim factoryrepository As ITipoAjusteRepository

    Public Sub New()
        factoryrepository = New TipoAjusteRepository
    End Sub
    Public Function GetAllFromTIPOAJUSTE() As System.Collections.Generic.List(Of BussinessEntities.TipoAjuste) Implements ITipoAjusteBL.GetAllFromTIPOAJUSTE
        Return factoryrepository.GetAllFromTIPOAJUSTE
    End Function
End Class
