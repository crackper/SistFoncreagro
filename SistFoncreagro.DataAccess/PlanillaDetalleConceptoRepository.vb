Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PlanillaDetalleConceptoRepository : Inherits MasterDataAccess : Implements IPlanillaDetalleConceptoRepository

    Public Sub DeletePlanillaDetalleConcepto(ByVal IdPlanillaDetalleConcepto As Integer) Implements IPlanillaDetalleConceptoRepository.DeletePlanillaDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePlanillaDetalleConcepto")
        command.Parameters.AddWithValue("IdPlanillaDetalleConcepto", IdPlanillaDetalleConcepto)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto(ByVal IdTipoPlanillaTrabajador As Integer, ByVal IdDetalleConcepto As Integer) As BussinessEntities.PlanillaDetalleConcepto Implements IPlanillaDetalleConceptoRepository.GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPlanillaDetalleConceptoByIdTipoPlanillaTrabajadorByIdDetalleConcepto")
        command.Parameters.AddWithValue("IdTipoPlanillaTrabajador", IdTipoPlanillaTrabajador)
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SavePlanillaDetalleConcepto(ByVal planillaDetalleConcepto As BussinessEntities.PlanillaDetalleConcepto) As Integer Implements IPlanillaDetalleConceptoRepository.SavePlanillaDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("SavePlanillaDetalleConcepto")
        command.Parameters.AddWithValue("IdPlanillaDetalleConcepto", planillaDetalleConcepto.IdPlanillaDetalleConcepto)
        command.Parameters.AddWithValue("IdTipoPlanillaTrabajador", planillaDetalleConcepto.IdTipoPlanillaTrabajador)
        command.Parameters.AddWithValue("IdDetalleConcepto", planillaDetalleConcepto.IdDetalleConcepto)
        command.Parameters.AddWithValue("Activo", planillaDetalleConcepto.Activo)
        command.Parameters.AddWithValue("Eliminar", planillaDetalleConcepto.Eliminar)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of PlanillaDetalleConcepto)
        Dim lista As New List(Of PlanillaDetalleConcepto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New PlanillaDetalleConcepto
                If Not reader.IsDBNull(reader.GetOrdinal("IdPlanillaDetalleConcepto")) Then
                    entity.IdPlanillaDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdPlanillaDetalleConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoPlanillaTrabajador")) Then
                    entity.IdTipoPlanillaTrabajador = reader.GetValue(reader.GetOrdinal("IdTipoPlanillaTrabajador"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Activo")) Then
                    entity.Activo = reader.GetValue(reader.GetOrdinal("Activo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Eliminar")) Then
                    entity.Eliminar = reader.GetValue(reader.GetOrdinal("Eliminar"))
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
