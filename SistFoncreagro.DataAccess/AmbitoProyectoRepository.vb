Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class AmbitoProyectoRepository : Inherits MasterDataAccess : Implements IAmbitoProyectoRepository

    Public Sub DeleteAmbitoProyecto(ByVal _id As Integer) Implements IAmbitoProyectoRepository.DeleteAmbitoProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAMBITOPROYECTO")
        command.Parameters.AddWithValue("idAmbProy", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromAmbitoProyecto() As System.Collections.Generic.List(Of BussinessEntities.AmbitoProyecto) Implements IAmbitoProyectoRepository.GetAllFromAmbitoProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromADJMONIT")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAmbitoProyectoByIdProy(ByVal _IdProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.AmbitoProyecto) Implements IAmbitoProyectoRepository.GetAmbitoProyectoByIdProy
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAMBITOPROYECTOByIdProy")
        command.Parameters.AddWithValue("IdProyecto", _IdProy)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromAmbitoProyectoById(ByVal _id As Integer) As BussinessEntities.AmbitoProyecto Implements IAmbitoProyectoRepository.GetFromAmbitoProyectoById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAMBITOPROYECTOById")
        command.Parameters.AddWithValue("IdAmbProy", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AmbitoProyecto)
        Dim lista As New List(Of AmbitoProyecto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _AmbitoProyecto As New AmbitoProyecto() With
                    {
                        .IdAmbProy = reader.GetValue(reader.GetOrdinal("IdAmbProy")),
                        .IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto")),
                        .CUbigeo = reader.GetValue(reader.GetOrdinal("CUbigeo"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Beneficiarios"))) Then
                    _AmbitoProyecto.Beneficiarios = reader.GetValue(reader.GetOrdinal("Beneficiarios"))
                End If

                Dim _miProyecto As New ProyectoRepository
                _AmbitoProyecto._Proyecto = _miProyecto.GetFromProyectoByIdProyecto(_AmbitoProyecto.IdProyecto)

                Dim _miUbigeoDatos As New UbigeoDatosRepository
                _AmbitoProyecto._UbigeoDatos = _miUbigeoDatos.GetUbigeoDatosByIdUbigeoDatos(_AmbitoProyecto.CUbigeo)

                lista.Add(_AmbitoProyecto)
            End While
        End Using
        Return lista
    End Function

    Public Sub SaveAmbitoProyecto(ByVal detalle As System.Collections.Generic.List(Of BussinessEntities.AmbitoProyecto)) Implements IAmbitoProyectoRepository.SaveAmbitoProyecto
        For Each det As AmbitoProyecto In detalle
            If IsNothing(det.Beneficiarios) Then
                SaveAmbitoProyecto1(det)
            Else
                SaveAmbitoProyectoBeneficiarios(det)
            End If
        Next
    End Sub

    Public Sub SaveAmbitoProyecto1(ByVal _AmbitoProyecto As BussinessEntities.AmbitoProyecto) Implements IAmbitoProyectoRepository.SaveAmbitoProyecto1
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAmbitoProyecto")
        command.Parameters.AddWithValue("IdAmbProy", _AmbitoProyecto.IdAmbProy)
        command.Parameters.AddWithValue("IdProyecto", _AmbitoProyecto.IdProyecto)
        command.Parameters.AddWithValue("CUbigeo", _AmbitoProyecto.CUbigeo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveAmbitoProyectoBeneficiarios(ByVal _AmbitoProyecto As BussinessEntities.AmbitoProyecto) Implements IAmbitoProyectoRepository.SaveAmbitoProyectoBeneficiarios
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAMBITOPROYECTOBeneficiarios")
        command.Parameters.AddWithValue("IdAmbProy", _AmbitoProyecto.IdAmbProy)
        command.Parameters.AddWithValue("Beneficiarios", _AmbitoProyecto.Beneficiarios)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
