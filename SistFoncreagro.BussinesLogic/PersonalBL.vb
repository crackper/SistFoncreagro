Imports SistFoncreagro.BussinessEntities
Imports SistFoncreagro.DataAccess
Public Class PersonalBL : Implements IPersonalBL


    Dim factoryrepository As IPersonalRepository

    Public Sub New()
        factoryrepository = New PersonalRepository
    End Sub

    Public Sub DeletePersonal(ByVal id As Int32) Implements IPersonalBL.DeletePersonal
        factoryrepository.DeletePersonal(id)
    End Sub

    Public Function GetAllFromPersonal() As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalBL.GetAllFromPersonal
        Return factoryrepository.GetAllFromPersonal
    End Function

    Public Function GetPersonalById(ByVal id As Int32) As BussinessEntities.Personal Implements IPersonalBL.GetPersonalById
        Return factoryrepository.GetPersonalByIdPersonal(id)
    End Function

    Public Function GetPersonalById(ByVal id As Int32, ByVal argPersonal As ArgumentosPersonal) As BussinessEntities.Personal Implements IPersonalBL.GetPersonalById
        Return factoryrepository.GetPersonalByIdPersonal(id, argPersonal)
    End Function

    Public Function SavePersonal(ByVal Personal As BussinessEntities.Personal) As Integer Implements IPersonalBL.SavePersonal
        Return factoryrepository.SavePersonal(Personal)
    End Function

    Public Function GetPERSONALActualmenteLaborandoByIdCategoria(ByVal idCategoria As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalBL.GetPERSONALActualmenteLaborandoByIdCategoria
        Return factoryrepository.GetPERSONALActualmenteLaborandoByIdCategoria(idCategoria)
    End Function

    Public Function GetPERSONALALiquidadoPorRangoFecha(ByVal idCategoria As Integer) As List(Of BussinessEntities.Personal) Implements IPersonalBL.GetPERSONALALiquidadoPorRangoFecha
        Return factoryrepository.GetPERSONALALiquidadoPorRangoFecha(idCategoria)
    End Function

    Public Function GetPERSONALSinVinculoLaboral() As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalBL.GetPERSONALSinVinculoLaboral
        Return factoryrepository.GetPERSONALSinVinculoLaboral()
    End Function

    Public Function GetPERSONALByIdCategoria(ByVal idCategoria As Integer) As List(Of BussinessEntities.Personal) Implements BussinesLogic.IPersonalBL.GetPERSONALByIdCategoria
        Return factoryrepository.GetPERSONALByIdCategoria(idCategoria)
    End Function

    Public Function GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha(ByVal fechaIni As DateTime) As List(Of BussinessEntities.Personal) Implements IPersonalBL.GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha
        Return factoryrepository.GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha(fechaIni)
    End Function

    Public Function GetPersonalByFechaByIdProyecto(ByVal Fecha As Date, ByVal idProyecto As Integer) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalBL.GetPersonalByFechaByIdProyecto
        Return factoryrepository.GetPersonalByFechaByIdProyecto(Fecha, idProyecto)
    End Function

    Public Sub UpdateCVPERSONAL(ByVal IdPersonal As Integer, ByVal ArchivoCV As String) Implements IPersonalBL.UpdateCVPERSONAL
        factoryrepository.UpdateCVPERSONAL(IdPersonal, ArchivoCV)
    End Sub

    Public Sub UpdateFotoPERSONAL(ByVal IdPersonal As Integer, ByVal ArchivoFoto As String) Implements IPersonalBL.UpdateFotoPERSONAL
        factoryrepository.UpdateFotoPERSONAL(IdPersonal, ArchivoFoto)
    End Sub

    Public Sub UpdateArchivoCertificadoTipoSangre(ByVal CertificadoTipoSangre As String, ByVal IdPersonal As Integer) Implements IPersonalBL.UpdateArchivoCertificadoTipoSangre
        factoryrepository.UpdateArchivoCertificadoTipoSangre(CertificadoTipoSangre, IdPersonal)
    End Sub

    Public Function GetListaPersonalPorParametro(ByVal parametro As Int32, ByVal idCategoria As Int32) As List(Of Personal)
        Select Case parametro
            Case 1  'Colaboradores activos
                Return Me.GetPERSONALActualmenteLaborandoByIdCategoria(idCategoria)
            Case 2  'Colaboradores liquidados
                'If fechaIni.HasValue And fechaFin.HasValue Then
                Return Me.GetPERSONALALiquidadoPorRangoFecha(idCategoria)
                'End If
            Case 3  'Sin vínculo laboral
                Return Me.GetPERSONALSinVinculoLaboral
            Case 4  'Practicantes activos e inactivos
                Return Me.GetPERSONALActualmenteLaborandoByIdCategoria(idCategoria)
                'Case 6  'Colaboradores y practicantes activos
                'Case 10  'Todos (colaboradores, practicantes, sin vinculo laboral, activos o liquidados)
                '    Return Me.GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha(fechaIni)
            Case Else
                Return Me.GetAllFromPersonal
        End Select

    End Function

    'Public Function GetListaPersonalPorParametro(ByVal parametro As Int32, ByVal idCategoria As Int32, ByVal fechaIni As Date, ByVal fechaFin As Date) As List(Of Personal)
    '    Select Case parametro
    '        Case 1  'Colaboradores activos
    '            Return Me.GetPERSONALActualmenteLaborandoByIdCategoria(idCategoria)
    '        Case 2  'Colaboradores liquidados
    '            'If fechaIni.HasValue And fechaFin.HasValue Then
    '            Return Me.GetPERSONALALiquidadoPorRangoFecha(idCategoria, fechaIni, fechaFin)
    '            'End If
    '        Case 3  'Sin vínculo laboral
    '            Return Me.GetPERSONALSinVinculoLaboral
    '        Case 4  'Practicantes activos e inactivos
    '            Return Me.GetPERSONALByIdCategoria(idCategoria)
    '            'Case 6  'Colaboradores y practicantes activos
    '        Case 10  'Todos (colaboradores, practicantes, sin vinculo laboral, activos o liquidados)
    '            Return Me.GetPERSONALSinVinculoYConVinculoApartirDeUnaFecha(fechaIni)
    '        Case Else
    '            Return Me.GetAllFromPersonal
    '    End Select

    'End Function

    Public Function GetFiltrarPERSONALPorParametro(ByVal apeMat As String, ByVal apePat As String, ByVal nomb As String, ByVal di As String) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalBL.GetFiltrarPERSONALPorParametro
        If String.IsNullOrEmpty(apeMat) Then
            apeMat = "%"
        End If
        If String.IsNullOrEmpty(apePat) Then
            apePat = "%"
        End If
        If String.IsNullOrEmpty(nomb) Then
            nomb = "%"
        End If
        If String.IsNullOrEmpty(di) Then
            di = "%"
        End If
        Return factoryrepository.GetFiltrarPERSONALPorParametro(apeMat, apePat, nomb, di)
    End Function


    Public Function SaveViculoLaboral(ByVal personal As BussinessEntities.Personal) As Integer? Implements IPersonalBL.SaveViculoLaboral
        factoryrepository.UpdateNIvelEducativo(personal.IdNivelEducativo, personal.IdPersonal)

        Dim PeriodoRepository As New PeriodoLaboralRepository
        Try
            PeriodoRepository.SavePERIODOLABORAL(personal.periodoLaboralActualEntity)
            Return personal.IdPersonal
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetPERSONALinControlAsistencia(ByVal Fecha As Date) As System.Collections.Generic.List(Of BussinessEntities.Personal) Implements IPersonalBL.GetPERSONALinControlAsistencia
        Return factoryrepository.GetPERSONALinControlAsistencia(Fecha)
    End Function

    Public Function GetCertificadoTipoSangrePERSONALByIdPersonal(ByVal IdPersonal As Integer) As String Implements IPersonalBL.GetCertificadoTipoSangrePERSONALByIdPersonal
        Return factoryrepository.GetCertificadoTipoSangrePERSONALByIdPersonal(IdPersonal)
    End Function


    Public Function GetAsignacionFamiliarByIdPersonal(ByVal Idpersonal As Integer) As Decimal Implements IPersonalBL.GetAsignacionFamiliarByIdPersonal
        Return factoryrepository.GetAsignacionFamiliarByIdPersonal(Idpersonal)
    End Function
End Class
