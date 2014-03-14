<%@ Page Title="Avance Físico Mensual" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="ReportePoaEjecutadoMeses.aspx.vb" Inherits="SistFoncreagro.WebSite.ReportePoaEjecutadoMeses" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.316, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%" class="tabla3">
        <tr>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td width="5%">
                                Año:</td>
                        <td width="10%">
                            <asp:TextBox ID="TextBox1" runat="server" Width="50px"></asp:TextBox>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td width="5%">
                                Meses:</td>
                        <td width="10%">
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                                Font-Names="arial" Font-Size="8pt" RepeatDirection="Horizontal" 
                                TextAlign="Left">
                                <asp:ListItem Value="Enero">Enero</asp:ListItem>
                                <asp:ListItem Value="Febrero">Febrero</asp:ListItem>
                                <asp:ListItem>Marzo</asp:ListItem>
                                <asp:ListItem>Abril</asp:ListItem>
                                <asp:ListItem>Mayo</asp:ListItem>
                                <asp:ListItem>Junio</asp:ListItem>
                                <asp:ListItem>Julio</asp:ListItem>
                                <asp:ListItem>Agosto</asp:ListItem>
                                <asp:ListItem>Setiembre</asp:ListItem>
                                <asp:ListItem>Octubre</asp:ListItem>
                                <asp:ListItem>Noviembre</asp:ListItem>
                                <asp:ListItem>Diciembre</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                                    ToolTip="Mostrar Ejecucion de Actividades" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="TextBox1">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="ReportViewer1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="CheckBoxList1">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="ReportViewer1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                        <telerik:AjaxSetting AjaxControlID="ImageButton1">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="ReportViewer1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManager>
                <telerik:ReportViewer ID="ReportViewer1" runat="server" BorderStyle="None" 
                        BorderWidth="1px" Height="600px" ParametersAreaVisible="False" 
                        ProgressText="Generando Vista Preliminar..." ShowHistoryButtons="False" 
                        ShowParametersButton="False" ShowZoomSelect="True" Width="100%">
                    <resources currentpagetooltip="Página actual" exportbuttontext="Exportar" 
                        exportselectformattext="Exportar al formato seleccionado" 
                        exporttooltip="Exportar" firstpagetooltip="Primera página" labelof="de" 
                        lastpagetooltip="Última página" nextpagetooltip="Página siguiente" 
                        previouspagetooltip="Página anterior" printtooltip="Imprimir" 
                        processingreportmessage="Generando Vista Preliminar..." 
                        refreshtooltip="Refrescar" zoomtopagewidth="Ancho de la página" 
                        zoomtowholepage="Página completa" />
                </telerik:ReportViewer>
            </td>
        </tr>
    </table>
</asp:Content>

