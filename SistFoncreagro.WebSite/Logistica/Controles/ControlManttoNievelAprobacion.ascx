<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="ControlManttoNievelAprobacion.ascx.vb" Inherits="SistFoncreagro.WebSite.ControlManttoNievelAprobacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<table style="width: 620px">
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
            <table class="style1" style="width: 280px">
                <tr>
                    <td align="right" class="style3">
                        Rol :</td>
                    <td align="left" colspan="3">
                        <telerik:RadComboBox ID="rcbRoles" Runat="server" AllowCustomText="True" 
                            DataSourceID="odsRoles" DataTextField="NombreRol" 
                            DataValueField="IdRol" EnableLoadOnDemand="True" 
                            EnableVirtualScrolling="True" ItemsPerRequest="10" MarkFirstMatch="True" 
                            ShowMoreResultsBox="True" Width="200px" ValidationGroup="validar">
                        </telerik:RadComboBox>
                     </td>
                    <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="rcbRoles" ErrorMessage="Seleccione el Rol." Font-Size="8pt" 
                            ValidationGroup="validar">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style3">
                        Orden :</td>
                    <td align="left">
                        <asp:TextBox ID="txtOrden" runat="server" Height="16px" Width="35px" 
                            ValidationGroup="validar"></asp:TextBox>
                    </td>
                    <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtOrden" ErrorMessage="Ingrese orden." Font-Size="8pt" 
                            ValidationGroup="validar">*</asp:RequiredFieldValidator>
                    </td>
                    <td align="left">
                        <asp:CheckBox ID="cbAreaProyecto" runat="server" Text="Resp. Área/Proyecto :" TextAlign="Left" />
                    </td>
                    <td align="left">
                        &nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
            <asp:ImageButton ID="ImageButton2" runat="server" CommandName="PerformInsert" 
                ImageUrl="~/img/Update.gif" ToolTip="Insertar" ValidationGroup="validar" />
            <asp:ImageButton ID="ImageButton3" runat="server" CommandName="Update" 
                ImageUrl="~/img/Update.gif" ToolTip="Actualizar" 
                CausesValidation="False" ValidationGroup="validar" />
            &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                CommandName="Cancel" ImageUrl="~/img/Cancel.gif" ToolTip="Cancelar" />
        </td>
    </tr>
    <tr>
        <td class="style2" style="width: 9%">
            &nbsp;</td>
        <td style="font-size: 9pt; " align="center">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Size="8pt" 
                            ForeColor="#FF3300" ValidationGroup="validar" />
        </td>
    </tr>
</table>
      <asp:ObjectDataSource ID="odsRoles" runat="server" 
          SelectMethod="GetAllFromROL" 
          TypeName="SistFoncreagro.BussinesLogic.RolBL">
      </asp:ObjectDataSource>
         