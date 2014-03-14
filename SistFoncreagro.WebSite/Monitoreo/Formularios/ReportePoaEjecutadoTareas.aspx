<%@ Page Title="Reporte de Ejecucion Por Tareas/Año" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="ReportePoaEjecutadoTareas.aspx.vb" Inherits="SistFoncreagro.WebSite.ReportePoaEjecutadoTareas" %>
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
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/Buscar.gif" 
                                    ToolTip="Mostrar Ejecucion de Actividades" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
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
