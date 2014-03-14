Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ProyCompRepository : Inherits MasterDataAccess : Implements IProyCompRepository

    Public Function GetAllFromProyComp() As System.Collections.Generic.List(Of BussinessEntities.ProyComp) Implements IProyCompRepository.GetAllFromProyComp
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPROYCOMP")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ProyComp)
        Dim lista As New List(Of ProyComp)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ProyComp As New ProyComp() With
                    {
                        .IdProyComp = reader.GetValue(reader.GetOrdinal("IdProyComp")),
                        .IdConvProy = reader.GetValue(reader.GetOrdinal("IdConvProy")),
                        .IdComponente = reader.GetValue(reader.GetOrdinal("IdComponente"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Porcentaje"))) Then
                    _ProyComp.Porcentaje = reader.GetValue(reader.GetOrdinal("Porcentaje"))
                End If
                Dim _miComponente As New ComponenteRepository
                _ProyComp._Componente = _miComponente.GetFromComponenteById(_ProyComp.IdComponente)

                Dim _miConvProy As New ConveProyRepository
                _ProyComp._ConvProy = _miConvProy.GetFromConveProyById(_ProyComp.IdConvProy)

                Dim _miConvenio As New ConvenioRepository
                _ProyComp._Convenio = _miConvenio.GetFromConvenioByIdConvenio(_ProyComp._ConvProy.IdConvenio)

                Dim _miProyecto As New ProyectoRepository
                _ProyComp._Proyecto = _miProyecto.GetFromProyectoByIdProyecto(_ProyComp._ConvProy.IdProyecto)

                lista.Add(_ProyComp)
            End While
        End Using
        Return lista
    End Function

    Public Function GetProyCompById(ByVal _id As Integer) As BussinessEntities.ProyComp Implements IProyCompRepository.GetProyCompById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYCOMPByIdProyComp")
        command.Parameters.AddWithValue("idProyComp", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetProyCompByIdProyecto(ByVal _idProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyComp) Implements IProyCompRepository.GetProyCompByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYCOMPByIdProyecto")
        command.Parameters.AddWithValue("idProyecto", _idProy)
        Return SelectObjectFactory(command)
    End Function

    Public Function DeleteProyComp(ByVal _id As Integer) As String Implements IProyCompRepository.DeleteProyComp
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePROYCOMP")
        command.Parameters.AddWithValue("idProyComp", _id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function SaveProyComp(ByVal _ProyComp As BussinessEntities.ProyComp) As String Implements IProyCompRepository.SaveProyComp
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePROYCOMP")
        Dim msj As String = "abc"

        command.Parameters.AddWithValue("IdProyComp", _ProyComp.IdProyComp)
        command.Parameters.AddWithValue("IdConvProy", _ProyComp.IdConvProy)
        command.Parameters.AddWithValue("IdComponente", _ProyComp.IdComponente)
        command.Parameters.AddWithValue("Porcentaje", _ProyComp.Porcentaje)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                msj = reader.GetValue(0)
            End If
        End Using
        Return msj
    End Function
End Class
