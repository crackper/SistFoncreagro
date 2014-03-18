<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmEditarPersonal.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmEditarPersonal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function cargarDatos(idRequerimiento, estado) {
            idReq = idRequerimiento;
            esta = estado
        }

        function eliminarFila() {
            //                    var tabla = document.getElementById('tablaRequerimiento');
            //                    tabla.deleteRow(6);
            //                    tabla.deleteRow(7);
        }

        function AdjuntarArchivos() {
            var oWnd = radopen("VentanaSubirFotoyCV.aspx", "VentanaAdjuntar");
            return false;
        }

        function AdjuntarContrato(origen, IdPeriodoLaboral, IdContrato) {
            var oWnd = radopen("VentanaAdjuntarArchivo.aspx?origen=contrato", "VentanaAdjuntarContrato");
            return false;
        }

        function AdjuntarCertificadoTS() {
            var oWnd = radopen("VentanaAdjuntarArchivo.aspx?origen=certificadoTS", "VentanaAdjuntarContrato");
            return false;
        }

        function CambiarCondiciones() {
            var oWnd = radopen("FrmCambioCondicionesContrato.aspx", "CambiarCondiciones");
            return false;
        }

        function CerrarVentana(oWnd, args) {
        var arg = args.get_argument();
        if (arg) {
            if (arg.indicador == 1) {
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("CambioCondiciones");
                 }
             }
        }

        function CerrarRadWindow(oWnd, args) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarPagina");
        }

        function CerrarRadWindow2(oWnd, args) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("ActualizarEnlaces");
        }

        function AsignarHorario() {
            var oWnd = radopen("FrmAsignarHorario.aspx", "AsignarHorario");
            return false;
        }

        function AsignarCC() {
            var oWnd = radopen("FrmAsignarCentroCostoPorPersona.aspx", "AsignarCC");
            return false;
        }

        function RegistrarAusencia() {
            var oWnd = radopen("FrmAusencia.aspx", "RegistrarAusencia");
            return false;
        }

                          
        function nodeClicking(sender, args)
            {
                var comboBox = $find("<%= RadComboBox1.ClientID %>");
                var node = args.get_node()
                comboBox.set_text(node.get_text());
                comboBox.set_value(node.get_value()); 
                comboBox.trackChanges();
                comboBox.get_items().getItem(0).set_text(node.get_text());
                comboBox.get_items().getItem(0).set_value(node.get_value());
                comboBox.commitChanges();
                comboBox.hideDropDown();
//                var treeView = c omboBox2.get_items().getItem(0).findControl("RadTreeView2");
//                var selectedNode = treeView.get_selectedNode();
//                if (selectedNode) {
//                    selectedNode.focus = false
//                }
//                treeView.trackChanges();
//                var node = new Telerik.Web.UI.RadTreeNode();
//                node.set_text("Seleccione Posicion");
//                //Add the new node as the child of the selected node or the treeview if no node is selected
//                var parent = treeView;
//                node.scrollIntoView();

//                parent.get_nodes().add(node);
//                //                treeView.set_selectedNode(node);
//                treeView.commitChanges();
////                return false;

            }
                        
            function StopPropagation(e)
            {
                if(!e)
                {
                    e = window.event;
                }
                e.cancelBubble = true;
            }
            
            function OnClientDropDownOpenedHandler(sender, eventArgs)
            {
                var tree = sender.get_items().getItem(0).findControl("RadTreeView1");
                var selectedNode = tree.get_selectedNode();
                if (selectedNode)
                {
                    selectedNode.scrollIntoView();
                }
            }

           
                // Call comboBox.attachDropDown if:
                // 1) The RadComboBox is inside an AJAX panel.
                // 2) The RadTreeView has a server-side event handler for the NodeClick event, i.e. it initiates a postback when clicking on a Node.
                // Otherwise the AJAX postback becomes a normal postback regardless of the outer AJAX panel.

                //comboBox.attachDropDown();
     </script>

     </telerik:RadCodeBlock>
</head>
<body style="width: 830px; " >
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="ScriptManager1" runat="server" 
        EnableTheming="True">
    </telerik:RadScriptManager>
    <div style="width: 830px">
    
    <table width ="830px" style="background-color: #FFFFFF">
        <tr>
         <td width="15">
         </td>
         <td width="800">
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="RCBNacionalidad">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RCBTipoDI" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="RCBVinculo">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="RCBTipoTrabajador" />
                                <telerik:AjaxUpdatedControl ControlID="RCBTipoContrato" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="RCBTipoContrato">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="rpFechaFinContrato" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="rpFechaInicioContrato">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="rpFechaInicioContrato" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="RadComboBox1">
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="ddlVinculoFamiliar">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="ddlEstadoCivilDH" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="ddlNacionalidadDH">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="ddlTipoDIDH" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="VentanaAdjuntar">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="panelCabecera" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManager>
            </td>
         <td width="15">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15">                                                    
                &nbsp;</td>
            <td width="800">
                <asp:Panel ID="panelCabecera" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <table width="100%">
                                <tr>
                                    <td align="center" rowspan="4" width="110">
                                        &nbsp;<asp:Image ID="foto" runat="server" Height="108px" Width="88px" />
                                    </td>
                                    <td valign="top">
                                        <table width="100%">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblNombre" runat="server" Height="25px" 
                                                        style="font-weight: 700; font-size: medium" Width="100%"></asp:Label>
                                                </td>
                                                <td align="left" valign="middle" width="100">
                                                    <asp:ImageButton ID="btnAbrirCV" runat="server" ImageUrl="~/img/OpenFile.gif" />
                                                    <asp:Label ID="lblAbrirCV" runat="server" 
                                                        style="font-family: Arial; font-size: 9pt" Text="Ver CV"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                        <asp:Label ID="lblArea" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                        <asp:Label ID="lblProyecto" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                        <asp:Label ID="lblCargo" runat="server" 
                                            style="font-weight: 700; font-size: medium" Width="100%">
                                </asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
            </td>
            <td width="15">
                                &nbsp;</td>
         </tr>
         <tr>
            <td width="15">                                                    
                &nbsp;</td>
            <td style="width: 800px">
              <telerik:RadTabStrip ID="RadTabStrip1" runat="server" Height="28px" 
                                Width="100%" SelectedIndex="0"  MultiPageID="RadMultiPage3"
                                 CssClass="tabStrip">
                                <Tabs>
                                    <telerik:RadTab Text="Datos Generales" Selected="True">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Periodo Laboral">
                                    </telerik:RadTab> 
                                    <telerik:RadTab Text="SP - Seguros">
                                    </telerik:RadTab>
                                    <telerik:RadTab Text="Derecho Habientes">
                                    </telerik:RadTab>

                                </Tabs>
                            </telerik:RadTabStrip>
            </td>
            <td width="15">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15">  
            </td>
            <td width ="800">
                <div>
                 <telerik:RadMultiPage ID="RadMultiPage3" runat="server" SelectedIndex="0" 
                                Width="100%">
                                <telerik:RadPageView ID="RPVDatosGenerales0" runat="server" 
                                    CssClass="pageViewEducation" BorderStyle="Solid" 
                                    BorderWidth="1px" Height="100%"><table style="width:100%; font-family: ARIAL; font-size: 9pt;" 
                                        cellpadding ="1" ><tr><td colspan="3" 
                                            
                                            style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #808080" 
                                            valign="top"><table width="100%"><tr><td width="25"><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                        ToolTip="Clic para grabar" /></td><td width="25">
                                                    <asp:ImageButton ID="btnCancelarGenerales" runat="server" 
                                                        CausesValidation="False" Height="24px" ImageUrl="~/img/Cancelar.gif" 
                                                        ToolTip="Clic para registrar nuevo" Width="25px" />
                                                </td><td>&nbsp;</td><td>&nbsp;</td><td width="80"><asp:LinkButton ID="lbtnFoto" runat="server" OnClientClick="return AdjuntarArchivos();">Subir Foto</asp:LinkButton></td><td width="80"><asp:LinkButton ID="lbtnCV" runat="server" OnClientClick="return AdjuntarArchivos();">Subir CV</asp:LinkButton></td></tr></table><asp:ObjectDataSource ID="ODSTipoDocumento" runat="server" 
                                            SelectMethod="GetTipoDocumentoIdentidadByIdNacionalidad" 
                                            TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoIdentidadBL"><SelectParameters><asp:ControlParameter ControlID="RCBNacionalidad" Name="idNacionalidad" 
                                                    PropertyName="SelectedValue" Type="Int32" /></SelectParameters></asp:ObjectDataSource></td></tr><tr><td style="width: 170px; " align="right" valign="top">Nombres:</td><td style="width: 185px" valign="top"><asp:TextBox ID="txtNombre" runat="server" BorderColor="Silver" 
                                                    BorderWidth="1px" Width="150px"></asp:TextBox>&nbsp;&nbsp;
                                            <asp:Label ID="lblValidarNombre" runat="server" ForeColor="Red" 
                                                Text="Debe ingresar nombre" Visible="False"></asp:Label>
                                            </td><td rowspan="12" style="vertical-align:top;"><div><table style="border-style: solid; border-width: 1px" width="100%"><tr><td width="6">&nbsp;</td><td width="110"><strong>Personales:</strong></td><td>&nbsp;</td></tr><tr><td align="right" width="6">&nbsp;</td><td align="right" width="110">Teléfono:</td><td><asp:TextBox ID="txtTelPersonal" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="210px"></asp:TextBox></td></tr><tr><td align="right" width="6">&nbsp;</td><td align="right" width="110">Celular:</td><td><asp:TextBox ID="txtCelPersonal" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="210px"></asp:TextBox></td></tr><tr><td align="right" width="6">&nbsp;</td><td align="right" width="110">Email:</td><td><asp:TextBox ID="txtEmailPersonal" runat="server" Height="40px" 
                                                                    TextMode="MultiLine" Width="220px"></asp:TextBox></td></tr><tr><td width="6">&nbsp;</td><td width="110">&nbsp;</td><td>&nbsp;</td></tr><tr><td width="6">&nbsp;</td><td colspan="2"><asp:Panel ID="Panel1" runat="server"><table class="style7"><tr><td style="font-family: arial; font-size: 9pt; font-weight: 700" width="100">Coorporativos:</td><td>
                                                <asp:LinkButton ID="r" runat="server" Visible="False">Asignar Celular</asp:LinkButton>
                                                </td></tr><tr><td style="text-align: right" width="100">Teléfono/Cel:</td><td><asp:TextBox ID="txtTelCoorporativo" runat="server" BorderColor="Silver" 
                                                                                    BorderWidth="1px" Width="210px"></asp:TextBox></td></tr><tr><td style="text-align: right" width="100">
                                                    &nbsp;</td><td style="text-align: right">&nbsp;</td></tr><tr><td align="right" colspan="2">&#160;&#160; 
                                                <asp:GridView ID="GridView2" runat="server" Width="280px" Visible="False"></asp:GridView></td></tr><tr><td style="text-align: right" valign="top" width="100">Email:</td><td>
                                                <telerik:RadTextBox ID="RtxtEmailCoorporativo" Runat="server" Height="40px" 
                                                                                    Skin="Default" TextMode="MultiLine" 
                                                    Width="250px" Visible="False"></telerik:RadTextBox></td></tr><tr><td style="text-align: right" valign="top" width="100">Fotocheck:</td><td><asp:TextBox ID="txtFotocheck" runat="server" BorderColor="Silver" 
                                                                                    BorderWidth="1px" Width="150px"></asp:TextBox></td></tr></table></asp:Panel></td></tr></table></div><br><div><table style="border-style: solid; border-width: 1px" width="100%"><tr><td align="right" style="width: 7px">&nbsp;</td><td align="right" class="style4" colspan="2">
                                                    <asp:UpdatePanel ID="UpdateCertificadoTS" runat="server">
                                                        <ContentTemplate>
                                                            <table class="style7">
                                                                <tr>
                                                                    <td width="100">
                                                                        Tipo de Sangre:</td>
                                                                    <td width="105">
                                                                        <asp:TextBox ID="txtTipoSangre" runat="server" BorderColor="Silver" 
                                                                            BorderWidth="1px" Width="100px"></asp:TextBox>
                                                                    </td>
                                                                    <td align="left" width="120">
                                                                        <asp:LinkButton ID="lbtnAdjuntarCerTS" runat="server" 
                                                                            OnClientClick="return AdjuntarCertificadoTS();" Visible="False">Adjuntar Certificado</asp:LinkButton>
                                                                    </td>
                                                                    <td align="left">
                                                                        <asp:ImageButton ID="btnAbrirCertTS" runat="server" 
                                                                            ImageUrl="~/img/OpenFile.gif" Visible="False" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                    </td></tr><tr><td align="right" style="width: 7px">&nbsp;</td><td align="right" class="style5">
                                                        &nbsp;</td><td class="style6">&nbsp;</td></tr><tr><td align="left" style="font-weight: 700; width: 7px">&nbsp;</td><td align="left" colspan="2" style="font-weight: 700">Persona de contacto en caso de emergencia:</td></tr><tr><td align="right" style="width: 7px">&nbsp;</td><td align="right" class="style5">Nombre:</td><td class="style6"><asp:TextBox ID="txtNombreContacto" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="250px"></asp:TextBox>&nbsp;</td></tr><tr><td align="right" style="width: 7px">&nbsp;</td><td align="right" class="style5">Telefono:</td><td class="style6"><asp:TextBox ID="txtTelContacto" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="250px"></asp:TextBox></td></tr><tr><td align="right" style="width: 7px">&nbsp;</td><td align="right" class="style5">&nbsp;</td><td class="style6">&nbsp;</td></tr></table></div></td></tr><tr><td align="right" style="width: 170px; " valign="top">Apellido Paterno:</td><td style="width: 185px" valign="top"><asp:TextBox ID="txtApelPaterno" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="150px"></asp:TextBox>&nbsp;
                                        <asp:Label ID="lblValidarApePat" runat="server" ForeColor="Red" 
                                            Text="Debe ingresar apellido" Visible="False"></asp:Label>
                                        </td></tr><tr><td align="right" style="width: 170px; " valign="top">Apellido Materno:</td><td style="width: 185px" valign="top"><asp:TextBox ID="txtApelMaterno" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="150px"></asp:TextBox>&nbsp;
                                            <asp:Label ID="lblValidarApeMat" runat="server" ForeColor="Red" 
                                                Text="Debe ingresar el apellido" Visible="False"></asp:Label>
                                            </td></tr><tr><td align="right" style="width: 170px; " valign="top">Nacionalidad:</td><td style="width: 185px" valign="top"><telerik:RadComboBox ID="RCBNacionalidad" Runat="server" AccessibilityMode="True" 
                                                    AllowCustomText="True" DataSourceID="ODSNacionalidad" 
                                                    DataTextField="Nacionalidad" DataValueField="IdNacionalidad" 
                                                    MarkFirstMatch="True" Skin="Sunset" Width="150px" AutoPostBack="True"></telerik:RadComboBox></td></tr><tr><td class="boton" colspan="2" valign="top"><table cellpadding="0" cellspacing="0" class="tabla4"><tr><td width="170" align="right" valign="top"><telerik:RadComboBox ID="RCBTipoDI" Runat="server" 
                                                                    DataSourceID="ODSTipoDocumento" Skin="Sunset" Width="150px" 
                                                                    DataTextField="Descripcion" DataValueField="IdTipoDI"></telerik:RadComboBox></td><td style="color: #000000" width="20">N°:</td><td width="105" valign="top"><asp:TextBox ID="txtNroDI" runat="server" BorderColor="Silver" 
                                                                    BorderWidth="1px" Width="100px"></asp:TextBox></td></tr></table></td></tr><tr><td align="right" style="width: 170px; " 
                                                    valign="top">Direccion:</td><td style="width: 185px" valign="top"><telerik:RadTextBox ID="RtxtDireccion" Runat="server" Height="50px" Skin="Default" 
                                                        TextMode="MultiLine" Width="150px"></telerik:RadTextBox></td></tr><tr><td align="right" style="width: 170px; " 
                                                    valign="top">Fecha de Nacimiento:</td><td style="width: 185px" valign="top"><telerik:RadDatePicker ID="rpFechaNacimiento" Runat="server" Culture="es-PE" 
                                                        Width="150px" MinDate="1950-01-01"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                            ViewSelectorText="x"></Calendar><DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker></td></tr><tr><td align="right" style="width: 170px; " 
                                                    valign="top">Lugar de Nacimiento:</td><td style="width: 185px" valign="top"><asp:TextBox ID="txtLugarNacimiento" runat="server" BorderColor="Silver" 
                                                        BorderWidth="1px" Width="150px"></asp:TextBox></td></tr><tr><td align="right" style="width: 170px; " 
                                                    valign="top">Genero:</td><td style="width: 185px" valign="top"><telerik:RadComboBox ID="RCBGenero" Runat="server" Skin="Sunset" 
                                                        Width="150px"><Items>
                                                    <telerik:RadComboBoxItem runat="server" Text="Seleccione" Value="-1" />
                                                    <telerik:RadComboBoxItem runat="server" Text="FEMENINO" Value="F" 
                                                                Owner="RCBGenero" /><telerik:RadComboBoxItem runat="server" Text="MASCULINO" Value="M" 
                                                                Owner="RCBGenero" /></Items></telerik:RadComboBox></td></tr><tr><td align="right" style="width: 170px; " 
                                                    valign="top">Estado Civil:</td><td style="width: 185px" valign="top"><telerik:RadComboBox ID="RCBEstadoCivil" Runat="server" 
                                                        AppendDataBoundItems="True" Skin="Sunset" Width="150px"><Items>
                                                    <telerik:RadComboBoxItem runat="server" Text="Seleccione" Value="-1" />
                                                    <telerik:RadComboBoxItem runat="server" Text="SOLTERO(A)" Value="SOLTERO(A)" 
                                                                Owner="RCBEstadoCivil" /><telerik:RadComboBoxItem runat="server" Text="CASADO(A)" Value="CASADO(A)" 
                                                                Owner="RCBEstadoCivil" /><telerik:RadComboBoxItem runat="server" Text="CONVIVIENTE" 
                                                                Value="CONVIVIENTE" Owner="RCBEstadoCivil" /></Items></telerik:RadComboBox>&nbsp;</td></tr><tr><td align="right" style="width: 170px; " 
                                                    valign="top">Lic. Conducir:</td><td style="width: 185px" valign="top"><asp:TextBox ID="txtLicConducir" runat="server" Width="150px" 
                                                        BorderColor="Silver" BorderWidth="1px"></asp:TextBox></td></tr><tr><td align="right" 
                                                    valign="top" colspan="2"><table class="style9"><tr><td style="font-family: arial; font-size: 9pt" valign="top" width="100">Nivel Educativo:</td><td valign="top"><telerik:RadComboBox ID="RCBNivelEducativo" Runat="server" 
                                                                    AllowCustomText="True" DataSourceID="ODSNivelEducativo" 
                                                                    DataTextField="Descripcion" DataValueField="IdNivelEducativo" Skin="Sunset" 
                                                                    Width="250px"></telerik:RadComboBox><asp:ObjectDataSource ID="ODSNivelEducativo" runat="server" 
                                                                    SelectMethod="GetAllFromNivelEducativo" 
                                                                    TypeName="SistFoncreagro.BussinesLogic.NivelEducativoBL"></asp:ObjectDataSource></td></tr></table></td></tr><tr><td align="center" valign="top" colspan="3"><asp:ObjectDataSource 
                                                    ID="ODSNacionalidad" runat="server" SelectMethod="GetAllFromNacionalidad" 
                                                    TypeName="SistFoncreagro.BussinesLogic.NacionalidadBL"></asp:ObjectDataSource></td></tr><tr><td align="right" valign="top" bgcolor="#F4F4F4" colspan="3">&nbsp;</td></tr></table></telerik:RadPageView>

                                <telerik:RadPageView ID="RadPageView9" runat="server"  
                                    cssClass= "pageview1" 
                                    Height="100%" BorderWidth="1px">
                                    <table style="width:100%; font-size: 9pt; font-family: arial;"><tr><td style="width: 3px">&nbsp;</td><td><table width="100%"><tr><td width="25"><asp:ImageButton ID="btnGrabarPeriodo" runat="server" 
                                                                ImageUrl="~/img/Grabar.gif" ToolTip="Clic para grabar" /></td>
                                        <td width="50">
                                            <asp:ImageButton ID="btnCancelarNuevo" runat="server" CausesValidation="False" 
                                                                ImageUrl="~/img/Cancelar.gif" 
                                                ToolTip="Clic para registrar nuevo" Visible="False" Height="24px" 
                                                Width="25px" />
                                            <asp:ImageButton ID="btnNuevoPeriodo" runat="server" CausesValidation="False" 
                                                ImageUrl="~/img/Nuevo.gif" ToolTip="Clic para registrar nuevo" 
                                                Visible="False" />
                                        </td><td width="25">&nbsp;</td><td><asp:TextBox ID="txtIdPeriodo" runat="server" Height="16px" Width="20px" 
                                                                Visible="False"></asp:TextBox></td><td>&nbsp;</td><td width="80"><asp:LinkButton ID="lbtnFoto0" runat="server" 
                                                                OnClientClick="return AdjuntarArchivos();">Subir Foto</asp:LinkButton></td><td width="80"><asp:LinkButton ID="lbtnCV0" runat="server" 
                                                                OnClientClick="return AdjuntarArchivos();">Subir CV</asp:LinkButton></td></tr></table></td></tr><tr><td style="width: 3px">&nbsp;</td><td><table class="tabla4" style="border-width: 1px; border-style: solid" 
                                                    width="100%"><tr><td colspan="2" width="265"><strong>Periodo Laboral:</strong></td><td width="130"><asp:TextBox ID="txtNuevo" runat="server" Width="50px" Visible="False"></asp:TextBox></td><td width="20">&nbsp;</td><td>&nbsp;</td></tr><tr>
                                            <td style="width: 115px" align="right" valign="top">Fecha de Ingreso:</td><td width="150"><telerik:RadDatePicker ID="rpFechaIngreso" Runat="server" Culture="es-PE" 
                                                                Width="100%" AutoPostBack="True"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                    ViewSelectorText="x"></Calendar><DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy" 
                                                                    AutoPostBack="True"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker>
                                            <asp:Label ID="lblValidarFI" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                                            </td><td width="130"><asp:TextBox ID="txtUltFechaCese" runat="server" Visible="False"></asp:TextBox></td><td width="20">&nbsp;</td><td>
                                            &nbsp;</td></tr><tr><td style="width: 115px" align="right" valign="top">Fecha de Cese:</td><td width="150"><telerik:RadDatePicker ID="rpFechaCese" Runat="server" Culture="es-PE" 
                                                                Width="100%"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                    ViewSelectorText="x"></Calendar><DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker></td><td width="130">&nbsp;</td><td width="20">&nbsp;</td><td>&nbsp;</td></tr><tr><td style="width: 115px" align="right">Vinculo:</td><td colspan="3"><telerik:RadComboBox ID="RCBVinculo" Runat="server" AllowCustomText="True" 
                                                                Skin="Sunset" Width="250px" DataSourceID="ODSCategoriaRRHH" 
                                                                AutoPostBack="True" DataTextField="Nombre" DataValueField="IdCategoria" 
                                                                Filter="Contains"></telerik:RadComboBox><asp:ObjectDataSource ID="ODSCategoriaRRHH" runat="server" 
                                                                SelectMethod="GetAllFromCategoriaRrhh" 
                                                                TypeName="SistFoncreagro.BussinesLogic.CategoriaRrhhBL"></asp:ObjectDataSource>
                                            <asp:Label ID="lblValidarVinculo" runat="server" ForeColor="Red" 
                                                Visible="False"></asp:Label>
                                            </td><td rowspan="2"><asp:RadioButtonList ID="rblSituacionEspecial" runat="server" 
                                                                DataSourceID="ODSSitEs" DataTextField="Descripcion" 
                                                                DataValueField="IdSituacionEspecial"><asp:ListItem Value="1">Personal De Confianza</asp:ListItem></asp:RadioButtonList><asp:ObjectDataSource ID="ODSSitEs" runat="server" 
                                                                SelectMethod="GetAllSituacionEspecial" 
                                                                TypeName="SistFoncreagro.BussinesLogic.SituacionEspecialBL"></asp:ObjectDataSource></td></tr><tr><td style="width: 115px" align="right">Tipo Trabajador:</td><td colspan="3"><telerik:RadComboBox ID="RCBTipoTrabajador" Runat="server" AllowCustomText="True" 
                                                                Skin="Sunset" Width="250px" DataSourceID="ODSTipoTrabajador" 
                                                                DataTextField="Descripcion" DataValueField="IdTipoTrabajador"></telerik:RadComboBox><asp:ObjectDataSource ID="ODSTipoTrabajador" runat="server" 
                                                                SelectMethod="GetTipoTrabajadorByIdCategoriaYDisponibles" 
                                                                TypeName="SistFoncreagro.BussinesLogic.TipoTrabajadorBL"><SelectParameters><asp:ControlParameter ControlID="RCBVinculo" DefaultValue="" Name="idCategoria" 
                                                                        PropertyName="SelectedValue" Type="Int32" /><asp:Parameter DefaultValue="true" Name="disponible" Type="Boolean" /></SelectParameters></asp:ObjectDataSource>
                                                <asp:Label ID="lblValidarTrabajador" runat="server" ForeColor="Red" 
                                                    Visible="False"></asp:Label>
                                                </td></tr></table></td></tr><tr><td style="width: 3px">&nbsp;</td><td>&nbsp;</td></tr><tr><td style="width: 3px">&nbsp;</td><td><table style="border-style: solid; border-width: 1px" 
                                                    width="100%">
                                            <tr>
                                            <td>
                                            <table width="100%">
                                            <tr>
                                            <td width="150"><strong>Contrato Actual:</strong>
                                            </td>
                                            <td width="110"><asp:TextBox ID="txtIdContrato" runat="server" Height="15px" Width="20px" 
                                                                            Visible="False"></asp:TextBox><asp:TextBox ID="txtIdCorrelativo" runat="server" Height="15px" Width="20px" 
                                                                            Visible="False"></asp:TextBox>
                                                <asp:TextBox ID="txtNroCorrelativo" runat="server" Height="15px" Width="62px" 
                                                                            Visible="False"></asp:TextBox>
                                            </td>
                                            <td width="115">
                                                <asp:LinkButton ID="lbtnCargarContrato" runat="server" 
                                                    OnClientClick="return AdjuntarContrato();">Adjuntar Contrato</asp:LinkButton>
                                            </td>
                                            <td width="30">
                                                <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                                    <ContentTemplate>
                                                        <asp:ImageButton ID="btnAbrirContrato" runat="server" 
                                                            ImageUrl="~/img/OpenFile.gif" Visible="False" />
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </td>
                                                <td>
                                                    <asp:LinkButton ID="lbtnRenovar" runat="server">Renovar</asp:LinkButton>
                                                </td>
                                            <td rowspan="2"><asp:Panel ID="PanelBtn" runat="server"><table width="100%" 
                                                                                style="border-style: Solid solid Solid solid; border-width: 1px; border-color: #C0C0C0;"><tr valign="bottom"><td align="center" valign="middle" width="90"><asp:ImageButton ID="btnHorario" runat="server" Height="23px" 
                                                                                            ImageUrl="~/img/Calendario.gif" Width="22px" OnClientClick="return AsignarHorario();"/></td><td align="center" valign="middle" width="70"><asp:ImageButton ID="ImageButton8" runat="server" 
                                                                                            ImageUrl="~/img/imgDineroP1.png" OnClientClick="return AsignarCC();" /></td><td align="center" valign="middle" width="70"><asp:ImageButton ID="btnRoles" runat="server" ImageUrl="~/img/empleado.gif" /></td><td align="center" valign="middle" width="70" OnClientClick="return RegistrarAusencia();" /><asp:ImageButton ID="btnAusencia" runat="server" ImageUrl="~/img/Rendir.gif" /></td>
                                            <td>&#160;
                                            </td>
                                            </tr>
                                            <tr>
                                            <td align="center" valign="top" width="90"><asp:LinkButton ID="lbtnasignarHorario" runat="server" 
                                                                                            OnClientClick="return AsignarHorario();" CssClass="style11" Font-Size="Smaller">Asignar Horario</asp:LinkButton>
                                            </td>
                                            <td align="center" valign="top" width="70"><asp:LinkButton ID="lbtnAsignarCC" runat="server" 
                                                                                            OnClientClick="return AsignarCC();" CssClass="style11" Font-Size="Smaller">AsignarCC</asp:LinkButton>
                                            
                                            </td>
                                            <td align="center" valign="top" width="70"><asp:LinkButton ID="lbtnRoles" runat="server" CssClass="style11" 
                                                                                            Font-Size="Smaller">Roles</asp:LinkButton>
                                            </td>
                                            <td align="center" valign="top" width="70"><asp:LinkButton ID="lbtnVacaciones" runat="server" 
                                                                                            OnClientClick="return RegistrarAusencia();" CssClass="style11" 
                                                                                            Font-Size="Smaller">Vacaciones</asp:LinkButton></td><td>&#160;</td></tr></table></asp:Panel></td></tr><tr><td align="right" width="150" valign="top">Nro. Contrato:</td><td width="110" valign="top"><asp:TextBox ID="txtNroContrato" runat="server" Width="105px"></asp:TextBox></td>
                                            <td width="115" valign="top">
                                                <asp:DropDownList ID="ddlRenovacion" runat="server" Width="110px" 
                                                    Enabled="False">
                                                    <asp:ListItem Selected="True" Value="-1">Seleccionar</asp:ListItem>
                                                    <asp:ListItem Value="0">Nuevo</asp:ListItem>
                                                    <asp:ListItem Value="1">Renovación</asp:ListItem>
                                                </asp:DropDownList>
                                            </td><td valign="top" width="30">&nbsp;</td>
                                                <td valign="top">
                                                    <asp:TextBox ID="txtEstado" runat="server" Width="20px" Visible="False"></asp:TextBox>
                                                </td>
                                                </tr><tr><td align="right" width="150" valign="top">Modalidad:</td><td colspan="4" 
                                                        valign="top"><telerik:RadComboBox ID="RCBTipoContrato" Runat="server" 
                                                                            AllowCustomText="True" DataSourceID="ODSTipoOCntrato0" 
                                                                            DataTextField="Descripcion" DataValueField="IdTipoContrato" Skin="Sunset" 
                                                                            Width="340px" Filter="Contains" AutoPostBack="True"></telerik:RadComboBox><asp:ObjectDataSource ID="ODSTipoOCntrato0" runat="server" 
                                                                            SelectMethod="GetTipoContratoByIdCategoria" 
                                                                            TypeName="SistFoncreagro.BussinesLogic.TipoContratoBL"><SelectParameters><asp:ControlParameter ControlID="RCBVinculo" Name="idCategoria" 
                                                                                    PropertyName="SelectedValue" Type="Int32" /></SelectParameters></asp:ObjectDataSource>
                                                    <asp:Label ID="lblValidarModalidad" runat="server" ForeColor="Red" 
                                                        Visible="False"></asp:Label>
                                                    </td><td valign="top">
                                                        &nbsp;</td></tr><tr><td align="right" width="150" valign="top">Grupo Ocupacional:</td>
                                                    <td colspan="4" valign="top"><telerik:RadComboBox ID="RCBGrupoOcupacional" Runat="server" 
                                                                            AllowCustomText="True" Skin="Sunset" Width="340px" 
                                                                            DataSourceID="ODSGrupoOcupacional" DataTextField="CodigoDescripcion" 
                                                                            DataValueField="IdGrupoOcupacional" Filter="Contains"></telerik:RadComboBox><asp:ObjectDataSource ID="ODSGrupoOcupacional" runat="server" 
                                                                            SelectMethod="GetGrupoOcupacionalByDisponible" 
                                                                            TypeName="SistFoncreagro.BussinesLogic.GrupoOcupacionalBL"></asp:ObjectDataSource></td><td valign="top">&nbsp;</td></tr><tr><td align="right" width="150" valign="top">Fecha de Inicio:</td><td colspan="2" style="width: 140px" width="110" valign="top"><telerik:RadDatePicker ID="rpFechaInicioContrato" Runat="server" Culture="es-PE" 
                                                                            Width="140px" AutoPostBack="True" style="color: #000000"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                ViewSelectorText="x"></Calendar><DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy" 
                                                                                AutoPostBack="True"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker>
                                                <asp:Label ID="lblValidarFechaIniC" runat="server" ForeColor="Red" 
                                                    Visible="False"></asp:Label>
                                                </td><td valign="top">
                                                    &nbsp;</td>
                                                <td valign="top">
                                                    <asp:TextBox ID="txtUltFechaFinContrato" runat="server" Visible="False" 
                                                        Width="50px"></asp:TextBox>
                                                </td>
                                                <td valign="top">&nbsp;</td></tr><tr><td align="right" valign="top" width="150">&nbsp;</td><td colspan="2" style="width: 140px" valign="top" width="110">&nbsp;</td><td valign="top">&nbsp;</td>
                                                <td valign="top">
                                                    &nbsp;</td>
                                                <td valign="top">&nbsp;</td></tr></table></td></tr><tr><td>&nbsp;</td></tr><tr><td><table width="100%"><tr><td colspan="2" style="width: 240px" width="300"><strong>Condiciones Actuales del Contrato:</strong></td>
                                            <td width="100">
                                        <asp:LinkButton ID="lbtnCargarAdemda" runat="server" Visible="False">Subir Adenda</asp:LinkButton></td>
                                            <td width="30">
                                                &nbsp;</td>
                                            <td width="200">
                                        <asp:LinkButton ID="lbtnCambiarCond" runat="server" OnClientClick="return CambiarCondiciones();">Cambiar Condiciones</asp:LinkButton>
                                        </td><td>
                                            <asp:TextBox ID="txtCondicionCambio" runat="server" Height="15px" 
                                                Visible="False" Width="20px"></asp:TextBox>
                                            <asp:TextBox ID="txtIdCondicion" runat="server" Height="15px" Visible="False" 
                                                Width="20px"></asp:TextBox>
                                        </td></tr><tr><td align="right" width="150">Fecha de Fin:</td><td width="150"><telerik:RadDatePicker ID="rpFechaFinContrato" Runat="server" Culture="es-PE" 
                                                                            Width="100%"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                ViewSelectorText="x"></Calendar><DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker>
                                                <asp:Label ID="lblValidarFechaFC" runat="server" ForeColor="Red" 
                                                    Visible="False"></asp:Label>
                                                </td>
                                                <td width="100">&nbsp;&nbsp;<asp:LinkButton ID="lbtnFechaFinContrato" runat="server" Visible="False">NroAdenda</asp:LinkButton></td>
                                                <td width="30">
                                                    <asp:ImageButton ID="btnAbrirAdenda1" runat="server" 
                                                        ImageUrl="~/img/OpenFile.gif" Visible="False" />
                                                </td>
                                                <td width="200">&nbsp;</td><td><asp:TextBox ID="txtUltFechaCamCond" runat="server" Width="90%" Visible="False"></asp:TextBox></td></tr><tr><td align="right" width="150">Sueldo Bruto: </td><td width="150"><asp:TextBox ID="txtSueldo" runat="server" Width="100%"></asp:TextBox></td>
                                            <td width="100">&nbsp;&nbsp;<asp:LinkButton ID="lbtnSueldoBruto" runat="server" Visible="False">NroAdenda</asp:LinkButton></td>
                                            <td width="30">
                                                <asp:ImageButton ID="btnAbrirAdenda2" runat="server" 
                                                    ImageUrl="~/img/OpenFile.gif" Visible="False" />
                                            </td>
                                            <td width="200">
                                                <asp:Label ID="lblAsignacion" runat="server" Width="98%"></asp:Label>
                                            </td><td>&nbsp;</td></tr><tr><td align="right" width="150">Fecha de Cambio:</td><td width="150"><asp:Label ID="lblFechaCambio" runat="server" Width="120px"></asp:Label></td>
                                            <td width="100">&nbsp;</td>
                                            <td width="30">
                                                <asp:ImageButton ID="btnAbrirAdenda3" runat="server" 
                                                    ImageUrl="~/img/OpenFile.gif" Visible="False" />
                                            </td>
                                            <td width="200">&nbsp;</td><td>&nbsp;</td></tr></table></td></tr><tr><td>&nbsp;</td></tr><tr><td><table width="100%"><tr><td align="right" width="150" valign="top">Area (organigrama):</td><td width="300" valign="top"><telerik:RadComboBox ID="RadComboBox1" runat="server" Width="290px"
                                                                            ShowToggleImage="True" Style="vertical-align: middle;" OnClientDropDownOpened="OnClientDropDownOpenedHandler"
                                                                            EmptyMessage="Elige el área" ExpandAnimation-Type="None" 
                                                                            CollapseAnimation-Type="None" AutoPostBack="True"><Items><telerik:RadComboBoxItem Text="" /></Items><ItemTemplate><div ID="div1"><telerik:RadTreeView ID="RadTreeView1" runat="server" DataFieldID="IdArea" 
                                                                                        DataFieldParentID="Dependencia" DataSourceID="ObjectDataSource1" 
                                                                                        DataTextField="Nombre" DataValueField="IdArea" Height="250px" 
                                                                                        OnClientNodeClicking="nodeClicking"  
                                                                                        Width="100%" onnodeclick="RadTreeView1_NodeClick1"><DataBindings><telerik:RadTreeNodeBinding Expanded="true" /></DataBindings></telerik:RadTreeView></div></ItemTemplate><ExpandAnimation Type="None" /><CollapseAnimation Type="None" /></telerik:RadComboBox><asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                                                                            SelectMethod="GetAllFromArea2" TypeName="SistFoncreagro.BussinesLogic.AreaBL"></asp:ObjectDataSource></td><td valign="top"><asp:TextBox ID="txtIdArea" runat="server" Width="40px" Visible="False"></asp:TextBox></td><td>&nbsp;</td></tr><tr><td align="right" width="150" valign="top">Cargo (Posición):</td><td width="300" valign="top"><asp:UpdatePanel ID="UpdatePanel2" runat="server"><ContentTemplate><asp:DropDownList ID="ddlPosicion" runat="server" 
                                                                                    DataSourceID="ObjectDataSource2" DataTextField="NomCargo" 
                                                                                    DataValueField="IdPosicion" style="font-family: arial; font-size: 9pt" 
                                                                                    Width="290px"></asp:DropDownList><asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                                                                                    SelectMethod="GetPosicionByIdArea2" 
                                                                                    TypeName="SistFoncreagro.BussinesLogic.PosicionBL"><SelectParameters><asp:ControlParameter ControlID="RadComboBox1" Name="IdArea" 
                                                                                            PropertyName="SelectedValue" Type="Int32" /></SelectParameters></asp:ObjectDataSource></ContentTemplate></asp:UpdatePanel></td><td valign="top">
                                                <asp:ImageButton ID="btnAbrirAdenda4" runat="server" 
                                                    ImageUrl="~/img/OpenFile.gif" Visible="False" />
                                            </td><td>&nbsp;</td></tr></table></td></tr></table>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
         </td>
         </tr>
         </table>
         </telerik:RadPageView>
                                
          <telerik:RadPageView ID="RadPageView10" runat="server" Height="100%" 
                                    BorderStyle="Solid" BorderWidth="1px">
                                    <table style="font-family: Arial; font-size: 9pt" width="100%"><tr><td width="10">&nbsp;</td><td><asp:UpdatePanel ID="UpdatePanel4" runat="server"><ContentTemplate><asp:GridView ID="gvSP" runat="server" AutoGenerateColumns="False" 
                                                            DataSourceID="ODSAfiliacionesS" 
                                                            DataKeyNames="IdAfiliacionSP,IdPersonal,IdSistemaPensiones"><Columns>
                                                            <asp:TemplateField><ItemTemplate><asp:ImageButton 
                                            ID="btnEditSP" runat="server" ImageUrl="~/img/Edit.gif" CommandName="Select" /></ItemTemplate>
                                            <HeaderStyle Width="30px" />
                                            <ItemStyle HorizontalAlign="Center" Width="30px" />
                                            </asp:TemplateField>

                                            <asp:TemplateField><ItemTemplate><asp:ImageButton ID="btnEliminarSP" runat="server" 
                                                    onclick="btnEliminarSP_Click" ImageUrl="~/img/Delete.gif" /></ItemTemplate><HeaderStyle Width="30px" /><ItemStyle HorizontalAlign="Center" Width="30px" /></asp:TemplateField><asp:TemplateField 
                                            HeaderText="IdAfiliacionSP" SortExpression="IdAfiliacionSP" Visible="False"><ItemTemplate><asp:Label 
                                                    ID="Label1" runat="server" Text='<%# Bind("IdAfiliacionSP") %>'></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox 
                                                    ID="TextBox1" runat="server" Text='<%# Bind("IdAfiliacionSP") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField><asp:TemplateField 
                                            HeaderText="IdPersonal" SortExpression="IdPersonal" Visible="False"><ItemTemplate><asp:Label 
                                                    ID="Label2" runat="server" Text='<%# Bind("IdPersonal") %>'></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox 
                                                    ID="TextBox2" runat="server" Text='<%# Bind("IdPersonal") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField><asp:TemplateField 
                                            HeaderText="IdSistemaPensiones" SortExpression="IdSistemaPensiones" 
                                            Visible="False"><ItemTemplate><asp:Label ID="Label3" runat="server" 
                                                    Text='<%# Bind("IdSistemaPensiones") %>'></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox 
                                                    ID="TextBox3" runat="server" Text='<%# Bind("IdSistemaPensiones") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField>
                                                            <asp:BoundField DataField="NombreSP" HeaderText="NombreSP" 
                                                                SortExpression="NombreSP"></asp:BoundField>
                                                            <asp:TemplateField 
                                            HeaderText="FechaAfiliacion" SortExpression="FechaAfiliacion"><ItemTemplate>
                                                                    <asp:Label 
                                                    ID="lblFechaAfiliacion" runat="server" 
                                                    Text='<%# Bind("FechaAfiliacion", "{0:dd-M-yyyy}") %>'></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox 
                                                    ID="TextBox4" runat="server" Text='<%# Bind("FechaAfiliacion") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField><asp:TemplateField 
                                            HeaderText="CUSPP" SortExpression="CUSPP"><ItemTemplate><asp:Label ID="lblCuspp" 
                                                    runat="server" Text='<%# Bind("CUSPP") %>'></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox 
                                                    ID="TextBox5" runat="server" Text='<%# Bind("CUSPP") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField><asp:CheckBoxField DataField="Estado" HeaderText="Estado" 
                                                                    SortExpression="Estado" /></Columns></asp:GridView><asp:ObjectDataSource ID="ODSAfiliacionesS" runat="server" 
                                                            SelectMethod="GetAFILIACIONSPByIdPersonal" 
                                                            TypeName="SistFoncreagro.BussinesLogic.AfiliacionSPBL"><SelectParameters><asp:SessionParameter Name="IdPersonal" SessionField="IdPersonal" 
                                                                    Type="Int32" /></SelectParameters></asp:ObjectDataSource></ContentTemplate></asp:UpdatePanel></td><td width="10">&nbsp;</td></tr><tr><td width="10">&nbsp;</td>
                                        <td>&nbsp;</td><td width="10">&nbsp;</td></tr>
                                        <tr>
                                            <td width="10">
                                                &nbsp;</td>
                                            <td valign="top">
                                                <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                                                    <ContentTemplate>
                                                        <asp:Panel ID="Panel5" runat="server" Height="500px">
                                                            <table style="border: 1px solid #C0C0C0" width="100%">
                                                                <tr>
                                                                    <td style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0" 
                                                                        width="140">
                                                                        <asp:ImageButton ID="btnGrabarSP" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                            ToolTip="Clic para grabar" />
                                                                        &nbsp;<asp:ImageButton ID="btnCancelar" runat="server" Height="25px" 
                                                                            ImageUrl="~/img/Cancelar.gif" Width="25px" />
                                                                    </td>
                                                                    <td style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0" 
                                                                        width="280">
                                                                        &nbsp;</td>
                                                                    <td style="border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #C0C0C0">
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style10" valign="top" width="140">
                                                                        &nbsp;</td>
                                                                    <td align="left" valign="top" width="280">
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style10" valign="top" width="140">
                                                                        Tipo de sistema:</td>
                                                                    <td align="left" valign="top" width="280">
                                                                        <asp:DropDownList ID="ddlTipoSP" runat="server" AutoPostBack="True" 
                                                                            DataSourceID="ODSTipoSP" DataTextField="Tipo" DataValueField="IdTipoSP" 
                                                                            Width="100%">
                                                                        </asp:DropDownList>
                                                                        <asp:ObjectDataSource ID="ODSTipoSP" runat="server" 
                                                                            SelectMethod="GetAllFromTipoSp" 
                                                                            TypeName="SistFoncreagro.BussinesLogic.TipoSpBL"></asp:ObjectDataSource>
                                                                    </td>
                                                                    <td>
                                                                        <asp:TextBox ID="txtIdAfiliacionSP" runat="server" Visible="False" Width="20px"></asp:TextBox>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style10" valign="top" width="140">
                                                                        Sistema de Pensiones:</td>
                                                                    <td align="left" valign="top" width="280">
                                                                        <asp:ObjectDataSource ID="ODSSP" runat="server" 
                                                                            SelectMethod="GetAllFromSistemaPensionesByTipoSp" 
                                                                            TypeName="SistFoncreagro.BussinesLogic.SistemaDePensionesBL">
                                                                            <SelectParameters>
                                                                                <asp:ControlParameter ControlID="ddlTipoSP" Name="idTipoSp" 
                                                                                    PropertyName="SelectedValue" Type="Int32" />
                                                                            </SelectParameters>
                                                                        </asp:ObjectDataSource>
                                                                        <telerik:RadComboBox ID="rcbSP" Runat="server" AllowCustomText="True" 
                                                                            DataSourceID="ODSSP" DataTextField="Descripcion" 
                                                                            DataValueField="IdSistemaPensiones" ErrorMessage="error ..." Filter="Contains" 
                                                                            Skin="Hay" Width="100%">
                                                                        </telerik:RadComboBox>
                                                                    </td>
                                                                    <td valign="top">
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style10" valign="top" width="140">
                                                                        Fecha de Afiliación:</td>
                                                                    <td align="left" valign="top" width="280">
                                                                        <telerik:RadDatePicker ID="rpFechaAfiliacionSP" Runat="server" 
                                                                            AutoPostBack="True" Culture="es-PE" MinDate="1950-01-01" Width="150px">
                                                                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                ViewSelectorText="x">
                                                                            </Calendar>
                                                                            <DateInput AutoPostBack="True" DateFormat="dd/MMM/yyyy" 
                                                                                DisplayDateFormat="dd/MMM/yyyy">
                                                                            </DateInput>
                                                                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                                                        </telerik:RadDatePicker>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td align="right" class="style10" valign="top" width="140">
                                                                        CUSPP:</td>
                                                                    <td align="left" valign="top" width="280">
                                                                        <asp:TextBox ID="txtCUSPP" runat="server" Width="100%"></asp:TextBox>
                                                                    </td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                                <tr>
                                                                    <td class="style10" width="140">
                                                                        &nbsp;</td>
                                                                    <td width="280">
                                                                        &nbsp;</td>
                                                                    <td>
                                                                        &nbsp;</td>
                                                                </tr>
                                                            </table>
                                                        </asp:Panel>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </td>
                                            <td width="10">
                                                &nbsp;</td>
                                        </tr>
                                    </table></telerik:RadPageView>
                                <telerik:RadPageView ID="RadPageView11" runat="server" Height="100%" 
                                    BorderStyle="Solid" BorderWidth="1px"><table width="100%" style="font-family: Arial; font-size: 9pt"><tr><td width="3">&nbsp;</td><td><asp:Panel ID="Panel2" runat="server"><table style="border: 1px solid #C0C0C0" width="100%"><tr><td><strong>Datos de Conyuge:</strong></td></tr><tr><td><asp:ObjectDataSource ID="ODSConyuge" runat="server" 
                                                                    SelectMethod="GetDERECHOHABIENTEConyugueByIdPersonal" 
                                                                    TypeName="SistFoncreagro.BussinesLogic.DerechoHabienteBL"><SelectParameters><asp:SessionParameter Name="IdPersonal" SessionField="IdPersonal" 
                                                                            Type="Int32" /></SelectParameters></asp:ObjectDataSource><asp:GridView ID="gvConyuge1" runat="server" AutoGenerateColumns="False" 
                                                                    DataSourceID="ODSConyuge"><Columns><asp:TemplateField><ItemTemplate><asp:ImageButton ID="btnEditarConyuge" runat="server" 
                                                                                    ImageUrl="~/img/Edit.gif" /></ItemTemplate></asp:TemplateField><asp:TemplateField><ItemTemplate><asp:ImageButton ID="btnEliminarConyuge" runat="server" 
                                                                                    ImageUrl="~/img/Delete.gif" 
                                                                                    CommandArgument='<%# Bind("IdDerechoHabiente") %>' 
                                                                                    onclick="btnEliminarConyuge_Click" /></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdDH" SortExpression="IdDerechoHabiente" 
                                                                            Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox1" runat="server" 
                                                                                    Text='<%# Bind("IdDerechoHabiente") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label1" runat="server" Text='<%# Bind("IdDerechoHabiente") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdP" SortExpression="IdPersonal" Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("IdPersonal") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label2" runat="server" Text='<%# Bind("IdPersonal") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdV" SortExpression="IdVinculo" Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("IdVinculo") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label3" runat="server" Text='<%# Bind("IdVinculo") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Nombre" SortExpression="Nombre"><EditItemTemplate><asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label4" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="ApePaterno" SortExpression="ApePaterno"><EditItemTemplate><asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("ApePaterno") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label5" runat="server" Text='<%# Bind("ApePaterno") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="ApeMaterno" SortExpression="ApeMaterno"><EditItemTemplate><asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("ApeMaterno") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label6" runat="server" Text='<%# Bind("ApeMaterno") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="EstadoCivil" SortExpression="EstadoCivil"><EditItemTemplate><asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("EstadoCivil") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label7" runat="server" Text='<%# Bind("EstadoCivil") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Fecha Nacim." SortExpression="FechaNacimiento"><EditItemTemplate><asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("FechaNacimiento") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label8" runat="server" 
                                                                                    Text='<%# CDate(Eval("FechaNacimiento")).ToString(“dd/MM/yyyy”) %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Estado" SortExpression="Estado"><EditItemTemplate><asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("Estado") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label9" runat="server" Text='<%# Bind("Estado") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Fecha Matrimonio" 
                                                                            SortExpression="FechaConvivencia"><EditItemTemplate><asp:TextBox ID="TextBox10" runat="server" 
                                                                                    Text='<%# Bind("FechaConvivencia") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label10" runat="server" 
                                                                                    Text='<%# CDate(Eval("FechaConvivencia")).ToString(“dd/MM/yyyy”) %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdTDI" SortExpression="IdTipoDI" Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("IdTipoDI") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label11" runat="server" Text='<%# Bind("IdTipoDI") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdNac" SortExpression="IdNacionalidad" 
                                                                            Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("IdNacionalidad") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label12" runat="server" Text='<%# Bind("IdNacionalidad") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Nro D.I." SortExpression="NroDI"><EditItemTemplate><asp:TextBox ID="TextBox13" runat="server" Text='<%# Bind("NroDI") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label13" runat="server" Text='<%# Bind("NroDI") %>'></asp:Label></ItemTemplate></asp:TemplateField></Columns></asp:GridView></td></tr></table></asp:Panel></td><td width="3">&nbsp;</td></tr><tr><td width="3">&nbsp;</td><td><asp:Panel ID="Panel3" runat="server"><table style="border: 1px solid #C0C0C0" width="100%"><tr><td style="font-weight: 700">Datos de hijos/as:</td></tr><tr><td><asp:ObjectDataSource ID="ODSHijos" runat="server" 
                                                                    SelectMethod="GetDERECHOHABIENTEHijoByIdPersonal" 
                                                                    TypeName="SistFoncreagro.BussinesLogic.DerechoHabienteBL"><SelectParameters><asp:SessionParameter Name="IdPersonal" SessionField="IdPersonal" 
                                                                            Type="Int32" /></SelectParameters></asp:ObjectDataSource><asp:GridView ID="gvHijosDH" runat="server" AutoGenerateColumns="False" 
                                                                    DataSourceID="ODSHijos"><Columns><asp:TemplateField><ItemTemplate><asp:ImageButton ID="btnEditarHijoDH" runat="server" 
                                                                                    ImageUrl="~/img/Edit.gif" /></ItemTemplate></asp:TemplateField><asp:TemplateField><ItemTemplate><asp:ImageButton ID="btnEliminarHijoDH" runat="server" 
                                                                                    CommandArgument='<%# Bind("IdDerechoHabiente") %>' ImageUrl="~/img/Delete.gif" 
                                                                                    onclick="btnEliminarHijoDH_Click" /></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdDH" SortExpression="IdDerechoHabiente" 
                                                                            Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox1" runat="server" 
                                                                                    Text='<%# Bind("IdDerechoHabiente") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label1" runat="server" Text='<%# Bind("IdDerechoHabiente") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdP" SortExpression="IdPersonal" Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("IdPersonal") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label2" runat="server" Text='<%# Bind("IdPersonal") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdV" SortExpression="IdVinculo" Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("IdVinculo") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label3" runat="server" Text='<%# Bind("IdVinculo") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Nombre" SortExpression="Nombre"><EditItemTemplate><asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label4" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="ApePaterno" SortExpression="ApePaterno"><EditItemTemplate><asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("ApePaterno") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label5" runat="server" Text='<%# Bind("ApePaterno") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="ApeMaterno" SortExpression="ApeMaterno"><EditItemTemplate><asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("ApeMaterno") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label6" runat="server" Text='<%# Bind("ApeMaterno") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="EstadoCivil" SortExpression="EstadoCivil"><EditItemTemplate><asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("EstadoCivil") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label7" runat="server" Text='<%# Bind("EstadoCivil") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="FechaNacim." SortExpression="FechaNacimiento"><EditItemTemplate><asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("FechaNacimiento") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label8" runat="server" 
                                                                                    Text='<%# CDate(Eval("FechaNacimiento")).ToString(“dd/MM/yyyy”) %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Discapacidad" SortExpression="Discapacidad"><EditItemTemplate><asp:CheckBox ID="CheckBox1" runat="server" 
                                                                                    Checked='<%# Bind("Discapacidad") %>' /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBox1" runat="server" 
                                                                                    Checked='<%# Bind("Discapacidad") %>' Enabled="false" /></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Estudiando" SortExpression="Estudiando"><EditItemTemplate><asp:CheckBox ID="CheckBox2" runat="server" 
                                                                                    Checked='<%# Bind("Estudiando") %>' /></EditItemTemplate><ItemTemplate><asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("Estudiando") %>' 
                                                                                    Enabled="false" /></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="Estado" SortExpression="Estado"><EditItemTemplate><asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("Estado") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label9" runat="server" Text='<%# Bind("Estado") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdTDI" SortExpression="IdTipoDI" Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox10" runat="server" Text='<%# Bind("IdTipoDI") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label10" runat="server" Text='<%# Bind("IdTipoDI") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="IdNac." SortExpression="IdNacionalidad" 
                                                                            Visible="False"><EditItemTemplate><asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("IdNacionalidad") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label11" runat="server" Text='<%# Bind("IdNacionalidad") %>'></asp:Label></ItemTemplate></asp:TemplateField><asp:TemplateField HeaderText="NroDI" SortExpression="NroDI"><EditItemTemplate><asp:TextBox ID="TextBox12" runat="server" Text='<%# Bind("NroDI") %>'></asp:TextBox></EditItemTemplate><ItemTemplate><asp:Label ID="Label12" runat="server" Text='<%# Bind("NroDI") %>'></asp:Label></ItemTemplate></asp:TemplateField></Columns></asp:GridView></td></tr></table></asp:Panel></td><td width="3">&nbsp;</td></tr><tr><td width="3">&nbsp;</td><td><asp:Panel ID="Panel4" runat="server"><table style="border: 1px solid #C0C0C0" width="100%"><tr><td style="font-weight: 700">Datos Otros<strong>:</strong></td></tr><tr><td><asp:ObjectDataSource ID="ODSOtrosVinculos" runat="server" 
                                                                    SelectMethod="GetDERECHOHABIENTEOtrosVinculosByIdPersonal" 
                                                                    TypeName="SistFoncreagro.BussinesLogic.DerechoHabienteBL"><SelectParameters><asp:SessionParameter Name="IdPersonal" SessionField="IdPersonal" 
                                                                            Type="Int32" /></SelectParameters></asp:ObjectDataSource><asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                                                                    DataSourceID="ODSOtrosVinculos"><Columns><asp:BoundField DataField="IdDerechoHabiente" HeaderText="IdDerechoHabiente" 
                                                                            SortExpression="IdDerechoHabiente" Visible="False" /><asp:BoundField DataField="IdPersonal" HeaderText="IdPersonal" 
                                                                            SortExpression="IdPersonal" Visible="False" /><asp:BoundField DataField="IdVinculo" HeaderText="IdVinculo" 
                                                                            SortExpression="IdVinculo" Visible="False" /><asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                                                                            SortExpression="Nombre" /><asp:BoundField DataField="ApePaterno" HeaderText="ApePaterno" 
                                                                            SortExpression="ApePaterno" /><asp:BoundField DataField="ApeMaterno" HeaderText="ApeMaterno" 
                                                                            SortExpression="ApeMaterno" /><asp:BoundField DataField="EstadoCivil" HeaderText="EstadoCivil" 
                                                                            SortExpression="EstadoCivil" /><asp:BoundField DataField="FechaNacimiento" HeaderText="FechaNacimiento" 
                                                                            SortExpression="FechaNacimiento" /><asp:CheckBoxField DataField="Discapacidad" HeaderText="Discapacidad" 
                                                                            SortExpression="Discapacidad" /><asp:CheckBoxField DataField="Estudiando" HeaderText="Estudiando" 
                                                                            SortExpression="Estudiando" /><asp:BoundField DataField="Estado" HeaderText="Estado" 
                                                                            SortExpression="Estado" /><asp:BoundField DataField="FechaConvivencia" HeaderText="FechaConvivencia" 
                                                                            SortExpression="FechaConvivencia" /><asp:BoundField DataField="IdTipoDI" HeaderText="IdTipoDI" 
                                                                            SortExpression="IdTipoDI" Visible="False" /><asp:BoundField DataField="IdNacionalidad" HeaderText="IdNacionalidad" 
                                                                            SortExpression="IdNacionalidad" Visible="False" /><asp:BoundField DataField="NroDI" HeaderText="NroDI" SortExpression="NroDI" /></Columns></asp:GridView></td></tr></table></asp:Panel></td><td width="3">&nbsp;</td></tr><tr><td width="3">&nbsp;</td><td style="font-weight: 700">Nuevo registro de Derecho&nbsp; Habiente:</td><td width="3">&nbsp;</td></tr><tr><td width="3">&nbsp;</td><td><asp:Panel ID="PanelDH" runat="server"><table style="border: 1px solid #C0C0C0; font-family: Arial; font-size: 9pt" 
                                                        width="100%"><tr><td width="3">&#160;</td><td align="left" width="100"><asp:ImageButton ID="btnGrabarDH" runat="server" ImageUrl="~/img/Grabar.gif" 
                                                                    ToolTip="Clic para grabar" /></td><td width="200"><asp:TextBox ID="txtIdDH" runat="server" Width="20px" Visible="False"></asp:TextBox></td><td width="10">&#160;</td><td width="120">&#160;</td><td width="10">&#160;</td><td width="150">&#160;</td><td>&#160;</td></tr><tr><td width="3">&#160;</td><td align="right" width="100">Vinculo:</td><td width="200"><asp:DropDownList ID="ddlVinculoFamiliar" runat="server" 
                                                                    DataSourceID="ODSVinculoFamiliar" DataTextField="Descripcion" 
                                                                    DataValueField="IdVinculo" Width="200px" AutoPostBack="True"></asp:DropDownList></td><td width="10">&#160;</td><td align="right" width="120">Fecha de Nacimiento:</td><td width="10">&#160;</td><td width="150"><asp:UpdatePanel ID="UpdatePanel3" runat="server"><ContentTemplate><telerik:RadDatePicker ID="rpFechaNacimientoDH" Runat="server" 
                                                                            AutoPostBack="True" Culture="es-PE" MinDate="1950-01-01" Width="150px"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                ViewSelectorText="x"></Calendar><DateInput AutoPostBack="True" DateFormat="dd/MMM/yyyy" 
                                                                                DisplayDateFormat="dd/MMM/yyyy"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker></ContentTemplate></asp:UpdatePanel></td><td><asp:ObjectDataSource ID="ODSVinculoFamiliar" runat="server" 
                                                                    SelectMethod="GetAllFromVINCULOFAMILIAR" 
                                                                    TypeName="SistFoncreagro.BussinesLogic.VinculoFamiliarBL"></asp:ObjectDataSource></td></tr><tr><td width="3">&#160;</td><td align="right" width="100">Nombres:</td><td width="200"><asp:TextBox ID="txtNombreDH" runat="server" Width="200px"></asp:TextBox></td><td width="10">&#160;</td><td align="right" width="120">Nacionalidad:</td><td width="10">&#160;</td><td width="150"><asp:DropDownList ID="ddlNacionalidadDH" runat="server" 
                                                                    DataSourceID="ODSNacionalidad" DataTextField="Nacionalidad" 
                                                                    DataValueField="IdNacionalidad" Width="150px" AutoPostBack="True"></asp:DropDownList></td><td><asp:ObjectDataSource ID="ODSTipoDIDH" runat="server" 
                                                                    SelectMethod="GetTipoDocumentoIdentidadByIdNacionalidad" 
                                                                    TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoIdentidadBL"><SelectParameters><asp:ControlParameter ControlID="RCBNacionalidad" Name="idNacionalidad" 
                                                                            PropertyName="SelectedValue" Type="Int32" /></SelectParameters></asp:ObjectDataSource></td></tr><tr><td width="3">&#160;</td><td align="right" width="100">Apellido Paterno:</td><td width="200"><asp:TextBox ID="txtApePatDH" runat="server" Width="200px"></asp:TextBox></td><td width="10">&#160;</td><td align="right" width="120">Tipo DI:</td><td width="10">&#160;</td><td width="150"><asp:DropDownList ID="ddlTipoDIDH" runat="server" DataSourceID="ODSTipoDIDH" 
                                                                    DataTextField="Descripcion" DataValueField="IdTipoDI" Width="150px"></asp:DropDownList></td><td>&#160;</td></tr><tr><td width="3">&#160;</td><td align="right" width="100">Apellido Materno:</td><td width="200"><asp:TextBox ID="txtApeMatDH" runat="server" Width="200px"></asp:TextBox></td><td width="10">&#160;</td><td align="right" width="120">Nro. DI:</td><td width="10">&#160;</td><td width="150"><asp:TextBox ID="txtNroDIDH" runat="server" Width="145px"></asp:TextBox></td><td>&#160;</td></tr><tr><td width="3">&#160;</td><td align="right" width="100">&#160;</td><td width="200">&#160;</td><td width="10">&#160;</td><td align="right" width="120">Estado Civil:</td><td width="10">&#160;</td><td width="150"><asp:DropDownList ID="ddlEstadoCivilDH" runat="server" Width="150px"><asp:ListItem>SOLTERO(A)</asp:ListItem><asp:ListItem>CASADO(A)</asp:ListItem><asp:ListItem>CONVIVIENTE</asp:ListItem></asp:DropDownList></td><td>&#160;</td></tr><tr><td width="3">&#160;</td><td align="right" width="100">&#160;</td><td colspan="6"><asp:UpdatePanel ID="UpdatePanelDiscDH" runat="server"><ContentTemplate><table class="style9"><tr><td><asp:Panel ID="PanelDiscapacidad" runat="server" Visible="False"><table width="100%"><tr><td align="right" width="60">Condición:</td><td width="100"><asp:DropDownList ID="ddlCondicionDiscEstDH" runat="server" Width="100px"><asp:ListItem Value="-1">Ninguna</asp:ListItem><asp:ListItem Value="1">Estudiano</asp:ListItem><asp:ListItem Value="2">Discapacidad</asp:ListItem></asp:DropDownList></td><td width="10">&#160;</td><td width="130"><asp:LinkButton ID="lbtnAddCertDiscaEst" runat="server">Agregar Certificado</asp:LinkButton></td><td>&#160;</td></tr></table></asp:Panel></td></tr><tr><td><asp:Panel ID="PanelFechaMatri" runat="server" Visible="False"><table width="100%"><tr><td align="right" width="130"><asp:Label ID="lblFechaMatri" runat="server"></asp:Label></td><td width="150"><telerik:RadDatePicker ID="rpFechaMatrimonio" Runat="server" Culture="es-PE" 
                                                                                                        MinDate="1950-01-01" Width="150px"><Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                                                                                            ViewSelectorText="x"></Calendar><DateInput DateFormat="dd/MMM/yyyy" DisplayDateFormat="dd/MMM/yyyy"></DateInput><DatePopupButton HoverImageUrl="" ImageUrl="" /></telerik:RadDatePicker></td><td width="10">&#160;</td><td width="130"><asp:LinkButton ID="lbtnAddCertConvivencia" runat="server">Agregar Certificado</asp:LinkButton></td><td>&#160;</td></tr></table></asp:Panel></td></tr></table></ContentTemplate></asp:UpdatePanel></td></tr><tr><td width="3">&#160;</td><td align="right" width="100">Estado:</td><td width="200"><asp:DropDownList ID="ddlEstadoDH" runat="server" Width="200px"><asp:ListItem Value="2">Aún no registrado En EsSalud</asp:ListItem><asp:ListItem Value="1">Activo en EsSalud</asp:ListItem><asp:ListItem Value="0">De Baja</asp:ListItem></asp:DropDownList></td><td width="10">&#160;</td><td align="right" width="120">&#160;</td><td width="10">&#160;</td><td width="150">&#160;</td><td>&#160;</td></tr></table></asp:Panel></td><td width="3">&nbsp;</td></tr><tr><td width="3">&nbsp;</td><td>&nbsp;</td><td width="3">&nbsp;</td></tr></table></telerik:RadPageView>
                            </telerik:RadMultiPage>
                </div>
            </td>
            <td width ="15">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="15">
                &nbsp;</td>
            <td style="width: 800px">
                            &nbsp;</td>
            <td width="15">
                &nbsp;</td>
        </tr>
        </table>
    
    </div>
     <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                            <telerik:RadWindow ID="VentanaAdjuntar" runat="server" Animation="Resize" AnimationDuration="200" Width="780 px" 
                            Height="300px" Title="Adjuntar Archivo" Left="150px" ReloadOnShow="True" 
                            ShowContentDuringLoad="False" Modal="True" OnClientClose="CerrarRadWindow"></telerik:RadWindow>

                            <telerik:RadWindow ID="VentanaAdjuntarContrato" runat="server" Animation="Resize" AnimationDuration="200" Width="780 px" 
                            Height="300px" Title="Adjuntar Archivo" Left="150px" ReloadOnShow="True" 
                            ShowContentDuringLoad="False" Modal="True"  OnClientClose="CerrarRadWindow2"></telerik:RadWindow>

                            <telerik:RadWindow ID="CambiarCondiciones" runat="server" Animation="Resize" AnimationDuration="200" Width="780 px" 
                            Height="480px" Title="Adjuntar Archivo" Left="150px" ReloadOnShow="True" 
                            ShowContentDuringLoad="False" Modal="True" OnClientClose = "CerrarVentana"></telerik:RadWindow>

                            <telerik:RadWindow ID="AsignarHorario" runat="server" Title="Asignar Horario" Height="480px"
                            Width="680px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                            Modal="true" Animation="Resize"></telerik:RadWindow>  

                            <telerik:RadWindow ID="AsignarCC" runat="server" Title="Asignar Centro de Costo" Height="700px"
                            Width="850px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                            Modal="true" Animation="Resize" ></telerik:RadWindow>    

                            <telerik:RadWindow ID="RegistrarAusencia" runat="server" Title="Registrar Ausencia" Height="450px"
                            Width="590px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                            Modal="true" Animation="Resize"></telerik:RadWindow>   
                    </Windows>
      </telerik:RadWindowManager>
    </form>
</body>
</html>
