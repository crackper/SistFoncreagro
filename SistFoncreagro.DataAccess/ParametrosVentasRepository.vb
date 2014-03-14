Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ParametrosVentasRepository : Inherits MasterDataAccess : Implements IParametrosVentasRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ParametrosVentas)
        Dim lista As New List(Of ParametrosVentas)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _ParametrosVenta As New ParametrosVentas() With
                {
                 .Estado = reader.GetValue(0),
                 .IdParametro = reader.GetValue(1),
                 .IdPlan = reader.GetValue(2),
                 .IdTipoParametro = reader.GetValue(3)
                }
              
                lista.Add(_ParametrosVenta)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromPARAMETROSVENTAS() As System.Collections.Generic.List(Of BussinessEntities.ParametrosVentas) Implements IParametrosVentasRepository.GetAllFromPARAMETROSVENTAS
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPARAMETROSVENTAS")
        Return SelectObjectFactory(command)
    End Function

    Public Sub SavePARAMETROSVENTAS(ByVal _Parametros As BussinessEntities.ParametrosVentas) Implements IParametrosVentasRepository.SavePARAMETROSVENTAS
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePARAMETROSVENTAS")
        command.Parameters.AddWithValue("IdParametro", _Parametros.IdParametro)
        command.Parameters.AddWithValue("IdPlan", _Parametros.IdPlan)
        command.Parameters.AddWithValue("IdTipoParametro", _Parametros.IdTipoParametro)
       MyBase.ExecuteReader(command)
    End Sub

    Public Sub UpdateEstadoPARAMETROSVENTAS(ByVal IdParametro As Integer) Implements IParametrosVentasRepository.UpdateEstadoPARAMETROSVENTAS
        Dim command As SqlCommand = MyBase.CreateSPCommand("UpdateEstadoPARAMETROSVENTAS")
        command.Parameters.AddWithValue("IdParametro", IdParametro)
       MyBase.ExecuteNonQuery(command)
    End Sub
End Class
