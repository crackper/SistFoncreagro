Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AportesSpRepository : Inherits MasterDataAccess : Implements IAportesSpRepository
    Dim aportePorPerido As IAportesPorPeriodoRepository
    Sub New()
        aportePorPerido = New AportesPorPeriodoRepository
    End Sub
    Public Function GetAllFromAportesSp() As System.Collections.Generic.List(Of BussinessEntities.AporteSp) Implements IAportesSpRepository.GetAllFromAportesSp
        Dim command As SqlCommand =
              MyBase.CreateSPCommand("GetAllFromAportesSp2")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SaveAportesSp(ByVal aportes As BussinessEntities.AporteSp) Implements IAportesSpRepository.SaveAportesSp

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AporteSp)
        Dim listaAporteSp As New List(Of AporteSp)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim aporteSp As New AporteSp
                With aporteSp
                    .IdAporteSp = reader.GetInt32(0)
                    .Descripcion = reader.GetString(1)
                End With
                If Not reader.IsDBNull(2) Then
                    aporteSp.IdConceptoPlanilla = reader.GetInt32(2)
                End If
                If Not reader.IsDBNull(3) Then
                    aporteSp.IdDetalleConcepto = reader.GetInt32(3)
                End If
                If Not reader.IsDBNull(4) Then
                    aporteSp.RemuneracionTope = reader.GetDecimal(4)
                End If
                If Not reader.IsDBNull(5) Then
                    aporteSp.RemuneracionMinima = reader.GetDecimal(5)
                End If
                If Not reader.IsDBNull(6) Then
                    aporteSp.Porcentaje = reader.GetDecimal(6)
                End If
                listaAporteSp.Add(aporteSp)
            End While
        End Using
        Return listaAporteSp
    End Function

    Public Function GetAllFromAporteAnterior(ByVal idSistema As Integer, ByVal idPerido As Integer) As Object Implements IAportesSpRepository.GetAllFromAporteAnterior
        Dim command As SqlCommand =
             MyBase.CreateSPCommand("GetFromAportePorPeridoAnterior")
        command.Parameters.AddWithValue("IdSistemaPensiones", idSistema)
        command.Parameters.AddWithValue("IdPerido", idPerido)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromAporteGuardado(ByVal idSistema As Integer, ByVal idPerido As Integer) As Object Implements IAportesSpRepository.GetAllFromAporteGuardado
        Dim command As SqlCommand =
           MyBase.CreateSPCommand("GetAllFromAporteGuardado")
        command.Parameters.AddWithValue("IdSistemaPensiones", idSistema)
        command.Parameters.AddWithValue("IdPerido", idPerido)
        Return SelectObjectFactory(command)
    End Function
End Class
