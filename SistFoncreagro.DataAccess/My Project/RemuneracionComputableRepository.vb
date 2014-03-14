Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class RemuneracionComputableRepository : Inherits MasterDataAccess : Implements IRemuneracionComputableRepository

    Public Sub DeleteREMUNERACIONCOMPUTABLE(ByVal IdRemComputable As Integer) Implements IRemuneracionComputableRepository.DeleteREMUNERACIONCOMPUTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteREMUNERACIONCOMPUTABLE")
        command.Parameters.AddWithValue("IdRemComputable", IdRemComputable)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetRemuneracionComputableIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.REMUNERACIONCOMPUTABLE) Implements IRemuneracionComputableRepository.GetRemuneracionComputableIdDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetRemuneracionComputableIdDetalleConcepto")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command)
    End Function

    Public Function SaveREMUNERACIONCOMPUTABLE(ByVal remuneracionComputable As BussinessEntities.REMUNERACIONCOMPUTABLE) As Integer Implements IRemuneracionComputableRepository.SaveREMUNERACIONCOMPUTABLE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveREMUNERACIONCOMPUTABLE")
        command.Parameters.AddWithValue("IdRemComputable", remuneracionComputable.IdRemComputable)
        command.Parameters.AddWithValue("IdDetalleConcepto", remuneracionComputable.IdDetalleConcepto)
        command.Parameters.AddWithValue("Naturaleza", remuneracionComputable.Naturaleza)
        command.Parameters.AddWithValue("FactorComponente", remuneracionComputable.FactorComponente)
        command.Parameters.AddWithValue("IdComponente", remuneracionComputable.IdComponente)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of REMUNERACIONCOMPUTABLE)
        Dim lista As New List(Of REMUNERACIONCOMPUTABLE)
        Dim detalleConceptoRepository As New DetalleConceptoRepository
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New REMUNERACIONCOMPUTABLE
                If Not reader.IsDBNull(reader.GetOrdinal("IdRemComputable")) Then
                    entity.IdRemComputable = reader.GetValue(reader.GetOrdinal("IdRemComputable"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Naturaleza")) Then
                    entity.Naturaleza = reader.GetValue(reader.GetOrdinal("Naturaleza"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FactorComponente")) Then
                    entity.FactorComponente = reader.GetValue(reader.GetOrdinal("FactorComponente"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdComponente")) Then
                    entity.IdComponente = reader.GetValue(reader.GetOrdinal("IdComponente"))
                End If

                If entity.Naturaleza = "Parametro" Then
                    Dim parametroLaboralRepository As New ParametroLaboralRepository
                    entity.Componente = parametroLaboralRepository.GetParametrosLaboralesByIdParametroLab(entity.IdComponente).Descripcion
                Else
                    If entity.Naturaleza = "Concepto" Then
                        entity.Componente = detalleConceptoRepository.GetDetalleConceptoByIdDetalleConcepto(entity.IdComponente).Descripcion
                    End If
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
