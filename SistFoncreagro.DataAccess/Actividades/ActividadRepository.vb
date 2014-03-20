Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Partial Public Class ActividadRepository : Inherits MasterDataAccess : Implements IActividadRepository

    Public Function GetAllFromActividad() As System.Collections.Generic.List(Of BussinessEntities.Actividad) Implements IActividadRepository.GetAllFromActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromACTIVIDAD")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromActividadById(ByVal _id As Integer) As BussinessEntities.Actividad Implements IActividadRepository.GetFromActividadById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetACTIVIDADByIdActividad")
        command.Parameters.AddWithValue("idActividad", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Actividad)
        Dim lista As New List(Of Actividad)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Actividad As New Actividad() With
                    {
                        .IdActividad = reader.GetValue(reader.GetOrdinal("IdActividad"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Nombre"))) Then
                    _Actividad.Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Descripcion"))) Then
                    _Actividad.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Codigo"))) Then
                    _Actividad.Codigo = reader.GetValue(reader.GetOrdinal("Codigo"))
                End If
                lista.Add(_Actividad)
            End While
        End Using
        Return lista
    End Function

    Public Function DeleteActividad(ByVal _id As Integer) As String Implements IActividadRepository.DeleteActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteACTIVIDAD")
        command.Parameters.AddWithValue("idActividad", _id)
        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function SaveActividad(ByVal _Actividad As BussinessEntities.Actividad) As Integer Implements IActividadRepository.SaveActividad
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveACTIVIDAD")
        Dim id As Int32

        command.Parameters.AddWithValue("IdActividad", _Actividad.IdActividad)
        command.Parameters.AddWithValue("Nombre", _Actividad.Nombre)
        command.Parameters.AddWithValue("Descripcion", _Actividad.Descripcion)
        'command.Parameters.AddWithValue("Codigo ", _Actividad.Codigo)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If
        End Using
        Return id
    End Function

    Public Function GetActividadByIdCompAndIdProyAndIdConv(ByVal _IdComp As Integer, ByVal _IdProy As Integer, ByVal _IdConv As Integer) As System.Collections.Generic.List(Of BussinessEntities.Actividad) Implements IActividadRepository.GetActividadByIdCompAndIdProyAndIdConv
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetACTIVIDADByIdCompAndIdProyAndIdConv")
        command.Parameters.AddWithValue("idComponente", _IdComp)
        command.Parameters.AddWithValue("IdProyecto", _IdProy)
        command.Parameters.AddWithValue("Idconvenio", _IdConv)
        Return SelectObjectFactory(command)
    End Function
End Class
