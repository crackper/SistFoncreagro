<%@ Page Title="Reporte de Bienes Inmuebles" Language="vb" AutoEventWireup="false" MasterPageFile="~/Patrimonio/MasterPagePatrimonio.master" CodeBehind="ReporteInmuebles.aspx.vb" Inherits="SistFoncreagro.WebSite.ReporteInmuebles" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.316, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
        <table align="center" class="tabla4">
            <tr>
                <td>
                    <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="800px" 
            ParametersAreaVisible="False" ProgressText="Generando Vista Preliminar..." 
               Width="100%" BorderStyle="None" BorderWidth="1px" ShowHistoryButtons="False" 
                        ShowZoomSelect="True" ShowParametersButton="False" 
                        style="text-align: center">
                        <Resources CurrentPageToolTip="P&#225;gina actual" ExportButtonText="Exportar" ExportSelectFormatText="Exportar al formato seleccionado"
            ExportToolTip="Exportar" FirstPageToolTip="Primera p&#225;gina" LabelOf="de"
            LastPageToolTip="&#218;ltima p&#225;gina" NextPageToolTip="P&#225;gina siguiente"
            PreviousPageToolTip="P&#225;gina anterior" PrintToolTip="Imprimir" ProcessingReportMessage="Generando Vista Preliminar..."
            RefreshToolTip="Refrescar" ZoomToPageWidth="Ancho de la p&#225;gina" 
                 ZoomToWholePage="P&#225;gina completa" />
                    </telerik:ReportViewer>
                   
                </td>
            </tr>
        </table>
    </asp:Content>

