<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentaResposablesRequerimiento.aspx.vb" Inherits="SistFoncreagro.WebSite.VentaResposables" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .jcv
        {}
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body style="width: 900px">
    <form id="form1" runat="server">
                                          <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                                      </telerik:RadScriptManager>
      <fieldset>  
          <table style="width: 700px">
              <tr>
                  <td class="style1" style="font-size: 11pt">
                      Rol :&nbsp;
                      <asp:DropDownList ID="ddlRolProceso" runat="server" 
                          DataSourceID="SqlRolesAprobarRequerimiento" DataTextField="NombreRol" 
                          DataValueField="IdRol" Width="250px">
                      </asp:DropDownList>
                  </td>
                  <td class="style1" style="font-size: 11pt">
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style1" style="font-size: 11pt" colspan="2">
                      <table class="style1">
                          <tr>
                              <td>
                      <asp:RadioButton ID="rbResponsable" runat="server" Checked="True" 
                          GroupName="aa" Text="Responsable" TextAlign="Left" />
                                      </td>
                              <td>
                                      <telerik:RadComboBox ID="rcmbPersonal0" Runat="server" AllowCustomText="True" 
                                          AutoPostBack="True" DataSourceID="odsPersonal" DataTextField="nombreCompleto" 
                                          DataValueField="IdPersonal" EnableLoadOnDemand="True" 
                                          EnableVirtualScrolling="True" ItemsPerRequest="10" 
                          MarkFirstMatch="True" Width="250px">
                                      </telerik:RadComboBox>
                              </td>
                              <td>
                      <asp:RadioButton ID="rbProyecto" runat="server" GroupName="aa" Text="Proyecto" 
                          TextAlign="Left" />
                                      </td>
                              <td>
                                      <telerik:RadComboBox ID="rcmbProyecto0" Runat="server" AllowCustomText="True" 
                                          DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                          DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                          EnableVirtualScrolling="True" ItemsPerRequest="10" 
                          MarkFirstMatch="True" Width="250px">
                                      </telerik:RadComboBox>
                              </td>
                              <td>
                      <asp:Button ID="btnBuscar" runat="server" Text="Buscar" ValidationGroup="a" />
                              </td>
                          </tr>
                      </table>
</td>
              </tr>
              <tr>
                  <td class="style1" colspan="2">
                      <asp:ValidationSummary ID="ValidationSummary2" runat="server" Font-Size="7pt" 
                          ValidationGroup="a" />
                  </td>
              </tr>
              <tr>
                  <td class="style2" colspan="2">
                              <asp:GridView ID="gvRolPersonal" runat="server" AutoGenerateColumns="False" Font-Size="8pt" Width="870px" 
                                  DataKeyNames="IdRolPersonal">
                                  <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:Label ID="lblEstado" runat="server" Height="0px" 
                                                    Text='<%# Bind("Estado") %>' Visible="False" Width="0px"></asp:Label>
                                            </ItemTemplate>
                                            <ControlStyle Width="5px" />
                                            <FooterStyle Width="5px" />
                                            <HeaderStyle Width="5px" />
                                            <ItemStyle Width="5px" />
                                        </asp:TemplateField>
                                        <asp:ButtonField CommandName="Enable" Text="Habilitar/Deshabilitar">
                                            <ItemStyle HorizontalAlign="Center" Width="15px" />
                                        </asp:ButtonField>
                                      <asp:BoundField DataField="NombreProyecto" HeaderText="Proyecto" 
                                          ReadOnly="True" SortExpression="NombreProyecto">
                                      <HeaderStyle HorizontalAlign="Center" Width="300px" />
                                      <ItemStyle HorizontalAlign="Center" Width="300px" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="NombrePersona" HeaderText="Responsable" 
                                          ReadOnly="True" SortExpression="NombrePersona">
                                      <HeaderStyle HorizontalAlign="Center" Width="300px" />
                                      <ItemStyle HorizontalAlign="Center" Width="300px" />
                                      </asp:BoundField>
                                      <asp:CheckBoxField DataField="Estado" HeaderText="Estado" 
                                          SortExpression="Estado">
                                      <HeaderStyle HorizontalAlign="Center" Width="50px" />
                                      <ItemStyle HorizontalAlign="Center" Width="50px" />
                                      </asp:CheckBoxField>
                                  </Columns>
                              </asp:GridView>
                  </td>
              </tr>
              <tr>
                  <td class="style3" colspan="2">
                      &nbsp;</td>
              </tr>
              <tr>
                  <td class="style3" colspan="2">
                  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                  <ContentTemplate>
                      <fieldset class="jcv">
                          <legend class="legendJcv">Agregar Responsable</legend>
                          <table border="0" cellpadding="0" cellspacing="0" style="width: 865px">
                              <tr>
                                  <td class="style10">
                                      Área/Proyecto :</td>
                                  <td align="left" class="style6">
                                      <telerik:RadComboBox ID="rcmProyecto" Runat="server" AllowCustomText="True" 
                                          AutoPostBack="True" DataSourceID="odsProyecto" DataTextField="AreaProyecto" 
                                          DataValueField="IdProyecto" EnableLoadOnDemand="True" 
                                          EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                          Width="447px">
                                      </telerik:RadComboBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                          ControlToValidate="rcmProyecto" ErrorMessage="Seleccione Área o Proyecto" 
                                          Font-Size="8pt" ValidationGroup="validar">*</asp:RequiredFieldValidator>
                                  </td>
                                  <td align="right" style="height: 30px">
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td valign="bottom" class="style9">
                                      Responsable :</td>
                                  <td class="style8">
                                      <telerik:RadComboBox ID="rcmbPersonal" Runat="server" AllowCustomText="True" 
                                          AutoPostBack="True" DataSourceID="odsPersonal" DataTextField="nombreCompleto" 
                                          DataValueField="IdPersonal" EnableLoadOnDemand="True" 
                                          EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                                          Width="447px">
                                      </telerik:RadComboBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                          ControlToValidate="rcmbPersonal" ErrorMessage="Seleccione Responsable" 
                                          Font-Size="8pt" ValidationGroup="validar">*</asp:RequiredFieldValidator>
                                  </td>
                                  <td>
                                      <asp:LinkButton ID="lbAgregarResponsable" runat="server" 
                                          ValidationGroup="validar">Agregar</asp:LinkButton>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="style9">
                                      &nbsp;</td>
                                  <td align="left" class="style8">
                                      <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Size="8pt" 
                                          ValidationGroup="validar" />
                                  </td>
                                  <td align="left">
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="style5" colspan="3">
                                      &nbsp;</td>
                              </tr>
                          </table>
                      </fieldset>

                      <fieldset class="jcv">
                          <legend class="legendJcv">Cambiar Responsable</legend>
                          <table border="0" cellpadding="0" cellspacing="0" style="width: 865px">
                              <tr>
                                  <td class="style10">
                                      Rol :</td>
                                  <td align="left" class="style6">
                                      <asp:DropDownList ID="ddlRol" runat="server" DataSourceID="odsRol" 
                                          DataTextField="NombreRol" DataValueField="IdRol" Width="250px">
                                      </asp:DropDownList>
                                      <asp:ObjectDataSource ID="odsRol" runat="server" SelectMethod="GetAllFromROL" 
                                          TypeName="SistFoncreagro.BussinesLogic.RolBL"></asp:ObjectDataSource>
                                  </td>
                                  <td align="right" style="height: 30px">
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="style10">
                                      Responsable :</td>
                                  <td align="left" class="style6">
                                      <telerik:RadComboBox ID="rcmbPersonaOriginal" Runat="server" 
                                          AllowCustomText="True" AutoPostBack="True" DataSourceID="odsPersonal" 
                                          DataTextField="nombreCompleto" DataValueField="IdPersonal" 
                                          EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                          MarkFirstMatch="True" Width="447px">
                                      </telerik:RadComboBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                          ControlToValidate="rcmbPersonaOriginal" Font-Size="8pt" 
                                          ValidationGroup="validar2">*</asp:RequiredFieldValidator>
                                  </td>
                                  <td align="right" style="height: 30px">
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td valign="bottom" class="style9">
                                      Reemplazo :</td>
                                  <td class="style8">
                                      <telerik:RadComboBox ID="rcmbPersonaReemplazo" Runat="server" 
                                          AllowCustomText="True" AutoPostBack="True" DataSourceID="odsPersonal" 
                                          DataTextField="nombreCompleto" DataValueField="IdPersonal" 
                                          EnableLoadOnDemand="True" EnableVirtualScrolling="True" ItemsPerRequest="10" 
                                          MarkFirstMatch="True" Width="447px">
                                      </telerik:RadComboBox>
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                          ControlToValidate="rcmbPersonaReemplazo" Font-Size="8pt" 
                                          ValidationGroup="validar2">*</asp:RequiredFieldValidator>
                                  </td>
                                  <td>
                                      <asp:LinkButton ID="lbCambiarResponsable" runat="server" 
                                          ValidationGroup="validar2">Actualizar</asp:LinkButton>
                                  </td>
                              </tr>
                              <tr>
                                  <td class="style9">
                                      &nbsp;</td>
                                  <td align="left" class="style8">
                                      <asp:Label ID="lblmensaje" runat="server" Font-Size="8pt" ForeColor="#CC0000"></asp:Label>
                                  </td>
                                  <td align="left">
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td class="style5" colspan="3">
                                      &nbsp;</td>
                              </tr>
                          </table>
                      </fieldset>
                  </ContentTemplate>
              </asp:UpdatePanel>
                  </td>
              </tr>
              <tr>
              <td>
              
              </td>
              </tr>
              </table>
      </fieldset>
                                      <asp:ObjectDataSource ID="odsAprobarRequerimiento" runat="server" 
                                          SelectMethod="GetAllFromNivelesAprobarRequerimiento" 
                                          TypeName="SistFoncreagro.BussinesLogic.AprobarRequerimientoBL">
                                      </asp:ObjectDataSource>
                                      <asp:ObjectDataSource ID="odsProyecto" runat="server" 
                                          SelectMethod="GetAllFromProyecto" 
                                          TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                                          <asp:SqlDataSource ID="SqlRolesAprobarRequerimiento" runat="server" 
                                              ConnectionString="<%$ ConnectionStrings:cnx %>" 
                                              SelectCommand="GetAprobarRequerimiento" SelectCommandType="StoredProcedure">
                                          </asp:SqlDataSource>
                                      <asp:ObjectDataSource ID="odsPersonal" runat="server" 
                                          SelectMethod="GetAllFromPersonal" 
                                          TypeName="SistFoncreagro.BussinesLogic.PersonalBL"></asp:ObjectDataSource>
                                      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                          <AjaxSettings>
                                              <telerik:AjaxSetting AjaxControlID="RadScriptManager1">
                                                  <UpdatedControls>
                                                      <telerik:AjaxUpdatedControl ControlID="rcmbPersonal0" />
                                                      <telerik:AjaxUpdatedControl ControlID="rcmbProyecto0" />
                                                  </UpdatedControls>
                                              </telerik:AjaxSetting>
                                              <telerik:AjaxSetting AjaxControlID="btnBuscar">
                                                  <UpdatedControls>
                                                      <telerik:AjaxUpdatedControl ControlID="rcmbPersonal0" />
                                                      <telerik:AjaxUpdatedControl ControlID="rcmbProyecto0" />
                                                      <telerik:AjaxUpdatedControl ControlID="gvRolPersonal" />
                                                  </UpdatedControls>
                                              </telerik:AjaxSetting>
                                          </AjaxSettings>
                                      </telerik:RadAjaxManager>
    </form>
</body>
</html>