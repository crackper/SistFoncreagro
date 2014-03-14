Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoMovimientoRepository : Inherits MasterDataAccess : Implements ITipoMovimientoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoMovimiento)
        Dim lista As New List(Of TipoMovimiento)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Tipo As New TipoMovimiento() With
                {
                 .IdTipoMovimiento = reader.GetValue(0),
                 .Descripcion = reader.GetValue(1)
                }

                lista.Add(_Tipo)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromTIPOMOVIMIENTO() As System.Collections.Generic.List(Of BussinessEntities.TipoMovimiento) Implements ITipoMovimientoRepository.GetAllFromTIPOMOVIMIENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOMOVIMIENTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOMOVIMIENTOByIdTipoMovimiento(ByVal IdTipoMovimiento As Integer) As BussinessEntities.TipoMovimiento Implements ITipoMovimientoRepository.GetTIPOMOVIMIENTOByIdTipoMovimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOMOVIMIENTOByIdTipoMovimiento")
        command.Parameters.AddWithValue("IdTipoMovimiento", IdTipoMovimiento)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
