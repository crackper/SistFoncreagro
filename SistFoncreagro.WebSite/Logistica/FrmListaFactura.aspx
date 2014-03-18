<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaFactura.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:cnx %>" SelectCommand="ListaFacturas" 
        SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <fieldset>
        <legend style="font-family: Arial; font-size: 15px; width: 200px;">Consulta de Facturas
                </legend>
        <div style="height: 900px; overflow: scroll; width: 910px;" class="grid">
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
        AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" 
        DataSourceID="SqlDataSource1" GridLines="None" Skin="Hay">
        <GroupingSettings CaseSensitive="False" />
<MasterTableView datasourceid="SqlDataSource1" PageSize="50" CommandItemDisplay="Top">
<CommandItemSettings ExportToPdfText=" Exportar a PDF" 
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
        <telerik:GridBoundColumn DataField="NroFactura" 
            FilterControlAltText="Filter NroFactura column" HeaderText="Factura Nº" 
            ReadOnly="True" SortExpression="NroFactura" UniqueName="NroFactura" 
            ShowFilterIcon="False" FilterControlWidth="60px" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="60px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Proveedor" 
            FilterControlAltText="Filter Proveedor column" HeaderText="Proveedor" 
            SortExpression="Proveedor" UniqueName="Proveedor" ShowFilterIcon="False" 
            FilterControlWidth="250px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="250px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Area" 
            FilterControlAltText="Filter Area column" HeaderText="Area" 
            SortExpression="Area" UniqueName="Area" ShowFilterIcon="False" 
            FilterControlWidth="50px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CCosto" 
            FilterControlAltText="Filter CCosto column" HeaderText="C.C." 
            SortExpression="CCosto" UniqueName="CCosto" ShowFilterIcon="False" 
            FilterControlWidth="50px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="Filter Descripcion column" HeaderText="Producto" 
            SortExpression="Descripcion" UniqueName="Descripcion" 
            ShowFilterIcon="False" FilterControlWidth="250px" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="250px" />
            <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Cantidad" DataType="System.Decimal" 
            FilterControlAltText="Filter Cantidad column" HeaderText="Cantidad" 
            SortExpression="Cantidad" UniqueName="Cantidad" ShowFilterIcon="False" 
            FilterControlWidth="50px" DataFormatString="{0:n}" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" DataType="System.Decimal" 
            FilterControlAltText="Filter Monto column" HeaderText="Monto" 
            SortExpression="Monto" UniqueName="Monto" ShowFilterIcon="False" 
            DataFormatString="{0:n}" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Moneda" 
            FilterControlAltText="Filter Moneda column" HeaderText="Moneda" 
            SortExpression="Moneda" UniqueName="Moneda" ShowFilterIcon="False" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaFactura" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaFactura column" HeaderText="Fecha de Factura" 
            SortExpression="FechaFactura" UniqueName="FechaFactura" 
            ShowFilterIcon="False" DataFormatString="{0:dd/MM/yyyy}" 
            FilterControlWidth="50px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FecRecFactura" DataType="System.DateTime" 
            FilterControlAltText="Filter FecRecFactura column" HeaderText="Fecha Recepción de Factura" 
            SortExpression="FecRecFactura" UniqueName="FecRecFactura" 
            ShowFilterIcon="False" DataFormatString="{0:dd/MM/yyyy}" 
            FilterControlWidth="50px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="GuiaRemision" 
            FilterControlAltText="Filter GuiaRemision column" HeaderText="Nro. Guia Remisión" 
            SortExpression="GuiaRemision" UniqueName="GuiaRemision" 
            ShowFilterIcon="False" FilterControlWidth="85px" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="85px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaGuia" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaGuia column" HeaderText="Fecha de Guia Remisión" 
            SortExpression="FechaGuia" UniqueName="FechaGuia" ShowFilterIcon="False" 
            DataFormatString="{0:dd/MM/yyyy}" FilterControlWidth="50px" 
            AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NumeroOrdenCompra" 
            FilterControlAltText="Filter NumeroOrdenCompra column" 
            HeaderText="Nº Orden" SortExpression="NumeroOrdenCompra" 
            UniqueName="NumeroOrdenCompra" ShowFilterIcon="False" 
            FilterControlWidth="80px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo de Orden" 
            SortExpression="Tipo" UniqueName="Tipo" ShowFilterIcon="False" 
            FilterControlWidth="50px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="Filter Estado column" HeaderText="Estado" 
            SortExpression="Estado" UniqueName="Estado" ShowFilterIcon="False" 
            FilterControlWidth="50px" AutoPostBackOnFilter="True">
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </telerik:GridBoundColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle FirstPageToolTip="Primera Página" LastPageToolTip="Ultima Página" 
        NextPagesToolTip="Páginas Siguientes" NextPageToolTip="Página Siguiente" 
        PagerTextFormat="Change page: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, Registro del &lt;strong&gt;{2}&lt;/strong&gt; al &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
        PageSizeLabelText="Número de Registros por página" 
        PrevPagesToolTip="Páginas Anteriores" PrevPageToolTip="Página Anterior" />
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
    </telerik:RadGrid>
    </div>
    </fieldset>
</asp:Content>
