Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class BonificacionVentaRepository : Inherits MasterDataAccess : Implements IBonificacionVentaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of BonificacionVenta)
        Dim lista As New List(Of BonificacionVenta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Bonificacion As New BonificacionVenta() With
                {
                   .IdBonificacion = reader.GetValue(0),
                   .IdTipoBonificacion = reader.GetValue(1),
                   .Importe = reader.GetValue(2),
                   .Cantidad = reader.GetValue(3),
                   .IdVenta = reader.GetValue(4),
                   .Glosa = reader.GetValue(5)
                  }

                lista.Add(_Bonificacion)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteBONIFICACIONVENTA(ByVal IdBonificacion As Integer) Implements IBonificacionVentaRepository.DeleteBONIFICACIONVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteBONIFICACIONVENTA")
        command.Parameters.AddWithValue("IdBonificacion", IdBonificacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetBONIFICACIONVENTAByIdBonificacion(ByVal IdBonificacion As Integer) As BussinessEntities.BonificacionVenta Implements IBonificacionVentaRepository.GetBONIFICACIONVENTAByIdBonificacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetBONIFICACIONVENTAByIdBonificacion")
        command.Parameters.AddWithValue("IdBonificacion", IdBonificacion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetBONIFICACIONVENTAByIdVenta(ByVal IdVenta As Integer) As System.Collections.Generic.List(Of BussinessEntities.BonificacionVenta) Implements IBonificacionVentaRepository.GetBONIFICACIONVENTAByIdVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetBONIFICACIONVENTAByIdVenta")
        command.Parameters.AddWithValue("IdVenta", IdVenta)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveBONIFICACIONVENTA(ByVal _Bonificacion As BussinessEntities.BonificacionVenta) Implements IBonificacionVentaRepository.SaveBONIFICACIONVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveBONIFICACIONVENTA")
        command.Parameters.AddWithValue("Cantidad", _Bonificacion.Cantidad)
        command.Parameters.AddWithValue("IdBonificacion", _Bonificacion.IdBonificacion)
        command.Parameters.AddWithValue("IdTipoBonificacion", _Bonificacion.IdTipoBonificacion)
        command.Parameters.AddWithValue("IdVenta", _Bonificacion.IdVenta)
        command.Parameters.AddWithValue("Importe", _Bonificacion.Importe)
        command.Parameters.AddWithValue("Glosa", _Bonificacion.Glosa)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
