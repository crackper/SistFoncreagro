Imports SistFoncreagro.BussinessEntities

Public Interface IDesembolsoBL
    Function GetAllFromDesembolsos() As List(Of Desembolso)
    Function GetFromDesembolsoByIdDesembolso(ByVal id As Int32) As Desembolso
    Function GetFromDesembolsoByIdConvenio(ByVal _id As Int32) As List(Of Desembolso)
    Function SaveDesembolso(ByVal _Desembolso As Desembolso) As Int32
    Sub DeleteDesembolso(ByVal _id As Int32)
End Interface
