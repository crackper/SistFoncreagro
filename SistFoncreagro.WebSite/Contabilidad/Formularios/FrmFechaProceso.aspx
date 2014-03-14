<%@ Page Title="Fecha de Proceso" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmFechaProceso.aspx.vb" Inherits="SistFoncreagro.WebSite.ElegirEmpresa" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" class="tabla1">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr class="Titulos">
                        <td class="Titulos" style="font-family: Arial; font-size: 10pt">
                            &nbsp;Fecha de Proceso</td>
                        <td>
                            &nbsp;</td>
                        <td style="text-align: right">
                

        


                            &nbsp;</td>
                    </tr>
                </table>

        


            </td>
        </tr>
        <tr>
            <td>
    <table align="center" class="style1" >
    <tr class="Texto">
        <td colspan="2">
            Indique la Fecha de Proceso, luego haga clic en el botón &quot;Aceptar&quot;.</td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;</td>
    </tr>
    <tr class="Texto">
        <td>
            Fecha de Proceso:</td>
        <td style="text-align: left">

        
            <telerik:RadDatePicker ID="RadDatePicker1" Runat="server" Culture="es-PE" 
                Skin="Default" Width="100px">
<Calendar UseRowHeadersAsSelectors="False" UseColumnHeadersAsSelectors="False" ViewSelectorText="x"></Calendar>

<DateInput DisplayDateFormat="dd/MM/yyyy" DateFormat="dd/MM/yyyy"></DateInput>

<DatePopupButton ImageUrl="" HoverImageUrl="" ToolTip="Abrir Calendario."></DatePopupButton>
            </telerik:RadDatePicker>




        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Aceptar.gif" 
                ToolTip="Aceptar" AccessKey="s" />
        </td>
    </tr>
        </table>

        


            </td>
        </tr>
    </table>

        

         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>
     <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <script type="text/javascript">
           
            function Alerta(Texto) {
                radalert(Texto, 300, 50, "Alerta");
            }
           
        </script>
    </telerik:RadCodeBlock>
</asp:Content>