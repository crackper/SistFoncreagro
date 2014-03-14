Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class AfectacionConceptoRepository : Inherits MasterDataAccess : Implements IAfectacionConceptoRepository

    Public Sub DeleteAFECTACIONCONCEPTO(ByVal IdAfectacion As Integer) Implements IAfectacionConceptoRepository.DeleteAFECTACIONCONCEPTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteAFECTACIONCONCEPTO")
        command.Parameters.AddWithValue("IdAfectacion", IdAfectacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromAFECTACIONCONCEPTO() As System.Collections.Generic.List(Of BussinessEntities.AfectacionConcepto) Implements IAfectacionConceptoRepository.GetAllFromAFECTACIONCONCEPTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromAFECTACIONCONCEPTO")
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveAFECTACIONCONCEPTO(ByVal afectacionConcepto As BussinessEntities.AfectacionConcepto) As Integer Implements IAfectacionConceptoRepository.SaveAFECTACIONCONCEPTO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveAFECTACIONCONCEPTO")
        command.Parameters.AddWithValue("IdAfectacion", afectacionConcepto.IdAfectacion)
        command.Parameters.AddWithValue("IdDetalleConcepto", afectacionConcepto.IdDetalleConcepto)
        command.Parameters.AddWithValue("IdAfectoA", afectacionConcepto.IdAfectoA)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output

        'MyBase.ExecuteNonQuery(command)
        Dim i As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    i = reader.GetValue(0)
                End If
            Else
                i = 0 'command.Parameters("idCargo").Value
            End If
        End Using


        Return i
        'command.ExecuteReader(CommandBehavior.SingleRow).Item(0)
    End Function

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of AfectacionConcepto)
        Dim lista As New List(Of AfectacionConcepto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New AfectacionConcepto
                If Not reader.IsDBNull(reader.GetOrdinal("IdAfectacion")) Then
                    entity.IdAfectacion = reader.GetValue(reader.GetOrdinal("IdAfectacion"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdAfectoA")) Then
                    entity.IdAfectoA = reader.GetValue(reader.GetOrdinal("IdAfectoA"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function
End Class
