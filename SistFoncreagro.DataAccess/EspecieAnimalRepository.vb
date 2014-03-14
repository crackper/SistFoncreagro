Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EspecieAnimalRepository : Inherits MasterDataAccess : Implements IEspecieAnimalRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of EspecieAnimal)
        Dim lista As New List(Of EspecieAnimal)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Especie As New EspecieAnimal() With
                {
                    .idespecieanimal = reader.GetValue(0),
                    .especie = reader.GetValue(1)
                }


                lista.Add(_Especie)
            End While
        End Using
        Return lista
    End Function

    Public Function GetAllFromEspecieAnimal() As System.Collections.Generic.List(Of BussinessEntities.EspecieAnimal) Implements IEspecieAnimalRepository.GetAllFromEspecieAnimal
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromEspecieAnimal")
        Return SelectObjectFactory(command)
    End Function

    Public Function GetEspecieAnimalByIdRaza(ByVal idRaza As Integer) As BussinessEntities.EspecieAnimal Implements IEspecieAnimalRepository.GetEspecieAnimalByIdRaza
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEspecieAnimalByIdRaza")
        command.Parameters.AddWithValue("idRaza", idRaza)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function
End Class
