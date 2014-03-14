Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data

Public Class DatosActualRepository : Inherits MasterDataAccess : Implements IDatosActualRepository

    Public Function GetAnioActual() As Integer Implements IDatosActualRepository.GetAnioActual
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAnioActual")
        Dim _Anio As Int32
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                _Anio = reader.GetValue(0)
            End If
        End Using
        Return _Anio
    End Function

    Public Function GetMesActual(ByVal _Mes As Integer) As String Implements IDatosActualRepository.GetMesActual
        Dim command As SqlCommand = MyBase.CreateSPCommand("AVANCEFISICOByMes")
        Dim _Error As String

        command.Parameters.AddWithValue("Mes", _Mes)

        _Error = ""
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                _Error = reader.GetValue(0)
            End If
        End Using
        Return _Error
    End Function
End Class
