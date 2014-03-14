Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class GradoSalarialRepository : Inherits MasterDataAccess : Implements IGradoSalarialRepository

    Public Sub DeleteGradoSalarial(ByVal idGradoSalarial As Integer) Implements IGradoSalarialRepository.DeleteGradoSalarial
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteGRADOSALARIAL")
        command.Parameters.AddWithValue("IdgradoSalarial", idGradoSalarial)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetAllFromGRADOSALARIAL() As System.Collections.Generic.List(Of BussinessEntities.GradoSalarial) Implements IGradoSalarialRepository.GetAllFromGRADOSALARIAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromGRADOSALARIAL")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetGradoSalarialByGrado(ByVal Grado As String) As BussinessEntities.GradoSalarial Implements IGradoSalarialRepository.GetGradoSalarialByGrado
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetGradoSalarialByGrado")
        command.Parameters.AddWithValue("grado", Grado)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetGradoSalarialByIdGradoSalarial(ByVal IdGradoSalarial As Integer) As BussinessEntities.GradoSalarial Implements IGradoSalarialRepository.GetGradoSalarialByIdGradoSalarial
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetGradoSalarialByIdGradoSalarial")
        command.Parameters.AddWithValue("IdGradoSalarial", IdGradoSalarial)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
    Public Function GetGradoSalarialSinSubsecuente() As BussinessEntities.GradoSalarial Implements IGradoSalarialRepository.GetGradoSalarialSinSubsecuente
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetGradoSalarialSinSubsecuente()")
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveGRADOSALARIAL(ByVal GradoSalarial As BussinessEntities.GradoSalarial) As Integer Implements IGradoSalarialRepository.SaveGRADOSALARIAL
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveGRADOSALARIAL")
        command.Parameters.AddWithValue("Grado", GradoSalarial.Grado)
        command.Parameters.AddWithValue("IdGradoSalarial", GradoSalarial.IdGradoSalarial)
        command.Parameters.AddWithValue("RemuneracionMaxima", GradoSalarial.RemuneracionMaxima)
        command.Parameters.AddWithValue("RemuneracionMinima", GradoSalarial.RemuneracionMinima)
        command.Parameters.AddWithValue("RemuneracionPromedio", GradoSalarial.RemuneracionPromedio)

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

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of GradoSalarial)
        Dim lista As New List(Of GradoSalarial)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New GradoSalarial
                If Not reader.IsDBNull(reader.GetOrdinal("Grado")) Then
                    entity.Grado = reader.GetValue(reader.GetOrdinal("Grado"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdGradoSalarial")) Then
                    entity.IdGradoSalarial = reader.GetValue(reader.GetOrdinal("IdGradoSalarial"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("RemuneracionMaxima")) Then
                    entity.RemuneracionMaxima = reader.GetValue(reader.GetOrdinal("RemuneracionMaxima"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("RemuneracionMinima")) Then
                    entity.RemuneracionMaxima = reader.GetValue(reader.GetOrdinal("RemuneracionMinima"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("RemuneracionPromedio")) Then
                    entity.RemuneracionMaxima = reader.GetValue(reader.GetOrdinal("RemuneracionPromedio"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("IdSecuencia")) Then
                    entity.RemuneracionMaxima = reader.GetValue(reader.GetOrdinal("IdSecuencia"))
                End If
                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function


End Class
