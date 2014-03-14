Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class ParametroLaboralRepository : Inherits MasterDataAccess : Implements IParametroLaboralRepository

    Public Sub DeletePARAMETROLABORAL(ByVal IdParametroLab As Integer) Implements IParametroLaboralRepository.DeletePARAMETROLABORAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeletePARAMETROLABORAL")
        command.Parameters.AddWithValue("IdParametroLab", IdParametroLab)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromParametrosLaborales() As System.Collections.Generic.List(Of BussinessEntities.ParametrosLaborales) Implements IParametroLaboralRepository.GetAllFromParametrosLaborales
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromParametrosLaborales")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetParametrosLaboralesByIdParametroLab(ByVal IdParametroLab As Integer) As BussinessEntities.ParametrosLaborales Implements IParametroLaboralRepository.GetParametrosLaboralesByIdParametroLab
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetParametrosLaboralesByIdParametroLab")
        command.Parameters.AddWithValue("IdParametroLab", IdParametroLab)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveParametroLaborales(ByVal parametroLaboral As BussinessEntities.ParametrosLaborales) As Integer Implements IParametroLaboralRepository.SaveParametroLaborales
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveParametroLaborales")
        command.Parameters.AddWithValue("IdParametroLab", parametroLaboral.IdParametroLab)
        command.Parameters.AddWithValue("Descripcion", parametroLaboral.Descripcion)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of ParametrosLaborales)
        Dim lista As New List(Of ParametrosLaborales)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New ParametrosLaborales
                If Not reader.IsDBNull(reader.GetOrdinal("IdParametroLab")) Then
                    entity.IdParametroLab = reader.GetValue(reader.GetOrdinal("IdParametroLab"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Descripcion")) Then
                    entity.Descripcion = reader.GetValue(reader.GetOrdinal("Descripcion"))
                End If

                lista.Add(entity)
            End While
        End Using
        Return lista
        '
    End Function


End Class
