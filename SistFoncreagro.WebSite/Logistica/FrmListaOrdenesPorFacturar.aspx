<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FrmListaOrdenesPorFacturar.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmListaOrdenesPorFacturar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
<script type="text/javascript">
    function CargarVentana(idOc) {
        var oWnd = radopen("VentanaCentroCostoFactura.aspx?IdOrden=" + idOc, "CentroCosto");
    }

    function CargarBandejaFactura(id, fact, numero, area, to, mon) {
        var oWnd = radopen("VentanaRegistroFactura.aspx?idoc=" + id + "&nro=" + numero + "&are=" + area + "&fac=" + fact + "&Mont=" + to + "&Moned=" + mon, "Factura");
    }
</script>
</telerik:RadCodeBlock>
<fieldset>
            <legend style="font-family: Arial; font-size: 12px; width: 142px; height: 14px;">Registro de Facturas</legend>
            <table>
                <tr>
                    <td>
                        Tipo O/C :&nbsp;&nbsp;&nbsp;  
                        <asp:DropDownList ID="ddlTipoOrdenCompra" runat="server" AutoPostBack="True" 
                            Height="18px" Width="130px">
                            <asp:ListItem>PRODUCTO</asp:ListItem>
                            <asp:ListItem>SERVICIO</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="6">
                          <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
                              AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" 
                              CssClass="GrillaStyle" DataSourceID="odsOrdenCompra" GridLines="None" 
                              PageSize="15" Skin="Hay" Width="900px">
                              <GroupingSettings CaseSensitive="False" 
                                  GroupSplitDisplayFormat="Mostrando {0} de {1} items." />
                              <ClientSettings AllowColumnHide="True" AllowColumnsReorder="True">
                                  <DataBinding EnableCaching="True">
                                  </DataBinding>
                                  <Selecting AllowRowSelect="True" />
                                  <ClientMessages DragToGroupOrReorder="Arrastre el Item con el que desea Agrupar los datos" 
                                      DropHereToReorder="Coloque aqui para reordenar" 
                                      
                                      
                                      PagerTooltipFormatString="Pagina &lt;strong&gt;{0}&lt;/strong&gt; de &lt;strong&gt;{1}&lt;/strong&gt;" />
                              </ClientSettings>
                              <MasterTableView ClientDataKeyNames="IdOrdenCompra" 
                                  
                                  
                                  DataKeyNames="IdOrdenCompra,NumeroOrden,CodigoAreaD,factura,Total,AbreviacionMonedaD" DataSourceID="odsOrdenCompra" 
                                  Width="900px">
                                  <CommandItemSettings ExportToPdfText="Export to PDF" />
                                  <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                  </RowIndicatorColumn>
                                  <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                  </ExpandCollapseColumn>
                                  <Columns>
                                      <telerik:GridTemplateColumn AllowFiltering="False" UniqueName="TemplateColumn">
                                          <ItemTemplate>
                                              <asp:ImageButton ID="EditButton" runat="server" CssClass="etiquetas" 
                                                  ImageUrl="~/img/Edit.gif" 
                                                  PostBackUrl='<%# "FrmOrdenCompraEditar.aspx?IdOrdenCompra=" & Eval("IdOrdenCompra")& "&accion=porAprobar" %>' 
                                                  ToolTip="Editar Requerimiento de Compra" />
                                          </ItemTemplate>
                                          <HeaderStyle Width="30px" />
                                          <ItemStyle HorizontalAlign="Center" />
                                      </telerik:GridTemplateColumn>
                                       <telerik:GridTemplateColumn AllowFiltering="False" UniqueName="TemplateColumn">
                                          <ItemTemplate>
                                              <asp:LinkButton ID="lbComprobante" runat="server">Comprobante</asp:LinkButton>
                                          </ItemTemplate>
                                          <HeaderStyle Width="30px" />
                                          <ItemStyle HorizontalAlign="Center" />
                                      </telerik:GridTemplateColumn>
                                      <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
                                          AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                          DataField="NumeroOrden" FilterControlAltText="Filter NumeroOrden column" 
                                          HeaderText="Nro O/C" ShowFilterIcon="False" SortExpression="NumeroOrden" 
                                          UniqueName="NumeroOrden">
                                          <HeaderStyle HorizontalAlign="Center" />
                                          <ItemStyle HorizontalAlign="Center" Width="60px" Font-Size="8pt" />
                                      </telerik:GridBoundColumn>
                                      <telerik:GridBoundColumn AndCurrentFilterFunction="Contains" 
                                          AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                          DataField="CodigoAreaD" FilterControlAltText="filtro80" 
                                          FilterControlWidth="25px" HeaderText="Área" ShowFilterIcon="False" 
                                          UniqueName="TemplateColumn90">
                                          <HeaderStyle HorizontalAlign="Center" Width="25px" />
                                          <ItemStyle HorizontalAlign="Center" Width="25px" Font-Size="8pt" />
                                      </telerik:GridBoundColumn>
                                      <telerik:GridTemplateColumn AndCurrentFilterFunction="Contains" 
                                          AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" DataField="Estado" 
                                          FilterControlWidth="95px" HeaderText="Estado" ShowFilterIcon="False" 
                                          SortExpression="Estado" UniqueName="EstadoTemplate">
                                          <ItemTemplate>
                                              <asp:Label ID="Label5" runat="server" Font-Bold="True" 
                                              Text='<%# Eval("Estado") %>'></asp:Label>
                                          </ItemTemplate>
                                          <HeaderStyle HorizontalAlign="Center" Width="95px" />
                                          <ItemStyle HorizontalAlign="Center" Font-Size="8pt" Width="95px" />
                                      </telerik:GridTemplateColumn>
                                      <telerik:GridBoundColumn AutoPostBackOnFilter="True" 
                                          CurrentFilterFunction="Contains" DataField="RazonSocialD" 
                                          FilterControlAltText="Filter column3 column" FilterControlWidth="250px" 
                                          HeaderText="Proveedor" ShowFilterIcon="False" UniqueName="column3">
                                          <HeaderStyle HorizontalAlign="Center" Width="250px" />
                                          <ItemStyle HorizontalAlign="Center" Width="250px" Font-Size="7pt" />
                                      </telerik:GridBoundColumn>
                                      <telerik:GridBoundColumn AllowFiltering="False" DataField="AbreviacionMonedaD" 
                                          DataType="System.Int32" FilterControlAltText="Filter IdMoneda column" 
                                          HeaderText="Moneda" SortExpression="AbreviacionMonedaD" 
                                          UniqueName="IdMoneda" FilterControlWidth="30px">
                                          <HeaderStyle HorizontalAlign="Center" Font-Size="7pt" Width="30px" />
                                          <ItemStyle HorizontalAlign="Center" Width="30px" />
                                      </telerik:GridBoundColumn>
                                      <telerik:GridBoundColumn AllowFiltering="False" DataField="SubTotal" 
                                          DataFormatString="{0:n}" DataType="System.Decimal" 
                                          FilterControlAltText="Filter SubTotal column" HeaderText="SubTotal" 
                                          SortExpression="SubTotal" UniqueName="SubTotal">
                                          <HeaderStyle HorizontalAlign="Center" />
                                      </telerik:GridBoundColumn>
                                      <telerik:GridBoundColumn AllowFiltering="False" DataField="Igv" 
                                          DataFormatString="{0:n}" DataType="System.Decimal" 
                                          FilterControlAltText="Filter Igv column" HeaderText="Igv" SortExpression="Igv" 
                                          UniqueName="Igv">
                                          <HeaderStyle HorizontalAlign="Center" />
                                      </telerik:GridBoundColumn>
                                      <telerik:GridBoundColumn AllowFiltering="False" DataField="Total" 
                                          DataFormatString="{0:n}" FilterControlAltText="Filter column1 column" 
                                          HeaderText="Total" SortExpression="Total" UniqueName="column1">
                                          <HeaderStyle HorizontalAlign="Center" />
                                      </telerik:GridBoundColumn>
                                  </Columns>
                                  <EditFormSettings>
                                      <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                      </EditColumn>
                                  </EditFormSettings>
                              </MasterTableView>
                              <FilterMenu EnableImageSprites="False">
                              </FilterMenu>
                              <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                              </HeaderContextMenu>
                          </telerik:RadGrid>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5" colspan="6">
               <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
              <Windows>
                <telerik:RadWindow ID="CentroCosto" runat="server" Title="Agregar C. Costo" Height="400px"
                    Width="710px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" />
                <telerik:RadWindow ID="Factura" runat="server" Title="Comprobante" Height="400px"
                    Width="670px" Left="150px" ReloadOnShow="true" ShowContentDuringLoad="false"
                    Modal="true" />
            </Windows>
                </telerik:RadWindowManager>
                        <asp:ObjectDataSource ID="odsOrdenCompra" runat="server" 
                            SelectMethod="GetAllFromOrdenCompraEnviadasRecepcionadasByTipo" 
                            TypeName="SistFoncreagro.BussinesLogic.OrdenCompraBL">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="ddlTipoOrdenCompra" Name="tipo" 
                                    PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                                      <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                          <AjaxSettings>
                                              <telerik:AjaxSetting AjaxControlID="ddlTipoOrdenCompra">
                                                  <UpdatedControls>
                                                      <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                                                  </UpdatedControls>
                                              </telerik:AjaxSetting>
                                              <telerik:AjaxSetting AjaxControlID="RadGrid1">
                                              </telerik:AjaxSetting>
                                          </AjaxSettings>
                                      </telerik:RadAjaxManager>
                                  </td>
                </tr>
                </table>
        </fieldset>
</asp:Content>



