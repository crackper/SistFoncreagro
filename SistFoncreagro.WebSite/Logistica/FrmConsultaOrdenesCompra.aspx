<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmConsultaOrdenesCompra.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmConsultaOrdenesCompra" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">               
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
                <legend style="font-family: Arial; font-size: 12px; width: 137px;">Órdenes de Compra</legend>
               <div style="height: 600px; overflow: scroll; width: 895px;" class="grid">
    <telerik:RadGrid ID="RadGrid1" runat="server"  AllowPaging="True" AllowFilteringByColumn="True"
      AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsOc" GridLines="None" Skin="Hay" 
        AllowSorting="True" Width="1000px" PageSize="20">
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
<MasterTableView datasourceid="odsOc" pagesize="15" DataKeyNames="IdRequerimiento">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
    <Columns>
       <telerik:GridTemplateColumn UniqueName="TemplateColumn1" AllowFiltering="False" 
            FilterControlAltText="filtro1" FilterControlWidth="110px">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmOrdenCompraPorRecepcionar.aspx?IdOrdenCompra=" & Eval("IdOrdenCompra") & "&ac=0" %>'
          ToolTip="Ver Orden de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="30px" />
         <ItemStyle HorizontalAlign="Center" />
       </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="NumeroOrden" 
            FilterControlAltText="filtro4" HeaderText="Número O/C" 
            SortExpression="NumeroOrden" UniqueName="TemplateColumn4" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="100px">
            <HeaderStyle HorizontalAlign="Center" Width="100px" />
            <ItemStyle HorizontalAlign="Center" Width="100px" />
        </telerik:GridBoundColumn>
          <telerik:GridBoundColumn DataField="CodigoAreaD" 
            FilterControlAltText="filtro80" HeaderText="Área" 
            UniqueName="TemplateColumn90" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False">
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

        <telerik:GridTemplateColumn DataField="Estado" HeaderText="Estado" SortExpression="Estado"
                            UniqueName="TemplateColumn7" FilterControlWidth="110px" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            AndCurrentFilterFunction="Contains" FilterControlAltText="filtro6" 
            ShowFilterIcon="False">
        <ItemTemplate>
             <asp:Label ID="Label5" runat="server" Font-Bold="True"
                Text='<%# Eval("Estado") %>'></asp:Label>
        </ItemTemplate>
            <FooterStyle Height="115px" />
          <HeaderStyle HorizontalAlign="Center" Width="115px" />
          <ItemStyle HorizontalAlign="Center" />
        </telerik:GridTemplateColumn>

                <telerik:GridBoundColumn DataField="RazonSocialD" 
            FilterControlAltText="filtro27" HeaderText="Proveedor" 
            SortExpression="RazonSocialD" UniqueName="TemplateColumn27" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="230px">
            <HeaderStyle HorizontalAlign="Center" Width="230px" />
            <ItemStyle HorizontalAlign="Center" Width="230px" Font-Size="8pt" />
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
        </fieldset>     
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
    </div>
    <asp:ObjectDataSource ID="odsOc" runat="server" 
                    SelectMethod="GetAllFromOrdenCompraByIdResponsableAprobar" 
                    TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL">
      <SelectParameters>
          <asp:SessionParameter Name="IdPersonaAprueba" SessionField="IdUser" 
              Type="Int32" />
      </SelectParameters>
  </asp:ObjectDataSource>
</asp:Content>