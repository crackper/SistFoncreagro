Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class IntegranteRepository : Inherits MasterDataAccess : Implements IIntegranteRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Integrante)
        Dim lista As New List(Of Integrante)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Integrante As New Integrante() With
                {
                  .IdIntegrante = reader.GetValue(0),
                  .IdPersonal = reader.GetValue(3),
                 .Conduce = reader.GetValue(5),
                  .IdDetalleEje = reader.GetValue(6)
                }
                If Not (reader.IsDBNull(1)) Then
                    _Integrante.Observacion = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(2)) Then
                    _Integrante.Documento = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _Integrante.IdVehiculo = reader.GetValue(4)
                End If
                lista.Add(_Integrante)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteINTEGRANTE(ByVal IdIntegrante As Integer) Implements IIntegranteRepository.DeleteINTEGRANTE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteINTEGRANTE")
        command.Parameters.AddWithValue("IdIntegrante", IdIntegrante)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetINTEGRANTEByIdDetalleEje(ByVal IdDetalleEje As Integer) As System.Collections.Generic.List(Of BussinessEntities.Integrante) Implements IIntegranteRepository.GetINTEGRANTEByIdDetalleEje
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINTEGRANTEByIdDetalleEje")
        command.Parameters.AddWithValue("IdDetalleEje", IdDetalleEje)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetINTEGRANTEByIdIntegrante(ByVal IdIntegrante As Integer) As BussinessEntities.Integrante Implements IIntegranteRepository.GetINTEGRANTEByIdIntegrante
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINTEGRANTEByIdIntegrante")
        command.Parameters.AddWithValue("IdIntegrante", IdIntegrante)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveINTEGRANTE(ByVal _Integrante As BussinessEntities.Integrante) Implements IIntegranteRepository.SaveINTEGRANTE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveINTEGRANTE")
        command.Parameters.AddWithValue("Documento", _Integrante.Documento)
        command.Parameters.AddWithValue("IdDetalleEje", _Integrante.IdDetalleEje)
        command.Parameters.AddWithValue("IdIntegrante", _Integrante.IdIntegrante)
        command.Parameters.AddWithValue("IdPersonal", _Integrante.IdPersonal)
        command.Parameters.AddWithValue("Observacion", _Integrante.Observacion)
        command.Parameters.AddWithValue("IdVehiculo", _Integrante.IdVehiculo)
        command.Parameters.AddWithValue("Conduce", _Integrante.Conduce)
        MyBase.ExecuteReader(command)
    End Sub
End Class
