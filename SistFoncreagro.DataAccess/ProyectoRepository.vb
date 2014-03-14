Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ProyectoRepository : Inherits MasterDataAccess : Implements IProyectoRepository

    Public Function GetAllFromProyecto() As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoRepository.GetAllFromProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPROYECTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromProyectoByIdProyecto(ByVal idproyecto As Integer) As BussinessEntities.Proyecto Implements IProyectoRepository.GetFromProyectoByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetProyectoByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", idproyecto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Proyecto)
        Dim lista As New List(Of Proyecto)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim _Proyecto As New Proyecto() With
                {
                    .IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto")),
                    .Nombre = reader.GetValue(reader.GetOrdinal("Nombre")),
                    .Estado = reader.GetValue(reader.GetOrdinal("Estado")),
                    .Codigo = reader.GetValue(reader.GetOrdinal("codigo"))
                 }
                If Not (reader.IsDBNull(reader.GetOrdinal("IniProyProg"))) Then
                    _Proyecto.IniProyProg = reader.GetValue(reader.GetOrdinal("IniProyProg"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("IniProyReal"))) Then
                    _Proyecto.IniProyReal = reader.GetValue(reader.GetOrdinal("IniProyReal"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FinProyProg"))) Then
                    _Proyecto.FinProyProg = reader.GetValue(reader.GetOrdinal("FinProyProg"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FinProyReal"))) Then
                    _Proyecto.FinProyReal = reader.GetValue(reader.GetOrdinal("FinProyReal"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Monto"))) Then
                    _Proyecto.Monto = reader.GetValue(reader.GetOrdinal("Monto"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Alineamiento"))) Then
                    _Proyecto.Alineamiento = reader.GetValue(reader.GetOrdinal("Alineamiento"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Programa"))) Then
                    _Proyecto.Programa = reader.GetValue(reader.GetOrdinal("Programa"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("IdResponsable"))) Then
                    _Proyecto.IdResponsable = reader.GetValue(reader.GetOrdinal("IdResponsable"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("TotalPresupuestado"))) Then
                    _Proyecto.TotalPresupuestado = reader.GetValue(reader.GetOrdinal("TotalPresupuestado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("TotalComprometido"))) Then
                    _Proyecto.TotalComprometido = reader.GetValue(reader.GetOrdinal("TotalComprometido"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("TotalEjecutado"))) Then
                    _Proyecto.TotalEjecutado = reader.GetValue(reader.GetOrdinal("TotalEjecutado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("CodigoAdicional"))) Then
                    _Proyecto.CodigoAdicional = reader.GetValue(reader.GetOrdinal("CodigoAdicional"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("AliasProy"))) Then
                    _Proyecto.AliasProy = reader.GetValue(reader.GetOrdinal("AliasProy"))
                End If
                Dim _Responsable As New PersonalRepository
                _Proyecto._Personal = _Responsable.GetPersonalByIdPersonal(_Proyecto.IdResponsable)
                lista.Add(_Proyecto)
            End While
        End Using
        Return lista
    End Function

    Private Function SelectObjectFactory2(ByVal command As SqlCommand) As List(Of Proyecto)
        Dim lista As New List(Of Proyecto)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim _Proyecto As New Proyecto() With
                {
                    .IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto")),
                    .Nombre = reader.GetValue(reader.GetOrdinal("Nombre")),
                    .Estado = reader.GetValue(reader.GetOrdinal("Estado")),
                    .Codigo = reader.GetValue(reader.GetOrdinal("codigo"))
                 }
                lista.Add(_Proyecto)
            End While
        End Using
        Return lista
    End Function

    Private Function SelectObjectFactory1(ByVal command As SqlCommand) As List(Of Proyecto)
        Dim lista As New List(Of Proyecto)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim _Proyecto As New Proyecto() With
                {
                   .Codigo = reader.GetValue(reader.GetOrdinal("codigo"))
                 }
                lista.Add(_Proyecto)
            End While
        End Using
        Return lista
    End Function
    Public Function SaveProyecto(ByVal _Proyecto As BussinessEntities.Proyecto) As Integer Implements IProyectoRepository.SaveProyecto

        Dim command As SqlCommand = MyBase.CreateSPCommand("Saveproyecto")
        Dim Id As Int32

        command.Parameters.AddWithValue("Idproyecto", _Proyecto.IdProyecto)
        command.Parameters.AddWithValue("Nombre", _Proyecto.Nombre)
        command.Parameters.AddWithValue("IniProyProg ", _Proyecto.IniProyProg)
        command.Parameters.AddWithValue("IniProyReal ", _Proyecto.IniProyReal)
        command.Parameters.AddWithValue("FinProyProg", _Proyecto.FinProyProg)
        command.Parameters.AddWithValue("FinProyReal", _Proyecto.FinProyReal)
        command.Parameters.AddWithValue("Monto", _Proyecto.Monto)
        command.Parameters.AddWithValue("Estado", _Proyecto.Estado)
        command.Parameters.AddWithValue("Alineamiento", _Proyecto.Alineamiento)
        command.Parameters.AddWithValue("Programa", _Proyecto.Programa)
        command.Parameters.AddWithValue("Codigo", _Proyecto.Codigo)
        command.Parameters.AddWithValue("IdResponsable", _Proyecto.IdResponsable)
        command.Parameters.AddWithValue("CodigoAdicional", _Proyecto.CodigoAdicional)
        command.Parameters.AddWithValue("AliasProy", _Proyecto.AliasProy)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function DeleteProyecto(ByVal id As Integer) As String Implements IProyectoRepository.DeleteProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePROYECTO")
        command.Parameters.AddWithValue("idProyecto", id)
        command.Parameters.AddWithValue("miError", "abc")
        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function GetFromProyectoByParameters(ByVal _Nombre As String, ByVal _Estado As String, ByVal _Responsable As String) As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoRepository.GetFromProyectoByParameters
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYECTOByParameters")
        command.Parameters.AddWithValue("Nombre", _Nombre)
        command.Parameters.AddWithValue("Estado", _Estado)
        command.Parameters.AddWithValue("Responsable", _Responsable)
        Return SelectObjectFactory(command)
    End Function
    Public Function GetPROYECTOBInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoRepository.GetPROYECTOBInTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYECTOBInTransaccion")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCodigoFromPROYECTO(ByVal IdProyecto As Integer) As BussinessEntities.Proyecto Implements IProyectoRepository.GetCodigoFromPROYECTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetProyectoByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory1(command).SingleOrDefault
    End Function

    Public Function GetAllFromProyectoDatosGenerales() As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoRepository.GetAllFromProyectoDatosGenerales
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPROYECTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetProyectoVigente() As System.Collections.Generic.List(Of BussinessEntities.Proyecto) Implements IProyectoRepository.GetProyectoVigente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYECTOVigente")
        Return SelectObjectFactory(command)
    End Function
End Class
