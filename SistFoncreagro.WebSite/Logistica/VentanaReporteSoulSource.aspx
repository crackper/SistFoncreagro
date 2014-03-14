<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaReporteSoulSource.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaReporteSoulSource" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.316, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="600px" 
                    ParametersAreaVisible="False" ProgressText="Generando Soul Source..." 
                    ShowExportGroup="False" ShowHistoryButtons="False" ShowNavigationGroup="False" 
                    ShowParametersButton="False" ShowRefreshButton="False" ShowZoomSelect="True" 
                    ToolbarVisible="False" Width="750px" ZoomPercent="97">
    </telerik:ReportViewer>
    </div>
    </form>
</body>
</html>
