Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ControlRepository : Inherits MasterDataAccess : Implements IControlRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Control)
        Dim lista As New List(Of Control)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Control As New Control() With
                {
                  .IdControl = reader.GetValue(0),
                  .IdUser = reader.GetValue(2),
                  .Cantidad = reader.GetValue(4),
                  .IdDetalleEje = reader.GetValue(6),
                  .Estado = reader.GetValue(9)
                }
                If Not (reader.IsDBNull(1)) Then
                    _Control.IdSubActividad = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _Control.Descripcion = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _Control.IdTarea = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _Control.IdTaller = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _Control.Documento = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Control.Observacion = reader.GetValue(10)
                End If
                lista.Add(_Control)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteCONTROL(ByVal IdControl As Integer) Implements IControlRepository.DeleteCONTROL
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCONTROL")
        command.Parameters.AddWithValue("IdControl", IdControl)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetCONTROLByIdControl(ByVal IdControl As Integer) As BussinessEntities.Control Implements IControlRepository.GetCONTROLByIdControl
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONTROLByIdControl")
        command.Parameters.AddWithValue("IdControl", IdControl)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetCONTROLByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Control) Implements IControlRepository.GetCONTROLByIdDetalleEje
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONTROLByIdDetalleEje")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveCONTROL(ByVal _Control As BussinessEntities.Control) As Integer Implements IControlRepository.SaveCONTROL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONTROL")
        command.Parameters.AddWithValue("Cantidad", _Control.Cantidad)
        command.Parameters.AddWithValue("Descripcion", _Control.Descripcion)
        command.Parameters.AddWithValue("IdControl", _Control.IdControl)
        command.Parameters.AddWithValue("IdSubActividad", _Control.IdSubActividad)
        command.Parameters.AddWithValue("IdTarea", _Control.IdTarea)
        command.Parameters.AddWithValue("IdUser", _Control.IdUser)
        command.Parameters.AddWithValue("IdDetalleEje", _Control.IdDetalleEje)
        command.Parameters.AddWithValue("IdTaller", _Control.IdTaller)
        command.Parameters.AddWithValue("Documento", _Control.Documento)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function

    Public Sub UpdateEstadoCONTROL(IdControl As Integer) Implements IControlRepository.UpdateEstadoCONTROL
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCONTROL")
        command.Parameters.AddWithValue("IdControl", IdControl)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateObservacionControl(IdControl As Integer, Observacion As String) Implements IControlRepository.UpdateObservacionControl
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateObservacionControl")
        command.Parameters.AddWithValue("IdControl", IdControl)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub ReprogramarActividad(IdControl As Integer, Fecha As Date, IdUsuario As Integer, Observacion As String) Implements IControlRepository.ReprogramarActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("ReprogramarActividad")
        command.Parameters.AddWithValue("IdControl", IdControl)
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdUsuario", IdUsuario)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub ReprogramarActividadGeneral(IdDetalleEje As Integer, Fecha As Date, IdUsuario As Integer, Observacion As String) Implements IControlRepository.ReprogramarActividadGeneral
        Dim command As SqlCommand = MyBase.CreateSPCommand("ReprogramarActividadGeneral")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        command.Parameters.AddWithValue("Fecha", Fecha)
        command.Parameters.AddWithValue("IdUsuario", IdUsuario)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CancelarActividad(IdControl As Integer, IdUsuario As Integer, Observacion As String) Implements IControlRepository.CancelarActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("CancelarActividad")
        command.Parameters.AddWithValue("IdControl", IdControl)
       command.Parameters.AddWithValue("IdUsuario", IdUsuario)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub CancelarActividadGeneral(IdDetalleEje As Integer, IdUsuario As Integer, Observacion As String) Implements IControlRepository.CancelarActividadGeneral
        Dim command As SqlCommand = MyBase.CreateSPCommand("CancelarActividadGeneral")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
       command.Parameters.AddWithValue("IdUsuario", IdUsuario)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
