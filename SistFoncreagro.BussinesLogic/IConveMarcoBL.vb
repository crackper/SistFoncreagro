Imports SistFoncreagro.BussinessEntities

Public Interface IConveMarcoBL
    Function GetAllFromConveMarco() As List(Of ConveMarco)
    Function GetFromConveMarcoByIdConveMarco(ByVal _id As Int32) As ConveMarco
    Function GetFromConveMarcoByParameter(ByVal _Texto As String) As List(Of ConveMarco)
    Function SaveConveMarco(ByVal _ConveMarco As ConveMarco) As Int32
    Sub DeleteConveMarco(ByVal _id As Int32)
End Interface
