<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmComponentes1.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmComponentes1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
        <script type ="text/javascript">
            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow;
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow;
                return oWindow;
            }
            function CerrarVentana(indicador) {
                var oWnd = GetRadWindow();
                var oArg = new Object();
                oArg.indicador = indicador;
                oWnd.close(oArg);
            }
          </script>
    </telerik:RadCodeBlock>

    <table style="width: 100%" class="tabla3">
        <tr>
            <td>
                <table style="width: 100%" class = "fondoTabla">
                    <tr>
                        <td style="width: 821px">
                            BANDEJA DE COMPONENTES</td>
                        <td align="right">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/cancel.gif" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsComponentes" 
                    GridLines="None" Skin="Hay" Width="100%" AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
<MasterTableView ClientDataKeyNames="IdComponente" CommandItemDisplay="Top" 
                        DataKeyNames="IdComponente" DataSourceID="OdsComponentes">
<CommandItemSettings ExportToPdfText="" AddNewRecordText="Agregar Registro" 
        ExportToExcelText="" RefreshText="Actualizar"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" 
            EditImageUrl="~/img/edit.gif" 
            FilterControlAltText="Filter EditCommandColumn column" EditText="Editar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column column" 
            ImageUrl="~/img/delete.gif" UniqueName="column" CommandName="Delete" 
            Text="Eliminar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdComponente" DataType="System.Int32" 
            FilterControlAltText="Filter IdComponente column" HeaderText="IdComponente" 
            SortExpression="IdComponente" UniqueName="IdComponente" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Código" 
            SortExpression="Codigo" UniqueName="Codigo" AllowFiltering="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="Nombre" ShowFilterIcon = "false" FilterControlWidth = "50%"
             CurrentFilterFunction = "Contains" AutoPostBackOnFilter = "true">
            <HeaderStyle Width="43%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
            SortExpression="Descripcion" UniqueName="Descripcion" 
            AllowFiltering="False">
            <HeaderStyle Width="44%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Monitoreo\Controles\ControlComponentes1.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="OdsComponentes" runat="server" 
                    SelectMethod="GetAllFromComponente" 
                    TypeName="SistFoncreagro.BussinesLogic.ComponenteBL"></asp:ObjectDataSource>
                <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                </telerik:RadWindowManager>
            </td>
        </tr>
    </table>
</asp:Content>

