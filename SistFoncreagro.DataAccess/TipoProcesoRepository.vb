Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoProcesoRepository : Inherits MasterDataAccess : Implements ITipoProcesoRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoProceso)
        Dim lista As New List(Of TipoProceso)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoProceso As New TipoProceso() With
                {
                    .Descripcion = reader.GetValue(0),
                    .IdTipoProceso = reader.GetValue(1)
                }


                lista.Add(_TipoProceso)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromTIPOPROCESO() As System.Collections.Generic.List(Of BussinessEntities.TipoProceso) Implements ITipoProcesoRepository.GetAllFromTIPOPROCESO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOPROCESO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetTIPOPROCESOByIdTipoProceso(ByVal IdTipoProceso As Integer) As BussinessEntities.TipoProceso Implements ITipoProcesoRepository.GetTIPOPROCESOByIdTipoProceso
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetTIPOPROCESOByIdTipoProceso")
        command.Parameters.AddWithValue("IdTipoProceso", IdTipoProceso)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
