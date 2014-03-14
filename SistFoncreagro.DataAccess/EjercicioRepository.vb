Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class EjercicioRepository : Inherits MasterDataAccess : Implements IEjercicioRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Ejercicio)
        Dim lista As New List(Of Ejercicio)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Ejercicio As New Ejercicio() With
                {
                    .Abril = reader.GetValue(0),
                    .Agosto = reader.GetValue(1),
                    .Anio = reader.GetValue(2),
                    .Apertura = reader.GetValue(3),
                    .Cierre = reader.GetValue(4),
                    .Diciembre = reader.GetValue(5),
                    .Enero = reader.GetValue(6),
                    .Febrero = reader.GetValue(7),
                    .IdEjercicio = reader.GetValue(8),
                    .Julio = reader.GetValue(9),
                    .Junio = reader.GetValue(10),
                    .Marzo = reader.GetValue(11),
                    .Mayo = reader.GetValue(12),
                    .Noviembre = reader.GetValue(13),
                    .Octubre = reader.GetValue(14),
                    .Setiembre = reader.GetValue(15)
                  }

                lista.Add(_Ejercicio)
            End While
        End Using
        Return lista
    End Function

    Public Function GetEJERCICIOByAnio(ByVal Anio As Integer) As BussinessEntities.Ejercicio Implements IEjercicioRepository.GetEJERCICIOByAnio
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEJERCICIOByAnio")
        command.Parameters.AddWithValue("Anio", Anio)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Function GetEstadoMes(ByVal Anio As Integer, ByVal Mes As Integer) As String Implements IEjercicioRepository.GetEstadoMes
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetEstadoMes")
        Dim estado As String = "C"
        command.Parameters.AddWithValue("Anio", Anio)
        command.Parameters.AddWithValue("Mes", Mes)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                estado = reader.GetValue(0)
            End If

        End Using
        Return estado
    End Function

    Public Function SaveEJERCICIO(ByVal _Ejercicio As BussinessEntities.Ejercicio) As Integer Implements IEjercicioRepository.SaveEJERCICIO
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveEJERCICIO")
        Dim Id As Int32 = 0
        command.Parameters.AddWithValue("Abril", _Ejercicio.Abril)
        command.Parameters.AddWithValue("Agosto", _Ejercicio.Agosto)
        command.Parameters.AddWithValue("Anio", _Ejercicio.Anio)
        command.Parameters.AddWithValue("Apertura", _Ejercicio.Apertura)
        command.Parameters.AddWithValue("Cierre", _Ejercicio.Cierre)
        command.Parameters.AddWithValue("Diciembre", _Ejercicio.Diciembre)
        command.Parameters.AddWithValue("Enero", _Ejercicio.Enero)
        command.Parameters.AddWithValue("Febrero", _Ejercicio.Febrero)
        command.Parameters.AddWithValue("IdEjercicio", _Ejercicio.IdEjercicio)
        command.Parameters.AddWithValue("Julio", _Ejercicio.Julio)
        command.Parameters.AddWithValue("Junio", _Ejercicio.Junio)
        command.Parameters.AddWithValue("Marzo", _Ejercicio.Marzo)
        command.Parameters.AddWithValue("Mayo", _Ejercicio.Mayo)
        command.Parameters.AddWithValue("Noviembre", _Ejercicio.Noviembre)
        command.Parameters.AddWithValue("Octubre", _Ejercicio.Octubre)
        command.Parameters.AddWithValue("Setiembre", _Ejercicio.Setiembre)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                Id = reader.GetValue(0)
            End If

        End Using
        Return Id
    End Function

    Public Function VerifyExisteEJERCICIO(ByVal Anio As Integer) As Integer Implements IEjercicioRepository.VerifyExisteEJERCICIO
        Dim id As Int32
        Dim command As SqlCommand = MyBase.CreateSPCommand("VerifyExisteEJERCICIO")
        command.Parameters.AddWithValue("Anio", Anio)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            If reader.Read Then
                id = reader.GetValue(0)
            End If

        End Using
        Return id
    End Function
End Class
