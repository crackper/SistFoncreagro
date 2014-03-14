<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmNuevoCargoFlotante.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmNuevoCargoFlotante" %>

<%@ Register src="../Controles/ControlNuevoCargo.ascx" tagname="ControlNuevoCargo" tagprefix="uc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
   
</head>
<body>
 <form id="form1" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type ="text/javascript">
            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }
            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
          </script>
    </telerik:RadCodeBlock>
    <div>
    
        <table width="100%">
            <tr>
                <td>
                    <uc1:ControlNuevoCargo ID="ControlNuevoCargo1" runat="server" />
                </td>
                <td width="150">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td width="150">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
