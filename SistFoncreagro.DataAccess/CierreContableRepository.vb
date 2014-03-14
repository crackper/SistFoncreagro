Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CierreContableRepository : Inherits MasterDataAccess : Implements ICierreContableRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of CierreContable)
        Dim lista As New List(Of CierreContable)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _CierreContable As New CierreContable() With
                {
                  .IdCierre = reader.GetValue(0),
                  .Descripcion = reader.GetValue(1),
                  .Cuenta1 = reader.GetValue(2),
                  .CuentaReceptora = reader.GetValue(12)
                }
                If Not (reader.IsDBNull(3)) Then
                    _CierreContable.Cuenta2 = reader.GetValue(3)
                End If
                If Not (reader.IsDBNull(4)) Then
                    _CierreContable.Cuenta3 = reader.GetValue(4)
                End If
                If Not (reader.IsDBNull(5)) Then
                    _CierreContable.Cuenta4 = reader.GetValue(5)
                End If
                If Not (reader.IsDBNull(6)) Then
                    _CierreContable.Cuenta5 = reader.GetValue(6)
                End If
                If Not (reader.IsDBNull(7)) Then
                    _CierreContable.Cuenta6 = reader.GetValue(7)
                End If
                If Not (reader.IsDBNull(8)) Then
                    _CierreContable.Cuenta7 = reader.GetValue(8)
                End If
                If Not (reader.IsDBNull(9)) Then
                    _CierreContable.Cuenta8 = reader.GetValue(9)
                End If
                If Not (reader.IsDBNull(10)) Then
                    _CierreContable.Cuenta9 = reader.GetValue(10)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _CierreContable.Cuenta10 = reader.GetValue(11)
                End If
                lista.Add(_CierreContable)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteCIERRECONTABLE(ByVal IdCierre As Integer) Implements ICierreContableRepository.DeleteCIERRECONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCIERRECONTABLE")
        command.Parameters.AddWithValue("IdCierre", IdCierre)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetAllFromCIERRECONTABLE() As System.Collections.Generic.List(Of BussinessEntities.CierreContable) Implements ICierreContableRepository.GetAllFromCIERRECONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCIERRECONTABLE")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllFromCIERRECONTABLEDetallado() As System.Collections.Generic.List(Of BussinessEntities.CierreContable) Implements ICierreContableRepository.GetAllFromCIERRECONTABLEDetallado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCIERRECONTABLEDetallado")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCIERRECONTABLEByIdCierre(ByVal IdCierre As Integer) As BussinessEntities.CierreContable Implements ICierreContableRepository.GetCIERRECONTABLEByIdCierre
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCIERRECONTABLEByIdCierre")
        command.Parameters.AddWithValue("IdCierre", IdCierre)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveCIERRECONTABLE(ByVal _CierreContable As BussinessEntities.CierreContable) As Integer Implements ICierreContableRepository.SaveCIERRECONTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCIERRECONTABLE")
        command.Parameters.AddWithValue("Cuenta1", _CierreContable.Cuenta1)
        command.Parameters.AddWithValue("Cuenta10", _CierreContable.Cuenta10)
        command.Parameters.AddWithValue("Cuenta2", _CierreContable.Cuenta2)
        command.Parameters.AddWithValue("Cuenta3", _CierreContable.Cuenta3)
        command.Parameters.AddWithValue("Cuenta4", _CierreContable.Cuenta4)
        command.Parameters.AddWithValue("Cuenta5", _CierreContable.Cuenta5)
        command.Parameters.AddWithValue("Cuenta6", _CierreContable.Cuenta6)
        command.Parameters.AddWithValue("Cuenta7", _CierreContable.Cuenta7)
        command.Parameters.AddWithValue("Cuenta8", _CierreContable.Cuenta8)
        command.Parameters.AddWithValue("Cuenta9", _CierreContable.Cuenta9)
        command.Parameters.AddWithValue("CuentaReceptora", _CierreContable.CuentaReceptora)
        command.Parameters.AddWithValue("Descripcion", _CierreContable.Descripcion)
        command.Parameters.AddWithValue("IdCierre", _CierreContable.IdCierre)

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
