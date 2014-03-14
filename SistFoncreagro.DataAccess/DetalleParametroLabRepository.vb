Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DetalleParametroLabRepository : Inherits MasterDataAccess : Implements IDetalleParametroLabRepository

    Public Sub DeleteDetalleParametroLab(ByVal IdDetalleParametroLab As Integer) Implements IDetalleParametroLabRepository.DeleteDetalleParametroLab
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDetalleParametroLab")
        command.Parameters.AddWithValue("IdDetalleParametroLab", IdDetalleParametroLab)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDetalleParametrosLabByIdDetalleParametroLab(ByVal IdDetalleParametroLab As Integer) As BussinessEntities.DetalleParametroLab Implements IDetalleParametroLabRepository.GetDetalleParametrosLabByIdDetalleParametroLab
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleParametrosLabByIdDetalleParametroLab")
        command.Parameters.AddWithValue("IdDetalleParametroLab", IdDetalleParametroLab)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetDetalleParametrosLabByIdParametroLab(ByVal IdParametroLab As Integer) As System.Collections.Generic.List(Of BussinessEntities.DetalleParametroLab) Implements IDetalleParametroLabRepository.GetDetalleParametrosLabByIdParametroLab
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleParametrosLabByIdParametroLab")
        command.Parameters.AddWithValue("IdParametroLab", IdParametroLab)
        Return SelectObjectFactory(command)
    End Function

    Public Function GetDetalleParametrosLabVigenteByIdParametroLab(ByVal IdParametroLab As Integer) As BussinessEntities.DetalleParametroLab Implements IDetalleParametroLabRepository.GetDetalleParametrosLabVigenteByIdParametroLab
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDetalleParametrosLabByIdParametroLab")
        command.Parameters.AddWithValue("IdParametroLab", IdParametroLab)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveDetalleParametroLab(ByVal DetalleParametroLab As BussinessEntities.DetalleParametroLab) As Integer Implements IDetalleParametroLabRepository.SaveDetalleParametroLab
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDetalleParametroLab")
        command.Parameters.AddWithValue("IdDetalleParametroLab", DetalleParametroLab.IdDetalleParametroLab)
        command.Parameters.AddWithValue("IdParametroLab", DetalleParametroLab.IdParametroLab)
        command.Parameters.AddWithValue("VigenciaDesde", DetalleParametroLab.VigenciaDesde)
        command.Parameters.AddWithValue("Valor", DetalleParametroLab.Valor)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of DetalleParametroLab)
        Dim lista As New List(Of DetalleParametroLab)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New DetalleParametroLab
                If Not reader.IsDBNull(reader.GetOrdinal("IdDetalleParametroLab")) Then
                    entity.IdDetalleParametroLab = reader.GetValue(reader.GetOrdinal("IdDetalleParametroLab"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdParametroLab")) Then
                    entity.IdParametroLab = reader.GetValue(reader.GetOrdinal("IdParametroLab"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("VigenciaDesde")) Then
                    entity.VigenciaDesde = reader.GetValue(reader.GetOrdinal("VigenciaDesde"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Valor")) Then
                    entity.Valor = reader.GetValue(reader.GetOrdinal("Valor"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
