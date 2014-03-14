Imports SistFoncreagro.BussinessEntities
Public Interface IIntegranteBL
    Function GetINTEGRANTEByIdDetalleEje(ByVal IdDetalleEje As Int32) As List(Of Integrante)
    Function GetINTEGRANTEByIdIntegrante(ByVal IdIntegrante As Int32) As Integrante
    Sub DeleteINTEGRANTE(ByVal IdIntegrante As Int32)
    Sub SaveINTEGRANTE(ByVal _Integrante As Integrante)
End Interface
