Imports SistFoncreagro.BussinessEntities

Public Interface IEjerPresupBL
    Function GetAllFromEjerPresup() As List(Of EjerPresup)
    Function GetEjerPresupByEstado(ByVal _estado As String) As EjerPresup
    Function GetEjerPresupByIdEjerPresup(ByVal _id As Int32) As EjerPresup
    Function SaveEjerPresup(ByVal _EjerPresup As EjerPresup) As String
    Function DeleteEjerPresup(ByVal _id As Int32) As String
    Function EjerPresupEstado() As String
End Interface
