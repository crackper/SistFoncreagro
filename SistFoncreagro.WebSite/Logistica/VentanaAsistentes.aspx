<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaAsistentes.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaAsistentes" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <style type="text/css">
        #form1
        {
            width: 658px;
        }
        .style5
        {
            width: 100%;
        }
    </style>
</head>
<body style="width: 663px">
   <form id="form1" runat="server">
        <fieldset style="width: 630px">       
          
            <table class="style5" style="width: 655px">
                <tr>
                    <td style="width: 37%">
                        ASISTENTES :</td>
                    <td style="width: 50%">
                        &nbsp;</td>
                    <td style="width: 13%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 37%">
                     </td>
                    <td style="width: 50%">
                        &nbsp;</td>
                    <td style="width: 13%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 37%">
                        <asp:RadioButton ID="rbPersonalFoncreagro" runat="server" Checked="True" 
                            GroupName="persona" Text="Personal Foncreagro" AutoPostBack="True" />
                    </td>
                    <td style="width: 50%">
                        &nbsp;</td>
                    <td style="width: 13%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 37%" align="right">
                        Nombre:</td>
                    <td style="width: 50%">
                        <telerik:RadComboBox ID="rcmbPersonal" Runat="server" Width="300px" 
                            DataSourceID="odsPersonal" DataTextField="nombreCompleto" 
                            DataValueField="IdPersonal">
                        </telerik:RadComboBox>
                    </td>
                    <td style="width: 13%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 37%">
                        <asp:RadioButton ID="rbPersonalExterno" runat="server" GroupName="persona" 
                            Text="Personal Externo" AutoPostBack="True" ValidationGroup="validar" />
                    </td>
                    <td style="width: 50%">
                        &nbsp;</td>
                    <td style="width: 13%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 37%" align="right">
                        Nombre :</td>
                    <td style="width: 50%">
                        <asp:TextBox ID="txtNombreExterno" runat="server" Enabled="False" Width="300px" 
                            ValidationGroup="validar"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtNombreExterno" ErrorMessage="Ingrese nombre." 
                            Font-Size="8pt" ValidationGroup="validar">*</asp:RequiredFieldValidator>
                    </td>
                    <td style="width: 13%">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 37%" align="right">
                        Cargo :</td>
                    <td style="width: 50%">
                        <asp:TextBox ID="txtCargo" runat="server" Enabled="False" Width="300px" 
                            ValidationGroup="validar"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtCargo" ErrorMessage="Ingrese cargo." Font-Size="8pt" 
                            Font-Strikeout="False" ValidationGroup="validar">*</asp:RequiredFieldValidator>
                    </td>
                    <td style="width: 13%" align="center">
                        <asp:LinkButton ID="lbAgregar" runat="server">Agregar</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td style="width: 37%">
                        &nbsp;</td>
                    <td style="width: 50%">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Size="8pt" 
                            ValidationGroup="validar" />
                    </td>
                    <td style="width: 13%" align="center">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                      <asp:GridView ID="gvAsistenteCotizacion" runat="server" 
                          AutoGenerateColumns="False" Width="650px" DataSourceID="odsAsistenteCotizacion" 
                          Font-Size="11pt">
                          <Columns>
                             <asp:TemplateField>
                                <EditItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("IdAsistenteCotizacion") %>'></asp:Label>
                                </EditItemTemplate>
                                     <ItemTemplate>
                                <asp:TextBox ID="txtIdAsistenteCotizacion" runat="server"
                                    Text='<%# Bind("IdAsistenteCotizacion") %>' Width="0px" Visible="False" 
                                             ReadOnly="True" BackColor="White" BorderColor="White" Height="0px"></asp:TextBox>
                                 </ItemTemplate>
                                    <ControlStyle Width="0px" />
                                    <FooterStyle Width="0px" />
                                    <HeaderStyle Width="0px" />
                                    <ItemStyle Width="0px" />
                            </asp:TemplateField>
                            <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                  ImageUrl="~/img/Delete.gif" FooterText="Eliminar" >
                              <HeaderStyle HorizontalAlign="Center" Width="20px" />
                              <ItemStyle Width="20px" HorizontalAlign="Center" />
                              </asp:ButtonField>
                              <asp:BoundField HeaderText="Nombre" DataField="Nombre" >
                              <ItemStyle Width="400px" />
                              </asp:BoundField>
                              <asp:BoundField HeaderText="Cargo" DataField="Cargo" >
                              <ItemStyle Width="230px" />
                              </asp:BoundField>
                          </Columns>
                      </asp:GridView>
                            </td>
                </tr>
                </table>
          
       </fieldset>
      <asp:ObjectDataSource ID="odsAsistenteCotizacion" runat="server" 
             SelectMethod="GetAllFromAsistennteCotizacionByIdCotizacion" 
             TypeName="SistFoncreagro.BussinesLogic.AsistenteCotizacionBL">
                  <SelectParameters>
                      <asp:QueryStringParameter Name="idCotizacion" QueryStringField="IdCotizacion" 
                          Type="Int32" />
                  </SelectParameters>
         </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="odsPersonal" runat="server" 
                            SelectMethod="GetAllFromPersonal" 
                            TypeName="SistFoncreagro.BussinesLogic.PersonalBL"></asp:ObjectDataSource>
      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
          <AjaxSettings>
              <telerik:AjaxSetting AjaxControlID="rbPersonalFoncreagro">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="rcmbPersonal" />
                      <telerik:AjaxUpdatedControl ControlID="txtNombreExterno" />
                      <telerik:AjaxUpdatedControl ControlID="txtCargo" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
              <telerik:AjaxSetting AjaxControlID="rbPersonalExterno">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="rcmbPersonal" />
                      <telerik:AjaxUpdatedControl ControlID="txtNombreExterno" />
                      <telerik:AjaxUpdatedControl ControlID="txtCargo" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
              <telerik:AjaxSetting AjaxControlID="lbAgregar">
                  <UpdatedControls>
                      <telerik:AjaxUpdatedControl ControlID="gvAsistenteCotizacion" />
                  </UpdatedControls>
              </telerik:AjaxSetting>
          </AjaxSettings>
      </telerik:RadAjaxManager>
       <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
       </telerik:RadScriptManager> 
      </form>
</body>
</html>

