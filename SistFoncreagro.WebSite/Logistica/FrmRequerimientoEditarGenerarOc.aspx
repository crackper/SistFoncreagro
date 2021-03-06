﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmRequerimientoEditarGenerarOc.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmRequerimientoEditarGenerarOc" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;
    var idDetalle = 0;

    function eliminarFila(param, tip) {
        var parametro = param;
        var tipo = tip;

        if (parametro == 2) {
            var tabla = document.getElementById('tablaRequerimiento');
            tabla.deleteRow(10);
            tabla.deleteRow(10);
        }
        else {
            if (parametro == 9) {
            }
            else {
                var tabla = document.getElementById('tablaRequerimiento');
                tabla.deleteRow(11);
            }
        }

        if (tipo == 0) {
            var tabla1 = document.getElementById('tablaRequerimiento');
            tabla1.deleteRow(5);

        }
    }

    function CargarVentana(idDetalle, idProyecto, producto) {
        var oWnd = radopen("VentanaCentroCostoxDetalleReq.aspx?IdDetalle=" + idDetalle + "&IdProyecto=" + idProyecto + "&Producto=" + producto + "&Estado=0", "CentroCosto");
    }

    function CargarBandejaReporte(id) {
        var oWnd = radopen("VentanaReporteSolicitarCotizacion.aspx?idReq=" + id, "VentanaReporte");
    }

    function EnviarLicitacion() {
            radconfirm('¿Está seguro que el Requerimiento es una Licitación?', confirmaEnvio, 300, 150, null, 'Recepción parcial');
        }

    function confirmaEnvio(arg) {
        if (arg) {
              $find("<%= RadAjaxManager1.ClientID%>").ajaxRequest("EnviarLIcitacion");
            }
    }

    function CargarAdjunto(id) {
        var oWnd = radopen("VentanaAdjuntarRequerimiento.aspx?idReq=" + id + "&elim=0", "VentanaAdjunto");
    }

    function AnularItem(id, prod) {
        idDetalle = id;
        radprompt('¿ Está seguro que desea <b>ANULAR</b> el item: ' + prod + '? <br> Ingrese motivo.', confirmaAnular, 580, 160, null, 'Anular Item', 'Motivo');
    }


    function confirmaAnular(arg) {
        if (arg) {
            $find("<%= RadAjaxManager1.ClientID%>").ajaxRequest("AnularItem|" + idDetalle + "|" + arg);
        }
    }
</script>
</telerik:RadCodeBlock>
<fieldset>
                <asp:LinkButton ID="lbAdjunto" runat="server"/>
                &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbReporteCotizacion" runat="server">Reporte Cotización</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="lbLicitacion" runat="server" Text="Licitación - Sole Source"/>
          <asp:ModalPopupExtender ID="lbLicitacionModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrarLicSould" PopupControlID="panelLicSoul" 
                      TargetControlID="lbLicitacion">
                  </asp:ModalPopupExtender>
                              &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:LinkButton ID="lbRechazarRequerimiento" runat="server" 
                      Text="Rechazar Requerimiento" />
                  <asp:ModalPopupExtender ID="lbRechazarRequerimiento_ModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrarRechazo" PopupControlID="panelRechazar" 
                      TargetControlID="lbRechazarRequerimiento">
                  </asp:ModalPopupExtender>
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lbAnularOc" runat="server" 
                    Text="Anular Requerimiento" Visible="False" />
                  <asp:ModalPopupExtender ID="lbAnularReqModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrar2" PopupControlID="panelAnular" 
                      TargetControlID="lbAnularOc">
                  </asp:ModalPopupExtender>

                <asp:LinkButton ID="lblVerOc" runat="server" Visible="False">Ver O/C</asp:LinkButton>

    </fieldset>
      <fieldset class="jcv">
       <legend class="legendJcv">REQUERIMIENTO DE COMPRA</legend>
       <asp:Panel ID="PanelEncabezado" runat="server">
    <table id="tablaRequerimiento" class="tabla4" cellpadding="0" cellspacing="0">
              <tr>
                  <td align="left" style="width: 2%" class="Texto">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Requerido Por :</td>
                  <td style="height: 10px; width: 70%;">
                        <asp:Label ID="lblRequeridoPor" runat="server"></asp:Label>
                    </td>
              </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Nro. Requerimiento :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblNroRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Tipo Requerimiento :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblTipoRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Estado :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblEstadoRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 20px;">
                           Fecha Requerimiento :</td>
                       <td style="height: 10px; width: 70%;">
                           <asp:Label ID="lblFechaRequerimiento" runat="server"></asp:Label>
                       </td>
                   </tr>
              <tr>
                  <td align="left" class="Texto" style="width: 2%">
                      &nbsp;</td>
                    <td align="left" class="Texto" 
                      style="height: 20px; width: 70%;" colspan="2">
                      <table border="0" cellpadding="0" cellspacing="0">
                          <tr>
                              <td align="right" style="width: 126.5px; font-weight: bold; height: 22px;">
                                  Periodo :</td>
                              <td align="right" style="width: 10.5px; ">
                                  &nbsp;</td>
                              <td align="left" style="width: 500px; height: 22px;">
                                  <asp:Label ID="lblPeridoInicio" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td align="right" style="width: 126.5px; font-weight: bold;" rowspan="2" 
                                  valign="middle">
                                  Ruta :</td>
                              <td align="right" rowspan="2" style="width: 10.5px; " valign="middle">
                                  &nbsp;</td>
                              <td align="left" style="width: 500px; height: 22px;">
                              <asp:Label ID="lblOrigen" runat="server"></asp:Label>
                              </td>
                          </tr>
                          <tr>
                              <td align="left" style="width: 500px; height: 22px;">
                                    <asp:Label ID="lblDestino" runat="server"></asp:Label>
                              </td>
                          </tr>
                      </table>

                  </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%" class="Texto">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Moneda :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:Label ID="lblMoneda" runat="server"></asp:Label>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Área/Proyecto :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:Label ID="lblAreaProyecto" runat="server"></asp:Label>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        &nbsp;</td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Sustento :</td>
                  <td style="width: 70%;" class="tablaJcv">
                        <asp:Label ID="lblSustento" runat="server"></asp:Label>
                    </td>
              </tr>
              <tr>
                  <td align="left" style="width: 2%">
                        <asp:TextBox ID="txtTipoCatalogoRequerimiento" runat="server" Visible="False" 
                            Width="0px">0</asp:TextBox>
                  </td>
                  <td align="left" style="width: 13%; font-weight: bold; height: 20px;" 
                      class="Texto">
                        Observaciones :<br />
                        <br />
                        <br />
                    </td>
                  <td style="width: 70%; " class="tablaJcv">
                        <asp:TextBox ID="txtObservacion" runat="server" Height="49px" 
                            TextMode="MultiLine" Width="441px" ReadOnly="True"></asp:TextBox>
                        </td>
              </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                           <asp:TextBox ID="txtCentroCostoHabilitado" runat="server" Visible="False" 
                               Width="0px">0</asp:TextBox>
                       </td>
                       <td align="left" class="Texto" 
                           style="width: 13%; font-weight: bold; height: 21px;">
                           Responsable :</td>
                       <td style="width: 70%; " class="tablaJcv">
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                               BorderColor="White" BorderStyle="None" 
                               DataSourceID="odsListaEstadoRequerimiento" Width="445px">
                               <Columns>
                                   <asp:BoundField DataField="NombrePersona" HeaderText="Nombre" ReadOnly="True" 
                                       SortExpression="NombrePersona">
                                   <ItemStyle HorizontalAlign="Center" Width="250px" />
                                   </asp:BoundField>
                                   <asp:BoundField DataField="FechaApruebaAnula" DataFormatString="{0:dd/MM/yyyy} - {0:HH:mm}" 
                                       HeaderText="Fecha Aprobación" SortExpression="FechaApruebaAnula">
                                   <ItemStyle HorizontalAlign="Center" Width="150px" />
                                   </asp:BoundField>
                               </Columns>
                           </asp:GridView>
                       </td>
                   </tr>
              <tr>
                  <td style="width: 2%">
                        <asp:TextBox ID="txtIdProyecto" runat="server" BorderStyle="None" Height="0px" 
                            ReadOnly="True" Visible="False" Width="0px"></asp:TextBox>
                        <asp:TextBox ID="txtIdRequerimiento" runat="server" Height="0px" 
                            ReadOnly="True" Visible="False" Width="0px"></asp:TextBox>
                  </td>
                  <td style="width: 13%;" class="Texto">
                    
                  </td>
                  <td style="width: 70%;" class="tablaJcv" align="right">
                    
                        &nbsp;</td>
              </tr>
          </table>
      </asp:Panel>
      </fieldset>   
    <fieldset class="jcv">
        <legend class="legendJcv">DETALLE REQUERIMIENTO</legend>
        <table class="tablaJcv">
           <tr>
              <td style="height: 23px;">
                  <asp:LinkButton ID="lbActualizarDetalle" runat="server">Actualizar Det.</asp:LinkButton>
                  </td>
              <td align="right" style="width: 800px; height: 23px;" valign="top">
                  <asp:LinkButton ID="lbPDescripcion" runat="server" 
                      Text="Registrar Cotización" />
                  <asp:ModalPopupExtender ID="lbPDescripcion_ModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrar" PopupControlID="pnlProductos" 
                      TargetControlID="lbPDescripcion">
                  </asp:ModalPopupExtender>
              </td>
          </tr>
          <tr>
              <td colspan="2">
                     <div style="overflow: scroll; width: 900px;">
                        <asp:GridView ID="gvDetalleRequerimiento" runat="server" 
                            AutoGenerateColumns="False" 
                            DataKeyNames="IdDetalleRequerimiento,codigoCatalogo,nombreCatalogo" 
                            DataSourceID="odsDetalleRequerimiento" 
                            Font-Size="8pt" Width="949px">
                            <Columns>
                                <asp:TemplateField HeaderText="Anular">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbAnularItem" runat="server"
                                        Visible='<%# estadoCb(Eval("Estado")) %>'
                                        >Anular</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="codigoCatalogo" HeaderText="Código" 
                                    SortExpression="codigoCatalogo">
                                <HeaderStyle HorizontalAlign="Center" Width="75px" />
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Afecto">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cbAfectoIgv" runat="server" 
                                            Checked='<%# Bind("AfectoIgv") %>' />
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="nombreCatalogo" HeaderText="Producto / Servicio" 
                                    SortExpression="nombreCatalogo">
                                <HeaderStyle Width="300px" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Observación" SortExpression="Observacion">
                                    <ItemTemplate>
                                      <asp:TextBox ID="txtIdDetReq" runat="server" BackColor="Info" 
                                          Text='<%# Bind("IdDetalleRequerimiento") %>' Width="0px" Height="0px" 
                                            ReadOnly="True" Visible="False"></asp:TextBox>
                                              <asp:TextBox ID="txtIdCatalogo" runat="server" BackColor="Info" 
                                          Text='<%# Bind("IdCatalogo") %>' Width="0px" Height="0px" 
                                            ReadOnly="True" Visible="False"></asp:TextBox>
                                      <asp:TextBox ID="txtDetalleObservacion" runat="server" BackColor="Info" 
                                            CssClass="TextoCentro" Text='<%# Bind("observacion") %>' Width="200px" 
                                            Font-Size="8pt"></asp:TextBox>
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" Width="210px" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="unidadAbreviatura" HeaderText="Unidad">
                                <HeaderStyle HorizontalAlign="Center" Width="65px" />
                                <ItemStyle HorizontalAlign="Center" Width="25px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Cantidad" DataFormatString="{0:n}" 
                                    HeaderText="Cantidad" SortExpression="Cantidad">
                                <HeaderStyle HorizontalAlign="Center" Width="70px" />
                                <ItemStyle HorizontalAlign="Center" Width="30px" />
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Estado">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="cbEstado" runat="server" 
                                            Visible='<%# estadoCb(Eval("Estado")) %>' />
                                        <asp:Label ID="lblEstado" runat="server" 
                                            Text='<%# estadoTextLabel(Eval("Estado")) %>' 
                                            Visible='<%# estadoLabel(Eval("Estado")) %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="15px" />
                                    <ItemStyle Height="15px" HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="C. Costo" SortExpression="">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbCentroCosto" runat="server" Font-Size="8pt" 
                                            Text="C. Costo" />
                                    </ItemTemplate>
                                    <HeaderStyle Width="65px" />
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="C. Costo" SortExpression="">
                                    <ItemTemplate>
                                        <telerik:RadComboBox ID="rcbCentroCostoDetalle" Runat="server" 
                                            AllowCustomText="True" DataSourceID="odsCentroCostoDetalle" 
                                            DataTextField="CodigoElementoGasto" DataValueField="IdCCosto" 
                                            EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                            MarkFirstMatch="True" SelectedValue='<%# Bind("IdCentroCosto") %>' 
                                            ShowMoreResultsBox="True" Width="300px" Enabled="False" ForeColor="Black">
                                        </telerik:RadComboBox>
                                    </ItemTemplate>
                                    <HeaderStyle Width="65px" />
                                    <ItemStyle HorizontalAlign="Center" Width="50px" />
                                </asp:TemplateField>
                                 <asp:BoundField DataField="Estado" 
                                    SortExpression="Estado">
                                <ItemStyle Font-Size="0pt" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                        <br />
                     </div>
              </td>           
          </tr>
          <tr>
              <td colspan="2">
              </td>
          </tr>
      </table>
   </fieldset>
              <br />
    <asp:Panel ID="pnlProductos" runat="server" CssClass="CajaDialogo" 
        Width="618px">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">TIPO COMPRA</legend>
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 65px; height: 30px;">
                Nombre :</td>
            <td style="height: 30px">
                <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="Validar" 
                    Width="300px"></asp:TextBox>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNombre" ErrorMessage="Campo requerido." Font-Size="8pt" 
                    ValidationGroup="Validar"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 65px; height: 30px;">
                Tipo :</td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlTipo" runat="server" DataSourceID="odsTipoCoti" 
                    DataTextField="Descripcion" DataValueField="IdTipoCotizacion" 
                    Width="305px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 65px; height: 30px;">
                Moneda :</td>
            <td style="height: 30px">
                <asp:DropDownList ID="ddlMoneda" runat="server" DataSourceID="odsMoneda" 
                    Width="305px" DataTextField="Nombre" 
                    DataValueField="IdMoneda">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton ID="ibGuardar" runat="server" ImageUrl="~/img/Grabar.gif" 
                    style="height: 25px" ValidationGroup="Validar" />
            </td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                <asp:LinkButton ID="lbCerrar" runat="server">Cerrar</asp:LinkButton>
            </td>
        </tr>
    </table>
</fieldset>
                </ContentTemplate>
        </asp:UpdatePanel>
    </asp:Panel>
    <asp:Panel ID="panelAnular" runat="server" CssClass="CajaDialogo" 
        Width="618px" Visible="False">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">Anular Requerimiento</legend>
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 65px; height: 30px;">
                Motivo :</td>
            <td style="height: 30px" align="right">
                <asp:LinkButton ID="lbCerrar2" runat="server">Cerrar</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 65px" valign="bottom">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtMotivoAnula" ErrorMessage="Ingrese motivo." Font-Size="8pt" 
                    ValidationGroup="Validar1"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtMotivoAnula" runat="server" Height="110px" TextMode="MultiLine" 
                    ValidationGroup="Validar1" Width="415px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                <asp:LinkButton ID="lbAnularRequerimientoR" runat="server" 
                    ValidationGroup="Validar1">Aceptar</asp:LinkButton>
            </td>
        </tr>
    </table>
</fieldset>
                </ContentTemplate>
        </asp:UpdatePanel>
</asp:Panel>

<asp:Panel ID="panelLicSoul" runat="server" CssClass="CajaDialogo" 
        Width="618px">
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">Licitación - Sole Source</legend>
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 65px; height: 30px;">
                &nbsp;</td>
            <td style="height: 30px" align="right">
                &nbsp;</td>
            <td align="left" style="height: 30px">
                &nbsp;</td>
            <td align="right" style="height: 30px">
                
                <asp:LinkButton ID="lbCerrarLicSould" runat="server">Cerrar</asp:LinkButton>
                
            </td>
        </tr>
        <tr>
            <td style="width: 65px; height: 30px;">
                Tipo :</td>
            <td align="right" style="height: 30px">
                &nbsp;</td>
            <td align="left" style="height: 30px">
                <asp:RadioButton ID="rbLicitacion" runat="server" Checked="True" GroupName="f" 
                    Text="Licitación" />
                <asp:RadioButton ID="rbSoulSource" runat="server" GroupName="f" 
                    Text="Soul Source" />
            </td>
            <td align="right" style="height: 30px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 65px" valign="bottom">
                Enviar a :</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:DropDownList ID="ddlPersonaNuevo" runat="server" 
                    DataSourceID="odsAsistentesUser" DataTextField="NombreUsuario" 
                    DataValueField="IdUsuario">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 65px" valign="bottom">
                Fecha :</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblFecha" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                &nbsp;</td>
            <td align="right">
                &nbsp;</td>
            <td align="right">
                <asp:LinkButton ID="LinkButton2" runat="server">Aceptar</asp:LinkButton>
            </td>
        </tr>
    </table>
</fieldset>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Panel>
<asp:Panel ID="panelRechazar" runat="server" CssClass="CajaDialogo" 
        Width="618px">
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">Rechazar Requerimiento</legend>
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 65px; height: 30px;">
                Motivo :</td>
            <td style="height: 30px" align="right">
                <asp:LinkButton ID="lbCerrarRechazo" runat="server">Cerrar</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 65px" valign="bottom">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtMotivo" ErrorMessage="Ingrese motivo." Font-Size="8pt" 
                    ValidationGroup="Validar7"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtMotivo" runat="server" Height="110px" TextMode="MultiLine" 
                    ValidationGroup="Validar" Width="415px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                <asp:LinkButton ID="lbAceptarRechazo" runat="server" ValidationGroup="Validar7">Aceptar</asp:LinkButton>
            </td>
        </tr>
    </table>
</fieldset>
                </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="lbCerrar" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    </asp:Panel>
<telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
                  Skin="Default">
              </telerik:RadAjaxLoadingPanel>
               <asp:ObjectDataSource ID="odsAsistentesUser" runat="server" 
        SelectMethod="GetAllFromAsistentesUser" 
        TypeName="SistFoncreagro.BussinesLogic.UsuarioBL"></asp:ObjectDataSource>
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="CentroCosto" runat="server" Title="Centro de Costo" Height="300px"
                        Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" />
                        <telerik:RadWindow runat="server" Animation="Resize" AnimationDuration="200" Width="795px" 
                            Height="300px" Title="Cargar Cotizaci&#243;n" Left="150px" ReloadOnShow="True" 
                            ShowContentDuringLoad="False" Modal="True" ID="VentanaCotizacion"></telerik:RadWindow>
                         <telerik:RadWindow ID="VentanaReporte" runat="server" Animation="Resize" 
                            AnimationDuration="200" Width="770px" 
                            Height="500px" Title="Envío Solicitud Cotización" Left="150px" ReloadOnShow="True" 
                            ShowContentDuringLoad="False" Modal="True"  VisibleStatusbar="False">
                        </telerik:RadWindow>
                           <telerik:RadWindow ID="VentanaAdjunto" runat="server" 
                            Title="Adjuntar archivo" Height="450px"
                        Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true">
                        </telerik:RadWindow>
                
                    </Windows>
                </telerik:RadWindowManager>
              <asp:ObjectDataSource ID="odsDetalleRequerimiento" runat="server" 
                   SelectMethod="GetAllFromDetalleRequerimientoOrdenadoByIdReq" 
                   TypeName="SistFoncreagro.BussinesLogic.DetalleRequerimientoBL" 
                  DeleteMethod="EliminarDetalle" 
        OldValuesParameterFormatString="original_{0}">
                   <DeleteParameters>
                       <asp:Parameter Name="idDetalleRequerimiento" Type="Int32" />
                   </DeleteParameters>
                   <SelectParameters>
                       <asp:QueryStringParameter Name="IdRequerimiento" QueryStringField="IdReq" 
                           Type="Int32" />
                   </SelectParameters>
               </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="odsListaEstadoRequerimiento" runat="server" 
                            SelectMethod="GetAllFromEstadoRequerimientoByIdRequerimiento" 
        TypeName="SistFoncreagro.BussinesLogic.EstadoRequerimientoBL" 
        OldValuesParameterFormatString="original_{0}">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="IdRequerimiento" QueryStringField="IdReq" 
                                    Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                  <asp:ObjectDataSource ID="odsTipoCoti" runat="server" 
                    SelectMethod="GetAllFromTipoCotizacion" 
                    TypeName="SistFoncreagro.BussinesLogic.TipoCotizacionBL">
                </asp:ObjectDataSource>
                  <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                    SelectMethod="GetAllFromMoneda" 
                    TypeName="SistFoncreagro.BussinesLogic.MonedaBL">
                </asp:ObjectDataSource>
              <asp:ObjectDataSource ID="odsCentroCostoDetalle" runat="server" 
                                            SelectMethod="GetCCOSTOByIdProyecto" 
                                            
        TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                  <SelectParameters>
                      <asp:ControlParameter ControlID="txtIdProyecto" Name="_IdProyecto" 
                                                    PropertyName="Text" Type="Int32" />
                  </SelectParameters>
    </asp:ObjectDataSource>
              <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                  <AjaxSettings>
                      <telerik:AjaxSetting AjaxControlID="lbActualizarDetalle">
                          <UpdatedControls>
                              <telerik:AjaxUpdatedControl ControlID="gvDetalleRequerimiento" 
                                  LoadingPanelID="RadAjaxLoadingPanel1" />
                          </UpdatedControls>
                      </telerik:AjaxSetting>
                  </AjaxSettings>
              </telerik:RadAjaxManager>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>
