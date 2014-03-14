Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class InsumosRepository : Inherits MasterDataAccess : Implements IInsumosRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Insumos)
        Dim lista As New List(Of Insumos)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Insumos As New Insumos() With
                {
                    .IdInsumo = reader.GetValue(0),
                    .IdControl = reader.GetValue(1),
                    .Cantidad = reader.GetValue(3),
                    .PrecioUnitario = reader.GetValue(4),
                .IdUnidad = reader.GetValue(9),
                    .Tipo = reader.GetValue(12)
                               }
                If Not (reader.IsDBNull(2)) Then
                    _Insumos.Descripcion = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _Insumos.Observaciones = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _Insumos.IdCatalogo = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _Insumos.IdCCosto = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _Insumos.IdOcxFactura = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Insumos.TipoAdquisicion = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _Insumos.IdDetalleOrdenCompra = reader.GetValue(11)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _Insumos.IdInteresado = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(14)) Then
                    _Insumos.Acta = reader.GetValue(14)
                End If
                lista.Add(_Insumos)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteINSUMOS(ByVal IdInsumo As Integer) Implements IInsumosRepository.DeleteINSUMOS
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteINSUMOS")
        command.Parameters.AddWithValue("IdInsumo", IdInsumo)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetINSUMOSByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Insumos) Implements IInsumosRepository.GetINSUMOSByIdControl
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINSUMOSByIdControl")
        command.Parameters.AddWithValue("IdControl", IdControl)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetINSUMOSByIdInsumo(ByVal IdInsumo As Integer) As BussinessEntities.Insumos Implements IInsumosRepository.GetINSUMOSByIdInsumo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINSUMOSByIdInsumo")
        command.Parameters.AddWithValue("IdInsumo", IdInsumo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveINSUMOS(ByVal _Insumos As BussinessEntities.Insumos) Implements IInsumosRepository.SaveINSUMOS
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveINSUMOS")
        command.Parameters.AddWithValue("Cantidad", _Insumos.Cantidad)
        command.Parameters.AddWithValue("Descripcion", _Insumos.Descripcion)
        command.Parameters.AddWithValue("IdControl", _Insumos.IdControl)
        command.Parameters.AddWithValue("IdInsumo", _Insumos.IdInsumo)
        command.Parameters.AddWithValue("PrecioUnitario", _Insumos.PrecioUnitario)
        command.Parameters.AddWithValue("IdUnidad", _Insumos.IdUnidad)
        command.Parameters.AddWithValue("Observaciones", _Insumos.Observaciones)
        command.Parameters.AddWithValue("IdCatalogo", _Insumos.IdCatalogo)
        command.Parameters.AddWithValue("IdCCosto", _Insumos.IdCCosto)
        command.Parameters.AddWithValue("IdOcxFactura", _Insumos.IdOcxFactura)
        command.Parameters.AddWithValue("TipoAdquisicion", _Insumos.TipoAdquisicion)
        command.Parameters.AddWithValue("IdDetalleOrdenCompra", _Insumos.IdDetalleOrdenCompra)
        command.Parameters.AddWithValue("IdInteresado", _Insumos.IdInteresado)
        command.Parameters.AddWithValue("Tipo", _Insumos.Tipo)
        command.Parameters.AddWithValue("Acta", _Insumos.Acta)
        MyBase.ExecuteReader(command)
    End Sub
End Class
