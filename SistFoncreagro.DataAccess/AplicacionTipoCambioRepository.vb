Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AplicacionTipoCambioRepository : Inherits MasterDataAccess : Implements IAplicacionTipoCambioRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AplicacionTipoCambio)
        Dim lista As New List(Of AplicacionTipoCambio)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _AplicacionTipoCambio As New AplicacionTipoCambio() With
                {
                   .Descripcion = reader.GetValue(0),
                   .IdAplTipoCambio = reader.GetValue(1)
                }
                lista.Add(_AplicacionTipoCambio)
            End While
        End Using
        Return lista
    End Function
    Public Function GetAllFromAPLICACIONTIPOCAMBIO() As System.Collections.Generic.List(Of BussinessEntities.AplicacionTipoCambio) Implements IAplicacionTipoCambioRepository.GetAllFromAPLICACIONTIPOCAMBIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromAPLICACIONTIPOCAMBIO")
        Return SelectObjectFactory(command)
    End Function
End Class
