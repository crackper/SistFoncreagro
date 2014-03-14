<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmElementoGasto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmElementoGasto" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
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
                            BANDEJA DE ELEMENTOS GASTO</td>
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
                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsElementoGasto" 
                    GridLines="None" Skin="Hay" Width="100%" AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
<MasterTableView ClientDataKeyNames="IdElemGasto" CommandItemDisplay="Top" 
                        DataKeyNames="IdElemGasto" DataSourceID="OdsElementoGasto">
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
            FilterControlAltText="Filter EditCommandColumn column" EditText="Editar" >
            <HeaderStyle Width="1.5%" />
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter column column" 
            ImageUrl="~/img/delete.gif" UniqueName="column" CommandName="Delete" 
            Text="Eliminar">
            <HeaderStyle Width="1.5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdElemGasto" DataType="System.Int32" 
            FilterControlAltText="Filter IdElemGasto column" HeaderText="IdComponente" 
            SortExpression="IdElemGasto" UniqueName="IdElemGasto" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CodElemGasto" 
            FilterControlAltText="Filter Codigo column" HeaderText="Código" 
            SortExpression="Codigo" UniqueName="Codigo" AllowFiltering="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NomElemGasto" 
            FilterControlAltText="Filter Nombre column" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="Nombre" ShowFilterIcon ="false" 
            FilterControlWidth = "150px" AutoPostBackOnFilter="True" CurrentFilterFunction="Contains"
             >
            <HeaderStyle Width="33%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DesElemGasto" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Descripcion" 
            SortExpression="Descripcion" UniqueName="Descripcion" 
            ShowFilterIcon="false" FilterControlWidth = "250px" AutoPostBackOnFilter="True" CurrentFilterFunction="Contains"
            >
            <HeaderStyle Width="34%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DescripClasif" 
            FilterControlAltText="Filter DescripClasif column" HeaderText="Tipo" 
            UniqueName="DescripClasif" AllowFiltering="False">
            <HeaderStyle Width="20%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings EditFormType="WebUserControl" 
        UserControlName="~\Monitoreo\Controles\ControlElementoGasto.ascx">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsElementoGasto" runat="server" 
                    SelectMethod="GetAllFromElementoGasto" 
                    TypeName="SistFoncreagro.BussinesLogic.ElementoGastoBL"></asp:ObjectDataSource>
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
