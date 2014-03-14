Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoGastoRepository : Inherits MasterDataAccess : Implements ITipoGastoRrpository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoGasto)
        Dim lista As New List(Of TipoGasto)
        Dim PlanContableRepository As New PlanContableRepository

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoGasto As New TipoGasto() With
                {
                 .Descripcion = reader.GetValue(0),
                 .IdTipoGasto = reader.GetValue(2)
                }
                If Not (reader.IsDBNull(1)) Then
                    _TipoGasto.IdPlan = reader.GetValue(1)
                    _TipoGasto.PlanContable = PlanContableRepository.GetCodigoFromPLANCONTABLE(reader.GetValue(1))
                End If
                lista.Add(_TipoGasto)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromTIPOGASTO() As System.Collections.Generic.List(Of BussinessEntities.TipoGasto) Implements ITipoGastoRrpository.GetAllFromTIPOGASTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOGASTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOGASTOByIdTipoGasto(ByVal IdTipoGasto As Integer) As BussinessEntities.TipoGasto Implements ITipoGastoRrpository.GetTIPOGASTOByIdTipoGasto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOGASTOByIdTipoGasto")
        command.Parameters.AddWithValue("IdTipoGasto", IdTipoGasto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveTIPOGASTO(ByVal _TipoGasto As BussinessEntities.TipoGasto) Implements ITipoGastoRrpository.SaveTIPOGASTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveTIPOGASTO")
        command.Parameters.AddWithValue("Descripcion", _TipoGasto.Descripcion)
        command.Parameters.AddWithValue("IdPlan", _TipoGasto.IdPlan)
        command.Parameters.AddWithValue("IdTipoGasto", _TipoGasto.IdTipoGasto)
        MyBase.ExecuteReader(command)
    End Sub
End Class
