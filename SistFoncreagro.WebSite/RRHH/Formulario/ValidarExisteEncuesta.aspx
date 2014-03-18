<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ValidarExisteEncuesta.aspx.vb" Inherits="SistFoncreagro.WebSite.ValidarExisteEncuesta" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        

         <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                            </telerik:RadWindowManager>

         <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
         </telerik:RadScriptManager>
         <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
    <script type="text/javascript">
               function Alerta(Texto) {
            radalert(Texto, 300, 50, "Alerta");
        }

        function alertCallBackFn(arg) {
            window.open("PrincipalRRHH.aspx", "_self");
        }
        
    </script>
</telerik:RadCodeBlock>

    </div>
    </form>
</body>
</html>
