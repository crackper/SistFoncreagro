Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoSpBL : Implements ITipoSpBL
    Dim factoryRepository As ITipoSpRepository
    Sub New()
        factoryRepository = New TipoSpRepository
    End Sub
    Public Function GetAllFromTipoSp() As System.Collections.Generic.List(Of BussinessEntities.TipoSp) Implements ITipoSpBL.GetAllFromTipoSp
        Return factoryRepository.GetAllFromTipoSp()
    End Function

    Public Sub SaveTipoSp(ByVal tipoSp As BussinessEntities.TipoSp) Implements ITipoSpBL.SaveTipoSp
        factoryRepository.SaveTipoSp(tipoSp)
    End Sub
End Class
