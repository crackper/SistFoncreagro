Imports SistFoncreagro.BussinessEntities
Public Interface ICaracteristicaRepository
    Function GetCARACTERISTICAByIdCaracteristica(ByVal IdCaracteristica As Int32) As Caracteristica
    Function GetCARACTERISTICAByIdFactor(ByVal IdFactor As Int32) As List(Of Caracteristica)
    Sub DeleteCARACTERISTICA(ByVal IdCaracteristica As Int32)
    Sub SaveCARACTERISTICA(ByVal _Caracteristica As Caracteristica)
End Interface
