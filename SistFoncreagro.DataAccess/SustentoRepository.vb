Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SustentoRepository : Inherits MasterDataAccess : Implements ISustentoRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Sustento)
        Dim lista As New List(Of Sustento)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Sustento As New Sustento() With
                {
                  .IdSustento = reader.GetValue(0),
                  .IdControl = reader.GetValue(1),
                  .Archivo = reader.GetValue(2),
                  .Nombre = reader.GetValue(3),
                  .Descripcion = reader.GetValue(4),
                  .Fecha = reader.GetValue(5)
                }
                lista.Add(_Sustento)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteSUSTENTO(ByVal IdSustento As Integer) Implements ISustentoRepository.DeleteSUSTENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteSUSTENTO")
        command.Parameters.AddWithValue("IdSustento", IdSustento)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetSUSTENTOByIdControl(ByVal IdControl As Integer) As System.Collections.Generic.List(Of BussinessEntities.Sustento) Implements ISustentoRepository.GetSUSTENTOByIdControl
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUSTENTOByIdControl")
        command.Parameters.AddWithValue("IdControl", IdControl)
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveSUSTENTO(ByVal _Sustento As BussinessEntities.Sustento) Implements ISustentoRepository.SaveSUSTENTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveSUSTENTO")
        command.Parameters.AddWithValue("Archivo", _Sustento.Archivo)
        command.Parameters.AddWithValue("Descripcion", _Sustento.Descripcion)
        command.Parameters.AddWithValue("Fecha", _Sustento.Fecha)
        command.Parameters.AddWithValue("IdControl", _Sustento.IdControl)
        command.Parameters.AddWithValue("IdSustento", _Sustento.IdSustento)
        command.Parameters.AddWithValue("Nombre", _Sustento.Nombre)
        command.Parameters.AddWithValue("IdDetalleEje", _Sustento.IdDetalleEje)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetSUSTENTOByIdSustento(ByVal IdSUstento As Integer) As BussinessEntities.Sustento Implements ISustentoRepository.GetSUSTENTOByIdSustento
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUSTENTOByIdSustento")
        command.Parameters.AddWithValue("IdSUstento", IdSUstento)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetSUSTENTOByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Sustento) Implements ISustentoRepository.GetSUSTENTOByIdDetalleEje
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUSTENTOByIdDetalleEje")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        Return SelectObjectFactory(command)
    End Function
End Class
