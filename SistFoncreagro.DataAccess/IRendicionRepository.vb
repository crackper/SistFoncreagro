Imports SistFoncreagro.BussinessEntities
Public Interface IRendicionRepository
    Function GetAllFromRENDICION() As List(Of Rendicion)
    Function GetRENDICIONByIdRendicion(ByVal IdRendicion As Int32) As Rendicion
    Function SaveRENDICION(ByVal _Rendicion As Rendicion) As Int32
    Function GetRENDICIONByEstado(ByVal Estado As String, ByVal mes As Int32) As List(Of Rendicion)
    Function GetRENDICIONPendientes(ByVal mes As Int32) As List(Of Rendicion)
    Sub DeleteRENDICION(ByVal IdRendicion As Int32)
    Sub UpdateObservacionRENDICION(ByVal IdRendicion As Int32, ByVal Observacion As String)
    Sub UpdateEstadoRENDICION(ByVal IdRendicion As Int32, ByVal Estado As String)
    Function GetTotalRendicion(ByVal IdRendicion As Int32) As Decimal
End Interface
