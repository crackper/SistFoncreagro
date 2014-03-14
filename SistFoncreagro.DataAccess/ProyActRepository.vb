Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class ProyActRepository : Inherits MasterDataAccess : Implements IProyActRepository

    Public Function GetAllFromProyAct() As System.Collections.Generic.List(Of BussinessEntities.ProyAct) Implements IProyActRepository.GetAllFromProyAct
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPROYACT")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ProyAct)
        Dim lista As New List(Of ProyAct)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ProyAct As New ProyAct() With
                    {
                        .IdProyAct = reader.GetValue(reader.GetOrdinal("IdProyAct")),
                        .IdProycomp = reader.GetValue(reader.GetOrdinal("IdProycomp")),
                        .IdActividad = reader.GetValue(reader.GetOrdinal("IdActividad"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Porcentaje"))) Then
                    _ProyAct.Porcentaje = reader.GetValue(reader.GetOrdinal("Porcentaje"))
                End If
                Dim _miProyComp As New ProyCompRepository
                _ProyAct._ProyComp = _miProyComp.GetProyCompById(_ProyAct.IdProycomp)

                Dim _miComponente As New ComponenteRepository
                _ProyAct._Componente = _miComponente.GetFromComponenteById(_ProyAct._ProyComp.IdComponente)

                Dim _miActividad As New ActividadRepository
                _ProyAct._Actividad = _miActividad.GetFromActividadById(_ProyAct.IdActividad)

                Dim _miConvProy As New ConveProyRepository
                _ProyAct._ConvProy = _miConvProy.GetFromConveProyById(_ProyAct._ProyComp.IdConvProy)

                Dim _miConvenio As New ConvenioRepository
                _ProyAct._Convenio = _miConvenio.GetFromConvenioByIdConvenio(_ProyAct._ConvProy.IdConvenio)

                Dim _miProyecto As New ProyectoRepository
                _ProyAct._Proyecto = _miProyecto.GetFromProyectoByIdProyecto(_ProyAct._ConvProy.IdProyecto)

                lista.Add(_ProyAct)
            End While
        End Using
        Return lista
    End Function

    Public Function GetProyActById(ByVal _id As Integer) As BussinessEntities.ProyAct Implements IProyActRepository.GetProyActById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYACTByIdProyAct")
        command.Parameters.AddWithValue("idProyAct", _id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetProyActByIdProyecto(ByVal _idProy As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProyAct) Implements IProyActRepository.GetProyActByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROYACTByIdProyecto")
        command.Parameters.AddWithValue("idProyecto", _idProy)
        Return SelectObjectFactory(command)
    End Function

    Public Function DeleteProyAct(ByVal _id As Integer) As String Implements IProyActRepository.DeleteProyAct
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePROYACT")
        command.Parameters.AddWithValue("idProyAct", _id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function SaveProyAct(ByVal _ProyAct As BussinessEntities.ProyAct) As String Implements IProyActRepository.SaveProyAct
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePROYACT")
        Dim msj As String = "abc"

        command.Parameters.AddWithValue("IdProyAct", _ProyAct.IdProyAct)
        command.Parameters.AddWithValue("IdProyComp", _ProyAct.IdProycomp)
        command.Parameters.AddWithValue("IdActividad", _ProyAct.IdActividad)
        command.Parameters.AddWithValue("Porcentaje", _ProyAct.Porcentaje)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                msj = reader.GetValue(0)
            End If
        End Using
        Return msj
    End Function
End Class
