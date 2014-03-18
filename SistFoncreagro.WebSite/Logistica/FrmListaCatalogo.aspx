<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaCatalogo.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaCatalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="ListaProductos" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <fieldset>
        <legend style="font-family: Arial; font-size: 15px; width: 310px;">Consulta Catalogo Productos / Servicios
                </legend>
    <div style="height: 900px; overflow: scroll; width: 910px;" class="grid">
    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None" Skin="Hay" 
            AllowFilteringByColumn="True" AllowPaging="True" PageSize="50">
        <GroupingSettings CaseSensitive="False" />
<MasterTableView datasourceid="SqlDataSource1" CommandItemDisplay="Top">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Agregar Nuevo Registro" ExportToCsvText="Exportar a CSV" 
        ExportToExcelText="Exportar a Excel" ExportToWordText="Exportar a Word" 
        RefreshText="Actualizar" ShowAddNewRecordButton="False" 
        ShowExportToExcelButton="True" ShowRefreshButton="False"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" FilterControlWidth="150px" 
            HeaderText="Descripción" ShowFilterIcon="False" SortExpression="Descripcion" 
            UniqueName="Descripcion">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" FilterControlWidth="75px" 
            HeaderText="Tipo" ReadOnly="True" ShowFilterIcon="False" SortExpression="Tipo" 
            UniqueName="Tipo">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="75px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Presentación" 
            FilterControlAltText="Filter Presentación column" FilterControlWidth="50px" 
            HeaderText="Presentación" ShowFilterIcon="False" SortExpression="Presentación" 
            UniqueName="Presentación">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Marca" 
            FilterControlAltText="Filter Marca column" HeaderText="Marca" 
            ShowFilterIcon="False" SortExpression="Marca" UniqueName="Marca" 
            FilterControlWidth="50px">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="ExoneradoIGV" 
            FilterControlAltText="Filter ExoneradoIGV column" FilterControlWidth="80px" 
            HeaderText="Exonerado IGV" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="ExoneradoIGV" UniqueName="ExoneradoIGV">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="Proveedor" 
            FilterControlAltText="Filter Proveedor column" FilterControlWidth="150px" 
            HeaderText="Proveedor" ReadOnly="True" ShowFilterIcon="False" 
            SortExpression="Proveedor" UniqueName="Proveedor">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" DataField="PrecioCompra" DataType="System.Decimal" 
            FilterControlAltText="Filter PrecioCompra column" FilterControlWidth="50px" 
            HeaderText="Precio" ShowFilterIcon="False" SortExpression="PrecioCompra" 
            UniqueName="PrecioCompra" DataFormatString="{0:n}">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

        <PagerStyle FirstPageToolTip="Primera Página" LastPageToolTip="Ultima Página" 
            NextPagesToolTip="Paginas Siguientes" NextPageToolTip="Pagina Siguiente" 
            PagerTextFormat="Change page: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, Registros del &lt;strong&gt;{2}&lt;/strong&gt; al &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
            PageSizeLabelText="Registros por página" PrevPagesToolTip="Páginas Anteriores" 
            PrevPageToolTip="Página Anterior" />

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
    </div>
    </fieldset>
</asp:Content>
