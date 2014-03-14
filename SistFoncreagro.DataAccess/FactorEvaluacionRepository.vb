Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class FactorEvaluacionRepository : Inherits MasterDataAccess : Implements IFactorEvaluacionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of FactorEvaluacion)
        Dim lista As New List(Of FactorEvaluacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Factor As New FactorEvaluacion() With
                {
                    .IdFactor = reader.GetValue(0),
                    .Nombre = reader.GetValue(1)
                  }

                lista.Add(_Factor)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteFACTOREVALUACION(ByVal IdFactor As Integer) Implements IFactorEvaluacionRepository.DeleteFACTOREVALUACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteFACTOREVALUACION")
        command.Parameters.AddWithValue("IdFactor", IdFactor)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromFACTOREVALUACION() As System.Collections.Generic.List(Of BussinessEntities.FactorEvaluacion) Implements IFactorEvaluacionRepository.GetAllFromFACTOREVALUACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromFACTOREVALUACION")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFACTOREVALUACIONByIdFactor(ByVal IdFactor As Integer) As BussinessEntities.FactorEvaluacion Implements IFactorEvaluacionRepository.GetFACTOREVALUACIONByIdFactor
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFACTOREVALUACIONByIdFactor")
        command.Parameters.AddWithValue("IdFactor", IdFactor)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveFACTOR(ByVal _Factor As BussinessEntities.FactorEvaluacion) Implements IFactorEvaluacionRepository.SaveFACTOR
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveFACTOR")
        command.Parameters.AddWithValue("IdFactor", _Factor.IdFactor)
        command.Parameters.AddWithValue("Nombre", _Factor.Nombre)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
