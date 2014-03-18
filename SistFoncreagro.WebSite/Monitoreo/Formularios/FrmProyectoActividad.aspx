<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Monitoreo/MasterPageMonitoreo.master" CodeBehind="FrmProyectoActividad.aspx.vb" Inherits="SistFoncreagro.WebSite.FrmProyectoActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
                    <script type="text/javascript">
                        function NuevoActividad(IdProyecto) {
                            var oWnd = radopen("FrmActividad.aspx?IdProyecto=" + IdProyecto, "AsignarAct");
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
                Lista de Actividades por proyecto:</td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" DataSourceID="OdsProyAct" GridLines="None" 
                    AllowPaging="True" PageSize="5">
                    <GroupingSettings CollapseTooltip="colapsar grupo" 
                        ExpandTooltip="Expandir grupo" 
                        GroupContinuedFormatString="... grupo continua de la página anterior. " 
                        GroupContinuesFormatString=" grup continuará en la siguiente página." 
                        GroupSplitDisplayFormat="mostrando {0} de {1} items." />
<MasterTableView datasourceid="OdsProyAct" ClientDataKeyNames="IdProyAct" DataKeyNames="IdProyAct" 
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
            FilterControlAltText="Filter column1 column" HeaderText="Edit." 
            ImageUrl="~/img/edit.gif" UniqueName="column1">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            FilterControlAltText="Filter column column" HeaderText="Elim." 
            ImageUrl="~/img/delete.gif" UniqueName="column">
            <HeaderStyle Width="5%" />
        </telerik:GridButtonColumn>
        <telerik:GridBoundColumn DataField="IdProyAct" DataType="System.Int32" 
            FilterControlAltText="Filter IdProyAct column" HeaderText="IdProyAct" 
            SortExpression="IdProyAct" UniqueName="IdProyAct" Visible="False">
            <HeaderStyle Width="0%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Componente.Nombre" 
            FilterControlAltText="Filter column3 column" HeaderText="Componente" 
            UniqueName="Componente" Visible="False">
            <HeaderStyle Width="39%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Convenio.Codigo" 
            FilterControlAltText="Filter Codigo column" UniqueName="Codigo" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="_Actividad.Nombre" 
            FilterControlAltText="Filter column4 column" HeaderText="Actividad" 
            UniqueName="Actividad">
            <HeaderStyle Width="79%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn Aggregate="Sum" DataField="Porcentaje" 
            DataFormatString="{0:0,0.00}" FilterControlAltText="Filter Porcentaje column" 
            HeaderText="Porcentaje" UniqueName="Porcentaje">
            <HeaderStyle Width="12%" />
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IdProyComp" 
            FilterControlAltText="Filter column2 column" HeaderText="IdProyComp" 
            UniqueName="column2" Visible="False">
        </telerik:GridBoundColumn>
    </Columns>

    <GroupByExpressions>
        <telerik:GridGroupByExpression>
            <SelectFields>
                <telerik:GridGroupByField FieldName="_Convenio.Codigo" 
                    FormatString="" FieldAlias="Convenio"  />
                <telerik:GridGroupByField FieldAlias="Componente" 
                    FieldName="_Componente.nombre" FormatString="" HeaderText="" />
            </SelectFields>
            <GroupByFields>
                <telerik:GridGroupByField FieldAlias="_Convenio.Codigo" FieldName="_Convenio.Codigo" 
                    FormatString="" HeaderText="" />
                <telerik:GridGroupByField FieldAlias="_Componente.nombre" 
                    FieldName="_Componente.nombre" FormatString="" HeaderText="" />
            </GroupByFields>
        </telerik:GridGroupByExpression>
    </GroupByExpressions>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

                    <PagerStyle FirstPageToolTip="Primera Página" LastPageToolTip="Última Página" 
                        NextPageToolTip="Página siguiente" PageSizeLabelText="Tamaño de Pagina:" 
                        PrevPageToolTip="Página anterior" />

<FilterMenu EnableImageSprites="False"></FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"></HeaderContextMenu>
                </telerik:RadGrid>
                <asp:ObjectDataSource ID="OdsProyAct" runat="server" 
                    SelectMethod="GetProyActByIdProyecto" 
                    TypeName="SistFoncreagro.BussinesLogic.ProyActBL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="_idProy" QueryStringField="IdProyecto" 
                            Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" />
                <telerik:RadWindowManager ID="RWMensajes" runat="server">
                    <Windows>
                        <telerik:RadWindow ID="AsignarAct" runat="server" Title="Agregar Actividad" 
                            Width="750px">
                        </telerik:RadWindow>
                    </Windows>
                </telerik:RadWindowManager>
                <telerik:RadAjaxManager ID="AJAX_MANAGER" runat="server">
                </telerik:RadAjaxManager>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td align="right" style="width: 101px">
                                Componente:</td>
                            <td style="width: 756px">
                                <asp:TextBox ID="TxtComponente" runat="server" 
                TextMode="MultiLine" Width="745px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 101px">
                                Actividad:</td>
                            <td style="width: 756px">
                                <asp:TextBox ID="TxtActividad" runat="server" 
                TextMode="MultiLine" Width="738px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 101px" align="right">
                                Porcentaje:</td>
                            <td style="width: 756px">
                                <telerik:RadNumericTextBox ID="TxtPorcentaje" Runat="server" MaxValue="100" 
                                    MinValue="0" Width="90px">
                                </telerik:RadNumericTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="TxtPorcentaje" ErrorMessage="Valor Requerido"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" style="width: 101px">
                                <asp:ImageButton ID="BtnGrabar" runat="server" ImageUrl="~/img/update.gif" 
                                    Width="25px" />
                                <asp:ImageButton ID="BtnCancelar" runat="server" ImageUrl="~/img/Cancel.gif" 
                                    Width="25px" />
                            </td>
                            <td style="width: 756px">
                                &nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:HiddenField ID="HFIdProyComp" runat="server" />
                <asp:HiddenField ID="HFIdActividad" runat="server" />
                <asp:HiddenField ID="HFIdProyAct" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 508px">
                                Seleccione un Componente:</td>
                            <td>
                                Seleccione una Actividad:<asp:Button ID="BtnNueAct" runat="server" Text="..." />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 508px">
                                <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                                    CellSpacing="0" DataSourceID="OdsProyComp" GridLines="None" Width="466px" 
                                    Skin="Office2007">
                                    <MasterTableView ClientDataKeyNames="IdProyComp" DataKeyNames="IdProyComp" 
                                        DataSourceID="OdsProyComp">
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
                                            <telerik:GridBoundColumn DataField="IdProyComp" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdProyComp column" HeaderText="IdProyComp" 
                                                SortExpression="IdProyComp" UniqueName="IdProyComp" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="_Convenio.codigo" 
                                                FilterControlAltText="Filter Codigo column" HeaderText="Convenio" 
                                                UniqueName="Codigo">
                                                <HeaderStyle Width="10%" />
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="_Componente.Nombre" 
                                                FilterControlAltText="Filter Componente column" HeaderText="Componente" 
                                                UniqueName="Componente">
                                                <HeaderStyle Width="85%" />
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
                                <asp:ObjectDataSource ID="OdsProyComp" runat="server" 
                                    SelectMethod="GetProyCompByIdProyecto" 
                                    TypeName="SistFoncreagro.BussinesLogic.ProyCompBL">
                                    <SelectParameters>
                                        <asp:QueryStringParameter Name="_idProy" QueryStringField="IdProyecto" 
                                            Type="Int32" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </td>
                            <td>
                                <telerik:RadGrid ID="RadGrid3" runat="server" AllowFilteringByColumn="True" 
                                    AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" 
                                    DataSourceID="OdsActividad" GridLines="None" Width="441px" Skin="Forest">
                                    <GroupingSettings CaseSensitive="False" />
                                    <MasterTableView ClientDataKeyNames="IdActividad" DataKeyNames="IdActividad" 
                                        DataSourceID="OdsActividad" PageSize="4">
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
                                                Text="Selec" UniqueName="Seleccionar">
                                            </telerik:GridButtonColumn>
                                            <telerik:GridBoundColumn DataField="IdActividad" DataType="System.Int32" 
                                                FilterControlAltText="Filter IdActividad column" HeaderText="IdActividad" 
                                                SortExpression="IdActividad" UniqueName="IdActividad" Visible="False">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn AutoPostBackOnFilter="True" DataField="Nombre" 
                                                FilterControlAltText="Filter Actividad column" HeaderText="Actividad" 
                                                SortExpression="Nombre" UniqueName="Actividad" showfiltericon = "false"
                                                currentfilterfunction = "contains" FilterControlWidth = "60%" >
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
                                    SelectMethod="GetAllFromActividad" 
                                    TypeName="SistFoncreagro.BussinesLogic.ActividadBL"></asp:ObjectDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 508px">
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
        <tr>
            <td style="font-family: Arial; font-size: 9pt">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
