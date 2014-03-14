Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DerechoHabienteRepository : Inherits MasterDataAccess : Implements IDerechoHabienteRepository

    Public Function GetDERECHOHABIENTEConyugueByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.DerechoHabiente) Implements IDerechoHabienteRepository.GetDERECHOHABIENTEConyugueByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDERECHOHABIENTEConyugueByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDERECHOHABIENTEHijoByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.DerechoHabiente) Implements IDerechoHabienteRepository.GetDERECHOHABIENTEHijoByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDERECHOHABIENTEHijoByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDERECHOHABIENTEOtrosVinculosByIdPersonal(ByVal IdPersonal As Integer) As System.Collections.Generic.List(Of BussinessEntities.DerechoHabiente) Implements IDerechoHabienteRepository.GetDERECHOHABIENTEOtrosVinculosByIdPersonal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDERECHOHABIENTEOtrosVinculosByIdPersonal")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        Return SelectObjectFactory(command)
    End Function

    Public Sub DeleteDerechoHabiente(ByVal IdPersonal As Integer, ByVal IdDerechoHabiente As Integer) Implements IDerechoHabienteRepository.DeleteDerechoHabiente
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDerechoHabiente")
        command.Parameters.AddWithValue("IdPersonal", IdPersonal)
        command.Parameters.AddWithValue("IdDerechoHabiente", IdDerechoHabiente)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function SaveDERECHOHABIENTE(ByVal derechoHabiente As BussinessEntities.DerechoHabiente) As Integer Implements IDerechoHabienteRepository.SaveDERECHOHABIENTE
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDERECHOHABIENTE")
        command.Parameters.AddWithValue("Discapacidad", derechoHabiente.Discapacidad)
        command.Parameters.AddWithValue("Estado", derechoHabiente.Estado)
        command.Parameters.AddWithValue("EstadoCivil", derechoHabiente.EstadoCivil)
        command.Parameters.AddWithValue("Estudiando", derechoHabiente.Estudiando)
        command.Parameters.AddWithValue("FechaNacimiento", derechoHabiente.FechaNacimiento)
        command.Parameters.AddWithValue("IdDerechoHabiente", derechoHabiente.IdDerechoHabiente)
        command.Parameters.AddWithValue("IdPersonal", derechoHabiente.IdPersonal)
        command.Parameters.AddWithValue("IdVinculo", derechoHabiente.IdVinculo)
        command.Parameters.AddWithValue("IdNacionalidad", derechoHabiente.IdNacionalidad)
        command.Parameters.AddWithValue("IdTipoDI", derechoHabiente.IdTipoDI)
        command.Parameters.AddWithValue("NroDI", derechoHabiente.NroDI)
        command.Parameters.AddWithValue("FechaConvivencia", derechoHabiente.FechaConvivencia)
        command.Parameters.AddWithValue("Nombre", derechoHabiente.Nombre)
        command.Parameters.AddWithValue("ApePaterno", derechoHabiente.ApePaterno)
        command.Parameters.AddWithValue("ApeMaterno", derechoHabiente.ApeMaterno)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DerechoHabiente)
        Dim lista As New List(Of DerechoHabiente)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New DerechoHabiente
                entity.VinculoEntity = New VinculoFamiliar
                entity.NacionalidadEntity = New Nacionalidad
                entity.TipoDIEntity = New TipoDocumentoIdentidad

                If Not reader.IsDBNull(reader.GetOrdinal("Nombre")) Then
                    entity.Nombre = reader.GetValue(reader.GetOrdinal("Nombre"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("ApePaterno")) Then
                    entity.ApePaterno = reader.GetValue(reader.GetOrdinal("ApePaterno"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("ApeMaterno")) Then
                    entity.ApeMaterno = reader.GetValue(reader.GetOrdinal("ApeMaterno"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Discapacidad")) Then
                    entity.Discapacidad = reader.GetValue(reader.GetOrdinal("Discapacidad"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Estado")) Then
                    entity.Estado = reader.GetValue(reader.GetOrdinal("Estado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("EstadoCivil")) Then
                    entity.EstadoCivil = reader.GetValue(reader.GetOrdinal("EstadoCivil"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Estudiando")) Then
                    entity.Estudiando = reader.GetValue(reader.GetOrdinal("Estudiando"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("FechaNacimiento")) Then
                    entity.FechaNacimiento = reader.GetValue(reader.GetOrdinal("FechaNacimiento"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdDerechoHabiente")) Then
                    entity.IdDerechoHabiente = reader.GetValue(reader.GetOrdinal("IdDerechoHabiente"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdPersonal")) Then
                    entity.IdPersonal = reader.GetValue(reader.GetOrdinal("IdPersonal"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdVinculo")) Then
                    entity.IdVinculo = reader.GetValue(reader.GetOrdinal("IdVinculo"))
                    entity.VinculoEntity.IdVinculo = entity.IdVinculo
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.VinculoEntity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdNacionalidad")) Then
                    entity.IdNacionalidad = reader.GetValue(reader.GetOrdinal("IdNacionalidad"))
                    entity.NacionalidadEntity.IdNacionalidad = entity.IdNacionalidad
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("DescNacionalidad")) Then
                    entity.NacionalidadEntity.Nacionalidad = reader.GetValue(reader.GetOrdinal("DescNacionalidad"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("IdTipoDI")) Then
                    entity.IdTipoDI = reader.GetValue(reader.GetOrdinal("IdTipoDI"))
                    entity.TipoDIEntity.IdTipoDI = entity.IdTipoDI
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("NroDI")) Then
                    entity.NroDI = reader.GetValue(reader.GetOrdinal("NroDI"))
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("DescDI")) Then
                    entity.TipoDIEntity.Descripcion = reader.GetValue(reader.GetOrdinal("DescDI"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
