<%@ Page Title="Mensaje de Alerta" Language="vb" AutoEventWireup="false" MasterPageFile="~/Contabilidad/MasterPageContabilidad.master" CodeBehind="Validacion.aspx.vb" Inherits="SistFoncreagro.WebSite.WebForm2" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
        <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">

        <script type="text/javascript">

            function Alerta(Texto) {
                radalert(Texto, 300, 100, "Alerta");
            }
           
        </script>
    </telerik:RadCodeBlock>
</asp:Content>
