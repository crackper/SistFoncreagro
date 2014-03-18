Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ConveProyRepository : Inherits MasterDataAccess : Implements IConveProyRepository

    Public Function GetAllFromConveProy() As System.Collections.Generic.List(Of BussinessEntities.ConveProy) Implements IConveProyRepository.GetAllFromConveProy
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCONVEPROY")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ConveProy)
        Dim lista As New List(Of ConveProy)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ConveProy As New ConveProy() With
                {.IdConvProy = reader.GetValue(reader.GetOrdinal("idconvproy")),
                .IdProyecto = reader.GetValue(reader.GetOrdinal("IdProyecto")),
                 .IdConvenio = reader.GetValue(reader.GetOrdinal("IdConvenio")),
                .MontoAprobado = reader.GetValue(reader.GetOrdinal("MontoAprobado"))
                }
                Dim _miConvenio As New ConvenioRepository
                _ConveProy._Convenio = _miConvenio.GetFromConvenioByIdConvenio(_ConveProy.IdConvenio)

                lista.Add(_ConveProy)
            End While
        End Using
        Return lista
    End Function

    Public Function GetFromConveProyByIdConvenio(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConveProy) Implements IConveProyRepository.GetFromConveProyByIdConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVEPROYByIdConvenio")
        command.Parameters.AddWithValue("IdConvenio", _id)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFromConveProyByIdProyecto(ByVal _id As Integer) As System.Collections.Generic.List(Of BussinessEntities.ConveProy) Implements IConveProyRepository.GetFromConveProyByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVEPROYByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", _id)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveConveProy(ByVal _ConveProy As BussinessEntities.ConveProy) As Integer Implements IConveProyRepository.SaveConveProy
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONVEPROY")
        Dim Id As Int32
        command.Parameters.AddWithValue("IdConvProy", _ConveProy.IdConvProy)
        command.Parameters.AddWithValue("IdProyecto", _ConveProy.IdProyecto)
        command.Parameters.AddWithValue("IdConvenio", _ConveProy.IdConvenio)
        command.Parameters.AddWithValue("MontoAprobado", _ConveProy.MontoAprobado)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id

    End Function

    Public Function GetFromConveProyByIdProyAndIdconv(ByVal _idProy As Integer, ByVal _idConv As Integer) As BussinessEntities.ConveProy Implements IConveProyRepository.GetFromConveProyByIdProyAndIdconv
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVEPROYByIdProyAndIdConv")
        command.Parameters.AddWithValue("IdProyecto", _idProy)
        command.Parameters.AddWithValue("IdConvenio", _idConv)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetFromConveProyById(ByVal _id As Integer) As BussinessEntities.ConveProy Implements IConveProyRepository.GetFromConveProyById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVEPROYById")
        command.Parameters.AddWithValue("IdConvProy", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function DeleteConveProy(ByVal _id As Integer) As String Implements IConveProyRepository.DeleteConveProy
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCONVEPROY")
        command.Parameters.AddWithValue("idConvProy", _id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function
End Class
