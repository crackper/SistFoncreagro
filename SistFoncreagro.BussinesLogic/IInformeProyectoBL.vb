Imports SistFoncreagro.BussinessEntities

Public Interface IInformeProyectoBL
    Function GetInformeProyectoByIdProyecto(ByVal _idProy As Int32) As List(Of InformeProyecto)
    Function GetAllFromInformeProyectoById(ByVal _id As Int32) As InformeProyecto
    Function SaveInformeProyecto(ByVal _InformeProyecto As InformeProyecto) As Int32
    Sub DeleteInformeProyecto(ByVal _id As Int32)
End Interface
