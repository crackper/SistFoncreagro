Imports SistFoncreagro.BussinesLogic
Imports SistFoncreagro.BussinessEntities
Public Class FrmEditarPersonal
    Inherits System.Web.UI.Page

    Dim nacionalidadBL As NacionalidadBL
    Dim listaNacionalidad As List(Of Nacionalidad)
    Dim personal As New Personal
    Dim periodoLaboralActual As New PeriodoLaboral
    Dim contratoActual As New ContratoConvenio
    Dim condicionesActuales As New CondicionesContrato
    Dim posicion As New Posicion
    Dim area As New Area
    Dim personalBl As New PersonalBL
    Dim idPersonal As Integer
    Dim arraySession1 As New Collection
    Dim correlativoBL As New CorrelativoBL
    Dim PeriodoLaboralBL As New PeriodoLaboralBL
    Dim contratoBL As New ContratoConvenioBL
    Dim condicionesBL As New CondicionesContratoBL
    Dim dhBL As New DerechoHabienteBL
    Dim afiliacionSPBL As New AfiliacionSPBL
    Dim spBL As New SistemaDePensionesBL
    Dim acc As String
    Dim ficha As Integer = 0
    'Dim accion As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim personalBL As IPersonalBL
        Dim personal As Personal
 
        acc = Request.QueryString("acc")
        idPersonal = Session("IdPersonal") 'Request.QueryString("IdPersonal")
        ficha = Request.QueryString("ficha")

        If ficha > 0 Then
            Me.RadTabStrip1.SelectedIndex = ficha
            Me.RadTabStrip1.Tabs(ficha).Focus()
            Me.RadMultiPage3.SelectedIndex = ficha
        End If

        personalBL = New PersonalBL
        Dim argPosicion As New ArgumentosPosicion(Nothing, 0, 0, 0, 0, 0, 0)
        Dim argPersonal As New ArgumentosPersonal(1, 1, 1, argPosicion, Nothing, 1, 0, 0, 1, 1, 1, 1, 0)
        personal = personalBL.GetPersonalById(idPersonal, argPersonal)

        If Not Page.IsPostBack Then
            'EN CASO DE QUE LA PERSONA EXISTA
            If Not personal Is Nothing Then
                arraySession1.Add(personal.IdPersonal, "IdPersonal")

                '1.COLOCA EL NOMBRE EN LA CABECERA Y LA FOTO Y CV EN CASO LO TUVIERA
                Me.lblNombre.Visible = True
                Me.lblNombre.Text = personal.nombreCompleto

                If Not String.IsNullOrEmpty(personal.ArchivoFoto) Then
                    Me.foto.Visible = True
                    Me.foto.ImageUrl = "~\Archivos\RRHH\Fotos\" + personal.ArchivoFoto
                    arraySession1.Add(personal.ArchivoFoto, "archivoFoto")
                Else
                    Me.foto.Visible = False
                    arraySession1.Add("", "archivoFoto")
                End If

                If Not String.IsNullOrEmpty(personal.ArchivoCV) Then
                    arraySession1.Add(personal.ArchivoCV, "archivoCV")
                    Me.btnAbrirCV.CommandArgument = personal.ArchivoCV
                    Me.btnAbrirCV.Visible = True
                    Me.lblAbrirCV.Visible = True
                Else
                    arraySession1.Add("", "archivoCV")
                    Me.btnAbrirCV.Visible = False
                    Me.lblAbrirCV.Visible = False
                End If
                ' FIN 1

                ''''''''''''''''''''''
                ''''''''''''''''''''''
                ''''''''''''''''''''''
                '2. SI PERSONAL EXISTE, -> ACTIVA EL RESTO DE FICHAS PARA QUE INGRESEN SUS DATOS
                Me.RadTabStrip1.Tabs.Item(1).Enabled = True
                Me.RadTabStrip1.Tabs.Item(2).Enabled = True
                Me.RadTabStrip1.Tabs.Item(3).Enabled = True
                ' FIN 2

                '3. COLOCA DATOS DEL PERSONAL EN LA FICHA GENERAL
                Me.txtNombre.Text = personal.Nombres
                Me.txtApelPaterno.Text = personal.ApePaterno
                Me.txtApelMaterno.Text = personal.ApeMaterno

                If personal.IdNacionalidad.HasValue Then
                    Me.RCBNacionalidad.SelectedValue = personal.IdNacionalidad
                End If

                If personal.IdTipoDI.HasValue Then
                    Me.RCBTipoDI.SelectedValue = personal.IdTipoDI
                End If

                If Not String.IsNullOrEmpty(personal.NroDI) Then
                    Me.txtNroDI.Text = personal.NroDI
                End If

                Me.RtxtDireccion.Text = personal.Direccion

                If personal.FechaNacimiento.HasValue Then
                    Me.rpFechaNacimiento.SelectedDate = personal.FechaNacimiento
                End If

                Me.txtLugarNacimiento.Text = personal.LugarNacimiento

                If Not String.IsNullOrEmpty(personal.Sexo) Then
                    Me.RCBGenero.SelectedValue = personal.Sexo
                End If

                If Not String.IsNullOrEmpty(personal.EstadoCivil) Then
                    Me.RCBEstadoCivil.SelectedValue = personal.EstadoCivil
                End If

                Me.txtLicConducir.Text = personal.LicenciaConducir
                Me.txtTelPersonal.Text = personal.Telefono
                Me.txtCelPersonal.Text = personal.Celular
                Me.txtEmailPersonal.Text = personal.Email

                If Not String.IsNullOrEmpty(personal.TipoSangre) Then
                    Me.txtTipoSangre.Text = personal.TipoSangre
                    lbtnAdjuntarCerTS.Visible = True
                End If

                If Not String.IsNullOrEmpty(personal.CertificadoTipoSangre) Then
                    Me.btnAbrirCertTS.Visible = True
                    arraySession1.Add(personal.CertificadoTipoSangre, "ArchivoTS")
                    Me.btnAbrirCertTS.CommandArgument = personal.CertificadoTipoSangre
                Else
                    arraySession1.Add("", "ArchivoTS")
                    Me.btnAbrirCertTS.Visible = False
                End If

                Me.txtNombreContacto.Text = personal.ContactoEmergencia
                Me.txtTelContacto.Text = personal.TelefonoContacto
                Me.txtFotocheck.Text = personal.Fotocheck

                If personal.IdNivelEducativo.HasValue Then
                    Me.RCBNivelEducativo.SelectedValue = personal.IdNivelEducativo
                End If
                'FIN 3


                If acc <> "nuevo" Then
                    '5. EN CASO DE QUE NO SE DESEE INGRESAR UN PERIODO LABORAL NUEVO
                    'SI EXISTE EL PERIODO LABORAL:
                    periodoLaboralActual = personal.periodoLaboralActualEntity
                    If Not periodoLaboralActual Is Nothing Then
                        '11. SI PERIODO LABORAL EXISTE COLOCAMOS LOS DATOS E INICIAMOS LA VARIABLE SESSION
                        Me.txtIdPeriodo.Text = periodoLaboralActual.IdPeriodoLaboral
                        'Me.txtNuevo.Text = ""
                        Session("IdPeriodoLaboral") = txtIdPeriodo.Text

                        If periodoLaboralActual.FechaInicio.HasValue Then
                            Me.rpFechaIngreso.SelectedDate = periodoLaboralActual.FechaInicio
                        End If

                        If periodoLaboralActual.FechaCese.HasValue Then
                            Me.rpFechaCese.SelectedDate = periodoLaboralActual.FechaCese
                            '12 SI TIENE FECHA DE CESE TODO DEBE ESTAR INHABILIDATO Y
                            'SE PUEDE CREAR UN NUEVO PERIODO LABORAL
                            Me.btnNuevoPeriodo.Visible = True
                            Me.btnCancelar.Visible = False
                            InhabilitarTodoPeriodoLaboral(False)
                            'FIN 12
                        Else
                            '13 SI NO TIENE FECHA DE CESE TODO DEBE ESTAR HABILITADO Y
                            ' NO SE PUEDE CREAR UN NUEVO PERIODO LABORAL
                            Me.btnNuevoPeriodo.Visible = False
                            Me.btnCancelar.Visible = True
                            InhabilitarTodoPeriodoLaboral(True)
                            'FIN 13
                        End If

                        If periodoLaboralActual.IdCategoria.HasValue Then
                            Me.RCBVinculo.SelectedValue = periodoLaboralActual.IdCategoria
                            Me.RCBTipoTrabajador.DataBind()
                            Me.RCBTipoContrato.DataBind()
                        End If

                        If periodoLaboralActual.IdTipoTrabajador.HasValue Then
                            Me.RCBTipoTrabajador.SelectedValue = periodoLaboralActual.IdTipoTrabajador
                        End If

                        If Not String.IsNullOrEmpty(periodoLaboralActual.EmailCoorporativo) Then
                            Me.RtxtDireccion.Text = periodoLaboralActual.EmailCoorporativo
                        End If

                        If Not String.IsNullOrEmpty(periodoLaboralActual.TelefCoorp) Then
                            Me.txtTelCoorporativo.Text = periodoLaboralActual.TelefCoorp
                        End If

                        If acc <> "renov" Then
                            '14. EN CASO DE QUE NO SE DESEE RENOVAR UN CONTRATO AÚN PARA DICHO PERIODO
                            contratoActual = periodoLaboralActual.contratoActual
                            If Not contratoActual Is Nothing Then
                                Me.txtIdContrato.Text = contratoActual.IdContrato
                                Session("IdContrato") = txtIdContrato.Text

                                Me.txtNroContrato.Text = contratoActual.NroContrato
                                Me.txtNroContrato.ForeColor = Drawing.Color.Black
                                Me.txtEstado.Text = contratoActual.Estado
                                If contratoActual.Renovacion.HasValue Then
                                    If contratoActual.Renovacion Then
                                        Me.ddlRenovacion.SelectedValue = 1
                                    Else
                                        Me.ddlRenovacion.SelectedValue = 0
                                    End If
                                End If

                                If Not String.IsNullOrEmpty(contratoActual.Archivo) Then
                                    Me.btnAbrirContrato.Visible = True
                                    arraySession1.Add(contratoActual.Archivo, "ArchivoContrato")
                                    Me.btnAbrirContrato.CommandArgument = contratoActual.Archivo
                                Else
                                    arraySession1.Add("", "ArchivoContrato")
                                    Me.btnAbrirContrato.Visible = False
                                End If

                                If contratoActual.FechaInicio.HasValue Then
                                    Me.rpFechaInicioContrato.SelectedDate = contratoActual.FechaInicio
                                End If

                                If contratoActual.IdTipoContrato.HasValue Then
                                    Me.RCBTipoContrato.SelectedValue = contratoActual.IdTipoContrato
                                End If

                                If contratoActual.IdGrupoOcupacional.HasValue Then
                                    Me.RCBGrupoOcupacional.SelectedValue = contratoActual.IdGrupoOcupacional
                                End If

                                '19. OBTENEMOS LAS CONDICIONES ACTUALES DEL CONTRATO
                                condicionesActuales = contratoActual.condicionesActualesDeContrato
                                'FIN 19

                                If Not condicionesActuales Is Nothing Then
                                    '20 SI EXISTEN LAS CONDICIONES ACTUALES DEL CONTRATO
                                    Me.txtIdCondicion.Text = condicionesActuales.IdCondicion

                                    '22 PONEMOS VISIBLE AL PANEL DE HORARIO
                                    Me.PanelBtn.Visible = True
                                    'FIN 22

                                    If condicionesActuales.FechaAmpliacionContrato.HasValue Then
                                        Me.rpFechaFinContrato.SelectedDate = condicionesActuales.FechaAmpliacionContrato
                                        '21 SOLO SE PUEDE RENOVAR CONTRATO SI EL CONTRATO TIENE FECHA DE FIN
                                        Me.lbtnCambiarCond.Visible = True
                                        'FIN 21
                                    End If

                                    'POR REVISAR
                                    If Not String.IsNullOrEmpty(condicionesActuales.archivo) Then
                                        Me.btnAbrirAdenda1.Visible = True
                                        arraySession1.Add(condicionesActuales.archivo, "ArchivoAdenda")
                                        Me.btnAbrirAdenda1.CommandArgument = condicionesActuales.archivo
                                        Me.btnAbrirAdenda2.CommandArgument = condicionesActuales.archivo
                                        Me.btnAbrirAdenda3.CommandArgument = condicionesActuales.archivo
                                    Else
                                        arraySession1.Add("", "ArchivoAdenda")
                                        Me.btnAbrirAdenda1.Visible = False
                                        Me.btnAbrirAdenda2.Visible = False
                                        Me.btnAbrirAdenda3.Visible = False
                                        Me.btnAbrirAdenda4.Visible = False
                                    End If
                                    ''''
                                    If condicionesActuales.Sueldo.HasValue Then
                                        Me.txtSueldo.Text = condicionesActuales.Sueldo

                                        Me.lblAsignacion.Text = "+ S/." & CStr(personalBL.GetAsignacionFamiliarByIdPersonal(idPersonal)) & " por Asignación Familiar"
                                    End If

                                    If Not String.IsNullOrEmpty(condicionesActuales.CondicionDelCambio) Then
                                        Me.txtCondicionCambio.Text = condicionesActuales.CondicionDelCambio
                                    End If

                                    If condicionesActuales.FechaCambio.HasValue Then
                                        Me.lblFechaCambio.Text = condicionesActuales.FechaCambio
                                    End If

                                    If condicionesActuales.IdSituacionEspecial.HasValue Then
                                        Me.rblSituacionEspecial.SelectedValue = condicionesActuales.IdSituacionEspecial
                                    End If
                                    'FIN 20

                                    posicion = condicionesActuales.Posicion
                                    If Not posicion Is Nothing Then
                                        '22 SI POSICION EXISTE VISUALIZAMOS LAS ETIQUETAS DE LA CABECERA:
                                        Me.lblCargo.Visible = True
                                        Me.lblCargo.Text = posicion.NomCargo
                                        'FIN DE 22

                                        area = posicion.Area
                                        If Not area Is Nothing Then
                                            '24 SI EXISTE AREA, VISUALIZAMOS CABECERA CORRESPONDIENTE
                                            Me.lblArea.Visible = True
                                            Me.lblArea.Text = area.Nombre
                                            'FIN 24
                                            If area.IdArea.HasValue Then
                                                Me.RadComboBox1.Items(0).Text = area.Nombre
                                                Me.RadComboBox1.Items(0).Value = area.IdArea
                                                Me.RadComboBox1.SelectedValue = area.IdArea

                                                Me.txtIdArea.Text = area.IdArea
                                                Me.ddlPosicion.DataBind()
                                                If posicion.IdPosicion.HasValue Then
                                                    Me.ddlPosicion.SelectedValue = posicion.IdPosicion
                                                End If
                                            End If
                                        Else
                                            '25 SI NO EXISTE AREA PONEMOS INVISIBLE CABECERA CORRESPONDIENTE
                                            Me.lblArea.Visible = False
                                            'FIN 25
                                        End If
                                    Else
                                        '23 SI NO EXISTE POSICION PONEMOS INVISIBLE CABECERA CORRESPONDIENTE
                                        Me.lblCargo.Visible = False
                                        ' FIN DE 23
                                    End If
                                Else
                                    '21 SI NO EXISTEN LAS CONDICIONES ACTUALES DEL CONTRATO
                                    Me.txtIdCondicion.Text = 0
                                    'pone invisibles botones de adjuntos y renovaciones
                                    Me.lbtnCargarAdemda.Visible = False
                                    Me.lbtnFechaFinContrato.Visible = False
                                    Me.lbtnCambiarCond.Visible = False
                                    Me.btnAbrirAdenda1.Visible = False
                                    Me.lbtnSueldoBruto.Visible = False
                                    Me.btnAbrirAdenda2.Visible = False
                                    Me.btnAbrirAdenda3.Visible = False
                                    Me.btnAbrirAdenda4.Visible = False
                                    Me.PanelBtn.Visible = False
                                    'FIN 21
                                End If

                            Else
                                '18 SI NO EXISTE NINGÚN CONTRATO PARA ESTA PERSONA EN ESTE PERIODO
                                Me.ddlRenovacion.SelectedValue = 0
                                arraySession1.Add("", "ArchivoContrato")
                                'SI NO EXISTE FECHA DE CESE
                                If Not periodoLaboralActual.FechaCese.HasValue Then
                                    SiNoexisteContrato(True)
                                End If
                                '
                            End If
                            'FIN 14
                        Else
                            '17. SI SE ELIGE RENOVAR CONTRATO
                            Me.ddlRenovacion.SelectedValue = 1
                            SiNoexisteContrato(False)
                            ' FIN DE 17
                        End If

                    Else
                        '9. SI NO EXISTE NINGÚN PERIODO LABORAL PARA ESA PERSONA.
                        PonerVisibleNoExistePeriodoLaboral()
                        arraySession1.Add("", "ArchivoContrato")
                        'FIN DE 9
                    End If
                    'FIN 5
                Else
                    '6. EN CASO DE QUE SE DESEE INGRESAR UN PERIODO LABORAL NUEVO
                    '10 EN CASO DE QUE SE HAYA ELEGIDO INGRESAR UN NUEVO PERIODO LABORAL
                    PonerVisibleNoExistePeriodoLaboral()
                    'FIN DE 10
                    'FIN 6
                End If

                'EN CASO DE QUE LA PERSONA NO EXISTA:
            Else
                '4. SI PERSONAL NO EXISTE, -> DESACTIVA EL RESTO DE FICHAS PARA QUE NO SE INGRESEN SUS DATOS
                arraySession1.Add("", "ArchivoTS")
                arraySession1.Add("", "ArchivoContrato")
                Me.RadTabStrip1.Tabs.Item(1).Enabled = False
                Me.RadTabStrip1.Tabs.Item(2).Enabled = False
                Me.RadTabStrip1.Tabs.Item(3).Enabled = False
                ' FIN 4
                '5. PONEMOS NO VISILES LOS BOTONES DE ADJUNTAR FOTO, CV Y CERTIFICADO TS
                Me.foto.Visible = False
                Me.btnAbrirCV.Visible = False
                Me.lblAbrirCV.Visible = False
                Me.lbtnFoto.Visible = False
                Me.lbtnCV.Visible = False
                Me.lbtnAdjuntarCerTS.Visible = False
                Me.btnAbrirCertTS.Visible = False
                'FIN 5

            End If
            Session("persona") = arraySession1
        End If
    End Sub

    Sub PonerVisibleNoExistePeriodoLaboral()
        'COLOCAMOS LOS IDS
        Me.txtIdPeriodo.Text = "0"
        'Me.txtNuevo.Text = "nuevo"

        '7. PONEMOS A NUEVO EN RENOVACION DE CONTRATO
        Me.ddlRenovacion.SelectedValue = 0
        'FIN 7

        ' BOTONES NUEVO Y CANCELAR
        Me.btnCancelarNuevo.Visible = True
        Me.btnNuevoPeriodo.Visible = False

        ' PONEMOS INVISIBLE BOTONES DE ADJUNTAR Y RENOVAR
        Me.lbtnCargarContrato.Visible = False
        Me.btnAbrirContrato.Visible = False
        Me.lbtnRenovar.Visible = False
        Me.lbtnCambiarCond.Visible = False
        Me.lbtnCargarAdemda.Visible = False

        '8. PONEMOS INVISIBLE CORREO Y TELEFONO COORPORATIVO
        Me.txtTelCoorporativo.Visible = False
        Me.RtxtEmailCoorporativo.Visible = False
        ' FIN 8

        Me.PanelBtn.Visible = False
    End Sub

    Sub InhabilitarTodoPeriodoLaboral(ByVal valor As Boolean)
        Me.rpFechaIngreso.Enabled = valor
        'Me.rpFechaCese.Enabled = valor
        Me.RCBVinculo.Enabled = valor
        Me.RCBTipoTrabajador.Enabled = valor
        Me.rblSituacionEspecial.Enabled = valor
        Me.PanelBtn.Enabled = valor
        Me.lbtnRenovar.Enabled = valor
        Me.lbtnCargarContrato.Enabled = valor
        Me.txtNroContrato.Enabled = valor
        Me.RCBTipoContrato.Enabled = valor
        Me.RCBGrupoOcupacional.Enabled = valor
        Me.rpFechaInicioContrato.Enabled = valor
        Me.lbtnCambiarCond.Enabled = valor
        Me.rpFechaFinContrato.Enabled = valor
        Me.txtSueldo.Enabled = valor
        Me.RadComboBox1.Enabled = valor
        Me.ddlPosicion.Enabled = valor
    End Sub

    'Sub InhabilitarSiRenuevaContrato(ByVal valor As Boolean)
    '    Me.rpFechaIngreso.Enabled = valor
    '    Me.rpFechaCese.Enabled = valor
    '    Me.RCBVinculo.Enabled = valor
    '    Me.RCBTipoTrabajador.Enabled = valor
    '    Me.rblSituacionEspecial.Enabled = valor
    '    Me.PanelBtn.Enabled = valor
    '    Me.lbtnRenovar.Enabled = valor
    'End Sub

    Sub SiNoexisteContrato(ByVal valor As Boolean)
        Me.btnNuevoPeriodo.Visible = False
        Me.btnCancelarNuevo.Visible = True
        '16 COLOCAMOS IDS DE CONTRATO
        Me.txtIdContrato.Text = 0
        'FIN 16

        '15 EN CASO DE QUE SE HAYA ELEGIDO RENOVAR UN CONTRATO
        'DEBE APARECER DESHABILITADO LO REFERENTE A PERIDO LABORAL
        Me.rpFechaIngreso.Enabled = valor
        Me.rpFechaCese.Enabled = valor
        Me.RCBVinculo.Enabled = valor
        Me.RCBTipoTrabajador.Enabled = valor
        Me.rblSituacionEspecial.Enabled = valor
        Me.PanelBtn.Enabled = False
        Me.lbtnRenovar.Visible = False
        Me.lbtnCargarContrato.Visible = False
        Me.lbtnCambiarCond.Visible = False
        'FIN 15
    End Sub

    'Protected Sub DropDownList4_Init(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList4.Init
    '    listaNacionalidad = New List(Of Nacionalidad)
    '    nacionalidadBL = New NacionalidadBL
    '    listaNacionalidad = Me.nacionalidadBL.GetAllFromNacionalidad
    '    Me.DropDownList4.DataSource = listaNacionalidad
    '    Me.DropDownList4.DataBind()
    '    'Me.DropDownList4.DataTextField= DropDownList4.DataSource.
    '    'Me.DropDownList4.DataTextField = listaNacionalidad(
    'End Sub

    'Protected Sub DropDownList5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList5.SelectedIndexChanged
    '    Me.DropDownList6.DataSource = Me.DropDownList5.SelectedValue
    '    Me.DropDownList6.DataBind()
    'End Sub

    Protected Sub ImageButton5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton5.Click
        Dim validar As Boolean
        validar = True

        personal.IdPersonal = idPersonal

        If Not String.IsNullOrEmpty(Me.txtApelMaterno.Text) Then
            personal.ApeMaterno = Me.txtApelMaterno.Text
            Me.lblValidarApeMat.Visible = False
        Else
            validar = False
            Me.lblValidarApeMat.Visible = True
        End If

        If Not String.IsNullOrEmpty(Me.txtApelPaterno.Text) Then
            personal.ApePaterno = Me.txtApelPaterno.Text
            Me.lblValidarApePat.Visible = False
        Else
            validar = False
            Me.lblValidarApePat.Visible = True
        End If

        If Not String.IsNullOrEmpty(Me.txtNombre.Text) Then
            personal.Nombres = Me.txtNombre.Text
            Me.lblValidarNombre.Visible = False
        Else
            validar = False
            Me.lblValidarNombre.Visible = True
        End If

        If Me.RCBNacionalidad.SelectedIndex > -1 Then
            personal.IdNacionalidad = Me.RCBNacionalidad.SelectedValue
            'personal.Nacionalidad = Me.RCBNacionalidad.Text
        End If

        If Me.RCBTipoDI.SelectedIndex > -1 Then
            personal.IdTipoDI = Me.RCBTipoDI.SelectedValue
            If Not String.IsNullOrEmpty(Me.txtNroDI.Text) Then
                personal.NroDI = Me.txtNroDI.Text
            End If
        End If

        If Not String.IsNullOrEmpty(Me.RtxtDireccion.Text) Then
            personal.Direccion = Me.RtxtDireccion.Text
        End If

        If Len(rpFechaNacimiento.SelectedDate) > 0 Then
            personal.FechaNacimiento = rpFechaNacimiento.SelectedDate
        End If

        If Not String.IsNullOrEmpty(Me.txtLugarNacimiento.Text) Then
            personal.LugarNacimiento = Me.txtLugarNacimiento.Text
        End If

        If Me.RCBGenero.SelectedIndex > -1 Then
            personal.Sexo = Me.RCBGenero.SelectedValue
        End If

        If Me.RCBEstadoCivil.SelectedIndex > -1 Then
            personal.EstadoCivil = Me.RCBEstadoCivil.SelectedValue
        End If

        If Not String.IsNullOrEmpty(Me.txtLicConducir.Text) Then
            personal.LicenciaConducir = Me.txtLicConducir.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtTelPersonal.Text) Then
            personal.Telefono = Me.txtTelPersonal.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtCelPersonal.Text) Then
            personal.Celular = txtCelPersonal.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtEmailPersonal.Text) Then
            personal.Email = Me.txtEmailPersonal.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtTipoSangre.Text) Then
            personal.TipoSangre = Me.txtTipoSangre.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtNombreContacto.Text) Then
            personal.ContactoEmergencia = Me.txtNombreContacto.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtTelContacto.Text) Then
            personal.TelefonoContacto = Me.txtTelContacto.Text
        End If

        If Me.RCBNivelEducativo.SelectedIndex > -1 Then
            personal.IdNivelEducativo = RCBNivelEducativo.SelectedValue
        End If

        If Not String.IsNullOrEmpty(Me.txtFotocheck.Text) Then
            personal.Fotocheck = Me.txtFotocheck.Text
        End If

        'personal.Discapacidad = Me.
        'personal.IdNivelEducativopersonal.IdPersonal = 0
        If Not personal.periodoLaboralActualEntity Is Nothing Then
            PeriodoLaboralBL.UpdateTelefonosPeriodoLaboral(personal.periodoLaboralActualEntity.IdPeriodoLaboral, RtxtEmailCoorporativo.Text, txtTelCoorporativo.Text)
        End If

        Dim IdPer As Int32
        If validar Then
            IdPer = personalBl.SavePersonal(personal)
            Session("IdPersonal") = IdPer
            Response.Redirect("~\RRHH\Formulario\FrmEditarPersonal.aspx?ficha=0")
        End If

    End Sub

    Protected Sub RadAjaxManager1_AjaxRequest(ByVal sender As Object, ByVal e As Telerik.Web.UI.AjaxRequestEventArgs) Handles RadAjaxManager1.AjaxRequest
        'Dim url As String
        'Dim cadena_java As String


        If e.Argument.StartsWith("ActualizarPagina") Then

            arraySession1 = Session("persona")

            If arraySession1.Count > 0 Then
                If Not String.IsNullOrEmpty(arraySession1("archivoFoto")) Then
                    foto.ImageUrl = "~\Archivos\RRHH\Fotos\" + arraySession1("archivoFoto")
                    foto.Visible = True
                    Me.UpdatePanel1.DataBind()
                    Me.foto.DataBind()
                Else
                    foto.Visible = False
                    foto.ImageUrl = ""
                End If

                If Not String.IsNullOrEmpty(arraySession1("archivoCV")) Then
                    Me.btnAbrirCV.Visible = True
                    Me.lblAbrirCV.Visible = True
                    Me.btnAbrirCV.CommandArgument = arraySession1("archivoCV")
                    Me.btnAbrirCV.DataBind()
                Else
                    Me.btnAbrirCV.Visible = False
                    Me.lblAbrirCV.Visible = False
                    Me.btnAbrirCV.DataBind()
                End If


                Me.UpdatePanel1.DataBind()
                'cadena_java = "<script type='text/javascript'> " & _
                '                     " ActualizarImagen('" & url & "'); " & _
                '                     Chr(60) & "/script>"
                'ScriptManager.RegisterStartupScript(Page, GetType(Page), "Actualizarf", cadena_java.ToString, False)

                'Response.Redirect("~\RRHH\Formulario\FrmRegistroPersonal.aspx?IdPersonal=" & btn.CommandArgument)
            End If
        ElseIf e.Argument.StartsWith("ActualizarEnlace") Then
            arraySession1 = Session("persona")

            If arraySession1.Count > 0 Then
                If Not String.IsNullOrEmpty(arraySession1("archivoContrato")) Then

                    Me.btnAbrirContrato.Visible = True
                    Me.btnAbrirContrato.CommandArgument = arraySession1("archivoContrato")
                    Me.btnAbrirContrato.DataBind()
                    Me.UpdateCertificadoTS.DataBind()
                Else
                    Me.btnAbrirContrato.Visible = False
                    Me.btnAbrirContrato.CommandArgument = ""
                    Me.btnAbrirContrato.DataBind()
                    Me.UpdateCertificadoTS.DataBind()

                End If


                If Not String.IsNullOrEmpty(arraySession1("archivoTS")) Then
                    Me.btnAbrirCertTS.Visible = True
                    Me.btnAbrirCertTS.CommandArgument = arraySession1("archivoTS")
                    Me.btnAbrirCertTS.DataBind()
                    Me.UpdatePanel6.DataBind()
                Else
                    Me.btnAbrirCertTS.Visible = False
                    Me.btnAbrirCertTS.CommandArgument = ""
                    Me.btnAbrirCertTS.DataBind()
                    Me.UpdatePanel6.DataBind()

                End If

                'If Not String.IsNullOrEmpty(arraySession1("archivoAdenda")) Then
                '    Me.btnAbrirAdenda1.Visible = True
                '    Me.btnAbrirAdenda1.CommandArgument = arraySession1("archivoAdenda")
                'Else
                '    Me.btnAbrirAdenda1.Visible = False
                'End If
            End If

        Else
            If e.Argument.StartsWith("CambioCondiciones") Then
                Me.Response.Redirect("FrmEditarPersonal.aspx")
            End If
        End If
    End Sub

    'Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
    '    Response.Redirect("~\RRHH\Formulario\FrmPersonal.aspx")
    'End Sub

    Protected Sub btnAbrirCV_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrirCV.Click
        Dim myFile As ProcessStartInfo
        Dim btn As ImageButton = CType(sender, ImageButton)
        myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\CV\" + btn.CommandArgument))
        'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        'Abre archivo
        Process.Start(myFile)
    End Sub

    Protected Sub txtSueldo_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSueldo.TextChanged

    End Sub

    Protected Sub btnGrabarPeriodo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnGrabarPeriodo.Click
        Dim periodoLaboral As New PeriodoLaboral
        Dim personal As New Personal
        Dim contrato As New ContratoConvenio
        Dim condiciones As New CondicionesContrato
        Dim idpl As Int32
        Dim idc As Int32
        Dim validar2 As Boolean

        validar2 = True

        If Len(rpFechaIngreso.SelectedDate) > 0 Then
            periodoLaboral.FechaInicio = rpFechaIngreso.SelectedDate
            Me.lblValidarFI.Visible = False
            If Len(rpFechaInicioContrato.SelectedDate) > 0 Then
                If rpFechaInicioContrato.SelectedDate < rpFechaIngreso.SelectedDate Then
                    Me.lblValidarFechaIniC.Visible = True
                    Me.lblValidarFechaIniC.Text = "la fecha no debe ser menor al inicio de periodo laboral"
                    validar2 = False
                Else
                    Me.lblValidarFechaIniC.Visible = False
                End If
            Else
                validar2 = False
                Me.lblValidarFechaIniC.Visible = True
                Me.lblValidarFechaIniC.Text = "Ingrese fecha inicio de contrato"
            End If
        Else
            validar2 = False
            Me.lblValidarFI.Visible = True
            Me.lblValidarFI.Text = "Ingrese fecha"
        End If

        If Len(rpFechaCese.SelectedDate) > 0 Then
            periodoLaboral.FechaCese = rpFechaCese.SelectedDate
            periodoLaboral.Estado = 2
        Else
            periodoLaboral.Estado = 1
        End If

        If RCBVinculo.SelectedIndex > -1 Then
            periodoLaboral.IdCategoria = RCBVinculo.SelectedValue
            Me.lblValidarVinculo.Visible = False
        Else
            validar2 = False
            Me.lblValidarVinculo.Visible = True
            Me.lblValidarVinculo.Text = "Seleccione vinculo"
        End If

        If RCBTipoTrabajador.SelectedIndex > -1 Then
            periodoLaboral.IdTipoTrabajador = RCBTipoTrabajador.SelectedValue
            Me.lblValidarTrabajador.Visible = False
        Else
            validar2 = False
            Me.lblValidarTrabajador.Visible = True
            Me.lblValidarTrabajador.Text = "Seleccione tipo trabajador"
        End If

        periodoLaboral.IdPersonal = idPersonal

        'si no es nuevo
        'If Me.txtNuevo.Text = "" Then
        periodoLaboral.IdPeriodoLaboral = txtIdPeriodo.Text
        'ElseIf Me.txtNuevo.Text = "nuevo" Then
        ''si es nuevo
        'periodoLaboral.IdPeriodoLaboral = 0
        'End If

        If periodoLaboral.IdPeriodoLaboral = 0 Then
            'obtenemos el último periodo laboral
            Dim ultimoPeriodo As New PeriodoLaboral
            ultimoPeriodo = PeriodoLaboralBL.GetPERIODOLABORALAUltimoByIdPersonal(idPersonal, Nothing)
            If Not ultimoPeriodo Is Nothing Then
                periodoLaboral.EmailCoorporativo = ultimoPeriodo.EmailCoorporativo
                periodoLaboral.TelefCoorp = ultimoPeriodo.TelefCoorp
            Else
                periodoLaboral.EmailCoorporativo = Me.RtxtEmailCoorporativo.Text
                periodoLaboral.TelefCoorp = Me.txtTelCoorporativo.Text
            End If
        Else
            periodoLaboral.EmailCoorporativo = Me.RtxtEmailCoorporativo.Text
            periodoLaboral.TelefCoorp = Me.txtTelCoorporativo.Text
        End If
        ' llenamos contrato:

        'VALIDAMOS LOS DATOS DE CONTRATO Y DE CONDICIONES DE CONTRATO ANTES DE GRABAR PERIODO LABORAL
        If Me.RCBTipoContrato.SelectedIndex > -1 Then
            Me.lblValidarModalidad.Visible = False
        Else
            validar2 = False
            Me.lblValidarModalidad.Visible = True
            Me.lblValidarModalidad.Text = "Seleccione modalidad de contrato"
        End If

        If Len(Me.rpFechaInicioContrato.SelectedDate) > 0 Then
            Me.lblValidarFechaIniC.Visible = False
        Else
            validar2 = False
            Me.lblValidarFechaIniC.Visible = True
            Me.lblValidarFechaIniC.Text = "Ingrese fecha inicio de contrato"
        End If

        If Len(Me.rpFechaFinContrato.SelectedDate) <= 0 Then
            If rpFechaFinContrato.Enabled = True Then
                validar2 = False
                Me.lblValidarFechaFC.Visible = True
                Me.lblValidarFechaFC.Text = "Ingrese fecha de fin de contrato o seleccione otra modalidad"
            Else
                Me.lblValidarFechaFC.Visible = False
            End If
        End If

        If validar2 Then
            Try
                idpl = Me.PeriodoLaboralBL.SavePERIODOLABORAL(periodoLaboral)

                contrato.IdPeriodoLaboral = idpl

                If Not String.IsNullOrEmpty(Me.txtIdContrato.Text) Then
                    contrato.IdContrato = Me.txtIdContrato.Text
                Else
                    contrato.IdContrato = 0
                End If

                If Me.RCBGrupoOcupacional.SelectedIndex > -1 Then
                    contrato.IdGrupoOcupacional = Me.RCBGrupoOcupacional.SelectedValue
                End If

                If Me.RCBTipoContrato.SelectedIndex > -1 Then
                    contrato.IdTipoContrato = Me.RCBTipoContrato.SelectedValue
                End If

                contrato.NroContrato = Me.txtNroContrato.Text
                contrato.Renovacion = Me.ddlRenovacion.SelectedValue

                If Len(Me.rpFechaInicioContrato.SelectedDate) > 0 Then
                    contrato.FechaInicio = Me.rpFechaInicioContrato.SelectedDate
                End If

                If Not String.IsNullOrEmpty(txtEstado.Text) Then
                    contrato.Estado = Me.txtEstado.Text
                End If

                'si se coloca fecha de cese a periodo laboral entonces se inhabilita el contrato
                If Len(rpFechaCese.SelectedDate) > 0 Then
                    contrato.Estado = "I"
                Else
                    contrato.Estado = "A"
                End If

                'If Not contrato.IdContrato = 0 Then
                '    contratoBL.UpdateContratoInEstadoByIdCotratoByIdPeriodoLaboral(contrato.IdPeriodoLaboral, "A")
                'End If
                'contrato.Estado = "A"
                idc = contratoBL.SaveContratosConvenios(contrato)

                If Not String.IsNullOrEmpty(Me.txtIdCorrelativo.Text) Then
                    If Me.txtIdCorrelativo.Text > 0 Then
                        ' actualizar el correlativo
                        Dim IdCorrelativo As Int32
                        Dim NroCorrelativo As Int32
                        IdCorrelativo = CInt(Me.txtIdCorrelativo.Text)

                        If Not String.IsNullOrEmpty(txtNroCorrelativo.Text) Then
                            NroCorrelativo = CInt(Me.txtNroCorrelativo.Text)
                        End If

                        correlativoBL.UpdateCorrelativoNroCorrelativo(IdCorrelativo, NroCorrelativo)
                        Me.txtIdCorrelativo.Text = ""
                        Me.txtNroCorrelativo.Text = ""
                    End If
                End If

                Try
                    If Not String.IsNullOrEmpty(Me.txtIdCondicion.Text) Then
                        condiciones.IdCondicion = Me.txtIdCondicion.Text
                    Else
                        condiciones.IdCondicion = 0
                    End If

                    condiciones.IdPeriodoLaboral = idpl
                    condiciones.IdContrato = idc
                    If condiciones.IdCondicion = 0 Then
                        condiciones.CondicionDelCambio = "0"
                        condiciones.FechaCambio = contrato.FechaInicio
                    Else
                        condiciones.CondicionDelCambio = txtCondicionCambio.Text
                        condiciones.FechaCambio = CDate(lblFechaCambio.Text)
                    End If

                    If Len(Me.rpFechaFinContrato.SelectedDate) > 0 Then
                        condiciones.FechaAmpliacionContrato = DateValue(Me.rpFechaFinContrato.SelectedDate)
                    End If

                    If Not String.IsNullOrEmpty(Me.txtSueldo.Text) Then
                        condiciones.Sueldo = Me.txtSueldo.Text
                    End If

                    If Not String.IsNullOrEmpty(ddlPosicion.SelectedValue) Then
                        condiciones.IdPosicion = Me.ddlPosicion.SelectedValue
                    Else
                        condiciones.IdPosicion = Nothing
                    End If

                    If rblSituacionEspecial.SelectedIndex > -1 Then
                        condiciones.IdSituacionEspecial = rblSituacionEspecial.SelectedValue
                    Else
                        condiciones.IdSituacionEspecial = Nothing
                    End If

                    condicionesBL.SaveCondicionesContrato(condiciones)
                    Session("IdPeriodoLaboral") = idpl
                    Me.Response.Redirect("FrmEditarPersonal.aspx?ficha=1")


                Catch ex As Exception
                    Me.Response.Redirect("FrmEditarPersonal.aspx?ficha=1")
                End Try
                'Llenamos condiciones:

            Catch ex As Exception
                Me.Response.Redirect("FrmEditarPersonal.aspx?ficha=1")
            End Try
        End If
        'contrato.NroContrato = Me.txtNroContrato.Text
    End Sub

    Protected Sub RadComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RadComboBox1.SelectedIndexChanged
        ' ''Me.TextBox16.Text = RadComboBox1.SelectedValue
        ''Dim tree As New Telerik.Web.UI.RadTreeView
        ''tree = Me.RadComboBox2.Items.Item(0).FindControl("RadTreeView2")
        ''If Not tree Is Nothing Then
        ''    tree.UnselectAllNodes()
        ''End If
        ''RadComboBox2.ClearSelection()
        ''RadComboBox2.Items.Clear()
        ''RadComboBox2.Text = ""
        ''RadComboBox2.DataBind()
        ' '' RadComboBox2.ClearSelection()
        Me.txtIdArea.Text = RadComboBox1.SelectedValue
    End Sub

    'Protected Sub RadTreeView2_NodeDataBound(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadTreeNodeEventArgs)
    '    'Me.RadComboBox1.Text = ""
    'End Sub

    'Protected Sub RadComboBox2_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles RadComboBox2.PreRender
    '    'Dim tree As New Telerik.Web.UI.RadTreeView
    '    'If tree.SelectedNodes.Count = 0 Then
    '    '    RadComboBox2.ClearSelection()
    '    '    RadComboBox2.Text = ""
    '    '    RadComboBox2.DataBind()
    '    'End If
    'End Sub


    Protected Sub RadTreeView1_NodeClick1(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadTreeNodeEventArgs)
        Dim nodo As New Telerik.Web.UI.RadTreeNode
        nodo = e.Node
        ''RadComboBox2.ClearSelection()
        ' ''RadComboBox2.Text = ""
        ''RadComboBox2.DataBind()
    End Sub

    Protected Sub rpFechaIngreso_SelectedDateChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs) Handles rpFechaIngreso.SelectedDateChanged
        rpFechaInicioContrato.SelectedDate = rpFechaIngreso.SelectedDate
        rpFechaInicioContrato.DataBind()
    End Sub

    Protected Sub RCBNacionalidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RCBNacionalidad.SelectedIndexChanged

    End Sub

    Protected Sub btnNuevoPeriodo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnNuevoPeriodo.Click
        'Me.txtNuevo.Text = "nuevo"
        Me.Response.Redirect("FrmEditarPersonal.aspx?ficha=1&acc=nuevo")
    End Sub

    Protected Sub btnNuevoPeriodo0_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCancelarNuevo.Click
        Me.Response.Redirect("FrmEditarPersonal.aspx?ficha=1")
    End Sub

    Protected Sub ddlRenovacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlRenovacion.SelectedIndexChanged

    End Sub

    Protected Sub rpFechaInicioContrato_SelectedDateChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs) Handles rpFechaInicioContrato.SelectedDateChanged
        Me.rpFechaInicioContrato.DateInput.ForeColor = Drawing.Color.Black
        Me.rpFechaInicioContrato.DateInput.Font.Italic = False

        If Len(rpFechaIngreso.SelectedDate) > 0 Then
            If Len(rpFechaInicioContrato.SelectedDate) > 0 Then
                If rpFechaInicioContrato.SelectedDate < rpFechaIngreso.SelectedDate Then
                    Me.lblValidarFechaIniC.Visible = True
                    Me.lblValidarFechaIniC.Text = "la fecha no debe ser menor al inicio de periodo laboral"
                Else
                    Me.lblValidarFechaIniC.Visible = False
                End If
            End If
        End If
    End Sub


    Protected Sub btnGrabarDH_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnGrabarDH.Click
        Dim dh As New DerechoHabiente

        If Not String.IsNullOrEmpty(Me.txtIdDH.Text) Then
            dh.IdDerechoHabiente = Me.txtIdDH.Text
        Else
            dh.IdDerechoHabiente = 0
        End If

        dh.IdPersonal = idPersonal

        If ddlVinculoFamiliar.SelectedValue > -1 Then
            dh.IdVinculo = ddlVinculoFamiliar.SelectedValue
        End If

        If Not String.IsNullOrEmpty(Me.txtNombreDH.Text) Then
            dh.Nombre = Me.txtNombreDH.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtApePatDH.Text) Then
            dh.ApePaterno = Me.txtApePatDH.Text
        End If

        If Not String.IsNullOrEmpty(Me.txtApeMatDH.Text) Then
            dh.ApeMaterno = Me.txtApeMatDH.Text
        End If

        If Len(rpFechaNacimientoDH.SelectedDate) > 0 Then
            dh.FechaNacimiento = DateValue(rpFechaNacimientoDH.SelectedDate)
        End If

        If ddlNacionalidadDH.SelectedValue > -1 Then
            dh.IdNacionalidad = ddlNacionalidadDH.SelectedValue
        End If

        If ddlTipoDIDH.SelectedValue > -1 Then
            dh.IdTipoDI = ddlTipoDIDH.SelectedValue
        End If

        If Not String.IsNullOrEmpty(Me.txtNroDIDH.Text) Then
            dh.NroDI = Me.txtNroDIDH.Text
        End If

        If ddlEstadoCivilDH.SelectedIndex > -1 Then
            dh.EstadoCivil = ddlEstadoCivilDH.SelectedValue
        End If

        If ddlCondicionDiscEstDH.SelectedValue > -1 Then
            If ddlCondicionDiscEstDH.SelectedValue = 1 Then
                dh.Estudiando = True
            ElseIf ddlCondicionDiscEstDH.SelectedValue = 2 Then
                dh.Discapacidad = True
            End If
        End If

        If Len(rpFechaMatrimonio.SelectedDate) > 0 Then
            dh.FechaConvivencia = DateValue(rpFechaMatrimonio.SelectedDate)
        End If

        If Me.ddlEstadoDH.SelectedValue > -1 Then
            dh.Estado = ddlEstadoDH.SelectedValue
        End If

        dhBL.SaveDERECHOHABIENTE(dh)
        Response.Redirect("~\RRHH\Formulario\FrmEditarPersonal.aspx?ficha=3&IdPersonal=" & idPersonal)
    End Sub

    Protected Sub ddlVinculoFamiliar_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlVinculoFamiliar.SelectedIndexChanged
        If Me.ddlVinculoFamiliar.SelectedItem.Text = "ESPOSA/O" Then
            Me.ddlEstadoCivilDH.SelectedValue = "CASADO(A)"
            Me.lblFechaMatri.Text = "Fecha de Matrimonio"
            Me.PanelFechaMatri.Visible = True
            Me.PanelDiscapacidad.Visible = False
            Me.UpdatePanelDiscDH.DataBind()
        ElseIf Me.ddlVinculoFamiliar.SelectedItem.Text = "CONYUGE" Then
            Me.ddlEstadoCivilDH.SelectedValue = "CONVIVIENTE"
            Me.lblFechaMatri.Text = "Fecha de Convivencia"
            Me.PanelFechaMatri.Visible = True
            Me.PanelDiscapacidad.Visible = False
            Me.UpdatePanelDiscDH.DataBind()
        ElseIf Me.ddlVinculoFamiliar.SelectedItem.Text = "HIJA/O" Then
            Me.ddlEstadoCivilDH.SelectedValue = "SOLTERO(A)"
            Me.PanelFechaMatri.Visible = False
            If Len(Me.rpFechaNacimientoDH.SelectedDate) > 0 Then
                If DateDiff(DateInterval.Year, DateValue(Me.rpFechaNacimientoDH.SelectedDate), Now) >= 18 Then
                    Me.PanelDiscapacidad.Visible = True
                    Me.UpdatePanelDiscDH.DataBind()
                Else
                    Me.PanelDiscapacidad.Visible = False
                    Me.UpdatePanelDiscDH.DataBind()
                End If
            End If
        End If
    End Sub

    Protected Sub rpFechaNacimientoDH_SelectedDateChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.Calendar.SelectedDateChangedEventArgs) Handles rpFechaNacimientoDH.SelectedDateChanged
        If Len(Me.rpFechaNacimientoDH.SelectedDate) > 0 Then
            If Me.ddlVinculoFamiliar.SelectedItem.Text = "HIJA/O" Then
                If DateDiff(DateInterval.Year, DateValue(Me.rpFechaNacimientoDH.SelectedDate), Now) >= 18 Then
                    Me.PanelDiscapacidad.Visible = True
                    Me.UpdatePanelDiscDH.DataBind()
                Else
                    Me.PanelDiscapacidad.Visible = False
                    Me.UpdatePanelDiscDH.DataBind()
                End If
            End If
        End If
    End Sub

    Protected Sub btnEditarConyuge_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        'Me.ddlVinculoFamiliar.SelectedValue = 
    End Sub


    Protected Sub gvConyuge1_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvConyuge1.RowCreated
        Dim btnEdit As New ImageButton
        btnEdit = e.Row.FindControl("btnEditarConyuge")
        If Not btnEdit Is Nothing Then
            btnEdit.CommandArgument = e.Row.RowIndex
        End If
    End Sub

    Protected Sub btnEliminarConyuge_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btnE As ImageButton = CType(sender, ImageButton)
        Me.dhBL.DeleteDerechoHabiente(idPersonal, btnE.CommandArgument)
    End Sub

    Protected Sub btnEliminarHijoDH_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btnE As ImageButton = CType(sender, ImageButton)
        Me.dhBL.DeleteDerechoHabiente(idPersonal, btnE.CommandArgument)
    End Sub

    Protected Sub btnGrabarSP_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnGrabarSP.Click
        Dim afiliacionSP As New AfiliacionSP
        If Not String.IsNullOrEmpty(txtIdAfiliacionSP.Text) Then
            afiliacionSP.IdAfiliacionSP = Me.txtIdAfiliacionSP.Text
        Else
            afiliacionSP.IdAfiliacionSP = 0
        End If

        afiliacionSP.IdPersonal = idPersonal

        If Me.rcbSP.SelectedIndex > -1 Then
            afiliacionSP.IdSistemaPensiones = rcbSP.SelectedValue
        End If

        If Len(rpFechaAfiliacionSP.SelectedDate) > 0 Then
            afiliacionSP.FechaAfiliacion = DateValue(rpFechaAfiliacionSP.SelectedDate)
        End If

        If Not String.IsNullOrEmpty(Me.txtCUSPP.Text) Then
            afiliacionSP.CUSPP = Me.txtCUSPP.Text
        End If

        ''por verificar
        'afiliacionSP.Estado = True
        Try
            Me.afiliacionSPBL.SaveAFILIACIONSP(afiliacionSP)
            Me.txtCUSPP.Text = ""
            Me.rpFechaAfiliacionSP.Clear()
            Me.gvSP.DataBind()
            Me.RadTabStrip1.SelectedIndex = 2
            Me.RadMultiPage3.SelectedIndex = 2
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub gvSP_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvSP.RowCreated
        Dim btnEditarSP As New ImageButton
        Dim btnEliminarSP As New ImageButton

        btnEditarSP = e.Row.FindControl("btnEditSP")
        btnEliminarSP = e.Row.FindControl("btnEliminarSP")

        If Not btnEditarSP Is Nothing Then
            btnEditarSP.CommandArgument = e.Row.RowIndex
        End If

        If Not btnEliminarSP Is Nothing Then
            btnEliminarSP.CommandArgument = e.Row.RowIndex
        End If
    End Sub

    Protected Sub btnEliminarSP_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Dim btnEliminarSP As ImageButton = CType(sender, ImageButton)
        Dim IdAfiliacionSP As Int32
        Dim IdPersonal As Int32
        Dim IdSistemaPensiones As Int32
        If Not btnEliminarSP Is Nothing Then
            IdAfiliacionSP = Me.gvSP.DataKeys.Item(btnEliminarSP.CommandArgument)("IdAfiliacionSP")
            IdPersonal = Me.gvSP.DataKeys.Item(btnEliminarSP.CommandArgument)("IdPersonal")
            IdSistemaPensiones = Me.gvSP.DataKeys.Item(btnEliminarSP.CommandArgument)("IdSistemaPensiones")
            Me.afiliacionSPBL.DeleteAfiliacionSP(IdAfiliacionSP, IdPersonal, IdSistemaPensiones)
            Me.gvSP.DataBind()
        End If
    End Sub

    Protected Sub ddlTipoSP_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddlTipoSP.SelectedIndexChanged
        Me.rcbSP.ClearSelection()
        Me.rcbSP.Text = ""
    End Sub

    Protected Sub RCBTipoContrato_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.Web.UI.RadComboBoxSelectedIndexChangedEventArgs) Handles RCBTipoContrato.SelectedIndexChanged
        If RCBTipoContrato.SelectedIndex > -1 Then
            If RCBTipoContrato.SelectedValue = 1 Then
                rpFechaFinContrato.Enabled = False
            Else
                rpFechaFinContrato.Enabled = True
            End If
        End If
    End Sub

    Protected Sub lbtnCargarContrato_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbtnCargarContrato.Click


        'Dim cadena_java As String
        'cadena_java = "<script type='text/javascript'> " & _
        '                            " AdjuntarContrato('contrato','" & Me.txtIdPeriodo.Text & "','" & Me.txtIdContrato.Text & "'); " & _
        '                            Chr(60) & "/script>"
        'ScriptManager.RegisterStartupScript(Page, GetType(Page), "Adjuntar", cadena_java.ToString, False)
    End Sub


    Protected Sub gvSP_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvSP.SelectedIndexChanged
        Dim i As Integer = gvSP.SelectedIndex
        Dim IdSistemaPensiones As Int32
        Dim sp As New SistemaDePensiones

        IdSistemaPensiones = Me.gvSP.DataKeys.Item(i)("IdSistemaPensiones")

        sp = spBL.GetSistemaDePensionesByIdSistemaPensiones(IdSistemaPensiones)

        If Not sp Is Nothing Then
            Me.ddlTipoSP.SelectedValue = sp.IdTipoSp
            Me.rcbSP.SelectedValue = sp.IdSistemaPensiones
            Me.rcbSP.Text = sp.Descripcion
        End If

        Me.txtIdAfiliacionSP.Text = Me.gvSP.DataKeys.Item(i)("IdAfiliacionSP")
        Me.txtCUSPP.Text = CType(gvSP.Rows(i).FindControl("lblCuspp"), Label).Text
        Me.rpFechaAfiliacionSP.SelectedDate = CDate(CType(gvSP.Rows(i).FindControl("lblFechaAfiliacion"), Label).Text)

    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCancelar.Click
        Me.txtCUSPP.Text = ""
        Me.rpFechaAfiliacionSP.Clear()

    End Sub

    Protected Sub lbtnRenovar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbtnRenovar.Click
        Me.Response.Redirect("FrmEditarPersonal.aspx?acc=renov")
    End Sub

    Protected Sub btnAbrirCertTS_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrirCertTS.Click
        Dim myFile As ProcessStartInfo
        Dim btn As ImageButton = CType(sender, ImageButton)
        myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\CertificadosTS\" + btn.CommandArgument))
        'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        'Abre archivo
        Process.Start(myFile)
    End Sub

    Protected Sub btnAbrirContrato_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrirContrato.Click
        Dim myFile As ProcessStartInfo
        Dim btn As ImageButton = CType(sender, ImageButton)
        myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\Contratos\" + btn.CommandArgument))
        'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        'Abre archivo
        Process.Start(myFile)
    End Sub

    Protected Sub btnAbrirAdenda1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAbrirAdenda1.Click
        Dim myFile As ProcessStartInfo
        Dim btn As ImageButton = CType(sender, ImageButton)
        myFile = New ProcessStartInfo(Server.MapPath("~\Archivos\RRHH\Contratos\Adendas\" + btn.CommandArgument))
        'myFile = New ProcessStartInfo(Server.MapPath("C:\Inetpub\wwwroot\SistIntegrall\Logistica\ArchivosCotizacion\" + txtNombreArchivo.Text))

        'Abre archivo
        Process.Start(myFile)
    End Sub

    Protected Sub btnCancelarGenerales_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnCancelarGenerales.Click
        Response.Redirect("~\RRHH\Formulario\FrmEditarPersonal.aspx?ficha=0")
    End Sub

    Protected Sub txtApelPaterno_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtApelPaterno.TextChanged

    End Sub
End Class