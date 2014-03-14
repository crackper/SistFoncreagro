<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dialog3.aspx.vb" Inherits="SistFoncreagro.WebSite.Dialog3" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Reprogramar Actividad</title>
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
            width: 668px;
        }
        
p
{
    margin-bottom: 10px;
    line-height: 1.6em;
}


        </style>
</head>
<body onload="AdjustRadWidow();">
    <form id="Form2" method="post" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
    </telerik:RadScriptManager>
    <telerik:RadFormDecorator ID="RadFormDecorator1" DecoratedControls="All" runat="server"
        Skin="Sunset" />
    

  

                                                <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                                </telerik:RadAjaxManager>

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
         oArg.idOC = '<%= Request.QueryString("IdControl") %>';
         oArg.observacion = document.getElementById("observacion").value;

         //get a reference to the current RadWindow
         var oWnd = GetRadWindow();

         //Close the RadWindow and send the argument to the parent page
         if (oArg.cityName) {
              //oWnd.close(oArg);
             if (oArg.observacion) {
                 $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("Validar");
                 //oWnd.close(oArg);
             }
             else {
                 alert("Debe ingresar la Observación");

             }
         }
         else {
             alert("Debe ingresar la Fecha de Reprogramación");
         }
     }
     function returnToParent1() {
         //create the argument that will be returned to the parent page
         var oArg = new Object();

         //get the city's name 
         oArg.cityName = document.getElementById("cityName").value;
         oArg.idOC = '<%= Request.QueryString("IdControl") %>';
         oArg.observacion = document.getElementById("observacion").value;

         //get a reference to the current RadWindow
         var oWnd = GetRadWindow();

         //Close the RadWindow and send the argument to the parent page
         if (oArg.cityName) {
             oWnd.close(oArg);
         }
         else {
             alert("Debe ingresar la Fecha de Reprogramación");
         }
     }
    </script>
    <table  width="300px">
        <tr>
            <td style="text-align: center" width="300px">
                Ingrese la Fecha de Reprogramación 
                y la observación y haga clic en el botón &quot;Aceptar&quot;<br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:TextBox ID="cityName" runat="server" TabIndex="1" Width="70px" />
                                                                                                                    <asp:MaskedEditExtender ID="MaskedEditExtender2" runat="server" 
                                                                                                                        AcceptNegative="None" CultureName="en-GB" Mask="99/99/9999" MaskType="Date" 
                                                                                                                        TargetControlID="cityName" />
                                                                                                                    <asp:MaskedEditValidator ID="MaskedEditValidator2" runat="server" 
                                                                                                                        ControlExtender="MaskedEditExtender2" ControlToValidate="cityName" 
                                                                                                                        Display="Dynamic" EmptyValueMessage="Ingrese la Fecha" 
                                                                                                                        InvalidValueMessage="¡Fecha Incorrecta!" />
                                                                                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator27" runat="server" 
                                                                                                                        ControlToValidate="cityName" Display="Dynamic" 
                                                                                                                        ErrorMessage="¡Debe ingresar la Fecha!"></asp:RequiredFieldValidator>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:TextBox ID="observacion" runat="server" Rows="2" TextMode="MultiLine" 
                    Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" 
                    ControlToValidate="observacion" Display="Dynamic" 
                    ErrorMessage="¡Debe ingresar la Observación!"></asp:RequiredFieldValidator>
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
