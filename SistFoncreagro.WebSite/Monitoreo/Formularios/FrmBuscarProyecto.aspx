<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmBuscarProyecto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmBuscarProyecto" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%" class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="width: 100%; height: 25px;">
                    <tr>
                        <td style="width: 890px">
                            BANDEJA DE PROYECTOS</td>
                        <td align="right">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/cancel.gif" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
                    DynamicHorizontalOffset="2" Font-Names="Arial" Font-Size="Small" 
                    ForeColor="#284E98" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#CCFFFF" />
                    <Items>
                        <asp:MenuItem Text="Ir a..." Value="Ir a...">
                            <asp:MenuItem Text="Estructura" Value="Estructura">
                                <asp:MenuItem Text="Convenio" Value="Convenio"></asp:MenuItem>
                                <asp:MenuItem Text="Componentes" Value="Componentes"></asp:MenuItem>
                                <asp:MenuItem Text="Actividades" Value="Actividades"></asp:MenuItem>
                                <asp:MenuItem Text="Centros de Costo" Value="CCostos"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="Datos Generales" Value="Datos"></asp:MenuItem>
                            <asp:MenuItem Text="Ambito/Beneficiarios" Value="Ambito"></asp:MenuItem>
                            <asp:MenuItem Text="Informes" Value="Informes"></asp:MenuItem>
                            <asp:MenuItem Text="Avance Físico" Value="AvanFis"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Mensual" Value="ForFin"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Anual" Value="ForAnual"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
                </td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="RadGrid2" runat="server" 
                    AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" 
                    DataSourceID="OdsProyecto" GridLines="None" Skin="Hay" PageSize="7" 
                    AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
                    <ClientSettings>
                        <Selecting AllowRowSelect="True" />
                    </ClientSettings>
<MasterTableView datasourceid="OdsProyecto" ClientDataKeyNames="IdProyecto" 
                        CommandItemDisplay="Top" DataKeyNames="IdProyecto" 
                       >
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Registro" ExportToExcelText="Exportar a Excel" 
        ShowExportToExcelButton="True" ShowExportToPdfButton="True"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter Eliminar column" HeaderText="Eliminar" 
            ImageUrl="~/img/delete.gif" UniqueName="Eliminar">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdProyecto" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyecto column" HeaderText="IdProyecto" 
            SortExpression="IdProyecto" UniqueName="IdProyecto" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Area" 
            SortExpression="Codigo" UniqueName="Codigo" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle Width="9%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="Filter Nombre column" HeaderText="Proyecto" 
            SortExpression="Nombre" UniqueName="Nombre" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle Width="36%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Personal.nombreCompleto" 
            FilterControlAltText="Filter NombreResponsable column" HeaderText="Responsable" 
            ReadOnly="True" SortExpression="NombreResponsable" 
            UniqueName="NombreResponsable" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle Width="26%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" DataType="System.Decimal" 
            FilterControlAltText="Filter Monto column" HeaderText="Monto" 
            SortExpression="Monto" UniqueName="Monto" DataFormatString="{0:#,##0.00}" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Alineamiento" 
            FilterControlAltText="Filter Alineamiento column" HeaderText="Alineamiento" 
            SortExpression="Alineamiento" UniqueName="Alineamiento" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="100%" ShowFilterIcon="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" 
            SortExpression="Estado" UniqueName="Estado" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" FilterControlWidth="100%" 
            ShowFilterIcon="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
            </td>
        </tr>
        </table>
          <telerik:RadWindowManager ID="RWMensajes" runat="server" >
                    <Windows>
                        <telerik:RadWindow ID="Formulario" runat="server" NavigateUrl="ListaStakeHolders.aspx" ReloadOnShow="true"  ShowContentDuringLoad="false" Modal="true">
                        </telerik:RadWindow>
                    </Windows>
                </telerik:RadWindowManager>   
                <asp:HiddenField ID="HIdProyecto" runat="server" />
                 <asp:ObjectDataSource ID="OdsProyecto" runat="server" 
                    SelectMethod="GetAllFromProyecto" 
                    TypeName="SistFoncreagro.BussinesLogic.ProyectoBL" 
                    OldValuesParameterFormatString="original_{0}">
                </asp:ObjectDataSource>
</asp:Content>
