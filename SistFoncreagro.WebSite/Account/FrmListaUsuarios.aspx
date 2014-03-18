<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaUsuarios.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    var parametro = 0;
    var tipo = 0;

    function CargaEstado(estado, idUsuario) {
        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("CambiarEstado|" + estado + "|" + idUsuario);
    }

    function Restaurar(estado, idUsuario) {
        $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Restaurar|" + estado + "|" + idUsuario);
        alert("El nuevo pasword es: 123456");
    }

    function CargarVentana(nombreUsuario) {
        var oWnd = radopen("VentanaRoles.aspx?Nombre=" + nombreUsuario, "VentanaRoles");
    }
</script>
</telerik:RadCodeBlock>
                    <h2>
                        LISTA DE USUARIOS
                    </h2>
                    <p>
                        Use el formulario siguiente para administrar roles y bloquear usuarios.
                    </p>
<fieldset>
   <legend style="font-family: Arial; font-size: 15px; width: 135px;">Lista de Usuarios</legend>
       <table style="width: 94%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <asp:LinkButton ID="lbNuevoUsuario" runat="server" 
                            PostBackUrl="~/Account/Register.aspx">NuevoUsuario</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                      <asp:GridView ID="gvRolPersonal" runat="server" 
                          DataSourceID="odsUsuariosSistema" Width="820px" AutoGenerateColumns="False" 
                          Font-Size="9pt" DataKeyNames="NombreUsuario,IdUsuario">
                          <Columns>
                              <asp:BoundField DataField="NombrePersonalCompleto" HeaderText="Nombre Completo" 
                                  SortExpression="NombrePersonalCompleto" >
                              <HeaderStyle HorizontalAlign="Center" />
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:BoundField>
                              <asp:BoundField DataField="EstadoNombre" HeaderText="Estado" 
                                  SortExpression="EstadoNombre" >
                              <HeaderStyle HorizontalAlign="Center" />
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:BoundField>
                              <asp:BoundField DataField="NroFalla" HeaderText="Nro. Falla">
                              <HeaderStyle HorizontalAlign="Center" />
                              <ItemStyle HorizontalAlign="Center" />
                              </asp:BoundField>
                             <asp:TemplateField HeaderText="" SortExpression="">
                                  <ItemTemplate>
                                     <asp:LinkButton ID="lbEstado" runat="server" Font-Size="8pt" Text="Bloquear" />
                                      <asp:Label ID="lblEstado" runat="server" Height="0px" 
                                          Text='<%# Bind("Estado") %>' Visible="False" Width="0px"></asp:Label>
                                  </ItemTemplate>
                                  <HeaderStyle Width="60px" HorizontalAlign="Center" />
                                   <ItemStyle HorizontalAlign="Center" Width="60px" />
                              </asp:TemplateField>
                              <asp:TemplateField HeaderText="" SortExpression="">
                                  <ItemTemplate>
                                     <asp:LinkButton ID="lbRoles" runat="server" Font-Size="8pt" Text="Roles" />
                                  </ItemTemplate>
                                  <HeaderStyle Width="60px" />
                                   <ItemStyle HorizontalAlign="Center" Width="60px" />
                              </asp:TemplateField>
                                                           <asp:TemplateField HeaderText="" SortExpression="">
                                  <ItemTemplate>
                                     <asp:LinkButton ID="lbRestart" runat="server" Font-Size="8pt" Text="Restaurar" />
                                  </ItemTemplate>
                                  <HeaderStyle Width="60px" HorizontalAlign="Center" />
                                   <ItemStyle HorizontalAlign="Center" Width="60px" />
                              </asp:TemplateField>
                          </Columns>
                      </asp:GridView>
                        <br />
                      <asp:ObjectDataSource ID="odsUsuariosSistema" runat="server" 
                          SelectMethod="GetAllFromUsuariosSistema" 
                          TypeName="SistFoncreagro.BussinesLogic.UsuarioBL">
                      </asp:ObjectDataSource>
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="VentanaRoles" runat="server" Title="ROLES" Height="390px"
                        Width="460px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false" 
                            Modal="true" VisibleStatusbar="False" />
                    </Windows>
                </telerik:RadWindowManager>
                        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                            <AjaxSettings>
                                <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                                    <UpdatedControls>
                                        <telerik:AjaxUpdatedControl ControlID="gvRolPersonal" />
                                    </UpdatedControls>
                                </telerik:AjaxSetting>
                            </AjaxSettings>
                        </telerik:RadAjaxManager>
                    </td>
                </tr>
            </table>
   </fieldset>
</asp:Content>
