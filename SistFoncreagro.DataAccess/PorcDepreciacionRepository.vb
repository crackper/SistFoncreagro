Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PorcDepreciacionRepository : Inherits MasterDataAccess : Implements IPorcDepreciacionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PorcDepreciacion)
        Dim lista As New List(Of PorcDepreciacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _PorcDepreciacion As New PorcDepreciacion() With
                {
                    .IdPorcDepreciacion = reader.GetValue(0),
                    .Tipo = reader.GetValue(1),
                    .Valor = reader.GetValue(2)
                }

                lista.Add(_PorcDepreciacion)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeletePORCDEPRECIACION(ByVal IdPorcDepreciacion As Integer) Implements IPorcDepreciacionRepository.DeletePORCDEPRECIACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePORCDEPRECIACION")
        command.Parameters.AddWithValue("IdPorcDepreciacion", IdPorcDepreciacion)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetPORCDEPRECIACIONByIdPorcDepreciacion(ByVal IdPorcDepreciacion As Integer) As BussinessEntities.PorcDepreciacion Implements IPorcDepreciacionRepository.GetPORCDEPRECIACIONByIdPorcDepreciacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPORCDEPRECIACIONByIdPorcDepreciacion")
        command.Parameters.AddWithValue("IdPorcDepreciacion", IdPorcDepreciacion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SavePORCDEPRECIACION(ByVal _PorcDepreciacion As BussinessEntities.PorcDepreciacion) Implements IPorcDepreciacionRepository.SavePORCDEPRECIACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePORCDEPRECIACION")
        command.Parameters.AddWithValue("IdPorcDepreciacion", _PorcDepreciacion.IdPorcDepreciacion)
        command.Parameters.AddWithValue("Tipo", _PorcDepreciacion.Tipo)
        command.Parameters.AddWithValue("Valor", _PorcDepreciacion.Valor)
        MyBase.ExecuteReader(command)
    End Sub

    Public Function GetAllFromPorcDepreciacion() As System.Collections.Generic.List(Of BussinessEntities.PorcDepreciacion) Implements IPorcDepreciacionRepository.GetAllFromPorcDepreciacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPorcDepreciacion")
        Return SelectObjectFactory(command)
    End Function
End Class
