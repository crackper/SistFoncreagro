<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaRoles.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaRoles" %>

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
    <div style="width: 405px">
        <fieldset style="width: 400px">
            <legend style="font-family: Arial; font-size: 15px; width: 155px;">ADMINISTRAR ROLES</legend>
            <table border="0" cellpadding="0" cellspacing="0" 
                style="width: 98%; height: 140px;">
                <tr>
                    <td class="style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style1" colspan="2">
                        Usuario:
                        <asp:Label ID="lblUsuario" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table>
                            <tr>
                                <td>
                                    <b>Roles Disponibles:</b>
                                    <br />
                                    <asp:ListBox ID="lbRoles" runat="server" Rows="10" Width="130px" Height="200px"></asp:ListBox>
                                </td>
                                <td>
                                    <asp:Button ID="btnAgregar" runat="server" onclick="btnAgregar_Click" 
                                        Text="&gt;&gt;" />
                                    <br />
                                    <asp:Button ID="btnQuitar" runat="server" onclick="btnQuitar_Click" 
                                        Text="&lt;&lt;" />
                                </td>
                                <td align="right">
                                    <b>Roles del Usuario:</b>
                                    <br />
                                    <asp:ListBox ID="lbRolesForUser" runat="server" Rows="10" Width="130px" 
                                        Height="200px">
                                    </asp:ListBox>
                                </td>
                            </tr>
                        </table>
                        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                        </telerik:RadAjaxManager>
                    </td>
                </tr>
            </table>
        </fieldset></div>
    <asp:ObjectDataSource ID="odsUsuariosSistema" runat="server" 
        SelectMethod="GetAllFromUsuariosSistema" 
        TypeName="SistFoncreagro.BussinesLogic.UsuarioBL"></asp:ObjectDataSource>
    </form>
</body>
</html>
