Imports SistFoncreagro.BussinessEntities
Imports System.Data.SqlClient
Imports System.Data
Public Class DepreciacionRepository : Inherits MasterDataAccess : Implements IDepreciacionRepository
    Private Function SelectObjectFactory(ByVal command As SqlCommand) As List(Of Depreciacion)
        Dim lista As New List(Of Depreciacion)

        Using reader As SqlDataReader = MyBase.ExecuteReader(command)
            While reader.Read
                Dim _Depreciacion As New Depreciacion() With
                {
                    .IdDepreciacion = reader.GetValue(0),
                    .Ejercicio = reader.GetValue(2),
                    .Mes = reader.GetValue(3),
                    .Fecha = reader.GetValue(4),
                    .MesesDepreciados = reader.GetValue(5),
                    .DepreciacionEjercicio = reader.GetValue(6),
                    .DepreciacionAcumulada = reader.GetValue(7),
                    .SaldoPorDepreciar = reader.GetValue(8),
                    .Porcentaje = reader.GetValue(9),
                .IdUsuario = reader.GetValue(10)
                }
                If Not (reader.IsDBNull(1)) Then
                    _Depreciacion.IdBienMueble = reader.GetValue(1)
                End If
                If Not (reader.IsDBNull(11)) Then
                    _Depreciacion.IdBienInmueble = reader.GetValue(11)
                End If
                lista.Add(_Depreciacion)
            End While
        End Using
        Return lista
    End Function

    Public Sub DeleteDEPRECIACION(ByVal IdDepreciacion As Integer) Implements IDepreciacionRepository.DeleteDEPRECIACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("DeleteDEPRECIACION")
        command.Parameters.AddWithValue("IdDepreciacion", IdDepreciacion)
        MyBase.ExecuteNonQuery(command)
    End Sub

    Public Function GetDEPRECIACIONByIdDepreciacion(ByVal IdDeprecicion As Integer) As BussinessEntities.Depreciacion Implements IDepreciacionRepository.GetDEPRECIACIONByIdDepreciacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GetDEPRECIACIONByIdDepreciacion")
        command.Parameters.AddWithValue("IdDeprecicion", IdDeprecicion)
        Return SelectObjectFactory(command).SingleOrDefault
    End Function

    Public Sub SaveDEPRECIACION(ByVal _Depreciacion As BussinessEntities.Depreciacion) Implements IDepreciacionRepository.SaveDEPRECIACION
        Dim command As SqlCommand = MyBase.CreateSPCommand("SaveDEPRECIACION")
        command.Parameters.AddWithValue("IdDepreciacion", _Depreciacion.IdDepreciacion)
        command.Parameters.AddWithValue("IdBienMueble", _Depreciacion.IdBienMueble)
        command.Parameters.AddWithValue("IdBienInmueble", _Depreciacion.IdBienInmueble)
        command.Parameters.AddWithValue("IdUsuario", _Depreciacion.IdUsuario)
        command.Parameters.AddWithValue("MesesDepreciados", _Depreciacion.MesesDepreciados)
        command.Parameters.AddWithValue("Porcentaje", _Depreciacion.Porcentaje)
        command.Parameters.AddWithValue("DepreciacionAcumulada", _Depreciacion.DepreciacionAcumulada)
        MyBase.ExecuteNonQuery(command)
    End Sub
    Public Sub GenerarDepreciacion(ByVal fechaContable As Date, ByVal usuario As Integer, ByVal ejercicio As Integer, ByVal mes As Integer, ByVal idProyecto As Integer) Implements IDepreciacionRepository.GenerarDepreciacion
        Dim command As SqlCommand = MyBase.CreateSPCommand("GenerarDepreciacion")
        command.Parameters.AddWithValue("fechaContable", fechaContable)
        command.Parameters.AddWithValue("usuario", usuario)
        command.Parameters.AddWithValue("ejercicio", ejercicio)
        command.Parameters.AddWithValue("mes", mes)
        command.Parameters.AddWithValue("idProyecto", idProyecto)
        MyBase.ExecuteNonQuery(command)
    End Sub
End Class
