<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FormDatosProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FormDatosProyecto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <telerik:RadAutoCompleteBox ID="radcbPersonal" runat="server" Culture="es-ES" 
        DataSourceID="odsPersonal" AutoPostBack="True" EmptyMessage="Ingrese apellidos o nombres"
        DataTextField="nombreCompleto" 
        DataValueField="IdPersonal" 
        DropDownWidth="400px"
        Width="400px" Skin="Hay" TextSettings-SelectionMode="Single">
<TextSettings SelectionMode="Single"></TextSettings>
    </telerik:RadAutoCompleteBox>
    <asp:ObjectDataSource ID="odsPersonal" runat="server" 
        SelectMethod="GetAllFromPersonal" 
        TypeName="SistFoncreagro.BussinesLogic.PersonalBL"></asp:ObjectDataSource>
</asp:Content>
