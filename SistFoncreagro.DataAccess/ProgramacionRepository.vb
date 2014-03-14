Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ProgramacionRepository : Inherits MasterDataAccess : Implements IProgramacionRepository
  
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Programacion)
        Dim lista As New List(Of Programacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Programacion As New Programacion() With
                {
                   .IdProgramacion = reader.GetValue(0),
                       .Anio = reader.GetValue(3),
                       .EneF = reader.GetValue(4),
                       .FebF = reader.GetValue(5),
                       .MarF = reader.GetValue(6),
                       .AbrF = reader.GetValue(7),
                       .MayF = reader.GetValue(8),
                       .JunF = reader.GetValue(9),
                       .JulF = reader.GetValue(10),
                       .AgoF = reader.GetValue(11),
                       .SepF = reader.GetValue(12),
                       .OctF = reader.GetValue(13),
                       .NovF = reader.GetValue(14),
                       .DicF = reader.GetValue(15)
                }
                If Not (reader.IsDBNull(1)) Then
                    _Programacion.IdTarea = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(2)) Then
                    _Programacion.IdSubActividad = reader.GetValue(2)
                End If

                lista.Add(_Programacion)
            End While
        End Using
        Return lista
    End Function
    Public Sub GenerarProgramacionPoaTecnico(ByVal anio As Integer, ByVal IdProyecto As Integer) Implements IProgramacionRepository.GenerarProgramacionPoaTecnico
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarProgramacionPoaTecnico")
        command.Parameters.AddWithValue("anio", anio)
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SavePROGRAMACION(ByVal _Programacion As BussinessEntities.Programacion) Implements IProgramacionRepository.SavePROGRAMACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePROGRAMACION")
        command.Parameters.AddWithValue("AbrF", _Programacion.AbrF)
        command.Parameters.AddWithValue("AgoF", _Programacion.AgoF)
        command.Parameters.AddWithValue("Anio", _Programacion.Anio)
        command.Parameters.AddWithValue("DicF", _Programacion.DicF)
        command.Parameters.AddWithValue("EneF", _Programacion.EneF)
        command.Parameters.AddWithValue("FebF", _Programacion.FebF)
        command.Parameters.AddWithValue("IdProgramacion", _Programacion.IdProgramacion)
        command.Parameters.AddWithValue("IdSubActividad", _Programacion.IdSubActividad)
        command.Parameters.AddWithValue("IdTarea", _Programacion.IdTarea)
        command.Parameters.AddWithValue("JulF", _Programacion.JulF)
        command.Parameters.AddWithValue("JunF", _Programacion.JunF)
        command.Parameters.AddWithValue("MarF", _Programacion.MarF)
        command.Parameters.AddWithValue("MayF", _Programacion.MayF)
        command.Parameters.AddWithValue("NovF", _Programacion.NovF)
        command.Parameters.AddWithValue("OctF", _Programacion.OctF)
        command.Parameters.AddWithValue("SepF", _Programacion.SepF)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveListaProgramacion(ByVal Programacion As System.Collections.Generic.List(Of BussinessEntities.Programacion)) Implements IProgramacionRepository.SaveListaProgramacion
        For Each det As Programacion In Programacion
            SavePROGRAMACION(det)
        Next
    End Sub
End Class
