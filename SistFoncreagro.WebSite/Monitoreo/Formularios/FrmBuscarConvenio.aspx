<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="../MasterPageMonitoreo.master" CodeBehind="FrmBuscarConvenio.aspx.vb" Inherits="SistFoncreagro.WebSite.BuscarConvenio" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="tabla3">
        <tr>
            <td>
                <table class="fondoTabla" style="background-color: #0C3B2A; color: #FFFFFF;">
                    <tr>
                        <td style="width: 618px">
&nbsp;&nbsp;BANDEJA DE CONVENIOS</td>
                        <td align="right">
                       
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/Cancel.gif" 
                                ToolTip="Cerrar" 
                                PostBackUrl="~/Monitoreo/Formularios/Defecto.aspx" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                  <table style="width: 100%">
                        <tr>
                            <td align="left">
                                <telerik:RadGrid ID="RadGrid2" runat="server" AllowPaging="True" 
                                    AutoGenerateColumns="False" CellSpacing="0" DataSourceID="OdsConvenio" 
                                    GridLines="None" ShowFooter="True" Skin="Hay" Width="100%" 
                                    AllowFilteringByColumn="True">
                                    <GroupingSettings CaseSensitive="False" />
                                    <MasterTableView ClientDataKeyNames="IdConvenio" CommandItemDisplay="Top" 
                                        DataKeyNames="IdConvenio" DataSourceID="OdsConvenio" PageSize="7" 
                                        ShowFooter="False">
                                        <CommandItemSettings AddNewRecordText="Agregar Registro" 
                                            ExportToExcelText="Exportar a Excel" ExportToPdfText="Exportar to PDF" 
                                            RefreshText="Actualizar" ShowExportToExcelButton="True" 
                                            ShowExportToPdfButton="True" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridEditCommandColumn ButtonType="ImageButton" EditText="Editar" 
                                                FilterControlAltText="Filter EditCommandColumn column" HeaderText="Editar">
                                            </telerik:GridEditCommandColumn>
                                            <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                                FilterControlAltText="Filter column column" HeaderText="Eliminar" 
                                                ImageUrl="~\img\Delete.gif" Text="Eliminar" UniqueName="column">
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn AllowFiltering="False" DataField="IdConvenio" 
                                                DataType="System.Int32" HeaderText="IdConvenio" SortExpression="IdConvenio" 
                                                UniqueName="IdConvenio" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn Aggregate="Count" AllowFiltering="False" 
                                                DataField="Codigo" HeaderText="Código" SortExpression="Código" 
                                                UniqueName="Codigo">
                                                <HeaderStyle Width="9%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="true" 
                                                CurrentFilterFunction="Contains" DataField="Nombre" FilterControlWidth="100%" 
                                                HeaderText="Nombre" ShowFilterIcon="false" SortExpression="Nombre" 
                                                UniqueName="Nombre">
                                                <HeaderStyle Width="36%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="AliasC" 
                                                HeaderText="Alias" SortExpression="AliasC" UniqueName="AliasC" 
                                                AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                                FilterControlWidth="100%" ShowFilterIcon="False">
                                                <HeaderStyle Width="18%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AllowFiltering="False" DataField="NombreMoneda" 
                                                FilterControlAltText="Filter NombreMoneda column" HeaderText="Moneda" 
                                                ReadOnly="True" SortExpression="NombreMoneda" UniqueName="NombreMoneda" 
                                                AutoPostBackOnFilter="True" CurrentFilterFunction="Contains" 
                                                FilterControlWidth="100%" ShowFilterIcon="False">
                                                <HeaderStyle Width="10%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="true" 
                                                CurrentFilterFunction="Contains" DataField="FaseCont" 
                                                FilterControlAltText="Filter FaseCont column" FilterControlWidth="100%" 
                                                HeaderText="Fase" ShowFilterIcon="false" SortExpression="FaseCont" 
                                                UniqueName="FaseCont">
                                                <HeaderStyle Width="9%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="true" 
                                                CurrentFilterFunction="Contains" DataField="Estado" 
                                                FilterControlAltText="Filter Estado column" FilterControlWidth="100%" 
                                                HeaderText="Estado" ShowFilterIcon="false" SortExpression="Estado" 
                                                UniqueName="Estado">
                                                <HeaderStyle Width="9%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                                HeaderText="Firma" UniqueName="TemplateColumn" AutoPostBackOnFilter="True" 
                                                CurrentFilterFunction="Contains" DataField="FechaFirma" 
                                                FilterControlWidth="100%" ShowFilterIcon="False">
                                                <ItemTemplate>
                                                    <asp:Label ID="Label5" runat="server" 
                                                        Text='<%# validarfecha(databinder.eval(container.dataitem, "FechaFirma")) %>'></asp:Label>
                                                </ItemTemplate>
                                                <HeaderStyle Width="9%" />
                                            </telerik:GridTemplateColumn>
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
                        </table>
            
            </td>
        </tr>
    </table>
     <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
                                    </telerik:RadWindowManager>
                                    <asp:ObjectDataSource ID="OdsConvenio" runat="server" 
                                        SelectMethod="GetAllFromConvenio" 
                                        TypeName="SistFoncreagro.BussinesLogic.ConvenioBL" 
                                    OldValuesParameterFormatString="original_{0}">
                                    </asp:ObjectDataSource>
   </asp:Content>
