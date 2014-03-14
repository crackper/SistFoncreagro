Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class CargoRepository : Inherits MasterDataAccess : Implements ICargoRepository

    Public Function GetAllFromCargo() As System.Collections.Generic.List(Of BussinessEntities.Cargo) Implements ICargoRepository.GetAllFromCargo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromCARGO")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetCARGOByNomCargo(ByVal NomCargo As String) As BussinessEntities.Cargo Implements ICargoRepository.GetCARGOByNomCargo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCARGOByNomCargo")
        command.Parameters.AddWithValue("nomCargo", NomCargo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetCargoByIdCargo(ByVal IdCargo As Integer) As BussinessEntities.Cargo Implements ICargoRepository.GetCargoByIdCargo
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetCargoByIdCargo")
        command.Parameters.AddWithValue("idCargo", IdCargo)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function SaveCargo(ByVal cargo As BussinessEntities.Cargo) As Int32 Implements ICargoRepository.SaveCargo
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveCARGO")
        command.Parameters.AddWithValue("idCargo", cargo.IdCargo)
        command.Parameters.AddWithValue("nomCargo", cargo.NomCargo)
        command.Parameters.AddWithValue("descCargo", cargo.DescCargo)

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

    Public Sub DeleteCargo(ByVal idCargo As Integer) Implements ICargoRepository.DeleteCargo
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteCARGO")
        command.Parameters.AddWithValue("idCargo", idCargo)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Cargo)
        Dim lista As New List(Of Cargo)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim entity As New Cargo
                If Not reader.IsDBNull(reader.GetOrdinal("idCargo")) Then
                    entity.IdCargo = reader.GetValue(reader.GetOrdinal("idCargo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("nomCargo")) Then
                    entity.NomCargo = reader.GetValue(reader.GetOrdinal("nomCargo"))
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("descCargo")) Then
                    entity.DescCargo = reader.GetValue(reader.GetOrdinal("descCargo"))
                End If

                lista.Add(entity)
            End While
        End Using
        'El indice depende de la columna con la que este en el SP
        Return lista
        '
    End Function

End Class
