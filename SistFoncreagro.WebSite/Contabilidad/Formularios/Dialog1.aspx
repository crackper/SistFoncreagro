<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dialog1.aspx.vb" Inherits="SistFoncreagro.WebSite.Dialog1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Devolver Orden</title>
    <style type="text/css">
        html, body, form
        {
            padding: 0;
            margin: 0;
            height: 100%;
            background: #f2f2de;
        }
        
        body
        {
            font: normal 11px Arial, Verdana, Sans-serif;
        }
        
        fieldset
        {
            height: 150px;
        }
        
        * + html fieldset
        {
            height: 154px;
            width: 268px;
        }
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body onload="AdjustRadWidow();">
    <form id="Form2" method="post" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" runat="server"
        Skin="Sunset" />
    <script type="text/javascript">
        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow;
            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
            return oWindow;
        }

       
        function populateCityName(arg) {
            var cityName = document.getElementById("cityName");
            cityName.value = arg;
        }

        function AdjustRadWidow() {
            var oWindow = GetRadWindow();
            setTimeout(function () { oWindow.autoSize(true); if ($telerik.isChrome || $telerik.isSafari) ChromeSafariFix(oWindow); }, 500);
        }

        //fix for Chrome/Safari due to absolute positioned popup not counted as part of the content page layout
        function ChromeSafariFix(oWindow) {
            var iframe = oWindow.get_contentFrame();
            var body = iframe.contentWindow.document.body;

            setTimeout(function () {
                var height = body.scrollHeight;
                var width = body.scrollWidth;

                var iframeBounds = $telerik.getBounds(iframe);
                var heightDelta = height - iframeBounds.height;
                var widthDelta = width - iframeBounds.width;

                if (heightDelta > 0) oWindow.set_height(oWindow.get_height() + heightDelta);
                if (widthDelta > 0) oWindow.set_width(oWindow.get_width() + widthDelta);
                oWindow.center();

            }, 310);
        }

        function returnToParent() {
            //create the argument that will be returned to the parent page
            var oArg = new Object();

            //get the city's name 
            oArg.cityName = document.getElementById("cityName").value;
            oArg.idOC = '<%= Request.QueryString("idOCxFactura") %>';

            //get a reference to the current RadWindow
            var oWnd = GetRadWindow();
            
            //Close the RadWindow and send the argument to the parent page
            if (oArg.cityName) {
                oWnd.close(oArg);
            }
            else {
                alert("Debe ingresar el motivo de la devolución");
            }
        }

    </script>
    <table class="style1">
        <tr>
            <td style="text-align: center">
                Ingrese el motivo de la devolución</td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:TextBox ID="cityName" runat="server" Rows="5" TextMode="MultiLine" 
                    Width="265px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
            <button title="Submit" id="close" onclick="returnToParent(); return false;">
                Aceptar</button>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
