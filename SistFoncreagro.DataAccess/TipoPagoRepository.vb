Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class TipoPagoRepository : Inherits MasterDataAccess : Implements ITipoPagoRepository



    Public Function GetAllFromTipoPago() As System.Collections.Generic.List(Of BussinessEntities.TipoPago) Implements ITipoPagoRepository.GetAllFromTipoPago
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTipoPago")
        Dim detalle As Boolean = False
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromTipoPagoByIdTipo(ByVal idTipoPago As Integer) As BussinessEntities.TipoPago Implements ITipoPagoRepository.GetAllFromTipoPagoByIdTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTipoPagoByIdTipo")
        command.Parameters.AddWithValue("IdTipoPago", idTipoPago)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveTipoPago(ByVal tipoPago As BussinessEntities.TipoPago) Implements ITipoPagoRepository.SaveTipoPago
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTipoPago")
        command.Parameters.AddWithValue("Descripcion", tipoPago.Descripcion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoPago)
        Dim listaTipoPago As New List(Of TipoPago)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim tipoPago As New TipoPago() With
                {
                    .IdTipo = reader.GetInt32(0),
                    .Descripcion = reader.GetString(1)
                }

                listaTipoPago.Add(tipoPago)
            End While
        End Using
        Return listaTipoPago
    End Function

End Class
