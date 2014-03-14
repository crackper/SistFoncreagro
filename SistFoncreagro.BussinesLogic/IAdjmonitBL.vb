Imports SistFoncreagro.BussinessEntities

Public Interface IAdjmonitBL
    Function GetAllFromAdjMonit() As List(Of AdjMonit)
    Function GetADJMONITByIdAdjMonit(ByVal _id As Int32) As AdjMonit
    Function GetADJMONITByIdAndTabla(ByVal _Id As Int32, ByVal _Tabla As String) As List(Of AdjMonit)
    Function SaveAdjMonit(ByVal _AdjMonit As AdjMonit) As Int32
    Sub DeleteAdjMonit(ByVal _id As Int32)
End Interface
