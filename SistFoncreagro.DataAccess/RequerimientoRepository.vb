Imports System.Data.Common
Imports System.Data.SqlClient
Imports SistFoncreagro.BussinessEntities

Public Class RequerimientoRepository : Inherits MasterDataAccess : Implements IRequerimientoRepository
    Dim personaRepository As IPersonalRepository
    Dim monedaRepository As IMonedaRepository
    Dim detalleRequerimiento1 As IDetalleRequerimientoRepository
    Sub New()
        personaRepository = New PersonalRepository
        monedaRepository = New MonedaRepository
        detalleRequerimiento1 = New DetalleRequerimientoRepository
    End Sub
    Public Function GetAllFromRequerimientoByIdReq(ByVal IdRequerimiento As Integer) As BussinessEntities.Requerimiento Implements IRequerimientoRepository.GetAllFromRequerimientoByIdReq
        Dim command As SqlCommand =
          MyBase.CreateSPCommand("GetAllFromREQUERIMIENTOSByIdReq")
        command.Parameters.AddWithValue("IdRequerimiento", IdRequerimiento)
        Return SelectObjectFactoryRequerimiento(command).SingleOrDefault
    End Function

    Public Function GetAllFromRequerimientoByIdPersona(ByVal IdUser As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoRepository.GetAllFromRequerimientoByIdPersona
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromREQUERIMIENTOSByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdUser)
        Return SelectObjectFactoryRequerimiento(command)
    End Function

    Public Function GetAllFromRequerimientosAprobadosByIdComprador(ByVal IdPersonaComprador As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoRepository.GetAllFromRequerimientosAprobadosByIdComprador
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromREQUERIMIENTOSAprobadosByIdComprador")
        command.Parameters.AddWithValue("IdPersonalComprador ", IdPersonaComprador)
        Return SelectObjectFactoryRequerimiento(command)
    End Function
    Public Function GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente(ByVal IdAsistente As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoRepository.GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente")
        command.Parameters.AddWithValue("IdPersonalComprador ", IdAsistente)
        Return SelectObjectFactoryRequerimiento(command)
    End Function
    Public Function SaveRequerimiento(ByVal requerimiento As BussinessEntities.Requerimiento) As Integer Implements IRequerimientoRepository.SaveRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveREQUERIMIENTO")
        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "idRequerimiento"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = requerimiento.IdRequerimiento
        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdProyectoArea", requerimiento.IdProyectoArea)
        command.Parameters.AddWithValue("IdCentroCosto", requerimiento.IdCentroCosto)
        command.Parameters.AddWithValue("IdMoneda", requerimiento.IdMoneda)
        command.Parameters.AddWithValue("Tipo", requerimiento.Tipo)
        command.Parameters.AddWithValue("IdRequeridoPor", requerimiento.IdRequeridoPor)
        command.Parameters.AddWithValue("Observacion", requerimiento.Observacion)
        command.Parameters.AddWithValue("Sustento", requerimiento.Sustento)
        command.Parameters.AddWithValue("Periodo", requerimiento.Periodo)
        command.Parameters.AddWithValue("FechaInicioServ", requerimiento.FechaInicioServicio)
        command.Parameters.AddWithValue("FechaFinServ", requerimiento.FechaFinServicio)
        command.Parameters.AddWithValue("Ruta", requerimiento.Ruta)
        command.Parameters.AddWithValue("IdRutaOrigen", requerimiento.IdRutaOrigen)
        command.Parameters.AddWithValue("IdRutaDestino", requerimiento.IdRutaDestino)
        MyBase.ExecuteNonQuery(command)
        requerimiento.IdRequerimiento = parametroBase.Value
        Return requerimiento.IdRequerimiento
    End Function

    Public Sub SaveDetalleRequerimiento(ByVal detalleRequerimiento As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento)) Implements IRequerimientoRepository.SaveDetalleRequerimiento
        detalleRequerimiento1.UpdateDetalleRequerimiento1(detalleRequerimiento)
    End Sub

    Public Sub UpdateDetalleRequerimiento(ByVal detalleRequerimiento As System.Collections.Generic.List(Of BussinessEntities.DetalleRequerimiento)) Implements IRequerimientoRepository.UpdateDetalleRequerimiento
        detalleRequerimiento1.UpdateDetalleReq1(detalleRequerimiento)
    End Sub
    Private Function SelectObjectFactoryRequerimiento(ByVal command As SqlCommand) As List(Of Requerimiento)
        Dim listaRequerimientos As New List(Of Requerimiento)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim requerimiento As New Requerimiento()
                With requerimiento
                    .IdRequerimiento = reader.GetInt32(0)
                    .IdProyectoArea = reader.GetInt32(1)
                    .IdCentroCosto = reader.GetInt32(2)
                    .IdMoneda = reader.GetInt32(3)
                    .Numero = reader.GetString(4)
                    .FechaRequerimiento = reader.GetDateTime(5)
                    .Tipo = reader.GetString(6)
                    .IdRequeridoPor = reader.GetInt32(7)
                    .Estado = reader.GetString(8)
                    .Sustento = reader.GetString(10)
                    .Monto = reader.GetDecimal(13)
                    .Periodo = reader.GetBoolean(14)
                    .Ruta = reader.GetBoolean(17)
                    .ActivarCentroCosto = reader.GetBoolean(20)
                End With
                If Not reader.IsDBNull(9) Then
                    requerimiento.FechaEnvioAprobar = reader.GetDateTime(9)
                End If
                If Not reader.IsDBNull(11) Then
                    requerimiento.Observacion = reader.GetString(11)
                End If
                If Not reader.IsDBNull(12) Then
                    requerimiento.IdComprador = reader.GetInt32(12)
                End If
                If Not reader.IsDBNull(15) Then
                    requerimiento.FechaInicioServicio = reader.GetDateTime(15)
                End If
                If Not reader.IsDBNull(16) Then
                    requerimiento.FechaFinServicio = reader.GetDateTime(16)
                End If
                If Not reader.IsDBNull(18) Then
                    requerimiento.IdRutaOrigen = reader.GetInt32(18)
                End If
                If Not reader.IsDBNull(19) Then
                    requerimiento.IdRutaDestino = reader.GetInt32(19)
                End If
                If Not reader.IsDBNull(21) Then
                    requerimiento.IdResponsableAprobar = reader.GetInt32(21)
                End If
                If Not reader.IsDBNull(22) Then
                    requerimiento.AbreviacionMoneda = reader.GetString(22)
                End If
                If Not reader.IsDBNull(23) Then
                    requerimiento.NombreRequiere = reader.GetString(23)
                End If
                If Not reader.IsDBNull(24) Then
                    requerimiento.CodigoArea = reader.GetString(24)
                End If
                If Not reader.IsDBNull(25) Then
                    requerimiento.NroAdjuntos = reader.GetInt32(25)
                End If
                listaRequerimientos.Add(requerimiento)
            End While
        End Using
        Return listaRequerimientos
    End Function
    Public Sub AnularRequerimiento(ByVal idRequerimiento As Integer, ByVal IdPersonal As Integer, ByVal Motivo As String, ByVal Tipo As Integer) Implements IRequerimientoRepository.AnularRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("AnularRequerimientoCompra")
        command.Parameters.AddWithValue("IdRequerimiento", idRequerimiento)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("Motivo", Motivo)
        command.Parameters.AddWithValue("Tipo", Tipo)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub SolictarAprobacion(ByVal idRequerimiento As Integer) Implements IRequerimientoRepository.SolictarAprobacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("SolicitarAprobacionRequerimientoCompraProceso")
        command.Parameters.AddWithValue("IdRequerimiento", idRequerimiento)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub AprobarRequerimiento(ByVal idRequerimiento As Integer, ByVal IdPersonal As Integer) Implements IRequerimientoRepository.AprobarRequerimiento
        Dim command As SqlCommand = MyBase.CreateSPCommand("AprobarRequerimientoProceso")
        command.Parameters.AddWithValue("IdRequerimiento", idRequerimiento)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromRequerimientoHabilitar() As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoRepository.GetAllFromRequerimientoHabilitar
        Dim command As SqlCommand =
         MyBase.CreateSPCommand("GetAllFromRequerimientoHabilitar")
        Return SelectObjectFactoryRequerimiento(command)
    End Function

    Public Function HabilitarCentroCosto(ByVal idRequerimiento As Integer, ByVal valor As Boolean) As Int32 Implements IRequerimientoRepository.HabilitarCentroCosto
        Dim command As SqlCommand = MyBase.CreateSPCommand("HabilitarCentroCosto")
        Dim resultado As Int32 = 0
        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "Resultado"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = resultado
        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdRequerimiento", idRequerimiento)
        command.Parameters.AddWithValue("Valor", valor)
        MyBase.ExecuteNonQuery(command)
        resultado = parametroBase.Value
        Return resultado
    End Function

    Public Function GetAllFromRequerimientoPorAprobarByIdResponsableAprobar(ByVal IdResponsableAprobar As Integer) As System.Collections.Generic.List(Of BussinessEntities.Requerimiento) Implements IRequerimientoRepository.GetAllFromRequerimientoPorAprobarByIdResponsableAprobar
        Dim command As SqlCommand =
          MyBase.CreateSPCommand("GetAllFromRequerimientoPorAprobarByIdResponsableAprobar")
        command.Parameters.AddWithValue("IdResponsableAprobar", IdResponsableAprobar)
        Return SelectObjectFactoryRequerimiento(command)
    End Function
    Public Sub CambiarComprador(ByVal IdRequerimiento As Integer, ByVal IdPersonal As Integer) Implements IRequerimientoRepository.CambiarComprador
        Dim command As SqlCommand = MyBase.CreateSPCommand("CambiarComprador")
        command.Parameters.AddWithValue("IdRequerimiento", IdRequerimiento)
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Private Function SelectObjectFactoryRequerimientosAprobados(ByVal command As SqlCommand) As List(Of Requerimiento)
        Dim listaRequerimientos As New List(Of Requerimiento)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read()
                Dim requerimiento As New Requerimiento()
                With requerimiento
                    .IdRequerimiento = reader.GetInt32(0)
                    .IdProyectoArea = reader.GetInt32(1)
                    .IdMoneda = reader.GetInt32(2)
                    .Numero = reader.GetString(3)
                    .Tipo = reader.GetString(4)
                    .Estado = reader.GetString(5)
                    .Sustento = reader.GetString(6)
                    .Monto = reader.GetDecimal(7)
                End With
                If Not reader.IsDBNull(12) Then
                    requerimiento.IdComprador = reader.GetInt32(12)
                End If
                requerimiento.personaComprador = personaRepository.GetPersonalByIdPersonal(reader.GetInt32(7))
                listaRequerimientos.Add(requerimiento)
            End While
        End Using
        Return listaRequerimientos
    End Function
    Public Sub EnviarLicitacion(ByVal IdReq As Integer, ByVal IdAsistenteReq As Integer) Implements IRequerimientoRepository.EnviarLicitacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("EnviarLicitacion")
        command.Parameters.AddWithValue("IdRequerimiento", IdReq)
        command.Parameters.AddWithValue("IdAsistenteReq", IdAsistenteReq)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class