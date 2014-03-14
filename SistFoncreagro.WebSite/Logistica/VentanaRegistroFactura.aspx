<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaRegistroFactura.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaRegistroFactura" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  </head>
<body>
    <form id="form1" runat="server">
    <div style="width: 610px">
          <fieldset> 
        <table style="width: 599px">
            <tr>
                <td style="font-size: 12px">
                    O/C :</td>
                <td>
                    <asp:Label ID="lblOrden" runat="server" Font-Size="9pt"></asp:Label>
                </td>
                <td colspan="4" style="font-size: 12px">
                    Monto :
                    <asp:Label ID="lblMonto" runat="server" Font-Size="9pt"></asp:Label>
                </td>
                <td align="right" style="font-size: 12px">
                    Área :
                    </td>
                <td colspan="2">
                    <asp:Label ID="lblArea" runat="server" Font-Size="9pt"></asp:Label>
                </td>
                <td>
                                        &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: 12px">
                    Tipo Doc. :</td>
                <td colspan="11">
                        <telerik:RadComboBox ID="rcbTipoDocumento" Runat="server" AllowCustomText="True" 
                            DataSourceID="odsTipoDocumento" DataTextField="Nombre" 
                            DataValueField="IdTipoDocumento" EnableLoadOnDemand="True" 
                            EnableVirtualScrolling="True" ItemsPerRequest="10" 
                        MarkFirstMatch="True" Width="325px" ValidationGroup="a">
                        </telerik:RadComboBox>
                        &nbsp;&nbsp;&nbsp; <asp:RequiredFieldValidator ID="rfvNumero2" runat="server" 
                            ControlToValidate="rcbTipoDocumento" ErrorMessage="*" Font-Size="7pt" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
                        </td>
            </tr>
            <tr>
                <td style="font-size: 12px">
                    Serie :</td>
                <td>

                    <asp:TextBox ID="txtSerie" runat="server" Width="100px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvNumero0" runat="server" 
                        ControlToValidate="txtSerie" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
                <td>
                   
                </td>
                <td style="font-size: 12px">
                    Número :</td>
                <td align="right">
                    <asp:TextBox ID="txtNumero" runat="server" Width="100px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvNumero" runat="server" 
                        ControlToValidate="txtNumero" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
                <td style="font-size: 12px">
                    Monto :</td>
                <td>

                    <asp:TextBox ID="txtMonto" runat="server" Width="100px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvNumero3" runat="server" 
                        ControlToValidate="txtMonto" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: 12px">
                    Fecha :</td>
                <td>

                    <telerik:RadDatePicker ID="rdpFecha" Runat="server" Width="110px">
                    </telerik:RadDatePicker>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvNumero1" runat="server" 
                        ControlToValidate="rdpFecha" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td style="font-size: 12px">
                    Fecha Recep. :</td>
                <td align="right">

                    <telerik:RadDatePicker ID="rdpFechaRecepcion" Runat="server" Width="110px">
                    </telerik:RadDatePicker>
                </td>
                <td>

                    <asp:RequiredFieldValidator ID="rfvNumero4" runat="server" 
                        ControlToValidate="rdpFechaRecepcion" ErrorMessage="*" Font-Size="7pt" 
                        ValidationGroup="a"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td align="center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="a" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>

                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="font-size: 12px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                   &nbsp;</td>
            </tr>
            <tr>
                <td colspan="12">

                    <asp:GridView ID="gvDetalle" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="odsOcxFactura" Font-Size="9pt" Width="600px">
                        <Columns>
                                                     <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                    FooterText="Eliminar" ImageUrl="~/img/Delete.gif">
                                <ItemStyle HorizontalAlign="Center" Width="15px" />
                                </asp:ButtonField>
                            <asp:BoundField DataField="NombreTipoDoc" HeaderText="Tipo" 
                                SortExpression="NombreTipoDoc" />
                                                     <asp:TemplateField HeaderText="Serie">
                                                         <ItemTemplate>
                                                             <asp:Label ID="Label1" runat="server" Text='<%# Bind("Serie") %>'></asp:Label>
                                                               <asp:TextBox ID="txtIdDet" runat="server" Height="0px" ReadOnly="True" 
                                                                    Text='<%# Bind("IdOcxFactura") %>' Visible="False" Width="0px"></asp:TextBox>
                                                         </ItemTemplate>
                                                         <HeaderStyle HorizontalAlign="Center" />
                                                         <ItemStyle HorizontalAlign="Center" />
                                                     </asp:TemplateField>
                            <asp:BoundField DataField="Numero" HeaderText="Número" 
                                SortExpression="Numero" >
                                                     <HeaderStyle HorizontalAlign="Center" />
                                                     <ItemStyle HorizontalAlign="Center" />
                                                     </asp:BoundField>
                            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto" 
                                DataFormatString="{0:n}" >
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" 
                                DataFormatString="{0:dd/MM/yyyy}" >
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:HyperLinkField 
                                Text="Det..." 
                                DataNavigateUrlFields="NombreDocumento,NombreTipoDoc,Monto,IdOrdenCompra,IdOcxFactura,TipoRendicion" 
                                
                                
                                                         DataNavigateUrlFormatString="~/Logistica/VentanaRegistroFacturaDetalle.aspx?Doc={0}&amp;tip={1}&amp;Mont={2}&amp;idOc={3}&amp;idOcfac={4}&amp;tipoRend={5}" >
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:HyperLinkField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>

                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
          </fieldset> 
    </div>

                    <asp:ObjectDataSource ID="odsOcxFactura" runat="server" 
                        SelectMethod="GetAllFromOcxFacturaByIdOrdenCompra" 
                        TypeName="SistFoncreagro.BussinesLogic.OcxFacturaBL" 
        OldValuesParameterFormatString="original_{0}">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="IdOrdenCompra" QueryStringField="idoc" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>

   <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
     SelectMethod="GetAllFromTIPODOCUMENTO" 
        TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
    </asp:ObjectDataSource>

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
