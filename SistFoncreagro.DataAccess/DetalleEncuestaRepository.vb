Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetalleEncuestaRepository : Inherits MasterDataAccess : Implements IDetalleEncuestaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleEncuesta)
        Dim lista As New List(Of DetalleEncuesta)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _DetalleEncuesta As New DetalleEncuesta() With
                {
                    .IdDetalle = reader.GetValue(0),
                        .IdEncuesta = reader.GetValue(1),
                        .IdCaracteristica = reader.GetValue(2)
                }

                lista.Add(_DetalleEncuesta)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteDETALLEENCUESTA(ByVal IdDetalle As Integer) Implements IDetalleEncuestaRepository.DeleteDETALLEENCUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDETALLEENCUESTA")
        command.Parameters.AddWithValue("IdDetalle", IdDetalle)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDETALLEENCUESTAByIdEncuesta(ByVal IdEncuesta As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleEncuesta) Implements IDetalleEncuestaRepository.GetDETALLEENCUESTAByIdEncuesta
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDETALLEENCUESTAByIdEncuesta")
        command.Parameters.AddWithValue("IdEncuesta", IdEncuesta)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveDETALLEENCUESTA(ByVal _detalle As BussinessEntities.DetalleEncuesta) Implements IDetalleEncuestaRepository.SaveDETALLEENCUESTA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDETALLEENCUESTA")
        command.Parameters.AddWithValue("IdCaracteristica", _detalle.IdCaracteristica)
        command.Parameters.AddWithValue("IdEncuesta", _detalle.IdEncuesta)
         MyBase.ExecuteNonQuery(command)
    End Sub
End Class
