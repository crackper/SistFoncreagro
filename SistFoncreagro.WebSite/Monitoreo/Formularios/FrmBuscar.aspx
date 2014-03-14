<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmBuscar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmBuscar" %>

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
        #TxtDato
        {
            width: 454px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>




    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
 <script type="text/javascript">
        //<![CDATA[
     function openWin() {
         var oWnd = radopen("FrmBuscar.aspx", "RadWindow1");
     }

     function OnClientClose(oWnd, args) {
         //get the transferred arguments

         var arg = args.get_argument();
         if (arg) {
             var DatoTexto = arg.DatoTexto;
             
         }
     }
        //]]>
    </script>

    </telerik:RadCodeBlock>
   




    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
        <Windows>
            <telerik:RadWindow runat="server" 
                NavigateUrl="~/Monitoreo/Formularios/FrmConvenioMarco.aspx"
                OpenerElementID="Button1" Modal="True" EnableTheming="True" 
                >
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            &nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <input id="TxtDato" type="text" /></td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
