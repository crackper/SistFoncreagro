Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetOcxFacturaRepository : Inherits MasterDataAccess : Implements IDetOcxFacturaRepository
    Public Sub DeleteDetOcxFactura(ByVal IdDetOc As Integer) Implements IDetOcxFacturaRepository.DeleteDetOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDetOcxFactura")
        command.Parameters.AddWithValue("IdDetOcxFactura", IdDetOc)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetAllFromDetOcxFacturaById(ByVal idOcFact As Object) As System.Collections.Generic.List(Of BussinessEntities.DetOcxFactura) Implements IDetOcxFacturaRepository.GetAllFromDetOcxFacturaById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromDetOcxFacturaById")
        command.Parameters.AddWithValue("IdOcxFactura", idOcFact)
        Return SelectObjectFactory(command)
    End Function
    Public Sub SaveDetOcxFactura(ByVal detOcxFact As BussinessEntities.DetOcxFactura) Implements IDetOcxFacturaRepository.SaveDetOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetOcxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", detOcxFact.IdOcxFactura)
        command.Parameters.AddWithValue("IdDetalleOrdenCompra", detOcxFact.IdDetalleOrdenCompra)
        command.Parameters.AddWithValue("Cantidad", detOcxFact.Cantidad)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub SaveDetOcxFactura1(ByVal detOcxFact As System.Collections.Generic.List(Of BussinessEntities.DetOcxFactura)) Implements IDetOcxFacturaRepository.SaveDetOcxFactura1
        For Each det As DetOcxFactura In detOcxFact
            SaveDetOcxFactura(det)
        Next
    End Sub

    Public Sub SaveDetOcxFacturaPrec(ByVal detOcxFact As BussinessEntities.DetOcxFactura) Implements IDetOcxFacturaRepository.SaveDetOcxFacturaPrec
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetOcxFacturaPrec")
        command.Parameters.AddWithValue("IdOcxFactura", detOcxFact.IdOcxFactura)
        command.Parameters.AddWithValue("IdDetalleOrdenCompra", detOcxFact.IdDetalleOrdenCompra)
        command.Parameters.AddWithValue("Monto", detOcxFact.PCompraDetalle)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveDetOcxFacturaPrec1(ByVal detOcxFact As System.Collections.Generic.List(Of BussinessEntities.DetOcxFactura)) Implements IDetOcxFacturaRepository.SaveDetOcxFacturaPrec1
        For Each det As DetOcxFactura In detOcxFact
            SaveDetOcxFacturaPrec(det)
        Next
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetOcxFactura)
        Dim lista As New List(Of DetOcxFactura)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim detOc As New DetOcxFactura() With
                {.IdDetOcxFactura = reader.GetValue(0),
                 .IdOcxFactura = reader.GetValue(1),
                 .IdDetalleOrdenCompra = reader.GetValue(2),
                 .IdPlanContable = reader.GetValue(3),
                 .Cantidad = reader.GetValue(4),
                 .Estado = reader.GetValue(5),
                 .CCosto = reader.GetValue(6),
                 .Producto = reader.GetValue(7),
                 .PCompraDetalle = reader.GetValue(8)
                }
                lista.Add(detOc)
            End While
        End Using
        Return lista
    End Function

    Public Sub FinalizarRegistroDetOcxFactura(ByVal idOcFact As Integer) Implements IDetOcxFacturaRepository.FinalizarRegistroDetOcxFactura
        Dim command As SqlCommand = MyBase.CreateSPCommand("FinalizarRegistroDetOcxFactura")
        command.Parameters.AddWithValue("IdOcxFactura", idOcFact)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
