<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaRegistroFacturaDetalle.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaRegistroFacturaDetalle" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
    </telerik:RadScriptManager>
    <div style="width: 610px">
          <fieldset> 
        <table>
            <tr>
                <td>
                    Tipo Doc. :</td>
                <td>

                    <asp:Label ID="lblTipo" runat="server" Font-Size="10pt"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="right">
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="10pt">&lt;&lt;&lt; Regresar</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td>
                    Número :</td>
                <td>

                    <asp:Label ID="lblDocumento" runat="server" Font-Size="10pt"></asp:Label>
                </td>
                <td>
                    Monto :&nbsp;
                    <asp:Label ID="lblMonto" runat="server" Font-Size="10pt"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="right">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    C. Costo :</td>
                <td colspan="2">

                    <telerik:RadComboBox ID="rcmbCCosto" Runat="server" AutoPostBack="True" 
                        DataSourceID="odsccOfOc" DataTextField="CodigoElementoGasto" 
                        DataValueField="IdCCosto" Width="300px">
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RadioButton ID="rdbCantidad" runat="server" GroupName="a" 
                        Text="Cantidad" AutoPostBack="True" Checked="True" />
                </td>
                <td align="right">
                    <asp:RadioButton ID="rdbPrecio" runat="server" GroupName="a" Text="Precio" 
                        AutoPostBack="True" />
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                          <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="odsDetalleOcByIdCcosto" Font-Size="9pt" Width="600px">
                        <Columns>
                            <asp:BoundField DataField="DescripcionGen" HeaderText="Producto" 
                                SortExpression="DescripcionGen" />
                            <asp:TemplateField HeaderText="Cantidad">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtCantidadDet" runat="server" BorderColor="White" 
                                        Font-Size="9pt" Text='<%# Bind("CantidadComprada") %>' Width="40px"></asp:TextBox>
                                    <asp:TextBox ID="txtIdDetOc" runat="server" Height="0px" ReadOnly="True" 
                                        Text='<%# Bind("IdDetalleOrdenCompra") %>' Visible="False" Width="0px"></asp:TextBox>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                               <asp:TemplateField HeaderText="Precio" Visible="False">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtPrecioDet" runat="server" BorderColor="White" 
                                        Font-Size="9pt" Text='<%# Bind("PrecioCompra") %>' Width="60px"></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="PrecioCompra" DataFormatString="{0:n}" 
                                HeaderText="Precio" ReadOnly="True" SortExpression="PrecioCompra">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PrecioCantComprada" DataFormatString="{0:n}" 
                                HeaderText="Sub Total" ReadOnly="True" SortExpression="PrecioCantComprada">
                            <HeaderStyle HorizontalAlign="Center" />
                            <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Item">
                                <ItemTemplate>
                                    <asp:CheckBox ID="cbDetalle" runat="server" 
                                        Checked='<%# Bind("EstadoFactura") %>' 
                                        Enabled='<%# Validar(Eval("CantidadComprada")) %>' />
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Center" Width="20px" />
                                <ItemStyle HorizontalAlign="Center" Width="20px" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                                          </ContentTemplate>
                </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">

                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="right">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="a" />
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="odsDet" Font-Size="9pt" Width="600px">
                        <Columns>
                             <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                    FooterText="Eliminar" ImageUrl="~/img/Delete.gif">
                                <ItemStyle HorizontalAlign="Center" Width="15px" />
                                </asp:ButtonField>
                            <asp:BoundField DataField="CCosto" HeaderText="C. Costo" 
                                SortExpression="CCosto" />
                                                        <asp:BoundField DataField="Producto" HeaderText="Producto" 
                                                            SortExpression="Producto" />
                                                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" 
                                                            SortExpression="Cantidad" 
                                 DataFormatString="{0:n}" >
                             <HeaderStyle HorizontalAlign="Center" />
                             <ItemStyle HorizontalAlign="Center" />
                             </asp:BoundField>
                            <asp:BoundField DataField="PCompraDetalle" 
                                HeaderText="P. Compra" SortExpression="PCompraDetalle" 
                                 DataFormatString="{0:n}">
                             <HeaderStyle HorizontalAlign="Center" />
                             <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                                                        <asp:TemplateField HeaderText="Sub Total">
                                                            <ItemTemplate>
                                                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("SubTotal","{0:n}") %>'></asp:Label>
                                                                <asp:TextBox ID="txtIdDet" runat="server" Height="0px" ReadOnly="True" 
                                                                    Text='<%# Bind("IdDetOcxFactura") %>' Visible="False" Width="0px"></asp:TextBox>
                                                            </ItemTemplate>
                                                            <ItemStyle HorizontalAlign="Right" />
                             </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                              </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">

                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="right">
                    <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" 
                        ValidationGroup="a" />
                </td>
            </tr>
            </table>
          </fieldset> 
    </div>
                    <asp:ObjectDataSource ID="odsDet" runat="server" 
                        SelectMethod="GetAllFromDetOcxFacturaById" 
                        TypeName="SistFoncreagro.BussinesLogic.DetOcxFacturaBL">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="idOcFact" QueryStringField="idOcfac" 
                                Type="Object" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ObjectDataSource ID="odsccOfOc" runat="server" 
                        SelectMethod="GetCCOSTOByIdOrdenCompra" 
                        TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="IdOrden" QueryStringField="idOc" 
                                Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsDetalleOcByIdCcosto" runat="server" 
        SelectMethod="GetAllFromDetalleByIdCCosto" 
        TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="rcmbCCosto" Name="IdCcosto" 
                            PropertyName="SelectedValue" Type="Int32" />
                        <asp:QueryStringParameter Name="IdOrden" QueryStringField="idOc" Type="Int32" />
                    </SelectParameters>
    </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="odsDetalleOcxFactura" runat="server" 
        SelectMethod="GetAllFromDetalleByIdCCosto" 
        TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="rcmbCCosto" Name="IdCcosto" 
                            PropertyName="SelectedValue" Type="Int32" />
                        <asp:QueryStringParameter Name="IdOrden" QueryStringField="idOc" Type="Int32" />
                    </SelectParameters>
    </asp:ObjectDataSource>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rdbPrecio">
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="rdbCantidad">
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>

    </form>
</body>
</html>
