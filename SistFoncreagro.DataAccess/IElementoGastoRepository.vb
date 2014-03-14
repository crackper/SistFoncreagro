Imports SistFoncreagro.BussinessEntities

Public Interface IElementoGastoRepository
    Function GetAllFromElementoGasto() As List(Of ElementoGasto)
    Function GetFromElementoGastoById(ByVal _id As Int32) As ElementoGasto
    Function GetFromElementoGastoByIdClasificacion(ByVal _id As Int32) As ElementoGasto
    Function SaveElementoGasto(ByVal _ElementoGasto As ElementoGasto) As Int32
    Function DeleteElementoGasto(ByVal _id As Int32) As String
End Interface
