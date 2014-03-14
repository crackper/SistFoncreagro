<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="ListaPoa.aspx.vb" Inherits="SistFoncreagro.WebSite.ListaPoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td >
                            Programacion operativa anual</td>
                        <td  >
                        </td>
                        <td style="text-align: center; width:30px"   >
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Cancel.gif" 
                                PostBackUrl="~/Monitoreo/Formularios/Defecto.aspx" 
                                ToolTip="Cerrar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="40%">
                <telerik:RadGrid ID="RadGrid1" runat="server" Skin="Hay">
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td width="40%" style="text-align: center">
                <asp:Button ID="Button1" runat="server" Text="GENERAR POA" />
            </td>
        </tr>
        <tr>
            <td width="40%">
                &nbsp;</td>
        </tr>
        <tr>
            <td width="40%">
                &nbsp;</td>
        </tr>
        
        <tr>
            <td width="40%">
                &nbsp;</td>
        </tr>
    </table><telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>

        

         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>

          <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
        function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }

        function alertCallBackFn(arg) {
            window.open("ListaPoa.aspx", "_self");
        }
        function confirmCallBackFn(arg) {
            $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Generar|" + arg);
        }
       

        
     </script>
    </telerik:RadCodeBlock>
    </asp:Content>
