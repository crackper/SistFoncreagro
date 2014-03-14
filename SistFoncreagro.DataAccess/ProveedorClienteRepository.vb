Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data

Public Class ProveedorClienteRepository : Inherits MasterDataAccess : Implements IProveedorClienteRepository
    Public Function GetProveedoresClienteInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer, ByVal IdSubDiario As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteRepository.GetProveedoresClienteInTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPROVEEDORCLIENTEInTransaccion")
        command.Parameters.AddWithValue("anio", Anio)
        command.Parameters.AddWithValue("mes", Mes)
        command.Parameters.AddWithValue("idSubDiario", IdSubDiario)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromProveedorCliente() As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteRepository.GetAllFromProveedorCliente
        Dim command As SqlCommand =
            MyBase.CreateSPCommand("GetAllFromPROVEEDORCLIENTE")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromProveedorClienteById(ByVal idProveedorCliente As Integer) As BussinessEntities.ProveedorCliente Implements IProveedorClienteRepository.GetAllFromProveedorClienteById
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPROVEEDORCLIENTEById")
        command.Parameters.AddWithValue("IdProveedorCliente", idProveedorCliente)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetAllFromProveedorClienteByTipo(ByVal tipoProveedorCliente As Integer) As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteRepository.GetAllFromProveedorClienteByTipo
        Dim command As SqlCommand =
           MyBase.CreateSPCommand("GetAllFromPROVEEDORCLIENTEByTipo")
        command.Parameters.AddWithValue("TipoPoveedorCliente", tipoProveedorCliente)

        Return SelectObjectFactory(command)
    End Function
    Public Function SaveProveedorCliente(ByVal proveedorCliente As BussinessEntities.ProveedorCliente) As Boolean Implements IProveedorClienteRepository.SaveProveedorCliente
        Dim respuesta As Boolean
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePROVEEDORCLIENTE")
        Dim parametroBase As DbParameter = command.CreateParameter()
        parametroBase.ParameterName = "Respuesta"
        parametroBase.Direction = ParameterDirection.InputOutput
        parametroBase.Value = respuesta
        command.Parameters.Add(parametroBase)
        command.Parameters.AddWithValue("IdProveedorCliente", proveedorCliente.IdProveedorCliente)
        command.Parameters.AddWithValue("Tipo", proveedorCliente.Tipo)
        command.Parameters.AddWithValue("Ruc", proveedorCliente.Ruc)
        command.Parameters.AddWithValue("RazonSocial", proveedorCliente.RazonSocial)
        command.Parameters.AddWithValue("Direccion", proveedorCliente.Direccion)
        command.Parameters.AddWithValue("Rubro", proveedorCliente.Rubro)
        command.Parameters.AddWithValue("Ciudad", proveedorCliente.Ciudad)
        command.Parameters.AddWithValue("Web", proveedorCliente.Web)
        command.Parameters.AddWithValue("Mail", proveedorCliente.Mail)
        command.Parameters.AddWithValue("Contacto", proveedorCliente.Contacto)
        command.Parameters.AddWithValue("Telefono1", proveedorCliente.Telefono1)
        command.Parameters.AddWithValue("Telefono2", proveedorCliente.Telefono2)
        command.Parameters.AddWithValue("Celular1", proveedorCliente.Celular1)
        command.Parameters.AddWithValue("Celular2", proveedorCliente.Celular2)
        command.Parameters.AddWithValue("IdTipoDI", proveedorCliente.IdTipoDocumento)
        command.Parameters.AddWithValue("IdPersonal", proveedorCliente.Idusuario)
        command.Parameters.AddWithValue("TipoCuenta", proveedorCliente.TipoCuenta)
        command.Parameters.AddWithValue("CuentaAbono", proveedorCliente.CuentaAbono)
        command.Parameters.AddWithValue("IdTipoMoneda", proveedorCliente.IdMoneda)
        command.Parameters.AddWithValue("TipoPersona", proveedorCliente.TipoPersona)
        command.Parameters.AddWithValue("ApellidoPaterno", proveedorCliente.ApellidoPaterno)
        command.Parameters.AddWithValue("ApellidoMaterno", proveedorCliente.ApellidoMaterno)
        command.Parameters.AddWithValue("PrimerNombre", proveedorCliente.PrimerNombre)
        command.Parameters.AddWithValue("SegundoNombre", proveedorCliente.SegundoNombre)
        command.Parameters.AddWithValue("NombreComercial", proveedorCliente.NombreComercial)
        command.Parameters.AddWithValue("InternoExterno", proveedorCliente.InternoExterno)
        MyBase.ExecuteNonQuery(command)
        respuesta = parametroBase.Value
        Return respuesta
    End Function

    Public Function GetAllFromProveedorClienteByParametro(ByVal parametro As String) As System.Collections.Generic.List(Of BussinessEntities.ProveedorCliente) Implements IProveedorClienteRepository.GetAllFromProveedorClienteByParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromProveedorClienteByParametro")
        command.Parameters.AddWithValue("Parametro", parametro)
        Return SelectObjectFactory(command)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ProveedorCliente)
        Dim lista As New List(Of ProveedorCliente)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim proveedorCliente As New ProveedorCliente() With
                {
                   .IdProveedorCliente = reader.GetInt32(0),
                   .Ruc = reader.GetString(1),
                   .RazonSocial = reader.GetString(2)
                 }
                If Not reader.IsDBNull(3) Then
                    proveedorCliente.Direccion = reader.GetString(3)
                End If
                If Not reader.IsDBNull(4) Then
                    proveedorCliente.Rubro = reader.GetString(4)
                End If
                If Not reader.IsDBNull(5) Then
                    proveedorCliente.Ciudad = reader.GetString(5)
                End If
                If Not reader.IsDBNull(6) Then
                    proveedorCliente.Web = reader.GetString(6)
                End If
                If Not reader.IsDBNull(7) Then
                    proveedorCliente.Mail = reader.GetString(7)
                End If
                If Not reader.IsDBNull(8) Then
                    proveedorCliente.Contacto = reader.GetString(8)
                End If
                If Not reader.IsDBNull(9) Then
                    proveedorCliente.Telefono1 = reader.GetString(9)
                End If
                If Not reader.IsDBNull(10) Then
                    proveedorCliente.Telefono2 = reader.GetString(10)
                End If
                If Not reader.IsDBNull(11) Then
                    proveedorCliente.Celular1 = reader.GetString(11)
                End If
                If Not reader.IsDBNull(12) Then
                    proveedorCliente.Celular2 = reader.GetString(12)
                End If
                If Not reader.IsDBNull(13) Then
                    proveedorCliente.Tipo = reader.GetInt32(13)
                End If
                proveedorCliente.IdTipoDocumento = reader.GetInt32(14)
                proveedorCliente.TipoCuenta = reader.GetString(15)
                proveedorCliente.CuentaAbono = reader.GetString(16)
                proveedorCliente.IdMoneda = reader.GetInt32(17)
                If Not reader.IsDBNull(18) Then
                    proveedorCliente.TipoPersona = reader.GetString(18)
                End If
                If Not reader.IsDBNull(19) Then
                    proveedorCliente.ApellidoPaterno = reader.GetString(19)
                End If
                If Not reader.IsDBNull(20) Then
                    proveedorCliente.ApellidoMaterno = reader.GetString(20)
                End If
                If Not reader.IsDBNull(21) Then
                    proveedorCliente.PrimerNombre = reader.GetString(21)
                End If
                If Not reader.IsDBNull(22) Then
                    proveedorCliente.SegundoNombre = reader.GetString(22)
                End If
                If Not reader.IsDBNull(23) Then
                    proveedorCliente.NombreComercial = reader.GetString(23)
                End If
                If Not reader.IsDBNull(24) Then
                    proveedorCliente.InternoExterno = reader.GetBoolean(24)
                End If
                lista.Add(proveedorCliente)
            End While
        End Using
        Return lista
    End Function

    Private Function SelectObjectFactoryUno(ByVal command As SqlCommand) As List(Of ProveedorCliente)
        Dim lista As New List(Of ProveedorCliente)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read

                Dim proveedorCliente As New ProveedorCliente() With
                {
                   .IdProveedorCliente = reader.GetInt32(0),
                   .Ruc = reader.GetString(1),
                   .RazonSocial = reader.GetString(2)
                 }
                If Not reader.IsDBNull(3) Then
                    proveedorCliente.Direccion = reader.GetString(3)
                End If
                If Not reader.IsDBNull(4) Then
                    proveedorCliente.Rubro = reader.GetString(4)
                End If
                If Not reader.IsDBNull(5) Then
                    proveedorCliente.Ciudad = reader.GetString(5)
                End If
                If Not reader.IsDBNull(6) Then
                    proveedorCliente.Web = reader.GetString(6)
                End If
                If Not reader.IsDBNull(7) Then
                    proveedorCliente.Mail = reader.GetString(7)
                End If
                If Not reader.IsDBNull(8) Then
                    proveedorCliente.Contacto = reader.GetString(8)
                End If
                If Not reader.IsDBNull(9) Then
                    proveedorCliente.Telefono1 = reader.GetString(9)
                End If
                If Not reader.IsDBNull(10) Then
                    proveedorCliente.Telefono2 = reader.GetString(10)
                End If
                If Not reader.IsDBNull(11) Then
                    proveedorCliente.Celular1 = reader.GetString(11)
                End If
                If Not reader.IsDBNull(12) Then
                    proveedorCliente.Celular2 = reader.GetString(12)
                End If
                If Not reader.IsDBNull(13) Then
                    proveedorCliente.Tipo = reader.GetInt32(13)
                End If
                proveedorCliente.IdTipoDocumento = reader.GetInt32(14)
                proveedorCliente.TipoCuenta = reader.GetString(15)
                proveedorCliente.CuentaAbono = reader.GetString(16)
                proveedorCliente.IdMoneda = reader.GetInt32(17)
                If Not reader.IsDBNull(18) Then
                    proveedorCliente.TipoPersona = reader.GetString(18)
                End If
                If Not reader.IsDBNull(19) Then
                    proveedorCliente.ApellidoPaterno = reader.GetString(19)
                End If
                If Not reader.IsDBNull(20) Then
                    proveedorCliente.ApellidoMaterno = reader.GetString(20)
                End If
                If Not reader.IsDBNull(21) Then
                    proveedorCliente.PrimerNombre = reader.GetString(21)
                End If
                If Not reader.IsDBNull(22) Then
                    proveedorCliente.SegundoNombre = reader.GetString(22)
                End If
                If Not reader.IsDBNull(23) Then
                    proveedorCliente.NombreComercial = reader.GetString(23)
                End If
                If Not reader.IsDBNull(24) Then
                    proveedorCliente.InternoExterno = reader.GetBoolean(24)
                End If
                lista.Add(proveedorCliente)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteProveedorCliente(ByVal idProveedorCliente As Integer) Implements IProveedorClienteRepository.DeleteProveedorCliente
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteProveedor")
        command.Parameters.AddWithValue("IdProveedorCliente", idProveedorCliente)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
