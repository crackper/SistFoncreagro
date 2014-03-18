<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FormDatosProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FormDatosProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" 
                Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <telerik:RadAutoCompleteBox ID="radcbPersonal" runat="server" Culture="es-ES" 
        DataSourceID="odsPersonal" AutoPostBack="True" DataTextField="ApePaterno" 
        DataValueField="IdPersonal">
    </telerik:RadAutoCompleteBox>
    <asp:ObjectDataSource ID="odsPersonal" runat="server" 
        SelectMethod="GetPersonalByCriterio" 
        TypeName="SistFoncreagro.BussinesLogic.PersonalBL">
        <SelectParameters>
            <asp:ControlParameter ControlID="radcbPersonal" Name="criterio" 
                PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
