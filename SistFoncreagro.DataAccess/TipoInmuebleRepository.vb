Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoInmuebleRepository : Inherits MasterDataAccess : Implements ITipoInmuebleRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoInmueble)
        Dim lista As New List(Of TipoInmueble)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoInmueble As New TipoInmueble() With
                {
                    .IdTipo = reader.GetValue(0),
                    .Tipo = reader.GetValue(1),
                    .IdPlanActivo = reader.GetValue(2),
                    .IdPlanDepreciacion = reader.GetValue(3),
                    .IdPlanGasto = reader.GetValue(4),
                    .IdPorcDepreciacion = reader.GetValue(5)
                }

                lista.Add(_TipoInmueble)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteTIPOINMUEBLE(ByVal IdTipo As Integer) Implements ITipoInmuebleRepository.DeleteTIPOINMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTIPOINMUEBLE")
        command.Parameters.AddWithValue("IdTipo", IdTipo)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetAllFromTIPOINMUEBLE() As System.Collections.Generic.List(Of BussinessEntities.TipoInmueble) Implements ITipoInmuebleRepository.GetAllFromTIPOINMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOINMUEBLE")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOINMUEBLEByIdTipo(ByVal IdTipo As Integer) As BussinessEntities.TipoInmueble Implements ITipoInmuebleRepository.GetTIPOINMUEBLEByIdTipo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOINMUEBLEByIdTipo")
        command.Parameters.AddWithValue("IdTipo", IdTipo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveTIPOINMUEBLE(ByVal _TipoInmueble As BussinessEntities.TipoInmueble) Implements ITipoInmuebleRepository.SaveTIPOINMUEBLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTIPOINMUEBLE")
        command.Parameters.AddWithValue("IdPlanActivo", _TipoInmueble.IdPlanActivo)
        command.Parameters.AddWithValue("IdPlanDepreciacion", _TipoInmueble.IdPlanDepreciacion)
        command.Parameters.AddWithValue("IdPlanGasto", _TipoInmueble.IdPlanGasto)
        command.Parameters.AddWithValue("IdPorcDepreciacion", _TipoInmueble.IdPorcDepreciacion)
        command.Parameters.AddWithValue("IdTipo", _TipoInmueble.IdTipo)
        command.Parameters.AddWithValue("Tipo", _TipoInmueble.Tipo)
        MyBase.ExecuteReader(command)
    End Sub
End Class
