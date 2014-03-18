<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterMonitoreo1.master" CodeBehind="DetalleOC.aspx.vb" Inherits="SistFoncreagro.WebSite.DetalleOC" %>
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

    function CargarHistorico(idOc) {
        var oWnd = radopen("VentanaHistoricoOrden.aspx?IdOrden=" + idOc, "Historico");
    }

    function CargarCuadro(idCoti) {
        var oWnd = radopen("VentanaCuadroComparativo.aspx?IdCot=" + idCoti, "Cuadro");
    }

</script>
</telerik:RadCodeBlock>
    <fieldset>
            <asp:LinkButton ID="lbHistorico" runat="server" Text="Histórico" Visible="True" />
                   &nbsp;&nbsp;&nbsp;&nbsp;
              &nbsp;&nbsp;&nbsp;&nbsp;
                          <asp:LinkButton ID="lbCuadroComparativo" runat="server" Text="Comparativo" Visible="True" />
                     &nbsp;&nbsp;&nbsp;&nbsp;
                   &nbsp;&nbsp;&nbsp;&nbsp;
                   </fieldset>
      <fieldset class="jcv">
       <legend class="legendJcv">ORDEN DE COMPRA</legend>
           <asp:Panel ID="updatePanelPrincipal" runat="server" Width="900px">
               <table id="tablaOrdenCompra" class="tabla5" cellpadding="0" cellspacing="0" 
                   style="width: 100%;">
          <tr>
              <td align="left" style="width: 2%" class="Texto">
                         <asp:TextBox ID="txtValidarOrden" runat="server" Visible="False" Width="0px" Height="0px"></asp:TextBox></td>
              <td align="left" style="font-weight: 600; " 
                  class="style14">
                    &nbsp;</td>
              <td style="width: 29%;">
                    &nbsp;</td>
              <td style="width: 14%; font-weight: 600; height: 20px;">
                  &nbsp;</td>
              <td colspan="3">
                  &nbsp;</td>
          </tr>
          <tr>
              <td align="left" style="width: 2%" class="Texto">
              </td>
              <td align="left" style="font-weight: 600; " 
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
                       style="font-weight: 600; ">
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
                       style="font-weight: 600; ">
                       Área/Proyecto :</td>
                   <td colspan="5">
                       <asp:Label ID="lblAreaProyecto" runat="server" Font-Size="9pt"></asp:Label>
                   </td>
               </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="right" class="Texto7" 
                           style="font-weight: 600;">
                           Periodo :&nbsp; &nbsp;</td>
                       <td colspan="5" style="height: 19px; ">
                           <asp:Label ID="lblPeriodo" runat="server"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="right" class="Texto7" 
                           style="font-weight: 600;">
                           Ruta : &nbsp;&nbsp;</td>
                       <td colspan="5" style="height: 19px; ">
                           <asp:Label ID="lblOrigen" runat="server"></asp:Label>
                       </td>
                   </tr>
          <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       &nbsp;</td>
                   <td align="left" class="Texto7" 
                       style="font-weight: 600; ">
                       Estado :</td>
                   <td style="width: 29%; height: 19px;">
                       <asp:Label ID="lblEstadoOrdenCompra" runat="server"></asp:Label>
                   </td>
                   <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto7">
                       Documento :</td>
                   <td>
                       <asp:DropDownList ID="ddlTipoDocumento" runat="server" Width="100px" 
                           Font-Size="9pt" Enabled="False">
                           <asp:ListItem Value="2">Factura</asp:ListItem>
                           <asp:ListItem Value="4">Boleta</asp:ListItem>
                           <asp:ListItem Value="3">Honorarios Con Ret.</asp:ListItem>
                           <asp:ListItem Value="31">Honorarios Sin Ret.</asp:ListItem>
                       </asp:DropDownList>
                   </td>
               <td style="font-weight: 600; " class="Texto7">
                       Moneda :</td>
                   <td>
                       <asp:DropDownList ID="ddlMoneda" runat="server" DataSourceID="odsMoneda" 
                           DataTextField="Nombre" DataValueField="IdMoneda" Width="100px" 
                           Enabled="False">
                       </asp:DropDownList>
                   </td>
               </tr>
               <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       <asp:TextBox ID="txtIdProyecto" runat="server" Height="0px" ReadOnly="True" 
                           Visible="False" Width="0px"></asp:TextBox>
                   </td>
                   <td align="left" class="Texto7" 
                       style="font-weight: 600; ">
                       Proveedor :</td>
                   <td style="height: 19px;" colspan="5">
                       <asp:Label ID="lblProveedorTexto" runat="server"></asp:Label>
                       <asp:Label ID="lblMoneda" runat="server"></asp:Label>
                   </td>
               </tr>
                     <tr>
                   <td align="left" class="Texto" style="width: 2%">
                       <asp:TextBox ID="txtIdCotizacion" runat="server" Height="0px" 
                           Visible="False" Width="0px"></asp:TextBox>
                           <asp:TextBox ID="txtIdProveedor" runat="server" Height="0px" 
                           Visible="False" Width="0px"></asp:TextBox>
                       </td>
                   <td align="left" class="Texto7" 
                       style="font-weight: 600; ">
                       Sustento :</td>
                   <td style="height: 20px;" valign="middle" colspan="5">
                       <asp:Label ID="lblSustento" runat="server"></asp:Label>
                   </td>
               </tr>
                   <tr>
                       <td align="left" class="Texto" style="width: 2%">
                           &nbsp;</td>
                       <td align="left" class="Texto7" 
                           style="font-weight: 600; ">
                           Tipo Pago :</td>
                       <td style="width: 29%; height: 20px;" valign="middle">
                           <asp:DropDownList ID="ddlTipoPago" runat="server" DataSourceID="odsTipoPago" 
                               DataTextField="Descripcion" DataValueField="IdTipo" Width="150px" 
                               Enabled="False">
                           </asp:DropDownList>
                           <asp:RegularExpressionValidator ID="rev" runat="server" 
                               ControlToValidate="ddlTipoPago" ErrorMessage="Seleccione tipo pago" 
                               Font-Size="7.5pt" ValidationExpression="[1-9]"></asp:RegularExpressionValidator>
                       </td>
                       <td style="width: 14%; font-weight: 600; height: 20px;" class="Texto7">
                           % Anticipo :</td>
                       <td style=" height: 20px;" valign="middle">
                           <asp:TextBox ID="txtAnticipo" runat="server" Width="68px" ReadOnly="True"></asp:TextBox>
                       </td>
                       <td style="font-weight: 600; " class="Texto7">
                           Destino :</td>
                       <td style="height: 20px;" valign="middle">
                           <asp:DropDownList ID="ddlDestino" runat="server" Width="100px" Enabled="False">
                               <asp:ListItem>Institución</asp:ListItem>
                               <asp:ListItem>Donación</asp:ListItem>
                           </asp:DropDownList>
                       </td>
                   </tr>
          <tr>
              <td align="left" style="width: 2%; height: 29px;">
                    </td>
              <td align="left" style="font-weight: 600; " 
                  class="Texto7">
                    Observaciones :<br />
                </td>
              <td colspan="4" style="height: 40px;">
                    <asp:TextBox ID="txtObservacion" runat="server" Height="37px" 
                        TextMode="MultiLine" Width="535px" ReadOnly="True"></asp:TextBox>
                </td>
              <td style="height: 40px;" align="center">
                  &nbsp;</td>
          </tr>
                   <tr>
                       <td align="left" style="width: 2%">
                       </td>
                       <td align="left" class="Texto7" 
                           style="font-weight: 600; " rowspan="3">
                           <asp:Label ID="lbResponsable" runat="server" Text="Responsable :" 
                               Visible="False"></asp:Label>
                       </td>
                       <td colspan="5" rowspan="3">
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                               BorderColor="White" BorderStyle="None" 
                               DataSourceID="odsListaEstadoOrdenCompra" Width="499px" CssClass="Texto7">
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
              <td style="font-weight: 600; " class="style14">
                    <asp:Label ID="lblProveedor" runat="server" Height="0px" Text="1" 
                        Visible="False" Width="0px" ForeColor="White"></asp:Label>
              </td>
              <td colspan="5">
                  <asp:TextBox ID="txtIgv" runat="server" Height="0px" Visible="False" 
                      Width="0px"></asp:TextBox>
              </td>
          </tr>
      </table>   
      </asp:Panel>
      </fieldset>
     <fieldset class="jcv">
        <legend class="legendJcv">DETALLE ORDEN DE COMPRA</legend>
        <div style="overflow: scroll; width: 900px;">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvDetalleOrdenCompra" runat="server" 
                        AutoGenerateColumns="False" CssClass="Texto7" 
                        DataKeyNames="IdDetalleOrdenCompra,codigoCatalogo,nombreCatalogo" 
                        ShowFooter="True" Width="1106px">
                        <Columns>
                            <asp:BoundField DataField="IdDetalleOrdenCompra" 
                                HeaderText="IdDetalleOrdenCompra" SortExpression="IdDetalleOrdenCompra" 
                                Visible="False">
                            <ControlStyle Font-Size="0px" ForeColor="White" />
                            <FooterStyle Font-Size="0px" ForeColor="White" />
                            <HeaderStyle Font-Size="0px" ForeColor="White" />
                            </asp:BoundField>
                            <asp:BoundField DataField="codigoCatalogo" HeaderText="Código" 
                                SortExpression="codigoCatalogo">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" Width="75px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="nombreCatalogo" HeaderText="Producto / Servicio" 
                                SortExpression="nombreCatalogo">
                            <HeaderStyle Width="460px" />
                            <ItemStyle Width="460px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="unidadMedidaAbreviacion" HeaderText="Unidad">
                            <HeaderStyle HorizontalAlign="Center" Width="40px" />
                            <ItemStyle HorizontalAlign="Center" Width="40px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="CantidadSolicitada" HeaderText="Cantidad">
                            <HeaderStyle HorizontalAlign="Center" Width="50px" />
                            <ItemStyle HorizontalAlign="Center" Width="50px" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="P. Unitario">
                                <FooterTemplate>
                                    Sub Total :<br /> Impuesto :<br /> Total :
                                </FooterTemplate>
                                <FooterStyle HorizontalAlign="Center" />
                                <ItemTemplate>
                                    <asp:TextBox ID="txtPrecioDetalle" runat="server" 
                                        Text='<%# Bind("PrecioCompra","{0:N}") %>' Width="60px" 
                                        Enabled="<%# validarEnabled() %>" ReadOnly="True"></asp:TextBox>
                                </ItemTemplate>
                                <HeaderStyle Width="50px" />
                                <ItemStyle Width="50px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sub Total">
                                <ItemTemplate>
                                    <asp:Label ID="lblSubTotal" runat="server" 
                                        Text='<%# GetMonto(decimal.Parse(Eval("Subtotal").ToString()),Eval("AfectoIgv")).ToString("N2") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                                    <%# GetSubTotal().ToString("N2")%><br />
                                                    <%# GetIgv().ToString("N2")%><br />
                                                    <%# GetTotal().ToString("N2")%>                    
                                                </FooterTemplate>
                                <FooterStyle HorizontalAlign="Right" Width="50px" />
                                <HeaderStyle HorizontalAlign="Center" Width="50px" />
                                <ItemStyle HorizontalAlign="Right" Width="50px" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Imp." SortExpression="AfectoIgv">
                                <ItemTemplate>
                                    <asp:CheckBox ID="cbAfectoIgv" runat="server" 
                                        Checked='<%# Bind("AfectoIgv") %>' Enabled="False" />
                                    <asp:TextBox ID="txtIdDetalleRequerimiento" runat="server" Height="0px" 
                                        Text='<%# Bind("IdDetalleRequerimiento") %>' Visible="False" Width="0px"></asp:TextBox>
                                    <asp:TextBox ID="txtIdDetalleOrden" runat="server" Height="0px" 
                                        Text='<%# Bind("IdDetalleOrdenCompra") %>' Visible="False" Width="0px"></asp:TextBox>
                                </ItemTemplate>
                                <HeaderStyle Width="30px" />
                                <ItemStyle HorizontalAlign="Center" Width="30px" />
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
                                    Width="300px" DataTextField="CodigoElementoGasto" DataValueField="IdCCosto" 
                                        DataSourceID="odsCentroCostoDetalle" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                        MarkFirstMatch="True" SelectedValue='<%# Bind("IdCentroCosto") %>' 
                                        Enabled="False">
                                    </telerik:RadComboBox>
                                </ItemTemplate>
                                <ControlStyle Width="300px" />
                                <FooterStyle Width="300px" />
                                <HeaderStyle Width="300px" />
                                <ItemStyle HorizontalAlign="Center" Width="300px" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
               
            </asp:UpdatePanel>
        </div>
     </fieldset>
   <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" 
        Runat="server" Skin="Default" AnimationDuration="200">
    </telerik:RadAjaxLoadingPanel>
   <asp:ObjectDataSource ID="odsCentroCostoDetalle" runat="server" 
     SelectMethod="GetCCOSTOByIdProyecto" 
        TypeName="SistFoncreagro.BussinesLogic.CCostoBL" 
        OldValuesParameterFormatString="original_{0}">
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
               <asp:ObjectDataSource ID="odsMoneda" runat="server" 
                   SelectMethod="GetAllFromMoneda" 
                   TypeName="SistFoncreagro.BussinesLogic.MonedaBL">
                   </asp:ObjectDataSource>   
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
              <Windows>
                <telerik:RadWindow ID="CentroCosto" runat="server" Title="Centro de Costo" Height="300px"
                    Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" />
                     <telerik:RadWindow ID="VentanaCotizacion" runat="server" 
                            Title="Archivos" Height="450px"
                        Width="705px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" VisibleStatusbar="False" />
                          <telerik:RadWindow ID="Historico" runat="server" Title="Histórico" Height="300px"
                    Width="800px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" VisibleStatusbar="False" />
                    <telerik:RadWindow ID="Cuadro" runat="server" Title="Cuadro Comparativo" Height="450px"
                    Width="800px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" VisibleStatusbar="False" />
            </Windows>
                </telerik:RadWindowManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="btnActualizarCabecera">
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>
