<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmNuevoCargo.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmNuevoCargo" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type ="text/javascript">
            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }
            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
          </script>
    </telerik:RadCodeBlock>
    <table style="width: 100%">
        <tr>
            <td width="60">
                Nombre:</td>
            <td>
                <asp:TextBox ID="txtNombreCargo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="60">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtIdCargo" runat="server" Height="28px" Width="79px"></asp:TextBox>
                <br />
                <br />
                <asp:LinkButton ID="LinkButton1" runat="server">cerrar</asp:LinkButton>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
