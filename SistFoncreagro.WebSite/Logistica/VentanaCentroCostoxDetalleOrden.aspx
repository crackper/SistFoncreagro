<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaCentroCostoxDetalleOrden.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaCentroCostoxDetalleOrden" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
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
                          DataSourceID="odsCentroCostoxDetalleRequerimiento" Width="635px" 
                          AutoGenerateColumns="False" Font-Size="11pt">
                          <Columns>
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
                          SelectMethod="GetAllFromCCostoDetalleOrdenByIdDetalleOrden" 
                          TypeName="SistFoncreagro.BussinesLogic.CCostoxDetalleOrdenBL">
                          <SelectParameters>
                              <asp:QueryStringParameter Name="idDetalleOrden" QueryStringField="IdDetalle" 
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
