<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaCentroCostoFactura.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaCentroCostoFactura" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
.TextoCentro
{
	text-align:center;
}
        .style2
        {}
        .style3
        {
        }
        .style4
        {
            width: 450px;
        }
        .style5
        {
            width: 350px;
        }
    </style>
</head>
<body style="width: 655px">
    <form id="form1" runat="server">
      <fieldset>  
          <table style="width: 640px">
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      &nbsp;</td>
                  <td class="style1" style="font-size: 11pt" colspan="4">
                      <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                      </telerik:RadScriptManager>
   <asp:ObjectDataSource ID="odsCentroCostoOfOrden" runat="server" 
     SelectMethod="GetAllFromOrdenCentroCostoByIdOrdenCompra" 
        TypeName="SistFoncreagro.BussinesLogic.OrdenCentroCostoBL">
                <SelectParameters>
                    <asp:QueryStringParameter Name="IdOrdenCOmpra" QueryStringField="IdOrden" 
                        Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>

   <asp:ObjectDataSource ID="odsTipoDocumento" runat="server" 
     SelectMethod="GetAllFromTIPODOCUMENTO" 
        TypeName="SistFoncreagro.BussinesLogic.TipoDocumentoBL">
    </asp:ObjectDataSource>

   <asp:ObjectDataSource ID="odsFacturaCentroCosto" runat="server" 
     SelectMethod="GetAllFromFacturaCentroCostoByIdOrdenCentroCosto" 
        TypeName="SistFoncreagro.BussinesLogic.FacturaCentroCostoBL" 
                          OldValuesParameterFormatString="original_{0}">
       <SelectParameters>
           <asp:ControlParameter ControlID="rcbOrdenCentroCosto" Name="IdOrdenCentroCosto" 
               PropertyName="SelectedValue" Type="Int32" />
       </SelectParameters>
    </asp:ObjectDataSource>

                  </td>
              </tr>
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      C. Costo :</td>
                  <td class="style1" style="font-size: 11pt" colspan="4">
                        <telerik:RadComboBox ID="rcbOrdenCentroCosto" Runat="server" 
                            DataSourceID="odsCentroCostoOfOrden" DataTextField="NombreCentroCosto" 
                            DataValueField="IdOrdenCentroCosto" Font-Size="7pt" Width="447px" 
                            AutoPostBack="True">
                        </telerik:RadComboBox>
                  </td>
              </tr>
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      Tipo Doc. :</td>
                  <td class="style1" style="font-size: 11pt" colspan="4">
                        <telerik:RadComboBox ID="rcbTipoDocumento" Runat="server" AllowCustomText="True" 
                            DataSourceID="odsTipoDocumento" DataTextField="Nombre" 
                            DataValueField="IdTipoDocumento" EnableLoadOnDemand="True" 
                            EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                            ShowMoreResultsBox="True" Width="447px" ValidationGroup="a">
                        </telerik:RadComboBox>
                        <asp:RequiredFieldValidator ID="rfvcCosto0" runat="server" 
                            ControlToValidate="rcbTipoDocumento" ErrorMessage="*" Font-Size="7pt" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      Serie :</td>
                  <td class="style1" style="font-size: 11pt">
                        <asp:TextBox ID="txtSerie" runat="server" ValidationGroup="a"></asp:TextBox>
                        </td>
                  <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvcCosto1" runat="server" 
                            ControlToValidate="txtSerie" ErrorMessage="*" Font-Size="7pt" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      Número :</td>
                  <td class="style1" style="font-size: 11pt">
                        <asp:TextBox ID="txtNumero" runat="server" ValidationGroup="a"></asp:TextBox>
                        </td>
                  <td colspan="3">
                        <asp:RequiredFieldValidator ID="rfvcCosto2" runat="server" 
                            ControlToValidate="txtNumero" ErrorMessage="*" Font-Size="7pt" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
                  </td>
              </tr>
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      Monto :</td>
                  <td class="style1" style="font-size: 11pt">
                        <asp:TextBox ID="txtMonto" runat="server" ValidationGroup="a"></asp:TextBox>
                        </td>
                  <td class="style4">
                        <asp:RequiredFieldValidator ID="rfvMonto" runat="server" 
                            ControlToValidate="txtMonto" ErrorMessage="*" Font-Size="7pt" 
                            ValidationGroup="a"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revMonto" runat="server" 
                            ControlToValidate="txtMonto" ErrorMessage="*" Font-Size="7pt" 
                            ValidationExpression="^[0-9]+(\.[0-9]+)?$" ValidationGroup="a"></asp:RegularExpressionValidator>
                        </td>
                  <td class="style4">
                        &nbsp;</td>
                  <td>
                        <asp:LinkButton ID="lbAgregar" runat="server" ValidationGroup="a">Agregar</asp:LinkButton>
                  </td>
              </tr>
              <tr>
                  <td class="style5" style="font-size: 11pt">
                      &nbsp;</td>
                  <td class="style1" style="font-size: 11pt">
                      &nbsp;</td>
                  <td colspan="3">
                        &nbsp;</td>
              </tr>
              <tr>
                  <td class="style2" colspan="5">
                      <%--                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                          <ContentTemplate>--%>
                              <asp:GridView ID="gvFacturaCentroCosto" runat="server" AutoGenerateColumns="False" 
                                  DataSourceID="odsFacturaCentroCosto" Font-Size="10pt" Width="620px" 
                                  DataKeyNames="IdFacturaCentroCosto">
                                  <Columns>
                                    <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                        FooterText="Eliminar" ImageUrl="~/img/Delete.gif">
                                    <ItemStyle HorizontalAlign="Center" Width="15px" />
                                    </asp:ButtonField>
                                        <asp:BoundField DataField="NombreDocumento" HeaderText="Documento" 
                                            ReadOnly="True" SortExpression="NombreDocumento" >
                                        <ItemStyle HorizontalAlign="Center" />
                                      </asp:BoundField>
                                        <asp:BoundField DataField="Serie" HeaderText="Serie" SortExpression="Serie" >
                                        <ItemStyle HorizontalAlign="Center" />
                                      </asp:BoundField>
                                        <asp:BoundField DataField="Numero" HeaderText="Número" 
                                            SortExpression="Numero" >
                                        <ItemStyle HorizontalAlign="Center" />
                                      </asp:BoundField>
                                        <asp:BoundField DataField="MontoFact" HeaderText="Monto" 
                                            SortExpression="MontoFact" >
                                      <ItemStyle HorizontalAlign="Right" />
                                      </asp:BoundField>
                                  </Columns>
                              </asp:GridView>
                      <%--                          </ContentTemplate>
                      </asp:UpdatePanel>--%>
                  </td>
              </tr>
              <tr>
                  <td class="style3" colspan="5">
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style3" colspan="3">
                      &nbsp;</td>
                  <td class="style3">
                      &nbsp;</td>
                  <td class="style3">
                      <asp:LinkButton ID="lbFinalizar" runat="server">Finalizar</asp:LinkButton>
                  </td>
              </tr>
              <tr>
                  <td class="style3" colspan="5">
                                      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                          <AjaxSettings>
                                              <telerik:AjaxSetting AjaxControlID="lbAgregar">
                                                  <UpdatedControls>
                                                      <telerik:AjaxUpdatedControl ControlID="odsTipoDocumento" />
                                                      <telerik:AjaxUpdatedControl ControlID="txtSerie" />
                                                      <telerik:AjaxUpdatedControl ControlID="txtNumero" />
                                                      <telerik:AjaxUpdatedControl ControlID="txtMonto" />
                                                  </UpdatedControls>
                                              </telerik:AjaxSetting>
                                          </AjaxSettings>
                                      </telerik:RadAjaxManager>
                  </td>
              </tr>
              </table>
      </fieldset>
    </form>
</body>
</html>