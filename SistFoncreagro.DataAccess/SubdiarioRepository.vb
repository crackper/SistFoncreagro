Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class SubdiarioRepository : Inherits MasterDataAccess : Implements ISubdiarioRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Subdiario)
        Dim lista As New List(Of Subdiario)
        Dim TipoProcesoRepository As New TipoProcesoRepository
        Dim OpeFinancieraRepository As New OperacionFinancieraRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Subdiario As New Subdiario() With
                {
                    .Descripcion = reader.GetValue(0),
                    .IdSubDiario = reader.GetValue(1),
                    .IdTipoProceso = reader.GetValue(2),
                    .Estado = reader.GetValue(3),
                    .IdOpFinanciera = reader.GetValue(4)
                }
                _Subdiario.TipoProceso = TipoProcesoRepository.GetTIPOPROCESOByIdTipoProceso(reader.GetValue(2))
                _Subdiario.OpeFinanciera = OpeFinancieraRepository.GetOPERACIONFINANCIERAByIdOperacion(reader.GetValue(4))
                lista.Add(_Subdiario)
            End While
        End Using
        Return lista
    End Function
    Public Sub SaveSUBDIARIO(ByVal Subdiario As BussinessEntities.Subdiario) Implements ISubdiarioRepository.SaveSUBDIARIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveSUBDIARIO")
        command.Parameters.AddWithValue("Descripcion", Subdiario.Descripcion)
        command.Parameters.AddWithValue("IdSubDiario", Subdiario.IdSubDiario)
        command.Parameters.AddWithValue("IdTipoProceso", Subdiario.IdTipoProceso)
        command.Parameters.AddWithValue("IdOpFinanciera", Subdiario.IdOpFinanciera)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Sub DeleteSUBDIARIO(ByVal IdSubdiario As Integer) Implements ISubdiarioRepository.DeleteSUBDIARIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteSUBDIARIO")
        command.Parameters.AddWithValue("IdSubdiario", IdSubdiario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetSUBDIARIOByIdSubDiario(ByVal IdSubDiario As Integer) As BussinessEntities.Subdiario Implements ISubdiarioRepository.GetSUBDIARIOByIdSubDiario
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUBDIARIOByIdSubDiario")
        command.Parameters.AddWithValue("IdSubDiario", IdSubDiario)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetSUBDIARIOInTransaccion(ByVal Anio As Integer, ByVal Mes As Integer) As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioRepository.GetSUBDIARIOInTransaccion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUBDIARIOInTransaccion")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetSUBDIARIOInTransaccionByFlag(ByVal Anio As Integer, ByVal Mes As Integer, ByVal Flag As String) As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioRepository.GetSUBDIARIOInTransaccionByFlag
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUBDIARIOInTransaccionByFlag")
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        command.Parameters.AddWithValue("Flag", Flag)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllSUBDIARIO() As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioRepository.GetAllSUBDIARIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromSUBDIARIO")
        Return SelectObjectFactory(command)
    End Function

    Public Sub UpdateEstadoSUBDIARIO(ByVal IdSubdiario As Integer) Implements ISubdiarioRepository.UpdateEstadoSUBDIARIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoSUBDIARIO")
        command.Parameters.AddWithValue("IdSubdiario", IdSubdiario)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetSUBDIARIOByIdOpFinanciera(ByVal IdOpFinanciera As Integer) As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioRepository.GetSUBDIARIOByIdOpFinanciera
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetSUBDIARIOByIdOpFinanciera")
        command.Parameters.AddWithValue("IdOpFinanciera", IdOpFinanciera)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetAllSUBDIARIOActivos() As System.Collections.Generic.List(Of BussinessEntities.Subdiario) Implements ISubdiarioRepository.GetAllSUBDIARIOActivos
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllSUBDIARIOActivos")
        Return SelectObjectFactory(command)
    End Function
End Class
