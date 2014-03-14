Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class TipoContratoBL : Implements ITipoContratoBL
    Dim factoryRepository As ITipoContratoRepository

    Sub New()
        factoryRepository = New TipoContratoRepository
    End Sub

    Public Function GetTipoContratoByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoContrato) Implements ITipoContratoBL.GetTipoContratoByIdCategoria
        Return Me.factoryRepository.GetTipoContratoByIdCategoria(idCategoria)
    End Function
End Class
