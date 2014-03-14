Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DetalleConceptoPeriodoRepository : Inherits MasterDataAccess : Implements IDetalleConceptoPeriodoRepository

    Public Function GetRemuneracionAfectaAUndetalleConcepto(ByVal Cod As String, ByVal IdAfectacion As Integer, ByVal IdPlanilla As Integer) As Decimal Implements IDetalleConceptoPeriodoRepository.GetRemuneracionAfectaAUndetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand(" GetRemuneracionAfectaAUndetalleConcepto")
        command.Parameters.AddWithValue("Cod", Cod)
        command.Parameters.AddWithValue("IdAfectacion", IdAfectacion)
        command.Parameters.AddWithValue("IdPlanilla", IdPlanilla)

        'command.Parameters("idCargo").Direction = ParameterDirection.Output

        'MyBase.ExecuteNonQuery(command)
        Dim i As Decimal
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
End Class
