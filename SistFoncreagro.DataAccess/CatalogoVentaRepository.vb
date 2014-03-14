Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports SistFoncreagro.BussinessEntities
Public Class CatalogoVentaRepository : Inherits MasterDataAccess : Implements ICatalogoVentaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CatalogoVenta)
        Dim lista As New List(Of CatalogoVenta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim _CatalogoVenta As New CatalogoVenta() With
                    {
                        .IdCatVenta = reader.GetValue(0),
                        .Descripcion = reader.GetValue(1),
                        .IdTipoVenta = reader.GetValue(2),
                        .IdUnidadMedida = reader.GetValue(3),
                        .Estado = reader.GetValue(4),
                        .PrecioReferencia = reader.GetValue(5),
                        .AfectoIGV = reader.GetValue(6),
                        .AfectoDetraccion = reader.GetValue(7),
                        .IdClasificacion = reader.GetValue(8)
                    }
                lista.Add(_CatalogoVenta)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromCATALOGOVENTAS() As System.Collections.Generic.List(Of BussinessEntities.CatalogoVenta) Implements ICatalogoVentaRepository.GetAllFromCATALOGOVENTAS
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCATALOGOVENTAS")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCATALOGOVENTAByIdCatVenta(ByVal IdCatVenta As Integer) As BussinessEntities.CatalogoVenta Implements ICatalogoVentaRepository.GetCATALOGOVENTAByIdCatVenta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCATALOGOVENTAByIdCatVenta")
        command.Parameters.AddWithValue("IdBanco", IdCatVenta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveCATALOGOVENTA(ByVal _CatalogoVenta As BussinessEntities.CatalogoVenta) Implements ICatalogoVentaRepository.SaveCATALOGOVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCATALOGOVENTA")
        command.Parameters.AddWithValue("AfectoDetraccion", _CatalogoVenta.AfectoDetraccion)
        command.Parameters.AddWithValue("AfectoIGV", _CatalogoVenta.AfectoIGV)
        command.Parameters.AddWithValue("Descripcion", _CatalogoVenta.Descripcion)
        command.Parameters.AddWithValue("IdCatVenta", _CatalogoVenta.IdCatVenta)
        command.Parameters.AddWithValue("IdClasificacion", _CatalogoVenta.IdClasificacion)
        command.Parameters.AddWithValue("IdTipoVenta", _CatalogoVenta.IdTipoVenta)
        command.Parameters.AddWithValue("IdUnidadMedida", _CatalogoVenta.IdUnidadMedida)
        command.Parameters.AddWithValue("PrecioReferencia", _CatalogoVenta.PrecioReferencia)
        MyBase.ExecuteReader(command)
    End Sub
    Public Sub UpdateEstadoCATALOGOVENTA(ByVal IdCatVenta As Integer) Implements ICatalogoVentaRepository.UpdateEstadoCATALOGOVENTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCATALOGOVENTA")
        command.Parameters.AddWithValue("IdCatVenta", IdCatVenta)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
