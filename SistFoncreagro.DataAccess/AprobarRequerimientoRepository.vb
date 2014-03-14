Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.Common

Public Class AprobarRequerimientoRepository : Inherits MasterDataAccess : Implements IAprobarRequerimientoRepository
    Dim aRol As IRolRepository
    Sub New()
        aRol = New RolRepository
    End Sub
    Public Function GetAllFromNivelesAprobarRequerimiento() As System.Collections.Generic.List(Of BussinessEntities.AprobarRequerimiento) Implements IAprobarRequerimientoRepository.GetAllFromNivelesAprobarRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromAprobarRequerimiento")
        Return SelectObjectFactory(command)
    End Function
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AprobarRequerimiento)
        Dim listaAprobarReq As New List(Of AprobarRequerimiento)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim aprobarReq As New AprobarRequerimiento
                With aprobarReq
                    .IdAprobarRequerimiento = reader.GetInt32(0)
                    .IdRol = reader.GetInt32(1)
                    .Orden = reader.GetInt32(2)
                    .AreaProyecto = reader.GetBoolean(3)
                End With
                aprobarReq.aRol = aRol.GetROLByIdRol(reader.GetInt32(1))
                listaAprobarReq.Add(aprobarReq)
            End While
        End Using
        Return listaAprobarReq
    End Function

    Public Function DeleteNivelAprobarRequerimiento(ByVal IdAprobarRequerimiento As Integer) As Boolean Implements IAprobarRequerimientoRepository.DeleteNivelAprobarRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAprobarRequerimiento")
        Dim resPuestaSql As Boolean

        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "Resultado"
        parametroBase.Direction = ParameterDirection.Output
        parametroBase.Value = resPuestaSql

        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdAprobarRequerimiento", IdAprobarRequerimiento)

        MyBase.ExecuteNonQuery(command)
        resPuestaSql = parametroBase.Value
        Return resPuestaSql
    End Function

    Public Function SaveNivelAprobarRequerimiento(ByVal aprobarReq As BussinessEntities.AprobarRequerimiento) As Int32 Implements IAprobarRequerimientoRepository.SaveNivelAprobarRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAprobarRequerimiento")
        Dim resultado As Int32

        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "Resultado"
        parametroBase.Direction = ParameterDirection.Output
        parametroBase.Value = resultado

        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdRol", aprobarReq.IdRol)
        command.Parameters.AddWithValue("Orden", aprobarReq.Orden)
        command.Parameters.AddWithValue("AreaProyecto", aprobarReq.AreaProyecto)
        MyBase.ExecuteNonQuery(command)
        resultado = parametroBase.Value
        Return resultado
    End Function

    Public Function UpdateNivelAprobarRequerimiento(ByVal aprobarReq As BussinessEntities.AprobarRequerimiento) As Integer Implements IAprobarRequerimientoRepository.UpdateNivelAprobarRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateAprobarRequerimiento")
        Dim resultado As Int32

        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "Resultado"
        parametroBase.Direction = ParameterDirection.Output
        parametroBase.Value = resultado

        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdAprobarRequerimiento", aprobarReq.IdAprobarRequerimiento)
        command.Parameters.AddWithValue("IdRol", aprobarReq.IdRol)
        command.Parameters.AddWithValue("Orden", aprobarReq.Orden)
        command.Parameters.AddWithValue("AreaProyecto", aprobarReq.AreaProyecto)
        MyBase.ExecuteNonQuery(command)
        resultado = parametroBase.Value
        Return resultado
    End Function
End Class
