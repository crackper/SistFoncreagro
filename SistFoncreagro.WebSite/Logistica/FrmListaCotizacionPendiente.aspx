<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaCotizacionPendiente.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaCotizacionPendiente" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 931px; margin-left: 0px">
        <fieldset>
          <legend style="font-family: Arial; font-size: 12px; width: 165px;">Cotizaciones pendientes</legend>
    <telerik:RadGrid ID="RadGrid1" runat="server"  AllowPaging="True" AllowFilteringByColumn="True"
      AutoGenerateColumns="False" CellSpacing="0" DataSourceID="odsCotizacionPendiente" 
                       GridLines="None" Skin="Hay" Width="900px" CssClass="GrillaStyle">
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
<MasterTableView datasourceid="odsCotizacionPendiente" pagesize="30" DataKeyNames="IdRequerimiento">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
</RowIndicatorColumn>
<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
</ExpandCollapseColumn>
    <Columns>
       <telerik:GridTemplateColumn UniqueName="TemplateColumn1" AllowFiltering="False" 
            FilterControlAltText="filtro1">
         <ItemTemplate>
          <asp:ImageButton ID="EditButton" runat="server" ImageUrl="~/img/Edit.gif"
          PostBackUrl='<%# "FrmCotizacionEditar.aspx?IdCoti=" & Eval("IdCotizacion")&"&IdReq="&Eval("IdRequerimiento") %>'
          ToolTip="Editar Requerimiento de Compra" CssClass="etiquetas" />
          </ItemTemplate>
         <HeaderStyle Width="15px" />
         <ItemStyle HorizontalAlign="Center" Width="15px" />
       </telerik:GridTemplateColumn>
               <telerik:GridBoundColumn DataField="NroRequerimiento" 
            FilterControlAltText="filtroReq" HeaderText="N° Req." 
            UniqueName="TemplateColumnReq" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False" FilterControlWidth="50px">
            <HeaderStyle HorizontalAlign="Center" Width="50px" />
            <ItemStyle HorizontalAlign="Center" Font-Size="8pt" Width="50px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            DataField="CodigoArea" FilterControlAltText="Filter column column" 
            FilterControlWidth="25px" HeaderText="Área" ShowFilterIcon="False" 
            UniqueName="column">
            <HeaderStyle HorizontalAlign="Center" Width="25px" />
            <ItemStyle HorizontalAlign="Center" Width="25px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Nombre" 
            FilterControlAltText="filtro4" HeaderText="Nombre" 
            SortExpression="Nombre" UniqueName="TemplateColumn4" 
            AndCurrentFilterFunction="Contains" AutoPostBackOnFilter="True" 
            CurrentFilterFunction="Contains" ShowFilterIcon="False" 
            FilterControlWidth="330px">
            <HeaderStyle HorizontalAlign="Center" Width="330px" />
            <ItemStyle Width="330px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Estado" 
            FilterControlAltText="filtroEstado" HeaderText="Estado" 
            UniqueName="TemplateColumnEstado" AndCurrentFilterFunction="Contains" 
            AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
            ShowFilterIcon="False" FilterControlWidth="80px">
            <HeaderStyle HorizontalAlign="Center" Width="80px" />
            <ItemStyle HorizontalAlign="Center" Width="80px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NombreComprador" 
            FilterControlAltText="filtro2" HeaderText="Asistente" 
            UniqueName="TemplateColumn2" AllowFiltering="False" 
            FilterControlWidth="300px">
            <HeaderStyle HorizontalAlign="Center" Width="300px" />
            <ItemStyle HorizontalAlign="Center" Font-Size="8pt" Width="300px" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaRegistro" 
            FilterControlAltText="filtro3" HeaderText="Fecha" 
            UniqueName="TemplateColumn3" AllowFiltering="False" 
            DataFormatString="{0:dd/MM/yyyy}" DataType="System.DateTime" 
            ShowFilterIcon="False" SortExpression="FechaRegistro" 
            FilterControlWidth="50px">
            <HeaderStyle HorizontalAlign="Center" Width="50px" />
            <ItemStyle HorizontalAlign="Center" Width="50px" />
        </telerik:GridBoundColumn>

    </Columns>
<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>
<FilterMenu EnableImageSprites="False"></FilterMenu>
<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
        </fieldset>     
        
    </div>
    <asp:ObjectDataSource ID="odsCotizacionPendiente" runat="server" 
                    SelectMethod="GetAllFromCotizacionesByIdComprador" 
                    TypeName="SistFoncreagro.BussinesLogic.CotizacionBL">
      <SelectParameters>
          <asp:SessionParameter Name="idComprador" SessionField="IdUser" Type="Int32" />
      </SelectParameters>
  </asp:ObjectDataSource>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
</asp:Content>
