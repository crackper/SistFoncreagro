Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class BancoBL : Implements IBancoBL
    Dim factoryrepository As IBancoRepository

    Public Sub New()
        factoryrepository = New BancoRepository
    End Sub
    Public Function GetAllFromBANCO() As System.Collections.Generic.List(Of BussinessEntities.Banco) Implements IBancoBL.GetAllFromBANCO
        Return factoryrepository.GetAllFromBANCO
    End Function

    Public Sub SaveBanco(ByVal _Banco As BussinessEntities.Banco) Implements IBancoBL.SaveBanco
        factoryrepository.SaveBanco(_Banco)
    End Sub

    Public Function GetBANCOByIdBanco(ByVal IdBanco As Integer) As BussinessEntities.Banco Implements IBancoBL.GetBANCOByIdBanco
        Return factoryrepository.GetBANCOByIdBanco(IdBanco)
    End Function
End Class
