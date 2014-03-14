Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RendicionRepository : Inherits MasterDataAccess : Implements IRendicionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Rendicion)
        Dim lista As New List(Of Rendicion)
        Dim Proyectorepository As New ProyectoRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Rendicion As New Rendicion() With
                {
                 .Codigo = reader.GetValue(0),
                 .Estado = reader.GetValue(1),
                 .Fecha = reader.GetValue(2),
                 .IdOpFinanciera = reader.GetValue(3),
                 .IdProyecto = reader.GetValue(4),
                 .IdRendicion = reader.GetValue(5),
                 .IdSubDiario = reader.GetValue(6),
                 .Responsable = reader.GetValue(7)
                }

                If Not (reader.IsDBNull(8)) Then
                    _Rendicion.Observacion = reader.GetValue(8)

                End If
                _Rendicion.Proyecto = Proyectorepository.GetFromProyectoByIdProyecto(reader.GetValue(4))
                lista.Add(_Rendicion)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteRENDICION(ByVal IdRendicion As Integer) Implements IRendicionRepository.DeleteRENDICION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteRENDICION")
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromRENDICION() As System.Collections.Generic.List(Of BussinessEntities.Rendicion) Implements IRendicionRepository.GetAllFromRENDICION
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromRENDICION")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetRENDICIONByIdRendicion(ByVal IdRendicion As Integer) As BussinessEntities.Rendicion Implements IRendicionRepository.GetRENDICIONByIdRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRENDICIONByIdRendicion")
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveRENDICION(ByVal _Rendicion As BussinessEntities.Rendicion) As Integer Implements IRendicionRepository.SaveRENDICION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRENDICION")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdRendicion", _Rendicion.IdRendicion)
        command.Parameters.AddWithValue("Fecha", _Rendicion.Fecha)
        command.Parameters.AddWithValue("IdOpFinanciera", _Rendicion.IdOpFinanciera)
        command.Parameters.AddWithValue("IdProyecto", _Rendicion.IdProyecto)
        command.Parameters.AddWithValue("IdSubDiario", _Rendicion.IdSubDiario)
        command.Parameters.AddWithValue("Responsable", _Rendicion.Responsable)
        command.Parameters.AddWithValue("Observacion", _Rendicion.Observacion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If

        End Using
        Return Id
    End Function

    Public Sub UpdateEstadoRENDICION(ByVal IdRendicion As Integer, ByVal Estado As String) Implements IRendicionRepository.UpdateEstadoRENDICION
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoRENDICION")
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        command.Parameters.AddWithValue("Estado", Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetRENDICIONByEstado(ByVal Estado As String, ByVal mes As Int32) As System.Collections.Generic.List(Of BussinessEntities.Rendicion) Implements IRendicionRepository.GetRENDICIONByEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRENDICIONByEstado")
        command.Parameters.AddWithValue("Estado", Estado)
        command.Parameters.AddWithValue("mes", mes)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateObservacionRENDICION(ByVal IdRendicion As Integer, ByVal Observacion As String) Implements IRendicionRepository.UpdateObservacionRENDICION
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateObservacionRENDICION")
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        command.Parameters.AddWithValue("Observacion", Observacion)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetTotalRendicion(ByVal IdRendicion As Integer) As Decimal Implements IRendicionRepository.GetTotalRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTotalRendicion")
        Dim total As Decimal
        command.Parameters.AddWithValue("IdRendicion", IdRendicion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                total = reader.GetValue(0)
            End If

        End Using
        Return total
    End Function

    Public Function GetRENDICIONPendientes(ByVal mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Rendicion) Implements IRendicionRepository.GetRENDICIONPendientes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRENDICIONPendientes")
        command.Parameters.AddWithValue("mes", mes)
        Return SelectObjectFactory(command)
    End Function
End Class
