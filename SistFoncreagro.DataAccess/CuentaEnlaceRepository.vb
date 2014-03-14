Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CuentaEnlaceRepository : Inherits MasterDataAccess : Implements ICuentaEnlaceRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CuentaEnlace)
        Dim lista As New List(Of CuentaEnlace)
        Dim PlanContablerepository As New PlanContableRepository
        Dim ProyectoRepository As New ProyectoRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _CuentaEnlace As New CuentaEnlace() With
                {
                    .CtaCobrar = reader.GetValue(0),
                    .CtaOperacion = reader.GetValue(1),
                    .CtaPagar = reader.GetValue(2),
                    .Destino = reader.GetValue(3),
                    .Estado = reader.GetValue(4),
                    .IdCtaEnlace = reader.GetValue(5),
                    .Origen = reader.GetValue(6),
                    .Tipo = reader.GetValue(7)
                }

                '_CuentaEnlace.PlanContable1 = PlanContablerepository.GetPLANCONTABLEByCodigo(reader.GetValue(0))
                '_CuentaEnlace.PlanContable = PlanContablerepository.GetPLANCONTABLEByCodigo(reader.GetValue(2))
                lista.Add(_CuentaEnlace)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromCUENTAENLACE() As System.Collections.Generic.List(Of BussinessEntities.CuentaEnlace) Implements ICuentaEnlaceRepository.GetAllFromCUENTAENLACE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCUENTAENLACE")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCUENTAENLACEByParameter(ByVal Texto As String, ByVal Tipo As String) As System.Collections.Generic.List(Of BussinessEntities.CuentaEnlace) Implements ICuentaEnlaceRepository.GetCUENTAENLACEByParameter
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTAENLACEByParameter")
        command.Parameters.AddWithValue("Texto", Texto)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCUENTAENLACEByCtaPagar(ByVal CtaPagar As Integer, ByVal Tipo As String) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceRepository.GetCUENTAENLACEByCtaPagar
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTAENLACEByCtaPagar")
        command.Parameters.AddWithValue("CtaPagar", CtaPagar)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetCUENTAENLACEByIdCtaEnlace(ByVal IdCtaEnlace As Integer) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceRepository.GetCUENTAENLACEByIdCtaEnlace
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTAENLACEByIdCtaEnlace")
        command.Parameters.AddWithValue("IdCtaEnlace", IdCtaEnlace)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveCUENTAENLACE(ByVal _CuentaEnlace As BussinessEntities.CuentaEnlace) As Integer Implements ICuentaEnlaceRepository.SaveCUENTAENLACE
        Dim id As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCUENTAENLACE")
        command.Parameters.AddWithValue("CtaCobrar", _CuentaEnlace.CtaCobrar)
        command.Parameters.AddWithValue("CtaOperacion", _CuentaEnlace.CtaOperacion)
        command.Parameters.AddWithValue("CtaPagar", _CuentaEnlace.CtaPagar)
        command.Parameters.AddWithValue("Destino", _CuentaEnlace.Destino)
        command.Parameters.AddWithValue("IdCtaEnlace", _CuentaEnlace.IdCtaEnlace)
        command.Parameters.AddWithValue("Origen", _CuentaEnlace.Origen)
        command.Parameters.AddWithValue("Tipo", _CuentaEnlace.Tipo)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If

        End Using
        Return id
    End Function

    Public Sub UpdateEstadoCUENTAENLACE(ByVal IdCtaEnlace As Integer) Implements ICuentaEnlaceRepository.UpdateEstadoCUENTAENLACE
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoCUENTAENLACE")
        command.Parameters.AddWithValue("IdCtaEnlace", IdCtaEnlace)
        MyBase.ExecuteReader(command)

    End Sub

    Public Function GetCtaCobrarByCtaPagarAndDestino(ByVal CtaPagar As Integer, ByVal Destino As String, ByVal Tipo As String) As Integer Implements ICuentaEnlaceRepository.GetCtaCobrarByCtaPagarAndDestino
        Dim Cta As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCtaCobrarByCtaPagarAndDestino")
        command.Parameters.AddWithValue("CtaPagar", CtaPagar)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Cta = reader.GetValue(0)
            End If

        End Using
        Return Cta
    End Function

    Public Function GetCUENTAENLACEByCtaOperacion(ByVal CtaOperacion As Integer, ByVal Destino As String, ByVal Tipo As String) As System.Collections.Generic.IList(Of BussinessEntities.CuentaEnlace) Implements ICuentaEnlaceRepository.GetCUENTAENLACEByCtaOperacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTAENLACEByCtaOperacion")
        command.Parameters.AddWithValue("CtaOperacion", CtaOperacion)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCUENTAENLACEByCtaOperacionAndCtaPagar(ByVal CtaOperacion As Integer, ByVal Destino As String, ByVal CtaPagar As Integer, ByVal Tipo As String) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceRepository.GetCUENTAENLACEByCtaOperacionAndCtaPagar
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTAENLACEByCtaOperacionAndCtaPagar")
        command.Parameters.AddWithValue("CtaOperacion", CtaOperacion)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("CtaPagar", CtaPagar)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetCtaPagarByCtaCobrarAndDestino(ByVal CtaCobrar As Integer, ByVal Destino As String, ByVal Tipo As String) As Integer Implements ICuentaEnlaceRepository.GetCtaPagarByCtaCobrarAndDestino
        Dim Cta As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCtaPagarByCtaCobrarAndDestino")
        command.Parameters.AddWithValue("CtaCobrar", CtaCobrar)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Cta = reader.GetValue(0)
            End If

        End Using
        Return Cta
    End Function

    Public Function GetCUENTAENLACEByCtaOperacionAndCtaCobrar(ByVal CtaOperacion As Integer, ByVal Destino As String, ByVal CtaCobrar As Integer, ByVal Tipo As String) As BussinessEntities.CuentaEnlace Implements ICuentaEnlaceRepository.GetCUENTAENLACEByCtaOperacionAndCtaCobrar
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCUENTAENLACEByCtaOperacionAndCtaCobrar")
        command.Parameters.AddWithValue("CtaOperacion", CtaOperacion)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("CtaCobrar", CtaCobrar)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetOrigenCtaEnlace(ByVal CtaPagar As Integer, ByVal Destino As String) As String Implements ICuentaEnlaceRepository.GetOrigenCtaEnlace
        Dim Cta As String
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOrigenCtaEnlace")
        command.Parameters.AddWithValue("CtaPagar", CtaPagar)
        command.Parameters.AddWithValue("Destino", Destino)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Cta = reader.GetValue(0)
            End If

        End Using
        Return Cta
    End Function

    Public Function GetOrigenCtaEnlace1(ByVal CtaCobrar As Integer, ByVal Destino As String) As String Implements ICuentaEnlaceRepository.GetOrigenCtaEnlace1
        Dim Cta As String
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetOrigenCtaEnlace1")
        command.Parameters.AddWithValue("CtaCobrar", CtaCobrar)
        command.Parameters.AddWithValue("Destino", Destino)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Cta = reader.GetValue(0)
            End If

        End Using
        Return Cta
    End Function

    Public Function GetCtaOperacionByCtaCobrarAndDestino(ByVal CtaCobrar As Integer, ByVal Destino As String, ByVal Tipo As String) As String Implements ICuentaEnlaceRepository.GetCtaOperacionByCtaCobrarAndDestino
        Dim Cta As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCtaOperacionByCtaCobrarAndDestino")
        command.Parameters.AddWithValue("CtaCobrar", CtaCobrar)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Cta = reader.GetValue(0)
            End If

        End Using
        Return Cta
    End Function

    Public Function GetCtaOperacionByCtaPagarAndDestino(ByVal CtaPagar As Integer, ByVal Destino As String, ByVal Tipo As String) As String Implements ICuentaEnlaceRepository.GetCtaOperacionByCtaPagarAndDestino
        Dim Cta As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCtaOperacionByCtaPagarAndDestino")
        command.Parameters.AddWithValue("CtaPagar", CtaPagar)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Cta = reader.GetValue(0)
            End If

        End Using
        Return Cta
    End Function

    Public Function VerifyExisteCUENTAENLACE(ByVal Origen As String, ByVal Destino As String, ByVal CtaOperacion As Integer, ByVal CtaPagar As Integer, ByVal CtaCobrar As Integer, ByVal Tipo As String) As Integer Implements ICuentaEnlaceRepository.VerifyExisteCUENTAENLACE
        Dim idCuenta As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyExisteCUENTAENLACE")
        command.Parameters.AddWithValue("Origen", Origen)
        command.Parameters.AddWithValue("Destino", Destino)
        command.Parameters.AddWithValue("CtaOperacion", CtaOperacion)
        command.Parameters.AddWithValue("CtaPagar", CtaPagar)
        command.Parameters.AddWithValue("CtaCobrar", CtaCobrar)
        command.Parameters.AddWithValue("Tipo", Tipo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                idCuenta = reader.GetValue(0)
            End If

        End Using
        Return idCuenta
    End Function
End Class
