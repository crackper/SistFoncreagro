Imports SistFoncreagro.BussinessEntities
Public Interface IPresupuestoBL
    Function GetAllFromPresupuesto() As List(Of Presupuesto)
    Function GetPRESUPUESTOByIdPresupuesto(ByVal id As IndexOutOfRangeException) As Presupuesto
    Sub RegistrarPresupuesto(ByVal presupesto As Presupuesto)
    Sub eliminarpresupuesto(ByVal id As Int32)
End Interface
