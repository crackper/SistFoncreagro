<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmEjerPresup.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmEjerPresup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%" class="tabla3">
        <tr>
            <td >
                <table  class="fondoTabla">
                    <tr>
                        <td>
                            BANDEJA DE EJERCICIOS PRESUPUESTALES</td>
                        <td align="right" >
                            <asp:ImageButton ID="BtnDefault" runat="server" ImageUrl="~/img/cancel.gif" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RGPresup" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsEjerPresup" GridLines="None" 
                    AllowPaging="True" Skin="Hay">
                    <GroupingSettings CaseSensitive="False" />
<MasterTableView datasourceid="OdsEjerPresup" ClientDataKeyNames="IdEjerPresup" 
                        CommandItemDisplay="Top" DataKeyNames="IdEjerPresup">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Nuevo Ejercicio Presupuestal"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" 
            EditImageUrl="~/img/edit.gif" 
            FilterControlAltText="Filter EditCommandColumn column" HeaderText="Editar">
            <HeaderStyle Width="5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            FilterControlAltText="Filter column column" HeaderText="Eliminar" 
            ImageUrl="~/img/delete.gif" UniqueName="column">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdEjerPresup" DataType="System.Int32" 
            FilterControlAltText="Filter IdEjerPresup column" HeaderText="IdEjerPresup" 
            SortExpression="IdEjerPresup" UniqueName="IdEjerPresup" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Anio" 
            FilterControlAltText="Filter column2 column" HeaderText="Año" 
            UniqueName="Anio" SortExpression="Anio">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn DataField="FechaInicio" 
            FilterControlAltText="Filter Inicio column" HeaderText="Inicio" 
            SortExpression="FechaInicio" UniqueName="Inicio">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" 
                    Text='<%# validarfecha(databinder.eval(container.dataitem, "FechaInicio")) %>'></asp:Label>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn DataField="FechaFin" 
            FilterControlAltText="Filter FechaFin column" HeaderText="Fin" 
            SortExpression="FechaFin" UniqueName="FechaFin">
            <ItemTemplate>
                <asp:Label ID="Label2" runat="server" 
                    Text='<%# validarfecha(databinder.eval(container.dataitem, "FechaFin")) %>'></asp:Label>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter column1 column" HeaderText="Estado" 
            UniqueName="Estado" SortExpression="Estado">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
            SortExpression="Tipo" UniqueName="Tipo">
            <HeaderStyle Width="20%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\monitoreo\controles\ControlEjerPresup.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsEjerPresup" runat="server" 
                    SelectMethod="GetAllFromEjerPresup" 
                    TypeName="SistFoncreagro.BussinesLogic.EjerPresupBL"></asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
        </table>
</asp:Content>
