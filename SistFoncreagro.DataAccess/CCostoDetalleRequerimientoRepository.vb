Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class CCostoDetalleRequerimientoRepository : Inherits MasterDataAccess : Implements ICCostoDetalleRequerimientoRepository

    Dim cCostoRepository As ICCostoRepository
    'Dim detalleRequerimiento As IDetalleRequerimientoRepository

    Sub New()
        cCostoRepository = New CCostoRepository
        'detalleRequerimiento = New DetalleRequerimientoRepository
    End Sub

    Public Sub DeleteCCostoDetalleRequerimiento(ByVal idcCostoDetalleRequerimiento As Integer) Implements ICCostoDetalleRequerimientoRepository.DeleteCCostoDetalleRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCCostoDetalleRequerimiento")
        command.Parameters.AddWithValue("IdCCostoxDetalleRequerimiento", idcCostoDetalleRequerimiento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromCCostoDetalleRequerimientoByIdDetReq(ByVal idDetReq As Integer) As System.Collections.Generic.List(Of BussinessEntities.CCostoxDetalleRequerimiento) Implements ICCostoDetalleRequerimientoRepository.GetAllFromCCostoDetalleRequerimientoByIdDetReq
        Dim command As SqlCommand =
            MyBase.CreateSPCommand("GetAllFromCCostoDetalleRequerimientoByIdDetReq")
        command.Parameters.AddWithValue("IdDetalleRequerimiento", idDetReq)

        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveCCostoDetalleRequerimiento(ByVal ccostoDetalleRequerimiento As BussinessEntities.CCostoxDetalleRequerimiento) Implements ICCostoDetalleRequerimientoRepository.SaveCCostoDetalleRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCCOSTOXDETALLEREQUERIMIENTO")

        'command.Parameters.AddWithValue("IdCCostoxDetalleRequerimiento", ccostoDetalleRequerimiento.IdCentroCostoDetalleRequerimiento)
        command.Parameters.AddWithValue("IdDetalleRequerimiento", ccostoDetalleRequerimiento.IdDetalleRequerimiento)
        command.Parameters.AddWithValue("IdCentroCosto", ccostoDetalleRequerimiento.IdCentroCosto)

        MyBase.ExecuteNonQuery(command)

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CCostoxDetalleRequerimiento)
        Dim listaCCostoxDetalleRequerimiento As New List(Of CCostoxDetalleRequerimiento)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim ccostoxDetalleRequerimiento As New CCostoxDetalleRequerimiento()

                With ccostoxDetalleRequerimiento
                    .IdCCostoxDetalleRequerimiento = reader.GetInt32(0)
                    .IdDetalleRequerimiento = reader.GetInt32(1)
                    .IdCentroCosto = reader.GetInt32(2)
                End With
                'ccostoxDetalleRequerimiento.detalleRequerimiento = detalleRequerimiento.GetDetalleRequerimientoByIdDetalleReq(reader.GetInt32(1))
                ccostoxDetalleRequerimiento.centroCosto = cCostoRepository.GetCCOSTOByIdCCosto(reader.GetInt32(2))
                listaCCostoxDetalleRequerimiento.Add(ccostoxDetalleRequerimiento)

            End While

        End Using

        Return listaCCostoxDetalleRequerimiento
    End Function

End Class
