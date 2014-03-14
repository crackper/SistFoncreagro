<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReportePoaEjec.aspx.vb" Inherits="SistFoncreagro.WebSite.ReportePoaEjec" %>
<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=5.0.11.316, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ejecución de Actividades</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%">
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
                        ShowParametersButton="False" ShowZoomSelect="True" Width="1500px">
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
    
    </div>
    </form>
</body>
</html>
