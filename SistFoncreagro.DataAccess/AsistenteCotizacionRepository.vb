Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AsistenteCotizacionRepository : Inherits MasterDataAccess : Implements IAsistenteCotizacionRepository

    Public Sub DeleteAsistenteCotizacion(ByVal IdAsistenteCotizacion As Integer) Implements IAsistenteCotizacionRepository.DeleteAsistenteCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAsistenteCotizacion")
        command.Parameters.AddWithValue("IdAsistenteCotizacion", IdAsistenteCotizacion)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetAllFromAsistennteCotizacionByIdCotizacion(ByVal IdCotizacion As Integer) As System.Collections.Generic.List(Of BussinessEntities.AsistenteCotizacion) Implements IAsistenteCotizacionRepository.GetAllFromAsistennteCotizacionByIdCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromAsistennteCotizacionByIdCotizacion")
        command.Parameters.AddWithValue("IdCotizacion", IdCotizacion)
        Return SelectObjectFactory(command)
    End Function
    Public Sub SaveAsistenteCotizacion(ByVal asistenteCotizacion As BussinessEntities.AsistenteCotizacion) Implements IAsistenteCotizacionRepository.SaveAsistenteCotizacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAsistenteCotizacion")

        command.Parameters.AddWithValue("IdCotizacion", asistenteCotizacion.IdCotizacion)
        command.Parameters.AddWithValue("Tipo", asistenteCotizacion.Tipo)
        command.Parameters.AddWithValue("IdPersonal", asistenteCotizacion.IdPersonal)
        command.Parameters.AddWithValue("Nombre", asistenteCotizacion.Nombre)
        command.Parameters.AddWithValue("Cargo", asistenteCotizacion.Cargo)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AsistenteCotizacion)
        Dim listaAsistenteCotizacion As New List(Of AsistenteCotizacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim asistenteCoti As New AsistenteCotizacion
                With asistenteCoti
                    .IdAsistenteCotizacion = reader.GetInt32(0)
                    .IdCotizacion = reader.GetInt32(1)
                    .Tipo = reader.GetBoolean(2)
                    .IdPersonal = reader.GetInt32(3)
                    .Nombre = reader.GetString(4)
                    .Cargo = reader.GetString(5)
                End With
                listaAsistenteCotizacion.Add(asistenteCoti)
            End While
        End Using
        Return listaAsistenteCotizacion
    End Function


End Class
