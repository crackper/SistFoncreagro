Imports System.Data
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class RutaRequerimientoRepository : Inherits MasterDataAccess : Implements IRutaRequerimientoRepository

    Public Sub DeleteRutaRequerimiento(ByVal idRutaRequerimiento As Integer) Implements IRutaRequerimientoRepository.DeleteRutaRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteRutaRequerimiento")
        command.Parameters.AddWithValue("IdRutaRequerimiento", idRutaRequerimiento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromRutaRequerimiento() As System.Collections.Generic.List(Of BussinessEntities.RutaRequerimiento) Implements IRutaRequerimientoRepository.GetAllFromRutaRequerimiento
        Dim command As SqlCommand =
         MyBase.CreateSPCommand("GetAllFromRutaRequerimiento")
        Return SelectObjectFactoryRutaRequerimiento(command)
    End Function

    Public Function GetRutaRequerimientoByIdRuta(ByVal idRutaRequerimiento As Integer) As BussinessEntities.RutaRequerimiento Implements IRutaRequerimientoRepository.GetRutaRequerimientoByIdRuta
        Dim command As SqlCommand =
         MyBase.CreateSPCommand("GetFromRutaRequerimientoByIdRuta")
        command.Parameters.AddWithValue("IdRutaRequerimiento", idRutaRequerimiento)

        Return SelectObjectFactoryRutaRequerimiento(command).SingleOrDefault
    End Function

    Public Sub SaveRutaRequerimiento(ByVal rutaRequerimiento As BussinessEntities.RutaRequerimiento) Implements IRutaRequerimientoRepository.SaveRutaRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRutaRequerimiento")
        command.Parameters.AddWithValue("IdRutaRequerimiento", rutaRequerimiento.IdRutaRequerimiento)
        command.Parameters.AddWithValue("Nombre", rutaRequerimiento.Nombre)
        command.Parameters.AddWithValue("Descripcion", rutaRequerimiento.Descripcion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactoryRutaRequerimiento(ByVal command As SqlCommand) As List(Of RutaRequerimiento)
        Dim listaRutaRequerimiento As New List(Of RutaRequerimiento)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim rutaRequerimiento As New RutaRequerimiento()

                With rutaRequerimiento
                    .IdRutaRequerimiento = reader.GetInt32(0)
                    .Codigo = reader.GetString(1)
                    .Nombre = reader.GetString(2)
                    .Descripcion = reader.GetString(3)
                End With
                listaRutaRequerimiento.Add(rutaRequerimiento)
            End While

        End Using

        Return listaRutaRequerimiento
    End Function
End Class
