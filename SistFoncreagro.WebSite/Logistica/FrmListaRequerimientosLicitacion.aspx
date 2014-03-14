<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaRequerimientosLicitacion.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaRequerimientosLicitacion" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function CargarBandejaReporte(id) {
        var oWnd = radopen("VentanaReporteSolicitarCotizacion.aspx?idReq=" + id, "VentanaReporte");
    }
</script>
</telerik:RadCodeBlock>
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
           <legend style="font-family: Arial; font-size: 12px; width: 275px;">Requerimientos de Compra (Licitaciones) </legend>
               <div style="height: 600px; overflow: scroll; width: 895px;" class="grid">
                    <telerik:RadGrid ID="RadGrid1" runat="server"  AllowPaging="True" AllowFilteringByColumn="True"
      AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsRequerimientos" 
                       GridLines="None" Skin="Hay" Width="1000px" CssClass="GrillaStyle" 
                        PageSize="30">
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
<MasterTableView datasourceid="odsRequerimientos" DataKeyNames="IdRequerimiento">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
    <Columns>
              <telerik:GridTemplateColumn UniqueName="TemplateColum1" AllowFiltering="False" 
            FilterControlAltText="Filter TemplateColum1 column">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmRequerimientoEditarGenerarOc.aspx?IdReq=" & Eval("IdRequerimiento") & "&accion=0" %>'
          ToolTip="Editar Requerimiento de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>
       <telerik:GridTemplateColumn UniqueName="TemplateColumnEnviar" AllowFiltering="False">
         <ItemTemplate>
         <asp:ImageButton ID="ibImprimir" runat="server" ImageUrl="~/img/impresora.gif"/>
        </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="Numero" 
            FilterControlAltText="filtro4" HeaderText="Número Req." 
            SortExpression="Numero" UniqueName="TemplateColumn4" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100px">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" Width="100px" />
        </telerik:GridBoundColumn>
          <telerik:GridBoundColumn DataField="CodigoArea" 
            FilterControlAltText="filtro80" HeaderText="Área" 
            UniqueName="TemplateColumn90" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            FilterControlWidth="40px" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" Width="40px" />
            <ItemStyle HorizontalAlign="Center" Width="40px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Tipo" 
            FilterControlAltText="filtro5" HeaderText="Tipo" 
            SortExpression="Tipo" UniqueName="TemplateColumn5" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

       <telerik:GridBoundColumn DataField="FechaEnvioAprobar" 
            FilterControlAltText="Filter column column" 
            HeaderText="Fecha Envío" 
            UniqueName="column" AllowFiltering="False" 
            DataFormatString="{0:dd/MM/yyyy}" ShowFilterIcon="False">
           <HeaderStyle HorizontalAlign="Center" />
           <ItemStyle HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridTemplateColumn DataField="Estado" HeaderText="Estado" SortExpression="Estado"
                            UniqueName="TemplateColumn7" FilterControlWidth="110px" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            AndCurrentFilterFunction="Contains" FilterControlAltText="filtro6" 
            ShowFilterIcon="False">
        <ItemTemplate>
             <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor='<%# ObtenerColor(Eval("Estado")) %>'
                Text='<%# Eval("Estado") %>'></asp:Label>
        </ItemTemplate>
            <FooterStyle Height="115px" />
          <HeaderStyle HorizontalAlign="Center" Width="115px" />
          <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>

        <telerik:GridBoundColumn DataField="NombreRequiere" 
            FilterControlAltText="filtro27" 
            HeaderText="Requerido Por" SortExpression="NombreRequiere" 
            UniqueName="TemplateColumn27" ShowFilterIcon="False" AutoPostBackOnFilter="True" 
                  AndCurrentFilterFunction="Contains" CurrentFilterFunction="Contains" 
                  FilterControlWidth="230px">
            <HeaderStyle HorizontalAlign="Center" Width="230px" />
            <ItemStyle HorizontalAlign="Center" Width="230px" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="AbreviacionMoneda" 
            FilterControlAltText="filtro8" HeaderText="Moneda" 
            UniqueName="TemplateColumn9" AllowFiltering="False">
            <HeaderStyle HorizontalAlign="Center" Width="40px" />
            <ItemStyle Width="40px" HorizontalAlign="Center" />
        </telerik:GridBoundColumn>

        <telerik:GridBoundColumn DataField="Monto" 
            FilterControlAltText="filtro9" HeaderText="Monto" 
            UniqueName="TemplateColumn10" AllowFiltering="False" 
            DataFormatString="{0:n}" DataType="System.Decimal" SortExpression="Monto">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Right" />
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
                    SelectMethod="GetAllFromREQUERIMIENTOSAprobadosLicitacionByIdAsistente" 
                    TypeName="SistFoncreagro.BussinesLogic.RequerimientoBL" 
                OldValuesParameterFormatString="original_{0}">
                    <SelectParameters>
                        <asp:SessionParameter Name="IdAsistente" SessionField="IdUser" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource> 
              <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                <Windows>
                <telerik:RadWindow ID="VentanaReporte" runat="server" Animation="Resize" 
                        AnimationDuration="200" Width="770px" 
                Height="500px" Title="Solicitar Cotización" Left="150px" ReloadOnShow="True" 
                ShowContentDuringLoad="False" Modal="True"  VisibleStatusbar="False">
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
    </div>
</asp:Content>
