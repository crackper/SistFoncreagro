Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Partial Public Class ConvenioRepository : Inherits MasterDataAccess : Implements IConvenioRepository

    Public Function GetAllFromConvenio() As System.Collections.Generic.List(Of BussinessEntities.Convenio) Implements IConvenioRepository.GetAllFromConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCONVENIO")
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Convenio)

        Dim lista As New List(Of Convenio)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Convenio As New Convenio() With
                {.IdConvenio = reader.GetValue(reader.GetOrdinal("IdConvenio")),
                    .Codigo = reader.GetValue(reader.GetOrdinal("Codigo")),
                    .Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                }
                If Not (reader.IsDBNull(reader.GetOrdinal("IdMoneda"))) Then
                    _Convenio.IdMoneda = reader.GetValue(reader.GetOrdinal("IdMoneda"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("MontoInicial"))) Then
                    _Convenio.MontoInicial = reader.GetValue(reader.GetOrdinal("MontoInicial"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("IdTipConv"))) Then
                    _Convenio.IdTipConv = reader.GetValue(reader.GetOrdinal("IdTipConv"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("IdConveMarco"))) Then
                    _Convenio.IdConveMarco = reader.GetValue(reader.GetOrdinal("IdConveMarco"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FecIni"))) Then
                    _Convenio.FecIni = reader.GetValue(reader.GetOrdinal("FecIni"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FecFin"))) Then
                    _Convenio.FecFin = reader.GetValue(reader.GetOrdinal("FecFin"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FaseCont"))) Then
                    _Convenio.FaseCont = reader.GetValue(reader.GetOrdinal("FaseCont"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Estado"))) Then
                    _Convenio.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Ejecutado"))) Then
                    _Convenio.Ejecutado = reader.GetValue(reader.GetOrdinal("Ejecutado"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("FechaFirma"))) Then
                    _Convenio.FechaFirma = reader.GetValue(reader.GetOrdinal("FechaFirma"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("MontoTotal"))) Then
                    _Convenio.MontoTotal = reader.GetValue(reader.GetOrdinal("MontoTotal"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Comprometido"))) Then
                    _Convenio.Comprometido = reader.GetValue(reader.GetOrdinal("Comprometido"))
                End If
                If Not (reader.IsDBNull(reader.GetOrdinal("Presupuestado"))) Then
                    _Convenio.Presupuestado = reader.GetValue(reader.GetOrdinal("Presupuestado"))
                End If

                Dim _miConveMarco As New ConveMarcoRepository
                _Convenio._ConveMarco = _miConveMarco.GetFromConveMarcoByIdConveMarco(_Convenio.IdConveMarco)

                Dim _miTipoConvenio As New TipoConvenioRepository
                _Convenio._TipoConvenio = _miTipoConvenio.GetTipoConvenioByIdTipoConvenio(_Convenio.IdTipConv)

                Dim _miMoneda As New MonedaRepository
                _Convenio._Moneda = _miMoneda.GetMonedaByIdMoneda(_Convenio.IdMoneda)

                lista.Add(_Convenio)
            End While
        End Using
        Return lista
    End Function

    Public Function SaveConvenio(ByVal convenio As BussinessEntities.Convenio) As Integer Implements IConvenioRepository.SaveConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCONVENIO")
        Dim Id As Int32

        command.Parameters.AddWithValue("IdConvenio", convenio.IdConvenio)
        command.Parameters.AddWithValue("Codigo", convenio.Codigo)
        command.Parameters.AddWithValue("Nombre", convenio.Nombre)
        command.Parameters.AddWithValue("FecIni", convenio.FecIni)
        command.Parameters.AddWithValue("FecFin", convenio.FecFin)
        command.Parameters.AddWithValue("FechaFirma", convenio.FechaFirma)
        command.Parameters.AddWithValue("IdMoneda", convenio.IdMoneda)
        command.Parameters.AddWithValue("MontoInicial", convenio.MontoInicial)
        command.Parameters.AddWithValue("IdTipConv", convenio.IdTipConv)
        command.Parameters.AddWithValue("FaseCont", convenio.FaseCont)
        command.Parameters.AddWithValue("estado", convenio.Estado)
        command.Parameters.AddWithValue("IdConveMarco", convenio.IdConveMarco)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If
        End Using
        Return Id
    End Function

    Public Function GetFromConvenioByIdConvenio(ByVal id As Integer) As BussinessEntities.Convenio Implements IConvenioRepository.GetFromConvenioByIdConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVENIOByIdConvenio")
        command.Parameters.AddWithValue("IdConvenio", id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function DeleteConvenio(ByVal id As Integer) As String Implements IConvenioRepository.DeleteConvenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteConvenio")
        command.Parameters.AddWithValue("idConvenio", id)

        Dim mMensaje As String
        mMensaje = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                mMensaje = reader.GetValue(0)
            End If
        End Using
        Return mMensaje
    End Function

    Public Function GetFromConvenioByParameters(ByVal _Codigo As String, ByVal _Nombre As String, ByVal _Estado As String, ByVal _Fase As String) As System.Collections.Generic.List(Of BussinessEntities.Convenio) Implements IConvenioRepository.GetFromConvenioByParameters
        Dim _Convenio As New Convenio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCONVENIOByParameters")
        command.Parameters.AddWithValue("Codigo", _Codigo)
        command.Parameters.AddWithValue("Nombre", _Nombre)
        command.Parameters.AddWithValue("Estado", _Estado)
        command.Parameters.AddWithValue("Fase", _Fase)
        Return SelectObjectFactory(command)
    End Function


End Class
