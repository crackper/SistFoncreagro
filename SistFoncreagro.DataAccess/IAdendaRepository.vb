Imports SistFoncreagro.BussinessEntities

Public Interface IAdendaRepository
    Function GetAllFromAdenda() As List(Of Adenda)
    Function GetFromAdendaByIdConvenio(ByVal _id As Int32) As List(Of Adenda)
    Function GetFromAdendaByIdAdenda(ByVal _id As Int32) As Adenda
    Function SaveAdenda(ByVal _Adenda As Adenda) As Int32
    Sub DeleteAdenda(ByVal _id As Int32)
End Interface
