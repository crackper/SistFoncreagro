Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class TipoCotizacionRepository : Inherits MasterDataAccess : Implements ITipoCotizacionRepository

    Public Function GetAllFromTipoCotizacion() As System.Collections.Generic.List(Of BussinessEntities.TipoCotizacion) Implements ITipoCotizacionRepository.GetAllFromTipoCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTipoCotizacion")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveTipoCotizacion(ByVal tipoCotizacion As BussinessEntities.TipoCotizacion) Implements ITipoCotizacionRepository.SaveTipoCotizacion

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoCotizacion)
        Dim listaTipoCotizacion As New List(Of TipoCotizacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim tipoCoti As New TipoCotizacion

                With tipoCoti
                    .IdTipoCotizacion = reader.GetInt32(0)
                    .Descripcion = reader.GetString(1)
                    .NroDocumentos = reader.GetInt32(2)
                End With
                listaTipoCotizacion.Add(tipoCoti)
            End While

        End Using
        Return listaTipoCotizacion
    End Function

End Class
