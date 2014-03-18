<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaServicios.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaServicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function CargarVentanaCatalogo(id, tipo) {
        var oWnd = radopen("VentanaServicio.aspx?id=" + id + "&tip=" + tipo, "EditarCatalogo");
    }

    function NuevoServicio() {
        var oWnd = radopen("VentanaServicio.aspx", "NuevoServicio");
        return false;
    }

</script>
</telerik:RadCodeBlock>
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
                <legend style="font-family: Arial; font-size: 15px; width: 180px;">Catálogo de 
                    Servicios</legend>
               <div style="height: 570px; overflow: scroll; width: 900px;" class="grid">

    <telerik:RadGrid ID="RadGrid2" runat="server" 
        AllowPaging="True" AllowFilteringByColumn="True"
                        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsProductos" 
                        GridLines="None" Skin="Hay" 
        AllowSorting="True">
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
<MasterTableView datasourceid="odsProductos" pagesize="15" CommandItemDisplay="Top" 
                            NoMasterRecordsText="No existen registros." DataKeyNames="IdCatalogo">
<CommandItemSettings ExportToPdfText="Exportar a PDF" 
        AddNewRecordText="Nuevo Servicio"  RefreshText="Refrescar" ></CommandItemSettings>
<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
<Columns>
       <telerik:GridTemplateColumn UniqueName="TemplateColumn1" AllowFiltering="False" 
            FilterControlAltText="filtro1" FilterControlWidth="110px">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          ToolTip="Editar Producto" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" Width="20px" />
       </telerik:GridTemplateColumn>
       <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Anular" 
          ConfirmDialogType="RadWindow" ConfirmText="¿Está seguro de Eliminar el Registro?" 
          ConfirmTitle="Mensaje de Confirmación" 
          FilterControlAltText="Filter column column" ImageUrl="~\img\delete.gif" 
          Text="Anular" UniqueName="column">
          <ItemStyle CssClass="cursor" HorizontalAlign="Center" Width="20px" />
       </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="filtro1" HeaderText="Código" 
            SortExpression="Codigo" UniqueName="TemplateColumn1" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100px">
            <HeaderStyle HorizontalAlign="Center" Width="90px" />
            <ItemStyle HorizontalAlign="Center" Width="90px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" 
            FilterControlAltText="filtro2" HeaderText="Descripción" 
            SortExpression="Descripcion" UniqueName="TemplateColumn2" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="500px">
            <HeaderStyle HorizontalAlign="Center" Width="500px" />
            <ItemStyle HorizontalAlign="Center" Width="500px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreClasificaion" 
            FilterControlAltText="filtro4" HeaderText="Clasificación" 
            SortExpression="NombreClasificaion" UniqueName="TemplateColumn4" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="350px">
            <HeaderStyle HorizontalAlign="Center" Width="350px" />
            <ItemStyle HorizontalAlign="Center" Width="350px" />
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
      <asp:Label ID="lblTipoCatalogo" runat="server" Text="1" Visible="False" 
        ForeColor="White"></asp:Label>
    <asp:ObjectDataSource ID="odsProductos" runat="server" 
                    SelectMethod="GetAllFromCatalogoByTipo" 
                    TypeName="SistFoncreagro.BussinesLogic.CatalogoBL">
      <SelectParameters>
          <asp:ControlParameter ControlID="lblTipoCatalogo" Name="tipo" 
              PropertyName="Text" Type="Int32" />
      </SelectParameters>
  </asp:ObjectDataSource>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
            <telerik:AjaxSetting AjaxControlID="RadGrid2">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid2" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <br />
    <telerik:RadWindowManager ID="RadWindowManager2" runat="server">
       <Windows>
              <telerik:RadWindow ID="NuevoServicio" runat="server" Title="NUEVO SERVICIO" Height="450px"
                        Width="795px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" />
              <telerik:RadWindow ID="EditarCatalogo" runat="server" Title="EDITAR SERVICIO" Height="450px"
                        Width="795px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                        Modal="true" Animation="Resize" />                         
              </Windows>
    </telerik:RadWindowManager>
</asp:Content>


