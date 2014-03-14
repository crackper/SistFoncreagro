<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaComprobante.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaComprobante" %>
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
            EnableVirtualScrolling="True" ItemsPerRequest="10" Width="530px">
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
ShowDropDownOnTextboxClick="False"  style="margin-left: 0px" Width="530px" 
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
                        &nbsp; </td>
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
                    <asp:RequiredFieldValidator ID="rfvNumero6" runat="server" 
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

                    Fecha Recep. :</td>
    <td>

                    <telerik:RadDatePicker ID="rdpFechaRecepcion" Runat="server" Width="110px" 
                        TabIndex="7">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy" TabIndex="7"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" TabIndex="7"></DatePopupButton>
                    </telerik:RadDatePicker>
                </td>
    <td>
                    <asp:RequiredFieldValidator ID="rfvNumero1" runat="server" 
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
            Value="0" Width="50px" TabIndex="9">
                <NumberFormat DecimalDigits="0" GroupSeparator="" GroupSizes="1" />
            </telerik:RadNumericTextBox>
        </td>
    <td>&nbsp;</td>
    <td>
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="a" TabIndex="10" Width="75px" />
                </td>
    </tr>
    <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>
            &nbsp;</td>
    <td align="right">
                          &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>
    <tr>
    <td>&nbsp;</td>
    <td colspan="3">
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

   <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
     SelectMethod="GetAllFromTIPODOCUMENTO" 
        TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
    </asp:ObjectDataSource>

        <asp:ObjectDataSource ID="odsMoneda" runat="server" 
            SelectMethod="GetAllFromMoneda" 
            TypeName="SistFoncreagro.BussinesLogic.MonedaBL"></asp:ObjectDataSource>
        </td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    </tr>
    </table>
    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
    </telerik:RadScriptManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="btnGuardar">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="gvDetalle" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    </form>
</body>
</html>