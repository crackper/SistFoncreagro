Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities
Public Class CCostoxDetalleOrdenRepository : Inherits MasterDataAccess : Implements ICCostoxDetalleOrden
    Dim cCostoRepository As ICCostoRepository
    Sub New()
        cCostoRepository = New CCostoRepository
    End Sub
    Public Function GetAllFromCCostoDetalleOrdenByIdDetalleOrden(ByVal idDetalleOrden As Integer) As System.Collections.Generic.List(Of CCostoxDetalleOrden) Implements ICCostoxDetalleOrden.GetAllFromCCostoDetalleOrdenByIdDetalleOrden
        Dim command As SqlCommand =
           MyBase.CreateSPCommand("GetAllFromCCostoDetalleOrdenByIdDetalleOrden")
        command.Parameters.AddWithValue("IdDetalleOrdenCompra", idDetalleOrden)

        Return SelectObjectFactory(command)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CCostoxDetalleOrden)
        Dim listaCCostoxDetalleOrden As New List(Of CCostoxDetalleOrden)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim ccostoxDetalleOrden As New CCostoxDetalleOrden()
                With ccostoxDetalleOrden
                    .IdCCostoxDetalleOrdenComrpa = reader.GetInt32(0)
                    .IdDetalleOrdenCompra = reader.GetInt32(1)
                    .IdCentroCosto = reader.GetInt32(2)
                End With
                ccostoxDetalleOrden.centroCosto = cCostoRepository.GetCCOSTOByIdCCosto(reader.GetInt32(2))
                listaCCostoxDetalleOrden.Add(ccostoxDetalleOrden)
            End While
        End Using
        Return listaCCostoxDetalleOrden
    End Function
End Class
