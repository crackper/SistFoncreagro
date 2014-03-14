Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ConveMarcoRepository : Inherits MasterDataAccess : Implements IConveMarcoRepository

    Public Sub DeleteConveMarco(ByVal _id As Integer) Implements IConveMarcoRepository.DeleteConveMarco
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCONVEMARCO")
        command.Parameters.AddWithValue("idConveMarco", _id)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromConveMarco() As System.Collections.Generic.List(Of BussinessEntities.ConveMarco) Implements IConveMarcoRepository.GetAllFromConveMarco
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCONVEMARCO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromConveMarcoByIdConveMarco(ByVal _id As Integer) As BussinessEntities.ConveMarco Implements IConveMarcoRepository.GetFromConveMarcoByIdConveMarco
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVEMARCOByIdConvemarco")
        command.Parameters.AddWithValue("idConveMarco", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ConveMarco)
        Dim lista As New List(Of ConveMarco)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ConveMarco As New ConveMarco() With
                    {
                        .IdConveMarco = reader.GetValue(reader.GetOrdinal("IdConveMarco")),
                        .Codigo = reader.GetValue(reader.GetOrdinal("Codigo")),
                        .Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                    }
                Dim _miAdjMonit As New AdjMonitRepository
                '_ConveMarco._Adjuntos = _miAdjMonit.GetADJMONITByIdAndTabla(_ConveMarco.IdConveMarco, "CONVEMARCO")

                lista.Add(_ConveMarco)
            End While
        End Using
        Return lista
    End Function

    Public Function SaveConveMarco(ByVal _ConveMarco As BussinessEntities.ConveMarco) As Integer Implements IConveMarcoRepository.SaveConveMarco
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONVEMARCO")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdConveMarco", _ConveMarco.IdConveMarco)
        command.Parameters.AddWithValue("Codigo", _ConveMarco.Codigo)
        command.Parameters.AddWithValue("Nombre ", _ConveMarco.Nombre)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function GetFromConveMarcoByParameter(ByVal _Texto As String) As System.Collections.Generic.List(Of BussinessEntities.ConveMarco) Implements IConveMarcoRepository.GetFromConveMarcoByParameter
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVEMARCOByParameter")
        command.Parameters.AddWithValue("Texto", _Texto)
        Return SelectObjectFactory(command)
    End Function
End Class
