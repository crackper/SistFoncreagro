<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaAgregarDetalle.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaAgregarDetalle1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body style="width: 755px">
   <form id="form1" runat="server" style="width: 770px; ">
        <fieldset style="width: 750px">       
          <table style="width: 745px; ">
              <tr>
                  <td class="style4">
                      </td>
                  <td colspan="2" class="style1" style="width: 84%">
                           </td>
              </tr>
              <tr>
                  <td class="style3">
                      <asp:Label ID="lblNombre" runat="server" Text="Párrafo :"></asp:Label>
                  </td>
                  <td class="style5" rowspan="2" style="width: 70%">
                      <asp:TextBox ID="txtTexto" runat="server" Height="63px" TextMode="MultiLine" 
                          Width="520px" style="margin-left: 0px"></asp:TextBox>
                  </td>
                  <td align="center" style="width: 14%">
                            &nbsp;</td>
              </tr>
              <tr>
                  <td class="style3">
                      &nbsp;</td>
                  <td align="center" style="width: 14%">
                            <asp:LinkButton ID="lbAgregarTexto" runat="server">Agregar</asp:LinkButton>
                  </td>
              </tr>
              <tr>
                  <td class="style3" colspan="3">
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style3" colspan="3">
                      <asp:GridView ID="gvDetalleCotizacion" runat="server" 
                          AutoGenerateColumns="False" Width="720px" 
                          DataKeyNames="IdDetalleReporteCotizacion" DataSourceID="odsDetalleReporteCotizacion" 
                          Font-Size="11pt">
                          <Columns>
                             <asp:TemplateField>
                                <EditItemTemplate>
                                        <asp:Label ID="Label1" runat="server" 
                                            Text='<%# Bind("IdDetalleReporteCotizacion") %>' ForeColor="White" 
                                            Visible="False"></asp:Label>
                                </EditItemTemplate>
                                     <ItemTemplate>
                                <asp:TextBox ID="txtIdDetalleReporteCotizacion" runat="server"
                                    Text='<%# Bind("IdDetalleReporteCotizacion") %>' Width="0px" Visible="False" 
                                             ReadOnly="True" BackColor="White" BorderColor="White" Height="0px" 
                                             ForeColor="White"></asp:TextBox>
                                 </ItemTemplate>
                                    <ControlStyle Width="0px" />
                                    <FooterStyle Width="0px" />
                                    <HeaderStyle Width="0px" />
                                    <ItemStyle Width="0px" />
                            </asp:TemplateField>
                              <asp:CommandField ButtonType="Image" EditImageUrl="~/img/Edit.gif" 
                                  ShowEditButton="True" CancelImageUrl="~/img/Cancel.gif" 
                                  UpdateImageUrl="~/img/Update.gif" >
                              <FooterStyle HorizontalAlign="Center" />
                              <HeaderStyle HorizontalAlign="Center" Width="20px" />
                              <ItemStyle HorizontalAlign="Center" Width="20px" />
                              </asp:CommandField>
                              <asp:TemplateField HeaderText="Texto" SortExpression="Texto">
                                  <EditItemTemplate>
                                      <asp:TextBox ID="TextBox1" runat="server" Height="90px" 
                                          Text='<%# Bind("Texto") %>' TextMode="MultiLine" Width="640px"></asp:TextBox>
                                  </EditItemTemplate>
                                  <ItemTemplate>
                                      <asp:Label ID="Label1" runat="server" Text='<%# Bind("Texto") %>'></asp:Label>
                                  </ItemTemplate>
                                  <ControlStyle Font-Overline="False" />
                                  <FooterStyle Height="50px" HorizontalAlign="Left" VerticalAlign="Middle" 
                                      Width="400px" Wrap="False" />
                                  <HeaderStyle Width="680px" />
                                  <ItemStyle Width="680px" />
                              </asp:TemplateField>
                            <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                  ImageUrl="~/img/Delete.gif" FooterText="Eliminar" >
                              <HeaderStyle HorizontalAlign="Center" Width="20px" />
                              <ItemStyle Width="20px" HorizontalAlign="Center" />
                              </asp:ButtonField>
                          </Columns>
                      </asp:GridView>
                            </td>
              </tr>
              <tr>
                  <td class="style3">
                      &nbsp;</td>
                  <td class="style5" style="width: 70%">
                      &nbsp;</td>
                  <td align="center" style="width: 14%">
                            &nbsp;</td>
              </tr>
              </table>
        </fieldset>
      <asp:ObjectDataSource ID="odsDetalleReporteCotizacion" runat="server" 
             SelectMethod="GetAllFromDetalleReporteCotizacionByIdCotizacion" 
             TypeName="SistFoncreagro.BussinesLogic.DetalleReporteCotizacionBL" 
            DataObjectTypeName="SistFoncreagro.BussinessEntities.DetalleReporteCotizacion" 
            DeleteMethod="DeleteDetalleReporteCotizacion" 
            UpdateMethod="UpdateDetalleReporteCotizacion">
                  <DeleteParameters>
                      <asp:Parameter Name="IdDetalleReporteCotizacion" Type="Int32" />
                  </DeleteParameters>
                  <SelectParameters>
                      <asp:QueryStringParameter Name="idCotizacion" QueryStringField="IdCotizacion" 
                          Type="Int32" />
                  </SelectParameters>
         </asp:ObjectDataSource>
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
          <AjaxSettings>
              <telerik:AjaxSetting AjaxControlID="lbAgregarTexto">
              </telerik:AjaxSetting>
              <telerik:AjaxSetting AjaxControlID="gvDetalleCotizacion">
              </telerik:AjaxSetting>
              <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="gvDetalleCotizacion" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
          </AjaxSettings>
      </telerik:RadAjaxManager>
       <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
       </telerik:RadScriptManager> 
      </form>
</body>
</html>

