<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaReporteOrdenCompra.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaReporteOrdenCompra" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=7.0.13.228, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 715px; height: 900px">
    <form id="form1" runat="server">
    <div>
    
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="900px" ProgressText="Generando Orden de Compra..."
            Skin="WebBlue" Width="720px" ShowHistoryButtons="False" 
            ShowNavigationGroup="False" ShowZoomSelect="True">
        </telerik:ReportViewer>
    
    </div>
    </form>
</body>
</html>
