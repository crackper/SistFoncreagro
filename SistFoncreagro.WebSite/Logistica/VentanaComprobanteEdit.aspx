<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaComprobanteEdit.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaComprobanteEdit" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
  </head>
<body>
    <form id="form1" runat="server">
    <table>
    <tr>
    <td style="font-size: 12px">Área / Proyecto :</td>
    <td colspan="6">
   <telerik:RadComboBox ID="rcmProyecto" Runat="server" AllowCustomText="True" 
            DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
    DataValueField="IdProyecto" EnableLoadOnDemand="True" 
            EnableVirtualScrolling="True" ItemsPerRequest="10" Width="520px">
</telerik:RadComboBox>
                </td>
    <td>
        <asp:RequiredFieldValidator ID="rfvNumero4" runat="server" 
            ControlToValidate="rcmProyecto" ErrorMessage="*" Font-Size="7pt" 
            ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">Proveedor :</td>
    <td colspan="6">
    <telerik:RadComboBox ID="rcbProveedor" Runat="server" DataSourceID="odsProveedor" DataTextField="RazonSocial" 
     DataValueField="IdProveedorCliente" EnableLoadOnDemand="True" MarkFirstMatch="True" 
ShowDropDownOnTextboxClick="False"  style="margin-left: 0px" Width="520px" 
            EmptyMessage="Ingrese Ruc o Razón social..." TabIndex="1">
</telerik:RadComboBox>
                                                        </td>
    <td>
        <asp:RequiredFieldValidator ID="rfvNumero5" runat="server" 
            ControlToValidate="rcbProveedor" ErrorMessage="*" Font-Size="7pt" 
            ValidationGroup="a"></asp:RequiredFieldValidator>
        </td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">Documento :</td>
    <td colspan="3">
                        <telerik:RadComboBox ID="rcbTipoDocumento" Runat="server" AllowCustomText="True" 
                            DataSourceID="odsTipoDocumento" DataTextField="Nombre" 
                            DataValueField="IdTipoDocumento" EnableLoadOnDemand="True" 
                            EnableVirtualScrolling="True" ItemsPerRequest="10" 
                        MarkFirstMatch="True" Width="325px" ValidationGroup="a" TabIndex="2">
                        </telerik:RadComboBox>
                        </td>
    <td><asp:RequiredFieldValidator ID="rfvNumero2" runat="server" 
                            ControlToValidate="rcbTipoDocumento" ErrorMessage="*" Font-Size="7pt" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
                             </td>
    <td style="font-size: 12px">
        Moneda :</td>
    <td>
        <asp:DropDownList ID="ddlMoneda" runat="server" DataSourceID="odsMoneda" 
            DataTextField="Nombre" DataValueField="IdMoneda" Width="105px" 
            TabIndex="3">
        </asp:DropDownList>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">Serie :</td>
    <td>

                    <asp:TextBox ID="txtSerie" runat="server" Width="100px" TabIndex="4"></asp:TextBox>
                &nbsp;
                   
                    <asp:RequiredFieldValidator ID="rfvNumero0" runat="server" 
                        ControlToValidate="txtSerie" ErrorMessage="*" Font-Size="7pt" ValidationGroup="a"></asp:RequiredFieldValidator>
                        </td>
    <td style="font-size: 12px">
       Número :</td>
    <td>
                    <asp:TextBox ID="txtNumero" runat="server" Width="100px" TabIndex="5"></asp:TextBox>
                </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
    <td style="font-size: 12px">Fecha :</td>
    <td>

                    <telerik:RadDatePicker ID="rdpFecha" Runat="server" Width="110px" TabIndex="7">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" TabIndex="7"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" TabIndex="7"></DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero1" runat="server" 
                        ControlToValidate="rdpFecha" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">Monto :</td>
    <td colspan="3">
                    <asp:TextBox ID="txtMonto" runat="server" Width="100px" TabIndex="6"></asp:TextBox>
                    &nbsp;
                    <asp:RequiredFieldValidator ID="rfvNumero3" runat="server" 
                        ControlToValidate="txtMonto" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                    </td>
    <td>
                    &nbsp;</td>
    <td style="font-size: 12px">

                    Fecha Recp. :</td>
    <td>

                    <telerik:RadDatePicker ID="rdpFechaRecepcion" Runat="server" Width="110px" 
                        TabIndex="7">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" TabIndex="7"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" TabIndex="7"></DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero10" runat="server" 
                        ControlToValidate="rdpFechaRecepcion" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">Observaciones :</td>
    <td colspan="3">
        <asp:TextBox ID="txtObservaciones" runat="server" Width="320px" TabIndex="8"></asp:TextBox>
        </td>
    <td>&nbsp;</td>
    <td style="font-size: 12px">
            Nro. Vales :</td>
    <td>
            <telerik:RadNumericTextBox ID="RadNrovales" Runat="server" MaxLength="11" 
            Value="0" Width="100px" TabIndex="9">
                <NumberFormat DecimalDigits="0" GroupSeparator="" GroupSizes="1" />
            </telerik:RadNumericTextBox>
        </td>
    <td>&nbsp;</td>
    <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Actualizar" ValidationGroup="a" 
                        TabIndex="10" Width="75px" />
                </td>
    </tr>
    <tr>
    <td style="font-size: 12px" align="center" colspan="7">
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">Producto / Servicio :</td>
    <td colspan="3">
                                <telerik:RadComboBox ID="rcbProductoServicio" Runat="server" 
                                    DataSourceID="odsCatalogoBusqueda" DataTextField="CodigoDescripcion" 
                                    DataValueField="IdCatalogo" 
            EnableLoadOnDemand="True" MarkFirstMatch="True" 
                                    ShowDropDownOnTextboxClick="False" 
                                    style="margin-left: 0px" ValidationGroup="poducto" Width="325px" 
                                    EmptyMessage="Ingrese el producto o servicio..." TabIndex="11">
                                </telerik:RadComboBox>
                                </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero6" runat="server" 
                        ControlToValidate="rcbProductoServicio" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="b"></asp:RequiredFieldValidator>
                    </td>
    <td style="font-size: 12px">
            Cantidad :</td>
    <td>
            <telerik:RadNumericTextBox ID="RadCantidad" Runat="server" MaxLength="11" 
                Width="100px" TabIndex="13">
                <NumberFormat DecimalDigits="2" GroupSeparator="" GroupSizes="1" />
            </telerik:RadNumericTextBox>
        </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero8" runat="server" 
                        ControlToValidate="RadCantidad" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="b"></asp:RequiredFieldValidator>
                    </td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px">C. Costo :</td>
    <td colspan="3">
                    <telerik:RadComboBox ID="rcbCentroCosto" Runat="server" 
                        Width="325px" DataTextField="CodigoElementoGasto" 
                        DataValueField="IdCCosto" DataSourceID="odsCentroCosto" AllowCustomText="True" 
                                    EnableLoadOnDemand="True" 
            EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                    MarkFirstMatch="True" TabIndex="12">
                    </telerik:RadComboBox>
        </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero7" runat="server" 
                        ControlToValidate="rcbCentroCosto" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="b"></asp:RequiredFieldValidator>
                    </td>
    <td style="font-size: 12px">
            Precio :</td>
    <td>
            <telerik:RadNumericTextBox ID="RadPrecio" Runat="server" MaxLength="11" 
                Width="100px" TabIndex="13">
                <NumberFormat DecimalDigits="2" GroupSeparator="" GroupSizes="1" />
            </telerik:RadNumericTextBox>
        </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero9" runat="server" 
                        ControlToValidate="RadPrecio" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="b"></asp:RequiredFieldValidator>
                    </td>
    <td>
                    <asp:Button ID="btnAgregarDetalle" runat="server" Text="Agregar" ValidationGroup="b" 
                        TabIndex="14" Width="75px" />
                </td>
    </tr>
    <tr>
    <td style="font-size: 12px">&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td style="font-size: 12px">
            &nbsp;</td>
    <td align="right">
                    &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td style="font-size: 12px" colspan="7">
        <asp:GridView ID="gvDetalleComprobante" runat="server" AutoGenerateColumns="False" 
            DataSourceID="odsDetalleComprobante">
            <Columns>
             <asp:ButtonField ButtonType="Image" CommandName="Eliminar" FooterText="Eliminar" ImageUrl="~/img/Delete.gif">
              <ItemStyle HorizontalAlign="Center" Width="15px" />
              </asp:ButtonField>
                <asp:BoundField DataField="NombreCatalogo" 
                    HeaderText="Producto / Servicio" SortExpression="NombreCatalogo" >
                <ItemStyle Width="410px" />
                </asp:BoundField>
                <asp:BoundField DataField="NombreCentroCosto" HeaderText="C. Costo" 
                    SortExpression="NombreCentroCosto" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cant." 
                    SortExpression="Cantidad" >
                <ItemStyle HorizontalAlign="Center" Width="50px" />
                </asp:BoundField>
                <asp:BoundField DataField="Precio" HeaderText="Precio" 
                    SortExpression="Precio" >
                <HeaderStyle HorizontalAlign="Center" Width="40px" />
                <ItemStyle HorizontalAlign="Center" Width="40px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="Sub Total">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# calculo(decimal.Parse(Eval("Cantidad").ToString()),Eval("Precio")).ToString("N2") %>'></asp:Label>
                        <asp:TextBox ID="txtIdDetalle" runat="server" Height="0px" Width="0px" 
                            Text='<%# Bind("IdDetalleComprobante") %>' Visible="False"></asp:TextBox>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Right" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </td>
    <td>&nbsp;</td>
    <td valign="bottom">
                    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" 
                        TabIndex="14" Width="75px" Visible="False" />
                </td>
    </tr>
    <tr>
    <td style="font-size: 12px">&nbsp;</td>
    <td>
        &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>
    </table>
    <asp:ObjectDataSource ID="odsProyecto" runat="server" 
    SelectMethod="GetAllFromProyecto" 
    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL">
    </asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsProveedor" 
        runat="server" SelectMethod="GetAllFromProveedorClienteByParametro" 
        TypeName="SistFoncreagro.BussinesLogic.ProveedorClienteBL" 
    OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="*" Name="parametro" Type="String" />
                                    </SelectParameters>
    </asp:ObjectDataSource>

        <asp:ObjectDataSource ID="odsMoneda" runat="server" 
            SelectMethod="GetAllFromMoneda" 
            TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
                                <asp:ObjectDataSource ID="odsCatalogoBusqueda" runat="server" 
                                    SelectMethod="GetAllFromCatalogoFullByParametro" 
                                    
        TypeName="SistFoncreagro.BussinesLogic.CatalogoBL" 
        OldValuesParameterFormatString="original_{0}">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="$" Name="parametro" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
      <asp:ObjectDataSource ID="odsCentroCosto" runat="server" 
          SelectMethod="GetCCOSTOByIdProyecto" 
          TypeName="SistFoncreagro.BussinesLogic.CCostoBL" 
        OldValuesParameterFormatString="original_{0}">
          <SelectParameters>
              <asp:ControlParameter ControlID="rcmProyecto" Name="_IdProyecto" 
                  PropertyName="SelectedValue" Type="Int32" />
          </SelectParameters>
      </asp:ObjectDataSource>

        <asp:ObjectDataSource ID="odsDetalleComprobante" runat="server" 
            SelectMethod="GetAllFromDetalleComprobanteByIdOcxFactura" 
            TypeName="SistFoncreagro.BussinesLogic.DetalleComprobanteBL">
            <SelectParameters>
                <asp:QueryStringParameter Name="idOcxFactura" QueryStringField="idc" 
                    Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

   <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
     SelectMethod="GetAllFromTIPODOCUMENTO" 
        TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
    </asp:ObjectDataSource>
        <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type="text/javascript">

            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }

            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
        </script>
    </telerik:RadCodeBlock>  
    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
    </telerik:RadScriptManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                    <telerik:AjaxUpdatedControl ControlID="rcbCentroCosto" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnAgregarDetalle">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                    <telerik:AjaxUpdatedControl ControlID="rcbProductoServicio" />
                    <telerik:AjaxUpdatedControl ControlID="RadCantidad" />
                    <telerik:AjaxUpdatedControl ControlID="rcbCentroCosto" />
                    <telerik:AjaxUpdatedControl ControlID="RadPrecio" />
                    <telerik:AjaxUpdatedControl ControlID="gvDetalleComprobante" />
                    <telerik:AjaxUpdatedControl ControlID="btnFinalizar" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="btnFinalizar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="lblMensaje" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    </form>
</body>
</html>
