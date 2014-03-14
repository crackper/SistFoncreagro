Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ResponsableBienMuebleRepository : Inherits MasterDataAccess : Implements IResponsableBienMuebleRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ResponsableBienMueble)
        Dim lista As New List(Of ResponsableBienMueble)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ResponsableBienMueble As New ResponsableBienMueble() With
                {
                    .IdResponsable = reader.GetValue(0),
                    .IdBienMueble = reader.GetValue(1),
                    .IdPersonal = reader.GetValue(2),
                    .FechaInicio = reader.GetValue(3)
                }
                If Not (reader.IsDBNull(4)) Then
                    _ResponsableBienMueble.FechaFin = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _ResponsableBienMueble.Observacion = reader.GetValue(5)
                End If
                lista.Add(_ResponsableBienMueble)
            End While
        End Using
        Return lista
    End Function

    Public Function GetRESPONSABLEBIENMUEBLEByIdBienMueble(ByVal IdBienMueble As Integer) As System.Collections.Generic.List(Of BussinessEntities.ResponsableBienMueble) Implements IResponsableBienMuebleRepository.GetRESPONSABLEBIENMUEBLEByIdBienMueble
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRESPONSABLEBIENMUEBLEByIdBienMueble")
        command.Parameters.AddWithValue("IdBienMueble", IdBienMueble)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetRESPONSABLEBIENMUEBLEByIdResponsable(ByVal IdResponsable As Integer) As BussinessEntities.ResponsableBienMueble Implements IResponsableBienMuebleRepository.GetRESPONSABLEBIENMUEBLEByIdResponsable
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRESPONSABLEBIENMUEBLEByIdResponsable")
        command.Parameters.AddWithValue("IdResponsable", IdResponsable)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveRESPONSABLEBIENMUEBLE(ByVal _ResponsableBienMueble As BussinessEntities.ResponsableBienMueble) Implements IResponsableBienMuebleRepository.SaveRESPONSABLEBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRESPONSABLEBIENMUEBLE")
        command.Parameters.AddWithValue("FechaFin", _ResponsableBienMueble.FechaFin)
        command.Parameters.AddWithValue("FechaInicio", _ResponsableBienMueble.FechaInicio)
        command.Parameters.AddWithValue("IdBienMueble", _ResponsableBienMueble.IdBienMueble)
        command.Parameters.AddWithValue("IdPersonal", _ResponsableBienMueble.IdPersonal)
        command.Parameters.AddWithValue("IdResponsable", _ResponsableBienMueble.IdResponsable)
        command.Parameters.AddWithValue("Observacion", _ResponsableBienMueble.Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub DeleteRESPONSABLEBIENMUEBLE(ByVal IdResponsable As Integer) Implements IResponsableBienMuebleRepository.DeleteRESPONSABLEBIENMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteRESPONSABLEBIENMUEBLE")
        command.Parameters.AddWithValue("IdResponsable", IdResponsable)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
