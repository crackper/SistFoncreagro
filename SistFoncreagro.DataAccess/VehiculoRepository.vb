Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class VehiculoRepository : Inherits MasterDataAccess : Implements IVehiculoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Vehiculo)
        Dim lista As New List(Of Vehiculo)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Vehiculo As New Vehiculo() With
                {
                  .IdVehiculo = reader.GetValue(0),
                      .Marca = reader.GetValue(1),
                      .Modelo = reader.GetValue(2),
                      .Placa = reader.GetValue(3),
                      .Tipo = reader.GetValue(4),
                      .IdDetalleEje = reader.GetValue(6),
                        .Implementacion = reader.GetValue(7),
                        .Mantenimiento = reader.GetValue(8)
                }

                If Not (reader.IsDBNull(5)) Then
                    _Vehiculo.Observaciones = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _Vehiculo.Incidente = reader.GetValue(9)
                End If

                lista.Add(_Vehiculo)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteVEHICULO(ByVal IdVehiculo As Integer) Implements IVehiculoRepository.DeleteVEHICULO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteVEHICULO")
        command.Parameters.AddWithValue("IdVehiculo", IdVehiculo)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetVEHICULOByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Vehiculo) Implements IVehiculoRepository.GetVEHICULOByIdDetalleEje
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetVEHICULOByIdDetalleEje")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetVEHICULOByIdVehiculo(ByVal IdVehiculo As Object) As BussinessEntities.Vehiculo Implements IVehiculoRepository.GetVEHICULOByIdVehiculo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetVEHICULOByIdVehiculo")
        command.Parameters.AddWithValue("IdVehiculo", IdVehiculo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveVEHICULO(ByVal _Vehiculo As BussinessEntities.Vehiculo) Implements IVehiculoRepository.SaveVEHICULO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveVEHICULO")
        command.Parameters.AddWithValue("IdDetalleEje", _Vehiculo.IdDetalleEje)
        command.Parameters.AddWithValue("IdVehiculo", _Vehiculo.IdVehiculo)
        command.Parameters.AddWithValue("Marca", _Vehiculo.Marca)
        command.Parameters.AddWithValue("Modelo", _Vehiculo.Modelo)
        command.Parameters.AddWithValue("Observaciones", _Vehiculo.Observaciones)
        command.Parameters.AddWithValue("Placa", _Vehiculo.Placa)
        command.Parameters.AddWithValue("Tipo", _Vehiculo.Tipo)
        command.Parameters.AddWithValue("Implementacion", _Vehiculo.Implementacion)
        command.Parameters.AddWithValue("Mantenimiento", _Vehiculo.Mantenimiento)
        command.Parameters.AddWithValue("Incidentes", _Vehiculo.Incidente)
        MyBase.ExecuteReader(command)
    End Sub
End Class
