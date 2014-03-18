<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="VentanaReporteSolicitarCotizacion.aspx.vb" Inherits="SistFoncreagro.WebSite.VentanaReporteSolicitarCotizacion" %>

<%@ Register assembly="Telerik.ReportViewer.WebForms, Version=7.0.13.228, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" namespace="Telerik.ReportViewer.WebForms" tagprefix="telerik" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">


.RadComboBox_Default
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #333;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Default
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #333;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox_Default
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #333;
}

.RadComboBox
{
	vertical-align: middle;
    display: -moz-inline-stack;
    display: inline-block;
}

.RadComboBox
{
	text-align: left;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox *
{
	margin: 0;
	padding: 0;
}

.RadComboBox_Default .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Default .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Default .rcbInputCellLeft
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbInputCellLeft
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Default .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #333;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Default .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #333;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Default .rcbInput
{
	font: 12px "Segoe UI", Arial, sans-serif;
	color: #333;
}

.RadComboBox .rcbInput
{
	text-align: left;
}

.RadComboBox_Default .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Default .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

.RadComboBox_Default .rcbArrowCellRight
{
	background-image: url('mvwres://Telerik.Web.UI, Version=2011.1.315.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.ComboBox.rcbSprite.png');
}

.RadComboBox .rcbArrowCellRight
{
	background-color: transparent;
	background-repeat: no-repeat;
}

    </style>
</head>
<body style="width: 715px; height: 900px">
    <form id="form1" runat="server">
    <div>
    <table class="style3">
        <tr>
            <td>
                Lugar :</td>
            <td colspan="2">
                                                                                            <telerik1:RadComboBox ID="rcmbLugar" Runat="server" AllowCustomText="True" 
                                                                                                DataSourceID="obsRuta" DataTextField="Nombre" 
                                                                                                
                        DataValueField="IdRutaRequerimiento" EnableLoadOnDemand="True" 
                                                                                                
                        EnableVirtualScrolling="True" ItemsPerRequest="10" Width="400px" 
                    EmptyMessage="Ingrese lugar de entrega...">
                                                                                            </telerik1:RadComboBox>
                </td>
            <td>
    <asp:ObjectDataSource ID="obsRuta" runat="server" 
        SelectMethod="GetAllFromRutaRequerimiento" 
        TypeName="SistFoncreagro.BussinesLogic.RutaRequerimientoBL">
    </asp:ObjectDataSource>
                </td>
        </tr>
        <tr>
            <td>
                Plazo :</td>
            <td>
                <asp:TextBox ID="txtPlazo" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtPlazo" ErrorMessage="*" Font-Size="9pt" 
                    ValidationGroup="l"></asp:RequiredFieldValidator>
                </td>
            <td align="right">
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" ValidationGroup="l" />
                </td>
            <td>
                <telerik1:RadScriptManager ID="RadScriptManager1" Runat="server">
                </telerik1:RadScriptManager>
                </td>
        </tr>
    </table>
        <telerik1:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik1:AjaxSetting AjaxControlID="btnMostrar">
                    <UpdatedControls>
                        <telerik1:AjaxUpdatedControl ControlID="ReportViewer1" />
                        <telerik1:AjaxUpdatedControl ControlID="GridView1" />
                    </UpdatedControls>
                </telerik1:AjaxSetting>
            </AjaxSettings>
        </telerik1:RadAjaxManager>
        <telerik:ReportViewer ID="ReportViewer1" runat="server" Height="758px" ProgressText="Generando Reporte..."
            Skin="WebBlue" Width="720px" ShowHistoryButtons="False" 
            ShowNavigationGroup="False" ShowZoomSelect="True">
        </telerik:ReportViewer>
    
    </div>
    </form>
</body>
</html>
