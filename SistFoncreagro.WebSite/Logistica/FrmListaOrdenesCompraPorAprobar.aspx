<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaOrdenesCompraPorAprobar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaOrdenesCompraPorAprobar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
            <legend style="font-family: Arial; font-size: 12px; width: 192px;">Aprobar Órdenes de Compra</legend>
            <div style="height: 530px; overflow: scroll; width: 895px;" class="grid">
    <telerik:RadGrid ID="RadGrid1" runat="server"  AllowPaging="True" AllowFilteringByColumn="True"
      AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsRequerimientos" 
                       GridLines="None" Skin="Hay" Width="1400px" CssClass="GrillaStyle">
                        <GroupingSettings CaseSensitive="False" 
                            GroupSplitDisplayFormat="Mostrando {0} de {1} items." />
                        <ClientSettings AllowColumnHide="True" 
                            AllowColumnsReorder="True">
                            <DataBinding EnableCaching="True">
                            </DataBinding>
                            <Selecting AllowRowSelect="True" />
                            <ClientMessages DragToGroupOrReorder="Arrastre el Item con el que desea Agrupar los datos" 
                                DropHereToReorder="Coloque aqui para reordenar" 
                                PagerTooltipFormatString="Pagina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;" />
                        </ClientSettings>
<MasterTableView datasourceid="odsRequerimientos" pagesize="15" DataKeyNames="IdRequerimiento">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridTemplateColumn UniqueName="TemplateColumn" AllowFiltering="False">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmOrdenCompraPorAprobar.aspx?IdOrdenCompra=" & Eval("IdOrdenCompra") %>'
          ToolTip="Editar Requerimiento de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>
     <telerik:GridBoundColumn DataField="NumeroOrden" 
            FilterControlAltText="Filter NumeroOrden column" 
            HeaderText="Nro O/C" SortExpression="NumeroOrden" 
            UniqueName="NumeroOrden" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="60px" HorizontalAlign="Center" Font-Size="8pt" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CodigoAreaD" 
            FilterControlAltText="filtro80" HeaderText="Área" 
            UniqueName="TemplateColumn90" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="40px" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="40px" />
            <ItemStyle HorizontalAlign="Center" Width="40px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
            SortExpression="Tipo" UniqueName="Tipo" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="70px">
            <HeaderStyle HorizontalAlign="Center" Width="70px" />
            <ItemStyle HorizontalAlign="Center" Width="70px" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn FilterControlAltText="Filter FechaGeneraOrden column" 
            HeaderText="Fecha O/C" UniqueName="FechaGeneraOrden" 
            DataField="FechaGeneraOrden" DataType="System.DateTime" 
            SortExpression="FechaGeneraOrden" DataFormatString="{0:dd/MM/yyyy}" 
            AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="RequeridoPorD" 
            FilterControlAltText="Filter IdRequeridoPor column" HeaderText="Requerido Por" 
            UniqueName="IdRequeridoPor" 
            SortExpression="RequeridoPorD" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="250px">
            <HeaderStyle HorizontalAlign="Center" Width="250px" />
            <ItemStyle HorizontalAlign="Center" Width="250px" />
        </telerik:GridBoundColumn>

        <telerik:GridTemplateColumn DataField="Estado" HeaderText="Estado" SortExpression="Estado"
                            UniqueName="EstadoTemplate" FilterControlWidth="115px" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False" AndCurrentFilterFunction="Contains">
        <ItemTemplate>
             <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor='<%# ObtenerColor(Eval("Estado")) %>'
                Text='<%# Eval("Estado") %>'></asp:Label>
        </ItemTemplate>
          <HeaderStyle HorizontalAlign="Center" Width="115px" />
          <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>

        <telerik:GridBoundColumn DataField="RazonSocialD" 
            FilterControlAltText="Filter column3 column" HeaderText="Proveedor" 
            UniqueName="column3" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="250px">
            <HeaderStyle Width="300px" HorizontalAlign="Center" />
            <ItemStyle Width="300px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="AbreviacionMonedaD" 
            FilterControlAltText="Filter IdMoneda column" HeaderText="Moneda" 
            UniqueName="IdMoneda" DataType="System.Int32" SortExpression="AbreviacionMonedaD" 
            AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="SubTotal" DataType="System.Decimal" 
            FilterControlAltText="Filter SubTotal column" HeaderText="SubTotal" 
            SortExpression="SubTotal" UniqueName="SubTotal" DataFormatString="{0:n}" 
            AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Igv" 
            FilterControlAltText="Filter Igv column" HeaderText="Igv" 
            UniqueName="Igv" DataType="System.Decimal" SortExpression="Igv" 
            DataFormatString="{0:n}" AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Total" 
            FilterControlAltText="Filter column1 column" HeaderText="Total" 
            SortExpression="Total" UniqueName="column1" DataFormatString="{0:n}" 
            AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>
    </Columns>
<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
            </div>
            <asp:ObjectDataSource ID="odsRequerimientos" runat="server" 
                SelectMethod="GetAllFromOrdenCompraPorAprobarByIdResponsable" 
                TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL">
                <SelectParameters>
                    <asp:SessionParameter Name="idResponsable" SessionField="IdUser" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </fieldset>
    </div>
</asp:Content>
