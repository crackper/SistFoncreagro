Imports SistFoncreagro.BussinessEntities
Public Class Personal

    Public Property ApeMaterno As String
    Public Property ApePaterno As String
    Public Property Celular As String
    Public Property Direccion As String
    Public Property Email As String
    Public Property EstadoCivil As String
    Public Property FechaNacimiento As System.Nullable(Of Date)
    Public Property IdPersonal As System.Nullable(Of Int32)
    Public Property LugarNacimiento As String
    Public Property Nacionalidad As String
    Public Property Nombres As String
    Public Property NroDI As String
    Public Property Sexo As String
    Public Property Telefono As String
    Public Property TipoSangre As String
    Public Property LicenciaConducir As String
    Public Property ContactoEmergencia As String
    Public Property TelefonoContacto As String
    Public Property Discapacidad As Boolean
    Public Property IdNacionalidad As System.Nullable(Of Int32)
    Public Property IdNivelEducativo As System.Nullable(Of Int32)
    Public Property IdTipoDI As System.Nullable(Of Int32)
    Public Property ArchivoFoto As String
    Public Property ArchivoCV As String
    Public Property CertificadoTipoSangre As String
    Public Property Fotocheck As String

    Public Property nacionalidadEntity As Nacionalidad
    Public Property tipoDIEntity As TipoDocumentoIdentidad
    Public Property periodoLaboralActualEntity As PeriodoLaboral

    Public Property JefeEntity As Personal
    Public Property ListaSubordinados As List(Of Personal)

    Public Property AfiliacionSPEntity As AfiliacionSP
    Public Property CorrespondeAsignacionFamiliar As Boolean


    Public ReadOnly Property nombreCompleto As String
        Get
            Return ApePaterno & " " & ApeMaterno & " " & Nombres
        End Get
    End Property
    Public ReadOnly Property IdJefe As System.Nullable(Of Int32)
        Get
            If Not JefeEntity Is Nothing Then
                Return JefeEntity.IdJefe
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property NombreJefe As String
        Get
            If Not JefeEntity Is Nothing Then
                Return JefeEntity.nombreCompleto
            Else
                Return Nothing
            End If
        End Get
    End Property


    Public ReadOnly Property IdPeriodoLaboralActual As System.Nullable(Of Int32)
        Get
            If Not periodoLaboralActualEntity Is Nothing Then
                Return periodoLaboralActualEntity.IdPeriodoLaboral
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property FechaInicio As System.Nullable(Of DateTime)
        Get
            If Not periodoLaboralActualEntity Is Nothing Then
                Return periodoLaboralActualEntity.FechaInicio
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property FechaCese As System.Nullable(Of DateTime)
        Get
            If Not periodoLaboralActualEntity Is Nothing Then
                Return periodoLaboralActualEntity.FechaCese
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property ContratoActual As ContratoConvenio
        Get
            If Not periodoLaboralActualEntity Is Nothing Then
                Return periodoLaboralActualEntity.contratoActual
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property NroContrato As String
        Get
            If Not ContratoActual Is Nothing Then
                Return ContratoActual.NroContrato
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property IdContrato As System.Nullable(Of Int32)
        Get
            If Not ContratoActual Is Nothing Then
                Return ContratoActual.IdContrato
            Else
                Return Nothing
            End If
        End Get
    End Property


    Public ReadOnly Property CondicionesActualesDeContrato As CondicionesContrato
        Get
            If Not ContratoActual Is Nothing Then
                Return ContratoActual.condicionesActualesDeContrato
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property PosicionActual As Posicion
        Get
            If Not CondicionesActualesDeContrato Is Nothing Then
                Return CondicionesActualesDeContrato.Posicion
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property IdPosicionActual As System.Nullable(Of Int32)
        Get
            If Not PosicionActual Is Nothing Then
                Return PosicionActual.IdPosicion
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property NombrePosicion As String
        Get
            If Not PosicionActual Is Nothing Then
                Return PosicionActual.NomCargo
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property Area As Area
        Get
            If Not PosicionActual Is Nothing Then
                Return PosicionActual.Area
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property IdArea As System.Nullable(Of Int32)
        Get
            If Not Area Is Nothing Then
                Return Area.IdArea
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property NombreArea As String
        Get
            If Not Area Is Nothing Then
                Return Area.Nombre
            Else
                Return Nothing
            End If
        End Get
    End Property
End Class
