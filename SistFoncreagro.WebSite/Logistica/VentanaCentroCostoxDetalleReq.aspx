<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaCentroCostoxDetalleReq.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaCentroCostoxDetalleReq" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
        }
        .style3
        {
        }
        .style4
        {
            width: 151px;
        }
        .style5
        {
            width: 168px;
        }
    </style>
</head>
<body style="width: 671px">
    <form id="form1" runat="server">
      <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
      </telerik:RadScriptManager>
      <fieldset>  
          <table style="width: 647px">
              <tr>
                  <td class="style4" style="font-size: 11pt">
                      Producto / Servicio :</td>
                  <td colspan="3">
                      <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Width="480px"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td class="style4" style="font-size: 11pt">
                      Centro de Costo :</td>
                  <td colspan="2">
                      <telerik:RadComboBox ID="rcbCentroCosto" Runat="server" Width="400px" 
                          DataSourceID="odsCentroCostoByProyecto" DataTextField="Codigo" 
                          DataValueField="IdCCosto">
                      </telerik:RadComboBox>
                  </td>
                  <td>
                      <asp:LinkButton ID="lbAgregar" runat="server">Agregar</asp:LinkButton>
                  </td>
              </tr>
              <tr>
                  <td class="style4">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
                  <td class="style5">
                      &nbsp;</td>
                  <td>
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style2" colspan="4">
                      <asp:GridView ID="gvCentroCosto" runat="server" 
                          DataSourceID="odsCentroCostoxDetalleRequerimiento" 
                          EnableModelValidation="True" Width="635px" AutoGenerateColumns="False" 
                          DataKeyNames="IdCCostoxDetalleRequerimiento" Font-Size="11pt">
                          <Columns>
                    <asp:TemplateField SortExpression="IdDetalleRequerimiento">
                    <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("IdCCostoxDetalleRequerimiento") %>'></asp:Label>
                    </EditItemTemplate>
                         <ItemTemplate>
                    <asp:TextBox ID="txtIdCcostoDetalle" runat="server" BackColor="Info"
                        Text='<%# Bind("IdCCostoxDetalleRequerimiento") %>' Width="0px"></asp:TextBox>
                     </ItemTemplate>
                        <ControlStyle Width="0pt" BorderStyle="None" BorderWidth="0pt" Font-Size="0pt" 
                            ForeColor="White" />
                        <FooterStyle Width="0pt" Font-Size="0pt" ForeColor="White" />
                        <ItemStyle Width="1px" />
                    </asp:TemplateField>
                    <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                  ImageUrl="~/img/Delete.gif" FooterText="Eliminar" >
                              <ItemStyle Width="15px" HorizontalAlign="Center" />
                    </asp:ButtonField>
                              <asp:BoundField DataField="CodigoCentroCosto" HeaderText="Centro de Costo" 
                                  SortExpression="CodigoCentroCosto" >
                              <HeaderStyle HorizontalAlign="Center" />
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:BoundField>
                          </Columns>
                      </asp:GridView>
                  </td>
              </tr>
              <tr>
                  <td class="style3" colspan="4">
                      <asp:ObjectDataSource ID="odsCentroCostoxDetalleRequerimiento" runat="server" 
                          SelectMethod="GetAllFromCCostoDetalleRequerimientoByIdDetReq" 
                          TypeName="SistFoncreagro.BussinesLogic.CCostoDetalleRequerimientoBL" 
                          DeleteMethod="DeleteCCostoDetalleRequerimiento">
                          <DeleteParameters>
                              <asp:Parameter Name="IdCCostoxDetalleRequerimiento" Type="Int32" />
                          </DeleteParameters>
                          <SelectParameters>
                              <asp:QueryStringParameter Name="idDetReq" QueryStringField="IdDetalle" 
                                  Type="Int32" />
                          </SelectParameters>
                      </asp:ObjectDataSource>
                      <asp:ObjectDataSource ID="odsCentroCostoByProyecto" runat="server" 
                          SelectMethod="GetCCOSTOByIdProyecto" 
                          TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                          <SelectParameters>
                              <asp:QueryStringParameter Name="_IdProyecto" QueryStringField="IdProyecto" 
                                  Type="Int32" />
                          </SelectParameters>
                      </asp:ObjectDataSource>
                  </td>
              </tr>
          </table>
      </fieldset>
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
          <AjaxSettings>
              <telerik:AjaxSetting AjaxControlID="lbAgregar">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="gvCentroCosto" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
              <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="gvCentroCosto" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
              <telerik:AjaxSetting AjaxControlID="gvCentroCosto">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="gvCentroCosto" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
          </AjaxSettings>
      </telerik:RadAjaxManager>
    </form>
</body>
</html>
