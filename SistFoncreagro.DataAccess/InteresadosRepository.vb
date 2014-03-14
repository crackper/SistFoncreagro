Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class InteresadosRepository : Inherits MasterDataAccess : Implements IInteresadosRepository

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Interesados)
        Dim lista As New List(Of Interesados)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Interesados As New Interesados() With
                {
                   .IdInteresado = reader.GetValue(0),
                   .FechaRegistro = reader.GetValue(1),
                   .IdUsuario = reader.GetValue(2),
                   .Apellidos = reader.GetValue(4),
                   .Nombres = reader.GetValue(5),
                   .Dni = reader.GetValue(6),
                    .IdProyecto = reader.GetValue(15),
                   .RedLideres = reader.GetValue(17)
                 }
                If Not (reader.IsDBNull(7)) Then
                    _Interesados.Direccion = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _Interesados.Telefono = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _Interesados.IdInstitucion = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _Interesados.Cargo = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _Interesados.Interes = reader.GetValue(11)
                End If
                If Not (reader.IsDBNull(12)) Then
                    _Interesados.ActividadEconomica = reader.GetValue(12)
                End If
                If Not (reader.IsDBNull(13)) Then
                    _Interesados.Relaciones = reader.GetValue(13)
                End If
                If Not (reader.IsDBNull(14)) Then
                    _Interesados.Operaciones = reader.GetValue(14)
                End If
                If Not (reader.IsDBNull(16)) Then
                    _Interesados.Comentario = reader.GetValue(16)
                End If
                If Not (reader.IsDBNull(3)) Then
                    _Interesados.IdUbigeo = reader.GetValue(3)
                End If

                lista.Add(_Interesados)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteINTERESADOS(ByVal IdInteresado As Integer) Implements IInteresadosRepository.DeleteINTERESADOS
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteINTERESADOS")
        command.Parameters.AddWithValue("IdInteresado", IdInteresado)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetINTERESADOSByIdInteresado(ByVal IdInteresado As Integer) As BussinessEntities.Interesados Implements IInteresadosRepository.GetINTERESADOSByIdInteresado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINTERESADOSByIdInteresado")
        command.Parameters.AddWithValue("IdInteresado", IdInteresado)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetINTERESADOByParametro(ByVal Parametro As String) As System.Collections.Generic.List(Of BussinessEntities.Interesados) Implements IInteresadosRepository.GetINTERESADOByParametro
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetINTERESADOByParametro")
        command.Parameters.AddWithValue("Parametro", Parametro)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveINTERESADO(ByVal _Interesados As BussinessEntities.Interesados) As Integer Implements IInteresadosRepository.SaveINTERESADO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveINTERESADO")
        command.Parameters.AddWithValue("ActividadEconomica", _Interesados.ActividadEconomica)
        command.Parameters.AddWithValue("Apellidos", _Interesados.Apellidos)
        command.Parameters.AddWithValue("Cargo", _Interesados.Cargo)
        command.Parameters.AddWithValue("Direccion", _Interesados.Direccion)
        command.Parameters.AddWithValue("Dni", _Interesados.Dni)
        command.Parameters.AddWithValue("FechaRegistro", _Interesados.FechaRegistro)
        command.Parameters.AddWithValue("IdInstitucion", _Interesados.IdInstitucion)
        command.Parameters.AddWithValue("IdInteresado", _Interesados.IdInteresado)
        command.Parameters.AddWithValue("IdProyecto", _Interesados.IdProyecto)
        command.Parameters.AddWithValue("IdUbigeo", _Interesados.IdUbigeo)
        command.Parameters.AddWithValue("IdUsuario", _Interesados.IdUsuario)
        command.Parameters.AddWithValue("Interes", _Interesados.Interes)
        command.Parameters.AddWithValue("Nombres", _Interesados.Nombres)
        command.Parameters.AddWithValue("Operaciones", _Interesados.Operaciones)
        command.Parameters.AddWithValue("Relaciones", _Interesados.Relaciones)
        command.Parameters.AddWithValue("Telefono", _Interesados.Telefono)
        command.Parameters.AddWithValue("RedLideres", _Interesados.RedLideres)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function

    Public Function VerifyInteresado(dni As String) As Integer Implements IInteresadosRepository.VerifyInteresado
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyInteresado")
        command.Parameters.AddWithValue("dni", dni)

        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function

    Public Function VerifyInteresado1(nombre As String) As Integer Implements IInteresadosRepository.VerifyInteresado1
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyInteresado1")
        command.Parameters.AddWithValue("nombre", nombre)

        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If

            End If
        End Using
        Return i
    End Function
End Class
