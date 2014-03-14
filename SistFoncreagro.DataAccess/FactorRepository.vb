Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class FactorRepository : Inherits MasterDataAccess : Implements IFactorRepository

    Public Function GetFactorByIdDetalleConcepto(ByVal IdDetalleConcepto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Factor) Implements IFactorRepository.GetFactorByIdDetalleConcepto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFactorByIdDetalleConcepto")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetFactorVigente(ByVal IdDetalleConcepto As Integer) As BussinessEntities.Factor Implements IFactorRepository.GetFactorVigente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFactorVigente")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetFactorByMaxFecha(ByVal IdDetalleConcepto As Integer) As BussinessEntities.Factor Implements IFactorRepository.GetFactorByMaxFecha
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetFactorByMaxFecha")
        command.Parameters.AddWithValue("IdDetalleConcepto", IdDetalleConcepto)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub DeleteFactor(ByVal IdFactor As Integer) Implements IFactorRepository.DeleteFactor
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteFactor")
        command.Parameters.AddWithValue("IdFactor", IdFactor)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveFACTOR(ByVal factor As BussinessEntities.Factor) As Integer Implements IFactorRepository.SaveFACTOR
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveFACTOR")
        command.Parameters.AddWithValue("IdDetalleConcepto", factor.IdDetalleConcepto)
        command.Parameters.AddWithValue("IdFactor", factor.IdFactor)
        command.Parameters.AddWithValue("InicioVigencia", factor.InicioVigencia)
        command.Parameters.AddWithValue("NaturalezaFactor", factor.NaturalezaFactor)
        command.Parameters.AddWithValue("vigente", factor.vigente)
        command.Parameters.AddWithValue("ValorFactor", factor.ValorFactor)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Factor)
        Dim lista As New List(Of Factor)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Factor
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleConcepto")) Then
                    entity.IdDetalleConcepto = reader.GetValue(reader.GetOrdinal("IdDetalleConcepto"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdFactor")) Then
                    entity.IdFactor = reader.GetValue(reader.GetOrdinal("IdFactor"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("InicioVigencia")) Then
                    entity.InicioVigencia = reader.GetValue(reader.GetOrdinal("InicioVigencia"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("NaturalezaFactor")) Then
                    entity.NaturalezaFactor = reader.GetValue(reader.GetOrdinal("NaturalezaFactor"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("vigente")) Then
                    entity.vigente = reader.GetValue(reader.GetOrdinal("vigente"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("ValorFactor")) Then
                    entity.ValorFactor = reader.GetValue(reader.GetOrdinal("ValorFactor"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
