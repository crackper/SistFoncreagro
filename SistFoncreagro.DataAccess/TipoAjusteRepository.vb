Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoAjusteRepository : Inherits MasterDataAccess : Implements ITipoAjusteRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoAjuste)
        Dim lista As New List(Of TipoAjuste)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoAjuste As New TipoAjuste() With
                {
                   .Descripcion = reader.GetValue(0),
                   .IdTipoAjuste = reader.GetValue(1)
                }
                lista.Add(_TipoAjuste)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromTIPOAJUSTE() As System.Collections.Generic.List(Of BussinessEntities.TipoAjuste) Implements ITipoAjusteRepository.GetAllFromTIPOAJUSTE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOAJUSTE")
        Return SelectObjectFactory(command)
    End Function
End Class
