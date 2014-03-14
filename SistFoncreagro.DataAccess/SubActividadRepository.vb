Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SubActividadRepository : Inherits MasterDataAccess : Implements ISubActividadRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of SubActividad)
        Dim lista As New List(Of SubActividad)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _SubActividad As New SubActividad() With
                    {
                       .IdSubActividad = reader.GetValue(0),
                           .IdElemGasto = reader.GetValue(1),
                           .Unidad = reader.GetValue(2),
                           .IdProyAct = reader.GetValue(4)
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Codigo"))) Then
                    _SubActividad.Codigo = reader.GetValue(reader.GetOrdinal("Codigo"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Porcentaje"))) Then
                    _SubActividad.Porcentaje = reader.GetValue(reader.GetOrdinal("Porcentaje"))
                End If
                lista.Add(_SubActividad)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteSubActividad(IdSubActividad As Integer) Implements ISubActividadRepository.DeleteSubActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteSubActividad")
        command.Parameters.AddWithValue("IdSubActividad", IdSubActividad)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub GenerarPoaTecnico(IdProyecto As Integer) Implements ISubActividadRepository.GenerarPoaTecnico
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarPoaTecnico")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetSUBACTIVIDADByIdSubActividad(IdSubActividad As Integer) As BussinessEntities.SubActividad Implements ISubActividadRepository.GetSUBACTIVIDADByIdSubActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUBACTIVIDADByIdSubActividad")
        command.Parameters.AddWithValue("IdSubActividad", IdSubActividad)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveSUBACTIVIDAD(_SUBACTIVIDAD As BussinessEntities.SubActividad) Implements ISubActividadRepository.SaveSUBACTIVIDAD
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveSUBACTIVIDAD")
        command.Parameters.AddWithValue("Codigo", _SUBACTIVIDAD.Codigo)
        command.Parameters.AddWithValue("IdElemGasto", _SUBACTIVIDAD.IdElemGasto)
        command.Parameters.AddWithValue("IdProyAct", _SUBACTIVIDAD.IdProyAct)
        command.Parameters.AddWithValue("Porcentaje", _SUBACTIVIDAD.Porcentaje)
        command.Parameters.AddWithValue("Unidad", _SUBACTIVIDAD.Unidad)
        command.Parameters.AddWithValue("IdSubActividad", _SUBACTIVIDAD.IdSubActividad)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
