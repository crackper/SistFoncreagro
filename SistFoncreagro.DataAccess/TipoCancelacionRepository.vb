Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class TipoCancelacionRepository : Inherits MasterDataAccess : Implements ITipoCancelacionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of TipoCancelacion)
        Dim lista As New List(Of TipoCancelacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _TipoCancelacion As New TipoCancelacion() With
                {
                   .Descripcion = reader.GetValue(0),
                   .IdTipoCancelacion = reader.GetValue(1)
                }
                lista.Add(_TipoCancelacion)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromTIPOCANCELACION() As System.Collections.Generic.List(Of BussinessEntities.TipoCancelacion) Implements ITipoCancelacionRepository.GetAllFromTIPOCANCELACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromTIPOCANCELACION")
        Return SelectObjectFactory(command)
    End Function
End Class
