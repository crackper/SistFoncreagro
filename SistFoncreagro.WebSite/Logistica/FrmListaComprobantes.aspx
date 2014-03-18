<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaComprobantes.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaComprobantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function editarComprobante(fina, idoc, idare, idproveedo, nomProveedo, idTipoDo, idMoned, seri, numer, mont, fech, ob, nrovale, fechar) {
        var num;
        if (fina == 'True') {
            num = 0;
        } else {
        num = 1;
    }
    var oWnd = radopen("VentanaComprobanteEdit.aspx?n=" + num + "&idc=" + idoc + "&idArea=" + idare + "&idProveedor=" + idproveedo + "&nomProv=" + nomProveedo + "&idTipoDoc=" + idTipoDo + "&idMoneda=" + idMoned + "&serie=" + seri + "&numero=" + numer + "&monto=" + mont + "&fecha=" + fech + "&obs=" + ob + "&nrovales=" + nrovale + "&fechaRecep=" + fechar, "EditarComprobante");
    }

    function NuevoComprobante() {
        var oWnd = radopen("VentanaComprobante.aspx", "NuevoComprobante");
        return false;
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
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
                <legend style="font-family: Arial; font-size: 12px; width: 100px;">Comprobantes</legend>
               <div style="height: 570px; overflow: scroll; width: 900px;" class="grid">
    <telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="True" AllowFilteringByColumn="True"
                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsComprobantes" GridLines="None" Skin="Hay" AllowSorting="True">
                        <GroupingSettings CaseSensitive="False" GroupSplitDisplayFormat="Mostrando {0} de {1} items." />
                        <ClientSettings AllowColumnHide="True" AllowColumnsReorder="True">
                            <DataBinding EnableCaching="True">
                            </DataBinding>
                            <Selecting AllowRowSelect="True" />
                            <ClientMessages DragToGroupOrReorder="Arrastre el Item con el que desea Agrupar los datos" DropHereToReorder="Coloque aqui para reordenar" PagerTooltipFormatString="Pagina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;" />
                        </ClientSettings>
            <MasterTableView datasourceid="odsComprobantes" pagesize="15" CommandItemDisplay="Top" NoMasterRecordsText="No existen registros." 
            DataKeyNames="Finalizado, IdOcxfactura, IdArea, IdProveedor, NombreProveedor, IdTipoDocumento, IdMoneda, Serie, Numero, Monto, Fecha, Observaciones, NroVales, FechaRecepcion" >
<CommandItemSettings ExportToPdfText="Exportar a PDF" AddNewRecordText="Nuevo Comprobante"  RefreshText="Refrescar" ></CommandItemSettings>
<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
<Columns>
       <telerik:GridTemplateColumn UniqueName="TemplateColumn1" AllowFiltering="False" 
            FilterControlAltText="filtro1" FilterControlWidth="110px">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          ToolTip="Editar Comprobante" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" Width="20px" />
       </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="NombreArea" 
            FilterControlAltText="filtroArea" HeaderText="Área"
            SortExpression="Area" UniqueName="TemplateColumnArea" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="50px">
            <HeaderStyle HorizontalAlign="Center" Width="50px" />
            <ItemStyle HorizontalAlign="Center" Width="50px" />
        </telerik:GridBoundColumn>
       <telerik:GridBoundColumn DataField="NombreTipoDoc" 
            FilterControlAltText="filtroTipoDoc" HeaderText="Comprobante" 
            SortExpression="Comprobante" UniqueName="TemplateColumnComprobante" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100px">
            <HeaderStyle HorizontalAlign="Center" Width="100px" />
            <ItemStyle HorizontalAlign="Center" Width="100px" />
        </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn DataField="Estado" HeaderText="Estado" SortExpression="Estado"
                            UniqueName="EstadoTemplate" FilterControlWidth="80px" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False" AndCurrentFilterFunction="Contains">
        <ItemTemplate>
             <asp:Label ID="Label5" runat="server" Font-Bold="True" Text='<%# ObtenerEstado(Eval("Finalizado")) %>'></asp:Label>
        </ItemTemplate>
          <HeaderStyle HorizontalAlign="Center" Width="80px" />
          <ItemStyle HorizontalAlign="Center" Width="80px" />
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="NombreProveedor" 
            FilterControlAltText="filtroNombreProveedor" HeaderText="Proveedor" 
            SortExpression="NombreProveedor" UniqueName="TemplateColumnProveedor" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="300px">
            <HeaderStyle HorizontalAlign="Center" Width="300px" />
            <ItemStyle HorizontalAlign="Center" Width="300px" />
        </telerik:GridBoundColumn>
       <telerik:GridBoundColumn DataField="Serie" 
            FilterControlAltText="filtro40" HeaderText="Serie" 
            SortExpression="Serie" UniqueName="TemplateColumnSerie" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="35px">
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
            <ItemStyle HorizontalAlign="Center" Width="30px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Numero" 
            FilterControlAltText="filtroNumero" HeaderText="Número" 
            SortExpression="Numero" UniqueName="TemplateColumnNumero" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="35px">
            <HeaderStyle HorizontalAlign="Center" Width="30px" />
            <ItemStyle HorizontalAlign="Center" Width="30px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NroOrden" 
            FilterControlAltText="filtroMonto" HeaderText="Moneda" 
            SortExpression="NroOrden" UniqueName="TemplateColumnNroOrden" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="50px">
            <HeaderStyle HorizontalAlign="Center" Width="50px" />
            <ItemStyle HorizontalAlign="Center" Width="50px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Monto" 
            FilterControlAltText="filtroMonto" HeaderText="Monto" 
            SortExpression="Monto" UniqueName="TemplateColumnMonto" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="80px">
            <HeaderStyle HorizontalAlign="Center" Width="80px" />
            <ItemStyle HorizontalAlign="Center" Width="80px" />
        </telerik:GridBoundColumn>
</Columns>
<EditFormSettings EditFormType="Template">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
    <PagerStyle PagerTextFormat="Change página: {4} &amp;nbsp;Página &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;, items &lt;strong&gt;{2}&lt;/strong&gt; to &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;." 
        PageSizeLabelText="Tamaño de Página" />
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                    </telerik:RadGrid>
                </div>
        </fieldset>     
    </div>
<asp:ObjectDataSource ID="odsComprobantes" runat="server" 
                    SelectMethod="GetAllFromOcxFacturaComprobante" 
                    TypeName="SistFoncreagro.BussinesLogic.OcxFacturaBL" 
        OldValuesParameterFormatString="original_{0}">
  </asp:ObjectDataSource>
    <telerik:RadWindowManager ID="RadWindowManager2" runat="server">
       <Windows>
              <telerik:RadWindow ID="NuevoComprobante" runat="server" Title="NUEVO COMPROBANTE" Height="460px"
                        Width="780px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" />
              <telerik:RadWindow ID="EditarComprobante" runat="server" 
                  Title="EDITAR COMPROBANTE" Height="460px"
                        Width="780px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" 
                   OnClientClose="CerrarVentana" VisibleStatusbar="False" />                         
              </Windows>
    </telerik:RadWindowManager>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    </asp:Content>


