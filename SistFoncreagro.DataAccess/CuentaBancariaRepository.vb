Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CuentaBancariaRepository : Inherits MasterDataAccess : Implements ICuentaBancariaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CuentaBancaria)
        Dim lista As New List(Of CuentaBancaria)
        Dim MonedaRepository As New MonedaRepository
        Dim PlanRepository As New PlanContableRepository
        Dim BancoRepository As New BancoRepository
        Dim TipoCtaRepository As New TipoCtaBancariaRepository
        Dim Subdiario As New SubdiarioRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)

            While reader.Read
                Dim _CuentaBancaria As New CuentaBancaria() With
                {
                    .Descripcion = reader.GetValue(0),
                    .IdBanco = reader.GetValue(1),
                    .IdCtaBancaria = reader.GetValue(2),
                    .IdMoneda = reader.GetValue(3),
                    .IdPlan = reader.GetValue(4),
                    .IdTipoCtaBancaria = reader.GetValue(5),
                    .NroCta = reader.GetValue(6),
                    .Saldo = reader.GetValue(7),
                    .Estado = reader.GetValue(8),
                    .IdSubdiario = reader.GetValue(9)
                }
                _CuentaBancaria.Moneda = MonedaRepository.GetMonedaByIdMoneda(reader.GetValue(3))
                _CuentaBancaria.Plan = PlanRepository.GetCodigoFromPLANCONTABLE(reader.GetValue(4))
                _CuentaBancaria.Banco = BancoRepository.GetBANCOByIdBanco(reader.GetValue(1))
                _CuentaBancaria.TipoCta = TipoCtaRepository.GetTIPOCTABANCARIAByIdTipoCtaBancaria(reader.GetValue(5))
                _CuentaBancaria.SubDiario = Subdiario.GetSUBDIARIOByIdSubDiario(reader.GetValue(9))
                lista.Add(_CuentaBancaria)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
    End Function
    Public Function GetCUENTABANCARIAByIdPoyecto(ByVal IdProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaRepository.GetCUENTABANCARIAByIdPoyecto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTABANCARIAByIdPoyecto")
        command.Parameters.AddWithValue("IdProyecto", IdProyecto)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromCUENTABANCARIA() As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaRepository.GetAllFromCUENTABANCARIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCUENTABANCARIA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCUENTABANCARIAByIdCtaBancaria(ByVal IdCtaBancaria As Integer) As BussinessEntities.CuentaBancaria Implements ICuentaBancariaRepository.GetCUENTABANCARIAByIdCtaBancaria
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTABANCARIAByIdCtaBancaria")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetCTABANCARIAInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaRepository.GetCTABANCARIAInTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCTABANCARIAInTransaccion")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function
    Public Sub SaveCUENTABANCARIA(ByVal _CuentaBancaria As BussinessEntities.CuentaBancaria) Implements ICuentaBancariaRepository.SaveCUENTABANCARIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCUENTABANCARIA")
        command.Parameters.AddWithValue("Descripcion", _CuentaBancaria.Descripcion)
        command.Parameters.AddWithValue("IdBanco", _CuentaBancaria.IdBanco)
        command.Parameters.AddWithValue("IdCtaBancaria", _CuentaBancaria.IdCtaBancaria)
        command.Parameters.AddWithValue("IdMoneda", _CuentaBancaria.IdMoneda)
        command.Parameters.AddWithValue("IdPlan", _CuentaBancaria.IdPlan)
        command.Parameters.AddWithValue("IdTipoCtaBancaria", _CuentaBancaria.IdTipoCtaBancaria)
        command.Parameters.AddWithValue("NroCta", _CuentaBancaria.NroCta)
        command.Parameters.AddWithValue("IdSubdiario", _CuentaBancaria.IdSubdiario)
        MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoCUENTABANCARIA(ByVal IdCtaBancaria As Integer) Implements ICuentaBancariaRepository.UpdateEstadoCUENTABANCARIA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCUENTABANCARIA")
        command.Parameters.AddWithValue("IdCtaBancaria", IdCtaBancaria)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetCTABANCARIAInConciliacion(ByVal Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.CuentaBancaria) Implements ICuentaBancariaRepository.GetCTABANCARIAInConciliacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCTABANCARIAInConciliacion")
        command.Parameters.AddWithValue("Anio", Anio)
        Return SelectObjectFactory(command)
    End Function
End Class
