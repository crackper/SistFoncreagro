<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaOrdenesCompraEnviar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaOrdenesCompraEnviar" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function prueba() {
        alert("prueba");
    }

    function CargarBandejaOrdenCompraEnviar(id, numero) {
        var oWnd = radopen("VentanaEnviarOrdenCompra.aspx?id=" + id + "&nro=" + numero, "Comprar");
    }

    function CargarBandejaReporte(id, tipo) {
        var resultado;
        if(tipo == 'PRODUCTO')
            {resultado = 1;}
        else
            {resultado = 0;}
            var oWnd = radopen("VentanaReporteOrdenCompra.aspx?idOc=" + id + "&tipo=" + resultado, "VentanaReporte");
    }

    function CerrarVentana(oWnd, args) {
        var arg = args.get_argument();
        if (arg) {
            if (arg.indicador == 1) {
                $find("<%= RadAjaxManager1.ClientID %>").ajaxRequest("UpdateRadGrid");
            }
        }

    }
</script>
</telerik:RadCodeBlock>
<fieldset>
            <legend style="font-family: Arial; font-size: 12px; width: 159px;">Enviar orden de compra</legend>
            <div style="height: 600px; overflow: scroll; width: 895px;" class="grid">
    <telerik:RadGrid ID="RadGrid1" runat="server"  AllowPaging="True" AllowFilteringByColumn="True"
      AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsRequerimientos" 
                       GridLines="None" Skin="Hay" Width="1000px" CssClass="GrillaStyle" 
                    PageSize="15">
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
<MasterTableView DataSourceID="odsRequerimientos" DataKeyNames="IdOrdenCompra,NumeroOrden,Tipo" 
                            ClientDataKeyNames="IdOrdenCompra" Width="1450px">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
<Columns>
        <telerik:GridTemplateColumn UniqueName="TemplateColumn" AllowFiltering="False">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmOrdenCompraEditar.aspx?IdOrdenCompra=" & Eval("IdOrdenCompra")& "&accion=porAprobar" %>'
          ToolTip="Editar Requerimiento de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>

       <telerik:GridTemplateColumn UniqueName="TemplateColumnEnviar" AllowFiltering="False">
         <ItemTemplate>
         <asp:ImageButton ID="ibEnviar" runat="server" ImageUrl="~/img/Mas.gif" 
                 Visible='<%# GetVisible(Eval("Estado")) %>' />
         <asp:ImageButton ID="ibImprimir" runat="server" ImageUrl="~/img/impresora.gif" 
                 Visible='<%# GetVisible2(Eval("Estado")) %>' />
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
            <ItemStyle Width="60px" HorizontalAlign="Center" />
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
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
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
                SelectMethod="GetAllFromOrdenCompraAprobadasEnviadasByIdComprador" 
                TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL">
                <SelectParameters>
                    <asp:SessionParameter Name="IdComprador" SessionField="IdUser" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                <Windows>
                <telerik:RadWindow ID="Comprar" runat="server" Animation="Resize" AnimationDuration="200" Width="480px" 
                Height="430px" Title="Enviar Orden de compra" Left="150px" ReloadOnShow="True" 
                ShowContentDuringLoad="False" Modal="True" 
                        OnClientClose="CerrarVentana">
                </telerik:RadWindow>
                <telerik:RadWindow ID="VentanaReporte" runat="server" Animation="Resize" 
                        AnimationDuration="200" Width="770px" 
                Height="500px" Title="Enviar Orden de compra" Left="150px" ReloadOnShow="True" 
                ShowContentDuringLoad="False" Modal="True" 
                        OnClientClose="CerrarVentana" VisibleStatusbar="False">
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
