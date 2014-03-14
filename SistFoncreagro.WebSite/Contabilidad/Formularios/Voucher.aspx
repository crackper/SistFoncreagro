﻿<%@ Page Title="Vista Preliminar" Language="vb" AutoEventWireup="false"  CodeBehind="Voucher.aspx.vb" Inherits="SistFoncreagro.WebSite.Voucher" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.316, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Voucher Contable</title>
       <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: #FFFFFF" >
        <table align="center" class="tabla5">
            <tr>
                <td>
                    <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="900px" 
            ParametersAreaVisible="False" ProgressText="Generando Vista Preliminar..." 
               Width="850px" BorderStyle="None" BorderWidth="1px" ShowHistoryButtons="False" 
                        ShowZoomSelect="True" ShowParametersButton="False">
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
   </div>
    </form>
</body>
</html>      

