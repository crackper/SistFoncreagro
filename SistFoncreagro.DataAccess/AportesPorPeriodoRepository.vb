Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class AportesPorPeriodoRepository : Inherits MasterDataAccess : Implements IAportesPorPeriodoRepository
    Dim periodoDeclaracion As IPeriodoDeclaracionRepository
    Dim sistemaPensiones As ISistemaDePensionesRepository
    Sub New()
        periodoDeclaracion = New PeriodoDeclaracionRepository
        sistemaPensiones = New SistemaDePensionesRepository
    End Sub
    Public Sub SaveAportesPorPeriodo(ByVal aportesPeriodo As BussinessEntities.AportesPorPeriodo) Implements IAportesPorPeriodoRepository.SaveAportesPorPeriodo

    End Sub

    Public Function GetFromAportePorPeridoAnterior(ByVal idPeriodoDeclaracionas As Integer) As BussinessEntities.AportesPorPeriodo Implements IAportesPorPeriodoRepository.GetFromAportePorPeridoAnterior
        'Dim command As SqlCommand =
        '     MyBase.CreateSPCommand("GetFromAportePorPeridoAnterior")
        'command.Parameters.AddWithValue("IdPeridoAnterior", idPeriodoDeclaracionas)
        'Return SelectObjectFactory(command, False).SingleOrDefault
    End Function

    Public Sub SaveListaAportes(ByVal aportePerido As BussinessEntities.AportesPorPeriodo) Implements IAportesPorPeriodoRepository.SaveListaAportes
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveListaAportes")
        command.Parameters.AddWithValue("IdPeriodoDeclaracion", aportePerido.IdPeridoDeclaracion)
        command.Parameters.AddWithValue("IdSistemaPensiones", aportePerido.IdSistemaPensiones)
        command.Parameters.AddWithValue("IdAporteSP", aportePerido.IdAporteSp)
        command.Parameters.AddWithValue("Porcentaje", aportePerido.Porcentaje)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub SaveListaAportes1(ByVal aportePerido As System.Collections.Generic.List(Of BussinessEntities.AportesPorPeriodo)) Implements IAportesPorPeriodoRepository.SaveListaAportes1
        For Each lista As AportesPorPeriodo In aportePerido
            SaveListaAportes(lista)
        Next
    End Sub

    Public Function GetFromAportePorPeriodoBandeja() As System.Collections.Generic.List(Of BussinessEntities.AportesPorPeriodo) Implements IAportesPorPeriodoRepository.GetFromAportePorPeriodoBandeja
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFromAportePorPeriodoBandeja")
        Return SelectObjectFactory(command, True)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand, ByVal bandeja As Boolean) As List(Of AportesPorPeriodo)
        Dim listaAportePeriodo As New List(Of AportesPorPeriodo)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim aportePeriodo As New AportesPorPeriodo

                With aportePeriodo
                    .IdPeridoDeclaracion = reader.GetInt32(0)
                    .IdSistemaPensiones = reader.GetInt32(1)
                    .IdAporteSp = reader.GetInt32(2)
                    .Porcentaje = reader.GetDecimal(3)
                    .IdAportesPorPerido = reader.GetInt32(4)
                    .Bandeja = reader.GetBoolean(5)
                End With
                If bandeja = True Then
                    aportePeriodo.peridoDeclaracion = periodoDeclaracion.GetPeriodoDeclaracionByIdPeriodoDeclaracion(reader.GetInt32(0))
                    aportePeriodo.sistemaPensiones = sistemaPensiones.GetFromSistemaPensionesByIdSistemaPensiones(reader.GetInt32(1))
                End If
                listaAportePeriodo.Add(aportePeriodo)
            End While

        End Using
        Return listaAportePeriodo
    End Function

    Public Sub UpdateListaAportes(ByVal aportePerido As BussinessEntities.AportesPorPeriodo) Implements IAportesPorPeriodoRepository.UpdateListaAportes
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateListaAportes")
        command.Parameters.AddWithValue("IdPeriodoDeclaracion", aportePerido.IdPeridoDeclaracion)
        command.Parameters.AddWithValue("IdSistemaPensiones", aportePerido.IdSistemaPensiones)
        command.Parameters.AddWithValue("IdAporteSP", aportePerido.IdAporteSp)
        command.Parameters.AddWithValue("Porcentaje", aportePerido.Porcentaje)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateListaAportes1(ByVal aportePerido As System.Collections.Generic.List(Of BussinessEntities.AportesPorPeriodo)) Implements IAportesPorPeriodoRepository.UpdateListaAportes1
        For Each lista As AportesPorPeriodo In aportePerido
            UpdateListaAportes(lista)
        Next
    End Sub
    'Mio a partir de aca
    Public Function GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP(ByVal IdPeriodoDeclaracion As Integer, ByVal IdSistemaPensiones As Integer, ByVal IdAporteSP As Integer) As BussinessEntities.AportesPorPeriodo Implements IAportesPorPeriodoRepository.GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAPORTESPPORPERIODOByIdPeriodoAndIdSistemaPensionesIdAporteSP")
        command.Parameters.AddWithValue("IdPeriodoDeclaracion", IdPeriodoDeclaracion)
        command.Parameters.AddWithValue("IdSistemaPensiones", IdSistemaPensiones)
        command.Parameters.AddWithValue("IdAporteSP", IdAporteSP)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AportesPorPeriodo)
        Dim lista As New List(Of AportesPorPeriodo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New AportesPorPeriodo
                If Not reader.IsDBNull(reader.GetOrdinal("IdAportesPorPerido")) Then
                    entity.IdAportesPorPerido = reader.GetValue(reader.GetOrdinal("IdAportesPorPerido"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdAporteSP")) Then
                    entity.IdAporteSp = reader.GetValue(reader.GetOrdinal("IdAporteSP"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPeriodoDeclaracion")) Then
                    entity.IdPeridoDeclaracion = reader.GetValue(reader.GetOrdinal("IdPeriodoDeclaracion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdSistemaPensiones")) Then
                    entity.IdSistemaPensiones = reader.GetValue(reader.GetOrdinal("IdSistemaPensiones"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Porcentaje")) Then
                    entity.Porcentaje = reader.GetValue(reader.GetOrdinal("Porcentaje"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
   
End Class
