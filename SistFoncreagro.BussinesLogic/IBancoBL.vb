Imports SistFoncreagro.BussinessEntities
Public Interface IBancoBL
    Function GetAllFromBANCO() As List(Of Banco)
    Sub SaveBanco(ByVal _Banco As Banco)
    Function GetBANCOByIdBanco(ByVal IdBanco As Int32) As Banco
End Interface
