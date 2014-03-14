Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ProveedorDetalleCotizacionRepository : Inherits MasterDataAccess : Implements IProveedorDetalleCotizacionRepository
    Dim proveedor As IProveedorClienteRepository
    Sub New()
        proveedor = New ProveedorClienteRepository
    End Sub
    Public Function GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion(ByVal idDetalleReqCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion) Implements IProveedorDetalleCotizacionRepository.GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion
        Dim command As SqlCommand =
              MyBase.CreateSPCommand("GetAllFromProveedorDetalleCotizacionByIdDetalleReqCotizacion")
        command.Parameters.AddWithValue("IdDetalleReqCotizacion", idDetalleReqCotizacion)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveProveedorDetalleCotizacion(ByVal proveedorDetalleCoti As BussinessEntities.ProveedorDetalleCotizacion) Implements IProveedorDetalleCotizacionRepository.SaveProveedorDetalleCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveProveedorDetalleCotizacion")
        command.Parameters.AddWithValue("IdDetalleReqCotizacion", proveedorDetalleCoti.IdDetalleReqCotizacion)
        command.Parameters.AddWithValue("IdProveedor", proveedorDetalleCoti.IdProveedor)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveProveedorDetalleCotizacion1(ByVal proveedorDetalleCoti As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion)) Implements IProveedorDetalleCotizacionRepository.SaveProveedorDetalleCotizacion1
        For Each det As ProveedorDetalleCotizacion In proveedorDetalleCoti
            SaveProveedorDetalleCotizacion(det)
        Next
    End Sub

    Public Sub DeleteProveedor(ByVal proveedorDetCot As BussinessEntities.ProveedorDetalleCotizacion) Implements IProveedorDetalleCotizacionRepository.DeleteProveedor
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteProveedorFromProveedorDetalleCotizacion")
        command.Parameters.AddWithValue("IdDetalleReqCotizacion", proveedorDetCot.IdDetalleReqCotizacion)
        command.Parameters.AddWithValue("IdProveedor", proveedorDetCot.IdProveedor)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub DeleteProveedor1(ByVal proveedorDetCot As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion)) Implements IProveedorDetalleCotizacionRepository.DeleteProveedor1
        For Each det As ProveedorDetalleCotizacion In proveedorDetCot
            DeleteProveedor(det)
        Next
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ProveedorDetalleCotizacion)
        Dim listaProveedorDetalleCotiz As New List(Of ProveedorDetalleCotizacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim proveedorDetalleCoti As New ProveedorDetalleCotizacion
                With proveedorDetalleCoti
                    .IdProveedorDetalleCotizacion = reader.GetInt32(0)
                    .IdDetalleReqCotizacion = reader.GetInt32(1)
                    .IdProveedor = reader.GetInt32(2)
                    .Monto = reader.GetDecimal(3)
                    .Estado = reader.GetBoolean(4)
                End With
                proveedorDetalleCoti.Proveedor = proveedor.GetAllFromProveedorClienteById(reader.GetInt32(2))
                listaProveedorDetalleCotiz.Add(proveedorDetalleCoti)
            End While
        End Using
        Return listaProveedorDetalleCotiz
    End Function

    Public Sub UpdateProveedorDetalleCotizacion(ByVal proveedorDetalleCoti As BussinessEntities.ProveedorDetalleCotizacion) Implements IProveedorDetalleCotizacionRepository.UpdateProveedorDetalleCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateProveedorDetalleCotizacion")
        command.Parameters.AddWithValue("IdProveedorDetalleCotizacion", proveedorDetalleCoti.IdProveedorDetalleCotizacion)
        command.Parameters.AddWithValue("Monto", proveedorDetalleCoti.Monto)
        command.Parameters.AddWithValue("Estado", proveedorDetalleCoti.Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub UpdateProveedorDetalleCotizacion1(ByVal proveedorDetalleCoti As System.Collections.Generic.List(Of BussinessEntities.ProveedorDetalleCotizacion)) Implements IProveedorDetalleCotizacionRepository.UpdateProveedorDetalleCotizacion1
        For Each det As ProveedorDetalleCotizacion In proveedorDetalleCoti
            UpdateProveedorDetalleCotizacion(det)
        Next
    End Sub
    'Public Sub DeleteProveedor(ByVal IdDetalleReqCotizacion As Integer, ByVal IdProveedor As Integer) Implements IProveedorDetalleCotizacionRepository.DeleteProveedor
    '    Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteProveedorFromProveedorDetalleCotizacion")
    '    command.Parameters.AddWithValue("IdDetalleReqCotizacion", IdDetalleReqCotizacion)
    '    command.Parameters.AddWithValue("IdProveedor", IdProveedor)
    '    MyBase.ExecuteNonQuery(command)
    'End Sub

    Public Sub UpdateIgvCotizacion(ByVal IdDetalleRequerimiento As Integer, ByVal valor As Boolean) Implements IProveedorDetalleCotizacionRepository.UpdateIgvCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateIgvCotizacion")
        command.Parameters.AddWithValue("IdDetalleRequerimiento", IdDetalleRequerimiento)
        command.Parameters.AddWithValue("Valor", valor)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
