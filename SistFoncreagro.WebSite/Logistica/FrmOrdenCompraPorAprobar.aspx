<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmOrdenCompraPorAprobar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmOrdenCompraPorAprobar" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;
    function eliminarFila(param, tip) {
        var tipo = tip;
        var parametro = param;

        if (tipo == 1) {
            var tabla = document.getElementById('tablaOrdenCompra');
            tabla.deleteRow(4);
            tabla.deleteRow(4);
        }
    }

    function CargarVentana(idDetalle, idProyecto, producto) {
        var oWnd = radopen("VentanaCentroCostoxDetalleOrden.aspx?IdDetalle=" + idDetalle + "&IdProyecto=" + idProyecto + "&Producto=" + producto, "CentroCosto");
    }

    function CargarVentanaCotizacion(idCoti, esta) {
        var oWnd = radopen("VentanaCargarCotizacion.aspx?IdCotizacion=" + idCoti + "&Estado=" + esta, "VentanaCotizacion");
        return false;
    }

    function CargarCuadro(idCoti, idOrden) {
        var oWnd = radopen("VentanaCuadroComparativo.aspx?IdCot=" + idCoti + "&idOc=" + idOrden, "Cuadro");
    }
</script>
</telerik:RadCodeBlock>
    <fieldset dir="rtl">
              <asp:LinkButton ID="lbAdjuntarArchivo" runat="server">Adjuntos</asp:LinkButton>
              &nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:LinkButton ID="lbCuadroComparativo" runat="server" 
                  Text="C. Comparativo" Visible="True" />
                     &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lbAprobarOc" runat="server">Aprobar O/C</asp:LinkButton>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lbRechazarOc" runat="server" 
                      Text="Rechazar O/C" Visible="False" />
                  <asp:ModalPopupExtender ID="lbRechazarOcModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrar2" PopupControlID="panelRechazar" 
                      TargetControlID="lbRechazarOc">
                  </asp:ModalPopupExtender>
    &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:LinkButton ID="lbAnularOc" runat="server" 
                      Text="Anular O/C" Visible="False" />
                  <asp:ModalPopupExtender ID="lbAnularReqModalPopupExtender" runat="server" 
                      BackgroundCssClass="FondoAplicacion" DynamicServicePath="" Enabled="True" 
                      OkControlID="lbCerrar" PopupControlID="panelAnular" 
                      TargetControlID="lbAnularOc">
                  </asp:ModalPopupExtender>
    </fieldset>
     <asp:TextBox ID="txtValidarOrden" runat="server" Visible="False" Width="0px" Height="0px"></asp:TextBox>
      <fieldset class="jcv">
       <legend class="legendJcv">ORDEN DE COMPRA</legend>
           <asp:Panel ID="updatePanelPrincipal" runat="server" Width="900px">
               <table id="tablaOrdenCompra" class="tabla5" cellpadding="0" cellspacing="0" 
                   style="width: 100%;">
          <tr>
              <td align="left" style="width: 2%" class="Texto">
                    &nbsp;</td>
              <td align="left" style="width: 14%; font-weight: 600; height: 20px;" 
                  class="Texto">
                    &nbsp;</td>
              <td style="width: 29%;">
                    &nbsp;</td>
              <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto7">
                  &nbsp;</td>
              <td colspan="3">
                  &nbsp;</td>
          </tr>
          <tr>
              <td align="left" style="width: 2%" class="Texto">
                    &nbsp;</td>
              <td align="left" style="width: 14%; font-weight: 600; height: 20px;" 
                  class="Texto7">
                    N° Orden Compra :</td>
              <td style="width: 29%; ">
                    <asp:Label ID="lblNumeroOc" runat="server"></asp:Label>
                </td>
              <td class="Texto7" style="font-weight: 600; width: 14%; height: 20px;">
                  N° Requerimiento :</td>
              <td colspan="3">
                  <asp:Label ID="lblNumeroRequerimiento" runat="server"></asp:Label>
              </td>
          </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td align="left" class="Texto7" 
                       style="width: 14%; font-weight: 600; height: 20px;">
                       Tipo :</td>
                   <td style="width: 29%; ">
                       <asp:Label ID="lblTipoOc" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto7">
                       Requerido Por :</td>
                   <td colspan="3">
                       <asp:Label ID="lblRequeridoPor" runat="server"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td align="left" class="Texto7" 
                       style="width: 14%; font-weight: 600; height: 20px;">
                       Área / Proyecto :</td>
                   <td colspan="5">
                       <asp:Label ID="lblAreaProyecto" runat="server" Font-Size="9pt"></asp:Label>
                   </td>
               </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="right" class="Texto7" 
                           style="height: 20px; width: 14%; font-weight: 600;">
                           Periodo :&nbsp; &nbsp;</td>
                       <td colspan="5" style="height: 19px; ">
                           <asp:Label ID="lblPeriodo" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="right" class="Texto7" 
                           style="height: 20px; width: 14%; font-weight: 600;">
                           Ruta : &nbsp;&nbsp;</td>
                       <td colspan="5" style="height: 19px; ">
                           <asp:Label ID="lblOrigen" runat="server"></asp:Label>
                       </td>
                   </tr>
          <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td align="left" class="Texto7" 
                       style="width: 14%; font-weight: 600; height: 20px;">
                       Estado :</td>
                   <td style="width: 29%; height: 19px;">
                       <asp:Label ID="lblEstadoOrdenCompra" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto7">
                       Moneda :</td>
                   <td style="width: 20%; ">
                       <asp:Label ID="lblMoneda" runat="server"></asp:Label>
                   </td>
                   <td style="width: 15%;">
                       <asp:DropDownList ID="ddlTipoDocumento" runat="server" Visible="False" 
                           Width="50px">
                           <asp:ListItem Value="2">Factura</asp:ListItem>
                           <asp:ListItem Value="4">Boleta</asp:ListItem>
                           <asp:ListItem Value="3">Honorarios Con Ret.</asp:ListItem>
                           <asp:ListItem Value="31">Honorarios Sin Ret.</asp:ListItem>
                       </asp:DropDownList>
                   </td>
                   <td style="width: 40%;">
                       &nbsp;</td>
               </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td align="left" class="Texto7" 
                       style="width: 14%; font-weight: 600; height: 20px;">
                       Proveedor :</td>
                   <td style="height: 19px;" colspan="5">
                       <asp:Label ID="lblProveedorTexto" runat="server"></asp:Label>
                   </td>
               </tr>
                     <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       <asp:TextBox ID="txtIdProyecto" runat="server" Height="0px" ReadOnly="True" 
                           Visible="False" Width="0px"></asp:TextBox>
                         </td>
                   <td align="left" class="Texto7" 
                       style="width: 14%; font-weight: 600; height: 20px;">
                       Tipo Pago :</td>
                   <td style="width: 29%; height: 20px;" valign="middle">
                       <asp:Label ID="lblTipoPago" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto7">
                       % Anticipo :</td>
                   <td style="width: 20%; height: 20px;" valign="middle">
                       <asp:Label ID="lblAnticipo" runat="server"></asp:Label>
                   </td>
                         <td class="Texto7" style="font-weight: 600; height: 20px; width: 15%;" 
                             align="right">
                             Destino :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                         <td style="width: 40%; height: 20px;" valign="middle">
                             <asp:Label ID="lblDestino" runat="server"></asp:Label>
                         </td>
               </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto7" 
                           style="width: 14%; font-weight: 600; height: 20px;">
                           Sustento :</td>
                       <td colspan="5" style="height: 20px;" valign="middle">
                           <asp:Label ID="lblSustento" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto7" 
                           style="width: 14%; font-weight: 600; height: 20px;">
                           Observaciones :</td>
                       <td colspan="5" style="height: 20px;" valign="middle">
                           <asp:Label ID="lblObservaciones" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                       </td>
                       <td align="left" class="Texto7" 
                           style="width: 14%; font-weight: 600; " rowspan="3">
                           <asp:Label ID="lbResponsable" runat="server" Text="Responsable :" 
                               Visible="False"></asp:Label>
                       </td>
                       <td colspan="5" rowspan="3">
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                               BorderColor="White" BorderStyle="None" 
                               DataSourceID="odsListaEstadoOrdenCompra" Width="500px" Font-Size="8pt">
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
                       <td align="left" style="width: 2%">
                       </td>
                   </tr>
                                      <tr>
                       <td align="left" style="width: 2%">
                       </td>
                   </tr>
          <tr>
              <td style="width: 2%">
                    &nbsp;</td>
              <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto">
                    <asp:Label ID="lblProveedor" runat="server" Height="0px" Text="1" 
                        Visible="False" Width="0px"></asp:Label>
              </td>
              <td colspan="5">
                  <asp:TextBox ID="txtIgv" runat="server" Height="0px" Visible="False" 
                      Width="0px" ReadOnly="True"></asp:TextBox>
              </td>
          </tr>
      </table>   
      </asp:Panel>
      </fieldset>
     <fieldset class="jcv">
        <legend class="legendJcv">DETALLE ORDEN DE COMPRA</legend>
          <div style="overflow: scroll; width: 900px;">
            <asp:GridView ID="gvDetalleOrdenCompra" runat="server" 
                AutoGenerateColumns="False" Width="1150px" 
                          DataKeyNames="IdDetalleOrdenCompra,codigoCatalogo,nombreCatalogo" 
                  ShowFooter="True" Font-Size="8pt">
            <Columns>
       
                <asp:BoundField DataField="IdDetalleOrdenCompra" 
                    HeaderText="IdDetalleOrdenCompra" 
                    SortExpression="IdDetalleOrdenCompra" Visible="False" >
                    <ControlStyle Font-Size="0px" ForeColor="White" />
                <FooterStyle Font-Size="0px" ForeColor="White" />
                <HeaderStyle Font-Size="0px" ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="codigoCatalogo" HeaderText="Código" 
                    SortExpression="codigoCatalogo" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" Width="75px" />
                </asp:BoundField>
                <asp:BoundField DataField="nombreCatalogo" HeaderText="Producto / Servicio" 
                    SortExpression="nombreCatalogo" >
                    <HeaderStyle Width="430px" />
                <ItemStyle Width="430px" />
                </asp:BoundField>
                <asp:BoundField DataField="unidadMedidaAbreviacion" HeaderText="Unidad" >
                <HeaderStyle HorizontalAlign="Center" Width="50px" />
                <ItemStyle HorizontalAlign="Center" Width="50px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Cantidad" SortExpression="PrecioCompra">
               <ItemTemplate>
                        <asp:TextBox ID="IdDetTB" runat="server" BackColor="Transparent" BorderColor="Transparent"
                        BorderStyle="None" Height="0px" Width="0px" TabIndex="-1" ReadOnly="True" 
                            Visible="False"></asp:TextBox>
                    <asp:Label ID="lblCantidad" runat="server" 
                        Text='<%# Bind("CantidadSolicitada") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle Width="80px" />
                <ItemStyle HorizontalAlign="Center" Width="80px" />

                </asp:TemplateField>
                <asp:TemplateField HeaderText="P. Unitario" SortExpression="PrecioCompra">
                <ItemTemplate>
                    <asp:Label ID="lblMonto" runat="server" 
                        Text='<%# Bind("PrecioCompra","{0:n}") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" Width="70px" />
                <ItemStyle HorizontalAlign="Right" Width="70px" />
                <FooterTemplate>
                    &nbsp;&nbsp; Sub Total :<br />&nbsp; Impuesto :<br />&nbsp; Total :
                </FooterTemplate>
                <FooterStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total" SortExpression="PrecioCompra">
                <ItemTemplate>
                    <asp:Label ID="lblMonto7" runat="server" 
                        Text='<%# Bind("PrecioCantComprada","{0:n}") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" Width="70px" />
                <ItemStyle HorizontalAlign="Right" Width="70px" />
                <FooterTemplate>
                    <%# subTotalMostrar().ToString("N2")%><br />
                    <%# igvMostrar().ToString("N2")%><br />
                    <%# totalMostrar().ToString("N2")%>                    
                </FooterTemplate>
                <FooterStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Imp." SortExpression="AfectoIgv">
               <ItemTemplate>
                    <asp:CheckBox ID="cbAfectoIgv" runat="server" 
                        Checked='<%# Bind("AfectoIgv") %>' Enabled="False" />
                </ItemTemplate>
                <HeaderStyle Width="35px" />
                <ItemStyle HorizontalAlign="Center" Width="35px" />
             </asp:TemplateField>
              <asp:TemplateField HeaderText="C. Costo" SortExpression="">
                   <ItemTemplate>
                     <asp:LinkButton ID="lbCentroCosto" runat="server" Font-Size="8pt" 
                         Text="C. Costo" />
                         </ItemTemplate>
                         <HeaderStyle Width="65px" />
                         <ItemStyle HorizontalAlign="Center" Width="65px" />
                   </asp:TemplateField>
                  <asp:TemplateField HeaderText="C. Costo" SortExpression="">
                      <ItemTemplate>
                           <telerik:RadComboBox ID="rcbCentroCostoDetalle" Runat="server" 
                                            AllowCustomText="True" DataSourceID="odsCentroCostoDetalle" 
                                            DataTextField="CodigoElementoGasto" DataValueField="IdCCosto" 
                                            EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                            MarkFirstMatch="True" SelectedValue='<%# Bind("IdCentroCosto") %>' 
                                            ShowMoreResultsBox="True" Width="300px" Enabled="False" 
                               ForeColor="Black">
                                        </telerik:RadComboBox>
                                    </ItemTemplate>
                                    <HeaderStyle Width="250px" />
                                    <ItemStyle HorizontalAlign="Center" Width="250px" />
                                </asp:TemplateField>
            </Columns>
            </asp:GridView>
          </div>
         <asp:ObjectDataSource ID="odsDetalleOrdenCompra" runat="server">
         </asp:ObjectDataSource>
     </fieldset>
      <asp:Panel ID="panelAnular" runat="server" CssClass="CajaDialogo" 
        Width="618px" Visible="False">
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">Anular Orden de Compra</legend>
    <table style="width: 100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td style="width: 65px; height: 30px;">
                Motivo :</td>
            <td style="height: 30px" align="right">
                <asp:LinkButton ID="lbCerrar" runat="server">Cerrar</asp:LinkButton>
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
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="lbCerrar" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
</asp:Panel>
<asp:Panel ID="panelRechazar" runat="server" CssClass="CajaDialogo" 
        Width="618px" Visible="False">
        <table>
        <tr>
        <td class="style4">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <fieldset class="jcv">
<legend class="legendJcv">Rechazar Orden de Compra</legend>
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
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtMotivoRechazo" ErrorMessage="Ingrese motivo." Font-Size="8pt" 
                    ValidationGroup="ww"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="txtMotivoRechazo" runat="server" Height="110px" TextMode="MultiLine" 
                    ValidationGroup="ww" Width="415px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 65px">
                &nbsp;</td>
            <td align="right">
                &nbsp;</td>
        </tr>
    </table>
</fieldset>
      </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="lbCerrar2" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        </td>
        </tr>
        <tr>
        <td align="right" class="style4">
        <asp:LinkButton ID="lbRechazarOrden" runat="server" ValidationGroup="ww">Aceptar</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        </tr>
        </table>
</asp:Panel>
   <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" 
        Runat="server" Skin="Default" AnimationDuration="200">
    </telerik:RadAjaxLoadingPanel>
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
              <Windows>
                <telerik:RadWindow ID="CentroCosto" runat="server" Title="Centro de Costo" Height="300px"
                    Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" />
                    <telerik:RadWindow ID="VentanaCotizacion" runat="server" 
                            Title="Archivos" Height="450px"
                        Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" VisibleStatusbar="False" />
                    <telerik:RadWindow ID="Cuadro" runat="server" Title="Detalle Cotización" Height="450px"
                    Width="800px" Left="150px"/>
            </Windows>
                </telerik:RadWindowManager>
   <asp:ObjectDataSource ID="odsCentroCostoDetalle" runat="server" 
     SelectMethod="GetCCOSTOByIdProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                <SelectParameters>
                <asp:ControlParameter ControlID="txtIdProyecto" Name="_IdProyecto" 
            PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

    <asp:ObjectDataSource ID="odsListaEstadoOrdenCompra" runat="server" 
        SelectMethod="GetAllFromEstadoOrdenCompraByIdOrdenCompra" 
        TypeName="SistFoncreagro.BussinesLogic.EstadoOrdenCompraBL">
        <SelectParameters>
            <asp:QueryStringParameter Name="IdOrdenCompra" QueryStringField="IdOrdenCompra" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="odsTipoPago" runat="server" 
        SelectMethod="GetAllFromTipoPago" 
        TypeName="SistFoncreagro.BussinesLogic.TipoPagoBL"></asp:ObjectDataSource>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="ibActualizar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="updatePanelPrincipal" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                    <telerik:AjaxUpdatedControl ControlID="gvDetalleOrdenCompra" 
                        LoadingPanelID="RadAjaxLoadingPanel1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .style4
        {
            width: 610px;
        }
    </style>
</asp:Content>


