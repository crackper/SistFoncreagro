<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RRHH/MasterPageRRHH.master" CodeBehind="FrmFeriado.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmFeriado" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <asp:HiddenField ID="HFIdFeriado" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsFeriado" 
                    GridLines="None">
<MasterTableView clientdatakeynames="IdFeriado" commanditemdisplay="Top" datakeynames="IdFeriado" 
                        datasourceid="OdsFeriado">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        addnewrecordtext="Nuevo Registro"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            FilterControlAltText="Filter column column" HeaderText="Edit." 
            ImageUrl="~/img/edit.gif" UniqueName="column">
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column1 column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="column1">
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdFeriado" DataType="System.Int32" 
            FilterControlAltText="Filter IdFeriado column" HeaderText="IdFeriado" 
            SortExpression="IdFeriado" UniqueName="IdFeriado" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Fecha" DataType="System.DateTime" 
            FilterControlAltText="Filter Fecha column" HeaderText="Fecha" 
            SortExpression="Fecha" UniqueName="Fecha">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Origen" 
            FilterControlAltText="Filter Origen column" HeaderText="Origen" 
            SortExpression="Origen" UniqueName="Origen">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="Recuperable" DataType="System.Boolean" 
            FilterControlAltText="Filter Recuperable column" HeaderText="Recuperable" 
            SortExpression="Recuperable" UniqueName="Recuperable">
        </telerik:GridCheckBoxColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsFeriado" runat="server" 
                    SelectMethod="GetAllFromFeriado" 
                    TypeName="SistFoncreagro.BussinesLogic.FeriadoBL"></asp:ObjectDataSource>
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
