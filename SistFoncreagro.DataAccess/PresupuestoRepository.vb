Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class PresupuestoRepository : Inherits MasterDataAccess : Implements IPresupuestoRepository

    Public Sub eliminarpresupuesto(ByVal id As Integer) Implements IPresupuestoRepository.eliminarpresupuesto

    End Sub

    Public Function GetAllFromPresupuesto() As System.Collections.Generic.List(Of BussinessEntities.Presupuesto) Implements IPresupuestoRepository.GetAllFromPresupuesto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetAllFromPRESUPUESTO")
        Return SelectObjectFactory(Command)
    End Function

    Public Function GetPRESUPUESTOByIdPresupuesto(ByVal id As System.IndexOutOfRangeException) As BussinessEntities.Presupuesto Implements IPresupuestoRepository.GetPRESUPUESTOByIdPresupuesto
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetPRESUPUESTOByIdPresupuesto")
        command.Parameters.AddWithValue("idPresupuesto", id)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub RegistrarPresupuesto(ByVal presupesto As BussinessEntities.Presupuesto) Implements IPresupuestoRepository.RegistrarPresupuesto

    End Sub

    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Presupuesto)
        Dim lista As New List(Of Presupuesto)
        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim Presupuesto As New Presupuesto() With
                {
                    .AnioEjecutado = reader.GetString(0),
                    .AnioProgramado = reader.GetString(1),
                    .IdElemGasto = reader.GetString(2),
                    .IdPresupuesto = reader.GetString(3),
                    .IdProyecto = reader.GetString(4),
                    .MesComprometido = reader.GetString(5),
                    .MesEjecutado = reader.GetString(6),
                    .MesProgramado = reader.GetString(7),
                    .MontoComprometido = reader.GetString(8),
                    .MontoEjecutado = reader.GetString(9),
                    .MontoProgramado = reader.GetString(10)
                }
                lista.Add(Presupuesto)
            End While
        End Using
        Return lista
    End Function
End Class
