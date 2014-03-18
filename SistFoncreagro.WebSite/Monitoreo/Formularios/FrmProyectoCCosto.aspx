<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoCCosto.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoCCosto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                        function NuevoElem(IdProyecto) {
                            var oWnd = radopen("FrmElementoGasto.aspx?IdProyecto=" + IdProyecto, "AsignarElem");
                            //                            var oWnd = radopen("FrmConvenioMarco.aspx", "NuevoMarco");
                            return false;
                        }
                        function CerrarRadWindow(oWnd, args) {
                            var arg = args.get_argument();
                            if (arg) {
                                if (arg.indicador >= 1) {
                                    $find("<%= AJAX_MANAGER.ClientID %>").ajaxRequest("ActualizarGrilla|" + arg.indicador);
                                }
                            }
                        }
                </script>
     </telerik:RadCodeBlock>
    
    
    <table style="width: 100%">
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Label ID="LblProyecto" runat="server" Font-Bold="True" Font-Size="Medium" 
                    Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:HiddenField ID="HFIdProyecto" runat="server" />
                <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
                    DynamicHorizontalOffset="2" Font-Names="Arial" Font-Size="Small" 
                    ForeColor="#284E98" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#507CD1" />
                    <Items>
                        <asp:MenuItem Text="Ir a..." Value="Ir a...">
                            <asp:MenuItem Text="Estructura" Value="Estructura">
                                <asp:MenuItem Text="Convenio" Value="Convenio"></asp:MenuItem>
                                <asp:MenuItem Text="Componentes" Value="Componentes"></asp:MenuItem>
                                <asp:MenuItem Text="Actividades" Value="Actividades"></asp:MenuItem>
                                <asp:MenuItem Text="Centros de Costo" Value="CCostos"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="Datos Generales" Value="Datos"></asp:MenuItem>
                            <asp:MenuItem Text="Ambito/Beneficiarios" Value="Ambito"></asp:MenuItem>
                            <asp:MenuItem Text="Informes" Value="Informes"></asp:MenuItem>
                            <asp:MenuItem Text="Avance Físico" Value="AvanFis"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Mensual" Value="ForFin"></asp:MenuItem>
                            <asp:MenuItem Text="Forecast Anual" Value="ForAnual"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                Lista de Centros de Costo por proyecto:</td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <telerik:RadGrid ID="RgGeneral" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" CellSpacing="0" 
                    DataSourceID="OdsCCosto" GridLines="None" PageSize="5" 
                    AllowFilteringByColumn="True">
                    <GroupingSettings CaseSensitive="False" />
<MasterTableView datasourceid="OdsCCosto" ClientDataKeyNames="IdCCosto" DataKeyNames="IdCCosto" 
                        ShowGroupFooter="True">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            FilterControlAltText="Filter Editar column" HeaderText="Edit." 
            ImageUrl="~/img/edit.gif" UniqueName="Editar">
            <HeaderStyle Width="4%" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            FilterControlAltText="Filter Eliminar column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="Eliminar">
            <HeaderStyle Width="4%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdCCosto" DataType="System.Int32" 
            FilterControlAltText="Filter IdCCosto column" HeaderText="IdCCosto" 
            SortExpression="IdCCosto" UniqueName="IdCCosto" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Codigo" 
            FilterControlAltText="Filter Codigo column" HeaderText="Codigo" 
            SortExpression="Codigo" UniqueName="Codigo" AllowFiltering="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Convenio.Codigo" 
            FilterControlAltText="Filter Convenio column" HeaderText="Convenio" 
            UniqueName="Convenio" Visible="False">
            <HeaderStyle Width="7%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Componente.Nombre" 
            FilterControlAltText="Filter Componente column" HeaderText="Componente" 
            UniqueName="Componente" Visible="False">
            <HeaderStyle Width="15%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Actividad.Nombre" 
            FilterControlAltText="Filter Actividad column" HeaderText="Actividad" 
            UniqueName="Actividad" Visible="False">
            <HeaderStyle Width="20%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_ElementoGasto.NomElemGasto" 
            FilterControlAltText="filtra la columna Elemento de Gasto" HeaderText="Elem. Gasto" 
            UniqueName="NomElemGasto" AutoPostBackOnFilter="True" ShowFilterIcon ="false"
             FilterControlWidth = 60% CurrentFilterFunction = "Contains">
            <HeaderStyle Width="58%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Unidad" 
            FilterControlAltText="Filter Unidad column" HeaderText="Unidad" 
            SortExpression="Unidad" UniqueName="Unidad" AllowFiltering="False">
            <HeaderStyle Width="12%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn Aggregate="Sum" DataField="Porcentaje" 
            DataFormatString="{0:0,0.00}" FilterControlAltText="Filter column column" 
            HeaderText="Porcentaje" UniqueName="Porcentaje" AllowFiltering="False">
            <HeaderStyle Width="10%" />
        </telerik:GridBoundColumn>
    </Columns>

    <GroupByExpressions>
        <telerik:GridGroupByExpression>
            <SelectFields>
                <telerik:GridGroupByField FieldAlias="Convenio" 
                    FieldName="_Convenio.Codigo" FormatString="" HeaderText="" />
                <telerik:GridGroupByField FieldAlias="Componente" 
                    FieldName="_Componente.Nombre" FormatString="" HeaderText="" />
                <telerik:GridGroupByField FieldAlias="Actividad" 
                    FieldName="_Actividad.Nombre" FormatString="" HeaderText="" />
            </SelectFields>
            <GroupByFields>
                <telerik:GridGroupByField FieldAlias="Convenio" 
                    FieldName="_Convenio.Codigo" FormatString="" HeaderText="" />
                <telerik:GridGroupByField FieldAlias="Componente" 
                    FieldName="_Componente.Nombre" FormatString="" HeaderText="" />
                <telerik:GridGroupByField FieldAlias="Actividad" 
                    FieldName="_Actividad.Nombre" FormatString="" HeaderText="" />
            </GroupByFields>
        </telerik:GridGroupByExpression>
    </GroupByExpressions>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsCCosto" runat="server" 
                    SelectMethod="GetCCOSTOByIdProyecto" 
                    TypeName="SistFoncreagro.BussinesLogic.CCostoBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_IdProyecto" QueryStringField="IdProyecto" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="AsignarElem" runat="server" Modal="True" 
                            Title="Elementos de Gasto" Width="700px">
                        </telerik:RadWindow>
                    </Windows>
                </telerik:RadWindowManager>
                <telerik:RadAjaxManager ID="AJAX_MANAGER" runat="server">
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td align="right" style="width: 108px">
                                Actividad:</td>
                            <td style="width: 768px">
                                <asp:TextBox ID="TxtActividad" runat="server" TextMode="MultiLine" 
                                    Width="764px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 108px">
                                Elemento Gasto:</td>
                            <td style="width: 768px">
                                <asp:TextBox ID="TxtElemGasto" runat="server" TextMode="MultiLine" 
                                    Width="764px" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 108px">
                                Unidad:</td>
                            <td style="width: 768px">
                                <asp:TextBox ID="TxtUnidad" runat="server" Width="298px"
                                style="text-transform:uppercase;"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 108px">
                                Porcentaje:</td>
                            <td style="width: 768px">
                                <telerik:RadNumericTextBox ID="TxtPorcen" Runat="server">
                                </telerik:RadNumericTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TxtPorcen" ErrorMessage="Valor Requerido"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 108px">
                                <asp:ImageButton ID="BtnAceptar" runat="server" ImageUrl="~/img/update.gif" 
                                    Width="25px" />
                                <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/cancel.gif" 
                                    Width="25px" />
                            </td>
                            <td style="width: 768px">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:HiddenField ID="HFIdCCosto" runat="server" />
                <asp:HiddenField ID="HFIdProyAct" runat="server" />
                <asp:HiddenField ID="HFIdElemGasto" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 599px">
                                Actividades:</td>
                            <td>
                                Elementos Gasto:<asp:Button ID="BtnNueElem" runat="server" Text="..." />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 599px">
                                <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
                                    AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                                    CellSpacing="0" DataSourceID="OdsActividad" GridLines="None" PageSize="4" 
                                    Width="584px" Skin="Office2007">
                                    <GroupingSettings CaseSensitive="False" />
                                    <MasterTableView DataSourceID="OdsActividad" ClientDataKeyNames="IdProyAct" 
                                        DataKeyNames="IdProyAct">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridButtonColumn CommandName="Select" 
                                                FilterControlAltText="Filter column column" HeaderText="Selec." Text="Selec." 
                                                UniqueName="column">
                                                <HeaderStyle Width="5%" />
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn DataField="IdProyAct" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdProyAct column" HeaderText="IdProyAct" 
                                                SortExpression="IdProyAct" UniqueName="IdProyAct" Visible="False">
                                                <HeaderStyle Width="0%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AllowFiltering="False" DataField="_Convenio.Codigo" 
                                                FilterControlAltText="Filter Convenio column" HeaderText="Convenio" 
                                                UniqueName="Convenio">
                                                <HeaderStyle Width="15%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AllowFiltering="False" DataField="_Componente.nombre" 
                                                FilterControlAltText="Filter Componente column" HeaderText="componente" 
                                                UniqueName="Componente">
                                                <HeaderStyle Width="40%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="_Actividad.Nombre" 
                                                FilterControlAltText="Filter Actividad column" HeaderText="Actividad" 
                                                UniqueName="Actividad" ShowFilterIcon = "false" FilterControlWidth = 60%
                                                 CurrentFilterFunction = "Contains" AutoPostBackOnFilter="True">
                                                <HeaderStyle Width="40%" />
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
                                <asp:ObjectDataSource ID="OdsActividad" runat="server" 
                                    SelectMethod="GetProyActByIdProyecto" 
                                    TypeName="SistFoncreagro.BussinesLogic.ProyActBL">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="_idProy" QueryStringField="IdProyecto" 
                                            Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td>
                                <telerik:RadGrid ID="RadGrid2" runat="server" AllowFilteringByColumn="True" 
                                    AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                                    CellSpacing="0" DataSourceID="OdsElementoGasto" GridLines="None" 
                                    PageSize="4" Skin="Forest">
                                    <GroupingSettings CaseSensitive="False" />
                                    <MasterTableView ClientDataKeyNames="IdElemGasto" DataKeyNames="IdElemGasto" 
                                        DataSourceID="OdsElementoGasto">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>
                                        <Columns>
                                            <telerik:GridButtonColumn CommandName="Select" 
                                                FilterControlAltText="Filter Seleccionar column" HeaderText="Selec." 
                                                Text="Selec." UniqueName="Seleccionar">
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn DataField="IdElemGasto" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdElemGasto column" HeaderText="IdElemGasto" 
                                                SortExpression="IdElemGasto" UniqueName="IdElemGasto" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="NomElemGasto" 
                                                FilterControlAltText="Filter NomElemGasto column" HeaderText="Elemento Gasto" 
                                                SortExpression="NomElemGasto" UniqueName="NomElemGasto" ShowFilterIcon = "false" 
                                                 CurrentFilterFunction = "Contains" FilterControlWidth = "70%" 
                                                AutoPostBackOnFilter="True" >
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
                                <asp:ObjectDataSource ID="OdsElementoGasto" runat="server" 
                                    SelectMethod="GetAllFromElementoGasto" 
                                    TypeName="SistFoncreagro.BussinesLogic.ElementoGastoBL">
                                </asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 599px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
