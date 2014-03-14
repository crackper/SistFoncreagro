Imports SistFoncreagro.BussinessEntities
Public Interface IMonedaBL
    Function GetAllFromMoneda() As List(Of Moneda)
    Function GetMonedaByIdMoneda(ByVal IdMoneda As Int32) As Moneda
    Sub SaveMoneda(ByVal _Moneda As Moneda)
    Sub DeleteMoneda(ByVal IdMoneda As Int32)

End Interface
