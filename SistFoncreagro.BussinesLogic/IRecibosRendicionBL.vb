Imports SistFoncreagro.BussinessEntities
Public Interface IRecibosRendicionBL
    Function GetAllFromRECIBOSRENDICION() As List(Of RecibosRendicion)
    Function GetRECIBOSRENDICIONByIdRendicion(ByVal IdRendicion As Int32) As List(Of RecibosRendicion)
    Function GetRECIBOSRENDICIONByIdReciboRendicion(ByVal IdReciboRendicion As Int32) As RecibosRendicion
    Sub SaveRECIBOSRENDICION(ByVal _Recibosrendicion As RecibosRendicion)
    Sub DeleteRECIBOSRENDICION(ByVal IdReciboRendicion As Int32)
End Interface
