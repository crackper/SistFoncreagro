Imports SistFoncreagro.BussinessEntities

Public Interface ITipoPagoRepository
    Function GetAllFromTipoPago() As List(Of TipoPago)
    Function GetAllFromTipoPagoByIdTipo(ByVal idTipoPago As Int32) As TipoPago
    Sub SaveTipoPago(ByVal tipoPago As TipoPago)
End Interface
