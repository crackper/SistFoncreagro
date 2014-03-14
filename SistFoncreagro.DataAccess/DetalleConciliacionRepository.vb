Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetalleConciliacionRepository : Inherits MasterDataAccess : Implements IDetalleConciliacionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleConciliacion)
        Dim lista As New List(Of DetalleConciliacion)
        Dim proveedorRepository As New ProveedorClienteRepository
        Dim tipomovimientoRepository As New TipoMovimientoRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DetalleConciliacion As New DetalleConciliacion() With
                {
                  .IdDetalle = reader.GetValue(0),
                  .IdConciliacion = reader.GetValue(1),
                  .Fecha = reader.GetValue(2),
                  .Glosa = reader.GetValue(3),
                  .IdProveedorCliente = reader.GetValue(4),
                  .Monto = reader.GetValue(5),
                  .IdTipoMovimiento = reader.GetValue(6)
                }
                _DetalleConciliacion.Coa = proveedorRepository.GetAllFromProveedorClienteById(reader.GetValue(4))
                _DetalleConciliacion.TipoMovimiento = tipomovimientoRepository.GetTIPOMOVIMIENTOByIdTipoMovimiento(reader.GetValue(6))
                lista.Add(_DetalleConciliacion)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteDETALLECONCILIACION(ByVal IdDetalle As Integer) Implements IDetalleConciliacionRepository.DeleteDETALLECONCILIACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDETALLECONCILIACION")
        command.Parameters.AddWithValue("IdDetalle", IdDetalle)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDETALLECONCILIACIONByIdConciliacion(ByVal IdConciliacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleConciliacion) Implements IDetalleConciliacionRepository.GetDETALLECONCILIACIONByIdConciliacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLECONCILIACIONByIdConciliacion")
        command.Parameters.AddWithValue("IdConciliacion", IdConciliacion)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDETALLECONCILIACIONByIdDetalle(ByVal IdDetalle As Integer) As BussinessEntities.DetalleConciliacion Implements IDetalleConciliacionRepository.GetDETALLECONCILIACIONByIdDetalle
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLECONCILIACIONByIdDetalle")
        command.Parameters.AddWithValue("IdDetalle", IdDetalle)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveDETALLECONCILIACION(ByVal _DetalleConciliacion As BussinessEntities.DetalleConciliacion) Implements IDetalleConciliacionRepository.SaveDETALLECONCILIACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDETALLECONCILIACION")
        command.Parameters.AddWithValue("Fecha", _DetalleConciliacion.Fecha)
        command.Parameters.AddWithValue("Glosa", _DetalleConciliacion.Glosa)
        command.Parameters.AddWithValue("IdConciliacion", _DetalleConciliacion.IdConciliacion)
        command.Parameters.AddWithValue("IdDetalle", _DetalleConciliacion.IdDetalle)
        command.Parameters.AddWithValue("IdProveedorCliente", _DetalleConciliacion.IdProveedorCliente)
        command.Parameters.AddWithValue("IdTipoMovimiento", _DetalleConciliacion.IdTipoMovimiento)
        command.Parameters.AddWithValue("Monto", _DetalleConciliacion.Monto)
        MyBase.ExecuteReader(command)
    End Sub
End Class
