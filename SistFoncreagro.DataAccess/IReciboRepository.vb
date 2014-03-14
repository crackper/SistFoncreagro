Imports SistFoncreagro.BussinessEntities
Public Interface IReciboRepository
    Function GetAllFromRECIBO() As List(Of Recibo)
    Function GetRECIBOByIdProyecto(ByVal IdProyecto As Int32) As List(Of Recibo)
    Function GetRECIBOByIdRecibo(ByVal IdRecibo As Int32) As Recibo
    Sub SaveRECIBO(ByVal _Recibo As Recibo)
    Function GetRECIBOByEstado(ByVal Estado As String) As List(Of Recibo)
    Function GetRECIBOPendientes() As List(Of Recibo)
    Function GetRECIBOByIdReciboRendicion(ByVal IdReciboRendicion As Int32) As Recibo
    Sub DeleteRECIBO(ByVal IdRecibo As Int32)
    Sub UpdateEstadoRECIBO(ByVal IdRecibo As Int32, ByVal Estado As String)
End Interface
