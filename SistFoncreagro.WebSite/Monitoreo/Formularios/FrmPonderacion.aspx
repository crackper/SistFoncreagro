<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmPonderacion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmPonderacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <table style="width: 100%" class = "fondoTabla">
                    <tr>
                        <td class="style2" style="width: 876px">
                            PONDERACIONES POR EJERCICIO PRESUPUESTAL</td>
                        <td align="right">
                            <asp:ImageButton ID="BtnCerrar" runat="server" ImageUrl="~/img/cancel.gif" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar Proyecto" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <asp:ObjectDataSource ID="OdsProyecto" runat="server" 
                        SelectMethod="GetAllFromProyectoDatoPrincipal" 
                        TypeName="SistFoncreagro.BussinesLogic.ProyectoBL"></asp:ObjectDataSource>
                    <telerik:RadGrid ID="RGProyecto" runat="server" 
    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsProyecto" 
    GridLines="None" AllowFilteringByColumn="True" AllowPaging="True">
                        <GroupingSettings CaseSensitive="False" />
                        <MasterTableView datasourceid="OdsProyecto" ClientDataKeyNames="IdProyecto" 
                            DataKeyNames="IdProyecto">
                            <CommandItemSettings ExportToPdfText="Export to PDF">
                            </CommandItemSettings>
                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                <HeaderStyle Width="20px"></HeaderStyle>
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                <HeaderStyle Width="20px"></HeaderStyle>
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridButtonColumn CommandName="Select" 
                                    FilterControlAltText="Filter Select column" HeaderText="Seleccionar" 
                                    Text="Seleccionar" UniqueName="Select">
                                    <HeaderStyle Width="10%" />
                                </telerik:GridButtonColumn>
                                <telerik:GridBoundColumn DataField="IdProyecto" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
            SortExpression="IdProyecto" UniqueName="IdProyecto" Visible="False">
                                    <HeaderStyle Width="0%" />
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo" AllowFiltering="False">
                                    <HeaderStyle Width="15%" />
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="Nombre" ShowFilterIcon = "false" CurrentFilterFunction ="Contains"
             FilterControlWidth = "40%" AutoPostBackOnFilter="True">
                                    <HeaderStyle Width="75%" />
                                </telerik:GridBoundColumn>
                            </Columns>
                            <EditFormSettings>
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                        </FilterMenu>
                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                        </HeaderContextMenu>
                    </telerik:RadGrid>
                    <asp:Button ID="BtnOcultar" runat="server" Text="&lt;&lt;Ocultar" />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Small"></asp:Label>
                <asp:HiddenField ID="HFIdProyecto" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
