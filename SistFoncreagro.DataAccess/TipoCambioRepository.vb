Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoCambioRepository : Inherits MasterDataAccess : Implements ITipoCambioRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoCambio)
        Dim lista As New List(Of TipoCambio)
        Dim MonedaRepository As New MonedaRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoCambio As New TipoCambio() With
                {
                    .Anio = reader.GetValue(0),
                    .IdTipoCambio = reader.GetValue(33),
                    .Mes = reader.GetValue(34),
                    .IdMoneda = reader.GetValue(35)
                }
                If Not (reader.IsDBNull(32)) Then
                    _TipoCambio.CompraCierre = reader.GetValue(32)
                End If
                If Not (reader.IsDBNull(67)) Then
                    _TipoCambio.VentaCierre = reader.GetValue(67)
                End If
                If Not (reader.IsDBNull(1)) Then
                    _TipoCambio.Compra1 = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(12)) Then
                    _TipoCambio.Compra2 = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(23)) Then
                    _TipoCambio.Compra3 = reader.GetValue(23)
                End If
                If Not (reader.IsDBNull(26)) Then
                    _TipoCambio.Compra4 = reader.GetValue(26)
                End If
                If Not (reader.IsDBNull(27)) Then
                    _TipoCambio.Compra5 = reader.GetValue(27)
                End If
                If Not (reader.IsDBNull(28)) Then
                    _TipoCambio.Compra6 = reader.GetValue(28)
                End If
                If Not (reader.IsDBNull(29)) Then
                    _TipoCambio.Compra7 = reader.GetValue(29)
                End If
                If Not (reader.IsDBNull(30)) Then
                    _TipoCambio.Compra8 = reader.GetValue(30)
                End If
                If Not (reader.IsDBNull(31)) Then
                    _TipoCambio.Compra9 = reader.GetValue(31)
                End If
                If Not (reader.IsDBNull(2)) Then
                    _TipoCambio.Compra10 = reader.GetValue(2)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _TipoCambio.Compra11 = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _TipoCambio.Compra12 = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _TipoCambio.Compra13 = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _TipoCambio.Compra14 = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _TipoCambio.Compra15 = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _TipoCambio.Compra16 = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _TipoCambio.Compra17 = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _TipoCambio.Compra18 = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _TipoCambio.Compra19 = reader.GetValue(11)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _TipoCambio.Compra20 = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(14)) Then
                    _TipoCambio.Compra21 = reader.GetValue(14)
                End If
                If Not (reader.IsDBNull(15)) Then
                    _TipoCambio.Compra22 = reader.GetValue(15)
                End If
                If Not (reader.IsDBNull(16)) Then
                    _TipoCambio.Compra23 = reader.GetValue(16)
                End If
                If Not (reader.IsDBNull(17)) Then
                    _TipoCambio.Compra24 = reader.GetValue(17)
                End If
                If Not (reader.IsDBNull(18)) Then
                    _TipoCambio.Compra25 = reader.GetValue(18)
                End If
                If Not (reader.IsDBNull(19)) Then
                    _TipoCambio.Compra26 = reader.GetValue(19)
                End If
                If Not (reader.IsDBNull(20)) Then
                    _TipoCambio.Compra27 = reader.GetValue(20)
                End If
                If Not (reader.IsDBNull(21)) Then
                    _TipoCambio.Compra28 = reader.GetValue(21)
                End If
                If Not (reader.IsDBNull(22)) Then
                    _TipoCambio.Compra29 = reader.GetValue(22)
                End If
                If Not (reader.IsDBNull(24)) Then
                    _TipoCambio.Compra30 = reader.GetValue(24)
                End If
                If Not (reader.IsDBNull(25)) Then
                    _TipoCambio.Compra31 = reader.GetValue(25)
                End If
                If Not (reader.IsDBNull(36)) Then
                    _TipoCambio.Venta1 = reader.GetValue(36)
                End If
                If Not (reader.IsDBNull(47)) Then
                    _TipoCambio.Venta2 = reader.GetValue(47)
                End If
                If Not (reader.IsDBNull(59)) Then
                    _TipoCambio.Venta3 = reader.GetValue(58)
                End If
                If Not (reader.IsDBNull(61)) Then
                    _TipoCambio.Venta4 = reader.GetValue(61)
                End If
                If Not (reader.IsDBNull(62)) Then
                    _TipoCambio.Venta5 = reader.GetValue(62)
                End If
                If Not (reader.IsDBNull(63)) Then
                    _TipoCambio.Venta6 = reader.GetValue(63)
                End If
                If Not (reader.IsDBNull(64)) Then
                    _TipoCambio.Venta7 = reader.GetValue(64)
                End If
                If Not (reader.IsDBNull(65)) Then
                    _TipoCambio.Venta8 = reader.GetValue(65)
                End If
                If Not (reader.IsDBNull(66)) Then
                    _TipoCambio.Venta9 = reader.GetValue(66)
                End If
                If Not (reader.IsDBNull(37)) Then
                    _TipoCambio.Venta10 = reader.GetValue(37)
                End If
                If Not (reader.IsDBNull(38)) Then
                    _TipoCambio.Venta11 = reader.GetValue(38)
                End If
                If Not (reader.IsDBNull(39)) Then
                    _TipoCambio.Venta12 = reader.GetValue(39)
                End If
                If Not (reader.IsDBNull(40)) Then
                    _TipoCambio.Venta13 = reader.GetValue(40)
                End If
                If Not (reader.IsDBNull(41)) Then
                    _TipoCambio.Venta14 = reader.GetValue(41)
                End If
                If Not (reader.IsDBNull(42)) Then
                    _TipoCambio.Venta15 = reader.GetValue(42)
                End If
                If Not (reader.IsDBNull(43)) Then
                    _TipoCambio.Venta16 = reader.GetValue(43)
                End If
                If Not (reader.IsDBNull(44)) Then
                    _TipoCambio.Venta17 = reader.GetValue(44)
                End If
                If Not (reader.IsDBNull(45)) Then
                    _TipoCambio.Venta18 = reader.GetValue(45)
                End If
                If Not (reader.IsDBNull(46)) Then
                    _TipoCambio.Venta19 = reader.GetValue(46)
                End If
                If Not (reader.IsDBNull(48)) Then
                    _TipoCambio.Venta20 = reader.GetValue(48)
                End If
                If Not (reader.IsDBNull(49)) Then
                    _TipoCambio.Venta21 = reader.GetValue(49)
                End If
                If Not (reader.IsDBNull(50)) Then
                    _TipoCambio.Venta22 = reader.GetValue(50)
                End If
                If Not (reader.IsDBNull(51)) Then
                    _TipoCambio.Venta23 = reader.GetValue(51)
                End If
                If Not (reader.IsDBNull(52)) Then
                    _TipoCambio.Venta24 = reader.GetValue(52)
                End If
                If Not (reader.IsDBNull(53)) Then
                    _TipoCambio.Venta25 = reader.GetValue(53)
                End If
                If Not (reader.IsDBNull(54)) Then
                    _TipoCambio.Venta26 = reader.GetValue(54)
                End If
                If Not (reader.IsDBNull(55)) Then
                    _TipoCambio.Venta27 = reader.GetValue(55)
                End If
                If Not (reader.IsDBNull(56)) Then
                    _TipoCambio.Venta28 = reader.GetValue(56)
                End If
                If Not (reader.IsDBNull(57)) Then
                    _TipoCambio.Venta29 = reader.GetValue(57)
                End If
                If Not (reader.IsDBNull(59)) Then
                    _TipoCambio.Venta30 = reader.GetValue(59)
                End If
                If Not (reader.IsDBNull(60)) Then
                    _TipoCambio.Venta31 = reader.GetValue(60)
                End If
                _TipoCambio.Moneda = MonedaRepository.GetMonedaByIdMoneda(reader.GetValue(35))
                lista.Add(_TipoCambio)
            End While
        End Using
        Return lista
    End Function
    Public Sub DeleteTIPOCAMBIO(ByVal idTipoCambio As Integer) Implements ITipoCambioRepository.DeleteTIPOCAMBIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteTIPOCAMBIO")
        command.Parameters.AddWithValue("idTipoCambio", idTipoCambio)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromTIPOCAMBIO() As System.Collections.Generic.List(Of BussinessEntities.TipoCambio) Implements ITipoCambioRepository.GetAllFromTIPOCAMBIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOCAMBIO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOCAMBIOByIdTipCambio(ByVal IdTipoCambio As Integer) As BussinessEntities.TipoCambio Implements ITipoCambioRepository.GetTIPOCAMBIOByIdTipCambio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIOByIdTipCambio")
        command.Parameters.AddWithValue("IdTipoCambio", IdTipoCambio)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetTIPOCAMBIOByFecha(ByVal Fecha As Date) As Decimal Implements ITipoCambioRepository.GetTIPOCAMBIOByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIOByFecha")
        Dim valor As Decimal
        command.Parameters.AddWithValue("Fecha", Fecha)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor

    End Function

    Public Function GetTIPOCAMBIOByAnioMes(ByVal Anio As Integer, ByVal Mes As Integer) As BussinessEntities.TipoCambio Implements ITipoCambioRepository.GetTIPOCAMBIOByAnioMes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIOByAnioMes")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetNumeroRegistrosFromTIPOCAMBIOByAnioMes(ByVal Anio As Integer, ByVal Mes As Integer) As Integer Implements ITipoCambioRepository.GetNumeroRegistrosFromTIPOCAMBIOByAnioMes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetNumeroRegistrosFromTIPOCAMBIOByAnioMes")
        Dim valor As Int32
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor
    End Function

    Public Function GetTIPOCAMBIOByAnioMesDia(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As Decimal Implements ITipoCambioRepository.GetTIPOCAMBIOByAnioMesDia
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIOByAnioMesDia")
        Dim valor As Decimal
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        command.Parameters.AddWithValue("Dia", Dia)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor
    End Function

    Public Function GetTIPOCAMBIOByAnio(ByVal Anio As Integer) As System.Collections.Generic.List(Of BussinessEntities.TipoCambio) Implements ITipoCambioRepository.GetTIPOCAMBIOByAnio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIOByAnio")
        command.Parameters.AddWithValue("Anio", Anio)
        Return SelectObjectFactory(command)
    End Function
    Public Function SaveTIPOCAMBIO(ByVal _TipoCambio As BussinessEntities.TipoCambio) As Integer Implements ITipoCambioRepository.SaveTIPOCAMBIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTIPOCAMBIO")
        Dim id As Int32
        command.Parameters.AddWithValue("Anio", _TipoCambio.Anio)
        command.Parameters.AddWithValue("CompraCierre", _TipoCambio.CompraCierre)
        command.Parameters.AddWithValue("Mes", _TipoCambio.Mes)
        command.Parameters.AddWithValue("IdTipoCambio", _TipoCambio.IdTipoCambio)
        command.Parameters.AddWithValue("IdMoneda", _TipoCambio.IdMoneda)
        command.Parameters.AddWithValue("VentaCierre", _TipoCambio.VentaCierre)
        command.Parameters.AddWithValue("Compra1", _TipoCambio.Compra1)
        command.Parameters.AddWithValue("Compra2", _TipoCambio.Compra2)
        command.Parameters.AddWithValue("Compra3", _TipoCambio.Compra3)
        command.Parameters.AddWithValue("Compra4", _TipoCambio.Compra4)
        command.Parameters.AddWithValue("Compra5", _TipoCambio.Compra5)
        command.Parameters.AddWithValue("Compra6", _TipoCambio.Compra6)
        command.Parameters.AddWithValue("Compra7", _TipoCambio.Compra7)
        command.Parameters.AddWithValue("Compra8", _TipoCambio.Compra8)
        command.Parameters.AddWithValue("Compra9", _TipoCambio.Compra9)
        command.Parameters.AddWithValue("Compra10", _TipoCambio.Compra10)
        command.Parameters.AddWithValue("Compra11", _TipoCambio.Compra11)
        command.Parameters.AddWithValue("Compra12", _TipoCambio.Compra12)
        command.Parameters.AddWithValue("Compra13", _TipoCambio.Compra13)
        command.Parameters.AddWithValue("Compra14", _TipoCambio.Compra14)
        command.Parameters.AddWithValue("Compra15", _TipoCambio.Compra15)
        command.Parameters.AddWithValue("Compra16", _TipoCambio.Compra16)
        command.Parameters.AddWithValue("Compra17", _TipoCambio.Compra17)
        command.Parameters.AddWithValue("Compra18", _TipoCambio.Compra18)
        command.Parameters.AddWithValue("Compra19", _TipoCambio.Compra19)
        command.Parameters.AddWithValue("Compra20", _TipoCambio.Compra20)
        command.Parameters.AddWithValue("Compra21", _TipoCambio.Compra21)
        command.Parameters.AddWithValue("Compra22", _TipoCambio.Compra22)
        command.Parameters.AddWithValue("Compra23", _TipoCambio.Compra23)
        command.Parameters.AddWithValue("Compra24", _TipoCambio.Compra24)
        command.Parameters.AddWithValue("Compra25", _TipoCambio.Compra25)
        command.Parameters.AddWithValue("Compra26", _TipoCambio.Compra26)
        command.Parameters.AddWithValue("Compra27", _TipoCambio.Compra27)
        command.Parameters.AddWithValue("Compra28", _TipoCambio.Compra28)
        command.Parameters.AddWithValue("Compra29", _TipoCambio.Compra29)
        command.Parameters.AddWithValue("Compra30", _TipoCambio.Compra30)
        command.Parameters.AddWithValue("Compra31", _TipoCambio.Compra31)
        command.Parameters.AddWithValue("Venta1", _TipoCambio.Venta1)
        command.Parameters.AddWithValue("Venta2", _TipoCambio.Venta2)
        command.Parameters.AddWithValue("Venta3", _TipoCambio.Venta3)
        command.Parameters.AddWithValue("Venta4", _TipoCambio.Venta4)
        command.Parameters.AddWithValue("Venta5", _TipoCambio.Venta5)
        command.Parameters.AddWithValue("Venta6", _TipoCambio.Venta6)
        command.Parameters.AddWithValue("Venta7", _TipoCambio.Venta7)
        command.Parameters.AddWithValue("Venta8", _TipoCambio.Venta8)
        command.Parameters.AddWithValue("Venta9", _TipoCambio.Venta9)
        command.Parameters.AddWithValue("Venta10", _TipoCambio.Venta10)
        command.Parameters.AddWithValue("Venta11", _TipoCambio.Venta11)
        command.Parameters.AddWithValue("Venta12", _TipoCambio.Venta12)
        command.Parameters.AddWithValue("Venta13", _TipoCambio.Venta13)
        command.Parameters.AddWithValue("Venta14", _TipoCambio.Venta14)
        command.Parameters.AddWithValue("Venta15", _TipoCambio.Venta15)
        command.Parameters.AddWithValue("Venta16", _TipoCambio.Venta16)
        command.Parameters.AddWithValue("Venta17", _TipoCambio.Venta17)
        command.Parameters.AddWithValue("Venta18", _TipoCambio.Venta18)
        command.Parameters.AddWithValue("Venta19", _TipoCambio.Venta19)
        command.Parameters.AddWithValue("Venta20", _TipoCambio.Venta20)
        command.Parameters.AddWithValue("Venta21", _TipoCambio.Venta21)
        command.Parameters.AddWithValue("Venta22", _TipoCambio.Venta22)
        command.Parameters.AddWithValue("Venta23", _TipoCambio.Venta23)
        command.Parameters.AddWithValue("Venta24", _TipoCambio.Venta24)
        command.Parameters.AddWithValue("Venta25", _TipoCambio.Venta25)
        command.Parameters.AddWithValue("Venta26", _TipoCambio.Venta26)
        command.Parameters.AddWithValue("Venta27", _TipoCambio.Venta27)
        command.Parameters.AddWithValue("Venta28", _TipoCambio.Venta28)
        command.Parameters.AddWithValue("Venta29", _TipoCambio.Venta29)
        command.Parameters.AddWithValue("Venta30", _TipoCambio.Venta30)
        command.Parameters.AddWithValue("Venta31", _TipoCambio.Venta31)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If

        End Using
        Return id
    End Function

    Public Function GetTIPOCAMBIOCompraByFecha(ByVal Fecha As Date) As Decimal Implements ITipoCambioRepository.GetTIPOCAMBIOCompraByFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIOCompraByFecha")
        Dim valor As Decimal
        command.Parameters.AddWithValue("Fecha", Fecha)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                valor = reader.GetValue(0)
            Else
                valor = 0
            End If
        End Using

        Return valor
    End Function

    Public Function GetTIPOCAMBIO1ByAnioMesDia(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Dia As Integer) As Decimal Implements ITipoCambioRepository.GetTIPOCAMBIO1ByAnioMesDia
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOCAMBIO1ByAnioMesDia")
        Dim valor As Decimal
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        command.Parameters.AddWithValue("Dia", Dia)
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
