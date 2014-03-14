Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class LineaRepository : Inherits MasterDataAccess : Implements ILineaRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Linea)
        Dim lista As New List(Of Linea)
        Dim PlanContableRepository As New PlanContableRepository
        Dim CCostoRepository As New CCostoRepository
        Dim TipoDocumentoRepository As New TipoDocumentoRepository
        Dim ProveedorRepository As New ProveedorClienteRepository
        Dim TransaccionRepository As New TransaccionRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Linea As New Linea() With
                {
                    .MontoAbono = reader.GetValue(0),
                    .MontoCargo = reader.GetValue(1),
                    .IdPlan = reader.GetValue(2),
                    .Glosa = reader.GetValue(3),
                    .IdLinea = reader.GetValue(4),
                    .IdTransaccion = reader.GetValue(5),
                    .FechaDocumento = reader.GetValue(11),
                    .Flag = reader.GetValue(12),
                    .Estado = reader.GetValue(14),
                    .IdMoneda = reader.GetValue(15),
                    .CargoMN = reader.GetValue(16),
                    .CargoME = reader.GetValue(17),
                    .AbonoMN = reader.GetValue(18),
                    .AbonoME = reader.GetValue(19)
                }

                If Not (reader.IsDBNull(6)) Then
                    _Linea.IdCCosto = reader.GetValue(6)
                    _Linea.CCosto = CCostoRepository.GetCCOSTOByIdCCosto(reader.GetValue(6))
                End If
                If Not (reader.IsDBNull(7)) Then
                    _Linea.IdProveedorCliente = reader.GetValue(7)
                    _Linea.Proveedor = ProveedorRepository.GetAllFromProveedorClienteById(reader.GetValue(7))
                End If
                If Not (reader.IsDBNull(13)) Then
                    _Linea.TipoCambio = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _Linea.IdTipoDocumento = reader.GetValue(8)
                    _Linea.TipoDocumento = TipoDocumentoRepository.GetTIPODOCUMENTOByIdTipoDocumento(reader.GetValue(8))
                End If
                If Not (reader.IsDBNull(9)) Then
                    _Linea.NroDocumento = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Linea.SerieDocumento = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _Linea.Enlace = reader.GetValue(20)
                End If
                If Not (reader.IsDBNull(21)) Then
                    _Linea.CtaEnlace = reader.GetValue(21)
                End If
                If Not (reader.IsDBNull(22)) Then
                    _Linea.FechaPago = reader.GetValue(22)
                End If
                If Not (reader.IsDBNull(23)) Then
                    _Linea.FechaVencimiento = reader.GetValue(23)
                End If
                _Linea.PlanContable = PlanContableRepository.GetPLANCONTABLEByIdPlan(reader.GetValue(2))
                _Linea.Transaccion = TransaccionRepository.GetTRANSACCIONByIdtransaccion(reader.GetValue(5))

                lista.Add(_Linea)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromLINEA() As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaRepository.GetAllFromLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromLINEA")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetLINEAByIdTransaccion(ByVal IdTransaccion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaRepository.GetLINEAByIdTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEAByIdTransaccion")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteLINEA(ByVal IdLinea As Integer) Implements ILineaRepository.DeleteLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteLINEA")
        command.Parameters.AddWithValue("IdLinea", IdLinea)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetLINEAByIdLinea(ByVal IdLinea As Integer) As BussinessEntities.Linea Implements ILineaRepository.GetLINEAByIdLinea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEAByIdLinea")
        command.Parameters.AddWithValue("IdLinea", IdLinea)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Sub GenerarLINEA(ByVal IdTransaccion As Integer) Implements ILineaRepository.GenerarLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarLINEA")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetNumeroRegistrosFromLINEA(ByVal IdTransaccion As Integer) As Integer Implements ILineaRepository.GetNumeroRegistrosFromLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetNumeroRegistrosFromLINEA")
        Dim valor As Int32
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor
    End Function

    Public Sub DeleteLINEAByFlag(ByVal IdTransaccion As Integer) Implements ILineaRepository.DeleteLINEAByFlag
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteLINEAByFlag")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetLINEAByIdTransaccionAndFlag(ByVal IdTransaccion As Integer) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaRepository.GetLINEAByIdTransaccionAndFlag
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEAByIdTransaccionAndFlag")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Return SelectObjectFactory(command)
    End Function
    Public Sub GenerarLINEACaja(ByVal IdTransaccion As Integer) Implements ILineaRepository.GenerarLINEACaja
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarLINEACaja")
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub UpdateEstadoLINEA(ByVal IdLinea As Integer) Implements ILineaRepository.UpdateEstadoLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoLINEA")
        command.Parameters.AddWithValue("IdLinea", IdLinea)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function SaveLINEA(ByVal _Linea As BussinessEntities.Linea) As Integer Implements ILineaRepository.SaveLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveLINEA")
        command.Parameters.Clear()
        command.Parameters.AddWithValue("FechaDocumento", _Linea.FechaDocumento)
        command.Parameters.AddWithValue("Glosa", _Linea.Glosa)
        command.Parameters.AddWithValue("IdCCosto", _Linea.IdCCosto)
        command.Parameters.AddWithValue("IdLinea", _Linea.IdLinea)
        command.Parameters.AddWithValue("IdPlan", _Linea.IdPlan)
        command.Parameters.AddWithValue("IdProveedorCliente", _Linea.IdProveedorCliente)
        command.Parameters.AddWithValue("IdTipoDocumento", _Linea.IdTipoDocumento)
        command.Parameters.AddWithValue("IdTransaccion", _Linea.IdTransaccion)
        command.Parameters.AddWithValue("MontoAbono", _Linea.MontoAbono)
        command.Parameters.AddWithValue("MontoCargo", _Linea.MontoCargo)
        command.Parameters.AddWithValue("NroDocumento", _Linea.NroDocumento)
        command.Parameters.AddWithValue("SerieDocumento", _Linea.SerieDocumento)
        command.Parameters.AddWithValue("TipoCambio", _Linea.TipoCambio)
        command.Parameters.AddWithValue("Flag", _Linea.Flag)
        command.Parameters.AddWithValue("IdMoneda", _Linea.IdMoneda)
        command.Parameters.AddWithValue("Enlace", _Linea.Enlace)
        command.Parameters.AddWithValue("Estado", _Linea.Estado)
        command.Parameters.AddWithValue("CargoMN", _Linea.CargoMN)
        command.Parameters.AddWithValue("CargoME", _Linea.CargoME)
        command.Parameters.AddWithValue("AbonoMN", _Linea.AbonoMN)
        command.Parameters.AddWithValue("AbonoME", _Linea.AbonoME)
        command.Parameters.AddWithValue("CtaEnlace", _Linea.CtaEnlace)
        command.Parameters.AddWithValue("FechaPago", _Linea.FechaPago)
        command.Parameters.AddWithValue("FechaVencimiento", _Linea.FechaVencimiento)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using


        Return i

    End Function

    Public Function GetLINEACaja(ByVal Anio As Integer, ByVal IdProveedorCliente As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaRepository.GetLINEACaja
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEACaja")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("IdProveedorCliente", IdProveedorCliente)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetLINEACajaMasivos(ByVal Anio As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaRepository.GetLINEACajaMasivos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEACajaMasivos")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTRANSACCIONByIdLinea(ByVal IdLinea As Integer) As Integer Implements ILineaRepository.GetTRANSACCIONByIdLinea
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTRANSACCIONByIdLinea")
        Dim valor As Int32
        command.Parameters.AddWithValue("IdLinea", IdLinea)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor
    End Function

    Public Function GetLINEADiario(ByVal Coa As Integer, ByVal OpFinan As Integer) As System.Collections.Generic.List(Of BussinessEntities.Linea) Implements ILineaRepository.GetLINEADiario
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEADiario")
        command.Parameters.AddWithValue("Coa", Coa)
        command.Parameters.AddWithValue("OpFinan", OpFinan)
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateMontosLINEA(ByVal idLinea As Integer, ByVal monto As Decimal) Implements ILineaRepository.UpdateMontosLINEA
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateMontosLINEA")
        command.Parameters.AddWithValue("idLinea", idLinea)
        command.Parameters.AddWithValue("monto", monto)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Function GetLINEAByRegistro(ByVal Registro As String, ByVal Coa As String, ByVal Cuenta As String) As BussinessEntities.Linea Implements ILineaRepository.GetLINEAByRegistro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetLINEAByRegistro")
        command.Parameters.AddWithValue("Registro", Registro)
        command.Parameters.AddWithValue("Coa", Coa)
        command.Parameters.AddWithValue("Cuenta", Cuenta)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetNumeroRegistrosFromLINEA1(ByVal IdTransaccion As Integer) As Integer Implements ILineaRepository.GetNumeroRegistrosFromLINEA1
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetNumeroRegistrosFromLINEA1")
        Dim valor As Int32
        command.Parameters.AddWithValue("IdTransaccion", IdTransaccion)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor
    End Function
End Class
