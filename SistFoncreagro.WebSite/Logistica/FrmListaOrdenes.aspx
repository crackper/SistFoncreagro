<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaOrdenes.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaOrdenes" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="DSListOrdenes" runat="server" 
    ConnectionString="<%$ ConnectionStrings:cnx %>" 
    SelectCommand="ListadoOrdenesCompra" SelectCommandType="StoredProcedure">
</asp:SqlDataSource>
    <fieldset>
        <legend style="font-family: Arial; font-size: 15px; width: 200px;">Consulta 
            de Ordenes </legend>
    <div style="width: 1150px; overflow: auto;">
   
<telerik:RadGrid ID="GridListOrdenes" runat="server" 
    AllowFilteringByColumn="True" AutoGenerateColumns="False" CellSpacing="0" 
    DataSourceID="DSListOrdenes" GridLines="None" Skin="Hay" AllowPaging="True" 
        Height="500px" Width="100%">
    <GroupingSettings CaseSensitive="False" />
    <MasterTableView datakeynames="IdOrdenCompra" datasourceid="DSListOrdenes" 
        PageSize="10">
        <CommandItemSettings ExportToPdfText="Exportar a PDF" 
            ExportToCsvText="Exportar a CSV" ExportToExcelText="Exportar a Excel" 
            ExportToWordText="Exportar a Word" ShowExportToExcelButton="True" 
            ShowRefreshButton="False" AddNewRecordText="Agregar Nuevo Registro" 
            ShowAddNewRecordButton="False">
        </CommandItemSettings>
        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
            <HeaderStyle Width="20px"></HeaderStyle>
        </RowIndicatorColumn>
        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
            <HeaderStyle Width="20px"></HeaderStyle>
        </ExpandCollapseColumn>
        <Columns>
            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="detalle" 
                FilterControlAltText="Filter column column" UniqueName="detalle" 
                ImageUrl="~\img\Mas.gif" Text="Ver Detalle">
            </telerik:GridButtonColumn>
            <telerik:GridBoundColumn AllowFiltering="False" DataField="IdOrdenCompra" 
                DataType="System.Int32" FilterControlAltText="Filter IdOrdenCompra column" 
                HeaderText="IdOrden" ReadOnly="True" SortExpression="IdOrdenCompra" 
                UniqueName="IdOrdenCompra" Visible="False" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
                AutoPostBackOnFilter="True" DataField="NroOrden" 
                FilterControlAltText="Filter NroOrden column" HeaderText="Nº de Orden" 
                ShowFilterIcon="False" SortExpression="NroOrden" UniqueName="NroOrden" 
                ReadOnly="True">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Area" 
                FilterControlAltText="Filter Area column" HeaderText="Area" 
                SortExpression="Area" UniqueName="Area" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="NomCotizacion" 
                FilterControlAltText="Filter NomCotizacion column" HeaderText="Nombre de Cotización" 
                SortExpression="NomCotizacion" UniqueName="NomCotizacion" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                FilterControlWidth="200px" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Monto" DataType="System.Decimal" 
                FilterControlAltText="Filter Monto column" HeaderText="Monto" ReadOnly="True" 
                SortExpression="Monto" UniqueName="Monto" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                DataFormatString="{0:n}" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Moneda" 
                FilterControlAltText="Filter Moneda column" HeaderText="Moneda" 
                SortExpression="Moneda" UniqueName="Moneda" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Proveedor" 
                FilterControlAltText="Filter Proveedor column" HeaderText="Proveedor" 
                SortExpression="Proveedor" UniqueName="Proveedor" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                FilterControlWidth="300px" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="300px" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="TipoCompra" 
                FilterControlAltText="Filter TipoCompra column" HeaderText=" Tipo de Compra" 
                ReadOnly="True" SortExpression="TipoCompra" UniqueName="TipoCompra" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                FilterControlWidth="100px" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="FormaPago" 
                FilterControlAltText="Filter FormaPago column" HeaderText="Forma de Pago" 
                SortExpression="FormaPago" UniqueName="FormaPago" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="TipoOrdenCompra" 
                FilterControlAltText="Filter TipoOrdenCompra column" 
                HeaderText="Tipo de Orden" SortExpression="TipoOrdenCompra" 
                UniqueName="TipoOrdenCompra" AndCurrentFilterFunction="Contains" 
                AutoPostBackOnFilter="True" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="FechaOrden" DataType="System.DateTime" 
                FilterControlAltText="Filter FechaOrden column" HeaderText="Fecha de OC" 
                SortExpression="FechaOrden" UniqueName="FechaOrden" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                DataFormatString="{0:dd/MM/yyyy}" ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
            <telerik:GridBoundColumn DataField="Estado" 
                FilterControlAltText="Filter Estado column" HeaderText="Estado" ReadOnly="True" 
                SortExpression="Estado" UniqueName="Estado" 
                AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
                ShowFilterIcon="False">
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </telerik:GridBoundColumn>
        </Columns>
        <EditFormSettings>
            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
            </EditColumn>
        </EditFormSettings>
        <PagerStyle AlwaysVisible="True" FirstPageToolTip="Primera Página" 
            LastPageToolTip="Ultima Página" NextPagesToolTip="Siguientes Páginas" 
            NextPageToolTip="Siguiente Página" 
            PagerTextFormat="Change page: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, Registro &lt;strong&gt;{2}&lt;/strong&gt; a &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
            PageSizeLabelText="Registros por Página:" PrevPagesToolTip="Páginas Previas" 
            PrevPageToolTip="Página Prevía" />
    </MasterTableView>
    <FilterMenu EnableImageSprites="False">
    </FilterMenu>
    <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
    </HeaderContextMenu>
</telerik:RadGrid>
 </div>
    </fieldset>&nbsp;<telerik:RadWindowManager ID="RadWindowManager1" runat="server" AutoSize="True"
        Behaviors="Resize, Close, Move" Height="800px" 
        Modal="True" Width="1000px" Behavior="Resize, Close, Move"  
        ReloadOnShow="True" >
        <Windows>
            <telerik:RadWindow ID="Formulario" runat="server" 
                Modal="True" AutoSize="True" Behavior="Resize, Close, Move, Reload" 
                Behaviors="Resize, Close, Move, Reload" 
                ReloadOnShow="True" >
                <Localization Close="Cerrar" Reload="Refrescar" />
            </telerik:RadWindow>
        </Windows>
    </telerik:RadWindowManager>
    </asp:Content>
  
