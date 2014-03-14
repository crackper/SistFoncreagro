Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess

Public Class TipoConvenioBL : Implements ITipoConvenioBL

    Dim factoryrepository As ITipoConvenioRepository

    Public Sub New()
        factoryrepository = New TipoConvenioRepository
    End Sub

    Public Function GetAllFromTipoConvenio() As System.Collections.Generic.List(Of BussinessEntities.TipoConvenio) Implements ITipoConvenioBL.GetAllFromTipoConvenio
        Return factoryrepository.GetAllFromTipoConvenio
    End Function

    Public Sub SaveTipoConvenio(ByVal _TipoConvenio As BussinessEntities.TipoConvenio) Implements ITipoConvenioBL.SaveTipoConvenio
        factoryrepository.SaveTipoConvenio(_TipoConvenio)
    End Sub

    Public Function GetFromTipoConvenioById(ByVal id As Integer) As BussinessEntities.TipoConvenio Implements ITipoConvenioBL.GetFromTipoConvenioById
        Return factoryrepository.GetTipoConvenioByIdTipoConvenio(id)
    End Function

    Public Sub DeleteTipoConvenio(ByVal id As Integer) Implements ITipoConvenioBL.DeleteTipoConvenio
        factoryrepository.DeleteTipoConvenio(id)
    End Sub
End Class
