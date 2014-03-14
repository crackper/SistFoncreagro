<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaOrdenesCompraPorRecepcionarInternas.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaOrdenesCompraPorRecepcionarInternas" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
            <legend style="font-family: Arial; font-size: 12px; width: 223px;">Recepción de Órdenes de compra</legend>
            <div style="height: 820px; overflow: scroll; width: 895px;" class="grid">
     <telerik:RadGrid ID="RadGrid1" runat="server"  AllowPaging="True" AllowFilteringByColumn="True"
      AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsOcEnviadasPorRecepcionar" 
                       GridLines="None" Skin="Hay" Width="1300px" CssClass="GrillaStyle">
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
<MasterTableView datasourceid="odsOcEnviadasPorRecepcionar" pagesize="25" 
                            DataKeyNames="IdRequerimiento">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
   <Columns>
        <telerik:GridTemplateColumn UniqueName="TemplateColumn" AllowFiltering="False">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmOrdenCompraPorRecepcionar.aspx?IdOrdenCompra=" & Eval("IdOrdenCompra") & "&tip=0" %>'
          ToolTip="Editar Requerimiento de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>

       <telerik:GridBoundColumn DataField="IdOrdenCompra" DataType="System.Int32" 
            FilterControlAltText="Filter IdOrdenCompra column" 
            HeaderText="IdOrdenCompra" SortExpression="IdOrdenCompra" 
            UniqueName="IdOrdenCompra" Visible="False">
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="NumeroOrden" 
            FilterControlAltText="Filter NumeroOrden column" 
            HeaderText="Nro O/C" SortExpression="NumeroOrden" 
            UniqueName="NumeroOrden" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle Width="60px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="Filter Tipo column" HeaderText="Tipo" 
            SortExpression="Tipo" UniqueName="Tipo" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn FilterControlAltText="Filterc FechaProbableEntrega column" 
            HeaderText="Fecha Probable" UniqueName="FechaProbableEntrega" 
            DataField="FechaProbableEntrega" DataType="System.DateTime" 
            SortExpression="FechaProbableEntrega" DataFormatString="{0:dd/MM/yyyy}" 
            AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
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
          <ItemStyle HorizontalAlign="Center" Width="115px" />
        </telerik:GridTemplateColumn>

        <telerik:GridBoundColumn DataField="nombreProveedor" 
            FilterControlAltText="Filter column3 column" HeaderText="Proveedor" 
            UniqueName="column3" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="250px">
            <HeaderStyle Width="300px" />
            <ItemStyle Width="300px" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="MonedaOrden" 
            FilterControlAltText="Filter IdMoneda column" HeaderText="Moneda" 
            UniqueName="IdMoneda" DataType="System.Int32" SortExpression="MonedaOrden" 
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

        <telerik:GridBoundColumn DataField="requerimiento.NombreRequiere" 
            FilterControlAltText="Filter IdRequeridoPor column" HeaderText="Requerido Por" 
            UniqueName="IdRequeridoPor" DataType="System.Int32" 
            SortExpression="requerimiento.NombreRequiere" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="250px">
            <HeaderStyle HorizontalAlign="Center" Width="250px" />
            <ItemStyle HorizontalAlign="Center" Width="250px" />
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

            <asp:ObjectDataSource ID="odsOcEnviadasPorRecepcionar" runat="server" 
                SelectMethod="GetAllFromOrdenCompraInternas" 
                TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL" 
                OldValuesParameterFormatString="original_{0}">
            </asp:ObjectDataSource>
            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                <Windows>
                 <telerik:RadWindow ID="RadWindow1" runat="server" style="display:none;">
                 </telerik:RadWindow>
                <telerik:RadWindow runat="server" Animation="Resize" AnimationDuration="200" Width="480px" 
                Height="430px" Title="Enviar Orden de compra" Left="150px" ReloadOnShow="True" 
                ShowContentDuringLoad="False" Modal="True" ID="Comprar" 
                        OnClientClose="CerrarBandeja">
                </telerik:RadWindow>
                </Windows>
            </telerik:RadWindowManager>
            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                <AjaxSettings>
                    <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                        <UpdatedControls>
                            <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                        </UpdatedControls>
                    </telerik:AjaxSetting>
                </AjaxSettings>
            </telerik:RadAjaxManager>
        </fieldset>
</asp:Content>
