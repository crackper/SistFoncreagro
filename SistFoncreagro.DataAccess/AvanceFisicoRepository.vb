Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class AvanceFisicoRepository : Inherits MasterDataAccess : Implements IAvanceFisicoRepository

    Public Function DeleteAvanceFisico(ByVal _id As Integer) As String Implements IAvanceFisicoRepository.DeleteAvanceFisico
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAVANCEFISICO")
        command.Parameters.AddWithValue("idAvanceFisico", _id)
        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function SaveAvanceFisico(ByVal _AvanceFisico As BussinessEntities.AvanceFisico) As Integer Implements IAvanceFisicoRepository.SaveAvanceFisico
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAVANCEFISICO")
        Dim _id As Int32
        command.Parameters.AddWithValue("IdAvanceFisico", _AvanceFisico.IdAvanceFisico)
        command.Parameters.AddWithValue("IdCCosto", _AvanceFisico.IdCCosto)
        command.Parameters.AddWithValue("Mes", _AvanceFisico.Mes)
        command.Parameters.AddWithValue("Anio", _AvanceFisico.Anio)
        command.Parameters.AddWithValue("Valor", _AvanceFisico.Valor)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                _id = reader.GetValue(0)
            End If
        End Using
        Return _id
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AvanceFisico)
        Dim lista As New List(Of AvanceFisico)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _AvanceFisico As New AvanceFisico() With
                    {
                        .IdAvanceFisico = reader.GetValue(reader.GetOrdinal("IdAvanceFisico")),
                        .IdCCosto = reader.GetValue(reader.GetOrdinal("IdCCosto"))
                    }
                If Not (reader.IsDBNull(reader.GetOrdinal("Mes"))) Then
                    _AvanceFisico.Mes = reader.GetValue(reader.GetOrdinal("Mes"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Anio"))) Then
                    _AvanceFisico.Anio = reader.GetValue(reader.GetOrdinal("Anio"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Valor"))) Then
                    _AvanceFisico.Valor = reader.GetValue(reader.GetOrdinal("Valor"))
                End If
                Dim _miCCosto As New CCostoRepository
                _AvanceFisico._CCosto = _miCCosto.GetCCOSTOByIdCCosto(_AvanceFisico.IdCCosto)

                Dim _miElementoGasto As New ElementoGastoRepository
                _AvanceFisico._ElementoGasto = _miElementoGasto.GetFromElementoGastoById(_AvanceFisico._CCosto.IdElemGasto)

                Dim _miProyAct As New ProyActRepository
                _AvanceFisico._ProyAct = _miProyAct.GetProyActById(_AvanceFisico._CCosto.IdProyAct)

                Dim _miActidvidad As New ActividadRepository
                _AvanceFisico._Act = _miActidvidad.GetFromActividadById(_AvanceFisico._ProyAct.IdActividad)

                Dim _miProyComp As New ProyCompRepository
                _AvanceFisico._ProyComp = _miProyComp.GetProyCompById(_AvanceFisico._ProyAct.IdProycomp)

                Dim _miComponente As New ComponenteRepository
                _AvanceFisico._Componente = _miComponente.GetFromComponenteById(_AvanceFisico._ProyComp.IdComponente)

                lista.Add(_AvanceFisico)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAvanceFisicoByIdProyecto(ByVal _IdProyecto As Integer, ByVal _Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.AvanceFisico) Implements IAvanceFisicoRepository.GetAvanceFisicoByIdProyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAVANCEFISICOByIdProyecto")
        command.Parameters.AddWithValue("IdProyecto", _IdProyecto)
        command.Parameters.AddWithValue("Mes", _Mes)
        Return SelectObjectFactory(command)
    End Function

    Public Sub NewAvanceFisico(ByVal _IdProyecto As Integer, ByVal _Anio As Integer, ByVal _Mes As Integer) Implements IAvanceFisicoRepository.NewAvanceFisico
        Dim command As SqlCommand = MyBase.CreateSPCommand("NueAvanceFisico")
        command.Parameters.AddWithValue("IdProyecto", _IdProyecto)
        command.Parameters.AddWithValue("Anio", _Anio)
        command.Parameters.AddWithValue("Mes", _Mes)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
