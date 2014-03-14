Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ClasificacionCatalogoVentasRepository : Inherits MasterDataAccess : Implements IClasificacionCatalogoVentasRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ClasificacionCatalogoVentas)
        Dim lista As New List(Of ClasificacionCatalogoVentas)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Clasificacion As New ClasificacionCatalogoVentas() With
                {
                  .IdClasificacion = reader.GetValue(0),
                  .Clasificacion = reader.GetValue(1),
                  .Estado = reader.GetValue(2)
                }
                If Not (reader.IsDBNull(3)) Then
                    _Clasificacion.IdEspecieAnimal = reader.GetValue(3)
                End If
                lista.Add(_Clasificacion)
            End While
        End Using
        Return lista
    End Function
    Public Function GetCLASIFICACIONCATALOGOVENTASById(ByVal IdClasificacion As Integer) As BussinessEntities.ClasificacionCatalogoVentas Implements IClasificacionCatalogoVentasRepository.GetCLASIFICACIONCATALOGOVENTASById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCLASIFICACIONCATALOGOVENTASById")
        command.Parameters.AddWithValue("IdClasificacion", IdClasificacion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveCLASIFICACIONCATALOGOVENTAS(ByVal _ClasificacionCatalogoVentas As BussinessEntities.ClasificacionCatalogoVentas) Implements IClasificacionCatalogoVentasRepository.SaveCLASIFICACIONCATALOGOVENTAS
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCLASIFICACIONCATALOGOVENTAS")
        command.Parameters.AddWithValue("Clasificacion", _ClasificacionCatalogoVentas.Clasificacion)
        command.Parameters.AddWithValue("IdClasificacion", _ClasificacionCatalogoVentas.IdClasificacion)
        command.Parameters.AddWithValue("IdEspecieAnimal", _ClasificacionCatalogoVentas.IdEspecieAnimal)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoCLASIFICACIONCATALOGOVENTAS(ByVal IdClasificacion As Integer) Implements IClasificacionCatalogoVentasRepository.UpdateEstadoCLASIFICACIONCATALOGOVENTAS
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCLASIFICACIONCATALOGOVENTAS")
        command.Parameters.AddWithValue("IdClasificacion", IdClasificacion)
        MyBase.ExecuteReader(command)
    End Sub
End Class
