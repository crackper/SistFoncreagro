Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ReciboRepository : Inherits MasterDataAccess : Implements IReciboRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Recibo)
        Dim lista As New List(Of Recibo)
        Dim PlanContableRepository As New PlanContableRepository
        Dim Personal As New PersonalRepository
        Dim CCostoRepository As New CCostoRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Recibo As New Recibo() With
                {
                   .Codigo = reader.GetValue(1),
                   .Estado = reader.GetValue(2),
                   .Glosa = reader.GetValue(4),
                   .IdRecibo = reader.GetValue(6),
                   .Monto = reader.GetValue(7)
                }
                If Not (reader.IsDBNull(0)) Then
                    _Recibo.Beneficiario = reader.GetValue(0)
                    _Recibo.Personal = Personal.GetPersonalByIdPersonal(reader.GetValue(0))
                End If
                If Not (reader.IsDBNull(3)) Then
                    _Recibo.Fecha = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _Recibo.IdProyecto = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _Recibo.Usuario = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _Recibo.FechaVencimiento = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Recibo.IdCCosto = reader.GetValue(10)
                    _Recibo.CCosto = CCostoRepository.GetCCOSTOByIdCCosto(reader.GetValue(10))
                End If

                lista.Add(_Recibo)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteRECIBO(ByVal IdRecibo As Integer) Implements IReciboRepository.DeleteRECIBO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteRECIBO")
        command.Parameters.AddWithValue("IdRecibo", IdRecibo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromRECIBO() As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboRepository.GetAllFromRECIBO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromRECIBO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetRECIBOByIdRecibo(ByVal IdRecibo As Integer) As BussinessEntities.Recibo Implements IReciboRepository.GetRECIBOByIdRecibo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRECIBOByIdRecibo")
        command.Parameters.AddWithValue("IdRecibo", IdRecibo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetRECIBOByIdProyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboRepository.GetRECIBOByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRECIBOByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateEstadoRECIBO(ByVal IdRecibo As Integer, ByVal Estado As String) Implements IReciboRepository.UpdateEstadoRECIBO
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoRECIBO")
        command.Parameters.AddWithValue("IdRecibo", IdRecibo)
        command.Parameters.AddWithValue("Estado", Estado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetRECIBOByEstado(ByVal Estado As String) As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboRepository.GetRECIBOByEstado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRECIBOByEstado")
        command.Parameters.AddWithValue("Estado", Estado)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetRECIBOPendientes() As System.Collections.Generic.List(Of BussinessEntities.Recibo) Implements IReciboRepository.GetRECIBOPendientes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRECIBOPendientes")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetRECIBOByIdReciboRendicion(ByVal IdReciboRendicion As Integer) As BussinessEntities.Recibo Implements IReciboRepository.GetRECIBOByIdReciboRendicion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRECIBOByIdReciboRendicion")
        command.Parameters.AddWithValue("IdReciboRendicion", IdReciboRendicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveRECIBO(ByVal _Recibo As BussinessEntities.Recibo) Implements IReciboRepository.SaveRECIBO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveRECIBO")
        command.Parameters.AddWithValue("Beneficiario", _Recibo.Beneficiario)
        command.Parameters.AddWithValue("Fecha", _Recibo.Fecha)
        command.Parameters.AddWithValue("Glosa", _Recibo.Glosa)
        command.Parameters.AddWithValue("IdProyecto", _Recibo.IdProyecto)
        command.Parameters.AddWithValue("IdRecibo", _Recibo.IdRecibo)
        command.Parameters.AddWithValue("Monto", _Recibo.Monto)
        command.Parameters.AddWithValue("Usuario", _Recibo.Usuario)
        command.Parameters.AddWithValue("FechaVencimiento", _Recibo.FechaVencimiento)
        command.Parameters.AddWithValue("IdCCosto", _Recibo.IdCCosto)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
